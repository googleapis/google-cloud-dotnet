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
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.ContactCenterInsights.V1
{
    /// <summary>Settings for <see cref="ContactCenterInsightsClient"/> instances.</summary>
    public sealed partial class ContactCenterInsightsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ContactCenterInsightsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ContactCenterInsightsSettings"/>.</returns>
        public static ContactCenterInsightsSettings GetDefault() => new ContactCenterInsightsSettings();

        /// <summary>
        /// Constructs a new <see cref="ContactCenterInsightsSettings"/> object with default settings.
        /// </summary>
        public ContactCenterInsightsSettings()
        {
        }

        private ContactCenterInsightsSettings(ContactCenterInsightsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateConversationSettings = existing.CreateConversationSettings;
            UploadConversationSettings = existing.UploadConversationSettings;
            UploadConversationOperationsSettings = existing.UploadConversationOperationsSettings.Clone();
            UpdateConversationSettings = existing.UpdateConversationSettings;
            GetConversationSettings = existing.GetConversationSettings;
            ListConversationsSettings = existing.ListConversationsSettings;
            DeleteConversationSettings = existing.DeleteConversationSettings;
            CreateAnalysisSettings = existing.CreateAnalysisSettings;
            CreateAnalysisOperationsSettings = existing.CreateAnalysisOperationsSettings.Clone();
            GetAnalysisSettings = existing.GetAnalysisSettings;
            ListAnalysesSettings = existing.ListAnalysesSettings;
            DeleteAnalysisSettings = existing.DeleteAnalysisSettings;
            BulkAnalyzeConversationsSettings = existing.BulkAnalyzeConversationsSettings;
            BulkAnalyzeConversationsOperationsSettings = existing.BulkAnalyzeConversationsOperationsSettings.Clone();
            BulkDeleteConversationsSettings = existing.BulkDeleteConversationsSettings;
            BulkDeleteConversationsOperationsSettings = existing.BulkDeleteConversationsOperationsSettings.Clone();
            IngestConversationsSettings = existing.IngestConversationsSettings;
            IngestConversationsOperationsSettings = existing.IngestConversationsOperationsSettings.Clone();
            ExportInsightsDataSettings = existing.ExportInsightsDataSettings;
            ExportInsightsDataOperationsSettings = existing.ExportInsightsDataOperationsSettings.Clone();
            CreateIssueModelSettings = existing.CreateIssueModelSettings;
            CreateIssueModelOperationsSettings = existing.CreateIssueModelOperationsSettings.Clone();
            UpdateIssueModelSettings = existing.UpdateIssueModelSettings;
            GetIssueModelSettings = existing.GetIssueModelSettings;
            ListIssueModelsSettings = existing.ListIssueModelsSettings;
            DeleteIssueModelSettings = existing.DeleteIssueModelSettings;
            DeleteIssueModelOperationsSettings = existing.DeleteIssueModelOperationsSettings.Clone();
            DeployIssueModelSettings = existing.DeployIssueModelSettings;
            DeployIssueModelOperationsSettings = existing.DeployIssueModelOperationsSettings.Clone();
            UndeployIssueModelSettings = existing.UndeployIssueModelSettings;
            UndeployIssueModelOperationsSettings = existing.UndeployIssueModelOperationsSettings.Clone();
            ExportIssueModelSettings = existing.ExportIssueModelSettings;
            ExportIssueModelOperationsSettings = existing.ExportIssueModelOperationsSettings.Clone();
            ImportIssueModelSettings = existing.ImportIssueModelSettings;
            ImportIssueModelOperationsSettings = existing.ImportIssueModelOperationsSettings.Clone();
            GetIssueSettings = existing.GetIssueSettings;
            ListIssuesSettings = existing.ListIssuesSettings;
            UpdateIssueSettings = existing.UpdateIssueSettings;
            DeleteIssueSettings = existing.DeleteIssueSettings;
            CalculateIssueModelStatsSettings = existing.CalculateIssueModelStatsSettings;
            CreatePhraseMatcherSettings = existing.CreatePhraseMatcherSettings;
            GetPhraseMatcherSettings = existing.GetPhraseMatcherSettings;
            ListPhraseMatchersSettings = existing.ListPhraseMatchersSettings;
            DeletePhraseMatcherSettings = existing.DeletePhraseMatcherSettings;
            UpdatePhraseMatcherSettings = existing.UpdatePhraseMatcherSettings;
            CalculateStatsSettings = existing.CalculateStatsSettings;
            GetSettingsSettings = existing.GetSettingsSettings;
            UpdateSettingsSettings = existing.UpdateSettingsSettings;
            CreateAnalysisRuleSettings = existing.CreateAnalysisRuleSettings;
            GetAnalysisRuleSettings = existing.GetAnalysisRuleSettings;
            ListAnalysisRulesSettings = existing.ListAnalysisRulesSettings;
            UpdateAnalysisRuleSettings = existing.UpdateAnalysisRuleSettings;
            DeleteAnalysisRuleSettings = existing.DeleteAnalysisRuleSettings;
            GetEncryptionSpecSettings = existing.GetEncryptionSpecSettings;
            InitializeEncryptionSpecSettings = existing.InitializeEncryptionSpecSettings;
            InitializeEncryptionSpecOperationsSettings = existing.InitializeEncryptionSpecOperationsSettings.Clone();
            CreateViewSettings = existing.CreateViewSettings;
            GetViewSettings = existing.GetViewSettings;
            ListViewsSettings = existing.ListViewsSettings;
            UpdateViewSettings = existing.UpdateViewSettings;
            DeleteViewSettings = existing.DeleteViewSettings;
            QueryMetricsSettings = existing.QueryMetricsSettings;
            QueryMetricsOperationsSettings = existing.QueryMetricsOperationsSettings.Clone();
            CreateQaQuestionSettings = existing.CreateQaQuestionSettings;
            GetQaQuestionSettings = existing.GetQaQuestionSettings;
            UpdateQaQuestionSettings = existing.UpdateQaQuestionSettings;
            DeleteQaQuestionSettings = existing.DeleteQaQuestionSettings;
            ListQaQuestionsSettings = existing.ListQaQuestionsSettings;
            CreateQaScorecardSettings = existing.CreateQaScorecardSettings;
            GetQaScorecardSettings = existing.GetQaScorecardSettings;
            UpdateQaScorecardSettings = existing.UpdateQaScorecardSettings;
            DeleteQaScorecardSettings = existing.DeleteQaScorecardSettings;
            ListQaScorecardsSettings = existing.ListQaScorecardsSettings;
            CreateQaScorecardRevisionSettings = existing.CreateQaScorecardRevisionSettings;
            GetQaScorecardRevisionSettings = existing.GetQaScorecardRevisionSettings;
            TuneQaScorecardRevisionSettings = existing.TuneQaScorecardRevisionSettings;
            TuneQaScorecardRevisionOperationsSettings = existing.TuneQaScorecardRevisionOperationsSettings.Clone();
            DeployQaScorecardRevisionSettings = existing.DeployQaScorecardRevisionSettings;
            UndeployQaScorecardRevisionSettings = existing.UndeployQaScorecardRevisionSettings;
            DeleteQaScorecardRevisionSettings = existing.DeleteQaScorecardRevisionSettings;
            ListQaScorecardRevisionsSettings = existing.ListQaScorecardRevisionsSettings;
            CreateFeedbackLabelSettings = existing.CreateFeedbackLabelSettings;
            ListFeedbackLabelsSettings = existing.ListFeedbackLabelsSettings;
            GetFeedbackLabelSettings = existing.GetFeedbackLabelSettings;
            UpdateFeedbackLabelSettings = existing.UpdateFeedbackLabelSettings;
            DeleteFeedbackLabelSettings = existing.DeleteFeedbackLabelSettings;
            ListAllFeedbackLabelsSettings = existing.ListAllFeedbackLabelsSettings;
            BulkUploadFeedbackLabelsSettings = existing.BulkUploadFeedbackLabelsSettings;
            BulkUploadFeedbackLabelsOperationsSettings = existing.BulkUploadFeedbackLabelsOperationsSettings.Clone();
            BulkDownloadFeedbackLabelsSettings = existing.BulkDownloadFeedbackLabelsSettings;
            BulkDownloadFeedbackLabelsOperationsSettings = existing.BulkDownloadFeedbackLabelsOperationsSettings.Clone();
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ContactCenterInsightsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreateConversation</c> and
        /// <c>ContactCenterInsightsClient.CreateConversationAsync</c>.
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
        public gaxgrpc::CallSettings CreateConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UploadConversation</c> and
        /// <c>ContactCenterInsightsClient.UploadConversationAsync</c>.
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
        public gaxgrpc::CallSettings UploadConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.UploadConversation</c> and
        /// <c>ContactCenterInsightsClient.UploadConversationAsync</c>.
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
        public lro::OperationsSettings UploadConversationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdateConversation</c> and
        /// <c>ContactCenterInsightsClient.UpdateConversationAsync</c>.
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
        public gaxgrpc::CallSettings UpdateConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetConversation</c> and <c>ContactCenterInsightsClient.GetConversationAsync</c>
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
        public gaxgrpc::CallSettings GetConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListConversations</c> and
        /// <c>ContactCenterInsightsClient.ListConversationsAsync</c>.
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
        public gaxgrpc::CallSettings ListConversationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeleteConversation</c> and
        /// <c>ContactCenterInsightsClient.DeleteConversationAsync</c>.
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
        public gaxgrpc::CallSettings DeleteConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreateAnalysis</c> and <c>ContactCenterInsightsClient.CreateAnalysisAsync</c>
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
        public gaxgrpc::CallSettings CreateAnalysisSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.CreateAnalysis</c> and
        /// <c>ContactCenterInsightsClient.CreateAnalysisAsync</c>.
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
        /// <c>ContactCenterInsightsClient.GetAnalysis</c> and <c>ContactCenterInsightsClient.GetAnalysisAsync</c>.
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
        public gaxgrpc::CallSettings GetAnalysisSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListAnalyses</c> and <c>ContactCenterInsightsClient.ListAnalysesAsync</c>.
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
        public gaxgrpc::CallSettings ListAnalysesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeleteAnalysis</c> and <c>ContactCenterInsightsClient.DeleteAnalysisAsync</c>
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
        public gaxgrpc::CallSettings DeleteAnalysisSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.BulkAnalyzeConversations</c> and
        /// <c>ContactCenterInsightsClient.BulkAnalyzeConversationsAsync</c>.
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
        public gaxgrpc::CallSettings BulkAnalyzeConversationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.BulkAnalyzeConversations</c> and
        /// <c>ContactCenterInsightsClient.BulkAnalyzeConversationsAsync</c>.
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
        public lro::OperationsSettings BulkAnalyzeConversationsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.BulkDeleteConversations</c> and
        /// <c>ContactCenterInsightsClient.BulkDeleteConversationsAsync</c>.
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
        public gaxgrpc::CallSettings BulkDeleteConversationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.BulkDeleteConversations</c> and
        /// <c>ContactCenterInsightsClient.BulkDeleteConversationsAsync</c>.
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
        public lro::OperationsSettings BulkDeleteConversationsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.IngestConversations</c> and
        /// <c>ContactCenterInsightsClient.IngestConversationsAsync</c>.
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
        public gaxgrpc::CallSettings IngestConversationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.IngestConversations</c> and
        /// <c>ContactCenterInsightsClient.IngestConversationsAsync</c>.
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
        public lro::OperationsSettings IngestConversationsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ExportInsightsData</c> and
        /// <c>ContactCenterInsightsClient.ExportInsightsDataAsync</c>.
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
        public gaxgrpc::CallSettings ExportInsightsDataSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.ExportInsightsData</c> and
        /// <c>ContactCenterInsightsClient.ExportInsightsDataAsync</c>.
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
        public lro::OperationsSettings ExportInsightsDataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreateIssueModel</c> and <c>ContactCenterInsightsClient.CreateIssueModelAsync</c>
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
        public gaxgrpc::CallSettings CreateIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.CreateIssueModel</c> and
        /// <c>ContactCenterInsightsClient.CreateIssueModelAsync</c>.
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
        public lro::OperationsSettings CreateIssueModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdateIssueModel</c> and <c>ContactCenterInsightsClient.UpdateIssueModelAsync</c>
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
        public gaxgrpc::CallSettings UpdateIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetIssueModel</c> and <c>ContactCenterInsightsClient.GetIssueModelAsync</c>.
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
        public gaxgrpc::CallSettings GetIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListIssueModels</c> and <c>ContactCenterInsightsClient.ListIssueModelsAsync</c>
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
        public gaxgrpc::CallSettings ListIssueModelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeleteIssueModel</c> and <c>ContactCenterInsightsClient.DeleteIssueModelAsync</c>
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
        public gaxgrpc::CallSettings DeleteIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.DeleteIssueModel</c> and
        /// <c>ContactCenterInsightsClient.DeleteIssueModelAsync</c>.
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
        public lro::OperationsSettings DeleteIssueModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeployIssueModel</c> and <c>ContactCenterInsightsClient.DeployIssueModelAsync</c>
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
        public gaxgrpc::CallSettings DeployIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.DeployIssueModel</c> and
        /// <c>ContactCenterInsightsClient.DeployIssueModelAsync</c>.
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
        public lro::OperationsSettings DeployIssueModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UndeployIssueModel</c> and
        /// <c>ContactCenterInsightsClient.UndeployIssueModelAsync</c>.
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
        public gaxgrpc::CallSettings UndeployIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.UndeployIssueModel</c> and
        /// <c>ContactCenterInsightsClient.UndeployIssueModelAsync</c>.
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
        public lro::OperationsSettings UndeployIssueModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ExportIssueModel</c> and <c>ContactCenterInsightsClient.ExportIssueModelAsync</c>
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
        public gaxgrpc::CallSettings ExportIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.ExportIssueModel</c> and
        /// <c>ContactCenterInsightsClient.ExportIssueModelAsync</c>.
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
        public lro::OperationsSettings ExportIssueModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ImportIssueModel</c> and <c>ContactCenterInsightsClient.ImportIssueModelAsync</c>
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
        public gaxgrpc::CallSettings ImportIssueModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.ImportIssueModel</c> and
        /// <c>ContactCenterInsightsClient.ImportIssueModelAsync</c>.
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
        public lro::OperationsSettings ImportIssueModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetIssue</c> and <c>ContactCenterInsightsClient.GetIssueAsync</c>.
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
        public gaxgrpc::CallSettings GetIssueSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListIssues</c> and <c>ContactCenterInsightsClient.ListIssuesAsync</c>.
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
        public gaxgrpc::CallSettings ListIssuesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdateIssue</c> and <c>ContactCenterInsightsClient.UpdateIssueAsync</c>.
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
        public gaxgrpc::CallSettings UpdateIssueSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeleteIssue</c> and <c>ContactCenterInsightsClient.DeleteIssueAsync</c>.
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
        public gaxgrpc::CallSettings DeleteIssueSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CalculateIssueModelStats</c> and
        /// <c>ContactCenterInsightsClient.CalculateIssueModelStatsAsync</c>.
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
        public gaxgrpc::CallSettings CalculateIssueModelStatsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreatePhraseMatcher</c> and
        /// <c>ContactCenterInsightsClient.CreatePhraseMatcherAsync</c>.
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
        public gaxgrpc::CallSettings CreatePhraseMatcherSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetPhraseMatcher</c> and <c>ContactCenterInsightsClient.GetPhraseMatcherAsync</c>
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
        public gaxgrpc::CallSettings GetPhraseMatcherSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListPhraseMatchers</c> and
        /// <c>ContactCenterInsightsClient.ListPhraseMatchersAsync</c>.
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
        public gaxgrpc::CallSettings ListPhraseMatchersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeletePhraseMatcher</c> and
        /// <c>ContactCenterInsightsClient.DeletePhraseMatcherAsync</c>.
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
        public gaxgrpc::CallSettings DeletePhraseMatcherSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdatePhraseMatcher</c> and
        /// <c>ContactCenterInsightsClient.UpdatePhraseMatcherAsync</c>.
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
        public gaxgrpc::CallSettings UpdatePhraseMatcherSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CalculateStats</c> and <c>ContactCenterInsightsClient.CalculateStatsAsync</c>
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
        public gaxgrpc::CallSettings CalculateStatsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetSettings</c> and <c>ContactCenterInsightsClient.GetSettingsAsync</c>.
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
        public gaxgrpc::CallSettings GetSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdateSettings</c> and <c>ContactCenterInsightsClient.UpdateSettingsAsync</c>
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
        public gaxgrpc::CallSettings UpdateSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreateAnalysisRule</c> and
        /// <c>ContactCenterInsightsClient.CreateAnalysisRuleAsync</c>.
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
        public gaxgrpc::CallSettings CreateAnalysisRuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetAnalysisRule</c> and <c>ContactCenterInsightsClient.GetAnalysisRuleAsync</c>
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
        public gaxgrpc::CallSettings GetAnalysisRuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListAnalysisRules</c> and
        /// <c>ContactCenterInsightsClient.ListAnalysisRulesAsync</c>.
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
        public gaxgrpc::CallSettings ListAnalysisRulesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdateAnalysisRule</c> and
        /// <c>ContactCenterInsightsClient.UpdateAnalysisRuleAsync</c>.
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
        public gaxgrpc::CallSettings UpdateAnalysisRuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeleteAnalysisRule</c> and
        /// <c>ContactCenterInsightsClient.DeleteAnalysisRuleAsync</c>.
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
        public gaxgrpc::CallSettings DeleteAnalysisRuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetEncryptionSpec</c> and
        /// <c>ContactCenterInsightsClient.GetEncryptionSpecAsync</c>.
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
        public gaxgrpc::CallSettings GetEncryptionSpecSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.InitializeEncryptionSpec</c> and
        /// <c>ContactCenterInsightsClient.InitializeEncryptionSpecAsync</c>.
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
        public gaxgrpc::CallSettings InitializeEncryptionSpecSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.InitializeEncryptionSpec</c> and
        /// <c>ContactCenterInsightsClient.InitializeEncryptionSpecAsync</c>.
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
        public lro::OperationsSettings InitializeEncryptionSpecOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreateView</c> and <c>ContactCenterInsightsClient.CreateViewAsync</c>.
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
        public gaxgrpc::CallSettings CreateViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetView</c> and <c>ContactCenterInsightsClient.GetViewAsync</c>.
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
        public gaxgrpc::CallSettings GetViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListViews</c> and <c>ContactCenterInsightsClient.ListViewsAsync</c>.
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
        public gaxgrpc::CallSettings ListViewsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdateView</c> and <c>ContactCenterInsightsClient.UpdateViewAsync</c>.
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
        public gaxgrpc::CallSettings UpdateViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeleteView</c> and <c>ContactCenterInsightsClient.DeleteViewAsync</c>.
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
        public gaxgrpc::CallSettings DeleteViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.QueryMetrics</c> and <c>ContactCenterInsightsClient.QueryMetricsAsync</c>.
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
        public gaxgrpc::CallSettings QueryMetricsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.QueryMetrics</c> and
        /// <c>ContactCenterInsightsClient.QueryMetricsAsync</c>.
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
        public lro::OperationsSettings QueryMetricsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreateQaQuestion</c> and <c>ContactCenterInsightsClient.CreateQaQuestionAsync</c>
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
        public gaxgrpc::CallSettings CreateQaQuestionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetQaQuestion</c> and <c>ContactCenterInsightsClient.GetQaQuestionAsync</c>.
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
        public gaxgrpc::CallSettings GetQaQuestionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdateQaQuestion</c> and <c>ContactCenterInsightsClient.UpdateQaQuestionAsync</c>
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
        public gaxgrpc::CallSettings UpdateQaQuestionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeleteQaQuestion</c> and <c>ContactCenterInsightsClient.DeleteQaQuestionAsync</c>
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
        public gaxgrpc::CallSettings DeleteQaQuestionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListQaQuestions</c> and <c>ContactCenterInsightsClient.ListQaQuestionsAsync</c>
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
        public gaxgrpc::CallSettings ListQaQuestionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreateQaScorecard</c> and
        /// <c>ContactCenterInsightsClient.CreateQaScorecardAsync</c>.
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
        public gaxgrpc::CallSettings CreateQaScorecardSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetQaScorecard</c> and <c>ContactCenterInsightsClient.GetQaScorecardAsync</c>
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
        public gaxgrpc::CallSettings GetQaScorecardSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdateQaScorecard</c> and
        /// <c>ContactCenterInsightsClient.UpdateQaScorecardAsync</c>.
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
        public gaxgrpc::CallSettings UpdateQaScorecardSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeleteQaScorecard</c> and
        /// <c>ContactCenterInsightsClient.DeleteQaScorecardAsync</c>.
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
        public gaxgrpc::CallSettings DeleteQaScorecardSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListQaScorecards</c> and <c>ContactCenterInsightsClient.ListQaScorecardsAsync</c>
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
        public gaxgrpc::CallSettings ListQaScorecardsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreateQaScorecardRevision</c> and
        /// <c>ContactCenterInsightsClient.CreateQaScorecardRevisionAsync</c>.
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
        public gaxgrpc::CallSettings CreateQaScorecardRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetQaScorecardRevision</c> and
        /// <c>ContactCenterInsightsClient.GetQaScorecardRevisionAsync</c>.
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
        public gaxgrpc::CallSettings GetQaScorecardRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.TuneQaScorecardRevision</c> and
        /// <c>ContactCenterInsightsClient.TuneQaScorecardRevisionAsync</c>.
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
        public gaxgrpc::CallSettings TuneQaScorecardRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.TuneQaScorecardRevision</c> and
        /// <c>ContactCenterInsightsClient.TuneQaScorecardRevisionAsync</c>.
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
        public lro::OperationsSettings TuneQaScorecardRevisionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeployQaScorecardRevision</c> and
        /// <c>ContactCenterInsightsClient.DeployQaScorecardRevisionAsync</c>.
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
        public gaxgrpc::CallSettings DeployQaScorecardRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UndeployQaScorecardRevision</c> and
        /// <c>ContactCenterInsightsClient.UndeployQaScorecardRevisionAsync</c>.
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
        public gaxgrpc::CallSettings UndeployQaScorecardRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeleteQaScorecardRevision</c> and
        /// <c>ContactCenterInsightsClient.DeleteQaScorecardRevisionAsync</c>.
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
        public gaxgrpc::CallSettings DeleteQaScorecardRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListQaScorecardRevisions</c> and
        /// <c>ContactCenterInsightsClient.ListQaScorecardRevisionsAsync</c>.
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
        public gaxgrpc::CallSettings ListQaScorecardRevisionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.CreateFeedbackLabel</c> and
        /// <c>ContactCenterInsightsClient.CreateFeedbackLabelAsync</c>.
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
        public gaxgrpc::CallSettings CreateFeedbackLabelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListFeedbackLabels</c> and
        /// <c>ContactCenterInsightsClient.ListFeedbackLabelsAsync</c>.
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
        public gaxgrpc::CallSettings ListFeedbackLabelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.GetFeedbackLabel</c> and <c>ContactCenterInsightsClient.GetFeedbackLabelAsync</c>
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
        public gaxgrpc::CallSettings GetFeedbackLabelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.UpdateFeedbackLabel</c> and
        /// <c>ContactCenterInsightsClient.UpdateFeedbackLabelAsync</c>.
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
        public gaxgrpc::CallSettings UpdateFeedbackLabelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.DeleteFeedbackLabel</c> and
        /// <c>ContactCenterInsightsClient.DeleteFeedbackLabelAsync</c>.
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
        public gaxgrpc::CallSettings DeleteFeedbackLabelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.ListAllFeedbackLabels</c> and
        /// <c>ContactCenterInsightsClient.ListAllFeedbackLabelsAsync</c>.
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
        public gaxgrpc::CallSettings ListAllFeedbackLabelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.BulkUploadFeedbackLabels</c> and
        /// <c>ContactCenterInsightsClient.BulkUploadFeedbackLabelsAsync</c>.
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
        public gaxgrpc::CallSettings BulkUploadFeedbackLabelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.BulkUploadFeedbackLabels</c> and
        /// <c>ContactCenterInsightsClient.BulkUploadFeedbackLabelsAsync</c>.
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
        public lro::OperationsSettings BulkUploadFeedbackLabelsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactCenterInsightsClient.BulkDownloadFeedbackLabels</c> and
        /// <c>ContactCenterInsightsClient.BulkDownloadFeedbackLabelsAsync</c>.
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
        public gaxgrpc::CallSettings BulkDownloadFeedbackLabelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ContactCenterInsightsClient.BulkDownloadFeedbackLabels</c>
        /// and <c>ContactCenterInsightsClient.BulkDownloadFeedbackLabelsAsync</c>.
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
        public lro::OperationsSettings BulkDownloadFeedbackLabelsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ContactCenterInsightsSettings"/> object.</returns>
        public ContactCenterInsightsSettings Clone() => new ContactCenterInsightsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ContactCenterInsightsClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ContactCenterInsightsClientBuilder : gaxgrpc::ClientBuilderBase<ContactCenterInsightsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ContactCenterInsightsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ContactCenterInsightsClientBuilder() : base(ContactCenterInsightsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ContactCenterInsightsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ContactCenterInsightsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ContactCenterInsightsClient Build()
        {
            ContactCenterInsightsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ContactCenterInsightsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ContactCenterInsightsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ContactCenterInsightsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ContactCenterInsightsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ContactCenterInsightsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ContactCenterInsightsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ContactCenterInsightsClient.ChannelPool;
    }

    /// <summary>ContactCenterInsights client wrapper, for convenient use.</summary>
    /// <remarks>
    /// An API that lets users analyze and explore their business conversation data.
    /// </remarks>
    public abstract partial class ContactCenterInsightsClient
    {
        /// <summary>
        /// The default endpoint for the ContactCenterInsights service, which is a host of
        /// "contactcenterinsights.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "contactcenterinsights.googleapis.com:443";

        /// <summary>The default ContactCenterInsights scopes.</summary>
        /// <remarks>
        /// The default ContactCenterInsights scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ContactCenterInsights.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ContactCenterInsightsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ContactCenterInsightsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ContactCenterInsightsClient"/>.</returns>
        public static stt::Task<ContactCenterInsightsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ContactCenterInsightsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ContactCenterInsightsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ContactCenterInsightsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ContactCenterInsightsClient"/>.</returns>
        public static ContactCenterInsightsClient Create() => new ContactCenterInsightsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ContactCenterInsightsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ContactCenterInsightsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ContactCenterInsightsClient"/>.</returns>
        internal static ContactCenterInsightsClient Create(grpccore::CallInvoker callInvoker, ContactCenterInsightsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ContactCenterInsights.ContactCenterInsightsClient grpcClient = new ContactCenterInsights.ContactCenterInsightsClient(callInvoker);
            return new ContactCenterInsightsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ContactCenterInsights client</summary>
        public virtual ContactCenterInsights.ContactCenterInsightsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a conversation.
        /// Note that this method does not support audio transcription or redaction.
        /// Use `conversations.upload` instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CreateConversation(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a conversation.
        /// Note that this method does not support audio transcription or redaction.
        /// Use `conversations.upload` instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a conversation.
        /// Note that this method does not support audio transcription or redaction.
        /// Use `conversations.upload` instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(CreateConversationRequest request, st::CancellationToken cancellationToken) =>
            CreateConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a conversation.
        /// Note that this method does not support audio transcription or redaction.
        /// Use `conversations.upload` instead.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation resource to create.
        /// </param>
        /// <param name="conversationId">
        /// A unique ID for the new conversation. This ID will become the final
        /// component of the conversation's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CreateConversation(string parent, Conversation conversation, string conversationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversation(new CreateConversationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                ConversationId = conversationId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a conversation.
        /// Note that this method does not support audio transcription or redaction.
        /// Use `conversations.upload` instead.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation resource to create.
        /// </param>
        /// <param name="conversationId">
        /// A unique ID for the new conversation. This ID will become the final
        /// component of the conversation's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(string parent, Conversation conversation, string conversationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationAsync(new CreateConversationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                ConversationId = conversationId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a conversation.
        /// Note that this method does not support audio transcription or redaction.
        /// Use `conversations.upload` instead.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation resource to create.
        /// </param>
        /// <param name="conversationId">
        /// A unique ID for the new conversation. This ID will become the final
        /// component of the conversation's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(string parent, Conversation conversation, string conversationId, st::CancellationToken cancellationToken) =>
            CreateConversationAsync(parent, conversation, conversationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a conversation.
        /// Note that this method does not support audio transcription or redaction.
        /// Use `conversations.upload` instead.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation resource to create.
        /// </param>
        /// <param name="conversationId">
        /// A unique ID for the new conversation. This ID will become the final
        /// component of the conversation's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CreateConversation(gagr::LocationName parent, Conversation conversation, string conversationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversation(new CreateConversationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                ConversationId = conversationId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a conversation.
        /// Note that this method does not support audio transcription or redaction.
        /// Use `conversations.upload` instead.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation resource to create.
        /// </param>
        /// <param name="conversationId">
        /// A unique ID for the new conversation. This ID will become the final
        /// component of the conversation's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(gagr::LocationName parent, Conversation conversation, string conversationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationAsync(new CreateConversationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                ConversationId = conversationId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a conversation.
        /// Note that this method does not support audio transcription or redaction.
        /// Use `conversations.upload` instead.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation resource to create.
        /// </param>
        /// <param name="conversationId">
        /// A unique ID for the new conversation. This ID will become the final
        /// component of the conversation's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(gagr::LocationName parent, Conversation conversation, string conversationId, st::CancellationToken cancellationToken) =>
            CreateConversationAsync(parent, conversation, conversationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a long-running conversation upload operation. This method differs
        /// from `CreateConversation` by allowing audio transcription and optional DLP
        /// redaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Conversation, UploadConversationMetadata> UploadConversation(UploadConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a long-running conversation upload operation. This method differs
        /// from `CreateConversation` by allowing audio transcription and optional DLP
        /// redaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Conversation, UploadConversationMetadata>> UploadConversationAsync(UploadConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a long-running conversation upload operation. This method differs
        /// from `CreateConversation` by allowing audio transcription and optional DLP
        /// redaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Conversation, UploadConversationMetadata>> UploadConversationAsync(UploadConversationRequest request, st::CancellationToken cancellationToken) =>
            UploadConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UploadConversation</c>.</summary>
        public virtual lro::OperationsClient UploadConversationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UploadConversation</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Conversation, UploadConversationMetadata> PollOnceUploadConversation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Conversation, UploadConversationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UploadConversationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UploadConversation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Conversation, UploadConversationMetadata>> PollOnceUploadConversationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Conversation, UploadConversationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UploadConversationOperationsClient, callSettings);

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation UpdateConversation(UpdateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> UpdateConversationAsync(UpdateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> UpdateConversationAsync(UpdateConversationRequest request, st::CancellationToken cancellationToken) =>
            UpdateConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. The new values for the conversation.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. All possible fields can be updated by
        /// passing `*`, or a subset of the following updateable fields can be
        /// provided:
        /// 
        /// * `agent_id`
        /// * `language_code`
        /// * `labels`
        /// * `metadata`
        /// * `quality_metadata`
        /// * `call_metadata`
        /// * `start_time`
        /// * `expire_time` or `ttl`
        /// * `data_source.gcs_source.audio_uri` or
        /// `data_source.dialogflow_source.audio_uri`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation UpdateConversation(Conversation conversation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversation(new UpdateConversationRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. The new values for the conversation.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. All possible fields can be updated by
        /// passing `*`, or a subset of the following updateable fields can be
        /// provided:
        /// 
        /// * `agent_id`
        /// * `language_code`
        /// * `labels`
        /// * `metadata`
        /// * `quality_metadata`
        /// * `call_metadata`
        /// * `start_time`
        /// * `expire_time` or `ttl`
        /// * `data_source.gcs_source.audio_uri` or
        /// `data_source.dialogflow_source.audio_uri`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> UpdateConversationAsync(Conversation conversation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversationAsync(new UpdateConversationRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. The new values for the conversation.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. All possible fields can be updated by
        /// passing `*`, or a subset of the following updateable fields can be
        /// provided:
        /// 
        /// * `agent_id`
        /// * `language_code`
        /// * `labels`
        /// * `metadata`
        /// * `quality_metadata`
        /// * `call_metadata`
        /// * `start_time`
        /// * `expire_time` or `ttl`
        /// * `data_source.gcs_source.audio_uri` or
        /// `data_source.dialogflow_source.audio_uri`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> UpdateConversationAsync(Conversation conversation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConversationAsync(conversation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, st::CancellationToken cancellationToken) =>
            GetConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversation(new GetConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationAsync(new GetConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(string name, st::CancellationToken cancellationToken) =>
            GetConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversation(new GetConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationAsync(new GetConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(ConversationName name, st::CancellationToken cancellationToken) =>
            GetConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
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
            return ListConversations(request, callSettings);
        }

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
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
            return ListConversationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
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
            return ListConversations(request, callSettings);
        }

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the conversation.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
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
            return ListConversationsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversation(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(DeleteConversationRequest request, st::CancellationToken cancellationToken) =>
            DeleteConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversation(new DeleteConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationAsync(new DeleteConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversation(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversation(new DeleteConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationAsync(new DeleteConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(ConversationName name, st::CancellationToken cancellationToken) =>
            DeleteConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Analysis, CreateAnalysisOperationMetadata> CreateAnalysis(CreateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(CreateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(CreateAnalysisRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Analysis, CreateAnalysisOperationMetadata> PollOnceCreateAnalysis(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Analysis, CreateAnalysisOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAnalysisOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAnalysis</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> PollOnceCreateAnalysisAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Analysis, CreateAnalysisOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAnalysisOperationsClient, callSettings);

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis.
        /// </param>
        /// <param name="analysis">
        /// Required. The analysis to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Analysis, CreateAnalysisOperationMetadata> CreateAnalysis(string parent, Analysis analysis, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysis(new CreateAnalysisRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis.
        /// </param>
        /// <param name="analysis">
        /// Required. The analysis to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(string parent, Analysis analysis, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysisAsync(new CreateAnalysisRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis.
        /// </param>
        /// <param name="analysis">
        /// Required. The analysis to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(string parent, Analysis analysis, st::CancellationToken cancellationToken) =>
            CreateAnalysisAsync(parent, analysis, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis.
        /// </param>
        /// <param name="analysis">
        /// Required. The analysis to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Analysis, CreateAnalysisOperationMetadata> CreateAnalysis(ConversationName parent, Analysis analysis, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysis(new CreateAnalysisRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis.
        /// </param>
        /// <param name="analysis">
        /// Required. The analysis to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(ConversationName parent, Analysis analysis, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysisAsync(new CreateAnalysisRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis.
        /// </param>
        /// <param name="analysis">
        /// Required. The analysis to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(ConversationName parent, Analysis analysis, st::CancellationToken cancellationToken) =>
            CreateAnalysisAsync(parent, analysis, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Analysis GetAnalysis(GetAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(GetAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(GetAnalysisRequest request, st::CancellationToken cancellationToken) =>
            GetAnalysisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Analysis GetAnalysis(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysis(new GetAnalysisRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysisAsync(new GetAnalysisRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnalysisAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Analysis GetAnalysis(AnalysisName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysis(new GetAnalysisRequest
            {
                AnalysisName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(AnalysisName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysisAsync(new GetAnalysisRequest
            {
                AnalysisName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(AnalysisName name, st::CancellationToken cancellationToken) =>
            GetAnalysisAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists analyses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalysesResponse, Analysis> ListAnalyses(ListAnalysesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists analyses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalysesResponse, Analysis> ListAnalysesAsync(ListAnalysesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists analyses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analyses.
        /// </param>
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
        /// Lists analyses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analyses.
        /// </param>
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
        /// Lists analyses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analyses.
        /// </param>
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
        public virtual gax::PagedEnumerable<ListAnalysesResponse, Analysis> ListAnalyses(ConversationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalysesRequest request = new ListAnalysesRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists analyses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analyses.
        /// </param>
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
        public virtual gax::PagedAsyncEnumerable<ListAnalysesResponse, Analysis> ListAnalysesAsync(ConversationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalysesRequest request = new ListAnalysesRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Deletes an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalysis(DeleteAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisAsync(DeleteAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisAsync(DeleteAnalysisRequest request, st::CancellationToken cancellationToken) =>
            DeleteAnalysisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalysis(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysis(new DeleteAnalysisRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysisAsync(new DeleteAnalysisRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAnalysisAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalysis(AnalysisName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysis(new DeleteAnalysisRequest
            {
                AnalysisName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisAsync(AnalysisName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysisAsync(new DeleteAnalysisRequest
            {
                AnalysisName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisAsync(AnalysisName name, st::CancellationToken cancellationToken) =>
            DeleteAnalysisAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Analyzes multiple conversations in a single request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> BulkAnalyzeConversations(BulkAnalyzeConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes multiple conversations in a single request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata>> BulkAnalyzeConversationsAsync(BulkAnalyzeConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes multiple conversations in a single request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata>> BulkAnalyzeConversationsAsync(BulkAnalyzeConversationsRequest request, st::CancellationToken cancellationToken) =>
            BulkAnalyzeConversationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BulkAnalyzeConversations</c>.</summary>
        public virtual lro::OperationsClient BulkAnalyzeConversationsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BulkAnalyzeConversations</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> PollOnceBulkAnalyzeConversations(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkAnalyzeConversationsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BulkAnalyzeConversations</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata>> PollOnceBulkAnalyzeConversationsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkAnalyzeConversationsOperationsClient, callSettings);

        /// <summary>
        /// Analyzes multiple conversations in a single request.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to create analyses in.
        /// </param>
        /// <param name="filter">
        /// Required. Filter used to select the subset of conversations to analyze.
        /// </param>
        /// <param name="analysisPercentage">
        /// Required. Percentage of selected conversation to analyze, between
        /// [0, 100].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> BulkAnalyzeConversations(string parent, string filter, float analysisPercentage, gaxgrpc::CallSettings callSettings = null) =>
            BulkAnalyzeConversations(new BulkAnalyzeConversationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                AnalysisPercentage = analysisPercentage,
            }, callSettings);

        /// <summary>
        /// Analyzes multiple conversations in a single request.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to create analyses in.
        /// </param>
        /// <param name="filter">
        /// Required. Filter used to select the subset of conversations to analyze.
        /// </param>
        /// <param name="analysisPercentage">
        /// Required. Percentage of selected conversation to analyze, between
        /// [0, 100].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata>> BulkAnalyzeConversationsAsync(string parent, string filter, float analysisPercentage, gaxgrpc::CallSettings callSettings = null) =>
            BulkAnalyzeConversationsAsync(new BulkAnalyzeConversationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                AnalysisPercentage = analysisPercentage,
            }, callSettings);

        /// <summary>
        /// Analyzes multiple conversations in a single request.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to create analyses in.
        /// </param>
        /// <param name="filter">
        /// Required. Filter used to select the subset of conversations to analyze.
        /// </param>
        /// <param name="analysisPercentage">
        /// Required. Percentage of selected conversation to analyze, between
        /// [0, 100].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata>> BulkAnalyzeConversationsAsync(string parent, string filter, float analysisPercentage, st::CancellationToken cancellationToken) =>
            BulkAnalyzeConversationsAsync(parent, filter, analysisPercentage, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Analyzes multiple conversations in a single request.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to create analyses in.
        /// </param>
        /// <param name="filter">
        /// Required. Filter used to select the subset of conversations to analyze.
        /// </param>
        /// <param name="analysisPercentage">
        /// Required. Percentage of selected conversation to analyze, between
        /// [0, 100].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> BulkAnalyzeConversations(gagr::LocationName parent, string filter, float analysisPercentage, gaxgrpc::CallSettings callSettings = null) =>
            BulkAnalyzeConversations(new BulkAnalyzeConversationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                AnalysisPercentage = analysisPercentage,
            }, callSettings);

        /// <summary>
        /// Analyzes multiple conversations in a single request.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to create analyses in.
        /// </param>
        /// <param name="filter">
        /// Required. Filter used to select the subset of conversations to analyze.
        /// </param>
        /// <param name="analysisPercentage">
        /// Required. Percentage of selected conversation to analyze, between
        /// [0, 100].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata>> BulkAnalyzeConversationsAsync(gagr::LocationName parent, string filter, float analysisPercentage, gaxgrpc::CallSettings callSettings = null) =>
            BulkAnalyzeConversationsAsync(new BulkAnalyzeConversationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                AnalysisPercentage = analysisPercentage,
            }, callSettings);

        /// <summary>
        /// Analyzes multiple conversations in a single request.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to create analyses in.
        /// </param>
        /// <param name="filter">
        /// Required. Filter used to select the subset of conversations to analyze.
        /// </param>
        /// <param name="analysisPercentage">
        /// Required. Percentage of selected conversation to analyze, between
        /// [0, 100].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata>> BulkAnalyzeConversationsAsync(gagr::LocationName parent, string filter, float analysisPercentage, st::CancellationToken cancellationToken) =>
            BulkAnalyzeConversationsAsync(parent, filter, analysisPercentage, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes multiple conversations in a single request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> BulkDeleteConversations(BulkDeleteConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes multiple conversations in a single request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata>> BulkDeleteConversationsAsync(BulkDeleteConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes multiple conversations in a single request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata>> BulkDeleteConversationsAsync(BulkDeleteConversationsRequest request, st::CancellationToken cancellationToken) =>
            BulkDeleteConversationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BulkDeleteConversations</c>.</summary>
        public virtual lro::OperationsClient BulkDeleteConversationsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BulkDeleteConversations</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> PollOnceBulkDeleteConversations(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkDeleteConversationsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BulkDeleteConversations</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata>> PollOnceBulkDeleteConversationsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkDeleteConversationsOperationsClient, callSettings);

        /// <summary>
        /// Deletes multiple conversations in a single request.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to delete conversations from.
        /// Format:
        /// projects/{project}/locations/{location}
        /// </param>
        /// <param name="filter">
        /// Filter used to select the subset of conversations to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> BulkDeleteConversations(string parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            BulkDeleteConversations(new BulkDeleteConversationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
            }, callSettings);

        /// <summary>
        /// Deletes multiple conversations in a single request.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to delete conversations from.
        /// Format:
        /// projects/{project}/locations/{location}
        /// </param>
        /// <param name="filter">
        /// Filter used to select the subset of conversations to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata>> BulkDeleteConversationsAsync(string parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            BulkDeleteConversationsAsync(new BulkDeleteConversationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
            }, callSettings);

        /// <summary>
        /// Deletes multiple conversations in a single request.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to delete conversations from.
        /// Format:
        /// projects/{project}/locations/{location}
        /// </param>
        /// <param name="filter">
        /// Filter used to select the subset of conversations to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata>> BulkDeleteConversationsAsync(string parent, string filter, st::CancellationToken cancellationToken) =>
            BulkDeleteConversationsAsync(parent, filter, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes multiple conversations in a single request.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to delete conversations from.
        /// Format:
        /// projects/{project}/locations/{location}
        /// </param>
        /// <param name="filter">
        /// Filter used to select the subset of conversations to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> BulkDeleteConversations(gagr::LocationName parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            BulkDeleteConversations(new BulkDeleteConversationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
            }, callSettings);

        /// <summary>
        /// Deletes multiple conversations in a single request.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to delete conversations from.
        /// Format:
        /// projects/{project}/locations/{location}
        /// </param>
        /// <param name="filter">
        /// Filter used to select the subset of conversations to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata>> BulkDeleteConversationsAsync(gagr::LocationName parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            BulkDeleteConversationsAsync(new BulkDeleteConversationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
            }, callSettings);

        /// <summary>
        /// Deletes multiple conversations in a single request.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to delete conversations from.
        /// Format:
        /// projects/{project}/locations/{location}
        /// </param>
        /// <param name="filter">
        /// Filter used to select the subset of conversations to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata>> BulkDeleteConversationsAsync(gagr::LocationName parent, string filter, st::CancellationToken cancellationToken) =>
            BulkDeleteConversationsAsync(parent, filter, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports conversations and processes them according to the user's
        /// configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IngestConversationsResponse, IngestConversationsMetadata> IngestConversations(IngestConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports conversations and processes them according to the user's
        /// configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IngestConversationsResponse, IngestConversationsMetadata>> IngestConversationsAsync(IngestConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports conversations and processes them according to the user's
        /// configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IngestConversationsResponse, IngestConversationsMetadata>> IngestConversationsAsync(IngestConversationsRequest request, st::CancellationToken cancellationToken) =>
            IngestConversationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>IngestConversations</c>.</summary>
        public virtual lro::OperationsClient IngestConversationsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>IngestConversations</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<IngestConversationsResponse, IngestConversationsMetadata> PollOnceIngestConversations(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IngestConversationsResponse, IngestConversationsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), IngestConversationsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>IngestConversations</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<IngestConversationsResponse, IngestConversationsMetadata>> PollOnceIngestConversationsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IngestConversationsResponse, IngestConversationsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), IngestConversationsOperationsClient, callSettings);

        /// <summary>
        /// Imports conversations and processes them according to the user's
        /// configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new conversations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IngestConversationsResponse, IngestConversationsMetadata> IngestConversations(string parent, gaxgrpc::CallSettings callSettings = null) =>
            IngestConversations(new IngestConversationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Imports conversations and processes them according to the user's
        /// configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new conversations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IngestConversationsResponse, IngestConversationsMetadata>> IngestConversationsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            IngestConversationsAsync(new IngestConversationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Imports conversations and processes them according to the user's
        /// configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new conversations.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IngestConversationsResponse, IngestConversationsMetadata>> IngestConversationsAsync(string parent, st::CancellationToken cancellationToken) =>
            IngestConversationsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports conversations and processes them according to the user's
        /// configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new conversations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IngestConversationsResponse, IngestConversationsMetadata> IngestConversations(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            IngestConversations(new IngestConversationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Imports conversations and processes them according to the user's
        /// configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new conversations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IngestConversationsResponse, IngestConversationsMetadata>> IngestConversationsAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            IngestConversationsAsync(new IngestConversationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Imports conversations and processes them according to the user's
        /// configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new conversations.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IngestConversationsResponse, IngestConversationsMetadata>> IngestConversationsAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            IngestConversationsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> ExportInsightsData(ExportInsightsDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(ExportInsightsDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(ExportInsightsDataRequest request, st::CancellationToken cancellationToken) =>
            ExportInsightsDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportInsightsData</c>.</summary>
        public virtual lro::OperationsClient ExportInsightsDataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportInsightsData</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> PollOnceExportInsightsData(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportInsightsDataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportInsightsData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> PollOnceExportInsightsDataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportInsightsDataOperationsClient, callSettings);

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to export data from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> ExportInsightsData(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportInsightsData(new ExportInsightsDataRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to export data from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportInsightsDataAsync(new ExportInsightsDataRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to export data from.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(string parent, st::CancellationToken cancellationToken) =>
            ExportInsightsDataAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to export data from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> ExportInsightsData(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportInsightsData(new ExportInsightsDataRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to export data from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportInsightsDataAsync(new ExportInsightsDataRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to export data from.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            ExportInsightsDataAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IssueModel, CreateIssueModelMetadata> CreateIssueModel(CreateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(CreateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(CreateIssueModelRequest request, st::CancellationToken cancellationToken) =>
            CreateIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateIssueModel</c>.</summary>
        public virtual lro::OperationsClient CreateIssueModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<IssueModel, CreateIssueModelMetadata> PollOnceCreateIssueModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IssueModel, CreateIssueModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> PollOnceCreateIssueModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IssueModel, CreateIssueModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="issueModel">
        /// Required. The issue model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IssueModel, CreateIssueModelMetadata> CreateIssueModel(string parent, IssueModel issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueModel(new CreateIssueModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IssueModel = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="issueModel">
        /// Required. The issue model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(string parent, IssueModel issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueModelAsync(new CreateIssueModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IssueModel = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="issueModel">
        /// Required. The issue model to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(string parent, IssueModel issueModel, st::CancellationToken cancellationToken) =>
            CreateIssueModelAsync(parent, issueModel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="issueModel">
        /// Required. The issue model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IssueModel, CreateIssueModelMetadata> CreateIssueModel(gagr::LocationName parent, IssueModel issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueModel(new CreateIssueModelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IssueModel = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="issueModel">
        /// Required. The issue model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(gagr::LocationName parent, IssueModel issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueModelAsync(new CreateIssueModelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IssueModel = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="issueModel">
        /// Required. The issue model to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(gagr::LocationName parent, IssueModel issueModel, st::CancellationToken cancellationToken) =>
            CreateIssueModelAsync(parent, issueModel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IssueModel UpdateIssueModel(UpdateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> UpdateIssueModelAsync(UpdateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> UpdateIssueModelAsync(UpdateIssueModelRequest request, st::CancellationToken cancellationToken) =>
            UpdateIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The new values for the issue model.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IssueModel UpdateIssueModel(IssueModel issueModel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIssueModel(new UpdateIssueModelRequest
            {
                IssueModel = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The new values for the issue model.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> UpdateIssueModelAsync(IssueModel issueModel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIssueModelAsync(new UpdateIssueModelRequest
            {
                IssueModel = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The new values for the issue model.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> UpdateIssueModelAsync(IssueModel issueModel, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateIssueModelAsync(issueModel, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IssueModel GetIssueModel(GetIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> GetIssueModelAsync(GetIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> GetIssueModelAsync(GetIssueModelRequest request, st::CancellationToken cancellationToken) =>
            GetIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IssueModel GetIssueModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueModel(new GetIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> GetIssueModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueModelAsync(new GetIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> GetIssueModelAsync(string name, st::CancellationToken cancellationToken) =>
            GetIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IssueModel GetIssueModel(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueModel(new GetIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> GetIssueModelAsync(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueModelAsync(new GetIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueModel> GetIssueModelAsync(IssueModelName name, st::CancellationToken cancellationToken) =>
            GetIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListIssueModelsResponse ListIssueModels(ListIssueModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(ListIssueModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(ListIssueModelsRequest request, st::CancellationToken cancellationToken) =>
            ListIssueModelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListIssueModelsResponse ListIssueModels(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssueModels(new ListIssueModelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssueModelsAsync(new ListIssueModelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(string parent, st::CancellationToken cancellationToken) =>
            ListIssueModelsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListIssueModelsResponse ListIssueModels(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssueModels(new ListIssueModelsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssueModelsAsync(new ListIssueModelsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            ListIssueModelsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIssueModelMetadata> DeleteIssueModel(DeleteIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(DeleteIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(DeleteIssueModelRequest request, st::CancellationToken cancellationToken) =>
            DeleteIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteIssueModel</c>.</summary>
        public virtual lro::OperationsClient DeleteIssueModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIssueModelMetadata> PollOnceDeleteIssueModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteIssueModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> PollOnceDeleteIssueModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteIssueModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIssueModelMetadata> DeleteIssueModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueModel(new DeleteIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueModelAsync(new DeleteIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIssueModelMetadata> DeleteIssueModel(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueModel(new DeleteIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueModelAsync(new DeleteIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue model to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(IssueModelName name, st::CancellationToken cancellationToken) =>
            DeleteIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata> DeployIssueModel(DeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(DeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(DeployIssueModelRequest request, st::CancellationToken cancellationToken) =>
            DeployIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeployIssueModel</c>.</summary>
        public virtual lro::OperationsClient DeployIssueModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeployIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata> PollOnceDeployIssueModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeployIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> PollOnceDeployIssueModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to deploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata> DeployIssueModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeployIssueModel(new DeployIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to deploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeployIssueModelAsync(new DeployIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to deploy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(string name, st::CancellationToken cancellationToken) =>
            DeployIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to deploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata> DeployIssueModel(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeployIssueModel(new DeployIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to deploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeployIssueModelAsync(new DeployIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to deploy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(IssueModelName name, st::CancellationToken cancellationToken) =>
            DeployIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> UndeployIssueModel(UndeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(UndeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(UndeployIssueModelRequest request, st::CancellationToken cancellationToken) =>
            UndeployIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeployIssueModel</c>.</summary>
        public virtual lro::OperationsClient UndeployIssueModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeployIssueModel</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> PollOnceUndeployIssueModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeployIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> PollOnceUndeployIssueModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to undeploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> UndeployIssueModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployIssueModel(new UndeployIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to undeploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployIssueModelAsync(new UndeployIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to undeploy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(string name, st::CancellationToken cancellationToken) =>
            UndeployIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to undeploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> UndeployIssueModel(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployIssueModel(new UndeployIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to undeploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployIssueModelAsync(new UndeployIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to undeploy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(IssueModelName name, st::CancellationToken cancellationToken) =>
            UndeployIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports an issue model to the provided destination.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata> ExportIssueModel(ExportIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports an issue model to the provided destination.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata>> ExportIssueModelAsync(ExportIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports an issue model to the provided destination.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata>> ExportIssueModelAsync(ExportIssueModelRequest request, st::CancellationToken cancellationToken) =>
            ExportIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportIssueModel</c>.</summary>
        public virtual lro::OperationsClient ExportIssueModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata> PollOnceExportIssueModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata>> PollOnceExportIssueModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Exports an issue model to the provided destination.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to export.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata> ExportIssueModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportIssueModel(new ExportIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports an issue model to the provided destination.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to export.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata>> ExportIssueModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportIssueModelAsync(new ExportIssueModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports an issue model to the provided destination.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to export.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata>> ExportIssueModelAsync(string name, st::CancellationToken cancellationToken) =>
            ExportIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports an issue model to the provided destination.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to export.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata> ExportIssueModel(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportIssueModel(new ExportIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports an issue model to the provided destination.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to export.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata>> ExportIssueModelAsync(IssueModelName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportIssueModelAsync(new ExportIssueModelRequest
            {
                IssueModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports an issue model to the provided destination.
        /// </summary>
        /// <param name="name">
        /// Required. The issue model to export.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata>> ExportIssueModelAsync(IssueModelName name, st::CancellationToken cancellationToken) =>
            ExportIssueModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports an issue model from a Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata> ImportIssueModel(ImportIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports an issue model from a Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata>> ImportIssueModelAsync(ImportIssueModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports an issue model from a Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata>> ImportIssueModelAsync(ImportIssueModelRequest request, st::CancellationToken cancellationToken) =>
            ImportIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportIssueModel</c>.</summary>
        public virtual lro::OperationsClient ImportIssueModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata> PollOnceImportIssueModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportIssueModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata>> PollOnceImportIssueModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportIssueModelOperationsClient, callSettings);

        /// <summary>
        /// Imports an issue model from a Cloud Storage bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata> ImportIssueModel(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ImportIssueModel(new ImportIssueModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Imports an issue model from a Cloud Storage bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata>> ImportIssueModelAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ImportIssueModelAsync(new ImportIssueModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Imports an issue model from a Cloud Storage bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata>> ImportIssueModelAsync(string parent, st::CancellationToken cancellationToken) =>
            ImportIssueModelAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports an issue model from a Cloud Storage bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata> ImportIssueModel(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ImportIssueModel(new ImportIssueModelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Imports an issue model from a Cloud Storage bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata>> ImportIssueModelAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ImportIssueModelAsync(new ImportIssueModelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Imports an issue model from a Cloud Storage bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue model.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata>> ImportIssueModelAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            ImportIssueModelAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Issue GetIssue(GetIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(GetIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(GetIssueRequest request, st::CancellationToken cancellationToken) =>
            GetIssueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Issue GetIssue(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssue(new GetIssueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueAsync(new GetIssueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(string name, st::CancellationToken cancellationToken) =>
            GetIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Issue GetIssue(IssueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssue(new GetIssueRequest
            {
                IssueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(IssueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueAsync(new GetIssueRequest
            {
                IssueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(IssueName name, st::CancellationToken cancellationToken) =>
            GetIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListIssuesResponse ListIssues(ListIssuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssuesResponse> ListIssuesAsync(ListIssuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssuesResponse> ListIssuesAsync(ListIssuesRequest request, st::CancellationToken cancellationToken) =>
            ListIssuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListIssuesResponse ListIssues(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssues(new ListIssuesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssuesResponse> ListIssuesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssuesAsync(new ListIssuesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssuesResponse> ListIssuesAsync(string parent, st::CancellationToken cancellationToken) =>
            ListIssuesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListIssuesResponse ListIssues(IssueModelName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssues(new ListIssuesRequest
            {
                ParentAsIssueModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssuesResponse> ListIssuesAsync(IssueModelName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListIssuesAsync(new ListIssuesRequest
            {
                ParentAsIssueModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the issue.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListIssuesResponse> ListIssuesAsync(IssueModelName parent, st::CancellationToken cancellationToken) =>
            ListIssuesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Issue UpdateIssue(UpdateIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> UpdateIssueAsync(UpdateIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> UpdateIssueAsync(UpdateIssueRequest request, st::CancellationToken cancellationToken) =>
            UpdateIssueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="issue">
        /// Required. The new values for the issue.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Issue UpdateIssue(Issue issue, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIssue(new UpdateIssueRequest
            {
                Issue = gax::GaxPreconditions.CheckNotNull(issue, nameof(issue)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="issue">
        /// Required. The new values for the issue.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> UpdateIssueAsync(Issue issue, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIssueAsync(new UpdateIssueRequest
            {
                Issue = gax::GaxPreconditions.CheckNotNull(issue, nameof(issue)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="issue">
        /// Required. The new values for the issue.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> UpdateIssueAsync(Issue issue, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateIssueAsync(issue, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteIssue(DeleteIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIssueAsync(DeleteIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIssueAsync(DeleteIssueRequest request, st::CancellationToken cancellationToken) =>
            DeleteIssueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteIssue(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssue(new DeleteIssueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIssueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueAsync(new DeleteIssueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIssueAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteIssue(IssueName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssue(new DeleteIssueRequest
            {
                IssueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIssueAsync(IssueName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueAsync(new DeleteIssueRequest
            {
                IssueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the issue to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIssueAsync(IssueName name, st::CancellationToken cancellationToken) =>
            DeleteIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateIssueModelStatsResponse CalculateIssueModelStats(CalculateIssueModelStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(CalculateIssueModelStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(CalculateIssueModelStatsRequest request, st::CancellationToken cancellationToken) =>
            CalculateIssueModelStatsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The resource name of the issue model to query against.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateIssueModelStatsResponse CalculateIssueModelStats(string issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CalculateIssueModelStats(new CalculateIssueModelStatsRequest
            {
                IssueModel = gax::GaxPreconditions.CheckNotNullOrEmpty(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The resource name of the issue model to query against.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(string issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CalculateIssueModelStatsAsync(new CalculateIssueModelStatsRequest
            {
                IssueModel = gax::GaxPreconditions.CheckNotNullOrEmpty(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The resource name of the issue model to query against.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(string issueModel, st::CancellationToken cancellationToken) =>
            CalculateIssueModelStatsAsync(issueModel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The resource name of the issue model to query against.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateIssueModelStatsResponse CalculateIssueModelStats(IssueModelName issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CalculateIssueModelStats(new CalculateIssueModelStatsRequest
            {
                IssueModelAsIssueModelName = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The resource name of the issue model to query against.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(IssueModelName issueModel, gaxgrpc::CallSettings callSettings = null) =>
            CalculateIssueModelStatsAsync(new CalculateIssueModelStatsRequest
            {
                IssueModelAsIssueModelName = gax::GaxPreconditions.CheckNotNull(issueModel, nameof(issueModel)),
            }, callSettings);

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="issueModel">
        /// Required. The resource name of the issue model to query against.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(IssueModelName issueModel, st::CancellationToken cancellationToken) =>
            CalculateIssueModelStatsAsync(issueModel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher CreatePhraseMatcher(CreatePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(CreatePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(CreatePhraseMatcherRequest request, st::CancellationToken cancellationToken) =>
            CreatePhraseMatcherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher. Required. The location
        /// to create a phrase matcher for. Format: `projects/&lt;Project
        /// ID&gt;/locations/&lt;Location ID&gt;` or `projects/&lt;Project
        /// Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="phraseMatcher">
        /// Required. The phrase matcher resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher CreatePhraseMatcher(string parent, PhraseMatcher phraseMatcher, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseMatcher(new CreatePhraseMatcherRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PhraseMatcher = gax::GaxPreconditions.CheckNotNull(phraseMatcher, nameof(phraseMatcher)),
            }, callSettings);

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher. Required. The location
        /// to create a phrase matcher for. Format: `projects/&lt;Project
        /// ID&gt;/locations/&lt;Location ID&gt;` or `projects/&lt;Project
        /// Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="phraseMatcher">
        /// Required. The phrase matcher resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(string parent, PhraseMatcher phraseMatcher, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseMatcherAsync(new CreatePhraseMatcherRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PhraseMatcher = gax::GaxPreconditions.CheckNotNull(phraseMatcher, nameof(phraseMatcher)),
            }, callSettings);

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher. Required. The location
        /// to create a phrase matcher for. Format: `projects/&lt;Project
        /// ID&gt;/locations/&lt;Location ID&gt;` or `projects/&lt;Project
        /// Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="phraseMatcher">
        /// Required. The phrase matcher resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(string parent, PhraseMatcher phraseMatcher, st::CancellationToken cancellationToken) =>
            CreatePhraseMatcherAsync(parent, phraseMatcher, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher. Required. The location
        /// to create a phrase matcher for. Format: `projects/&lt;Project
        /// ID&gt;/locations/&lt;Location ID&gt;` or `projects/&lt;Project
        /// Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="phraseMatcher">
        /// Required. The phrase matcher resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher CreatePhraseMatcher(gagr::LocationName parent, PhraseMatcher phraseMatcher, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseMatcher(new CreatePhraseMatcherRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PhraseMatcher = gax::GaxPreconditions.CheckNotNull(phraseMatcher, nameof(phraseMatcher)),
            }, callSettings);

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher. Required. The location
        /// to create a phrase matcher for. Format: `projects/&lt;Project
        /// ID&gt;/locations/&lt;Location ID&gt;` or `projects/&lt;Project
        /// Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="phraseMatcher">
        /// Required. The phrase matcher resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(gagr::LocationName parent, PhraseMatcher phraseMatcher, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseMatcherAsync(new CreatePhraseMatcherRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PhraseMatcher = gax::GaxPreconditions.CheckNotNull(phraseMatcher, nameof(phraseMatcher)),
            }, callSettings);

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher. Required. The location
        /// to create a phrase matcher for. Format: `projects/&lt;Project
        /// ID&gt;/locations/&lt;Location ID&gt;` or `projects/&lt;Project
        /// Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="phraseMatcher">
        /// Required. The phrase matcher resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(gagr::LocationName parent, PhraseMatcher phraseMatcher, st::CancellationToken cancellationToken) =>
            CreatePhraseMatcherAsync(parent, phraseMatcher, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher GetPhraseMatcher(GetPhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> GetPhraseMatcherAsync(GetPhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> GetPhraseMatcherAsync(GetPhraseMatcherRequest request, st::CancellationToken cancellationToken) =>
            GetPhraseMatcherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher GetPhraseMatcher(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseMatcher(new GetPhraseMatcherRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> GetPhraseMatcherAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseMatcherAsync(new GetPhraseMatcherRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> GetPhraseMatcherAsync(string name, st::CancellationToken cancellationToken) =>
            GetPhraseMatcherAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher GetPhraseMatcher(PhraseMatcherName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseMatcher(new GetPhraseMatcherRequest
            {
                PhraseMatcherName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> GetPhraseMatcherAsync(PhraseMatcherName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseMatcherAsync(new GetPhraseMatcherRequest
            {
                PhraseMatcherName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> GetPhraseMatcherAsync(PhraseMatcherName name, st::CancellationToken cancellationToken) =>
            GetPhraseMatcherAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchers(ListPhraseMatchersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchersAsync(ListPhraseMatchersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhraseMatchersRequest request = new ListPhraseMatchersRequest
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
            return ListPhraseMatchers(request, callSettings);
        }

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhraseMatchersRequest request = new ListPhraseMatchersRequest
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
            return ListPhraseMatchersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhraseMatchersRequest request = new ListPhraseMatchersRequest
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
            return ListPhraseMatchers(request, callSettings);
        }

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the phrase matcher.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhraseMatchersRequest request = new ListPhraseMatchersRequest
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
            return ListPhraseMatchersAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePhraseMatcher(DeletePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseMatcherAsync(DeletePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseMatcherAsync(DeletePhraseMatcherRequest request, st::CancellationToken cancellationToken) =>
            DeletePhraseMatcherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePhraseMatcher(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseMatcher(new DeletePhraseMatcherRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseMatcherAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseMatcherAsync(new DeletePhraseMatcherRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseMatcherAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePhraseMatcherAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePhraseMatcher(PhraseMatcherName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseMatcher(new DeletePhraseMatcherRequest
            {
                PhraseMatcherName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseMatcherAsync(PhraseMatcherName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseMatcherAsync(new DeletePhraseMatcherRequest
            {
                PhraseMatcherName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase matcher to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseMatcherAsync(PhraseMatcherName name, st::CancellationToken cancellationToken) =>
            DeletePhraseMatcherAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher UpdatePhraseMatcher(UpdatePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> UpdatePhraseMatcherAsync(UpdatePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> UpdatePhraseMatcherAsync(UpdatePhraseMatcherRequest request, st::CancellationToken cancellationToken) =>
            UpdatePhraseMatcherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a phrase matcher.
        /// </summary>
        /// <param name="phraseMatcher">
        /// Required. The new values for the phrase matcher.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseMatcher UpdatePhraseMatcher(PhraseMatcher phraseMatcher, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhraseMatcher(new UpdatePhraseMatcherRequest
            {
                PhraseMatcher = gax::GaxPreconditions.CheckNotNull(phraseMatcher, nameof(phraseMatcher)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a phrase matcher.
        /// </summary>
        /// <param name="phraseMatcher">
        /// Required. The new values for the phrase matcher.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> UpdatePhraseMatcherAsync(PhraseMatcher phraseMatcher, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhraseMatcherAsync(new UpdatePhraseMatcherRequest
            {
                PhraseMatcher = gax::GaxPreconditions.CheckNotNull(phraseMatcher, nameof(phraseMatcher)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a phrase matcher.
        /// </summary>
        /// <param name="phraseMatcher">
        /// Required. The new values for the phrase matcher.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseMatcher> UpdatePhraseMatcherAsync(PhraseMatcher phraseMatcher, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePhraseMatcherAsync(phraseMatcher, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateStatsResponse CalculateStats(CalculateStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateStatsResponse> CalculateStatsAsync(CalculateStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateStatsResponse> CalculateStatsAsync(CalculateStatsRequest request, st::CancellationToken cancellationToken) =>
            CalculateStatsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="location">
        /// Required. The location of the conversations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateStatsResponse CalculateStats(string location, gaxgrpc::CallSettings callSettings = null) =>
            CalculateStats(new CalculateStatsRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="location">
        /// Required. The location of the conversations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateStatsResponse> CalculateStatsAsync(string location, gaxgrpc::CallSettings callSettings = null) =>
            CalculateStatsAsync(new CalculateStatsRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="location">
        /// Required. The location of the conversations.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateStatsResponse> CalculateStatsAsync(string location, st::CancellationToken cancellationToken) =>
            CalculateStatsAsync(location, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="location">
        /// Required. The location of the conversations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateStatsResponse CalculateStats(gagr::LocationName location, gaxgrpc::CallSettings callSettings = null) =>
            CalculateStats(new CalculateStatsRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="location">
        /// Required. The location of the conversations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateStatsResponse> CalculateStatsAsync(gagr::LocationName location, gaxgrpc::CallSettings callSettings = null) =>
            CalculateStatsAsync(new CalculateStatsRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            }, callSettings);

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="location">
        /// Required. The location of the conversations.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateStatsResponse> CalculateStatsAsync(gagr::LocationName location, st::CancellationToken cancellationToken) =>
            CalculateStatsAsync(location, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="settings">
        /// Required. The new settings values.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings UpdateSettings(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettings(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="settings">
        /// Required. The new settings values.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettingsAsync(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="settings">
        /// Required. The new settings values.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(settings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalysisRule CreateAnalysisRule(CreateAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> CreateAnalysisRuleAsync(CreateAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> CreateAnalysisRuleAsync(CreateAnalysisRuleRequest request, st::CancellationToken cancellationToken) =>
            CreateAnalysisRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a analysis rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis rule. Required. The location
        /// to create a analysis rule for. Format: `projects/&lt;Project
        /// ID&gt;/locations/&lt;Location ID&gt;` or `projects/&lt;Project
        /// Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="analysisRule">
        /// Required. The analysis rule resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalysisRule CreateAnalysisRule(string parent, AnalysisRule analysisRule, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysisRule(new CreateAnalysisRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AnalysisRule = gax::GaxPreconditions.CheckNotNull(analysisRule, nameof(analysisRule)),
            }, callSettings);

        /// <summary>
        /// Creates a analysis rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis rule. Required. The location
        /// to create a analysis rule for. Format: `projects/&lt;Project
        /// ID&gt;/locations/&lt;Location ID&gt;` or `projects/&lt;Project
        /// Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="analysisRule">
        /// Required. The analysis rule resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> CreateAnalysisRuleAsync(string parent, AnalysisRule analysisRule, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysisRuleAsync(new CreateAnalysisRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AnalysisRule = gax::GaxPreconditions.CheckNotNull(analysisRule, nameof(analysisRule)),
            }, callSettings);

        /// <summary>
        /// Creates a analysis rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis rule. Required. The location
        /// to create a analysis rule for. Format: `projects/&lt;Project
        /// ID&gt;/locations/&lt;Location ID&gt;` or `projects/&lt;Project
        /// Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="analysisRule">
        /// Required. The analysis rule resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> CreateAnalysisRuleAsync(string parent, AnalysisRule analysisRule, st::CancellationToken cancellationToken) =>
            CreateAnalysisRuleAsync(parent, analysisRule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a analysis rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis rule. Required. The location
        /// to create a analysis rule for. Format: `projects/&lt;Project
        /// ID&gt;/locations/&lt;Location ID&gt;` or `projects/&lt;Project
        /// Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="analysisRule">
        /// Required. The analysis rule resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalysisRule CreateAnalysisRule(gagr::LocationName parent, AnalysisRule analysisRule, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysisRule(new CreateAnalysisRuleRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AnalysisRule = gax::GaxPreconditions.CheckNotNull(analysisRule, nameof(analysisRule)),
            }, callSettings);

        /// <summary>
        /// Creates a analysis rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis rule. Required. The location
        /// to create a analysis rule for. Format: `projects/&lt;Project
        /// ID&gt;/locations/&lt;Location ID&gt;` or `projects/&lt;Project
        /// Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="analysisRule">
        /// Required. The analysis rule resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> CreateAnalysisRuleAsync(gagr::LocationName parent, AnalysisRule analysisRule, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysisRuleAsync(new CreateAnalysisRuleRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AnalysisRule = gax::GaxPreconditions.CheckNotNull(analysisRule, nameof(analysisRule)),
            }, callSettings);

        /// <summary>
        /// Creates a analysis rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis rule. Required. The location
        /// to create a analysis rule for. Format: `projects/&lt;Project
        /// ID&gt;/locations/&lt;Location ID&gt;` or `projects/&lt;Project
        /// Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="analysisRule">
        /// Required. The analysis rule resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> CreateAnalysisRuleAsync(gagr::LocationName parent, AnalysisRule analysisRule, st::CancellationToken cancellationToken) =>
            CreateAnalysisRuleAsync(parent, analysisRule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalysisRule GetAnalysisRule(GetAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> GetAnalysisRuleAsync(GetAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> GetAnalysisRuleAsync(GetAnalysisRuleRequest request, st::CancellationToken cancellationToken) =>
            GetAnalysisRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a analysis rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalysisRule to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalysisRule GetAnalysisRule(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysisRule(new GetAnalysisRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a analysis rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalysisRule to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> GetAnalysisRuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysisRuleAsync(new GetAnalysisRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a analysis rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalysisRule to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> GetAnalysisRuleAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnalysisRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a analysis rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalysisRule to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalysisRule GetAnalysisRule(AnalysisRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysisRule(new GetAnalysisRuleRequest
            {
                AnalysisRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a analysis rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalysisRule to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> GetAnalysisRuleAsync(AnalysisRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysisRuleAsync(new GetAnalysisRuleRequest
            {
                AnalysisRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a analysis rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalysisRule to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> GetAnalysisRuleAsync(AnalysisRuleName name, st::CancellationToken cancellationToken) =>
            GetAnalysisRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists analysis rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalysisRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalysisRulesResponse, AnalysisRule> ListAnalysisRules(ListAnalysisRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists analysis rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalysisRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalysisRulesResponse, AnalysisRule> ListAnalysisRulesAsync(ListAnalysisRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists analysis rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis rules.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalysisRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalysisRulesResponse, AnalysisRule> ListAnalysisRules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalysisRulesRequest request = new ListAnalysisRulesRequest
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
            return ListAnalysisRules(request, callSettings);
        }

        /// <summary>
        /// Lists analysis rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis rules.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalysisRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalysisRulesResponse, AnalysisRule> ListAnalysisRulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalysisRulesRequest request = new ListAnalysisRulesRequest
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
            return ListAnalysisRulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists analysis rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis rules.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalysisRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalysisRulesResponse, AnalysisRule> ListAnalysisRules(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalysisRulesRequest request = new ListAnalysisRulesRequest
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
            return ListAnalysisRules(request, callSettings);
        }

        /// <summary>
        /// Lists analysis rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the analysis rules.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalysisRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalysisRulesResponse, AnalysisRule> ListAnalysisRulesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalysisRulesRequest request = new ListAnalysisRulesRequest
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
            return ListAnalysisRulesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalysisRule UpdateAnalysisRule(UpdateAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> UpdateAnalysisRuleAsync(UpdateAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> UpdateAnalysisRuleAsync(UpdateAnalysisRuleRequest request, st::CancellationToken cancellationToken) =>
            UpdateAnalysisRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a analysis rule.
        /// </summary>
        /// <param name="analysisRule">
        /// Required. The new analysis rule.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated.
        /// If the update_mask is not provided, the update will be applied to all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalysisRule UpdateAnalysisRule(AnalysisRule analysisRule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAnalysisRule(new UpdateAnalysisRuleRequest
            {
                AnalysisRule = gax::GaxPreconditions.CheckNotNull(analysisRule, nameof(analysisRule)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a analysis rule.
        /// </summary>
        /// <param name="analysisRule">
        /// Required. The new analysis rule.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated.
        /// If the update_mask is not provided, the update will be applied to all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> UpdateAnalysisRuleAsync(AnalysisRule analysisRule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAnalysisRuleAsync(new UpdateAnalysisRuleRequest
            {
                AnalysisRule = gax::GaxPreconditions.CheckNotNull(analysisRule, nameof(analysisRule)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a analysis rule.
        /// </summary>
        /// <param name="analysisRule">
        /// Required. The new analysis rule.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated.
        /// If the update_mask is not provided, the update will be applied to all
        /// fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalysisRule> UpdateAnalysisRuleAsync(AnalysisRule analysisRule, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAnalysisRuleAsync(analysisRule, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalysisRule(DeleteAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisRuleAsync(DeleteAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisRuleAsync(DeleteAnalysisRuleRequest request, st::CancellationToken cancellationToken) =>
            DeleteAnalysisRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a analysis rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis rule to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalysisRule(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysisRule(new DeleteAnalysisRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a analysis rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis rule to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisRuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysisRuleAsync(new DeleteAnalysisRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a analysis rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis rule to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisRuleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAnalysisRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a analysis rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis rule to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalysisRule(AnalysisRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysisRule(new DeleteAnalysisRuleRequest
            {
                AnalysisRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a analysis rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis rule to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisRuleAsync(AnalysisRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysisRuleAsync(new DeleteAnalysisRuleRequest
            {
                AnalysisRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a analysis rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the analysis rule to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalysisRuleAsync(AnalysisRuleName name, st::CancellationToken cancellationToken) =>
            DeleteAnalysisRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EncryptionSpec GetEncryptionSpec(GetEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionSpec> GetEncryptionSpecAsync(GetEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionSpec> GetEncryptionSpecAsync(GetEncryptionSpecRequest request, st::CancellationToken cancellationToken) =>
            GetEncryptionSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the encryption spec resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EncryptionSpec GetEncryptionSpec(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEncryptionSpec(new GetEncryptionSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the encryption spec resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionSpec> GetEncryptionSpecAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEncryptionSpecAsync(new GetEncryptionSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the encryption spec resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionSpec> GetEncryptionSpecAsync(string name, st::CancellationToken cancellationToken) =>
            GetEncryptionSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the encryption spec resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EncryptionSpec GetEncryptionSpec(EncryptionSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEncryptionSpec(new GetEncryptionSpecRequest
            {
                EncryptionSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the encryption spec resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionSpec> GetEncryptionSpecAsync(EncryptionSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEncryptionSpecAsync(new GetEncryptionSpecRequest
            {
                EncryptionSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the encryption spec resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionSpec> GetEncryptionSpecAsync(EncryptionSpecName name, st::CancellationToken cancellationToken) =>
            GetEncryptionSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initializes a location-level encryption key specification. An error will
        /// result if the location has resources already created before the
        /// initialization. After the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> InitializeEncryptionSpec(InitializeEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initializes a location-level encryption key specification. An error will
        /// result if the location has resources already created before the
        /// initialization. After the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>> InitializeEncryptionSpecAsync(InitializeEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initializes a location-level encryption key specification. An error will
        /// result if the location has resources already created before the
        /// initialization. After the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>> InitializeEncryptionSpecAsync(InitializeEncryptionSpecRequest request, st::CancellationToken cancellationToken) =>
            InitializeEncryptionSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>InitializeEncryptionSpec</c>.</summary>
        public virtual lro::OperationsClient InitializeEncryptionSpecOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>InitializeEncryptionSpec</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> PollOnceInitializeEncryptionSpec(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InitializeEncryptionSpecOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>InitializeEncryptionSpec</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>> PollOnceInitializeEncryptionSpecAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InitializeEncryptionSpecOperationsClient, callSettings);

        /// <summary>
        /// Initializes a location-level encryption key specification. An error will
        /// result if the location has resources already created before the
        /// initialization. After the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="encryptionSpec">
        /// Required. The encryption spec used for CMEK encryption. It is required that
        /// the kms key is in the same region as the endpoint. The same key will be
        /// used for all provisioned resources, if encryption is available. If the
        /// `kms_key_name` field is left empty, no encryption will be enforced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> InitializeEncryptionSpec(EncryptionSpec encryptionSpec, gaxgrpc::CallSettings callSettings = null) =>
            InitializeEncryptionSpec(new InitializeEncryptionSpecRequest
            {
                EncryptionSpec = gax::GaxPreconditions.CheckNotNull(encryptionSpec, nameof(encryptionSpec)),
            }, callSettings);

        /// <summary>
        /// Initializes a location-level encryption key specification. An error will
        /// result if the location has resources already created before the
        /// initialization. After the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="encryptionSpec">
        /// Required. The encryption spec used for CMEK encryption. It is required that
        /// the kms key is in the same region as the endpoint. The same key will be
        /// used for all provisioned resources, if encryption is available. If the
        /// `kms_key_name` field is left empty, no encryption will be enforced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>> InitializeEncryptionSpecAsync(EncryptionSpec encryptionSpec, gaxgrpc::CallSettings callSettings = null) =>
            InitializeEncryptionSpecAsync(new InitializeEncryptionSpecRequest
            {
                EncryptionSpec = gax::GaxPreconditions.CheckNotNull(encryptionSpec, nameof(encryptionSpec)),
            }, callSettings);

        /// <summary>
        /// Initializes a location-level encryption key specification. An error will
        /// result if the location has resources already created before the
        /// initialization. After the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="encryptionSpec">
        /// Required. The encryption spec used for CMEK encryption. It is required that
        /// the kms key is in the same region as the endpoint. The same key will be
        /// used for all provisioned resources, if encryption is available. If the
        /// `kms_key_name` field is left empty, no encryption will be enforced.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>> InitializeEncryptionSpecAsync(EncryptionSpec encryptionSpec, st::CancellationToken cancellationToken) =>
            InitializeEncryptionSpecAsync(encryptionSpec, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual View CreateView(CreateViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> CreateViewAsync(CreateViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> CreateViewAsync(CreateViewRequest request, st::CancellationToken cancellationToken) =>
            CreateViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a view.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the view. Required. The location to create
        /// a view for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;` or
        /// `projects/&lt;Project Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="view">
        /// Required. The view resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual View CreateView(string parent, View view, gaxgrpc::CallSettings callSettings = null) =>
            CreateView(new CreateViewRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                View = gax::GaxPreconditions.CheckNotNull(view, nameof(view)),
            }, callSettings);

        /// <summary>
        /// Creates a view.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the view. Required. The location to create
        /// a view for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;` or
        /// `projects/&lt;Project Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="view">
        /// Required. The view resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> CreateViewAsync(string parent, View view, gaxgrpc::CallSettings callSettings = null) =>
            CreateViewAsync(new CreateViewRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                View = gax::GaxPreconditions.CheckNotNull(view, nameof(view)),
            }, callSettings);

        /// <summary>
        /// Creates a view.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the view. Required. The location to create
        /// a view for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;` or
        /// `projects/&lt;Project Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="view">
        /// Required. The view resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> CreateViewAsync(string parent, View view, st::CancellationToken cancellationToken) =>
            CreateViewAsync(parent, view, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a view.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the view. Required. The location to create
        /// a view for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;` or
        /// `projects/&lt;Project Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="view">
        /// Required. The view resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual View CreateView(gagr::LocationName parent, View view, gaxgrpc::CallSettings callSettings = null) =>
            CreateView(new CreateViewRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                View = gax::GaxPreconditions.CheckNotNull(view, nameof(view)),
            }, callSettings);

        /// <summary>
        /// Creates a view.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the view. Required. The location to create
        /// a view for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;` or
        /// `projects/&lt;Project Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="view">
        /// Required. The view resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> CreateViewAsync(gagr::LocationName parent, View view, gaxgrpc::CallSettings callSettings = null) =>
            CreateViewAsync(new CreateViewRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                View = gax::GaxPreconditions.CheckNotNull(view, nameof(view)),
            }, callSettings);

        /// <summary>
        /// Creates a view.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the view. Required. The location to create
        /// a view for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;` or
        /// `projects/&lt;Project Number&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="view">
        /// Required. The view resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> CreateViewAsync(gagr::LocationName parent, View view, st::CancellationToken cancellationToken) =>
            CreateViewAsync(parent, view, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual View GetView(GetViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> GetViewAsync(GetViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> GetViewAsync(GetViewRequest request, st::CancellationToken cancellationToken) =>
            GetViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a view.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the view to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual View GetView(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetView(new GetViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a view.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the view to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> GetViewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetViewAsync(new GetViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a view.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the view to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> GetViewAsync(string name, st::CancellationToken cancellationToken) =>
            GetViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a view.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the view to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual View GetView(ViewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetView(new GetViewRequest
            {
                ViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a view.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the view to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> GetViewAsync(ViewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetViewAsync(new GetViewRequest
            {
                ViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a view.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the view to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> GetViewAsync(ViewName name, st::CancellationToken cancellationToken) =>
            GetViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists views.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="View"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViewsResponse, View> ListViews(ListViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists views.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="View"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViewsResponse, View> ListViewsAsync(ListViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists views.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the views.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="View"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViewsResponse, View> ListViews(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewsRequest request = new ListViewsRequest
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
            return ListViews(request, callSettings);
        }

        /// <summary>
        /// Lists views.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the views.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="View"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViewsResponse, View> ListViewsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewsRequest request = new ListViewsRequest
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
            return ListViewsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists views.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the views.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="View"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViewsResponse, View> ListViews(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewsRequest request = new ListViewsRequest
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
            return ListViews(request, callSettings);
        }

        /// <summary>
        /// Lists views.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the views.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="View"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViewsResponse, View> ListViewsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewsRequest request = new ListViewsRequest
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
            return ListViewsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual View UpdateView(UpdateViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> UpdateViewAsync(UpdateViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> UpdateViewAsync(UpdateViewRequest request, st::CancellationToken cancellationToken) =>
            UpdateViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a view.
        /// </summary>
        /// <param name="view">
        /// Required. The new view.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual View UpdateView(View view, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateView(new UpdateViewRequest
            {
                View = gax::GaxPreconditions.CheckNotNull(view, nameof(view)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a view.
        /// </summary>
        /// <param name="view">
        /// Required. The new view.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> UpdateViewAsync(View view, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateViewAsync(new UpdateViewRequest
            {
                View = gax::GaxPreconditions.CheckNotNull(view, nameof(view)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a view.
        /// </summary>
        /// <param name="view">
        /// Required. The new view.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> UpdateViewAsync(View view, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateViewAsync(view, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteView(DeleteViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteViewAsync(DeleteViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteViewAsync(DeleteViewRequest request, st::CancellationToken cancellationToken) =>
            DeleteViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a view.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the view to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteView(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteView(new DeleteViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a view.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the view to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteViewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteViewAsync(new DeleteViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a view.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the view to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteViewAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a view.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the view to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteView(ViewName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteView(new DeleteViewRequest
            {
                ViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a view.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the view to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteViewAsync(ViewName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteViewAsync(new DeleteViewRequest
            {
                ViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a view.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the view to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteViewAsync(ViewName name, st::CancellationToken cancellationToken) =>
            DeleteViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Query metrics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<QueryMetricsResponse, QueryMetricsMetadata> QueryMetrics(QueryMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Query metrics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<QueryMetricsResponse, QueryMetricsMetadata>> QueryMetricsAsync(QueryMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Query metrics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<QueryMetricsResponse, QueryMetricsMetadata>> QueryMetricsAsync(QueryMetricsRequest request, st::CancellationToken cancellationToken) =>
            QueryMetricsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>QueryMetrics</c>.</summary>
        public virtual lro::OperationsClient QueryMetricsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>QueryMetrics</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<QueryMetricsResponse, QueryMetricsMetadata> PollOnceQueryMetrics(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<QueryMetricsResponse, QueryMetricsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), QueryMetricsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>QueryMetrics</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<QueryMetricsResponse, QueryMetricsMetadata>> PollOnceQueryMetricsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<QueryMetricsResponse, QueryMetricsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), QueryMetricsOperationsClient, callSettings);

        /// <summary>
        /// Create a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaQuestion CreateQaQuestion(CreateQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> CreateQaQuestionAsync(CreateQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> CreateQaQuestionAsync(CreateQaQuestionRequest request, st::CancellationToken cancellationToken) =>
            CreateQaQuestionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a QaQuestion.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaQuestion.
        /// </param>
        /// <param name="qaQuestion">
        /// Required. The QaQuestion to create.
        /// </param>
        /// <param name="qaQuestionId">
        /// Optional. A unique ID for the new question. This ID will become the final
        /// component of the question's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaQuestion CreateQaQuestion(string parent, QaQuestion qaQuestion, string qaQuestionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQaQuestion(new CreateQaQuestionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                QaQuestion = gax::GaxPreconditions.CheckNotNull(qaQuestion, nameof(qaQuestion)),
                QaQuestionId = qaQuestionId ?? "",
            }, callSettings);

        /// <summary>
        /// Create a QaQuestion.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaQuestion.
        /// </param>
        /// <param name="qaQuestion">
        /// Required. The QaQuestion to create.
        /// </param>
        /// <param name="qaQuestionId">
        /// Optional. A unique ID for the new question. This ID will become the final
        /// component of the question's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> CreateQaQuestionAsync(string parent, QaQuestion qaQuestion, string qaQuestionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQaQuestionAsync(new CreateQaQuestionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                QaQuestion = gax::GaxPreconditions.CheckNotNull(qaQuestion, nameof(qaQuestion)),
                QaQuestionId = qaQuestionId ?? "",
            }, callSettings);

        /// <summary>
        /// Create a QaQuestion.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaQuestion.
        /// </param>
        /// <param name="qaQuestion">
        /// Required. The QaQuestion to create.
        /// </param>
        /// <param name="qaQuestionId">
        /// Optional. A unique ID for the new question. This ID will become the final
        /// component of the question's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> CreateQaQuestionAsync(string parent, QaQuestion qaQuestion, string qaQuestionId, st::CancellationToken cancellationToken) =>
            CreateQaQuestionAsync(parent, qaQuestion, qaQuestionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a QaQuestion.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaQuestion.
        /// </param>
        /// <param name="qaQuestion">
        /// Required. The QaQuestion to create.
        /// </param>
        /// <param name="qaQuestionId">
        /// Optional. A unique ID for the new question. This ID will become the final
        /// component of the question's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaQuestion CreateQaQuestion(QaScorecardRevisionName parent, QaQuestion qaQuestion, string qaQuestionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQaQuestion(new CreateQaQuestionRequest
            {
                ParentAsQaScorecardRevisionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QaQuestion = gax::GaxPreconditions.CheckNotNull(qaQuestion, nameof(qaQuestion)),
                QaQuestionId = qaQuestionId ?? "",
            }, callSettings);

        /// <summary>
        /// Create a QaQuestion.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaQuestion.
        /// </param>
        /// <param name="qaQuestion">
        /// Required. The QaQuestion to create.
        /// </param>
        /// <param name="qaQuestionId">
        /// Optional. A unique ID for the new question. This ID will become the final
        /// component of the question's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> CreateQaQuestionAsync(QaScorecardRevisionName parent, QaQuestion qaQuestion, string qaQuestionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQaQuestionAsync(new CreateQaQuestionRequest
            {
                ParentAsQaScorecardRevisionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QaQuestion = gax::GaxPreconditions.CheckNotNull(qaQuestion, nameof(qaQuestion)),
                QaQuestionId = qaQuestionId ?? "",
            }, callSettings);

        /// <summary>
        /// Create a QaQuestion.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaQuestion.
        /// </param>
        /// <param name="qaQuestion">
        /// Required. The QaQuestion to create.
        /// </param>
        /// <param name="qaQuestionId">
        /// Optional. A unique ID for the new question. This ID will become the final
        /// component of the question's resource name. If no ID is specified, a
        /// server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> CreateQaQuestionAsync(QaScorecardRevisionName parent, QaQuestion qaQuestion, string qaQuestionId, st::CancellationToken cancellationToken) =>
            CreateQaQuestionAsync(parent, qaQuestion, qaQuestionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaQuestion GetQaQuestion(GetQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> GetQaQuestionAsync(GetQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> GetQaQuestionAsync(GetQaQuestionRequest request, st::CancellationToken cancellationToken) =>
            GetQaQuestionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a QaQuestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaQuestion to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaQuestion GetQaQuestion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQaQuestion(new GetQaQuestionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a QaQuestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaQuestion to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> GetQaQuestionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQaQuestionAsync(new GetQaQuestionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a QaQuestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaQuestion to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> GetQaQuestionAsync(string name, st::CancellationToken cancellationToken) =>
            GetQaQuestionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a QaQuestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaQuestion to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaQuestion GetQaQuestion(QaQuestionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQaQuestion(new GetQaQuestionRequest
            {
                QaQuestionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a QaQuestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaQuestion to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> GetQaQuestionAsync(QaQuestionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQaQuestionAsync(new GetQaQuestionRequest
            {
                QaQuestionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a QaQuestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaQuestion to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> GetQaQuestionAsync(QaQuestionName name, st::CancellationToken cancellationToken) =>
            GetQaQuestionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaQuestion UpdateQaQuestion(UpdateQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> UpdateQaQuestionAsync(UpdateQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> UpdateQaQuestionAsync(UpdateQaQuestionRequest request, st::CancellationToken cancellationToken) =>
            UpdateQaQuestionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a QaQuestion.
        /// </summary>
        /// <param name="qaQuestion">
        /// Required. The QaQuestion to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. All possible fields can be
        /// updated by passing `*`, or a subset of the following updateable fields can
        /// be provided:
        /// 
        /// * `abbreviation`
        /// * `answer_choices`
        /// * `answer_instructions`
        /// * `order`
        /// * `question_body`
        /// * `tags`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaQuestion UpdateQaQuestion(QaQuestion qaQuestion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateQaQuestion(new UpdateQaQuestionRequest
            {
                QaQuestion = gax::GaxPreconditions.CheckNotNull(qaQuestion, nameof(qaQuestion)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a QaQuestion.
        /// </summary>
        /// <param name="qaQuestion">
        /// Required. The QaQuestion to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. All possible fields can be
        /// updated by passing `*`, or a subset of the following updateable fields can
        /// be provided:
        /// 
        /// * `abbreviation`
        /// * `answer_choices`
        /// * `answer_instructions`
        /// * `order`
        /// * `question_body`
        /// * `tags`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> UpdateQaQuestionAsync(QaQuestion qaQuestion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateQaQuestionAsync(new UpdateQaQuestionRequest
            {
                QaQuestion = gax::GaxPreconditions.CheckNotNull(qaQuestion, nameof(qaQuestion)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a QaQuestion.
        /// </summary>
        /// <param name="qaQuestion">
        /// Required. The QaQuestion to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. All possible fields can be
        /// updated by passing `*`, or a subset of the following updateable fields can
        /// be provided:
        /// 
        /// * `abbreviation`
        /// * `answer_choices`
        /// * `answer_instructions`
        /// * `order`
        /// * `question_body`
        /// * `tags`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaQuestion> UpdateQaQuestionAsync(QaQuestion qaQuestion, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateQaQuestionAsync(qaQuestion, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteQaQuestion(DeleteQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaQuestionAsync(DeleteQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaQuestionAsync(DeleteQaQuestionRequest request, st::CancellationToken cancellationToken) =>
            DeleteQaQuestionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a QaQuestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaQuestion to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteQaQuestion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQaQuestion(new DeleteQaQuestionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a QaQuestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaQuestion to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaQuestionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQaQuestionAsync(new DeleteQaQuestionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a QaQuestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaQuestion to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaQuestionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteQaQuestionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a QaQuestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaQuestion to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteQaQuestion(QaQuestionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQaQuestion(new DeleteQaQuestionRequest
            {
                QaQuestionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a QaQuestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaQuestion to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaQuestionAsync(QaQuestionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQaQuestionAsync(new DeleteQaQuestionRequest
            {
                QaQuestionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a QaQuestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaQuestion to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaQuestionAsync(QaQuestionName name, st::CancellationToken cancellationToken) =>
            DeleteQaQuestionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists QaQuestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QaQuestion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQaQuestionsResponse, QaQuestion> ListQaQuestions(ListQaQuestionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists QaQuestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QaQuestion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQaQuestionsResponse, QaQuestion> ListQaQuestionsAsync(ListQaQuestionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists QaQuestions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the questions.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QaQuestion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQaQuestionsResponse, QaQuestion> ListQaQuestions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQaQuestionsRequest request = new ListQaQuestionsRequest
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
            return ListQaQuestions(request, callSettings);
        }

        /// <summary>
        /// Lists QaQuestions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the questions.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QaQuestion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQaQuestionsResponse, QaQuestion> ListQaQuestionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQaQuestionsRequest request = new ListQaQuestionsRequest
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
            return ListQaQuestionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists QaQuestions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the questions.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QaQuestion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQaQuestionsResponse, QaQuestion> ListQaQuestions(QaScorecardRevisionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQaQuestionsRequest request = new ListQaQuestionsRequest
            {
                ParentAsQaScorecardRevisionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListQaQuestions(request, callSettings);
        }

        /// <summary>
        /// Lists QaQuestions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the questions.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QaQuestion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQaQuestionsResponse, QaQuestion> ListQaQuestionsAsync(QaScorecardRevisionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQaQuestionsRequest request = new ListQaQuestionsRequest
            {
                ParentAsQaScorecardRevisionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListQaQuestionsAsync(request, callSettings);
        }

        /// <summary>
        /// Create a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecard CreateQaScorecard(CreateQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> CreateQaScorecardAsync(CreateQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> CreateQaScorecardAsync(CreateQaScorecardRequest request, st::CancellationToken cancellationToken) =>
            CreateQaScorecardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a QaScorecard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaScorecard.
        /// </param>
        /// <param name="qaScorecard">
        /// Required. The QaScorecard to create.
        /// </param>
        /// <param name="qaScorecardId">
        /// Optional. A unique ID for the new QaScorecard. This ID will become the
        /// final component of the QaScorecard's resource name. If no ID is specified,
        /// a server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecard CreateQaScorecard(string parent, QaScorecard qaScorecard, string qaScorecardId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQaScorecard(new CreateQaScorecardRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                QaScorecard = gax::GaxPreconditions.CheckNotNull(qaScorecard, nameof(qaScorecard)),
                QaScorecardId = qaScorecardId ?? "",
            }, callSettings);

        /// <summary>
        /// Create a QaScorecard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaScorecard.
        /// </param>
        /// <param name="qaScorecard">
        /// Required. The QaScorecard to create.
        /// </param>
        /// <param name="qaScorecardId">
        /// Optional. A unique ID for the new QaScorecard. This ID will become the
        /// final component of the QaScorecard's resource name. If no ID is specified,
        /// a server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> CreateQaScorecardAsync(string parent, QaScorecard qaScorecard, string qaScorecardId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQaScorecardAsync(new CreateQaScorecardRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                QaScorecard = gax::GaxPreconditions.CheckNotNull(qaScorecard, nameof(qaScorecard)),
                QaScorecardId = qaScorecardId ?? "",
            }, callSettings);

        /// <summary>
        /// Create a QaScorecard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaScorecard.
        /// </param>
        /// <param name="qaScorecard">
        /// Required. The QaScorecard to create.
        /// </param>
        /// <param name="qaScorecardId">
        /// Optional. A unique ID for the new QaScorecard. This ID will become the
        /// final component of the QaScorecard's resource name. If no ID is specified,
        /// a server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> CreateQaScorecardAsync(string parent, QaScorecard qaScorecard, string qaScorecardId, st::CancellationToken cancellationToken) =>
            CreateQaScorecardAsync(parent, qaScorecard, qaScorecardId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a QaScorecard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaScorecard.
        /// </param>
        /// <param name="qaScorecard">
        /// Required. The QaScorecard to create.
        /// </param>
        /// <param name="qaScorecardId">
        /// Optional. A unique ID for the new QaScorecard. This ID will become the
        /// final component of the QaScorecard's resource name. If no ID is specified,
        /// a server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecard CreateQaScorecard(gagr::LocationName parent, QaScorecard qaScorecard, string qaScorecardId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQaScorecard(new CreateQaScorecardRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QaScorecard = gax::GaxPreconditions.CheckNotNull(qaScorecard, nameof(qaScorecard)),
                QaScorecardId = qaScorecardId ?? "",
            }, callSettings);

        /// <summary>
        /// Create a QaScorecard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaScorecard.
        /// </param>
        /// <param name="qaScorecard">
        /// Required. The QaScorecard to create.
        /// </param>
        /// <param name="qaScorecardId">
        /// Optional. A unique ID for the new QaScorecard. This ID will become the
        /// final component of the QaScorecard's resource name. If no ID is specified,
        /// a server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> CreateQaScorecardAsync(gagr::LocationName parent, QaScorecard qaScorecard, string qaScorecardId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQaScorecardAsync(new CreateQaScorecardRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QaScorecard = gax::GaxPreconditions.CheckNotNull(qaScorecard, nameof(qaScorecard)),
                QaScorecardId = qaScorecardId ?? "",
            }, callSettings);

        /// <summary>
        /// Create a QaScorecard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaScorecard.
        /// </param>
        /// <param name="qaScorecard">
        /// Required. The QaScorecard to create.
        /// </param>
        /// <param name="qaScorecardId">
        /// Optional. A unique ID for the new QaScorecard. This ID will become the
        /// final component of the QaScorecard's resource name. If no ID is specified,
        /// a server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> CreateQaScorecardAsync(gagr::LocationName parent, QaScorecard qaScorecard, string qaScorecardId, st::CancellationToken cancellationToken) =>
            CreateQaScorecardAsync(parent, qaScorecard, qaScorecardId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecard GetQaScorecard(GetQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> GetQaScorecardAsync(GetQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> GetQaScorecardAsync(GetQaScorecardRequest request, st::CancellationToken cancellationToken) =>
            GetQaScorecardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a QaScorecard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecard to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecard GetQaScorecard(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQaScorecard(new GetQaScorecardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a QaScorecard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecard to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> GetQaScorecardAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQaScorecardAsync(new GetQaScorecardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a QaScorecard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecard to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> GetQaScorecardAsync(string name, st::CancellationToken cancellationToken) =>
            GetQaScorecardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a QaScorecard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecard to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecard GetQaScorecard(QaScorecardName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQaScorecard(new GetQaScorecardRequest
            {
                QaScorecardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a QaScorecard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecard to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> GetQaScorecardAsync(QaScorecardName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQaScorecardAsync(new GetQaScorecardRequest
            {
                QaScorecardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a QaScorecard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecard to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> GetQaScorecardAsync(QaScorecardName name, st::CancellationToken cancellationToken) =>
            GetQaScorecardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecard UpdateQaScorecard(UpdateQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> UpdateQaScorecardAsync(UpdateQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> UpdateQaScorecardAsync(UpdateQaScorecardRequest request, st::CancellationToken cancellationToken) =>
            UpdateQaScorecardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a QaScorecard.
        /// </summary>
        /// <param name="qaScorecard">
        /// Required. The QaScorecard to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. All possible fields can be
        /// updated by passing `*`, or a subset of the following updateable fields can
        /// be provided:
        /// 
        /// * `description`
        /// * `display_name`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecard UpdateQaScorecard(QaScorecard qaScorecard, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateQaScorecard(new UpdateQaScorecardRequest
            {
                QaScorecard = gax::GaxPreconditions.CheckNotNull(qaScorecard, nameof(qaScorecard)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a QaScorecard.
        /// </summary>
        /// <param name="qaScorecard">
        /// Required. The QaScorecard to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. All possible fields can be
        /// updated by passing `*`, or a subset of the following updateable fields can
        /// be provided:
        /// 
        /// * `description`
        /// * `display_name`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> UpdateQaScorecardAsync(QaScorecard qaScorecard, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateQaScorecardAsync(new UpdateQaScorecardRequest
            {
                QaScorecard = gax::GaxPreconditions.CheckNotNull(qaScorecard, nameof(qaScorecard)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a QaScorecard.
        /// </summary>
        /// <param name="qaScorecard">
        /// Required. The QaScorecard to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated. All possible fields can be
        /// updated by passing `*`, or a subset of the following updateable fields can
        /// be provided:
        /// 
        /// * `description`
        /// * `display_name`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecard> UpdateQaScorecardAsync(QaScorecard qaScorecard, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateQaScorecardAsync(qaScorecard, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteQaScorecard(DeleteQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaScorecardAsync(DeleteQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaScorecardAsync(DeleteQaScorecardRequest request, st::CancellationToken cancellationToken) =>
            DeleteQaScorecardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a QaScorecard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecard to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteQaScorecard(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQaScorecard(new DeleteQaScorecardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a QaScorecard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecard to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaScorecardAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQaScorecardAsync(new DeleteQaScorecardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a QaScorecard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecard to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaScorecardAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteQaScorecardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a QaScorecard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecard to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteQaScorecard(QaScorecardName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQaScorecard(new DeleteQaScorecardRequest
            {
                QaScorecardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a QaScorecard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecard to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaScorecardAsync(QaScorecardName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQaScorecardAsync(new DeleteQaScorecardRequest
            {
                QaScorecardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a QaScorecard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecard to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaScorecardAsync(QaScorecardName name, st::CancellationToken cancellationToken) =>
            DeleteQaScorecardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists QaScorecards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QaScorecard"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQaScorecardsResponse, QaScorecard> ListQaScorecards(ListQaScorecardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists QaScorecards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QaScorecard"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQaScorecardsResponse, QaScorecard> ListQaScorecardsAsync(ListQaScorecardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists QaScorecards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the scorecards.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QaScorecard"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQaScorecardsResponse, QaScorecard> ListQaScorecards(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQaScorecardsRequest request = new ListQaScorecardsRequest
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
            return ListQaScorecards(request, callSettings);
        }

        /// <summary>
        /// Lists QaScorecards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the scorecards.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QaScorecard"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQaScorecardsResponse, QaScorecard> ListQaScorecardsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQaScorecardsRequest request = new ListQaScorecardsRequest
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
            return ListQaScorecardsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists QaScorecards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the scorecards.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QaScorecard"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQaScorecardsResponse, QaScorecard> ListQaScorecards(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQaScorecardsRequest request = new ListQaScorecardsRequest
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
            return ListQaScorecards(request, callSettings);
        }

        /// <summary>
        /// Lists QaScorecards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the scorecards.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QaScorecard"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQaScorecardsResponse, QaScorecard> ListQaScorecardsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQaScorecardsRequest request = new ListQaScorecardsRequest
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
            return ListQaScorecardsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecardRevision CreateQaScorecardRevision(CreateQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> CreateQaScorecardRevisionAsync(CreateQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> CreateQaScorecardRevisionAsync(CreateQaScorecardRevisionRequest request, st::CancellationToken cancellationToken) =>
            CreateQaScorecardRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a QaScorecardRevision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaScorecardRevision.
        /// </param>
        /// <param name="qaScorecardRevision">
        /// Required. The QaScorecardRevision to create.
        /// </param>
        /// <param name="qaScorecardRevisionId">
        /// Optional. A unique ID for the new QaScorecardRevision. This ID will become
        /// the final component of the QaScorecardRevision's resource name. If no ID is
        /// specified, a server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecardRevision CreateQaScorecardRevision(string parent, QaScorecardRevision qaScorecardRevision, string qaScorecardRevisionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQaScorecardRevision(new CreateQaScorecardRevisionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                QaScorecardRevision = gax::GaxPreconditions.CheckNotNull(qaScorecardRevision, nameof(qaScorecardRevision)),
                QaScorecardRevisionId = qaScorecardRevisionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a QaScorecardRevision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaScorecardRevision.
        /// </param>
        /// <param name="qaScorecardRevision">
        /// Required. The QaScorecardRevision to create.
        /// </param>
        /// <param name="qaScorecardRevisionId">
        /// Optional. A unique ID for the new QaScorecardRevision. This ID will become
        /// the final component of the QaScorecardRevision's resource name. If no ID is
        /// specified, a server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> CreateQaScorecardRevisionAsync(string parent, QaScorecardRevision qaScorecardRevision, string qaScorecardRevisionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQaScorecardRevisionAsync(new CreateQaScorecardRevisionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                QaScorecardRevision = gax::GaxPreconditions.CheckNotNull(qaScorecardRevision, nameof(qaScorecardRevision)),
                QaScorecardRevisionId = qaScorecardRevisionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a QaScorecardRevision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaScorecardRevision.
        /// </param>
        /// <param name="qaScorecardRevision">
        /// Required. The QaScorecardRevision to create.
        /// </param>
        /// <param name="qaScorecardRevisionId">
        /// Optional. A unique ID for the new QaScorecardRevision. This ID will become
        /// the final component of the QaScorecardRevision's resource name. If no ID is
        /// specified, a server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> CreateQaScorecardRevisionAsync(string parent, QaScorecardRevision qaScorecardRevision, string qaScorecardRevisionId, st::CancellationToken cancellationToken) =>
            CreateQaScorecardRevisionAsync(parent, qaScorecardRevision, qaScorecardRevisionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a QaScorecardRevision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaScorecardRevision.
        /// </param>
        /// <param name="qaScorecardRevision">
        /// Required. The QaScorecardRevision to create.
        /// </param>
        /// <param name="qaScorecardRevisionId">
        /// Optional. A unique ID for the new QaScorecardRevision. This ID will become
        /// the final component of the QaScorecardRevision's resource name. If no ID is
        /// specified, a server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecardRevision CreateQaScorecardRevision(QaScorecardName parent, QaScorecardRevision qaScorecardRevision, string qaScorecardRevisionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQaScorecardRevision(new CreateQaScorecardRevisionRequest
            {
                ParentAsQaScorecardName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QaScorecardRevision = gax::GaxPreconditions.CheckNotNull(qaScorecardRevision, nameof(qaScorecardRevision)),
                QaScorecardRevisionId = qaScorecardRevisionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a QaScorecardRevision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaScorecardRevision.
        /// </param>
        /// <param name="qaScorecardRevision">
        /// Required. The QaScorecardRevision to create.
        /// </param>
        /// <param name="qaScorecardRevisionId">
        /// Optional. A unique ID for the new QaScorecardRevision. This ID will become
        /// the final component of the QaScorecardRevision's resource name. If no ID is
        /// specified, a server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> CreateQaScorecardRevisionAsync(QaScorecardName parent, QaScorecardRevision qaScorecardRevision, string qaScorecardRevisionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQaScorecardRevisionAsync(new CreateQaScorecardRevisionRequest
            {
                ParentAsQaScorecardName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QaScorecardRevision = gax::GaxPreconditions.CheckNotNull(qaScorecardRevision, nameof(qaScorecardRevision)),
                QaScorecardRevisionId = qaScorecardRevisionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a QaScorecardRevision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the QaScorecardRevision.
        /// </param>
        /// <param name="qaScorecardRevision">
        /// Required. The QaScorecardRevision to create.
        /// </param>
        /// <param name="qaScorecardRevisionId">
        /// Optional. A unique ID for the new QaScorecardRevision. This ID will become
        /// the final component of the QaScorecardRevision's resource name. If no ID is
        /// specified, a server-generated ID will be used.
        /// 
        /// This value should be 4-64 characters and must match the regular
        /// expression `^[a-z0-9-]{4,64}$`. Valid characters are `[a-z][0-9]-`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> CreateQaScorecardRevisionAsync(QaScorecardName parent, QaScorecardRevision qaScorecardRevision, string qaScorecardRevisionId, st::CancellationToken cancellationToken) =>
            CreateQaScorecardRevisionAsync(parent, qaScorecardRevision, qaScorecardRevisionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecardRevision GetQaScorecardRevision(GetQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> GetQaScorecardRevisionAsync(GetQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> GetQaScorecardRevisionAsync(GetQaScorecardRevisionRequest request, st::CancellationToken cancellationToken) =>
            GetQaScorecardRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a QaScorecardRevision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecardRevision to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecardRevision GetQaScorecardRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQaScorecardRevision(new GetQaScorecardRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a QaScorecardRevision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecardRevision to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> GetQaScorecardRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQaScorecardRevisionAsync(new GetQaScorecardRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a QaScorecardRevision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecardRevision to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> GetQaScorecardRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            GetQaScorecardRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a QaScorecardRevision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecardRevision to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecardRevision GetQaScorecardRevision(QaScorecardRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQaScorecardRevision(new GetQaScorecardRevisionRequest
            {
                QaScorecardRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a QaScorecardRevision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecardRevision to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> GetQaScorecardRevisionAsync(QaScorecardRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQaScorecardRevisionAsync(new GetQaScorecardRevisionRequest
            {
                QaScorecardRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a QaScorecardRevision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecardRevision to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> GetQaScorecardRevisionAsync(QaScorecardRevisionName name, st::CancellationToken cancellationToken) =>
            GetQaScorecardRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fine tune one or more QaModels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata> TuneQaScorecardRevision(TuneQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fine tune one or more QaModels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata>> TuneQaScorecardRevisionAsync(TuneQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fine tune one or more QaModels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata>> TuneQaScorecardRevisionAsync(TuneQaScorecardRevisionRequest request, st::CancellationToken cancellationToken) =>
            TuneQaScorecardRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>TuneQaScorecardRevision</c>.</summary>
        public virtual lro::OperationsClient TuneQaScorecardRevisionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TuneQaScorecardRevision</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata> PollOnceTuneQaScorecardRevision(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TuneQaScorecardRevisionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TuneQaScorecardRevision</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata>> PollOnceTuneQaScorecardRevisionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TuneQaScorecardRevisionOperationsClient, callSettings);

        /// <summary>
        /// Fine tune one or more QaModels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new fine tuning job instance.
        /// </param>
        /// <param name="filter">
        /// Required. Filter for selecting the feedback labels that needs to be
        /// used for training.
        /// This filter can be used to limit the feedback labels used for tuning to a
        /// feedback labels created or updated for a specific time-window etc.
        /// </param>
        /// <param name="validateOnly">
        /// Optional. Run in validate only mode, no fine tuning will actually run.
        /// Data quality validations like training data distributions will run.
        /// Even when set to false, the data quality validations will still run but
        /// once the validations complete we will proceed with the fine tune, if
        /// applicable.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata> TuneQaScorecardRevision(string parent, string filter, bool validateOnly, gaxgrpc::CallSettings callSettings = null) =>
            TuneQaScorecardRevision(new TuneQaScorecardRevisionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                ValidateOnly = validateOnly,
            }, callSettings);

        /// <summary>
        /// Fine tune one or more QaModels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new fine tuning job instance.
        /// </param>
        /// <param name="filter">
        /// Required. Filter for selecting the feedback labels that needs to be
        /// used for training.
        /// This filter can be used to limit the feedback labels used for tuning to a
        /// feedback labels created or updated for a specific time-window etc.
        /// </param>
        /// <param name="validateOnly">
        /// Optional. Run in validate only mode, no fine tuning will actually run.
        /// Data quality validations like training data distributions will run.
        /// Even when set to false, the data quality validations will still run but
        /// once the validations complete we will proceed with the fine tune, if
        /// applicable.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata>> TuneQaScorecardRevisionAsync(string parent, string filter, bool validateOnly, gaxgrpc::CallSettings callSettings = null) =>
            TuneQaScorecardRevisionAsync(new TuneQaScorecardRevisionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                ValidateOnly = validateOnly,
            }, callSettings);

        /// <summary>
        /// Fine tune one or more QaModels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new fine tuning job instance.
        /// </param>
        /// <param name="filter">
        /// Required. Filter for selecting the feedback labels that needs to be
        /// used for training.
        /// This filter can be used to limit the feedback labels used for tuning to a
        /// feedback labels created or updated for a specific time-window etc.
        /// </param>
        /// <param name="validateOnly">
        /// Optional. Run in validate only mode, no fine tuning will actually run.
        /// Data quality validations like training data distributions will run.
        /// Even when set to false, the data quality validations will still run but
        /// once the validations complete we will proceed with the fine tune, if
        /// applicable.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata>> TuneQaScorecardRevisionAsync(string parent, string filter, bool validateOnly, st::CancellationToken cancellationToken) =>
            TuneQaScorecardRevisionAsync(parent, filter, validateOnly, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fine tune one or more QaModels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new fine tuning job instance.
        /// </param>
        /// <param name="filter">
        /// Required. Filter for selecting the feedback labels that needs to be
        /// used for training.
        /// This filter can be used to limit the feedback labels used for tuning to a
        /// feedback labels created or updated for a specific time-window etc.
        /// </param>
        /// <param name="validateOnly">
        /// Optional. Run in validate only mode, no fine tuning will actually run.
        /// Data quality validations like training data distributions will run.
        /// Even when set to false, the data quality validations will still run but
        /// once the validations complete we will proceed with the fine tune, if
        /// applicable.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata> TuneQaScorecardRevision(QaScorecardRevisionName parent, string filter, bool validateOnly, gaxgrpc::CallSettings callSettings = null) =>
            TuneQaScorecardRevision(new TuneQaScorecardRevisionRequest
            {
                ParentAsQaScorecardRevisionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                ValidateOnly = validateOnly,
            }, callSettings);

        /// <summary>
        /// Fine tune one or more QaModels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new fine tuning job instance.
        /// </param>
        /// <param name="filter">
        /// Required. Filter for selecting the feedback labels that needs to be
        /// used for training.
        /// This filter can be used to limit the feedback labels used for tuning to a
        /// feedback labels created or updated for a specific time-window etc.
        /// </param>
        /// <param name="validateOnly">
        /// Optional. Run in validate only mode, no fine tuning will actually run.
        /// Data quality validations like training data distributions will run.
        /// Even when set to false, the data quality validations will still run but
        /// once the validations complete we will proceed with the fine tune, if
        /// applicable.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata>> TuneQaScorecardRevisionAsync(QaScorecardRevisionName parent, string filter, bool validateOnly, gaxgrpc::CallSettings callSettings = null) =>
            TuneQaScorecardRevisionAsync(new TuneQaScorecardRevisionRequest
            {
                ParentAsQaScorecardRevisionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                ValidateOnly = validateOnly,
            }, callSettings);

        /// <summary>
        /// Fine tune one or more QaModels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new fine tuning job instance.
        /// </param>
        /// <param name="filter">
        /// Required. Filter for selecting the feedback labels that needs to be
        /// used for training.
        /// This filter can be used to limit the feedback labels used for tuning to a
        /// feedback labels created or updated for a specific time-window etc.
        /// </param>
        /// <param name="validateOnly">
        /// Optional. Run in validate only mode, no fine tuning will actually run.
        /// Data quality validations like training data distributions will run.
        /// Even when set to false, the data quality validations will still run but
        /// once the validations complete we will proceed with the fine tune, if
        /// applicable.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata>> TuneQaScorecardRevisionAsync(QaScorecardRevisionName parent, string filter, bool validateOnly, st::CancellationToken cancellationToken) =>
            TuneQaScorecardRevisionAsync(parent, filter, validateOnly, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploy a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecardRevision DeployQaScorecardRevision(DeployQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploy a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> DeployQaScorecardRevisionAsync(DeployQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploy a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> DeployQaScorecardRevisionAsync(DeployQaScorecardRevisionRequest request, st::CancellationToken cancellationToken) =>
            DeployQaScorecardRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploy a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QaScorecardRevision UndeployQaScorecardRevision(UndeployQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploy a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> UndeployQaScorecardRevisionAsync(UndeployQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploy a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QaScorecardRevision> UndeployQaScorecardRevisionAsync(UndeployQaScorecardRevisionRequest request, st::CancellationToken cancellationToken) =>
            UndeployQaScorecardRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteQaScorecardRevision(DeleteQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaScorecardRevisionAsync(DeleteQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaScorecardRevisionAsync(DeleteQaScorecardRevisionRequest request, st::CancellationToken cancellationToken) =>
            DeleteQaScorecardRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a QaScorecardRevision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecardRevision to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteQaScorecardRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQaScorecardRevision(new DeleteQaScorecardRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a QaScorecardRevision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecardRevision to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaScorecardRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQaScorecardRevisionAsync(new DeleteQaScorecardRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a QaScorecardRevision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecardRevision to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaScorecardRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteQaScorecardRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a QaScorecardRevision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecardRevision to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteQaScorecardRevision(QaScorecardRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQaScorecardRevision(new DeleteQaScorecardRevisionRequest
            {
                QaScorecardRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a QaScorecardRevision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecardRevision to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaScorecardRevisionAsync(QaScorecardRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQaScorecardRevisionAsync(new DeleteQaScorecardRevisionRequest
            {
                QaScorecardRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a QaScorecardRevision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the QaScorecardRevision to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQaScorecardRevisionAsync(QaScorecardRevisionName name, st::CancellationToken cancellationToken) =>
            DeleteQaScorecardRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all revisions under the parent QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QaScorecardRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQaScorecardRevisionsResponse, QaScorecardRevision> ListQaScorecardRevisions(ListQaScorecardRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all revisions under the parent QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QaScorecardRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQaScorecardRevisionsResponse, QaScorecardRevision> ListQaScorecardRevisionsAsync(ListQaScorecardRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all revisions under the parent QaScorecard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the scorecard revisions. To list all
        /// revisions of all scorecards, substitute the QaScorecard ID with a '-'
        /// character.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QaScorecardRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQaScorecardRevisionsResponse, QaScorecardRevision> ListQaScorecardRevisions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQaScorecardRevisionsRequest request = new ListQaScorecardRevisionsRequest
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
            return ListQaScorecardRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists all revisions under the parent QaScorecard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the scorecard revisions. To list all
        /// revisions of all scorecards, substitute the QaScorecard ID with a '-'
        /// character.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QaScorecardRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQaScorecardRevisionsResponse, QaScorecardRevision> ListQaScorecardRevisionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQaScorecardRevisionsRequest request = new ListQaScorecardRevisionsRequest
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
            return ListQaScorecardRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all revisions under the parent QaScorecard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the scorecard revisions. To list all
        /// revisions of all scorecards, substitute the QaScorecard ID with a '-'
        /// character.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QaScorecardRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQaScorecardRevisionsResponse, QaScorecardRevision> ListQaScorecardRevisions(QaScorecardName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQaScorecardRevisionsRequest request = new ListQaScorecardRevisionsRequest
            {
                ParentAsQaScorecardName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListQaScorecardRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists all revisions under the parent QaScorecard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the scorecard revisions. To list all
        /// revisions of all scorecards, substitute the QaScorecard ID with a '-'
        /// character.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QaScorecardRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQaScorecardRevisionsResponse, QaScorecardRevision> ListQaScorecardRevisionsAsync(QaScorecardName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQaScorecardRevisionsRequest request = new ListQaScorecardRevisionsRequest
            {
                ParentAsQaScorecardName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListQaScorecardRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Create feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedbackLabel CreateFeedbackLabel(CreateFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> CreateFeedbackLabelAsync(CreateFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> CreateFeedbackLabelAsync(CreateFeedbackLabelRequest request, st::CancellationToken cancellationToken) =>
            CreateFeedbackLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create feedback label.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the feedback label.
        /// </param>
        /// <param name="feedbackLabel">
        /// Required. The feedback label to create.
        /// </param>
        /// <param name="feedbackLabelId">
        /// Optional. The ID of the feedback label to create.
        /// If one is not specified it will be generated by the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedbackLabel CreateFeedbackLabel(string parent, FeedbackLabel feedbackLabel, string feedbackLabelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeedbackLabel(new CreateFeedbackLabelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FeedbackLabelId = feedbackLabelId ?? "",
                FeedbackLabel = gax::GaxPreconditions.CheckNotNull(feedbackLabel, nameof(feedbackLabel)),
            }, callSettings);

        /// <summary>
        /// Create feedback label.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the feedback label.
        /// </param>
        /// <param name="feedbackLabel">
        /// Required. The feedback label to create.
        /// </param>
        /// <param name="feedbackLabelId">
        /// Optional. The ID of the feedback label to create.
        /// If one is not specified it will be generated by the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> CreateFeedbackLabelAsync(string parent, FeedbackLabel feedbackLabel, string feedbackLabelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeedbackLabelAsync(new CreateFeedbackLabelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FeedbackLabelId = feedbackLabelId ?? "",
                FeedbackLabel = gax::GaxPreconditions.CheckNotNull(feedbackLabel, nameof(feedbackLabel)),
            }, callSettings);

        /// <summary>
        /// Create feedback label.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the feedback label.
        /// </param>
        /// <param name="feedbackLabel">
        /// Required. The feedback label to create.
        /// </param>
        /// <param name="feedbackLabelId">
        /// Optional. The ID of the feedback label to create.
        /// If one is not specified it will be generated by the server.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> CreateFeedbackLabelAsync(string parent, FeedbackLabel feedbackLabel, string feedbackLabelId, st::CancellationToken cancellationToken) =>
            CreateFeedbackLabelAsync(parent, feedbackLabel, feedbackLabelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create feedback label.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the feedback label.
        /// </param>
        /// <param name="feedbackLabel">
        /// Required. The feedback label to create.
        /// </param>
        /// <param name="feedbackLabelId">
        /// Optional. The ID of the feedback label to create.
        /// If one is not specified it will be generated by the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedbackLabel CreateFeedbackLabel(ConversationName parent, FeedbackLabel feedbackLabel, string feedbackLabelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeedbackLabel(new CreateFeedbackLabelRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FeedbackLabelId = feedbackLabelId ?? "",
                FeedbackLabel = gax::GaxPreconditions.CheckNotNull(feedbackLabel, nameof(feedbackLabel)),
            }, callSettings);

        /// <summary>
        /// Create feedback label.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the feedback label.
        /// </param>
        /// <param name="feedbackLabel">
        /// Required. The feedback label to create.
        /// </param>
        /// <param name="feedbackLabelId">
        /// Optional. The ID of the feedback label to create.
        /// If one is not specified it will be generated by the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> CreateFeedbackLabelAsync(ConversationName parent, FeedbackLabel feedbackLabel, string feedbackLabelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeedbackLabelAsync(new CreateFeedbackLabelRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FeedbackLabelId = feedbackLabelId ?? "",
                FeedbackLabel = gax::GaxPreconditions.CheckNotNull(feedbackLabel, nameof(feedbackLabel)),
            }, callSettings);

        /// <summary>
        /// Create feedback label.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the feedback label.
        /// </param>
        /// <param name="feedbackLabel">
        /// Required. The feedback label to create.
        /// </param>
        /// <param name="feedbackLabelId">
        /// Optional. The ID of the feedback label to create.
        /// If one is not specified it will be generated by the server.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> CreateFeedbackLabelAsync(ConversationName parent, FeedbackLabel feedbackLabel, string feedbackLabelId, st::CancellationToken cancellationToken) =>
            CreateFeedbackLabelAsync(parent, feedbackLabel, feedbackLabelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List feedback labels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeedbackLabelsResponse, FeedbackLabel> ListFeedbackLabels(ListFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List feedback labels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeedbackLabelsResponse, FeedbackLabel> ListFeedbackLabelsAsync(ListFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List feedback labels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the feedback labels.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeedbackLabelsResponse, FeedbackLabel> ListFeedbackLabels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedbackLabelsRequest request = new ListFeedbackLabelsRequest
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
            return ListFeedbackLabels(request, callSettings);
        }

        /// <summary>
        /// List feedback labels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the feedback labels.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeedbackLabelsResponse, FeedbackLabel> ListFeedbackLabelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedbackLabelsRequest request = new ListFeedbackLabelsRequest
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
            return ListFeedbackLabelsAsync(request, callSettings);
        }

        /// <summary>
        /// List feedback labels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the feedback labels.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeedbackLabelsResponse, FeedbackLabel> ListFeedbackLabels(ConversationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedbackLabelsRequest request = new ListFeedbackLabelsRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeedbackLabels(request, callSettings);
        }

        /// <summary>
        /// List feedback labels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the feedback labels.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeedbackLabelsResponse, FeedbackLabel> ListFeedbackLabelsAsync(ConversationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedbackLabelsRequest request = new ListFeedbackLabelsRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeedbackLabelsAsync(request, callSettings);
        }

        /// <summary>
        /// Get feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedbackLabel GetFeedbackLabel(GetFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> GetFeedbackLabelAsync(GetFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> GetFeedbackLabelAsync(GetFeedbackLabelRequest request, st::CancellationToken cancellationToken) =>
            GetFeedbackLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get feedback label.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feedback label to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedbackLabel GetFeedbackLabel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedbackLabel(new GetFeedbackLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get feedback label.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feedback label to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> GetFeedbackLabelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedbackLabelAsync(new GetFeedbackLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get feedback label.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feedback label to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> GetFeedbackLabelAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeedbackLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get feedback label.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feedback label to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedbackLabel GetFeedbackLabel(FeedbackLabelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedbackLabel(new GetFeedbackLabelRequest
            {
                FeedbackLabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get feedback label.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feedback label to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> GetFeedbackLabelAsync(FeedbackLabelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedbackLabelAsync(new GetFeedbackLabelRequest
            {
                FeedbackLabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get feedback label.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feedback label to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> GetFeedbackLabelAsync(FeedbackLabelName name, st::CancellationToken cancellationToken) =>
            GetFeedbackLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedbackLabel UpdateFeedbackLabel(UpdateFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> UpdateFeedbackLabelAsync(UpdateFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> UpdateFeedbackLabelAsync(UpdateFeedbackLabelRequest request, st::CancellationToken cancellationToken) =>
            UpdateFeedbackLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update feedback label.
        /// </summary>
        /// <param name="feedbackLabel">
        /// Required. The feedback label to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedbackLabel UpdateFeedbackLabel(FeedbackLabel feedbackLabel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeedbackLabel(new UpdateFeedbackLabelRequest
            {
                FeedbackLabel = gax::GaxPreconditions.CheckNotNull(feedbackLabel, nameof(feedbackLabel)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update feedback label.
        /// </summary>
        /// <param name="feedbackLabel">
        /// Required. The feedback label to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> UpdateFeedbackLabelAsync(FeedbackLabel feedbackLabel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeedbackLabelAsync(new UpdateFeedbackLabelRequest
            {
                FeedbackLabel = gax::GaxPreconditions.CheckNotNull(feedbackLabel, nameof(feedbackLabel)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update feedback label.
        /// </summary>
        /// <param name="feedbackLabel">
        /// Required. The feedback label to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedbackLabel> UpdateFeedbackLabelAsync(FeedbackLabel feedbackLabel, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFeedbackLabelAsync(feedbackLabel, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFeedbackLabel(DeleteFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedbackLabelAsync(DeleteFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedbackLabelAsync(DeleteFeedbackLabelRequest request, st::CancellationToken cancellationToken) =>
            DeleteFeedbackLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete feedback label.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feedback label to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFeedbackLabel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeedbackLabel(new DeleteFeedbackLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete feedback label.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feedback label to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedbackLabelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeedbackLabelAsync(new DeleteFeedbackLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete feedback label.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feedback label to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedbackLabelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFeedbackLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete feedback label.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feedback label to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFeedbackLabel(FeedbackLabelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeedbackLabel(new DeleteFeedbackLabelRequest
            {
                FeedbackLabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete feedback label.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feedback label to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedbackLabelAsync(FeedbackLabelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeedbackLabelAsync(new DeleteFeedbackLabelRequest
            {
                FeedbackLabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete feedback label.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feedback label to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedbackLabelAsync(FeedbackLabelName name, st::CancellationToken cancellationToken) =>
            DeleteFeedbackLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all feedback labels by project number.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAllFeedbackLabelsResponse, FeedbackLabel> ListAllFeedbackLabels(ListAllFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all feedback labels by project number.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAllFeedbackLabelsResponse, FeedbackLabel> ListAllFeedbackLabelsAsync(ListAllFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all feedback labels by project number.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of all feedback labels per project.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAllFeedbackLabelsResponse, FeedbackLabel> ListAllFeedbackLabels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAllFeedbackLabelsRequest request = new ListAllFeedbackLabelsRequest
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
            return ListAllFeedbackLabels(request, callSettings);
        }

        /// <summary>
        /// List all feedback labels by project number.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of all feedback labels per project.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAllFeedbackLabelsResponse, FeedbackLabel> ListAllFeedbackLabelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAllFeedbackLabelsRequest request = new ListAllFeedbackLabelsRequest
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
            return ListAllFeedbackLabelsAsync(request, callSettings);
        }

        /// <summary>
        /// List all feedback labels by project number.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of all feedback labels per project.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAllFeedbackLabelsResponse, FeedbackLabel> ListAllFeedbackLabels(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAllFeedbackLabelsRequest request = new ListAllFeedbackLabelsRequest
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
            return ListAllFeedbackLabels(request, callSettings);
        }

        /// <summary>
        /// List all feedback labels by project number.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of all feedback labels per project.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAllFeedbackLabelsResponse, FeedbackLabel> ListAllFeedbackLabelsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAllFeedbackLabelsRequest request = new ListAllFeedbackLabelsRequest
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
            return ListAllFeedbackLabelsAsync(request, callSettings);
        }

        /// <summary>
        /// Upload feedback labels in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata> BulkUploadFeedbackLabels(BulkUploadFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upload feedback labels in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata>> BulkUploadFeedbackLabelsAsync(BulkUploadFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upload feedback labels in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata>> BulkUploadFeedbackLabelsAsync(BulkUploadFeedbackLabelsRequest request, st::CancellationToken cancellationToken) =>
            BulkUploadFeedbackLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BulkUploadFeedbackLabels</c>.</summary>
        public virtual lro::OperationsClient BulkUploadFeedbackLabelsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BulkUploadFeedbackLabels</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata> PollOnceBulkUploadFeedbackLabels(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkUploadFeedbackLabelsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BulkUploadFeedbackLabels</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata>> PollOnceBulkUploadFeedbackLabelsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkUploadFeedbackLabelsOperationsClient, callSettings);

        /// <summary>
        /// Upload feedback labels in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new feedback labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata> BulkUploadFeedbackLabels(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BulkUploadFeedbackLabels(new BulkUploadFeedbackLabelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Upload feedback labels in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new feedback labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata>> BulkUploadFeedbackLabelsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BulkUploadFeedbackLabelsAsync(new BulkUploadFeedbackLabelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Upload feedback labels in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new feedback labels.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata>> BulkUploadFeedbackLabelsAsync(string parent, st::CancellationToken cancellationToken) =>
            BulkUploadFeedbackLabelsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upload feedback labels in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new feedback labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata> BulkUploadFeedbackLabels(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            BulkUploadFeedbackLabels(new BulkUploadFeedbackLabelsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Upload feedback labels in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new feedback labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata>> BulkUploadFeedbackLabelsAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            BulkUploadFeedbackLabelsAsync(new BulkUploadFeedbackLabelsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Upload feedback labels in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new feedback labels.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata>> BulkUploadFeedbackLabelsAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            BulkUploadFeedbackLabelsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Download feedback labels in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata> BulkDownloadFeedbackLabels(BulkDownloadFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Download feedback labels in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata>> BulkDownloadFeedbackLabelsAsync(BulkDownloadFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Download feedback labels in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata>> BulkDownloadFeedbackLabelsAsync(BulkDownloadFeedbackLabelsRequest request, st::CancellationToken cancellationToken) =>
            BulkDownloadFeedbackLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BulkDownloadFeedbackLabels</c>.</summary>
        public virtual lro::OperationsClient BulkDownloadFeedbackLabelsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BulkDownloadFeedbackLabels</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata> PollOnceBulkDownloadFeedbackLabels(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkDownloadFeedbackLabelsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BulkDownloadFeedbackLabels</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata>> PollOnceBulkDownloadFeedbackLabelsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkDownloadFeedbackLabelsOperationsClient, callSettings);

        /// <summary>
        /// Download feedback labels in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new feedback labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata> BulkDownloadFeedbackLabels(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BulkDownloadFeedbackLabels(new BulkDownloadFeedbackLabelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Download feedback labels in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new feedback labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata>> BulkDownloadFeedbackLabelsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BulkDownloadFeedbackLabelsAsync(new BulkDownloadFeedbackLabelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Download feedback labels in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new feedback labels.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata>> BulkDownloadFeedbackLabelsAsync(string parent, st::CancellationToken cancellationToken) =>
            BulkDownloadFeedbackLabelsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Download feedback labels in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new feedback labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata> BulkDownloadFeedbackLabels(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            BulkDownloadFeedbackLabels(new BulkDownloadFeedbackLabelsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Download feedback labels in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new feedback labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata>> BulkDownloadFeedbackLabelsAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            BulkDownloadFeedbackLabelsAsync(new BulkDownloadFeedbackLabelsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Download feedback labels in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for new feedback labels.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata>> BulkDownloadFeedbackLabelsAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            BulkDownloadFeedbackLabelsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ContactCenterInsights client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// An API that lets users analyze and explore their business conversation data.
    /// </remarks>
    public sealed partial class ContactCenterInsightsClientImpl : ContactCenterInsightsClient
    {
        private readonly gaxgrpc::ApiCall<CreateConversationRequest, Conversation> _callCreateConversation;

        private readonly gaxgrpc::ApiCall<UploadConversationRequest, lro::Operation> _callUploadConversation;

        private readonly gaxgrpc::ApiCall<UpdateConversationRequest, Conversation> _callUpdateConversation;

        private readonly gaxgrpc::ApiCall<GetConversationRequest, Conversation> _callGetConversation;

        private readonly gaxgrpc::ApiCall<ListConversationsRequest, ListConversationsResponse> _callListConversations;

        private readonly gaxgrpc::ApiCall<DeleteConversationRequest, wkt::Empty> _callDeleteConversation;

        private readonly gaxgrpc::ApiCall<CreateAnalysisRequest, lro::Operation> _callCreateAnalysis;

        private readonly gaxgrpc::ApiCall<GetAnalysisRequest, Analysis> _callGetAnalysis;

        private readonly gaxgrpc::ApiCall<ListAnalysesRequest, ListAnalysesResponse> _callListAnalyses;

        private readonly gaxgrpc::ApiCall<DeleteAnalysisRequest, wkt::Empty> _callDeleteAnalysis;

        private readonly gaxgrpc::ApiCall<BulkAnalyzeConversationsRequest, lro::Operation> _callBulkAnalyzeConversations;

        private readonly gaxgrpc::ApiCall<BulkDeleteConversationsRequest, lro::Operation> _callBulkDeleteConversations;

        private readonly gaxgrpc::ApiCall<IngestConversationsRequest, lro::Operation> _callIngestConversations;

        private readonly gaxgrpc::ApiCall<ExportInsightsDataRequest, lro::Operation> _callExportInsightsData;

        private readonly gaxgrpc::ApiCall<CreateIssueModelRequest, lro::Operation> _callCreateIssueModel;

        private readonly gaxgrpc::ApiCall<UpdateIssueModelRequest, IssueModel> _callUpdateIssueModel;

        private readonly gaxgrpc::ApiCall<GetIssueModelRequest, IssueModel> _callGetIssueModel;

        private readonly gaxgrpc::ApiCall<ListIssueModelsRequest, ListIssueModelsResponse> _callListIssueModels;

        private readonly gaxgrpc::ApiCall<DeleteIssueModelRequest, lro::Operation> _callDeleteIssueModel;

        private readonly gaxgrpc::ApiCall<DeployIssueModelRequest, lro::Operation> _callDeployIssueModel;

        private readonly gaxgrpc::ApiCall<UndeployIssueModelRequest, lro::Operation> _callUndeployIssueModel;

        private readonly gaxgrpc::ApiCall<ExportIssueModelRequest, lro::Operation> _callExportIssueModel;

        private readonly gaxgrpc::ApiCall<ImportIssueModelRequest, lro::Operation> _callImportIssueModel;

        private readonly gaxgrpc::ApiCall<GetIssueRequest, Issue> _callGetIssue;

        private readonly gaxgrpc::ApiCall<ListIssuesRequest, ListIssuesResponse> _callListIssues;

        private readonly gaxgrpc::ApiCall<UpdateIssueRequest, Issue> _callUpdateIssue;

        private readonly gaxgrpc::ApiCall<DeleteIssueRequest, wkt::Empty> _callDeleteIssue;

        private readonly gaxgrpc::ApiCall<CalculateIssueModelStatsRequest, CalculateIssueModelStatsResponse> _callCalculateIssueModelStats;

        private readonly gaxgrpc::ApiCall<CreatePhraseMatcherRequest, PhraseMatcher> _callCreatePhraseMatcher;

        private readonly gaxgrpc::ApiCall<GetPhraseMatcherRequest, PhraseMatcher> _callGetPhraseMatcher;

        private readonly gaxgrpc::ApiCall<ListPhraseMatchersRequest, ListPhraseMatchersResponse> _callListPhraseMatchers;

        private readonly gaxgrpc::ApiCall<DeletePhraseMatcherRequest, wkt::Empty> _callDeletePhraseMatcher;

        private readonly gaxgrpc::ApiCall<UpdatePhraseMatcherRequest, PhraseMatcher> _callUpdatePhraseMatcher;

        private readonly gaxgrpc::ApiCall<CalculateStatsRequest, CalculateStatsResponse> _callCalculateStats;

        private readonly gaxgrpc::ApiCall<GetSettingsRequest, Settings> _callGetSettings;

        private readonly gaxgrpc::ApiCall<UpdateSettingsRequest, Settings> _callUpdateSettings;

        private readonly gaxgrpc::ApiCall<CreateAnalysisRuleRequest, AnalysisRule> _callCreateAnalysisRule;

        private readonly gaxgrpc::ApiCall<GetAnalysisRuleRequest, AnalysisRule> _callGetAnalysisRule;

        private readonly gaxgrpc::ApiCall<ListAnalysisRulesRequest, ListAnalysisRulesResponse> _callListAnalysisRules;

        private readonly gaxgrpc::ApiCall<UpdateAnalysisRuleRequest, AnalysisRule> _callUpdateAnalysisRule;

        private readonly gaxgrpc::ApiCall<DeleteAnalysisRuleRequest, wkt::Empty> _callDeleteAnalysisRule;

        private readonly gaxgrpc::ApiCall<GetEncryptionSpecRequest, EncryptionSpec> _callGetEncryptionSpec;

        private readonly gaxgrpc::ApiCall<InitializeEncryptionSpecRequest, lro::Operation> _callInitializeEncryptionSpec;

        private readonly gaxgrpc::ApiCall<CreateViewRequest, View> _callCreateView;

        private readonly gaxgrpc::ApiCall<GetViewRequest, View> _callGetView;

        private readonly gaxgrpc::ApiCall<ListViewsRequest, ListViewsResponse> _callListViews;

        private readonly gaxgrpc::ApiCall<UpdateViewRequest, View> _callUpdateView;

        private readonly gaxgrpc::ApiCall<DeleteViewRequest, wkt::Empty> _callDeleteView;

        private readonly gaxgrpc::ApiCall<QueryMetricsRequest, lro::Operation> _callQueryMetrics;

        private readonly gaxgrpc::ApiCall<CreateQaQuestionRequest, QaQuestion> _callCreateQaQuestion;

        private readonly gaxgrpc::ApiCall<GetQaQuestionRequest, QaQuestion> _callGetQaQuestion;

        private readonly gaxgrpc::ApiCall<UpdateQaQuestionRequest, QaQuestion> _callUpdateQaQuestion;

        private readonly gaxgrpc::ApiCall<DeleteQaQuestionRequest, wkt::Empty> _callDeleteQaQuestion;

        private readonly gaxgrpc::ApiCall<ListQaQuestionsRequest, ListQaQuestionsResponse> _callListQaQuestions;

        private readonly gaxgrpc::ApiCall<CreateQaScorecardRequest, QaScorecard> _callCreateQaScorecard;

        private readonly gaxgrpc::ApiCall<GetQaScorecardRequest, QaScorecard> _callGetQaScorecard;

        private readonly gaxgrpc::ApiCall<UpdateQaScorecardRequest, QaScorecard> _callUpdateQaScorecard;

        private readonly gaxgrpc::ApiCall<DeleteQaScorecardRequest, wkt::Empty> _callDeleteQaScorecard;

        private readonly gaxgrpc::ApiCall<ListQaScorecardsRequest, ListQaScorecardsResponse> _callListQaScorecards;

        private readonly gaxgrpc::ApiCall<CreateQaScorecardRevisionRequest, QaScorecardRevision> _callCreateQaScorecardRevision;

        private readonly gaxgrpc::ApiCall<GetQaScorecardRevisionRequest, QaScorecardRevision> _callGetQaScorecardRevision;

        private readonly gaxgrpc::ApiCall<TuneQaScorecardRevisionRequest, lro::Operation> _callTuneQaScorecardRevision;

        private readonly gaxgrpc::ApiCall<DeployQaScorecardRevisionRequest, QaScorecardRevision> _callDeployQaScorecardRevision;

        private readonly gaxgrpc::ApiCall<UndeployQaScorecardRevisionRequest, QaScorecardRevision> _callUndeployQaScorecardRevision;

        private readonly gaxgrpc::ApiCall<DeleteQaScorecardRevisionRequest, wkt::Empty> _callDeleteQaScorecardRevision;

        private readonly gaxgrpc::ApiCall<ListQaScorecardRevisionsRequest, ListQaScorecardRevisionsResponse> _callListQaScorecardRevisions;

        private readonly gaxgrpc::ApiCall<CreateFeedbackLabelRequest, FeedbackLabel> _callCreateFeedbackLabel;

        private readonly gaxgrpc::ApiCall<ListFeedbackLabelsRequest, ListFeedbackLabelsResponse> _callListFeedbackLabels;

        private readonly gaxgrpc::ApiCall<GetFeedbackLabelRequest, FeedbackLabel> _callGetFeedbackLabel;

        private readonly gaxgrpc::ApiCall<UpdateFeedbackLabelRequest, FeedbackLabel> _callUpdateFeedbackLabel;

        private readonly gaxgrpc::ApiCall<DeleteFeedbackLabelRequest, wkt::Empty> _callDeleteFeedbackLabel;

        private readonly gaxgrpc::ApiCall<ListAllFeedbackLabelsRequest, ListAllFeedbackLabelsResponse> _callListAllFeedbackLabels;

        private readonly gaxgrpc::ApiCall<BulkUploadFeedbackLabelsRequest, lro::Operation> _callBulkUploadFeedbackLabels;

        private readonly gaxgrpc::ApiCall<BulkDownloadFeedbackLabelsRequest, lro::Operation> _callBulkDownloadFeedbackLabels;

        /// <summary>
        /// Constructs a client wrapper for the ContactCenterInsights service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ContactCenterInsightsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ContactCenterInsightsClientImpl(ContactCenterInsights.ContactCenterInsightsClient grpcClient, ContactCenterInsightsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ContactCenterInsightsSettings effectiveSettings = settings ?? ContactCenterInsightsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            UploadConversationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UploadConversationOperationsSettings, logger);
            CreateAnalysisOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAnalysisOperationsSettings, logger);
            BulkAnalyzeConversationsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BulkAnalyzeConversationsOperationsSettings, logger);
            BulkDeleteConversationsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BulkDeleteConversationsOperationsSettings, logger);
            IngestConversationsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.IngestConversationsOperationsSettings, logger);
            ExportInsightsDataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportInsightsDataOperationsSettings, logger);
            CreateIssueModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateIssueModelOperationsSettings, logger);
            DeleteIssueModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteIssueModelOperationsSettings, logger);
            DeployIssueModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeployIssueModelOperationsSettings, logger);
            UndeployIssueModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeployIssueModelOperationsSettings, logger);
            ExportIssueModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportIssueModelOperationsSettings, logger);
            ImportIssueModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportIssueModelOperationsSettings, logger);
            InitializeEncryptionSpecOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.InitializeEncryptionSpecOperationsSettings, logger);
            QueryMetricsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.QueryMetricsOperationsSettings, logger);
            TuneQaScorecardRevisionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TuneQaScorecardRevisionOperationsSettings, logger);
            BulkUploadFeedbackLabelsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BulkUploadFeedbackLabelsOperationsSettings, logger);
            BulkDownloadFeedbackLabelsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BulkDownloadFeedbackLabelsOperationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateConversation = clientHelper.BuildApiCall<CreateConversationRequest, Conversation>("CreateConversation", grpcClient.CreateConversationAsync, grpcClient.CreateConversation, effectiveSettings.CreateConversationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConversation);
            Modify_CreateConversationApiCall(ref _callCreateConversation);
            _callUploadConversation = clientHelper.BuildApiCall<UploadConversationRequest, lro::Operation>("UploadConversation", grpcClient.UploadConversationAsync, grpcClient.UploadConversation, effectiveSettings.UploadConversationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callUploadConversation);
            Modify_UploadConversationApiCall(ref _callUploadConversation);
            _callUpdateConversation = clientHelper.BuildApiCall<UpdateConversationRequest, Conversation>("UpdateConversation", grpcClient.UpdateConversationAsync, grpcClient.UpdateConversation, effectiveSettings.UpdateConversationSettings).WithGoogleRequestParam("conversation.name", request => request.Conversation?.Name);
            Modify_ApiCall(ref _callUpdateConversation);
            Modify_UpdateConversationApiCall(ref _callUpdateConversation);
            _callGetConversation = clientHelper.BuildApiCall<GetConversationRequest, Conversation>("GetConversation", grpcClient.GetConversationAsync, grpcClient.GetConversation, effectiveSettings.GetConversationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConversation);
            Modify_GetConversationApiCall(ref _callGetConversation);
            _callListConversations = clientHelper.BuildApiCall<ListConversationsRequest, ListConversationsResponse>("ListConversations", grpcClient.ListConversationsAsync, grpcClient.ListConversations, effectiveSettings.ListConversationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConversations);
            Modify_ListConversationsApiCall(ref _callListConversations);
            _callDeleteConversation = clientHelper.BuildApiCall<DeleteConversationRequest, wkt::Empty>("DeleteConversation", grpcClient.DeleteConversationAsync, grpcClient.DeleteConversation, effectiveSettings.DeleteConversationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConversation);
            Modify_DeleteConversationApiCall(ref _callDeleteConversation);
            _callCreateAnalysis = clientHelper.BuildApiCall<CreateAnalysisRequest, lro::Operation>("CreateAnalysis", grpcClient.CreateAnalysisAsync, grpcClient.CreateAnalysis, effectiveSettings.CreateAnalysisSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAnalysis);
            Modify_CreateAnalysisApiCall(ref _callCreateAnalysis);
            _callGetAnalysis = clientHelper.BuildApiCall<GetAnalysisRequest, Analysis>("GetAnalysis", grpcClient.GetAnalysisAsync, grpcClient.GetAnalysis, effectiveSettings.GetAnalysisSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAnalysis);
            Modify_GetAnalysisApiCall(ref _callGetAnalysis);
            _callListAnalyses = clientHelper.BuildApiCall<ListAnalysesRequest, ListAnalysesResponse>("ListAnalyses", grpcClient.ListAnalysesAsync, grpcClient.ListAnalyses, effectiveSettings.ListAnalysesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAnalyses);
            Modify_ListAnalysesApiCall(ref _callListAnalyses);
            _callDeleteAnalysis = clientHelper.BuildApiCall<DeleteAnalysisRequest, wkt::Empty>("DeleteAnalysis", grpcClient.DeleteAnalysisAsync, grpcClient.DeleteAnalysis, effectiveSettings.DeleteAnalysisSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAnalysis);
            Modify_DeleteAnalysisApiCall(ref _callDeleteAnalysis);
            _callBulkAnalyzeConversations = clientHelper.BuildApiCall<BulkAnalyzeConversationsRequest, lro::Operation>("BulkAnalyzeConversations", grpcClient.BulkAnalyzeConversationsAsync, grpcClient.BulkAnalyzeConversations, effectiveSettings.BulkAnalyzeConversationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBulkAnalyzeConversations);
            Modify_BulkAnalyzeConversationsApiCall(ref _callBulkAnalyzeConversations);
            _callBulkDeleteConversations = clientHelper.BuildApiCall<BulkDeleteConversationsRequest, lro::Operation>("BulkDeleteConversations", grpcClient.BulkDeleteConversationsAsync, grpcClient.BulkDeleteConversations, effectiveSettings.BulkDeleteConversationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBulkDeleteConversations);
            Modify_BulkDeleteConversationsApiCall(ref _callBulkDeleteConversations);
            _callIngestConversations = clientHelper.BuildApiCall<IngestConversationsRequest, lro::Operation>("IngestConversations", grpcClient.IngestConversationsAsync, grpcClient.IngestConversations, effectiveSettings.IngestConversationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callIngestConversations);
            Modify_IngestConversationsApiCall(ref _callIngestConversations);
            _callExportInsightsData = clientHelper.BuildApiCall<ExportInsightsDataRequest, lro::Operation>("ExportInsightsData", grpcClient.ExportInsightsDataAsync, grpcClient.ExportInsightsData, effectiveSettings.ExportInsightsDataSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportInsightsData);
            Modify_ExportInsightsDataApiCall(ref _callExportInsightsData);
            _callCreateIssueModel = clientHelper.BuildApiCall<CreateIssueModelRequest, lro::Operation>("CreateIssueModel", grpcClient.CreateIssueModelAsync, grpcClient.CreateIssueModel, effectiveSettings.CreateIssueModelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIssueModel);
            Modify_CreateIssueModelApiCall(ref _callCreateIssueModel);
            _callUpdateIssueModel = clientHelper.BuildApiCall<UpdateIssueModelRequest, IssueModel>("UpdateIssueModel", grpcClient.UpdateIssueModelAsync, grpcClient.UpdateIssueModel, effectiveSettings.UpdateIssueModelSettings).WithGoogleRequestParam("issue_model.name", request => request.IssueModel?.Name);
            Modify_ApiCall(ref _callUpdateIssueModel);
            Modify_UpdateIssueModelApiCall(ref _callUpdateIssueModel);
            _callGetIssueModel = clientHelper.BuildApiCall<GetIssueModelRequest, IssueModel>("GetIssueModel", grpcClient.GetIssueModelAsync, grpcClient.GetIssueModel, effectiveSettings.GetIssueModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIssueModel);
            Modify_GetIssueModelApiCall(ref _callGetIssueModel);
            _callListIssueModels = clientHelper.BuildApiCall<ListIssueModelsRequest, ListIssueModelsResponse>("ListIssueModels", grpcClient.ListIssueModelsAsync, grpcClient.ListIssueModels, effectiveSettings.ListIssueModelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIssueModels);
            Modify_ListIssueModelsApiCall(ref _callListIssueModels);
            _callDeleteIssueModel = clientHelper.BuildApiCall<DeleteIssueModelRequest, lro::Operation>("DeleteIssueModel", grpcClient.DeleteIssueModelAsync, grpcClient.DeleteIssueModel, effectiveSettings.DeleteIssueModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIssueModel);
            Modify_DeleteIssueModelApiCall(ref _callDeleteIssueModel);
            _callDeployIssueModel = clientHelper.BuildApiCall<DeployIssueModelRequest, lro::Operation>("DeployIssueModel", grpcClient.DeployIssueModelAsync, grpcClient.DeployIssueModel, effectiveSettings.DeployIssueModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeployIssueModel);
            Modify_DeployIssueModelApiCall(ref _callDeployIssueModel);
            _callUndeployIssueModel = clientHelper.BuildApiCall<UndeployIssueModelRequest, lro::Operation>("UndeployIssueModel", grpcClient.UndeployIssueModelAsync, grpcClient.UndeployIssueModel, effectiveSettings.UndeployIssueModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeployIssueModel);
            Modify_UndeployIssueModelApiCall(ref _callUndeployIssueModel);
            _callExportIssueModel = clientHelper.BuildApiCall<ExportIssueModelRequest, lro::Operation>("ExportIssueModel", grpcClient.ExportIssueModelAsync, grpcClient.ExportIssueModel, effectiveSettings.ExportIssueModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportIssueModel);
            Modify_ExportIssueModelApiCall(ref _callExportIssueModel);
            _callImportIssueModel = clientHelper.BuildApiCall<ImportIssueModelRequest, lro::Operation>("ImportIssueModel", grpcClient.ImportIssueModelAsync, grpcClient.ImportIssueModel, effectiveSettings.ImportIssueModelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportIssueModel);
            Modify_ImportIssueModelApiCall(ref _callImportIssueModel);
            _callGetIssue = clientHelper.BuildApiCall<GetIssueRequest, Issue>("GetIssue", grpcClient.GetIssueAsync, grpcClient.GetIssue, effectiveSettings.GetIssueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIssue);
            Modify_GetIssueApiCall(ref _callGetIssue);
            _callListIssues = clientHelper.BuildApiCall<ListIssuesRequest, ListIssuesResponse>("ListIssues", grpcClient.ListIssuesAsync, grpcClient.ListIssues, effectiveSettings.ListIssuesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIssues);
            Modify_ListIssuesApiCall(ref _callListIssues);
            _callUpdateIssue = clientHelper.BuildApiCall<UpdateIssueRequest, Issue>("UpdateIssue", grpcClient.UpdateIssueAsync, grpcClient.UpdateIssue, effectiveSettings.UpdateIssueSettings).WithGoogleRequestParam("issue.name", request => request.Issue?.Name);
            Modify_ApiCall(ref _callUpdateIssue);
            Modify_UpdateIssueApiCall(ref _callUpdateIssue);
            _callDeleteIssue = clientHelper.BuildApiCall<DeleteIssueRequest, wkt::Empty>("DeleteIssue", grpcClient.DeleteIssueAsync, grpcClient.DeleteIssue, effectiveSettings.DeleteIssueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIssue);
            Modify_DeleteIssueApiCall(ref _callDeleteIssue);
            _callCalculateIssueModelStats = clientHelper.BuildApiCall<CalculateIssueModelStatsRequest, CalculateIssueModelStatsResponse>("CalculateIssueModelStats", grpcClient.CalculateIssueModelStatsAsync, grpcClient.CalculateIssueModelStats, effectiveSettings.CalculateIssueModelStatsSettings).WithGoogleRequestParam("issue_model", request => request.IssueModel);
            Modify_ApiCall(ref _callCalculateIssueModelStats);
            Modify_CalculateIssueModelStatsApiCall(ref _callCalculateIssueModelStats);
            _callCreatePhraseMatcher = clientHelper.BuildApiCall<CreatePhraseMatcherRequest, PhraseMatcher>("CreatePhraseMatcher", grpcClient.CreatePhraseMatcherAsync, grpcClient.CreatePhraseMatcher, effectiveSettings.CreatePhraseMatcherSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePhraseMatcher);
            Modify_CreatePhraseMatcherApiCall(ref _callCreatePhraseMatcher);
            _callGetPhraseMatcher = clientHelper.BuildApiCall<GetPhraseMatcherRequest, PhraseMatcher>("GetPhraseMatcher", grpcClient.GetPhraseMatcherAsync, grpcClient.GetPhraseMatcher, effectiveSettings.GetPhraseMatcherSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPhraseMatcher);
            Modify_GetPhraseMatcherApiCall(ref _callGetPhraseMatcher);
            _callListPhraseMatchers = clientHelper.BuildApiCall<ListPhraseMatchersRequest, ListPhraseMatchersResponse>("ListPhraseMatchers", grpcClient.ListPhraseMatchersAsync, grpcClient.ListPhraseMatchers, effectiveSettings.ListPhraseMatchersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPhraseMatchers);
            Modify_ListPhraseMatchersApiCall(ref _callListPhraseMatchers);
            _callDeletePhraseMatcher = clientHelper.BuildApiCall<DeletePhraseMatcherRequest, wkt::Empty>("DeletePhraseMatcher", grpcClient.DeletePhraseMatcherAsync, grpcClient.DeletePhraseMatcher, effectiveSettings.DeletePhraseMatcherSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePhraseMatcher);
            Modify_DeletePhraseMatcherApiCall(ref _callDeletePhraseMatcher);
            _callUpdatePhraseMatcher = clientHelper.BuildApiCall<UpdatePhraseMatcherRequest, PhraseMatcher>("UpdatePhraseMatcher", grpcClient.UpdatePhraseMatcherAsync, grpcClient.UpdatePhraseMatcher, effectiveSettings.UpdatePhraseMatcherSettings).WithGoogleRequestParam("phrase_matcher.name", request => request.PhraseMatcher?.Name);
            Modify_ApiCall(ref _callUpdatePhraseMatcher);
            Modify_UpdatePhraseMatcherApiCall(ref _callUpdatePhraseMatcher);
            _callCalculateStats = clientHelper.BuildApiCall<CalculateStatsRequest, CalculateStatsResponse>("CalculateStats", grpcClient.CalculateStatsAsync, grpcClient.CalculateStats, effectiveSettings.CalculateStatsSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callCalculateStats);
            Modify_CalculateStatsApiCall(ref _callCalculateStats);
            _callGetSettings = clientHelper.BuildApiCall<GetSettingsRequest, Settings>("GetSettings", grpcClient.GetSettingsAsync, grpcClient.GetSettings, effectiveSettings.GetSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSettings);
            Modify_GetSettingsApiCall(ref _callGetSettings);
            _callUpdateSettings = clientHelper.BuildApiCall<UpdateSettingsRequest, Settings>("UpdateSettings", grpcClient.UpdateSettingsAsync, grpcClient.UpdateSettings, effectiveSettings.UpdateSettingsSettings).WithGoogleRequestParam("settings.name", request => request.Settings?.Name);
            Modify_ApiCall(ref _callUpdateSettings);
            Modify_UpdateSettingsApiCall(ref _callUpdateSettings);
            _callCreateAnalysisRule = clientHelper.BuildApiCall<CreateAnalysisRuleRequest, AnalysisRule>("CreateAnalysisRule", grpcClient.CreateAnalysisRuleAsync, grpcClient.CreateAnalysisRule, effectiveSettings.CreateAnalysisRuleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAnalysisRule);
            Modify_CreateAnalysisRuleApiCall(ref _callCreateAnalysisRule);
            _callGetAnalysisRule = clientHelper.BuildApiCall<GetAnalysisRuleRequest, AnalysisRule>("GetAnalysisRule", grpcClient.GetAnalysisRuleAsync, grpcClient.GetAnalysisRule, effectiveSettings.GetAnalysisRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAnalysisRule);
            Modify_GetAnalysisRuleApiCall(ref _callGetAnalysisRule);
            _callListAnalysisRules = clientHelper.BuildApiCall<ListAnalysisRulesRequest, ListAnalysisRulesResponse>("ListAnalysisRules", grpcClient.ListAnalysisRulesAsync, grpcClient.ListAnalysisRules, effectiveSettings.ListAnalysisRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAnalysisRules);
            Modify_ListAnalysisRulesApiCall(ref _callListAnalysisRules);
            _callUpdateAnalysisRule = clientHelper.BuildApiCall<UpdateAnalysisRuleRequest, AnalysisRule>("UpdateAnalysisRule", grpcClient.UpdateAnalysisRuleAsync, grpcClient.UpdateAnalysisRule, effectiveSettings.UpdateAnalysisRuleSettings).WithGoogleRequestParam("analysis_rule.name", request => request.AnalysisRule?.Name);
            Modify_ApiCall(ref _callUpdateAnalysisRule);
            Modify_UpdateAnalysisRuleApiCall(ref _callUpdateAnalysisRule);
            _callDeleteAnalysisRule = clientHelper.BuildApiCall<DeleteAnalysisRuleRequest, wkt::Empty>("DeleteAnalysisRule", grpcClient.DeleteAnalysisRuleAsync, grpcClient.DeleteAnalysisRule, effectiveSettings.DeleteAnalysisRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAnalysisRule);
            Modify_DeleteAnalysisRuleApiCall(ref _callDeleteAnalysisRule);
            _callGetEncryptionSpec = clientHelper.BuildApiCall<GetEncryptionSpecRequest, EncryptionSpec>("GetEncryptionSpec", grpcClient.GetEncryptionSpecAsync, grpcClient.GetEncryptionSpec, effectiveSettings.GetEncryptionSpecSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEncryptionSpec);
            Modify_GetEncryptionSpecApiCall(ref _callGetEncryptionSpec);
            _callInitializeEncryptionSpec = clientHelper.BuildApiCall<InitializeEncryptionSpecRequest, lro::Operation>("InitializeEncryptionSpec", grpcClient.InitializeEncryptionSpecAsync, grpcClient.InitializeEncryptionSpec, effectiveSettings.InitializeEncryptionSpecSettings).WithGoogleRequestParam("encryption_spec.name", request => request.EncryptionSpec?.Name);
            Modify_ApiCall(ref _callInitializeEncryptionSpec);
            Modify_InitializeEncryptionSpecApiCall(ref _callInitializeEncryptionSpec);
            _callCreateView = clientHelper.BuildApiCall<CreateViewRequest, View>("CreateView", grpcClient.CreateViewAsync, grpcClient.CreateView, effectiveSettings.CreateViewSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateView);
            Modify_CreateViewApiCall(ref _callCreateView);
            _callGetView = clientHelper.BuildApiCall<GetViewRequest, View>("GetView", grpcClient.GetViewAsync, grpcClient.GetView, effectiveSettings.GetViewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetView);
            Modify_GetViewApiCall(ref _callGetView);
            _callListViews = clientHelper.BuildApiCall<ListViewsRequest, ListViewsResponse>("ListViews", grpcClient.ListViewsAsync, grpcClient.ListViews, effectiveSettings.ListViewsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListViews);
            Modify_ListViewsApiCall(ref _callListViews);
            _callUpdateView = clientHelper.BuildApiCall<UpdateViewRequest, View>("UpdateView", grpcClient.UpdateViewAsync, grpcClient.UpdateView, effectiveSettings.UpdateViewSettings).WithGoogleRequestParam("view.name", request => request.View?.Name);
            Modify_ApiCall(ref _callUpdateView);
            Modify_UpdateViewApiCall(ref _callUpdateView);
            _callDeleteView = clientHelper.BuildApiCall<DeleteViewRequest, wkt::Empty>("DeleteView", grpcClient.DeleteViewAsync, grpcClient.DeleteView, effectiveSettings.DeleteViewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteView);
            Modify_DeleteViewApiCall(ref _callDeleteView);
            _callQueryMetrics = clientHelper.BuildApiCall<QueryMetricsRequest, lro::Operation>("QueryMetrics", grpcClient.QueryMetricsAsync, grpcClient.QueryMetrics, effectiveSettings.QueryMetricsSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callQueryMetrics);
            Modify_QueryMetricsApiCall(ref _callQueryMetrics);
            _callCreateQaQuestion = clientHelper.BuildApiCall<CreateQaQuestionRequest, QaQuestion>("CreateQaQuestion", grpcClient.CreateQaQuestionAsync, grpcClient.CreateQaQuestion, effectiveSettings.CreateQaQuestionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateQaQuestion);
            Modify_CreateQaQuestionApiCall(ref _callCreateQaQuestion);
            _callGetQaQuestion = clientHelper.BuildApiCall<GetQaQuestionRequest, QaQuestion>("GetQaQuestion", grpcClient.GetQaQuestionAsync, grpcClient.GetQaQuestion, effectiveSettings.GetQaQuestionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetQaQuestion);
            Modify_GetQaQuestionApiCall(ref _callGetQaQuestion);
            _callUpdateQaQuestion = clientHelper.BuildApiCall<UpdateQaQuestionRequest, QaQuestion>("UpdateQaQuestion", grpcClient.UpdateQaQuestionAsync, grpcClient.UpdateQaQuestion, effectiveSettings.UpdateQaQuestionSettings).WithGoogleRequestParam("qa_question.name", request => request.QaQuestion?.Name);
            Modify_ApiCall(ref _callUpdateQaQuestion);
            Modify_UpdateQaQuestionApiCall(ref _callUpdateQaQuestion);
            _callDeleteQaQuestion = clientHelper.BuildApiCall<DeleteQaQuestionRequest, wkt::Empty>("DeleteQaQuestion", grpcClient.DeleteQaQuestionAsync, grpcClient.DeleteQaQuestion, effectiveSettings.DeleteQaQuestionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteQaQuestion);
            Modify_DeleteQaQuestionApiCall(ref _callDeleteQaQuestion);
            _callListQaQuestions = clientHelper.BuildApiCall<ListQaQuestionsRequest, ListQaQuestionsResponse>("ListQaQuestions", grpcClient.ListQaQuestionsAsync, grpcClient.ListQaQuestions, effectiveSettings.ListQaQuestionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListQaQuestions);
            Modify_ListQaQuestionsApiCall(ref _callListQaQuestions);
            _callCreateQaScorecard = clientHelper.BuildApiCall<CreateQaScorecardRequest, QaScorecard>("CreateQaScorecard", grpcClient.CreateQaScorecardAsync, grpcClient.CreateQaScorecard, effectiveSettings.CreateQaScorecardSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateQaScorecard);
            Modify_CreateQaScorecardApiCall(ref _callCreateQaScorecard);
            _callGetQaScorecard = clientHelper.BuildApiCall<GetQaScorecardRequest, QaScorecard>("GetQaScorecard", grpcClient.GetQaScorecardAsync, grpcClient.GetQaScorecard, effectiveSettings.GetQaScorecardSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetQaScorecard);
            Modify_GetQaScorecardApiCall(ref _callGetQaScorecard);
            _callUpdateQaScorecard = clientHelper.BuildApiCall<UpdateQaScorecardRequest, QaScorecard>("UpdateQaScorecard", grpcClient.UpdateQaScorecardAsync, grpcClient.UpdateQaScorecard, effectiveSettings.UpdateQaScorecardSettings).WithGoogleRequestParam("qa_scorecard.name", request => request.QaScorecard?.Name);
            Modify_ApiCall(ref _callUpdateQaScorecard);
            Modify_UpdateQaScorecardApiCall(ref _callUpdateQaScorecard);
            _callDeleteQaScorecard = clientHelper.BuildApiCall<DeleteQaScorecardRequest, wkt::Empty>("DeleteQaScorecard", grpcClient.DeleteQaScorecardAsync, grpcClient.DeleteQaScorecard, effectiveSettings.DeleteQaScorecardSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteQaScorecard);
            Modify_DeleteQaScorecardApiCall(ref _callDeleteQaScorecard);
            _callListQaScorecards = clientHelper.BuildApiCall<ListQaScorecardsRequest, ListQaScorecardsResponse>("ListQaScorecards", grpcClient.ListQaScorecardsAsync, grpcClient.ListQaScorecards, effectiveSettings.ListQaScorecardsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListQaScorecards);
            Modify_ListQaScorecardsApiCall(ref _callListQaScorecards);
            _callCreateQaScorecardRevision = clientHelper.BuildApiCall<CreateQaScorecardRevisionRequest, QaScorecardRevision>("CreateQaScorecardRevision", grpcClient.CreateQaScorecardRevisionAsync, grpcClient.CreateQaScorecardRevision, effectiveSettings.CreateQaScorecardRevisionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateQaScorecardRevision);
            Modify_CreateQaScorecardRevisionApiCall(ref _callCreateQaScorecardRevision);
            _callGetQaScorecardRevision = clientHelper.BuildApiCall<GetQaScorecardRevisionRequest, QaScorecardRevision>("GetQaScorecardRevision", grpcClient.GetQaScorecardRevisionAsync, grpcClient.GetQaScorecardRevision, effectiveSettings.GetQaScorecardRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetQaScorecardRevision);
            Modify_GetQaScorecardRevisionApiCall(ref _callGetQaScorecardRevision);
            _callTuneQaScorecardRevision = clientHelper.BuildApiCall<TuneQaScorecardRevisionRequest, lro::Operation>("TuneQaScorecardRevision", grpcClient.TuneQaScorecardRevisionAsync, grpcClient.TuneQaScorecardRevision, effectiveSettings.TuneQaScorecardRevisionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callTuneQaScorecardRevision);
            Modify_TuneQaScorecardRevisionApiCall(ref _callTuneQaScorecardRevision);
            _callDeployQaScorecardRevision = clientHelper.BuildApiCall<DeployQaScorecardRevisionRequest, QaScorecardRevision>("DeployQaScorecardRevision", grpcClient.DeployQaScorecardRevisionAsync, grpcClient.DeployQaScorecardRevision, effectiveSettings.DeployQaScorecardRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeployQaScorecardRevision);
            Modify_DeployQaScorecardRevisionApiCall(ref _callDeployQaScorecardRevision);
            _callUndeployQaScorecardRevision = clientHelper.BuildApiCall<UndeployQaScorecardRevisionRequest, QaScorecardRevision>("UndeployQaScorecardRevision", grpcClient.UndeployQaScorecardRevisionAsync, grpcClient.UndeployQaScorecardRevision, effectiveSettings.UndeployQaScorecardRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeployQaScorecardRevision);
            Modify_UndeployQaScorecardRevisionApiCall(ref _callUndeployQaScorecardRevision);
            _callDeleteQaScorecardRevision = clientHelper.BuildApiCall<DeleteQaScorecardRevisionRequest, wkt::Empty>("DeleteQaScorecardRevision", grpcClient.DeleteQaScorecardRevisionAsync, grpcClient.DeleteQaScorecardRevision, effectiveSettings.DeleteQaScorecardRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteQaScorecardRevision);
            Modify_DeleteQaScorecardRevisionApiCall(ref _callDeleteQaScorecardRevision);
            _callListQaScorecardRevisions = clientHelper.BuildApiCall<ListQaScorecardRevisionsRequest, ListQaScorecardRevisionsResponse>("ListQaScorecardRevisions", grpcClient.ListQaScorecardRevisionsAsync, grpcClient.ListQaScorecardRevisions, effectiveSettings.ListQaScorecardRevisionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListQaScorecardRevisions);
            Modify_ListQaScorecardRevisionsApiCall(ref _callListQaScorecardRevisions);
            _callCreateFeedbackLabel = clientHelper.BuildApiCall<CreateFeedbackLabelRequest, FeedbackLabel>("CreateFeedbackLabel", grpcClient.CreateFeedbackLabelAsync, grpcClient.CreateFeedbackLabel, effectiveSettings.CreateFeedbackLabelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFeedbackLabel);
            Modify_CreateFeedbackLabelApiCall(ref _callCreateFeedbackLabel);
            _callListFeedbackLabels = clientHelper.BuildApiCall<ListFeedbackLabelsRequest, ListFeedbackLabelsResponse>("ListFeedbackLabels", grpcClient.ListFeedbackLabelsAsync, grpcClient.ListFeedbackLabels, effectiveSettings.ListFeedbackLabelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeedbackLabels);
            Modify_ListFeedbackLabelsApiCall(ref _callListFeedbackLabels);
            _callGetFeedbackLabel = clientHelper.BuildApiCall<GetFeedbackLabelRequest, FeedbackLabel>("GetFeedbackLabel", grpcClient.GetFeedbackLabelAsync, grpcClient.GetFeedbackLabel, effectiveSettings.GetFeedbackLabelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeedbackLabel);
            Modify_GetFeedbackLabelApiCall(ref _callGetFeedbackLabel);
            _callUpdateFeedbackLabel = clientHelper.BuildApiCall<UpdateFeedbackLabelRequest, FeedbackLabel>("UpdateFeedbackLabel", grpcClient.UpdateFeedbackLabelAsync, grpcClient.UpdateFeedbackLabel, effectiveSettings.UpdateFeedbackLabelSettings).WithGoogleRequestParam("feedback_label.name", request => request.FeedbackLabel?.Name);
            Modify_ApiCall(ref _callUpdateFeedbackLabel);
            Modify_UpdateFeedbackLabelApiCall(ref _callUpdateFeedbackLabel);
            _callDeleteFeedbackLabel = clientHelper.BuildApiCall<DeleteFeedbackLabelRequest, wkt::Empty>("DeleteFeedbackLabel", grpcClient.DeleteFeedbackLabelAsync, grpcClient.DeleteFeedbackLabel, effectiveSettings.DeleteFeedbackLabelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFeedbackLabel);
            Modify_DeleteFeedbackLabelApiCall(ref _callDeleteFeedbackLabel);
            _callListAllFeedbackLabels = clientHelper.BuildApiCall<ListAllFeedbackLabelsRequest, ListAllFeedbackLabelsResponse>("ListAllFeedbackLabels", grpcClient.ListAllFeedbackLabelsAsync, grpcClient.ListAllFeedbackLabels, effectiveSettings.ListAllFeedbackLabelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAllFeedbackLabels);
            Modify_ListAllFeedbackLabelsApiCall(ref _callListAllFeedbackLabels);
            _callBulkUploadFeedbackLabels = clientHelper.BuildApiCall<BulkUploadFeedbackLabelsRequest, lro::Operation>("BulkUploadFeedbackLabels", grpcClient.BulkUploadFeedbackLabelsAsync, grpcClient.BulkUploadFeedbackLabels, effectiveSettings.BulkUploadFeedbackLabelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBulkUploadFeedbackLabels);
            Modify_BulkUploadFeedbackLabelsApiCall(ref _callBulkUploadFeedbackLabels);
            _callBulkDownloadFeedbackLabels = clientHelper.BuildApiCall<BulkDownloadFeedbackLabelsRequest, lro::Operation>("BulkDownloadFeedbackLabels", grpcClient.BulkDownloadFeedbackLabelsAsync, grpcClient.BulkDownloadFeedbackLabels, effectiveSettings.BulkDownloadFeedbackLabelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBulkDownloadFeedbackLabels);
            Modify_BulkDownloadFeedbackLabelsApiCall(ref _callBulkDownloadFeedbackLabels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateConversationApiCall(ref gaxgrpc::ApiCall<CreateConversationRequest, Conversation> call);

        partial void Modify_UploadConversationApiCall(ref gaxgrpc::ApiCall<UploadConversationRequest, lro::Operation> call);

        partial void Modify_UpdateConversationApiCall(ref gaxgrpc::ApiCall<UpdateConversationRequest, Conversation> call);

        partial void Modify_GetConversationApiCall(ref gaxgrpc::ApiCall<GetConversationRequest, Conversation> call);

        partial void Modify_ListConversationsApiCall(ref gaxgrpc::ApiCall<ListConversationsRequest, ListConversationsResponse> call);

        partial void Modify_DeleteConversationApiCall(ref gaxgrpc::ApiCall<DeleteConversationRequest, wkt::Empty> call);

        partial void Modify_CreateAnalysisApiCall(ref gaxgrpc::ApiCall<CreateAnalysisRequest, lro::Operation> call);

        partial void Modify_GetAnalysisApiCall(ref gaxgrpc::ApiCall<GetAnalysisRequest, Analysis> call);

        partial void Modify_ListAnalysesApiCall(ref gaxgrpc::ApiCall<ListAnalysesRequest, ListAnalysesResponse> call);

        partial void Modify_DeleteAnalysisApiCall(ref gaxgrpc::ApiCall<DeleteAnalysisRequest, wkt::Empty> call);

        partial void Modify_BulkAnalyzeConversationsApiCall(ref gaxgrpc::ApiCall<BulkAnalyzeConversationsRequest, lro::Operation> call);

        partial void Modify_BulkDeleteConversationsApiCall(ref gaxgrpc::ApiCall<BulkDeleteConversationsRequest, lro::Operation> call);

        partial void Modify_IngestConversationsApiCall(ref gaxgrpc::ApiCall<IngestConversationsRequest, lro::Operation> call);

        partial void Modify_ExportInsightsDataApiCall(ref gaxgrpc::ApiCall<ExportInsightsDataRequest, lro::Operation> call);

        partial void Modify_CreateIssueModelApiCall(ref gaxgrpc::ApiCall<CreateIssueModelRequest, lro::Operation> call);

        partial void Modify_UpdateIssueModelApiCall(ref gaxgrpc::ApiCall<UpdateIssueModelRequest, IssueModel> call);

        partial void Modify_GetIssueModelApiCall(ref gaxgrpc::ApiCall<GetIssueModelRequest, IssueModel> call);

        partial void Modify_ListIssueModelsApiCall(ref gaxgrpc::ApiCall<ListIssueModelsRequest, ListIssueModelsResponse> call);

        partial void Modify_DeleteIssueModelApiCall(ref gaxgrpc::ApiCall<DeleteIssueModelRequest, lro::Operation> call);

        partial void Modify_DeployIssueModelApiCall(ref gaxgrpc::ApiCall<DeployIssueModelRequest, lro::Operation> call);

        partial void Modify_UndeployIssueModelApiCall(ref gaxgrpc::ApiCall<UndeployIssueModelRequest, lro::Operation> call);

        partial void Modify_ExportIssueModelApiCall(ref gaxgrpc::ApiCall<ExportIssueModelRequest, lro::Operation> call);

        partial void Modify_ImportIssueModelApiCall(ref gaxgrpc::ApiCall<ImportIssueModelRequest, lro::Operation> call);

        partial void Modify_GetIssueApiCall(ref gaxgrpc::ApiCall<GetIssueRequest, Issue> call);

        partial void Modify_ListIssuesApiCall(ref gaxgrpc::ApiCall<ListIssuesRequest, ListIssuesResponse> call);

        partial void Modify_UpdateIssueApiCall(ref gaxgrpc::ApiCall<UpdateIssueRequest, Issue> call);

        partial void Modify_DeleteIssueApiCall(ref gaxgrpc::ApiCall<DeleteIssueRequest, wkt::Empty> call);

        partial void Modify_CalculateIssueModelStatsApiCall(ref gaxgrpc::ApiCall<CalculateIssueModelStatsRequest, CalculateIssueModelStatsResponse> call);

        partial void Modify_CreatePhraseMatcherApiCall(ref gaxgrpc::ApiCall<CreatePhraseMatcherRequest, PhraseMatcher> call);

        partial void Modify_GetPhraseMatcherApiCall(ref gaxgrpc::ApiCall<GetPhraseMatcherRequest, PhraseMatcher> call);

        partial void Modify_ListPhraseMatchersApiCall(ref gaxgrpc::ApiCall<ListPhraseMatchersRequest, ListPhraseMatchersResponse> call);

        partial void Modify_DeletePhraseMatcherApiCall(ref gaxgrpc::ApiCall<DeletePhraseMatcherRequest, wkt::Empty> call);

        partial void Modify_UpdatePhraseMatcherApiCall(ref gaxgrpc::ApiCall<UpdatePhraseMatcherRequest, PhraseMatcher> call);

        partial void Modify_CalculateStatsApiCall(ref gaxgrpc::ApiCall<CalculateStatsRequest, CalculateStatsResponse> call);

        partial void Modify_GetSettingsApiCall(ref gaxgrpc::ApiCall<GetSettingsRequest, Settings> call);

        partial void Modify_UpdateSettingsApiCall(ref gaxgrpc::ApiCall<UpdateSettingsRequest, Settings> call);

        partial void Modify_CreateAnalysisRuleApiCall(ref gaxgrpc::ApiCall<CreateAnalysisRuleRequest, AnalysisRule> call);

        partial void Modify_GetAnalysisRuleApiCall(ref gaxgrpc::ApiCall<GetAnalysisRuleRequest, AnalysisRule> call);

        partial void Modify_ListAnalysisRulesApiCall(ref gaxgrpc::ApiCall<ListAnalysisRulesRequest, ListAnalysisRulesResponse> call);

        partial void Modify_UpdateAnalysisRuleApiCall(ref gaxgrpc::ApiCall<UpdateAnalysisRuleRequest, AnalysisRule> call);

        partial void Modify_DeleteAnalysisRuleApiCall(ref gaxgrpc::ApiCall<DeleteAnalysisRuleRequest, wkt::Empty> call);

        partial void Modify_GetEncryptionSpecApiCall(ref gaxgrpc::ApiCall<GetEncryptionSpecRequest, EncryptionSpec> call);

        partial void Modify_InitializeEncryptionSpecApiCall(ref gaxgrpc::ApiCall<InitializeEncryptionSpecRequest, lro::Operation> call);

        partial void Modify_CreateViewApiCall(ref gaxgrpc::ApiCall<CreateViewRequest, View> call);

        partial void Modify_GetViewApiCall(ref gaxgrpc::ApiCall<GetViewRequest, View> call);

        partial void Modify_ListViewsApiCall(ref gaxgrpc::ApiCall<ListViewsRequest, ListViewsResponse> call);

        partial void Modify_UpdateViewApiCall(ref gaxgrpc::ApiCall<UpdateViewRequest, View> call);

        partial void Modify_DeleteViewApiCall(ref gaxgrpc::ApiCall<DeleteViewRequest, wkt::Empty> call);

        partial void Modify_QueryMetricsApiCall(ref gaxgrpc::ApiCall<QueryMetricsRequest, lro::Operation> call);

        partial void Modify_CreateQaQuestionApiCall(ref gaxgrpc::ApiCall<CreateQaQuestionRequest, QaQuestion> call);

        partial void Modify_GetQaQuestionApiCall(ref gaxgrpc::ApiCall<GetQaQuestionRequest, QaQuestion> call);

        partial void Modify_UpdateQaQuestionApiCall(ref gaxgrpc::ApiCall<UpdateQaQuestionRequest, QaQuestion> call);

        partial void Modify_DeleteQaQuestionApiCall(ref gaxgrpc::ApiCall<DeleteQaQuestionRequest, wkt::Empty> call);

        partial void Modify_ListQaQuestionsApiCall(ref gaxgrpc::ApiCall<ListQaQuestionsRequest, ListQaQuestionsResponse> call);

        partial void Modify_CreateQaScorecardApiCall(ref gaxgrpc::ApiCall<CreateQaScorecardRequest, QaScorecard> call);

        partial void Modify_GetQaScorecardApiCall(ref gaxgrpc::ApiCall<GetQaScorecardRequest, QaScorecard> call);

        partial void Modify_UpdateQaScorecardApiCall(ref gaxgrpc::ApiCall<UpdateQaScorecardRequest, QaScorecard> call);

        partial void Modify_DeleteQaScorecardApiCall(ref gaxgrpc::ApiCall<DeleteQaScorecardRequest, wkt::Empty> call);

        partial void Modify_ListQaScorecardsApiCall(ref gaxgrpc::ApiCall<ListQaScorecardsRequest, ListQaScorecardsResponse> call);

        partial void Modify_CreateQaScorecardRevisionApiCall(ref gaxgrpc::ApiCall<CreateQaScorecardRevisionRequest, QaScorecardRevision> call);

        partial void Modify_GetQaScorecardRevisionApiCall(ref gaxgrpc::ApiCall<GetQaScorecardRevisionRequest, QaScorecardRevision> call);

        partial void Modify_TuneQaScorecardRevisionApiCall(ref gaxgrpc::ApiCall<TuneQaScorecardRevisionRequest, lro::Operation> call);

        partial void Modify_DeployQaScorecardRevisionApiCall(ref gaxgrpc::ApiCall<DeployQaScorecardRevisionRequest, QaScorecardRevision> call);

        partial void Modify_UndeployQaScorecardRevisionApiCall(ref gaxgrpc::ApiCall<UndeployQaScorecardRevisionRequest, QaScorecardRevision> call);

        partial void Modify_DeleteQaScorecardRevisionApiCall(ref gaxgrpc::ApiCall<DeleteQaScorecardRevisionRequest, wkt::Empty> call);

        partial void Modify_ListQaScorecardRevisionsApiCall(ref gaxgrpc::ApiCall<ListQaScorecardRevisionsRequest, ListQaScorecardRevisionsResponse> call);

        partial void Modify_CreateFeedbackLabelApiCall(ref gaxgrpc::ApiCall<CreateFeedbackLabelRequest, FeedbackLabel> call);

        partial void Modify_ListFeedbackLabelsApiCall(ref gaxgrpc::ApiCall<ListFeedbackLabelsRequest, ListFeedbackLabelsResponse> call);

        partial void Modify_GetFeedbackLabelApiCall(ref gaxgrpc::ApiCall<GetFeedbackLabelRequest, FeedbackLabel> call);

        partial void Modify_UpdateFeedbackLabelApiCall(ref gaxgrpc::ApiCall<UpdateFeedbackLabelRequest, FeedbackLabel> call);

        partial void Modify_DeleteFeedbackLabelApiCall(ref gaxgrpc::ApiCall<DeleteFeedbackLabelRequest, wkt::Empty> call);

        partial void Modify_ListAllFeedbackLabelsApiCall(ref gaxgrpc::ApiCall<ListAllFeedbackLabelsRequest, ListAllFeedbackLabelsResponse> call);

        partial void Modify_BulkUploadFeedbackLabelsApiCall(ref gaxgrpc::ApiCall<BulkUploadFeedbackLabelsRequest, lro::Operation> call);

        partial void Modify_BulkDownloadFeedbackLabelsApiCall(ref gaxgrpc::ApiCall<BulkDownloadFeedbackLabelsRequest, lro::Operation> call);

        partial void OnConstruction(ContactCenterInsights.ContactCenterInsightsClient grpcClient, ContactCenterInsightsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ContactCenterInsights client</summary>
        public override ContactCenterInsights.ContactCenterInsightsClient GrpcClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateConversationRequest(ref CreateConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UploadConversationRequest(ref UploadConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConversationRequest(ref UpdateConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversationRequest(ref GetConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConversationsRequest(ref ListConversationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConversationRequest(ref DeleteConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAnalysisRequest(ref CreateAnalysisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnalysisRequest(ref GetAnalysisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAnalysesRequest(ref ListAnalysesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAnalysisRequest(ref DeleteAnalysisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BulkAnalyzeConversationsRequest(ref BulkAnalyzeConversationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BulkDeleteConversationsRequest(ref BulkDeleteConversationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_IngestConversationsRequest(ref IngestConversationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportInsightsDataRequest(ref ExportInsightsDataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateIssueModelRequest(ref CreateIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateIssueModelRequest(ref UpdateIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIssueModelRequest(ref GetIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIssueModelsRequest(ref ListIssueModelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIssueModelRequest(ref DeleteIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeployIssueModelRequest(ref DeployIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeployIssueModelRequest(ref UndeployIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportIssueModelRequest(ref ExportIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportIssueModelRequest(ref ImportIssueModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIssueRequest(ref GetIssueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIssuesRequest(ref ListIssuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateIssueRequest(ref UpdateIssueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIssueRequest(ref DeleteIssueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CalculateIssueModelStatsRequest(ref CalculateIssueModelStatsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePhraseMatcherRequest(ref CreatePhraseMatcherRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPhraseMatcherRequest(ref GetPhraseMatcherRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPhraseMatchersRequest(ref ListPhraseMatchersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePhraseMatcherRequest(ref DeletePhraseMatcherRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePhraseMatcherRequest(ref UpdatePhraseMatcherRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CalculateStatsRequest(ref CalculateStatsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSettingsRequest(ref GetSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSettingsRequest(ref UpdateSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAnalysisRuleRequest(ref CreateAnalysisRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnalysisRuleRequest(ref GetAnalysisRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAnalysisRulesRequest(ref ListAnalysisRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAnalysisRuleRequest(ref UpdateAnalysisRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAnalysisRuleRequest(ref DeleteAnalysisRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEncryptionSpecRequest(ref GetEncryptionSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InitializeEncryptionSpecRequest(ref InitializeEncryptionSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateViewRequest(ref CreateViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetViewRequest(ref GetViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListViewsRequest(ref ListViewsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateViewRequest(ref UpdateViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteViewRequest(ref DeleteViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryMetricsRequest(ref QueryMetricsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateQaQuestionRequest(ref CreateQaQuestionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetQaQuestionRequest(ref GetQaQuestionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateQaQuestionRequest(ref UpdateQaQuestionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteQaQuestionRequest(ref DeleteQaQuestionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListQaQuestionsRequest(ref ListQaQuestionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateQaScorecardRequest(ref CreateQaScorecardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetQaScorecardRequest(ref GetQaScorecardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateQaScorecardRequest(ref UpdateQaScorecardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteQaScorecardRequest(ref DeleteQaScorecardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListQaScorecardsRequest(ref ListQaScorecardsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateQaScorecardRevisionRequest(ref CreateQaScorecardRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetQaScorecardRevisionRequest(ref GetQaScorecardRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TuneQaScorecardRevisionRequest(ref TuneQaScorecardRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeployQaScorecardRevisionRequest(ref DeployQaScorecardRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeployQaScorecardRevisionRequest(ref UndeployQaScorecardRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteQaScorecardRevisionRequest(ref DeleteQaScorecardRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListQaScorecardRevisionsRequest(ref ListQaScorecardRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFeedbackLabelRequest(ref CreateFeedbackLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeedbackLabelsRequest(ref ListFeedbackLabelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeedbackLabelRequest(ref GetFeedbackLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFeedbackLabelRequest(ref UpdateFeedbackLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFeedbackLabelRequest(ref DeleteFeedbackLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAllFeedbackLabelsRequest(ref ListAllFeedbackLabelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BulkUploadFeedbackLabelsRequest(ref BulkUploadFeedbackLabelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BulkDownloadFeedbackLabelsRequest(ref BulkDownloadFeedbackLabelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a conversation.
        /// Note that this method does not support audio transcription or redaction.
        /// Use `conversations.upload` instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Conversation CreateConversation(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationRequest(ref request, ref callSettings);
            return _callCreateConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a conversation.
        /// Note that this method does not support audio transcription or redaction.
        /// Use `conversations.upload` instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Conversation> CreateConversationAsync(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationRequest(ref request, ref callSettings);
            return _callCreateConversation.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UploadConversation</c>.</summary>
        public override lro::OperationsClient UploadConversationOperationsClient { get; }

        /// <summary>
        /// Create a long-running conversation upload operation. This method differs
        /// from `CreateConversation` by allowing audio transcription and optional DLP
        /// redaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Conversation, UploadConversationMetadata> UploadConversation(UploadConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadConversationRequest(ref request, ref callSettings);
            return new lro::Operation<Conversation, UploadConversationMetadata>(_callUploadConversation.Sync(request, callSettings), UploadConversationOperationsClient);
        }

        /// <summary>
        /// Create a long-running conversation upload operation. This method differs
        /// from `CreateConversation` by allowing audio transcription and optional DLP
        /// redaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Conversation, UploadConversationMetadata>> UploadConversationAsync(UploadConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadConversationRequest(ref request, ref callSettings);
            return new lro::Operation<Conversation, UploadConversationMetadata>(await _callUploadConversation.Async(request, callSettings).ConfigureAwait(false), UploadConversationOperationsClient);
        }

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Conversation UpdateConversation(UpdateConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversationRequest(ref request, ref callSettings);
            return _callUpdateConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Conversation> UpdateConversationAsync(UpdateConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversationRequest(ref request, ref callSettings);
            return _callUpdateConversation.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Conversation GetConversation(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationRequest(ref request, ref callSettings);
            return _callGetConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationRequest(ref request, ref callSettings);
            return _callGetConversation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public override gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConversationsRequest, ListConversationsResponse, Conversation>(_callListConversations, request, callSettings);
        }

        /// <summary>
        /// Lists conversations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConversationsRequest, ListConversationsResponse, Conversation>(_callListConversations, request, callSettings);
        }

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteConversation(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationRequest(ref request, ref callSettings);
            _callDeleteConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteConversationAsync(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationRequest(ref request, ref callSettings);
            return _callDeleteConversation.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAnalysis</c>.</summary>
        public override lro::OperationsClient CreateAnalysisOperationsClient { get; }

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Analysis, CreateAnalysisOperationMetadata> CreateAnalysis(CreateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnalysisRequest(ref request, ref callSettings);
            return new lro::Operation<Analysis, CreateAnalysisOperationMetadata>(_callCreateAnalysis.Sync(request, callSettings), CreateAnalysisOperationsClient);
        }

        /// <summary>
        /// Creates an analysis. The long running operation is done when the analysis
        /// has completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Analysis, CreateAnalysisOperationMetadata>> CreateAnalysisAsync(CreateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnalysisRequest(ref request, ref callSettings);
            return new lro::Operation<Analysis, CreateAnalysisOperationMetadata>(await _callCreateAnalysis.Async(request, callSettings).ConfigureAwait(false), CreateAnalysisOperationsClient);
        }

        /// <summary>
        /// Gets an analysis.
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
        /// Gets an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Analysis> GetAnalysisAsync(GetAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnalysisRequest(ref request, ref callSettings);
            return _callGetAnalysis.Async(request, callSettings);
        }

        /// <summary>
        /// Lists analyses.
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
        /// Lists analyses.
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
        /// Deletes an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAnalysis(DeleteAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnalysisRequest(ref request, ref callSettings);
            _callDeleteAnalysis.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAnalysisAsync(DeleteAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnalysisRequest(ref request, ref callSettings);
            return _callDeleteAnalysis.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BulkAnalyzeConversations</c>.</summary>
        public override lro::OperationsClient BulkAnalyzeConversationsOperationsClient { get; }

        /// <summary>
        /// Analyzes multiple conversations in a single request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> BulkAnalyzeConversations(BulkAnalyzeConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkAnalyzeConversationsRequest(ref request, ref callSettings);
            return new lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata>(_callBulkAnalyzeConversations.Sync(request, callSettings), BulkAnalyzeConversationsOperationsClient);
        }

        /// <summary>
        /// Analyzes multiple conversations in a single request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata>> BulkAnalyzeConversationsAsync(BulkAnalyzeConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkAnalyzeConversationsRequest(ref request, ref callSettings);
            return new lro::Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata>(await _callBulkAnalyzeConversations.Async(request, callSettings).ConfigureAwait(false), BulkAnalyzeConversationsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BulkDeleteConversations</c>.</summary>
        public override lro::OperationsClient BulkDeleteConversationsOperationsClient { get; }

        /// <summary>
        /// Deletes multiple conversations in a single request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> BulkDeleteConversations(BulkDeleteConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkDeleteConversationsRequest(ref request, ref callSettings);
            return new lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata>(_callBulkDeleteConversations.Sync(request, callSettings), BulkDeleteConversationsOperationsClient);
        }

        /// <summary>
        /// Deletes multiple conversations in a single request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata>> BulkDeleteConversationsAsync(BulkDeleteConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkDeleteConversationsRequest(ref request, ref callSettings);
            return new lro::Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata>(await _callBulkDeleteConversations.Async(request, callSettings).ConfigureAwait(false), BulkDeleteConversationsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>IngestConversations</c>.</summary>
        public override lro::OperationsClient IngestConversationsOperationsClient { get; }

        /// <summary>
        /// Imports conversations and processes them according to the user's
        /// configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<IngestConversationsResponse, IngestConversationsMetadata> IngestConversations(IngestConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IngestConversationsRequest(ref request, ref callSettings);
            return new lro::Operation<IngestConversationsResponse, IngestConversationsMetadata>(_callIngestConversations.Sync(request, callSettings), IngestConversationsOperationsClient);
        }

        /// <summary>
        /// Imports conversations and processes them according to the user's
        /// configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<IngestConversationsResponse, IngestConversationsMetadata>> IngestConversationsAsync(IngestConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IngestConversationsRequest(ref request, ref callSettings);
            return new lro::Operation<IngestConversationsResponse, IngestConversationsMetadata>(await _callIngestConversations.Async(request, callSettings).ConfigureAwait(false), IngestConversationsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportInsightsData</c>.</summary>
        public override lro::OperationsClient ExportInsightsDataOperationsClient { get; }

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> ExportInsightsData(ExportInsightsDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportInsightsDataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>(_callExportInsightsData.Sync(request, callSettings), ExportInsightsDataOperationsClient);
        }

        /// <summary>
        /// Export insights data to a destination defined in the request body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>> ExportInsightsDataAsync(ExportInsightsDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportInsightsDataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata>(await _callExportInsightsData.Async(request, callSettings).ConfigureAwait(false), ExportInsightsDataOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateIssueModel</c>.</summary>
        public override lro::OperationsClient CreateIssueModelOperationsClient { get; }

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<IssueModel, CreateIssueModelMetadata> CreateIssueModel(CreateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<IssueModel, CreateIssueModelMetadata>(_callCreateIssueModel.Sync(request, callSettings), CreateIssueModelOperationsClient);
        }

        /// <summary>
        /// Creates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<IssueModel, CreateIssueModelMetadata>> CreateIssueModelAsync(CreateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<IssueModel, CreateIssueModelMetadata>(await _callCreateIssueModel.Async(request, callSettings).ConfigureAwait(false), CreateIssueModelOperationsClient);
        }

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IssueModel UpdateIssueModel(UpdateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIssueModelRequest(ref request, ref callSettings);
            return _callUpdateIssueModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IssueModel> UpdateIssueModelAsync(UpdateIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIssueModelRequest(ref request, ref callSettings);
            return _callUpdateIssueModel.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IssueModel GetIssueModel(GetIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIssueModelRequest(ref request, ref callSettings);
            return _callGetIssueModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IssueModel> GetIssueModelAsync(GetIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIssueModelRequest(ref request, ref callSettings);
            return _callGetIssueModel.Async(request, callSettings);
        }

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListIssueModelsResponse ListIssueModels(ListIssueModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIssueModelsRequest(ref request, ref callSettings);
            return _callListIssueModels.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists issue models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListIssueModelsResponse> ListIssueModelsAsync(ListIssueModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIssueModelsRequest(ref request, ref callSettings);
            return _callListIssueModels.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteIssueModel</c>.</summary>
        public override lro::OperationsClient DeleteIssueModelOperationsClient { get; }

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteIssueModelMetadata> DeleteIssueModel(DeleteIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteIssueModelMetadata>(_callDeleteIssueModel.Sync(request, callSettings), DeleteIssueModelOperationsClient);
        }

        /// <summary>
        /// Deletes an issue model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteIssueModelMetadata>> DeleteIssueModelAsync(DeleteIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteIssueModelMetadata>(await _callDeleteIssueModel.Async(request, callSettings).ConfigureAwait(false), DeleteIssueModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeployIssueModel</c>.</summary>
        public override lro::OperationsClient DeployIssueModelOperationsClient { get; }

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata> DeployIssueModel(DeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>(_callDeployIssueModel.Sync(request, callSettings), DeployIssueModelOperationsClient);
        }

        /// <summary>
        /// Deploys an issue model. Returns an error if a model is already deployed.
        /// An issue model can only be used in analysis after it has been deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>> DeployIssueModelAsync(DeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<DeployIssueModelResponse, DeployIssueModelMetadata>(await _callDeployIssueModel.Async(request, callSettings).ConfigureAwait(false), DeployIssueModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeployIssueModel</c>.</summary>
        public override lro::OperationsClient UndeployIssueModelOperationsClient { get; }

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> UndeployIssueModel(UndeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>(_callUndeployIssueModel.Sync(request, callSettings), UndeployIssueModelOperationsClient);
        }

        /// <summary>
        /// Undeploys an issue model.
        /// An issue model can not be used in analysis after it has been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>> UndeployIssueModelAsync(UndeployIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata>(await _callUndeployIssueModel.Async(request, callSettings).ConfigureAwait(false), UndeployIssueModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportIssueModel</c>.</summary>
        public override lro::OperationsClient ExportIssueModelOperationsClient { get; }

        /// <summary>
        /// Exports an issue model to the provided destination.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata> ExportIssueModel(ExportIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata>(_callExportIssueModel.Sync(request, callSettings), ExportIssueModelOperationsClient);
        }

        /// <summary>
        /// Exports an issue model to the provided destination.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata>> ExportIssueModelAsync(ExportIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<ExportIssueModelResponse, ExportIssueModelMetadata>(await _callExportIssueModel.Async(request, callSettings).ConfigureAwait(false), ExportIssueModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportIssueModel</c>.</summary>
        public override lro::OperationsClient ImportIssueModelOperationsClient { get; }

        /// <summary>
        /// Imports an issue model from a Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata> ImportIssueModel(ImportIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata>(_callImportIssueModel.Sync(request, callSettings), ImportIssueModelOperationsClient);
        }

        /// <summary>
        /// Imports an issue model from a Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata>> ImportIssueModelAsync(ImportIssueModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportIssueModelRequest(ref request, ref callSettings);
            return new lro::Operation<ImportIssueModelResponse, ImportIssueModelMetadata>(await _callImportIssueModel.Async(request, callSettings).ConfigureAwait(false), ImportIssueModelOperationsClient);
        }

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Issue GetIssue(GetIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIssueRequest(ref request, ref callSettings);
            return _callGetIssue.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Issue> GetIssueAsync(GetIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIssueRequest(ref request, ref callSettings);
            return _callGetIssue.Async(request, callSettings);
        }

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListIssuesResponse ListIssues(ListIssuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIssuesRequest(ref request, ref callSettings);
            return _callListIssues.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists issues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListIssuesResponse> ListIssuesAsync(ListIssuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIssuesRequest(ref request, ref callSettings);
            return _callListIssues.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Issue UpdateIssue(UpdateIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIssueRequest(ref request, ref callSettings);
            return _callUpdateIssue.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Issue> UpdateIssueAsync(UpdateIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIssueRequest(ref request, ref callSettings);
            return _callUpdateIssue.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteIssue(DeleteIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIssueRequest(ref request, ref callSettings);
            _callDeleteIssue.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteIssueAsync(DeleteIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIssueRequest(ref request, ref callSettings);
            return _callDeleteIssue.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CalculateIssueModelStatsResponse CalculateIssueModelStats(CalculateIssueModelStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateIssueModelStatsRequest(ref request, ref callSettings);
            return _callCalculateIssueModelStats.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an issue model's statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CalculateIssueModelStatsResponse> CalculateIssueModelStatsAsync(CalculateIssueModelStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateIssueModelStatsRequest(ref request, ref callSettings);
            return _callCalculateIssueModelStats.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhraseMatcher CreatePhraseMatcher(CreatePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhraseMatcherRequest(ref request, ref callSettings);
            return _callCreatePhraseMatcher.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhraseMatcher> CreatePhraseMatcherAsync(CreatePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhraseMatcherRequest(ref request, ref callSettings);
            return _callCreatePhraseMatcher.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhraseMatcher GetPhraseMatcher(GetPhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhraseMatcherRequest(ref request, ref callSettings);
            return _callGetPhraseMatcher.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhraseMatcher> GetPhraseMatcherAsync(GetPhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhraseMatcherRequest(ref request, ref callSettings);
            return _callGetPhraseMatcher.Async(request, callSettings);
        }

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public override gax::PagedEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchers(ListPhraseMatchersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhraseMatchersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPhraseMatchersRequest, ListPhraseMatchersResponse, PhraseMatcher>(_callListPhraseMatchers, request, callSettings);
        }

        /// <summary>
        /// Lists phrase matchers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseMatcher"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPhraseMatchersResponse, PhraseMatcher> ListPhraseMatchersAsync(ListPhraseMatchersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhraseMatchersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPhraseMatchersRequest, ListPhraseMatchersResponse, PhraseMatcher>(_callListPhraseMatchers, request, callSettings);
        }

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePhraseMatcher(DeletePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhraseMatcherRequest(ref request, ref callSettings);
            _callDeletePhraseMatcher.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePhraseMatcherAsync(DeletePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhraseMatcherRequest(ref request, ref callSettings);
            return _callDeletePhraseMatcher.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhraseMatcher UpdatePhraseMatcher(UpdatePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhraseMatcherRequest(ref request, ref callSettings);
            return _callUpdatePhraseMatcher.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a phrase matcher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhraseMatcher> UpdatePhraseMatcherAsync(UpdatePhraseMatcherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhraseMatcherRequest(ref request, ref callSettings);
            return _callUpdatePhraseMatcher.Async(request, callSettings);
        }

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CalculateStatsResponse CalculateStats(CalculateStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateStatsRequest(ref request, ref callSettings);
            return _callCalculateStats.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets conversation statistics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CalculateStatsResponse> CalculateStatsAsync(CalculateStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateStatsRequest(ref request, ref callSettings);
            return _callCalculateStats.Async(request, callSettings);
        }

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return _callUpdateSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates project-level settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return _callUpdateSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalysisRule CreateAnalysisRule(CreateAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnalysisRuleRequest(ref request, ref callSettings);
            return _callCreateAnalysisRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalysisRule> CreateAnalysisRuleAsync(CreateAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnalysisRuleRequest(ref request, ref callSettings);
            return _callCreateAnalysisRule.Async(request, callSettings);
        }

        /// <summary>
        /// Get a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalysisRule GetAnalysisRule(GetAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnalysisRuleRequest(ref request, ref callSettings);
            return _callGetAnalysisRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalysisRule> GetAnalysisRuleAsync(GetAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnalysisRuleRequest(ref request, ref callSettings);
            return _callGetAnalysisRule.Async(request, callSettings);
        }

        /// <summary>
        /// Lists analysis rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalysisRule"/> resources.</returns>
        public override gax::PagedEnumerable<ListAnalysisRulesResponse, AnalysisRule> ListAnalysisRules(ListAnalysisRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalysisRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnalysisRulesRequest, ListAnalysisRulesResponse, AnalysisRule>(_callListAnalysisRules, request, callSettings);
        }

        /// <summary>
        /// Lists analysis rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalysisRule"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAnalysisRulesResponse, AnalysisRule> ListAnalysisRulesAsync(ListAnalysisRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalysisRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnalysisRulesRequest, ListAnalysisRulesResponse, AnalysisRule>(_callListAnalysisRules, request, callSettings);
        }

        /// <summary>
        /// Updates a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalysisRule UpdateAnalysisRule(UpdateAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAnalysisRuleRequest(ref request, ref callSettings);
            return _callUpdateAnalysisRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalysisRule> UpdateAnalysisRuleAsync(UpdateAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAnalysisRuleRequest(ref request, ref callSettings);
            return _callUpdateAnalysisRule.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAnalysisRule(DeleteAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnalysisRuleRequest(ref request, ref callSettings);
            _callDeleteAnalysisRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a analysis rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAnalysisRuleAsync(DeleteAnalysisRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnalysisRuleRequest(ref request, ref callSettings);
            return _callDeleteAnalysisRule.Async(request, callSettings);
        }

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EncryptionSpec GetEncryptionSpec(GetEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEncryptionSpecRequest(ref request, ref callSettings);
            return _callGetEncryptionSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EncryptionSpec> GetEncryptionSpecAsync(GetEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEncryptionSpecRequest(ref request, ref callSettings);
            return _callGetEncryptionSpec.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>InitializeEncryptionSpec</c>.</summary>
        public override lro::OperationsClient InitializeEncryptionSpecOperationsClient { get; }

        /// <summary>
        /// Initializes a location-level encryption key specification. An error will
        /// result if the location has resources already created before the
        /// initialization. After the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> InitializeEncryptionSpec(InitializeEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InitializeEncryptionSpecRequest(ref request, ref callSettings);
            return new lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>(_callInitializeEncryptionSpec.Sync(request, callSettings), InitializeEncryptionSpecOperationsClient);
        }

        /// <summary>
        /// Initializes a location-level encryption key specification. An error will
        /// result if the location has resources already created before the
        /// initialization. After the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>> InitializeEncryptionSpecAsync(InitializeEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InitializeEncryptionSpecRequest(ref request, ref callSettings);
            return new lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>(await _callInitializeEncryptionSpec.Async(request, callSettings).ConfigureAwait(false), InitializeEncryptionSpecOperationsClient);
        }

        /// <summary>
        /// Creates a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override View CreateView(CreateViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateViewRequest(ref request, ref callSettings);
            return _callCreateView.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<View> CreateViewAsync(CreateViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateViewRequest(ref request, ref callSettings);
            return _callCreateView.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override View GetView(GetViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetViewRequest(ref request, ref callSettings);
            return _callGetView.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<View> GetViewAsync(GetViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetViewRequest(ref request, ref callSettings);
            return _callGetView.Async(request, callSettings);
        }

        /// <summary>
        /// Lists views.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="View"/> resources.</returns>
        public override gax::PagedEnumerable<ListViewsResponse, View> ListViews(ListViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListViewsRequest, ListViewsResponse, View>(_callListViews, request, callSettings);
        }

        /// <summary>
        /// Lists views.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="View"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListViewsResponse, View> ListViewsAsync(ListViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListViewsRequest, ListViewsResponse, View>(_callListViews, request, callSettings);
        }

        /// <summary>
        /// Updates a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override View UpdateView(UpdateViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateViewRequest(ref request, ref callSettings);
            return _callUpdateView.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<View> UpdateViewAsync(UpdateViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateViewRequest(ref request, ref callSettings);
            return _callUpdateView.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteView(DeleteViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteViewRequest(ref request, ref callSettings);
            _callDeleteView.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteViewAsync(DeleteViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteViewRequest(ref request, ref callSettings);
            return _callDeleteView.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>QueryMetrics</c>.</summary>
        public override lro::OperationsClient QueryMetricsOperationsClient { get; }

        /// <summary>
        /// Query metrics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<QueryMetricsResponse, QueryMetricsMetadata> QueryMetrics(QueryMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryMetricsRequest(ref request, ref callSettings);
            return new lro::Operation<QueryMetricsResponse, QueryMetricsMetadata>(_callQueryMetrics.Sync(request, callSettings), QueryMetricsOperationsClient);
        }

        /// <summary>
        /// Query metrics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<QueryMetricsResponse, QueryMetricsMetadata>> QueryMetricsAsync(QueryMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryMetricsRequest(ref request, ref callSettings);
            return new lro::Operation<QueryMetricsResponse, QueryMetricsMetadata>(await _callQueryMetrics.Async(request, callSettings).ConfigureAwait(false), QueryMetricsOperationsClient);
        }

        /// <summary>
        /// Create a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QaQuestion CreateQaQuestion(CreateQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateQaQuestionRequest(ref request, ref callSettings);
            return _callCreateQaQuestion.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QaQuestion> CreateQaQuestionAsync(CreateQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateQaQuestionRequest(ref request, ref callSettings);
            return _callCreateQaQuestion.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QaQuestion GetQaQuestion(GetQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQaQuestionRequest(ref request, ref callSettings);
            return _callGetQaQuestion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QaQuestion> GetQaQuestionAsync(GetQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQaQuestionRequest(ref request, ref callSettings);
            return _callGetQaQuestion.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QaQuestion UpdateQaQuestion(UpdateQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateQaQuestionRequest(ref request, ref callSettings);
            return _callUpdateQaQuestion.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QaQuestion> UpdateQaQuestionAsync(UpdateQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateQaQuestionRequest(ref request, ref callSettings);
            return _callUpdateQaQuestion.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteQaQuestion(DeleteQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteQaQuestionRequest(ref request, ref callSettings);
            _callDeleteQaQuestion.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a QaQuestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteQaQuestionAsync(DeleteQaQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteQaQuestionRequest(ref request, ref callSettings);
            return _callDeleteQaQuestion.Async(request, callSettings);
        }

        /// <summary>
        /// Lists QaQuestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QaQuestion"/> resources.</returns>
        public override gax::PagedEnumerable<ListQaQuestionsResponse, QaQuestion> ListQaQuestions(ListQaQuestionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQaQuestionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListQaQuestionsRequest, ListQaQuestionsResponse, QaQuestion>(_callListQaQuestions, request, callSettings);
        }

        /// <summary>
        /// Lists QaQuestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QaQuestion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListQaQuestionsResponse, QaQuestion> ListQaQuestionsAsync(ListQaQuestionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQaQuestionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListQaQuestionsRequest, ListQaQuestionsResponse, QaQuestion>(_callListQaQuestions, request, callSettings);
        }

        /// <summary>
        /// Create a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QaScorecard CreateQaScorecard(CreateQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateQaScorecardRequest(ref request, ref callSettings);
            return _callCreateQaScorecard.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QaScorecard> CreateQaScorecardAsync(CreateQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateQaScorecardRequest(ref request, ref callSettings);
            return _callCreateQaScorecard.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QaScorecard GetQaScorecard(GetQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQaScorecardRequest(ref request, ref callSettings);
            return _callGetQaScorecard.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QaScorecard> GetQaScorecardAsync(GetQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQaScorecardRequest(ref request, ref callSettings);
            return _callGetQaScorecard.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QaScorecard UpdateQaScorecard(UpdateQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateQaScorecardRequest(ref request, ref callSettings);
            return _callUpdateQaScorecard.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QaScorecard> UpdateQaScorecardAsync(UpdateQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateQaScorecardRequest(ref request, ref callSettings);
            return _callUpdateQaScorecard.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteQaScorecard(DeleteQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteQaScorecardRequest(ref request, ref callSettings);
            _callDeleteQaScorecard.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteQaScorecardAsync(DeleteQaScorecardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteQaScorecardRequest(ref request, ref callSettings);
            return _callDeleteQaScorecard.Async(request, callSettings);
        }

        /// <summary>
        /// Lists QaScorecards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QaScorecard"/> resources.</returns>
        public override gax::PagedEnumerable<ListQaScorecardsResponse, QaScorecard> ListQaScorecards(ListQaScorecardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQaScorecardsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListQaScorecardsRequest, ListQaScorecardsResponse, QaScorecard>(_callListQaScorecards, request, callSettings);
        }

        /// <summary>
        /// Lists QaScorecards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QaScorecard"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListQaScorecardsResponse, QaScorecard> ListQaScorecardsAsync(ListQaScorecardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQaScorecardsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListQaScorecardsRequest, ListQaScorecardsResponse, QaScorecard>(_callListQaScorecards, request, callSettings);
        }

        /// <summary>
        /// Creates a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QaScorecardRevision CreateQaScorecardRevision(CreateQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateQaScorecardRevisionRequest(ref request, ref callSettings);
            return _callCreateQaScorecardRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QaScorecardRevision> CreateQaScorecardRevisionAsync(CreateQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateQaScorecardRevisionRequest(ref request, ref callSettings);
            return _callCreateQaScorecardRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QaScorecardRevision GetQaScorecardRevision(GetQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQaScorecardRevisionRequest(ref request, ref callSettings);
            return _callGetQaScorecardRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QaScorecardRevision> GetQaScorecardRevisionAsync(GetQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQaScorecardRevisionRequest(ref request, ref callSettings);
            return _callGetQaScorecardRevision.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>TuneQaScorecardRevision</c>.</summary>
        public override lro::OperationsClient TuneQaScorecardRevisionOperationsClient { get; }

        /// <summary>
        /// Fine tune one or more QaModels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata> TuneQaScorecardRevision(TuneQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TuneQaScorecardRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata>(_callTuneQaScorecardRevision.Sync(request, callSettings), TuneQaScorecardRevisionOperationsClient);
        }

        /// <summary>
        /// Fine tune one or more QaModels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata>> TuneQaScorecardRevisionAsync(TuneQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TuneQaScorecardRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<TuneQaScorecardRevisionResponse, TuneQaScorecardRevisionMetadata>(await _callTuneQaScorecardRevision.Async(request, callSettings).ConfigureAwait(false), TuneQaScorecardRevisionOperationsClient);
        }

        /// <summary>
        /// Deploy a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QaScorecardRevision DeployQaScorecardRevision(DeployQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployQaScorecardRevisionRequest(ref request, ref callSettings);
            return _callDeployQaScorecardRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Deploy a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QaScorecardRevision> DeployQaScorecardRevisionAsync(DeployQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployQaScorecardRevisionRequest(ref request, ref callSettings);
            return _callDeployQaScorecardRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Undeploy a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QaScorecardRevision UndeployQaScorecardRevision(UndeployQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployQaScorecardRevisionRequest(ref request, ref callSettings);
            return _callUndeployQaScorecardRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Undeploy a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QaScorecardRevision> UndeployQaScorecardRevisionAsync(UndeployQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployQaScorecardRevisionRequest(ref request, ref callSettings);
            return _callUndeployQaScorecardRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteQaScorecardRevision(DeleteQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteQaScorecardRevisionRequest(ref request, ref callSettings);
            _callDeleteQaScorecardRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a QaScorecardRevision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteQaScorecardRevisionAsync(DeleteQaScorecardRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteQaScorecardRevisionRequest(ref request, ref callSettings);
            return _callDeleteQaScorecardRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all revisions under the parent QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QaScorecardRevision"/> resources.</returns>
        public override gax::PagedEnumerable<ListQaScorecardRevisionsResponse, QaScorecardRevision> ListQaScorecardRevisions(ListQaScorecardRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQaScorecardRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListQaScorecardRevisionsRequest, ListQaScorecardRevisionsResponse, QaScorecardRevision>(_callListQaScorecardRevisions, request, callSettings);
        }

        /// <summary>
        /// Lists all revisions under the parent QaScorecard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QaScorecardRevision"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListQaScorecardRevisionsResponse, QaScorecardRevision> ListQaScorecardRevisionsAsync(ListQaScorecardRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQaScorecardRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListQaScorecardRevisionsRequest, ListQaScorecardRevisionsResponse, QaScorecardRevision>(_callListQaScorecardRevisions, request, callSettings);
        }

        /// <summary>
        /// Create feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FeedbackLabel CreateFeedbackLabel(CreateFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeedbackLabelRequest(ref request, ref callSettings);
            return _callCreateFeedbackLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Create feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FeedbackLabel> CreateFeedbackLabelAsync(CreateFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeedbackLabelRequest(ref request, ref callSettings);
            return _callCreateFeedbackLabel.Async(request, callSettings);
        }

        /// <summary>
        /// List feedback labels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public override gax::PagedEnumerable<ListFeedbackLabelsResponse, FeedbackLabel> ListFeedbackLabels(ListFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeedbackLabelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFeedbackLabelsRequest, ListFeedbackLabelsResponse, FeedbackLabel>(_callListFeedbackLabels, request, callSettings);
        }

        /// <summary>
        /// List feedback labels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFeedbackLabelsResponse, FeedbackLabel> ListFeedbackLabelsAsync(ListFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeedbackLabelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFeedbackLabelsRequest, ListFeedbackLabelsResponse, FeedbackLabel>(_callListFeedbackLabels, request, callSettings);
        }

        /// <summary>
        /// Get feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FeedbackLabel GetFeedbackLabel(GetFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedbackLabelRequest(ref request, ref callSettings);
            return _callGetFeedbackLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Get feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FeedbackLabel> GetFeedbackLabelAsync(GetFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedbackLabelRequest(ref request, ref callSettings);
            return _callGetFeedbackLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Update feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FeedbackLabel UpdateFeedbackLabel(UpdateFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeedbackLabelRequest(ref request, ref callSettings);
            return _callUpdateFeedbackLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Update feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FeedbackLabel> UpdateFeedbackLabelAsync(UpdateFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeedbackLabelRequest(ref request, ref callSettings);
            return _callUpdateFeedbackLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Delete feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteFeedbackLabel(DeleteFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeedbackLabelRequest(ref request, ref callSettings);
            _callDeleteFeedbackLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete feedback label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteFeedbackLabelAsync(DeleteFeedbackLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeedbackLabelRequest(ref request, ref callSettings);
            return _callDeleteFeedbackLabel.Async(request, callSettings);
        }

        /// <summary>
        /// List all feedback labels by project number.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public override gax::PagedEnumerable<ListAllFeedbackLabelsResponse, FeedbackLabel> ListAllFeedbackLabels(ListAllFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAllFeedbackLabelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAllFeedbackLabelsRequest, ListAllFeedbackLabelsResponse, FeedbackLabel>(_callListAllFeedbackLabels, request, callSettings);
        }

        /// <summary>
        /// List all feedback labels by project number.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedbackLabel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAllFeedbackLabelsResponse, FeedbackLabel> ListAllFeedbackLabelsAsync(ListAllFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAllFeedbackLabelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAllFeedbackLabelsRequest, ListAllFeedbackLabelsResponse, FeedbackLabel>(_callListAllFeedbackLabels, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BulkUploadFeedbackLabels</c>.</summary>
        public override lro::OperationsClient BulkUploadFeedbackLabelsOperationsClient { get; }

        /// <summary>
        /// Upload feedback labels in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata> BulkUploadFeedbackLabels(BulkUploadFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkUploadFeedbackLabelsRequest(ref request, ref callSettings);
            return new lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata>(_callBulkUploadFeedbackLabels.Sync(request, callSettings), BulkUploadFeedbackLabelsOperationsClient);
        }

        /// <summary>
        /// Upload feedback labels in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata>> BulkUploadFeedbackLabelsAsync(BulkUploadFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkUploadFeedbackLabelsRequest(ref request, ref callSettings);
            return new lro::Operation<BulkUploadFeedbackLabelsResponse, BulkUploadFeedbackLabelsMetadata>(await _callBulkUploadFeedbackLabels.Async(request, callSettings).ConfigureAwait(false), BulkUploadFeedbackLabelsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BulkDownloadFeedbackLabels</c>.</summary>
        public override lro::OperationsClient BulkDownloadFeedbackLabelsOperationsClient { get; }

        /// <summary>
        /// Download feedback labels in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata> BulkDownloadFeedbackLabels(BulkDownloadFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkDownloadFeedbackLabelsRequest(ref request, ref callSettings);
            return new lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata>(_callBulkDownloadFeedbackLabels.Sync(request, callSettings), BulkDownloadFeedbackLabelsOperationsClient);
        }

        /// <summary>
        /// Download feedback labels in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata>> BulkDownloadFeedbackLabelsAsync(BulkDownloadFeedbackLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkDownloadFeedbackLabelsRequest(ref request, ref callSettings);
            return new lro::Operation<BulkDownloadFeedbackLabelsResponse, BulkDownloadFeedbackLabelsMetadata>(await _callBulkDownloadFeedbackLabels.Async(request, callSettings).ConfigureAwait(false), BulkDownloadFeedbackLabelsOperationsClient);
        }
    }

    public partial class ListConversationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnalysesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPhraseMatchersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnalysisRulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListViewsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListQaQuestionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListQaScorecardsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListQaScorecardRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeedbackLabelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAllFeedbackLabelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConversationsResponse : gaxgrpc::IPageResponse<Conversation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Conversation> GetEnumerator() => Conversations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAnalysesResponse : gaxgrpc::IPageResponse<Analysis>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Analysis> GetEnumerator() => Analyses.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPhraseMatchersResponse : gaxgrpc::IPageResponse<PhraseMatcher>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PhraseMatcher> GetEnumerator() => PhraseMatchers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAnalysisRulesResponse : gaxgrpc::IPageResponse<AnalysisRule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AnalysisRule> GetEnumerator() => AnalysisRules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListViewsResponse : gaxgrpc::IPageResponse<View>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<View> GetEnumerator() => Views.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListQaQuestionsResponse : gaxgrpc::IPageResponse<QaQuestion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<QaQuestion> GetEnumerator() => QaQuestions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListQaScorecardsResponse : gaxgrpc::IPageResponse<QaScorecard>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<QaScorecard> GetEnumerator() => QaScorecards.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListQaScorecardRevisionsResponse : gaxgrpc::IPageResponse<QaScorecardRevision>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<QaScorecardRevision> GetEnumerator() => QaScorecardRevisions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFeedbackLabelsResponse : gaxgrpc::IPageResponse<FeedbackLabel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FeedbackLabel> GetEnumerator() => FeedbackLabels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAllFeedbackLabelsResponse : gaxgrpc::IPageResponse<FeedbackLabel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FeedbackLabel> GetEnumerator() => FeedbackLabels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ContactCenterInsights
    {
        public partial class ContactCenterInsightsClient
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

    public static partial class ContactCenterInsights
    {
        public partial class ContactCenterInsightsClient
        {
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
