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

namespace Google.Cloud.NetworkSecurity.V1
{
    /// <summary>Settings for <see cref="InterceptClient"/> instances.</summary>
    public sealed partial class InterceptSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="InterceptSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="InterceptSettings"/>.</returns>
        public static InterceptSettings GetDefault() => new InterceptSettings();

        /// <summary>Constructs a new <see cref="InterceptSettings"/> object with default settings.</summary>
        public InterceptSettings()
        {
        }

        private InterceptSettings(InterceptSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInterceptEndpointGroupsSettings = existing.ListInterceptEndpointGroupsSettings;
            GetInterceptEndpointGroupSettings = existing.GetInterceptEndpointGroupSettings;
            CreateInterceptEndpointGroupSettings = existing.CreateInterceptEndpointGroupSettings;
            CreateInterceptEndpointGroupOperationsSettings = existing.CreateInterceptEndpointGroupOperationsSettings.Clone();
            UpdateInterceptEndpointGroupSettings = existing.UpdateInterceptEndpointGroupSettings;
            UpdateInterceptEndpointGroupOperationsSettings = existing.UpdateInterceptEndpointGroupOperationsSettings.Clone();
            DeleteInterceptEndpointGroupSettings = existing.DeleteInterceptEndpointGroupSettings;
            DeleteInterceptEndpointGroupOperationsSettings = existing.DeleteInterceptEndpointGroupOperationsSettings.Clone();
            ListInterceptEndpointGroupAssociationsSettings = existing.ListInterceptEndpointGroupAssociationsSettings;
            GetInterceptEndpointGroupAssociationSettings = existing.GetInterceptEndpointGroupAssociationSettings;
            CreateInterceptEndpointGroupAssociationSettings = existing.CreateInterceptEndpointGroupAssociationSettings;
            CreateInterceptEndpointGroupAssociationOperationsSettings = existing.CreateInterceptEndpointGroupAssociationOperationsSettings.Clone();
            UpdateInterceptEndpointGroupAssociationSettings = existing.UpdateInterceptEndpointGroupAssociationSettings;
            UpdateInterceptEndpointGroupAssociationOperationsSettings = existing.UpdateInterceptEndpointGroupAssociationOperationsSettings.Clone();
            DeleteInterceptEndpointGroupAssociationSettings = existing.DeleteInterceptEndpointGroupAssociationSettings;
            DeleteInterceptEndpointGroupAssociationOperationsSettings = existing.DeleteInterceptEndpointGroupAssociationOperationsSettings.Clone();
            ListInterceptDeploymentGroupsSettings = existing.ListInterceptDeploymentGroupsSettings;
            GetInterceptDeploymentGroupSettings = existing.GetInterceptDeploymentGroupSettings;
            CreateInterceptDeploymentGroupSettings = existing.CreateInterceptDeploymentGroupSettings;
            CreateInterceptDeploymentGroupOperationsSettings = existing.CreateInterceptDeploymentGroupOperationsSettings.Clone();
            UpdateInterceptDeploymentGroupSettings = existing.UpdateInterceptDeploymentGroupSettings;
            UpdateInterceptDeploymentGroupOperationsSettings = existing.UpdateInterceptDeploymentGroupOperationsSettings.Clone();
            DeleteInterceptDeploymentGroupSettings = existing.DeleteInterceptDeploymentGroupSettings;
            DeleteInterceptDeploymentGroupOperationsSettings = existing.DeleteInterceptDeploymentGroupOperationsSettings.Clone();
            ListInterceptDeploymentsSettings = existing.ListInterceptDeploymentsSettings;
            GetInterceptDeploymentSettings = existing.GetInterceptDeploymentSettings;
            CreateInterceptDeploymentSettings = existing.CreateInterceptDeploymentSettings;
            CreateInterceptDeploymentOperationsSettings = existing.CreateInterceptDeploymentOperationsSettings.Clone();
            UpdateInterceptDeploymentSettings = existing.UpdateInterceptDeploymentSettings;
            UpdateInterceptDeploymentOperationsSettings = existing.UpdateInterceptDeploymentOperationsSettings.Clone();
            DeleteInterceptDeploymentSettings = existing.DeleteInterceptDeploymentSettings;
            DeleteInterceptDeploymentOperationsSettings = existing.DeleteInterceptDeploymentOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(InterceptSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.ListInterceptEndpointGroups</c> and <c>InterceptClient.ListInterceptEndpointGroupsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInterceptEndpointGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.GetInterceptEndpointGroup</c> and <c>InterceptClient.GetInterceptEndpointGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInterceptEndpointGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.CreateInterceptEndpointGroup</c> and <c>InterceptClient.CreateInterceptEndpointGroupAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInterceptEndpointGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InterceptClient.CreateInterceptEndpointGroup</c> and
        /// <c>InterceptClient.CreateInterceptEndpointGroupAsync</c>.
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
        public lro::OperationsSettings CreateInterceptEndpointGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.UpdateInterceptEndpointGroup</c> and <c>InterceptClient.UpdateInterceptEndpointGroupAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInterceptEndpointGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InterceptClient.UpdateInterceptEndpointGroup</c> and
        /// <c>InterceptClient.UpdateInterceptEndpointGroupAsync</c>.
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
        public lro::OperationsSettings UpdateInterceptEndpointGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.DeleteInterceptEndpointGroup</c> and <c>InterceptClient.DeleteInterceptEndpointGroupAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInterceptEndpointGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InterceptClient.DeleteInterceptEndpointGroup</c> and
        /// <c>InterceptClient.DeleteInterceptEndpointGroupAsync</c>.
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
        public lro::OperationsSettings DeleteInterceptEndpointGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.ListInterceptEndpointGroupAssociations</c> and
        /// <c>InterceptClient.ListInterceptEndpointGroupAssociationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInterceptEndpointGroupAssociationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.GetInterceptEndpointGroupAssociation</c> and
        /// <c>InterceptClient.GetInterceptEndpointGroupAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInterceptEndpointGroupAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.CreateInterceptEndpointGroupAssociation</c> and
        /// <c>InterceptClient.CreateInterceptEndpointGroupAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInterceptEndpointGroupAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InterceptClient.CreateInterceptEndpointGroupAssociation</c>
        /// and <c>InterceptClient.CreateInterceptEndpointGroupAssociationAsync</c>.
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
        public lro::OperationsSettings CreateInterceptEndpointGroupAssociationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.UpdateInterceptEndpointGroupAssociation</c> and
        /// <c>InterceptClient.UpdateInterceptEndpointGroupAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInterceptEndpointGroupAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InterceptClient.UpdateInterceptEndpointGroupAssociation</c>
        /// and <c>InterceptClient.UpdateInterceptEndpointGroupAssociationAsync</c>.
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
        public lro::OperationsSettings UpdateInterceptEndpointGroupAssociationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.DeleteInterceptEndpointGroupAssociation</c> and
        /// <c>InterceptClient.DeleteInterceptEndpointGroupAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInterceptEndpointGroupAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InterceptClient.DeleteInterceptEndpointGroupAssociation</c>
        /// and <c>InterceptClient.DeleteInterceptEndpointGroupAssociationAsync</c>.
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
        public lro::OperationsSettings DeleteInterceptEndpointGroupAssociationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.ListInterceptDeploymentGroups</c> and
        /// <c>InterceptClient.ListInterceptDeploymentGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInterceptDeploymentGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.GetInterceptDeploymentGroup</c> and <c>InterceptClient.GetInterceptDeploymentGroupAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInterceptDeploymentGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.CreateInterceptDeploymentGroup</c> and
        /// <c>InterceptClient.CreateInterceptDeploymentGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInterceptDeploymentGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InterceptClient.CreateInterceptDeploymentGroup</c> and
        /// <c>InterceptClient.CreateInterceptDeploymentGroupAsync</c>.
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
        public lro::OperationsSettings CreateInterceptDeploymentGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.UpdateInterceptDeploymentGroup</c> and
        /// <c>InterceptClient.UpdateInterceptDeploymentGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInterceptDeploymentGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InterceptClient.UpdateInterceptDeploymentGroup</c> and
        /// <c>InterceptClient.UpdateInterceptDeploymentGroupAsync</c>.
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
        public lro::OperationsSettings UpdateInterceptDeploymentGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.DeleteInterceptDeploymentGroup</c> and
        /// <c>InterceptClient.DeleteInterceptDeploymentGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInterceptDeploymentGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InterceptClient.DeleteInterceptDeploymentGroup</c> and
        /// <c>InterceptClient.DeleteInterceptDeploymentGroupAsync</c>.
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
        public lro::OperationsSettings DeleteInterceptDeploymentGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.ListInterceptDeployments</c> and <c>InterceptClient.ListInterceptDeploymentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInterceptDeploymentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.GetInterceptDeployment</c> and <c>InterceptClient.GetInterceptDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInterceptDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.CreateInterceptDeployment</c> and <c>InterceptClient.CreateInterceptDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInterceptDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InterceptClient.CreateInterceptDeployment</c> and
        /// <c>InterceptClient.CreateInterceptDeploymentAsync</c>.
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
        public lro::OperationsSettings CreateInterceptDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.UpdateInterceptDeployment</c> and <c>InterceptClient.UpdateInterceptDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInterceptDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InterceptClient.UpdateInterceptDeployment</c> and
        /// <c>InterceptClient.UpdateInterceptDeploymentAsync</c>.
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
        public lro::OperationsSettings UpdateInterceptDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InterceptClient.DeleteInterceptDeployment</c> and <c>InterceptClient.DeleteInterceptDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInterceptDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InterceptClient.DeleteInterceptDeployment</c> and
        /// <c>InterceptClient.DeleteInterceptDeploymentAsync</c>.
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
        public lro::OperationsSettings DeleteInterceptDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="InterceptSettings"/> object.</returns>
        public InterceptSettings Clone() => new InterceptSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="InterceptClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class InterceptClientBuilder : gaxgrpc::ClientBuilderBase<InterceptClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public InterceptSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public InterceptClientBuilder() : base(InterceptClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref InterceptClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<InterceptClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override InterceptClient Build()
        {
            InterceptClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<InterceptClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<InterceptClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private InterceptClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return InterceptClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<InterceptClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return InterceptClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => InterceptClient.ChannelPool;
    }

    /// <summary>Intercept client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for Third-Party Packet Intercept (TPPI).
    /// TPPI is the "in-band" flavor of the Network Security Integrations product.
    /// </remarks>
    public abstract partial class InterceptClient
    {
        /// <summary>
        /// The default endpoint for the Intercept service, which is a host of "networksecurity.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networksecurity.googleapis.com:443";

        /// <summary>The default Intercept scopes.</summary>
        /// <remarks>
        /// The default Intercept scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Intercept.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="InterceptClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="InterceptClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="InterceptClient"/>.</returns>
        public static stt::Task<InterceptClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new InterceptClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="InterceptClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="InterceptClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="InterceptClient"/>.</returns>
        public static InterceptClient Create() => new InterceptClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="InterceptClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="InterceptSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="InterceptClient"/>.</returns>
        internal static InterceptClient Create(grpccore::CallInvoker callInvoker, InterceptSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Intercept.InterceptClient grpcClient = new Intercept.InterceptClient(callInvoker);
            return new InterceptClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Intercept client</summary>
        public virtual Intercept.InterceptClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists endpoint groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptEndpointGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> ListInterceptEndpointGroups(ListInterceptEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists endpoint groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterceptEndpointGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> ListInterceptEndpointGroupsAsync(ListInterceptEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists endpoint groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of endpoint groups.
        /// Example: `projects/123456789/locations/global`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptEndpointGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> ListInterceptEndpointGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptEndpointGroupsRequest request = new ListInterceptEndpointGroupsRequest
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
            return ListInterceptEndpointGroups(request, callSettings);
        }

        /// <summary>
        /// Lists endpoint groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of endpoint groups.
        /// Example: `projects/123456789/locations/global`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterceptEndpointGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> ListInterceptEndpointGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptEndpointGroupsRequest request = new ListInterceptEndpointGroupsRequest
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
            return ListInterceptEndpointGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists endpoint groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of endpoint groups.
        /// Example: `projects/123456789/locations/global`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptEndpointGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> ListInterceptEndpointGroups(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptEndpointGroupsRequest request = new ListInterceptEndpointGroupsRequest
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
            return ListInterceptEndpointGroups(request, callSettings);
        }

        /// <summary>
        /// Lists endpoint groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of endpoint groups.
        /// Example: `projects/123456789/locations/global`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterceptEndpointGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> ListInterceptEndpointGroupsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptEndpointGroupsRequest request = new ListInterceptEndpointGroupsRequest
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
            return ListInterceptEndpointGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterceptEndpointGroup GetInterceptEndpointGroup(GetInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptEndpointGroup> GetInterceptEndpointGroupAsync(GetInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptEndpointGroup> GetInterceptEndpointGroupAsync(GetInterceptEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
            GetInterceptEndpointGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterceptEndpointGroup GetInterceptEndpointGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptEndpointGroup(new GetInterceptEndpointGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptEndpointGroup> GetInterceptEndpointGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptEndpointGroupAsync(new GetInterceptEndpointGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptEndpointGroup> GetInterceptEndpointGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetInterceptEndpointGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterceptEndpointGroup GetInterceptEndpointGroup(InterceptEndpointGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptEndpointGroup(new GetInterceptEndpointGroupRequest
            {
                InterceptEndpointGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptEndpointGroup> GetInterceptEndpointGroupAsync(InterceptEndpointGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptEndpointGroupAsync(new GetInterceptEndpointGroupRequest
            {
                InterceptEndpointGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptEndpointGroups/{intercept_endpoint_group}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptEndpointGroup> GetInterceptEndpointGroupAsync(InterceptEndpointGroupName name, st::CancellationToken cancellationToken) =>
            GetInterceptEndpointGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptEndpointGroup, OperationMetadata> CreateInterceptEndpointGroup(CreateInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> CreateInterceptEndpointGroupAsync(CreateInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> CreateInterceptEndpointGroupAsync(CreateInterceptEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateInterceptEndpointGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInterceptEndpointGroup</c>.</summary>
        public virtual lro::OperationsClient CreateInterceptEndpointGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInterceptEndpointGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InterceptEndpointGroup, OperationMetadata> PollOnceCreateInterceptEndpointGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptEndpointGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInterceptEndpointGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInterceptEndpointGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> PollOnceCreateInterceptEndpointGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptEndpointGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInterceptEndpointGroupOperationsClient, callSettings);

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this endpoint group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptEndpointGroup">
        /// Required. The endpoint group to create.
        /// </param>
        /// <param name="interceptEndpointGroupId">
        /// Required. The ID to use for the endpoint group, which will become the final
        /// component of the endpoint group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptEndpointGroup, OperationMetadata> CreateInterceptEndpointGroup(string parent, InterceptEndpointGroup interceptEndpointGroup, string interceptEndpointGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptEndpointGroup(new CreateInterceptEndpointGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InterceptEndpointGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(interceptEndpointGroupId, nameof(interceptEndpointGroupId)),
                InterceptEndpointGroup = gax::GaxPreconditions.CheckNotNull(interceptEndpointGroup, nameof(interceptEndpointGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this endpoint group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptEndpointGroup">
        /// Required. The endpoint group to create.
        /// </param>
        /// <param name="interceptEndpointGroupId">
        /// Required. The ID to use for the endpoint group, which will become the final
        /// component of the endpoint group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> CreateInterceptEndpointGroupAsync(string parent, InterceptEndpointGroup interceptEndpointGroup, string interceptEndpointGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptEndpointGroupAsync(new CreateInterceptEndpointGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InterceptEndpointGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(interceptEndpointGroupId, nameof(interceptEndpointGroupId)),
                InterceptEndpointGroup = gax::GaxPreconditions.CheckNotNull(interceptEndpointGroup, nameof(interceptEndpointGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this endpoint group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptEndpointGroup">
        /// Required. The endpoint group to create.
        /// </param>
        /// <param name="interceptEndpointGroupId">
        /// Required. The ID to use for the endpoint group, which will become the final
        /// component of the endpoint group's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> CreateInterceptEndpointGroupAsync(string parent, InterceptEndpointGroup interceptEndpointGroup, string interceptEndpointGroupId, st::CancellationToken cancellationToken) =>
            CreateInterceptEndpointGroupAsync(parent, interceptEndpointGroup, interceptEndpointGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this endpoint group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptEndpointGroup">
        /// Required. The endpoint group to create.
        /// </param>
        /// <param name="interceptEndpointGroupId">
        /// Required. The ID to use for the endpoint group, which will become the final
        /// component of the endpoint group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptEndpointGroup, OperationMetadata> CreateInterceptEndpointGroup(gagr::LocationName parent, InterceptEndpointGroup interceptEndpointGroup, string interceptEndpointGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptEndpointGroup(new CreateInterceptEndpointGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InterceptEndpointGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(interceptEndpointGroupId, nameof(interceptEndpointGroupId)),
                InterceptEndpointGroup = gax::GaxPreconditions.CheckNotNull(interceptEndpointGroup, nameof(interceptEndpointGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this endpoint group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptEndpointGroup">
        /// Required. The endpoint group to create.
        /// </param>
        /// <param name="interceptEndpointGroupId">
        /// Required. The ID to use for the endpoint group, which will become the final
        /// component of the endpoint group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> CreateInterceptEndpointGroupAsync(gagr::LocationName parent, InterceptEndpointGroup interceptEndpointGroup, string interceptEndpointGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptEndpointGroupAsync(new CreateInterceptEndpointGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InterceptEndpointGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(interceptEndpointGroupId, nameof(interceptEndpointGroupId)),
                InterceptEndpointGroup = gax::GaxPreconditions.CheckNotNull(interceptEndpointGroup, nameof(interceptEndpointGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this endpoint group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptEndpointGroup">
        /// Required. The endpoint group to create.
        /// </param>
        /// <param name="interceptEndpointGroupId">
        /// Required. The ID to use for the endpoint group, which will become the final
        /// component of the endpoint group's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> CreateInterceptEndpointGroupAsync(gagr::LocationName parent, InterceptEndpointGroup interceptEndpointGroup, string interceptEndpointGroupId, st::CancellationToken cancellationToken) =>
            CreateInterceptEndpointGroupAsync(parent, interceptEndpointGroup, interceptEndpointGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptEndpointGroup, OperationMetadata> UpdateInterceptEndpointGroup(UpdateInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> UpdateInterceptEndpointGroupAsync(UpdateInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> UpdateInterceptEndpointGroupAsync(UpdateInterceptEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateInterceptEndpointGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInterceptEndpointGroup</c>.</summary>
        public virtual lro::OperationsClient UpdateInterceptEndpointGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInterceptEndpointGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InterceptEndpointGroup, OperationMetadata> PollOnceUpdateInterceptEndpointGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptEndpointGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInterceptEndpointGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInterceptEndpointGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> PollOnceUpdateInterceptEndpointGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptEndpointGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInterceptEndpointGroupOperationsClient, callSettings);

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="interceptEndpointGroup">
        /// Required. The endpoint group to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the endpoint group
        /// (e.g. `description`; *not* `intercept_endpoint_group.description`).
        /// See https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptEndpointGroup, OperationMetadata> UpdateInterceptEndpointGroup(InterceptEndpointGroup interceptEndpointGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInterceptEndpointGroup(new UpdateInterceptEndpointGroupRequest
            {
                UpdateMask = updateMask,
                InterceptEndpointGroup = gax::GaxPreconditions.CheckNotNull(interceptEndpointGroup, nameof(interceptEndpointGroup)),
            }, callSettings);

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="interceptEndpointGroup">
        /// Required. The endpoint group to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the endpoint group
        /// (e.g. `description`; *not* `intercept_endpoint_group.description`).
        /// See https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> UpdateInterceptEndpointGroupAsync(InterceptEndpointGroup interceptEndpointGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInterceptEndpointGroupAsync(new UpdateInterceptEndpointGroupRequest
            {
                UpdateMask = updateMask,
                InterceptEndpointGroup = gax::GaxPreconditions.CheckNotNull(interceptEndpointGroup, nameof(interceptEndpointGroup)),
            }, callSettings);

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="interceptEndpointGroup">
        /// Required. The endpoint group to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the endpoint group
        /// (e.g. `description`; *not* `intercept_endpoint_group.description`).
        /// See https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> UpdateInterceptEndpointGroupAsync(InterceptEndpointGroup interceptEndpointGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInterceptEndpointGroupAsync(interceptEndpointGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptEndpointGroup(DeleteInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAsync(DeleteInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAsync(DeleteInterceptEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteInterceptEndpointGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInterceptEndpointGroup</c>.</summary>
        public virtual lro::OperationsClient DeleteInterceptEndpointGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInterceptEndpointGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInterceptEndpointGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInterceptEndpointGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInterceptEndpointGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInterceptEndpointGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInterceptEndpointGroupOperationsClient, callSettings);

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The endpoint group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptEndpointGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptEndpointGroup(new DeleteInterceptEndpointGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The endpoint group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptEndpointGroupAsync(new DeleteInterceptEndpointGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The endpoint group to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInterceptEndpointGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The endpoint group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptEndpointGroup(InterceptEndpointGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptEndpointGroup(new DeleteInterceptEndpointGroupRequest
            {
                InterceptEndpointGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The endpoint group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAsync(InterceptEndpointGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptEndpointGroupAsync(new DeleteInterceptEndpointGroupRequest
            {
                InterceptEndpointGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The endpoint group to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAsync(InterceptEndpointGroupName name, st::CancellationToken cancellationToken) =>
            DeleteInterceptEndpointGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists associations in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptEndpointGroupAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> ListInterceptEndpointGroupAssociations(ListInterceptEndpointGroupAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists associations in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="InterceptEndpointGroupAssociation"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> ListInterceptEndpointGroupAssociationsAsync(ListInterceptEndpointGroupAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists associations in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of associations.
        /// Example: `projects/123456789/locations/global`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptEndpointGroupAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> ListInterceptEndpointGroupAssociations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptEndpointGroupAssociationsRequest request = new ListInterceptEndpointGroupAssociationsRequest
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
            return ListInterceptEndpointGroupAssociations(request, callSettings);
        }

        /// <summary>
        /// Lists associations in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of associations.
        /// Example: `projects/123456789/locations/global`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
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
        /// A pageable asynchronous sequence of <see cref="InterceptEndpointGroupAssociation"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> ListInterceptEndpointGroupAssociationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptEndpointGroupAssociationsRequest request = new ListInterceptEndpointGroupAssociationsRequest
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
            return ListInterceptEndpointGroupAssociationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists associations in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of associations.
        /// Example: `projects/123456789/locations/global`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptEndpointGroupAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> ListInterceptEndpointGroupAssociations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptEndpointGroupAssociationsRequest request = new ListInterceptEndpointGroupAssociationsRequest
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
            return ListInterceptEndpointGroupAssociations(request, callSettings);
        }

        /// <summary>
        /// Lists associations in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of associations.
        /// Example: `projects/123456789/locations/global`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
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
        /// A pageable asynchronous sequence of <see cref="InterceptEndpointGroupAssociation"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> ListInterceptEndpointGroupAssociationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptEndpointGroupAssociationsRequest request = new ListInterceptEndpointGroupAssociationsRequest
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
            return ListInterceptEndpointGroupAssociationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterceptEndpointGroupAssociation GetInterceptEndpointGroupAssociation(GetInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptEndpointGroupAssociation> GetInterceptEndpointGroupAssociationAsync(GetInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptEndpointGroupAssociation> GetInterceptEndpointGroupAssociationAsync(GetInterceptEndpointGroupAssociationRequest request, st::CancellationToken cancellationToken) =>
            GetInterceptEndpointGroupAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the association to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterceptEndpointGroupAssociation GetInterceptEndpointGroupAssociation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptEndpointGroupAssociation(new GetInterceptEndpointGroupAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the association to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptEndpointGroupAssociation> GetInterceptEndpointGroupAssociationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptEndpointGroupAssociationAsync(new GetInterceptEndpointGroupAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the association to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptEndpointGroupAssociation> GetInterceptEndpointGroupAssociationAsync(string name, st::CancellationToken cancellationToken) =>
            GetInterceptEndpointGroupAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the association to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterceptEndpointGroupAssociation GetInterceptEndpointGroupAssociation(InterceptEndpointGroupAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptEndpointGroupAssociation(new GetInterceptEndpointGroupAssociationRequest
            {
                InterceptEndpointGroupAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the association to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptEndpointGroupAssociation> GetInterceptEndpointGroupAssociationAsync(InterceptEndpointGroupAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptEndpointGroupAssociationAsync(new GetInterceptEndpointGroupAssociationRequest
            {
                InterceptEndpointGroupAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the association to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptEndpointGroupAssociations/{intercept_endpoint_group_association}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptEndpointGroupAssociation> GetInterceptEndpointGroupAssociationAsync(InterceptEndpointGroupAssociationName name, st::CancellationToken cancellationToken) =>
            GetInterceptEndpointGroupAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata> CreateInterceptEndpointGroupAssociation(CreateInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> CreateInterceptEndpointGroupAssociationAsync(CreateInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> CreateInterceptEndpointGroupAssociationAsync(CreateInterceptEndpointGroupAssociationRequest request, st::CancellationToken cancellationToken) =>
            CreateInterceptEndpointGroupAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInterceptEndpointGroupAssociation</c>.</summary>
        public virtual lro::OperationsClient CreateInterceptEndpointGroupAssociationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInterceptEndpointGroupAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata> PollOnceCreateInterceptEndpointGroupAssociation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInterceptEndpointGroupAssociationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInterceptEndpointGroupAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> PollOnceCreateInterceptEndpointGroupAssociationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInterceptEndpointGroupAssociationOperationsClient, callSettings);

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this association will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptEndpointGroupAssociation">
        /// Required. The association to create.
        /// </param>
        /// <param name="interceptEndpointGroupAssociationId">
        /// Optional. The ID to use for the new association, which will become the
        /// final component of the endpoint group's resource name. If not provided, the
        /// server will generate a unique ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata> CreateInterceptEndpointGroupAssociation(string parent, InterceptEndpointGroupAssociation interceptEndpointGroupAssociation, string interceptEndpointGroupAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptEndpointGroupAssociation(new CreateInterceptEndpointGroupAssociationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InterceptEndpointGroupAssociationId = interceptEndpointGroupAssociationId ?? "",
                InterceptEndpointGroupAssociation = gax::GaxPreconditions.CheckNotNull(interceptEndpointGroupAssociation, nameof(interceptEndpointGroupAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this association will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptEndpointGroupAssociation">
        /// Required. The association to create.
        /// </param>
        /// <param name="interceptEndpointGroupAssociationId">
        /// Optional. The ID to use for the new association, which will become the
        /// final component of the endpoint group's resource name. If not provided, the
        /// server will generate a unique ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> CreateInterceptEndpointGroupAssociationAsync(string parent, InterceptEndpointGroupAssociation interceptEndpointGroupAssociation, string interceptEndpointGroupAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptEndpointGroupAssociationAsync(new CreateInterceptEndpointGroupAssociationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InterceptEndpointGroupAssociationId = interceptEndpointGroupAssociationId ?? "",
                InterceptEndpointGroupAssociation = gax::GaxPreconditions.CheckNotNull(interceptEndpointGroupAssociation, nameof(interceptEndpointGroupAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this association will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptEndpointGroupAssociation">
        /// Required. The association to create.
        /// </param>
        /// <param name="interceptEndpointGroupAssociationId">
        /// Optional. The ID to use for the new association, which will become the
        /// final component of the endpoint group's resource name. If not provided, the
        /// server will generate a unique ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> CreateInterceptEndpointGroupAssociationAsync(string parent, InterceptEndpointGroupAssociation interceptEndpointGroupAssociation, string interceptEndpointGroupAssociationId, st::CancellationToken cancellationToken) =>
            CreateInterceptEndpointGroupAssociationAsync(parent, interceptEndpointGroupAssociation, interceptEndpointGroupAssociationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this association will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptEndpointGroupAssociation">
        /// Required. The association to create.
        /// </param>
        /// <param name="interceptEndpointGroupAssociationId">
        /// Optional. The ID to use for the new association, which will become the
        /// final component of the endpoint group's resource name. If not provided, the
        /// server will generate a unique ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata> CreateInterceptEndpointGroupAssociation(gagr::LocationName parent, InterceptEndpointGroupAssociation interceptEndpointGroupAssociation, string interceptEndpointGroupAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptEndpointGroupAssociation(new CreateInterceptEndpointGroupAssociationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InterceptEndpointGroupAssociationId = interceptEndpointGroupAssociationId ?? "",
                InterceptEndpointGroupAssociation = gax::GaxPreconditions.CheckNotNull(interceptEndpointGroupAssociation, nameof(interceptEndpointGroupAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this association will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptEndpointGroupAssociation">
        /// Required. The association to create.
        /// </param>
        /// <param name="interceptEndpointGroupAssociationId">
        /// Optional. The ID to use for the new association, which will become the
        /// final component of the endpoint group's resource name. If not provided, the
        /// server will generate a unique ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> CreateInterceptEndpointGroupAssociationAsync(gagr::LocationName parent, InterceptEndpointGroupAssociation interceptEndpointGroupAssociation, string interceptEndpointGroupAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptEndpointGroupAssociationAsync(new CreateInterceptEndpointGroupAssociationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InterceptEndpointGroupAssociationId = interceptEndpointGroupAssociationId ?? "",
                InterceptEndpointGroupAssociation = gax::GaxPreconditions.CheckNotNull(interceptEndpointGroupAssociation, nameof(interceptEndpointGroupAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this association will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptEndpointGroupAssociation">
        /// Required. The association to create.
        /// </param>
        /// <param name="interceptEndpointGroupAssociationId">
        /// Optional. The ID to use for the new association, which will become the
        /// final component of the endpoint group's resource name. If not provided, the
        /// server will generate a unique ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> CreateInterceptEndpointGroupAssociationAsync(gagr::LocationName parent, InterceptEndpointGroupAssociation interceptEndpointGroupAssociation, string interceptEndpointGroupAssociationId, st::CancellationToken cancellationToken) =>
            CreateInterceptEndpointGroupAssociationAsync(parent, interceptEndpointGroupAssociation, interceptEndpointGroupAssociationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata> UpdateInterceptEndpointGroupAssociation(UpdateInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> UpdateInterceptEndpointGroupAssociationAsync(UpdateInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> UpdateInterceptEndpointGroupAssociationAsync(UpdateInterceptEndpointGroupAssociationRequest request, st::CancellationToken cancellationToken) =>
            UpdateInterceptEndpointGroupAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInterceptEndpointGroupAssociation</c>.</summary>
        public virtual lro::OperationsClient UpdateInterceptEndpointGroupAssociationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInterceptEndpointGroupAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata> PollOnceUpdateInterceptEndpointGroupAssociation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInterceptEndpointGroupAssociationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInterceptEndpointGroupAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> PollOnceUpdateInterceptEndpointGroupAssociationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInterceptEndpointGroupAssociationOperationsClient, callSettings);

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="interceptEndpointGroupAssociation">
        /// Required. The association to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the association
        /// (e.g. `description`; *not*
        /// `intercept_endpoint_group_association.description`). See
        /// https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata> UpdateInterceptEndpointGroupAssociation(InterceptEndpointGroupAssociation interceptEndpointGroupAssociation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInterceptEndpointGroupAssociation(new UpdateInterceptEndpointGroupAssociationRequest
            {
                UpdateMask = updateMask,
                InterceptEndpointGroupAssociation = gax::GaxPreconditions.CheckNotNull(interceptEndpointGroupAssociation, nameof(interceptEndpointGroupAssociation)),
            }, callSettings);

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="interceptEndpointGroupAssociation">
        /// Required. The association to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the association
        /// (e.g. `description`; *not*
        /// `intercept_endpoint_group_association.description`). See
        /// https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> UpdateInterceptEndpointGroupAssociationAsync(InterceptEndpointGroupAssociation interceptEndpointGroupAssociation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInterceptEndpointGroupAssociationAsync(new UpdateInterceptEndpointGroupAssociationRequest
            {
                UpdateMask = updateMask,
                InterceptEndpointGroupAssociation = gax::GaxPreconditions.CheckNotNull(interceptEndpointGroupAssociation, nameof(interceptEndpointGroupAssociation)),
            }, callSettings);

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="interceptEndpointGroupAssociation">
        /// Required. The association to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the association
        /// (e.g. `description`; *not*
        /// `intercept_endpoint_group_association.description`). See
        /// https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> UpdateInterceptEndpointGroupAssociationAsync(InterceptEndpointGroupAssociation interceptEndpointGroupAssociation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInterceptEndpointGroupAssociationAsync(interceptEndpointGroupAssociation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptEndpointGroupAssociation(DeleteInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAssociationAsync(DeleteInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAssociationAsync(DeleteInterceptEndpointGroupAssociationRequest request, st::CancellationToken cancellationToken) =>
            DeleteInterceptEndpointGroupAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInterceptEndpointGroupAssociation</c>.</summary>
        public virtual lro::OperationsClient DeleteInterceptEndpointGroupAssociationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInterceptEndpointGroupAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInterceptEndpointGroupAssociation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInterceptEndpointGroupAssociationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInterceptEndpointGroupAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInterceptEndpointGroupAssociationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInterceptEndpointGroupAssociationOperationsClient, callSettings);

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The association to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptEndpointGroupAssociation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptEndpointGroupAssociation(new DeleteInterceptEndpointGroupAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The association to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAssociationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptEndpointGroupAssociationAsync(new DeleteInterceptEndpointGroupAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The association to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAssociationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInterceptEndpointGroupAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The association to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptEndpointGroupAssociation(InterceptEndpointGroupAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptEndpointGroupAssociation(new DeleteInterceptEndpointGroupAssociationRequest
            {
                InterceptEndpointGroupAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The association to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAssociationAsync(InterceptEndpointGroupAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptEndpointGroupAssociationAsync(new DeleteInterceptEndpointGroupAssociationRequest
            {
                InterceptEndpointGroupAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The association to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAssociationAsync(InterceptEndpointGroupAssociationName name, st::CancellationToken cancellationToken) =>
            DeleteInterceptEndpointGroupAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists deployment groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptDeploymentGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> ListInterceptDeploymentGroups(ListInterceptDeploymentGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists deployment groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterceptDeploymentGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> ListInterceptDeploymentGroupsAsync(ListInterceptDeploymentGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists deployment groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployment groups.
        /// Example: `projects/123456789/locations/global`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptDeploymentGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> ListInterceptDeploymentGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptDeploymentGroupsRequest request = new ListInterceptDeploymentGroupsRequest
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
            return ListInterceptDeploymentGroups(request, callSettings);
        }

        /// <summary>
        /// Lists deployment groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployment groups.
        /// Example: `projects/123456789/locations/global`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterceptDeploymentGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> ListInterceptDeploymentGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptDeploymentGroupsRequest request = new ListInterceptDeploymentGroupsRequest
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
            return ListInterceptDeploymentGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists deployment groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployment groups.
        /// Example: `projects/123456789/locations/global`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptDeploymentGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> ListInterceptDeploymentGroups(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptDeploymentGroupsRequest request = new ListInterceptDeploymentGroupsRequest
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
            return ListInterceptDeploymentGroups(request, callSettings);
        }

        /// <summary>
        /// Lists deployment groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployment groups.
        /// Example: `projects/123456789/locations/global`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterceptDeploymentGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> ListInterceptDeploymentGroupsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptDeploymentGroupsRequest request = new ListInterceptDeploymentGroupsRequest
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
            return ListInterceptDeploymentGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterceptDeploymentGroup GetInterceptDeploymentGroup(GetInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptDeploymentGroup> GetInterceptDeploymentGroupAsync(GetInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptDeploymentGroup> GetInterceptDeploymentGroupAsync(GetInterceptDeploymentGroupRequest request, st::CancellationToken cancellationToken) =>
            GetInterceptDeploymentGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterceptDeploymentGroup GetInterceptDeploymentGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptDeploymentGroup(new GetInterceptDeploymentGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptDeploymentGroup> GetInterceptDeploymentGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptDeploymentGroupAsync(new GetInterceptDeploymentGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptDeploymentGroup> GetInterceptDeploymentGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetInterceptDeploymentGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterceptDeploymentGroup GetInterceptDeploymentGroup(InterceptDeploymentGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptDeploymentGroup(new GetInterceptDeploymentGroupRequest
            {
                InterceptDeploymentGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptDeploymentGroup> GetInterceptDeploymentGroupAsync(InterceptDeploymentGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptDeploymentGroupAsync(new GetInterceptDeploymentGroupRequest
            {
                InterceptDeploymentGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptDeploymentGroups/{intercept_deployment_group}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptDeploymentGroup> GetInterceptDeploymentGroupAsync(InterceptDeploymentGroupName name, st::CancellationToken cancellationToken) =>
            GetInterceptDeploymentGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptDeploymentGroup, OperationMetadata> CreateInterceptDeploymentGroup(CreateInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> CreateInterceptDeploymentGroupAsync(CreateInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> CreateInterceptDeploymentGroupAsync(CreateInterceptDeploymentGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateInterceptDeploymentGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInterceptDeploymentGroup</c>.</summary>
        public virtual lro::OperationsClient CreateInterceptDeploymentGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInterceptDeploymentGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InterceptDeploymentGroup, OperationMetadata> PollOnceCreateInterceptDeploymentGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptDeploymentGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInterceptDeploymentGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInterceptDeploymentGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> PollOnceCreateInterceptDeploymentGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptDeploymentGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInterceptDeploymentGroupOperationsClient, callSettings);

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptDeploymentGroup">
        /// Required. The deployment group to create.
        /// </param>
        /// <param name="interceptDeploymentGroupId">
        /// Required. The ID to use for the new deployment group, which will become the
        /// final component of the deployment group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptDeploymentGroup, OperationMetadata> CreateInterceptDeploymentGroup(string parent, InterceptDeploymentGroup interceptDeploymentGroup, string interceptDeploymentGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptDeploymentGroup(new CreateInterceptDeploymentGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InterceptDeploymentGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentGroupId, nameof(interceptDeploymentGroupId)),
                InterceptDeploymentGroup = gax::GaxPreconditions.CheckNotNull(interceptDeploymentGroup, nameof(interceptDeploymentGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptDeploymentGroup">
        /// Required. The deployment group to create.
        /// </param>
        /// <param name="interceptDeploymentGroupId">
        /// Required. The ID to use for the new deployment group, which will become the
        /// final component of the deployment group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> CreateInterceptDeploymentGroupAsync(string parent, InterceptDeploymentGroup interceptDeploymentGroup, string interceptDeploymentGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptDeploymentGroupAsync(new CreateInterceptDeploymentGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InterceptDeploymentGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentGroupId, nameof(interceptDeploymentGroupId)),
                InterceptDeploymentGroup = gax::GaxPreconditions.CheckNotNull(interceptDeploymentGroup, nameof(interceptDeploymentGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptDeploymentGroup">
        /// Required. The deployment group to create.
        /// </param>
        /// <param name="interceptDeploymentGroupId">
        /// Required. The ID to use for the new deployment group, which will become the
        /// final component of the deployment group's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> CreateInterceptDeploymentGroupAsync(string parent, InterceptDeploymentGroup interceptDeploymentGroup, string interceptDeploymentGroupId, st::CancellationToken cancellationToken) =>
            CreateInterceptDeploymentGroupAsync(parent, interceptDeploymentGroup, interceptDeploymentGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptDeploymentGroup">
        /// Required. The deployment group to create.
        /// </param>
        /// <param name="interceptDeploymentGroupId">
        /// Required. The ID to use for the new deployment group, which will become the
        /// final component of the deployment group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptDeploymentGroup, OperationMetadata> CreateInterceptDeploymentGroup(gagr::LocationName parent, InterceptDeploymentGroup interceptDeploymentGroup, string interceptDeploymentGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptDeploymentGroup(new CreateInterceptDeploymentGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InterceptDeploymentGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentGroupId, nameof(interceptDeploymentGroupId)),
                InterceptDeploymentGroup = gax::GaxPreconditions.CheckNotNull(interceptDeploymentGroup, nameof(interceptDeploymentGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptDeploymentGroup">
        /// Required. The deployment group to create.
        /// </param>
        /// <param name="interceptDeploymentGroupId">
        /// Required. The ID to use for the new deployment group, which will become the
        /// final component of the deployment group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> CreateInterceptDeploymentGroupAsync(gagr::LocationName parent, InterceptDeploymentGroup interceptDeploymentGroup, string interceptDeploymentGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptDeploymentGroupAsync(new CreateInterceptDeploymentGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InterceptDeploymentGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentGroupId, nameof(interceptDeploymentGroupId)),
                InterceptDeploymentGroup = gax::GaxPreconditions.CheckNotNull(interceptDeploymentGroup, nameof(interceptDeploymentGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptDeploymentGroup">
        /// Required. The deployment group to create.
        /// </param>
        /// <param name="interceptDeploymentGroupId">
        /// Required. The ID to use for the new deployment group, which will become the
        /// final component of the deployment group's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> CreateInterceptDeploymentGroupAsync(gagr::LocationName parent, InterceptDeploymentGroup interceptDeploymentGroup, string interceptDeploymentGroupId, st::CancellationToken cancellationToken) =>
            CreateInterceptDeploymentGroupAsync(parent, interceptDeploymentGroup, interceptDeploymentGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptDeploymentGroup, OperationMetadata> UpdateInterceptDeploymentGroup(UpdateInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> UpdateInterceptDeploymentGroupAsync(UpdateInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> UpdateInterceptDeploymentGroupAsync(UpdateInterceptDeploymentGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateInterceptDeploymentGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInterceptDeploymentGroup</c>.</summary>
        public virtual lro::OperationsClient UpdateInterceptDeploymentGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInterceptDeploymentGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InterceptDeploymentGroup, OperationMetadata> PollOnceUpdateInterceptDeploymentGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptDeploymentGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInterceptDeploymentGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInterceptDeploymentGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> PollOnceUpdateInterceptDeploymentGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptDeploymentGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInterceptDeploymentGroupOperationsClient, callSettings);

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="interceptDeploymentGroup">
        /// Required. The deployment group to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the deployment group
        /// (e.g. `description`; *not*
        /// `intercept_deployment_group.description`). See
        /// https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptDeploymentGroup, OperationMetadata> UpdateInterceptDeploymentGroup(InterceptDeploymentGroup interceptDeploymentGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInterceptDeploymentGroup(new UpdateInterceptDeploymentGroupRequest
            {
                UpdateMask = updateMask,
                InterceptDeploymentGroup = gax::GaxPreconditions.CheckNotNull(interceptDeploymentGroup, nameof(interceptDeploymentGroup)),
            }, callSettings);

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="interceptDeploymentGroup">
        /// Required. The deployment group to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the deployment group
        /// (e.g. `description`; *not*
        /// `intercept_deployment_group.description`). See
        /// https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> UpdateInterceptDeploymentGroupAsync(InterceptDeploymentGroup interceptDeploymentGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInterceptDeploymentGroupAsync(new UpdateInterceptDeploymentGroupRequest
            {
                UpdateMask = updateMask,
                InterceptDeploymentGroup = gax::GaxPreconditions.CheckNotNull(interceptDeploymentGroup, nameof(interceptDeploymentGroup)),
            }, callSettings);

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="interceptDeploymentGroup">
        /// Required. The deployment group to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the deployment group
        /// (e.g. `description`; *not*
        /// `intercept_deployment_group.description`). See
        /// https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> UpdateInterceptDeploymentGroupAsync(InterceptDeploymentGroup interceptDeploymentGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInterceptDeploymentGroupAsync(interceptDeploymentGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptDeploymentGroup(DeleteInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentGroupAsync(DeleteInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentGroupAsync(DeleteInterceptDeploymentGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteInterceptDeploymentGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInterceptDeploymentGroup</c>.</summary>
        public virtual lro::OperationsClient DeleteInterceptDeploymentGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInterceptDeploymentGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInterceptDeploymentGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInterceptDeploymentGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInterceptDeploymentGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInterceptDeploymentGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInterceptDeploymentGroupOperationsClient, callSettings);

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The deployment group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptDeploymentGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptDeploymentGroup(new DeleteInterceptDeploymentGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The deployment group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptDeploymentGroupAsync(new DeleteInterceptDeploymentGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The deployment group to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInterceptDeploymentGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The deployment group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptDeploymentGroup(InterceptDeploymentGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptDeploymentGroup(new DeleteInterceptDeploymentGroupRequest
            {
                InterceptDeploymentGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The deployment group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentGroupAsync(InterceptDeploymentGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptDeploymentGroupAsync(new DeleteInterceptDeploymentGroupRequest
            {
                InterceptDeploymentGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The deployment group to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentGroupAsync(InterceptDeploymentGroupName name, st::CancellationToken cancellationToken) =>
            DeleteInterceptDeploymentGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists deployments in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> ListInterceptDeployments(ListInterceptDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists deployments in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterceptDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> ListInterceptDeploymentsAsync(ListInterceptDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists deployments in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Example: `projects/123456789/locations/us-central1-a`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> ListInterceptDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptDeploymentsRequest request = new ListInterceptDeploymentsRequest
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
            return ListInterceptDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists deployments in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Example: `projects/123456789/locations/us-central1-a`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterceptDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> ListInterceptDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptDeploymentsRequest request = new ListInterceptDeploymentsRequest
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
            return ListInterceptDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists deployments in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Example: `projects/123456789/locations/us-central1-a`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> ListInterceptDeployments(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptDeploymentsRequest request = new ListInterceptDeploymentsRequest
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
            return ListInterceptDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists deployments in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Example: `projects/123456789/locations/us-central1-a`.
        /// See https://google.aip.dev/132 for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterceptDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> ListInterceptDeploymentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInterceptDeploymentsRequest request = new ListInterceptDeploymentsRequest
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
            return ListInterceptDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterceptDeployment GetInterceptDeployment(GetInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptDeployment> GetInterceptDeploymentAsync(GetInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptDeployment> GetInterceptDeploymentAsync(GetInterceptDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetInterceptDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterceptDeployment GetInterceptDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptDeployment(new GetInterceptDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptDeployment> GetInterceptDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptDeploymentAsync(new GetInterceptDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptDeployment> GetInterceptDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetInterceptDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InterceptDeployment GetInterceptDeployment(InterceptDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptDeployment(new GetInterceptDeploymentRequest
            {
                InterceptDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptDeployment> GetInterceptDeploymentAsync(InterceptDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInterceptDeploymentAsync(new GetInterceptDeploymentRequest
            {
                InterceptDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/interceptDeployments/{intercept_deployment}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InterceptDeployment> GetInterceptDeploymentAsync(InterceptDeploymentName name, st::CancellationToken cancellationToken) =>
            GetInterceptDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptDeployment, OperationMetadata> CreateInterceptDeployment(CreateInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> CreateInterceptDeploymentAsync(CreateInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> CreateInterceptDeploymentAsync(CreateInterceptDeploymentRequest request, st::CancellationToken cancellationToken) =>
            CreateInterceptDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInterceptDeployment</c>.</summary>
        public virtual lro::OperationsClient CreateInterceptDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInterceptDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InterceptDeployment, OperationMetadata> PollOnceCreateInterceptDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptDeployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInterceptDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInterceptDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> PollOnceCreateInterceptDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptDeployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInterceptDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="interceptDeploymentId">
        /// Required. The ID to use for the new deployment, which will become the final
        /// component of the deployment's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptDeployment, OperationMetadata> CreateInterceptDeployment(string parent, InterceptDeployment interceptDeployment, string interceptDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptDeployment(new CreateInterceptDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InterceptDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentId, nameof(interceptDeploymentId)),
                InterceptDeployment = gax::GaxPreconditions.CheckNotNull(interceptDeployment, nameof(interceptDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="interceptDeploymentId">
        /// Required. The ID to use for the new deployment, which will become the final
        /// component of the deployment's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> CreateInterceptDeploymentAsync(string parent, InterceptDeployment interceptDeployment, string interceptDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptDeploymentAsync(new CreateInterceptDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InterceptDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentId, nameof(interceptDeploymentId)),
                InterceptDeployment = gax::GaxPreconditions.CheckNotNull(interceptDeployment, nameof(interceptDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="interceptDeploymentId">
        /// Required. The ID to use for the new deployment, which will become the final
        /// component of the deployment's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> CreateInterceptDeploymentAsync(string parent, InterceptDeployment interceptDeployment, string interceptDeploymentId, st::CancellationToken cancellationToken) =>
            CreateInterceptDeploymentAsync(parent, interceptDeployment, interceptDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="interceptDeploymentId">
        /// Required. The ID to use for the new deployment, which will become the final
        /// component of the deployment's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptDeployment, OperationMetadata> CreateInterceptDeployment(gagr::LocationName parent, InterceptDeployment interceptDeployment, string interceptDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptDeployment(new CreateInterceptDeploymentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InterceptDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentId, nameof(interceptDeploymentId)),
                InterceptDeployment = gax::GaxPreconditions.CheckNotNull(interceptDeployment, nameof(interceptDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="interceptDeploymentId">
        /// Required. The ID to use for the new deployment, which will become the final
        /// component of the deployment's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> CreateInterceptDeploymentAsync(gagr::LocationName parent, InterceptDeployment interceptDeployment, string interceptDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInterceptDeploymentAsync(new CreateInterceptDeploymentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InterceptDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(interceptDeploymentId, nameof(interceptDeploymentId)),
                InterceptDeployment = gax::GaxPreconditions.CheckNotNull(interceptDeployment, nameof(interceptDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="interceptDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="interceptDeploymentId">
        /// Required. The ID to use for the new deployment, which will become the final
        /// component of the deployment's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> CreateInterceptDeploymentAsync(gagr::LocationName parent, InterceptDeployment interceptDeployment, string interceptDeploymentId, st::CancellationToken cancellationToken) =>
            CreateInterceptDeploymentAsync(parent, interceptDeployment, interceptDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptDeployment, OperationMetadata> UpdateInterceptDeployment(UpdateInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> UpdateInterceptDeploymentAsync(UpdateInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> UpdateInterceptDeploymentAsync(UpdateInterceptDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UpdateInterceptDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInterceptDeployment</c>.</summary>
        public virtual lro::OperationsClient UpdateInterceptDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInterceptDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InterceptDeployment, OperationMetadata> PollOnceUpdateInterceptDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptDeployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInterceptDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInterceptDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> PollOnceUpdateInterceptDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InterceptDeployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInterceptDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="interceptDeployment">
        /// Required. The deployment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the deployment
        /// (e.g. `description`; *not* `intercept_deployment.description`).
        /// See https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InterceptDeployment, OperationMetadata> UpdateInterceptDeployment(InterceptDeployment interceptDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInterceptDeployment(new UpdateInterceptDeploymentRequest
            {
                UpdateMask = updateMask,
                InterceptDeployment = gax::GaxPreconditions.CheckNotNull(interceptDeployment, nameof(interceptDeployment)),
            }, callSettings);

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="interceptDeployment">
        /// Required. The deployment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the deployment
        /// (e.g. `description`; *not* `intercept_deployment.description`).
        /// See https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> UpdateInterceptDeploymentAsync(InterceptDeployment interceptDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInterceptDeploymentAsync(new UpdateInterceptDeploymentRequest
            {
                UpdateMask = updateMask,
                InterceptDeployment = gax::GaxPreconditions.CheckNotNull(interceptDeployment, nameof(interceptDeployment)),
            }, callSettings);

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="interceptDeployment">
        /// Required. The deployment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the deployment
        /// (e.g. `description`; *not* `intercept_deployment.description`).
        /// See https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> UpdateInterceptDeploymentAsync(InterceptDeployment interceptDeployment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInterceptDeploymentAsync(interceptDeployment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptDeployment(DeleteInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentAsync(DeleteInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentAsync(DeleteInterceptDeploymentRequest request, st::CancellationToken cancellationToken) =>
            DeleteInterceptDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInterceptDeployment</c>.</summary>
        public virtual lro::OperationsClient DeleteInterceptDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInterceptDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInterceptDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInterceptDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInterceptDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInterceptDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInterceptDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptDeployment(new DeleteInterceptDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptDeploymentAsync(new DeleteInterceptDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInterceptDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptDeployment(InterceptDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptDeployment(new DeleteInterceptDeploymentRequest
            {
                InterceptDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentAsync(InterceptDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInterceptDeploymentAsync(new DeleteInterceptDeploymentRequest
            {
                InterceptDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentAsync(InterceptDeploymentName name, st::CancellationToken cancellationToken) =>
            DeleteInterceptDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Intercept client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for Third-Party Packet Intercept (TPPI).
    /// TPPI is the "in-band" flavor of the Network Security Integrations product.
    /// </remarks>
    public sealed partial class InterceptClientImpl : InterceptClient
    {
        private readonly gaxgrpc::ApiCall<ListInterceptEndpointGroupsRequest, ListInterceptEndpointGroupsResponse> _callListInterceptEndpointGroups;

        private readonly gaxgrpc::ApiCall<GetInterceptEndpointGroupRequest, InterceptEndpointGroup> _callGetInterceptEndpointGroup;

        private readonly gaxgrpc::ApiCall<CreateInterceptEndpointGroupRequest, lro::Operation> _callCreateInterceptEndpointGroup;

        private readonly gaxgrpc::ApiCall<UpdateInterceptEndpointGroupRequest, lro::Operation> _callUpdateInterceptEndpointGroup;

        private readonly gaxgrpc::ApiCall<DeleteInterceptEndpointGroupRequest, lro::Operation> _callDeleteInterceptEndpointGroup;

        private readonly gaxgrpc::ApiCall<ListInterceptEndpointGroupAssociationsRequest, ListInterceptEndpointGroupAssociationsResponse> _callListInterceptEndpointGroupAssociations;

        private readonly gaxgrpc::ApiCall<GetInterceptEndpointGroupAssociationRequest, InterceptEndpointGroupAssociation> _callGetInterceptEndpointGroupAssociation;

        private readonly gaxgrpc::ApiCall<CreateInterceptEndpointGroupAssociationRequest, lro::Operation> _callCreateInterceptEndpointGroupAssociation;

        private readonly gaxgrpc::ApiCall<UpdateInterceptEndpointGroupAssociationRequest, lro::Operation> _callUpdateInterceptEndpointGroupAssociation;

        private readonly gaxgrpc::ApiCall<DeleteInterceptEndpointGroupAssociationRequest, lro::Operation> _callDeleteInterceptEndpointGroupAssociation;

        private readonly gaxgrpc::ApiCall<ListInterceptDeploymentGroupsRequest, ListInterceptDeploymentGroupsResponse> _callListInterceptDeploymentGroups;

        private readonly gaxgrpc::ApiCall<GetInterceptDeploymentGroupRequest, InterceptDeploymentGroup> _callGetInterceptDeploymentGroup;

        private readonly gaxgrpc::ApiCall<CreateInterceptDeploymentGroupRequest, lro::Operation> _callCreateInterceptDeploymentGroup;

        private readonly gaxgrpc::ApiCall<UpdateInterceptDeploymentGroupRequest, lro::Operation> _callUpdateInterceptDeploymentGroup;

        private readonly gaxgrpc::ApiCall<DeleteInterceptDeploymentGroupRequest, lro::Operation> _callDeleteInterceptDeploymentGroup;

        private readonly gaxgrpc::ApiCall<ListInterceptDeploymentsRequest, ListInterceptDeploymentsResponse> _callListInterceptDeployments;

        private readonly gaxgrpc::ApiCall<GetInterceptDeploymentRequest, InterceptDeployment> _callGetInterceptDeployment;

        private readonly gaxgrpc::ApiCall<CreateInterceptDeploymentRequest, lro::Operation> _callCreateInterceptDeployment;

        private readonly gaxgrpc::ApiCall<UpdateInterceptDeploymentRequest, lro::Operation> _callUpdateInterceptDeployment;

        private readonly gaxgrpc::ApiCall<DeleteInterceptDeploymentRequest, lro::Operation> _callDeleteInterceptDeployment;

        /// <summary>
        /// Constructs a client wrapper for the Intercept service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="InterceptSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public InterceptClientImpl(Intercept.InterceptClient grpcClient, InterceptSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            InterceptSettings effectiveSettings = settings ?? InterceptSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateInterceptEndpointGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInterceptEndpointGroupOperationsSettings, logger);
            UpdateInterceptEndpointGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInterceptEndpointGroupOperationsSettings, logger);
            DeleteInterceptEndpointGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInterceptEndpointGroupOperationsSettings, logger);
            CreateInterceptEndpointGroupAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInterceptEndpointGroupAssociationOperationsSettings, logger);
            UpdateInterceptEndpointGroupAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInterceptEndpointGroupAssociationOperationsSettings, logger);
            DeleteInterceptEndpointGroupAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInterceptEndpointGroupAssociationOperationsSettings, logger);
            CreateInterceptDeploymentGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInterceptDeploymentGroupOperationsSettings, logger);
            UpdateInterceptDeploymentGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInterceptDeploymentGroupOperationsSettings, logger);
            DeleteInterceptDeploymentGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInterceptDeploymentGroupOperationsSettings, logger);
            CreateInterceptDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInterceptDeploymentOperationsSettings, logger);
            UpdateInterceptDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInterceptDeploymentOperationsSettings, logger);
            DeleteInterceptDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInterceptDeploymentOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListInterceptEndpointGroups = clientHelper.BuildApiCall<ListInterceptEndpointGroupsRequest, ListInterceptEndpointGroupsResponse>("ListInterceptEndpointGroups", grpcClient.ListInterceptEndpointGroupsAsync, grpcClient.ListInterceptEndpointGroups, effectiveSettings.ListInterceptEndpointGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInterceptEndpointGroups);
            Modify_ListInterceptEndpointGroupsApiCall(ref _callListInterceptEndpointGroups);
            _callGetInterceptEndpointGroup = clientHelper.BuildApiCall<GetInterceptEndpointGroupRequest, InterceptEndpointGroup>("GetInterceptEndpointGroup", grpcClient.GetInterceptEndpointGroupAsync, grpcClient.GetInterceptEndpointGroup, effectiveSettings.GetInterceptEndpointGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInterceptEndpointGroup);
            Modify_GetInterceptEndpointGroupApiCall(ref _callGetInterceptEndpointGroup);
            _callCreateInterceptEndpointGroup = clientHelper.BuildApiCall<CreateInterceptEndpointGroupRequest, lro::Operation>("CreateInterceptEndpointGroup", grpcClient.CreateInterceptEndpointGroupAsync, grpcClient.CreateInterceptEndpointGroup, effectiveSettings.CreateInterceptEndpointGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInterceptEndpointGroup);
            Modify_CreateInterceptEndpointGroupApiCall(ref _callCreateInterceptEndpointGroup);
            _callUpdateInterceptEndpointGroup = clientHelper.BuildApiCall<UpdateInterceptEndpointGroupRequest, lro::Operation>("UpdateInterceptEndpointGroup", grpcClient.UpdateInterceptEndpointGroupAsync, grpcClient.UpdateInterceptEndpointGroup, effectiveSettings.UpdateInterceptEndpointGroupSettings).WithGoogleRequestParam("intercept_endpoint_group.name", request => request.InterceptEndpointGroup?.Name);
            Modify_ApiCall(ref _callUpdateInterceptEndpointGroup);
            Modify_UpdateInterceptEndpointGroupApiCall(ref _callUpdateInterceptEndpointGroup);
            _callDeleteInterceptEndpointGroup = clientHelper.BuildApiCall<DeleteInterceptEndpointGroupRequest, lro::Operation>("DeleteInterceptEndpointGroup", grpcClient.DeleteInterceptEndpointGroupAsync, grpcClient.DeleteInterceptEndpointGroup, effectiveSettings.DeleteInterceptEndpointGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInterceptEndpointGroup);
            Modify_DeleteInterceptEndpointGroupApiCall(ref _callDeleteInterceptEndpointGroup);
            _callListInterceptEndpointGroupAssociations = clientHelper.BuildApiCall<ListInterceptEndpointGroupAssociationsRequest, ListInterceptEndpointGroupAssociationsResponse>("ListInterceptEndpointGroupAssociations", grpcClient.ListInterceptEndpointGroupAssociationsAsync, grpcClient.ListInterceptEndpointGroupAssociations, effectiveSettings.ListInterceptEndpointGroupAssociationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInterceptEndpointGroupAssociations);
            Modify_ListInterceptEndpointGroupAssociationsApiCall(ref _callListInterceptEndpointGroupAssociations);
            _callGetInterceptEndpointGroupAssociation = clientHelper.BuildApiCall<GetInterceptEndpointGroupAssociationRequest, InterceptEndpointGroupAssociation>("GetInterceptEndpointGroupAssociation", grpcClient.GetInterceptEndpointGroupAssociationAsync, grpcClient.GetInterceptEndpointGroupAssociation, effectiveSettings.GetInterceptEndpointGroupAssociationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInterceptEndpointGroupAssociation);
            Modify_GetInterceptEndpointGroupAssociationApiCall(ref _callGetInterceptEndpointGroupAssociation);
            _callCreateInterceptEndpointGroupAssociation = clientHelper.BuildApiCall<CreateInterceptEndpointGroupAssociationRequest, lro::Operation>("CreateInterceptEndpointGroupAssociation", grpcClient.CreateInterceptEndpointGroupAssociationAsync, grpcClient.CreateInterceptEndpointGroupAssociation, effectiveSettings.CreateInterceptEndpointGroupAssociationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInterceptEndpointGroupAssociation);
            Modify_CreateInterceptEndpointGroupAssociationApiCall(ref _callCreateInterceptEndpointGroupAssociation);
            _callUpdateInterceptEndpointGroupAssociation = clientHelper.BuildApiCall<UpdateInterceptEndpointGroupAssociationRequest, lro::Operation>("UpdateInterceptEndpointGroupAssociation", grpcClient.UpdateInterceptEndpointGroupAssociationAsync, grpcClient.UpdateInterceptEndpointGroupAssociation, effectiveSettings.UpdateInterceptEndpointGroupAssociationSettings).WithGoogleRequestParam("intercept_endpoint_group_association.name", request => request.InterceptEndpointGroupAssociation?.Name);
            Modify_ApiCall(ref _callUpdateInterceptEndpointGroupAssociation);
            Modify_UpdateInterceptEndpointGroupAssociationApiCall(ref _callUpdateInterceptEndpointGroupAssociation);
            _callDeleteInterceptEndpointGroupAssociation = clientHelper.BuildApiCall<DeleteInterceptEndpointGroupAssociationRequest, lro::Operation>("DeleteInterceptEndpointGroupAssociation", grpcClient.DeleteInterceptEndpointGroupAssociationAsync, grpcClient.DeleteInterceptEndpointGroupAssociation, effectiveSettings.DeleteInterceptEndpointGroupAssociationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInterceptEndpointGroupAssociation);
            Modify_DeleteInterceptEndpointGroupAssociationApiCall(ref _callDeleteInterceptEndpointGroupAssociation);
            _callListInterceptDeploymentGroups = clientHelper.BuildApiCall<ListInterceptDeploymentGroupsRequest, ListInterceptDeploymentGroupsResponse>("ListInterceptDeploymentGroups", grpcClient.ListInterceptDeploymentGroupsAsync, grpcClient.ListInterceptDeploymentGroups, effectiveSettings.ListInterceptDeploymentGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInterceptDeploymentGroups);
            Modify_ListInterceptDeploymentGroupsApiCall(ref _callListInterceptDeploymentGroups);
            _callGetInterceptDeploymentGroup = clientHelper.BuildApiCall<GetInterceptDeploymentGroupRequest, InterceptDeploymentGroup>("GetInterceptDeploymentGroup", grpcClient.GetInterceptDeploymentGroupAsync, grpcClient.GetInterceptDeploymentGroup, effectiveSettings.GetInterceptDeploymentGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInterceptDeploymentGroup);
            Modify_GetInterceptDeploymentGroupApiCall(ref _callGetInterceptDeploymentGroup);
            _callCreateInterceptDeploymentGroup = clientHelper.BuildApiCall<CreateInterceptDeploymentGroupRequest, lro::Operation>("CreateInterceptDeploymentGroup", grpcClient.CreateInterceptDeploymentGroupAsync, grpcClient.CreateInterceptDeploymentGroup, effectiveSettings.CreateInterceptDeploymentGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInterceptDeploymentGroup);
            Modify_CreateInterceptDeploymentGroupApiCall(ref _callCreateInterceptDeploymentGroup);
            _callUpdateInterceptDeploymentGroup = clientHelper.BuildApiCall<UpdateInterceptDeploymentGroupRequest, lro::Operation>("UpdateInterceptDeploymentGroup", grpcClient.UpdateInterceptDeploymentGroupAsync, grpcClient.UpdateInterceptDeploymentGroup, effectiveSettings.UpdateInterceptDeploymentGroupSettings).WithGoogleRequestParam("intercept_deployment_group.name", request => request.InterceptDeploymentGroup?.Name);
            Modify_ApiCall(ref _callUpdateInterceptDeploymentGroup);
            Modify_UpdateInterceptDeploymentGroupApiCall(ref _callUpdateInterceptDeploymentGroup);
            _callDeleteInterceptDeploymentGroup = clientHelper.BuildApiCall<DeleteInterceptDeploymentGroupRequest, lro::Operation>("DeleteInterceptDeploymentGroup", grpcClient.DeleteInterceptDeploymentGroupAsync, grpcClient.DeleteInterceptDeploymentGroup, effectiveSettings.DeleteInterceptDeploymentGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInterceptDeploymentGroup);
            Modify_DeleteInterceptDeploymentGroupApiCall(ref _callDeleteInterceptDeploymentGroup);
            _callListInterceptDeployments = clientHelper.BuildApiCall<ListInterceptDeploymentsRequest, ListInterceptDeploymentsResponse>("ListInterceptDeployments", grpcClient.ListInterceptDeploymentsAsync, grpcClient.ListInterceptDeployments, effectiveSettings.ListInterceptDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInterceptDeployments);
            Modify_ListInterceptDeploymentsApiCall(ref _callListInterceptDeployments);
            _callGetInterceptDeployment = clientHelper.BuildApiCall<GetInterceptDeploymentRequest, InterceptDeployment>("GetInterceptDeployment", grpcClient.GetInterceptDeploymentAsync, grpcClient.GetInterceptDeployment, effectiveSettings.GetInterceptDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInterceptDeployment);
            Modify_GetInterceptDeploymentApiCall(ref _callGetInterceptDeployment);
            _callCreateInterceptDeployment = clientHelper.BuildApiCall<CreateInterceptDeploymentRequest, lro::Operation>("CreateInterceptDeployment", grpcClient.CreateInterceptDeploymentAsync, grpcClient.CreateInterceptDeployment, effectiveSettings.CreateInterceptDeploymentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInterceptDeployment);
            Modify_CreateInterceptDeploymentApiCall(ref _callCreateInterceptDeployment);
            _callUpdateInterceptDeployment = clientHelper.BuildApiCall<UpdateInterceptDeploymentRequest, lro::Operation>("UpdateInterceptDeployment", grpcClient.UpdateInterceptDeploymentAsync, grpcClient.UpdateInterceptDeployment, effectiveSettings.UpdateInterceptDeploymentSettings).WithGoogleRequestParam("intercept_deployment.name", request => request.InterceptDeployment?.Name);
            Modify_ApiCall(ref _callUpdateInterceptDeployment);
            Modify_UpdateInterceptDeploymentApiCall(ref _callUpdateInterceptDeployment);
            _callDeleteInterceptDeployment = clientHelper.BuildApiCall<DeleteInterceptDeploymentRequest, lro::Operation>("DeleteInterceptDeployment", grpcClient.DeleteInterceptDeploymentAsync, grpcClient.DeleteInterceptDeployment, effectiveSettings.DeleteInterceptDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInterceptDeployment);
            Modify_DeleteInterceptDeploymentApiCall(ref _callDeleteInterceptDeployment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInterceptEndpointGroupsApiCall(ref gaxgrpc::ApiCall<ListInterceptEndpointGroupsRequest, ListInterceptEndpointGroupsResponse> call);

        partial void Modify_GetInterceptEndpointGroupApiCall(ref gaxgrpc::ApiCall<GetInterceptEndpointGroupRequest, InterceptEndpointGroup> call);

        partial void Modify_CreateInterceptEndpointGroupApiCall(ref gaxgrpc::ApiCall<CreateInterceptEndpointGroupRequest, lro::Operation> call);

        partial void Modify_UpdateInterceptEndpointGroupApiCall(ref gaxgrpc::ApiCall<UpdateInterceptEndpointGroupRequest, lro::Operation> call);

        partial void Modify_DeleteInterceptEndpointGroupApiCall(ref gaxgrpc::ApiCall<DeleteInterceptEndpointGroupRequest, lro::Operation> call);

        partial void Modify_ListInterceptEndpointGroupAssociationsApiCall(ref gaxgrpc::ApiCall<ListInterceptEndpointGroupAssociationsRequest, ListInterceptEndpointGroupAssociationsResponse> call);

        partial void Modify_GetInterceptEndpointGroupAssociationApiCall(ref gaxgrpc::ApiCall<GetInterceptEndpointGroupAssociationRequest, InterceptEndpointGroupAssociation> call);

        partial void Modify_CreateInterceptEndpointGroupAssociationApiCall(ref gaxgrpc::ApiCall<CreateInterceptEndpointGroupAssociationRequest, lro::Operation> call);

        partial void Modify_UpdateInterceptEndpointGroupAssociationApiCall(ref gaxgrpc::ApiCall<UpdateInterceptEndpointGroupAssociationRequest, lro::Operation> call);

        partial void Modify_DeleteInterceptEndpointGroupAssociationApiCall(ref gaxgrpc::ApiCall<DeleteInterceptEndpointGroupAssociationRequest, lro::Operation> call);

        partial void Modify_ListInterceptDeploymentGroupsApiCall(ref gaxgrpc::ApiCall<ListInterceptDeploymentGroupsRequest, ListInterceptDeploymentGroupsResponse> call);

        partial void Modify_GetInterceptDeploymentGroupApiCall(ref gaxgrpc::ApiCall<GetInterceptDeploymentGroupRequest, InterceptDeploymentGroup> call);

        partial void Modify_CreateInterceptDeploymentGroupApiCall(ref gaxgrpc::ApiCall<CreateInterceptDeploymentGroupRequest, lro::Operation> call);

        partial void Modify_UpdateInterceptDeploymentGroupApiCall(ref gaxgrpc::ApiCall<UpdateInterceptDeploymentGroupRequest, lro::Operation> call);

        partial void Modify_DeleteInterceptDeploymentGroupApiCall(ref gaxgrpc::ApiCall<DeleteInterceptDeploymentGroupRequest, lro::Operation> call);

        partial void Modify_ListInterceptDeploymentsApiCall(ref gaxgrpc::ApiCall<ListInterceptDeploymentsRequest, ListInterceptDeploymentsResponse> call);

        partial void Modify_GetInterceptDeploymentApiCall(ref gaxgrpc::ApiCall<GetInterceptDeploymentRequest, InterceptDeployment> call);

        partial void Modify_CreateInterceptDeploymentApiCall(ref gaxgrpc::ApiCall<CreateInterceptDeploymentRequest, lro::Operation> call);

        partial void Modify_UpdateInterceptDeploymentApiCall(ref gaxgrpc::ApiCall<UpdateInterceptDeploymentRequest, lro::Operation> call);

        partial void Modify_DeleteInterceptDeploymentApiCall(ref gaxgrpc::ApiCall<DeleteInterceptDeploymentRequest, lro::Operation> call);

        partial void OnConstruction(Intercept.InterceptClient grpcClient, InterceptSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Intercept client</summary>
        public override Intercept.InterceptClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListInterceptEndpointGroupsRequest(ref ListInterceptEndpointGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInterceptEndpointGroupRequest(ref GetInterceptEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInterceptEndpointGroupRequest(ref CreateInterceptEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInterceptEndpointGroupRequest(ref UpdateInterceptEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInterceptEndpointGroupRequest(ref DeleteInterceptEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInterceptEndpointGroupAssociationsRequest(ref ListInterceptEndpointGroupAssociationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInterceptEndpointGroupAssociationRequest(ref GetInterceptEndpointGroupAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInterceptEndpointGroupAssociationRequest(ref CreateInterceptEndpointGroupAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInterceptEndpointGroupAssociationRequest(ref UpdateInterceptEndpointGroupAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInterceptEndpointGroupAssociationRequest(ref DeleteInterceptEndpointGroupAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInterceptDeploymentGroupsRequest(ref ListInterceptDeploymentGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInterceptDeploymentGroupRequest(ref GetInterceptDeploymentGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInterceptDeploymentGroupRequest(ref CreateInterceptDeploymentGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInterceptDeploymentGroupRequest(ref UpdateInterceptDeploymentGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInterceptDeploymentGroupRequest(ref DeleteInterceptDeploymentGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInterceptDeploymentsRequest(ref ListInterceptDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInterceptDeploymentRequest(ref GetInterceptDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInterceptDeploymentRequest(ref CreateInterceptDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInterceptDeploymentRequest(ref UpdateInterceptDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInterceptDeploymentRequest(ref DeleteInterceptDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists endpoint groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptEndpointGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> ListInterceptEndpointGroups(ListInterceptEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInterceptEndpointGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInterceptEndpointGroupsRequest, ListInterceptEndpointGroupsResponse, InterceptEndpointGroup>(_callListInterceptEndpointGroups, request, callSettings);
        }

        /// <summary>
        /// Lists endpoint groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterceptEndpointGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> ListInterceptEndpointGroupsAsync(ListInterceptEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInterceptEndpointGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInterceptEndpointGroupsRequest, ListInterceptEndpointGroupsResponse, InterceptEndpointGroup>(_callListInterceptEndpointGroups, request, callSettings);
        }

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InterceptEndpointGroup GetInterceptEndpointGroup(GetInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInterceptEndpointGroupRequest(ref request, ref callSettings);
            return _callGetInterceptEndpointGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InterceptEndpointGroup> GetInterceptEndpointGroupAsync(GetInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInterceptEndpointGroupRequest(ref request, ref callSettings);
            return _callGetInterceptEndpointGroup.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInterceptEndpointGroup</c>.</summary>
        public override lro::OperationsClient CreateInterceptEndpointGroupOperationsClient { get; }

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InterceptEndpointGroup, OperationMetadata> CreateInterceptEndpointGroup(CreateInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInterceptEndpointGroupRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptEndpointGroup, OperationMetadata>(_callCreateInterceptEndpointGroup.Sync(request, callSettings), CreateInterceptEndpointGroupOperationsClient);
        }

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> CreateInterceptEndpointGroupAsync(CreateInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInterceptEndpointGroupRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptEndpointGroup, OperationMetadata>(await _callCreateInterceptEndpointGroup.Async(request, callSettings).ConfigureAwait(false), CreateInterceptEndpointGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInterceptEndpointGroup</c>.</summary>
        public override lro::OperationsClient UpdateInterceptEndpointGroupOperationsClient { get; }

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InterceptEndpointGroup, OperationMetadata> UpdateInterceptEndpointGroup(UpdateInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInterceptEndpointGroupRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptEndpointGroup, OperationMetadata>(_callUpdateInterceptEndpointGroup.Sync(request, callSettings), UpdateInterceptEndpointGroupOperationsClient);
        }

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InterceptEndpointGroup, OperationMetadata>> UpdateInterceptEndpointGroupAsync(UpdateInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInterceptEndpointGroupRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptEndpointGroup, OperationMetadata>(await _callUpdateInterceptEndpointGroup.Async(request, callSettings).ConfigureAwait(false), UpdateInterceptEndpointGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInterceptEndpointGroup</c>.</summary>
        public override lro::OperationsClient DeleteInterceptEndpointGroupOperationsClient { get; }

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptEndpointGroup(DeleteInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInterceptEndpointGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInterceptEndpointGroup.Sync(request, callSettings), DeleteInterceptEndpointGroupOperationsClient);
        }

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAsync(DeleteInterceptEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInterceptEndpointGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInterceptEndpointGroup.Async(request, callSettings).ConfigureAwait(false), DeleteInterceptEndpointGroupOperationsClient);
        }

        /// <summary>
        /// Lists associations in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptEndpointGroupAssociation"/> resources.</returns>
        public override gax::PagedEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> ListInterceptEndpointGroupAssociations(ListInterceptEndpointGroupAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInterceptEndpointGroupAssociationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInterceptEndpointGroupAssociationsRequest, ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation>(_callListInterceptEndpointGroupAssociations, request, callSettings);
        }

        /// <summary>
        /// Lists associations in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="InterceptEndpointGroupAssociation"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> ListInterceptEndpointGroupAssociationsAsync(ListInterceptEndpointGroupAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInterceptEndpointGroupAssociationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInterceptEndpointGroupAssociationsRequest, ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation>(_callListInterceptEndpointGroupAssociations, request, callSettings);
        }

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InterceptEndpointGroupAssociation GetInterceptEndpointGroupAssociation(GetInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInterceptEndpointGroupAssociationRequest(ref request, ref callSettings);
            return _callGetInterceptEndpointGroupAssociation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InterceptEndpointGroupAssociation> GetInterceptEndpointGroupAssociationAsync(GetInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInterceptEndpointGroupAssociationRequest(ref request, ref callSettings);
            return _callGetInterceptEndpointGroupAssociation.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInterceptEndpointGroupAssociation</c>.</summary>
        public override lro::OperationsClient CreateInterceptEndpointGroupAssociationOperationsClient { get; }

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata> CreateInterceptEndpointGroupAssociation(CreateInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInterceptEndpointGroupAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>(_callCreateInterceptEndpointGroupAssociation.Sync(request, callSettings), CreateInterceptEndpointGroupAssociationOperationsClient);
        }

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> CreateInterceptEndpointGroupAssociationAsync(CreateInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInterceptEndpointGroupAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>(await _callCreateInterceptEndpointGroupAssociation.Async(request, callSettings).ConfigureAwait(false), CreateInterceptEndpointGroupAssociationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInterceptEndpointGroupAssociation</c>.</summary>
        public override lro::OperationsClient UpdateInterceptEndpointGroupAssociationOperationsClient { get; }

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata> UpdateInterceptEndpointGroupAssociation(UpdateInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInterceptEndpointGroupAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>(_callUpdateInterceptEndpointGroupAssociation.Sync(request, callSettings), UpdateInterceptEndpointGroupAssociationOperationsClient);
        }

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>> UpdateInterceptEndpointGroupAssociationAsync(UpdateInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInterceptEndpointGroupAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptEndpointGroupAssociation, OperationMetadata>(await _callUpdateInterceptEndpointGroupAssociation.Async(request, callSettings).ConfigureAwait(false), UpdateInterceptEndpointGroupAssociationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInterceptEndpointGroupAssociation</c>.</summary>
        public override lro::OperationsClient DeleteInterceptEndpointGroupAssociationOperationsClient { get; }

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptEndpointGroupAssociation(DeleteInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInterceptEndpointGroupAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInterceptEndpointGroupAssociation.Sync(request, callSettings), DeleteInterceptEndpointGroupAssociationOperationsClient);
        }

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptEndpointGroupAssociationAsync(DeleteInterceptEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInterceptEndpointGroupAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInterceptEndpointGroupAssociation.Async(request, callSettings).ConfigureAwait(false), DeleteInterceptEndpointGroupAssociationOperationsClient);
        }

        /// <summary>
        /// Lists deployment groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptDeploymentGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> ListInterceptDeploymentGroups(ListInterceptDeploymentGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInterceptDeploymentGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInterceptDeploymentGroupsRequest, ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup>(_callListInterceptDeploymentGroups, request, callSettings);
        }

        /// <summary>
        /// Lists deployment groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterceptDeploymentGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> ListInterceptDeploymentGroupsAsync(ListInterceptDeploymentGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInterceptDeploymentGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInterceptDeploymentGroupsRequest, ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup>(_callListInterceptDeploymentGroups, request, callSettings);
        }

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InterceptDeploymentGroup GetInterceptDeploymentGroup(GetInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInterceptDeploymentGroupRequest(ref request, ref callSettings);
            return _callGetInterceptDeploymentGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InterceptDeploymentGroup> GetInterceptDeploymentGroupAsync(GetInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInterceptDeploymentGroupRequest(ref request, ref callSettings);
            return _callGetInterceptDeploymentGroup.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInterceptDeploymentGroup</c>.</summary>
        public override lro::OperationsClient CreateInterceptDeploymentGroupOperationsClient { get; }

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InterceptDeploymentGroup, OperationMetadata> CreateInterceptDeploymentGroup(CreateInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInterceptDeploymentGroupRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptDeploymentGroup, OperationMetadata>(_callCreateInterceptDeploymentGroup.Sync(request, callSettings), CreateInterceptDeploymentGroupOperationsClient);
        }

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> CreateInterceptDeploymentGroupAsync(CreateInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInterceptDeploymentGroupRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptDeploymentGroup, OperationMetadata>(await _callCreateInterceptDeploymentGroup.Async(request, callSettings).ConfigureAwait(false), CreateInterceptDeploymentGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInterceptDeploymentGroup</c>.</summary>
        public override lro::OperationsClient UpdateInterceptDeploymentGroupOperationsClient { get; }

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InterceptDeploymentGroup, OperationMetadata> UpdateInterceptDeploymentGroup(UpdateInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInterceptDeploymentGroupRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptDeploymentGroup, OperationMetadata>(_callUpdateInterceptDeploymentGroup.Sync(request, callSettings), UpdateInterceptDeploymentGroupOperationsClient);
        }

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InterceptDeploymentGroup, OperationMetadata>> UpdateInterceptDeploymentGroupAsync(UpdateInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInterceptDeploymentGroupRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptDeploymentGroup, OperationMetadata>(await _callUpdateInterceptDeploymentGroup.Async(request, callSettings).ConfigureAwait(false), UpdateInterceptDeploymentGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInterceptDeploymentGroup</c>.</summary>
        public override lro::OperationsClient DeleteInterceptDeploymentGroupOperationsClient { get; }

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptDeploymentGroup(DeleteInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInterceptDeploymentGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInterceptDeploymentGroup.Sync(request, callSettings), DeleteInterceptDeploymentGroupOperationsClient);
        }

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentGroupAsync(DeleteInterceptDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInterceptDeploymentGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInterceptDeploymentGroup.Async(request, callSettings).ConfigureAwait(false), DeleteInterceptDeploymentGroupOperationsClient);
        }

        /// <summary>
        /// Lists deployments in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InterceptDeployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> ListInterceptDeployments(ListInterceptDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInterceptDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInterceptDeploymentsRequest, ListInterceptDeploymentsResponse, InterceptDeployment>(_callListInterceptDeployments, request, callSettings);
        }

        /// <summary>
        /// Lists deployments in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InterceptDeployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> ListInterceptDeploymentsAsync(ListInterceptDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInterceptDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInterceptDeploymentsRequest, ListInterceptDeploymentsResponse, InterceptDeployment>(_callListInterceptDeployments, request, callSettings);
        }

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InterceptDeployment GetInterceptDeployment(GetInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInterceptDeploymentRequest(ref request, ref callSettings);
            return _callGetInterceptDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InterceptDeployment> GetInterceptDeploymentAsync(GetInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInterceptDeploymentRequest(ref request, ref callSettings);
            return _callGetInterceptDeployment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInterceptDeployment</c>.</summary>
        public override lro::OperationsClient CreateInterceptDeploymentOperationsClient { get; }

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InterceptDeployment, OperationMetadata> CreateInterceptDeployment(CreateInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInterceptDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptDeployment, OperationMetadata>(_callCreateInterceptDeployment.Sync(request, callSettings), CreateInterceptDeploymentOperationsClient);
        }

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> CreateInterceptDeploymentAsync(CreateInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInterceptDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptDeployment, OperationMetadata>(await _callCreateInterceptDeployment.Async(request, callSettings).ConfigureAwait(false), CreateInterceptDeploymentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInterceptDeployment</c>.</summary>
        public override lro::OperationsClient UpdateInterceptDeploymentOperationsClient { get; }

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InterceptDeployment, OperationMetadata> UpdateInterceptDeployment(UpdateInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInterceptDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptDeployment, OperationMetadata>(_callUpdateInterceptDeployment.Sync(request, callSettings), UpdateInterceptDeploymentOperationsClient);
        }

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InterceptDeployment, OperationMetadata>> UpdateInterceptDeploymentAsync(UpdateInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInterceptDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<InterceptDeployment, OperationMetadata>(await _callUpdateInterceptDeployment.Async(request, callSettings).ConfigureAwait(false), UpdateInterceptDeploymentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInterceptDeployment</c>.</summary>
        public override lro::OperationsClient DeleteInterceptDeploymentOperationsClient { get; }

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInterceptDeployment(DeleteInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInterceptDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInterceptDeployment.Sync(request, callSettings), DeleteInterceptDeploymentOperationsClient);
        }

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInterceptDeploymentAsync(DeleteInterceptDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInterceptDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInterceptDeployment.Async(request, callSettings).ConfigureAwait(false), DeleteInterceptDeploymentOperationsClient);
        }
    }

    public partial class ListInterceptEndpointGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInterceptEndpointGroupAssociationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInterceptDeploymentGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInterceptDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInterceptEndpointGroupsResponse : gaxgrpc::IPageResponse<InterceptEndpointGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InterceptEndpointGroup> GetEnumerator() => InterceptEndpointGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInterceptEndpointGroupAssociationsResponse : gaxgrpc::IPageResponse<InterceptEndpointGroupAssociation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InterceptEndpointGroupAssociation> GetEnumerator() =>
            InterceptEndpointGroupAssociations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInterceptDeploymentGroupsResponse : gaxgrpc::IPageResponse<InterceptDeploymentGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InterceptDeploymentGroup> GetEnumerator() => InterceptDeploymentGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInterceptDeploymentsResponse : gaxgrpc::IPageResponse<InterceptDeployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InterceptDeployment> GetEnumerator() => InterceptDeployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Intercept
    {
        public partial class InterceptClient
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

    public static partial class Intercept
    {
        public partial class InterceptClient
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
