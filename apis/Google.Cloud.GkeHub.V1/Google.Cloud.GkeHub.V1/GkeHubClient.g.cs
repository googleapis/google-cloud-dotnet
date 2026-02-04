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

namespace Google.Cloud.GkeHub.V1
{
    /// <summary>Settings for <see cref="GkeHubClient"/> instances.</summary>
    public sealed partial class GkeHubSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GkeHubSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GkeHubSettings"/>.</returns>
        public static GkeHubSettings GetDefault() => new GkeHubSettings();

        /// <summary>Constructs a new <see cref="GkeHubSettings"/> object with default settings.</summary>
        public GkeHubSettings()
        {
        }

        private GkeHubSettings(GkeHubSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListMembershipsSettings = existing.ListMembershipsSettings;
            ListBoundMembershipsSettings = existing.ListBoundMembershipsSettings;
            ListFeaturesSettings = existing.ListFeaturesSettings;
            GetMembershipSettings = existing.GetMembershipSettings;
            GetFeatureSettings = existing.GetFeatureSettings;
            CreateMembershipSettings = existing.CreateMembershipSettings;
            CreateMembershipOperationsSettings = existing.CreateMembershipOperationsSettings.Clone();
            CreateFeatureSettings = existing.CreateFeatureSettings;
            CreateFeatureOperationsSettings = existing.CreateFeatureOperationsSettings.Clone();
            DeleteMembershipSettings = existing.DeleteMembershipSettings;
            DeleteMembershipOperationsSettings = existing.DeleteMembershipOperationsSettings.Clone();
            DeleteFeatureSettings = existing.DeleteFeatureSettings;
            DeleteFeatureOperationsSettings = existing.DeleteFeatureOperationsSettings.Clone();
            UpdateMembershipSettings = existing.UpdateMembershipSettings;
            UpdateMembershipOperationsSettings = existing.UpdateMembershipOperationsSettings.Clone();
            UpdateFeatureSettings = existing.UpdateFeatureSettings;
            UpdateFeatureOperationsSettings = existing.UpdateFeatureOperationsSettings.Clone();
            GenerateConnectManifestSettings = existing.GenerateConnectManifestSettings;
            CreateFleetSettings = existing.CreateFleetSettings;
            CreateFleetOperationsSettings = existing.CreateFleetOperationsSettings.Clone();
            GetFleetSettings = existing.GetFleetSettings;
            UpdateFleetSettings = existing.UpdateFleetSettings;
            UpdateFleetOperationsSettings = existing.UpdateFleetOperationsSettings.Clone();
            DeleteFleetSettings = existing.DeleteFleetSettings;
            DeleteFleetOperationsSettings = existing.DeleteFleetOperationsSettings.Clone();
            ListFleetsSettings = existing.ListFleetsSettings;
            GetScopeNamespaceSettings = existing.GetScopeNamespaceSettings;
            CreateScopeNamespaceSettings = existing.CreateScopeNamespaceSettings;
            CreateScopeNamespaceOperationsSettings = existing.CreateScopeNamespaceOperationsSettings.Clone();
            UpdateScopeNamespaceSettings = existing.UpdateScopeNamespaceSettings;
            UpdateScopeNamespaceOperationsSettings = existing.UpdateScopeNamespaceOperationsSettings.Clone();
            DeleteScopeNamespaceSettings = existing.DeleteScopeNamespaceSettings;
            DeleteScopeNamespaceOperationsSettings = existing.DeleteScopeNamespaceOperationsSettings.Clone();
            ListScopeNamespacesSettings = existing.ListScopeNamespacesSettings;
            GetScopeRBACRoleBindingSettings = existing.GetScopeRBACRoleBindingSettings;
            CreateScopeRBACRoleBindingSettings = existing.CreateScopeRBACRoleBindingSettings;
            CreateScopeRBACRoleBindingOperationsSettings = existing.CreateScopeRBACRoleBindingOperationsSettings.Clone();
            UpdateScopeRBACRoleBindingSettings = existing.UpdateScopeRBACRoleBindingSettings;
            UpdateScopeRBACRoleBindingOperationsSettings = existing.UpdateScopeRBACRoleBindingOperationsSettings.Clone();
            DeleteScopeRBACRoleBindingSettings = existing.DeleteScopeRBACRoleBindingSettings;
            DeleteScopeRBACRoleBindingOperationsSettings = existing.DeleteScopeRBACRoleBindingOperationsSettings.Clone();
            ListScopeRBACRoleBindingsSettings = existing.ListScopeRBACRoleBindingsSettings;
            GetScopeSettings = existing.GetScopeSettings;
            CreateScopeSettings = existing.CreateScopeSettings;
            CreateScopeOperationsSettings = existing.CreateScopeOperationsSettings.Clone();
            UpdateScopeSettings = existing.UpdateScopeSettings;
            UpdateScopeOperationsSettings = existing.UpdateScopeOperationsSettings.Clone();
            DeleteScopeSettings = existing.DeleteScopeSettings;
            DeleteScopeOperationsSettings = existing.DeleteScopeOperationsSettings.Clone();
            ListScopesSettings = existing.ListScopesSettings;
            ListPermittedScopesSettings = existing.ListPermittedScopesSettings;
            GetMembershipBindingSettings = existing.GetMembershipBindingSettings;
            CreateMembershipBindingSettings = existing.CreateMembershipBindingSettings;
            CreateMembershipBindingOperationsSettings = existing.CreateMembershipBindingOperationsSettings.Clone();
            UpdateMembershipBindingSettings = existing.UpdateMembershipBindingSettings;
            UpdateMembershipBindingOperationsSettings = existing.UpdateMembershipBindingOperationsSettings.Clone();
            DeleteMembershipBindingSettings = existing.DeleteMembershipBindingSettings;
            DeleteMembershipBindingOperationsSettings = existing.DeleteMembershipBindingOperationsSettings.Clone();
            ListMembershipBindingsSettings = existing.ListMembershipBindingsSettings;
            GetMembershipRBACRoleBindingSettings = existing.GetMembershipRBACRoleBindingSettings;
            CreateMembershipRBACRoleBindingSettings = existing.CreateMembershipRBACRoleBindingSettings;
            CreateMembershipRBACRoleBindingOperationsSettings = existing.CreateMembershipRBACRoleBindingOperationsSettings.Clone();
            UpdateMembershipRBACRoleBindingSettings = existing.UpdateMembershipRBACRoleBindingSettings;
            UpdateMembershipRBACRoleBindingOperationsSettings = existing.UpdateMembershipRBACRoleBindingOperationsSettings.Clone();
            DeleteMembershipRBACRoleBindingSettings = existing.DeleteMembershipRBACRoleBindingSettings;
            DeleteMembershipRBACRoleBindingOperationsSettings = existing.DeleteMembershipRBACRoleBindingOperationsSettings.Clone();
            ListMembershipRBACRoleBindingsSettings = existing.ListMembershipRBACRoleBindingsSettings;
            GenerateMembershipRBACRoleBindingYAMLSettings = existing.GenerateMembershipRBACRoleBindingYAMLSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GkeHubSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.ListMemberships</c> and <c>GkeHubClient.ListMembershipsAsync</c>.
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
        public gaxgrpc::CallSettings ListMembershipsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.ListBoundMemberships</c> and <c>GkeHubClient.ListBoundMembershipsAsync</c>.
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
        public gaxgrpc::CallSettings ListBoundMembershipsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.ListFeatures</c>
        ///  and <c>GkeHubClient.ListFeaturesAsync</c>.
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
        public gaxgrpc::CallSettings ListFeaturesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.GetMembership</c>
        ///  and <c>GkeHubClient.GetMembershipAsync</c>.
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
        public gaxgrpc::CallSettings GetMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.GetFeature</c>
        /// and <c>GkeHubClient.GetFeatureAsync</c>.
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
        public gaxgrpc::CallSettings GetFeatureSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.CreateMembership</c> and <c>GkeHubClient.CreateMembershipAsync</c>.
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
        public gaxgrpc::CallSettings CreateMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.CreateMembership</c> and
        /// <c>GkeHubClient.CreateMembershipAsync</c>.
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
        public lro::OperationsSettings CreateMembershipOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.CreateFeature</c>
        ///  and <c>GkeHubClient.CreateFeatureAsync</c>.
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
        public gaxgrpc::CallSettings CreateFeatureSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.CreateFeature</c> and
        /// <c>GkeHubClient.CreateFeatureAsync</c>.
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
        public lro::OperationsSettings CreateFeatureOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.DeleteMembership</c> and <c>GkeHubClient.DeleteMembershipAsync</c>.
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
        public gaxgrpc::CallSettings DeleteMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.DeleteMembership</c> and
        /// <c>GkeHubClient.DeleteMembershipAsync</c>.
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
        public lro::OperationsSettings DeleteMembershipOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.DeleteFeature</c>
        ///  and <c>GkeHubClient.DeleteFeatureAsync</c>.
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
        public gaxgrpc::CallSettings DeleteFeatureSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.DeleteFeature</c> and
        /// <c>GkeHubClient.DeleteFeatureAsync</c>.
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
        public lro::OperationsSettings DeleteFeatureOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.UpdateMembership</c> and <c>GkeHubClient.UpdateMembershipAsync</c>.
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
        public gaxgrpc::CallSettings UpdateMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.UpdateMembership</c> and
        /// <c>GkeHubClient.UpdateMembershipAsync</c>.
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
        public lro::OperationsSettings UpdateMembershipOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.UpdateFeature</c>
        ///  and <c>GkeHubClient.UpdateFeatureAsync</c>.
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
        public gaxgrpc::CallSettings UpdateFeatureSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.UpdateFeature</c> and
        /// <c>GkeHubClient.UpdateFeatureAsync</c>.
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
        public lro::OperationsSettings UpdateFeatureOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.GenerateConnectManifest</c> and <c>GkeHubClient.GenerateConnectManifestAsync</c>.
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
        public gaxgrpc::CallSettings GenerateConnectManifestSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.CreateFleet</c>
        ///  and <c>GkeHubClient.CreateFleetAsync</c>.
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
        public gaxgrpc::CallSettings CreateFleetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.CreateFleet</c> and
        /// <c>GkeHubClient.CreateFleetAsync</c>.
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
        public lro::OperationsSettings CreateFleetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.GetFleet</c>
        /// and <c>GkeHubClient.GetFleetAsync</c>.
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
        public gaxgrpc::CallSettings GetFleetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.UpdateFleet</c>
        ///  and <c>GkeHubClient.UpdateFleetAsync</c>.
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
        public gaxgrpc::CallSettings UpdateFleetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.UpdateFleet</c> and
        /// <c>GkeHubClient.UpdateFleetAsync</c>.
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
        public lro::OperationsSettings UpdateFleetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.DeleteFleet</c>
        ///  and <c>GkeHubClient.DeleteFleetAsync</c>.
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
        public gaxgrpc::CallSettings DeleteFleetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.DeleteFleet</c> and
        /// <c>GkeHubClient.DeleteFleetAsync</c>.
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
        public lro::OperationsSettings DeleteFleetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.ListFleets</c>
        /// and <c>GkeHubClient.ListFleetsAsync</c>.
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
        public gaxgrpc::CallSettings ListFleetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.GetScopeNamespace</c> and <c>GkeHubClient.GetScopeNamespaceAsync</c>.
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
        public gaxgrpc::CallSettings GetScopeNamespaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.CreateScopeNamespace</c> and <c>GkeHubClient.CreateScopeNamespaceAsync</c>.
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
        public gaxgrpc::CallSettings CreateScopeNamespaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.CreateScopeNamespace</c> and
        /// <c>GkeHubClient.CreateScopeNamespaceAsync</c>.
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
        public lro::OperationsSettings CreateScopeNamespaceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.UpdateScopeNamespace</c> and <c>GkeHubClient.UpdateScopeNamespaceAsync</c>.
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
        public gaxgrpc::CallSettings UpdateScopeNamespaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.UpdateScopeNamespace</c> and
        /// <c>GkeHubClient.UpdateScopeNamespaceAsync</c>.
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
        public lro::OperationsSettings UpdateScopeNamespaceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.DeleteScopeNamespace</c> and <c>GkeHubClient.DeleteScopeNamespaceAsync</c>.
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
        public gaxgrpc::CallSettings DeleteScopeNamespaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.DeleteScopeNamespace</c> and
        /// <c>GkeHubClient.DeleteScopeNamespaceAsync</c>.
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
        public lro::OperationsSettings DeleteScopeNamespaceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.ListScopeNamespaces</c> and <c>GkeHubClient.ListScopeNamespacesAsync</c>.
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
        public gaxgrpc::CallSettings ListScopeNamespacesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.GetScopeRBACRoleBinding</c> and <c>GkeHubClient.GetScopeRBACRoleBindingAsync</c>.
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
        public gaxgrpc::CallSettings GetScopeRBACRoleBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.CreateScopeRBACRoleBinding</c> and <c>GkeHubClient.CreateScopeRBACRoleBindingAsync</c>.
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
        public gaxgrpc::CallSettings CreateScopeRBACRoleBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.CreateScopeRBACRoleBinding</c> and
        /// <c>GkeHubClient.CreateScopeRBACRoleBindingAsync</c>.
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
        public lro::OperationsSettings CreateScopeRBACRoleBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.UpdateScopeRBACRoleBinding</c> and <c>GkeHubClient.UpdateScopeRBACRoleBindingAsync</c>.
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
        public gaxgrpc::CallSettings UpdateScopeRBACRoleBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.UpdateScopeRBACRoleBinding</c> and
        /// <c>GkeHubClient.UpdateScopeRBACRoleBindingAsync</c>.
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
        public lro::OperationsSettings UpdateScopeRBACRoleBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.DeleteScopeRBACRoleBinding</c> and <c>GkeHubClient.DeleteScopeRBACRoleBindingAsync</c>.
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
        public gaxgrpc::CallSettings DeleteScopeRBACRoleBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.DeleteScopeRBACRoleBinding</c> and
        /// <c>GkeHubClient.DeleteScopeRBACRoleBindingAsync</c>.
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
        public lro::OperationsSettings DeleteScopeRBACRoleBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.ListScopeRBACRoleBindings</c> and <c>GkeHubClient.ListScopeRBACRoleBindingsAsync</c>.
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
        public gaxgrpc::CallSettings ListScopeRBACRoleBindingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.GetScope</c>
        /// and <c>GkeHubClient.GetScopeAsync</c>.
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
        public gaxgrpc::CallSettings GetScopeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.CreateScope</c>
        ///  and <c>GkeHubClient.CreateScopeAsync</c>.
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
        public gaxgrpc::CallSettings CreateScopeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.CreateScope</c> and
        /// <c>GkeHubClient.CreateScopeAsync</c>.
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
        public lro::OperationsSettings CreateScopeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.UpdateScope</c>
        ///  and <c>GkeHubClient.UpdateScopeAsync</c>.
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
        public gaxgrpc::CallSettings UpdateScopeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.UpdateScope</c> and
        /// <c>GkeHubClient.UpdateScopeAsync</c>.
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
        public lro::OperationsSettings UpdateScopeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.DeleteScope</c>
        ///  and <c>GkeHubClient.DeleteScopeAsync</c>.
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
        public gaxgrpc::CallSettings DeleteScopeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.DeleteScope</c> and
        /// <c>GkeHubClient.DeleteScopeAsync</c>.
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
        public lro::OperationsSettings DeleteScopeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.ListScopes</c>
        /// and <c>GkeHubClient.ListScopesAsync</c>.
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
        public gaxgrpc::CallSettings ListScopesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.ListPermittedScopes</c> and <c>GkeHubClient.ListPermittedScopesAsync</c>.
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
        public gaxgrpc::CallSettings ListPermittedScopesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.GetMembershipBinding</c> and <c>GkeHubClient.GetMembershipBindingAsync</c>.
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
        public gaxgrpc::CallSettings GetMembershipBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.CreateMembershipBinding</c> and <c>GkeHubClient.CreateMembershipBindingAsync</c>.
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
        public gaxgrpc::CallSettings CreateMembershipBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.CreateMembershipBinding</c> and
        /// <c>GkeHubClient.CreateMembershipBindingAsync</c>.
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
        public lro::OperationsSettings CreateMembershipBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.UpdateMembershipBinding</c> and <c>GkeHubClient.UpdateMembershipBindingAsync</c>.
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
        public gaxgrpc::CallSettings UpdateMembershipBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.UpdateMembershipBinding</c> and
        /// <c>GkeHubClient.UpdateMembershipBindingAsync</c>.
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
        public lro::OperationsSettings UpdateMembershipBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.DeleteMembershipBinding</c> and <c>GkeHubClient.DeleteMembershipBindingAsync</c>.
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
        public gaxgrpc::CallSettings DeleteMembershipBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.DeleteMembershipBinding</c> and
        /// <c>GkeHubClient.DeleteMembershipBindingAsync</c>.
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
        public lro::OperationsSettings DeleteMembershipBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.ListMembershipBindings</c> and <c>GkeHubClient.ListMembershipBindingsAsync</c>.
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
        public gaxgrpc::CallSettings ListMembershipBindingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.GetMembershipRBACRoleBinding</c> and <c>GkeHubClient.GetMembershipRBACRoleBindingAsync</c>.
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
        public gaxgrpc::CallSettings GetMembershipRBACRoleBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.CreateMembershipRBACRoleBinding</c> and <c>GkeHubClient.CreateMembershipRBACRoleBindingAsync</c>
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
        public gaxgrpc::CallSettings CreateMembershipRBACRoleBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.CreateMembershipRBACRoleBinding</c> and
        /// <c>GkeHubClient.CreateMembershipRBACRoleBindingAsync</c>.
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
        public lro::OperationsSettings CreateMembershipRBACRoleBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.UpdateMembershipRBACRoleBinding</c> and <c>GkeHubClient.UpdateMembershipRBACRoleBindingAsync</c>
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
        public gaxgrpc::CallSettings UpdateMembershipRBACRoleBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.UpdateMembershipRBACRoleBinding</c> and
        /// <c>GkeHubClient.UpdateMembershipRBACRoleBindingAsync</c>.
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
        public lro::OperationsSettings UpdateMembershipRBACRoleBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.DeleteMembershipRBACRoleBinding</c> and <c>GkeHubClient.DeleteMembershipRBACRoleBindingAsync</c>
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
        public gaxgrpc::CallSettings DeleteMembershipRBACRoleBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.DeleteMembershipRBACRoleBinding</c> and
        /// <c>GkeHubClient.DeleteMembershipRBACRoleBindingAsync</c>.
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
        public lro::OperationsSettings DeleteMembershipRBACRoleBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.ListMembershipRBACRoleBindings</c> and <c>GkeHubClient.ListMembershipRBACRoleBindingsAsync</c>
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
        public gaxgrpc::CallSettings ListMembershipRBACRoleBindingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.GenerateMembershipRBACRoleBindingYAML</c> and
        /// <c>GkeHubClient.GenerateMembershipRBACRoleBindingYAMLAsync</c>.
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
        public gaxgrpc::CallSettings GenerateMembershipRBACRoleBindingYAMLSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GkeHubSettings"/> object.</returns>
        public GkeHubSettings Clone() => new GkeHubSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GkeHubClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class GkeHubClientBuilder : gaxgrpc::ClientBuilderBase<GkeHubClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GkeHubSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GkeHubClientBuilder() : base(GkeHubClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GkeHubClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GkeHubClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GkeHubClient Build()
        {
            GkeHubClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GkeHubClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GkeHubClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GkeHubClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GkeHubClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GkeHubClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GkeHubClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GkeHubClient.ChannelPool;
    }

    /// <summary>GkeHub client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The GKE Hub service handles the registration of many Kubernetes clusters to
    /// Google Cloud, and the management of multi-cluster features over those
    /// clusters.
    /// 
    /// The GKE Hub service operates on the following resources:
    /// 
    /// * [Membership][google.cloud.gkehub.v1.Membership]
    /// * [Feature][google.cloud.gkehub.v1.Feature]
    /// 
    /// GKE Hub is currently available in the global region and all regions in
    /// https://cloud.google.com/compute/docs/regions-zones. Feature is only
    /// available in global region while membership is global region and all the
    /// regions.
    /// 
    /// **Membership management may be non-trivial:** it is recommended to use one
    /// of the Google-provided client libraries or tools where possible when working
    /// with Membership resources.
    /// </remarks>
    public abstract partial class GkeHubClient
    {
        /// <summary>
        /// The default endpoint for the GkeHub service, which is a host of "gkehub.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gkehub.googleapis.com:443";

        /// <summary>The default GkeHub scopes.</summary>
        /// <remarks>
        /// The default GkeHub scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GkeHub.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GkeHubClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="GkeHubClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GkeHubClient"/>.</returns>
        public static stt::Task<GkeHubClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GkeHubClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GkeHubClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="GkeHubClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GkeHubClient"/>.</returns>
        public static GkeHubClient Create() => new GkeHubClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GkeHubClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GkeHubSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GkeHubClient"/>.</returns>
        internal static GkeHubClient Create(grpccore::CallInvoker callInvoker, GkeHubSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GkeHub.GkeHubClient grpcClient = new GkeHub.GkeHubClient(callInvoker);
            return new GkeHubClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GkeHub client</summary>
        public virtual GkeHub.GkeHubClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// listed. Specified in the format `projects/*/locations/*`.
        /// `projects/*/locations/-` list memberships in all the regions.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipsRequest request = new ListMembershipsRequest
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
            return ListMemberships(request, callSettings);
        }

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// listed. Specified in the format `projects/*/locations/*`.
        /// `projects/*/locations/-` list memberships in all the regions.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipsRequest request = new ListMembershipsRequest
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
            return ListMembershipsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// listed. Specified in the format `projects/*/locations/*`.
        /// `projects/*/locations/-` list memberships in all the regions.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipsRequest request = new ListMembershipsRequest
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
            return ListMemberships(request, callSettings);
        }

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// listed. Specified in the format `projects/*/locations/*`.
        /// `projects/*/locations/-` list memberships in all the regions.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipsRequest request = new ListMembershipsRequest
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
            return ListMembershipsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Memberships bound to a Scope. The response includes relevant
        /// Memberships from all regions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBoundMembershipsResponse, Membership> ListBoundMemberships(ListBoundMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Memberships bound to a Scope. The response includes relevant
        /// Memberships from all regions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBoundMembershipsResponse, Membership> ListBoundMembershipsAsync(ListBoundMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Memberships bound to a Scope. The response includes relevant
        /// Memberships from all regions.
        /// </summary>
        /// <param name="scopeName">
        /// Required. Name of the Scope, in the format
        /// `projects/*/locations/global/scopes/*`, to which the Memberships are bound.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBoundMembershipsResponse, Membership> ListBoundMemberships(string scopeName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBoundMembershipsRequest request = new ListBoundMembershipsRequest
            {
                ScopeName = gax::GaxPreconditions.CheckNotNullOrEmpty(scopeName, nameof(scopeName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBoundMemberships(request, callSettings);
        }

        /// <summary>
        /// Lists Memberships bound to a Scope. The response includes relevant
        /// Memberships from all regions.
        /// </summary>
        /// <param name="scopeName">
        /// Required. Name of the Scope, in the format
        /// `projects/*/locations/global/scopes/*`, to which the Memberships are bound.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBoundMembershipsResponse, Membership> ListBoundMembershipsAsync(string scopeName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBoundMembershipsRequest request = new ListBoundMembershipsRequest
            {
                ScopeName = gax::GaxPreconditions.CheckNotNullOrEmpty(scopeName, nameof(scopeName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBoundMembershipsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Memberships bound to a Scope. The response includes relevant
        /// Memberships from all regions.
        /// </summary>
        /// <param name="scopeName">
        /// Required. Name of the Scope, in the format
        /// `projects/*/locations/global/scopes/*`, to which the Memberships are bound.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBoundMembershipsResponse, Membership> ListBoundMemberships(ScopeName scopeName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBoundMembershipsRequest request = new ListBoundMembershipsRequest
            {
                ScopeNameAsScopeName = gax::GaxPreconditions.CheckNotNull(scopeName, nameof(scopeName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBoundMemberships(request, callSettings);
        }

        /// <summary>
        /// Lists Memberships bound to a Scope. The response includes relevant
        /// Memberships from all regions.
        /// </summary>
        /// <param name="scopeName">
        /// Required. Name of the Scope, in the format
        /// `projects/*/locations/global/scopes/*`, to which the Memberships are bound.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBoundMembershipsResponse, Membership> ListBoundMembershipsAsync(ScopeName scopeName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBoundMembershipsRequest request = new ListBoundMembershipsRequest
            {
                ScopeNameAsScopeName = gax::GaxPreconditions.CheckNotNull(scopeName, nameof(scopeName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBoundMembershipsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeatures(request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeaturesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsLocationName = parent,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeatures(request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsLocationName = parent,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeaturesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership GetMembership(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(GetMembershipRequest request, st::CancellationToken cancellationToken) =>
            GetMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership GetMembership(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembership(new GetMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipAsync(new GetMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(string name, st::CancellationToken cancellationToken) =>
            GetMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership GetMembership(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembership(new GetMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipAsync(new GetMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(MembershipName name, st::CancellationToken cancellationToken) =>
            GetMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feature GetFeature(GetFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(GetFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(GetFeatureRequest request, st::CancellationToken cancellationToken) =>
            GetFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feature GetFeature(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeature(new GetFeatureRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureAsync(new GetFeatureRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feature GetFeature(FeatureName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeature(new GetFeatureRequest { FeatureName = name, }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(FeatureName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureAsync(new GetFeatureRequest { FeatureName = name, }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(FeatureName name, st::CancellationToken cancellationToken) =>
            GetFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> CreateMembership(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(CreateMembershipRequest request, st::CancellationToken cancellationToken) =>
            CreateMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMembership</c>.</summary>
        public virtual lro::OperationsClient CreateMembershipOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> PollOnceCreateMembership(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Membership, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMembershipOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> PollOnceCreateMembershipAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Membership, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMembershipOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> CreateMembership(string parent, Membership resource, string membershipId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembership(new CreateMembershipRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MembershipId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(string parent, Membership resource, string membershipId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipAsync(new CreateMembershipRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MembershipId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(string parent, Membership resource, string membershipId, st::CancellationToken cancellationToken) =>
            CreateMembershipAsync(parent, resource, membershipId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> CreateMembership(gagr::LocationName parent, Membership resource, string membershipId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembership(new CreateMembershipRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MembershipId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(gagr::LocationName parent, Membership resource, string membershipId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipAsync(new CreateMembershipRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MembershipId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(gagr::LocationName parent, Membership resource, string membershipId, st::CancellationToken cancellationToken) =>
            CreateMembershipAsync(parent, resource, membershipId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> CreateFeature(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> CreateFeatureAsync(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> CreateFeatureAsync(CreateFeatureRequest request, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFeature</c>.</summary>
        public virtual lro::OperationsClient CreateFeatureOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> PollOnceCreateFeature(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> PollOnceCreateFeatureAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Feature will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// The Feature resource to create.
        /// </param>
        /// <param name="featureId">
        /// The ID of the feature to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> CreateFeature(string parent, Feature resource, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeature(new CreateFeatureRequest
            {
                Parent = parent ?? "",
                FeatureId = featureId ?? "",
                Resource = resource,
            }, callSettings);

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Feature will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// The Feature resource to create.
        /// </param>
        /// <param name="featureId">
        /// The ID of the feature to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> CreateFeatureAsync(string parent, Feature resource, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureAsync(new CreateFeatureRequest
            {
                Parent = parent ?? "",
                FeatureId = featureId ?? "",
                Resource = resource,
            }, callSettings);

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Feature will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// The Feature resource to create.
        /// </param>
        /// <param name="featureId">
        /// The ID of the feature to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> CreateFeatureAsync(string parent, Feature resource, string featureId, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(parent, resource, featureId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Feature will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// The Feature resource to create.
        /// </param>
        /// <param name="featureId">
        /// The ID of the feature to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> CreateFeature(gagr::LocationName parent, Feature resource, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeature(new CreateFeatureRequest
            {
                ParentAsLocationName = parent,
                FeatureId = featureId ?? "",
                Resource = resource,
            }, callSettings);

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Feature will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// The Feature resource to create.
        /// </param>
        /// <param name="featureId">
        /// The ID of the feature to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> CreateFeatureAsync(gagr::LocationName parent, Feature resource, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureAsync(new CreateFeatureRequest
            {
                ParentAsLocationName = parent,
                FeatureId = featureId ?? "",
                Resource = resource,
            }, callSettings);

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Feature will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// The Feature resource to create.
        /// </param>
        /// <param name="featureId">
        /// The ID of the feature to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> CreateFeatureAsync(gagr::LocationName parent, Feature resource, string featureId, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(parent, resource, featureId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembership(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(DeleteMembershipRequest request, st::CancellationToken cancellationToken) =>
            DeleteMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMembership</c>.</summary>
        public virtual lro::OperationsClient DeleteMembershipOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMembership(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMembershipOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMembershipAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMembershipOperationsClient, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembership(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembership(new DeleteMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipAsync(new DeleteMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembership(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembership(new DeleteMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipAsync(new DeleteMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(MembershipName name, st::CancellationToken cancellationToken) =>
            DeleteMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFeature(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFeatureAsync(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFeatureAsync(DeleteFeatureRequest request, st::CancellationToken cancellationToken) =>
            DeleteFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFeature</c>.</summary>
        public virtual lro::OperationsClient DeleteFeatureOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteFeature(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteFeatureAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureOperationsClient, callSettings);

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFeature(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeature(new DeleteFeatureRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFeatureAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureAsync(new DeleteFeatureRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFeatureAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFeature(FeatureName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeature(new DeleteFeatureRequest { FeatureName = name, }, callSettings);

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFeatureAsync(FeatureName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureAsync(new DeleteFeatureRequest { FeatureName = name, }, callSettings);

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFeatureAsync(FeatureName name, st::CancellationToken cancellationToken) =>
            DeleteFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> UpdateMembership(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(UpdateMembershipRequest request, st::CancellationToken cancellationToken) =>
            UpdateMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMembership</c>.</summary>
        public virtual lro::OperationsClient UpdateMembershipOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> PollOnceUpdateMembership(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Membership, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMembershipOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> PollOnceUpdateMembershipAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Membership, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMembershipOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> UpdateMembership(string name, Membership resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembership(new UpdateMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(string name, Membership resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembershipAsync(new UpdateMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(string name, Membership resource, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMembershipAsync(name, resource, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> UpdateMembership(MembershipName name, Membership resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembership(new UpdateMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(MembershipName name, Membership resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembershipAsync(new UpdateMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(MembershipName name, Membership resource, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMembershipAsync(name, resource, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> UpdateFeature(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> UpdateFeatureAsync(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> UpdateFeatureAsync(UpdateFeatureRequest request, st::CancellationToken cancellationToken) =>
            UpdateFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFeature</c>.</summary>
        public virtual lro::OperationsClient UpdateFeatureOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> PollOnceUpdateFeature(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> PollOnceUpdateFeatureAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="resource">
        /// Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> UpdateFeature(string name, Feature resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeature(new UpdateFeatureRequest
            {
                Name = name ?? "",
                UpdateMask = updateMask,
                Resource = resource,
            }, callSettings);

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="resource">
        /// Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> UpdateFeatureAsync(string name, Feature resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeatureAsync(new UpdateFeatureRequest
            {
                Name = name ?? "",
                UpdateMask = updateMask,
                Resource = resource,
            }, callSettings);

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="resource">
        /// Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> UpdateFeatureAsync(string name, Feature resource, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFeatureAsync(name, resource, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="resource">
        /// Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> UpdateFeature(FeatureName name, Feature resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeature(new UpdateFeatureRequest
            {
                FeatureName = name,
                UpdateMask = updateMask,
                Resource = resource,
            }, callSettings);

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="resource">
        /// Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> UpdateFeatureAsync(FeatureName name, Feature resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeatureAsync(new UpdateFeatureRequest
            {
                FeatureName = name,
                UpdateMask = updateMask,
                Resource = resource,
            }, callSettings);

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="resource">
        /// Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> UpdateFeatureAsync(FeatureName name, Feature resource, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFeatureAsync(name, resource, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateConnectManifestResponse GenerateConnectManifest(GenerateConnectManifestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConnectManifestResponse> GenerateConnectManifestAsync(GenerateConnectManifestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConnectManifestResponse> GenerateConnectManifestAsync(GenerateConnectManifestRequest request, st::CancellationToken cancellationToken) =>
            GenerateConnectManifestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Fleet, OperationMetadata> CreateFleet(CreateFleetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Fleet, OperationMetadata>> CreateFleetAsync(CreateFleetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Fleet, OperationMetadata>> CreateFleetAsync(CreateFleetRequest request, st::CancellationToken cancellationToken) =>
            CreateFleetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFleet</c>.</summary>
        public virtual lro::OperationsClient CreateFleetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateFleet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Fleet, OperationMetadata> PollOnceCreateFleet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Fleet, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFleetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFleet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Fleet, OperationMetadata>> PollOnceCreateFleetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Fleet, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFleetOperationsClient, callSettings);

        /// <summary>
        /// Creates a fleet.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Fleet will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="fleet">
        /// Required. The fleet to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Fleet, OperationMetadata> CreateFleet(string parent, Fleet fleet, gaxgrpc::CallSettings callSettings = null) =>
            CreateFleet(new CreateFleetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Fleet = gax::GaxPreconditions.CheckNotNull(fleet, nameof(fleet)),
            }, callSettings);

        /// <summary>
        /// Creates a fleet.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Fleet will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="fleet">
        /// Required. The fleet to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Fleet, OperationMetadata>> CreateFleetAsync(string parent, Fleet fleet, gaxgrpc::CallSettings callSettings = null) =>
            CreateFleetAsync(new CreateFleetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Fleet = gax::GaxPreconditions.CheckNotNull(fleet, nameof(fleet)),
            }, callSettings);

        /// <summary>
        /// Creates a fleet.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Fleet will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="fleet">
        /// Required. The fleet to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Fleet, OperationMetadata>> CreateFleetAsync(string parent, Fleet fleet, st::CancellationToken cancellationToken) =>
            CreateFleetAsync(parent, fleet, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a fleet.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Fleet will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="fleet">
        /// Required. The fleet to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Fleet, OperationMetadata> CreateFleet(gagr::LocationName parent, Fleet fleet, gaxgrpc::CallSettings callSettings = null) =>
            CreateFleet(new CreateFleetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Fleet = gax::GaxPreconditions.CheckNotNull(fleet, nameof(fleet)),
            }, callSettings);

        /// <summary>
        /// Creates a fleet.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Fleet will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="fleet">
        /// Required. The fleet to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Fleet, OperationMetadata>> CreateFleetAsync(gagr::LocationName parent, Fleet fleet, gaxgrpc::CallSettings callSettings = null) =>
            CreateFleetAsync(new CreateFleetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Fleet = gax::GaxPreconditions.CheckNotNull(fleet, nameof(fleet)),
            }, callSettings);

        /// <summary>
        /// Creates a fleet.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Fleet will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="fleet">
        /// Required. The fleet to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Fleet, OperationMetadata>> CreateFleetAsync(gagr::LocationName parent, Fleet fleet, st::CancellationToken cancellationToken) =>
            CreateFleetAsync(parent, fleet, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details of a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Fleet GetFleet(GetFleetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details of a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fleet> GetFleetAsync(GetFleetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details of a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fleet> GetFleetAsync(GetFleetRequest request, st::CancellationToken cancellationToken) =>
            GetFleetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details of a fleet.
        /// </summary>
        /// <param name="name">
        /// Required. The Fleet resource name in the format
        /// `projects/*/locations/*/fleets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Fleet GetFleet(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFleet(new GetFleetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a fleet.
        /// </summary>
        /// <param name="name">
        /// Required. The Fleet resource name in the format
        /// `projects/*/locations/*/fleets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fleet> GetFleetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFleetAsync(new GetFleetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a fleet.
        /// </summary>
        /// <param name="name">
        /// Required. The Fleet resource name in the format
        /// `projects/*/locations/*/fleets/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fleet> GetFleetAsync(string name, st::CancellationToken cancellationToken) =>
            GetFleetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details of a fleet.
        /// </summary>
        /// <param name="name">
        /// Required. The Fleet resource name in the format
        /// `projects/*/locations/*/fleets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Fleet GetFleet(FleetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFleet(new GetFleetRequest
            {
                FleetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a fleet.
        /// </summary>
        /// <param name="name">
        /// Required. The Fleet resource name in the format
        /// `projects/*/locations/*/fleets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fleet> GetFleetAsync(FleetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFleetAsync(new GetFleetRequest
            {
                FleetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a fleet.
        /// </summary>
        /// <param name="name">
        /// Required. The Fleet resource name in the format
        /// `projects/*/locations/*/fleets/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fleet> GetFleetAsync(FleetName name, st::CancellationToken cancellationToken) =>
            GetFleetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Fleet, OperationMetadata> UpdateFleet(UpdateFleetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Fleet, OperationMetadata>> UpdateFleetAsync(UpdateFleetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Fleet, OperationMetadata>> UpdateFleetAsync(UpdateFleetRequest request, st::CancellationToken cancellationToken) =>
            UpdateFleetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFleet</c>.</summary>
        public virtual lro::OperationsClient UpdateFleetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateFleet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Fleet, OperationMetadata> PollOnceUpdateFleet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Fleet, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFleetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFleet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Fleet, OperationMetadata>> PollOnceUpdateFleetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Fleet, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFleetOperationsClient, callSettings);

        /// <summary>
        /// Updates a fleet.
        /// </summary>
        /// <param name="fleet">
        /// Required. The Fleet to update.
        /// 
        /// The `name` field of the Fleet object identifies which fleet will be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated;
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Fleet, OperationMetadata> UpdateFleet(Fleet fleet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFleet(new UpdateFleetRequest
            {
                Fleet = gax::GaxPreconditions.CheckNotNull(fleet, nameof(fleet)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a fleet.
        /// </summary>
        /// <param name="fleet">
        /// Required. The Fleet to update.
        /// 
        /// The `name` field of the Fleet object identifies which fleet will be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated;
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Fleet, OperationMetadata>> UpdateFleetAsync(Fleet fleet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFleetAsync(new UpdateFleetRequest
            {
                Fleet = gax::GaxPreconditions.CheckNotNull(fleet, nameof(fleet)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a fleet.
        /// </summary>
        /// <param name="fleet">
        /// Required. The Fleet to update.
        /// 
        /// The `name` field of the Fleet object identifies which fleet will be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated;
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Fleet, OperationMetadata>> UpdateFleetAsync(Fleet fleet, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFleetAsync(fleet, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Fleet. There must be no memberships remaining in the Fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFleet(DeleteFleetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Fleet. There must be no memberships remaining in the Fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetAsync(DeleteFleetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Fleet. There must be no memberships remaining in the Fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetAsync(DeleteFleetRequest request, st::CancellationToken cancellationToken) =>
            DeleteFleetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFleet</c>.</summary>
        public virtual lro::OperationsClient DeleteFleetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFleet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteFleet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFleetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFleet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteFleetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFleetOperationsClient, callSettings);

        /// <summary>
        /// Removes a Fleet. There must be no memberships remaining in the Fleet.
        /// </summary>
        /// <param name="name">
        /// Required. The Fleet resource name in the format
        /// `projects/*/locations/*/fleets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFleet(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFleet(new DeleteFleetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Fleet. There must be no memberships remaining in the Fleet.
        /// </summary>
        /// <param name="name">
        /// Required. The Fleet resource name in the format
        /// `projects/*/locations/*/fleets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFleetAsync(new DeleteFleetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Fleet. There must be no memberships remaining in the Fleet.
        /// </summary>
        /// <param name="name">
        /// Required. The Fleet resource name in the format
        /// `projects/*/locations/*/fleets/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFleetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Fleet. There must be no memberships remaining in the Fleet.
        /// </summary>
        /// <param name="name">
        /// Required. The Fleet resource name in the format
        /// `projects/*/locations/*/fleets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFleet(FleetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFleet(new DeleteFleetRequest
            {
                FleetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Fleet. There must be no memberships remaining in the Fleet.
        /// </summary>
        /// <param name="name">
        /// Required. The Fleet resource name in the format
        /// `projects/*/locations/*/fleets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetAsync(FleetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFleetAsync(new DeleteFleetRequest
            {
                FleetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Fleet. There must be no memberships remaining in the Fleet.
        /// </summary>
        /// <param name="name">
        /// Required. The Fleet resource name in the format
        /// `projects/*/locations/*/fleets/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetAsync(FleetName name, st::CancellationToken cancellationToken) =>
            DeleteFleetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all fleets within an organization or a project that the caller has
        /// access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Fleet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFleetsResponse, Fleet> ListFleets(ListFleetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all fleets within an organization or a project that the caller has
        /// access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Fleet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFleetsResponse, Fleet> ListFleetsAsync(ListFleetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all fleets within an organization or a project that the caller has
        /// access to.
        /// </summary>
        /// <param name="parent">
        /// Required. The organization or project to list for Fleets under, in the
        /// format `organizations/*/locations/*` or `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Fleet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFleetsResponse, Fleet> ListFleets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFleetsRequest request = new ListFleetsRequest
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
            return ListFleets(request, callSettings);
        }

        /// <summary>
        /// Returns all fleets within an organization or a project that the caller has
        /// access to.
        /// </summary>
        /// <param name="parent">
        /// Required. The organization or project to list for Fleets under, in the
        /// format `organizations/*/locations/*` or `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Fleet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFleetsResponse, Fleet> ListFleetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFleetsRequest request = new ListFleetsRequest
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
            return ListFleetsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all fleets within an organization or a project that the caller has
        /// access to.
        /// </summary>
        /// <param name="parent">
        /// Required. The organization or project to list for Fleets under, in the
        /// format `organizations/*/locations/*` or `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Fleet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFleetsResponse, Fleet> ListFleets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFleetsRequest request = new ListFleetsRequest
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
            return ListFleets(request, callSettings);
        }

        /// <summary>
        /// Returns all fleets within an organization or a project that the caller has
        /// access to.
        /// </summary>
        /// <param name="parent">
        /// Required. The organization or project to list for Fleets under, in the
        /// format `organizations/*/locations/*` or `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Fleet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFleetsResponse, Fleet> ListFleetsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFleetsRequest request = new ListFleetsRequest
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
            return ListFleetsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the details of a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Namespace GetScopeNamespace(GetScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details of a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> GetScopeNamespaceAsync(GetScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details of a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> GetScopeNamespaceAsync(GetScopeNamespaceRequest request, st::CancellationToken cancellationToken) =>
            GetScopeNamespaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details of a fleet namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The Namespace resource name in the format
        /// `projects/*/locations/*/scopes/*/namespaces/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Namespace GetScopeNamespace(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScopeNamespace(new GetScopeNamespaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a fleet namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The Namespace resource name in the format
        /// `projects/*/locations/*/scopes/*/namespaces/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> GetScopeNamespaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScopeNamespaceAsync(new GetScopeNamespaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a fleet namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The Namespace resource name in the format
        /// `projects/*/locations/*/scopes/*/namespaces/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> GetScopeNamespaceAsync(string name, st::CancellationToken cancellationToken) =>
            GetScopeNamespaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details of a fleet namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The Namespace resource name in the format
        /// `projects/*/locations/*/scopes/*/namespaces/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Namespace GetScopeNamespace(NamespaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScopeNamespace(new GetScopeNamespaceRequest
            {
                NamespaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a fleet namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The Namespace resource name in the format
        /// `projects/*/locations/*/scopes/*/namespaces/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> GetScopeNamespaceAsync(NamespaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScopeNamespaceAsync(new GetScopeNamespaceRequest
            {
                NamespaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a fleet namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The Namespace resource name in the format
        /// `projects/*/locations/*/scopes/*/namespaces/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> GetScopeNamespaceAsync(NamespaceName name, st::CancellationToken cancellationToken) =>
            GetScopeNamespaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Namespace, OperationMetadata> CreateScopeNamespace(CreateScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Namespace, OperationMetadata>> CreateScopeNamespaceAsync(CreateScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Namespace, OperationMetadata>> CreateScopeNamespaceAsync(CreateScopeNamespaceRequest request, st::CancellationToken cancellationToken) =>
            CreateScopeNamespaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateScopeNamespace</c>.</summary>
        public virtual lro::OperationsClient CreateScopeNamespaceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateScopeNamespace</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Namespace, OperationMetadata> PollOnceCreateScopeNamespace(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Namespace, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateScopeNamespaceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateScopeNamespace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Namespace, OperationMetadata>> PollOnceCreateScopeNamespaceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Namespace, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateScopeNamespaceOperationsClient, callSettings);

        /// <summary>
        /// Creates a fleet namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Namespace will be
        /// created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="scopeNamespace">
        /// Required. The fleet namespace to create.
        /// </param>
        /// <param name="scopeNamespaceId">
        /// Required. Client chosen ID for the Namespace. `namespace_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Namespace, OperationMetadata> CreateScopeNamespace(string parent, Namespace scopeNamespace, string scopeNamespaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScopeNamespace(new CreateScopeNamespaceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ScopeNamespaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(scopeNamespaceId, nameof(scopeNamespaceId)),
                ScopeNamespace = gax::GaxPreconditions.CheckNotNull(scopeNamespace, nameof(scopeNamespace)),
            }, callSettings);

        /// <summary>
        /// Creates a fleet namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Namespace will be
        /// created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="scopeNamespace">
        /// Required. The fleet namespace to create.
        /// </param>
        /// <param name="scopeNamespaceId">
        /// Required. Client chosen ID for the Namespace. `namespace_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Namespace, OperationMetadata>> CreateScopeNamespaceAsync(string parent, Namespace scopeNamespace, string scopeNamespaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScopeNamespaceAsync(new CreateScopeNamespaceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ScopeNamespaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(scopeNamespaceId, nameof(scopeNamespaceId)),
                ScopeNamespace = gax::GaxPreconditions.CheckNotNull(scopeNamespace, nameof(scopeNamespace)),
            }, callSettings);

        /// <summary>
        /// Creates a fleet namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Namespace will be
        /// created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="scopeNamespace">
        /// Required. The fleet namespace to create.
        /// </param>
        /// <param name="scopeNamespaceId">
        /// Required. Client chosen ID for the Namespace. `namespace_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Namespace, OperationMetadata>> CreateScopeNamespaceAsync(string parent, Namespace scopeNamespace, string scopeNamespaceId, st::CancellationToken cancellationToken) =>
            CreateScopeNamespaceAsync(parent, scopeNamespace, scopeNamespaceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a fleet namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Namespace will be
        /// created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="scopeNamespace">
        /// Required. The fleet namespace to create.
        /// </param>
        /// <param name="scopeNamespaceId">
        /// Required. Client chosen ID for the Namespace. `namespace_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Namespace, OperationMetadata> CreateScopeNamespace(ScopeName parent, Namespace scopeNamespace, string scopeNamespaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScopeNamespace(new CreateScopeNamespaceRequest
            {
                ParentAsScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ScopeNamespaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(scopeNamespaceId, nameof(scopeNamespaceId)),
                ScopeNamespace = gax::GaxPreconditions.CheckNotNull(scopeNamespace, nameof(scopeNamespace)),
            }, callSettings);

        /// <summary>
        /// Creates a fleet namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Namespace will be
        /// created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="scopeNamespace">
        /// Required. The fleet namespace to create.
        /// </param>
        /// <param name="scopeNamespaceId">
        /// Required. Client chosen ID for the Namespace. `namespace_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Namespace, OperationMetadata>> CreateScopeNamespaceAsync(ScopeName parent, Namespace scopeNamespace, string scopeNamespaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScopeNamespaceAsync(new CreateScopeNamespaceRequest
            {
                ParentAsScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ScopeNamespaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(scopeNamespaceId, nameof(scopeNamespaceId)),
                ScopeNamespace = gax::GaxPreconditions.CheckNotNull(scopeNamespace, nameof(scopeNamespace)),
            }, callSettings);

        /// <summary>
        /// Creates a fleet namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Namespace will be
        /// created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="scopeNamespace">
        /// Required. The fleet namespace to create.
        /// </param>
        /// <param name="scopeNamespaceId">
        /// Required. Client chosen ID for the Namespace. `namespace_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Namespace, OperationMetadata>> CreateScopeNamespaceAsync(ScopeName parent, Namespace scopeNamespace, string scopeNamespaceId, st::CancellationToken cancellationToken) =>
            CreateScopeNamespaceAsync(parent, scopeNamespace, scopeNamespaceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Namespace, OperationMetadata> UpdateScopeNamespace(UpdateScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Namespace, OperationMetadata>> UpdateScopeNamespaceAsync(UpdateScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Namespace, OperationMetadata>> UpdateScopeNamespaceAsync(UpdateScopeNamespaceRequest request, st::CancellationToken cancellationToken) =>
            UpdateScopeNamespaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateScopeNamespace</c>.</summary>
        public virtual lro::OperationsClient UpdateScopeNamespaceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateScopeNamespace</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Namespace, OperationMetadata> PollOnceUpdateScopeNamespace(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Namespace, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateScopeNamespaceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateScopeNamespace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Namespace, OperationMetadata>> PollOnceUpdateScopeNamespaceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Namespace, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateScopeNamespaceOperationsClient, callSettings);

        /// <summary>
        /// Updates a fleet namespace.
        /// </summary>
        /// <param name="scopeNamespace">
        /// Required. A namespace with fields updated. The 'name' field in this
        /// namespace is used to identify the resource to update. Given 'updated'
        /// prefix to follow go/proto-best-practices-checkers#keyword_conflict
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Namespace, OperationMetadata> UpdateScopeNamespace(Namespace scopeNamespace, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateScopeNamespace(new UpdateScopeNamespaceRequest
            {
                ScopeNamespace = gax::GaxPreconditions.CheckNotNull(scopeNamespace, nameof(scopeNamespace)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a fleet namespace.
        /// </summary>
        /// <param name="scopeNamespace">
        /// Required. A namespace with fields updated. The 'name' field in this
        /// namespace is used to identify the resource to update. Given 'updated'
        /// prefix to follow go/proto-best-practices-checkers#keyword_conflict
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Namespace, OperationMetadata>> UpdateScopeNamespaceAsync(Namespace scopeNamespace, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateScopeNamespaceAsync(new UpdateScopeNamespaceRequest
            {
                ScopeNamespace = gax::GaxPreconditions.CheckNotNull(scopeNamespace, nameof(scopeNamespace)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a fleet namespace.
        /// </summary>
        /// <param name="scopeNamespace">
        /// Required. A namespace with fields updated. The 'name' field in this
        /// namespace is used to identify the resource to update. Given 'updated'
        /// prefix to follow go/proto-best-practices-checkers#keyword_conflict
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Namespace, OperationMetadata>> UpdateScopeNamespaceAsync(Namespace scopeNamespace, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateScopeNamespaceAsync(scopeNamespace, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteScopeNamespace(DeleteScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeNamespaceAsync(DeleteScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeNamespaceAsync(DeleteScopeNamespaceRequest request, st::CancellationToken cancellationToken) =>
            DeleteScopeNamespaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteScopeNamespace</c>.</summary>
        public virtual lro::OperationsClient DeleteScopeNamespaceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteScopeNamespace</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteScopeNamespace(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteScopeNamespaceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteScopeNamespace</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteScopeNamespaceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteScopeNamespaceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a fleet namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The Namespace resource name in the format
        /// `projects/*/locations/*/scopes/*/namespaces/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteScopeNamespace(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScopeNamespace(new DeleteScopeNamespaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a fleet namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The Namespace resource name in the format
        /// `projects/*/locations/*/scopes/*/namespaces/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeNamespaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScopeNamespaceAsync(new DeleteScopeNamespaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a fleet namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The Namespace resource name in the format
        /// `projects/*/locations/*/scopes/*/namespaces/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeNamespaceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteScopeNamespaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a fleet namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The Namespace resource name in the format
        /// `projects/*/locations/*/scopes/*/namespaces/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteScopeNamespace(NamespaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScopeNamespace(new DeleteScopeNamespaceRequest
            {
                NamespaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a fleet namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The Namespace resource name in the format
        /// `projects/*/locations/*/scopes/*/namespaces/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeNamespaceAsync(NamespaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScopeNamespaceAsync(new DeleteScopeNamespaceRequest
            {
                NamespaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a fleet namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The Namespace resource name in the format
        /// `projects/*/locations/*/scopes/*/namespaces/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeNamespaceAsync(NamespaceName name, st::CancellationToken cancellationToken) =>
            DeleteScopeNamespaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists fleet namespaces.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Namespace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScopeNamespacesResponse, Namespace> ListScopeNamespaces(ListScopeNamespacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists fleet namespaces.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Namespace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScopeNamespacesResponse, Namespace> ListScopeNamespacesAsync(ListScopeNamespacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists fleet namespaces.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Namespace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScopeNamespacesResponse, Namespace> ListScopeNamespaces(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopeNamespacesRequest request = new ListScopeNamespacesRequest
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
            return ListScopeNamespaces(request, callSettings);
        }

        /// <summary>
        /// Lists fleet namespaces.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Namespace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScopeNamespacesResponse, Namespace> ListScopeNamespacesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopeNamespacesRequest request = new ListScopeNamespacesRequest
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
            return ListScopeNamespacesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists fleet namespaces.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Namespace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScopeNamespacesResponse, Namespace> ListScopeNamespaces(ScopeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopeNamespacesRequest request = new ListScopeNamespacesRequest
            {
                ParentAsScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListScopeNamespaces(request, callSettings);
        }

        /// <summary>
        /// Lists fleet namespaces.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Namespace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScopeNamespacesResponse, Namespace> ListScopeNamespacesAsync(ScopeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopeNamespacesRequest request = new ListScopeNamespacesRequest
            {
                ParentAsScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListScopeNamespacesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the details of a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RBACRoleBinding GetScopeRBACRoleBinding(GetScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details of a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RBACRoleBinding> GetScopeRBACRoleBindingAsync(GetScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details of a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RBACRoleBinding> GetScopeRBACRoleBindingAsync(GetScopeRBACRoleBindingRequest request, st::CancellationToken cancellationToken) =>
            GetScopeRBACRoleBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details of a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RBACRoleBinding GetScopeRBACRoleBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScopeRBACRoleBinding(new GetScopeRBACRoleBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RBACRoleBinding> GetScopeRBACRoleBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScopeRBACRoleBindingAsync(new GetScopeRBACRoleBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RBACRoleBinding> GetScopeRBACRoleBindingAsync(string name, st::CancellationToken cancellationToken) =>
            GetScopeRBACRoleBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details of a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RBACRoleBinding GetScopeRBACRoleBinding(RBACRoleBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScopeRBACRoleBinding(new GetScopeRBACRoleBindingRequest
            {
                RBACRoleBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RBACRoleBinding> GetScopeRBACRoleBindingAsync(RBACRoleBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScopeRBACRoleBindingAsync(new GetScopeRBACRoleBindingRequest
            {
                RBACRoleBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RBACRoleBinding> GetScopeRBACRoleBindingAsync(RBACRoleBindingName name, st::CancellationToken cancellationToken) =>
            GetScopeRBACRoleBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> CreateScopeRBACRoleBinding(CreateScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateScopeRBACRoleBindingAsync(CreateScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateScopeRBACRoleBindingAsync(CreateScopeRBACRoleBindingRequest request, st::CancellationToken cancellationToken) =>
            CreateScopeRBACRoleBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateScopeRBACRoleBinding</c>.</summary>
        public virtual lro::OperationsClient CreateScopeRBACRoleBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateScopeRBACRoleBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> PollOnceCreateScopeRBACRoleBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RBACRoleBinding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateScopeRBACRoleBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateScopeRBACRoleBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> PollOnceCreateScopeRBACRoleBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RBACRoleBinding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateScopeRBACRoleBindingOperationsClient, callSettings);

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> CreateScopeRBACRoleBinding(string parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScopeRBACRoleBinding(new CreateScopeRBACRoleBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RbacrolebindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)),
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
            }, callSettings);

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateScopeRBACRoleBindingAsync(string parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScopeRBACRoleBindingAsync(new CreateScopeRBACRoleBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RbacrolebindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)),
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
            }, callSettings);

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateScopeRBACRoleBindingAsync(string parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, st::CancellationToken cancellationToken) =>
            CreateScopeRBACRoleBindingAsync(parent, rbacrolebinding, rbacrolebindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> CreateScopeRBACRoleBinding(ScopeName parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScopeRBACRoleBinding(new CreateScopeRBACRoleBindingRequest
            {
                ParentAsScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RbacrolebindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)),
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
            }, callSettings);

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateScopeRBACRoleBindingAsync(ScopeName parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScopeRBACRoleBindingAsync(new CreateScopeRBACRoleBindingRequest
            {
                ParentAsScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RbacrolebindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)),
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
            }, callSettings);

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateScopeRBACRoleBindingAsync(ScopeName parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, st::CancellationToken cancellationToken) =>
            CreateScopeRBACRoleBindingAsync(parent, rbacrolebinding, rbacrolebindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> CreateScopeRBACRoleBinding(MembershipName parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScopeRBACRoleBinding(new CreateScopeRBACRoleBindingRequest
            {
                ParentAsMembershipName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RbacrolebindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)),
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
            }, callSettings);

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateScopeRBACRoleBindingAsync(MembershipName parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScopeRBACRoleBindingAsync(new CreateScopeRBACRoleBindingRequest
            {
                ParentAsMembershipName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RbacrolebindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)),
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
            }, callSettings);

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateScopeRBACRoleBindingAsync(MembershipName parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, st::CancellationToken cancellationToken) =>
            CreateScopeRBACRoleBindingAsync(parent, rbacrolebinding, rbacrolebindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> UpdateScopeRBACRoleBinding(UpdateScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> UpdateScopeRBACRoleBindingAsync(UpdateScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> UpdateScopeRBACRoleBindingAsync(UpdateScopeRBACRoleBindingRequest request, st::CancellationToken cancellationToken) =>
            UpdateScopeRBACRoleBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateScopeRBACRoleBinding</c>.</summary>
        public virtual lro::OperationsClient UpdateScopeRBACRoleBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateScopeRBACRoleBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> PollOnceUpdateScopeRBACRoleBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RBACRoleBinding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateScopeRBACRoleBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateScopeRBACRoleBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> PollOnceUpdateScopeRBACRoleBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RBACRoleBinding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateScopeRBACRoleBindingOperationsClient, callSettings);

        /// <summary>
        /// Updates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="rbacrolebinding">
        /// Required. A rbacrolebinding with fields updated. The 'name' field in this
        /// rbacrolebinding is used to identify the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> UpdateScopeRBACRoleBinding(RBACRoleBinding rbacrolebinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateScopeRBACRoleBinding(new UpdateScopeRBACRoleBindingRequest
            {
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="rbacrolebinding">
        /// Required. A rbacrolebinding with fields updated. The 'name' field in this
        /// rbacrolebinding is used to identify the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> UpdateScopeRBACRoleBindingAsync(RBACRoleBinding rbacrolebinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateScopeRBACRoleBindingAsync(new UpdateScopeRBACRoleBindingRequest
            {
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="rbacrolebinding">
        /// Required. A rbacrolebinding with fields updated. The 'name' field in this
        /// rbacrolebinding is used to identify the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> UpdateScopeRBACRoleBindingAsync(RBACRoleBinding rbacrolebinding, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateScopeRBACRoleBindingAsync(rbacrolebinding, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteScopeRBACRoleBinding(DeleteScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeRBACRoleBindingAsync(DeleteScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeRBACRoleBindingAsync(DeleteScopeRBACRoleBindingRequest request, st::CancellationToken cancellationToken) =>
            DeleteScopeRBACRoleBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteScopeRBACRoleBinding</c>.</summary>
        public virtual lro::OperationsClient DeleteScopeRBACRoleBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteScopeRBACRoleBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteScopeRBACRoleBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteScopeRBACRoleBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteScopeRBACRoleBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteScopeRBACRoleBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteScopeRBACRoleBindingOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteScopeRBACRoleBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScopeRBACRoleBinding(new DeleteScopeRBACRoleBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeRBACRoleBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScopeRBACRoleBindingAsync(new DeleteScopeRBACRoleBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeRBACRoleBindingAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteScopeRBACRoleBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteScopeRBACRoleBinding(RBACRoleBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScopeRBACRoleBinding(new DeleteScopeRBACRoleBindingRequest
            {
                RBACRoleBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeRBACRoleBindingAsync(RBACRoleBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScopeRBACRoleBindingAsync(new DeleteScopeRBACRoleBindingRequest
            {
                RBACRoleBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeRBACRoleBindingAsync(RBACRoleBindingName name, st::CancellationToken cancellationToken) =>
            DeleteScopeRBACRoleBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all Scope RBACRoleBindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> ListScopeRBACRoleBindings(ListScopeRBACRoleBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Scope RBACRoleBindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> ListScopeRBACRoleBindingsAsync(ListScopeRBACRoleBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Scope RBACRoleBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> ListScopeRBACRoleBindings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopeRBACRoleBindingsRequest request = new ListScopeRBACRoleBindingsRequest
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
            return ListScopeRBACRoleBindings(request, callSettings);
        }

        /// <summary>
        /// Lists all Scope RBACRoleBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> ListScopeRBACRoleBindingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopeRBACRoleBindingsRequest request = new ListScopeRBACRoleBindingsRequest
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
            return ListScopeRBACRoleBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Scope RBACRoleBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> ListScopeRBACRoleBindings(ScopeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopeRBACRoleBindingsRequest request = new ListScopeRBACRoleBindingsRequest
            {
                ParentAsScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListScopeRBACRoleBindings(request, callSettings);
        }

        /// <summary>
        /// Lists all Scope RBACRoleBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> ListScopeRBACRoleBindingsAsync(ScopeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopeRBACRoleBindingsRequest request = new ListScopeRBACRoleBindingsRequest
            {
                ParentAsScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListScopeRBACRoleBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Scope RBACRoleBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> ListScopeRBACRoleBindings(MembershipName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopeRBACRoleBindingsRequest request = new ListScopeRBACRoleBindingsRequest
            {
                ParentAsMembershipName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListScopeRBACRoleBindings(request, callSettings);
        }

        /// <summary>
        /// Lists all Scope RBACRoleBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> ListScopeRBACRoleBindingsAsync(MembershipName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopeRBACRoleBindingsRequest request = new ListScopeRBACRoleBindingsRequest
            {
                ParentAsMembershipName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListScopeRBACRoleBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the details of a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Scope GetScope(GetScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details of a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> GetScopeAsync(GetScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details of a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> GetScopeAsync(GetScopeRequest request, st::CancellationToken cancellationToken) =>
            GetScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details of a Scope.
        /// </summary>
        /// <param name="name">
        /// Required. The Scope resource name in the format
        /// `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Scope GetScope(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScope(new GetScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a Scope.
        /// </summary>
        /// <param name="name">
        /// Required. The Scope resource name in the format
        /// `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> GetScopeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScopeAsync(new GetScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a Scope.
        /// </summary>
        /// <param name="name">
        /// Required. The Scope resource name in the format
        /// `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> GetScopeAsync(string name, st::CancellationToken cancellationToken) =>
            GetScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details of a Scope.
        /// </summary>
        /// <param name="name">
        /// Required. The Scope resource name in the format
        /// `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Scope GetScope(ScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScope(new GetScopeRequest
            {
                ScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a Scope.
        /// </summary>
        /// <param name="name">
        /// Required. The Scope resource name in the format
        /// `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> GetScopeAsync(ScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScopeAsync(new GetScopeRequest
            {
                ScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a Scope.
        /// </summary>
        /// <param name="name">
        /// Required. The Scope resource name in the format
        /// `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> GetScopeAsync(ScopeName name, st::CancellationToken cancellationToken) =>
            GetScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Scope, OperationMetadata> CreateScope(CreateScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Scope, OperationMetadata>> CreateScopeAsync(CreateScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Scope, OperationMetadata>> CreateScopeAsync(CreateScopeRequest request, st::CancellationToken cancellationToken) =>
            CreateScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateScope</c>.</summary>
        public virtual lro::OperationsClient CreateScopeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateScope</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Scope, OperationMetadata> PollOnceCreateScope(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Scope, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateScopeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateScope</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Scope, OperationMetadata>> PollOnceCreateScopeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Scope, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateScopeOperationsClient, callSettings);

        /// <summary>
        /// Creates a Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="scope">
        /// Required. The Scope to create.
        /// </param>
        /// <param name="scopeId">
        /// Required. Client chosen ID for the Scope. `scope_id` must be a
        /// ????
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Scope, OperationMetadata> CreateScope(string parent, Scope scope, string scopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScope(new CreateScopeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)),
                Scope = gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
            }, callSettings);

        /// <summary>
        /// Creates a Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="scope">
        /// Required. The Scope to create.
        /// </param>
        /// <param name="scopeId">
        /// Required. Client chosen ID for the Scope. `scope_id` must be a
        /// ????
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Scope, OperationMetadata>> CreateScopeAsync(string parent, Scope scope, string scopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScopeAsync(new CreateScopeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)),
                Scope = gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
            }, callSettings);

        /// <summary>
        /// Creates a Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="scope">
        /// Required. The Scope to create.
        /// </param>
        /// <param name="scopeId">
        /// Required. Client chosen ID for the Scope. `scope_id` must be a
        /// ????
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Scope, OperationMetadata>> CreateScopeAsync(string parent, Scope scope, string scopeId, st::CancellationToken cancellationToken) =>
            CreateScopeAsync(parent, scope, scopeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="scope">
        /// Required. The Scope to create.
        /// </param>
        /// <param name="scopeId">
        /// Required. Client chosen ID for the Scope. `scope_id` must be a
        /// ????
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Scope, OperationMetadata> CreateScope(gagr::LocationName parent, Scope scope, string scopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScope(new CreateScopeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)),
                Scope = gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
            }, callSettings);

        /// <summary>
        /// Creates a Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="scope">
        /// Required. The Scope to create.
        /// </param>
        /// <param name="scopeId">
        /// Required. Client chosen ID for the Scope. `scope_id` must be a
        /// ????
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Scope, OperationMetadata>> CreateScopeAsync(gagr::LocationName parent, Scope scope, string scopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScopeAsync(new CreateScopeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)),
                Scope = gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
            }, callSettings);

        /// <summary>
        /// Creates a Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="scope">
        /// Required. The Scope to create.
        /// </param>
        /// <param name="scopeId">
        /// Required. Client chosen ID for the Scope. `scope_id` must be a
        /// ????
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Scope, OperationMetadata>> CreateScopeAsync(gagr::LocationName parent, Scope scope, string scopeId, st::CancellationToken cancellationToken) =>
            CreateScopeAsync(parent, scope, scopeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Scope, OperationMetadata> UpdateScope(UpdateScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Scope, OperationMetadata>> UpdateScopeAsync(UpdateScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Scope, OperationMetadata>> UpdateScopeAsync(UpdateScopeRequest request, st::CancellationToken cancellationToken) =>
            UpdateScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateScope</c>.</summary>
        public virtual lro::OperationsClient UpdateScopeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateScope</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Scope, OperationMetadata> PollOnceUpdateScope(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Scope, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateScopeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateScope</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Scope, OperationMetadata>> PollOnceUpdateScopeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Scope, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateScopeOperationsClient, callSettings);

        /// <summary>
        /// Updates a scopes.
        /// </summary>
        /// <param name="scope">
        /// Required. A Scope with fields updated. The 'name' field in this
        /// namespace is used to identify the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Scope, OperationMetadata> UpdateScope(Scope scope, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateScope(new UpdateScopeRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a scopes.
        /// </summary>
        /// <param name="scope">
        /// Required. A Scope with fields updated. The 'name' field in this
        /// namespace is used to identify the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Scope, OperationMetadata>> UpdateScopeAsync(Scope scope, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateScopeAsync(new UpdateScopeRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a scopes.
        /// </summary>
        /// <param name="scope">
        /// Required. A Scope with fields updated. The 'name' field in this
        /// namespace is used to identify the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Scope, OperationMetadata>> UpdateScopeAsync(Scope scope, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateScopeAsync(scope, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteScope(DeleteScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeAsync(DeleteScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeAsync(DeleteScopeRequest request, st::CancellationToken cancellationToken) =>
            DeleteScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteScope</c>.</summary>
        public virtual lro::OperationsClient DeleteScopeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteScope</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteScope(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteScopeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteScope</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteScopeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteScopeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Scope.
        /// </summary>
        /// <param name="name">
        /// Required. The Scope resource name in the format
        /// `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteScope(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScope(new DeleteScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Scope.
        /// </summary>
        /// <param name="name">
        /// Required. The Scope resource name in the format
        /// `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScopeAsync(new DeleteScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Scope.
        /// </summary>
        /// <param name="name">
        /// Required. The Scope resource name in the format
        /// `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Scope.
        /// </summary>
        /// <param name="name">
        /// Required. The Scope resource name in the format
        /// `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteScope(ScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScope(new DeleteScopeRequest
            {
                ScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Scope.
        /// </summary>
        /// <param name="name">
        /// Required. The Scope resource name in the format
        /// `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeAsync(ScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScopeAsync(new DeleteScopeRequest
            {
                ScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Scope.
        /// </summary>
        /// <param name="name">
        /// Required. The Scope resource name in the format
        /// `projects/*/locations/*/scopes/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeAsync(ScopeName name, st::CancellationToken cancellationToken) =>
            DeleteScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Scope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScopesResponse, Scope> ListScopes(ListScopesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Scope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScopesResponse, Scope> ListScopesAsync(ListScopesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Scopes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Scope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScopesResponse, Scope> ListScopes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopesRequest request = new ListScopesRequest
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
            return ListScopes(request, callSettings);
        }

        /// <summary>
        /// Lists Scopes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Scope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScopesResponse, Scope> ListScopesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopesRequest request = new ListScopesRequest
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
            return ListScopesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Scopes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Scope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScopesResponse, Scope> ListScopes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopesRequest request = new ListScopesRequest
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
            return ListScopes(request, callSettings);
        }

        /// <summary>
        /// Lists Scopes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Scope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScopesResponse, Scope> ListScopesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScopesRequest request = new ListScopesRequest
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
            return ListScopesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists permitted Scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Scope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPermittedScopesResponse, Scope> ListPermittedScopes(ListPermittedScopesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists permitted Scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Scope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPermittedScopesResponse, Scope> ListPermittedScopesAsync(ListPermittedScopesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists permitted Scopes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Scope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPermittedScopesResponse, Scope> ListPermittedScopes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPermittedScopesRequest request = new ListPermittedScopesRequest
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
            return ListPermittedScopes(request, callSettings);
        }

        /// <summary>
        /// Lists permitted Scopes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Scope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPermittedScopesResponse, Scope> ListPermittedScopesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPermittedScopesRequest request = new ListPermittedScopesRequest
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
            return ListPermittedScopesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists permitted Scopes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Scope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPermittedScopesResponse, Scope> ListPermittedScopes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPermittedScopesRequest request = new ListPermittedScopesRequest
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
            return ListPermittedScopes(request, callSettings);
        }

        /// <summary>
        /// Lists permitted Scopes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Scope will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Scope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPermittedScopesResponse, Scope> ListPermittedScopesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPermittedScopesRequest request = new ListPermittedScopesRequest
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
            return ListPermittedScopesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the details of a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MembershipBinding GetMembershipBinding(GetMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details of a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MembershipBinding> GetMembershipBindingAsync(GetMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details of a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MembershipBinding> GetMembershipBindingAsync(GetMembershipBindingRequest request, st::CancellationToken cancellationToken) =>
            GetMembershipBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details of a MembershipBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The MembershipBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/bindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MembershipBinding GetMembershipBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipBinding(new GetMembershipBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a MembershipBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The MembershipBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/bindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MembershipBinding> GetMembershipBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipBindingAsync(new GetMembershipBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a MembershipBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The MembershipBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/bindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MembershipBinding> GetMembershipBindingAsync(string name, st::CancellationToken cancellationToken) =>
            GetMembershipBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details of a MembershipBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The MembershipBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/bindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MembershipBinding GetMembershipBinding(MembershipBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipBinding(new GetMembershipBindingRequest
            {
                MembershipBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a MembershipBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The MembershipBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/bindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MembershipBinding> GetMembershipBindingAsync(MembershipBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipBindingAsync(new GetMembershipBindingRequest
            {
                MembershipBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a MembershipBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The MembershipBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/bindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MembershipBinding> GetMembershipBindingAsync(MembershipBindingName name, st::CancellationToken cancellationToken) =>
            GetMembershipBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MembershipBinding, OperationMetadata> CreateMembershipBinding(CreateMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> CreateMembershipBindingAsync(CreateMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> CreateMembershipBindingAsync(CreateMembershipBindingRequest request, st::CancellationToken cancellationToken) =>
            CreateMembershipBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMembershipBinding</c>.</summary>
        public virtual lro::OperationsClient CreateMembershipBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMembershipBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MembershipBinding, OperationMetadata> PollOnceCreateMembershipBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MembershipBinding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMembershipBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMembershipBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> PollOnceCreateMembershipBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MembershipBinding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMembershipBindingOperationsClient, callSettings);

        /// <summary>
        /// Creates a MembershipBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the MembershipBinding
        /// will be created. Specified in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="membershipBinding">
        /// Required. The MembershipBinding to create.
        /// </param>
        /// <param name="membershipBindingId">
        /// Required. The ID to use for the MembershipBinding.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MembershipBinding, OperationMetadata> CreateMembershipBinding(string parent, MembershipBinding membershipBinding, string membershipBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipBinding(new CreateMembershipBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MembershipBinding = gax::GaxPreconditions.CheckNotNull(membershipBinding, nameof(membershipBinding)),
                MembershipBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipBindingId, nameof(membershipBindingId)),
            }, callSettings);

        /// <summary>
        /// Creates a MembershipBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the MembershipBinding
        /// will be created. Specified in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="membershipBinding">
        /// Required. The MembershipBinding to create.
        /// </param>
        /// <param name="membershipBindingId">
        /// Required. The ID to use for the MembershipBinding.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> CreateMembershipBindingAsync(string parent, MembershipBinding membershipBinding, string membershipBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipBindingAsync(new CreateMembershipBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MembershipBinding = gax::GaxPreconditions.CheckNotNull(membershipBinding, nameof(membershipBinding)),
                MembershipBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipBindingId, nameof(membershipBindingId)),
            }, callSettings);

        /// <summary>
        /// Creates a MembershipBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the MembershipBinding
        /// will be created. Specified in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="membershipBinding">
        /// Required. The MembershipBinding to create.
        /// </param>
        /// <param name="membershipBindingId">
        /// Required. The ID to use for the MembershipBinding.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> CreateMembershipBindingAsync(string parent, MembershipBinding membershipBinding, string membershipBindingId, st::CancellationToken cancellationToken) =>
            CreateMembershipBindingAsync(parent, membershipBinding, membershipBindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a MembershipBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the MembershipBinding
        /// will be created. Specified in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="membershipBinding">
        /// Required. The MembershipBinding to create.
        /// </param>
        /// <param name="membershipBindingId">
        /// Required. The ID to use for the MembershipBinding.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MembershipBinding, OperationMetadata> CreateMembershipBinding(MembershipName parent, MembershipBinding membershipBinding, string membershipBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipBinding(new CreateMembershipBindingRequest
            {
                ParentAsMembershipName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MembershipBinding = gax::GaxPreconditions.CheckNotNull(membershipBinding, nameof(membershipBinding)),
                MembershipBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipBindingId, nameof(membershipBindingId)),
            }, callSettings);

        /// <summary>
        /// Creates a MembershipBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the MembershipBinding
        /// will be created. Specified in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="membershipBinding">
        /// Required. The MembershipBinding to create.
        /// </param>
        /// <param name="membershipBindingId">
        /// Required. The ID to use for the MembershipBinding.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> CreateMembershipBindingAsync(MembershipName parent, MembershipBinding membershipBinding, string membershipBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipBindingAsync(new CreateMembershipBindingRequest
            {
                ParentAsMembershipName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MembershipBinding = gax::GaxPreconditions.CheckNotNull(membershipBinding, nameof(membershipBinding)),
                MembershipBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipBindingId, nameof(membershipBindingId)),
            }, callSettings);

        /// <summary>
        /// Creates a MembershipBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the MembershipBinding
        /// will be created. Specified in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="membershipBinding">
        /// Required. The MembershipBinding to create.
        /// </param>
        /// <param name="membershipBindingId">
        /// Required. The ID to use for the MembershipBinding.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> CreateMembershipBindingAsync(MembershipName parent, MembershipBinding membershipBinding, string membershipBindingId, st::CancellationToken cancellationToken) =>
            CreateMembershipBindingAsync(parent, membershipBinding, membershipBindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MembershipBinding, OperationMetadata> UpdateMembershipBinding(UpdateMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> UpdateMembershipBindingAsync(UpdateMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> UpdateMembershipBindingAsync(UpdateMembershipBindingRequest request, st::CancellationToken cancellationToken) =>
            UpdateMembershipBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMembershipBinding</c>.</summary>
        public virtual lro::OperationsClient UpdateMembershipBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMembershipBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MembershipBinding, OperationMetadata> PollOnceUpdateMembershipBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MembershipBinding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMembershipBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMembershipBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> PollOnceUpdateMembershipBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MembershipBinding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMembershipBindingOperationsClient, callSettings);

        /// <summary>
        /// Updates a MembershipBinding.
        /// </summary>
        /// <param name="membershipBinding">
        /// Required. The MembershipBinding object with fields updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MembershipBinding, OperationMetadata> UpdateMembershipBinding(MembershipBinding membershipBinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembershipBinding(new UpdateMembershipBindingRequest
            {
                MembershipBinding = gax::GaxPreconditions.CheckNotNull(membershipBinding, nameof(membershipBinding)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a MembershipBinding.
        /// </summary>
        /// <param name="membershipBinding">
        /// Required. The MembershipBinding object with fields updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> UpdateMembershipBindingAsync(MembershipBinding membershipBinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembershipBindingAsync(new UpdateMembershipBindingRequest
            {
                MembershipBinding = gax::GaxPreconditions.CheckNotNull(membershipBinding, nameof(membershipBinding)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a MembershipBinding.
        /// </summary>
        /// <param name="membershipBinding">
        /// Required. The MembershipBinding object with fields updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> UpdateMembershipBindingAsync(MembershipBinding membershipBinding, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMembershipBindingAsync(membershipBinding, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembershipBinding(DeleteMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipBindingAsync(DeleteMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipBindingAsync(DeleteMembershipBindingRequest request, st::CancellationToken cancellationToken) =>
            DeleteMembershipBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMembershipBinding</c>.</summary>
        public virtual lro::OperationsClient DeleteMembershipBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMembershipBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMembershipBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMembershipBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMembershipBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMembershipBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMembershipBindingOperationsClient, callSettings);

        /// <summary>
        /// Deletes a MembershipBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The MembershipBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/bindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembershipBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipBinding(new DeleteMembershipBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a MembershipBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The MembershipBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/bindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipBindingAsync(new DeleteMembershipBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a MembershipBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The MembershipBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/bindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipBindingAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMembershipBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a MembershipBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The MembershipBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/bindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembershipBinding(MembershipBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipBinding(new DeleteMembershipBindingRequest
            {
                MembershipBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a MembershipBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The MembershipBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/bindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipBindingAsync(MembershipBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipBindingAsync(new DeleteMembershipBindingRequest
            {
                MembershipBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a MembershipBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The MembershipBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/bindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipBindingAsync(MembershipBindingName name, st::CancellationToken cancellationToken) =>
            DeleteMembershipBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists MembershipBindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MembershipBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipBindingsResponse, MembershipBinding> ListMembershipBindings(ListMembershipBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MembershipBindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MembershipBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipBindingsResponse, MembershipBinding> ListMembershipBindingsAsync(ListMembershipBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MembershipBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Membership for which the MembershipBindings will be
        /// listed. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MembershipBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipBindingsResponse, MembershipBinding> ListMembershipBindings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipBindingsRequest request = new ListMembershipBindingsRequest
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
            return ListMembershipBindings(request, callSettings);
        }

        /// <summary>
        /// Lists MembershipBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Membership for which the MembershipBindings will be
        /// listed. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MembershipBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipBindingsResponse, MembershipBinding> ListMembershipBindingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipBindingsRequest request = new ListMembershipBindingsRequest
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
            return ListMembershipBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists MembershipBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Membership for which the MembershipBindings will be
        /// listed. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MembershipBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipBindingsResponse, MembershipBinding> ListMembershipBindings(MembershipName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipBindingsRequest request = new ListMembershipBindingsRequest
            {
                ParentAsMembershipName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMembershipBindings(request, callSettings);
        }

        /// <summary>
        /// Lists MembershipBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Membership for which the MembershipBindings will be
        /// listed. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MembershipBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipBindingsResponse, MembershipBinding> ListMembershipBindingsAsync(MembershipName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipBindingsRequest request = new ListMembershipBindingsRequest
            {
                ParentAsMembershipName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMembershipBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the details of a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RBACRoleBinding GetMembershipRBACRoleBinding(GetMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details of a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RBACRoleBinding> GetMembershipRBACRoleBindingAsync(GetMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details of a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RBACRoleBinding> GetMembershipRBACRoleBindingAsync(GetMembershipRBACRoleBindingRequest request, st::CancellationToken cancellationToken) =>
            GetMembershipRBACRoleBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details of a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RBACRoleBinding GetMembershipRBACRoleBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipRBACRoleBinding(new GetMembershipRBACRoleBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RBACRoleBinding> GetMembershipRBACRoleBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipRBACRoleBindingAsync(new GetMembershipRBACRoleBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RBACRoleBinding> GetMembershipRBACRoleBindingAsync(string name, st::CancellationToken cancellationToken) =>
            GetMembershipRBACRoleBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details of a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RBACRoleBinding GetMembershipRBACRoleBinding(RBACRoleBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipRBACRoleBinding(new GetMembershipRBACRoleBindingRequest
            {
                RBACRoleBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RBACRoleBinding> GetMembershipRBACRoleBindingAsync(RBACRoleBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipRBACRoleBindingAsync(new GetMembershipRBACRoleBindingRequest
            {
                RBACRoleBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details of a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RBACRoleBinding> GetMembershipRBACRoleBindingAsync(RBACRoleBindingName name, st::CancellationToken cancellationToken) =>
            GetMembershipRBACRoleBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> CreateMembershipRBACRoleBinding(CreateMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateMembershipRBACRoleBindingAsync(CreateMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateMembershipRBACRoleBindingAsync(CreateMembershipRBACRoleBindingRequest request, st::CancellationToken cancellationToken) =>
            CreateMembershipRBACRoleBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMembershipRBACRoleBinding</c>.</summary>
        public virtual lro::OperationsClient CreateMembershipRBACRoleBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMembershipRBACRoleBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> PollOnceCreateMembershipRBACRoleBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RBACRoleBinding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMembershipRBACRoleBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMembershipRBACRoleBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> PollOnceCreateMembershipRBACRoleBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RBACRoleBinding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMembershipRBACRoleBindingOperationsClient, callSettings);

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> CreateMembershipRBACRoleBinding(string parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipRBACRoleBinding(new CreateMembershipRBACRoleBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RbacrolebindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)),
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
            }, callSettings);

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateMembershipRBACRoleBindingAsync(string parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipRBACRoleBindingAsync(new CreateMembershipRBACRoleBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RbacrolebindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)),
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
            }, callSettings);

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateMembershipRBACRoleBindingAsync(string parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, st::CancellationToken cancellationToken) =>
            CreateMembershipRBACRoleBindingAsync(parent, rbacrolebinding, rbacrolebindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> CreateMembershipRBACRoleBinding(ScopeName parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipRBACRoleBinding(new CreateMembershipRBACRoleBindingRequest
            {
                ParentAsScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RbacrolebindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)),
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
            }, callSettings);

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateMembershipRBACRoleBindingAsync(ScopeName parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipRBACRoleBindingAsync(new CreateMembershipRBACRoleBindingRequest
            {
                ParentAsScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RbacrolebindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)),
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
            }, callSettings);

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateMembershipRBACRoleBindingAsync(ScopeName parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, st::CancellationToken cancellationToken) =>
            CreateMembershipRBACRoleBindingAsync(parent, rbacrolebinding, rbacrolebindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> CreateMembershipRBACRoleBinding(MembershipName parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipRBACRoleBinding(new CreateMembershipRBACRoleBindingRequest
            {
                ParentAsMembershipName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RbacrolebindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)),
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
            }, callSettings);

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateMembershipRBACRoleBindingAsync(MembershipName parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipRBACRoleBindingAsync(new CreateMembershipRBACRoleBindingRequest
            {
                ParentAsMembershipName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RbacrolebindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)),
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
            }, callSettings);

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the RBACRoleBinding will
        /// be created. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="rbacrolebinding">
        /// Required. The rbacrolebindings to create.
        /// </param>
        /// <param name="rbacrolebindingId">
        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id`
        /// must be a valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateMembershipRBACRoleBindingAsync(MembershipName parent, RBACRoleBinding rbacrolebinding, string rbacrolebindingId, st::CancellationToken cancellationToken) =>
            CreateMembershipRBACRoleBindingAsync(parent, rbacrolebinding, rbacrolebindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> UpdateMembershipRBACRoleBinding(UpdateMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> UpdateMembershipRBACRoleBindingAsync(UpdateMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> UpdateMembershipRBACRoleBindingAsync(UpdateMembershipRBACRoleBindingRequest request, st::CancellationToken cancellationToken) =>
            UpdateMembershipRBACRoleBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMembershipRBACRoleBinding</c>.</summary>
        public virtual lro::OperationsClient UpdateMembershipRBACRoleBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMembershipRBACRoleBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> PollOnceUpdateMembershipRBACRoleBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RBACRoleBinding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMembershipRBACRoleBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMembershipRBACRoleBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> PollOnceUpdateMembershipRBACRoleBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RBACRoleBinding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMembershipRBACRoleBindingOperationsClient, callSettings);

        /// <summary>
        /// Updates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="rbacrolebinding">
        /// Required. A rbacrolebinding with fields updated. The 'name' field in this
        /// rbacrolebinding is used to identify the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RBACRoleBinding, OperationMetadata> UpdateMembershipRBACRoleBinding(RBACRoleBinding rbacrolebinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembershipRBACRoleBinding(new UpdateMembershipRBACRoleBindingRequest
            {
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="rbacrolebinding">
        /// Required. A rbacrolebinding with fields updated. The 'name' field in this
        /// rbacrolebinding is used to identify the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> UpdateMembershipRBACRoleBindingAsync(RBACRoleBinding rbacrolebinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembershipRBACRoleBindingAsync(new UpdateMembershipRBACRoleBindingRequest
            {
                Rbacrolebinding = gax::GaxPreconditions.CheckNotNull(rbacrolebinding, nameof(rbacrolebinding)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="rbacrolebinding">
        /// Required. A rbacrolebinding with fields updated. The 'name' field in this
        /// rbacrolebinding is used to identify the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> UpdateMembershipRBACRoleBindingAsync(RBACRoleBinding rbacrolebinding, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMembershipRBACRoleBindingAsync(rbacrolebinding, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembershipRBACRoleBinding(DeleteMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipRBACRoleBindingAsync(DeleteMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipRBACRoleBindingAsync(DeleteMembershipRBACRoleBindingRequest request, st::CancellationToken cancellationToken) =>
            DeleteMembershipRBACRoleBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMembershipRBACRoleBinding</c>.</summary>
        public virtual lro::OperationsClient DeleteMembershipRBACRoleBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMembershipRBACRoleBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMembershipRBACRoleBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMembershipRBACRoleBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMembershipRBACRoleBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMembershipRBACRoleBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMembershipRBACRoleBindingOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembershipRBACRoleBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipRBACRoleBinding(new DeleteMembershipRBACRoleBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipRBACRoleBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipRBACRoleBindingAsync(new DeleteMembershipRBACRoleBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipRBACRoleBindingAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMembershipRBACRoleBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembershipRBACRoleBinding(RBACRoleBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipRBACRoleBinding(new DeleteMembershipRBACRoleBindingRequest
            {
                RBACRoleBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipRBACRoleBindingAsync(RBACRoleBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipRBACRoleBindingAsync(new DeleteMembershipRBACRoleBindingRequest
            {
                RBACRoleBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The RBACRoleBinding resource name in the format
        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipRBACRoleBindingAsync(RBACRoleBindingName name, st::CancellationToken cancellationToken) =>
            DeleteMembershipRBACRoleBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all Membership RBACRoleBindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> ListMembershipRBACRoleBindings(ListMembershipRBACRoleBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Membership RBACRoleBindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> ListMembershipRBACRoleBindingsAsync(ListMembershipRBACRoleBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Membership RBACRoleBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> ListMembershipRBACRoleBindings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipRBACRoleBindingsRequest request = new ListMembershipRBACRoleBindingsRequest
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
            return ListMembershipRBACRoleBindings(request, callSettings);
        }

        /// <summary>
        /// Lists all Membership RBACRoleBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> ListMembershipRBACRoleBindingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipRBACRoleBindingsRequest request = new ListMembershipRBACRoleBindingsRequest
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
            return ListMembershipRBACRoleBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Membership RBACRoleBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> ListMembershipRBACRoleBindings(ScopeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipRBACRoleBindingsRequest request = new ListMembershipRBACRoleBindingsRequest
            {
                ParentAsScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMembershipRBACRoleBindings(request, callSettings);
        }

        /// <summary>
        /// Lists all Membership RBACRoleBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> ListMembershipRBACRoleBindingsAsync(ScopeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipRBACRoleBindingsRequest request = new ListMembershipRBACRoleBindingsRequest
            {
                ParentAsScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMembershipRBACRoleBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Membership RBACRoleBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> ListMembershipRBACRoleBindings(MembershipName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipRBACRoleBindingsRequest request = new ListMembershipRBACRoleBindingsRequest
            {
                ParentAsMembershipName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMembershipRBACRoleBindings(request, callSettings);
        }

        /// <summary>
        /// Lists all Membership RBACRoleBindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Features will be
        /// listed. Specified in the format `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> ListMembershipRBACRoleBindingsAsync(MembershipName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipRBACRoleBindingsRequest request = new ListMembershipRBACRoleBindingsRequest
            {
                ParentAsMembershipName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMembershipRBACRoleBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Generates a YAML of the  RBAC policies for the specified
        /// RoleBinding and its associated impersonation resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateMembershipRBACRoleBindingYAMLResponse GenerateMembershipRBACRoleBindingYAML(GenerateMembershipRBACRoleBindingYAMLRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a YAML of the  RBAC policies for the specified
        /// RoleBinding and its associated impersonation resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateMembershipRBACRoleBindingYAMLResponse> GenerateMembershipRBACRoleBindingYAMLAsync(GenerateMembershipRBACRoleBindingYAMLRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a YAML of the  RBAC policies for the specified
        /// RoleBinding and its associated impersonation resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateMembershipRBACRoleBindingYAMLResponse> GenerateMembershipRBACRoleBindingYAMLAsync(GenerateMembershipRBACRoleBindingYAMLRequest request, st::CancellationToken cancellationToken) =>
            GenerateMembershipRBACRoleBindingYAMLAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GkeHub client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The GKE Hub service handles the registration of many Kubernetes clusters to
    /// Google Cloud, and the management of multi-cluster features over those
    /// clusters.
    /// 
    /// The GKE Hub service operates on the following resources:
    /// 
    /// * [Membership][google.cloud.gkehub.v1.Membership]
    /// * [Feature][google.cloud.gkehub.v1.Feature]
    /// 
    /// GKE Hub is currently available in the global region and all regions in
    /// https://cloud.google.com/compute/docs/regions-zones. Feature is only
    /// available in global region while membership is global region and all the
    /// regions.
    /// 
    /// **Membership management may be non-trivial:** it is recommended to use one
    /// of the Google-provided client libraries or tools where possible when working
    /// with Membership resources.
    /// </remarks>
    public sealed partial class GkeHubClientImpl : GkeHubClient
    {
        private readonly gaxgrpc::ApiCall<ListMembershipsRequest, ListMembershipsResponse> _callListMemberships;

        private readonly gaxgrpc::ApiCall<ListBoundMembershipsRequest, ListBoundMembershipsResponse> _callListBoundMemberships;

        private readonly gaxgrpc::ApiCall<ListFeaturesRequest, ListFeaturesResponse> _callListFeatures;

        private readonly gaxgrpc::ApiCall<GetMembershipRequest, Membership> _callGetMembership;

        private readonly gaxgrpc::ApiCall<GetFeatureRequest, Feature> _callGetFeature;

        private readonly gaxgrpc::ApiCall<CreateMembershipRequest, lro::Operation> _callCreateMembership;

        private readonly gaxgrpc::ApiCall<CreateFeatureRequest, lro::Operation> _callCreateFeature;

        private readonly gaxgrpc::ApiCall<DeleteMembershipRequest, lro::Operation> _callDeleteMembership;

        private readonly gaxgrpc::ApiCall<DeleteFeatureRequest, lro::Operation> _callDeleteFeature;

        private readonly gaxgrpc::ApiCall<UpdateMembershipRequest, lro::Operation> _callUpdateMembership;

        private readonly gaxgrpc::ApiCall<UpdateFeatureRequest, lro::Operation> _callUpdateFeature;

        private readonly gaxgrpc::ApiCall<GenerateConnectManifestRequest, GenerateConnectManifestResponse> _callGenerateConnectManifest;

        private readonly gaxgrpc::ApiCall<CreateFleetRequest, lro::Operation> _callCreateFleet;

        private readonly gaxgrpc::ApiCall<GetFleetRequest, Fleet> _callGetFleet;

        private readonly gaxgrpc::ApiCall<UpdateFleetRequest, lro::Operation> _callUpdateFleet;

        private readonly gaxgrpc::ApiCall<DeleteFleetRequest, lro::Operation> _callDeleteFleet;

        private readonly gaxgrpc::ApiCall<ListFleetsRequest, ListFleetsResponse> _callListFleets;

        private readonly gaxgrpc::ApiCall<GetScopeNamespaceRequest, Namespace> _callGetScopeNamespace;

        private readonly gaxgrpc::ApiCall<CreateScopeNamespaceRequest, lro::Operation> _callCreateScopeNamespace;

        private readonly gaxgrpc::ApiCall<UpdateScopeNamespaceRequest, lro::Operation> _callUpdateScopeNamespace;

        private readonly gaxgrpc::ApiCall<DeleteScopeNamespaceRequest, lro::Operation> _callDeleteScopeNamespace;

        private readonly gaxgrpc::ApiCall<ListScopeNamespacesRequest, ListScopeNamespacesResponse> _callListScopeNamespaces;

        private readonly gaxgrpc::ApiCall<GetScopeRBACRoleBindingRequest, RBACRoleBinding> _callGetScopeRBACRoleBinding;

        private readonly gaxgrpc::ApiCall<CreateScopeRBACRoleBindingRequest, lro::Operation> _callCreateScopeRBACRoleBinding;

        private readonly gaxgrpc::ApiCall<UpdateScopeRBACRoleBindingRequest, lro::Operation> _callUpdateScopeRBACRoleBinding;

        private readonly gaxgrpc::ApiCall<DeleteScopeRBACRoleBindingRequest, lro::Operation> _callDeleteScopeRBACRoleBinding;

        private readonly gaxgrpc::ApiCall<ListScopeRBACRoleBindingsRequest, ListScopeRBACRoleBindingsResponse> _callListScopeRBACRoleBindings;

        private readonly gaxgrpc::ApiCall<GetScopeRequest, Scope> _callGetScope;

        private readonly gaxgrpc::ApiCall<CreateScopeRequest, lro::Operation> _callCreateScope;

        private readonly gaxgrpc::ApiCall<UpdateScopeRequest, lro::Operation> _callUpdateScope;

        private readonly gaxgrpc::ApiCall<DeleteScopeRequest, lro::Operation> _callDeleteScope;

        private readonly gaxgrpc::ApiCall<ListScopesRequest, ListScopesResponse> _callListScopes;

        private readonly gaxgrpc::ApiCall<ListPermittedScopesRequest, ListPermittedScopesResponse> _callListPermittedScopes;

        private readonly gaxgrpc::ApiCall<GetMembershipBindingRequest, MembershipBinding> _callGetMembershipBinding;

        private readonly gaxgrpc::ApiCall<CreateMembershipBindingRequest, lro::Operation> _callCreateMembershipBinding;

        private readonly gaxgrpc::ApiCall<UpdateMembershipBindingRequest, lro::Operation> _callUpdateMembershipBinding;

        private readonly gaxgrpc::ApiCall<DeleteMembershipBindingRequest, lro::Operation> _callDeleteMembershipBinding;

        private readonly gaxgrpc::ApiCall<ListMembershipBindingsRequest, ListMembershipBindingsResponse> _callListMembershipBindings;

        private readonly gaxgrpc::ApiCall<GetMembershipRBACRoleBindingRequest, RBACRoleBinding> _callGetMembershipRBACRoleBinding;

        private readonly gaxgrpc::ApiCall<CreateMembershipRBACRoleBindingRequest, lro::Operation> _callCreateMembershipRBACRoleBinding;

        private readonly gaxgrpc::ApiCall<UpdateMembershipRBACRoleBindingRequest, lro::Operation> _callUpdateMembershipRBACRoleBinding;

        private readonly gaxgrpc::ApiCall<DeleteMembershipRBACRoleBindingRequest, lro::Operation> _callDeleteMembershipRBACRoleBinding;

        private readonly gaxgrpc::ApiCall<ListMembershipRBACRoleBindingsRequest, ListMembershipRBACRoleBindingsResponse> _callListMembershipRBACRoleBindings;

        private readonly gaxgrpc::ApiCall<GenerateMembershipRBACRoleBindingYAMLRequest, GenerateMembershipRBACRoleBindingYAMLResponse> _callGenerateMembershipRBACRoleBindingYAML;

        /// <summary>
        /// Constructs a client wrapper for the GkeHub service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GkeHubSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GkeHubClientImpl(GkeHub.GkeHubClient grpcClient, GkeHubSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GkeHubSettings effectiveSettings = settings ?? GkeHubSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateMembershipOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMembershipOperationsSettings, logger);
            CreateFeatureOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFeatureOperationsSettings, logger);
            DeleteMembershipOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMembershipOperationsSettings, logger);
            DeleteFeatureOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFeatureOperationsSettings, logger);
            UpdateMembershipOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMembershipOperationsSettings, logger);
            UpdateFeatureOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFeatureOperationsSettings, logger);
            CreateFleetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFleetOperationsSettings, logger);
            UpdateFleetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFleetOperationsSettings, logger);
            DeleteFleetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFleetOperationsSettings, logger);
            CreateScopeNamespaceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateScopeNamespaceOperationsSettings, logger);
            UpdateScopeNamespaceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateScopeNamespaceOperationsSettings, logger);
            DeleteScopeNamespaceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteScopeNamespaceOperationsSettings, logger);
            CreateScopeRBACRoleBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateScopeRBACRoleBindingOperationsSettings, logger);
            UpdateScopeRBACRoleBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateScopeRBACRoleBindingOperationsSettings, logger);
            DeleteScopeRBACRoleBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteScopeRBACRoleBindingOperationsSettings, logger);
            CreateScopeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateScopeOperationsSettings, logger);
            UpdateScopeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateScopeOperationsSettings, logger);
            DeleteScopeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteScopeOperationsSettings, logger);
            CreateMembershipBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMembershipBindingOperationsSettings, logger);
            UpdateMembershipBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMembershipBindingOperationsSettings, logger);
            DeleteMembershipBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMembershipBindingOperationsSettings, logger);
            CreateMembershipRBACRoleBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMembershipRBACRoleBindingOperationsSettings, logger);
            UpdateMembershipRBACRoleBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMembershipRBACRoleBindingOperationsSettings, logger);
            DeleteMembershipRBACRoleBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMembershipRBACRoleBindingOperationsSettings, logger);
            _callListMemberships = clientHelper.BuildApiCall<ListMembershipsRequest, ListMembershipsResponse>("ListMemberships", grpcClient.ListMembershipsAsync, grpcClient.ListMemberships, effectiveSettings.ListMembershipsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMemberships);
            Modify_ListMembershipsApiCall(ref _callListMemberships);
            _callListBoundMemberships = clientHelper.BuildApiCall<ListBoundMembershipsRequest, ListBoundMembershipsResponse>("ListBoundMemberships", grpcClient.ListBoundMembershipsAsync, grpcClient.ListBoundMemberships, effectiveSettings.ListBoundMembershipsSettings).WithGoogleRequestParam("scope_name", request => request.ScopeName);
            Modify_ApiCall(ref _callListBoundMemberships);
            Modify_ListBoundMembershipsApiCall(ref _callListBoundMemberships);
            _callListFeatures = clientHelper.BuildApiCall<ListFeaturesRequest, ListFeaturesResponse>("ListFeatures", grpcClient.ListFeaturesAsync, grpcClient.ListFeatures, effectiveSettings.ListFeaturesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeatures);
            Modify_ListFeaturesApiCall(ref _callListFeatures);
            _callGetMembership = clientHelper.BuildApiCall<GetMembershipRequest, Membership>("GetMembership", grpcClient.GetMembershipAsync, grpcClient.GetMembership, effectiveSettings.GetMembershipSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMembership);
            Modify_GetMembershipApiCall(ref _callGetMembership);
            _callGetFeature = clientHelper.BuildApiCall<GetFeatureRequest, Feature>("GetFeature", grpcClient.GetFeatureAsync, grpcClient.GetFeature, effectiveSettings.GetFeatureSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeature);
            Modify_GetFeatureApiCall(ref _callGetFeature);
            _callCreateMembership = clientHelper.BuildApiCall<CreateMembershipRequest, lro::Operation>("CreateMembership", grpcClient.CreateMembershipAsync, grpcClient.CreateMembership, effectiveSettings.CreateMembershipSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMembership);
            Modify_CreateMembershipApiCall(ref _callCreateMembership);
            _callCreateFeature = clientHelper.BuildApiCall<CreateFeatureRequest, lro::Operation>("CreateFeature", grpcClient.CreateFeatureAsync, grpcClient.CreateFeature, effectiveSettings.CreateFeatureSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFeature);
            Modify_CreateFeatureApiCall(ref _callCreateFeature);
            _callDeleteMembership = clientHelper.BuildApiCall<DeleteMembershipRequest, lro::Operation>("DeleteMembership", grpcClient.DeleteMembershipAsync, grpcClient.DeleteMembership, effectiveSettings.DeleteMembershipSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMembership);
            Modify_DeleteMembershipApiCall(ref _callDeleteMembership);
            _callDeleteFeature = clientHelper.BuildApiCall<DeleteFeatureRequest, lro::Operation>("DeleteFeature", grpcClient.DeleteFeatureAsync, grpcClient.DeleteFeature, effectiveSettings.DeleteFeatureSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFeature);
            Modify_DeleteFeatureApiCall(ref _callDeleteFeature);
            _callUpdateMembership = clientHelper.BuildApiCall<UpdateMembershipRequest, lro::Operation>("UpdateMembership", grpcClient.UpdateMembershipAsync, grpcClient.UpdateMembership, effectiveSettings.UpdateMembershipSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateMembership);
            Modify_UpdateMembershipApiCall(ref _callUpdateMembership);
            _callUpdateFeature = clientHelper.BuildApiCall<UpdateFeatureRequest, lro::Operation>("UpdateFeature", grpcClient.UpdateFeatureAsync, grpcClient.UpdateFeature, effectiveSettings.UpdateFeatureSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateFeature);
            Modify_UpdateFeatureApiCall(ref _callUpdateFeature);
            _callGenerateConnectManifest = clientHelper.BuildApiCall<GenerateConnectManifestRequest, GenerateConnectManifestResponse>("GenerateConnectManifest", grpcClient.GenerateConnectManifestAsync, grpcClient.GenerateConnectManifest, effectiveSettings.GenerateConnectManifestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateConnectManifest);
            Modify_GenerateConnectManifestApiCall(ref _callGenerateConnectManifest);
            _callCreateFleet = clientHelper.BuildApiCall<CreateFleetRequest, lro::Operation>("CreateFleet", grpcClient.CreateFleetAsync, grpcClient.CreateFleet, effectiveSettings.CreateFleetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFleet);
            Modify_CreateFleetApiCall(ref _callCreateFleet);
            _callGetFleet = clientHelper.BuildApiCall<GetFleetRequest, Fleet>("GetFleet", grpcClient.GetFleetAsync, grpcClient.GetFleet, effectiveSettings.GetFleetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFleet);
            Modify_GetFleetApiCall(ref _callGetFleet);
            _callUpdateFleet = clientHelper.BuildApiCall<UpdateFleetRequest, lro::Operation>("UpdateFleet", grpcClient.UpdateFleetAsync, grpcClient.UpdateFleet, effectiveSettings.UpdateFleetSettings).WithGoogleRequestParam("fleet.name", request => request.Fleet?.Name);
            Modify_ApiCall(ref _callUpdateFleet);
            Modify_UpdateFleetApiCall(ref _callUpdateFleet);
            _callDeleteFleet = clientHelper.BuildApiCall<DeleteFleetRequest, lro::Operation>("DeleteFleet", grpcClient.DeleteFleetAsync, grpcClient.DeleteFleet, effectiveSettings.DeleteFleetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFleet);
            Modify_DeleteFleetApiCall(ref _callDeleteFleet);
            _callListFleets = clientHelper.BuildApiCall<ListFleetsRequest, ListFleetsResponse>("ListFleets", grpcClient.ListFleetsAsync, grpcClient.ListFleets, effectiveSettings.ListFleetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFleets);
            Modify_ListFleetsApiCall(ref _callListFleets);
            _callGetScopeNamespace = clientHelper.BuildApiCall<GetScopeNamespaceRequest, Namespace>("GetScopeNamespace", grpcClient.GetScopeNamespaceAsync, grpcClient.GetScopeNamespace, effectiveSettings.GetScopeNamespaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetScopeNamespace);
            Modify_GetScopeNamespaceApiCall(ref _callGetScopeNamespace);
            _callCreateScopeNamespace = clientHelper.BuildApiCall<CreateScopeNamespaceRequest, lro::Operation>("CreateScopeNamespace", grpcClient.CreateScopeNamespaceAsync, grpcClient.CreateScopeNamespace, effectiveSettings.CreateScopeNamespaceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateScopeNamespace);
            Modify_CreateScopeNamespaceApiCall(ref _callCreateScopeNamespace);
            _callUpdateScopeNamespace = clientHelper.BuildApiCall<UpdateScopeNamespaceRequest, lro::Operation>("UpdateScopeNamespace", grpcClient.UpdateScopeNamespaceAsync, grpcClient.UpdateScopeNamespace, effectiveSettings.UpdateScopeNamespaceSettings).WithGoogleRequestParam("scope_namespace.name", request => request.ScopeNamespace?.Name);
            Modify_ApiCall(ref _callUpdateScopeNamespace);
            Modify_UpdateScopeNamespaceApiCall(ref _callUpdateScopeNamespace);
            _callDeleteScopeNamespace = clientHelper.BuildApiCall<DeleteScopeNamespaceRequest, lro::Operation>("DeleteScopeNamespace", grpcClient.DeleteScopeNamespaceAsync, grpcClient.DeleteScopeNamespace, effectiveSettings.DeleteScopeNamespaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteScopeNamespace);
            Modify_DeleteScopeNamespaceApiCall(ref _callDeleteScopeNamespace);
            _callListScopeNamespaces = clientHelper.BuildApiCall<ListScopeNamespacesRequest, ListScopeNamespacesResponse>("ListScopeNamespaces", grpcClient.ListScopeNamespacesAsync, grpcClient.ListScopeNamespaces, effectiveSettings.ListScopeNamespacesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListScopeNamespaces);
            Modify_ListScopeNamespacesApiCall(ref _callListScopeNamespaces);
            _callGetScopeRBACRoleBinding = clientHelper.BuildApiCall<GetScopeRBACRoleBindingRequest, RBACRoleBinding>("GetScopeRBACRoleBinding", grpcClient.GetScopeRBACRoleBindingAsync, grpcClient.GetScopeRBACRoleBinding, effectiveSettings.GetScopeRBACRoleBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetScopeRBACRoleBinding);
            Modify_GetScopeRBACRoleBindingApiCall(ref _callGetScopeRBACRoleBinding);
            _callCreateScopeRBACRoleBinding = clientHelper.BuildApiCall<CreateScopeRBACRoleBindingRequest, lro::Operation>("CreateScopeRBACRoleBinding", grpcClient.CreateScopeRBACRoleBindingAsync, grpcClient.CreateScopeRBACRoleBinding, effectiveSettings.CreateScopeRBACRoleBindingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateScopeRBACRoleBinding);
            Modify_CreateScopeRBACRoleBindingApiCall(ref _callCreateScopeRBACRoleBinding);
            _callUpdateScopeRBACRoleBinding = clientHelper.BuildApiCall<UpdateScopeRBACRoleBindingRequest, lro::Operation>("UpdateScopeRBACRoleBinding", grpcClient.UpdateScopeRBACRoleBindingAsync, grpcClient.UpdateScopeRBACRoleBinding, effectiveSettings.UpdateScopeRBACRoleBindingSettings).WithGoogleRequestParam("rbacrolebinding.name", request => request.Rbacrolebinding?.Name);
            Modify_ApiCall(ref _callUpdateScopeRBACRoleBinding);
            Modify_UpdateScopeRBACRoleBindingApiCall(ref _callUpdateScopeRBACRoleBinding);
            _callDeleteScopeRBACRoleBinding = clientHelper.BuildApiCall<DeleteScopeRBACRoleBindingRequest, lro::Operation>("DeleteScopeRBACRoleBinding", grpcClient.DeleteScopeRBACRoleBindingAsync, grpcClient.DeleteScopeRBACRoleBinding, effectiveSettings.DeleteScopeRBACRoleBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteScopeRBACRoleBinding);
            Modify_DeleteScopeRBACRoleBindingApiCall(ref _callDeleteScopeRBACRoleBinding);
            _callListScopeRBACRoleBindings = clientHelper.BuildApiCall<ListScopeRBACRoleBindingsRequest, ListScopeRBACRoleBindingsResponse>("ListScopeRBACRoleBindings", grpcClient.ListScopeRBACRoleBindingsAsync, grpcClient.ListScopeRBACRoleBindings, effectiveSettings.ListScopeRBACRoleBindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListScopeRBACRoleBindings);
            Modify_ListScopeRBACRoleBindingsApiCall(ref _callListScopeRBACRoleBindings);
            _callGetScope = clientHelper.BuildApiCall<GetScopeRequest, Scope>("GetScope", grpcClient.GetScopeAsync, grpcClient.GetScope, effectiveSettings.GetScopeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetScope);
            Modify_GetScopeApiCall(ref _callGetScope);
            _callCreateScope = clientHelper.BuildApiCall<CreateScopeRequest, lro::Operation>("CreateScope", grpcClient.CreateScopeAsync, grpcClient.CreateScope, effectiveSettings.CreateScopeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateScope);
            Modify_CreateScopeApiCall(ref _callCreateScope);
            _callUpdateScope = clientHelper.BuildApiCall<UpdateScopeRequest, lro::Operation>("UpdateScope", grpcClient.UpdateScopeAsync, grpcClient.UpdateScope, effectiveSettings.UpdateScopeSettings).WithGoogleRequestParam("scope.name", request => request.Scope?.Name);
            Modify_ApiCall(ref _callUpdateScope);
            Modify_UpdateScopeApiCall(ref _callUpdateScope);
            _callDeleteScope = clientHelper.BuildApiCall<DeleteScopeRequest, lro::Operation>("DeleteScope", grpcClient.DeleteScopeAsync, grpcClient.DeleteScope, effectiveSettings.DeleteScopeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteScope);
            Modify_DeleteScopeApiCall(ref _callDeleteScope);
            _callListScopes = clientHelper.BuildApiCall<ListScopesRequest, ListScopesResponse>("ListScopes", grpcClient.ListScopesAsync, grpcClient.ListScopes, effectiveSettings.ListScopesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListScopes);
            Modify_ListScopesApiCall(ref _callListScopes);
            _callListPermittedScopes = clientHelper.BuildApiCall<ListPermittedScopesRequest, ListPermittedScopesResponse>("ListPermittedScopes", grpcClient.ListPermittedScopesAsync, grpcClient.ListPermittedScopes, effectiveSettings.ListPermittedScopesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPermittedScopes);
            Modify_ListPermittedScopesApiCall(ref _callListPermittedScopes);
            _callGetMembershipBinding = clientHelper.BuildApiCall<GetMembershipBindingRequest, MembershipBinding>("GetMembershipBinding", grpcClient.GetMembershipBindingAsync, grpcClient.GetMembershipBinding, effectiveSettings.GetMembershipBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMembershipBinding);
            Modify_GetMembershipBindingApiCall(ref _callGetMembershipBinding);
            _callCreateMembershipBinding = clientHelper.BuildApiCall<CreateMembershipBindingRequest, lro::Operation>("CreateMembershipBinding", grpcClient.CreateMembershipBindingAsync, grpcClient.CreateMembershipBinding, effectiveSettings.CreateMembershipBindingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMembershipBinding);
            Modify_CreateMembershipBindingApiCall(ref _callCreateMembershipBinding);
            _callUpdateMembershipBinding = clientHelper.BuildApiCall<UpdateMembershipBindingRequest, lro::Operation>("UpdateMembershipBinding", grpcClient.UpdateMembershipBindingAsync, grpcClient.UpdateMembershipBinding, effectiveSettings.UpdateMembershipBindingSettings).WithGoogleRequestParam("membership_binding.name", request => request.MembershipBinding?.Name);
            Modify_ApiCall(ref _callUpdateMembershipBinding);
            Modify_UpdateMembershipBindingApiCall(ref _callUpdateMembershipBinding);
            _callDeleteMembershipBinding = clientHelper.BuildApiCall<DeleteMembershipBindingRequest, lro::Operation>("DeleteMembershipBinding", grpcClient.DeleteMembershipBindingAsync, grpcClient.DeleteMembershipBinding, effectiveSettings.DeleteMembershipBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMembershipBinding);
            Modify_DeleteMembershipBindingApiCall(ref _callDeleteMembershipBinding);
            _callListMembershipBindings = clientHelper.BuildApiCall<ListMembershipBindingsRequest, ListMembershipBindingsResponse>("ListMembershipBindings", grpcClient.ListMembershipBindingsAsync, grpcClient.ListMembershipBindings, effectiveSettings.ListMembershipBindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMembershipBindings);
            Modify_ListMembershipBindingsApiCall(ref _callListMembershipBindings);
            _callGetMembershipRBACRoleBinding = clientHelper.BuildApiCall<GetMembershipRBACRoleBindingRequest, RBACRoleBinding>("GetMembershipRBACRoleBinding", grpcClient.GetMembershipRBACRoleBindingAsync, grpcClient.GetMembershipRBACRoleBinding, effectiveSettings.GetMembershipRBACRoleBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMembershipRBACRoleBinding);
            Modify_GetMembershipRBACRoleBindingApiCall(ref _callGetMembershipRBACRoleBinding);
            _callCreateMembershipRBACRoleBinding = clientHelper.BuildApiCall<CreateMembershipRBACRoleBindingRequest, lro::Operation>("CreateMembershipRBACRoleBinding", grpcClient.CreateMembershipRBACRoleBindingAsync, grpcClient.CreateMembershipRBACRoleBinding, effectiveSettings.CreateMembershipRBACRoleBindingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMembershipRBACRoleBinding);
            Modify_CreateMembershipRBACRoleBindingApiCall(ref _callCreateMembershipRBACRoleBinding);
            _callUpdateMembershipRBACRoleBinding = clientHelper.BuildApiCall<UpdateMembershipRBACRoleBindingRequest, lro::Operation>("UpdateMembershipRBACRoleBinding", grpcClient.UpdateMembershipRBACRoleBindingAsync, grpcClient.UpdateMembershipRBACRoleBinding, effectiveSettings.UpdateMembershipRBACRoleBindingSettings).WithGoogleRequestParam("rbacrolebinding.name", request => request.Rbacrolebinding?.Name);
            Modify_ApiCall(ref _callUpdateMembershipRBACRoleBinding);
            Modify_UpdateMembershipRBACRoleBindingApiCall(ref _callUpdateMembershipRBACRoleBinding);
            _callDeleteMembershipRBACRoleBinding = clientHelper.BuildApiCall<DeleteMembershipRBACRoleBindingRequest, lro::Operation>("DeleteMembershipRBACRoleBinding", grpcClient.DeleteMembershipRBACRoleBindingAsync, grpcClient.DeleteMembershipRBACRoleBinding, effectiveSettings.DeleteMembershipRBACRoleBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMembershipRBACRoleBinding);
            Modify_DeleteMembershipRBACRoleBindingApiCall(ref _callDeleteMembershipRBACRoleBinding);
            _callListMembershipRBACRoleBindings = clientHelper.BuildApiCall<ListMembershipRBACRoleBindingsRequest, ListMembershipRBACRoleBindingsResponse>("ListMembershipRBACRoleBindings", grpcClient.ListMembershipRBACRoleBindingsAsync, grpcClient.ListMembershipRBACRoleBindings, effectiveSettings.ListMembershipRBACRoleBindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMembershipRBACRoleBindings);
            Modify_ListMembershipRBACRoleBindingsApiCall(ref _callListMembershipRBACRoleBindings);
            _callGenerateMembershipRBACRoleBindingYAML = clientHelper.BuildApiCall<GenerateMembershipRBACRoleBindingYAMLRequest, GenerateMembershipRBACRoleBindingYAMLResponse>("GenerateMembershipRBACRoleBindingYAML", grpcClient.GenerateMembershipRBACRoleBindingYAMLAsync, grpcClient.GenerateMembershipRBACRoleBindingYAML, effectiveSettings.GenerateMembershipRBACRoleBindingYAMLSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGenerateMembershipRBACRoleBindingYAML);
            Modify_GenerateMembershipRBACRoleBindingYAMLApiCall(ref _callGenerateMembershipRBACRoleBindingYAML);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListMembershipsApiCall(ref gaxgrpc::ApiCall<ListMembershipsRequest, ListMembershipsResponse> call);

        partial void Modify_ListBoundMembershipsApiCall(ref gaxgrpc::ApiCall<ListBoundMembershipsRequest, ListBoundMembershipsResponse> call);

        partial void Modify_ListFeaturesApiCall(ref gaxgrpc::ApiCall<ListFeaturesRequest, ListFeaturesResponse> call);

        partial void Modify_GetMembershipApiCall(ref gaxgrpc::ApiCall<GetMembershipRequest, Membership> call);

        partial void Modify_GetFeatureApiCall(ref gaxgrpc::ApiCall<GetFeatureRequest, Feature> call);

        partial void Modify_CreateMembershipApiCall(ref gaxgrpc::ApiCall<CreateMembershipRequest, lro::Operation> call);

        partial void Modify_CreateFeatureApiCall(ref gaxgrpc::ApiCall<CreateFeatureRequest, lro::Operation> call);

        partial void Modify_DeleteMembershipApiCall(ref gaxgrpc::ApiCall<DeleteMembershipRequest, lro::Operation> call);

        partial void Modify_DeleteFeatureApiCall(ref gaxgrpc::ApiCall<DeleteFeatureRequest, lro::Operation> call);

        partial void Modify_UpdateMembershipApiCall(ref gaxgrpc::ApiCall<UpdateMembershipRequest, lro::Operation> call);

        partial void Modify_UpdateFeatureApiCall(ref gaxgrpc::ApiCall<UpdateFeatureRequest, lro::Operation> call);

        partial void Modify_GenerateConnectManifestApiCall(ref gaxgrpc::ApiCall<GenerateConnectManifestRequest, GenerateConnectManifestResponse> call);

        partial void Modify_CreateFleetApiCall(ref gaxgrpc::ApiCall<CreateFleetRequest, lro::Operation> call);

        partial void Modify_GetFleetApiCall(ref gaxgrpc::ApiCall<GetFleetRequest, Fleet> call);

        partial void Modify_UpdateFleetApiCall(ref gaxgrpc::ApiCall<UpdateFleetRequest, lro::Operation> call);

        partial void Modify_DeleteFleetApiCall(ref gaxgrpc::ApiCall<DeleteFleetRequest, lro::Operation> call);

        partial void Modify_ListFleetsApiCall(ref gaxgrpc::ApiCall<ListFleetsRequest, ListFleetsResponse> call);

        partial void Modify_GetScopeNamespaceApiCall(ref gaxgrpc::ApiCall<GetScopeNamespaceRequest, Namespace> call);

        partial void Modify_CreateScopeNamespaceApiCall(ref gaxgrpc::ApiCall<CreateScopeNamespaceRequest, lro::Operation> call);

        partial void Modify_UpdateScopeNamespaceApiCall(ref gaxgrpc::ApiCall<UpdateScopeNamespaceRequest, lro::Operation> call);

        partial void Modify_DeleteScopeNamespaceApiCall(ref gaxgrpc::ApiCall<DeleteScopeNamespaceRequest, lro::Operation> call);

        partial void Modify_ListScopeNamespacesApiCall(ref gaxgrpc::ApiCall<ListScopeNamespacesRequest, ListScopeNamespacesResponse> call);

        partial void Modify_GetScopeRBACRoleBindingApiCall(ref gaxgrpc::ApiCall<GetScopeRBACRoleBindingRequest, RBACRoleBinding> call);

        partial void Modify_CreateScopeRBACRoleBindingApiCall(ref gaxgrpc::ApiCall<CreateScopeRBACRoleBindingRequest, lro::Operation> call);

        partial void Modify_UpdateScopeRBACRoleBindingApiCall(ref gaxgrpc::ApiCall<UpdateScopeRBACRoleBindingRequest, lro::Operation> call);

        partial void Modify_DeleteScopeRBACRoleBindingApiCall(ref gaxgrpc::ApiCall<DeleteScopeRBACRoleBindingRequest, lro::Operation> call);

        partial void Modify_ListScopeRBACRoleBindingsApiCall(ref gaxgrpc::ApiCall<ListScopeRBACRoleBindingsRequest, ListScopeRBACRoleBindingsResponse> call);

        partial void Modify_GetScopeApiCall(ref gaxgrpc::ApiCall<GetScopeRequest, Scope> call);

        partial void Modify_CreateScopeApiCall(ref gaxgrpc::ApiCall<CreateScopeRequest, lro::Operation> call);

        partial void Modify_UpdateScopeApiCall(ref gaxgrpc::ApiCall<UpdateScopeRequest, lro::Operation> call);

        partial void Modify_DeleteScopeApiCall(ref gaxgrpc::ApiCall<DeleteScopeRequest, lro::Operation> call);

        partial void Modify_ListScopesApiCall(ref gaxgrpc::ApiCall<ListScopesRequest, ListScopesResponse> call);

        partial void Modify_ListPermittedScopesApiCall(ref gaxgrpc::ApiCall<ListPermittedScopesRequest, ListPermittedScopesResponse> call);

        partial void Modify_GetMembershipBindingApiCall(ref gaxgrpc::ApiCall<GetMembershipBindingRequest, MembershipBinding> call);

        partial void Modify_CreateMembershipBindingApiCall(ref gaxgrpc::ApiCall<CreateMembershipBindingRequest, lro::Operation> call);

        partial void Modify_UpdateMembershipBindingApiCall(ref gaxgrpc::ApiCall<UpdateMembershipBindingRequest, lro::Operation> call);

        partial void Modify_DeleteMembershipBindingApiCall(ref gaxgrpc::ApiCall<DeleteMembershipBindingRequest, lro::Operation> call);

        partial void Modify_ListMembershipBindingsApiCall(ref gaxgrpc::ApiCall<ListMembershipBindingsRequest, ListMembershipBindingsResponse> call);

        partial void Modify_GetMembershipRBACRoleBindingApiCall(ref gaxgrpc::ApiCall<GetMembershipRBACRoleBindingRequest, RBACRoleBinding> call);

        partial void Modify_CreateMembershipRBACRoleBindingApiCall(ref gaxgrpc::ApiCall<CreateMembershipRBACRoleBindingRequest, lro::Operation> call);

        partial void Modify_UpdateMembershipRBACRoleBindingApiCall(ref gaxgrpc::ApiCall<UpdateMembershipRBACRoleBindingRequest, lro::Operation> call);

        partial void Modify_DeleteMembershipRBACRoleBindingApiCall(ref gaxgrpc::ApiCall<DeleteMembershipRBACRoleBindingRequest, lro::Operation> call);

        partial void Modify_ListMembershipRBACRoleBindingsApiCall(ref gaxgrpc::ApiCall<ListMembershipRBACRoleBindingsRequest, ListMembershipRBACRoleBindingsResponse> call);

        partial void Modify_GenerateMembershipRBACRoleBindingYAMLApiCall(ref gaxgrpc::ApiCall<GenerateMembershipRBACRoleBindingYAMLRequest, GenerateMembershipRBACRoleBindingYAMLResponse> call);

        partial void OnConstruction(GkeHub.GkeHubClient grpcClient, GkeHubSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GkeHub client</summary>
        public override GkeHub.GkeHubClient GrpcClient { get; }

        partial void Modify_ListMembershipsRequest(ref ListMembershipsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBoundMembershipsRequest(ref ListBoundMembershipsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeaturesRequest(ref ListFeaturesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMembershipRequest(ref GetMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeatureRequest(ref GetFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMembershipRequest(ref CreateMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFeatureRequest(ref CreateFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMembershipRequest(ref DeleteMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFeatureRequest(ref DeleteFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMembershipRequest(ref UpdateMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFeatureRequest(ref UpdateFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateConnectManifestRequest(ref GenerateConnectManifestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFleetRequest(ref CreateFleetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFleetRequest(ref GetFleetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFleetRequest(ref UpdateFleetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFleetRequest(ref DeleteFleetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFleetsRequest(ref ListFleetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetScopeNamespaceRequest(ref GetScopeNamespaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateScopeNamespaceRequest(ref CreateScopeNamespaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateScopeNamespaceRequest(ref UpdateScopeNamespaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteScopeNamespaceRequest(ref DeleteScopeNamespaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListScopeNamespacesRequest(ref ListScopeNamespacesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetScopeRBACRoleBindingRequest(ref GetScopeRBACRoleBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateScopeRBACRoleBindingRequest(ref CreateScopeRBACRoleBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateScopeRBACRoleBindingRequest(ref UpdateScopeRBACRoleBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteScopeRBACRoleBindingRequest(ref DeleteScopeRBACRoleBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListScopeRBACRoleBindingsRequest(ref ListScopeRBACRoleBindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetScopeRequest(ref GetScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateScopeRequest(ref CreateScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateScopeRequest(ref UpdateScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteScopeRequest(ref DeleteScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListScopesRequest(ref ListScopesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPermittedScopesRequest(ref ListPermittedScopesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMembershipBindingRequest(ref GetMembershipBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMembershipBindingRequest(ref CreateMembershipBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMembershipBindingRequest(ref UpdateMembershipBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMembershipBindingRequest(ref DeleteMembershipBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMembershipBindingsRequest(ref ListMembershipBindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMembershipRBACRoleBindingRequest(ref GetMembershipRBACRoleBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMembershipRBACRoleBindingRequest(ref CreateMembershipRBACRoleBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMembershipRBACRoleBindingRequest(ref UpdateMembershipRBACRoleBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMembershipRBACRoleBindingRequest(ref DeleteMembershipRBACRoleBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMembershipRBACRoleBindingsRequest(ref ListMembershipRBACRoleBindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateMembershipRBACRoleBindingYAMLRequest(ref GenerateMembershipRBACRoleBindingYAMLRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public override gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMembershipsRequest, ListMembershipsResponse, Membership>(_callListMemberships, request, callSettings);
        }

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMembershipsRequest, ListMembershipsResponse, Membership>(_callListMemberships, request, callSettings);
        }

        /// <summary>
        /// Lists Memberships bound to a Scope. The response includes relevant
        /// Memberships from all regions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public override gax::PagedEnumerable<ListBoundMembershipsResponse, Membership> ListBoundMemberships(ListBoundMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBoundMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBoundMembershipsRequest, ListBoundMembershipsResponse, Membership>(_callListBoundMemberships, request, callSettings);
        }

        /// <summary>
        /// Lists Memberships bound to a Scope. The response includes relevant
        /// Memberships from all regions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBoundMembershipsResponse, Membership> ListBoundMembershipsAsync(ListBoundMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBoundMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBoundMembershipsRequest, ListBoundMembershipsResponse, Membership>(_callListBoundMemberships, request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public override gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeaturesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFeaturesRequest, ListFeaturesResponse, Feature>(_callListFeatures, request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeaturesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFeaturesRequest, ListFeaturesResponse, Feature>(_callListFeatures, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Membership GetMembership(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMembershipRequest(ref request, ref callSettings);
            return _callGetMembership.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Membership> GetMembershipAsync(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMembershipRequest(ref request, ref callSettings);
            return _callGetMembership.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Feature GetFeature(GetFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureRequest(ref request, ref callSettings);
            return _callGetFeature.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Feature> GetFeatureAsync(GetFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureRequest(ref request, ref callSettings);
            return _callGetFeature.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMembership</c>.</summary>
        public override lro::OperationsClient CreateMembershipOperationsClient { get; }

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Membership, OperationMetadata> CreateMembership(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<Membership, OperationMetadata>(_callCreateMembership.Sync(request, callSettings), CreateMembershipOperationsClient);
        }

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<Membership, OperationMetadata>(await _callCreateMembership.Async(request, callSettings).ConfigureAwait(false), CreateMembershipOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateFeature</c>.</summary>
        public override lro::OperationsClient CreateFeatureOperationsClient { get; }

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Feature, OperationMetadata> CreateFeature(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, OperationMetadata>(_callCreateFeature.Sync(request, callSettings), CreateFeatureOperationsClient);
        }

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Feature, OperationMetadata>> CreateFeatureAsync(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, OperationMetadata>(await _callCreateFeature.Async(request, callSettings).ConfigureAwait(false), CreateFeatureOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMembership</c>.</summary>
        public override lro::OperationsClient DeleteMembershipOperationsClient { get; }

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMembership(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMembership.Sync(request, callSettings), DeleteMembershipOperationsClient);
        }

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMembership.Async(request, callSettings).ConfigureAwait(false), DeleteMembershipOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFeature</c>.</summary>
        public override lro::OperationsClient DeleteFeatureOperationsClient { get; }

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteFeature(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteFeature.Sync(request, callSettings), DeleteFeatureOperationsClient);
        }

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFeatureAsync(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteFeature.Async(request, callSettings).ConfigureAwait(false), DeleteFeatureOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMembership</c>.</summary>
        public override lro::OperationsClient UpdateMembershipOperationsClient { get; }

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Membership, OperationMetadata> UpdateMembership(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<Membership, OperationMetadata>(_callUpdateMembership.Sync(request, callSettings), UpdateMembershipOperationsClient);
        }

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<Membership, OperationMetadata>(await _callUpdateMembership.Async(request, callSettings).ConfigureAwait(false), UpdateMembershipOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateFeature</c>.</summary>
        public override lro::OperationsClient UpdateFeatureOperationsClient { get; }

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Feature, OperationMetadata> UpdateFeature(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, OperationMetadata>(_callUpdateFeature.Sync(request, callSettings), UpdateFeatureOperationsClient);
        }

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Feature, OperationMetadata>> UpdateFeatureAsync(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, OperationMetadata>(await _callUpdateFeature.Async(request, callSettings).ConfigureAwait(false), UpdateFeatureOperationsClient);
        }

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateConnectManifestResponse GenerateConnectManifest(GenerateConnectManifestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateConnectManifestRequest(ref request, ref callSettings);
            return _callGenerateConnectManifest.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateConnectManifestResponse> GenerateConnectManifestAsync(GenerateConnectManifestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateConnectManifestRequest(ref request, ref callSettings);
            return _callGenerateConnectManifest.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateFleet</c>.</summary>
        public override lro::OperationsClient CreateFleetOperationsClient { get; }

        /// <summary>
        /// Creates a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Fleet, OperationMetadata> CreateFleet(CreateFleetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFleetRequest(ref request, ref callSettings);
            return new lro::Operation<Fleet, OperationMetadata>(_callCreateFleet.Sync(request, callSettings), CreateFleetOperationsClient);
        }

        /// <summary>
        /// Creates a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Fleet, OperationMetadata>> CreateFleetAsync(CreateFleetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFleetRequest(ref request, ref callSettings);
            return new lro::Operation<Fleet, OperationMetadata>(await _callCreateFleet.Async(request, callSettings).ConfigureAwait(false), CreateFleetOperationsClient);
        }

        /// <summary>
        /// Returns the details of a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Fleet GetFleet(GetFleetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFleetRequest(ref request, ref callSettings);
            return _callGetFleet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the details of a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Fleet> GetFleetAsync(GetFleetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFleetRequest(ref request, ref callSettings);
            return _callGetFleet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateFleet</c>.</summary>
        public override lro::OperationsClient UpdateFleetOperationsClient { get; }

        /// <summary>
        /// Updates a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Fleet, OperationMetadata> UpdateFleet(UpdateFleetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFleetRequest(ref request, ref callSettings);
            return new lro::Operation<Fleet, OperationMetadata>(_callUpdateFleet.Sync(request, callSettings), UpdateFleetOperationsClient);
        }

        /// <summary>
        /// Updates a fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Fleet, OperationMetadata>> UpdateFleetAsync(UpdateFleetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFleetRequest(ref request, ref callSettings);
            return new lro::Operation<Fleet, OperationMetadata>(await _callUpdateFleet.Async(request, callSettings).ConfigureAwait(false), UpdateFleetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFleet</c>.</summary>
        public override lro::OperationsClient DeleteFleetOperationsClient { get; }

        /// <summary>
        /// Removes a Fleet. There must be no memberships remaining in the Fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteFleet(DeleteFleetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFleetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteFleet.Sync(request, callSettings), DeleteFleetOperationsClient);
        }

        /// <summary>
        /// Removes a Fleet. There must be no memberships remaining in the Fleet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetAsync(DeleteFleetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFleetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteFleet.Async(request, callSettings).ConfigureAwait(false), DeleteFleetOperationsClient);
        }

        /// <summary>
        /// Returns all fleets within an organization or a project that the caller has
        /// access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Fleet"/> resources.</returns>
        public override gax::PagedEnumerable<ListFleetsResponse, Fleet> ListFleets(ListFleetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFleetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFleetsRequest, ListFleetsResponse, Fleet>(_callListFleets, request, callSettings);
        }

        /// <summary>
        /// Returns all fleets within an organization or a project that the caller has
        /// access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Fleet"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFleetsResponse, Fleet> ListFleetsAsync(ListFleetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFleetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFleetsRequest, ListFleetsResponse, Fleet>(_callListFleets, request, callSettings);
        }

        /// <summary>
        /// Returns the details of a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Namespace GetScopeNamespace(GetScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScopeNamespaceRequest(ref request, ref callSettings);
            return _callGetScopeNamespace.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the details of a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Namespace> GetScopeNamespaceAsync(GetScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScopeNamespaceRequest(ref request, ref callSettings);
            return _callGetScopeNamespace.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateScopeNamespace</c>.</summary>
        public override lro::OperationsClient CreateScopeNamespaceOperationsClient { get; }

        /// <summary>
        /// Creates a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Namespace, OperationMetadata> CreateScopeNamespace(CreateScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScopeNamespaceRequest(ref request, ref callSettings);
            return new lro::Operation<Namespace, OperationMetadata>(_callCreateScopeNamespace.Sync(request, callSettings), CreateScopeNamespaceOperationsClient);
        }

        /// <summary>
        /// Creates a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Namespace, OperationMetadata>> CreateScopeNamespaceAsync(CreateScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScopeNamespaceRequest(ref request, ref callSettings);
            return new lro::Operation<Namespace, OperationMetadata>(await _callCreateScopeNamespace.Async(request, callSettings).ConfigureAwait(false), CreateScopeNamespaceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateScopeNamespace</c>.</summary>
        public override lro::OperationsClient UpdateScopeNamespaceOperationsClient { get; }

        /// <summary>
        /// Updates a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Namespace, OperationMetadata> UpdateScopeNamespace(UpdateScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScopeNamespaceRequest(ref request, ref callSettings);
            return new lro::Operation<Namespace, OperationMetadata>(_callUpdateScopeNamespace.Sync(request, callSettings), UpdateScopeNamespaceOperationsClient);
        }

        /// <summary>
        /// Updates a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Namespace, OperationMetadata>> UpdateScopeNamespaceAsync(UpdateScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScopeNamespaceRequest(ref request, ref callSettings);
            return new lro::Operation<Namespace, OperationMetadata>(await _callUpdateScopeNamespace.Async(request, callSettings).ConfigureAwait(false), UpdateScopeNamespaceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteScopeNamespace</c>.</summary>
        public override lro::OperationsClient DeleteScopeNamespaceOperationsClient { get; }

        /// <summary>
        /// Deletes a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteScopeNamespace(DeleteScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScopeNamespaceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteScopeNamespace.Sync(request, callSettings), DeleteScopeNamespaceOperationsClient);
        }

        /// <summary>
        /// Deletes a fleet namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeNamespaceAsync(DeleteScopeNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScopeNamespaceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteScopeNamespace.Async(request, callSettings).ConfigureAwait(false), DeleteScopeNamespaceOperationsClient);
        }

        /// <summary>
        /// Lists fleet namespaces.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Namespace"/> resources.</returns>
        public override gax::PagedEnumerable<ListScopeNamespacesResponse, Namespace> ListScopeNamespaces(ListScopeNamespacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScopeNamespacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListScopeNamespacesRequest, ListScopeNamespacesResponse, Namespace>(_callListScopeNamespaces, request, callSettings);
        }

        /// <summary>
        /// Lists fleet namespaces.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Namespace"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListScopeNamespacesResponse, Namespace> ListScopeNamespacesAsync(ListScopeNamespacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScopeNamespacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListScopeNamespacesRequest, ListScopeNamespacesResponse, Namespace>(_callListScopeNamespaces, request, callSettings);
        }

        /// <summary>
        /// Returns the details of a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RBACRoleBinding GetScopeRBACRoleBinding(GetScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScopeRBACRoleBindingRequest(ref request, ref callSettings);
            return _callGetScopeRBACRoleBinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the details of a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RBACRoleBinding> GetScopeRBACRoleBindingAsync(GetScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScopeRBACRoleBindingRequest(ref request, ref callSettings);
            return _callGetScopeRBACRoleBinding.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateScopeRBACRoleBinding</c>.</summary>
        public override lro::OperationsClient CreateScopeRBACRoleBindingOperationsClient { get; }

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RBACRoleBinding, OperationMetadata> CreateScopeRBACRoleBinding(CreateScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScopeRBACRoleBindingRequest(ref request, ref callSettings);
            return new lro::Operation<RBACRoleBinding, OperationMetadata>(_callCreateScopeRBACRoleBinding.Sync(request, callSettings), CreateScopeRBACRoleBindingOperationsClient);
        }

        /// <summary>
        /// Creates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateScopeRBACRoleBindingAsync(CreateScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScopeRBACRoleBindingRequest(ref request, ref callSettings);
            return new lro::Operation<RBACRoleBinding, OperationMetadata>(await _callCreateScopeRBACRoleBinding.Async(request, callSettings).ConfigureAwait(false), CreateScopeRBACRoleBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateScopeRBACRoleBinding</c>.</summary>
        public override lro::OperationsClient UpdateScopeRBACRoleBindingOperationsClient { get; }

        /// <summary>
        /// Updates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RBACRoleBinding, OperationMetadata> UpdateScopeRBACRoleBinding(UpdateScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScopeRBACRoleBindingRequest(ref request, ref callSettings);
            return new lro::Operation<RBACRoleBinding, OperationMetadata>(_callUpdateScopeRBACRoleBinding.Sync(request, callSettings), UpdateScopeRBACRoleBindingOperationsClient);
        }

        /// <summary>
        /// Updates a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> UpdateScopeRBACRoleBindingAsync(UpdateScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScopeRBACRoleBindingRequest(ref request, ref callSettings);
            return new lro::Operation<RBACRoleBinding, OperationMetadata>(await _callUpdateScopeRBACRoleBinding.Async(request, callSettings).ConfigureAwait(false), UpdateScopeRBACRoleBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteScopeRBACRoleBinding</c>.</summary>
        public override lro::OperationsClient DeleteScopeRBACRoleBindingOperationsClient { get; }

        /// <summary>
        /// Deletes a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteScopeRBACRoleBinding(DeleteScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScopeRBACRoleBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteScopeRBACRoleBinding.Sync(request, callSettings), DeleteScopeRBACRoleBindingOperationsClient);
        }

        /// <summary>
        /// Deletes a Scope RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeRBACRoleBindingAsync(DeleteScopeRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScopeRBACRoleBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteScopeRBACRoleBinding.Async(request, callSettings).ConfigureAwait(false), DeleteScopeRBACRoleBindingOperationsClient);
        }

        /// <summary>
        /// Lists all Scope RBACRoleBindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public override gax::PagedEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> ListScopeRBACRoleBindings(ListScopeRBACRoleBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScopeRBACRoleBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListScopeRBACRoleBindingsRequest, ListScopeRBACRoleBindingsResponse, RBACRoleBinding>(_callListScopeRBACRoleBindings, request, callSettings);
        }

        /// <summary>
        /// Lists all Scope RBACRoleBindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> ListScopeRBACRoleBindingsAsync(ListScopeRBACRoleBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScopeRBACRoleBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListScopeRBACRoleBindingsRequest, ListScopeRBACRoleBindingsResponse, RBACRoleBinding>(_callListScopeRBACRoleBindings, request, callSettings);
        }

        /// <summary>
        /// Returns the details of a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Scope GetScope(GetScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScopeRequest(ref request, ref callSettings);
            return _callGetScope.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the details of a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Scope> GetScopeAsync(GetScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScopeRequest(ref request, ref callSettings);
            return _callGetScope.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateScope</c>.</summary>
        public override lro::OperationsClient CreateScopeOperationsClient { get; }

        /// <summary>
        /// Creates a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Scope, OperationMetadata> CreateScope(CreateScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScopeRequest(ref request, ref callSettings);
            return new lro::Operation<Scope, OperationMetadata>(_callCreateScope.Sync(request, callSettings), CreateScopeOperationsClient);
        }

        /// <summary>
        /// Creates a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Scope, OperationMetadata>> CreateScopeAsync(CreateScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScopeRequest(ref request, ref callSettings);
            return new lro::Operation<Scope, OperationMetadata>(await _callCreateScope.Async(request, callSettings).ConfigureAwait(false), CreateScopeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateScope</c>.</summary>
        public override lro::OperationsClient UpdateScopeOperationsClient { get; }

        /// <summary>
        /// Updates a scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Scope, OperationMetadata> UpdateScope(UpdateScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScopeRequest(ref request, ref callSettings);
            return new lro::Operation<Scope, OperationMetadata>(_callUpdateScope.Sync(request, callSettings), UpdateScopeOperationsClient);
        }

        /// <summary>
        /// Updates a scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Scope, OperationMetadata>> UpdateScopeAsync(UpdateScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScopeRequest(ref request, ref callSettings);
            return new lro::Operation<Scope, OperationMetadata>(await _callUpdateScope.Async(request, callSettings).ConfigureAwait(false), UpdateScopeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteScope</c>.</summary>
        public override lro::OperationsClient DeleteScopeOperationsClient { get; }

        /// <summary>
        /// Deletes a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteScope(DeleteScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScopeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteScope.Sync(request, callSettings), DeleteScopeOperationsClient);
        }

        /// <summary>
        /// Deletes a Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScopeAsync(DeleteScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScopeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteScope.Async(request, callSettings).ConfigureAwait(false), DeleteScopeOperationsClient);
        }

        /// <summary>
        /// Lists Scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Scope"/> resources.</returns>
        public override gax::PagedEnumerable<ListScopesResponse, Scope> ListScopes(ListScopesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScopesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListScopesRequest, ListScopesResponse, Scope>(_callListScopes, request, callSettings);
        }

        /// <summary>
        /// Lists Scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Scope"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListScopesResponse, Scope> ListScopesAsync(ListScopesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScopesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListScopesRequest, ListScopesResponse, Scope>(_callListScopes, request, callSettings);
        }

        /// <summary>
        /// Lists permitted Scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Scope"/> resources.</returns>
        public override gax::PagedEnumerable<ListPermittedScopesResponse, Scope> ListPermittedScopes(ListPermittedScopesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPermittedScopesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPermittedScopesRequest, ListPermittedScopesResponse, Scope>(_callListPermittedScopes, request, callSettings);
        }

        /// <summary>
        /// Lists permitted Scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Scope"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPermittedScopesResponse, Scope> ListPermittedScopesAsync(ListPermittedScopesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPermittedScopesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPermittedScopesRequest, ListPermittedScopesResponse, Scope>(_callListPermittedScopes, request, callSettings);
        }

        /// <summary>
        /// Returns the details of a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MembershipBinding GetMembershipBinding(GetMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMembershipBindingRequest(ref request, ref callSettings);
            return _callGetMembershipBinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the details of a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MembershipBinding> GetMembershipBindingAsync(GetMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMembershipBindingRequest(ref request, ref callSettings);
            return _callGetMembershipBinding.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMembershipBinding</c>.</summary>
        public override lro::OperationsClient CreateMembershipBindingOperationsClient { get; }

        /// <summary>
        /// Creates a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MembershipBinding, OperationMetadata> CreateMembershipBinding(CreateMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMembershipBindingRequest(ref request, ref callSettings);
            return new lro::Operation<MembershipBinding, OperationMetadata>(_callCreateMembershipBinding.Sync(request, callSettings), CreateMembershipBindingOperationsClient);
        }

        /// <summary>
        /// Creates a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> CreateMembershipBindingAsync(CreateMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMembershipBindingRequest(ref request, ref callSettings);
            return new lro::Operation<MembershipBinding, OperationMetadata>(await _callCreateMembershipBinding.Async(request, callSettings).ConfigureAwait(false), CreateMembershipBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMembershipBinding</c>.</summary>
        public override lro::OperationsClient UpdateMembershipBindingOperationsClient { get; }

        /// <summary>
        /// Updates a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MembershipBinding, OperationMetadata> UpdateMembershipBinding(UpdateMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMembershipBindingRequest(ref request, ref callSettings);
            return new lro::Operation<MembershipBinding, OperationMetadata>(_callUpdateMembershipBinding.Sync(request, callSettings), UpdateMembershipBindingOperationsClient);
        }

        /// <summary>
        /// Updates a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MembershipBinding, OperationMetadata>> UpdateMembershipBindingAsync(UpdateMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMembershipBindingRequest(ref request, ref callSettings);
            return new lro::Operation<MembershipBinding, OperationMetadata>(await _callUpdateMembershipBinding.Async(request, callSettings).ConfigureAwait(false), UpdateMembershipBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMembershipBinding</c>.</summary>
        public override lro::OperationsClient DeleteMembershipBindingOperationsClient { get; }

        /// <summary>
        /// Deletes a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMembershipBinding(DeleteMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMembershipBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMembershipBinding.Sync(request, callSettings), DeleteMembershipBindingOperationsClient);
        }

        /// <summary>
        /// Deletes a MembershipBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipBindingAsync(DeleteMembershipBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMembershipBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMembershipBinding.Async(request, callSettings).ConfigureAwait(false), DeleteMembershipBindingOperationsClient);
        }

        /// <summary>
        /// Lists MembershipBindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MembershipBinding"/> resources.</returns>
        public override gax::PagedEnumerable<ListMembershipBindingsResponse, MembershipBinding> ListMembershipBindings(ListMembershipBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembershipBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMembershipBindingsRequest, ListMembershipBindingsResponse, MembershipBinding>(_callListMembershipBindings, request, callSettings);
        }

        /// <summary>
        /// Lists MembershipBindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MembershipBinding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMembershipBindingsResponse, MembershipBinding> ListMembershipBindingsAsync(ListMembershipBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembershipBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMembershipBindingsRequest, ListMembershipBindingsResponse, MembershipBinding>(_callListMembershipBindings, request, callSettings);
        }

        /// <summary>
        /// Returns the details of a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RBACRoleBinding GetMembershipRBACRoleBinding(GetMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMembershipRBACRoleBindingRequest(ref request, ref callSettings);
            return _callGetMembershipRBACRoleBinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the details of a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RBACRoleBinding> GetMembershipRBACRoleBindingAsync(GetMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMembershipRBACRoleBindingRequest(ref request, ref callSettings);
            return _callGetMembershipRBACRoleBinding.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMembershipRBACRoleBinding</c>.</summary>
        public override lro::OperationsClient CreateMembershipRBACRoleBindingOperationsClient { get; }

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RBACRoleBinding, OperationMetadata> CreateMembershipRBACRoleBinding(CreateMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMembershipRBACRoleBindingRequest(ref request, ref callSettings);
            return new lro::Operation<RBACRoleBinding, OperationMetadata>(_callCreateMembershipRBACRoleBinding.Sync(request, callSettings), CreateMembershipRBACRoleBindingOperationsClient);
        }

        /// <summary>
        /// Creates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> CreateMembershipRBACRoleBindingAsync(CreateMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMembershipRBACRoleBindingRequest(ref request, ref callSettings);
            return new lro::Operation<RBACRoleBinding, OperationMetadata>(await _callCreateMembershipRBACRoleBinding.Async(request, callSettings).ConfigureAwait(false), CreateMembershipRBACRoleBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMembershipRBACRoleBinding</c>.</summary>
        public override lro::OperationsClient UpdateMembershipRBACRoleBindingOperationsClient { get; }

        /// <summary>
        /// Updates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RBACRoleBinding, OperationMetadata> UpdateMembershipRBACRoleBinding(UpdateMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMembershipRBACRoleBindingRequest(ref request, ref callSettings);
            return new lro::Operation<RBACRoleBinding, OperationMetadata>(_callUpdateMembershipRBACRoleBinding.Sync(request, callSettings), UpdateMembershipRBACRoleBindingOperationsClient);
        }

        /// <summary>
        /// Updates a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RBACRoleBinding, OperationMetadata>> UpdateMembershipRBACRoleBindingAsync(UpdateMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMembershipRBACRoleBindingRequest(ref request, ref callSettings);
            return new lro::Operation<RBACRoleBinding, OperationMetadata>(await _callUpdateMembershipRBACRoleBinding.Async(request, callSettings).ConfigureAwait(false), UpdateMembershipRBACRoleBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMembershipRBACRoleBinding</c>.</summary>
        public override lro::OperationsClient DeleteMembershipRBACRoleBindingOperationsClient { get; }

        /// <summary>
        /// Deletes a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMembershipRBACRoleBinding(DeleteMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMembershipRBACRoleBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMembershipRBACRoleBinding.Sync(request, callSettings), DeleteMembershipRBACRoleBindingOperationsClient);
        }

        /// <summary>
        /// Deletes a Membership RBACRoleBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipRBACRoleBindingAsync(DeleteMembershipRBACRoleBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMembershipRBACRoleBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMembershipRBACRoleBinding.Async(request, callSettings).ConfigureAwait(false), DeleteMembershipRBACRoleBindingOperationsClient);
        }

        /// <summary>
        /// Lists all Membership RBACRoleBindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public override gax::PagedEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> ListMembershipRBACRoleBindings(ListMembershipRBACRoleBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembershipRBACRoleBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMembershipRBACRoleBindingsRequest, ListMembershipRBACRoleBindingsResponse, RBACRoleBinding>(_callListMembershipRBACRoleBindings, request, callSettings);
        }

        /// <summary>
        /// Lists all Membership RBACRoleBindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RBACRoleBinding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> ListMembershipRBACRoleBindingsAsync(ListMembershipRBACRoleBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembershipRBACRoleBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMembershipRBACRoleBindingsRequest, ListMembershipRBACRoleBindingsResponse, RBACRoleBinding>(_callListMembershipRBACRoleBindings, request, callSettings);
        }

        /// <summary>
        /// Generates a YAML of the  RBAC policies for the specified
        /// RoleBinding and its associated impersonation resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateMembershipRBACRoleBindingYAMLResponse GenerateMembershipRBACRoleBindingYAML(GenerateMembershipRBACRoleBindingYAMLRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateMembershipRBACRoleBindingYAMLRequest(ref request, ref callSettings);
            return _callGenerateMembershipRBACRoleBindingYAML.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a YAML of the  RBAC policies for the specified
        /// RoleBinding and its associated impersonation resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateMembershipRBACRoleBindingYAMLResponse> GenerateMembershipRBACRoleBindingYAMLAsync(GenerateMembershipRBACRoleBindingYAMLRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateMembershipRBACRoleBindingYAMLRequest(ref request, ref callSettings);
            return _callGenerateMembershipRBACRoleBindingYAML.Async(request, callSettings);
        }
    }

    public partial class ListMembershipsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBoundMembershipsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeaturesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFleetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListScopeNamespacesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListScopeRBACRoleBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListScopesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPermittedScopesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMembershipBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMembershipRBACRoleBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMembershipsResponse : gaxgrpc::IPageResponse<Membership>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Membership> GetEnumerator() => Resources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBoundMembershipsResponse : gaxgrpc::IPageResponse<Membership>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Membership> GetEnumerator() => Memberships.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFeaturesResponse : gaxgrpc::IPageResponse<Feature>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Feature> GetEnumerator() => Resources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFleetsResponse : gaxgrpc::IPageResponse<Fleet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Fleet> GetEnumerator() => Fleets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListScopeNamespacesResponse : gaxgrpc::IPageResponse<Namespace>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Namespace> GetEnumerator() => ScopeNamespaces.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListScopeRBACRoleBindingsResponse : gaxgrpc::IPageResponse<RBACRoleBinding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RBACRoleBinding> GetEnumerator() => Rbacrolebindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListScopesResponse : gaxgrpc::IPageResponse<Scope>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Scope> GetEnumerator() => Scopes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPermittedScopesResponse : gaxgrpc::IPageResponse<Scope>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Scope> GetEnumerator() => Scopes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMembershipBindingsResponse : gaxgrpc::IPageResponse<MembershipBinding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MembershipBinding> GetEnumerator() => MembershipBindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMembershipRBACRoleBindingsResponse : gaxgrpc::IPageResponse<RBACRoleBinding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RBACRoleBinding> GetEnumerator() => Rbacrolebindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class GkeHub
    {
        public partial class GkeHubClient
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
