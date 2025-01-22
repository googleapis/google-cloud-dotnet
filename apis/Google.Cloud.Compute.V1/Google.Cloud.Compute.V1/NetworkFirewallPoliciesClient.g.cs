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
    /// <summary>Settings for <see cref="NetworkFirewallPoliciesClient"/> instances.</summary>
    public sealed partial class NetworkFirewallPoliciesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NetworkFirewallPoliciesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NetworkFirewallPoliciesSettings"/>.</returns>
        public static NetworkFirewallPoliciesSettings GetDefault() => new NetworkFirewallPoliciesSettings();

        /// <summary>
        /// Constructs a new <see cref="NetworkFirewallPoliciesSettings"/> object with default settings.
        /// </summary>
        public NetworkFirewallPoliciesSettings()
        {
        }

        private NetworkFirewallPoliciesSettings(NetworkFirewallPoliciesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AddAssociationSettings = existing.AddAssociationSettings;
            AddAssociationOperationsSettings = existing.AddAssociationOperationsSettings.Clone();
            AddRuleSettings = existing.AddRuleSettings;
            AddRuleOperationsSettings = existing.AddRuleOperationsSettings.Clone();
            AggregatedListSettings = existing.AggregatedListSettings;
            CloneRulesSettings = existing.CloneRulesSettings;
            CloneRulesOperationsSettings = existing.CloneRulesOperationsSettings.Clone();
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            GetAssociationSettings = existing.GetAssociationSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            GetRuleSettings = existing.GetRuleSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            PatchOperationsSettings = existing.PatchOperationsSettings.Clone();
            PatchRuleSettings = existing.PatchRuleSettings;
            PatchRuleOperationsSettings = existing.PatchRuleOperationsSettings.Clone();
            RemoveAssociationSettings = existing.RemoveAssociationSettings;
            RemoveAssociationOperationsSettings = existing.RemoveAssociationOperationsSettings.Clone();
            RemoveRuleSettings = existing.RemoveRuleSettings;
            RemoveRuleOperationsSettings = existing.RemoveRuleOperationsSettings.Clone();
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(NetworkFirewallPoliciesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkFirewallPoliciesClient.AddAssociation</c> and <c>NetworkFirewallPoliciesClient.AddAssociationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkFirewallPoliciesClient.AddAssociation</c> and
        /// <c>NetworkFirewallPoliciesClient.AddAssociationAsync</c>.
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
        /// <c>NetworkFirewallPoliciesClient.AddRule</c> and <c>NetworkFirewallPoliciesClient.AddRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkFirewallPoliciesClient.AddRule</c> and
        /// <c>NetworkFirewallPoliciesClient.AddRuleAsync</c>.
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
        /// <c>NetworkFirewallPoliciesClient.AggregatedList</c> and <c>NetworkFirewallPoliciesClient.AggregatedListAsync</c>
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
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkFirewallPoliciesClient.CloneRules</c> and <c>NetworkFirewallPoliciesClient.CloneRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CloneRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkFirewallPoliciesClient.CloneRules</c> and
        /// <c>NetworkFirewallPoliciesClient.CloneRulesAsync</c>.
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
        public lro::OperationsSettings CloneRulesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkFirewallPoliciesClient.Delete</c> and <c>NetworkFirewallPoliciesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkFirewallPoliciesClient.Delete</c> and
        /// <c>NetworkFirewallPoliciesClient.DeleteAsync</c>.
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
        /// <c>NetworkFirewallPoliciesClient.Get</c> and <c>NetworkFirewallPoliciesClient.GetAsync</c>.
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
        /// <c>NetworkFirewallPoliciesClient.GetAssociation</c> and <c>NetworkFirewallPoliciesClient.GetAssociationAsync</c>
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
        public gaxgrpc::CallSettings GetAssociationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkFirewallPoliciesClient.GetIamPolicy</c> and <c>NetworkFirewallPoliciesClient.GetIamPolicyAsync</c>
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
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkFirewallPoliciesClient.GetRule</c> and <c>NetworkFirewallPoliciesClient.GetRuleAsync</c>.
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
        /// <c>NetworkFirewallPoliciesClient.Insert</c> and <c>NetworkFirewallPoliciesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkFirewallPoliciesClient.Insert</c> and
        /// <c>NetworkFirewallPoliciesClient.InsertAsync</c>.
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
        /// <c>NetworkFirewallPoliciesClient.List</c> and <c>NetworkFirewallPoliciesClient.ListAsync</c>.
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
        /// <c>NetworkFirewallPoliciesClient.Patch</c> and <c>NetworkFirewallPoliciesClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkFirewallPoliciesClient.Patch</c> and
        /// <c>NetworkFirewallPoliciesClient.PatchAsync</c>.
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
        /// <c>NetworkFirewallPoliciesClient.PatchRule</c> and <c>NetworkFirewallPoliciesClient.PatchRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkFirewallPoliciesClient.PatchRule</c> and
        /// <c>NetworkFirewallPoliciesClient.PatchRuleAsync</c>.
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
        /// <c>NetworkFirewallPoliciesClient.RemoveAssociation</c> and
        /// <c>NetworkFirewallPoliciesClient.RemoveAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkFirewallPoliciesClient.RemoveAssociation</c> and
        /// <c>NetworkFirewallPoliciesClient.RemoveAssociationAsync</c>.
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
        /// <c>NetworkFirewallPoliciesClient.RemoveRule</c> and <c>NetworkFirewallPoliciesClient.RemoveRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkFirewallPoliciesClient.RemoveRule</c> and
        /// <c>NetworkFirewallPoliciesClient.RemoveRuleAsync</c>.
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

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkFirewallPoliciesClient.SetIamPolicy</c> and <c>NetworkFirewallPoliciesClient.SetIamPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkFirewallPoliciesClient.TestIamPermissions</c> and
        /// <c>NetworkFirewallPoliciesClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="NetworkFirewallPoliciesSettings"/> object.</returns>
        public NetworkFirewallPoliciesSettings Clone() => new NetworkFirewallPoliciesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NetworkFirewallPoliciesClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class NetworkFirewallPoliciesClientBuilder : gaxgrpc::ClientBuilderBase<NetworkFirewallPoliciesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NetworkFirewallPoliciesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NetworkFirewallPoliciesClientBuilder() : base(NetworkFirewallPoliciesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NetworkFirewallPoliciesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NetworkFirewallPoliciesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NetworkFirewallPoliciesClient Build()
        {
            NetworkFirewallPoliciesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NetworkFirewallPoliciesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NetworkFirewallPoliciesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NetworkFirewallPoliciesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NetworkFirewallPoliciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NetworkFirewallPoliciesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NetworkFirewallPoliciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NetworkFirewallPoliciesClient.ChannelPool;
    }

    /// <summary>NetworkFirewallPolicies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The NetworkFirewallPolicies API.
    /// </remarks>
    public abstract partial class NetworkFirewallPoliciesClient
    {
        /// <summary>
        /// The default endpoint for the NetworkFirewallPolicies service, which is a host of "compute.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default NetworkFirewallPolicies scopes.</summary>
        /// <remarks>
        /// The default NetworkFirewallPolicies scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NetworkFirewallPolicies.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NetworkFirewallPoliciesClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="NetworkFirewallPoliciesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NetworkFirewallPoliciesClient"/>.</returns>
        public static stt::Task<NetworkFirewallPoliciesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NetworkFirewallPoliciesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NetworkFirewallPoliciesClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="NetworkFirewallPoliciesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NetworkFirewallPoliciesClient"/>.</returns>
        public static NetworkFirewallPoliciesClient Create() => new NetworkFirewallPoliciesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NetworkFirewallPoliciesClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NetworkFirewallPoliciesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NetworkFirewallPoliciesClient"/>.</returns>
        internal static NetworkFirewallPoliciesClient Create(grpccore::CallInvoker callInvoker, NetworkFirewallPoliciesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NetworkFirewallPolicies.NetworkFirewallPoliciesClient grpcClient = new NetworkFirewallPolicies.NetworkFirewallPoliciesClient(callInvoker);
            return new NetworkFirewallPoliciesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NetworkFirewallPolicies client</summary>
        public virtual NetworkFirewallPolicies.NetworkFirewallPoliciesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddAssociation(AddAssociationNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddAssociationAsync(AddAssociationNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddAssociationAsync(AddAssociationNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
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
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyAssociationResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddAssociation(string project, string firewallPolicy, FirewallPolicyAssociation firewallPolicyAssociationResource, gaxgrpc::CallSettings callSettings = null) =>
            AddAssociation(new AddAssociationNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyAssociationResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyAssociationResource, nameof(firewallPolicyAssociationResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyAssociationResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddAssociationAsync(string project, string firewallPolicy, FirewallPolicyAssociation firewallPolicyAssociationResource, gaxgrpc::CallSettings callSettings = null) =>
            AddAssociationAsync(new AddAssociationNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyAssociationResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyAssociationResource, nameof(firewallPolicyAssociationResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyAssociationResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddAssociationAsync(string project, string firewallPolicy, FirewallPolicyAssociation firewallPolicyAssociationResource, st::CancellationToken cancellationToken) =>
            AddAssociationAsync(project, firewallPolicy, firewallPolicyAssociationResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddRule(AddRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddRuleAsync(AddRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddRuleAsync(AddRuleNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
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
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddRule(string project, string firewallPolicy, FirewallPolicyRule firewallPolicyRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            AddRule(new AddRuleNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyRuleResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyRuleResource, nameof(firewallPolicyRuleResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddRuleAsync(string project, string firewallPolicy, FirewallPolicyRule firewallPolicyRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            AddRuleAsync(new AddRuleNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyRuleResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyRuleResource, nameof(firewallPolicyRuleResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddRuleAsync(string project, string firewallPolicy, FirewallPolicyRule firewallPolicyRuleResource, st::CancellationToken cancellationToken) =>
            AddRuleAsync(project, firewallPolicy, firewallPolicyRuleResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an aggregated list of network firewall policies, listing network firewall policies from all applicable scopes (global and regional) and grouping the results per scope. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<NetworkFirewallPolicyAggregatedList, scg::KeyValuePair<string, FirewallPoliciesScopedList>> AggregatedList(AggregatedListNetworkFirewallPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of network firewall policies, listing network firewall policies from all applicable scopes (global and regional) and grouping the results per scope. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<NetworkFirewallPolicyAggregatedList, scg::KeyValuePair<string, FirewallPoliciesScopedList>> AggregatedListAsync(AggregatedListNetworkFirewallPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of network firewall policies, listing network firewall policies from all applicable scopes (global and regional) and grouping the results per scope. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<NetworkFirewallPolicyAggregatedList, scg::KeyValuePair<string, FirewallPoliciesScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListNetworkFirewallPoliciesRequest request = new AggregatedListNetworkFirewallPoliciesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregatedList(request, callSettings);
        }

        /// <summary>
        /// Retrieves an aggregated list of network firewall policies, listing network firewall policies from all applicable scopes (global and regional) and grouping the results per scope. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
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
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<NetworkFirewallPolicyAggregatedList, scg::KeyValuePair<string, FirewallPoliciesScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListNetworkFirewallPoliciesRequest request = new AggregatedListNetworkFirewallPoliciesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregatedListAsync(request, callSettings);
        }

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> CloneRules(CloneRulesNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CloneRulesAsync(CloneRulesNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CloneRulesAsync(CloneRulesNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            CloneRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CloneRules</c>.</summary>
        public virtual lro::OperationsClient CloneRulesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CloneRules</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceCloneRules(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CloneRulesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CloneRules</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceCloneRulesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CloneRulesOperationsClient, callSettings);

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> CloneRules(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CloneRules(new CloneRulesNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CloneRulesAsync(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CloneRulesAsync(new CloneRulesNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CloneRulesAsync(string project, string firewallPolicy, st::CancellationToken cancellationToken) =>
            CloneRulesAsync(project, firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
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
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string firewallPolicy, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified network firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicy Get(GetNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified network firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicy> GetAsync(GetNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified network firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicy> GetAsync(GetNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified network firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicy Get(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Returns the specified network firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicy> GetAsync(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Returns the specified network firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicy> GetAsync(string project, string firewallPolicy, st::CancellationToken cancellationToken) =>
            GetAsync(project, firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicyAssociation GetAssociation(GetAssociationNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyAssociation> GetAssociationAsync(GetAssociationNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyAssociation> GetAssociationAsync(GetAssociationNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to which the queried association belongs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicyAssociation GetAssociation(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetAssociation(new GetAssociationNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to which the queried association belongs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyAssociation> GetAssociationAsync(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetAssociationAsync(new GetAssociationNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to which the queried association belongs.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyAssociation> GetAssociationAsync(string project, string firewallPolicy, st::CancellationToken cancellationToken) =>
            GetAssociationAsync(project, firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetIamPolicy(GetIamPolicyNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetIamPolicy(string project, string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new GetIamPolicyNetworkFirewallPolicyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(string project, string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new GetIamPolicyNetworkFirewallPolicyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(string project, string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(project, resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicyRule GetRule(GetRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyRule> GetRuleAsync(GetRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyRule> GetRuleAsync(GetRuleNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to which the queried rule belongs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallPolicyRule GetRule(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetRule(new GetRuleNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to which the queried rule belongs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyRule> GetRuleAsync(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetRuleAsync(new GetRuleNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to which the queried rule belongs.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallPolicyRule> GetRuleAsync(string project, string firewallPolicy, st::CancellationToken cancellationToken) =>
            GetRuleAsync(project, firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
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
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, FirewallPolicy firewallPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertNetworkFirewallPolicyRequest
            {
                FirewallPolicyResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyResource, nameof(firewallPolicyResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, FirewallPolicy firewallPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertNetworkFirewallPolicyRequest
            {
                FirewallPolicyResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyResource, nameof(firewallPolicyResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, FirewallPolicy firewallPolicyResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, firewallPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FirewallPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<FirewallPolicyList, FirewallPolicy> List(ListNetworkFirewallPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FirewallPolicyList, FirewallPolicy> ListAsync(ListNetworkFirewallPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FirewallPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<FirewallPolicyList, FirewallPolicy> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNetworkFirewallPoliciesRequest request = new ListNetworkFirewallPoliciesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
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
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FirewallPolicyList, FirewallPolicy> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNetworkFirewallPoliciesRequest request = new ListNetworkFirewallPoliciesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
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
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(PatchNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
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
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(string project, string firewallPolicy, FirewallPolicy firewallPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyResource, nameof(firewallPolicyResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string firewallPolicy, FirewallPolicy firewallPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyResource, nameof(firewallPolicyResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string firewallPolicy, FirewallPolicy firewallPolicyResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, firewallPolicy, firewallPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> PatchRule(PatchRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchRuleAsync(PatchRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchRuleAsync(PatchRuleNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
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
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> PatchRule(string project, string firewallPolicy, FirewallPolicyRule firewallPolicyRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchRule(new PatchRuleNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyRuleResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyRuleResource, nameof(firewallPolicyRuleResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchRuleAsync(string project, string firewallPolicy, FirewallPolicyRule firewallPolicyRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchRuleAsync(new PatchRuleNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                FirewallPolicyRuleResource = gax::GaxPreconditions.CheckNotNull(firewallPolicyRuleResource, nameof(firewallPolicyRuleResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="firewallPolicyRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchRuleAsync(string project, string firewallPolicy, FirewallPolicyRule firewallPolicyRuleResource, st::CancellationToken cancellationToken) =>
            PatchRuleAsync(project, firewallPolicy, firewallPolicyRuleResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveAssociation(RemoveAssociationNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveAssociationAsync(RemoveAssociationNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveAssociationAsync(RemoveAssociationNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
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
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveAssociation(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAssociation(new RemoveAssociationNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveAssociationAsync(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAssociationAsync(new RemoveAssociationNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveAssociationAsync(string project, string firewallPolicy, st::CancellationToken cancellationToken) =>
            RemoveAssociationAsync(project, firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveRule(RemoveRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveRuleAsync(RemoveRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveRuleAsync(RemoveRuleNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
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
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveRule(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            RemoveRule(new RemoveRuleNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveRuleAsync(string project, string firewallPolicy, gaxgrpc::CallSettings callSettings = null) =>
            RemoveRuleAsync(new RemoveRuleNetworkFirewallPolicyRequest
            {
                FirewallPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(firewallPolicy, nameof(firewallPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="firewallPolicy">
        /// Name of the firewall policy to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveRuleAsync(string project, string firewallPolicy, st::CancellationToken cancellationToken) =>
            RemoveRuleAsync(project, firewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy SetIamPolicy(SetIamPolicyNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="globalSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy SetIamPolicy(string project, string resource, GlobalSetPolicyRequest globalSetPolicyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new SetIamPolicyNetworkFirewallPolicyRequest
            {
                GlobalSetPolicyRequestResource = gax::GaxPreconditions.CheckNotNull(globalSetPolicyRequestResource, nameof(globalSetPolicyRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="globalSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(string project, string resource, GlobalSetPolicyRequest globalSetPolicyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new SetIamPolicyNetworkFirewallPolicyRequest
            {
                GlobalSetPolicyRequestResource = gax::GaxPreconditions.CheckNotNull(globalSetPolicyRequestResource, nameof(globalSetPolicyRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="globalSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(string project, string resource, GlobalSetPolicyRequest globalSetPolicyRequestResource, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(project, resource, globalSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(TestIamPermissionsNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsNetworkFirewallPolicyRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(string project, string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new TestIamPermissionsNetworkFirewallPolicyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string project, string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new TestIamPermissionsNetworkFirewallPolicyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string project, string resource, TestPermissionsRequest testPermissionsRequestResource, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(project, resource, testPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>NetworkFirewallPolicies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The NetworkFirewallPolicies API.
    /// </remarks>
    public sealed partial class NetworkFirewallPoliciesClientImpl : NetworkFirewallPoliciesClient
    {
        private readonly gaxgrpc::ApiCall<AddAssociationNetworkFirewallPolicyRequest, Operation> _callAddAssociation;

        private readonly gaxgrpc::ApiCall<AddRuleNetworkFirewallPolicyRequest, Operation> _callAddRule;

        private readonly gaxgrpc::ApiCall<AggregatedListNetworkFirewallPoliciesRequest, NetworkFirewallPolicyAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<CloneRulesNetworkFirewallPolicyRequest, Operation> _callCloneRules;

        private readonly gaxgrpc::ApiCall<DeleteNetworkFirewallPolicyRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetNetworkFirewallPolicyRequest, FirewallPolicy> _callGet;

        private readonly gaxgrpc::ApiCall<GetAssociationNetworkFirewallPolicyRequest, FirewallPolicyAssociation> _callGetAssociation;

        private readonly gaxgrpc::ApiCall<GetIamPolicyNetworkFirewallPolicyRequest, Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<GetRuleNetworkFirewallPolicyRequest, FirewallPolicyRule> _callGetRule;

        private readonly gaxgrpc::ApiCall<InsertNetworkFirewallPolicyRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListNetworkFirewallPoliciesRequest, FirewallPolicyList> _callList;

        private readonly gaxgrpc::ApiCall<PatchNetworkFirewallPolicyRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<PatchRuleNetworkFirewallPolicyRequest, Operation> _callPatchRule;

        private readonly gaxgrpc::ApiCall<RemoveAssociationNetworkFirewallPolicyRequest, Operation> _callRemoveAssociation;

        private readonly gaxgrpc::ApiCall<RemoveRuleNetworkFirewallPolicyRequest, Operation> _callRemoveRule;

        private readonly gaxgrpc::ApiCall<SetIamPolicyNetworkFirewallPolicyRequest, Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<TestIamPermissionsNetworkFirewallPolicyRequest, TestPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the NetworkFirewallPolicies service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="NetworkFirewallPoliciesSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NetworkFirewallPoliciesClientImpl(NetworkFirewallPolicies.NetworkFirewallPoliciesClient grpcClient, NetworkFirewallPoliciesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NetworkFirewallPoliciesSettings effectiveSettings = settings ?? NetworkFirewallPoliciesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            AddAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.AddAssociationOperationsSettings, logger);
            AddRuleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.AddRuleOperationsSettings, logger);
            CloneRulesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.CloneRulesOperationsSettings, logger);
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.InsertOperationsSettings, logger);
            PatchOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.PatchOperationsSettings, logger);
            PatchRuleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.PatchRuleOperationsSettings, logger);
            RemoveAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.RemoveAssociationOperationsSettings, logger);
            RemoveRuleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.RemoveRuleOperationsSettings, logger);
            _callAddAssociation = clientHelper.BuildApiCall<AddAssociationNetworkFirewallPolicyRequest, Operation>("AddAssociation", grpcClient.AddAssociationAsync, grpcClient.AddAssociation, effectiveSettings.AddAssociationSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callAddAssociation);
            Modify_AddAssociationApiCall(ref _callAddAssociation);
            _callAddRule = clientHelper.BuildApiCall<AddRuleNetworkFirewallPolicyRequest, Operation>("AddRule", grpcClient.AddRuleAsync, grpcClient.AddRule, effectiveSettings.AddRuleSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callAddRule);
            Modify_AddRuleApiCall(ref _callAddRule);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListNetworkFirewallPoliciesRequest, NetworkFirewallPolicyAggregatedList>("AggregatedList", grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callCloneRules = clientHelper.BuildApiCall<CloneRulesNetworkFirewallPolicyRequest, Operation>("CloneRules", grpcClient.CloneRulesAsync, grpcClient.CloneRules, effectiveSettings.CloneRulesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callCloneRules);
            Modify_CloneRulesApiCall(ref _callCloneRules);
            _callDelete = clientHelper.BuildApiCall<DeleteNetworkFirewallPolicyRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetNetworkFirewallPolicyRequest, FirewallPolicy>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callGetAssociation = clientHelper.BuildApiCall<GetAssociationNetworkFirewallPolicyRequest, FirewallPolicyAssociation>("GetAssociation", grpcClient.GetAssociationAsync, grpcClient.GetAssociation, effectiveSettings.GetAssociationSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callGetAssociation);
            Modify_GetAssociationApiCall(ref _callGetAssociation);
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyNetworkFirewallPolicyRequest, Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callGetRule = clientHelper.BuildApiCall<GetRuleNetworkFirewallPolicyRequest, FirewallPolicyRule>("GetRule", grpcClient.GetRuleAsync, grpcClient.GetRule, effectiveSettings.GetRuleSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callGetRule);
            Modify_GetRuleApiCall(ref _callGetRule);
            _callInsert = clientHelper.BuildApiCall<InsertNetworkFirewallPolicyRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListNetworkFirewallPoliciesRequest, FirewallPolicyList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchNetworkFirewallPolicyRequest, Operation>("Patch", grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callPatchRule = clientHelper.BuildApiCall<PatchRuleNetworkFirewallPolicyRequest, Operation>("PatchRule", grpcClient.PatchRuleAsync, grpcClient.PatchRule, effectiveSettings.PatchRuleSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callPatchRule);
            Modify_PatchRuleApiCall(ref _callPatchRule);
            _callRemoveAssociation = clientHelper.BuildApiCall<RemoveAssociationNetworkFirewallPolicyRequest, Operation>("RemoveAssociation", grpcClient.RemoveAssociationAsync, grpcClient.RemoveAssociation, effectiveSettings.RemoveAssociationSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callRemoveAssociation);
            Modify_RemoveAssociationApiCall(ref _callRemoveAssociation);
            _callRemoveRule = clientHelper.BuildApiCall<RemoveRuleNetworkFirewallPolicyRequest, Operation>("RemoveRule", grpcClient.RemoveRuleAsync, grpcClient.RemoveRule, effectiveSettings.RemoveRuleSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("firewall_policy", request => request.FirewallPolicy);
            Modify_ApiCall(ref _callRemoveRule);
            Modify_RemoveRuleApiCall(ref _callRemoveRule);
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyNetworkFirewallPolicyRequest, Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsNetworkFirewallPolicyRequest, TestPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AddAssociationApiCall(ref gaxgrpc::ApiCall<AddAssociationNetworkFirewallPolicyRequest, Operation> call);

        partial void Modify_AddRuleApiCall(ref gaxgrpc::ApiCall<AddRuleNetworkFirewallPolicyRequest, Operation> call);

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListNetworkFirewallPoliciesRequest, NetworkFirewallPolicyAggregatedList> call);

        partial void Modify_CloneRulesApiCall(ref gaxgrpc::ApiCall<CloneRulesNetworkFirewallPolicyRequest, Operation> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteNetworkFirewallPolicyRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetNetworkFirewallPolicyRequest, FirewallPolicy> call);

        partial void Modify_GetAssociationApiCall(ref gaxgrpc::ApiCall<GetAssociationNetworkFirewallPolicyRequest, FirewallPolicyAssociation> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<GetIamPolicyNetworkFirewallPolicyRequest, Policy> call);

        partial void Modify_GetRuleApiCall(ref gaxgrpc::ApiCall<GetRuleNetworkFirewallPolicyRequest, FirewallPolicyRule> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertNetworkFirewallPolicyRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListNetworkFirewallPoliciesRequest, FirewallPolicyList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchNetworkFirewallPolicyRequest, Operation> call);

        partial void Modify_PatchRuleApiCall(ref gaxgrpc::ApiCall<PatchRuleNetworkFirewallPolicyRequest, Operation> call);

        partial void Modify_RemoveAssociationApiCall(ref gaxgrpc::ApiCall<RemoveAssociationNetworkFirewallPolicyRequest, Operation> call);

        partial void Modify_RemoveRuleApiCall(ref gaxgrpc::ApiCall<RemoveRuleNetworkFirewallPolicyRequest, Operation> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<SetIamPolicyNetworkFirewallPolicyRequest, Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<TestIamPermissionsNetworkFirewallPolicyRequest, TestPermissionsResponse> call);

        partial void OnConstruction(NetworkFirewallPolicies.NetworkFirewallPoliciesClient grpcClient, NetworkFirewallPoliciesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NetworkFirewallPolicies client</summary>
        public override NetworkFirewallPolicies.NetworkFirewallPoliciesClient GrpcClient { get; }

        partial void Modify_AddAssociationNetworkFirewallPolicyRequest(ref AddAssociationNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddRuleNetworkFirewallPolicyRequest(ref AddRuleNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AggregatedListNetworkFirewallPoliciesRequest(ref AggregatedListNetworkFirewallPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CloneRulesNetworkFirewallPolicyRequest(ref CloneRulesNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNetworkFirewallPolicyRequest(ref DeleteNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNetworkFirewallPolicyRequest(ref GetNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAssociationNetworkFirewallPolicyRequest(ref GetAssociationNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyNetworkFirewallPolicyRequest(ref GetIamPolicyNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRuleNetworkFirewallPolicyRequest(ref GetRuleNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertNetworkFirewallPolicyRequest(ref InsertNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNetworkFirewallPoliciesRequest(ref ListNetworkFirewallPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchNetworkFirewallPolicyRequest(ref PatchNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchRuleNetworkFirewallPolicyRequest(ref PatchRuleNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveAssociationNetworkFirewallPolicyRequest(ref RemoveAssociationNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveRuleNetworkFirewallPolicyRequest(ref RemoveRuleNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyNetworkFirewallPolicyRequest(ref SetIamPolicyNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsNetworkFirewallPolicyRequest(ref TestIamPermissionsNetworkFirewallPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>AddAssociation</c>.</summary>
        public override lro::OperationsClient AddAssociationOperationsClient { get; }

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> AddAssociation(AddAssociationNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAssociationNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = _callAddAssociation.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddAssociationOperationsClient);
        }

        /// <summary>
        /// Inserts an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AddAssociationAsync(AddAssociationNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAssociationNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = await _callAddAssociation.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddAssociationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AddRule</c>.</summary>
        public override lro::OperationsClient AddRuleOperationsClient { get; }

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> AddRule(AddRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddRuleNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = _callAddRule.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddRuleOperationsClient);
        }

        /// <summary>
        /// Inserts a rule into a firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AddRuleAsync(AddRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddRuleNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = await _callAddRule.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddRuleOperationsClient);
        }

        /// <summary>
        /// Retrieves an aggregated list of network firewall policies, listing network firewall policies from all applicable scopes (global and regional) and grouping the results per scope. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<NetworkFirewallPolicyAggregatedList, scg::KeyValuePair<string, FirewallPoliciesScopedList>> AggregatedList(AggregatedListNetworkFirewallPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListNetworkFirewallPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListNetworkFirewallPoliciesRequest, NetworkFirewallPolicyAggregatedList, scg::KeyValuePair<string, FirewallPoliciesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves an aggregated list of network firewall policies, listing network firewall policies from all applicable scopes (global and regional) and grouping the results per scope. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<NetworkFirewallPolicyAggregatedList, scg::KeyValuePair<string, FirewallPoliciesScopedList>> AggregatedListAsync(AggregatedListNetworkFirewallPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListNetworkFirewallPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListNetworkFirewallPoliciesRequest, NetworkFirewallPolicyAggregatedList, scg::KeyValuePair<string, FirewallPoliciesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CloneRules</c>.</summary>
        public override lro::OperationsClient CloneRulesOperationsClient { get; }

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> CloneRules(CloneRulesNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CloneRulesNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = _callCloneRules.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), CloneRulesOperationsClient);
        }

        /// <summary>
        /// Copies rules to the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> CloneRulesAsync(CloneRulesNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CloneRulesNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = await _callCloneRules.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), CloneRulesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns the specified network firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallPolicy Get(GetNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNetworkFirewallPolicyRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified network firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallPolicy> GetAsync(GetNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNetworkFirewallPolicyRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallPolicyAssociation GetAssociation(GetAssociationNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssociationNetworkFirewallPolicyRequest(ref request, ref callSettings);
            return _callGetAssociation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an association with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallPolicyAssociation> GetAssociationAsync(GetAssociationNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssociationNetworkFirewallPolicyRequest(ref request, ref callSettings);
            return _callGetAssociation.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetIamPolicy(GetIamPolicyNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyNetworkFirewallPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyNetworkFirewallPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallPolicyRule GetRule(GetRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuleNetworkFirewallPolicyRequest(ref request, ref callSettings);
            return _callGetRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallPolicyRule> GetRuleAsync(GetRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuleNetworkFirewallPolicyRequest(ref request, ref callSettings);
            return _callGetRule.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a new policy in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FirewallPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<FirewallPolicyList, FirewallPolicy> List(ListNetworkFirewallPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworkFirewallPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNetworkFirewallPoliciesRequest, FirewallPolicyList, FirewallPolicy>(_callList, request, callSettings);
        }

        /// <summary>
        /// Lists all the policies that have been configured for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FirewallPolicyList, FirewallPolicy> ListAsync(ListNetworkFirewallPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworkFirewallPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNetworkFirewallPoliciesRequest, FirewallPolicyList, FirewallPolicy>(_callList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public override lro::OperationsClient PatchOperationsClient { get; }

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Patch(PatchNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = _callPatch.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>
        /// Patches the specified policy with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = await _callPatch.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PatchRule</c>.</summary>
        public override lro::OperationsClient PatchRuleOperationsClient { get; }

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> PatchRule(PatchRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRuleNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = _callPatchRule.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchRuleOperationsClient);
        }

        /// <summary>
        /// Patches a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> PatchRuleAsync(PatchRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRuleNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = await _callPatchRule.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchRuleOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveAssociation</c>.</summary>
        public override lro::OperationsClient RemoveAssociationOperationsClient { get; }

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> RemoveAssociation(RemoveAssociationNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAssociationNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = _callRemoveAssociation.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveAssociationOperationsClient);
        }

        /// <summary>
        /// Removes an association for the specified firewall policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> RemoveAssociationAsync(RemoveAssociationNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAssociationNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = await _callRemoveAssociation.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveAssociationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveRule</c>.</summary>
        public override lro::OperationsClient RemoveRuleOperationsClient { get; }

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> RemoveRule(RemoveRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveRuleNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = _callRemoveRule.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveRuleOperationsClient);
        }

        /// <summary>
        /// Deletes a rule of the specified priority.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> RemoveRuleAsync(RemoveRuleNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveRuleNetworkFirewallPolicyRequest(ref request, ref callSettings);
            Operation response = await _callRemoveRule.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveRuleOperationsClient);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy SetIamPolicy(SetIamPolicyNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyNetworkFirewallPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyNetworkFirewallPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestPermissionsResponse TestIamPermissions(TestIamPermissionsNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsNetworkFirewallPolicyRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsNetworkFirewallPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsNetworkFirewallPolicyRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class AggregatedListNetworkFirewallPoliciesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListNetworkFirewallPoliciesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class NetworkFirewallPolicyAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, FirewallPoliciesScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, FirewallPoliciesScopedList>> GetEnumerator() =>
            Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class NetworkFirewallPolicies
    {
        public partial class NetworkFirewallPoliciesClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to GlobalOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForGlobalOperations() =>
                GlobalOperations.GlobalOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
