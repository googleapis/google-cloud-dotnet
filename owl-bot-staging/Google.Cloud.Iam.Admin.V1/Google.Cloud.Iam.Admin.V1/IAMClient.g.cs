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
using linq = System.Linq;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Iam.Admin.V1
{
    /// <summary>Settings for <see cref="IAMClient"/> instances.</summary>
    public sealed partial class IAMSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IAMSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IAMSettings"/>.</returns>
        public static IAMSettings GetDefault() => new IAMSettings();

        /// <summary>Constructs a new <see cref="IAMSettings"/> object with default settings.</summary>
        public IAMSettings()
        {
        }

        private IAMSettings(IAMSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListServiceAccountsSettings = existing.ListServiceAccountsSettings;
            GetServiceAccountSettings = existing.GetServiceAccountSettings;
            CreateServiceAccountSettings = existing.CreateServiceAccountSettings;
            UpdateServiceAccountSettings = existing.UpdateServiceAccountSettings;
            PatchServiceAccountSettings = existing.PatchServiceAccountSettings;
            DeleteServiceAccountSettings = existing.DeleteServiceAccountSettings;
            UndeleteServiceAccountSettings = existing.UndeleteServiceAccountSettings;
            EnableServiceAccountSettings = existing.EnableServiceAccountSettings;
            DisableServiceAccountSettings = existing.DisableServiceAccountSettings;
            ListServiceAccountKeysSettings = existing.ListServiceAccountKeysSettings;
            GetServiceAccountKeySettings = existing.GetServiceAccountKeySettings;
            CreateServiceAccountKeySettings = existing.CreateServiceAccountKeySettings;
            UploadServiceAccountKeySettings = existing.UploadServiceAccountKeySettings;
            DeleteServiceAccountKeySettings = existing.DeleteServiceAccountKeySettings;
            DisableServiceAccountKeySettings = existing.DisableServiceAccountKeySettings;
            EnableServiceAccountKeySettings = existing.EnableServiceAccountKeySettings;
            SignBlobSettings = existing.SignBlobSettings;
            SignJwtSettings = existing.SignJwtSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            QueryGrantableRolesSettings = existing.QueryGrantableRolesSettings;
            ListRolesSettings = existing.ListRolesSettings;
            GetRoleSettings = existing.GetRoleSettings;
            CreateRoleSettings = existing.CreateRoleSettings;
            UpdateRoleSettings = existing.UpdateRoleSettings;
            DeleteRoleSettings = existing.DeleteRoleSettings;
            UndeleteRoleSettings = existing.UndeleteRoleSettings;
            QueryTestablePermissionsSettings = existing.QueryTestablePermissionsSettings;
            QueryAuditableServicesSettings = existing.QueryAuditableServicesSettings;
            LintPolicySettings = existing.LintPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(IAMSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.ListServiceAccounts</c> and <c>IAMClient.ListServiceAccountsAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServiceAccountsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IAMClient.GetServiceAccount</c>
        ///  and <c>IAMClient.GetServiceAccountAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.CreateServiceAccount</c> and <c>IAMClient.CreateServiceAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceAccountSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.UpdateServiceAccount</c> and <c>IAMClient.UpdateServiceAccountAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.PatchServiceAccount</c> and <c>IAMClient.PatchServiceAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchServiceAccountSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.DeleteServiceAccount</c> and <c>IAMClient.DeleteServiceAccountAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.UndeleteServiceAccount</c> and <c>IAMClient.UndeleteServiceAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeleteServiceAccountSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.EnableServiceAccount</c> and <c>IAMClient.EnableServiceAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableServiceAccountSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.DisableServiceAccount</c> and <c>IAMClient.DisableServiceAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableServiceAccountSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.ListServiceAccountKeys</c> and <c>IAMClient.ListServiceAccountKeysAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServiceAccountKeysSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.GetServiceAccountKey</c> and <c>IAMClient.GetServiceAccountKeyAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceAccountKeySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.CreateServiceAccountKey</c> and <c>IAMClient.CreateServiceAccountKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceAccountKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.UploadServiceAccountKey</c> and <c>IAMClient.UploadServiceAccountKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UploadServiceAccountKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.DeleteServiceAccountKey</c> and <c>IAMClient.DeleteServiceAccountKeyAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceAccountKeySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.DisableServiceAccountKey</c> and <c>IAMClient.DisableServiceAccountKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableServiceAccountKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.EnableServiceAccountKey</c> and <c>IAMClient.EnableServiceAccountKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableServiceAccountKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IAMClient.SignBlob</c> and
        /// <c>IAMClient.SignBlobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SignBlobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IAMClient.SignJwt</c> and
        /// <c>IAMClient.SignJwtAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SignJwtSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IAMClient.GetIamPolicy</c>
        /// and <c>IAMClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IAMClient.SetIamPolicy</c>
        /// and <c>IAMClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.TestIamPermissions</c> and <c>IAMClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.QueryGrantableRoles</c> and <c>IAMClient.QueryGrantableRolesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryGrantableRolesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IAMClient.ListRoles</c> and
        /// <c>IAMClient.ListRolesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRolesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IAMClient.GetRole</c> and
        /// <c>IAMClient.GetRoleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRoleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IAMClient.CreateRole</c>
        /// and <c>IAMClient.CreateRoleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRoleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IAMClient.UpdateRole</c>
        /// and <c>IAMClient.UpdateRoleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRoleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IAMClient.DeleteRole</c>
        /// and <c>IAMClient.DeleteRoleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRoleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IAMClient.UndeleteRole</c>
        /// and <c>IAMClient.UndeleteRoleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeleteRoleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.QueryTestablePermissions</c> and <c>IAMClient.QueryTestablePermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryTestablePermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMClient.QueryAuditableServices</c> and <c>IAMClient.QueryAuditableServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryAuditableServicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IAMClient.LintPolicy</c>
        /// and <c>IAMClient.LintPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LintPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IAMSettings"/> object.</returns>
        public IAMSettings Clone() => new IAMSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IAMClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class IAMClientBuilder : gaxgrpc::ClientBuilderBase<IAMClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IAMSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IAMClientBuilder() : base(IAMClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IAMClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IAMClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IAMClient Build()
        {
            IAMClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IAMClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IAMClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IAMClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IAMClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IAMClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IAMClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IAMClient.ChannelPool;
    }

    /// <summary>IAM client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Creates and manages Identity and Access Management (IAM) resources.
    /// 
    /// You can use this service to work with all of the following resources:
    /// 
    /// * **Service accounts**, which identify an application or a virtual machine
    /// (VM) instance rather than a person
    /// * **Service account keys**, which service accounts use to authenticate with
    /// Google APIs
    /// * **IAM policies for service accounts**, which specify the roles that a
    /// principal has for the service account
    /// * **IAM custom roles**, which help you limit the number of permissions that
    /// you grant to principals
    /// 
    /// In addition, you can use this service to complete the following tasks, among
    /// others:
    /// 
    /// * Test whether a service account can use specific permissions
    /// * Check which roles you can grant for a specific resource
    /// * Lint, or validate, condition expressions in an IAM policy
    /// 
    /// When you read data from the IAM API, each read is eventually consistent. In
    /// other words, if you write data with the IAM API, then immediately read that
    /// data, the read operation might return an older version of the data. To deal
    /// with this behavior, your application can retry the request with truncated
    /// exponential backoff.
    /// 
    /// In contrast, writing data to the IAM API is sequentially consistent. In other
    /// words, write operations are always processed in the order in which they were
    /// received.
    /// </remarks>
    public abstract partial class IAMClient
    {
        /// <summary>
        /// The default endpoint for the IAM service, which is a host of "iam.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "iam.googleapis.com:443";

        /// <summary>The default IAM scopes.</summary>
        /// <remarks>
        /// The default IAM scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IAM.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IAMClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="IAMClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IAMClient"/>.</returns>
        public static stt::Task<IAMClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IAMClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IAMClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="IAMClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IAMClient"/>.</returns>
        public static IAMClient Create() => new IAMClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IAMClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IAMSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IAMClient"/>.</returns>
        internal static IAMClient Create(grpccore::CallInvoker callInvoker, IAMSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IAM.IAMClient grpcClient = new IAM.IAMClient(callInvoker);
            return new IAMClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IAM client</summary>
        public virtual IAM.IAMClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists every [ServiceAccount][google.iam.admin.v1.ServiceAccount] that belongs to a specific project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceAccount"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccounts(ListServiceAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists every [ServiceAccount][google.iam.admin.v1.ServiceAccount] that belongs to a specific project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceAccount"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccountsAsync(ListServiceAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists every [ServiceAccount][google.iam.admin.v1.ServiceAccount] that belongs to a specific project.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project associated with the service
        /// accounts, such as `projects/my-project-123`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceAccount"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccounts(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceAccountsRequest request = new ListServiceAccountsRequest
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
            return ListServiceAccounts(request, callSettings);
        }

        /// <summary>
        /// Lists every [ServiceAccount][google.iam.admin.v1.ServiceAccount] that belongs to a specific project.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project associated with the service
        /// accounts, such as `projects/my-project-123`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceAccount"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccountsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceAccountsRequest request = new ListServiceAccountsRequest
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
            return ListServiceAccountsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists every [ServiceAccount][google.iam.admin.v1.ServiceAccount] that belongs to a specific project.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project associated with the service
        /// accounts, such as `projects/my-project-123`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceAccount"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccounts(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceAccountsRequest request = new ListServiceAccountsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServiceAccounts(request, callSettings);
        }

        /// <summary>
        /// Lists every [ServiceAccount][google.iam.admin.v1.ServiceAccount] that belongs to a specific project.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project associated with the service
        /// accounts, such as `projects/my-project-123`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceAccount"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccountsAsync(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceAccountsRequest request = new ListServiceAccountsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServiceAccountsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount GetServiceAccount(GetServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(GetServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(GetServiceAccountRequest request, st::CancellationToken cancellationToken) =>
            GetServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount GetServiceAccount(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccount(new GetServiceAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccountAsync(new GetServiceAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount GetServiceAccount(ServiceAccountName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccount(new GetServiceAccountRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(ServiceAccountName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccountAsync(new GetServiceAccountRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(ServiceAccountName name, st::CancellationToken cancellationToken) =>
            GetServiceAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount CreateServiceAccount(CreateServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> CreateServiceAccountAsync(CreateServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> CreateServiceAccountAsync(CreateServiceAccountRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project associated with the service
        /// accounts, such as `projects/my-project-123`.
        /// </param>
        /// <param name="accountId">
        /// Required. The account id that is used to generate the service account
        /// email address and a stable unique id. It is unique within a project,
        /// must be 6-30 characters long, and match the regular expression
        /// `[a-z]([-a-z0-9]*[a-z0-9])` to comply with RFC1035.
        /// </param>
        /// <param name="serviceAccount">
        /// The [ServiceAccount][google.iam.admin.v1.ServiceAccount] resource to
        /// create. Currently, only the following values are user assignable:
        /// `display_name` and `description`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount CreateServiceAccount(string name, string accountId, ServiceAccount serviceAccount, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAccount(new CreateServiceAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AccountId = gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)),
                ServiceAccount = serviceAccount,
            }, callSettings);

        /// <summary>
        /// Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project associated with the service
        /// accounts, such as `projects/my-project-123`.
        /// </param>
        /// <param name="accountId">
        /// Required. The account id that is used to generate the service account
        /// email address and a stable unique id. It is unique within a project,
        /// must be 6-30 characters long, and match the regular expression
        /// `[a-z]([-a-z0-9]*[a-z0-9])` to comply with RFC1035.
        /// </param>
        /// <param name="serviceAccount">
        /// The [ServiceAccount][google.iam.admin.v1.ServiceAccount] resource to
        /// create. Currently, only the following values are user assignable:
        /// `display_name` and `description`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> CreateServiceAccountAsync(string name, string accountId, ServiceAccount serviceAccount, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAccountAsync(new CreateServiceAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AccountId = gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)),
                ServiceAccount = serviceAccount,
            }, callSettings);

        /// <summary>
        /// Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project associated with the service
        /// accounts, such as `projects/my-project-123`.
        /// </param>
        /// <param name="accountId">
        /// Required. The account id that is used to generate the service account
        /// email address and a stable unique id. It is unique within a project,
        /// must be 6-30 characters long, and match the regular expression
        /// `[a-z]([-a-z0-9]*[a-z0-9])` to comply with RFC1035.
        /// </param>
        /// <param name="serviceAccount">
        /// The [ServiceAccount][google.iam.admin.v1.ServiceAccount] resource to
        /// create. Currently, only the following values are user assignable:
        /// `display_name` and `description`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> CreateServiceAccountAsync(string name, string accountId, ServiceAccount serviceAccount, st::CancellationToken cancellationToken) =>
            CreateServiceAccountAsync(name, accountId, serviceAccount, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project associated with the service
        /// accounts, such as `projects/my-project-123`.
        /// </param>
        /// <param name="accountId">
        /// Required. The account id that is used to generate the service account
        /// email address and a stable unique id. It is unique within a project,
        /// must be 6-30 characters long, and match the regular expression
        /// `[a-z]([-a-z0-9]*[a-z0-9])` to comply with RFC1035.
        /// </param>
        /// <param name="serviceAccount">
        /// The [ServiceAccount][google.iam.admin.v1.ServiceAccount] resource to
        /// create. Currently, only the following values are user assignable:
        /// `display_name` and `description`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount CreateServiceAccount(gagr::ProjectName name, string accountId, ServiceAccount serviceAccount, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAccount(new CreateServiceAccountRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AccountId = gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)),
                ServiceAccount = serviceAccount,
            }, callSettings);

        /// <summary>
        /// Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project associated with the service
        /// accounts, such as `projects/my-project-123`.
        /// </param>
        /// <param name="accountId">
        /// Required. The account id that is used to generate the service account
        /// email address and a stable unique id. It is unique within a project,
        /// must be 6-30 characters long, and match the regular expression
        /// `[a-z]([-a-z0-9]*[a-z0-9])` to comply with RFC1035.
        /// </param>
        /// <param name="serviceAccount">
        /// The [ServiceAccount][google.iam.admin.v1.ServiceAccount] resource to
        /// create. Currently, only the following values are user assignable:
        /// `display_name` and `description`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> CreateServiceAccountAsync(gagr::ProjectName name, string accountId, ServiceAccount serviceAccount, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAccountAsync(new CreateServiceAccountRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AccountId = gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)),
                ServiceAccount = serviceAccount,
            }, callSettings);

        /// <summary>
        /// Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project associated with the service
        /// accounts, such as `projects/my-project-123`.
        /// </param>
        /// <param name="accountId">
        /// Required. The account id that is used to generate the service account
        /// email address and a stable unique id. It is unique within a project,
        /// must be 6-30 characters long, and match the regular expression
        /// `[a-z]([-a-z0-9]*[a-z0-9])` to comply with RFC1035.
        /// </param>
        /// <param name="serviceAccount">
        /// The [ServiceAccount][google.iam.admin.v1.ServiceAccount] resource to
        /// create. Currently, only the following values are user assignable:
        /// `display_name` and `description`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> CreateServiceAccountAsync(gagr::ProjectName name, string accountId, ServiceAccount serviceAccount, st::CancellationToken cancellationToken) =>
            CreateServiceAccountAsync(name, accountId, serviceAccount, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// **Note:** We are in the process of deprecating this method. Use
        /// [PatchServiceAccount][google.iam.admin.v1.IAM.PatchServiceAccount] instead.
        /// 
        /// Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// You can update only the `display_name` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount UpdateServiceAccount(ServiceAccount request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// **Note:** We are in the process of deprecating this method. Use
        /// [PatchServiceAccount][google.iam.admin.v1.IAM.PatchServiceAccount] instead.
        /// 
        /// Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// You can update only the `display_name` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> UpdateServiceAccountAsync(ServiceAccount request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// **Note:** We are in the process of deprecating this method. Use
        /// [PatchServiceAccount][google.iam.admin.v1.IAM.PatchServiceAccount] instead.
        /// 
        /// Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// You can update only the `display_name` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> UpdateServiceAccountAsync(ServiceAccount request, st::CancellationToken cancellationToken) =>
            UpdateServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount PatchServiceAccount(PatchServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> PatchServiceAccountAsync(PatchServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> PatchServiceAccountAsync(PatchServiceAccountRequest request, st::CancellationToken cancellationToken) =>
            PatchServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Warning:** After you delete a service account, you might not be able to
        /// undelete it. If you know that you need to re-enable the service account in
        /// the future, use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] instead.
        /// 
        /// If you delete a service account, IAM permanently removes the service
        /// account 30 days later. Google Cloud cannot recover the service account
        /// after it is permanently removed, even if you file a support request.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] to disable the
        /// service account, then wait at least 24 hours and watch for unintended
        /// consequences. If there are no unintended consequences, you can delete the
        /// service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteServiceAccount(DeleteServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Warning:** After you delete a service account, you might not be able to
        /// undelete it. If you know that you need to re-enable the service account in
        /// the future, use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] instead.
        /// 
        /// If you delete a service account, IAM permanently removes the service
        /// account 30 days later. Google Cloud cannot recover the service account
        /// after it is permanently removed, even if you file a support request.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] to disable the
        /// service account, then wait at least 24 hours and watch for unintended
        /// consequences. If there are no unintended consequences, you can delete the
        /// service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAccountAsync(DeleteServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Warning:** After you delete a service account, you might not be able to
        /// undelete it. If you know that you need to re-enable the service account in
        /// the future, use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] instead.
        /// 
        /// If you delete a service account, IAM permanently removes the service
        /// account 30 days later. Google Cloud cannot recover the service account
        /// after it is permanently removed, even if you file a support request.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] to disable the
        /// service account, then wait at least 24 hours and watch for unintended
        /// consequences. If there are no unintended consequences, you can delete the
        /// service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAccountAsync(DeleteServiceAccountRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Warning:** After you delete a service account, you might not be able to
        /// undelete it. If you know that you need to re-enable the service account in
        /// the future, use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] instead.
        /// 
        /// If you delete a service account, IAM permanently removes the service
        /// account 30 days later. Google Cloud cannot recover the service account
        /// after it is permanently removed, even if you file a support request.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] to disable the
        /// service account, then wait at least 24 hours and watch for unintended
        /// consequences. If there are no unintended consequences, you can delete the
        /// service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteServiceAccount(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAccount(new DeleteServiceAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Warning:** After you delete a service account, you might not be able to
        /// undelete it. If you know that you need to re-enable the service account in
        /// the future, use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] instead.
        /// 
        /// If you delete a service account, IAM permanently removes the service
        /// account 30 days later. Google Cloud cannot recover the service account
        /// after it is permanently removed, even if you file a support request.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] to disable the
        /// service account, then wait at least 24 hours and watch for unintended
        /// consequences. If there are no unintended consequences, you can delete the
        /// service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAccountAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAccountAsync(new DeleteServiceAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Warning:** After you delete a service account, you might not be able to
        /// undelete it. If you know that you need to re-enable the service account in
        /// the future, use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] instead.
        /// 
        /// If you delete a service account, IAM permanently removes the service
        /// account 30 days later. Google Cloud cannot recover the service account
        /// after it is permanently removed, even if you file a support request.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] to disable the
        /// service account, then wait at least 24 hours and watch for unintended
        /// consequences. If there are no unintended consequences, you can delete the
        /// service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAccountAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Warning:** After you delete a service account, you might not be able to
        /// undelete it. If you know that you need to re-enable the service account in
        /// the future, use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] instead.
        /// 
        /// If you delete a service account, IAM permanently removes the service
        /// account 30 days later. Google Cloud cannot recover the service account
        /// after it is permanently removed, even if you file a support request.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] to disable the
        /// service account, then wait at least 24 hours and watch for unintended
        /// consequences. If there are no unintended consequences, you can delete the
        /// service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteServiceAccount(ServiceAccountName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAccount(new DeleteServiceAccountRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Warning:** After you delete a service account, you might not be able to
        /// undelete it. If you know that you need to re-enable the service account in
        /// the future, use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] instead.
        /// 
        /// If you delete a service account, IAM permanently removes the service
        /// account 30 days later. Google Cloud cannot recover the service account
        /// after it is permanently removed, even if you file a support request.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] to disable the
        /// service account, then wait at least 24 hours and watch for unintended
        /// consequences. If there are no unintended consequences, you can delete the
        /// service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAccountAsync(ServiceAccountName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAccountAsync(new DeleteServiceAccountRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Warning:** After you delete a service account, you might not be able to
        /// undelete it. If you know that you need to re-enable the service account in
        /// the future, use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] instead.
        /// 
        /// If you delete a service account, IAM permanently removes the service
        /// account 30 days later. Google Cloud cannot recover the service account
        /// after it is permanently removed, even if you file a support request.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] to disable the
        /// service account, then wait at least 24 hours and watch for unintended
        /// consequences. If there are no unintended consequences, you can delete the
        /// service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAccountAsync(ServiceAccountName name, st::CancellationToken cancellationToken) =>
            DeleteServiceAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores a deleted [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Important:** It is not always possible to restore a deleted service
        /// account. Use this method only as a last resort.
        /// 
        /// After you delete a service account, IAM permanently removes the service
        /// account 30 days later. There is no way to restore a deleted service account
        /// that has been permanently removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UndeleteServiceAccountResponse UndeleteServiceAccount(UndeleteServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores a deleted [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Important:** It is not always possible to restore a deleted service
        /// account. Use this method only as a last resort.
        /// 
        /// After you delete a service account, IAM permanently removes the service
        /// account 30 days later. There is no way to restore a deleted service account
        /// that has been permanently removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UndeleteServiceAccountResponse> UndeleteServiceAccountAsync(UndeleteServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores a deleted [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Important:** It is not always possible to restore a deleted service
        /// account. Use this method only as a last resort.
        /// 
        /// After you delete a service account, IAM permanently removes the service
        /// account 30 days later. There is no way to restore a deleted service account
        /// that has been permanently removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UndeleteServiceAccountResponse> UndeleteServiceAccountAsync(UndeleteServiceAccountRequest request, st::CancellationToken cancellationToken) =>
            UndeleteServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables a [ServiceAccount][google.iam.admin.v1.ServiceAccount] that was disabled by
        /// [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount].
        /// 
        /// If the service account is already enabled, then this method has no effect.
        /// 
        /// If the service account was disabled by other means—for example, if Google
        /// disabled the service account because it was compromised—you cannot use this
        /// method to enable the service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void EnableServiceAccount(EnableServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a [ServiceAccount][google.iam.admin.v1.ServiceAccount] that was disabled by
        /// [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount].
        /// 
        /// If the service account is already enabled, then this method has no effect.
        /// 
        /// If the service account was disabled by other means—for example, if Google
        /// disabled the service account because it was compromised—you cannot use this
        /// method to enable the service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EnableServiceAccountAsync(EnableServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a [ServiceAccount][google.iam.admin.v1.ServiceAccount] that was disabled by
        /// [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount].
        /// 
        /// If the service account is already enabled, then this method has no effect.
        /// 
        /// If the service account was disabled by other means—for example, if Google
        /// disabled the service account because it was compromised—you cannot use this
        /// method to enable the service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EnableServiceAccountAsync(EnableServiceAccountRequest request, st::CancellationToken cancellationToken) =>
            EnableServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a [ServiceAccount][google.iam.admin.v1.ServiceAccount] immediately.
        /// 
        /// If an application uses the service account to authenticate, that
        /// application can no longer call Google APIs or access Google Cloud
        /// resources. Existing access tokens for the service account are rejected, and
        /// requests for new access tokens will fail.
        /// 
        /// To re-enable the service account, use [EnableServiceAccount][google.iam.admin.v1.IAM.EnableServiceAccount]. After you
        /// re-enable the service account, its existing access tokens will be accepted,
        /// and you can request new access tokens.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use this method to disable the service
        /// account, then wait at least 24 hours and watch for unintended consequences.
        /// If there are no unintended consequences, you can delete the service account
        /// with [DeleteServiceAccount][google.iam.admin.v1.IAM.DeleteServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DisableServiceAccount(DisableServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a [ServiceAccount][google.iam.admin.v1.ServiceAccount] immediately.
        /// 
        /// If an application uses the service account to authenticate, that
        /// application can no longer call Google APIs or access Google Cloud
        /// resources. Existing access tokens for the service account are rejected, and
        /// requests for new access tokens will fail.
        /// 
        /// To re-enable the service account, use [EnableServiceAccount][google.iam.admin.v1.IAM.EnableServiceAccount]. After you
        /// re-enable the service account, its existing access tokens will be accepted,
        /// and you can request new access tokens.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use this method to disable the service
        /// account, then wait at least 24 hours and watch for unintended consequences.
        /// If there are no unintended consequences, you can delete the service account
        /// with [DeleteServiceAccount][google.iam.admin.v1.IAM.DeleteServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DisableServiceAccountAsync(DisableServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a [ServiceAccount][google.iam.admin.v1.ServiceAccount] immediately.
        /// 
        /// If an application uses the service account to authenticate, that
        /// application can no longer call Google APIs or access Google Cloud
        /// resources. Existing access tokens for the service account are rejected, and
        /// requests for new access tokens will fail.
        /// 
        /// To re-enable the service account, use [EnableServiceAccount][google.iam.admin.v1.IAM.EnableServiceAccount]. After you
        /// re-enable the service account, its existing access tokens will be accepted,
        /// and you can request new access tokens.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use this method to disable the service
        /// account, then wait at least 24 hours and watch for unintended consequences.
        /// If there are no unintended consequences, you can delete the service account
        /// with [DeleteServiceAccount][google.iam.admin.v1.IAM.DeleteServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DisableServiceAccountAsync(DisableServiceAccountRequest request, st::CancellationToken cancellationToken) =>
            DisableServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists every [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListServiceAccountKeysResponse ListServiceAccountKeys(ListServiceAccountKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists every [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListServiceAccountKeysResponse> ListServiceAccountKeysAsync(ListServiceAccountKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists every [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListServiceAccountKeysResponse> ListServiceAccountKeysAsync(ListServiceAccountKeysRequest request, st::CancellationToken cancellationToken) =>
            ListServiceAccountKeysAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists every [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID`, will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="keyTypes">
        /// Filters the types of keys the user wants to include in the list
        /// response. Duplicate key types are not allowed. If no key type
        /// is provided, all keys are returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListServiceAccountKeysResponse ListServiceAccountKeys(string name, scg::IEnumerable<ListServiceAccountKeysRequest.Types.KeyType> keyTypes, gaxgrpc::CallSettings callSettings = null) =>
            ListServiceAccountKeys(new ListServiceAccountKeysRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                KeyTypes =
                {
                    keyTypes ?? linq::Enumerable.Empty<ListServiceAccountKeysRequest.Types.KeyType>(),
                },
            }, callSettings);

        /// <summary>
        /// Lists every [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID`, will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="keyTypes">
        /// Filters the types of keys the user wants to include in the list
        /// response. Duplicate key types are not allowed. If no key type
        /// is provided, all keys are returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListServiceAccountKeysResponse> ListServiceAccountKeysAsync(string name, scg::IEnumerable<ListServiceAccountKeysRequest.Types.KeyType> keyTypes, gaxgrpc::CallSettings callSettings = null) =>
            ListServiceAccountKeysAsync(new ListServiceAccountKeysRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                KeyTypes =
                {
                    keyTypes ?? linq::Enumerable.Empty<ListServiceAccountKeysRequest.Types.KeyType>(),
                },
            }, callSettings);

        /// <summary>
        /// Lists every [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID`, will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="keyTypes">
        /// Filters the types of keys the user wants to include in the list
        /// response. Duplicate key types are not allowed. If no key type
        /// is provided, all keys are returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListServiceAccountKeysResponse> ListServiceAccountKeysAsync(string name, scg::IEnumerable<ListServiceAccountKeysRequest.Types.KeyType> keyTypes, st::CancellationToken cancellationToken) =>
            ListServiceAccountKeysAsync(name, keyTypes, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists every [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID`, will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="keyTypes">
        /// Filters the types of keys the user wants to include in the list
        /// response. Duplicate key types are not allowed. If no key type
        /// is provided, all keys are returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListServiceAccountKeysResponse ListServiceAccountKeys(ServiceAccountName name, scg::IEnumerable<ListServiceAccountKeysRequest.Types.KeyType> keyTypes, gaxgrpc::CallSettings callSettings = null) =>
            ListServiceAccountKeys(new ListServiceAccountKeysRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                KeyTypes =
                {
                    keyTypes ?? linq::Enumerable.Empty<ListServiceAccountKeysRequest.Types.KeyType>(),
                },
            }, callSettings);

        /// <summary>
        /// Lists every [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID`, will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="keyTypes">
        /// Filters the types of keys the user wants to include in the list
        /// response. Duplicate key types are not allowed. If no key type
        /// is provided, all keys are returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListServiceAccountKeysResponse> ListServiceAccountKeysAsync(ServiceAccountName name, scg::IEnumerable<ListServiceAccountKeysRequest.Types.KeyType> keyTypes, gaxgrpc::CallSettings callSettings = null) =>
            ListServiceAccountKeysAsync(new ListServiceAccountKeysRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                KeyTypes =
                {
                    keyTypes ?? linq::Enumerable.Empty<ListServiceAccountKeysRequest.Types.KeyType>(),
                },
            }, callSettings);

        /// <summary>
        /// Lists every [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID`, will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="keyTypes">
        /// Filters the types of keys the user wants to include in the list
        /// response. Duplicate key types are not allowed. If no key type
        /// is provided, all keys are returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListServiceAccountKeysResponse> ListServiceAccountKeysAsync(ServiceAccountName name, scg::IEnumerable<ListServiceAccountKeysRequest.Types.KeyType> keyTypes, st::CancellationToken cancellationToken) =>
            ListServiceAccountKeysAsync(name, keyTypes, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccountKey GetServiceAccountKey(GetServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> GetServiceAccountKeyAsync(GetServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> GetServiceAccountKeyAsync(GetServiceAccountKeyRequest request, st::CancellationToken cancellationToken) =>
            GetServiceAccountKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="publicKeyType">
        /// Optional. The output format of the public key. The default is `TYPE_NONE`, which
        /// means that the public key is not returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccountKey GetServiceAccountKey(string name, ServiceAccountPublicKeyType publicKeyType, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccountKey(new GetServiceAccountKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PublicKeyType = publicKeyType,
            }, callSettings);

        /// <summary>
        /// Gets a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="publicKeyType">
        /// Optional. The output format of the public key. The default is `TYPE_NONE`, which
        /// means that the public key is not returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> GetServiceAccountKeyAsync(string name, ServiceAccountPublicKeyType publicKeyType, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccountKeyAsync(new GetServiceAccountKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PublicKeyType = publicKeyType,
            }, callSettings);

        /// <summary>
        /// Gets a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="publicKeyType">
        /// Optional. The output format of the public key. The default is `TYPE_NONE`, which
        /// means that the public key is not returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> GetServiceAccountKeyAsync(string name, ServiceAccountPublicKeyType publicKeyType, st::CancellationToken cancellationToken) =>
            GetServiceAccountKeyAsync(name, publicKeyType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="publicKeyType">
        /// Optional. The output format of the public key. The default is `TYPE_NONE`, which
        /// means that the public key is not returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccountKey GetServiceAccountKey(KeyName name, ServiceAccountPublicKeyType publicKeyType, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccountKey(new GetServiceAccountKeyRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PublicKeyType = publicKeyType,
            }, callSettings);

        /// <summary>
        /// Gets a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="publicKeyType">
        /// Optional. The output format of the public key. The default is `TYPE_NONE`, which
        /// means that the public key is not returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> GetServiceAccountKeyAsync(KeyName name, ServiceAccountPublicKeyType publicKeyType, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccountKeyAsync(new GetServiceAccountKeyRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PublicKeyType = publicKeyType,
            }, callSettings);

        /// <summary>
        /// Gets a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="publicKeyType">
        /// Optional. The output format of the public key. The default is `TYPE_NONE`, which
        /// means that the public key is not returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> GetServiceAccountKeyAsync(KeyName name, ServiceAccountPublicKeyType publicKeyType, st::CancellationToken cancellationToken) =>
            GetServiceAccountKeyAsync(name, publicKeyType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccountKey CreateServiceAccountKey(CreateServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> CreateServiceAccountKeyAsync(CreateServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> CreateServiceAccountKeyAsync(CreateServiceAccountKeyRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceAccountKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="privateKeyType">
        /// The output format of the private key. The default value is
        /// `TYPE_GOOGLE_CREDENTIALS_FILE`, which is the Google Credentials File
        /// format.
        /// </param>
        /// <param name="keyAlgorithm">
        /// Which type of key and algorithm to use for the key.
        /// The default is currently a 2K RSA key.  However this may change in the
        /// future.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccountKey CreateServiceAccountKey(string name, ServiceAccountPrivateKeyType privateKeyType, ServiceAccountKeyAlgorithm keyAlgorithm, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAccountKey(new CreateServiceAccountKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PrivateKeyType = privateKeyType,
                KeyAlgorithm = keyAlgorithm,
            }, callSettings);

        /// <summary>
        /// Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="privateKeyType">
        /// The output format of the private key. The default value is
        /// `TYPE_GOOGLE_CREDENTIALS_FILE`, which is the Google Credentials File
        /// format.
        /// </param>
        /// <param name="keyAlgorithm">
        /// Which type of key and algorithm to use for the key.
        /// The default is currently a 2K RSA key.  However this may change in the
        /// future.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> CreateServiceAccountKeyAsync(string name, ServiceAccountPrivateKeyType privateKeyType, ServiceAccountKeyAlgorithm keyAlgorithm, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAccountKeyAsync(new CreateServiceAccountKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PrivateKeyType = privateKeyType,
                KeyAlgorithm = keyAlgorithm,
            }, callSettings);

        /// <summary>
        /// Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="privateKeyType">
        /// The output format of the private key. The default value is
        /// `TYPE_GOOGLE_CREDENTIALS_FILE`, which is the Google Credentials File
        /// format.
        /// </param>
        /// <param name="keyAlgorithm">
        /// Which type of key and algorithm to use for the key.
        /// The default is currently a 2K RSA key.  However this may change in the
        /// future.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> CreateServiceAccountKeyAsync(string name, ServiceAccountPrivateKeyType privateKeyType, ServiceAccountKeyAlgorithm keyAlgorithm, st::CancellationToken cancellationToken) =>
            CreateServiceAccountKeyAsync(name, privateKeyType, keyAlgorithm, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="privateKeyType">
        /// The output format of the private key. The default value is
        /// `TYPE_GOOGLE_CREDENTIALS_FILE`, which is the Google Credentials File
        /// format.
        /// </param>
        /// <param name="keyAlgorithm">
        /// Which type of key and algorithm to use for the key.
        /// The default is currently a 2K RSA key.  However this may change in the
        /// future.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccountKey CreateServiceAccountKey(ServiceAccountName name, ServiceAccountPrivateKeyType privateKeyType, ServiceAccountKeyAlgorithm keyAlgorithm, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAccountKey(new CreateServiceAccountKeyRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PrivateKeyType = privateKeyType,
                KeyAlgorithm = keyAlgorithm,
            }, callSettings);

        /// <summary>
        /// Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="privateKeyType">
        /// The output format of the private key. The default value is
        /// `TYPE_GOOGLE_CREDENTIALS_FILE`, which is the Google Credentials File
        /// format.
        /// </param>
        /// <param name="keyAlgorithm">
        /// Which type of key and algorithm to use for the key.
        /// The default is currently a 2K RSA key.  However this may change in the
        /// future.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> CreateServiceAccountKeyAsync(ServiceAccountName name, ServiceAccountPrivateKeyType privateKeyType, ServiceAccountKeyAlgorithm keyAlgorithm, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAccountKeyAsync(new CreateServiceAccountKeyRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PrivateKeyType = privateKeyType,
                KeyAlgorithm = keyAlgorithm,
            }, callSettings);

        /// <summary>
        /// Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="privateKeyType">
        /// The output format of the private key. The default value is
        /// `TYPE_GOOGLE_CREDENTIALS_FILE`, which is the Google Credentials File
        /// format.
        /// </param>
        /// <param name="keyAlgorithm">
        /// Which type of key and algorithm to use for the key.
        /// The default is currently a 2K RSA key.  However this may change in the
        /// future.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> CreateServiceAccountKeyAsync(ServiceAccountName name, ServiceAccountPrivateKeyType privateKeyType, ServiceAccountKeyAlgorithm keyAlgorithm, st::CancellationToken cancellationToken) =>
            CreateServiceAccountKeyAsync(name, privateKeyType, keyAlgorithm, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uploads the public key portion of a key pair that you manage, and
        /// associates the public key with a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// After you upload the public key, you can use the private key from the key
        /// pair as a service account key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccountKey UploadServiceAccountKey(UploadServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads the public key portion of a key pair that you manage, and
        /// associates the public key with a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// After you upload the public key, you can use the private key from the key
        /// pair as a service account key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> UploadServiceAccountKeyAsync(UploadServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads the public key portion of a key pair that you manage, and
        /// associates the public key with a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// After you upload the public key, you can use the private key from the key
        /// pair as a service account key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccountKey> UploadServiceAccountKeyAsync(UploadServiceAccountKeyRequest request, st::CancellationToken cancellationToken) =>
            UploadServiceAccountKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. Deleting a service account key does not
        /// revoke short-lived credentials that have been issued based on the service
        /// account key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteServiceAccountKey(DeleteServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. Deleting a service account key does not
        /// revoke short-lived credentials that have been issued based on the service
        /// account key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAccountKeyAsync(DeleteServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. Deleting a service account key does not
        /// revoke short-lived credentials that have been issued based on the service
        /// account key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAccountKeyAsync(DeleteServiceAccountKeyRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceAccountKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. Deleting a service account key does not
        /// revoke short-lived credentials that have been issued based on the service
        /// account key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteServiceAccountKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAccountKey(new DeleteServiceAccountKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. Deleting a service account key does not
        /// revoke short-lived credentials that have been issued based on the service
        /// account key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAccountKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAccountKeyAsync(new DeleteServiceAccountKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. Deleting a service account key does not
        /// revoke short-lived credentials that have been issued based on the service
        /// account key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAccountKeyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceAccountKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. Deleting a service account key does not
        /// revoke short-lived credentials that have been issued based on the service
        /// account key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteServiceAccountKey(KeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAccountKey(new DeleteServiceAccountKeyRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. Deleting a service account key does not
        /// revoke short-lived credentials that have been issued based on the service
        /// account key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAccountKeyAsync(KeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAccountKeyAsync(new DeleteServiceAccountKeyRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. Deleting a service account key does not
        /// revoke short-lived credentials that have been issued based on the service
        /// account key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAccountKeyAsync(KeyName name, st::CancellationToken cancellationToken) =>
            DeleteServiceAccountKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. A disabled service account key can be
        /// re-enabled with [EnableServiceAccountKey][google.iam.admin.v1.IAM.EnableServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DisableServiceAccountKey(DisableServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. A disabled service account key can be
        /// re-enabled with [EnableServiceAccountKey][google.iam.admin.v1.IAM.EnableServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DisableServiceAccountKeyAsync(DisableServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. A disabled service account key can be
        /// re-enabled with [EnableServiceAccountKey][google.iam.admin.v1.IAM.EnableServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DisableServiceAccountKeyAsync(DisableServiceAccountKeyRequest request, st::CancellationToken cancellationToken) =>
            DisableServiceAccountKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. A disabled service account key can be
        /// re-enabled with [EnableServiceAccountKey][google.iam.admin.v1.IAM.EnableServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DisableServiceAccountKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableServiceAccountKey(new DisableServiceAccountKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. A disabled service account key can be
        /// re-enabled with [EnableServiceAccountKey][google.iam.admin.v1.IAM.EnableServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DisableServiceAccountKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableServiceAccountKeyAsync(new DisableServiceAccountKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. A disabled service account key can be
        /// re-enabled with [EnableServiceAccountKey][google.iam.admin.v1.IAM.EnableServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DisableServiceAccountKeyAsync(string name, st::CancellationToken cancellationToken) =>
            DisableServiceAccountKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. A disabled service account key can be
        /// re-enabled with [EnableServiceAccountKey][google.iam.admin.v1.IAM.EnableServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DisableServiceAccountKey(KeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableServiceAccountKey(new DisableServiceAccountKeyRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. A disabled service account key can be
        /// re-enabled with [EnableServiceAccountKey][google.iam.admin.v1.IAM.EnableServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DisableServiceAccountKeyAsync(KeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableServiceAccountKeyAsync(new DisableServiceAccountKeyRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. A disabled service account key can be
        /// re-enabled with [EnableServiceAccountKey][google.iam.admin.v1.IAM.EnableServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DisableServiceAccountKeyAsync(KeyName name, st::CancellationToken cancellationToken) =>
            DisableServiceAccountKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void EnableServiceAccountKey(EnableServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EnableServiceAccountKeyAsync(EnableServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EnableServiceAccountKeyAsync(EnableServiceAccountKeyRequest request, st::CancellationToken cancellationToken) =>
            EnableServiceAccountKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void EnableServiceAccountKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableServiceAccountKey(new EnableServiceAccountKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EnableServiceAccountKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableServiceAccountKeyAsync(new EnableServiceAccountKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EnableServiceAccountKeyAsync(string name, st::CancellationToken cancellationToken) =>
            EnableServiceAccountKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void EnableServiceAccountKey(KeyName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableServiceAccountKey(new EnableServiceAccountKeyRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EnableServiceAccountKeyAsync(KeyName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableServiceAccountKeyAsync(new EnableServiceAccountKeyRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account key in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// 
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EnableServiceAccountKeyAsync(KeyName name, st::CancellationToken cancellationToken) =>
            EnableServiceAccountKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a blob using the system-managed private key for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual SignBlobResponse SignBlob(SignBlobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a blob using the system-managed private key for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<SignBlobResponse> SignBlobAsync(SignBlobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a blob using the system-managed private key for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<SignBlobResponse> SignBlobAsync(SignBlobRequest request, st::CancellationToken cancellationToken) =>
            SignBlobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a blob using the system-managed private key for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="bytesToSign">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The bytes to sign.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual SignBlobResponse SignBlob(string name, proto::ByteString bytesToSign, gaxgrpc::CallSettings callSettings = null) =>
            SignBlob(new SignBlobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                BytesToSign = gax::GaxPreconditions.CheckNotNull(bytesToSign, nameof(bytesToSign)),
            }, callSettings);

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a blob using the system-managed private key for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="bytesToSign">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The bytes to sign.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<SignBlobResponse> SignBlobAsync(string name, proto::ByteString bytesToSign, gaxgrpc::CallSettings callSettings = null) =>
            SignBlobAsync(new SignBlobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                BytesToSign = gax::GaxPreconditions.CheckNotNull(bytesToSign, nameof(bytesToSign)),
            }, callSettings);

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a blob using the system-managed private key for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="bytesToSign">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The bytes to sign.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<SignBlobResponse> SignBlobAsync(string name, proto::ByteString bytesToSign, st::CancellationToken cancellationToken) =>
            SignBlobAsync(name, bytesToSign, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a blob using the system-managed private key for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="bytesToSign">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The bytes to sign.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual SignBlobResponse SignBlob(ServiceAccountName name, proto::ByteString bytesToSign, gaxgrpc::CallSettings callSettings = null) =>
            SignBlob(new SignBlobRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                BytesToSign = gax::GaxPreconditions.CheckNotNull(bytesToSign, nameof(bytesToSign)),
            }, callSettings);

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a blob using the system-managed private key for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="bytesToSign">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The bytes to sign.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<SignBlobResponse> SignBlobAsync(ServiceAccountName name, proto::ByteString bytesToSign, gaxgrpc::CallSettings callSettings = null) =>
            SignBlobAsync(new SignBlobRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                BytesToSign = gax::GaxPreconditions.CheckNotNull(bytesToSign, nameof(bytesToSign)),
            }, callSettings);

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a blob using the system-managed private key for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="bytesToSign">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The bytes to sign.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<SignBlobResponse> SignBlobAsync(ServiceAccountName name, proto::ByteString bytesToSign, st::CancellationToken cancellationToken) =>
            SignBlobAsync(name, bytesToSign, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a JSON Web Token (JWT) using the system-managed private key for a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual SignJwtResponse SignJwt(SignJwtRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a JSON Web Token (JWT) using the system-managed private key for a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<SignJwtResponse> SignJwtAsync(SignJwtRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a JSON Web Token (JWT) using the system-managed private key for a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<SignJwtResponse> SignJwtAsync(SignJwtRequest request, st::CancellationToken cancellationToken) =>
            SignJwtAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a JSON Web Token (JWT) using the system-managed private key for a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="payload">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The JWT payload to sign. Must be a serialized JSON object that contains a
        /// JWT Claims Set. For example: `{"sub": "user@example.com", "iat": 313435}`
        /// 
        /// If the JWT Claims Set contains an expiration time (`exp`) claim, it must be
        /// an integer timestamp that is not in the past and no more than 12 hours in
        /// the future.
        /// 
        /// If the JWT Claims Set does not contain an expiration time (`exp`) claim,
        /// this claim is added automatically, with a timestamp that is 1 hour in the
        /// future.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual SignJwtResponse SignJwt(string name, string payload, gaxgrpc::CallSettings callSettings = null) =>
            SignJwt(new SignJwtRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Payload = gax::GaxPreconditions.CheckNotNullOrEmpty(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a JSON Web Token (JWT) using the system-managed private key for a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="payload">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The JWT payload to sign. Must be a serialized JSON object that contains a
        /// JWT Claims Set. For example: `{"sub": "user@example.com", "iat": 313435}`
        /// 
        /// If the JWT Claims Set contains an expiration time (`exp`) claim, it must be
        /// an integer timestamp that is not in the past and no more than 12 hours in
        /// the future.
        /// 
        /// If the JWT Claims Set does not contain an expiration time (`exp`) claim,
        /// this claim is added automatically, with a timestamp that is 1 hour in the
        /// future.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<SignJwtResponse> SignJwtAsync(string name, string payload, gaxgrpc::CallSettings callSettings = null) =>
            SignJwtAsync(new SignJwtRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Payload = gax::GaxPreconditions.CheckNotNullOrEmpty(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a JSON Web Token (JWT) using the system-managed private key for a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="payload">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The JWT payload to sign. Must be a serialized JSON object that contains a
        /// JWT Claims Set. For example: `{"sub": "user@example.com", "iat": 313435}`
        /// 
        /// If the JWT Claims Set contains an expiration time (`exp`) claim, it must be
        /// an integer timestamp that is not in the past and no more than 12 hours in
        /// the future.
        /// 
        /// If the JWT Claims Set does not contain an expiration time (`exp`) claim,
        /// this claim is added automatically, with a timestamp that is 1 hour in the
        /// future.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<SignJwtResponse> SignJwtAsync(string name, string payload, st::CancellationToken cancellationToken) =>
            SignJwtAsync(name, payload, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a JSON Web Token (JWT) using the system-managed private key for a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="payload">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The JWT payload to sign. Must be a serialized JSON object that contains a
        /// JWT Claims Set. For example: `{"sub": "user@example.com", "iat": 313435}`
        /// 
        /// If the JWT Claims Set contains an expiration time (`exp`) claim, it must be
        /// an integer timestamp that is not in the past and no more than 12 hours in
        /// the future.
        /// 
        /// If the JWT Claims Set does not contain an expiration time (`exp`) claim,
        /// this claim is added automatically, with a timestamp that is 1 hour in the
        /// future.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual SignJwtResponse SignJwt(ServiceAccountName name, string payload, gaxgrpc::CallSettings callSettings = null) =>
            SignJwt(new SignJwtRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Payload = gax::GaxPreconditions.CheckNotNullOrEmpty(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a JSON Web Token (JWT) using the system-managed private key for a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="payload">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The JWT payload to sign. Must be a serialized JSON object that contains a
        /// JWT Claims Set. For example: `{"sub": "user@example.com", "iat": 313435}`
        /// 
        /// If the JWT Claims Set contains an expiration time (`exp`) claim, it must be
        /// an integer timestamp that is not in the past and no more than 12 hours in
        /// the future.
        /// 
        /// If the JWT Claims Set does not contain an expiration time (`exp`) claim,
        /// this claim is added automatically, with a timestamp that is 1 hour in the
        /// future.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<SignJwtResponse> SignJwtAsync(ServiceAccountName name, string payload, gaxgrpc::CallSettings callSettings = null) =>
            SignJwtAsync(new SignJwtRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Payload = gax::GaxPreconditions.CheckNotNullOrEmpty(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a JSON Web Token (JWT) using the system-managed private key for a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="name">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The resource name of the service account in the following format:
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        /// Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        /// the account. The `ACCOUNT` value can be the `email` address or the
        /// `unique_id` of the service account.
        /// </param>
        /// <param name="payload">
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api).
        /// 
        /// The JWT payload to sign. Must be a serialized JSON object that contains a
        /// JWT Claims Set. For example: `{"sub": "user@example.com", "iat": 313435}`
        /// 
        /// If the JWT Claims Set contains an expiration time (`exp`) claim, it must be
        /// an integer timestamp that is not in the past and no more than 12 hours in
        /// the future.
        /// 
        /// If the JWT Claims Set does not contain an expiration time (`exp`) claim,
        /// this claim is added automatically, with a timestamp that is 1 hour in the
        /// future.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public virtual stt::Task<SignJwtResponse> SignJwtAsync(ServiceAccountName name, string payload, st::CancellationToken cancellationToken) =>
            SignJwtAsync(name, payload, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount]. This IAM
        /// policy specifies which principals have access to the service account.
        /// 
        /// This method does not tell you whether the service account has been granted
        /// any roles on other resources. To check whether a service account has role
        /// grants on a resource, use the `getIamPolicy` method for that resource. For
        /// example, to view the role grants for a project, call the Resource Manager
        /// API's
        /// [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount]. This IAM
        /// policy specifies which principals have access to the service account.
        /// 
        /// This method does not tell you whether the service account has been granted
        /// any roles on other resources. To check whether a service account has role
        /// grants on a resource, use the `getIamPolicy` method for that resource. For
        /// example, to view the role grants for a project, call the Resource Manager
        /// API's
        /// [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount]. This IAM
        /// policy specifies which principals have access to the service account.
        /// 
        /// This method does not tell you whether the service account has been granted
        /// any roles on other resources. To check whether a service account has role
        /// grants on a resource, use the `getIamPolicy` method for that resource. For
        /// example, to view the role grants for a project, call the Resource Manager
        /// API's
        /// [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount]. This IAM
        /// policy specifies which principals have access to the service account.
        /// 
        /// This method does not tell you whether the service account has been granted
        /// any roles on other resources. To check whether a service account has role
        /// grants on a resource, use the `getIamPolicy` method for that resource. For
        /// example, to view the role grants for a project, call the Resource Manager
        /// API's
        /// [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
        /// method.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount]. This IAM
        /// policy specifies which principals have access to the service account.
        /// 
        /// This method does not tell you whether the service account has been granted
        /// any roles on other resources. To check whether a service account has role
        /// grants on a resource, use the `getIamPolicy` method for that resource. For
        /// example, to view the role grants for a project, call the Resource Manager
        /// API's
        /// [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
        /// method.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount]. This IAM
        /// policy specifies which principals have access to the service account.
        /// 
        /// This method does not tell you whether the service account has been granted
        /// any roles on other resources. To check whether a service account has role
        /// grants on a resource, use the `getIamPolicy` method for that resource. For
        /// example, to view the role grants for a project, call the Resource Manager
        /// API's
        /// [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
        /// method.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount]. This IAM
        /// policy specifies which principals have access to the service account.
        /// 
        /// This method does not tell you whether the service account has been granted
        /// any roles on other resources. To check whether a service account has role
        /// grants on a resource, use the `getIamPolicy` method for that resource. For
        /// example, to view the role grants for a project, call the Resource Manager
        /// API's
        /// [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
        /// method.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount]. This IAM
        /// policy specifies which principals have access to the service account.
        /// 
        /// This method does not tell you whether the service account has been granted
        /// any roles on other resources. To check whether a service account has role
        /// grants on a resource, use the `getIamPolicy` method for that resource. For
        /// example, to view the role grants for a project, call the Resource Manager
        /// API's
        /// [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
        /// method.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount]. This IAM
        /// policy specifies which principals have access to the service account.
        /// 
        /// This method does not tell you whether the service account has been granted
        /// any roles on other resources. To check whether a service account has role
        /// grants on a resource, use the `getIamPolicy` method for that resource. For
        /// example, to view the role grants for a project, call the Resource Manager
        /// API's
        /// [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
        /// method.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// Use this method to grant or revoke access to the service account. For
        /// example, you could grant a principal the ability to impersonate the service
        /// account.
        /// 
        /// This method does not enable the service account to access other resources.
        /// To grant roles to a service account on a resource, follow these steps:
        /// 
        /// 1. Call the resource's `getIamPolicy` method to get its current IAM policy.
        /// 2. Edit the policy so that it binds the service account to an IAM role for
        /// the resource.
        /// 3. Call the resource's `setIamPolicy` method to update its IAM policy.
        /// 
        /// For detailed instructions, see
        /// [Manage access to project, folders, and
        /// organizations](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts)
        /// or [Manage access to other
        /// resources](https://cloud.google.com/iam/help/access/manage-other-resources).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// Use this method to grant or revoke access to the service account. For
        /// example, you could grant a principal the ability to impersonate the service
        /// account.
        /// 
        /// This method does not enable the service account to access other resources.
        /// To grant roles to a service account on a resource, follow these steps:
        /// 
        /// 1. Call the resource's `getIamPolicy` method to get its current IAM policy.
        /// 2. Edit the policy so that it binds the service account to an IAM role for
        /// the resource.
        /// 3. Call the resource's `setIamPolicy` method to update its IAM policy.
        /// 
        /// For detailed instructions, see
        /// [Manage access to project, folders, and
        /// organizations](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts)
        /// or [Manage access to other
        /// resources](https://cloud.google.com/iam/help/access/manage-other-resources).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// Use this method to grant or revoke access to the service account. For
        /// example, you could grant a principal the ability to impersonate the service
        /// account.
        /// 
        /// This method does not enable the service account to access other resources.
        /// To grant roles to a service account on a resource, follow these steps:
        /// 
        /// 1. Call the resource's `getIamPolicy` method to get its current IAM policy.
        /// 2. Edit the policy so that it binds the service account to an IAM role for
        /// the resource.
        /// 3. Call the resource's `setIamPolicy` method to update its IAM policy.
        /// 
        /// For detailed instructions, see
        /// [Manage access to project, folders, and
        /// organizations](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts)
        /// or [Manage access to other
        /// resources](https://cloud.google.com/iam/help/access/manage-other-resources).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// Use this method to grant or revoke access to the service account. For
        /// example, you could grant a principal the ability to impersonate the service
        /// account.
        /// 
        /// This method does not enable the service account to access other resources.
        /// To grant roles to a service account on a resource, follow these steps:
        /// 
        /// 1. Call the resource's `getIamPolicy` method to get its current IAM policy.
        /// 2. Edit the policy so that it binds the service account to an IAM role for
        /// the resource.
        /// 3. Call the resource's `setIamPolicy` method to update its IAM policy.
        /// 
        /// For detailed instructions, see
        /// [Manage access to project, folders, and
        /// organizations](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts)
        /// or [Manage access to other
        /// resources](https://cloud.google.com/iam/help/access/manage-other-resources).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// Use this method to grant or revoke access to the service account. For
        /// example, you could grant a principal the ability to impersonate the service
        /// account.
        /// 
        /// This method does not enable the service account to access other resources.
        /// To grant roles to a service account on a resource, follow these steps:
        /// 
        /// 1. Call the resource's `getIamPolicy` method to get its current IAM policy.
        /// 2. Edit the policy so that it binds the service account to an IAM role for
        /// the resource.
        /// 3. Call the resource's `setIamPolicy` method to update its IAM policy.
        /// 
        /// For detailed instructions, see
        /// [Manage access to project, folders, and
        /// organizations](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts)
        /// or [Manage access to other
        /// resources](https://cloud.google.com/iam/help/access/manage-other-resources).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// Use this method to grant or revoke access to the service account. For
        /// example, you could grant a principal the ability to impersonate the service
        /// account.
        /// 
        /// This method does not enable the service account to access other resources.
        /// To grant roles to a service account on a resource, follow these steps:
        /// 
        /// 1. Call the resource's `getIamPolicy` method to get its current IAM policy.
        /// 2. Edit the policy so that it binds the service account to an IAM role for
        /// the resource.
        /// 3. Call the resource's `setIamPolicy` method to update its IAM policy.
        /// 
        /// For detailed instructions, see
        /// [Manage access to project, folders, and
        /// organizations](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts)
        /// or [Manage access to other
        /// resources](https://cloud.google.com/iam/help/access/manage-other-resources).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// Use this method to grant or revoke access to the service account. For
        /// example, you could grant a principal the ability to impersonate the service
        /// account.
        /// 
        /// This method does not enable the service account to access other resources.
        /// To grant roles to a service account on a resource, follow these steps:
        /// 
        /// 1. Call the resource's `getIamPolicy` method to get its current IAM policy.
        /// 2. Edit the policy so that it binds the service account to an IAM role for
        /// the resource.
        /// 3. Call the resource's `setIamPolicy` method to update its IAM policy.
        /// 
        /// For detailed instructions, see
        /// [Manage access to project, folders, and
        /// organizations](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts)
        /// or [Manage access to other
        /// resources](https://cloud.google.com/iam/help/access/manage-other-resources).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// Use this method to grant or revoke access to the service account. For
        /// example, you could grant a principal the ability to impersonate the service
        /// account.
        /// 
        /// This method does not enable the service account to access other resources.
        /// To grant roles to a service account on a resource, follow these steps:
        /// 
        /// 1. Call the resource's `getIamPolicy` method to get its current IAM policy.
        /// 2. Edit the policy so that it binds the service account to an IAM role for
        /// the resource.
        /// 3. Call the resource's `setIamPolicy` method to update its IAM policy.
        /// 
        /// For detailed instructions, see
        /// [Manage access to project, folders, and
        /// organizations](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts)
        /// or [Manage access to other
        /// resources](https://cloud.google.com/iam/help/access/manage-other-resources).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// Use this method to grant or revoke access to the service account. For
        /// example, you could grant a principal the ability to impersonate the service
        /// account.
        /// 
        /// This method does not enable the service account to access other resources.
        /// To grant roles to a service account on a resource, follow these steps:
        /// 
        /// 1. Call the resource's `getIamPolicy` method to get its current IAM policy.
        /// 2. Edit the policy so that it binds the service account to an IAM role for
        /// the resource.
        /// 3. Call the resource's `setIamPolicy` method to update its IAM policy.
        /// 
        /// For detailed instructions, see
        /// [Manage access to project, folders, and
        /// organizations](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts)
        /// or [Manage access to other
        /// resources](https://cloud.google.com/iam/help/access/manage-other-resources).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests whether the caller has the specified permissions on a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests whether the caller has the specified permissions on a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests whether the caller has the specified permissions on a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests whether the caller has the specified permissions on a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests whether the caller has the specified permissions on a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests whether the caller has the specified permissions on a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests whether the caller has the specified permissions on a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests whether the caller has the specified permissions on a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests whether the caller has the specified permissions on a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists roles that can be granted on a Google Cloud resource. A role is
        /// grantable if the IAM policy for the resource can contain bindings to the
        /// role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Role"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryGrantableRolesResponse, Role> QueryGrantableRoles(QueryGrantableRolesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists roles that can be granted on a Google Cloud resource. A role is
        /// grantable if the IAM policy for the resource can contain bindings to the
        /// role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Role"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryGrantableRolesResponse, Role> QueryGrantableRolesAsync(QueryGrantableRolesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists roles that can be granted on a Google Cloud resource. A role is
        /// grantable if the IAM policy for the resource can contain bindings to the
        /// role.
        /// </summary>
        /// <param name="fullResourceName">
        /// Required. The full resource name to query from the list of grantable roles.
        /// 
        /// The name follows the Google Cloud Platform resource format.
        /// For example, a Cloud Platform project with id `my-project` will be named
        /// `//cloudresourcemanager.googleapis.com/projects/my-project`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Role"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryGrantableRolesResponse, Role> QueryGrantableRoles(string fullResourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryGrantableRolesRequest request = new QueryGrantableRolesRequest
            {
                FullResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(fullResourceName, nameof(fullResourceName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryGrantableRoles(request, callSettings);
        }

        /// <summary>
        /// Lists roles that can be granted on a Google Cloud resource. A role is
        /// grantable if the IAM policy for the resource can contain bindings to the
        /// role.
        /// </summary>
        /// <param name="fullResourceName">
        /// Required. The full resource name to query from the list of grantable roles.
        /// 
        /// The name follows the Google Cloud Platform resource format.
        /// For example, a Cloud Platform project with id `my-project` will be named
        /// `//cloudresourcemanager.googleapis.com/projects/my-project`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Role"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryGrantableRolesResponse, Role> QueryGrantableRolesAsync(string fullResourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryGrantableRolesRequest request = new QueryGrantableRolesRequest
            {
                FullResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(fullResourceName, nameof(fullResourceName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryGrantableRolesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists every predefined [Role][google.iam.admin.v1.Role] that IAM supports, or every custom role
        /// that is defined for an organization or project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Role"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolesResponse, Role> ListRoles(ListRolesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists every predefined [Role][google.iam.admin.v1.Role] that IAM supports, or every custom role
        /// that is defined for an organization or project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Role"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolesResponse, Role> ListRolesAsync(ListRolesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the definition of a [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Role GetRole(GetRoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the definition of a [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> GetRoleAsync(GetRoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the definition of a [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> GetRoleAsync(GetRoleRequest request, st::CancellationToken cancellationToken) =>
            GetRoleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Role CreateRole(CreateRoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> CreateRoleAsync(CreateRoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> CreateRoleAsync(CreateRoleRequest request, st::CancellationToken cancellationToken) =>
            CreateRoleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the definition of a custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Role UpdateRole(UpdateRoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the definition of a custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> UpdateRoleAsync(UpdateRoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the definition of a custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> UpdateRoleAsync(UpdateRoleRequest request, st::CancellationToken cancellationToken) =>
            UpdateRoleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a custom [Role][google.iam.admin.v1.Role].
        /// 
        /// When you delete a custom role, the following changes occur immediately:
        /// 
        /// * You cannot bind a principal to the custom role in an IAM
        /// [Policy][google.iam.v1.Policy].
        /// * Existing bindings to the custom role are not changed, but they have no
        /// effect.
        /// * By default, the response from [ListRoles][google.iam.admin.v1.IAM.ListRoles] does not include the custom
        /// role.
        /// 
        /// You have 7 days to undelete the custom role. After 7 days, the following
        /// changes occur:
        /// 
        /// * The custom role is permanently deleted and cannot be recovered.
        /// * If an IAM policy contains a binding to the custom role, the binding is
        /// permanently removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Role DeleteRole(DeleteRoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a custom [Role][google.iam.admin.v1.Role].
        /// 
        /// When you delete a custom role, the following changes occur immediately:
        /// 
        /// * You cannot bind a principal to the custom role in an IAM
        /// [Policy][google.iam.v1.Policy].
        /// * Existing bindings to the custom role are not changed, but they have no
        /// effect.
        /// * By default, the response from [ListRoles][google.iam.admin.v1.IAM.ListRoles] does not include the custom
        /// role.
        /// 
        /// You have 7 days to undelete the custom role. After 7 days, the following
        /// changes occur:
        /// 
        /// * The custom role is permanently deleted and cannot be recovered.
        /// * If an IAM policy contains a binding to the custom role, the binding is
        /// permanently removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> DeleteRoleAsync(DeleteRoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a custom [Role][google.iam.admin.v1.Role].
        /// 
        /// When you delete a custom role, the following changes occur immediately:
        /// 
        /// * You cannot bind a principal to the custom role in an IAM
        /// [Policy][google.iam.v1.Policy].
        /// * Existing bindings to the custom role are not changed, but they have no
        /// effect.
        /// * By default, the response from [ListRoles][google.iam.admin.v1.IAM.ListRoles] does not include the custom
        /// role.
        /// 
        /// You have 7 days to undelete the custom role. After 7 days, the following
        /// changes occur:
        /// 
        /// * The custom role is permanently deleted and cannot be recovered.
        /// * If an IAM policy contains a binding to the custom role, the binding is
        /// permanently removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> DeleteRoleAsync(DeleteRoleRequest request, st::CancellationToken cancellationToken) =>
            DeleteRoleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes a custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Role UndeleteRole(UndeleteRoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes a custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> UndeleteRoleAsync(UndeleteRoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes a custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> UndeleteRoleAsync(UndeleteRoleRequest request, st::CancellationToken cancellationToken) =>
            UndeleteRoleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists every permission that you can test on a resource. A permission is
        /// testable if you can check whether a principal has that permission on the
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Permission"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryTestablePermissionsResponse, Permission> QueryTestablePermissions(QueryTestablePermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists every permission that you can test on a resource. A permission is
        /// testable if you can check whether a principal has that permission on the
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Permission"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryTestablePermissionsResponse, Permission> QueryTestablePermissionsAsync(QueryTestablePermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of services that allow you to opt into audit logs that are
        /// not generated by default.
        /// 
        /// To learn more about audit logs, see the [Logging
        /// documentation](https://cloud.google.com/logging/docs/audit).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryAuditableServicesResponse QueryAuditableServices(QueryAuditableServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of services that allow you to opt into audit logs that are
        /// not generated by default.
        /// 
        /// To learn more about audit logs, see the [Logging
        /// documentation](https://cloud.google.com/logging/docs/audit).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryAuditableServicesResponse> QueryAuditableServicesAsync(QueryAuditableServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of services that allow you to opt into audit logs that are
        /// not generated by default.
        /// 
        /// To learn more about audit logs, see the [Logging
        /// documentation](https://cloud.google.com/logging/docs/audit).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryAuditableServicesResponse> QueryAuditableServicesAsync(QueryAuditableServicesRequest request, st::CancellationToken cancellationToken) =>
            QueryAuditableServicesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lints, or validates, an IAM policy. Currently checks the
        /// [google.iam.v1.Binding.condition][google.iam.v1.Binding.condition] field, which contains a condition
        /// expression for a role binding.
        /// 
        /// Successful calls to this method always return an HTTP `200 OK` status code,
        /// even if the linter detects an issue in the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LintPolicyResponse LintPolicy(LintPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lints, or validates, an IAM policy. Currently checks the
        /// [google.iam.v1.Binding.condition][google.iam.v1.Binding.condition] field, which contains a condition
        /// expression for a role binding.
        /// 
        /// Successful calls to this method always return an HTTP `200 OK` status code,
        /// even if the linter detects an issue in the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LintPolicyResponse> LintPolicyAsync(LintPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lints, or validates, an IAM policy. Currently checks the
        /// [google.iam.v1.Binding.condition][google.iam.v1.Binding.condition] field, which contains a condition
        /// expression for a role binding.
        /// 
        /// Successful calls to this method always return an HTTP `200 OK` status code,
        /// even if the linter detects an issue in the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LintPolicyResponse> LintPolicyAsync(LintPolicyRequest request, st::CancellationToken cancellationToken) =>
            LintPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IAM client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Creates and manages Identity and Access Management (IAM) resources.
    /// 
    /// You can use this service to work with all of the following resources:
    /// 
    /// * **Service accounts**, which identify an application or a virtual machine
    /// (VM) instance rather than a person
    /// * **Service account keys**, which service accounts use to authenticate with
    /// Google APIs
    /// * **IAM policies for service accounts**, which specify the roles that a
    /// principal has for the service account
    /// * **IAM custom roles**, which help you limit the number of permissions that
    /// you grant to principals
    /// 
    /// In addition, you can use this service to complete the following tasks, among
    /// others:
    /// 
    /// * Test whether a service account can use specific permissions
    /// * Check which roles you can grant for a specific resource
    /// * Lint, or validate, condition expressions in an IAM policy
    /// 
    /// When you read data from the IAM API, each read is eventually consistent. In
    /// other words, if you write data with the IAM API, then immediately read that
    /// data, the read operation might return an older version of the data. To deal
    /// with this behavior, your application can retry the request with truncated
    /// exponential backoff.
    /// 
    /// In contrast, writing data to the IAM API is sequentially consistent. In other
    /// words, write operations are always processed in the order in which they were
    /// received.
    /// </remarks>
    public sealed partial class IAMClientImpl : IAMClient
    {
        private readonly gaxgrpc::ApiCall<ListServiceAccountsRequest, ListServiceAccountsResponse> _callListServiceAccounts;

        private readonly gaxgrpc::ApiCall<GetServiceAccountRequest, ServiceAccount> _callGetServiceAccount;

        private readonly gaxgrpc::ApiCall<CreateServiceAccountRequest, ServiceAccount> _callCreateServiceAccount;

        private readonly gaxgrpc::ApiCall<ServiceAccount, ServiceAccount> _callUpdateServiceAccount;

        private readonly gaxgrpc::ApiCall<PatchServiceAccountRequest, ServiceAccount> _callPatchServiceAccount;

        private readonly gaxgrpc::ApiCall<DeleteServiceAccountRequest, wkt::Empty> _callDeleteServiceAccount;

        private readonly gaxgrpc::ApiCall<UndeleteServiceAccountRequest, UndeleteServiceAccountResponse> _callUndeleteServiceAccount;

        private readonly gaxgrpc::ApiCall<EnableServiceAccountRequest, wkt::Empty> _callEnableServiceAccount;

        private readonly gaxgrpc::ApiCall<DisableServiceAccountRequest, wkt::Empty> _callDisableServiceAccount;

        private readonly gaxgrpc::ApiCall<ListServiceAccountKeysRequest, ListServiceAccountKeysResponse> _callListServiceAccountKeys;

        private readonly gaxgrpc::ApiCall<GetServiceAccountKeyRequest, ServiceAccountKey> _callGetServiceAccountKey;

        private readonly gaxgrpc::ApiCall<CreateServiceAccountKeyRequest, ServiceAccountKey> _callCreateServiceAccountKey;

        private readonly gaxgrpc::ApiCall<UploadServiceAccountKeyRequest, ServiceAccountKey> _callUploadServiceAccountKey;

        private readonly gaxgrpc::ApiCall<DeleteServiceAccountKeyRequest, wkt::Empty> _callDeleteServiceAccountKey;

        private readonly gaxgrpc::ApiCall<DisableServiceAccountKeyRequest, wkt::Empty> _callDisableServiceAccountKey;

        private readonly gaxgrpc::ApiCall<EnableServiceAccountKeyRequest, wkt::Empty> _callEnableServiceAccountKey;

        private readonly gaxgrpc::ApiCall<SignBlobRequest, SignBlobResponse> _callSignBlob;

        private readonly gaxgrpc::ApiCall<SignJwtRequest, SignJwtResponse> _callSignJwt;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<QueryGrantableRolesRequest, QueryGrantableRolesResponse> _callQueryGrantableRoles;

        private readonly gaxgrpc::ApiCall<ListRolesRequest, ListRolesResponse> _callListRoles;

        private readonly gaxgrpc::ApiCall<GetRoleRequest, Role> _callGetRole;

        private readonly gaxgrpc::ApiCall<CreateRoleRequest, Role> _callCreateRole;

        private readonly gaxgrpc::ApiCall<UpdateRoleRequest, Role> _callUpdateRole;

        private readonly gaxgrpc::ApiCall<DeleteRoleRequest, Role> _callDeleteRole;

        private readonly gaxgrpc::ApiCall<UndeleteRoleRequest, Role> _callUndeleteRole;

        private readonly gaxgrpc::ApiCall<QueryTestablePermissionsRequest, QueryTestablePermissionsResponse> _callQueryTestablePermissions;

        private readonly gaxgrpc::ApiCall<QueryAuditableServicesRequest, QueryAuditableServicesResponse> _callQueryAuditableServices;

        private readonly gaxgrpc::ApiCall<LintPolicyRequest, LintPolicyResponse> _callLintPolicy;

        /// <summary>
        /// Constructs a client wrapper for the IAM service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IAMSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IAMClientImpl(IAM.IAMClient grpcClient, IAMSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IAMSettings effectiveSettings = settings ?? IAMSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListServiceAccounts = clientHelper.BuildApiCall<ListServiceAccountsRequest, ListServiceAccountsResponse>("ListServiceAccounts", grpcClient.ListServiceAccountsAsync, grpcClient.ListServiceAccounts, effectiveSettings.ListServiceAccountsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListServiceAccounts);
            Modify_ListServiceAccountsApiCall(ref _callListServiceAccounts);
            _callGetServiceAccount = clientHelper.BuildApiCall<GetServiceAccountRequest, ServiceAccount>("GetServiceAccount", grpcClient.GetServiceAccountAsync, grpcClient.GetServiceAccount, effectiveSettings.GetServiceAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServiceAccount);
            Modify_GetServiceAccountApiCall(ref _callGetServiceAccount);
            _callCreateServiceAccount = clientHelper.BuildApiCall<CreateServiceAccountRequest, ServiceAccount>("CreateServiceAccount", grpcClient.CreateServiceAccountAsync, grpcClient.CreateServiceAccount, effectiveSettings.CreateServiceAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateServiceAccount);
            Modify_CreateServiceAccountApiCall(ref _callCreateServiceAccount);
            _callUpdateServiceAccount = clientHelper.BuildApiCall<ServiceAccount, ServiceAccount>("UpdateServiceAccount", grpcClient.UpdateServiceAccountAsync, grpcClient.UpdateServiceAccount, effectiveSettings.UpdateServiceAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateServiceAccount);
            Modify_UpdateServiceAccountApiCall(ref _callUpdateServiceAccount);
            _callPatchServiceAccount = clientHelper.BuildApiCall<PatchServiceAccountRequest, ServiceAccount>("PatchServiceAccount", grpcClient.PatchServiceAccountAsync, grpcClient.PatchServiceAccount, effectiveSettings.PatchServiceAccountSettings).WithGoogleRequestParam("service_account.name", request => request.ServiceAccount?.Name);
            Modify_ApiCall(ref _callPatchServiceAccount);
            Modify_PatchServiceAccountApiCall(ref _callPatchServiceAccount);
            _callDeleteServiceAccount = clientHelper.BuildApiCall<DeleteServiceAccountRequest, wkt::Empty>("DeleteServiceAccount", grpcClient.DeleteServiceAccountAsync, grpcClient.DeleteServiceAccount, effectiveSettings.DeleteServiceAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServiceAccount);
            Modify_DeleteServiceAccountApiCall(ref _callDeleteServiceAccount);
            _callUndeleteServiceAccount = clientHelper.BuildApiCall<UndeleteServiceAccountRequest, UndeleteServiceAccountResponse>("UndeleteServiceAccount", grpcClient.UndeleteServiceAccountAsync, grpcClient.UndeleteServiceAccount, effectiveSettings.UndeleteServiceAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeleteServiceAccount);
            Modify_UndeleteServiceAccountApiCall(ref _callUndeleteServiceAccount);
            _callEnableServiceAccount = clientHelper.BuildApiCall<EnableServiceAccountRequest, wkt::Empty>("EnableServiceAccount", grpcClient.EnableServiceAccountAsync, grpcClient.EnableServiceAccount, effectiveSettings.EnableServiceAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnableServiceAccount);
            Modify_EnableServiceAccountApiCall(ref _callEnableServiceAccount);
            _callDisableServiceAccount = clientHelper.BuildApiCall<DisableServiceAccountRequest, wkt::Empty>("DisableServiceAccount", grpcClient.DisableServiceAccountAsync, grpcClient.DisableServiceAccount, effectiveSettings.DisableServiceAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisableServiceAccount);
            Modify_DisableServiceAccountApiCall(ref _callDisableServiceAccount);
            _callListServiceAccountKeys = clientHelper.BuildApiCall<ListServiceAccountKeysRequest, ListServiceAccountKeysResponse>("ListServiceAccountKeys", grpcClient.ListServiceAccountKeysAsync, grpcClient.ListServiceAccountKeys, effectiveSettings.ListServiceAccountKeysSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListServiceAccountKeys);
            Modify_ListServiceAccountKeysApiCall(ref _callListServiceAccountKeys);
            _callGetServiceAccountKey = clientHelper.BuildApiCall<GetServiceAccountKeyRequest, ServiceAccountKey>("GetServiceAccountKey", grpcClient.GetServiceAccountKeyAsync, grpcClient.GetServiceAccountKey, effectiveSettings.GetServiceAccountKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServiceAccountKey);
            Modify_GetServiceAccountKeyApiCall(ref _callGetServiceAccountKey);
            _callCreateServiceAccountKey = clientHelper.BuildApiCall<CreateServiceAccountKeyRequest, ServiceAccountKey>("CreateServiceAccountKey", grpcClient.CreateServiceAccountKeyAsync, grpcClient.CreateServiceAccountKey, effectiveSettings.CreateServiceAccountKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateServiceAccountKey);
            Modify_CreateServiceAccountKeyApiCall(ref _callCreateServiceAccountKey);
            _callUploadServiceAccountKey = clientHelper.BuildApiCall<UploadServiceAccountKeyRequest, ServiceAccountKey>("UploadServiceAccountKey", grpcClient.UploadServiceAccountKeyAsync, grpcClient.UploadServiceAccountKey, effectiveSettings.UploadServiceAccountKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUploadServiceAccountKey);
            Modify_UploadServiceAccountKeyApiCall(ref _callUploadServiceAccountKey);
            _callDeleteServiceAccountKey = clientHelper.BuildApiCall<DeleteServiceAccountKeyRequest, wkt::Empty>("DeleteServiceAccountKey", grpcClient.DeleteServiceAccountKeyAsync, grpcClient.DeleteServiceAccountKey, effectiveSettings.DeleteServiceAccountKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServiceAccountKey);
            Modify_DeleteServiceAccountKeyApiCall(ref _callDeleteServiceAccountKey);
            _callDisableServiceAccountKey = clientHelper.BuildApiCall<DisableServiceAccountKeyRequest, wkt::Empty>("DisableServiceAccountKey", grpcClient.DisableServiceAccountKeyAsync, grpcClient.DisableServiceAccountKey, effectiveSettings.DisableServiceAccountKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisableServiceAccountKey);
            Modify_DisableServiceAccountKeyApiCall(ref _callDisableServiceAccountKey);
            _callEnableServiceAccountKey = clientHelper.BuildApiCall<EnableServiceAccountKeyRequest, wkt::Empty>("EnableServiceAccountKey", grpcClient.EnableServiceAccountKeyAsync, grpcClient.EnableServiceAccountKey, effectiveSettings.EnableServiceAccountKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnableServiceAccountKey);
            Modify_EnableServiceAccountKeyApiCall(ref _callEnableServiceAccountKey);
#pragma warning disable CS0612
            _callSignBlob = clientHelper.BuildApiCall<SignBlobRequest, SignBlobResponse>("SignBlob", grpcClient.SignBlobAsync, grpcClient.SignBlob, effectiveSettings.SignBlobSettings).WithGoogleRequestParam("name", request => request.Name);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callSignBlob);
            Modify_SignBlobApiCall(ref _callSignBlob);
#pragma warning disable CS0612
            _callSignJwt = clientHelper.BuildApiCall<SignJwtRequest, SignJwtResponse>("SignJwt", grpcClient.SignJwtAsync, grpcClient.SignJwt, effectiveSettings.SignJwtSettings).WithGoogleRequestParam("name", request => request.Name);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callSignJwt);
            Modify_SignJwtApiCall(ref _callSignJwt);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callQueryGrantableRoles = clientHelper.BuildApiCall<QueryGrantableRolesRequest, QueryGrantableRolesResponse>("QueryGrantableRoles", grpcClient.QueryGrantableRolesAsync, grpcClient.QueryGrantableRoles, effectiveSettings.QueryGrantableRolesSettings);
            Modify_ApiCall(ref _callQueryGrantableRoles);
            Modify_QueryGrantableRolesApiCall(ref _callQueryGrantableRoles);
            _callListRoles = clientHelper.BuildApiCall<ListRolesRequest, ListRolesResponse>("ListRoles", grpcClient.ListRolesAsync, grpcClient.ListRoles, effectiveSettings.ListRolesSettings);
            Modify_ApiCall(ref _callListRoles);
            Modify_ListRolesApiCall(ref _callListRoles);
            _callGetRole = clientHelper.BuildApiCall<GetRoleRequest, Role>("GetRole", grpcClient.GetRoleAsync, grpcClient.GetRole, effectiveSettings.GetRoleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRole);
            Modify_GetRoleApiCall(ref _callGetRole);
            _callCreateRole = clientHelper.BuildApiCall<CreateRoleRequest, Role>("CreateRole", grpcClient.CreateRoleAsync, grpcClient.CreateRole, effectiveSettings.CreateRoleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRole);
            Modify_CreateRoleApiCall(ref _callCreateRole);
            _callUpdateRole = clientHelper.BuildApiCall<UpdateRoleRequest, Role>("UpdateRole", grpcClient.UpdateRoleAsync, grpcClient.UpdateRole, effectiveSettings.UpdateRoleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateRole);
            Modify_UpdateRoleApiCall(ref _callUpdateRole);
            _callDeleteRole = clientHelper.BuildApiCall<DeleteRoleRequest, Role>("DeleteRole", grpcClient.DeleteRoleAsync, grpcClient.DeleteRole, effectiveSettings.DeleteRoleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRole);
            Modify_DeleteRoleApiCall(ref _callDeleteRole);
            _callUndeleteRole = clientHelper.BuildApiCall<UndeleteRoleRequest, Role>("UndeleteRole", grpcClient.UndeleteRoleAsync, grpcClient.UndeleteRole, effectiveSettings.UndeleteRoleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeleteRole);
            Modify_UndeleteRoleApiCall(ref _callUndeleteRole);
            _callQueryTestablePermissions = clientHelper.BuildApiCall<QueryTestablePermissionsRequest, QueryTestablePermissionsResponse>("QueryTestablePermissions", grpcClient.QueryTestablePermissionsAsync, grpcClient.QueryTestablePermissions, effectiveSettings.QueryTestablePermissionsSettings);
            Modify_ApiCall(ref _callQueryTestablePermissions);
            Modify_QueryTestablePermissionsApiCall(ref _callQueryTestablePermissions);
            _callQueryAuditableServices = clientHelper.BuildApiCall<QueryAuditableServicesRequest, QueryAuditableServicesResponse>("QueryAuditableServices", grpcClient.QueryAuditableServicesAsync, grpcClient.QueryAuditableServices, effectiveSettings.QueryAuditableServicesSettings);
            Modify_ApiCall(ref _callQueryAuditableServices);
            Modify_QueryAuditableServicesApiCall(ref _callQueryAuditableServices);
            _callLintPolicy = clientHelper.BuildApiCall<LintPolicyRequest, LintPolicyResponse>("LintPolicy", grpcClient.LintPolicyAsync, grpcClient.LintPolicy, effectiveSettings.LintPolicySettings);
            Modify_ApiCall(ref _callLintPolicy);
            Modify_LintPolicyApiCall(ref _callLintPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListServiceAccountsApiCall(ref gaxgrpc::ApiCall<ListServiceAccountsRequest, ListServiceAccountsResponse> call);

        partial void Modify_GetServiceAccountApiCall(ref gaxgrpc::ApiCall<GetServiceAccountRequest, ServiceAccount> call);

        partial void Modify_CreateServiceAccountApiCall(ref gaxgrpc::ApiCall<CreateServiceAccountRequest, ServiceAccount> call);

        partial void Modify_UpdateServiceAccountApiCall(ref gaxgrpc::ApiCall<ServiceAccount, ServiceAccount> call);

        partial void Modify_PatchServiceAccountApiCall(ref gaxgrpc::ApiCall<PatchServiceAccountRequest, ServiceAccount> call);

        partial void Modify_DeleteServiceAccountApiCall(ref gaxgrpc::ApiCall<DeleteServiceAccountRequest, wkt::Empty> call);

        partial void Modify_UndeleteServiceAccountApiCall(ref gaxgrpc::ApiCall<UndeleteServiceAccountRequest, UndeleteServiceAccountResponse> call);

        partial void Modify_EnableServiceAccountApiCall(ref gaxgrpc::ApiCall<EnableServiceAccountRequest, wkt::Empty> call);

        partial void Modify_DisableServiceAccountApiCall(ref gaxgrpc::ApiCall<DisableServiceAccountRequest, wkt::Empty> call);

        partial void Modify_ListServiceAccountKeysApiCall(ref gaxgrpc::ApiCall<ListServiceAccountKeysRequest, ListServiceAccountKeysResponse> call);

        partial void Modify_GetServiceAccountKeyApiCall(ref gaxgrpc::ApiCall<GetServiceAccountKeyRequest, ServiceAccountKey> call);

        partial void Modify_CreateServiceAccountKeyApiCall(ref gaxgrpc::ApiCall<CreateServiceAccountKeyRequest, ServiceAccountKey> call);

        partial void Modify_UploadServiceAccountKeyApiCall(ref gaxgrpc::ApiCall<UploadServiceAccountKeyRequest, ServiceAccountKey> call);

        partial void Modify_DeleteServiceAccountKeyApiCall(ref gaxgrpc::ApiCall<DeleteServiceAccountKeyRequest, wkt::Empty> call);

        partial void Modify_DisableServiceAccountKeyApiCall(ref gaxgrpc::ApiCall<DisableServiceAccountKeyRequest, wkt::Empty> call);

        partial void Modify_EnableServiceAccountKeyApiCall(ref gaxgrpc::ApiCall<EnableServiceAccountKeyRequest, wkt::Empty> call);

        partial void Modify_SignBlobApiCall(ref gaxgrpc::ApiCall<SignBlobRequest, SignBlobResponse> call);

        partial void Modify_SignJwtApiCall(ref gaxgrpc::ApiCall<SignJwtRequest, SignJwtResponse> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_QueryGrantableRolesApiCall(ref gaxgrpc::ApiCall<QueryGrantableRolesRequest, QueryGrantableRolesResponse> call);

        partial void Modify_ListRolesApiCall(ref gaxgrpc::ApiCall<ListRolesRequest, ListRolesResponse> call);

        partial void Modify_GetRoleApiCall(ref gaxgrpc::ApiCall<GetRoleRequest, Role> call);

        partial void Modify_CreateRoleApiCall(ref gaxgrpc::ApiCall<CreateRoleRequest, Role> call);

        partial void Modify_UpdateRoleApiCall(ref gaxgrpc::ApiCall<UpdateRoleRequest, Role> call);

        partial void Modify_DeleteRoleApiCall(ref gaxgrpc::ApiCall<DeleteRoleRequest, Role> call);

        partial void Modify_UndeleteRoleApiCall(ref gaxgrpc::ApiCall<UndeleteRoleRequest, Role> call);

        partial void Modify_QueryTestablePermissionsApiCall(ref gaxgrpc::ApiCall<QueryTestablePermissionsRequest, QueryTestablePermissionsResponse> call);

        partial void Modify_QueryAuditableServicesApiCall(ref gaxgrpc::ApiCall<QueryAuditableServicesRequest, QueryAuditableServicesResponse> call);

        partial void Modify_LintPolicyApiCall(ref gaxgrpc::ApiCall<LintPolicyRequest, LintPolicyResponse> call);

        partial void OnConstruction(IAM.IAMClient grpcClient, IAMSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IAM client</summary>
        public override IAM.IAMClient GrpcClient { get; }

        partial void Modify_ListServiceAccountsRequest(ref ListServiceAccountsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceAccountRequest(ref GetServiceAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceAccountRequest(ref CreateServiceAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ServiceAccount(ref ServiceAccount request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchServiceAccountRequest(ref PatchServiceAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceAccountRequest(ref DeleteServiceAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeleteServiceAccountRequest(ref UndeleteServiceAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnableServiceAccountRequest(ref EnableServiceAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableServiceAccountRequest(ref DisableServiceAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServiceAccountKeysRequest(ref ListServiceAccountKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceAccountKeyRequest(ref GetServiceAccountKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceAccountKeyRequest(ref CreateServiceAccountKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UploadServiceAccountKeyRequest(ref UploadServiceAccountKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceAccountKeyRequest(ref DeleteServiceAccountKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableServiceAccountKeyRequest(ref DisableServiceAccountKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnableServiceAccountKeyRequest(ref EnableServiceAccountKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SignBlobRequest(ref SignBlobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SignJwtRequest(ref SignJwtRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryGrantableRolesRequest(ref QueryGrantableRolesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRolesRequest(ref ListRolesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRoleRequest(ref GetRoleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRoleRequest(ref CreateRoleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRoleRequest(ref UpdateRoleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRoleRequest(ref DeleteRoleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeleteRoleRequest(ref UndeleteRoleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryTestablePermissionsRequest(ref QueryTestablePermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryAuditableServicesRequest(ref QueryAuditableServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LintPolicyRequest(ref LintPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists every [ServiceAccount][google.iam.admin.v1.ServiceAccount] that belongs to a specific project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceAccount"/> resources.</returns>
        public override gax::PagedEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccounts(ListServiceAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServiceAccountsRequest, ListServiceAccountsResponse, ServiceAccount>(_callListServiceAccounts, request, callSettings);
        }

        /// <summary>
        /// Lists every [ServiceAccount][google.iam.admin.v1.ServiceAccount] that belongs to a specific project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceAccount"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccountsAsync(ListServiceAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServiceAccountsRequest, ListServiceAccountsResponse, ServiceAccount>(_callListServiceAccounts, request, callSettings);
        }

        /// <summary>
        /// Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceAccount GetServiceAccount(GetServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceAccountRequest(ref request, ref callSettings);
            return _callGetServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceAccount> GetServiceAccountAsync(GetServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceAccountRequest(ref request, ref callSettings);
            return _callGetServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceAccount CreateServiceAccount(CreateServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceAccountRequest(ref request, ref callSettings);
            return _callCreateServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceAccount> CreateServiceAccountAsync(CreateServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceAccountRequest(ref request, ref callSettings);
            return _callCreateServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// **Note:** We are in the process of deprecating this method. Use
        /// [PatchServiceAccount][google.iam.admin.v1.IAM.PatchServiceAccount] instead.
        /// 
        /// Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// You can update only the `display_name` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceAccount UpdateServiceAccount(ServiceAccount request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ServiceAccount(ref request, ref callSettings);
            return _callUpdateServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// **Note:** We are in the process of deprecating this method. Use
        /// [PatchServiceAccount][google.iam.admin.v1.IAM.PatchServiceAccount] instead.
        /// 
        /// Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// You can update only the `display_name` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceAccount> UpdateServiceAccountAsync(ServiceAccount request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ServiceAccount(ref request, ref callSettings);
            return _callUpdateServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Patches a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceAccount PatchServiceAccount(PatchServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchServiceAccountRequest(ref request, ref callSettings);
            return _callPatchServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Patches a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceAccount> PatchServiceAccountAsync(PatchServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchServiceAccountRequest(ref request, ref callSettings);
            return _callPatchServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Warning:** After you delete a service account, you might not be able to
        /// undelete it. If you know that you need to re-enable the service account in
        /// the future, use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] instead.
        /// 
        /// If you delete a service account, IAM permanently removes the service
        /// account 30 days later. Google Cloud cannot recover the service account
        /// after it is permanently removed, even if you file a support request.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] to disable the
        /// service account, then wait at least 24 hours and watch for unintended
        /// consequences. If there are no unintended consequences, you can delete the
        /// service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteServiceAccount(DeleteServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceAccountRequest(ref request, ref callSettings);
            _callDeleteServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Warning:** After you delete a service account, you might not be able to
        /// undelete it. If you know that you need to re-enable the service account in
        /// the future, use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] instead.
        /// 
        /// If you delete a service account, IAM permanently removes the service
        /// account 30 days later. Google Cloud cannot recover the service account
        /// after it is permanently removed, even if you file a support request.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] to disable the
        /// service account, then wait at least 24 hours and watch for unintended
        /// consequences. If there are no unintended consequences, you can delete the
        /// service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteServiceAccountAsync(DeleteServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceAccountRequest(ref request, ref callSettings);
            return _callDeleteServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Restores a deleted [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Important:** It is not always possible to restore a deleted service
        /// account. Use this method only as a last resort.
        /// 
        /// After you delete a service account, IAM permanently removes the service
        /// account 30 days later. There is no way to restore a deleted service account
        /// that has been permanently removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UndeleteServiceAccountResponse UndeleteServiceAccount(UndeleteServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteServiceAccountRequest(ref request, ref callSettings);
            return _callUndeleteServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Restores a deleted [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// **Important:** It is not always possible to restore a deleted service
        /// account. Use this method only as a last resort.
        /// 
        /// After you delete a service account, IAM permanently removes the service
        /// account 30 days later. There is no way to restore a deleted service account
        /// that has been permanently removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UndeleteServiceAccountResponse> UndeleteServiceAccountAsync(UndeleteServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteServiceAccountRequest(ref request, ref callSettings);
            return _callUndeleteServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Enables a [ServiceAccount][google.iam.admin.v1.ServiceAccount] that was disabled by
        /// [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount].
        /// 
        /// If the service account is already enabled, then this method has no effect.
        /// 
        /// If the service account was disabled by other means—for example, if Google
        /// disabled the service account because it was compromised—you cannot use this
        /// method to enable the service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void EnableServiceAccount(EnableServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableServiceAccountRequest(ref request, ref callSettings);
            _callEnableServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Enables a [ServiceAccount][google.iam.admin.v1.ServiceAccount] that was disabled by
        /// [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount].
        /// 
        /// If the service account is already enabled, then this method has no effect.
        /// 
        /// If the service account was disabled by other means—for example, if Google
        /// disabled the service account because it was compromised—you cannot use this
        /// method to enable the service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task EnableServiceAccountAsync(EnableServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableServiceAccountRequest(ref request, ref callSettings);
            return _callEnableServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Disables a [ServiceAccount][google.iam.admin.v1.ServiceAccount] immediately.
        /// 
        /// If an application uses the service account to authenticate, that
        /// application can no longer call Google APIs or access Google Cloud
        /// resources. Existing access tokens for the service account are rejected, and
        /// requests for new access tokens will fail.
        /// 
        /// To re-enable the service account, use [EnableServiceAccount][google.iam.admin.v1.IAM.EnableServiceAccount]. After you
        /// re-enable the service account, its existing access tokens will be accepted,
        /// and you can request new access tokens.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use this method to disable the service
        /// account, then wait at least 24 hours and watch for unintended consequences.
        /// If there are no unintended consequences, you can delete the service account
        /// with [DeleteServiceAccount][google.iam.admin.v1.IAM.DeleteServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DisableServiceAccount(DisableServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableServiceAccountRequest(ref request, ref callSettings);
            _callDisableServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Disables a [ServiceAccount][google.iam.admin.v1.ServiceAccount] immediately.
        /// 
        /// If an application uses the service account to authenticate, that
        /// application can no longer call Google APIs or access Google Cloud
        /// resources. Existing access tokens for the service account are rejected, and
        /// requests for new access tokens will fail.
        /// 
        /// To re-enable the service account, use [EnableServiceAccount][google.iam.admin.v1.IAM.EnableServiceAccount]. After you
        /// re-enable the service account, its existing access tokens will be accepted,
        /// and you can request new access tokens.
        /// 
        /// To help avoid unplanned outages, we recommend that you disable the service
        /// account before you delete it. Use this method to disable the service
        /// account, then wait at least 24 hours and watch for unintended consequences.
        /// If there are no unintended consequences, you can delete the service account
        /// with [DeleteServiceAccount][google.iam.admin.v1.IAM.DeleteServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DisableServiceAccountAsync(DisableServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableServiceAccountRequest(ref request, ref callSettings);
            return _callDisableServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Lists every [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListServiceAccountKeysResponse ListServiceAccountKeys(ListServiceAccountKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceAccountKeysRequest(ref request, ref callSettings);
            return _callListServiceAccountKeys.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists every [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListServiceAccountKeysResponse> ListServiceAccountKeysAsync(ListServiceAccountKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceAccountKeysRequest(ref request, ref callSettings);
            return _callListServiceAccountKeys.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceAccountKey GetServiceAccountKey(GetServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceAccountKeyRequest(ref request, ref callSettings);
            return _callGetServiceAccountKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceAccountKey> GetServiceAccountKeyAsync(GetServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceAccountKeyRequest(ref request, ref callSettings);
            return _callGetServiceAccountKey.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceAccountKey CreateServiceAccountKey(CreateServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceAccountKeyRequest(ref request, ref callSettings);
            return _callCreateServiceAccountKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceAccountKey> CreateServiceAccountKeyAsync(CreateServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceAccountKeyRequest(ref request, ref callSettings);
            return _callCreateServiceAccountKey.Async(request, callSettings);
        }

        /// <summary>
        /// Uploads the public key portion of a key pair that you manage, and
        /// associates the public key with a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// After you upload the public key, you can use the private key from the key
        /// pair as a service account key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceAccountKey UploadServiceAccountKey(UploadServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadServiceAccountKeyRequest(ref request, ref callSettings);
            return _callUploadServiceAccountKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Uploads the public key portion of a key pair that you manage, and
        /// associates the public key with a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// After you upload the public key, you can use the private key from the key
        /// pair as a service account key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceAccountKey> UploadServiceAccountKeyAsync(UploadServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadServiceAccountKeyRequest(ref request, ref callSettings);
            return _callUploadServiceAccountKey.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. Deleting a service account key does not
        /// revoke short-lived credentials that have been issued based on the service
        /// account key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteServiceAccountKey(DeleteServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceAccountKeyRequest(ref request, ref callSettings);
            _callDeleteServiceAccountKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. Deleting a service account key does not
        /// revoke short-lived credentials that have been issued based on the service
        /// account key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteServiceAccountKeyAsync(DeleteServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceAccountKeyRequest(ref request, ref callSettings);
            return _callDeleteServiceAccountKey.Async(request, callSettings);
        }

        /// <summary>
        /// Disable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. A disabled service account key can be
        /// re-enabled with [EnableServiceAccountKey][google.iam.admin.v1.IAM.EnableServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DisableServiceAccountKey(DisableServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableServiceAccountKeyRequest(ref request, ref callSettings);
            _callDisableServiceAccountKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Disable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. A disabled service account key can be
        /// re-enabled with [EnableServiceAccountKey][google.iam.admin.v1.IAM.EnableServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DisableServiceAccountKeyAsync(DisableServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableServiceAccountKeyRequest(ref request, ref callSettings);
            return _callDisableServiceAccountKey.Async(request, callSettings);
        }

        /// <summary>
        /// Enable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void EnableServiceAccountKey(EnableServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableServiceAccountKeyRequest(ref request, ref callSettings);
            _callEnableServiceAccountKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Enable a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task EnableServiceAccountKeyAsync(EnableServiceAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableServiceAccountKeyRequest(ref request, ref callSettings);
            return _callEnableServiceAccountKey.Async(request, callSettings);
        }

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a blob using the system-managed private key for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override SignBlobResponse SignBlob(SignBlobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SignBlobRequest(ref request, ref callSettings);
            return _callSignBlob.Sync(request, callSettings);
        }

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a blob using the system-managed private key for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override stt::Task<SignBlobResponse> SignBlobAsync(SignBlobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SignBlobRequest(ref request, ref callSettings);
            return _callSignBlob.Async(request, callSettings);
        }

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a JSON Web Token (JWT) using the system-managed private key for a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override SignJwtResponse SignJwt(SignJwtRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SignJwtRequest(ref request, ref callSettings);
            return _callSignJwt.Sync(request, callSettings);
        }

        /// <summary>
        /// **Note:** This method is deprecated. Use the
        /// [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
        /// method in the IAM Service Account Credentials API instead. If you currently
        /// use this method, see the [migration
        /// guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
        /// instructions.
        /// 
        /// Signs a JSON Web Token (JWT) using the system-managed private key for a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
        public override stt::Task<SignJwtResponse> SignJwtAsync(SignJwtRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SignJwtRequest(ref request, ref callSettings);
            return _callSignJwt.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount]. This IAM
        /// policy specifies which principals have access to the service account.
        /// 
        /// This method does not tell you whether the service account has been granted
        /// any roles on other resources. To check whether a service account has role
        /// grants on a resource, use the `getIamPolicy` method for that resource. For
        /// example, to view the role grants for a project, call the Resource Manager
        /// API's
        /// [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount]. This IAM
        /// policy specifies which principals have access to the service account.
        /// 
        /// This method does not tell you whether the service account has been granted
        /// any roles on other resources. To check whether a service account has role
        /// grants on a resource, use the `getIamPolicy` method for that resource. For
        /// example, to view the role grants for a project, call the Resource Manager
        /// API's
        /// [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// Use this method to grant or revoke access to the service account. For
        /// example, you could grant a principal the ability to impersonate the service
        /// account.
        /// 
        /// This method does not enable the service account to access other resources.
        /// To grant roles to a service account on a resource, follow these steps:
        /// 
        /// 1. Call the resource's `getIamPolicy` method to get its current IAM policy.
        /// 2. Edit the policy so that it binds the service account to an IAM role for
        /// the resource.
        /// 3. Call the resource's `setIamPolicy` method to update its IAM policy.
        /// 
        /// For detailed instructions, see
        /// [Manage access to project, folders, and
        /// organizations](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts)
        /// or [Manage access to other
        /// resources](https://cloud.google.com/iam/help/access/manage-other-resources).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// 
        /// Use this method to grant or revoke access to the service account. For
        /// example, you could grant a principal the ability to impersonate the service
        /// account.
        /// 
        /// This method does not enable the service account to access other resources.
        /// To grant roles to a service account on a resource, follow these steps:
        /// 
        /// 1. Call the resource's `getIamPolicy` method to get its current IAM policy.
        /// 2. Edit the policy so that it binds the service account to an IAM role for
        /// the resource.
        /// 3. Call the resource's `setIamPolicy` method to update its IAM policy.
        /// 
        /// For detailed instructions, see
        /// [Manage access to project, folders, and
        /// organizations](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts)
        /// or [Manage access to other
        /// resources](https://cloud.google.com/iam/help/access/manage-other-resources).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Tests whether the caller has the specified permissions on a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Tests whether the caller has the specified permissions on a
        /// [ServiceAccount][google.iam.admin.v1.ServiceAccount].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Lists roles that can be granted on a Google Cloud resource. A role is
        /// grantable if the IAM policy for the resource can contain bindings to the
        /// role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Role"/> resources.</returns>
        public override gax::PagedEnumerable<QueryGrantableRolesResponse, Role> QueryGrantableRoles(QueryGrantableRolesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryGrantableRolesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryGrantableRolesRequest, QueryGrantableRolesResponse, Role>(_callQueryGrantableRoles, request, callSettings);
        }

        /// <summary>
        /// Lists roles that can be granted on a Google Cloud resource. A role is
        /// grantable if the IAM policy for the resource can contain bindings to the
        /// role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Role"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<QueryGrantableRolesResponse, Role> QueryGrantableRolesAsync(QueryGrantableRolesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryGrantableRolesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryGrantableRolesRequest, QueryGrantableRolesResponse, Role>(_callQueryGrantableRoles, request, callSettings);
        }

        /// <summary>
        /// Lists every predefined [Role][google.iam.admin.v1.Role] that IAM supports, or every custom role
        /// that is defined for an organization or project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Role"/> resources.</returns>
        public override gax::PagedEnumerable<ListRolesResponse, Role> ListRoles(ListRolesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRolesRequest, ListRolesResponse, Role>(_callListRoles, request, callSettings);
        }

        /// <summary>
        /// Lists every predefined [Role][google.iam.admin.v1.Role] that IAM supports, or every custom role
        /// that is defined for an organization or project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Role"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRolesResponse, Role> ListRolesAsync(ListRolesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRolesRequest, ListRolesResponse, Role>(_callListRoles, request, callSettings);
        }

        /// <summary>
        /// Gets the definition of a [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Role GetRole(GetRoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRoleRequest(ref request, ref callSettings);
            return _callGetRole.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the definition of a [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Role> GetRoleAsync(GetRoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRoleRequest(ref request, ref callSettings);
            return _callGetRole.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Role CreateRole(CreateRoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRoleRequest(ref request, ref callSettings);
            return _callCreateRole.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Role> CreateRoleAsync(CreateRoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRoleRequest(ref request, ref callSettings);
            return _callCreateRole.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the definition of a custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Role UpdateRole(UpdateRoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRoleRequest(ref request, ref callSettings);
            return _callUpdateRole.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the definition of a custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Role> UpdateRoleAsync(UpdateRoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRoleRequest(ref request, ref callSettings);
            return _callUpdateRole.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a custom [Role][google.iam.admin.v1.Role].
        /// 
        /// When you delete a custom role, the following changes occur immediately:
        /// 
        /// * You cannot bind a principal to the custom role in an IAM
        /// [Policy][google.iam.v1.Policy].
        /// * Existing bindings to the custom role are not changed, but they have no
        /// effect.
        /// * By default, the response from [ListRoles][google.iam.admin.v1.IAM.ListRoles] does not include the custom
        /// role.
        /// 
        /// You have 7 days to undelete the custom role. After 7 days, the following
        /// changes occur:
        /// 
        /// * The custom role is permanently deleted and cannot be recovered.
        /// * If an IAM policy contains a binding to the custom role, the binding is
        /// permanently removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Role DeleteRole(DeleteRoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRoleRequest(ref request, ref callSettings);
            return _callDeleteRole.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a custom [Role][google.iam.admin.v1.Role].
        /// 
        /// When you delete a custom role, the following changes occur immediately:
        /// 
        /// * You cannot bind a principal to the custom role in an IAM
        /// [Policy][google.iam.v1.Policy].
        /// * Existing bindings to the custom role are not changed, but they have no
        /// effect.
        /// * By default, the response from [ListRoles][google.iam.admin.v1.IAM.ListRoles] does not include the custom
        /// role.
        /// 
        /// You have 7 days to undelete the custom role. After 7 days, the following
        /// changes occur:
        /// 
        /// * The custom role is permanently deleted and cannot be recovered.
        /// * If an IAM policy contains a binding to the custom role, the binding is
        /// permanently removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Role> DeleteRoleAsync(DeleteRoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRoleRequest(ref request, ref callSettings);
            return _callDeleteRole.Async(request, callSettings);
        }

        /// <summary>
        /// Undeletes a custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Role UndeleteRole(UndeleteRoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteRoleRequest(ref request, ref callSettings);
            return _callUndeleteRole.Sync(request, callSettings);
        }

        /// <summary>
        /// Undeletes a custom [Role][google.iam.admin.v1.Role].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Role> UndeleteRoleAsync(UndeleteRoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteRoleRequest(ref request, ref callSettings);
            return _callUndeleteRole.Async(request, callSettings);
        }

        /// <summary>
        /// Lists every permission that you can test on a resource. A permission is
        /// testable if you can check whether a principal has that permission on the
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Permission"/> resources.</returns>
        public override gax::PagedEnumerable<QueryTestablePermissionsResponse, Permission> QueryTestablePermissions(QueryTestablePermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryTestablePermissionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryTestablePermissionsRequest, QueryTestablePermissionsResponse, Permission>(_callQueryTestablePermissions, request, callSettings);
        }

        /// <summary>
        /// Lists every permission that you can test on a resource. A permission is
        /// testable if you can check whether a principal has that permission on the
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Permission"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<QueryTestablePermissionsResponse, Permission> QueryTestablePermissionsAsync(QueryTestablePermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryTestablePermissionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryTestablePermissionsRequest, QueryTestablePermissionsResponse, Permission>(_callQueryTestablePermissions, request, callSettings);
        }

        /// <summary>
        /// Returns a list of services that allow you to opt into audit logs that are
        /// not generated by default.
        /// 
        /// To learn more about audit logs, see the [Logging
        /// documentation](https://cloud.google.com/logging/docs/audit).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QueryAuditableServicesResponse QueryAuditableServices(QueryAuditableServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryAuditableServicesRequest(ref request, ref callSettings);
            return _callQueryAuditableServices.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of services that allow you to opt into audit logs that are
        /// not generated by default.
        /// 
        /// To learn more about audit logs, see the [Logging
        /// documentation](https://cloud.google.com/logging/docs/audit).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QueryAuditableServicesResponse> QueryAuditableServicesAsync(QueryAuditableServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryAuditableServicesRequest(ref request, ref callSettings);
            return _callQueryAuditableServices.Async(request, callSettings);
        }

        /// <summary>
        /// Lints, or validates, an IAM policy. Currently checks the
        /// [google.iam.v1.Binding.condition][google.iam.v1.Binding.condition] field, which contains a condition
        /// expression for a role binding.
        /// 
        /// Successful calls to this method always return an HTTP `200 OK` status code,
        /// even if the linter detects an issue in the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LintPolicyResponse LintPolicy(LintPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LintPolicyRequest(ref request, ref callSettings);
            return _callLintPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Lints, or validates, an IAM policy. Currently checks the
        /// [google.iam.v1.Binding.condition][google.iam.v1.Binding.condition] field, which contains a condition
        /// expression for a role binding.
        /// 
        /// Successful calls to this method always return an HTTP `200 OK` status code,
        /// even if the linter detects an issue in the IAM policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LintPolicyResponse> LintPolicyAsync(LintPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LintPolicyRequest(ref request, ref callSettings);
            return _callLintPolicy.Async(request, callSettings);
        }
    }

    public partial class ListServiceAccountsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryGrantableRolesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRolesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryTestablePermissionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServiceAccountsResponse : gaxgrpc::IPageResponse<ServiceAccount>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ServiceAccount> GetEnumerator() => Accounts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class QueryGrantableRolesResponse : gaxgrpc::IPageResponse<Role>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Role> GetEnumerator() => Roles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRolesResponse : gaxgrpc::IPageResponse<Role>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Role> GetEnumerator() => Roles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class QueryTestablePermissionsResponse : gaxgrpc::IPageResponse<Permission>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Permission> GetEnumerator() => Permissions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
