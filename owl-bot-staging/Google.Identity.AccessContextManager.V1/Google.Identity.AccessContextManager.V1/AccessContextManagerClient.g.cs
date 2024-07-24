// Copyright 2024 Google LLC
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

namespace Google.Identity.AccessContextManager.V1
{
    /// <summary>Settings for <see cref="AccessContextManagerClient"/> instances.</summary>
    public sealed partial class AccessContextManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccessContextManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccessContextManagerSettings"/>.</returns>
        public static AccessContextManagerSettings GetDefault() => new AccessContextManagerSettings();

        /// <summary>Constructs a new <see cref="AccessContextManagerSettings"/> object with default settings.</summary>
        public AccessContextManagerSettings()
        {
        }

        private AccessContextManagerSettings(AccessContextManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAccessPoliciesSettings = existing.ListAccessPoliciesSettings;
            GetAccessPolicySettings = existing.GetAccessPolicySettings;
            CreateAccessPolicySettings = existing.CreateAccessPolicySettings;
            CreateAccessPolicyOperationsSettings = existing.CreateAccessPolicyOperationsSettings.Clone();
            UpdateAccessPolicySettings = existing.UpdateAccessPolicySettings;
            UpdateAccessPolicyOperationsSettings = existing.UpdateAccessPolicyOperationsSettings.Clone();
            DeleteAccessPolicySettings = existing.DeleteAccessPolicySettings;
            DeleteAccessPolicyOperationsSettings = existing.DeleteAccessPolicyOperationsSettings.Clone();
            ListAccessLevelsSettings = existing.ListAccessLevelsSettings;
            GetAccessLevelSettings = existing.GetAccessLevelSettings;
            CreateAccessLevelSettings = existing.CreateAccessLevelSettings;
            CreateAccessLevelOperationsSettings = existing.CreateAccessLevelOperationsSettings.Clone();
            UpdateAccessLevelSettings = existing.UpdateAccessLevelSettings;
            UpdateAccessLevelOperationsSettings = existing.UpdateAccessLevelOperationsSettings.Clone();
            DeleteAccessLevelSettings = existing.DeleteAccessLevelSettings;
            DeleteAccessLevelOperationsSettings = existing.DeleteAccessLevelOperationsSettings.Clone();
            ReplaceAccessLevelsSettings = existing.ReplaceAccessLevelsSettings;
            ReplaceAccessLevelsOperationsSettings = existing.ReplaceAccessLevelsOperationsSettings.Clone();
            ListServicePerimetersSettings = existing.ListServicePerimetersSettings;
            GetServicePerimeterSettings = existing.GetServicePerimeterSettings;
            CreateServicePerimeterSettings = existing.CreateServicePerimeterSettings;
            CreateServicePerimeterOperationsSettings = existing.CreateServicePerimeterOperationsSettings.Clone();
            UpdateServicePerimeterSettings = existing.UpdateServicePerimeterSettings;
            UpdateServicePerimeterOperationsSettings = existing.UpdateServicePerimeterOperationsSettings.Clone();
            DeleteServicePerimeterSettings = existing.DeleteServicePerimeterSettings;
            DeleteServicePerimeterOperationsSettings = existing.DeleteServicePerimeterOperationsSettings.Clone();
            ReplaceServicePerimetersSettings = existing.ReplaceServicePerimetersSettings;
            ReplaceServicePerimetersOperationsSettings = existing.ReplaceServicePerimetersOperationsSettings.Clone();
            CommitServicePerimetersSettings = existing.CommitServicePerimetersSettings;
            CommitServicePerimetersOperationsSettings = existing.CommitServicePerimetersOperationsSettings.Clone();
            ListGcpUserAccessBindingsSettings = existing.ListGcpUserAccessBindingsSettings;
            GetGcpUserAccessBindingSettings = existing.GetGcpUserAccessBindingSettings;
            CreateGcpUserAccessBindingSettings = existing.CreateGcpUserAccessBindingSettings;
            CreateGcpUserAccessBindingOperationsSettings = existing.CreateGcpUserAccessBindingOperationsSettings.Clone();
            UpdateGcpUserAccessBindingSettings = existing.UpdateGcpUserAccessBindingSettings;
            UpdateGcpUserAccessBindingOperationsSettings = existing.UpdateGcpUserAccessBindingOperationsSettings.Clone();
            DeleteGcpUserAccessBindingSettings = existing.DeleteGcpUserAccessBindingSettings;
            DeleteGcpUserAccessBindingOperationsSettings = existing.DeleteGcpUserAccessBindingOperationsSettings.Clone();
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccessContextManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.ListAccessPolicies</c> and
        /// <c>AccessContextManagerClient.ListAccessPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAccessPoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.GetAccessPolicy</c> and <c>AccessContextManagerClient.GetAccessPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAccessPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.CreateAccessPolicy</c> and
        /// <c>AccessContextManagerClient.CreateAccessPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAccessPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.CreateAccessPolicy</c> and
        /// <c>AccessContextManagerClient.CreateAccessPolicyAsync</c>.
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
        public lro::OperationsSettings CreateAccessPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.UpdateAccessPolicy</c> and
        /// <c>AccessContextManagerClient.UpdateAccessPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAccessPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.UpdateAccessPolicy</c> and
        /// <c>AccessContextManagerClient.UpdateAccessPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateAccessPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.DeleteAccessPolicy</c> and
        /// <c>AccessContextManagerClient.DeleteAccessPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAccessPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.DeleteAccessPolicy</c> and
        /// <c>AccessContextManagerClient.DeleteAccessPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteAccessPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.ListAccessLevels</c> and <c>AccessContextManagerClient.ListAccessLevelsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAccessLevelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.GetAccessLevel</c> and <c>AccessContextManagerClient.GetAccessLevelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAccessLevelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.CreateAccessLevel</c> and <c>AccessContextManagerClient.CreateAccessLevelAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAccessLevelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.CreateAccessLevel</c> and
        /// <c>AccessContextManagerClient.CreateAccessLevelAsync</c>.
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
        public lro::OperationsSettings CreateAccessLevelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.UpdateAccessLevel</c> and <c>AccessContextManagerClient.UpdateAccessLevelAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAccessLevelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.UpdateAccessLevel</c> and
        /// <c>AccessContextManagerClient.UpdateAccessLevelAsync</c>.
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
        public lro::OperationsSettings UpdateAccessLevelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.DeleteAccessLevel</c> and <c>AccessContextManagerClient.DeleteAccessLevelAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAccessLevelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.DeleteAccessLevel</c> and
        /// <c>AccessContextManagerClient.DeleteAccessLevelAsync</c>.
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
        public lro::OperationsSettings DeleteAccessLevelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.ReplaceAccessLevels</c> and
        /// <c>AccessContextManagerClient.ReplaceAccessLevelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReplaceAccessLevelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.ReplaceAccessLevels</c> and
        /// <c>AccessContextManagerClient.ReplaceAccessLevelsAsync</c>.
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
        public lro::OperationsSettings ReplaceAccessLevelsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.ListServicePerimeters</c> and
        /// <c>AccessContextManagerClient.ListServicePerimetersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServicePerimetersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.GetServicePerimeter</c> and
        /// <c>AccessContextManagerClient.GetServicePerimeterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServicePerimeterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.CreateServicePerimeter</c> and
        /// <c>AccessContextManagerClient.CreateServicePerimeterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServicePerimeterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.CreateServicePerimeter</c> and
        /// <c>AccessContextManagerClient.CreateServicePerimeterAsync</c>.
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
        public lro::OperationsSettings CreateServicePerimeterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.UpdateServicePerimeter</c> and
        /// <c>AccessContextManagerClient.UpdateServicePerimeterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServicePerimeterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.UpdateServicePerimeter</c> and
        /// <c>AccessContextManagerClient.UpdateServicePerimeterAsync</c>.
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
        public lro::OperationsSettings UpdateServicePerimeterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.DeleteServicePerimeter</c> and
        /// <c>AccessContextManagerClient.DeleteServicePerimeterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServicePerimeterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.DeleteServicePerimeter</c> and
        /// <c>AccessContextManagerClient.DeleteServicePerimeterAsync</c>.
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
        public lro::OperationsSettings DeleteServicePerimeterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.ReplaceServicePerimeters</c> and
        /// <c>AccessContextManagerClient.ReplaceServicePerimetersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReplaceServicePerimetersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.ReplaceServicePerimeters</c> and
        /// <c>AccessContextManagerClient.ReplaceServicePerimetersAsync</c>.
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
        public lro::OperationsSettings ReplaceServicePerimetersOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.CommitServicePerimeters</c> and
        /// <c>AccessContextManagerClient.CommitServicePerimetersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CommitServicePerimetersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.CommitServicePerimeters</c> and
        /// <c>AccessContextManagerClient.CommitServicePerimetersAsync</c>.
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
        public lro::OperationsSettings CommitServicePerimetersOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.ListGcpUserAccessBindings</c> and
        /// <c>AccessContextManagerClient.ListGcpUserAccessBindingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGcpUserAccessBindingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.GetGcpUserAccessBinding</c> and
        /// <c>AccessContextManagerClient.GetGcpUserAccessBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGcpUserAccessBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.CreateGcpUserAccessBinding</c> and
        /// <c>AccessContextManagerClient.CreateGcpUserAccessBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGcpUserAccessBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.CreateGcpUserAccessBinding</c>
        /// and <c>AccessContextManagerClient.CreateGcpUserAccessBindingAsync</c>.
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
        public lro::OperationsSettings CreateGcpUserAccessBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.UpdateGcpUserAccessBinding</c> and
        /// <c>AccessContextManagerClient.UpdateGcpUserAccessBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGcpUserAccessBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.UpdateGcpUserAccessBinding</c>
        /// and <c>AccessContextManagerClient.UpdateGcpUserAccessBindingAsync</c>.
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
        public lro::OperationsSettings UpdateGcpUserAccessBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.DeleteGcpUserAccessBinding</c> and
        /// <c>AccessContextManagerClient.DeleteGcpUserAccessBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGcpUserAccessBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessContextManagerClient.DeleteGcpUserAccessBinding</c>
        /// and <c>AccessContextManagerClient.DeleteGcpUserAccessBindingAsync</c>.
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
        public lro::OperationsSettings DeleteGcpUserAccessBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.SetIamPolicy</c> and <c>AccessContextManagerClient.SetIamPolicyAsync</c>.
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
        /// <c>AccessContextManagerClient.GetIamPolicy</c> and <c>AccessContextManagerClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessContextManagerClient.TestIamPermissions</c> and
        /// <c>AccessContextManagerClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccessContextManagerSettings"/> object.</returns>
        public AccessContextManagerSettings Clone() => new AccessContextManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccessContextManagerClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AccessContextManagerClientBuilder : gaxgrpc::ClientBuilderBase<AccessContextManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccessContextManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AccessContextManagerClientBuilder() : base(AccessContextManagerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AccessContextManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccessContextManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccessContextManagerClient Build()
        {
            AccessContextManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccessContextManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccessContextManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccessContextManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccessContextManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AccessContextManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccessContextManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccessContextManagerClient.ChannelPool;
    }

    /// <summary>AccessContextManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// API for setting [access levels]
    /// [google.identity.accesscontextmanager.v1.AccessLevel] and [service
    /// perimeters] [google.identity.accesscontextmanager.v1.ServicePerimeter]
    /// for Google Cloud projects. Each organization has one [access policy]
    /// [google.identity.accesscontextmanager.v1.AccessPolicy] that contains the
    /// [access levels] [google.identity.accesscontextmanager.v1.AccessLevel]
    /// and [service perimeters]
    /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. This
    /// [access policy] [google.identity.accesscontextmanager.v1.AccessPolicy] is
    /// applicable to all resources in the organization.
    /// AccessPolicies
    /// </remarks>
    public abstract partial class AccessContextManagerClient
    {
        /// <summary>
        /// The default endpoint for the AccessContextManager service, which is a host of
        /// "accesscontextmanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "accesscontextmanager.googleapis.com:443";

        /// <summary>The default AccessContextManager scopes.</summary>
        /// <remarks>
        /// The default AccessContextManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AccessContextManager.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AccessContextManagerClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AccessContextManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccessContextManagerClient"/>.</returns>
        public static stt::Task<AccessContextManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccessContextManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccessContextManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AccessContextManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AccessContextManagerClient"/>.</returns>
        public static AccessContextManagerClient Create() => new AccessContextManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccessContextManagerClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccessContextManagerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AccessContextManagerClient"/>.</returns>
        internal static AccessContextManagerClient Create(grpccore::CallInvoker callInvoker, AccessContextManagerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccessContextManager.AccessContextManagerClient grpcClient = new AccessContextManager.AccessContextManagerClient(callInvoker);
            return new AccessContextManagerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AccessContextManager client</summary>
        public virtual AccessContextManager.AccessContextManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [access policies]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] in an
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccessPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPolicies(ListAccessPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [access policies]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] in an
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccessPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPoliciesAsync(ListAccessPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessPolicy GetAccessPolicy(GetAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessPolicy> GetAccessPolicyAsync(GetAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessPolicy> GetAccessPolicyAsync(GetAccessPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAccessPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to get.
        /// 
        /// Format `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessPolicy GetAccessPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessPolicy(new GetAccessPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to get.
        /// 
        /// Format `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessPolicy> GetAccessPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessPolicyAsync(new GetAccessPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to get.
        /// 
        /// Format `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessPolicy> GetAccessPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetAccessPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to get.
        /// 
        /// Format `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessPolicy GetAccessPolicy(AccessPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessPolicy(new GetAccessPolicyRequest
            {
                AccessPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to get.
        /// 
        /// Format `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessPolicy> GetAccessPolicyAsync(AccessPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessPolicyAsync(new GetAccessPolicyRequest
            {
                AccessPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to get.
        /// 
        /// Format `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessPolicy> GetAccessPolicyAsync(AccessPolicyName name, st::CancellationToken cancellationToken) =>
            GetAccessPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an access policy. This method fails if the organization already has
        /// an access policy. The long-running operation has a successful status
        /// after the access policy propagates to long-lasting storage.
        /// Syntactic and basic semantic errors are returned in `metadata` as a
        /// BadRequest proto.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata> CreateAccessPolicy(AccessPolicy request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an access policy. This method fails if the organization already has
        /// an access policy. The long-running operation has a successful status
        /// after the access policy propagates to long-lasting storage.
        /// Syntactic and basic semantic errors are returned in `metadata` as a
        /// BadRequest proto.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>> CreateAccessPolicyAsync(AccessPolicy request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an access policy. This method fails if the organization already has
        /// an access policy. The long-running operation has a successful status
        /// after the access policy propagates to long-lasting storage.
        /// Syntactic and basic semantic errors are returned in `metadata` as a
        /// BadRequest proto.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>> CreateAccessPolicyAsync(AccessPolicy request, st::CancellationToken cancellationToken) =>
            CreateAccessPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAccessPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateAccessPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAccessPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata> PollOnceCreateAccessPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAccessPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAccessPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>> PollOnceCreateAccessPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAccessPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy]. The
        /// long-running operation from this RPC has a successful status after the
        /// changes to the [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] propagate
        /// to long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata> UpdateAccessPolicy(UpdateAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy]. The
        /// long-running operation from this RPC has a successful status after the
        /// changes to the [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] propagate
        /// to long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>> UpdateAccessPolicyAsync(UpdateAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy]. The
        /// long-running operation from this RPC has a successful status after the
        /// changes to the [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] propagate
        /// to long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>> UpdateAccessPolicyAsync(UpdateAccessPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateAccessPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAccessPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateAccessPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAccessPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata> PollOnceUpdateAccessPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAccessPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAccessPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>> PollOnceUpdateAccessPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAccessPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy]. The
        /// long-running operation from this RPC has a successful status after the
        /// changes to the [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] propagate
        /// to long-lasting storage.
        /// </summary>
        /// <param name="policy">
        /// Required. The updated AccessPolicy.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask to control which fields get updated. Must be non-empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata> UpdateAccessPolicy(AccessPolicy policy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccessPolicy(new UpdateAccessPolicyRequest
            {
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy]. The
        /// long-running operation from this RPC has a successful status after the
        /// changes to the [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] propagate
        /// to long-lasting storage.
        /// </summary>
        /// <param name="policy">
        /// Required. The updated AccessPolicy.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask to control which fields get updated. Must be non-empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>> UpdateAccessPolicyAsync(AccessPolicy policy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccessPolicyAsync(new UpdateAccessPolicyRequest
            {
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy]. The
        /// long-running operation from this RPC has a successful status after the
        /// changes to the [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] propagate
        /// to long-lasting storage.
        /// </summary>
        /// <param name="policy">
        /// Required. The updated AccessPolicy.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask to control which fields get updated. Must be non-empty.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>> UpdateAccessPolicyAsync(AccessPolicy policy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAccessPolicyAsync(policy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the
        /// resource name. The long-running operation has a successful status after the
        /// [access policy] [google.identity.accesscontextmanager.v1.AccessPolicy]
        /// is removed from long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> DeleteAccessPolicy(DeleteAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the
        /// resource name. The long-running operation has a successful status after the
        /// [access policy] [google.identity.accesscontextmanager.v1.AccessPolicy]
        /// is removed from long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessPolicyAsync(DeleteAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the
        /// resource name. The long-running operation has a successful status after the
        /// [access policy] [google.identity.accesscontextmanager.v1.AccessPolicy]
        /// is removed from long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessPolicyAsync(DeleteAccessPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAccessPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAccessPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteAccessPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAccessPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> PollOnceDeleteAccessPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAccessPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAccessPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> PollOnceDeleteAccessPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAccessPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the
        /// resource name. The long-running operation has a successful status after the
        /// [access policy] [google.identity.accesscontextmanager.v1.AccessPolicy]
        /// is removed from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to delete.
        /// 
        /// Format `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> DeleteAccessPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessPolicy(new DeleteAccessPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the
        /// resource name. The long-running operation has a successful status after the
        /// [access policy] [google.identity.accesscontextmanager.v1.AccessPolicy]
        /// is removed from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to delete.
        /// 
        /// Format `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessPolicyAsync(new DeleteAccessPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the
        /// resource name. The long-running operation has a successful status after the
        /// [access policy] [google.identity.accesscontextmanager.v1.AccessPolicy]
        /// is removed from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to delete.
        /// 
        /// Format `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAccessPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the
        /// resource name. The long-running operation has a successful status after the
        /// [access policy] [google.identity.accesscontextmanager.v1.AccessPolicy]
        /// is removed from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to delete.
        /// 
        /// Format `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> DeleteAccessPolicy(AccessPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessPolicy(new DeleteAccessPolicyRequest
            {
                AccessPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the
        /// resource name. The long-running operation has a successful status after the
        /// [access policy] [google.identity.accesscontextmanager.v1.AccessPolicy]
        /// is removed from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to delete.
        /// 
        /// Format `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessPolicyAsync(AccessPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessPolicyAsync(new DeleteAccessPolicyRequest
            {
                AccessPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the
        /// resource name. The long-running operation has a successful status after the
        /// [access policy] [google.identity.accesscontextmanager.v1.AccessPolicy]
        /// is removed from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to delete.
        /// 
        /// Format `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessPolicyAsync(AccessPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteAccessPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] for an access
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccessLevel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccessLevelsResponse, AccessLevel> ListAccessLevels(ListAccessLevelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] for an access
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccessLevel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccessLevelsResponse, AccessLevel> ListAccessLevelsAsync(ListAccessLevelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] for an access
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy to list [Access Levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] from.
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccessLevel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccessLevelsResponse, AccessLevel> ListAccessLevels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessLevelsRequest request = new ListAccessLevelsRequest
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
            return ListAccessLevels(request, callSettings);
        }

        /// <summary>
        /// Lists all [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] for an access
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy to list [Access Levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] from.
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccessLevel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccessLevelsResponse, AccessLevel> ListAccessLevelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessLevelsRequest request = new ListAccessLevelsRequest
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
            return ListAccessLevelsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] for an access
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy to list [Access Levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] from.
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccessLevel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccessLevelsResponse, AccessLevel> ListAccessLevels(AccessPolicyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessLevelsRequest request = new ListAccessLevelsRequest
            {
                ParentAsAccessPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAccessLevels(request, callSettings);
        }

        /// <summary>
        /// Lists all [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] for an access
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy to list [Access Levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] from.
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccessLevel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccessLevelsResponse, AccessLevel> ListAccessLevelsAsync(AccessPolicyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessLevelsRequest request = new ListAccessLevelsRequest
            {
                ParentAsAccessPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAccessLevelsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessLevel GetAccessLevel(GetAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessLevel> GetAccessLevelAsync(GetAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessLevel> GetAccessLevelAsync(GetAccessLevelRequest request, st::CancellationToken cancellationToken) =>
            GetAccessLevelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessLevel GetAccessLevel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessLevel(new GetAccessLevelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessLevel> GetAccessLevelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessLevelAsync(new GetAccessLevelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessLevel> GetAccessLevelAsync(string name, st::CancellationToken cancellationToken) =>
            GetAccessLevelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessLevel GetAccessLevel(AccessLevelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessLevel(new GetAccessLevelRequest
            {
                AccessLevelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessLevel> GetAccessLevelAsync(AccessLevelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessLevelAsync(new GetAccessLevelRequest
            {
                AccessLevelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessLevel> GetAccessLevelAsync(AccessLevelName name, st::CancellationToken cancellationToken) =>
            GetAccessLevelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the [access
        /// level] [google.identity.accesscontextmanager.v1.AccessLevel]
        /// propagates to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessLevel, AccessContextManagerOperationMetadata> CreateAccessLevel(CreateAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the [access
        /// level] [google.identity.accesscontextmanager.v1.AccessLevel]
        /// propagates to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> CreateAccessLevelAsync(CreateAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the [access
        /// level] [google.identity.accesscontextmanager.v1.AccessLevel]
        /// propagates to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> CreateAccessLevelAsync(CreateAccessLevelRequest request, st::CancellationToken cancellationToken) =>
            CreateAccessLevelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAccessLevel</c>.</summary>
        public virtual lro::OperationsClient CreateAccessLevelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAccessLevel</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AccessLevel, AccessContextManagerOperationMetadata> PollOnceCreateAccessLevel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAccessLevelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAccessLevel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> PollOnceCreateAccessLevelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAccessLevelOperationsClient, callSettings);

        /// <summary>
        /// Creates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the [access
        /// level] [google.identity.accesscontextmanager.v1.AccessLevel]
        /// propagates to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy which owns this [Access
        /// Level] [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format: `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="accessLevel">
        /// Required. The [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] to create.
        /// Syntactic correctness of the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] is a
        /// precondition for creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessLevel, AccessContextManagerOperationMetadata> CreateAccessLevel(string parent, AccessLevel accessLevel, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccessLevel(new CreateAccessLevelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AccessLevel = gax::GaxPreconditions.CheckNotNull(accessLevel, nameof(accessLevel)),
            }, callSettings);

        /// <summary>
        /// Creates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the [access
        /// level] [google.identity.accesscontextmanager.v1.AccessLevel]
        /// propagates to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy which owns this [Access
        /// Level] [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format: `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="accessLevel">
        /// Required. The [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] to create.
        /// Syntactic correctness of the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] is a
        /// precondition for creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> CreateAccessLevelAsync(string parent, AccessLevel accessLevel, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccessLevelAsync(new CreateAccessLevelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AccessLevel = gax::GaxPreconditions.CheckNotNull(accessLevel, nameof(accessLevel)),
            }, callSettings);

        /// <summary>
        /// Creates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the [access
        /// level] [google.identity.accesscontextmanager.v1.AccessLevel]
        /// propagates to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy which owns this [Access
        /// Level] [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format: `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="accessLevel">
        /// Required. The [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] to create.
        /// Syntactic correctness of the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] is a
        /// precondition for creation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> CreateAccessLevelAsync(string parent, AccessLevel accessLevel, st::CancellationToken cancellationToken) =>
            CreateAccessLevelAsync(parent, accessLevel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the [access
        /// level] [google.identity.accesscontextmanager.v1.AccessLevel]
        /// propagates to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy which owns this [Access
        /// Level] [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format: `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="accessLevel">
        /// Required. The [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] to create.
        /// Syntactic correctness of the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] is a
        /// precondition for creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessLevel, AccessContextManagerOperationMetadata> CreateAccessLevel(AccessPolicyName parent, AccessLevel accessLevel, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccessLevel(new CreateAccessLevelRequest
            {
                ParentAsAccessPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AccessLevel = gax::GaxPreconditions.CheckNotNull(accessLevel, nameof(accessLevel)),
            }, callSettings);

        /// <summary>
        /// Creates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the [access
        /// level] [google.identity.accesscontextmanager.v1.AccessLevel]
        /// propagates to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy which owns this [Access
        /// Level] [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format: `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="accessLevel">
        /// Required. The [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] to create.
        /// Syntactic correctness of the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] is a
        /// precondition for creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> CreateAccessLevelAsync(AccessPolicyName parent, AccessLevel accessLevel, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccessLevelAsync(new CreateAccessLevelRequest
            {
                ParentAsAccessPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AccessLevel = gax::GaxPreconditions.CheckNotNull(accessLevel, nameof(accessLevel)),
            }, callSettings);

        /// <summary>
        /// Creates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the [access
        /// level] [google.identity.accesscontextmanager.v1.AccessLevel]
        /// propagates to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy which owns this [Access
        /// Level] [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format: `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="accessLevel">
        /// Required. The [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] to create.
        /// Syntactic correctness of the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] is a
        /// precondition for creation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> CreateAccessLevelAsync(AccessPolicyName parent, AccessLevel accessLevel, st::CancellationToken cancellationToken) =>
            CreateAccessLevelAsync(parent, accessLevel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the changes to
        /// the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] propagate
        /// to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessLevel, AccessContextManagerOperationMetadata> UpdateAccessLevel(UpdateAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the changes to
        /// the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] propagate
        /// to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> UpdateAccessLevelAsync(UpdateAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the changes to
        /// the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] propagate
        /// to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> UpdateAccessLevelAsync(UpdateAccessLevelRequest request, st::CancellationToken cancellationToken) =>
            UpdateAccessLevelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAccessLevel</c>.</summary>
        public virtual lro::OperationsClient UpdateAccessLevelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAccessLevel</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AccessLevel, AccessContextManagerOperationMetadata> PollOnceUpdateAccessLevel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAccessLevelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAccessLevel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> PollOnceUpdateAccessLevelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAccessLevelOperationsClient, callSettings);

        /// <summary>
        /// Updates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the changes to
        /// the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] propagate
        /// to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="accessLevel">
        /// Required. The updated [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. Syntactic
        /// correctness of the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] is a
        /// precondition for creation.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask to control which fields get updated. Must be non-empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessLevel, AccessContextManagerOperationMetadata> UpdateAccessLevel(AccessLevel accessLevel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccessLevel(new UpdateAccessLevelRequest
            {
                AccessLevel = gax::GaxPreconditions.CheckNotNull(accessLevel, nameof(accessLevel)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the changes to
        /// the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] propagate
        /// to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="accessLevel">
        /// Required. The updated [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. Syntactic
        /// correctness of the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] is a
        /// precondition for creation.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask to control which fields get updated. Must be non-empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> UpdateAccessLevelAsync(AccessLevel accessLevel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccessLevelAsync(new UpdateAccessLevelRequest
            {
                AccessLevel = gax::GaxPreconditions.CheckNotNull(accessLevel, nameof(accessLevel)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the changes to
        /// the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] propagate
        /// to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="accessLevel">
        /// Required. The updated [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. Syntactic
        /// correctness of the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] is a
        /// precondition for creation.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask to control which fields get updated. Must be non-empty.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> UpdateAccessLevelAsync(AccessLevel accessLevel, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAccessLevelAsync(accessLevel, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name. The long-running operation from this RPC has a successful status
        /// after the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] has been removed
        /// from long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> DeleteAccessLevel(DeleteAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name. The long-running operation from this RPC has a successful status
        /// after the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] has been removed
        /// from long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessLevelAsync(DeleteAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name. The long-running operation from this RPC has a successful status
        /// after the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] has been removed
        /// from long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessLevelAsync(DeleteAccessLevelRequest request, st::CancellationToken cancellationToken) =>
            DeleteAccessLevelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAccessLevel</c>.</summary>
        public virtual lro::OperationsClient DeleteAccessLevelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAccessLevel</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> PollOnceDeleteAccessLevel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAccessLevelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAccessLevel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> PollOnceDeleteAccessLevelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAccessLevelOperationsClient, callSettings);

        /// <summary>
        /// Deletes an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name. The long-running operation from this RPC has a successful status
        /// after the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] has been removed
        /// from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> DeleteAccessLevel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessLevel(new DeleteAccessLevelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name. The long-running operation from this RPC has a successful status
        /// after the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] has been removed
        /// from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessLevelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessLevelAsync(new DeleteAccessLevelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name. The long-running operation from this RPC has a successful status
        /// after the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] has been removed
        /// from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessLevelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAccessLevelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name. The long-running operation from this RPC has a successful status
        /// after the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] has been removed
        /// from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> DeleteAccessLevel(AccessLevelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessLevel(new DeleteAccessLevelRequest
            {
                AccessLevelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name. The long-running operation from this RPC has a successful status
        /// after the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] has been removed
        /// from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessLevelAsync(AccessLevelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessLevelAsync(new DeleteAccessLevelRequest
            {
                AccessLevelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name. The long-running operation from this RPC has a successful status
        /// after the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] has been removed
        /// from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Access Level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessLevelAsync(AccessLevelName name, st::CancellationToken cancellationToken) =>
            DeleteAccessLevelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replaces all existing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] in an [access
        /// policy] [google.identity.accesscontextmanager.v1.AccessPolicy] with
        /// the [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] provided. This
        /// is done atomically. The long-running operation from this RPC has a
        /// successful status after all replacements propagate to long-lasting
        /// storage. If the replacement contains errors, an error response is returned
        /// for the first error encountered.  Upon error, the replacement is cancelled,
        /// and existing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] are not
        /// affected. The Operation.response field contains
        /// ReplaceAccessLevelsResponse. Removing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contained in existing
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] result in an
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata> ReplaceAccessLevels(ReplaceAccessLevelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces all existing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] in an [access
        /// policy] [google.identity.accesscontextmanager.v1.AccessPolicy] with
        /// the [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] provided. This
        /// is done atomically. The long-running operation from this RPC has a
        /// successful status after all replacements propagate to long-lasting
        /// storage. If the replacement contains errors, an error response is returned
        /// for the first error encountered.  Upon error, the replacement is cancelled,
        /// and existing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] are not
        /// affected. The Operation.response field contains
        /// ReplaceAccessLevelsResponse. Removing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contained in existing
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] result in an
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata>> ReplaceAccessLevelsAsync(ReplaceAccessLevelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces all existing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] in an [access
        /// policy] [google.identity.accesscontextmanager.v1.AccessPolicy] with
        /// the [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] provided. This
        /// is done atomically. The long-running operation from this RPC has a
        /// successful status after all replacements propagate to long-lasting
        /// storage. If the replacement contains errors, an error response is returned
        /// for the first error encountered.  Upon error, the replacement is cancelled,
        /// and existing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] are not
        /// affected. The Operation.response field contains
        /// ReplaceAccessLevelsResponse. Removing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contained in existing
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] result in an
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata>> ReplaceAccessLevelsAsync(ReplaceAccessLevelsRequest request, st::CancellationToken cancellationToken) =>
            ReplaceAccessLevelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReplaceAccessLevels</c>.</summary>
        public virtual lro::OperationsClient ReplaceAccessLevelsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ReplaceAccessLevels</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata> PollOnceReplaceAccessLevels(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReplaceAccessLevelsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReplaceAccessLevels</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata>> PollOnceReplaceAccessLevelsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReplaceAccessLevelsOperationsClient, callSettings);

        /// <summary>
        /// Lists all [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] for an
        /// access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServicePerimeter"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicePerimetersResponse, ServicePerimeter> ListServicePerimeters(ListServicePerimetersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] for an
        /// access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServicePerimeter"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicePerimetersResponse, ServicePerimeter> ListServicePerimetersAsync(ListServicePerimetersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] for an
        /// access policy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy to list [Service Perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] from.
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServicePerimeter"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicePerimetersResponse, ServicePerimeter> ListServicePerimeters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicePerimetersRequest request = new ListServicePerimetersRequest
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
            return ListServicePerimeters(request, callSettings);
        }

        /// <summary>
        /// Lists all [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] for an
        /// access policy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy to list [Service Perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] from.
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServicePerimeter"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicePerimetersResponse, ServicePerimeter> ListServicePerimetersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicePerimetersRequest request = new ListServicePerimetersRequest
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
            return ListServicePerimetersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] for an
        /// access policy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy to list [Service Perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] from.
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServicePerimeter"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicePerimetersResponse, ServicePerimeter> ListServicePerimeters(AccessPolicyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicePerimetersRequest request = new ListServicePerimetersRequest
            {
                ParentAsAccessPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServicePerimeters(request, callSettings);
        }

        /// <summary>
        /// Lists all [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] for an
        /// access policy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy to list [Service Perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] from.
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServicePerimeter"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicePerimetersResponse, ServicePerimeter> ListServicePerimetersAsync(AccessPolicyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicePerimetersRequest request = new ListServicePerimetersRequest
            {
                ParentAsAccessPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServicePerimetersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServicePerimeter GetServicePerimeter(GetServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServicePerimeter> GetServicePerimeterAsync(GetServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServicePerimeter> GetServicePerimeterAsync(GetServicePerimeterRequest request, st::CancellationToken cancellationToken) =>
            GetServicePerimeterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeters_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServicePerimeter GetServicePerimeter(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServicePerimeter(new GetServicePerimeterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeters_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServicePerimeter> GetServicePerimeterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServicePerimeterAsync(new GetServicePerimeterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeters_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServicePerimeter> GetServicePerimeterAsync(string name, st::CancellationToken cancellationToken) =>
            GetServicePerimeterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeters_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServicePerimeter GetServicePerimeter(ServicePerimeterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServicePerimeter(new GetServicePerimeterRequest
            {
                ServicePerimeterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeters_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServicePerimeter> GetServicePerimeterAsync(ServicePerimeterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServicePerimeterAsync(new GetServicePerimeterRequest
            {
                ServicePerimeterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeters_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServicePerimeter> GetServicePerimeterAsync(ServicePerimeterName name, st::CancellationToken cancellationToken) =>
            GetServicePerimeterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata> CreateServicePerimeter(CreateServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> CreateServicePerimeterAsync(CreateServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> CreateServicePerimeterAsync(CreateServicePerimeterRequest request, st::CancellationToken cancellationToken) =>
            CreateServicePerimeterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateServicePerimeter</c>.</summary>
        public virtual lro::OperationsClient CreateServicePerimeterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServicePerimeter</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata> PollOnceCreateServicePerimeter(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServicePerimeterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServicePerimeter</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> PollOnceCreateServicePerimeterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServicePerimeterOperationsClient, callSettings);

        /// <summary>
        /// Creates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy which owns this [Service
        /// Perimeter] [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format: `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="servicePerimeter">
        /// Required. The [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] to create.
        /// Syntactic correctness of the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is a
        /// precondition for creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata> CreateServicePerimeter(string parent, ServicePerimeter servicePerimeter, gaxgrpc::CallSettings callSettings = null) =>
            CreateServicePerimeter(new CreateServicePerimeterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServicePerimeter = gax::GaxPreconditions.CheckNotNull(servicePerimeter, nameof(servicePerimeter)),
            }, callSettings);

        /// <summary>
        /// Creates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy which owns this [Service
        /// Perimeter] [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format: `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="servicePerimeter">
        /// Required. The [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] to create.
        /// Syntactic correctness of the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is a
        /// precondition for creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> CreateServicePerimeterAsync(string parent, ServicePerimeter servicePerimeter, gaxgrpc::CallSettings callSettings = null) =>
            CreateServicePerimeterAsync(new CreateServicePerimeterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServicePerimeter = gax::GaxPreconditions.CheckNotNull(servicePerimeter, nameof(servicePerimeter)),
            }, callSettings);

        /// <summary>
        /// Creates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy which owns this [Service
        /// Perimeter] [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format: `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="servicePerimeter">
        /// Required. The [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] to create.
        /// Syntactic correctness of the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is a
        /// precondition for creation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> CreateServicePerimeterAsync(string parent, ServicePerimeter servicePerimeter, st::CancellationToken cancellationToken) =>
            CreateServicePerimeterAsync(parent, servicePerimeter, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy which owns this [Service
        /// Perimeter] [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format: `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="servicePerimeter">
        /// Required. The [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] to create.
        /// Syntactic correctness of the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is a
        /// precondition for creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata> CreateServicePerimeter(AccessPolicyName parent, ServicePerimeter servicePerimeter, gaxgrpc::CallSettings callSettings = null) =>
            CreateServicePerimeter(new CreateServicePerimeterRequest
            {
                ParentAsAccessPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServicePerimeter = gax::GaxPreconditions.CheckNotNull(servicePerimeter, nameof(servicePerimeter)),
            }, callSettings);

        /// <summary>
        /// Creates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy which owns this [Service
        /// Perimeter] [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format: `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="servicePerimeter">
        /// Required. The [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] to create.
        /// Syntactic correctness of the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is a
        /// precondition for creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> CreateServicePerimeterAsync(AccessPolicyName parent, ServicePerimeter servicePerimeter, gaxgrpc::CallSettings callSettings = null) =>
            CreateServicePerimeterAsync(new CreateServicePerimeterRequest
            {
                ParentAsAccessPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServicePerimeter = gax::GaxPreconditions.CheckNotNull(servicePerimeter, nameof(servicePerimeter)),
            }, callSettings);

        /// <summary>
        /// Creates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name for the access policy which owns this [Service
        /// Perimeter] [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format: `accessPolicies/{policy_id}`
        /// </param>
        /// <param name="servicePerimeter">
        /// Required. The [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] to create.
        /// Syntactic correctness of the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is a
        /// precondition for creation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> CreateServicePerimeterAsync(AccessPolicyName parent, ServicePerimeter servicePerimeter, st::CancellationToken cancellationToken) =>
            CreateServicePerimeterAsync(parent, servicePerimeter, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata> UpdateServicePerimeter(UpdateServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> UpdateServicePerimeterAsync(UpdateServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> UpdateServicePerimeterAsync(UpdateServicePerimeterRequest request, st::CancellationToken cancellationToken) =>
            UpdateServicePerimeterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateServicePerimeter</c>.</summary>
        public virtual lro::OperationsClient UpdateServicePerimeterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateServicePerimeter</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata> PollOnceUpdateServicePerimeter(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServicePerimeterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateServicePerimeter</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> PollOnceUpdateServicePerimeterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServicePerimeterOperationsClient, callSettings);

        /// <summary>
        /// Updates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="servicePerimeter">
        /// Required. The updated `ServicePerimeter`. Syntactic correctness of the
        /// `ServicePerimeter` is a precondition for creation.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask to control which fields get updated. Must be non-empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata> UpdateServicePerimeter(ServicePerimeter servicePerimeter, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServicePerimeter(new UpdateServicePerimeterRequest
            {
                ServicePerimeter = gax::GaxPreconditions.CheckNotNull(servicePerimeter, nameof(servicePerimeter)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="servicePerimeter">
        /// Required. The updated `ServicePerimeter`. Syntactic correctness of the
        /// `ServicePerimeter` is a precondition for creation.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask to control which fields get updated. Must be non-empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> UpdateServicePerimeterAsync(ServicePerimeter servicePerimeter, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServicePerimeterAsync(new UpdateServicePerimeterRequest
            {
                ServicePerimeter = gax::GaxPreconditions.CheckNotNull(servicePerimeter, nameof(servicePerimeter)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="servicePerimeter">
        /// Required. The updated `ServicePerimeter`. Syntactic correctness of the
        /// `ServicePerimeter` is a precondition for creation.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask to control which fields get updated. Must be non-empty.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> UpdateServicePerimeterAsync(ServicePerimeter servicePerimeter, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateServicePerimeterAsync(servicePerimeter, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name. The long-running operation from this RPC has a successful
        /// status after the [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is removed from
        /// long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> DeleteServicePerimeter(DeleteServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name. The long-running operation from this RPC has a successful
        /// status after the [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is removed from
        /// long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteServicePerimeterAsync(DeleteServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name. The long-running operation from this RPC has a successful
        /// status after the [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is removed from
        /// long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteServicePerimeterAsync(DeleteServicePerimeterRequest request, st::CancellationToken cancellationToken) =>
            DeleteServicePerimeterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteServicePerimeter</c>.</summary>
        public virtual lro::OperationsClient DeleteServicePerimeterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServicePerimeter</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> PollOnceDeleteServicePerimeter(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServicePerimeterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServicePerimeter</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> PollOnceDeleteServicePerimeterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServicePerimeterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name. The long-running operation from this RPC has a successful
        /// status after the [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is removed from
        /// long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeter_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> DeleteServicePerimeter(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServicePerimeter(new DeleteServicePerimeterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name. The long-running operation from this RPC has a successful
        /// status after the [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is removed from
        /// long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeter_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteServicePerimeterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServicePerimeterAsync(new DeleteServicePerimeterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name. The long-running operation from this RPC has a successful
        /// status after the [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is removed from
        /// long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeter_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteServicePerimeterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServicePerimeterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name. The long-running operation from this RPC has a successful
        /// status after the [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is removed from
        /// long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeter_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> DeleteServicePerimeter(ServicePerimeterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServicePerimeter(new DeleteServicePerimeterRequest
            {
                ServicePerimeterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name. The long-running operation from this RPC has a successful
        /// status after the [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is removed from
        /// long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeter_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteServicePerimeterAsync(ServicePerimeterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServicePerimeterAsync(new DeleteServicePerimeterRequest
            {
                ServicePerimeterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name. The long-running operation from this RPC has a successful
        /// status after the [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is removed from
        /// long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the [Service Perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter].
        /// 
        /// Format:
        /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeter_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteServicePerimeterAsync(ServicePerimeterName name, st::CancellationToken cancellationToken) =>
            DeleteServicePerimeterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replace all existing [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] in an [access
        /// policy] [google.identity.accesscontextmanager.v1.AccessPolicy] with the
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] provided. This
        /// is done atomically. The long-running operation from this RPC has a
        /// successful status after all replacements propagate to long-lasting storage.
        /// Replacements containing errors result in an error response for the first
        /// error encountered. Upon an error, replacement are cancelled and existing
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] are not
        /// affected. The Operation.response field contains
        /// ReplaceServicePerimetersResponse.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata> ReplaceServicePerimeters(ReplaceServicePerimetersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replace all existing [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] in an [access
        /// policy] [google.identity.accesscontextmanager.v1.AccessPolicy] with the
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] provided. This
        /// is done atomically. The long-running operation from this RPC has a
        /// successful status after all replacements propagate to long-lasting storage.
        /// Replacements containing errors result in an error response for the first
        /// error encountered. Upon an error, replacement are cancelled and existing
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] are not
        /// affected. The Operation.response field contains
        /// ReplaceServicePerimetersResponse.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata>> ReplaceServicePerimetersAsync(ReplaceServicePerimetersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replace all existing [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] in an [access
        /// policy] [google.identity.accesscontextmanager.v1.AccessPolicy] with the
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] provided. This
        /// is done atomically. The long-running operation from this RPC has a
        /// successful status after all replacements propagate to long-lasting storage.
        /// Replacements containing errors result in an error response for the first
        /// error encountered. Upon an error, replacement are cancelled and existing
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] are not
        /// affected. The Operation.response field contains
        /// ReplaceServicePerimetersResponse.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata>> ReplaceServicePerimetersAsync(ReplaceServicePerimetersRequest request, st::CancellationToken cancellationToken) =>
            ReplaceServicePerimetersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReplaceServicePerimeters</c>.</summary>
        public virtual lro::OperationsClient ReplaceServicePerimetersOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReplaceServicePerimeters</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata> PollOnceReplaceServicePerimeters(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReplaceServicePerimetersOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReplaceServicePerimeters</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata>> PollOnceReplaceServicePerimetersAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReplaceServicePerimetersOperationsClient, callSettings);

        /// <summary>
        /// Commits the dry-run specification for all the [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] in an
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// A commit operation on a service perimeter involves copying its `spec` field
        /// to the `status` field of the service perimeter. Only [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] with
        /// `use_explicit_dry_run_spec` field set to true are affected by a commit
        /// operation. The long-running operation from this RPC has a successful
        /// status after the dry-run specifications for all the [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] have been
        /// committed. If a commit fails, it causes the long-running operation to
        /// return an error response and the entire commit operation is cancelled.
        /// When successful, the Operation.response field contains
        /// CommitServicePerimetersResponse. The `dry_run` and the `spec` fields are
        /// cleared after a successful commit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata> CommitServicePerimeters(CommitServicePerimetersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Commits the dry-run specification for all the [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] in an
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// A commit operation on a service perimeter involves copying its `spec` field
        /// to the `status` field of the service perimeter. Only [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] with
        /// `use_explicit_dry_run_spec` field set to true are affected by a commit
        /// operation. The long-running operation from this RPC has a successful
        /// status after the dry-run specifications for all the [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] have been
        /// committed. If a commit fails, it causes the long-running operation to
        /// return an error response and the entire commit operation is cancelled.
        /// When successful, the Operation.response field contains
        /// CommitServicePerimetersResponse. The `dry_run` and the `spec` fields are
        /// cleared after a successful commit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata>> CommitServicePerimetersAsync(CommitServicePerimetersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Commits the dry-run specification for all the [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] in an
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// A commit operation on a service perimeter involves copying its `spec` field
        /// to the `status` field of the service perimeter. Only [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] with
        /// `use_explicit_dry_run_spec` field set to true are affected by a commit
        /// operation. The long-running operation from this RPC has a successful
        /// status after the dry-run specifications for all the [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] have been
        /// committed. If a commit fails, it causes the long-running operation to
        /// return an error response and the entire commit operation is cancelled.
        /// When successful, the Operation.response field contains
        /// CommitServicePerimetersResponse. The `dry_run` and the `spec` fields are
        /// cleared after a successful commit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata>> CommitServicePerimetersAsync(CommitServicePerimetersRequest request, st::CancellationToken cancellationToken) =>
            CommitServicePerimetersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CommitServicePerimeters</c>.</summary>
        public virtual lro::OperationsClient CommitServicePerimetersOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CommitServicePerimeters</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata> PollOnceCommitServicePerimeters(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CommitServicePerimetersOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CommitServicePerimeters</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata>> PollOnceCommitServicePerimetersAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CommitServicePerimetersOperationsClient, callSettings);

        /// <summary>
        /// Lists all [GcpUserAccessBindings]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] for a
        /// Google Cloud organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GcpUserAccessBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> ListGcpUserAccessBindings(ListGcpUserAccessBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [GcpUserAccessBindings]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] for a
        /// Google Cloud organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GcpUserAccessBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> ListGcpUserAccessBindingsAsync(ListGcpUserAccessBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [GcpUserAccessBindings]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] for a
        /// Google Cloud organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Example: "organizations/256"
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GcpUserAccessBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> ListGcpUserAccessBindings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGcpUserAccessBindingsRequest request = new ListGcpUserAccessBindingsRequest
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
            return ListGcpUserAccessBindings(request, callSettings);
        }

        /// <summary>
        /// Lists all [GcpUserAccessBindings]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] for a
        /// Google Cloud organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Example: "organizations/256"
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GcpUserAccessBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> ListGcpUserAccessBindingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGcpUserAccessBindingsRequest request = new ListGcpUserAccessBindingsRequest
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
            return ListGcpUserAccessBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all [GcpUserAccessBindings]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] for a
        /// Google Cloud organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Example: "organizations/256"
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GcpUserAccessBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> ListGcpUserAccessBindings(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGcpUserAccessBindingsRequest request = new ListGcpUserAccessBindingsRequest
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
            return ListGcpUserAccessBindings(request, callSettings);
        }

        /// <summary>
        /// Lists all [GcpUserAccessBindings]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] for a
        /// Google Cloud organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Example: "organizations/256"
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GcpUserAccessBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> ListGcpUserAccessBindingsAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGcpUserAccessBindingsRequest request = new ListGcpUserAccessBindingsRequest
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
            return ListGcpUserAccessBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] with
        /// the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GcpUserAccessBinding GetGcpUserAccessBinding(GetGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] with
        /// the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GcpUserAccessBinding> GetGcpUserAccessBindingAsync(GetGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] with
        /// the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GcpUserAccessBinding> GetGcpUserAccessBindingAsync(GetGcpUserAccessBindingRequest request, st::CancellationToken cancellationToken) =>
            GetGcpUserAccessBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] with
        /// the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GcpUserAccessBinding GetGcpUserAccessBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGcpUserAccessBinding(new GetGcpUserAccessBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] with
        /// the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GcpUserAccessBinding> GetGcpUserAccessBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGcpUserAccessBindingAsync(new GetGcpUserAccessBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] with
        /// the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GcpUserAccessBinding> GetGcpUserAccessBindingAsync(string name, st::CancellationToken cancellationToken) =>
            GetGcpUserAccessBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] with
        /// the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GcpUserAccessBinding GetGcpUserAccessBinding(GcpUserAccessBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGcpUserAccessBinding(new GetGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] with
        /// the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GcpUserAccessBinding> GetGcpUserAccessBindingAsync(GcpUserAccessBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGcpUserAccessBindingAsync(new GetGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] with
        /// the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GcpUserAccessBinding> GetGcpUserAccessBindingAsync(GcpUserAccessBindingName name, st::CancellationToken cancellationToken) =>
            GetGcpUserAccessBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]. If the
        /// client specifies a [name]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        /// the server ignores it. Fails if a resource already exists with the same
        /// [group_key]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        /// Completion of this long-running operation does not necessarily signify that
        /// the new binding is deployed onto all affected users, which may take more
        /// time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> CreateGcpUserAccessBinding(CreateGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]. If the
        /// client specifies a [name]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        /// the server ignores it. Fails if a resource already exists with the same
        /// [group_key]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        /// Completion of this long-running operation does not necessarily signify that
        /// the new binding is deployed onto all affected users, which may take more
        /// time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> CreateGcpUserAccessBindingAsync(CreateGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]. If the
        /// client specifies a [name]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        /// the server ignores it. Fails if a resource already exists with the same
        /// [group_key]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        /// Completion of this long-running operation does not necessarily signify that
        /// the new binding is deployed onto all affected users, which may take more
        /// time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> CreateGcpUserAccessBindingAsync(CreateGcpUserAccessBindingRequest request, st::CancellationToken cancellationToken) =>
            CreateGcpUserAccessBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGcpUserAccessBinding</c>.</summary>
        public virtual lro::OperationsClient CreateGcpUserAccessBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGcpUserAccessBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> PollOnceCreateGcpUserAccessBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGcpUserAccessBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGcpUserAccessBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> PollOnceCreateGcpUserAccessBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGcpUserAccessBindingOperationsClient, callSettings);

        /// <summary>
        /// Creates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]. If the
        /// client specifies a [name]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        /// the server ignores it. Fails if a resource already exists with the same
        /// [group_key]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        /// Completion of this long-running operation does not necessarily signify that
        /// the new binding is deployed onto all affected users, which may take more
        /// time.
        /// </summary>
        /// <param name="parent">
        /// Required. Example: "organizations/256"
        /// </param>
        /// <param name="gcpUserAccessBinding">
        /// Required. [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> CreateGcpUserAccessBinding(string parent, GcpUserAccessBinding gcpUserAccessBinding, gaxgrpc::CallSettings callSettings = null) =>
            CreateGcpUserAccessBinding(new CreateGcpUserAccessBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GcpUserAccessBinding = gax::GaxPreconditions.CheckNotNull(gcpUserAccessBinding, nameof(gcpUserAccessBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]. If the
        /// client specifies a [name]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        /// the server ignores it. Fails if a resource already exists with the same
        /// [group_key]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        /// Completion of this long-running operation does not necessarily signify that
        /// the new binding is deployed onto all affected users, which may take more
        /// time.
        /// </summary>
        /// <param name="parent">
        /// Required. Example: "organizations/256"
        /// </param>
        /// <param name="gcpUserAccessBinding">
        /// Required. [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> CreateGcpUserAccessBindingAsync(string parent, GcpUserAccessBinding gcpUserAccessBinding, gaxgrpc::CallSettings callSettings = null) =>
            CreateGcpUserAccessBindingAsync(new CreateGcpUserAccessBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GcpUserAccessBinding = gax::GaxPreconditions.CheckNotNull(gcpUserAccessBinding, nameof(gcpUserAccessBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]. If the
        /// client specifies a [name]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        /// the server ignores it. Fails if a resource already exists with the same
        /// [group_key]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        /// Completion of this long-running operation does not necessarily signify that
        /// the new binding is deployed onto all affected users, which may take more
        /// time.
        /// </summary>
        /// <param name="parent">
        /// Required. Example: "organizations/256"
        /// </param>
        /// <param name="gcpUserAccessBinding">
        /// Required. [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> CreateGcpUserAccessBindingAsync(string parent, GcpUserAccessBinding gcpUserAccessBinding, st::CancellationToken cancellationToken) =>
            CreateGcpUserAccessBindingAsync(parent, gcpUserAccessBinding, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]. If the
        /// client specifies a [name]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        /// the server ignores it. Fails if a resource already exists with the same
        /// [group_key]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        /// Completion of this long-running operation does not necessarily signify that
        /// the new binding is deployed onto all affected users, which may take more
        /// time.
        /// </summary>
        /// <param name="parent">
        /// Required. Example: "organizations/256"
        /// </param>
        /// <param name="gcpUserAccessBinding">
        /// Required. [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> CreateGcpUserAccessBinding(gagr::OrganizationName parent, GcpUserAccessBinding gcpUserAccessBinding, gaxgrpc::CallSettings callSettings = null) =>
            CreateGcpUserAccessBinding(new CreateGcpUserAccessBindingRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GcpUserAccessBinding = gax::GaxPreconditions.CheckNotNull(gcpUserAccessBinding, nameof(gcpUserAccessBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]. If the
        /// client specifies a [name]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        /// the server ignores it. Fails if a resource already exists with the same
        /// [group_key]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        /// Completion of this long-running operation does not necessarily signify that
        /// the new binding is deployed onto all affected users, which may take more
        /// time.
        /// </summary>
        /// <param name="parent">
        /// Required. Example: "organizations/256"
        /// </param>
        /// <param name="gcpUserAccessBinding">
        /// Required. [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> CreateGcpUserAccessBindingAsync(gagr::OrganizationName parent, GcpUserAccessBinding gcpUserAccessBinding, gaxgrpc::CallSettings callSettings = null) =>
            CreateGcpUserAccessBindingAsync(new CreateGcpUserAccessBindingRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GcpUserAccessBinding = gax::GaxPreconditions.CheckNotNull(gcpUserAccessBinding, nameof(gcpUserAccessBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]. If the
        /// client specifies a [name]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        /// the server ignores it. Fails if a resource already exists with the same
        /// [group_key]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        /// Completion of this long-running operation does not necessarily signify that
        /// the new binding is deployed onto all affected users, which may take more
        /// time.
        /// </summary>
        /// <param name="parent">
        /// Required. Example: "organizations/256"
        /// </param>
        /// <param name="gcpUserAccessBinding">
        /// Required. [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> CreateGcpUserAccessBindingAsync(gagr::OrganizationName parent, GcpUserAccessBinding gcpUserAccessBinding, st::CancellationToken cancellationToken) =>
            CreateGcpUserAccessBindingAsync(parent, gcpUserAccessBinding, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the changed binding is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> UpdateGcpUserAccessBinding(UpdateGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the changed binding is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> UpdateGcpUserAccessBindingAsync(UpdateGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the changed binding is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> UpdateGcpUserAccessBindingAsync(UpdateGcpUserAccessBindingRequest request, st::CancellationToken cancellationToken) =>
            UpdateGcpUserAccessBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateGcpUserAccessBinding</c>.</summary>
        public virtual lro::OperationsClient UpdateGcpUserAccessBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGcpUserAccessBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> PollOnceUpdateGcpUserAccessBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGcpUserAccessBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGcpUserAccessBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> PollOnceUpdateGcpUserAccessBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGcpUserAccessBindingOperationsClient, callSettings);

        /// <summary>
        /// Updates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the changed binding is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="gcpUserAccessBinding">
        /// Required. [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        /// </param>
        /// <param name="updateMask">
        /// Required. Only the fields specified in this mask are updated. Because name and
        /// group_key cannot be changed, update_mask is required and must always be:
        /// 
        /// update_mask {
        /// paths: "access_levels"
        /// }
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> UpdateGcpUserAccessBinding(GcpUserAccessBinding gcpUserAccessBinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGcpUserAccessBinding(new UpdateGcpUserAccessBindingRequest
            {
                GcpUserAccessBinding = gax::GaxPreconditions.CheckNotNull(gcpUserAccessBinding, nameof(gcpUserAccessBinding)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the changed binding is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="gcpUserAccessBinding">
        /// Required. [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        /// </param>
        /// <param name="updateMask">
        /// Required. Only the fields specified in this mask are updated. Because name and
        /// group_key cannot be changed, update_mask is required and must always be:
        /// 
        /// update_mask {
        /// paths: "access_levels"
        /// }
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> UpdateGcpUserAccessBindingAsync(GcpUserAccessBinding gcpUserAccessBinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGcpUserAccessBindingAsync(new UpdateGcpUserAccessBindingRequest
            {
                GcpUserAccessBinding = gax::GaxPreconditions.CheckNotNull(gcpUserAccessBinding, nameof(gcpUserAccessBinding)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the changed binding is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="gcpUserAccessBinding">
        /// Required. [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        /// </param>
        /// <param name="updateMask">
        /// Required. Only the fields specified in this mask are updated. Because name and
        /// group_key cannot be changed, update_mask is required and must always be:
        /// 
        /// update_mask {
        /// paths: "access_levels"
        /// }
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> UpdateGcpUserAccessBindingAsync(GcpUserAccessBinding gcpUserAccessBinding, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGcpUserAccessBindingAsync(gcpUserAccessBinding, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the binding deletion is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata> DeleteGcpUserAccessBinding(DeleteGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the binding deletion is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata>> DeleteGcpUserAccessBindingAsync(DeleteGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the binding deletion is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata>> DeleteGcpUserAccessBindingAsync(DeleteGcpUserAccessBindingRequest request, st::CancellationToken cancellationToken) =>
            DeleteGcpUserAccessBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGcpUserAccessBinding</c>.</summary>
        public virtual lro::OperationsClient DeleteGcpUserAccessBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGcpUserAccessBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata> PollOnceDeleteGcpUserAccessBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGcpUserAccessBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGcpUserAccessBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata>> PollOnceDeleteGcpUserAccessBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGcpUserAccessBindingOperationsClient, callSettings);

        /// <summary>
        /// Deletes a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the binding deletion is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="name">
        /// Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata> DeleteGcpUserAccessBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGcpUserAccessBinding(new DeleteGcpUserAccessBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the binding deletion is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="name">
        /// Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata>> DeleteGcpUserAccessBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGcpUserAccessBindingAsync(new DeleteGcpUserAccessBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the binding deletion is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="name">
        /// Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata>> DeleteGcpUserAccessBindingAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGcpUserAccessBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the binding deletion is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="name">
        /// Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata> DeleteGcpUserAccessBinding(GcpUserAccessBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGcpUserAccessBinding(new DeleteGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the binding deletion is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="name">
        /// Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata>> DeleteGcpUserAccessBindingAsync(GcpUserAccessBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGcpUserAccessBindingAsync(new DeleteGcpUserAccessBindingRequest
            {
                GcpUserAccessBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the binding deletion is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="name">
        /// Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata>> DeleteGcpUserAccessBindingAsync(GcpUserAccessBindingName name, st::CancellationToken cancellationToken) =>
            DeleteGcpUserAccessBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM policy for the specified Access Context Manager
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// This method replaces the existing IAM policy on the access policy. The IAM
        /// policy controls the set of users who can perform specific operations on the
        /// Access Context Manager [access
        /// policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM policy for the specified Access Context Manager
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// This method replaces the existing IAM policy on the access policy. The IAM
        /// policy controls the set of users who can perform specific operations on the
        /// Access Context Manager [access
        /// policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM policy for the specified Access Context Manager
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// This method replaces the existing IAM policy on the access policy. The IAM
        /// policy controls the set of users who can perform specific operations on the
        /// Access Context Manager [access
        /// policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy for the specified Access Context Manager
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for the specified Access Context Manager
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for the specified Access Context Manager
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the IAM permissions that the caller has on the specified Access
        /// Context Manager resource. The resource can be an
        /// [AccessPolicy][google.identity.accesscontextmanager.v1.AccessPolicy],
        /// [AccessLevel][google.identity.accesscontextmanager.v1.AccessLevel], or
        /// [ServicePerimeter][google.identity.accesscontextmanager.v1.ServicePerimeter
        /// ]. This method does not support other resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the IAM permissions that the caller has on the specified Access
        /// Context Manager resource. The resource can be an
        /// [AccessPolicy][google.identity.accesscontextmanager.v1.AccessPolicy],
        /// [AccessLevel][google.identity.accesscontextmanager.v1.AccessLevel], or
        /// [ServicePerimeter][google.identity.accesscontextmanager.v1.ServicePerimeter
        /// ]. This method does not support other resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the IAM permissions that the caller has on the specified Access
        /// Context Manager resource. The resource can be an
        /// [AccessPolicy][google.identity.accesscontextmanager.v1.AccessPolicy],
        /// [AccessLevel][google.identity.accesscontextmanager.v1.AccessLevel], or
        /// [ServicePerimeter][google.identity.accesscontextmanager.v1.ServicePerimeter
        /// ]. This method does not support other resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AccessContextManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// API for setting [access levels]
    /// [google.identity.accesscontextmanager.v1.AccessLevel] and [service
    /// perimeters] [google.identity.accesscontextmanager.v1.ServicePerimeter]
    /// for Google Cloud projects. Each organization has one [access policy]
    /// [google.identity.accesscontextmanager.v1.AccessPolicy] that contains the
    /// [access levels] [google.identity.accesscontextmanager.v1.AccessLevel]
    /// and [service perimeters]
    /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. This
    /// [access policy] [google.identity.accesscontextmanager.v1.AccessPolicy] is
    /// applicable to all resources in the organization.
    /// AccessPolicies
    /// </remarks>
    public sealed partial class AccessContextManagerClientImpl : AccessContextManagerClient
    {
        private readonly gaxgrpc::ApiCall<ListAccessPoliciesRequest, ListAccessPoliciesResponse> _callListAccessPolicies;

        private readonly gaxgrpc::ApiCall<GetAccessPolicyRequest, AccessPolicy> _callGetAccessPolicy;

        private readonly gaxgrpc::ApiCall<AccessPolicy, lro::Operation> _callCreateAccessPolicy;

        private readonly gaxgrpc::ApiCall<UpdateAccessPolicyRequest, lro::Operation> _callUpdateAccessPolicy;

        private readonly gaxgrpc::ApiCall<DeleteAccessPolicyRequest, lro::Operation> _callDeleteAccessPolicy;

        private readonly gaxgrpc::ApiCall<ListAccessLevelsRequest, ListAccessLevelsResponse> _callListAccessLevels;

        private readonly gaxgrpc::ApiCall<GetAccessLevelRequest, AccessLevel> _callGetAccessLevel;

        private readonly gaxgrpc::ApiCall<CreateAccessLevelRequest, lro::Operation> _callCreateAccessLevel;

        private readonly gaxgrpc::ApiCall<UpdateAccessLevelRequest, lro::Operation> _callUpdateAccessLevel;

        private readonly gaxgrpc::ApiCall<DeleteAccessLevelRequest, lro::Operation> _callDeleteAccessLevel;

        private readonly gaxgrpc::ApiCall<ReplaceAccessLevelsRequest, lro::Operation> _callReplaceAccessLevels;

        private readonly gaxgrpc::ApiCall<ListServicePerimetersRequest, ListServicePerimetersResponse> _callListServicePerimeters;

        private readonly gaxgrpc::ApiCall<GetServicePerimeterRequest, ServicePerimeter> _callGetServicePerimeter;

        private readonly gaxgrpc::ApiCall<CreateServicePerimeterRequest, lro::Operation> _callCreateServicePerimeter;

        private readonly gaxgrpc::ApiCall<UpdateServicePerimeterRequest, lro::Operation> _callUpdateServicePerimeter;

        private readonly gaxgrpc::ApiCall<DeleteServicePerimeterRequest, lro::Operation> _callDeleteServicePerimeter;

        private readonly gaxgrpc::ApiCall<ReplaceServicePerimetersRequest, lro::Operation> _callReplaceServicePerimeters;

        private readonly gaxgrpc::ApiCall<CommitServicePerimetersRequest, lro::Operation> _callCommitServicePerimeters;

        private readonly gaxgrpc::ApiCall<ListGcpUserAccessBindingsRequest, ListGcpUserAccessBindingsResponse> _callListGcpUserAccessBindings;

        private readonly gaxgrpc::ApiCall<GetGcpUserAccessBindingRequest, GcpUserAccessBinding> _callGetGcpUserAccessBinding;

        private readonly gaxgrpc::ApiCall<CreateGcpUserAccessBindingRequest, lro::Operation> _callCreateGcpUserAccessBinding;

        private readonly gaxgrpc::ApiCall<UpdateGcpUserAccessBindingRequest, lro::Operation> _callUpdateGcpUserAccessBinding;

        private readonly gaxgrpc::ApiCall<DeleteGcpUserAccessBindingRequest, lro::Operation> _callDeleteGcpUserAccessBinding;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the AccessContextManager service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AccessContextManagerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AccessContextManagerClientImpl(AccessContextManager.AccessContextManagerClient grpcClient, AccessContextManagerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AccessContextManagerSettings effectiveSettings = settings ?? AccessContextManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateAccessPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAccessPolicyOperationsSettings, logger);
            UpdateAccessPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAccessPolicyOperationsSettings, logger);
            DeleteAccessPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAccessPolicyOperationsSettings, logger);
            CreateAccessLevelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAccessLevelOperationsSettings, logger);
            UpdateAccessLevelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAccessLevelOperationsSettings, logger);
            DeleteAccessLevelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAccessLevelOperationsSettings, logger);
            ReplaceAccessLevelsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReplaceAccessLevelsOperationsSettings, logger);
            CreateServicePerimeterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServicePerimeterOperationsSettings, logger);
            UpdateServicePerimeterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateServicePerimeterOperationsSettings, logger);
            DeleteServicePerimeterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServicePerimeterOperationsSettings, logger);
            ReplaceServicePerimetersOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReplaceServicePerimetersOperationsSettings, logger);
            CommitServicePerimetersOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CommitServicePerimetersOperationsSettings, logger);
            CreateGcpUserAccessBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGcpUserAccessBindingOperationsSettings, logger);
            UpdateGcpUserAccessBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGcpUserAccessBindingOperationsSettings, logger);
            DeleteGcpUserAccessBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGcpUserAccessBindingOperationsSettings, logger);
            _callListAccessPolicies = clientHelper.BuildApiCall<ListAccessPoliciesRequest, ListAccessPoliciesResponse>("ListAccessPolicies", grpcClient.ListAccessPoliciesAsync, grpcClient.ListAccessPolicies, effectiveSettings.ListAccessPoliciesSettings);
            Modify_ApiCall(ref _callListAccessPolicies);
            Modify_ListAccessPoliciesApiCall(ref _callListAccessPolicies);
            _callGetAccessPolicy = clientHelper.BuildApiCall<GetAccessPolicyRequest, AccessPolicy>("GetAccessPolicy", grpcClient.GetAccessPolicyAsync, grpcClient.GetAccessPolicy, effectiveSettings.GetAccessPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAccessPolicy);
            Modify_GetAccessPolicyApiCall(ref _callGetAccessPolicy);
            _callCreateAccessPolicy = clientHelper.BuildApiCall<AccessPolicy, lro::Operation>("CreateAccessPolicy", grpcClient.CreateAccessPolicyAsync, grpcClient.CreateAccessPolicy, effectiveSettings.CreateAccessPolicySettings);
            Modify_ApiCall(ref _callCreateAccessPolicy);
            Modify_CreateAccessPolicyApiCall(ref _callCreateAccessPolicy);
            _callUpdateAccessPolicy = clientHelper.BuildApiCall<UpdateAccessPolicyRequest, lro::Operation>("UpdateAccessPolicy", grpcClient.UpdateAccessPolicyAsync, grpcClient.UpdateAccessPolicy, effectiveSettings.UpdateAccessPolicySettings).WithGoogleRequestParam("policy.name", request => request.Policy?.Name);
            Modify_ApiCall(ref _callUpdateAccessPolicy);
            Modify_UpdateAccessPolicyApiCall(ref _callUpdateAccessPolicy);
            _callDeleteAccessPolicy = clientHelper.BuildApiCall<DeleteAccessPolicyRequest, lro::Operation>("DeleteAccessPolicy", grpcClient.DeleteAccessPolicyAsync, grpcClient.DeleteAccessPolicy, effectiveSettings.DeleteAccessPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAccessPolicy);
            Modify_DeleteAccessPolicyApiCall(ref _callDeleteAccessPolicy);
            _callListAccessLevels = clientHelper.BuildApiCall<ListAccessLevelsRequest, ListAccessLevelsResponse>("ListAccessLevels", grpcClient.ListAccessLevelsAsync, grpcClient.ListAccessLevels, effectiveSettings.ListAccessLevelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAccessLevels);
            Modify_ListAccessLevelsApiCall(ref _callListAccessLevels);
            _callGetAccessLevel = clientHelper.BuildApiCall<GetAccessLevelRequest, AccessLevel>("GetAccessLevel", grpcClient.GetAccessLevelAsync, grpcClient.GetAccessLevel, effectiveSettings.GetAccessLevelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAccessLevel);
            Modify_GetAccessLevelApiCall(ref _callGetAccessLevel);
            _callCreateAccessLevel = clientHelper.BuildApiCall<CreateAccessLevelRequest, lro::Operation>("CreateAccessLevel", grpcClient.CreateAccessLevelAsync, grpcClient.CreateAccessLevel, effectiveSettings.CreateAccessLevelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAccessLevel);
            Modify_CreateAccessLevelApiCall(ref _callCreateAccessLevel);
            _callUpdateAccessLevel = clientHelper.BuildApiCall<UpdateAccessLevelRequest, lro::Operation>("UpdateAccessLevel", grpcClient.UpdateAccessLevelAsync, grpcClient.UpdateAccessLevel, effectiveSettings.UpdateAccessLevelSettings).WithGoogleRequestParam("access_level.name", request => request.AccessLevel?.Name);
            Modify_ApiCall(ref _callUpdateAccessLevel);
            Modify_UpdateAccessLevelApiCall(ref _callUpdateAccessLevel);
            _callDeleteAccessLevel = clientHelper.BuildApiCall<DeleteAccessLevelRequest, lro::Operation>("DeleteAccessLevel", grpcClient.DeleteAccessLevelAsync, grpcClient.DeleteAccessLevel, effectiveSettings.DeleteAccessLevelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAccessLevel);
            Modify_DeleteAccessLevelApiCall(ref _callDeleteAccessLevel);
            _callReplaceAccessLevels = clientHelper.BuildApiCall<ReplaceAccessLevelsRequest, lro::Operation>("ReplaceAccessLevels", grpcClient.ReplaceAccessLevelsAsync, grpcClient.ReplaceAccessLevels, effectiveSettings.ReplaceAccessLevelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callReplaceAccessLevels);
            Modify_ReplaceAccessLevelsApiCall(ref _callReplaceAccessLevels);
            _callListServicePerimeters = clientHelper.BuildApiCall<ListServicePerimetersRequest, ListServicePerimetersResponse>("ListServicePerimeters", grpcClient.ListServicePerimetersAsync, grpcClient.ListServicePerimeters, effectiveSettings.ListServicePerimetersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServicePerimeters);
            Modify_ListServicePerimetersApiCall(ref _callListServicePerimeters);
            _callGetServicePerimeter = clientHelper.BuildApiCall<GetServicePerimeterRequest, ServicePerimeter>("GetServicePerimeter", grpcClient.GetServicePerimeterAsync, grpcClient.GetServicePerimeter, effectiveSettings.GetServicePerimeterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServicePerimeter);
            Modify_GetServicePerimeterApiCall(ref _callGetServicePerimeter);
            _callCreateServicePerimeter = clientHelper.BuildApiCall<CreateServicePerimeterRequest, lro::Operation>("CreateServicePerimeter", grpcClient.CreateServicePerimeterAsync, grpcClient.CreateServicePerimeter, effectiveSettings.CreateServicePerimeterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateServicePerimeter);
            Modify_CreateServicePerimeterApiCall(ref _callCreateServicePerimeter);
            _callUpdateServicePerimeter = clientHelper.BuildApiCall<UpdateServicePerimeterRequest, lro::Operation>("UpdateServicePerimeter", grpcClient.UpdateServicePerimeterAsync, grpcClient.UpdateServicePerimeter, effectiveSettings.UpdateServicePerimeterSettings).WithGoogleRequestParam("service_perimeter.name", request => request.ServicePerimeter?.Name);
            Modify_ApiCall(ref _callUpdateServicePerimeter);
            Modify_UpdateServicePerimeterApiCall(ref _callUpdateServicePerimeter);
            _callDeleteServicePerimeter = clientHelper.BuildApiCall<DeleteServicePerimeterRequest, lro::Operation>("DeleteServicePerimeter", grpcClient.DeleteServicePerimeterAsync, grpcClient.DeleteServicePerimeter, effectiveSettings.DeleteServicePerimeterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServicePerimeter);
            Modify_DeleteServicePerimeterApiCall(ref _callDeleteServicePerimeter);
            _callReplaceServicePerimeters = clientHelper.BuildApiCall<ReplaceServicePerimetersRequest, lro::Operation>("ReplaceServicePerimeters", grpcClient.ReplaceServicePerimetersAsync, grpcClient.ReplaceServicePerimeters, effectiveSettings.ReplaceServicePerimetersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callReplaceServicePerimeters);
            Modify_ReplaceServicePerimetersApiCall(ref _callReplaceServicePerimeters);
            _callCommitServicePerimeters = clientHelper.BuildApiCall<CommitServicePerimetersRequest, lro::Operation>("CommitServicePerimeters", grpcClient.CommitServicePerimetersAsync, grpcClient.CommitServicePerimeters, effectiveSettings.CommitServicePerimetersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCommitServicePerimeters);
            Modify_CommitServicePerimetersApiCall(ref _callCommitServicePerimeters);
            _callListGcpUserAccessBindings = clientHelper.BuildApiCall<ListGcpUserAccessBindingsRequest, ListGcpUserAccessBindingsResponse>("ListGcpUserAccessBindings", grpcClient.ListGcpUserAccessBindingsAsync, grpcClient.ListGcpUserAccessBindings, effectiveSettings.ListGcpUserAccessBindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGcpUserAccessBindings);
            Modify_ListGcpUserAccessBindingsApiCall(ref _callListGcpUserAccessBindings);
            _callGetGcpUserAccessBinding = clientHelper.BuildApiCall<GetGcpUserAccessBindingRequest, GcpUserAccessBinding>("GetGcpUserAccessBinding", grpcClient.GetGcpUserAccessBindingAsync, grpcClient.GetGcpUserAccessBinding, effectiveSettings.GetGcpUserAccessBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGcpUserAccessBinding);
            Modify_GetGcpUserAccessBindingApiCall(ref _callGetGcpUserAccessBinding);
            _callCreateGcpUserAccessBinding = clientHelper.BuildApiCall<CreateGcpUserAccessBindingRequest, lro::Operation>("CreateGcpUserAccessBinding", grpcClient.CreateGcpUserAccessBindingAsync, grpcClient.CreateGcpUserAccessBinding, effectiveSettings.CreateGcpUserAccessBindingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGcpUserAccessBinding);
            Modify_CreateGcpUserAccessBindingApiCall(ref _callCreateGcpUserAccessBinding);
            _callUpdateGcpUserAccessBinding = clientHelper.BuildApiCall<UpdateGcpUserAccessBindingRequest, lro::Operation>("UpdateGcpUserAccessBinding", grpcClient.UpdateGcpUserAccessBindingAsync, grpcClient.UpdateGcpUserAccessBinding, effectiveSettings.UpdateGcpUserAccessBindingSettings).WithGoogleRequestParam("gcp_user_access_binding.name", request => request.GcpUserAccessBinding?.Name);
            Modify_ApiCall(ref _callUpdateGcpUserAccessBinding);
            Modify_UpdateGcpUserAccessBindingApiCall(ref _callUpdateGcpUserAccessBinding);
            _callDeleteGcpUserAccessBinding = clientHelper.BuildApiCall<DeleteGcpUserAccessBindingRequest, lro::Operation>("DeleteGcpUserAccessBinding", grpcClient.DeleteGcpUserAccessBindingAsync, grpcClient.DeleteGcpUserAccessBinding, effectiveSettings.DeleteGcpUserAccessBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGcpUserAccessBinding);
            Modify_DeleteGcpUserAccessBindingApiCall(ref _callDeleteGcpUserAccessBinding);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAccessPoliciesApiCall(ref gaxgrpc::ApiCall<ListAccessPoliciesRequest, ListAccessPoliciesResponse> call);

        partial void Modify_GetAccessPolicyApiCall(ref gaxgrpc::ApiCall<GetAccessPolicyRequest, AccessPolicy> call);

        partial void Modify_CreateAccessPolicyApiCall(ref gaxgrpc::ApiCall<AccessPolicy, lro::Operation> call);

        partial void Modify_UpdateAccessPolicyApiCall(ref gaxgrpc::ApiCall<UpdateAccessPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteAccessPolicyApiCall(ref gaxgrpc::ApiCall<DeleteAccessPolicyRequest, lro::Operation> call);

        partial void Modify_ListAccessLevelsApiCall(ref gaxgrpc::ApiCall<ListAccessLevelsRequest, ListAccessLevelsResponse> call);

        partial void Modify_GetAccessLevelApiCall(ref gaxgrpc::ApiCall<GetAccessLevelRequest, AccessLevel> call);

        partial void Modify_CreateAccessLevelApiCall(ref gaxgrpc::ApiCall<CreateAccessLevelRequest, lro::Operation> call);

        partial void Modify_UpdateAccessLevelApiCall(ref gaxgrpc::ApiCall<UpdateAccessLevelRequest, lro::Operation> call);

        partial void Modify_DeleteAccessLevelApiCall(ref gaxgrpc::ApiCall<DeleteAccessLevelRequest, lro::Operation> call);

        partial void Modify_ReplaceAccessLevelsApiCall(ref gaxgrpc::ApiCall<ReplaceAccessLevelsRequest, lro::Operation> call);

        partial void Modify_ListServicePerimetersApiCall(ref gaxgrpc::ApiCall<ListServicePerimetersRequest, ListServicePerimetersResponse> call);

        partial void Modify_GetServicePerimeterApiCall(ref gaxgrpc::ApiCall<GetServicePerimeterRequest, ServicePerimeter> call);

        partial void Modify_CreateServicePerimeterApiCall(ref gaxgrpc::ApiCall<CreateServicePerimeterRequest, lro::Operation> call);

        partial void Modify_UpdateServicePerimeterApiCall(ref gaxgrpc::ApiCall<UpdateServicePerimeterRequest, lro::Operation> call);

        partial void Modify_DeleteServicePerimeterApiCall(ref gaxgrpc::ApiCall<DeleteServicePerimeterRequest, lro::Operation> call);

        partial void Modify_ReplaceServicePerimetersApiCall(ref gaxgrpc::ApiCall<ReplaceServicePerimetersRequest, lro::Operation> call);

        partial void Modify_CommitServicePerimetersApiCall(ref gaxgrpc::ApiCall<CommitServicePerimetersRequest, lro::Operation> call);

        partial void Modify_ListGcpUserAccessBindingsApiCall(ref gaxgrpc::ApiCall<ListGcpUserAccessBindingsRequest, ListGcpUserAccessBindingsResponse> call);

        partial void Modify_GetGcpUserAccessBindingApiCall(ref gaxgrpc::ApiCall<GetGcpUserAccessBindingRequest, GcpUserAccessBinding> call);

        partial void Modify_CreateGcpUserAccessBindingApiCall(ref gaxgrpc::ApiCall<CreateGcpUserAccessBindingRequest, lro::Operation> call);

        partial void Modify_UpdateGcpUserAccessBindingApiCall(ref gaxgrpc::ApiCall<UpdateGcpUserAccessBindingRequest, lro::Operation> call);

        partial void Modify_DeleteGcpUserAccessBindingApiCall(ref gaxgrpc::ApiCall<DeleteGcpUserAccessBindingRequest, lro::Operation> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(AccessContextManager.AccessContextManagerClient grpcClient, AccessContextManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccessContextManager client</summary>
        public override AccessContextManager.AccessContextManagerClient GrpcClient { get; }

        partial void Modify_ListAccessPoliciesRequest(ref ListAccessPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAccessPolicyRequest(ref GetAccessPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AccessPolicy(ref AccessPolicy request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAccessPolicyRequest(ref UpdateAccessPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAccessPolicyRequest(ref DeleteAccessPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAccessLevelsRequest(ref ListAccessLevelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAccessLevelRequest(ref GetAccessLevelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAccessLevelRequest(ref CreateAccessLevelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAccessLevelRequest(ref UpdateAccessLevelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAccessLevelRequest(ref DeleteAccessLevelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReplaceAccessLevelsRequest(ref ReplaceAccessLevelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServicePerimetersRequest(ref ListServicePerimetersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServicePerimeterRequest(ref GetServicePerimeterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServicePerimeterRequest(ref CreateServicePerimeterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServicePerimeterRequest(ref UpdateServicePerimeterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServicePerimeterRequest(ref DeleteServicePerimeterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReplaceServicePerimetersRequest(ref ReplaceServicePerimetersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CommitServicePerimetersRequest(ref CommitServicePerimetersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGcpUserAccessBindingsRequest(ref ListGcpUserAccessBindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGcpUserAccessBindingRequest(ref GetGcpUserAccessBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGcpUserAccessBindingRequest(ref CreateGcpUserAccessBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGcpUserAccessBindingRequest(ref UpdateGcpUserAccessBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGcpUserAccessBindingRequest(ref DeleteGcpUserAccessBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all [access policies]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] in an
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccessPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPolicies(ListAccessPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAccessPoliciesRequest, ListAccessPoliciesResponse, AccessPolicy>(_callListAccessPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists all [access policies]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] in an
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccessPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPoliciesAsync(ListAccessPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAccessPoliciesRequest, ListAccessPoliciesResponse, AccessPolicy>(_callListAccessPolicies, request, callSettings);
        }

        /// <summary>
        /// Returns an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccessPolicy GetAccessPolicy(GetAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccessPolicyRequest(ref request, ref callSettings);
            return _callGetAccessPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccessPolicy> GetAccessPolicyAsync(GetAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccessPolicyRequest(ref request, ref callSettings);
            return _callGetAccessPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAccessPolicy</c>.</summary>
        public override lro::OperationsClient CreateAccessPolicyOperationsClient { get; }

        /// <summary>
        /// Creates an access policy. This method fails if the organization already has
        /// an access policy. The long-running operation has a successful status
        /// after the access policy propagates to long-lasting storage.
        /// Syntactic and basic semantic errors are returned in `metadata` as a
        /// BadRequest proto.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata> CreateAccessPolicy(AccessPolicy request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AccessPolicy(ref request, ref callSettings);
            return new lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>(_callCreateAccessPolicy.Sync(request, callSettings), CreateAccessPolicyOperationsClient);
        }

        /// <summary>
        /// Creates an access policy. This method fails if the organization already has
        /// an access policy. The long-running operation has a successful status
        /// after the access policy propagates to long-lasting storage.
        /// Syntactic and basic semantic errors are returned in `metadata` as a
        /// BadRequest proto.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>> CreateAccessPolicyAsync(AccessPolicy request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AccessPolicy(ref request, ref callSettings);
            return new lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>(await _callCreateAccessPolicy.Async(request, callSettings).ConfigureAwait(false), CreateAccessPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAccessPolicy</c>.</summary>
        public override lro::OperationsClient UpdateAccessPolicyOperationsClient { get; }

        /// <summary>
        /// Updates an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy]. The
        /// long-running operation from this RPC has a successful status after the
        /// changes to the [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] propagate
        /// to long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata> UpdateAccessPolicy(UpdateAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccessPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>(_callUpdateAccessPolicy.Sync(request, callSettings), UpdateAccessPolicyOperationsClient);
        }

        /// <summary>
        /// Updates an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy]. The
        /// long-running operation from this RPC has a successful status after the
        /// changes to the [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] propagate
        /// to long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>> UpdateAccessPolicyAsync(UpdateAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccessPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AccessPolicy, AccessContextManagerOperationMetadata>(await _callUpdateAccessPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateAccessPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAccessPolicy</c>.</summary>
        public override lro::OperationsClient DeleteAccessPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the
        /// resource name. The long-running operation has a successful status after the
        /// [access policy] [google.identity.accesscontextmanager.v1.AccessPolicy]
        /// is removed from long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> DeleteAccessPolicy(DeleteAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccessPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>(_callDeleteAccessPolicy.Sync(request, callSettings), DeleteAccessPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes an [access policy]
        /// [google.identity.accesscontextmanager.v1.AccessPolicy] based on the
        /// resource name. The long-running operation has a successful status after the
        /// [access policy] [google.identity.accesscontextmanager.v1.AccessPolicy]
        /// is removed from long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessPolicyAsync(DeleteAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccessPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>(await _callDeleteAccessPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteAccessPolicyOperationsClient);
        }

        /// <summary>
        /// Lists all [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] for an access
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccessLevel"/> resources.</returns>
        public override gax::PagedEnumerable<ListAccessLevelsResponse, AccessLevel> ListAccessLevels(ListAccessLevelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessLevelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAccessLevelsRequest, ListAccessLevelsResponse, AccessLevel>(_callListAccessLevels, request, callSettings);
        }

        /// <summary>
        /// Lists all [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] for an access
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccessLevel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAccessLevelsResponse, AccessLevel> ListAccessLevelsAsync(ListAccessLevelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessLevelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAccessLevelsRequest, ListAccessLevelsResponse, AccessLevel>(_callListAccessLevels, request, callSettings);
        }

        /// <summary>
        /// Gets an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccessLevel GetAccessLevel(GetAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccessLevelRequest(ref request, ref callSettings);
            return _callGetAccessLevel.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccessLevel> GetAccessLevelAsync(GetAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccessLevelRequest(ref request, ref callSettings);
            return _callGetAccessLevel.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAccessLevel</c>.</summary>
        public override lro::OperationsClient CreateAccessLevelOperationsClient { get; }

        /// <summary>
        /// Creates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the [access
        /// level] [google.identity.accesscontextmanager.v1.AccessLevel]
        /// propagates to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AccessLevel, AccessContextManagerOperationMetadata> CreateAccessLevel(CreateAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAccessLevelRequest(ref request, ref callSettings);
            return new lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>(_callCreateAccessLevel.Sync(request, callSettings), CreateAccessLevelOperationsClient);
        }

        /// <summary>
        /// Creates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the [access
        /// level] [google.identity.accesscontextmanager.v1.AccessLevel]
        /// propagates to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> CreateAccessLevelAsync(CreateAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAccessLevelRequest(ref request, ref callSettings);
            return new lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>(await _callCreateAccessLevel.Async(request, callSettings).ConfigureAwait(false), CreateAccessLevelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAccessLevel</c>.</summary>
        public override lro::OperationsClient UpdateAccessLevelOperationsClient { get; }

        /// <summary>
        /// Updates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the changes to
        /// the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] propagate
        /// to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AccessLevel, AccessContextManagerOperationMetadata> UpdateAccessLevel(UpdateAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccessLevelRequest(ref request, ref callSettings);
            return new lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>(_callUpdateAccessLevel.Sync(request, callSettings), UpdateAccessLevelOperationsClient);
        }

        /// <summary>
        /// Updates an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel]. The long-running
        /// operation from this RPC has a successful status after the changes to
        /// the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] propagate
        /// to long-lasting storage. If [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contain
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>> UpdateAccessLevelAsync(UpdateAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccessLevelRequest(ref request, ref callSettings);
            return new lro::Operation<AccessLevel, AccessContextManagerOperationMetadata>(await _callUpdateAccessLevel.Async(request, callSettings).ConfigureAwait(false), UpdateAccessLevelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAccessLevel</c>.</summary>
        public override lro::OperationsClient DeleteAccessLevelOperationsClient { get; }

        /// <summary>
        /// Deletes an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name. The long-running operation from this RPC has a successful status
        /// after the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] has been removed
        /// from long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> DeleteAccessLevel(DeleteAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccessLevelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>(_callDeleteAccessLevel.Sync(request, callSettings), DeleteAccessLevelOperationsClient);
        }

        /// <summary>
        /// Deletes an [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] based on the resource
        /// name. The long-running operation from this RPC has a successful status
        /// after the [access level]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] has been removed
        /// from long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteAccessLevelAsync(DeleteAccessLevelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccessLevelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>(await _callDeleteAccessLevel.Async(request, callSettings).ConfigureAwait(false), DeleteAccessLevelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReplaceAccessLevels</c>.</summary>
        public override lro::OperationsClient ReplaceAccessLevelsOperationsClient { get; }

        /// <summary>
        /// Replaces all existing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] in an [access
        /// policy] [google.identity.accesscontextmanager.v1.AccessPolicy] with
        /// the [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] provided. This
        /// is done atomically. The long-running operation from this RPC has a
        /// successful status after all replacements propagate to long-lasting
        /// storage. If the replacement contains errors, an error response is returned
        /// for the first error encountered.  Upon error, the replacement is cancelled,
        /// and existing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] are not
        /// affected. The Operation.response field contains
        /// ReplaceAccessLevelsResponse. Removing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contained in existing
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] result in an
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata> ReplaceAccessLevels(ReplaceAccessLevelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReplaceAccessLevelsRequest(ref request, ref callSettings);
            return new lro::Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata>(_callReplaceAccessLevels.Sync(request, callSettings), ReplaceAccessLevelsOperationsClient);
        }

        /// <summary>
        /// Replaces all existing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] in an [access
        /// policy] [google.identity.accesscontextmanager.v1.AccessPolicy] with
        /// the [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] provided. This
        /// is done atomically. The long-running operation from this RPC has a
        /// successful status after all replacements propagate to long-lasting
        /// storage. If the replacement contains errors, an error response is returned
        /// for the first error encountered.  Upon error, the replacement is cancelled,
        /// and existing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] are not
        /// affected. The Operation.response field contains
        /// ReplaceAccessLevelsResponse. Removing [access levels]
        /// [google.identity.accesscontextmanager.v1.AccessLevel] contained in existing
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] result in an
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata>> ReplaceAccessLevelsAsync(ReplaceAccessLevelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReplaceAccessLevelsRequest(ref request, ref callSettings);
            return new lro::Operation<ReplaceAccessLevelsResponse, AccessContextManagerOperationMetadata>(await _callReplaceAccessLevels.Async(request, callSettings).ConfigureAwait(false), ReplaceAccessLevelsOperationsClient);
        }

        /// <summary>
        /// Lists all [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] for an
        /// access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServicePerimeter"/> resources.</returns>
        public override gax::PagedEnumerable<ListServicePerimetersResponse, ServicePerimeter> ListServicePerimeters(ListServicePerimetersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicePerimetersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServicePerimetersRequest, ListServicePerimetersResponse, ServicePerimeter>(_callListServicePerimeters, request, callSettings);
        }

        /// <summary>
        /// Lists all [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] for an
        /// access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServicePerimeter"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServicePerimetersResponse, ServicePerimeter> ListServicePerimetersAsync(ListServicePerimetersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicePerimetersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServicePerimetersRequest, ListServicePerimetersResponse, ServicePerimeter>(_callListServicePerimeters, request, callSettings);
        }

        /// <summary>
        /// Gets a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServicePerimeter GetServicePerimeter(GetServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServicePerimeterRequest(ref request, ref callSettings);
            return _callGetServicePerimeter.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServicePerimeter> GetServicePerimeterAsync(GetServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServicePerimeterRequest(ref request, ref callSettings);
            return _callGetServicePerimeter.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateServicePerimeter</c>.</summary>
        public override lro::OperationsClient CreateServicePerimeterOperationsClient { get; }

        /// <summary>
        /// Creates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata> CreateServicePerimeter(CreateServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServicePerimeterRequest(ref request, ref callSettings);
            return new lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>(_callCreateServicePerimeter.Sync(request, callSettings), CreateServicePerimeterOperationsClient);
        }

        /// <summary>
        /// Creates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> CreateServicePerimeterAsync(CreateServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServicePerimeterRequest(ref request, ref callSettings);
            return new lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>(await _callCreateServicePerimeter.Async(request, callSettings).ConfigureAwait(false), CreateServicePerimeterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateServicePerimeter</c>.</summary>
        public override lro::OperationsClient UpdateServicePerimeterOperationsClient { get; }

        /// <summary>
        /// Updates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata> UpdateServicePerimeter(UpdateServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServicePerimeterRequest(ref request, ref callSettings);
            return new lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>(_callUpdateServicePerimeter.Sync(request, callSettings), UpdateServicePerimeterOperationsClient);
        }

        /// <summary>
        /// Updates a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        /// long-running operation from this RPC has a successful status after the
        /// [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter]
        /// propagates to long-lasting storage. If a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] contains
        /// errors, an error response is returned for the first error encountered.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>> UpdateServicePerimeterAsync(UpdateServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServicePerimeterRequest(ref request, ref callSettings);
            return new lro::Operation<ServicePerimeter, AccessContextManagerOperationMetadata>(await _callUpdateServicePerimeter.Async(request, callSettings).ConfigureAwait(false), UpdateServicePerimeterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteServicePerimeter</c>.</summary>
        public override lro::OperationsClient DeleteServicePerimeterOperationsClient { get; }

        /// <summary>
        /// Deletes a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name. The long-running operation from this RPC has a successful
        /// status after the [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is removed from
        /// long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata> DeleteServicePerimeter(DeleteServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServicePerimeterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>(_callDeleteServicePerimeter.Sync(request, callSettings), DeleteServicePerimeterOperationsClient);
        }

        /// <summary>
        /// Deletes a [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] based on the
        /// resource name. The long-running operation from this RPC has a successful
        /// status after the [service perimeter]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] is removed from
        /// long-lasting storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>> DeleteServicePerimeterAsync(DeleteServicePerimeterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServicePerimeterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, AccessContextManagerOperationMetadata>(await _callDeleteServicePerimeter.Async(request, callSettings).ConfigureAwait(false), DeleteServicePerimeterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReplaceServicePerimeters</c>.</summary>
        public override lro::OperationsClient ReplaceServicePerimetersOperationsClient { get; }

        /// <summary>
        /// Replace all existing [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] in an [access
        /// policy] [google.identity.accesscontextmanager.v1.AccessPolicy] with the
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] provided. This
        /// is done atomically. The long-running operation from this RPC has a
        /// successful status after all replacements propagate to long-lasting storage.
        /// Replacements containing errors result in an error response for the first
        /// error encountered. Upon an error, replacement are cancelled and existing
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] are not
        /// affected. The Operation.response field contains
        /// ReplaceServicePerimetersResponse.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata> ReplaceServicePerimeters(ReplaceServicePerimetersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReplaceServicePerimetersRequest(ref request, ref callSettings);
            return new lro::Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata>(_callReplaceServicePerimeters.Sync(request, callSettings), ReplaceServicePerimetersOperationsClient);
        }

        /// <summary>
        /// Replace all existing [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] in an [access
        /// policy] [google.identity.accesscontextmanager.v1.AccessPolicy] with the
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] provided. This
        /// is done atomically. The long-running operation from this RPC has a
        /// successful status after all replacements propagate to long-lasting storage.
        /// Replacements containing errors result in an error response for the first
        /// error encountered. Upon an error, replacement are cancelled and existing
        /// [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] are not
        /// affected. The Operation.response field contains
        /// ReplaceServicePerimetersResponse.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata>> ReplaceServicePerimetersAsync(ReplaceServicePerimetersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReplaceServicePerimetersRequest(ref request, ref callSettings);
            return new lro::Operation<ReplaceServicePerimetersResponse, AccessContextManagerOperationMetadata>(await _callReplaceServicePerimeters.Async(request, callSettings).ConfigureAwait(false), ReplaceServicePerimetersOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CommitServicePerimeters</c>.</summary>
        public override lro::OperationsClient CommitServicePerimetersOperationsClient { get; }

        /// <summary>
        /// Commits the dry-run specification for all the [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] in an
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// A commit operation on a service perimeter involves copying its `spec` field
        /// to the `status` field of the service perimeter. Only [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] with
        /// `use_explicit_dry_run_spec` field set to true are affected by a commit
        /// operation. The long-running operation from this RPC has a successful
        /// status after the dry-run specifications for all the [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] have been
        /// committed. If a commit fails, it causes the long-running operation to
        /// return an error response and the entire commit operation is cancelled.
        /// When successful, the Operation.response field contains
        /// CommitServicePerimetersResponse. The `dry_run` and the `spec` fields are
        /// cleared after a successful commit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata> CommitServicePerimeters(CommitServicePerimetersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitServicePerimetersRequest(ref request, ref callSettings);
            return new lro::Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata>(_callCommitServicePerimeters.Sync(request, callSettings), CommitServicePerimetersOperationsClient);
        }

        /// <summary>
        /// Commits the dry-run specification for all the [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] in an
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// A commit operation on a service perimeter involves copying its `spec` field
        /// to the `status` field of the service perimeter. Only [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] with
        /// `use_explicit_dry_run_spec` field set to true are affected by a commit
        /// operation. The long-running operation from this RPC has a successful
        /// status after the dry-run specifications for all the [service perimeters]
        /// [google.identity.accesscontextmanager.v1.ServicePerimeter] have been
        /// committed. If a commit fails, it causes the long-running operation to
        /// return an error response and the entire commit operation is cancelled.
        /// When successful, the Operation.response field contains
        /// CommitServicePerimetersResponse. The `dry_run` and the `spec` fields are
        /// cleared after a successful commit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata>> CommitServicePerimetersAsync(CommitServicePerimetersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitServicePerimetersRequest(ref request, ref callSettings);
            return new lro::Operation<CommitServicePerimetersResponse, AccessContextManagerOperationMetadata>(await _callCommitServicePerimeters.Async(request, callSettings).ConfigureAwait(false), CommitServicePerimetersOperationsClient);
        }

        /// <summary>
        /// Lists all [GcpUserAccessBindings]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] for a
        /// Google Cloud organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GcpUserAccessBinding"/> resources.</returns>
        public override gax::PagedEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> ListGcpUserAccessBindings(ListGcpUserAccessBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGcpUserAccessBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGcpUserAccessBindingsRequest, ListGcpUserAccessBindingsResponse, GcpUserAccessBinding>(_callListGcpUserAccessBindings, request, callSettings);
        }

        /// <summary>
        /// Lists all [GcpUserAccessBindings]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] for a
        /// Google Cloud organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GcpUserAccessBinding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGcpUserAccessBindingsResponse, GcpUserAccessBinding> ListGcpUserAccessBindingsAsync(ListGcpUserAccessBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGcpUserAccessBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGcpUserAccessBindingsRequest, ListGcpUserAccessBindingsResponse, GcpUserAccessBinding>(_callListGcpUserAccessBindings, request, callSettings);
        }

        /// <summary>
        /// Gets the [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] with
        /// the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GcpUserAccessBinding GetGcpUserAccessBinding(GetGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGcpUserAccessBindingRequest(ref request, ref callSettings);
            return _callGetGcpUserAccessBinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding] with
        /// the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GcpUserAccessBinding> GetGcpUserAccessBindingAsync(GetGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGcpUserAccessBindingRequest(ref request, ref callSettings);
            return _callGetGcpUserAccessBinding.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateGcpUserAccessBinding</c>.</summary>
        public override lro::OperationsClient CreateGcpUserAccessBindingOperationsClient { get; }

        /// <summary>
        /// Creates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]. If the
        /// client specifies a [name]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        /// the server ignores it. Fails if a resource already exists with the same
        /// [group_key]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        /// Completion of this long-running operation does not necessarily signify that
        /// the new binding is deployed onto all affected users, which may take more
        /// time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> CreateGcpUserAccessBinding(CreateGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGcpUserAccessBindingRequest(ref request, ref callSettings);
            return new lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>(_callCreateGcpUserAccessBinding.Sync(request, callSettings), CreateGcpUserAccessBindingOperationsClient);
        }

        /// <summary>
        /// Creates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]. If the
        /// client specifies a [name]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        /// the server ignores it. Fails if a resource already exists with the same
        /// [group_key]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        /// Completion of this long-running operation does not necessarily signify that
        /// the new binding is deployed onto all affected users, which may take more
        /// time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> CreateGcpUserAccessBindingAsync(CreateGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGcpUserAccessBindingRequest(ref request, ref callSettings);
            return new lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>(await _callCreateGcpUserAccessBinding.Async(request, callSettings).ConfigureAwait(false), CreateGcpUserAccessBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateGcpUserAccessBinding</c>.</summary>
        public override lro::OperationsClient UpdateGcpUserAccessBindingOperationsClient { get; }

        /// <summary>
        /// Updates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the changed binding is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> UpdateGcpUserAccessBinding(UpdateGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGcpUserAccessBindingRequest(ref request, ref callSettings);
            return new lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>(_callUpdateGcpUserAccessBinding.Sync(request, callSettings), UpdateGcpUserAccessBindingOperationsClient);
        }

        /// <summary>
        /// Updates a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the changed binding is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>> UpdateGcpUserAccessBindingAsync(UpdateGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGcpUserAccessBindingRequest(ref request, ref callSettings);
            return new lro::Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata>(await _callUpdateGcpUserAccessBinding.Async(request, callSettings).ConfigureAwait(false), UpdateGcpUserAccessBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteGcpUserAccessBinding</c>.</summary>
        public override lro::OperationsClient DeleteGcpUserAccessBindingOperationsClient { get; }

        /// <summary>
        /// Deletes a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the binding deletion is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata> DeleteGcpUserAccessBinding(DeleteGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGcpUserAccessBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata>(_callDeleteGcpUserAccessBinding.Sync(request, callSettings), DeleteGcpUserAccessBindingOperationsClient);
        }

        /// <summary>
        /// Deletes a [GcpUserAccessBinding]
        /// [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        /// Completion of this long-running operation does not necessarily signify that
        /// the binding deletion is deployed onto all affected users, which may take
        /// more time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata>> DeleteGcpUserAccessBindingAsync(DeleteGcpUserAccessBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGcpUserAccessBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, GcpUserAccessBindingOperationMetadata>(await _callDeleteGcpUserAccessBinding.Async(request, callSettings).ConfigureAwait(false), DeleteGcpUserAccessBindingOperationsClient);
        }

        /// <summary>
        /// Sets the IAM policy for the specified Access Context Manager
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// This method replaces the existing IAM policy on the access policy. The IAM
        /// policy controls the set of users who can perform specific operations on the
        /// Access Context Manager [access
        /// policy][google.identity.accesscontextmanager.v1.AccessPolicy].
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
        /// Sets the IAM policy for the specified Access Context Manager
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
        /// This method replaces the existing IAM policy on the access policy. The IAM
        /// policy controls the set of users who can perform specific operations on the
        /// Access Context Manager [access
        /// policy][google.identity.accesscontextmanager.v1.AccessPolicy].
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
        /// Gets the IAM policy for the specified Access Context Manager
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
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
        /// Gets the IAM policy for the specified Access Context Manager
        /// [access policy][google.identity.accesscontextmanager.v1.AccessPolicy].
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
        /// Returns the IAM permissions that the caller has on the specified Access
        /// Context Manager resource. The resource can be an
        /// [AccessPolicy][google.identity.accesscontextmanager.v1.AccessPolicy],
        /// [AccessLevel][google.identity.accesscontextmanager.v1.AccessLevel], or
        /// [ServicePerimeter][google.identity.accesscontextmanager.v1.ServicePerimeter
        /// ]. This method does not support other resources.
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
        /// Returns the IAM permissions that the caller has on the specified Access
        /// Context Manager resource. The resource can be an
        /// [AccessPolicy][google.identity.accesscontextmanager.v1.AccessPolicy],
        /// [AccessLevel][google.identity.accesscontextmanager.v1.AccessLevel], or
        /// [ServicePerimeter][google.identity.accesscontextmanager.v1.ServicePerimeter
        /// ]. This method does not support other resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class ListAccessPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAccessLevelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServicePerimetersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGcpUserAccessBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAccessPoliciesResponse : gaxgrpc::IPageResponse<AccessPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AccessPolicy> GetEnumerator() => AccessPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAccessLevelsResponse : gaxgrpc::IPageResponse<AccessLevel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AccessLevel> GetEnumerator() => AccessLevels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServicePerimetersResponse : gaxgrpc::IPageResponse<ServicePerimeter>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ServicePerimeter> GetEnumerator() => ServicePerimeters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGcpUserAccessBindingsResponse : gaxgrpc::IPageResponse<GcpUserAccessBinding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GcpUserAccessBinding> GetEnumerator() => GcpUserAccessBindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AccessContextManager
    {
        public partial class AccessContextManagerClient
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
