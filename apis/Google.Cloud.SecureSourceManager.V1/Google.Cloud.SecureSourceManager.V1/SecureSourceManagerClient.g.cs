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

namespace Google.Cloud.SecureSourceManager.V1
{
    /// <summary>Settings for <see cref="SecureSourceManagerClient"/> instances.</summary>
    public sealed partial class SecureSourceManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SecureSourceManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SecureSourceManagerSettings"/>.</returns>
        public static SecureSourceManagerSettings GetDefault() => new SecureSourceManagerSettings();

        /// <summary>Constructs a new <see cref="SecureSourceManagerSettings"/> object with default settings.</summary>
        public SecureSourceManagerSettings()
        {
        }

        private SecureSourceManagerSettings(SecureSourceManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings.Clone();
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            DeleteInstanceOperationsSettings = existing.DeleteInstanceOperationsSettings.Clone();
            ListRepositoriesSettings = existing.ListRepositoriesSettings;
            GetRepositorySettings = existing.GetRepositorySettings;
            CreateRepositorySettings = existing.CreateRepositorySettings;
            CreateRepositoryOperationsSettings = existing.CreateRepositoryOperationsSettings.Clone();
            UpdateRepositorySettings = existing.UpdateRepositorySettings;
            UpdateRepositoryOperationsSettings = existing.UpdateRepositoryOperationsSettings.Clone();
            DeleteRepositorySettings = existing.DeleteRepositorySettings;
            DeleteRepositoryOperationsSettings = existing.DeleteRepositoryOperationsSettings.Clone();
            ListHooksSettings = existing.ListHooksSettings;
            GetHookSettings = existing.GetHookSettings;
            CreateHookSettings = existing.CreateHookSettings;
            CreateHookOperationsSettings = existing.CreateHookOperationsSettings.Clone();
            UpdateHookSettings = existing.UpdateHookSettings;
            UpdateHookOperationsSettings = existing.UpdateHookOperationsSettings.Clone();
            DeleteHookSettings = existing.DeleteHookSettings;
            DeleteHookOperationsSettings = existing.DeleteHookOperationsSettings.Clone();
            GetIamPolicyRepoSettings = existing.GetIamPolicyRepoSettings;
            SetIamPolicyRepoSettings = existing.SetIamPolicyRepoSettings;
            TestIamPermissionsRepoSettings = existing.TestIamPermissionsRepoSettings;
            CreateBranchRuleSettings = existing.CreateBranchRuleSettings;
            CreateBranchRuleOperationsSettings = existing.CreateBranchRuleOperationsSettings.Clone();
            ListBranchRulesSettings = existing.ListBranchRulesSettings;
            GetBranchRuleSettings = existing.GetBranchRuleSettings;
            UpdateBranchRuleSettings = existing.UpdateBranchRuleSettings;
            UpdateBranchRuleOperationsSettings = existing.UpdateBranchRuleOperationsSettings.Clone();
            DeleteBranchRuleSettings = existing.DeleteBranchRuleSettings;
            DeleteBranchRuleOperationsSettings = existing.DeleteBranchRuleOperationsSettings.Clone();
            CreatePullRequestSettings = existing.CreatePullRequestSettings;
            CreatePullRequestOperationsSettings = existing.CreatePullRequestOperationsSettings.Clone();
            GetPullRequestSettings = existing.GetPullRequestSettings;
            ListPullRequestsSettings = existing.ListPullRequestsSettings;
            UpdatePullRequestSettings = existing.UpdatePullRequestSettings;
            UpdatePullRequestOperationsSettings = existing.UpdatePullRequestOperationsSettings.Clone();
            MergePullRequestSettings = existing.MergePullRequestSettings;
            MergePullRequestOperationsSettings = existing.MergePullRequestOperationsSettings.Clone();
            OpenPullRequestSettings = existing.OpenPullRequestSettings;
            OpenPullRequestOperationsSettings = existing.OpenPullRequestOperationsSettings.Clone();
            ClosePullRequestSettings = existing.ClosePullRequestSettings;
            ClosePullRequestOperationsSettings = existing.ClosePullRequestOperationsSettings.Clone();
            ListPullRequestFileDiffsSettings = existing.ListPullRequestFileDiffsSettings;
            FetchTreeSettings = existing.FetchTreeSettings;
            FetchBlobSettings = existing.FetchBlobSettings;
            CreateIssueSettings = existing.CreateIssueSettings;
            CreateIssueOperationsSettings = existing.CreateIssueOperationsSettings.Clone();
            GetIssueSettings = existing.GetIssueSettings;
            ListIssuesSettings = existing.ListIssuesSettings;
            UpdateIssueSettings = existing.UpdateIssueSettings;
            UpdateIssueOperationsSettings = existing.UpdateIssueOperationsSettings.Clone();
            DeleteIssueSettings = existing.DeleteIssueSettings;
            DeleteIssueOperationsSettings = existing.DeleteIssueOperationsSettings.Clone();
            OpenIssueSettings = existing.OpenIssueSettings;
            OpenIssueOperationsSettings = existing.OpenIssueOperationsSettings.Clone();
            CloseIssueSettings = existing.CloseIssueSettings;
            CloseIssueOperationsSettings = existing.CloseIssueOperationsSettings.Clone();
            GetPullRequestCommentSettings = existing.GetPullRequestCommentSettings;
            ListPullRequestCommentsSettings = existing.ListPullRequestCommentsSettings;
            CreatePullRequestCommentSettings = existing.CreatePullRequestCommentSettings;
            CreatePullRequestCommentOperationsSettings = existing.CreatePullRequestCommentOperationsSettings.Clone();
            UpdatePullRequestCommentSettings = existing.UpdatePullRequestCommentSettings;
            UpdatePullRequestCommentOperationsSettings = existing.UpdatePullRequestCommentOperationsSettings.Clone();
            DeletePullRequestCommentSettings = existing.DeletePullRequestCommentSettings;
            DeletePullRequestCommentOperationsSettings = existing.DeletePullRequestCommentOperationsSettings.Clone();
            BatchCreatePullRequestCommentsSettings = existing.BatchCreatePullRequestCommentsSettings;
            BatchCreatePullRequestCommentsOperationsSettings = existing.BatchCreatePullRequestCommentsOperationsSettings.Clone();
            ResolvePullRequestCommentsSettings = existing.ResolvePullRequestCommentsSettings;
            ResolvePullRequestCommentsOperationsSettings = existing.ResolvePullRequestCommentsOperationsSettings.Clone();
            UnresolvePullRequestCommentsSettings = existing.UnresolvePullRequestCommentsSettings;
            UnresolvePullRequestCommentsOperationsSettings = existing.UnresolvePullRequestCommentsOperationsSettings.Clone();
            CreateIssueCommentSettings = existing.CreateIssueCommentSettings;
            CreateIssueCommentOperationsSettings = existing.CreateIssueCommentOperationsSettings.Clone();
            GetIssueCommentSettings = existing.GetIssueCommentSettings;
            ListIssueCommentsSettings = existing.ListIssueCommentsSettings;
            UpdateIssueCommentSettings = existing.UpdateIssueCommentSettings;
            UpdateIssueCommentOperationsSettings = existing.UpdateIssueCommentOperationsSettings.Clone();
            DeleteIssueCommentSettings = existing.DeleteIssueCommentSettings;
            DeleteIssueCommentOperationsSettings = existing.DeleteIssueCommentOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(SecureSourceManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.ListInstances</c> and <c>SecureSourceManagerClient.ListInstancesAsync</c>.
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
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.GetInstance</c> and <c>SecureSourceManagerClient.GetInstanceAsync</c>.
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
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.CreateInstance</c> and <c>SecureSourceManagerClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.CreateInstance</c> and
        /// <c>SecureSourceManagerClient.CreateInstanceAsync</c>.
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
        public lro::OperationsSettings CreateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.DeleteInstance</c> and <c>SecureSourceManagerClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.DeleteInstance</c> and
        /// <c>SecureSourceManagerClient.DeleteInstanceAsync</c>.
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
        public lro::OperationsSettings DeleteInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.ListRepositories</c> and <c>SecureSourceManagerClient.ListRepositoriesAsync</c>
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
        public gaxgrpc::CallSettings ListRepositoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.GetRepository</c> and <c>SecureSourceManagerClient.GetRepositoryAsync</c>.
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
        public gaxgrpc::CallSettings GetRepositorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.CreateRepository</c> and <c>SecureSourceManagerClient.CreateRepositoryAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.CreateRepository</c> and
        /// <c>SecureSourceManagerClient.CreateRepositoryAsync</c>.
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
        public lro::OperationsSettings CreateRepositoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.UpdateRepository</c> and <c>SecureSourceManagerClient.UpdateRepositoryAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.UpdateRepository</c> and
        /// <c>SecureSourceManagerClient.UpdateRepositoryAsync</c>.
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
        public lro::OperationsSettings UpdateRepositoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.DeleteRepository</c> and <c>SecureSourceManagerClient.DeleteRepositoryAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.DeleteRepository</c> and
        /// <c>SecureSourceManagerClient.DeleteRepositoryAsync</c>.
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
        public lro::OperationsSettings DeleteRepositoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.ListHooks</c> and <c>SecureSourceManagerClient.ListHooksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListHooksSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.GetHook</c> and <c>SecureSourceManagerClient.GetHookAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetHookSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.CreateHook</c> and <c>SecureSourceManagerClient.CreateHookAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateHookSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.CreateHook</c> and
        /// <c>SecureSourceManagerClient.CreateHookAsync</c>.
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
        public lro::OperationsSettings CreateHookOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.UpdateHook</c> and <c>SecureSourceManagerClient.UpdateHookAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateHookSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.UpdateHook</c> and
        /// <c>SecureSourceManagerClient.UpdateHookAsync</c>.
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
        public lro::OperationsSettings UpdateHookOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.DeleteHook</c> and <c>SecureSourceManagerClient.DeleteHookAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteHookSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.DeleteHook</c> and
        /// <c>SecureSourceManagerClient.DeleteHookAsync</c>.
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
        public lro::OperationsSettings DeleteHookOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.GetIamPolicyRepo</c> and <c>SecureSourceManagerClient.GetIamPolicyRepoAsync</c>
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
        public gaxgrpc::CallSettings GetIamPolicyRepoSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.SetIamPolicyRepo</c> and <c>SecureSourceManagerClient.SetIamPolicyRepoAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicyRepoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.TestIamPermissionsRepo</c> and
        /// <c>SecureSourceManagerClient.TestIamPermissionsRepoAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsRepoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.CreateBranchRule</c> and <c>SecureSourceManagerClient.CreateBranchRuleAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBranchRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.CreateBranchRule</c> and
        /// <c>SecureSourceManagerClient.CreateBranchRuleAsync</c>.
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
        public lro::OperationsSettings CreateBranchRuleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.ListBranchRules</c> and <c>SecureSourceManagerClient.ListBranchRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBranchRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.GetBranchRule</c> and <c>SecureSourceManagerClient.GetBranchRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBranchRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.UpdateBranchRule</c> and <c>SecureSourceManagerClient.UpdateBranchRuleAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBranchRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.UpdateBranchRule</c> and
        /// <c>SecureSourceManagerClient.UpdateBranchRuleAsync</c>.
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
        public lro::OperationsSettings UpdateBranchRuleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.DeleteBranchRule</c> and <c>SecureSourceManagerClient.DeleteBranchRuleAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBranchRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.DeleteBranchRule</c> and
        /// <c>SecureSourceManagerClient.DeleteBranchRuleAsync</c>.
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
        public lro::OperationsSettings DeleteBranchRuleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.CreatePullRequest</c> and <c>SecureSourceManagerClient.CreatePullRequestAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePullRequestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.CreatePullRequest</c> and
        /// <c>SecureSourceManagerClient.CreatePullRequestAsync</c>.
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
        public lro::OperationsSettings CreatePullRequestOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.GetPullRequest</c> and <c>SecureSourceManagerClient.GetPullRequestAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPullRequestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.ListPullRequests</c> and <c>SecureSourceManagerClient.ListPullRequestsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPullRequestsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.UpdatePullRequest</c> and <c>SecureSourceManagerClient.UpdatePullRequestAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePullRequestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.UpdatePullRequest</c> and
        /// <c>SecureSourceManagerClient.UpdatePullRequestAsync</c>.
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
        public lro::OperationsSettings UpdatePullRequestOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.MergePullRequest</c> and <c>SecureSourceManagerClient.MergePullRequestAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MergePullRequestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.MergePullRequest</c> and
        /// <c>SecureSourceManagerClient.MergePullRequestAsync</c>.
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
        public lro::OperationsSettings MergePullRequestOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.OpenPullRequest</c> and <c>SecureSourceManagerClient.OpenPullRequestAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings OpenPullRequestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.OpenPullRequest</c> and
        /// <c>SecureSourceManagerClient.OpenPullRequestAsync</c>.
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
        public lro::OperationsSettings OpenPullRequestOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.ClosePullRequest</c> and <c>SecureSourceManagerClient.ClosePullRequestAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ClosePullRequestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.ClosePullRequest</c> and
        /// <c>SecureSourceManagerClient.ClosePullRequestAsync</c>.
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
        public lro::OperationsSettings ClosePullRequestOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.ListPullRequestFileDiffs</c> and
        /// <c>SecureSourceManagerClient.ListPullRequestFileDiffsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPullRequestFileDiffsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.FetchTree</c> and <c>SecureSourceManagerClient.FetchTreeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchTreeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.FetchBlob</c> and <c>SecureSourceManagerClient.FetchBlobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchBlobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.CreateIssue</c> and <c>SecureSourceManagerClient.CreateIssueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateIssueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.CreateIssue</c> and
        /// <c>SecureSourceManagerClient.CreateIssueAsync</c>.
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
        public lro::OperationsSettings CreateIssueOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.GetIssue</c> and <c>SecureSourceManagerClient.GetIssueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIssueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.ListIssues</c> and <c>SecureSourceManagerClient.ListIssuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListIssuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.UpdateIssue</c> and <c>SecureSourceManagerClient.UpdateIssueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateIssueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.UpdateIssue</c> and
        /// <c>SecureSourceManagerClient.UpdateIssueAsync</c>.
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
        public lro::OperationsSettings UpdateIssueOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.DeleteIssue</c> and <c>SecureSourceManagerClient.DeleteIssueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteIssueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.DeleteIssue</c> and
        /// <c>SecureSourceManagerClient.DeleteIssueAsync</c>.
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
        public lro::OperationsSettings DeleteIssueOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.OpenIssue</c> and <c>SecureSourceManagerClient.OpenIssueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings OpenIssueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.OpenIssue</c> and
        /// <c>SecureSourceManagerClient.OpenIssueAsync</c>.
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
        public lro::OperationsSettings OpenIssueOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.CloseIssue</c> and <c>SecureSourceManagerClient.CloseIssueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CloseIssueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.CloseIssue</c> and
        /// <c>SecureSourceManagerClient.CloseIssueAsync</c>.
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
        public lro::OperationsSettings CloseIssueOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.GetPullRequestComment</c> and
        /// <c>SecureSourceManagerClient.GetPullRequestCommentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPullRequestCommentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.ListPullRequestComments</c> and
        /// <c>SecureSourceManagerClient.ListPullRequestCommentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPullRequestCommentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.CreatePullRequestComment</c> and
        /// <c>SecureSourceManagerClient.CreatePullRequestCommentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePullRequestCommentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.CreatePullRequestComment</c> and
        /// <c>SecureSourceManagerClient.CreatePullRequestCommentAsync</c>.
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
        public lro::OperationsSettings CreatePullRequestCommentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.UpdatePullRequestComment</c> and
        /// <c>SecureSourceManagerClient.UpdatePullRequestCommentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePullRequestCommentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.UpdatePullRequestComment</c> and
        /// <c>SecureSourceManagerClient.UpdatePullRequestCommentAsync</c>.
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
        public lro::OperationsSettings UpdatePullRequestCommentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.DeletePullRequestComment</c> and
        /// <c>SecureSourceManagerClient.DeletePullRequestCommentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePullRequestCommentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.DeletePullRequestComment</c> and
        /// <c>SecureSourceManagerClient.DeletePullRequestCommentAsync</c>.
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
        public lro::OperationsSettings DeletePullRequestCommentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.BatchCreatePullRequestComments</c> and
        /// <c>SecureSourceManagerClient.BatchCreatePullRequestCommentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreatePullRequestCommentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.BatchCreatePullRequestComments</c>
        /// and <c>SecureSourceManagerClient.BatchCreatePullRequestCommentsAsync</c>.
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
        public lro::OperationsSettings BatchCreatePullRequestCommentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.ResolvePullRequestComments</c> and
        /// <c>SecureSourceManagerClient.ResolvePullRequestCommentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResolvePullRequestCommentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.ResolvePullRequestComments</c> and
        /// <c>SecureSourceManagerClient.ResolvePullRequestCommentsAsync</c>.
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
        public lro::OperationsSettings ResolvePullRequestCommentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.UnresolvePullRequestComments</c> and
        /// <c>SecureSourceManagerClient.UnresolvePullRequestCommentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UnresolvePullRequestCommentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.UnresolvePullRequestComments</c>
        /// and <c>SecureSourceManagerClient.UnresolvePullRequestCommentsAsync</c>.
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
        public lro::OperationsSettings UnresolvePullRequestCommentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.CreateIssueComment</c> and <c>SecureSourceManagerClient.CreateIssueCommentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateIssueCommentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.CreateIssueComment</c> and
        /// <c>SecureSourceManagerClient.CreateIssueCommentAsync</c>.
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
        public lro::OperationsSettings CreateIssueCommentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.GetIssueComment</c> and <c>SecureSourceManagerClient.GetIssueCommentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIssueCommentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.ListIssueComments</c> and <c>SecureSourceManagerClient.ListIssueCommentsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListIssueCommentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.UpdateIssueComment</c> and <c>SecureSourceManagerClient.UpdateIssueCommentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateIssueCommentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.UpdateIssueComment</c> and
        /// <c>SecureSourceManagerClient.UpdateIssueCommentAsync</c>.
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
        public lro::OperationsSettings UpdateIssueCommentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecureSourceManagerClient.DeleteIssueComment</c> and <c>SecureSourceManagerClient.DeleteIssueCommentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteIssueCommentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecureSourceManagerClient.DeleteIssueComment</c> and
        /// <c>SecureSourceManagerClient.DeleteIssueCommentAsync</c>.
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
        public lro::OperationsSettings DeleteIssueCommentOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="SecureSourceManagerSettings"/> object.</returns>
        public SecureSourceManagerSettings Clone() => new SecureSourceManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SecureSourceManagerClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SecureSourceManagerClientBuilder : gaxgrpc::ClientBuilderBase<SecureSourceManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SecureSourceManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SecureSourceManagerClientBuilder() : base(SecureSourceManagerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SecureSourceManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SecureSourceManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SecureSourceManagerClient Build()
        {
            SecureSourceManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SecureSourceManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SecureSourceManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SecureSourceManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SecureSourceManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SecureSourceManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SecureSourceManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SecureSourceManagerClient.ChannelPool;
    }

    /// <summary>SecureSourceManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Secure Source Manager API
    /// 
    /// Access Secure Source Manager instances, resources, and repositories.
    /// </remarks>
    public abstract partial class SecureSourceManagerClient
    {
        /// <summary>
        /// The default endpoint for the SecureSourceManager service, which is a host of
        /// "securesourcemanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "securesourcemanager.googleapis.com:443";

        /// <summary>The default SecureSourceManager scopes.</summary>
        /// <remarks>
        /// The default SecureSourceManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SecureSourceManager.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SecureSourceManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="SecureSourceManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SecureSourceManagerClient"/>.</returns>
        public static stt::Task<SecureSourceManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SecureSourceManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SecureSourceManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="SecureSourceManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SecureSourceManagerClient"/>.</returns>
        public static SecureSourceManagerClient Create() => new SecureSourceManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SecureSourceManagerClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SecureSourceManagerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SecureSourceManagerClient"/>.</returns>
        internal static SecureSourceManagerClient Create(grpccore::CallInvoker callInvoker, SecureSourceManagerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SecureSourceManager.SecureSourceManagerClient grpcClient = new SecureSourceManager.SecureSourceManagerClient(callInvoker);
            return new SecureSourceManagerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SecureSourceManager client</summary>
        public virtual SecureSourceManager.SecureSourceManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public virtual lro::OperationsClient CreateInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceCreateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceCreateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created.
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the instance to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(string parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created.
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the instance to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created.
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the instance to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created.
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the instance to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(gagr::LocationName parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created.
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the instance to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(gagr::LocationName parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created.
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the instance to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(gagr::LocationName parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public virtual lro::OperationsClient DeleteInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Repositories in a given project and location.
        /// 
        /// The instance field is required in the query parameter for requests using
        /// the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Repositories in a given project and location.
        /// 
        /// The instance field is required in the query parameter for requests using
        /// the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Repositories in a given project and location.
        /// 
        /// The instance field is required in the query parameter for requests using
        /// the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRepositoriesRequest.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRepositoriesRequest request = new ListRepositoriesRequest
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
            return ListRepositories(request, callSettings);
        }

        /// <summary>
        /// Lists Repositories in a given project and location.
        /// 
        /// The instance field is required in the query parameter for requests using
        /// the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRepositoriesRequest.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRepositoriesRequest request = new ListRepositoriesRequest
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
            return ListRepositoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Repositories in a given project and location.
        /// 
        /// The instance field is required in the query parameter for requests using
        /// the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRepositoriesRequest.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRepositoriesRequest request = new ListRepositoriesRequest
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
            return ListRepositories(request, callSettings);
        }

        /// <summary>
        /// Lists Repositories in a given project and location.
        /// 
        /// The instance field is required in the query parameter for requests using
        /// the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRepositoriesRequest.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRepositoriesRequest request = new ListRepositoriesRequest
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
            return ListRepositoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets metadata of a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata of a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata of a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata of a repository.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepository(new GetRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata of a repository.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepositoryAsync(new GetRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata of a repository.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata of a repository.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepository(new GetRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata of a repository.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepositoryAsync(new GetRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata of a repository.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(RepositoryName name, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new repository in a given project and location.
        /// 
        /// The Repository.Instance field is required in the request body for requests
        /// using the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> CreateRepository(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new repository in a given project and location.
        /// 
        /// The Repository.Instance field is required in the request body for requests
        /// using the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new repository in a given project and location.
        /// 
        /// The Repository.Instance field is required in the request body for requests
        /// using the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(CreateRepositoryRequest request, st::CancellationToken cancellationToken) =>
            CreateRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRepository</c>.</summary>
        public virtual lro::OperationsClient CreateRepositoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> PollOnceCreateRepository(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Repository, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> PollOnceCreateRepositoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Repository, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Creates a new repository in a given project and location.
        /// 
        /// The Repository.Instance field is required in the request body for requests
        /// using the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which to create the repository. Values are of the
        /// form `projects/{project_number}/locations/{location_id}`
        /// </param>
        /// <param name="repository">
        /// Required. The resource being created.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This value should be 4-63
        /// characters, and valid characters are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> CreateRepository(string parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepository(new CreateRepositoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
            }, callSettings);

        /// <summary>
        /// Creates a new repository in a given project and location.
        /// 
        /// The Repository.Instance field is required in the request body for requests
        /// using the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which to create the repository. Values are of the
        /// form `projects/{project_number}/locations/{location_id}`
        /// </param>
        /// <param name="repository">
        /// Required. The resource being created.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This value should be 4-63
        /// characters, and valid characters are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(string parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepositoryAsync(new CreateRepositoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
            }, callSettings);

        /// <summary>
        /// Creates a new repository in a given project and location.
        /// 
        /// The Repository.Instance field is required in the request body for requests
        /// using the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which to create the repository. Values are of the
        /// form `projects/{project_number}/locations/{location_id}`
        /// </param>
        /// <param name="repository">
        /// Required. The resource being created.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This value should be 4-63
        /// characters, and valid characters are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(string parent, Repository repository, string repositoryId, st::CancellationToken cancellationToken) =>
            CreateRepositoryAsync(parent, repository, repositoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new repository in a given project and location.
        /// 
        /// The Repository.Instance field is required in the request body for requests
        /// using the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which to create the repository. Values are of the
        /// form `projects/{project_number}/locations/{location_id}`
        /// </param>
        /// <param name="repository">
        /// Required. The resource being created.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This value should be 4-63
        /// characters, and valid characters are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> CreateRepository(gagr::LocationName parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepository(new CreateRepositoryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
            }, callSettings);

        /// <summary>
        /// Creates a new repository in a given project and location.
        /// 
        /// The Repository.Instance field is required in the request body for requests
        /// using the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which to create the repository. Values are of the
        /// form `projects/{project_number}/locations/{location_id}`
        /// </param>
        /// <param name="repository">
        /// Required. The resource being created.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This value should be 4-63
        /// characters, and valid characters are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(gagr::LocationName parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepositoryAsync(new CreateRepositoryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
            }, callSettings);

        /// <summary>
        /// Creates a new repository in a given project and location.
        /// 
        /// The Repository.Instance field is required in the request body for requests
        /// using the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which to create the repository. Values are of the
        /// form `projects/{project_number}/locations/{location_id}`
        /// </param>
        /// <param name="repository">
        /// Required. The resource being created.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This value should be 4-63
        /// characters, and valid characters are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(gagr::LocationName parent, Repository repository, string repositoryId, st::CancellationToken cancellationToken) =>
            CreateRepositoryAsync(parent, repository, repositoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the metadata of a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> UpdateRepository(UpdateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata of a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> UpdateRepositoryAsync(UpdateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata of a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> UpdateRepositoryAsync(UpdateRepositoryRequest request, st::CancellationToken cancellationToken) =>
            UpdateRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateRepository</c>.</summary>
        public virtual lro::OperationsClient UpdateRepositoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> PollOnceUpdateRepository(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Repository, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> PollOnceUpdateRepositoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Repository, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Updates the metadata of a repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The repository being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// repository resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> UpdateRepository(Repository repository, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRepository(new UpdateRepositoryRequest
            {
                UpdateMask = updateMask,
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Updates the metadata of a repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The repository being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// repository resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> UpdateRepositoryAsync(Repository repository, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRepositoryAsync(new UpdateRepositoryRequest
            {
                UpdateMask = updateMask,
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Updates the metadata of a repository.
        /// </summary>
        /// <param name="repository">
        /// Required. The repository being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// repository resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> UpdateRepositoryAsync(Repository repository, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRepositoryAsync(repository, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRepository(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(DeleteRepositoryRequest request, st::CancellationToken cancellationToken) =>
            DeleteRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRepository</c>.</summary>
        public virtual lro::OperationsClient DeleteRepositoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteRepository(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteRepositoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Repository.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRepository(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepository(new DeleteRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Repository.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepositoryAsync(new DeleteRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Repository.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Repository.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRepository(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepository(new DeleteRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Repository.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepositoryAsync(new DeleteRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Repository.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(RepositoryName name, st::CancellationToken cancellationToken) =>
            DeleteRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists hooks in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Hook"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHooksResponse, Hook> ListHooks(ListHooksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists hooks in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Hook"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHooksResponse, Hook> ListHooksAsync(ListHooksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists hooks in a given repository.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListHooksRequest.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Hook"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHooksResponse, Hook> ListHooks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHooksRequest request = new ListHooksRequest
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
            return ListHooks(request, callSettings);
        }

        /// <summary>
        /// Lists hooks in a given repository.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListHooksRequest.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Hook"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHooksResponse, Hook> ListHooksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHooksRequest request = new ListHooksRequest
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
            return ListHooksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists hooks in a given repository.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListHooksRequest.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Hook"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHooksResponse, Hook> ListHooks(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHooksRequest request = new ListHooksRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListHooks(request, callSettings);
        }

        /// <summary>
        /// Lists hooks in a given repository.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListHooksRequest.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Hook"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHooksResponse, Hook> ListHooksAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHooksRequest request = new ListHooksRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListHooksAsync(request, callSettings);
        }

        /// <summary>
        /// Gets metadata of a hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Hook GetHook(GetHookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata of a hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hook> GetHookAsync(GetHookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata of a hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hook> GetHookAsync(GetHookRequest request, st::CancellationToken cancellationToken) =>
            GetHookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata of a hook.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hook to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Hook GetHook(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHook(new GetHookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata of a hook.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hook to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hook> GetHookAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHookAsync(new GetHookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata of a hook.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hook to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hook> GetHookAsync(string name, st::CancellationToken cancellationToken) =>
            GetHookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata of a hook.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hook to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Hook GetHook(HookName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHook(new GetHookRequest
            {
                HookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata of a hook.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hook to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hook> GetHookAsync(HookName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHookAsync(new GetHookRequest
            {
                HookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata of a hook.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hook to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hook> GetHookAsync(HookName name, st::CancellationToken cancellationToken) =>
            GetHookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new hook in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hook, OperationMetadata> CreateHook(CreateHookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new hook in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hook, OperationMetadata>> CreateHookAsync(CreateHookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new hook in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hook, OperationMetadata>> CreateHookAsync(CreateHookRequest request, st::CancellationToken cancellationToken) =>
            CreateHookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateHook</c>.</summary>
        public virtual lro::OperationsClient CreateHookOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateHook</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Hook, OperationMetadata> PollOnceCreateHook(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hook, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHookOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateHook</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Hook, OperationMetadata>> PollOnceCreateHookAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hook, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHookOperationsClient, callSettings);

        /// <summary>
        /// Creates a new hook in a given repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the hook. Values are of the
        /// form
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="hook">
        /// Required. The resource being created.
        /// </param>
        /// <param name="hookId">
        /// Required. The ID to use for the hook, which will become the final component
        /// of the hook's resource name. This value restricts to lower-case letters,
        /// numbers, and hyphen, with the first character a letter, the last a letter
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hook, OperationMetadata> CreateHook(string parent, Hook hook, string hookId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHook(new CreateHookRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Hook = gax::GaxPreconditions.CheckNotNull(hook, nameof(hook)),
                HookId = gax::GaxPreconditions.CheckNotNullOrEmpty(hookId, nameof(hookId)),
            }, callSettings);

        /// <summary>
        /// Creates a new hook in a given repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the hook. Values are of the
        /// form
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="hook">
        /// Required. The resource being created.
        /// </param>
        /// <param name="hookId">
        /// Required. The ID to use for the hook, which will become the final component
        /// of the hook's resource name. This value restricts to lower-case letters,
        /// numbers, and hyphen, with the first character a letter, the last a letter
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hook, OperationMetadata>> CreateHookAsync(string parent, Hook hook, string hookId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHookAsync(new CreateHookRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Hook = gax::GaxPreconditions.CheckNotNull(hook, nameof(hook)),
                HookId = gax::GaxPreconditions.CheckNotNullOrEmpty(hookId, nameof(hookId)),
            }, callSettings);

        /// <summary>
        /// Creates a new hook in a given repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the hook. Values are of the
        /// form
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="hook">
        /// Required. The resource being created.
        /// </param>
        /// <param name="hookId">
        /// Required. The ID to use for the hook, which will become the final component
        /// of the hook's resource name. This value restricts to lower-case letters,
        /// numbers, and hyphen, with the first character a letter, the last a letter
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hook, OperationMetadata>> CreateHookAsync(string parent, Hook hook, string hookId, st::CancellationToken cancellationToken) =>
            CreateHookAsync(parent, hook, hookId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new hook in a given repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the hook. Values are of the
        /// form
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="hook">
        /// Required. The resource being created.
        /// </param>
        /// <param name="hookId">
        /// Required. The ID to use for the hook, which will become the final component
        /// of the hook's resource name. This value restricts to lower-case letters,
        /// numbers, and hyphen, with the first character a letter, the last a letter
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hook, OperationMetadata> CreateHook(RepositoryName parent, Hook hook, string hookId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHook(new CreateHookRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Hook = gax::GaxPreconditions.CheckNotNull(hook, nameof(hook)),
                HookId = gax::GaxPreconditions.CheckNotNullOrEmpty(hookId, nameof(hookId)),
            }, callSettings);

        /// <summary>
        /// Creates a new hook in a given repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the hook. Values are of the
        /// form
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="hook">
        /// Required. The resource being created.
        /// </param>
        /// <param name="hookId">
        /// Required. The ID to use for the hook, which will become the final component
        /// of the hook's resource name. This value restricts to lower-case letters,
        /// numbers, and hyphen, with the first character a letter, the last a letter
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hook, OperationMetadata>> CreateHookAsync(RepositoryName parent, Hook hook, string hookId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHookAsync(new CreateHookRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Hook = gax::GaxPreconditions.CheckNotNull(hook, nameof(hook)),
                HookId = gax::GaxPreconditions.CheckNotNullOrEmpty(hookId, nameof(hookId)),
            }, callSettings);

        /// <summary>
        /// Creates a new hook in a given repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the hook. Values are of the
        /// form
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="hook">
        /// Required. The resource being created.
        /// </param>
        /// <param name="hookId">
        /// Required. The ID to use for the hook, which will become the final component
        /// of the hook's resource name. This value restricts to lower-case letters,
        /// numbers, and hyphen, with the first character a letter, the last a letter
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hook, OperationMetadata>> CreateHookAsync(RepositoryName parent, Hook hook, string hookId, st::CancellationToken cancellationToken) =>
            CreateHookAsync(parent, hook, hookId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the metadata of a hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hook, OperationMetadata> UpdateHook(UpdateHookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata of a hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hook, OperationMetadata>> UpdateHookAsync(UpdateHookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata of a hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hook, OperationMetadata>> UpdateHookAsync(UpdateHookRequest request, st::CancellationToken cancellationToken) =>
            UpdateHookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateHook</c>.</summary>
        public virtual lro::OperationsClient UpdateHookOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateHook</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Hook, OperationMetadata> PollOnceUpdateHook(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hook, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateHookOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateHook</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Hook, OperationMetadata>> PollOnceUpdateHookAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hook, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateHookOperationsClient, callSettings);

        /// <summary>
        /// Updates the metadata of a hook.
        /// </summary>
        /// <param name="hook">
        /// Required. The hook being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// hook resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hook, OperationMetadata> UpdateHook(Hook hook, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHook(new UpdateHookRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Hook = gax::GaxPreconditions.CheckNotNull(hook, nameof(hook)),
            }, callSettings);

        /// <summary>
        /// Updates the metadata of a hook.
        /// </summary>
        /// <param name="hook">
        /// Required. The hook being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// hook resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hook, OperationMetadata>> UpdateHookAsync(Hook hook, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHookAsync(new UpdateHookRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Hook = gax::GaxPreconditions.CheckNotNull(hook, nameof(hook)),
            }, callSettings);

        /// <summary>
        /// Updates the metadata of a hook.
        /// </summary>
        /// <param name="hook">
        /// Required. The hook being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// hook resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hook, OperationMetadata>> UpdateHookAsync(Hook hook, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateHookAsync(hook, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHook(DeleteHookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHookAsync(DeleteHookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHookAsync(DeleteHookRequest request, st::CancellationToken cancellationToken) =>
            DeleteHookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteHook</c>.</summary>
        public virtual lro::OperationsClient DeleteHookOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteHook</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteHook(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHookOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteHook</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteHookAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHookOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Hook.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hook to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHook(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHook(new DeleteHookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Hook.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hook to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHookAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHookAsync(new DeleteHookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Hook.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hook to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHookAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteHookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Hook.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hook to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHook(HookName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHook(new DeleteHookRequest
            {
                HookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Hook.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hook to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHookAsync(HookName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHookAsync(new DeleteHookRequest
            {
                HookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Hook.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hook to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHookAsync(HookName name, st::CancellationToken cancellationToken) =>
            DeleteHookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get IAM policy for a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicyRepo(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get IAM policy for a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyRepoAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get IAM policy for a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyRepoAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyRepoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get IAM policy for a repository.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicyRepo(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyRepo(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Get IAM policy for a repository.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyRepoAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyRepoAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Get IAM policy for a repository.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyRepoAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyRepoAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get IAM policy for a repository.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicyRepo(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyRepo(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Get IAM policy for a repository.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyRepoAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyRepoAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Get IAM policy for a repository.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyRepoAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyRepoAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Set IAM policy on a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicyRepo(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Set IAM policy on a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyRepoAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Set IAM policy on a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyRepoAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyRepoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Set IAM policy on a repository.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicyRepo(string resource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyRepo(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Set IAM policy on a repository.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyRepoAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyRepoAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Set IAM policy on a repository.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyRepoAsync(string resource, st::CancellationToken cancellationToken) =>
            SetIamPolicyRepoAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Set IAM policy on a repository.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicyRepo(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyRepo(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Set IAM policy on a repository.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyRepoAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyRepoAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Set IAM policy on a repository.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyRepoAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            SetIamPolicyRepoAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Test IAM permissions on a repository.
        /// IAM permission checks are not required on this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissionsRepo(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Test IAM permissions on a repository.
        /// IAM permission checks are not required on this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsRepoAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Test IAM permissions on a repository.
        /// IAM permission checks are not required on this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsRepoAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsRepoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Test IAM permissions on a repository.
        /// IAM permission checks are not required on this method.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissionsRepo(string resource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsRepo(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Test IAM permissions on a repository.
        /// IAM permission checks are not required on this method.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsRepoAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsRepoAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Test IAM permissions on a repository.
        /// IAM permission checks are not required on this method.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsRepoAsync(string resource, st::CancellationToken cancellationToken) =>
            TestIamPermissionsRepoAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Test IAM permissions on a repository.
        /// IAM permission checks are not required on this method.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissionsRepo(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsRepo(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Test IAM permissions on a repository.
        /// IAM permission checks are not required on this method.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsRepoAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsRepoAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Test IAM permissions on a repository.
        /// IAM permission checks are not required on this method.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsRepoAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            TestIamPermissionsRepoAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CreateBranchRule creates a branch rule in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BranchRule, OperationMetadata> CreateBranchRule(CreateBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateBranchRule creates a branch rule in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BranchRule, OperationMetadata>> CreateBranchRuleAsync(CreateBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateBranchRule creates a branch rule in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BranchRule, OperationMetadata>> CreateBranchRuleAsync(CreateBranchRuleRequest request, st::CancellationToken cancellationToken) =>
            CreateBranchRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateBranchRule</c>.</summary>
        public virtual lro::OperationsClient CreateBranchRuleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateBranchRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BranchRule, OperationMetadata> PollOnceCreateBranchRule(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BranchRule, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBranchRuleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBranchRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BranchRule, OperationMetadata>> PollOnceCreateBranchRuleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BranchRule, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBranchRuleOperationsClient, callSettings);

        /// <summary>
        /// CreateBranchRule creates a branch rule in a given repository.
        /// </summary>
        /// <param name="parent">
        /// </param>
        /// <param name="branchRule">
        /// </param>
        /// <param name="branchRuleId">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BranchRule, OperationMetadata> CreateBranchRule(string parent, BranchRule branchRule, string branchRuleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBranchRule(new CreateBranchRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BranchRule = gax::GaxPreconditions.CheckNotNull(branchRule, nameof(branchRule)),
                BranchRuleId = gax::GaxPreconditions.CheckNotNullOrEmpty(branchRuleId, nameof(branchRuleId)),
            }, callSettings);

        /// <summary>
        /// CreateBranchRule creates a branch rule in a given repository.
        /// </summary>
        /// <param name="parent">
        /// </param>
        /// <param name="branchRule">
        /// </param>
        /// <param name="branchRuleId">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BranchRule, OperationMetadata>> CreateBranchRuleAsync(string parent, BranchRule branchRule, string branchRuleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBranchRuleAsync(new CreateBranchRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BranchRule = gax::GaxPreconditions.CheckNotNull(branchRule, nameof(branchRule)),
                BranchRuleId = gax::GaxPreconditions.CheckNotNullOrEmpty(branchRuleId, nameof(branchRuleId)),
            }, callSettings);

        /// <summary>
        /// CreateBranchRule creates a branch rule in a given repository.
        /// </summary>
        /// <param name="parent">
        /// </param>
        /// <param name="branchRule">
        /// </param>
        /// <param name="branchRuleId">
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BranchRule, OperationMetadata>> CreateBranchRuleAsync(string parent, BranchRule branchRule, string branchRuleId, st::CancellationToken cancellationToken) =>
            CreateBranchRuleAsync(parent, branchRule, branchRuleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CreateBranchRule creates a branch rule in a given repository.
        /// </summary>
        /// <param name="parent">
        /// </param>
        /// <param name="branchRule">
        /// </param>
        /// <param name="branchRuleId">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BranchRule, OperationMetadata> CreateBranchRule(RepositoryName parent, BranchRule branchRule, string branchRuleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBranchRule(new CreateBranchRuleRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BranchRule = gax::GaxPreconditions.CheckNotNull(branchRule, nameof(branchRule)),
                BranchRuleId = gax::GaxPreconditions.CheckNotNullOrEmpty(branchRuleId, nameof(branchRuleId)),
            }, callSettings);

        /// <summary>
        /// CreateBranchRule creates a branch rule in a given repository.
        /// </summary>
        /// <param name="parent">
        /// </param>
        /// <param name="branchRule">
        /// </param>
        /// <param name="branchRuleId">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BranchRule, OperationMetadata>> CreateBranchRuleAsync(RepositoryName parent, BranchRule branchRule, string branchRuleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBranchRuleAsync(new CreateBranchRuleRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BranchRule = gax::GaxPreconditions.CheckNotNull(branchRule, nameof(branchRule)),
                BranchRuleId = gax::GaxPreconditions.CheckNotNullOrEmpty(branchRuleId, nameof(branchRuleId)),
            }, callSettings);

        /// <summary>
        /// CreateBranchRule creates a branch rule in a given repository.
        /// </summary>
        /// <param name="parent">
        /// </param>
        /// <param name="branchRule">
        /// </param>
        /// <param name="branchRuleId">
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BranchRule, OperationMetadata>> CreateBranchRuleAsync(RepositoryName parent, BranchRule branchRule, string branchRuleId, st::CancellationToken cancellationToken) =>
            CreateBranchRuleAsync(parent, branchRule, branchRuleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// ListBranchRules lists branch rules in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BranchRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBranchRulesResponse, BranchRule> ListBranchRules(ListBranchRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ListBranchRules lists branch rules in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BranchRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBranchRulesResponse, BranchRule> ListBranchRulesAsync(ListBranchRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ListBranchRules lists branch rules in a given repository.
        /// </summary>
        /// <param name="parent">
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BranchRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBranchRulesResponse, BranchRule> ListBranchRules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBranchRulesRequest request = new ListBranchRulesRequest
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
            return ListBranchRules(request, callSettings);
        }

        /// <summary>
        /// ListBranchRules lists branch rules in a given repository.
        /// </summary>
        /// <param name="parent">
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BranchRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBranchRulesResponse, BranchRule> ListBranchRulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBranchRulesRequest request = new ListBranchRulesRequest
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
            return ListBranchRulesAsync(request, callSettings);
        }

        /// <summary>
        /// ListBranchRules lists branch rules in a given repository.
        /// </summary>
        /// <param name="parent">
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BranchRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBranchRulesResponse, BranchRule> ListBranchRules(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBranchRulesRequest request = new ListBranchRulesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBranchRules(request, callSettings);
        }

        /// <summary>
        /// ListBranchRules lists branch rules in a given repository.
        /// </summary>
        /// <param name="parent">
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BranchRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBranchRulesResponse, BranchRule> ListBranchRulesAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBranchRulesRequest request = new ListBranchRulesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBranchRulesAsync(request, callSettings);
        }

        /// <summary>
        /// GetBranchRule gets a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BranchRule GetBranchRule(GetBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GetBranchRule gets a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BranchRule> GetBranchRuleAsync(GetBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GetBranchRule gets a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BranchRule> GetBranchRuleAsync(GetBranchRuleRequest request, st::CancellationToken cancellationToken) =>
            GetBranchRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// GetBranchRule gets a branch rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BranchRule GetBranchRule(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBranchRule(new GetBranchRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// GetBranchRule gets a branch rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BranchRule> GetBranchRuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBranchRuleAsync(new GetBranchRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// GetBranchRule gets a branch rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BranchRule> GetBranchRuleAsync(string name, st::CancellationToken cancellationToken) =>
            GetBranchRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// GetBranchRule gets a branch rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BranchRule GetBranchRule(BranchRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBranchRule(new GetBranchRuleRequest
            {
                BranchRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// GetBranchRule gets a branch rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BranchRule> GetBranchRuleAsync(BranchRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBranchRuleAsync(new GetBranchRuleRequest
            {
                BranchRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// GetBranchRule gets a branch rule.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the repository to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BranchRule> GetBranchRuleAsync(BranchRuleName name, st::CancellationToken cancellationToken) =>
            GetBranchRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// UpdateBranchRule updates a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BranchRule, OperationMetadata> UpdateBranchRule(UpdateBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// UpdateBranchRule updates a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BranchRule, OperationMetadata>> UpdateBranchRuleAsync(UpdateBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// UpdateBranchRule updates a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BranchRule, OperationMetadata>> UpdateBranchRuleAsync(UpdateBranchRuleRequest request, st::CancellationToken cancellationToken) =>
            UpdateBranchRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateBranchRule</c>.</summary>
        public virtual lro::OperationsClient UpdateBranchRuleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateBranchRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BranchRule, OperationMetadata> PollOnceUpdateBranchRule(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BranchRule, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBranchRuleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateBranchRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BranchRule, OperationMetadata>> PollOnceUpdateBranchRuleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BranchRule, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBranchRuleOperationsClient, callSettings);

        /// <summary>
        /// UpdateBranchRule updates a branch rule.
        /// </summary>
        /// <param name="branchRule">
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// branchRule resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BranchRule, OperationMetadata> UpdateBranchRule(BranchRule branchRule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBranchRule(new UpdateBranchRuleRequest
            {
                BranchRule = gax::GaxPreconditions.CheckNotNull(branchRule, nameof(branchRule)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// UpdateBranchRule updates a branch rule.
        /// </summary>
        /// <param name="branchRule">
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// branchRule resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BranchRule, OperationMetadata>> UpdateBranchRuleAsync(BranchRule branchRule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBranchRuleAsync(new UpdateBranchRuleRequest
            {
                BranchRule = gax::GaxPreconditions.CheckNotNull(branchRule, nameof(branchRule)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// UpdateBranchRule updates a branch rule.
        /// </summary>
        /// <param name="branchRule">
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// branchRule resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BranchRule, OperationMetadata>> UpdateBranchRuleAsync(BranchRule branchRule, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBranchRuleAsync(branchRule, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// DeleteBranchRule deletes a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBranchRule(DeleteBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// DeleteBranchRule deletes a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBranchRuleAsync(DeleteBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// DeleteBranchRule deletes a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBranchRuleAsync(DeleteBranchRuleRequest request, st::CancellationToken cancellationToken) =>
            DeleteBranchRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteBranchRule</c>.</summary>
        public virtual lro::OperationsClient DeleteBranchRuleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteBranchRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteBranchRule(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBranchRuleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBranchRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteBranchRuleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBranchRuleOperationsClient, callSettings);

        /// <summary>
        /// DeleteBranchRule deletes a branch rule.
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBranchRule(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBranchRule(new DeleteBranchRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// DeleteBranchRule deletes a branch rule.
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBranchRuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBranchRuleAsync(new DeleteBranchRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// DeleteBranchRule deletes a branch rule.
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBranchRuleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBranchRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// DeleteBranchRule deletes a branch rule.
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBranchRule(BranchRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBranchRule(new DeleteBranchRuleRequest
            {
                BranchRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// DeleteBranchRule deletes a branch rule.
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBranchRuleAsync(BranchRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBranchRuleAsync(new DeleteBranchRuleRequest
            {
                BranchRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// DeleteBranchRule deletes a branch rule.
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBranchRuleAsync(BranchRuleName name, st::CancellationToken cancellationToken) =>
            DeleteBranchRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> CreatePullRequest(CreatePullRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> CreatePullRequestAsync(CreatePullRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> CreatePullRequestAsync(CreatePullRequestRequest request, st::CancellationToken cancellationToken) =>
            CreatePullRequestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePullRequest</c>.</summary>
        public virtual lro::OperationsClient CreatePullRequestOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreatePullRequest</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> PollOnceCreatePullRequest(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequest, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePullRequestOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePullRequest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> PollOnceCreatePullRequestAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequest, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePullRequestOperationsClient, callSettings);

        /// <summary>
        /// Creates a pull request.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository that the pull request is created from. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pullRequest">
        /// Required. The pull request to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> CreatePullRequest(string parent, PullRequest pullRequest, gaxgrpc::CallSettings callSettings = null) =>
            CreatePullRequest(new CreatePullRequestRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PullRequest = gax::GaxPreconditions.CheckNotNull(pullRequest, nameof(pullRequest)),
            }, callSettings);

        /// <summary>
        /// Creates a pull request.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository that the pull request is created from. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pullRequest">
        /// Required. The pull request to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> CreatePullRequestAsync(string parent, PullRequest pullRequest, gaxgrpc::CallSettings callSettings = null) =>
            CreatePullRequestAsync(new CreatePullRequestRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PullRequest = gax::GaxPreconditions.CheckNotNull(pullRequest, nameof(pullRequest)),
            }, callSettings);

        /// <summary>
        /// Creates a pull request.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository that the pull request is created from. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pullRequest">
        /// Required. The pull request to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> CreatePullRequestAsync(string parent, PullRequest pullRequest, st::CancellationToken cancellationToken) =>
            CreatePullRequestAsync(parent, pullRequest, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a pull request.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository that the pull request is created from. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pullRequest">
        /// Required. The pull request to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> CreatePullRequest(RepositoryName parent, PullRequest pullRequest, gaxgrpc::CallSettings callSettings = null) =>
            CreatePullRequest(new CreatePullRequestRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PullRequest = gax::GaxPreconditions.CheckNotNull(pullRequest, nameof(pullRequest)),
            }, callSettings);

        /// <summary>
        /// Creates a pull request.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository that the pull request is created from. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pullRequest">
        /// Required. The pull request to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> CreatePullRequestAsync(RepositoryName parent, PullRequest pullRequest, gaxgrpc::CallSettings callSettings = null) =>
            CreatePullRequestAsync(new CreatePullRequestRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PullRequest = gax::GaxPreconditions.CheckNotNull(pullRequest, nameof(pullRequest)),
            }, callSettings);

        /// <summary>
        /// Creates a pull request.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository that the pull request is created from. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pullRequest">
        /// Required. The pull request to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> CreatePullRequestAsync(RepositoryName parent, PullRequest pullRequest, st::CancellationToken cancellationToken) =>
            CreatePullRequestAsync(parent, pullRequest, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PullRequest GetPullRequest(GetPullRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullRequest> GetPullRequestAsync(GetPullRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullRequest> GetPullRequestAsync(GetPullRequestRequest request, st::CancellationToken cancellationToken) =>
            GetPullRequestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PullRequest GetPullRequest(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPullRequest(new GetPullRequestRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullRequest> GetPullRequestAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPullRequestAsync(new GetPullRequestRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullRequest> GetPullRequestAsync(string name, st::CancellationToken cancellationToken) =>
            GetPullRequestAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PullRequest GetPullRequest(PullRequestName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPullRequest(new GetPullRequestRequest
            {
                PullRequestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullRequest> GetPullRequestAsync(PullRequestName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPullRequestAsync(new GetPullRequestRequest
            {
                PullRequestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullRequest> GetPullRequestAsync(PullRequestName name, st::CancellationToken cancellationToken) =>
            GetPullRequestAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists pull requests in a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PullRequest"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPullRequestsResponse, PullRequest> ListPullRequests(ListPullRequestsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists pull requests in a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PullRequest"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPullRequestsResponse, PullRequest> ListPullRequestsAsync(ListPullRequestsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists pull requests in a repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list pull requests. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PullRequest"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPullRequestsResponse, PullRequest> ListPullRequests(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPullRequestsRequest request = new ListPullRequestsRequest
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
            return ListPullRequests(request, callSettings);
        }

        /// <summary>
        /// Lists pull requests in a repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list pull requests. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PullRequest"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPullRequestsResponse, PullRequest> ListPullRequestsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPullRequestsRequest request = new ListPullRequestsRequest
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
            return ListPullRequestsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists pull requests in a repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list pull requests. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PullRequest"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPullRequestsResponse, PullRequest> ListPullRequests(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPullRequestsRequest request = new ListPullRequestsRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPullRequests(request, callSettings);
        }

        /// <summary>
        /// Lists pull requests in a repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list pull requests. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PullRequest"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPullRequestsResponse, PullRequest> ListPullRequestsAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPullRequestsRequest request = new ListPullRequestsRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPullRequestsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> UpdatePullRequest(UpdatePullRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> UpdatePullRequestAsync(UpdatePullRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> UpdatePullRequestAsync(UpdatePullRequestRequest request, st::CancellationToken cancellationToken) =>
            UpdatePullRequestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdatePullRequest</c>.</summary>
        public virtual lro::OperationsClient UpdatePullRequestOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdatePullRequest</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> PollOnceUpdatePullRequest(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequest, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePullRequestOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePullRequest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> PollOnceUpdatePullRequestAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequest, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePullRequestOperationsClient, callSettings);

        /// <summary>
        /// Updates a pull request.
        /// </summary>
        /// <param name="pullRequest">
        /// Required. The pull request to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// pull request resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> UpdatePullRequest(PullRequest pullRequest, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePullRequest(new UpdatePullRequestRequest
            {
                PullRequest = gax::GaxPreconditions.CheckNotNull(pullRequest, nameof(pullRequest)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a pull request.
        /// </summary>
        /// <param name="pullRequest">
        /// Required. The pull request to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// pull request resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> UpdatePullRequestAsync(PullRequest pullRequest, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePullRequestAsync(new UpdatePullRequestRequest
            {
                PullRequest = gax::GaxPreconditions.CheckNotNull(pullRequest, nameof(pullRequest)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a pull request.
        /// </summary>
        /// <param name="pullRequest">
        /// Required. The pull request to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// pull request resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> UpdatePullRequestAsync(PullRequest pullRequest, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePullRequestAsync(pullRequest, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Merges a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> MergePullRequest(MergePullRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Merges a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> MergePullRequestAsync(MergePullRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Merges a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> MergePullRequestAsync(MergePullRequestRequest request, st::CancellationToken cancellationToken) =>
            MergePullRequestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>MergePullRequest</c>.</summary>
        public virtual lro::OperationsClient MergePullRequestOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>MergePullRequest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> PollOnceMergePullRequest(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequest, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MergePullRequestOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>MergePullRequest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> PollOnceMergePullRequestAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequest, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MergePullRequestOperationsClient, callSettings);

        /// <summary>
        /// Merges a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to merge.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> MergePullRequest(string name, gaxgrpc::CallSettings callSettings = null) =>
            MergePullRequest(new MergePullRequestRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Merges a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to merge.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> MergePullRequestAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            MergePullRequestAsync(new MergePullRequestRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Merges a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to merge.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> MergePullRequestAsync(string name, st::CancellationToken cancellationToken) =>
            MergePullRequestAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Merges a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to merge.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> MergePullRequest(PullRequestName name, gaxgrpc::CallSettings callSettings = null) =>
            MergePullRequest(new MergePullRequestRequest
            {
                PullRequestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Merges a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to merge.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> MergePullRequestAsync(PullRequestName name, gaxgrpc::CallSettings callSettings = null) =>
            MergePullRequestAsync(new MergePullRequestRequest
            {
                PullRequestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Merges a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to merge.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> MergePullRequestAsync(PullRequestName name, st::CancellationToken cancellationToken) =>
            MergePullRequestAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Opens a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> OpenPullRequest(OpenPullRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Opens a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> OpenPullRequestAsync(OpenPullRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Opens a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> OpenPullRequestAsync(OpenPullRequestRequest request, st::CancellationToken cancellationToken) =>
            OpenPullRequestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>OpenPullRequest</c>.</summary>
        public virtual lro::OperationsClient OpenPullRequestOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>OpenPullRequest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> PollOnceOpenPullRequest(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequest, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), OpenPullRequestOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>OpenPullRequest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> PollOnceOpenPullRequestAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequest, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), OpenPullRequestOperationsClient, callSettings);

        /// <summary>
        /// Opens a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to open.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> OpenPullRequest(string name, gaxgrpc::CallSettings callSettings = null) =>
            OpenPullRequest(new OpenPullRequestRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Opens a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to open.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> OpenPullRequestAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            OpenPullRequestAsync(new OpenPullRequestRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Opens a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to open.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> OpenPullRequestAsync(string name, st::CancellationToken cancellationToken) =>
            OpenPullRequestAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Opens a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to open.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> OpenPullRequest(PullRequestName name, gaxgrpc::CallSettings callSettings = null) =>
            OpenPullRequest(new OpenPullRequestRequest
            {
                PullRequestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Opens a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to open.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> OpenPullRequestAsync(PullRequestName name, gaxgrpc::CallSettings callSettings = null) =>
            OpenPullRequestAsync(new OpenPullRequestRequest
            {
                PullRequestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Opens a pull request.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to open.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> OpenPullRequestAsync(PullRequestName name, st::CancellationToken cancellationToken) =>
            OpenPullRequestAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Closes a pull request without merging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> ClosePullRequest(ClosePullRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Closes a pull request without merging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> ClosePullRequestAsync(ClosePullRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Closes a pull request without merging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> ClosePullRequestAsync(ClosePullRequestRequest request, st::CancellationToken cancellationToken) =>
            ClosePullRequestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ClosePullRequest</c>.</summary>
        public virtual lro::OperationsClient ClosePullRequestOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ClosePullRequest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> PollOnceClosePullRequest(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequest, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ClosePullRequestOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ClosePullRequest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> PollOnceClosePullRequestAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequest, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ClosePullRequestOperationsClient, callSettings);

        /// <summary>
        /// Closes a pull request without merging.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to close.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> ClosePullRequest(string name, gaxgrpc::CallSettings callSettings = null) =>
            ClosePullRequest(new ClosePullRequestRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Closes a pull request without merging.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to close.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> ClosePullRequestAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ClosePullRequestAsync(new ClosePullRequestRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Closes a pull request without merging.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to close.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> ClosePullRequestAsync(string name, st::CancellationToken cancellationToken) =>
            ClosePullRequestAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Closes a pull request without merging.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to close.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequest, OperationMetadata> ClosePullRequest(PullRequestName name, gaxgrpc::CallSettings callSettings = null) =>
            ClosePullRequest(new ClosePullRequestRequest
            {
                PullRequestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Closes a pull request without merging.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to close.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> ClosePullRequestAsync(PullRequestName name, gaxgrpc::CallSettings callSettings = null) =>
            ClosePullRequestAsync(new ClosePullRequestRequest
            {
                PullRequestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Closes a pull request without merging.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to close.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequest, OperationMetadata>> ClosePullRequestAsync(PullRequestName name, st::CancellationToken cancellationToken) =>
            ClosePullRequestAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists a pull request's file diffs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FileDiff"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPullRequestFileDiffsResponse, FileDiff> ListPullRequestFileDiffs(ListPullRequestFileDiffsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a pull request's file diffs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FileDiff"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPullRequestFileDiffsResponse, FileDiff> ListPullRequestFileDiffsAsync(ListPullRequestFileDiffsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a pull request's file diffs.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to list file diffs for.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FileDiff"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPullRequestFileDiffsResponse, FileDiff> ListPullRequestFileDiffs(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPullRequestFileDiffsRequest request = new ListPullRequestFileDiffsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPullRequestFileDiffs(request, callSettings);
        }

        /// <summary>
        /// Lists a pull request's file diffs.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to list file diffs for.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FileDiff"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPullRequestFileDiffsResponse, FileDiff> ListPullRequestFileDiffsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPullRequestFileDiffsRequest request = new ListPullRequestFileDiffsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPullRequestFileDiffsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists a pull request's file diffs.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to list file diffs for.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FileDiff"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPullRequestFileDiffsResponse, FileDiff> ListPullRequestFileDiffs(PullRequestName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPullRequestFileDiffsRequest request = new ListPullRequestFileDiffsRequest
            {
                PullRequestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPullRequestFileDiffs(request, callSettings);
        }

        /// <summary>
        /// Lists a pull request's file diffs.
        /// </summary>
        /// <param name="name">
        /// Required. The pull request to list file diffs for.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FileDiff"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPullRequestFileDiffsResponse, FileDiff> ListPullRequestFileDiffsAsync(PullRequestName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPullRequestFileDiffsRequest request = new ListPullRequestFileDiffsRequest
            {
                PullRequestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPullRequestFileDiffsAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches a tree from a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TreeEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchTreeResponse, TreeEntry> FetchTree(FetchTreeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a tree from a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TreeEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchTreeResponse, TreeEntry> FetchTreeAsync(FetchTreeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a blob from a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchBlobResponse FetchBlob(FetchBlobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a blob from a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchBlobResponse> FetchBlobAsync(FetchBlobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a blob from a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchBlobResponse> FetchBlobAsync(FetchBlobRequest request, st::CancellationToken cancellationToken) =>
            FetchBlobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> CreateIssue(CreateIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> CreateIssueAsync(CreateIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> CreateIssueAsync(CreateIssueRequest request, st::CancellationToken cancellationToken) =>
            CreateIssueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateIssue</c>.</summary>
        public virtual lro::OperationsClient CreateIssueOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateIssue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> PollOnceCreateIssue(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Issue, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIssueOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateIssue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> PollOnceCreateIssueAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Issue, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIssueOperationsClient, callSettings);

        /// <summary>
        /// Creates an issue.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the issue. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="issue">
        /// Required. The issue to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> CreateIssue(string parent, Issue issue, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssue(new CreateIssueRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Issue = gax::GaxPreconditions.CheckNotNull(issue, nameof(issue)),
            }, callSettings);

        /// <summary>
        /// Creates an issue.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the issue. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="issue">
        /// Required. The issue to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> CreateIssueAsync(string parent, Issue issue, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueAsync(new CreateIssueRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Issue = gax::GaxPreconditions.CheckNotNull(issue, nameof(issue)),
            }, callSettings);

        /// <summary>
        /// Creates an issue.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the issue. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="issue">
        /// Required. The issue to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> CreateIssueAsync(string parent, Issue issue, st::CancellationToken cancellationToken) =>
            CreateIssueAsync(parent, issue, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an issue.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the issue. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="issue">
        /// Required. The issue to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> CreateIssue(RepositoryName parent, Issue issue, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssue(new CreateIssueRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Issue = gax::GaxPreconditions.CheckNotNull(issue, nameof(issue)),
            }, callSettings);

        /// <summary>
        /// Creates an issue.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the issue. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="issue">
        /// Required. The issue to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> CreateIssueAsync(RepositoryName parent, Issue issue, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueAsync(new CreateIssueRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Issue = gax::GaxPreconditions.CheckNotNull(issue, nameof(issue)),
            }, callSettings);

        /// <summary>
        /// Creates an issue.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the issue. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="issue">
        /// Required. The issue to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> CreateIssueAsync(RepositoryName parent, Issue issue, st::CancellationToken cancellationToken) =>
            CreateIssueAsync(parent, issue, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. Name of the issue to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/issues/{issue_id}`.
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
        /// Required. Name of the issue to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/issues/{issue_id}`.
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
        /// Required. Name of the issue to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/issues/{issue_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(string name, st::CancellationToken cancellationToken) =>
            GetIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/issues/{issue_id}`.
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
        /// Required. Name of the issue to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/issues/{issue_id}`.
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
        /// Required. Name of the issue to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/issues/{issue_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Issue> GetIssueAsync(IssueName name, st::CancellationToken cancellationToken) =>
            GetIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists issues in a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Issue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIssuesResponse, Issue> ListIssues(ListIssuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists issues in a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Issue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIssuesResponse, Issue> ListIssuesAsync(ListIssuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists issues in a repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list issues. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Issue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIssuesResponse, Issue> ListIssues(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIssuesRequest request = new ListIssuesRequest
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
            return ListIssues(request, callSettings);
        }

        /// <summary>
        /// Lists issues in a repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list issues. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Issue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIssuesResponse, Issue> ListIssuesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIssuesRequest request = new ListIssuesRequest
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
            return ListIssuesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists issues in a repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list issues. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Issue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIssuesResponse, Issue> ListIssues(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIssuesRequest request = new ListIssuesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListIssues(request, callSettings);
        }

        /// <summary>
        /// Lists issues in a repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list issues. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Issue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIssuesResponse, Issue> ListIssuesAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIssuesRequest request = new ListIssuesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListIssuesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> UpdateIssue(UpdateIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> UpdateIssueAsync(UpdateIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> UpdateIssueAsync(UpdateIssueRequest request, st::CancellationToken cancellationToken) =>
            UpdateIssueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateIssue</c>.</summary>
        public virtual lro::OperationsClient UpdateIssueOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateIssue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> PollOnceUpdateIssue(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Issue, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateIssueOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateIssue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> PollOnceUpdateIssueAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Issue, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateIssueOperationsClient, callSettings);

        /// <summary>
        /// Updates a issue.
        /// </summary>
        /// <param name="issue">
        /// Required. The issue to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// issue resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> UpdateIssue(Issue issue, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIssue(new UpdateIssueRequest
            {
                Issue = gax::GaxPreconditions.CheckNotNull(issue, nameof(issue)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a issue.
        /// </summary>
        /// <param name="issue">
        /// Required. The issue to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// issue resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> UpdateIssueAsync(Issue issue, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIssueAsync(new UpdateIssueRequest
            {
                Issue = gax::GaxPreconditions.CheckNotNull(issue, nameof(issue)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a issue.
        /// </summary>
        /// <param name="issue">
        /// Required. The issue to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// issue resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> UpdateIssueAsync(Issue issue, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateIssueAsync(issue, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteIssue(DeleteIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueAsync(DeleteIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueAsync(DeleteIssueRequest request, st::CancellationToken cancellationToken) =>
            DeleteIssueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteIssue</c>.</summary>
        public virtual lro::OperationsClient DeleteIssueOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteIssue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteIssue(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIssueOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteIssue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteIssueAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIssueOperationsClient, callSettings);

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteIssue(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssue(new DeleteIssueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueAsync(new DeleteIssueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteIssue(IssueName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssue(new DeleteIssueRequest
            {
                IssueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueAsync(IssueName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueAsync(new DeleteIssueRequest
            {
                IssueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueAsync(IssueName name, st::CancellationToken cancellationToken) =>
            DeleteIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Opens an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> OpenIssue(OpenIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Opens an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> OpenIssueAsync(OpenIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Opens an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> OpenIssueAsync(OpenIssueRequest request, st::CancellationToken cancellationToken) =>
            OpenIssueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>OpenIssue</c>.</summary>
        public virtual lro::OperationsClient OpenIssueOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>OpenIssue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> PollOnceOpenIssue(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Issue, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), OpenIssueOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>OpenIssue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> PollOnceOpenIssueAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Issue, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), OpenIssueOperationsClient, callSettings);

        /// <summary>
        /// Opens an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to open.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> OpenIssue(string name, gaxgrpc::CallSettings callSettings = null) =>
            OpenIssue(new OpenIssueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Opens an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to open.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> OpenIssueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            OpenIssueAsync(new OpenIssueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Opens an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to open.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> OpenIssueAsync(string name, st::CancellationToken cancellationToken) =>
            OpenIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Opens an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to open.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> OpenIssue(IssueName name, gaxgrpc::CallSettings callSettings = null) =>
            OpenIssue(new OpenIssueRequest
            {
                IssueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Opens an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to open.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> OpenIssueAsync(IssueName name, gaxgrpc::CallSettings callSettings = null) =>
            OpenIssueAsync(new OpenIssueRequest
            {
                IssueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Opens an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to open.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> OpenIssueAsync(IssueName name, st::CancellationToken cancellationToken) =>
            OpenIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Closes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> CloseIssue(CloseIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Closes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> CloseIssueAsync(CloseIssueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Closes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> CloseIssueAsync(CloseIssueRequest request, st::CancellationToken cancellationToken) =>
            CloseIssueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CloseIssue</c>.</summary>
        public virtual lro::OperationsClient CloseIssueOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CloseIssue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> PollOnceCloseIssue(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Issue, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CloseIssueOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CloseIssue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> PollOnceCloseIssueAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Issue, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CloseIssueOperationsClient, callSettings);

        /// <summary>
        /// Closes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to close.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> CloseIssue(string name, gaxgrpc::CallSettings callSettings = null) =>
            CloseIssue(new CloseIssueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Closes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to close.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> CloseIssueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CloseIssueAsync(new CloseIssueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Closes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to close.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> CloseIssueAsync(string name, st::CancellationToken cancellationToken) =>
            CloseIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Closes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to close.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Issue, OperationMetadata> CloseIssue(IssueName name, gaxgrpc::CallSettings callSettings = null) =>
            CloseIssue(new CloseIssueRequest
            {
                IssueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Closes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to close.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> CloseIssueAsync(IssueName name, gaxgrpc::CallSettings callSettings = null) =>
            CloseIssueAsync(new CloseIssueRequest
            {
                IssueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Closes an issue.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue to close.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Issue, OperationMetadata>> CloseIssueAsync(IssueName name, st::CancellationToken cancellationToken) =>
            CloseIssueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PullRequestComment GetPullRequestComment(GetPullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullRequestComment> GetPullRequestCommentAsync(GetPullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullRequestComment> GetPullRequestCommentAsync(GetPullRequestCommentRequest request, st::CancellationToken cancellationToken) =>
            GetPullRequestCommentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a pull request comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request comment to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PullRequestComment GetPullRequestComment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPullRequestComment(new GetPullRequestCommentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a pull request comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request comment to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullRequestComment> GetPullRequestCommentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPullRequestCommentAsync(new GetPullRequestCommentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a pull request comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request comment to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullRequestComment> GetPullRequestCommentAsync(string name, st::CancellationToken cancellationToken) =>
            GetPullRequestCommentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a pull request comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request comment to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PullRequestComment GetPullRequestComment(PullRequestCommentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPullRequestComment(new GetPullRequestCommentRequest
            {
                PullRequestCommentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a pull request comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request comment to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullRequestComment> GetPullRequestCommentAsync(PullRequestCommentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPullRequestCommentAsync(new GetPullRequestCommentRequest
            {
                PullRequestCommentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a pull request comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request comment to retrieve.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullRequestComment> GetPullRequestCommentAsync(PullRequestCommentName name, st::CancellationToken cancellationToken) =>
            GetPullRequestCommentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PullRequestComment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPullRequestCommentsResponse, PullRequestComment> ListPullRequestComments(ListPullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PullRequestComment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPullRequestCommentsResponse, PullRequestComment> ListPullRequestCommentsAsync(ListPullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to list pull request comments. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PullRequestComment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPullRequestCommentsResponse, PullRequestComment> ListPullRequestComments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPullRequestCommentsRequest request = new ListPullRequestCommentsRequest
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
            return ListPullRequestComments(request, callSettings);
        }

        /// <summary>
        /// Lists pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to list pull request comments. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PullRequestComment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPullRequestCommentsResponse, PullRequestComment> ListPullRequestCommentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPullRequestCommentsRequest request = new ListPullRequestCommentsRequest
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
            return ListPullRequestCommentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to list pull request comments. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PullRequestComment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPullRequestCommentsResponse, PullRequestComment> ListPullRequestComments(PullRequestName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPullRequestCommentsRequest request = new ListPullRequestCommentsRequest
            {
                ParentAsPullRequestName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPullRequestComments(request, callSettings);
        }

        /// <summary>
        /// Lists pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to list pull request comments. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PullRequestComment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPullRequestCommentsResponse, PullRequestComment> ListPullRequestCommentsAsync(PullRequestName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPullRequestCommentsRequest request = new ListPullRequestCommentsRequest
            {
                ParentAsPullRequestName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPullRequestCommentsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequestComment, OperationMetadata> CreatePullRequestComment(CreatePullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> CreatePullRequestCommentAsync(CreatePullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> CreatePullRequestCommentAsync(CreatePullRequestCommentRequest request, st::CancellationToken cancellationToken) =>
            CreatePullRequestCommentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePullRequestComment</c>.</summary>
        public virtual lro::OperationsClient CreatePullRequestCommentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePullRequestComment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PullRequestComment, OperationMetadata> PollOnceCreatePullRequestComment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequestComment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePullRequestCommentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePullRequestComment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> PollOnceCreatePullRequestCommentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequestComment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePullRequestCommentOperationsClient, callSettings);

        /// <summary>
        /// Creates a pull request comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to create the pull request comment.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pullRequestComment">
        /// Required. The pull request comment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequestComment, OperationMetadata> CreatePullRequestComment(string parent, PullRequestComment pullRequestComment, gaxgrpc::CallSettings callSettings = null) =>
            CreatePullRequestComment(new CreatePullRequestCommentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PullRequestComment = gax::GaxPreconditions.CheckNotNull(pullRequestComment, nameof(pullRequestComment)),
            }, callSettings);

        /// <summary>
        /// Creates a pull request comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to create the pull request comment.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pullRequestComment">
        /// Required. The pull request comment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> CreatePullRequestCommentAsync(string parent, PullRequestComment pullRequestComment, gaxgrpc::CallSettings callSettings = null) =>
            CreatePullRequestCommentAsync(new CreatePullRequestCommentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PullRequestComment = gax::GaxPreconditions.CheckNotNull(pullRequestComment, nameof(pullRequestComment)),
            }, callSettings);

        /// <summary>
        /// Creates a pull request comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to create the pull request comment.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pullRequestComment">
        /// Required. The pull request comment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> CreatePullRequestCommentAsync(string parent, PullRequestComment pullRequestComment, st::CancellationToken cancellationToken) =>
            CreatePullRequestCommentAsync(parent, pullRequestComment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a pull request comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to create the pull request comment.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pullRequestComment">
        /// Required. The pull request comment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequestComment, OperationMetadata> CreatePullRequestComment(PullRequestName parent, PullRequestComment pullRequestComment, gaxgrpc::CallSettings callSettings = null) =>
            CreatePullRequestComment(new CreatePullRequestCommentRequest
            {
                ParentAsPullRequestName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PullRequestComment = gax::GaxPreconditions.CheckNotNull(pullRequestComment, nameof(pullRequestComment)),
            }, callSettings);

        /// <summary>
        /// Creates a pull request comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to create the pull request comment.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pullRequestComment">
        /// Required. The pull request comment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> CreatePullRequestCommentAsync(PullRequestName parent, PullRequestComment pullRequestComment, gaxgrpc::CallSettings callSettings = null) =>
            CreatePullRequestCommentAsync(new CreatePullRequestCommentRequest
            {
                ParentAsPullRequestName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PullRequestComment = gax::GaxPreconditions.CheckNotNull(pullRequestComment, nameof(pullRequestComment)),
            }, callSettings);

        /// <summary>
        /// Creates a pull request comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to create the pull request comment.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="pullRequestComment">
        /// Required. The pull request comment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> CreatePullRequestCommentAsync(PullRequestName parent, PullRequestComment pullRequestComment, st::CancellationToken cancellationToken) =>
            CreatePullRequestCommentAsync(parent, pullRequestComment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequestComment, OperationMetadata> UpdatePullRequestComment(UpdatePullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> UpdatePullRequestCommentAsync(UpdatePullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> UpdatePullRequestCommentAsync(UpdatePullRequestCommentRequest request, st::CancellationToken cancellationToken) =>
            UpdatePullRequestCommentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdatePullRequestComment</c>.</summary>
        public virtual lro::OperationsClient UpdatePullRequestCommentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePullRequestComment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PullRequestComment, OperationMetadata> PollOnceUpdatePullRequestComment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequestComment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePullRequestCommentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePullRequestComment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> PollOnceUpdatePullRequestCommentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PullRequestComment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePullRequestCommentOperationsClient, callSettings);

        /// <summary>
        /// Updates a pull request comment.
        /// </summary>
        /// <param name="pullRequestComment">
        /// Required. The pull request comment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// pull request comment resource by the update. Updatable fields are
        /// `body`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PullRequestComment, OperationMetadata> UpdatePullRequestComment(PullRequestComment pullRequestComment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePullRequestComment(new UpdatePullRequestCommentRequest
            {
                PullRequestComment = gax::GaxPreconditions.CheckNotNull(pullRequestComment, nameof(pullRequestComment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a pull request comment.
        /// </summary>
        /// <param name="pullRequestComment">
        /// Required. The pull request comment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// pull request comment resource by the update. Updatable fields are
        /// `body`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> UpdatePullRequestCommentAsync(PullRequestComment pullRequestComment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePullRequestCommentAsync(new UpdatePullRequestCommentRequest
            {
                PullRequestComment = gax::GaxPreconditions.CheckNotNull(pullRequestComment, nameof(pullRequestComment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a pull request comment.
        /// </summary>
        /// <param name="pullRequestComment">
        /// Required. The pull request comment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// pull request comment resource by the update. Updatable fields are
        /// `body`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> UpdatePullRequestCommentAsync(PullRequestComment pullRequestComment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePullRequestCommentAsync(pullRequestComment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePullRequestComment(DeletePullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePullRequestCommentAsync(DeletePullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePullRequestCommentAsync(DeletePullRequestCommentRequest request, st::CancellationToken cancellationToken) =>
            DeletePullRequestCommentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePullRequestComment</c>.</summary>
        public virtual lro::OperationsClient DeletePullRequestCommentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePullRequestComment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeletePullRequestComment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePullRequestCommentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePullRequestComment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeletePullRequestCommentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePullRequestCommentOperationsClient, callSettings);

        /// <summary>
        /// Deletes a pull request comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request comment to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePullRequestComment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePullRequestComment(new DeletePullRequestCommentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a pull request comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request comment to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePullRequestCommentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePullRequestCommentAsync(new DeletePullRequestCommentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a pull request comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request comment to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePullRequestCommentAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePullRequestCommentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a pull request comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request comment to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePullRequestComment(PullRequestCommentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePullRequestComment(new DeletePullRequestCommentRequest
            {
                PullRequestCommentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a pull request comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request comment to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePullRequestCommentAsync(PullRequestCommentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePullRequestCommentAsync(new DeletePullRequestCommentRequest
            {
                PullRequestCommentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a pull request comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the pull request comment to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePullRequestCommentAsync(PullRequestCommentName name, st::CancellationToken cancellationToken) =>
            DeletePullRequestCommentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> BatchCreatePullRequestComments(BatchCreatePullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata>> BatchCreatePullRequestCommentsAsync(BatchCreatePullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata>> BatchCreatePullRequestCommentsAsync(BatchCreatePullRequestCommentsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreatePullRequestCommentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchCreatePullRequestComments</c>.</summary>
        public virtual lro::OperationsClient BatchCreatePullRequestCommentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchCreatePullRequestComments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> PollOnceBatchCreatePullRequestComments(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreatePullRequestCommentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchCreatePullRequestComments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata>> PollOnceBatchCreatePullRequestCommentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreatePullRequestCommentsOperationsClient, callSettings);

        /// <summary>
        /// Batch creates pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to create the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to create. There
        /// should be exactly one CreatePullRequestCommentRequest with CommentDetail
        /// being REVIEW in the list, and no more than 100
        /// CreatePullRequestCommentRequests with CommentDetail being CODE in the list
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> BatchCreatePullRequestComments(string parent, scg::IEnumerable<CreatePullRequestCommentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreatePullRequestComments(new BatchCreatePullRequestCommentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to create the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to create. There
        /// should be exactly one CreatePullRequestCommentRequest with CommentDetail
        /// being REVIEW in the list, and no more than 100
        /// CreatePullRequestCommentRequests with CommentDetail being CODE in the list
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata>> BatchCreatePullRequestCommentsAsync(string parent, scg::IEnumerable<CreatePullRequestCommentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreatePullRequestCommentsAsync(new BatchCreatePullRequestCommentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to create the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to create. There
        /// should be exactly one CreatePullRequestCommentRequest with CommentDetail
        /// being REVIEW in the list, and no more than 100
        /// CreatePullRequestCommentRequests with CommentDetail being CODE in the list
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata>> BatchCreatePullRequestCommentsAsync(string parent, scg::IEnumerable<CreatePullRequestCommentRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreatePullRequestCommentsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to create the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to create. There
        /// should be exactly one CreatePullRequestCommentRequest with CommentDetail
        /// being REVIEW in the list, and no more than 100
        /// CreatePullRequestCommentRequests with CommentDetail being CODE in the list
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> BatchCreatePullRequestComments(PullRequestName parent, scg::IEnumerable<CreatePullRequestCommentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreatePullRequestComments(new BatchCreatePullRequestCommentsRequest
            {
                ParentAsPullRequestName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to create the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to create. There
        /// should be exactly one CreatePullRequestCommentRequest with CommentDetail
        /// being REVIEW in the list, and no more than 100
        /// CreatePullRequestCommentRequests with CommentDetail being CODE in the list
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata>> BatchCreatePullRequestCommentsAsync(PullRequestName parent, scg::IEnumerable<CreatePullRequestCommentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreatePullRequestCommentsAsync(new BatchCreatePullRequestCommentsRequest
            {
                ParentAsPullRequestName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to create the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to create. There
        /// should be exactly one CreatePullRequestCommentRequest with CommentDetail
        /// being REVIEW in the list, and no more than 100
        /// CreatePullRequestCommentRequests with CommentDetail being CODE in the list
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata>> BatchCreatePullRequestCommentsAsync(PullRequestName parent, scg::IEnumerable<CreatePullRequestCommentRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreatePullRequestCommentsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resolves pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata> ResolvePullRequestComments(ResolvePullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resolves pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata>> ResolvePullRequestCommentsAsync(ResolvePullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resolves pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata>> ResolvePullRequestCommentsAsync(ResolvePullRequestCommentsRequest request, st::CancellationToken cancellationToken) =>
            ResolvePullRequestCommentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResolvePullRequestComments</c>.</summary>
        public virtual lro::OperationsClient ResolvePullRequestCommentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResolvePullRequestComments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata> PollOnceResolvePullRequestComments(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResolvePullRequestCommentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResolvePullRequestComments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata>> PollOnceResolvePullRequestCommentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResolvePullRequestCommentsOperationsClient, callSettings);

        /// <summary>
        /// Resolves pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to resolve the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the pull request comments to resolve. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`
        /// Only comments from the same threads are allowed in the same request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata> ResolvePullRequestComments(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            ResolvePullRequestComments(new ResolvePullRequestCommentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resolves pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to resolve the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the pull request comments to resolve. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`
        /// Only comments from the same threads are allowed in the same request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata>> ResolvePullRequestCommentsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            ResolvePullRequestCommentsAsync(new ResolvePullRequestCommentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resolves pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to resolve the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the pull request comments to resolve. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`
        /// Only comments from the same threads are allowed in the same request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata>> ResolvePullRequestCommentsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            ResolvePullRequestCommentsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resolves pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to resolve the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the pull request comments to resolve. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`
        /// Only comments from the same threads are allowed in the same request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata> ResolvePullRequestComments(PullRequestName parent, scg::IEnumerable<PullRequestCommentName> names, gaxgrpc::CallSettings callSettings = null) =>
            ResolvePullRequestComments(new ResolvePullRequestCommentsRequest
            {
                ParentAsPullRequestName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PullRequestCommentNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resolves pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to resolve the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the pull request comments to resolve. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`
        /// Only comments from the same threads are allowed in the same request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata>> ResolvePullRequestCommentsAsync(PullRequestName parent, scg::IEnumerable<PullRequestCommentName> names, gaxgrpc::CallSettings callSettings = null) =>
            ResolvePullRequestCommentsAsync(new ResolvePullRequestCommentsRequest
            {
                ParentAsPullRequestName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PullRequestCommentNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resolves pull request comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to resolve the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the pull request comments to resolve. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`
        /// Only comments from the same threads are allowed in the same request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata>> ResolvePullRequestCommentsAsync(PullRequestName parent, scg::IEnumerable<PullRequestCommentName> names, st::CancellationToken cancellationToken) =>
            ResolvePullRequestCommentsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unresolves pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> UnresolvePullRequestComments(UnresolvePullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unresolves pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata>> UnresolvePullRequestCommentsAsync(UnresolvePullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unresolves pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata>> UnresolvePullRequestCommentsAsync(UnresolvePullRequestCommentsRequest request, st::CancellationToken cancellationToken) =>
            UnresolvePullRequestCommentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UnresolvePullRequestComments</c>.</summary>
        public virtual lro::OperationsClient UnresolvePullRequestCommentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UnresolvePullRequestComments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> PollOnceUnresolvePullRequestComments(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UnresolvePullRequestCommentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UnresolvePullRequestComments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata>> PollOnceUnresolvePullRequestCommentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UnresolvePullRequestCommentsOperationsClient, callSettings);

        /// <summary>
        /// Unresolves pull request comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to resolve the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the pull request comments to unresolve. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`
        /// Only comments from the same threads are allowed in the same request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> UnresolvePullRequestComments(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            UnresolvePullRequestComments(new UnresolvePullRequestCommentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Unresolves pull request comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to resolve the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the pull request comments to unresolve. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`
        /// Only comments from the same threads are allowed in the same request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata>> UnresolvePullRequestCommentsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            UnresolvePullRequestCommentsAsync(new UnresolvePullRequestCommentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Unresolves pull request comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to resolve the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the pull request comments to unresolve. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`
        /// Only comments from the same threads are allowed in the same request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata>> UnresolvePullRequestCommentsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            UnresolvePullRequestCommentsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unresolves pull request comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to resolve the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the pull request comments to unresolve. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`
        /// Only comments from the same threads are allowed in the same request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> UnresolvePullRequestComments(PullRequestName parent, scg::IEnumerable<PullRequestCommentName> names, gaxgrpc::CallSettings callSettings = null) =>
            UnresolvePullRequestComments(new UnresolvePullRequestCommentsRequest
            {
                ParentAsPullRequestName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PullRequestCommentNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Unresolves pull request comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to resolve the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the pull request comments to unresolve. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`
        /// Only comments from the same threads are allowed in the same request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata>> UnresolvePullRequestCommentsAsync(PullRequestName parent, scg::IEnumerable<PullRequestCommentName> names, gaxgrpc::CallSettings callSettings = null) =>
            UnresolvePullRequestCommentsAsync(new UnresolvePullRequestCommentsRequest
            {
                ParentAsPullRequestName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PullRequestCommentNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Unresolves pull request comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The pull request in which to resolve the pull request comments.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the pull request comments to unresolve. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/pullRequests/{pull_request_id}/pullRequestComments/{comment_id}`
        /// Only comments from the same threads are allowed in the same request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata>> UnresolvePullRequestCommentsAsync(PullRequestName parent, scg::IEnumerable<PullRequestCommentName> names, st::CancellationToken cancellationToken) =>
            UnresolvePullRequestCommentsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IssueComment, OperationMetadata> CreateIssueComment(CreateIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueComment, OperationMetadata>> CreateIssueCommentAsync(CreateIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueComment, OperationMetadata>> CreateIssueCommentAsync(CreateIssueCommentRequest request, st::CancellationToken cancellationToken) =>
            CreateIssueCommentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateIssueComment</c>.</summary>
        public virtual lro::OperationsClient CreateIssueCommentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateIssueComment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<IssueComment, OperationMetadata> PollOnceCreateIssueComment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IssueComment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIssueCommentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateIssueComment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<IssueComment, OperationMetadata>> PollOnceCreateIssueCommentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IssueComment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIssueCommentOperationsClient, callSettings);

        /// <summary>
        /// Creates an issue comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The issue in which to create the issue comment. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`
        /// </param>
        /// <param name="issueComment">
        /// Required. The issue comment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IssueComment, OperationMetadata> CreateIssueComment(string parent, IssueComment issueComment, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueComment(new CreateIssueCommentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IssueComment = gax::GaxPreconditions.CheckNotNull(issueComment, nameof(issueComment)),
            }, callSettings);

        /// <summary>
        /// Creates an issue comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The issue in which to create the issue comment. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`
        /// </param>
        /// <param name="issueComment">
        /// Required. The issue comment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueComment, OperationMetadata>> CreateIssueCommentAsync(string parent, IssueComment issueComment, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueCommentAsync(new CreateIssueCommentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IssueComment = gax::GaxPreconditions.CheckNotNull(issueComment, nameof(issueComment)),
            }, callSettings);

        /// <summary>
        /// Creates an issue comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The issue in which to create the issue comment. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`
        /// </param>
        /// <param name="issueComment">
        /// Required. The issue comment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueComment, OperationMetadata>> CreateIssueCommentAsync(string parent, IssueComment issueComment, st::CancellationToken cancellationToken) =>
            CreateIssueCommentAsync(parent, issueComment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an issue comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The issue in which to create the issue comment. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`
        /// </param>
        /// <param name="issueComment">
        /// Required. The issue comment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IssueComment, OperationMetadata> CreateIssueComment(IssueName parent, IssueComment issueComment, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueComment(new CreateIssueCommentRequest
            {
                ParentAsIssueName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IssueComment = gax::GaxPreconditions.CheckNotNull(issueComment, nameof(issueComment)),
            }, callSettings);

        /// <summary>
        /// Creates an issue comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The issue in which to create the issue comment. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`
        /// </param>
        /// <param name="issueComment">
        /// Required. The issue comment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueComment, OperationMetadata>> CreateIssueCommentAsync(IssueName parent, IssueComment issueComment, gaxgrpc::CallSettings callSettings = null) =>
            CreateIssueCommentAsync(new CreateIssueCommentRequest
            {
                ParentAsIssueName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IssueComment = gax::GaxPreconditions.CheckNotNull(issueComment, nameof(issueComment)),
            }, callSettings);

        /// <summary>
        /// Creates an issue comment.
        /// </summary>
        /// <param name="parent">
        /// Required. The issue in which to create the issue comment. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`
        /// </param>
        /// <param name="issueComment">
        /// Required. The issue comment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueComment, OperationMetadata>> CreateIssueCommentAsync(IssueName parent, IssueComment issueComment, st::CancellationToken cancellationToken) =>
            CreateIssueCommentAsync(parent, issueComment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IssueComment GetIssueComment(GetIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueComment> GetIssueCommentAsync(GetIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueComment> GetIssueCommentAsync(GetIssueCommentRequest request, st::CancellationToken cancellationToken) =>
            GetIssueCommentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue comment to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/issues/{issue_id}/issueComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IssueComment GetIssueComment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueComment(new GetIssueCommentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue comment to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/issues/{issue_id}/issueComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueComment> GetIssueCommentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueCommentAsync(new GetIssueCommentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue comment to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/issues/{issue_id}/issueComments/{comment_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueComment> GetIssueCommentAsync(string name, st::CancellationToken cancellationToken) =>
            GetIssueCommentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an issue comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue comment to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/issues/{issue_id}/issueComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IssueComment GetIssueComment(IssueCommentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueComment(new GetIssueCommentRequest
            {
                IssueCommentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue comment to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/issues/{issue_id}/issueComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueComment> GetIssueCommentAsync(IssueCommentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIssueCommentAsync(new GetIssueCommentRequest
            {
                IssueCommentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an issue comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue comment to retrieve.
        /// The format is
        /// `projects/{project}/locations/{location}/repositories/{repository}/issues/{issue_id}/issueComments/{comment_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IssueComment> GetIssueCommentAsync(IssueCommentName name, st::CancellationToken cancellationToken) =>
            GetIssueCommentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists comments in an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IssueComment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIssueCommentsResponse, IssueComment> ListIssueComments(ListIssueCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists comments in an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IssueComment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIssueCommentsResponse, IssueComment> ListIssueCommentsAsync(ListIssueCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists comments in an issue.
        /// </summary>
        /// <param name="parent">
        /// Required. The issue in which to list the comments. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IssueComment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIssueCommentsResponse, IssueComment> ListIssueComments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIssueCommentsRequest request = new ListIssueCommentsRequest
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
            return ListIssueComments(request, callSettings);
        }

        /// <summary>
        /// Lists comments in an issue.
        /// </summary>
        /// <param name="parent">
        /// Required. The issue in which to list the comments. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IssueComment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIssueCommentsResponse, IssueComment> ListIssueCommentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIssueCommentsRequest request = new ListIssueCommentsRequest
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
            return ListIssueCommentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists comments in an issue.
        /// </summary>
        /// <param name="parent">
        /// Required. The issue in which to list the comments. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IssueComment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIssueCommentsResponse, IssueComment> ListIssueComments(IssueName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIssueCommentsRequest request = new ListIssueCommentsRequest
            {
                ParentAsIssueName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListIssueComments(request, callSettings);
        }

        /// <summary>
        /// Lists comments in an issue.
        /// </summary>
        /// <param name="parent">
        /// Required. The issue in which to list the comments. Format:
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IssueComment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIssueCommentsResponse, IssueComment> ListIssueCommentsAsync(IssueName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIssueCommentsRequest request = new ListIssueCommentsRequest
            {
                ParentAsIssueName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListIssueCommentsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IssueComment, OperationMetadata> UpdateIssueComment(UpdateIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueComment, OperationMetadata>> UpdateIssueCommentAsync(UpdateIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueComment, OperationMetadata>> UpdateIssueCommentAsync(UpdateIssueCommentRequest request, st::CancellationToken cancellationToken) =>
            UpdateIssueCommentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateIssueComment</c>.</summary>
        public virtual lro::OperationsClient UpdateIssueCommentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateIssueComment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<IssueComment, OperationMetadata> PollOnceUpdateIssueComment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IssueComment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateIssueCommentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateIssueComment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<IssueComment, OperationMetadata>> PollOnceUpdateIssueCommentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IssueComment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateIssueCommentOperationsClient, callSettings);

        /// <summary>
        /// Updates an issue comment.
        /// </summary>
        /// <param name="issueComment">
        /// Required. The issue comment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// issue comment resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IssueComment, OperationMetadata> UpdateIssueComment(IssueComment issueComment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIssueComment(new UpdateIssueCommentRequest
            {
                IssueComment = gax::GaxPreconditions.CheckNotNull(issueComment, nameof(issueComment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an issue comment.
        /// </summary>
        /// <param name="issueComment">
        /// Required. The issue comment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// issue comment resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueComment, OperationMetadata>> UpdateIssueCommentAsync(IssueComment issueComment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIssueCommentAsync(new UpdateIssueCommentRequest
            {
                IssueComment = gax::GaxPreconditions.CheckNotNull(issueComment, nameof(issueComment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an issue comment.
        /// </summary>
        /// <param name="issueComment">
        /// Required. The issue comment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// issue comment resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IssueComment, OperationMetadata>> UpdateIssueCommentAsync(IssueComment issueComment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateIssueCommentAsync(issueComment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteIssueComment(DeleteIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueCommentAsync(DeleteIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueCommentAsync(DeleteIssueCommentRequest request, st::CancellationToken cancellationToken) =>
            DeleteIssueCommentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteIssueComment</c>.</summary>
        public virtual lro::OperationsClient DeleteIssueCommentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteIssueComment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteIssueComment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIssueCommentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteIssueComment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteIssueCommentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIssueCommentOperationsClient, callSettings);

        /// <summary>
        /// Deletes an issue comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue comment to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}/issueComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteIssueComment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueComment(new DeleteIssueCommentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue comment to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}/issueComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueCommentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueCommentAsync(new DeleteIssueCommentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue comment to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}/issueComments/{comment_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueCommentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteIssueCommentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an issue comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue comment to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}/issueComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteIssueComment(IssueCommentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueComment(new DeleteIssueCommentRequest
            {
                IssueCommentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue comment to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}/issueComments/{comment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueCommentAsync(IssueCommentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIssueCommentAsync(new DeleteIssueCommentRequest
            {
                IssueCommentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an issue comment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the issue comment to delete.
        /// The format is
        /// `projects/{project_number}/locations/{location_id}/repositories/{repository_id}/issues/{issue_id}/issueComments/{comment_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueCommentAsync(IssueCommentName name, st::CancellationToken cancellationToken) =>
            DeleteIssueCommentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SecureSourceManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Secure Source Manager API
    /// 
    /// Access Secure Source Manager instances, resources, and repositories.
    /// </remarks>
    public sealed partial class SecureSourceManagerClientImpl : SecureSourceManagerClient
    {
        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;

        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> _callDeleteInstance;

        private readonly gaxgrpc::ApiCall<ListRepositoriesRequest, ListRepositoriesResponse> _callListRepositories;

        private readonly gaxgrpc::ApiCall<GetRepositoryRequest, Repository> _callGetRepository;

        private readonly gaxgrpc::ApiCall<CreateRepositoryRequest, lro::Operation> _callCreateRepository;

        private readonly gaxgrpc::ApiCall<UpdateRepositoryRequest, lro::Operation> _callUpdateRepository;

        private readonly gaxgrpc::ApiCall<DeleteRepositoryRequest, lro::Operation> _callDeleteRepository;

        private readonly gaxgrpc::ApiCall<ListHooksRequest, ListHooksResponse> _callListHooks;

        private readonly gaxgrpc::ApiCall<GetHookRequest, Hook> _callGetHook;

        private readonly gaxgrpc::ApiCall<CreateHookRequest, lro::Operation> _callCreateHook;

        private readonly gaxgrpc::ApiCall<UpdateHookRequest, lro::Operation> _callUpdateHook;

        private readonly gaxgrpc::ApiCall<DeleteHookRequest, lro::Operation> _callDeleteHook;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicyRepo;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicyRepo;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissionsRepo;

        private readonly gaxgrpc::ApiCall<CreateBranchRuleRequest, lro::Operation> _callCreateBranchRule;

        private readonly gaxgrpc::ApiCall<ListBranchRulesRequest, ListBranchRulesResponse> _callListBranchRules;

        private readonly gaxgrpc::ApiCall<GetBranchRuleRequest, BranchRule> _callGetBranchRule;

        private readonly gaxgrpc::ApiCall<UpdateBranchRuleRequest, lro::Operation> _callUpdateBranchRule;

        private readonly gaxgrpc::ApiCall<DeleteBranchRuleRequest, lro::Operation> _callDeleteBranchRule;

        private readonly gaxgrpc::ApiCall<CreatePullRequestRequest, lro::Operation> _callCreatePullRequest;

        private readonly gaxgrpc::ApiCall<GetPullRequestRequest, PullRequest> _callGetPullRequest;

        private readonly gaxgrpc::ApiCall<ListPullRequestsRequest, ListPullRequestsResponse> _callListPullRequests;

        private readonly gaxgrpc::ApiCall<UpdatePullRequestRequest, lro::Operation> _callUpdatePullRequest;

        private readonly gaxgrpc::ApiCall<MergePullRequestRequest, lro::Operation> _callMergePullRequest;

        private readonly gaxgrpc::ApiCall<OpenPullRequestRequest, lro::Operation> _callOpenPullRequest;

        private readonly gaxgrpc::ApiCall<ClosePullRequestRequest, lro::Operation> _callClosePullRequest;

        private readonly gaxgrpc::ApiCall<ListPullRequestFileDiffsRequest, ListPullRequestFileDiffsResponse> _callListPullRequestFileDiffs;

        private readonly gaxgrpc::ApiCall<FetchTreeRequest, FetchTreeResponse> _callFetchTree;

        private readonly gaxgrpc::ApiCall<FetchBlobRequest, FetchBlobResponse> _callFetchBlob;

        private readonly gaxgrpc::ApiCall<CreateIssueRequest, lro::Operation> _callCreateIssue;

        private readonly gaxgrpc::ApiCall<GetIssueRequest, Issue> _callGetIssue;

        private readonly gaxgrpc::ApiCall<ListIssuesRequest, ListIssuesResponse> _callListIssues;

        private readonly gaxgrpc::ApiCall<UpdateIssueRequest, lro::Operation> _callUpdateIssue;

        private readonly gaxgrpc::ApiCall<DeleteIssueRequest, lro::Operation> _callDeleteIssue;

        private readonly gaxgrpc::ApiCall<OpenIssueRequest, lro::Operation> _callOpenIssue;

        private readonly gaxgrpc::ApiCall<CloseIssueRequest, lro::Operation> _callCloseIssue;

        private readonly gaxgrpc::ApiCall<GetPullRequestCommentRequest, PullRequestComment> _callGetPullRequestComment;

        private readonly gaxgrpc::ApiCall<ListPullRequestCommentsRequest, ListPullRequestCommentsResponse> _callListPullRequestComments;

        private readonly gaxgrpc::ApiCall<CreatePullRequestCommentRequest, lro::Operation> _callCreatePullRequestComment;

        private readonly gaxgrpc::ApiCall<UpdatePullRequestCommentRequest, lro::Operation> _callUpdatePullRequestComment;

        private readonly gaxgrpc::ApiCall<DeletePullRequestCommentRequest, lro::Operation> _callDeletePullRequestComment;

        private readonly gaxgrpc::ApiCall<BatchCreatePullRequestCommentsRequest, lro::Operation> _callBatchCreatePullRequestComments;

        private readonly gaxgrpc::ApiCall<ResolvePullRequestCommentsRequest, lro::Operation> _callResolvePullRequestComments;

        private readonly gaxgrpc::ApiCall<UnresolvePullRequestCommentsRequest, lro::Operation> _callUnresolvePullRequestComments;

        private readonly gaxgrpc::ApiCall<CreateIssueCommentRequest, lro::Operation> _callCreateIssueComment;

        private readonly gaxgrpc::ApiCall<GetIssueCommentRequest, IssueComment> _callGetIssueComment;

        private readonly gaxgrpc::ApiCall<ListIssueCommentsRequest, ListIssueCommentsResponse> _callListIssueComments;

        private readonly gaxgrpc::ApiCall<UpdateIssueCommentRequest, lro::Operation> _callUpdateIssueComment;

        private readonly gaxgrpc::ApiCall<DeleteIssueCommentRequest, lro::Operation> _callDeleteIssueComment;

        /// <summary>
        /// Constructs a client wrapper for the SecureSourceManager service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SecureSourceManagerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SecureSourceManagerClientImpl(SecureSourceManager.SecureSourceManagerClient grpcClient, SecureSourceManagerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SecureSourceManagerSettings effectiveSettings = settings ?? SecureSourceManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings, logger);
            DeleteInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInstanceOperationsSettings, logger);
            CreateRepositoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRepositoryOperationsSettings, logger);
            UpdateRepositoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateRepositoryOperationsSettings, logger);
            DeleteRepositoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRepositoryOperationsSettings, logger);
            CreateHookOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateHookOperationsSettings, logger);
            UpdateHookOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateHookOperationsSettings, logger);
            DeleteHookOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteHookOperationsSettings, logger);
            CreateBranchRuleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBranchRuleOperationsSettings, logger);
            UpdateBranchRuleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBranchRuleOperationsSettings, logger);
            DeleteBranchRuleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBranchRuleOperationsSettings, logger);
            CreatePullRequestOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePullRequestOperationsSettings, logger);
            UpdatePullRequestOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdatePullRequestOperationsSettings, logger);
            MergePullRequestOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.MergePullRequestOperationsSettings, logger);
            OpenPullRequestOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.OpenPullRequestOperationsSettings, logger);
            ClosePullRequestOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ClosePullRequestOperationsSettings, logger);
            CreateIssueOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateIssueOperationsSettings, logger);
            UpdateIssueOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateIssueOperationsSettings, logger);
            DeleteIssueOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteIssueOperationsSettings, logger);
            OpenIssueOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.OpenIssueOperationsSettings, logger);
            CloseIssueOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CloseIssueOperationsSettings, logger);
            CreatePullRequestCommentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePullRequestCommentOperationsSettings, logger);
            UpdatePullRequestCommentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdatePullRequestCommentOperationsSettings, logger);
            DeletePullRequestCommentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePullRequestCommentOperationsSettings, logger);
            BatchCreatePullRequestCommentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchCreatePullRequestCommentsOperationsSettings, logger);
            ResolvePullRequestCommentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResolvePullRequestCommentsOperationsSettings, logger);
            UnresolvePullRequestCommentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UnresolvePullRequestCommentsOperationsSettings, logger);
            CreateIssueCommentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateIssueCommentOperationsSettings, logger);
            UpdateIssueCommentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateIssueCommentOperationsSettings, logger);
            DeleteIssueCommentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteIssueCommentOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("GetInstance", grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, lro::Operation>("CreateInstance", grpcClient.CreateInstanceAsync, grpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, lro::Operation>("DeleteInstance", grpcClient.DeleteInstanceAsync, grpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            _callListRepositories = clientHelper.BuildApiCall<ListRepositoriesRequest, ListRepositoriesResponse>("ListRepositories", grpcClient.ListRepositoriesAsync, grpcClient.ListRepositories, effectiveSettings.ListRepositoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRepositories);
            Modify_ListRepositoriesApiCall(ref _callListRepositories);
            _callGetRepository = clientHelper.BuildApiCall<GetRepositoryRequest, Repository>("GetRepository", grpcClient.GetRepositoryAsync, grpcClient.GetRepository, effectiveSettings.GetRepositorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRepository);
            Modify_GetRepositoryApiCall(ref _callGetRepository);
            _callCreateRepository = clientHelper.BuildApiCall<CreateRepositoryRequest, lro::Operation>("CreateRepository", grpcClient.CreateRepositoryAsync, grpcClient.CreateRepository, effectiveSettings.CreateRepositorySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRepository);
            Modify_CreateRepositoryApiCall(ref _callCreateRepository);
            _callUpdateRepository = clientHelper.BuildApiCall<UpdateRepositoryRequest, lro::Operation>("UpdateRepository", grpcClient.UpdateRepositoryAsync, grpcClient.UpdateRepository, effectiveSettings.UpdateRepositorySettings).WithGoogleRequestParam("repository.name", request => request.Repository?.Name);
            Modify_ApiCall(ref _callUpdateRepository);
            Modify_UpdateRepositoryApiCall(ref _callUpdateRepository);
            _callDeleteRepository = clientHelper.BuildApiCall<DeleteRepositoryRequest, lro::Operation>("DeleteRepository", grpcClient.DeleteRepositoryAsync, grpcClient.DeleteRepository, effectiveSettings.DeleteRepositorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRepository);
            Modify_DeleteRepositoryApiCall(ref _callDeleteRepository);
            _callListHooks = clientHelper.BuildApiCall<ListHooksRequest, ListHooksResponse>("ListHooks", grpcClient.ListHooksAsync, grpcClient.ListHooks, effectiveSettings.ListHooksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListHooks);
            Modify_ListHooksApiCall(ref _callListHooks);
            _callGetHook = clientHelper.BuildApiCall<GetHookRequest, Hook>("GetHook", grpcClient.GetHookAsync, grpcClient.GetHook, effectiveSettings.GetHookSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetHook);
            Modify_GetHookApiCall(ref _callGetHook);
            _callCreateHook = clientHelper.BuildApiCall<CreateHookRequest, lro::Operation>("CreateHook", grpcClient.CreateHookAsync, grpcClient.CreateHook, effectiveSettings.CreateHookSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateHook);
            Modify_CreateHookApiCall(ref _callCreateHook);
            _callUpdateHook = clientHelper.BuildApiCall<UpdateHookRequest, lro::Operation>("UpdateHook", grpcClient.UpdateHookAsync, grpcClient.UpdateHook, effectiveSettings.UpdateHookSettings).WithGoogleRequestParam("hook.name", request => request.Hook?.Name);
            Modify_ApiCall(ref _callUpdateHook);
            Modify_UpdateHookApiCall(ref _callUpdateHook);
            _callDeleteHook = clientHelper.BuildApiCall<DeleteHookRequest, lro::Operation>("DeleteHook", grpcClient.DeleteHookAsync, grpcClient.DeleteHook, effectiveSettings.DeleteHookSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteHook);
            Modify_DeleteHookApiCall(ref _callDeleteHook);
            _callGetIamPolicyRepo = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicyRepo", grpcClient.GetIamPolicyRepoAsync, grpcClient.GetIamPolicyRepo, effectiveSettings.GetIamPolicyRepoSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicyRepo);
            Modify_GetIamPolicyRepoApiCall(ref _callGetIamPolicyRepo);
            _callSetIamPolicyRepo = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicyRepo", grpcClient.SetIamPolicyRepoAsync, grpcClient.SetIamPolicyRepo, effectiveSettings.SetIamPolicyRepoSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicyRepo);
            Modify_SetIamPolicyRepoApiCall(ref _callSetIamPolicyRepo);
            _callTestIamPermissionsRepo = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissionsRepo", grpcClient.TestIamPermissionsRepoAsync, grpcClient.TestIamPermissionsRepo, effectiveSettings.TestIamPermissionsRepoSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissionsRepo);
            Modify_TestIamPermissionsRepoApiCall(ref _callTestIamPermissionsRepo);
            _callCreateBranchRule = clientHelper.BuildApiCall<CreateBranchRuleRequest, lro::Operation>("CreateBranchRule", grpcClient.CreateBranchRuleAsync, grpcClient.CreateBranchRule, effectiveSettings.CreateBranchRuleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBranchRule);
            Modify_CreateBranchRuleApiCall(ref _callCreateBranchRule);
            _callListBranchRules = clientHelper.BuildApiCall<ListBranchRulesRequest, ListBranchRulesResponse>("ListBranchRules", grpcClient.ListBranchRulesAsync, grpcClient.ListBranchRules, effectiveSettings.ListBranchRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBranchRules);
            Modify_ListBranchRulesApiCall(ref _callListBranchRules);
            _callGetBranchRule = clientHelper.BuildApiCall<GetBranchRuleRequest, BranchRule>("GetBranchRule", grpcClient.GetBranchRuleAsync, grpcClient.GetBranchRule, effectiveSettings.GetBranchRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBranchRule);
            Modify_GetBranchRuleApiCall(ref _callGetBranchRule);
            _callUpdateBranchRule = clientHelper.BuildApiCall<UpdateBranchRuleRequest, lro::Operation>("UpdateBranchRule", grpcClient.UpdateBranchRuleAsync, grpcClient.UpdateBranchRule, effectiveSettings.UpdateBranchRuleSettings).WithGoogleRequestParam("branch_rule.name", request => request.BranchRule?.Name);
            Modify_ApiCall(ref _callUpdateBranchRule);
            Modify_UpdateBranchRuleApiCall(ref _callUpdateBranchRule);
            _callDeleteBranchRule = clientHelper.BuildApiCall<DeleteBranchRuleRequest, lro::Operation>("DeleteBranchRule", grpcClient.DeleteBranchRuleAsync, grpcClient.DeleteBranchRule, effectiveSettings.DeleteBranchRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBranchRule);
            Modify_DeleteBranchRuleApiCall(ref _callDeleteBranchRule);
            _callCreatePullRequest = clientHelper.BuildApiCall<CreatePullRequestRequest, lro::Operation>("CreatePullRequest", grpcClient.CreatePullRequestAsync, grpcClient.CreatePullRequest, effectiveSettings.CreatePullRequestSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePullRequest);
            Modify_CreatePullRequestApiCall(ref _callCreatePullRequest);
            _callGetPullRequest = clientHelper.BuildApiCall<GetPullRequestRequest, PullRequest>("GetPullRequest", grpcClient.GetPullRequestAsync, grpcClient.GetPullRequest, effectiveSettings.GetPullRequestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPullRequest);
            Modify_GetPullRequestApiCall(ref _callGetPullRequest);
            _callListPullRequests = clientHelper.BuildApiCall<ListPullRequestsRequest, ListPullRequestsResponse>("ListPullRequests", grpcClient.ListPullRequestsAsync, grpcClient.ListPullRequests, effectiveSettings.ListPullRequestsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPullRequests);
            Modify_ListPullRequestsApiCall(ref _callListPullRequests);
            _callUpdatePullRequest = clientHelper.BuildApiCall<UpdatePullRequestRequest, lro::Operation>("UpdatePullRequest", grpcClient.UpdatePullRequestAsync, grpcClient.UpdatePullRequest, effectiveSettings.UpdatePullRequestSettings).WithGoogleRequestParam("pull_request.name", request => request.PullRequest?.Name);
            Modify_ApiCall(ref _callUpdatePullRequest);
            Modify_UpdatePullRequestApiCall(ref _callUpdatePullRequest);
            _callMergePullRequest = clientHelper.BuildApiCall<MergePullRequestRequest, lro::Operation>("MergePullRequest", grpcClient.MergePullRequestAsync, grpcClient.MergePullRequest, effectiveSettings.MergePullRequestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMergePullRequest);
            Modify_MergePullRequestApiCall(ref _callMergePullRequest);
            _callOpenPullRequest = clientHelper.BuildApiCall<OpenPullRequestRequest, lro::Operation>("OpenPullRequest", grpcClient.OpenPullRequestAsync, grpcClient.OpenPullRequest, effectiveSettings.OpenPullRequestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callOpenPullRequest);
            Modify_OpenPullRequestApiCall(ref _callOpenPullRequest);
            _callClosePullRequest = clientHelper.BuildApiCall<ClosePullRequestRequest, lro::Operation>("ClosePullRequest", grpcClient.ClosePullRequestAsync, grpcClient.ClosePullRequest, effectiveSettings.ClosePullRequestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callClosePullRequest);
            Modify_ClosePullRequestApiCall(ref _callClosePullRequest);
            _callListPullRequestFileDiffs = clientHelper.BuildApiCall<ListPullRequestFileDiffsRequest, ListPullRequestFileDiffsResponse>("ListPullRequestFileDiffs", grpcClient.ListPullRequestFileDiffsAsync, grpcClient.ListPullRequestFileDiffs, effectiveSettings.ListPullRequestFileDiffsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListPullRequestFileDiffs);
            Modify_ListPullRequestFileDiffsApiCall(ref _callListPullRequestFileDiffs);
            _callFetchTree = clientHelper.BuildApiCall<FetchTreeRequest, FetchTreeResponse>("FetchTree", grpcClient.FetchTreeAsync, grpcClient.FetchTree, effectiveSettings.FetchTreeSettings).WithGoogleRequestParam("repository", request => request.Repository);
            Modify_ApiCall(ref _callFetchTree);
            Modify_FetchTreeApiCall(ref _callFetchTree);
            _callFetchBlob = clientHelper.BuildApiCall<FetchBlobRequest, FetchBlobResponse>("FetchBlob", grpcClient.FetchBlobAsync, grpcClient.FetchBlob, effectiveSettings.FetchBlobSettings).WithGoogleRequestParam("repository", request => request.Repository);
            Modify_ApiCall(ref _callFetchBlob);
            Modify_FetchBlobApiCall(ref _callFetchBlob);
            _callCreateIssue = clientHelper.BuildApiCall<CreateIssueRequest, lro::Operation>("CreateIssue", grpcClient.CreateIssueAsync, grpcClient.CreateIssue, effectiveSettings.CreateIssueSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIssue);
            Modify_CreateIssueApiCall(ref _callCreateIssue);
            _callGetIssue = clientHelper.BuildApiCall<GetIssueRequest, Issue>("GetIssue", grpcClient.GetIssueAsync, grpcClient.GetIssue, effectiveSettings.GetIssueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIssue);
            Modify_GetIssueApiCall(ref _callGetIssue);
            _callListIssues = clientHelper.BuildApiCall<ListIssuesRequest, ListIssuesResponse>("ListIssues", grpcClient.ListIssuesAsync, grpcClient.ListIssues, effectiveSettings.ListIssuesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIssues);
            Modify_ListIssuesApiCall(ref _callListIssues);
            _callUpdateIssue = clientHelper.BuildApiCall<UpdateIssueRequest, lro::Operation>("UpdateIssue", grpcClient.UpdateIssueAsync, grpcClient.UpdateIssue, effectiveSettings.UpdateIssueSettings).WithGoogleRequestParam("issue.name", request => request.Issue?.Name);
            Modify_ApiCall(ref _callUpdateIssue);
            Modify_UpdateIssueApiCall(ref _callUpdateIssue);
            _callDeleteIssue = clientHelper.BuildApiCall<DeleteIssueRequest, lro::Operation>("DeleteIssue", grpcClient.DeleteIssueAsync, grpcClient.DeleteIssue, effectiveSettings.DeleteIssueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIssue);
            Modify_DeleteIssueApiCall(ref _callDeleteIssue);
            _callOpenIssue = clientHelper.BuildApiCall<OpenIssueRequest, lro::Operation>("OpenIssue", grpcClient.OpenIssueAsync, grpcClient.OpenIssue, effectiveSettings.OpenIssueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callOpenIssue);
            Modify_OpenIssueApiCall(ref _callOpenIssue);
            _callCloseIssue = clientHelper.BuildApiCall<CloseIssueRequest, lro::Operation>("CloseIssue", grpcClient.CloseIssueAsync, grpcClient.CloseIssue, effectiveSettings.CloseIssueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCloseIssue);
            Modify_CloseIssueApiCall(ref _callCloseIssue);
            _callGetPullRequestComment = clientHelper.BuildApiCall<GetPullRequestCommentRequest, PullRequestComment>("GetPullRequestComment", grpcClient.GetPullRequestCommentAsync, grpcClient.GetPullRequestComment, effectiveSettings.GetPullRequestCommentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPullRequestComment);
            Modify_GetPullRequestCommentApiCall(ref _callGetPullRequestComment);
            _callListPullRequestComments = clientHelper.BuildApiCall<ListPullRequestCommentsRequest, ListPullRequestCommentsResponse>("ListPullRequestComments", grpcClient.ListPullRequestCommentsAsync, grpcClient.ListPullRequestComments, effectiveSettings.ListPullRequestCommentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPullRequestComments);
            Modify_ListPullRequestCommentsApiCall(ref _callListPullRequestComments);
            _callCreatePullRequestComment = clientHelper.BuildApiCall<CreatePullRequestCommentRequest, lro::Operation>("CreatePullRequestComment", grpcClient.CreatePullRequestCommentAsync, grpcClient.CreatePullRequestComment, effectiveSettings.CreatePullRequestCommentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePullRequestComment);
            Modify_CreatePullRequestCommentApiCall(ref _callCreatePullRequestComment);
            _callUpdatePullRequestComment = clientHelper.BuildApiCall<UpdatePullRequestCommentRequest, lro::Operation>("UpdatePullRequestComment", grpcClient.UpdatePullRequestCommentAsync, grpcClient.UpdatePullRequestComment, effectiveSettings.UpdatePullRequestCommentSettings).WithGoogleRequestParam("pull_request_comment.name", request => request.PullRequestComment?.Name);
            Modify_ApiCall(ref _callUpdatePullRequestComment);
            Modify_UpdatePullRequestCommentApiCall(ref _callUpdatePullRequestComment);
            _callDeletePullRequestComment = clientHelper.BuildApiCall<DeletePullRequestCommentRequest, lro::Operation>("DeletePullRequestComment", grpcClient.DeletePullRequestCommentAsync, grpcClient.DeletePullRequestComment, effectiveSettings.DeletePullRequestCommentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePullRequestComment);
            Modify_DeletePullRequestCommentApiCall(ref _callDeletePullRequestComment);
            _callBatchCreatePullRequestComments = clientHelper.BuildApiCall<BatchCreatePullRequestCommentsRequest, lro::Operation>("BatchCreatePullRequestComments", grpcClient.BatchCreatePullRequestCommentsAsync, grpcClient.BatchCreatePullRequestComments, effectiveSettings.BatchCreatePullRequestCommentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreatePullRequestComments);
            Modify_BatchCreatePullRequestCommentsApiCall(ref _callBatchCreatePullRequestComments);
            _callResolvePullRequestComments = clientHelper.BuildApiCall<ResolvePullRequestCommentsRequest, lro::Operation>("ResolvePullRequestComments", grpcClient.ResolvePullRequestCommentsAsync, grpcClient.ResolvePullRequestComments, effectiveSettings.ResolvePullRequestCommentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callResolvePullRequestComments);
            Modify_ResolvePullRequestCommentsApiCall(ref _callResolvePullRequestComments);
            _callUnresolvePullRequestComments = clientHelper.BuildApiCall<UnresolvePullRequestCommentsRequest, lro::Operation>("UnresolvePullRequestComments", grpcClient.UnresolvePullRequestCommentsAsync, grpcClient.UnresolvePullRequestComments, effectiveSettings.UnresolvePullRequestCommentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callUnresolvePullRequestComments);
            Modify_UnresolvePullRequestCommentsApiCall(ref _callUnresolvePullRequestComments);
            _callCreateIssueComment = clientHelper.BuildApiCall<CreateIssueCommentRequest, lro::Operation>("CreateIssueComment", grpcClient.CreateIssueCommentAsync, grpcClient.CreateIssueComment, effectiveSettings.CreateIssueCommentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIssueComment);
            Modify_CreateIssueCommentApiCall(ref _callCreateIssueComment);
            _callGetIssueComment = clientHelper.BuildApiCall<GetIssueCommentRequest, IssueComment>("GetIssueComment", grpcClient.GetIssueCommentAsync, grpcClient.GetIssueComment, effectiveSettings.GetIssueCommentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIssueComment);
            Modify_GetIssueCommentApiCall(ref _callGetIssueComment);
            _callListIssueComments = clientHelper.BuildApiCall<ListIssueCommentsRequest, ListIssueCommentsResponse>("ListIssueComments", grpcClient.ListIssueCommentsAsync, grpcClient.ListIssueComments, effectiveSettings.ListIssueCommentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIssueComments);
            Modify_ListIssueCommentsApiCall(ref _callListIssueComments);
            _callUpdateIssueComment = clientHelper.BuildApiCall<UpdateIssueCommentRequest, lro::Operation>("UpdateIssueComment", grpcClient.UpdateIssueCommentAsync, grpcClient.UpdateIssueComment, effectiveSettings.UpdateIssueCommentSettings).WithGoogleRequestParam("issue_comment.name", request => request.IssueComment?.Name);
            Modify_ApiCall(ref _callUpdateIssueComment);
            Modify_UpdateIssueCommentApiCall(ref _callUpdateIssueComment);
            _callDeleteIssueComment = clientHelper.BuildApiCall<DeleteIssueCommentRequest, lro::Operation>("DeleteIssueComment", grpcClient.DeleteIssueCommentAsync, grpcClient.DeleteIssueComment, effectiveSettings.DeleteIssueCommentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIssueComment);
            Modify_DeleteIssueCommentApiCall(ref _callDeleteIssueComment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);

        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> call);

        partial void Modify_ListRepositoriesApiCall(ref gaxgrpc::ApiCall<ListRepositoriesRequest, ListRepositoriesResponse> call);

        partial void Modify_GetRepositoryApiCall(ref gaxgrpc::ApiCall<GetRepositoryRequest, Repository> call);

        partial void Modify_CreateRepositoryApiCall(ref gaxgrpc::ApiCall<CreateRepositoryRequest, lro::Operation> call);

        partial void Modify_UpdateRepositoryApiCall(ref gaxgrpc::ApiCall<UpdateRepositoryRequest, lro::Operation> call);

        partial void Modify_DeleteRepositoryApiCall(ref gaxgrpc::ApiCall<DeleteRepositoryRequest, lro::Operation> call);

        partial void Modify_ListHooksApiCall(ref gaxgrpc::ApiCall<ListHooksRequest, ListHooksResponse> call);

        partial void Modify_GetHookApiCall(ref gaxgrpc::ApiCall<GetHookRequest, Hook> call);

        partial void Modify_CreateHookApiCall(ref gaxgrpc::ApiCall<CreateHookRequest, lro::Operation> call);

        partial void Modify_UpdateHookApiCall(ref gaxgrpc::ApiCall<UpdateHookRequest, lro::Operation> call);

        partial void Modify_DeleteHookApiCall(ref gaxgrpc::ApiCall<DeleteHookRequest, lro::Operation> call);

        partial void Modify_GetIamPolicyRepoApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyRepoApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsRepoApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_CreateBranchRuleApiCall(ref gaxgrpc::ApiCall<CreateBranchRuleRequest, lro::Operation> call);

        partial void Modify_ListBranchRulesApiCall(ref gaxgrpc::ApiCall<ListBranchRulesRequest, ListBranchRulesResponse> call);

        partial void Modify_GetBranchRuleApiCall(ref gaxgrpc::ApiCall<GetBranchRuleRequest, BranchRule> call);

        partial void Modify_UpdateBranchRuleApiCall(ref gaxgrpc::ApiCall<UpdateBranchRuleRequest, lro::Operation> call);

        partial void Modify_DeleteBranchRuleApiCall(ref gaxgrpc::ApiCall<DeleteBranchRuleRequest, lro::Operation> call);

        partial void Modify_CreatePullRequestApiCall(ref gaxgrpc::ApiCall<CreatePullRequestRequest, lro::Operation> call);

        partial void Modify_GetPullRequestApiCall(ref gaxgrpc::ApiCall<GetPullRequestRequest, PullRequest> call);

        partial void Modify_ListPullRequestsApiCall(ref gaxgrpc::ApiCall<ListPullRequestsRequest, ListPullRequestsResponse> call);

        partial void Modify_UpdatePullRequestApiCall(ref gaxgrpc::ApiCall<UpdatePullRequestRequest, lro::Operation> call);

        partial void Modify_MergePullRequestApiCall(ref gaxgrpc::ApiCall<MergePullRequestRequest, lro::Operation> call);

        partial void Modify_OpenPullRequestApiCall(ref gaxgrpc::ApiCall<OpenPullRequestRequest, lro::Operation> call);

        partial void Modify_ClosePullRequestApiCall(ref gaxgrpc::ApiCall<ClosePullRequestRequest, lro::Operation> call);

        partial void Modify_ListPullRequestFileDiffsApiCall(ref gaxgrpc::ApiCall<ListPullRequestFileDiffsRequest, ListPullRequestFileDiffsResponse> call);

        partial void Modify_FetchTreeApiCall(ref gaxgrpc::ApiCall<FetchTreeRequest, FetchTreeResponse> call);

        partial void Modify_FetchBlobApiCall(ref gaxgrpc::ApiCall<FetchBlobRequest, FetchBlobResponse> call);

        partial void Modify_CreateIssueApiCall(ref gaxgrpc::ApiCall<CreateIssueRequest, lro::Operation> call);

        partial void Modify_GetIssueApiCall(ref gaxgrpc::ApiCall<GetIssueRequest, Issue> call);

        partial void Modify_ListIssuesApiCall(ref gaxgrpc::ApiCall<ListIssuesRequest, ListIssuesResponse> call);

        partial void Modify_UpdateIssueApiCall(ref gaxgrpc::ApiCall<UpdateIssueRequest, lro::Operation> call);

        partial void Modify_DeleteIssueApiCall(ref gaxgrpc::ApiCall<DeleteIssueRequest, lro::Operation> call);

        partial void Modify_OpenIssueApiCall(ref gaxgrpc::ApiCall<OpenIssueRequest, lro::Operation> call);

        partial void Modify_CloseIssueApiCall(ref gaxgrpc::ApiCall<CloseIssueRequest, lro::Operation> call);

        partial void Modify_GetPullRequestCommentApiCall(ref gaxgrpc::ApiCall<GetPullRequestCommentRequest, PullRequestComment> call);

        partial void Modify_ListPullRequestCommentsApiCall(ref gaxgrpc::ApiCall<ListPullRequestCommentsRequest, ListPullRequestCommentsResponse> call);

        partial void Modify_CreatePullRequestCommentApiCall(ref gaxgrpc::ApiCall<CreatePullRequestCommentRequest, lro::Operation> call);

        partial void Modify_UpdatePullRequestCommentApiCall(ref gaxgrpc::ApiCall<UpdatePullRequestCommentRequest, lro::Operation> call);

        partial void Modify_DeletePullRequestCommentApiCall(ref gaxgrpc::ApiCall<DeletePullRequestCommentRequest, lro::Operation> call);

        partial void Modify_BatchCreatePullRequestCommentsApiCall(ref gaxgrpc::ApiCall<BatchCreatePullRequestCommentsRequest, lro::Operation> call);

        partial void Modify_ResolvePullRequestCommentsApiCall(ref gaxgrpc::ApiCall<ResolvePullRequestCommentsRequest, lro::Operation> call);

        partial void Modify_UnresolvePullRequestCommentsApiCall(ref gaxgrpc::ApiCall<UnresolvePullRequestCommentsRequest, lro::Operation> call);

        partial void Modify_CreateIssueCommentApiCall(ref gaxgrpc::ApiCall<CreateIssueCommentRequest, lro::Operation> call);

        partial void Modify_GetIssueCommentApiCall(ref gaxgrpc::ApiCall<GetIssueCommentRequest, IssueComment> call);

        partial void Modify_ListIssueCommentsApiCall(ref gaxgrpc::ApiCall<ListIssueCommentsRequest, ListIssueCommentsResponse> call);

        partial void Modify_UpdateIssueCommentApiCall(ref gaxgrpc::ApiCall<UpdateIssueCommentRequest, lro::Operation> call);

        partial void Modify_DeleteIssueCommentApiCall(ref gaxgrpc::ApiCall<DeleteIssueCommentRequest, lro::Operation> call);

        partial void OnConstruction(SecureSourceManager.SecureSourceManagerClient grpcClient, SecureSourceManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SecureSourceManager client</summary>
        public override SecureSourceManager.SecureSourceManagerClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRepositoriesRequest(ref ListRepositoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRepositoryRequest(ref GetRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRepositoryRequest(ref CreateRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRepositoryRequest(ref UpdateRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRepositoryRequest(ref DeleteRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListHooksRequest(ref ListHooksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetHookRequest(ref GetHookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateHookRequest(ref CreateHookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateHookRequest(ref UpdateHookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteHookRequest(ref DeleteHookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBranchRuleRequest(ref CreateBranchRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBranchRulesRequest(ref ListBranchRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBranchRuleRequest(ref GetBranchRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBranchRuleRequest(ref UpdateBranchRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBranchRuleRequest(ref DeleteBranchRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePullRequestRequest(ref CreatePullRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPullRequestRequest(ref GetPullRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPullRequestsRequest(ref ListPullRequestsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePullRequestRequest(ref UpdatePullRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MergePullRequestRequest(ref MergePullRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_OpenPullRequestRequest(ref OpenPullRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ClosePullRequestRequest(ref ClosePullRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPullRequestFileDiffsRequest(ref ListPullRequestFileDiffsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchTreeRequest(ref FetchTreeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchBlobRequest(ref FetchBlobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateIssueRequest(ref CreateIssueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIssueRequest(ref GetIssueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIssuesRequest(ref ListIssuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateIssueRequest(ref UpdateIssueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIssueRequest(ref DeleteIssueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_OpenIssueRequest(ref OpenIssueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CloseIssueRequest(ref CloseIssueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPullRequestCommentRequest(ref GetPullRequestCommentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPullRequestCommentsRequest(ref ListPullRequestCommentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePullRequestCommentRequest(ref CreatePullRequestCommentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePullRequestCommentRequest(ref UpdatePullRequestCommentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePullRequestCommentRequest(ref DeletePullRequestCommentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreatePullRequestCommentsRequest(ref BatchCreatePullRequestCommentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResolvePullRequestCommentsRequest(ref ResolvePullRequestCommentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UnresolvePullRequestCommentsRequest(ref UnresolvePullRequestCommentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateIssueCommentRequest(ref CreateIssueCommentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIssueCommentRequest(ref GetIssueCommentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIssueCommentsRequest(ref ListIssueCommentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateIssueCommentRequest(ref UpdateIssueCommentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIssueCommentRequest(ref DeleteIssueCommentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public override lro::OperationsClient CreateInstanceOperationsClient { get; }

        /// <summary>
        /// Creates a new instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Creates a new instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public override lro::OperationsClient DeleteInstanceOperationsClient { get; }

        /// <summary>
        /// Deletes a single instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInstance.Sync(request, callSettings), DeleteInstanceOperationsClient);
        }

        /// <summary>
        /// Deletes a single instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInstance.Async(request, callSettings).ConfigureAwait(false), DeleteInstanceOperationsClient);
        }

        /// <summary>
        /// Lists Repositories in a given project and location.
        /// 
        /// The instance field is required in the query parameter for requests using
        /// the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public override gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRepositoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRepositoriesRequest, ListRepositoriesResponse, Repository>(_callListRepositories, request, callSettings);
        }

        /// <summary>
        /// Lists Repositories in a given project and location.
        /// 
        /// The instance field is required in the query parameter for requests using
        /// the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRepositoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRepositoriesRequest, ListRepositoriesResponse, Repository>(_callListRepositories, request, callSettings);
        }

        /// <summary>
        /// Gets metadata of a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Repository GetRepository(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRepositoryRequest(ref request, ref callSettings);
            return _callGetRepository.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets metadata of a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRepositoryRequest(ref request, ref callSettings);
            return _callGetRepository.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateRepository</c>.</summary>
        public override lro::OperationsClient CreateRepositoryOperationsClient { get; }

        /// <summary>
        /// Creates a new repository in a given project and location.
        /// 
        /// The Repository.Instance field is required in the request body for requests
        /// using the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Repository, OperationMetadata> CreateRepository(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<Repository, OperationMetadata>(_callCreateRepository.Sync(request, callSettings), CreateRepositoryOperationsClient);
        }

        /// <summary>
        /// Creates a new repository in a given project and location.
        /// 
        /// The Repository.Instance field is required in the request body for requests
        /// using the securesourcemanager.googleapis.com endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<Repository, OperationMetadata>(await _callCreateRepository.Async(request, callSettings).ConfigureAwait(false), CreateRepositoryOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateRepository</c>.</summary>
        public override lro::OperationsClient UpdateRepositoryOperationsClient { get; }

        /// <summary>
        /// Updates the metadata of a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Repository, OperationMetadata> UpdateRepository(UpdateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<Repository, OperationMetadata>(_callUpdateRepository.Sync(request, callSettings), UpdateRepositoryOperationsClient);
        }

        /// <summary>
        /// Updates the metadata of a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Repository, OperationMetadata>> UpdateRepositoryAsync(UpdateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<Repository, OperationMetadata>(await _callUpdateRepository.Async(request, callSettings).ConfigureAwait(false), UpdateRepositoryOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteRepository</c>.</summary>
        public override lro::OperationsClient DeleteRepositoryOperationsClient { get; }

        /// <summary>
        /// Deletes a Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteRepository(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteRepository.Sync(request, callSettings), DeleteRepositoryOperationsClient);
        }

        /// <summary>
        /// Deletes a Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteRepository.Async(request, callSettings).ConfigureAwait(false), DeleteRepositoryOperationsClient);
        }

        /// <summary>
        /// Lists hooks in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Hook"/> resources.</returns>
        public override gax::PagedEnumerable<ListHooksResponse, Hook> ListHooks(ListHooksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHooksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHooksRequest, ListHooksResponse, Hook>(_callListHooks, request, callSettings);
        }

        /// <summary>
        /// Lists hooks in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Hook"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListHooksResponse, Hook> ListHooksAsync(ListHooksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHooksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHooksRequest, ListHooksResponse, Hook>(_callListHooks, request, callSettings);
        }

        /// <summary>
        /// Gets metadata of a hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Hook GetHook(GetHookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHookRequest(ref request, ref callSettings);
            return _callGetHook.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets metadata of a hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Hook> GetHookAsync(GetHookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHookRequest(ref request, ref callSettings);
            return _callGetHook.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateHook</c>.</summary>
        public override lro::OperationsClient CreateHookOperationsClient { get; }

        /// <summary>
        /// Creates a new hook in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Hook, OperationMetadata> CreateHook(CreateHookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHookRequest(ref request, ref callSettings);
            return new lro::Operation<Hook, OperationMetadata>(_callCreateHook.Sync(request, callSettings), CreateHookOperationsClient);
        }

        /// <summary>
        /// Creates a new hook in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Hook, OperationMetadata>> CreateHookAsync(CreateHookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHookRequest(ref request, ref callSettings);
            return new lro::Operation<Hook, OperationMetadata>(await _callCreateHook.Async(request, callSettings).ConfigureAwait(false), CreateHookOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateHook</c>.</summary>
        public override lro::OperationsClient UpdateHookOperationsClient { get; }

        /// <summary>
        /// Updates the metadata of a hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Hook, OperationMetadata> UpdateHook(UpdateHookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHookRequest(ref request, ref callSettings);
            return new lro::Operation<Hook, OperationMetadata>(_callUpdateHook.Sync(request, callSettings), UpdateHookOperationsClient);
        }

        /// <summary>
        /// Updates the metadata of a hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Hook, OperationMetadata>> UpdateHookAsync(UpdateHookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHookRequest(ref request, ref callSettings);
            return new lro::Operation<Hook, OperationMetadata>(await _callUpdateHook.Async(request, callSettings).ConfigureAwait(false), UpdateHookOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteHook</c>.</summary>
        public override lro::OperationsClient DeleteHookOperationsClient { get; }

        /// <summary>
        /// Deletes a Hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteHook(DeleteHookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHookRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteHook.Sync(request, callSettings), DeleteHookOperationsClient);
        }

        /// <summary>
        /// Deletes a Hook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHookAsync(DeleteHookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHookRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteHook.Async(request, callSettings).ConfigureAwait(false), DeleteHookOperationsClient);
        }

        /// <summary>
        /// Get IAM policy for a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicyRepo(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicyRepo.Sync(request, callSettings);
        }

        /// <summary>
        /// Get IAM policy for a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyRepoAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicyRepo.Async(request, callSettings);
        }

        /// <summary>
        /// Set IAM policy on a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicyRepo(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicyRepo.Sync(request, callSettings);
        }

        /// <summary>
        /// Set IAM policy on a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyRepoAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicyRepo.Async(request, callSettings);
        }

        /// <summary>
        /// Test IAM permissions on a repository.
        /// IAM permission checks are not required on this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissionsRepo(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissionsRepo.Sync(request, callSettings);
        }

        /// <summary>
        /// Test IAM permissions on a repository.
        /// IAM permission checks are not required on this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsRepoAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissionsRepo.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateBranchRule</c>.</summary>
        public override lro::OperationsClient CreateBranchRuleOperationsClient { get; }

        /// <summary>
        /// CreateBranchRule creates a branch rule in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BranchRule, OperationMetadata> CreateBranchRule(CreateBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBranchRuleRequest(ref request, ref callSettings);
            return new lro::Operation<BranchRule, OperationMetadata>(_callCreateBranchRule.Sync(request, callSettings), CreateBranchRuleOperationsClient);
        }

        /// <summary>
        /// CreateBranchRule creates a branch rule in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BranchRule, OperationMetadata>> CreateBranchRuleAsync(CreateBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBranchRuleRequest(ref request, ref callSettings);
            return new lro::Operation<BranchRule, OperationMetadata>(await _callCreateBranchRule.Async(request, callSettings).ConfigureAwait(false), CreateBranchRuleOperationsClient);
        }

        /// <summary>
        /// ListBranchRules lists branch rules in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BranchRule"/> resources.</returns>
        public override gax::PagedEnumerable<ListBranchRulesResponse, BranchRule> ListBranchRules(ListBranchRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBranchRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBranchRulesRequest, ListBranchRulesResponse, BranchRule>(_callListBranchRules, request, callSettings);
        }

        /// <summary>
        /// ListBranchRules lists branch rules in a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BranchRule"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBranchRulesResponse, BranchRule> ListBranchRulesAsync(ListBranchRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBranchRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBranchRulesRequest, ListBranchRulesResponse, BranchRule>(_callListBranchRules, request, callSettings);
        }

        /// <summary>
        /// GetBranchRule gets a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BranchRule GetBranchRule(GetBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBranchRuleRequest(ref request, ref callSettings);
            return _callGetBranchRule.Sync(request, callSettings);
        }

        /// <summary>
        /// GetBranchRule gets a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BranchRule> GetBranchRuleAsync(GetBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBranchRuleRequest(ref request, ref callSettings);
            return _callGetBranchRule.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateBranchRule</c>.</summary>
        public override lro::OperationsClient UpdateBranchRuleOperationsClient { get; }

        /// <summary>
        /// UpdateBranchRule updates a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BranchRule, OperationMetadata> UpdateBranchRule(UpdateBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBranchRuleRequest(ref request, ref callSettings);
            return new lro::Operation<BranchRule, OperationMetadata>(_callUpdateBranchRule.Sync(request, callSettings), UpdateBranchRuleOperationsClient);
        }

        /// <summary>
        /// UpdateBranchRule updates a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BranchRule, OperationMetadata>> UpdateBranchRuleAsync(UpdateBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBranchRuleRequest(ref request, ref callSettings);
            return new lro::Operation<BranchRule, OperationMetadata>(await _callUpdateBranchRule.Async(request, callSettings).ConfigureAwait(false), UpdateBranchRuleOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteBranchRule</c>.</summary>
        public override lro::OperationsClient DeleteBranchRuleOperationsClient { get; }

        /// <summary>
        /// DeleteBranchRule deletes a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteBranchRule(DeleteBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBranchRuleRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteBranchRule.Sync(request, callSettings), DeleteBranchRuleOperationsClient);
        }

        /// <summary>
        /// DeleteBranchRule deletes a branch rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBranchRuleAsync(DeleteBranchRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBranchRuleRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBranchRule.Async(request, callSettings).ConfigureAwait(false), DeleteBranchRuleOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreatePullRequest</c>.</summary>
        public override lro::OperationsClient CreatePullRequestOperationsClient { get; }

        /// <summary>
        /// Creates a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PullRequest, OperationMetadata> CreatePullRequest(CreatePullRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePullRequestRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequest, OperationMetadata>(_callCreatePullRequest.Sync(request, callSettings), CreatePullRequestOperationsClient);
        }

        /// <summary>
        /// Creates a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PullRequest, OperationMetadata>> CreatePullRequestAsync(CreatePullRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePullRequestRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequest, OperationMetadata>(await _callCreatePullRequest.Async(request, callSettings).ConfigureAwait(false), CreatePullRequestOperationsClient);
        }

        /// <summary>
        /// Gets a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PullRequest GetPullRequest(GetPullRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPullRequestRequest(ref request, ref callSettings);
            return _callGetPullRequest.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PullRequest> GetPullRequestAsync(GetPullRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPullRequestRequest(ref request, ref callSettings);
            return _callGetPullRequest.Async(request, callSettings);
        }

        /// <summary>
        /// Lists pull requests in a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PullRequest"/> resources.</returns>
        public override gax::PagedEnumerable<ListPullRequestsResponse, PullRequest> ListPullRequests(ListPullRequestsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPullRequestsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPullRequestsRequest, ListPullRequestsResponse, PullRequest>(_callListPullRequests, request, callSettings);
        }

        /// <summary>
        /// Lists pull requests in a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PullRequest"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPullRequestsResponse, PullRequest> ListPullRequestsAsync(ListPullRequestsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPullRequestsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPullRequestsRequest, ListPullRequestsResponse, PullRequest>(_callListPullRequests, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdatePullRequest</c>.</summary>
        public override lro::OperationsClient UpdatePullRequestOperationsClient { get; }

        /// <summary>
        /// Updates a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PullRequest, OperationMetadata> UpdatePullRequest(UpdatePullRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePullRequestRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequest, OperationMetadata>(_callUpdatePullRequest.Sync(request, callSettings), UpdatePullRequestOperationsClient);
        }

        /// <summary>
        /// Updates a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PullRequest, OperationMetadata>> UpdatePullRequestAsync(UpdatePullRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePullRequestRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequest, OperationMetadata>(await _callUpdatePullRequest.Async(request, callSettings).ConfigureAwait(false), UpdatePullRequestOperationsClient);
        }

        /// <summary>The long-running operations client for <c>MergePullRequest</c>.</summary>
        public override lro::OperationsClient MergePullRequestOperationsClient { get; }

        /// <summary>
        /// Merges a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PullRequest, OperationMetadata> MergePullRequest(MergePullRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MergePullRequestRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequest, OperationMetadata>(_callMergePullRequest.Sync(request, callSettings), MergePullRequestOperationsClient);
        }

        /// <summary>
        /// Merges a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PullRequest, OperationMetadata>> MergePullRequestAsync(MergePullRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MergePullRequestRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequest, OperationMetadata>(await _callMergePullRequest.Async(request, callSettings).ConfigureAwait(false), MergePullRequestOperationsClient);
        }

        /// <summary>The long-running operations client for <c>OpenPullRequest</c>.</summary>
        public override lro::OperationsClient OpenPullRequestOperationsClient { get; }

        /// <summary>
        /// Opens a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PullRequest, OperationMetadata> OpenPullRequest(OpenPullRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_OpenPullRequestRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequest, OperationMetadata>(_callOpenPullRequest.Sync(request, callSettings), OpenPullRequestOperationsClient);
        }

        /// <summary>
        /// Opens a pull request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PullRequest, OperationMetadata>> OpenPullRequestAsync(OpenPullRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_OpenPullRequestRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequest, OperationMetadata>(await _callOpenPullRequest.Async(request, callSettings).ConfigureAwait(false), OpenPullRequestOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ClosePullRequest</c>.</summary>
        public override lro::OperationsClient ClosePullRequestOperationsClient { get; }

        /// <summary>
        /// Closes a pull request without merging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PullRequest, OperationMetadata> ClosePullRequest(ClosePullRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClosePullRequestRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequest, OperationMetadata>(_callClosePullRequest.Sync(request, callSettings), ClosePullRequestOperationsClient);
        }

        /// <summary>
        /// Closes a pull request without merging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PullRequest, OperationMetadata>> ClosePullRequestAsync(ClosePullRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClosePullRequestRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequest, OperationMetadata>(await _callClosePullRequest.Async(request, callSettings).ConfigureAwait(false), ClosePullRequestOperationsClient);
        }

        /// <summary>
        /// Lists a pull request's file diffs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FileDiff"/> resources.</returns>
        public override gax::PagedEnumerable<ListPullRequestFileDiffsResponse, FileDiff> ListPullRequestFileDiffs(ListPullRequestFileDiffsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPullRequestFileDiffsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPullRequestFileDiffsRequest, ListPullRequestFileDiffsResponse, FileDiff>(_callListPullRequestFileDiffs, request, callSettings);
        }

        /// <summary>
        /// Lists a pull request's file diffs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FileDiff"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPullRequestFileDiffsResponse, FileDiff> ListPullRequestFileDiffsAsync(ListPullRequestFileDiffsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPullRequestFileDiffsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPullRequestFileDiffsRequest, ListPullRequestFileDiffsResponse, FileDiff>(_callListPullRequestFileDiffs, request, callSettings);
        }

        /// <summary>
        /// Fetches a tree from a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TreeEntry"/> resources.</returns>
        public override gax::PagedEnumerable<FetchTreeResponse, TreeEntry> FetchTree(FetchTreeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchTreeRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchTreeRequest, FetchTreeResponse, TreeEntry>(_callFetchTree, request, callSettings);
        }

        /// <summary>
        /// Fetches a tree from a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TreeEntry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchTreeResponse, TreeEntry> FetchTreeAsync(FetchTreeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchTreeRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchTreeRequest, FetchTreeResponse, TreeEntry>(_callFetchTree, request, callSettings);
        }

        /// <summary>
        /// Fetches a blob from a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchBlobResponse FetchBlob(FetchBlobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchBlobRequest(ref request, ref callSettings);
            return _callFetchBlob.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches a blob from a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchBlobResponse> FetchBlobAsync(FetchBlobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchBlobRequest(ref request, ref callSettings);
            return _callFetchBlob.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateIssue</c>.</summary>
        public override lro::OperationsClient CreateIssueOperationsClient { get; }

        /// <summary>
        /// Creates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Issue, OperationMetadata> CreateIssue(CreateIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIssueRequest(ref request, ref callSettings);
            return new lro::Operation<Issue, OperationMetadata>(_callCreateIssue.Sync(request, callSettings), CreateIssueOperationsClient);
        }

        /// <summary>
        /// Creates an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Issue, OperationMetadata>> CreateIssueAsync(CreateIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIssueRequest(ref request, ref callSettings);
            return new lro::Operation<Issue, OperationMetadata>(await _callCreateIssue.Async(request, callSettings).ConfigureAwait(false), CreateIssueOperationsClient);
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
        /// Lists issues in a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Issue"/> resources.</returns>
        public override gax::PagedEnumerable<ListIssuesResponse, Issue> ListIssues(ListIssuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIssuesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIssuesRequest, ListIssuesResponse, Issue>(_callListIssues, request, callSettings);
        }

        /// <summary>
        /// Lists issues in a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Issue"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListIssuesResponse, Issue> ListIssuesAsync(ListIssuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIssuesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIssuesRequest, ListIssuesResponse, Issue>(_callListIssues, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateIssue</c>.</summary>
        public override lro::OperationsClient UpdateIssueOperationsClient { get; }

        /// <summary>
        /// Updates a issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Issue, OperationMetadata> UpdateIssue(UpdateIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIssueRequest(ref request, ref callSettings);
            return new lro::Operation<Issue, OperationMetadata>(_callUpdateIssue.Sync(request, callSettings), UpdateIssueOperationsClient);
        }

        /// <summary>
        /// Updates a issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Issue, OperationMetadata>> UpdateIssueAsync(UpdateIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIssueRequest(ref request, ref callSettings);
            return new lro::Operation<Issue, OperationMetadata>(await _callUpdateIssue.Async(request, callSettings).ConfigureAwait(false), UpdateIssueOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteIssue</c>.</summary>
        public override lro::OperationsClient DeleteIssueOperationsClient { get; }

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteIssue(DeleteIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIssueRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteIssue.Sync(request, callSettings), DeleteIssueOperationsClient);
        }

        /// <summary>
        /// Deletes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueAsync(DeleteIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIssueRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteIssue.Async(request, callSettings).ConfigureAwait(false), DeleteIssueOperationsClient);
        }

        /// <summary>The long-running operations client for <c>OpenIssue</c>.</summary>
        public override lro::OperationsClient OpenIssueOperationsClient { get; }

        /// <summary>
        /// Opens an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Issue, OperationMetadata> OpenIssue(OpenIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_OpenIssueRequest(ref request, ref callSettings);
            return new lro::Operation<Issue, OperationMetadata>(_callOpenIssue.Sync(request, callSettings), OpenIssueOperationsClient);
        }

        /// <summary>
        /// Opens an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Issue, OperationMetadata>> OpenIssueAsync(OpenIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_OpenIssueRequest(ref request, ref callSettings);
            return new lro::Operation<Issue, OperationMetadata>(await _callOpenIssue.Async(request, callSettings).ConfigureAwait(false), OpenIssueOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CloseIssue</c>.</summary>
        public override lro::OperationsClient CloseIssueOperationsClient { get; }

        /// <summary>
        /// Closes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Issue, OperationMetadata> CloseIssue(CloseIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CloseIssueRequest(ref request, ref callSettings);
            return new lro::Operation<Issue, OperationMetadata>(_callCloseIssue.Sync(request, callSettings), CloseIssueOperationsClient);
        }

        /// <summary>
        /// Closes an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Issue, OperationMetadata>> CloseIssueAsync(CloseIssueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CloseIssueRequest(ref request, ref callSettings);
            return new lro::Operation<Issue, OperationMetadata>(await _callCloseIssue.Async(request, callSettings).ConfigureAwait(false), CloseIssueOperationsClient);
        }

        /// <summary>
        /// Gets a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PullRequestComment GetPullRequestComment(GetPullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPullRequestCommentRequest(ref request, ref callSettings);
            return _callGetPullRequestComment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PullRequestComment> GetPullRequestCommentAsync(GetPullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPullRequestCommentRequest(ref request, ref callSettings);
            return _callGetPullRequestComment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PullRequestComment"/> resources.</returns>
        public override gax::PagedEnumerable<ListPullRequestCommentsResponse, PullRequestComment> ListPullRequestComments(ListPullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPullRequestCommentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPullRequestCommentsRequest, ListPullRequestCommentsResponse, PullRequestComment>(_callListPullRequestComments, request, callSettings);
        }

        /// <summary>
        /// Lists pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PullRequestComment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPullRequestCommentsResponse, PullRequestComment> ListPullRequestCommentsAsync(ListPullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPullRequestCommentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPullRequestCommentsRequest, ListPullRequestCommentsResponse, PullRequestComment>(_callListPullRequestComments, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreatePullRequestComment</c>.</summary>
        public override lro::OperationsClient CreatePullRequestCommentOperationsClient { get; }

        /// <summary>
        /// Creates a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PullRequestComment, OperationMetadata> CreatePullRequestComment(CreatePullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePullRequestCommentRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequestComment, OperationMetadata>(_callCreatePullRequestComment.Sync(request, callSettings), CreatePullRequestCommentOperationsClient);
        }

        /// <summary>
        /// Creates a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> CreatePullRequestCommentAsync(CreatePullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePullRequestCommentRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequestComment, OperationMetadata>(await _callCreatePullRequestComment.Async(request, callSettings).ConfigureAwait(false), CreatePullRequestCommentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdatePullRequestComment</c>.</summary>
        public override lro::OperationsClient UpdatePullRequestCommentOperationsClient { get; }

        /// <summary>
        /// Updates a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PullRequestComment, OperationMetadata> UpdatePullRequestComment(UpdatePullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePullRequestCommentRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequestComment, OperationMetadata>(_callUpdatePullRequestComment.Sync(request, callSettings), UpdatePullRequestCommentOperationsClient);
        }

        /// <summary>
        /// Updates a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PullRequestComment, OperationMetadata>> UpdatePullRequestCommentAsync(UpdatePullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePullRequestCommentRequest(ref request, ref callSettings);
            return new lro::Operation<PullRequestComment, OperationMetadata>(await _callUpdatePullRequestComment.Async(request, callSettings).ConfigureAwait(false), UpdatePullRequestCommentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeletePullRequestComment</c>.</summary>
        public override lro::OperationsClient DeletePullRequestCommentOperationsClient { get; }

        /// <summary>
        /// Deletes a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeletePullRequestComment(DeletePullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePullRequestCommentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeletePullRequestComment.Sync(request, callSettings), DeletePullRequestCommentOperationsClient);
        }

        /// <summary>
        /// Deletes a pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePullRequestCommentAsync(DeletePullRequestCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePullRequestCommentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeletePullRequestComment.Async(request, callSettings).ConfigureAwait(false), DeletePullRequestCommentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchCreatePullRequestComments</c>.</summary>
        public override lro::OperationsClient BatchCreatePullRequestCommentsOperationsClient { get; }

        /// <summary>
        /// Batch creates pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> BatchCreatePullRequestComments(BatchCreatePullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreatePullRequestCommentsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata>(_callBatchCreatePullRequestComments.Sync(request, callSettings), BatchCreatePullRequestCommentsOperationsClient);
        }

        /// <summary>
        /// Batch creates pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata>> BatchCreatePullRequestCommentsAsync(BatchCreatePullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreatePullRequestCommentsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata>(await _callBatchCreatePullRequestComments.Async(request, callSettings).ConfigureAwait(false), BatchCreatePullRequestCommentsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ResolvePullRequestComments</c>.</summary>
        public override lro::OperationsClient ResolvePullRequestCommentsOperationsClient { get; }

        /// <summary>
        /// Resolves pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata> ResolvePullRequestComments(ResolvePullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolvePullRequestCommentsRequest(ref request, ref callSettings);
            return new lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata>(_callResolvePullRequestComments.Sync(request, callSettings), ResolvePullRequestCommentsOperationsClient);
        }

        /// <summary>
        /// Resolves pull request comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata>> ResolvePullRequestCommentsAsync(ResolvePullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolvePullRequestCommentsRequest(ref request, ref callSettings);
            return new lro::Operation<ResolvePullRequestCommentsResponse, OperationMetadata>(await _callResolvePullRequestComments.Async(request, callSettings).ConfigureAwait(false), ResolvePullRequestCommentsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UnresolvePullRequestComments</c>.</summary>
        public override lro::OperationsClient UnresolvePullRequestCommentsOperationsClient { get; }

        /// <summary>
        /// Unresolves pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> UnresolvePullRequestComments(UnresolvePullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnresolvePullRequestCommentsRequest(ref request, ref callSettings);
            return new lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata>(_callUnresolvePullRequestComments.Sync(request, callSettings), UnresolvePullRequestCommentsOperationsClient);
        }

        /// <summary>
        /// Unresolves pull request comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata>> UnresolvePullRequestCommentsAsync(UnresolvePullRequestCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnresolvePullRequestCommentsRequest(ref request, ref callSettings);
            return new lro::Operation<UnresolvePullRequestCommentsResponse, OperationMetadata>(await _callUnresolvePullRequestComments.Async(request, callSettings).ConfigureAwait(false), UnresolvePullRequestCommentsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateIssueComment</c>.</summary>
        public override lro::OperationsClient CreateIssueCommentOperationsClient { get; }

        /// <summary>
        /// Creates an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<IssueComment, OperationMetadata> CreateIssueComment(CreateIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIssueCommentRequest(ref request, ref callSettings);
            return new lro::Operation<IssueComment, OperationMetadata>(_callCreateIssueComment.Sync(request, callSettings), CreateIssueCommentOperationsClient);
        }

        /// <summary>
        /// Creates an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<IssueComment, OperationMetadata>> CreateIssueCommentAsync(CreateIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIssueCommentRequest(ref request, ref callSettings);
            return new lro::Operation<IssueComment, OperationMetadata>(await _callCreateIssueComment.Async(request, callSettings).ConfigureAwait(false), CreateIssueCommentOperationsClient);
        }

        /// <summary>
        /// Gets an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IssueComment GetIssueComment(GetIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIssueCommentRequest(ref request, ref callSettings);
            return _callGetIssueComment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IssueComment> GetIssueCommentAsync(GetIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIssueCommentRequest(ref request, ref callSettings);
            return _callGetIssueComment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists comments in an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IssueComment"/> resources.</returns>
        public override gax::PagedEnumerable<ListIssueCommentsResponse, IssueComment> ListIssueComments(ListIssueCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIssueCommentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIssueCommentsRequest, ListIssueCommentsResponse, IssueComment>(_callListIssueComments, request, callSettings);
        }

        /// <summary>
        /// Lists comments in an issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IssueComment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListIssueCommentsResponse, IssueComment> ListIssueCommentsAsync(ListIssueCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIssueCommentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIssueCommentsRequest, ListIssueCommentsResponse, IssueComment>(_callListIssueComments, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateIssueComment</c>.</summary>
        public override lro::OperationsClient UpdateIssueCommentOperationsClient { get; }

        /// <summary>
        /// Updates an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<IssueComment, OperationMetadata> UpdateIssueComment(UpdateIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIssueCommentRequest(ref request, ref callSettings);
            return new lro::Operation<IssueComment, OperationMetadata>(_callUpdateIssueComment.Sync(request, callSettings), UpdateIssueCommentOperationsClient);
        }

        /// <summary>
        /// Updates an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<IssueComment, OperationMetadata>> UpdateIssueCommentAsync(UpdateIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIssueCommentRequest(ref request, ref callSettings);
            return new lro::Operation<IssueComment, OperationMetadata>(await _callUpdateIssueComment.Async(request, callSettings).ConfigureAwait(false), UpdateIssueCommentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteIssueComment</c>.</summary>
        public override lro::OperationsClient DeleteIssueCommentOperationsClient { get; }

        /// <summary>
        /// Deletes an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteIssueComment(DeleteIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIssueCommentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteIssueComment.Sync(request, callSettings), DeleteIssueCommentOperationsClient);
        }

        /// <summary>
        /// Deletes an issue comment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIssueCommentAsync(DeleteIssueCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIssueCommentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteIssueComment.Async(request, callSettings).ConfigureAwait(false), DeleteIssueCommentOperationsClient);
        }
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRepositoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListHooksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBranchRulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPullRequestsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPullRequestFileDiffsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchTreeRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIssuesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPullRequestCommentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIssueCommentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRepositoriesResponse : gaxgrpc::IPageResponse<Repository>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Repository> GetEnumerator() => Repositories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListHooksResponse : gaxgrpc::IPageResponse<Hook>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Hook> GetEnumerator() => Hooks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBranchRulesResponse : gaxgrpc::IPageResponse<BranchRule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BranchRule> GetEnumerator() => BranchRules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPullRequestsResponse : gaxgrpc::IPageResponse<PullRequest>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PullRequest> GetEnumerator() => PullRequests.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPullRequestFileDiffsResponse : gaxgrpc::IPageResponse<FileDiff>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FileDiff> GetEnumerator() => FileDiffs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchTreeResponse : gaxgrpc::IPageResponse<TreeEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TreeEntry> GetEnumerator() => TreeEntries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListIssuesResponse : gaxgrpc::IPageResponse<Issue>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Issue> GetEnumerator() => Issues.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPullRequestCommentsResponse : gaxgrpc::IPageResponse<PullRequestComment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PullRequestComment> GetEnumerator() => PullRequestComments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListIssueCommentsResponse : gaxgrpc::IPageResponse<IssueComment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<IssueComment> GetEnumerator() => IssueComments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SecureSourceManager
    {
        public partial class SecureSourceManagerClient
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

    public static partial class SecureSourceManager
    {
        public partial class SecureSourceManagerClient
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
