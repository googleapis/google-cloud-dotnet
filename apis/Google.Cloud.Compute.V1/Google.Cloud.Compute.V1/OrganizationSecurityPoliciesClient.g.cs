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

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="OrganizationSecurityPoliciesClient"/> instances.</summary>
    public sealed partial class OrganizationSecurityPoliciesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OrganizationSecurityPoliciesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OrganizationSecurityPoliciesSettings"/>.</returns>
        public static OrganizationSecurityPoliciesSettings GetDefault() => new OrganizationSecurityPoliciesSettings();

        /// <summary>
        /// Constructs a new <see cref="OrganizationSecurityPoliciesSettings"/> object with default settings.
        /// </summary>
        public OrganizationSecurityPoliciesSettings()
        {
        }

        private OrganizationSecurityPoliciesSettings(OrganizationSecurityPoliciesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AddAssociationSettings = existing.AddAssociationSettings;
            AddAssociationOperationsSettings = existing.AddAssociationOperationsSettings.Clone();
            AddRuleSettings = existing.AddRuleSettings;
            AddRuleOperationsSettings = existing.AddRuleOperationsSettings.Clone();
            CopyRulesSettings = existing.CopyRulesSettings;
            CopyRulesOperationsSettings = existing.CopyRulesOperationsSettings.Clone();
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            GetAssociationSettings = existing.GetAssociationSettings;
            GetRuleSettings = existing.GetRuleSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            ListAssociationsSettings = existing.ListAssociationsSettings;
            ListPreconfiguredExpressionSetsSettings = existing.ListPreconfiguredExpressionSetsSettings;
            MoveSettings = existing.MoveSettings;
            MoveOperationsSettings = existing.MoveOperationsSettings.Clone();
            PatchSettings = existing.PatchSettings;
            PatchOperationsSettings = existing.PatchOperationsSettings.Clone();
            PatchRuleSettings = existing.PatchRuleSettings;
            PatchRuleOperationsSettings = existing.PatchRuleOperationsSettings.Clone();
            RemoveAssociationSettings = existing.RemoveAssociationSettings;
            RemoveAssociationOperationsSettings = existing.RemoveAssociationOperationsSettings.Clone();
            RemoveRuleSettings = existing.RemoveRuleSettings;
            RemoveRuleOperationsSettings = existing.RemoveRuleOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(OrganizationSecurityPoliciesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.AddAssociation</c> and
        /// <c>OrganizationSecurityPoliciesClient.AddAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OrganizationSecurityPoliciesClient.AddAssociation</c> and
        /// <c>OrganizationSecurityPoliciesClient.AddAssociationAsync</c>.
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
        public lro::OperationsSettings AddAssociationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.AddRule</c> and <c>OrganizationSecurityPoliciesClient.AddRuleAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OrganizationSecurityPoliciesClient.AddRule</c> and
        /// <c>OrganizationSecurityPoliciesClient.AddRuleAsync</c>.
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
        public lro::OperationsSettings AddRuleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.CopyRules</c> and <c>OrganizationSecurityPoliciesClient.CopyRulesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CopyRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OrganizationSecurityPoliciesClient.CopyRules</c> and
        /// <c>OrganizationSecurityPoliciesClient.CopyRulesAsync</c>.
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
        public lro::OperationsSettings CopyRulesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.Delete</c> and <c>OrganizationSecurityPoliciesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OrganizationSecurityPoliciesClient.Delete</c> and
        /// <c>OrganizationSecurityPoliciesClient.DeleteAsync</c>.
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
        public lro::OperationsSettings DeleteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.Get</c> and <c>OrganizationSecurityPoliciesClient.GetAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.GetAssociation</c> and
        /// <c>OrganizationSecurityPoliciesClient.GetAssociationAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAssociationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.GetRule</c> and <c>OrganizationSecurityPoliciesClient.GetRuleAsync</c>
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.Insert</c> and <c>OrganizationSecurityPoliciesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OrganizationSecurityPoliciesClient.Insert</c> and
        /// <c>OrganizationSecurityPoliciesClient.InsertAsync</c>.
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
        public lro::OperationsSettings InsertOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.List</c> and <c>OrganizationSecurityPoliciesClient.ListAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.ListAssociations</c> and
        /// <c>OrganizationSecurityPoliciesClient.ListAssociationsAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAssociationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.ListPreconfiguredExpressionSets</c> and
        /// <c>OrganizationSecurityPoliciesClient.ListPreconfiguredExpressionSetsAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPreconfiguredExpressionSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.Move</c> and <c>OrganizationSecurityPoliciesClient.MoveAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OrganizationSecurityPoliciesClient.Move</c> and
        /// <c>OrganizationSecurityPoliciesClient.MoveAsync</c>.
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
        public lro::OperationsSettings MoveOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.Patch</c> and <c>OrganizationSecurityPoliciesClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OrganizationSecurityPoliciesClient.Patch</c> and
        /// <c>OrganizationSecurityPoliciesClient.PatchAsync</c>.
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
        public lro::OperationsSettings PatchOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.PatchRule</c> and <c>OrganizationSecurityPoliciesClient.PatchRuleAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OrganizationSecurityPoliciesClient.PatchRule</c> and
        /// <c>OrganizationSecurityPoliciesClient.PatchRuleAsync</c>.
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
        public lro::OperationsSettings PatchRuleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.RemoveAssociation</c> and
        /// <c>OrganizationSecurityPoliciesClient.RemoveAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OrganizationSecurityPoliciesClient.RemoveAssociation</c> and
        /// <c>OrganizationSecurityPoliciesClient.RemoveAssociationAsync</c>.
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
        public lro::OperationsSettings RemoveAssociationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityPoliciesClient.RemoveRule</c> and
        /// <c>OrganizationSecurityPoliciesClient.RemoveRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OrganizationSecurityPoliciesClient.RemoveRule</c> and
        /// <c>OrganizationSecurityPoliciesClient.RemoveRuleAsync</c>.
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
        public lro::OperationsSettings RemoveRuleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OrganizationSecurityPoliciesSettings"/> object.</returns>
        public OrganizationSecurityPoliciesSettings Clone() => new OrganizationSecurityPoliciesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OrganizationSecurityPoliciesClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class OrganizationSecurityPoliciesClientBuilder : gaxgrpc::ClientBuilderBase<OrganizationSecurityPoliciesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OrganizationSecurityPoliciesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OrganizationSecurityPoliciesClientBuilder() : base(OrganizationSecurityPoliciesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OrganizationSecurityPoliciesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OrganizationSecurityPoliciesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OrganizationSecurityPoliciesClient Build()
        {
            OrganizationSecurityPoliciesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OrganizationSecurityPoliciesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OrganizationSecurityPoliciesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OrganizationSecurityPoliciesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OrganizationSecurityPoliciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OrganizationSecurityPoliciesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OrganizationSecurityPoliciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OrganizationSecurityPoliciesClient.ChannelPool;
    }

    /// <summary>OrganizationSecurityPolicies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The OrganizationSecurityPolicies API.
    /// </remarks>
    public abstract partial class OrganizationSecurityPoliciesClient
    {
        /// <summary>
        /// The default endpoint for the OrganizationSecurityPolicies service, which is a host of
        /// "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default OrganizationSecurityPolicies scopes.</summary>
        /// <remarks>
        /// The default OrganizationSecurityPolicies scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OrganizationSecurityPolicies.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OrganizationSecurityPoliciesClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OrganizationSecurityPoliciesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OrganizationSecurityPoliciesClient"/>.</returns>
        public static stt::Task<OrganizationSecurityPoliciesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OrganizationSecurityPoliciesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OrganizationSecurityPoliciesClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OrganizationSecurityPoliciesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OrganizationSecurityPoliciesClient"/>.</returns>
        public static OrganizationSecurityPoliciesClient Create() => new OrganizationSecurityPoliciesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OrganizationSecurityPoliciesClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OrganizationSecurityPoliciesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OrganizationSecurityPoliciesClient"/>.</returns>
        internal static OrganizationSecurityPoliciesClient Create(grpccore::CallInvoker callInvoker, OrganizationSecurityPoliciesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OrganizationSecurityPolicies.OrganizationSecurityPoliciesClient grpcClient = new OrganizationSecurityPolicies.OrganizationSecurityPoliciesClient(callInvoker);
            return new OrganizationSecurityPoliciesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC OrganizationSecurityPolicies client</summary>
        public virtual OrganizationSecurityPolicies.OrganizationSecurityPoliciesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts an association for the specified security policy. This has billing implications. Projects in the hierarchy with effective hierarchical security policies will be automatically enrolled into Cloud Armor Enterprise if not already enrolled. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.addAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddAssociation(AddAssociationOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts an association for the specified security policy. This has billing implications. Projects in the hierarchy with effective hierarchical security policies will be automatically enrolled into Cloud Armor Enterprise if not already enrolled. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.addAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddAssociationAsync(AddAssociationOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts an association for the specified security policy. This has billing implications. Projects in the hierarchy with effective hierarchical security policies will be automatically enrolled into Cloud Armor Enterprise if not already enrolled. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.addAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddAssociationAsync(AddAssociationOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            AddAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddAssociation</c>.</summary>
        public virtual lro::OperationsClient AddAssociationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceAddAssociation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddAssociationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceAddAssociationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddAssociationOperationsClient, callSettings);

        /// <summary>
        /// Inserts an association for the specified security policy. This has billing implications. Projects in the hierarchy with effective hierarchical security policies will be automatically enrolled into Cloud Armor Enterprise if not already enrolled. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.addAssociation instead if possible.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="securityPolicyAssociationResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddAssociation(string securityPolicy, SecurityPolicyAssociation securityPolicyAssociationResource, gaxgrpc::CallSettings callSettings = null) =>
            AddAssociation(new AddAssociationOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
                SecurityPolicyAssociationResource = gax::GaxPreconditions.CheckNotNull(securityPolicyAssociationResource, nameof(securityPolicyAssociationResource)),
            }, callSettings);

        /// <summary>
        /// Inserts an association for the specified security policy. This has billing implications. Projects in the hierarchy with effective hierarchical security policies will be automatically enrolled into Cloud Armor Enterprise if not already enrolled. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.addAssociation instead if possible.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="securityPolicyAssociationResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddAssociationAsync(string securityPolicy, SecurityPolicyAssociation securityPolicyAssociationResource, gaxgrpc::CallSettings callSettings = null) =>
            AddAssociationAsync(new AddAssociationOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
                SecurityPolicyAssociationResource = gax::GaxPreconditions.CheckNotNull(securityPolicyAssociationResource, nameof(securityPolicyAssociationResource)),
            }, callSettings);

        /// <summary>
        /// Inserts an association for the specified security policy. This has billing implications. Projects in the hierarchy with effective hierarchical security policies will be automatically enrolled into Cloud Armor Enterprise if not already enrolled. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.addAssociation instead if possible.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="securityPolicyAssociationResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddAssociationAsync(string securityPolicy, SecurityPolicyAssociation securityPolicyAssociationResource, st::CancellationToken cancellationToken) =>
            AddAssociationAsync(securityPolicy, securityPolicyAssociationResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inserts a rule into a security policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddRule(AddRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a rule into a security policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddRuleAsync(AddRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a rule into a security policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddRuleAsync(AddRuleOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            AddRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddRule</c>.</summary>
        public virtual lro::OperationsClient AddRuleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceAddRule(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddRuleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceAddRuleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddRuleOperationsClient, callSettings);

        /// <summary>
        /// Inserts a rule into a security policy.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="securityPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddRule(string securityPolicy, SecurityPolicyRule securityPolicyRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            AddRule(new AddRuleOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
                SecurityPolicyRuleResource = gax::GaxPreconditions.CheckNotNull(securityPolicyRuleResource, nameof(securityPolicyRuleResource)),
            }, callSettings);

        /// <summary>
        /// Inserts a rule into a security policy.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="securityPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddRuleAsync(string securityPolicy, SecurityPolicyRule securityPolicyRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            AddRuleAsync(new AddRuleOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
                SecurityPolicyRuleResource = gax::GaxPreconditions.CheckNotNull(securityPolicyRuleResource, nameof(securityPolicyRuleResource)),
            }, callSettings);

        /// <summary>
        /// Inserts a rule into a security policy.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="securityPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddRuleAsync(string securityPolicy, SecurityPolicyRule securityPolicyRuleResource, st::CancellationToken cancellationToken) =>
            AddRuleAsync(securityPolicy, securityPolicyRuleResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Copies rules to the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.copyRules instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> CopyRules(CopyRulesOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Copies rules to the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.copyRules instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CopyRulesAsync(CopyRulesOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Copies rules to the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.copyRules instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CopyRulesAsync(CopyRulesOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            CopyRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CopyRules</c>.</summary>
        public virtual lro::OperationsClient CopyRulesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CopyRules</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceCopyRules(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CopyRulesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CopyRules</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceCopyRulesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CopyRulesOperationsClient, callSettings);

        /// <summary>
        /// Copies rules to the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.copyRules instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> CopyRules(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CopyRules(new CopyRulesOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Copies rules to the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.copyRules instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CopyRulesAsync(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CopyRulesAsync(new CopyRulesOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Copies rules to the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.copyRules instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CopyRulesAsync(string securityPolicy, st::CancellationToken cancellationToken) =>
            CopyRulesAsync(securityPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified policy. Use of this API to remove firewall policies is deprecated. Use firewallPolicies.delete instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified policy. Use of this API to remove firewall policies is deprecated. Use firewallPolicies.delete instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified policy. Use of this API to remove firewall policies is deprecated. Use firewallPolicies.delete instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public virtual lro::OperationsClient DeleteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDelete(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDeleteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified policy. Use of this API to remove firewall policies is deprecated. Use firewallPolicies.delete instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified policy. Use of this API to remove firewall policies is deprecated. Use firewallPolicies.delete instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified policy. Use of this API to remove firewall policies is deprecated. Use firewallPolicies.delete instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string securityPolicy, st::CancellationToken cancellationToken) =>
            DeleteAsync(securityPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all of the ordered rules present in a single specified policy. Use of this API to read firewall policies is deprecated. Use firewallPolicies.get instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityPolicy Get(GetOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all of the ordered rules present in a single specified policy. Use of this API to read firewall policies is deprecated. Use firewallPolicies.get instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPolicy> GetAsync(GetOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all of the ordered rules present in a single specified policy. Use of this API to read firewall policies is deprecated. Use firewallPolicies.get instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPolicy> GetAsync(GetOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all of the ordered rules present in a single specified policy. Use of this API to read firewall policies is deprecated. Use firewallPolicies.get instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityPolicy Get(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// List all of the ordered rules present in a single specified policy. Use of this API to read firewall policies is deprecated. Use firewallPolicies.get instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPolicy> GetAsync(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// List all of the ordered rules present in a single specified policy. Use of this API to read firewall policies is deprecated. Use firewallPolicies.get instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPolicy> GetAsync(string securityPolicy, st::CancellationToken cancellationToken) =>
            GetAsync(securityPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an association with the specified name. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityPolicyAssociation GetAssociation(GetAssociationOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an association with the specified name. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPolicyAssociation> GetAssociationAsync(GetAssociationOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an association with the specified name. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPolicyAssociation> GetAssociationAsync(GetAssociationOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an association with the specified name. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getAssociation instead if possible.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to which the queried rule belongs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityPolicyAssociation GetAssociation(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetAssociation(new GetAssociationOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Gets an association with the specified name. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getAssociation instead if possible.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to which the queried rule belongs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPolicyAssociation> GetAssociationAsync(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetAssociationAsync(new GetAssociationOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Gets an association with the specified name. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getAssociation instead if possible.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to which the queried rule belongs.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPolicyAssociation> GetAssociationAsync(string securityPolicy, st::CancellationToken cancellationToken) =>
            GetAssociationAsync(securityPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a rule at the specified priority. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getRule instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityPolicyRule GetRule(GetRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a rule at the specified priority. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getRule instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPolicyRule> GetRuleAsync(GetRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a rule at the specified priority. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getRule instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPolicyRule> GetRuleAsync(GetRuleOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a rule at the specified priority. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getRule instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to which the queried rule belongs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityPolicyRule GetRule(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetRule(new GetRuleOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Gets a rule at the specified priority. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getRule instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to which the queried rule belongs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPolicyRule> GetRuleAsync(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetRuleAsync(new GetRuleOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Gets a rule at the specified priority. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getRule instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to which the queried rule belongs.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPolicyRule> GetRuleAsync(string securityPolicy, st::CancellationToken cancellationToken) =>
            GetRuleAsync(securityPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request. Use of this API to insert firewall policies is deprecated. Use firewallPolicies.insert instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request. Use of this API to insert firewall policies is deprecated. Use firewallPolicies.insert instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request. Use of this API to insert firewall policies is deprecated. Use firewallPolicies.insert instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public virtual lro::OperationsClient InsertOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceInsert(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceInsertAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request. Use of this API to insert firewall policies is deprecated. Use firewallPolicies.insert instead.
        /// </summary>
        /// <param name="securityPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(SecurityPolicy securityPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertOrganizationSecurityPolicyRequest
            {
                SecurityPolicyResource = gax::GaxPreconditions.CheckNotNull(securityPolicyResource, nameof(securityPolicyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request. Use of this API to insert firewall policies is deprecated. Use firewallPolicies.insert instead.
        /// </summary>
        /// <param name="securityPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(SecurityPolicy securityPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertOrganizationSecurityPolicyRequest
            {
                SecurityPolicyResource = gax::GaxPreconditions.CheckNotNull(securityPolicyResource, nameof(securityPolicyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request. Use of this API to insert firewall policies is deprecated. Use firewallPolicies.insert instead.
        /// </summary>
        /// <param name="securityPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(SecurityPolicy securityPolicyResource, st::CancellationToken cancellationToken) =>
            InsertAsync(securityPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all the policies that have been configured for the specified project. Use of this API to read firewall policies is deprecated. Use firewallPolicies.list instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecurityPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<SecurityPolicyList, SecurityPolicy> List(ListOrganizationSecurityPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the policies that have been configured for the specified project. Use of this API to read firewall policies is deprecated. Use firewallPolicies.list instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SecurityPolicyList, SecurityPolicy> ListAsync(ListOrganizationSecurityPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the policies that have been configured for the specified project. Use of this API to read firewall policies is deprecated. Use firewallPolicies.list instead.
        /// </summary>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecurityPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<SecurityPolicyList, SecurityPolicy> List(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrganizationSecurityPoliciesRequest request = new ListOrganizationSecurityPoliciesRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return List(request, callSettings);
        }

        /// <summary>
        /// List all the policies that have been configured for the specified project. Use of this API to read firewall policies is deprecated. Use firewallPolicies.list instead.
        /// </summary>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SecurityPolicyList, SecurityPolicy> ListAsync(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrganizationSecurityPoliciesRequest request = new ListOrganizationSecurityPoliciesRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAsync(request, callSettings);
        }

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder. Use of this API to read firewall policies is deprecated. Use firewallPolicies.listAssociations instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrganizationSecurityPoliciesListAssociationsResponse ListAssociations(ListAssociationsOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder. Use of this API to read firewall policies is deprecated. Use firewallPolicies.listAssociations instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationSecurityPoliciesListAssociationsResponse> ListAssociationsAsync(ListAssociationsOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder. Use of this API to read firewall policies is deprecated. Use firewallPolicies.listAssociations instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationSecurityPoliciesListAssociationsResponse> ListAssociationsAsync(ListAssociationsOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            ListAssociationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder. Use of this API to read firewall policies is deprecated. Use firewallPolicies.listAssociations instead if possible.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrganizationSecurityPoliciesListAssociationsResponse ListAssociations(gaxgrpc::CallSettings callSettings = null) =>
            ListAssociations(new ListAssociationsOrganizationSecurityPolicyRequest { }, callSettings);

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder. Use of this API to read firewall policies is deprecated. Use firewallPolicies.listAssociations instead if possible.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationSecurityPoliciesListAssociationsResponse> ListAssociationsAsync(gaxgrpc::CallSettings callSettings = null) =>
            ListAssociationsAsync(new ListAssociationsOrganizationSecurityPolicyRequest { }, callSettings);

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder. Use of this API to read firewall policies is deprecated. Use firewallPolicies.listAssociations instead if possible.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationSecurityPoliciesListAssociationsResponse> ListAssociationsAsync(st::CancellationToken cancellationToken) =>
            ListAssociationsAsync(gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the current list of preconfigured Web Application Firewall (WAF) expressions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityPoliciesListPreconfiguredExpressionSetsResponse ListPreconfiguredExpressionSets(ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the current list of preconfigured Web Application Firewall (WAF) expressions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPoliciesListPreconfiguredExpressionSetsResponse> ListPreconfiguredExpressionSetsAsync(ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the current list of preconfigured Web Application Firewall (WAF) expressions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPoliciesListPreconfiguredExpressionSetsResponse> ListPreconfiguredExpressionSetsAsync(ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest request, st::CancellationToken cancellationToken) =>
            ListPreconfiguredExpressionSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the current list of preconfigured Web Application Firewall (WAF) expressions.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityPoliciesListPreconfiguredExpressionSetsResponse ListPreconfiguredExpressionSets(gaxgrpc::CallSettings callSettings = null) =>
            ListPreconfiguredExpressionSets(new ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest { }, callSettings);

        /// <summary>
        /// Gets the current list of preconfigured Web Application Firewall (WAF) expressions.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPoliciesListPreconfiguredExpressionSetsResponse> ListPreconfiguredExpressionSetsAsync(gaxgrpc::CallSettings callSettings = null) =>
            ListPreconfiguredExpressionSetsAsync(new ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest { }, callSettings);

        /// <summary>
        /// Gets the current list of preconfigured Web Application Firewall (WAF) expressions.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityPoliciesListPreconfiguredExpressionSetsResponse> ListPreconfiguredExpressionSetsAsync(st::CancellationToken cancellationToken) =>
            ListPreconfiguredExpressionSetsAsync(gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.move instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Move(MoveOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.move instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> MoveAsync(MoveOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.move instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> MoveAsync(MoveOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            MoveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Move</c>.</summary>
        public virtual lro::OperationsClient MoveOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Move</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceMove(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Move</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceMoveAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveOperationsClient, callSettings);

        /// <summary>
        /// Moves the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.move instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Move(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            Move(new MoveOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Moves the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.move instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> MoveAsync(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            MoveAsync(new MoveOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Moves the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.move instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> MoveAsync(string securityPolicy, st::CancellationToken cancellationToken) =>
            MoveAsync(securityPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified policy with the data included in the request. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patch instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(PatchOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified policy with the data included in the request. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patch instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified policy with the data included in the request. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patch instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public virtual lro::OperationsClient PatchOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Patch</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOncePatch(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Patch</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOncePatchAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchOperationsClient, callSettings);

        /// <summary>
        /// Patches the specified policy with the data included in the request. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patch instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="securityPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(string securityPolicy, SecurityPolicy securityPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
                SecurityPolicyResource = gax::GaxPreconditions.CheckNotNull(securityPolicyResource, nameof(securityPolicyResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified policy with the data included in the request. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patch instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="securityPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string securityPolicy, SecurityPolicy securityPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
                SecurityPolicyResource = gax::GaxPreconditions.CheckNotNull(securityPolicyResource, nameof(securityPolicyResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified policy with the data included in the request. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patch instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="securityPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string securityPolicy, SecurityPolicy securityPolicyResource, st::CancellationToken cancellationToken) =>
            PatchAsync(securityPolicy, securityPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches a rule at the specified priority. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patchRule instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> PatchRule(PatchRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a rule at the specified priority. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patchRule instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchRuleAsync(PatchRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a rule at the specified priority. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patchRule instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchRuleAsync(PatchRuleOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            PatchRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PatchRule</c>.</summary>
        public virtual lro::OperationsClient PatchRuleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PatchRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOncePatchRule(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchRuleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PatchRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOncePatchRuleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchRuleOperationsClient, callSettings);

        /// <summary>
        /// Patches a rule at the specified priority. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patchRule instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="securityPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> PatchRule(string securityPolicy, SecurityPolicyRule securityPolicyRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchRule(new PatchRuleOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
                SecurityPolicyRuleResource = gax::GaxPreconditions.CheckNotNull(securityPolicyRuleResource, nameof(securityPolicyRuleResource)),
            }, callSettings);

        /// <summary>
        /// Patches a rule at the specified priority. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patchRule instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="securityPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchRuleAsync(string securityPolicy, SecurityPolicyRule securityPolicyRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchRuleAsync(new PatchRuleOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
                SecurityPolicyRuleResource = gax::GaxPreconditions.CheckNotNull(securityPolicyRuleResource, nameof(securityPolicyRuleResource)),
            }, callSettings);

        /// <summary>
        /// Patches a rule at the specified priority. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patchRule instead.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="securityPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchRuleAsync(string securityPolicy, SecurityPolicyRule securityPolicyRuleResource, st::CancellationToken cancellationToken) =>
            PatchRuleAsync(securityPolicy, securityPolicyRuleResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes an association for the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.removeAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveAssociation(RemoveAssociationOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes an association for the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.removeAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveAssociationAsync(RemoveAssociationOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes an association for the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.removeAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveAssociationAsync(RemoveAssociationOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            RemoveAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveAssociation</c>.</summary>
        public virtual lro::OperationsClient RemoveAssociationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RemoveAssociation</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceRemoveAssociation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveAssociationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceRemoveAssociationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveAssociationOperationsClient, callSettings);

        /// <summary>
        /// Removes an association for the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.removeAssociation instead if possible.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveAssociation(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAssociation(new RemoveAssociationOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Removes an association for the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.removeAssociation instead if possible.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveAssociationAsync(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAssociationAsync(new RemoveAssociationOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Removes an association for the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.removeAssociation instead if possible.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveAssociationAsync(string securityPolicy, st::CancellationToken cancellationToken) =>
            RemoveAssociationAsync(securityPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a rule at the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveRule(RemoveRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a rule at the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveRuleAsync(RemoveRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a rule at the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveRuleAsync(RemoveRuleOrganizationSecurityPolicyRequest request, st::CancellationToken cancellationToken) =>
            RemoveRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveRule</c>.</summary>
        public virtual lro::OperationsClient RemoveRuleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RemoveRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceRemoveRule(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveRuleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveRule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceRemoveRuleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveRuleOperationsClient, callSettings);

        /// <summary>
        /// Deletes a rule at the specified priority.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveRule(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            RemoveRule(new RemoveRuleOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Deletes a rule at the specified priority.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveRuleAsync(string securityPolicy, gaxgrpc::CallSettings callSettings = null) =>
            RemoveRuleAsync(new RemoveRuleOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(securityPolicy, nameof(securityPolicy)),
            }, callSettings);

        /// <summary>
        /// Deletes a rule at the specified priority.
        /// </summary>
        /// <param name="securityPolicy">
        /// Name of the security policy to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveRuleAsync(string securityPolicy, st::CancellationToken cancellationToken) =>
            RemoveRuleAsync(securityPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>OrganizationSecurityPolicies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The OrganizationSecurityPolicies API.
    /// </remarks>
    public sealed partial class OrganizationSecurityPoliciesClientImpl : OrganizationSecurityPoliciesClient
    {
        private readonly gaxgrpc::ApiCall<AddAssociationOrganizationSecurityPolicyRequest, Operation> _callAddAssociation;

        private readonly gaxgrpc::ApiCall<AddRuleOrganizationSecurityPolicyRequest, Operation> _callAddRule;

        private readonly gaxgrpc::ApiCall<CopyRulesOrganizationSecurityPolicyRequest, Operation> _callCopyRules;

        private readonly gaxgrpc::ApiCall<DeleteOrganizationSecurityPolicyRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetOrganizationSecurityPolicyRequest, SecurityPolicy> _callGet;

        private readonly gaxgrpc::ApiCall<GetAssociationOrganizationSecurityPolicyRequest, SecurityPolicyAssociation> _callGetAssociation;

        private readonly gaxgrpc::ApiCall<GetRuleOrganizationSecurityPolicyRequest, SecurityPolicyRule> _callGetRule;

        private readonly gaxgrpc::ApiCall<InsertOrganizationSecurityPolicyRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListOrganizationSecurityPoliciesRequest, SecurityPolicyList> _callList;

        private readonly gaxgrpc::ApiCall<ListAssociationsOrganizationSecurityPolicyRequest, OrganizationSecurityPoliciesListAssociationsResponse> _callListAssociations;

        private readonly gaxgrpc::ApiCall<ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest, SecurityPoliciesListPreconfiguredExpressionSetsResponse> _callListPreconfiguredExpressionSets;

        private readonly gaxgrpc::ApiCall<MoveOrganizationSecurityPolicyRequest, Operation> _callMove;

        private readonly gaxgrpc::ApiCall<PatchOrganizationSecurityPolicyRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<PatchRuleOrganizationSecurityPolicyRequest, Operation> _callPatchRule;

        private readonly gaxgrpc::ApiCall<RemoveAssociationOrganizationSecurityPolicyRequest, Operation> _callRemoveAssociation;

        private readonly gaxgrpc::ApiCall<RemoveRuleOrganizationSecurityPolicyRequest, Operation> _callRemoveRule;

        /// <summary>
        /// Constructs a client wrapper for the OrganizationSecurityPolicies service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="OrganizationSecurityPoliciesSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OrganizationSecurityPoliciesClientImpl(OrganizationSecurityPolicies.OrganizationSecurityPoliciesClient grpcClient, OrganizationSecurityPoliciesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OrganizationSecurityPoliciesSettings effectiveSettings = settings ?? OrganizationSecurityPoliciesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            AddAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOrganizationOperations(), effectiveSettings.AddAssociationOperationsSettings, logger);
            AddRuleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOrganizationOperations(), effectiveSettings.AddRuleOperationsSettings, logger);
            CopyRulesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOrganizationOperations(), effectiveSettings.CopyRulesOperationsSettings, logger);
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOrganizationOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOrganizationOperations(), effectiveSettings.InsertOperationsSettings, logger);
            MoveOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOrganizationOperations(), effectiveSettings.MoveOperationsSettings, logger);
            PatchOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOrganizationOperations(), effectiveSettings.PatchOperationsSettings, logger);
            PatchRuleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOrganizationOperations(), effectiveSettings.PatchRuleOperationsSettings, logger);
            RemoveAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOrganizationOperations(), effectiveSettings.RemoveAssociationOperationsSettings, logger);
            RemoveRuleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOrganizationOperations(), effectiveSettings.RemoveRuleOperationsSettings, logger);
            _callAddAssociation = clientHelper.BuildApiCall<AddAssociationOrganizationSecurityPolicyRequest, Operation>("AddAssociation", grpcClient.AddAssociationAsync, grpcClient.AddAssociation, effectiveSettings.AddAssociationSettings).WithGoogleRequestParam("security_policy", request => request.SecurityPolicy);
            Modify_ApiCall(ref _callAddAssociation);
            Modify_AddAssociationApiCall(ref _callAddAssociation);
            _callAddRule = clientHelper.BuildApiCall<AddRuleOrganizationSecurityPolicyRequest, Operation>("AddRule", grpcClient.AddRuleAsync, grpcClient.AddRule, effectiveSettings.AddRuleSettings).WithGoogleRequestParam("security_policy", request => request.SecurityPolicy);
            Modify_ApiCall(ref _callAddRule);
            Modify_AddRuleApiCall(ref _callAddRule);
            _callCopyRules = clientHelper.BuildApiCall<CopyRulesOrganizationSecurityPolicyRequest, Operation>("CopyRules", grpcClient.CopyRulesAsync, grpcClient.CopyRules, effectiveSettings.CopyRulesSettings).WithGoogleRequestParam("security_policy", request => request.SecurityPolicy);
            Modify_ApiCall(ref _callCopyRules);
            Modify_CopyRulesApiCall(ref _callCopyRules);
            _callDelete = clientHelper.BuildApiCall<DeleteOrganizationSecurityPolicyRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("security_policy", request => request.SecurityPolicy);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetOrganizationSecurityPolicyRequest, SecurityPolicy>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("security_policy", request => request.SecurityPolicy);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callGetAssociation = clientHelper.BuildApiCall<GetAssociationOrganizationSecurityPolicyRequest, SecurityPolicyAssociation>("GetAssociation", grpcClient.GetAssociationAsync, grpcClient.GetAssociation, effectiveSettings.GetAssociationSettings).WithGoogleRequestParam("security_policy", request => request.SecurityPolicy);
            Modify_ApiCall(ref _callGetAssociation);
            Modify_GetAssociationApiCall(ref _callGetAssociation);
            _callGetRule = clientHelper.BuildApiCall<GetRuleOrganizationSecurityPolicyRequest, SecurityPolicyRule>("GetRule", grpcClient.GetRuleAsync, grpcClient.GetRule, effectiveSettings.GetRuleSettings).WithGoogleRequestParam("security_policy", request => request.SecurityPolicy);
            Modify_ApiCall(ref _callGetRule);
            Modify_GetRuleApiCall(ref _callGetRule);
            _callInsert = clientHelper.BuildApiCall<InsertOrganizationSecurityPolicyRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListOrganizationSecurityPoliciesRequest, SecurityPolicyList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callListAssociations = clientHelper.BuildApiCall<ListAssociationsOrganizationSecurityPolicyRequest, OrganizationSecurityPoliciesListAssociationsResponse>("ListAssociations", grpcClient.ListAssociationsAsync, grpcClient.ListAssociations, effectiveSettings.ListAssociationsSettings);
            Modify_ApiCall(ref _callListAssociations);
            Modify_ListAssociationsApiCall(ref _callListAssociations);
            _callListPreconfiguredExpressionSets = clientHelper.BuildApiCall<ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest, SecurityPoliciesListPreconfiguredExpressionSetsResponse>("ListPreconfiguredExpressionSets", grpcClient.ListPreconfiguredExpressionSetsAsync, grpcClient.ListPreconfiguredExpressionSets, effectiveSettings.ListPreconfiguredExpressionSetsSettings);
            Modify_ApiCall(ref _callListPreconfiguredExpressionSets);
            Modify_ListPreconfiguredExpressionSetsApiCall(ref _callListPreconfiguredExpressionSets);
            _callMove = clientHelper.BuildApiCall<MoveOrganizationSecurityPolicyRequest, Operation>("Move", grpcClient.MoveAsync, grpcClient.Move, effectiveSettings.MoveSettings).WithGoogleRequestParam("security_policy", request => request.SecurityPolicy);
            Modify_ApiCall(ref _callMove);
            Modify_MoveApiCall(ref _callMove);
            _callPatch = clientHelper.BuildApiCall<PatchOrganizationSecurityPolicyRequest, Operation>("Patch", grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("security_policy", request => request.SecurityPolicy);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callPatchRule = clientHelper.BuildApiCall<PatchRuleOrganizationSecurityPolicyRequest, Operation>("PatchRule", grpcClient.PatchRuleAsync, grpcClient.PatchRule, effectiveSettings.PatchRuleSettings).WithGoogleRequestParam("security_policy", request => request.SecurityPolicy);
            Modify_ApiCall(ref _callPatchRule);
            Modify_PatchRuleApiCall(ref _callPatchRule);
            _callRemoveAssociation = clientHelper.BuildApiCall<RemoveAssociationOrganizationSecurityPolicyRequest, Operation>("RemoveAssociation", grpcClient.RemoveAssociationAsync, grpcClient.RemoveAssociation, effectiveSettings.RemoveAssociationSettings).WithGoogleRequestParam("security_policy", request => request.SecurityPolicy);
            Modify_ApiCall(ref _callRemoveAssociation);
            Modify_RemoveAssociationApiCall(ref _callRemoveAssociation);
            _callRemoveRule = clientHelper.BuildApiCall<RemoveRuleOrganizationSecurityPolicyRequest, Operation>("RemoveRule", grpcClient.RemoveRuleAsync, grpcClient.RemoveRule, effectiveSettings.RemoveRuleSettings).WithGoogleRequestParam("security_policy", request => request.SecurityPolicy);
            Modify_ApiCall(ref _callRemoveRule);
            Modify_RemoveRuleApiCall(ref _callRemoveRule);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AddAssociationApiCall(ref gaxgrpc::ApiCall<AddAssociationOrganizationSecurityPolicyRequest, Operation> call);

        partial void Modify_AddRuleApiCall(ref gaxgrpc::ApiCall<AddRuleOrganizationSecurityPolicyRequest, Operation> call);

        partial void Modify_CopyRulesApiCall(ref gaxgrpc::ApiCall<CopyRulesOrganizationSecurityPolicyRequest, Operation> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteOrganizationSecurityPolicyRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetOrganizationSecurityPolicyRequest, SecurityPolicy> call);

        partial void Modify_GetAssociationApiCall(ref gaxgrpc::ApiCall<GetAssociationOrganizationSecurityPolicyRequest, SecurityPolicyAssociation> call);

        partial void Modify_GetRuleApiCall(ref gaxgrpc::ApiCall<GetRuleOrganizationSecurityPolicyRequest, SecurityPolicyRule> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertOrganizationSecurityPolicyRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListOrganizationSecurityPoliciesRequest, SecurityPolicyList> call);

        partial void Modify_ListAssociationsApiCall(ref gaxgrpc::ApiCall<ListAssociationsOrganizationSecurityPolicyRequest, OrganizationSecurityPoliciesListAssociationsResponse> call);

        partial void Modify_ListPreconfiguredExpressionSetsApiCall(ref gaxgrpc::ApiCall<ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest, SecurityPoliciesListPreconfiguredExpressionSetsResponse> call);

        partial void Modify_MoveApiCall(ref gaxgrpc::ApiCall<MoveOrganizationSecurityPolicyRequest, Operation> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchOrganizationSecurityPolicyRequest, Operation> call);

        partial void Modify_PatchRuleApiCall(ref gaxgrpc::ApiCall<PatchRuleOrganizationSecurityPolicyRequest, Operation> call);

        partial void Modify_RemoveAssociationApiCall(ref gaxgrpc::ApiCall<RemoveAssociationOrganizationSecurityPolicyRequest, Operation> call);

        partial void Modify_RemoveRuleApiCall(ref gaxgrpc::ApiCall<RemoveRuleOrganizationSecurityPolicyRequest, Operation> call);

        partial void OnConstruction(OrganizationSecurityPolicies.OrganizationSecurityPoliciesClient grpcClient, OrganizationSecurityPoliciesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OrganizationSecurityPolicies client</summary>
        public override OrganizationSecurityPolicies.OrganizationSecurityPoliciesClient GrpcClient { get; }

        partial void Modify_AddAssociationOrganizationSecurityPolicyRequest(ref AddAssociationOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddRuleOrganizationSecurityPolicyRequest(ref AddRuleOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CopyRulesOrganizationSecurityPolicyRequest(ref CopyRulesOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteOrganizationSecurityPolicyRequest(ref DeleteOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOrganizationSecurityPolicyRequest(ref GetOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAssociationOrganizationSecurityPolicyRequest(ref GetAssociationOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRuleOrganizationSecurityPolicyRequest(ref GetRuleOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertOrganizationSecurityPolicyRequest(ref InsertOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOrganizationSecurityPoliciesRequest(ref ListOrganizationSecurityPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAssociationsOrganizationSecurityPolicyRequest(ref ListAssociationsOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest(ref ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveOrganizationSecurityPolicyRequest(ref MoveOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchOrganizationSecurityPolicyRequest(ref PatchOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchRuleOrganizationSecurityPolicyRequest(ref PatchRuleOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveAssociationOrganizationSecurityPolicyRequest(ref RemoveAssociationOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveRuleOrganizationSecurityPolicyRequest(ref RemoveRuleOrganizationSecurityPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>AddAssociation</c>.</summary>
        public override lro::OperationsClient AddAssociationOperationsClient { get; }

        /// <summary>
        /// Inserts an association for the specified security policy. This has billing implications. Projects in the hierarchy with effective hierarchical security policies will be automatically enrolled into Cloud Armor Enterprise if not already enrolled. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.addAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> AddAssociation(AddAssociationOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAssociationOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = _callAddAssociation.Sync(request, callSettings);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddAssociationOperationsClient);
        }

        /// <summary>
        /// Inserts an association for the specified security policy. This has billing implications. Projects in the hierarchy with effective hierarchical security policies will be automatically enrolled into Cloud Armor Enterprise if not already enrolled. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.addAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AddAssociationAsync(AddAssociationOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAssociationOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = await _callAddAssociation.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddAssociationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AddRule</c>.</summary>
        public override lro::OperationsClient AddRuleOperationsClient { get; }

        /// <summary>
        /// Inserts a rule into a security policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> AddRule(AddRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddRuleOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = _callAddRule.Sync(request, callSettings);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddRuleOperationsClient);
        }

        /// <summary>
        /// Inserts a rule into a security policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AddRuleAsync(AddRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddRuleOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = await _callAddRule.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddRuleOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CopyRules</c>.</summary>
        public override lro::OperationsClient CopyRulesOperationsClient { get; }

        /// <summary>
        /// Copies rules to the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.copyRules instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> CopyRules(CopyRulesOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CopyRulesOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = _callCopyRules.Sync(request, callSettings);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), CopyRulesOperationsClient);
        }

        /// <summary>
        /// Copies rules to the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.copyRules instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> CopyRulesAsync(CopyRulesOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CopyRulesOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = await _callCopyRules.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), CopyRulesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified policy. Use of this API to remove firewall policies is deprecated. Use firewallPolicies.delete instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified policy. Use of this API to remove firewall policies is deprecated. Use firewallPolicies.delete instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// List all of the ordered rules present in a single specified policy. Use of this API to read firewall policies is deprecated. Use firewallPolicies.get instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecurityPolicy Get(GetOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// List all of the ordered rules present in a single specified policy. Use of this API to read firewall policies is deprecated. Use firewallPolicies.get instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecurityPolicy> GetAsync(GetOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an association with the specified name. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecurityPolicyAssociation GetAssociation(GetAssociationOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssociationOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            return _callGetAssociation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an association with the specified name. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecurityPolicyAssociation> GetAssociationAsync(GetAssociationOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssociationOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            return _callGetAssociation.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a rule at the specified priority. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getRule instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecurityPolicyRule GetRule(GetRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuleOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            return _callGetRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a rule at the specified priority. Use of this API to read firewall policies is deprecated. Use firewallPolicies.getRule instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecurityPolicyRule> GetRuleAsync(GetRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuleOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            return _callGetRule.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request. Use of this API to insert firewall policies is deprecated. Use firewallPolicies.insert instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request. Use of this API to insert firewall policies is deprecated. Use firewallPolicies.insert instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// List all the policies that have been configured for the specified project. Use of this API to read firewall policies is deprecated. Use firewallPolicies.list instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecurityPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<SecurityPolicyList, SecurityPolicy> List(ListOrganizationSecurityPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrganizationSecurityPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOrganizationSecurityPoliciesRequest, SecurityPolicyList, SecurityPolicy>(_callList, request, callSettings);
        }

        /// <summary>
        /// List all the policies that have been configured for the specified project. Use of this API to read firewall policies is deprecated. Use firewallPolicies.list instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SecurityPolicyList, SecurityPolicy> ListAsync(ListOrganizationSecurityPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrganizationSecurityPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOrganizationSecurityPoliciesRequest, SecurityPolicyList, SecurityPolicy>(_callList, request, callSettings);
        }

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder. Use of this API to read firewall policies is deprecated. Use firewallPolicies.listAssociations instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OrganizationSecurityPoliciesListAssociationsResponse ListAssociations(ListAssociationsOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssociationsOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            return _callListAssociations.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists associations of a specified target, i.e., organization or folder. Use of this API to read firewall policies is deprecated. Use firewallPolicies.listAssociations instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OrganizationSecurityPoliciesListAssociationsResponse> ListAssociationsAsync(ListAssociationsOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssociationsOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            return _callListAssociations.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the current list of preconfigured Web Application Firewall (WAF) expressions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecurityPoliciesListPreconfiguredExpressionSetsResponse ListPreconfiguredExpressionSets(ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest(ref request, ref callSettings);
            return _callListPreconfiguredExpressionSets.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the current list of preconfigured Web Application Firewall (WAF) expressions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecurityPoliciesListPreconfiguredExpressionSetsResponse> ListPreconfiguredExpressionSetsAsync(ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest(ref request, ref callSettings);
            return _callListPreconfiguredExpressionSets.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Move</c>.</summary>
        public override lro::OperationsClient MoveOperationsClient { get; }

        /// <summary>
        /// Moves the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.move instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Move(MoveOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = _callMove.Sync(request, callSettings);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), MoveOperationsClient);
        }

        /// <summary>
        /// Moves the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.move instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> MoveAsync(MoveOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = await _callMove.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), MoveOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public override lro::OperationsClient PatchOperationsClient { get; }

        /// <summary>
        /// Patches the specified policy with the data included in the request. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patch instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Patch(PatchOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = _callPatch.Sync(request, callSettings);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>
        /// Patches the specified policy with the data included in the request. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patch instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = await _callPatch.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PatchRule</c>.</summary>
        public override lro::OperationsClient PatchRuleOperationsClient { get; }

        /// <summary>
        /// Patches a rule at the specified priority. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patchRule instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> PatchRule(PatchRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRuleOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = _callPatchRule.Sync(request, callSettings);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchRuleOperationsClient);
        }

        /// <summary>
        /// Patches a rule at the specified priority. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.patchRule instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> PatchRuleAsync(PatchRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRuleOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = await _callPatchRule.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchRuleOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveAssociation</c>.</summary>
        public override lro::OperationsClient RemoveAssociationOperationsClient { get; }

        /// <summary>
        /// Removes an association for the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.removeAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> RemoveAssociation(RemoveAssociationOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAssociationOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = _callRemoveAssociation.Sync(request, callSettings);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveAssociationOperationsClient);
        }

        /// <summary>
        /// Removes an association for the specified security policy. Use of this API to modify firewall policies is deprecated. Use firewallPolicies.removeAssociation instead if possible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> RemoveAssociationAsync(RemoveAssociationOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAssociationOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = await _callRemoveAssociation.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveAssociationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveRule</c>.</summary>
        public override lro::OperationsClient RemoveRuleOperationsClient { get; }

        /// <summary>
        /// Deletes a rule at the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> RemoveRule(RemoveRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveRuleOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = _callRemoveRule.Sync(request, callSettings);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveRuleOperationsClient);
        }

        /// <summary>
        /// Deletes a rule at the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> RemoveRuleAsync(RemoveRuleOrganizationSecurityPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveRuleOrganizationSecurityPolicyRequest(ref request, ref callSettings);
            Operation response = await _callRemoveRule.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOrganizationOperationRequest pollRequest = GetGlobalOrganizationOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveRuleOperationsClient);
        }
    }

    public partial class ListOrganizationSecurityPoliciesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class SecurityPolicyList : gaxgrpc::IPageResponse<SecurityPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SecurityPolicy> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class OrganizationSecurityPolicies
    {
        public partial class OrganizationSecurityPoliciesClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to GlobalOrganizationOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForGlobalOrganizationOperations() =>
                GlobalOrganizationOperations.GlobalOrganizationOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
