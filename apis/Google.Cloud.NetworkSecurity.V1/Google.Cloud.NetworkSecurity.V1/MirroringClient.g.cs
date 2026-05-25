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
    /// <summary>Settings for <see cref="MirroringClient"/> instances.</summary>
    public sealed partial class MirroringSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MirroringSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MirroringSettings"/>.</returns>
        public static MirroringSettings GetDefault() => new MirroringSettings();

        /// <summary>Constructs a new <see cref="MirroringSettings"/> object with default settings.</summary>
        public MirroringSettings()
        {
        }

        private MirroringSettings(MirroringSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListMirroringEndpointGroupsSettings = existing.ListMirroringEndpointGroupsSettings;
            GetMirroringEndpointGroupSettings = existing.GetMirroringEndpointGroupSettings;
            CreateMirroringEndpointGroupSettings = existing.CreateMirroringEndpointGroupSettings;
            CreateMirroringEndpointGroupOperationsSettings = existing.CreateMirroringEndpointGroupOperationsSettings.Clone();
            UpdateMirroringEndpointGroupSettings = existing.UpdateMirroringEndpointGroupSettings;
            UpdateMirroringEndpointGroupOperationsSettings = existing.UpdateMirroringEndpointGroupOperationsSettings.Clone();
            DeleteMirroringEndpointGroupSettings = existing.DeleteMirroringEndpointGroupSettings;
            DeleteMirroringEndpointGroupOperationsSettings = existing.DeleteMirroringEndpointGroupOperationsSettings.Clone();
            ListMirroringEndpointGroupAssociationsSettings = existing.ListMirroringEndpointGroupAssociationsSettings;
            GetMirroringEndpointGroupAssociationSettings = existing.GetMirroringEndpointGroupAssociationSettings;
            CreateMirroringEndpointGroupAssociationSettings = existing.CreateMirroringEndpointGroupAssociationSettings;
            CreateMirroringEndpointGroupAssociationOperationsSettings = existing.CreateMirroringEndpointGroupAssociationOperationsSettings.Clone();
            UpdateMirroringEndpointGroupAssociationSettings = existing.UpdateMirroringEndpointGroupAssociationSettings;
            UpdateMirroringEndpointGroupAssociationOperationsSettings = existing.UpdateMirroringEndpointGroupAssociationOperationsSettings.Clone();
            DeleteMirroringEndpointGroupAssociationSettings = existing.DeleteMirroringEndpointGroupAssociationSettings;
            DeleteMirroringEndpointGroupAssociationOperationsSettings = existing.DeleteMirroringEndpointGroupAssociationOperationsSettings.Clone();
            ListMirroringDeploymentGroupsSettings = existing.ListMirroringDeploymentGroupsSettings;
            GetMirroringDeploymentGroupSettings = existing.GetMirroringDeploymentGroupSettings;
            CreateMirroringDeploymentGroupSettings = existing.CreateMirroringDeploymentGroupSettings;
            CreateMirroringDeploymentGroupOperationsSettings = existing.CreateMirroringDeploymentGroupOperationsSettings.Clone();
            UpdateMirroringDeploymentGroupSettings = existing.UpdateMirroringDeploymentGroupSettings;
            UpdateMirroringDeploymentGroupOperationsSettings = existing.UpdateMirroringDeploymentGroupOperationsSettings.Clone();
            DeleteMirroringDeploymentGroupSettings = existing.DeleteMirroringDeploymentGroupSettings;
            DeleteMirroringDeploymentGroupOperationsSettings = existing.DeleteMirroringDeploymentGroupOperationsSettings.Clone();
            ListMirroringDeploymentsSettings = existing.ListMirroringDeploymentsSettings;
            GetMirroringDeploymentSettings = existing.GetMirroringDeploymentSettings;
            CreateMirroringDeploymentSettings = existing.CreateMirroringDeploymentSettings;
            CreateMirroringDeploymentOperationsSettings = existing.CreateMirroringDeploymentOperationsSettings.Clone();
            UpdateMirroringDeploymentSettings = existing.UpdateMirroringDeploymentSettings;
            UpdateMirroringDeploymentOperationsSettings = existing.UpdateMirroringDeploymentOperationsSettings.Clone();
            DeleteMirroringDeploymentSettings = existing.DeleteMirroringDeploymentSettings;
            DeleteMirroringDeploymentOperationsSettings = existing.DeleteMirroringDeploymentOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(MirroringSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.ListMirroringEndpointGroups</c> and <c>MirroringClient.ListMirroringEndpointGroupsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMirroringEndpointGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.GetMirroringEndpointGroup</c> and <c>MirroringClient.GetMirroringEndpointGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMirroringEndpointGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.CreateMirroringEndpointGroup</c> and <c>MirroringClient.CreateMirroringEndpointGroupAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMirroringEndpointGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MirroringClient.CreateMirroringEndpointGroup</c> and
        /// <c>MirroringClient.CreateMirroringEndpointGroupAsync</c>.
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
        public lro::OperationsSettings CreateMirroringEndpointGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.UpdateMirroringEndpointGroup</c> and <c>MirroringClient.UpdateMirroringEndpointGroupAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMirroringEndpointGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MirroringClient.UpdateMirroringEndpointGroup</c> and
        /// <c>MirroringClient.UpdateMirroringEndpointGroupAsync</c>.
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
        public lro::OperationsSettings UpdateMirroringEndpointGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.DeleteMirroringEndpointGroup</c> and <c>MirroringClient.DeleteMirroringEndpointGroupAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMirroringEndpointGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MirroringClient.DeleteMirroringEndpointGroup</c> and
        /// <c>MirroringClient.DeleteMirroringEndpointGroupAsync</c>.
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
        public lro::OperationsSettings DeleteMirroringEndpointGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.ListMirroringEndpointGroupAssociations</c> and
        /// <c>MirroringClient.ListMirroringEndpointGroupAssociationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMirroringEndpointGroupAssociationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.GetMirroringEndpointGroupAssociation</c> and
        /// <c>MirroringClient.GetMirroringEndpointGroupAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMirroringEndpointGroupAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.CreateMirroringEndpointGroupAssociation</c> and
        /// <c>MirroringClient.CreateMirroringEndpointGroupAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMirroringEndpointGroupAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MirroringClient.CreateMirroringEndpointGroupAssociation</c>
        /// and <c>MirroringClient.CreateMirroringEndpointGroupAssociationAsync</c>.
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
        public lro::OperationsSettings CreateMirroringEndpointGroupAssociationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.UpdateMirroringEndpointGroupAssociation</c> and
        /// <c>MirroringClient.UpdateMirroringEndpointGroupAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMirroringEndpointGroupAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MirroringClient.UpdateMirroringEndpointGroupAssociation</c>
        /// and <c>MirroringClient.UpdateMirroringEndpointGroupAssociationAsync</c>.
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
        public lro::OperationsSettings UpdateMirroringEndpointGroupAssociationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.DeleteMirroringEndpointGroupAssociation</c> and
        /// <c>MirroringClient.DeleteMirroringEndpointGroupAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMirroringEndpointGroupAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MirroringClient.DeleteMirroringEndpointGroupAssociation</c>
        /// and <c>MirroringClient.DeleteMirroringEndpointGroupAssociationAsync</c>.
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
        public lro::OperationsSettings DeleteMirroringEndpointGroupAssociationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.ListMirroringDeploymentGroups</c> and
        /// <c>MirroringClient.ListMirroringDeploymentGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMirroringDeploymentGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.GetMirroringDeploymentGroup</c> and <c>MirroringClient.GetMirroringDeploymentGroupAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMirroringDeploymentGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.CreateMirroringDeploymentGroup</c> and
        /// <c>MirroringClient.CreateMirroringDeploymentGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMirroringDeploymentGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MirroringClient.CreateMirroringDeploymentGroup</c> and
        /// <c>MirroringClient.CreateMirroringDeploymentGroupAsync</c>.
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
        public lro::OperationsSettings CreateMirroringDeploymentGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.UpdateMirroringDeploymentGroup</c> and
        /// <c>MirroringClient.UpdateMirroringDeploymentGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMirroringDeploymentGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MirroringClient.UpdateMirroringDeploymentGroup</c> and
        /// <c>MirroringClient.UpdateMirroringDeploymentGroupAsync</c>.
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
        public lro::OperationsSettings UpdateMirroringDeploymentGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.DeleteMirroringDeploymentGroup</c> and
        /// <c>MirroringClient.DeleteMirroringDeploymentGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMirroringDeploymentGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MirroringClient.DeleteMirroringDeploymentGroup</c> and
        /// <c>MirroringClient.DeleteMirroringDeploymentGroupAsync</c>.
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
        public lro::OperationsSettings DeleteMirroringDeploymentGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.ListMirroringDeployments</c> and <c>MirroringClient.ListMirroringDeploymentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMirroringDeploymentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.GetMirroringDeployment</c> and <c>MirroringClient.GetMirroringDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMirroringDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.CreateMirroringDeployment</c> and <c>MirroringClient.CreateMirroringDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMirroringDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MirroringClient.CreateMirroringDeployment</c> and
        /// <c>MirroringClient.CreateMirroringDeploymentAsync</c>.
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
        public lro::OperationsSettings CreateMirroringDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.UpdateMirroringDeployment</c> and <c>MirroringClient.UpdateMirroringDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMirroringDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MirroringClient.UpdateMirroringDeployment</c> and
        /// <c>MirroringClient.UpdateMirroringDeploymentAsync</c>.
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
        public lro::OperationsSettings UpdateMirroringDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MirroringClient.DeleteMirroringDeployment</c> and <c>MirroringClient.DeleteMirroringDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMirroringDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MirroringClient.DeleteMirroringDeployment</c> and
        /// <c>MirroringClient.DeleteMirroringDeploymentAsync</c>.
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
        public lro::OperationsSettings DeleteMirroringDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="MirroringSettings"/> object.</returns>
        public MirroringSettings Clone() => new MirroringSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MirroringClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class MirroringClientBuilder : gaxgrpc::ClientBuilderBase<MirroringClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MirroringSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MirroringClientBuilder() : base(MirroringClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MirroringClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MirroringClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MirroringClient Build()
        {
            MirroringClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MirroringClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MirroringClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MirroringClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MirroringClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MirroringClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MirroringClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MirroringClient.ChannelPool;
    }

    /// <summary>Mirroring client wrapper, for convenient use.</summary>
    /// <remarks>
    /// PM2 is the "out-of-band" flavor of the Network Security Integrations product.
    /// </remarks>
    public abstract partial class MirroringClient
    {
        /// <summary>
        /// The default endpoint for the Mirroring service, which is a host of "networksecurity.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networksecurity.googleapis.com:443";

        /// <summary>The default Mirroring scopes.</summary>
        /// <remarks>
        /// The default Mirroring scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Mirroring.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MirroringClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="MirroringClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MirroringClient"/>.</returns>
        public static stt::Task<MirroringClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MirroringClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MirroringClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="MirroringClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MirroringClient"/>.</returns>
        public static MirroringClient Create() => new MirroringClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MirroringClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MirroringSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MirroringClient"/>.</returns>
        internal static MirroringClient Create(grpccore::CallInvoker callInvoker, MirroringSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Mirroring.MirroringClient grpcClient = new Mirroring.MirroringClient(callInvoker);
            return new MirroringClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Mirroring client</summary>
        public virtual Mirroring.MirroringClient GrpcClient => throw new sys::NotImplementedException();

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
        /// <returns>A pageable sequence of <see cref="MirroringEndpointGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> ListMirroringEndpointGroups(ListMirroringEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists endpoint groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MirroringEndpointGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> ListMirroringEndpointGroupsAsync(ListMirroringEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
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
        /// <returns>A pageable sequence of <see cref="MirroringEndpointGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> ListMirroringEndpointGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringEndpointGroupsRequest request = new ListMirroringEndpointGroupsRequest
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
            return ListMirroringEndpointGroups(request, callSettings);
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
        /// <returns>A pageable asynchronous sequence of <see cref="MirroringEndpointGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> ListMirroringEndpointGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringEndpointGroupsRequest request = new ListMirroringEndpointGroupsRequest
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
            return ListMirroringEndpointGroupsAsync(request, callSettings);
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
        /// <returns>A pageable sequence of <see cref="MirroringEndpointGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> ListMirroringEndpointGroups(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringEndpointGroupsRequest request = new ListMirroringEndpointGroupsRequest
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
            return ListMirroringEndpointGroups(request, callSettings);
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
        /// <returns>A pageable asynchronous sequence of <see cref="MirroringEndpointGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> ListMirroringEndpointGroupsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringEndpointGroupsRequest request = new ListMirroringEndpointGroupsRequest
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
            return ListMirroringEndpointGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MirroringEndpointGroup GetMirroringEndpointGroup(GetMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringEndpointGroup> GetMirroringEndpointGroupAsync(GetMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringEndpointGroup> GetMirroringEndpointGroupAsync(GetMirroringEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
            GetMirroringEndpointGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MirroringEndpointGroup GetMirroringEndpointGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringEndpointGroup(new GetMirroringEndpointGroupRequest
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
        /// projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringEndpointGroup> GetMirroringEndpointGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringEndpointGroupAsync(new GetMirroringEndpointGroupRequest
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
        /// projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringEndpointGroup> GetMirroringEndpointGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetMirroringEndpointGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MirroringEndpointGroup GetMirroringEndpointGroup(MirroringEndpointGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringEndpointGroup(new GetMirroringEndpointGroupRequest
            {
                MirroringEndpointGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringEndpointGroup> GetMirroringEndpointGroupAsync(MirroringEndpointGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringEndpointGroupAsync(new GetMirroringEndpointGroupRequest
            {
                MirroringEndpointGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringEndpointGroups/{mirroring_endpoint_group}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringEndpointGroup> GetMirroringEndpointGroupAsync(MirroringEndpointGroupName name, st::CancellationToken cancellationToken) =>
            GetMirroringEndpointGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringEndpointGroup, OperationMetadata> CreateMirroringEndpointGroup(CreateMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> CreateMirroringEndpointGroupAsync(CreateMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> CreateMirroringEndpointGroupAsync(CreateMirroringEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateMirroringEndpointGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMirroringEndpointGroup</c>.</summary>
        public virtual lro::OperationsClient CreateMirroringEndpointGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMirroringEndpointGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MirroringEndpointGroup, OperationMetadata> PollOnceCreateMirroringEndpointGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringEndpointGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMirroringEndpointGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMirroringEndpointGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> PollOnceCreateMirroringEndpointGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringEndpointGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMirroringEndpointGroupOperationsClient, callSettings);

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this endpoint group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringEndpointGroup">
        /// Required. The endpoint group to create.
        /// </param>
        /// <param name="mirroringEndpointGroupId">
        /// Required. The ID to use for the endpoint group, which will become the final
        /// component of the endpoint group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringEndpointGroup, OperationMetadata> CreateMirroringEndpointGroup(string parent, MirroringEndpointGroup mirroringEndpointGroup, string mirroringEndpointGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringEndpointGroup(new CreateMirroringEndpointGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MirroringEndpointGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringEndpointGroupId, nameof(mirroringEndpointGroupId)),
                MirroringEndpointGroup = gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroup, nameof(mirroringEndpointGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this endpoint group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringEndpointGroup">
        /// Required. The endpoint group to create.
        /// </param>
        /// <param name="mirroringEndpointGroupId">
        /// Required. The ID to use for the endpoint group, which will become the final
        /// component of the endpoint group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> CreateMirroringEndpointGroupAsync(string parent, MirroringEndpointGroup mirroringEndpointGroup, string mirroringEndpointGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringEndpointGroupAsync(new CreateMirroringEndpointGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MirroringEndpointGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringEndpointGroupId, nameof(mirroringEndpointGroupId)),
                MirroringEndpointGroup = gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroup, nameof(mirroringEndpointGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this endpoint group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringEndpointGroup">
        /// Required. The endpoint group to create.
        /// </param>
        /// <param name="mirroringEndpointGroupId">
        /// Required. The ID to use for the endpoint group, which will become the final
        /// component of the endpoint group's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> CreateMirroringEndpointGroupAsync(string parent, MirroringEndpointGroup mirroringEndpointGroup, string mirroringEndpointGroupId, st::CancellationToken cancellationToken) =>
            CreateMirroringEndpointGroupAsync(parent, mirroringEndpointGroup, mirroringEndpointGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this endpoint group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringEndpointGroup">
        /// Required. The endpoint group to create.
        /// </param>
        /// <param name="mirroringEndpointGroupId">
        /// Required. The ID to use for the endpoint group, which will become the final
        /// component of the endpoint group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringEndpointGroup, OperationMetadata> CreateMirroringEndpointGroup(gagr::LocationName parent, MirroringEndpointGroup mirroringEndpointGroup, string mirroringEndpointGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringEndpointGroup(new CreateMirroringEndpointGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MirroringEndpointGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringEndpointGroupId, nameof(mirroringEndpointGroupId)),
                MirroringEndpointGroup = gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroup, nameof(mirroringEndpointGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this endpoint group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringEndpointGroup">
        /// Required. The endpoint group to create.
        /// </param>
        /// <param name="mirroringEndpointGroupId">
        /// Required. The ID to use for the endpoint group, which will become the final
        /// component of the endpoint group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> CreateMirroringEndpointGroupAsync(gagr::LocationName parent, MirroringEndpointGroup mirroringEndpointGroup, string mirroringEndpointGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringEndpointGroupAsync(new CreateMirroringEndpointGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MirroringEndpointGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringEndpointGroupId, nameof(mirroringEndpointGroupId)),
                MirroringEndpointGroup = gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroup, nameof(mirroringEndpointGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this endpoint group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringEndpointGroup">
        /// Required. The endpoint group to create.
        /// </param>
        /// <param name="mirroringEndpointGroupId">
        /// Required. The ID to use for the endpoint group, which will become the final
        /// component of the endpoint group's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> CreateMirroringEndpointGroupAsync(gagr::LocationName parent, MirroringEndpointGroup mirroringEndpointGroup, string mirroringEndpointGroupId, st::CancellationToken cancellationToken) =>
            CreateMirroringEndpointGroupAsync(parent, mirroringEndpointGroup, mirroringEndpointGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringEndpointGroup, OperationMetadata> UpdateMirroringEndpointGroup(UpdateMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> UpdateMirroringEndpointGroupAsync(UpdateMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> UpdateMirroringEndpointGroupAsync(UpdateMirroringEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateMirroringEndpointGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMirroringEndpointGroup</c>.</summary>
        public virtual lro::OperationsClient UpdateMirroringEndpointGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMirroringEndpointGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MirroringEndpointGroup, OperationMetadata> PollOnceUpdateMirroringEndpointGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringEndpointGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMirroringEndpointGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMirroringEndpointGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> PollOnceUpdateMirroringEndpointGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringEndpointGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMirroringEndpointGroupOperationsClient, callSettings);

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="mirroringEndpointGroup">
        /// Required. The endpoint group to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the endpoint group
        /// (e.g. `description`; *not* `mirroring_endpoint_group.description`).
        /// See https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringEndpointGroup, OperationMetadata> UpdateMirroringEndpointGroup(MirroringEndpointGroup mirroringEndpointGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMirroringEndpointGroup(new UpdateMirroringEndpointGroupRequest
            {
                UpdateMask = updateMask,
                MirroringEndpointGroup = gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroup, nameof(mirroringEndpointGroup)),
            }, callSettings);

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="mirroringEndpointGroup">
        /// Required. The endpoint group to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the endpoint group
        /// (e.g. `description`; *not* `mirroring_endpoint_group.description`).
        /// See https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> UpdateMirroringEndpointGroupAsync(MirroringEndpointGroup mirroringEndpointGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMirroringEndpointGroupAsync(new UpdateMirroringEndpointGroupRequest
            {
                UpdateMask = updateMask,
                MirroringEndpointGroup = gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroup, nameof(mirroringEndpointGroup)),
            }, callSettings);

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="mirroringEndpointGroup">
        /// Required. The endpoint group to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the endpoint group
        /// (e.g. `description`; *not* `mirroring_endpoint_group.description`).
        /// See https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> UpdateMirroringEndpointGroupAsync(MirroringEndpointGroup mirroringEndpointGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMirroringEndpointGroupAsync(mirroringEndpointGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringEndpointGroup(DeleteMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAsync(DeleteMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAsync(DeleteMirroringEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteMirroringEndpointGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMirroringEndpointGroup</c>.</summary>
        public virtual lro::OperationsClient DeleteMirroringEndpointGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMirroringEndpointGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMirroringEndpointGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMirroringEndpointGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMirroringEndpointGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMirroringEndpointGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMirroringEndpointGroupOperationsClient, callSettings);

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The endpoint group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringEndpointGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringEndpointGroup(new DeleteMirroringEndpointGroupRequest
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringEndpointGroupAsync(new DeleteMirroringEndpointGroupRequest
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMirroringEndpointGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The endpoint group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringEndpointGroup(MirroringEndpointGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringEndpointGroup(new DeleteMirroringEndpointGroupRequest
            {
                MirroringEndpointGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAsync(MirroringEndpointGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringEndpointGroupAsync(new DeleteMirroringEndpointGroupRequest
            {
                MirroringEndpointGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAsync(MirroringEndpointGroupName name, st::CancellationToken cancellationToken) =>
            DeleteMirroringEndpointGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists associations in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MirroringEndpointGroupAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> ListMirroringEndpointGroupAssociations(ListMirroringEndpointGroupAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists associations in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="MirroringEndpointGroupAssociation"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> ListMirroringEndpointGroupAssociationsAsync(ListMirroringEndpointGroupAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
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
        /// <returns>A pageable sequence of <see cref="MirroringEndpointGroupAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> ListMirroringEndpointGroupAssociations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringEndpointGroupAssociationsRequest request = new ListMirroringEndpointGroupAssociationsRequest
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
            return ListMirroringEndpointGroupAssociations(request, callSettings);
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
        /// A pageable asynchronous sequence of <see cref="MirroringEndpointGroupAssociation"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> ListMirroringEndpointGroupAssociationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringEndpointGroupAssociationsRequest request = new ListMirroringEndpointGroupAssociationsRequest
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
            return ListMirroringEndpointGroupAssociationsAsync(request, callSettings);
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
        /// <returns>A pageable sequence of <see cref="MirroringEndpointGroupAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> ListMirroringEndpointGroupAssociations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringEndpointGroupAssociationsRequest request = new ListMirroringEndpointGroupAssociationsRequest
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
            return ListMirroringEndpointGroupAssociations(request, callSettings);
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
        /// A pageable asynchronous sequence of <see cref="MirroringEndpointGroupAssociation"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> ListMirroringEndpointGroupAssociationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringEndpointGroupAssociationsRequest request = new ListMirroringEndpointGroupAssociationsRequest
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
            return ListMirroringEndpointGroupAssociationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MirroringEndpointGroupAssociation GetMirroringEndpointGroupAssociation(GetMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringEndpointGroupAssociation> GetMirroringEndpointGroupAssociationAsync(GetMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringEndpointGroupAssociation> GetMirroringEndpointGroupAssociationAsync(GetMirroringEndpointGroupAssociationRequest request, st::CancellationToken cancellationToken) =>
            GetMirroringEndpointGroupAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the association to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MirroringEndpointGroupAssociation GetMirroringEndpointGroupAssociation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringEndpointGroupAssociation(new GetMirroringEndpointGroupAssociationRequest
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
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringEndpointGroupAssociation> GetMirroringEndpointGroupAssociationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringEndpointGroupAssociationAsync(new GetMirroringEndpointGroupAssociationRequest
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
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringEndpointGroupAssociation> GetMirroringEndpointGroupAssociationAsync(string name, st::CancellationToken cancellationToken) =>
            GetMirroringEndpointGroupAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the association to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MirroringEndpointGroupAssociation GetMirroringEndpointGroupAssociation(MirroringEndpointGroupAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringEndpointGroupAssociation(new GetMirroringEndpointGroupAssociationRequest
            {
                MirroringEndpointGroupAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the association to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringEndpointGroupAssociation> GetMirroringEndpointGroupAssociationAsync(MirroringEndpointGroupAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringEndpointGroupAssociationAsync(new GetMirroringEndpointGroupAssociationRequest
            {
                MirroringEndpointGroupAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the association to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringEndpointGroupAssociations/{mirroring_endpoint_group_association}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringEndpointGroupAssociation> GetMirroringEndpointGroupAssociationAsync(MirroringEndpointGroupAssociationName name, st::CancellationToken cancellationToken) =>
            GetMirroringEndpointGroupAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata> CreateMirroringEndpointGroupAssociation(CreateMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> CreateMirroringEndpointGroupAssociationAsync(CreateMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> CreateMirroringEndpointGroupAssociationAsync(CreateMirroringEndpointGroupAssociationRequest request, st::CancellationToken cancellationToken) =>
            CreateMirroringEndpointGroupAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMirroringEndpointGroupAssociation</c>.</summary>
        public virtual lro::OperationsClient CreateMirroringEndpointGroupAssociationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMirroringEndpointGroupAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata> PollOnceCreateMirroringEndpointGroupAssociation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMirroringEndpointGroupAssociationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMirroringEndpointGroupAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> PollOnceCreateMirroringEndpointGroupAssociationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMirroringEndpointGroupAssociationOperationsClient, callSettings);

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this association will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringEndpointGroupAssociation">
        /// Required. The association to create.
        /// </param>
        /// <param name="mirroringEndpointGroupAssociationId">
        /// Optional. The ID to use for the new association, which will become the
        /// final component of the endpoint group's resource name. If not provided, the
        /// server will generate a unique ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata> CreateMirroringEndpointGroupAssociation(string parent, MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation, string mirroringEndpointGroupAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringEndpointGroupAssociation(new CreateMirroringEndpointGroupAssociationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MirroringEndpointGroupAssociationId = mirroringEndpointGroupAssociationId ?? "",
                MirroringEndpointGroupAssociation = gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroupAssociation, nameof(mirroringEndpointGroupAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this association will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringEndpointGroupAssociation">
        /// Required. The association to create.
        /// </param>
        /// <param name="mirroringEndpointGroupAssociationId">
        /// Optional. The ID to use for the new association, which will become the
        /// final component of the endpoint group's resource name. If not provided, the
        /// server will generate a unique ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> CreateMirroringEndpointGroupAssociationAsync(string parent, MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation, string mirroringEndpointGroupAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringEndpointGroupAssociationAsync(new CreateMirroringEndpointGroupAssociationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MirroringEndpointGroupAssociationId = mirroringEndpointGroupAssociationId ?? "",
                MirroringEndpointGroupAssociation = gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroupAssociation, nameof(mirroringEndpointGroupAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this association will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringEndpointGroupAssociation">
        /// Required. The association to create.
        /// </param>
        /// <param name="mirroringEndpointGroupAssociationId">
        /// Optional. The ID to use for the new association, which will become the
        /// final component of the endpoint group's resource name. If not provided, the
        /// server will generate a unique ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> CreateMirroringEndpointGroupAssociationAsync(string parent, MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation, string mirroringEndpointGroupAssociationId, st::CancellationToken cancellationToken) =>
            CreateMirroringEndpointGroupAssociationAsync(parent, mirroringEndpointGroupAssociation, mirroringEndpointGroupAssociationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this association will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringEndpointGroupAssociation">
        /// Required. The association to create.
        /// </param>
        /// <param name="mirroringEndpointGroupAssociationId">
        /// Optional. The ID to use for the new association, which will become the
        /// final component of the endpoint group's resource name. If not provided, the
        /// server will generate a unique ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata> CreateMirroringEndpointGroupAssociation(gagr::LocationName parent, MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation, string mirroringEndpointGroupAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringEndpointGroupAssociation(new CreateMirroringEndpointGroupAssociationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MirroringEndpointGroupAssociationId = mirroringEndpointGroupAssociationId ?? "",
                MirroringEndpointGroupAssociation = gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroupAssociation, nameof(mirroringEndpointGroupAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this association will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringEndpointGroupAssociation">
        /// Required. The association to create.
        /// </param>
        /// <param name="mirroringEndpointGroupAssociationId">
        /// Optional. The ID to use for the new association, which will become the
        /// final component of the endpoint group's resource name. If not provided, the
        /// server will generate a unique ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> CreateMirroringEndpointGroupAssociationAsync(gagr::LocationName parent, MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation, string mirroringEndpointGroupAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringEndpointGroupAssociationAsync(new CreateMirroringEndpointGroupAssociationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MirroringEndpointGroupAssociationId = mirroringEndpointGroupAssociationId ?? "",
                MirroringEndpointGroupAssociation = gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroupAssociation, nameof(mirroringEndpointGroupAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this association will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringEndpointGroupAssociation">
        /// Required. The association to create.
        /// </param>
        /// <param name="mirroringEndpointGroupAssociationId">
        /// Optional. The ID to use for the new association, which will become the
        /// final component of the endpoint group's resource name. If not provided, the
        /// server will generate a unique ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> CreateMirroringEndpointGroupAssociationAsync(gagr::LocationName parent, MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation, string mirroringEndpointGroupAssociationId, st::CancellationToken cancellationToken) =>
            CreateMirroringEndpointGroupAssociationAsync(parent, mirroringEndpointGroupAssociation, mirroringEndpointGroupAssociationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata> UpdateMirroringEndpointGroupAssociation(UpdateMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> UpdateMirroringEndpointGroupAssociationAsync(UpdateMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> UpdateMirroringEndpointGroupAssociationAsync(UpdateMirroringEndpointGroupAssociationRequest request, st::CancellationToken cancellationToken) =>
            UpdateMirroringEndpointGroupAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMirroringEndpointGroupAssociation</c>.</summary>
        public virtual lro::OperationsClient UpdateMirroringEndpointGroupAssociationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMirroringEndpointGroupAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata> PollOnceUpdateMirroringEndpointGroupAssociation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMirroringEndpointGroupAssociationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMirroringEndpointGroupAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> PollOnceUpdateMirroringEndpointGroupAssociationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMirroringEndpointGroupAssociationOperationsClient, callSettings);

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="mirroringEndpointGroupAssociation">
        /// Required. The association to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the association
        /// (e.g. `description`; *not*
        /// `mirroring_endpoint_group_association.description`). See
        /// https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata> UpdateMirroringEndpointGroupAssociation(MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMirroringEndpointGroupAssociation(new UpdateMirroringEndpointGroupAssociationRequest
            {
                UpdateMask = updateMask,
                MirroringEndpointGroupAssociation = gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroupAssociation, nameof(mirroringEndpointGroupAssociation)),
            }, callSettings);

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="mirroringEndpointGroupAssociation">
        /// Required. The association to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the association
        /// (e.g. `description`; *not*
        /// `mirroring_endpoint_group_association.description`). See
        /// https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> UpdateMirroringEndpointGroupAssociationAsync(MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMirroringEndpointGroupAssociationAsync(new UpdateMirroringEndpointGroupAssociationRequest
            {
                UpdateMask = updateMask,
                MirroringEndpointGroupAssociation = gax::GaxPreconditions.CheckNotNull(mirroringEndpointGroupAssociation, nameof(mirroringEndpointGroupAssociation)),
            }, callSettings);

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="mirroringEndpointGroupAssociation">
        /// Required. The association to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the association
        /// (e.g. `description`; *not*
        /// `mirroring_endpoint_group_association.description`). See
        /// https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> UpdateMirroringEndpointGroupAssociationAsync(MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMirroringEndpointGroupAssociationAsync(mirroringEndpointGroupAssociation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringEndpointGroupAssociation(DeleteMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAssociationAsync(DeleteMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAssociationAsync(DeleteMirroringEndpointGroupAssociationRequest request, st::CancellationToken cancellationToken) =>
            DeleteMirroringEndpointGroupAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMirroringEndpointGroupAssociation</c>.</summary>
        public virtual lro::OperationsClient DeleteMirroringEndpointGroupAssociationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMirroringEndpointGroupAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMirroringEndpointGroupAssociation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMirroringEndpointGroupAssociationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMirroringEndpointGroupAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMirroringEndpointGroupAssociationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMirroringEndpointGroupAssociationOperationsClient, callSettings);

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The association to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringEndpointGroupAssociation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringEndpointGroupAssociation(new DeleteMirroringEndpointGroupAssociationRequest
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAssociationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringEndpointGroupAssociationAsync(new DeleteMirroringEndpointGroupAssociationRequest
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAssociationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMirroringEndpointGroupAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The association to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringEndpointGroupAssociation(MirroringEndpointGroupAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringEndpointGroupAssociation(new DeleteMirroringEndpointGroupAssociationRequest
            {
                MirroringEndpointGroupAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAssociationAsync(MirroringEndpointGroupAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringEndpointGroupAssociationAsync(new DeleteMirroringEndpointGroupAssociationRequest
            {
                MirroringEndpointGroupAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAssociationAsync(MirroringEndpointGroupAssociationName name, st::CancellationToken cancellationToken) =>
            DeleteMirroringEndpointGroupAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists deployment groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MirroringDeploymentGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> ListMirroringDeploymentGroups(ListMirroringDeploymentGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists deployment groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MirroringDeploymentGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> ListMirroringDeploymentGroupsAsync(ListMirroringDeploymentGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
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
        /// <returns>A pageable sequence of <see cref="MirroringDeploymentGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> ListMirroringDeploymentGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringDeploymentGroupsRequest request = new ListMirroringDeploymentGroupsRequest
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
            return ListMirroringDeploymentGroups(request, callSettings);
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
        /// <returns>A pageable asynchronous sequence of <see cref="MirroringDeploymentGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> ListMirroringDeploymentGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringDeploymentGroupsRequest request = new ListMirroringDeploymentGroupsRequest
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
            return ListMirroringDeploymentGroupsAsync(request, callSettings);
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
        /// <returns>A pageable sequence of <see cref="MirroringDeploymentGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> ListMirroringDeploymentGroups(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringDeploymentGroupsRequest request = new ListMirroringDeploymentGroupsRequest
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
            return ListMirroringDeploymentGroups(request, callSettings);
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
        /// <returns>A pageable asynchronous sequence of <see cref="MirroringDeploymentGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> ListMirroringDeploymentGroupsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringDeploymentGroupsRequest request = new ListMirroringDeploymentGroupsRequest
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
            return ListMirroringDeploymentGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MirroringDeploymentGroup GetMirroringDeploymentGroup(GetMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringDeploymentGroup> GetMirroringDeploymentGroupAsync(GetMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringDeploymentGroup> GetMirroringDeploymentGroupAsync(GetMirroringDeploymentGroupRequest request, st::CancellationToken cancellationToken) =>
            GetMirroringDeploymentGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MirroringDeploymentGroup GetMirroringDeploymentGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringDeploymentGroup(new GetMirroringDeploymentGroupRequest
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
        /// projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringDeploymentGroup> GetMirroringDeploymentGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringDeploymentGroupAsync(new GetMirroringDeploymentGroupRequest
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
        /// projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringDeploymentGroup> GetMirroringDeploymentGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetMirroringDeploymentGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MirroringDeploymentGroup GetMirroringDeploymentGroup(MirroringDeploymentGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringDeploymentGroup(new GetMirroringDeploymentGroupRequest
            {
                MirroringDeploymentGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringDeploymentGroup> GetMirroringDeploymentGroupAsync(MirroringDeploymentGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringDeploymentGroupAsync(new GetMirroringDeploymentGroupRequest
            {
                MirroringDeploymentGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment group to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringDeploymentGroups/{mirroring_deployment_group}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringDeploymentGroup> GetMirroringDeploymentGroupAsync(MirroringDeploymentGroupName name, st::CancellationToken cancellationToken) =>
            GetMirroringDeploymentGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringDeploymentGroup, OperationMetadata> CreateMirroringDeploymentGroup(CreateMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> CreateMirroringDeploymentGroupAsync(CreateMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> CreateMirroringDeploymentGroupAsync(CreateMirroringDeploymentGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateMirroringDeploymentGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMirroringDeploymentGroup</c>.</summary>
        public virtual lro::OperationsClient CreateMirroringDeploymentGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMirroringDeploymentGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MirroringDeploymentGroup, OperationMetadata> PollOnceCreateMirroringDeploymentGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringDeploymentGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMirroringDeploymentGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMirroringDeploymentGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> PollOnceCreateMirroringDeploymentGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringDeploymentGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMirroringDeploymentGroupOperationsClient, callSettings);

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringDeploymentGroup">
        /// Required. The deployment group to create.
        /// </param>
        /// <param name="mirroringDeploymentGroupId">
        /// Required. The ID to use for the new deployment group, which will become the
        /// final component of the deployment group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringDeploymentGroup, OperationMetadata> CreateMirroringDeploymentGroup(string parent, MirroringDeploymentGroup mirroringDeploymentGroup, string mirroringDeploymentGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringDeploymentGroup(new CreateMirroringDeploymentGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MirroringDeploymentGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentGroupId, nameof(mirroringDeploymentGroupId)),
                MirroringDeploymentGroup = gax::GaxPreconditions.CheckNotNull(mirroringDeploymentGroup, nameof(mirroringDeploymentGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringDeploymentGroup">
        /// Required. The deployment group to create.
        /// </param>
        /// <param name="mirroringDeploymentGroupId">
        /// Required. The ID to use for the new deployment group, which will become the
        /// final component of the deployment group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> CreateMirroringDeploymentGroupAsync(string parent, MirroringDeploymentGroup mirroringDeploymentGroup, string mirroringDeploymentGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringDeploymentGroupAsync(new CreateMirroringDeploymentGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MirroringDeploymentGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentGroupId, nameof(mirroringDeploymentGroupId)),
                MirroringDeploymentGroup = gax::GaxPreconditions.CheckNotNull(mirroringDeploymentGroup, nameof(mirroringDeploymentGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringDeploymentGroup">
        /// Required. The deployment group to create.
        /// </param>
        /// <param name="mirroringDeploymentGroupId">
        /// Required. The ID to use for the new deployment group, which will become the
        /// final component of the deployment group's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> CreateMirroringDeploymentGroupAsync(string parent, MirroringDeploymentGroup mirroringDeploymentGroup, string mirroringDeploymentGroupId, st::CancellationToken cancellationToken) =>
            CreateMirroringDeploymentGroupAsync(parent, mirroringDeploymentGroup, mirroringDeploymentGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringDeploymentGroup">
        /// Required. The deployment group to create.
        /// </param>
        /// <param name="mirroringDeploymentGroupId">
        /// Required. The ID to use for the new deployment group, which will become the
        /// final component of the deployment group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringDeploymentGroup, OperationMetadata> CreateMirroringDeploymentGroup(gagr::LocationName parent, MirroringDeploymentGroup mirroringDeploymentGroup, string mirroringDeploymentGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringDeploymentGroup(new CreateMirroringDeploymentGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MirroringDeploymentGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentGroupId, nameof(mirroringDeploymentGroupId)),
                MirroringDeploymentGroup = gax::GaxPreconditions.CheckNotNull(mirroringDeploymentGroup, nameof(mirroringDeploymentGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringDeploymentGroup">
        /// Required. The deployment group to create.
        /// </param>
        /// <param name="mirroringDeploymentGroupId">
        /// Required. The ID to use for the new deployment group, which will become the
        /// final component of the deployment group's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> CreateMirroringDeploymentGroupAsync(gagr::LocationName parent, MirroringDeploymentGroup mirroringDeploymentGroup, string mirroringDeploymentGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringDeploymentGroupAsync(new CreateMirroringDeploymentGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MirroringDeploymentGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentGroupId, nameof(mirroringDeploymentGroupId)),
                MirroringDeploymentGroup = gax::GaxPreconditions.CheckNotNull(mirroringDeploymentGroup, nameof(mirroringDeploymentGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment group will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringDeploymentGroup">
        /// Required. The deployment group to create.
        /// </param>
        /// <param name="mirroringDeploymentGroupId">
        /// Required. The ID to use for the new deployment group, which will become the
        /// final component of the deployment group's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> CreateMirroringDeploymentGroupAsync(gagr::LocationName parent, MirroringDeploymentGroup mirroringDeploymentGroup, string mirroringDeploymentGroupId, st::CancellationToken cancellationToken) =>
            CreateMirroringDeploymentGroupAsync(parent, mirroringDeploymentGroup, mirroringDeploymentGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringDeploymentGroup, OperationMetadata> UpdateMirroringDeploymentGroup(UpdateMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> UpdateMirroringDeploymentGroupAsync(UpdateMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> UpdateMirroringDeploymentGroupAsync(UpdateMirroringDeploymentGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateMirroringDeploymentGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMirroringDeploymentGroup</c>.</summary>
        public virtual lro::OperationsClient UpdateMirroringDeploymentGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMirroringDeploymentGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MirroringDeploymentGroup, OperationMetadata> PollOnceUpdateMirroringDeploymentGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringDeploymentGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMirroringDeploymentGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMirroringDeploymentGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> PollOnceUpdateMirroringDeploymentGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringDeploymentGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMirroringDeploymentGroupOperationsClient, callSettings);

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="mirroringDeploymentGroup">
        /// Required. The deployment group to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the deployment group
        /// (e.g. `description`; *not*
        /// `mirroring_deployment_group.description`). See
        /// https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringDeploymentGroup, OperationMetadata> UpdateMirroringDeploymentGroup(MirroringDeploymentGroup mirroringDeploymentGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMirroringDeploymentGroup(new UpdateMirroringDeploymentGroupRequest
            {
                UpdateMask = updateMask,
                MirroringDeploymentGroup = gax::GaxPreconditions.CheckNotNull(mirroringDeploymentGroup, nameof(mirroringDeploymentGroup)),
            }, callSettings);

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="mirroringDeploymentGroup">
        /// Required. The deployment group to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the deployment group
        /// (e.g. `description`; *not*
        /// `mirroring_deployment_group.description`). See
        /// https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> UpdateMirroringDeploymentGroupAsync(MirroringDeploymentGroup mirroringDeploymentGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMirroringDeploymentGroupAsync(new UpdateMirroringDeploymentGroupRequest
            {
                UpdateMask = updateMask,
                MirroringDeploymentGroup = gax::GaxPreconditions.CheckNotNull(mirroringDeploymentGroup, nameof(mirroringDeploymentGroup)),
            }, callSettings);

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="mirroringDeploymentGroup">
        /// Required. The deployment group to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the deployment group
        /// (e.g. `description`; *not*
        /// `mirroring_deployment_group.description`). See
        /// https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> UpdateMirroringDeploymentGroupAsync(MirroringDeploymentGroup mirroringDeploymentGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMirroringDeploymentGroupAsync(mirroringDeploymentGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringDeploymentGroup(DeleteMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentGroupAsync(DeleteMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentGroupAsync(DeleteMirroringDeploymentGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteMirroringDeploymentGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMirroringDeploymentGroup</c>.</summary>
        public virtual lro::OperationsClient DeleteMirroringDeploymentGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMirroringDeploymentGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMirroringDeploymentGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMirroringDeploymentGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMirroringDeploymentGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMirroringDeploymentGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMirroringDeploymentGroupOperationsClient, callSettings);

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The deployment group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringDeploymentGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringDeploymentGroup(new DeleteMirroringDeploymentGroupRequest
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringDeploymentGroupAsync(new DeleteMirroringDeploymentGroupRequest
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMirroringDeploymentGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. The deployment group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringDeploymentGroup(MirroringDeploymentGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringDeploymentGroup(new DeleteMirroringDeploymentGroupRequest
            {
                MirroringDeploymentGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentGroupAsync(MirroringDeploymentGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringDeploymentGroupAsync(new DeleteMirroringDeploymentGroupRequest
            {
                MirroringDeploymentGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentGroupAsync(MirroringDeploymentGroupName name, st::CancellationToken cancellationToken) =>
            DeleteMirroringDeploymentGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists deployments in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MirroringDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> ListMirroringDeployments(ListMirroringDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists deployments in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MirroringDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> ListMirroringDeploymentsAsync(ListMirroringDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
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
        /// <returns>A pageable sequence of <see cref="MirroringDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> ListMirroringDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringDeploymentsRequest request = new ListMirroringDeploymentsRequest
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
            return ListMirroringDeployments(request, callSettings);
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
        /// <returns>A pageable asynchronous sequence of <see cref="MirroringDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> ListMirroringDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringDeploymentsRequest request = new ListMirroringDeploymentsRequest
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
            return ListMirroringDeploymentsAsync(request, callSettings);
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
        /// <returns>A pageable sequence of <see cref="MirroringDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> ListMirroringDeployments(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringDeploymentsRequest request = new ListMirroringDeploymentsRequest
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
            return ListMirroringDeployments(request, callSettings);
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
        /// <returns>A pageable asynchronous sequence of <see cref="MirroringDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> ListMirroringDeploymentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMirroringDeploymentsRequest request = new ListMirroringDeploymentsRequest
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
            return ListMirroringDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MirroringDeployment GetMirroringDeployment(GetMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringDeployment> GetMirroringDeploymentAsync(GetMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringDeployment> GetMirroringDeploymentAsync(GetMirroringDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetMirroringDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MirroringDeployment GetMirroringDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringDeployment(new GetMirroringDeploymentRequest
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
        /// projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringDeployment> GetMirroringDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringDeploymentAsync(new GetMirroringDeploymentRequest
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
        /// projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringDeployment> GetMirroringDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetMirroringDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MirroringDeployment GetMirroringDeployment(MirroringDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringDeployment(new GetMirroringDeploymentRequest
            {
                MirroringDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringDeployment> GetMirroringDeploymentAsync(MirroringDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMirroringDeploymentAsync(new GetMirroringDeploymentRequest
            {
                MirroringDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/mirroringDeployments/{mirroring_deployment}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MirroringDeployment> GetMirroringDeploymentAsync(MirroringDeploymentName name, st::CancellationToken cancellationToken) =>
            GetMirroringDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringDeployment, OperationMetadata> CreateMirroringDeployment(CreateMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> CreateMirroringDeploymentAsync(CreateMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> CreateMirroringDeploymentAsync(CreateMirroringDeploymentRequest request, st::CancellationToken cancellationToken) =>
            CreateMirroringDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMirroringDeployment</c>.</summary>
        public virtual lro::OperationsClient CreateMirroringDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMirroringDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MirroringDeployment, OperationMetadata> PollOnceCreateMirroringDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringDeployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMirroringDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMirroringDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> PollOnceCreateMirroringDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringDeployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMirroringDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="mirroringDeploymentId">
        /// Required. The ID to use for the new deployment, which will become the final
        /// component of the deployment's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringDeployment, OperationMetadata> CreateMirroringDeployment(string parent, MirroringDeployment mirroringDeployment, string mirroringDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringDeployment(new CreateMirroringDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MirroringDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentId, nameof(mirroringDeploymentId)),
                MirroringDeployment = gax::GaxPreconditions.CheckNotNull(mirroringDeployment, nameof(mirroringDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="mirroringDeploymentId">
        /// Required. The ID to use for the new deployment, which will become the final
        /// component of the deployment's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> CreateMirroringDeploymentAsync(string parent, MirroringDeployment mirroringDeployment, string mirroringDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringDeploymentAsync(new CreateMirroringDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MirroringDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentId, nameof(mirroringDeploymentId)),
                MirroringDeployment = gax::GaxPreconditions.CheckNotNull(mirroringDeployment, nameof(mirroringDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="mirroringDeploymentId">
        /// Required. The ID to use for the new deployment, which will become the final
        /// component of the deployment's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> CreateMirroringDeploymentAsync(string parent, MirroringDeployment mirroringDeployment, string mirroringDeploymentId, st::CancellationToken cancellationToken) =>
            CreateMirroringDeploymentAsync(parent, mirroringDeployment, mirroringDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="mirroringDeploymentId">
        /// Required. The ID to use for the new deployment, which will become the final
        /// component of the deployment's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringDeployment, OperationMetadata> CreateMirroringDeployment(gagr::LocationName parent, MirroringDeployment mirroringDeployment, string mirroringDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringDeployment(new CreateMirroringDeploymentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MirroringDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentId, nameof(mirroringDeploymentId)),
                MirroringDeployment = gax::GaxPreconditions.CheckNotNull(mirroringDeployment, nameof(mirroringDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="mirroringDeploymentId">
        /// Required. The ID to use for the new deployment, which will become the final
        /// component of the deployment's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> CreateMirroringDeploymentAsync(gagr::LocationName parent, MirroringDeployment mirroringDeployment, string mirroringDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMirroringDeploymentAsync(new CreateMirroringDeploymentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MirroringDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(mirroringDeploymentId, nameof(mirroringDeploymentId)),
                MirroringDeployment = gax::GaxPreconditions.CheckNotNull(mirroringDeployment, nameof(mirroringDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this deployment will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="mirroringDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="mirroringDeploymentId">
        /// Required. The ID to use for the new deployment, which will become the final
        /// component of the deployment's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> CreateMirroringDeploymentAsync(gagr::LocationName parent, MirroringDeployment mirroringDeployment, string mirroringDeploymentId, st::CancellationToken cancellationToken) =>
            CreateMirroringDeploymentAsync(parent, mirroringDeployment, mirroringDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringDeployment, OperationMetadata> UpdateMirroringDeployment(UpdateMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> UpdateMirroringDeploymentAsync(UpdateMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> UpdateMirroringDeploymentAsync(UpdateMirroringDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UpdateMirroringDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMirroringDeployment</c>.</summary>
        public virtual lro::OperationsClient UpdateMirroringDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMirroringDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MirroringDeployment, OperationMetadata> PollOnceUpdateMirroringDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringDeployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMirroringDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMirroringDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> PollOnceUpdateMirroringDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MirroringDeployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMirroringDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="mirroringDeployment">
        /// Required. The deployment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the deployment
        /// (e.g. `description`; *not* `mirroring_deployment.description`).
        /// See https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MirroringDeployment, OperationMetadata> UpdateMirroringDeployment(MirroringDeployment mirroringDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMirroringDeployment(new UpdateMirroringDeploymentRequest
            {
                UpdateMask = updateMask,
                MirroringDeployment = gax::GaxPreconditions.CheckNotNull(mirroringDeployment, nameof(mirroringDeployment)),
            }, callSettings);

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="mirroringDeployment">
        /// Required. The deployment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the deployment
        /// (e.g. `description`; *not* `mirroring_deployment.description`).
        /// See https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> UpdateMirroringDeploymentAsync(MirroringDeployment mirroringDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMirroringDeploymentAsync(new UpdateMirroringDeploymentRequest
            {
                UpdateMask = updateMask,
                MirroringDeployment = gax::GaxPreconditions.CheckNotNull(mirroringDeployment, nameof(mirroringDeployment)),
            }, callSettings);

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="mirroringDeployment">
        /// Required. The deployment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// Fields are specified relative to the deployment
        /// (e.g. `description`; *not* `mirroring_deployment.description`).
        /// See https://google.aip.dev/161 for more details.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> UpdateMirroringDeploymentAsync(MirroringDeployment mirroringDeployment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMirroringDeploymentAsync(mirroringDeployment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringDeployment(DeleteMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentAsync(DeleteMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentAsync(DeleteMirroringDeploymentRequest request, st::CancellationToken cancellationToken) =>
            DeleteMirroringDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMirroringDeployment</c>.</summary>
        public virtual lro::OperationsClient DeleteMirroringDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMirroringDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMirroringDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMirroringDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMirroringDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMirroringDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMirroringDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringDeployment(new DeleteMirroringDeploymentRequest
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringDeploymentAsync(new DeleteMirroringDeploymentRequest
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMirroringDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringDeployment(MirroringDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringDeployment(new DeleteMirroringDeploymentRequest
            {
                MirroringDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentAsync(MirroringDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMirroringDeploymentAsync(new DeleteMirroringDeploymentRequest
            {
                MirroringDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentAsync(MirroringDeploymentName name, st::CancellationToken cancellationToken) =>
            DeleteMirroringDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Mirroring client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// PM2 is the "out-of-band" flavor of the Network Security Integrations product.
    /// </remarks>
    public sealed partial class MirroringClientImpl : MirroringClient
    {
        private readonly gaxgrpc::ApiCall<ListMirroringEndpointGroupsRequest, ListMirroringEndpointGroupsResponse> _callListMirroringEndpointGroups;

        private readonly gaxgrpc::ApiCall<GetMirroringEndpointGroupRequest, MirroringEndpointGroup> _callGetMirroringEndpointGroup;

        private readonly gaxgrpc::ApiCall<CreateMirroringEndpointGroupRequest, lro::Operation> _callCreateMirroringEndpointGroup;

        private readonly gaxgrpc::ApiCall<UpdateMirroringEndpointGroupRequest, lro::Operation> _callUpdateMirroringEndpointGroup;

        private readonly gaxgrpc::ApiCall<DeleteMirroringEndpointGroupRequest, lro::Operation> _callDeleteMirroringEndpointGroup;

        private readonly gaxgrpc::ApiCall<ListMirroringEndpointGroupAssociationsRequest, ListMirroringEndpointGroupAssociationsResponse> _callListMirroringEndpointGroupAssociations;

        private readonly gaxgrpc::ApiCall<GetMirroringEndpointGroupAssociationRequest, MirroringEndpointGroupAssociation> _callGetMirroringEndpointGroupAssociation;

        private readonly gaxgrpc::ApiCall<CreateMirroringEndpointGroupAssociationRequest, lro::Operation> _callCreateMirroringEndpointGroupAssociation;

        private readonly gaxgrpc::ApiCall<UpdateMirroringEndpointGroupAssociationRequest, lro::Operation> _callUpdateMirroringEndpointGroupAssociation;

        private readonly gaxgrpc::ApiCall<DeleteMirroringEndpointGroupAssociationRequest, lro::Operation> _callDeleteMirroringEndpointGroupAssociation;

        private readonly gaxgrpc::ApiCall<ListMirroringDeploymentGroupsRequest, ListMirroringDeploymentGroupsResponse> _callListMirroringDeploymentGroups;

        private readonly gaxgrpc::ApiCall<GetMirroringDeploymentGroupRequest, MirroringDeploymentGroup> _callGetMirroringDeploymentGroup;

        private readonly gaxgrpc::ApiCall<CreateMirroringDeploymentGroupRequest, lro::Operation> _callCreateMirroringDeploymentGroup;

        private readonly gaxgrpc::ApiCall<UpdateMirroringDeploymentGroupRequest, lro::Operation> _callUpdateMirroringDeploymentGroup;

        private readonly gaxgrpc::ApiCall<DeleteMirroringDeploymentGroupRequest, lro::Operation> _callDeleteMirroringDeploymentGroup;

        private readonly gaxgrpc::ApiCall<ListMirroringDeploymentsRequest, ListMirroringDeploymentsResponse> _callListMirroringDeployments;

        private readonly gaxgrpc::ApiCall<GetMirroringDeploymentRequest, MirroringDeployment> _callGetMirroringDeployment;

        private readonly gaxgrpc::ApiCall<CreateMirroringDeploymentRequest, lro::Operation> _callCreateMirroringDeployment;

        private readonly gaxgrpc::ApiCall<UpdateMirroringDeploymentRequest, lro::Operation> _callUpdateMirroringDeployment;

        private readonly gaxgrpc::ApiCall<DeleteMirroringDeploymentRequest, lro::Operation> _callDeleteMirroringDeployment;

        /// <summary>
        /// Constructs a client wrapper for the Mirroring service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MirroringSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MirroringClientImpl(Mirroring.MirroringClient grpcClient, MirroringSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MirroringSettings effectiveSettings = settings ?? MirroringSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateMirroringEndpointGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMirroringEndpointGroupOperationsSettings, logger);
            UpdateMirroringEndpointGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMirroringEndpointGroupOperationsSettings, logger);
            DeleteMirroringEndpointGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMirroringEndpointGroupOperationsSettings, logger);
            CreateMirroringEndpointGroupAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMirroringEndpointGroupAssociationOperationsSettings, logger);
            UpdateMirroringEndpointGroupAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMirroringEndpointGroupAssociationOperationsSettings, logger);
            DeleteMirroringEndpointGroupAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMirroringEndpointGroupAssociationOperationsSettings, logger);
            CreateMirroringDeploymentGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMirroringDeploymentGroupOperationsSettings, logger);
            UpdateMirroringDeploymentGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMirroringDeploymentGroupOperationsSettings, logger);
            DeleteMirroringDeploymentGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMirroringDeploymentGroupOperationsSettings, logger);
            CreateMirroringDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMirroringDeploymentOperationsSettings, logger);
            UpdateMirroringDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMirroringDeploymentOperationsSettings, logger);
            DeleteMirroringDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMirroringDeploymentOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListMirroringEndpointGroups = clientHelper.BuildApiCall<ListMirroringEndpointGroupsRequest, ListMirroringEndpointGroupsResponse>("ListMirroringEndpointGroups", grpcClient.ListMirroringEndpointGroupsAsync, grpcClient.ListMirroringEndpointGroups, effectiveSettings.ListMirroringEndpointGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMirroringEndpointGroups);
            Modify_ListMirroringEndpointGroupsApiCall(ref _callListMirroringEndpointGroups);
            _callGetMirroringEndpointGroup = clientHelper.BuildApiCall<GetMirroringEndpointGroupRequest, MirroringEndpointGroup>("GetMirroringEndpointGroup", grpcClient.GetMirroringEndpointGroupAsync, grpcClient.GetMirroringEndpointGroup, effectiveSettings.GetMirroringEndpointGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMirroringEndpointGroup);
            Modify_GetMirroringEndpointGroupApiCall(ref _callGetMirroringEndpointGroup);
            _callCreateMirroringEndpointGroup = clientHelper.BuildApiCall<CreateMirroringEndpointGroupRequest, lro::Operation>("CreateMirroringEndpointGroup", grpcClient.CreateMirroringEndpointGroupAsync, grpcClient.CreateMirroringEndpointGroup, effectiveSettings.CreateMirroringEndpointGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMirroringEndpointGroup);
            Modify_CreateMirroringEndpointGroupApiCall(ref _callCreateMirroringEndpointGroup);
            _callUpdateMirroringEndpointGroup = clientHelper.BuildApiCall<UpdateMirroringEndpointGroupRequest, lro::Operation>("UpdateMirroringEndpointGroup", grpcClient.UpdateMirroringEndpointGroupAsync, grpcClient.UpdateMirroringEndpointGroup, effectiveSettings.UpdateMirroringEndpointGroupSettings).WithGoogleRequestParam("mirroring_endpoint_group.name", request => request.MirroringEndpointGroup?.Name);
            Modify_ApiCall(ref _callUpdateMirroringEndpointGroup);
            Modify_UpdateMirroringEndpointGroupApiCall(ref _callUpdateMirroringEndpointGroup);
            _callDeleteMirroringEndpointGroup = clientHelper.BuildApiCall<DeleteMirroringEndpointGroupRequest, lro::Operation>("DeleteMirroringEndpointGroup", grpcClient.DeleteMirroringEndpointGroupAsync, grpcClient.DeleteMirroringEndpointGroup, effectiveSettings.DeleteMirroringEndpointGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMirroringEndpointGroup);
            Modify_DeleteMirroringEndpointGroupApiCall(ref _callDeleteMirroringEndpointGroup);
            _callListMirroringEndpointGroupAssociations = clientHelper.BuildApiCall<ListMirroringEndpointGroupAssociationsRequest, ListMirroringEndpointGroupAssociationsResponse>("ListMirroringEndpointGroupAssociations", grpcClient.ListMirroringEndpointGroupAssociationsAsync, grpcClient.ListMirroringEndpointGroupAssociations, effectiveSettings.ListMirroringEndpointGroupAssociationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMirroringEndpointGroupAssociations);
            Modify_ListMirroringEndpointGroupAssociationsApiCall(ref _callListMirroringEndpointGroupAssociations);
            _callGetMirroringEndpointGroupAssociation = clientHelper.BuildApiCall<GetMirroringEndpointGroupAssociationRequest, MirroringEndpointGroupAssociation>("GetMirroringEndpointGroupAssociation", grpcClient.GetMirroringEndpointGroupAssociationAsync, grpcClient.GetMirroringEndpointGroupAssociation, effectiveSettings.GetMirroringEndpointGroupAssociationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMirroringEndpointGroupAssociation);
            Modify_GetMirroringEndpointGroupAssociationApiCall(ref _callGetMirroringEndpointGroupAssociation);
            _callCreateMirroringEndpointGroupAssociation = clientHelper.BuildApiCall<CreateMirroringEndpointGroupAssociationRequest, lro::Operation>("CreateMirroringEndpointGroupAssociation", grpcClient.CreateMirroringEndpointGroupAssociationAsync, grpcClient.CreateMirroringEndpointGroupAssociation, effectiveSettings.CreateMirroringEndpointGroupAssociationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMirroringEndpointGroupAssociation);
            Modify_CreateMirroringEndpointGroupAssociationApiCall(ref _callCreateMirroringEndpointGroupAssociation);
            _callUpdateMirroringEndpointGroupAssociation = clientHelper.BuildApiCall<UpdateMirroringEndpointGroupAssociationRequest, lro::Operation>("UpdateMirroringEndpointGroupAssociation", grpcClient.UpdateMirroringEndpointGroupAssociationAsync, grpcClient.UpdateMirroringEndpointGroupAssociation, effectiveSettings.UpdateMirroringEndpointGroupAssociationSettings).WithGoogleRequestParam("mirroring_endpoint_group_association.name", request => request.MirroringEndpointGroupAssociation?.Name);
            Modify_ApiCall(ref _callUpdateMirroringEndpointGroupAssociation);
            Modify_UpdateMirroringEndpointGroupAssociationApiCall(ref _callUpdateMirroringEndpointGroupAssociation);
            _callDeleteMirroringEndpointGroupAssociation = clientHelper.BuildApiCall<DeleteMirroringEndpointGroupAssociationRequest, lro::Operation>("DeleteMirroringEndpointGroupAssociation", grpcClient.DeleteMirroringEndpointGroupAssociationAsync, grpcClient.DeleteMirroringEndpointGroupAssociation, effectiveSettings.DeleteMirroringEndpointGroupAssociationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMirroringEndpointGroupAssociation);
            Modify_DeleteMirroringEndpointGroupAssociationApiCall(ref _callDeleteMirroringEndpointGroupAssociation);
            _callListMirroringDeploymentGroups = clientHelper.BuildApiCall<ListMirroringDeploymentGroupsRequest, ListMirroringDeploymentGroupsResponse>("ListMirroringDeploymentGroups", grpcClient.ListMirroringDeploymentGroupsAsync, grpcClient.ListMirroringDeploymentGroups, effectiveSettings.ListMirroringDeploymentGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMirroringDeploymentGroups);
            Modify_ListMirroringDeploymentGroupsApiCall(ref _callListMirroringDeploymentGroups);
            _callGetMirroringDeploymentGroup = clientHelper.BuildApiCall<GetMirroringDeploymentGroupRequest, MirroringDeploymentGroup>("GetMirroringDeploymentGroup", grpcClient.GetMirroringDeploymentGroupAsync, grpcClient.GetMirroringDeploymentGroup, effectiveSettings.GetMirroringDeploymentGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMirroringDeploymentGroup);
            Modify_GetMirroringDeploymentGroupApiCall(ref _callGetMirroringDeploymentGroup);
            _callCreateMirroringDeploymentGroup = clientHelper.BuildApiCall<CreateMirroringDeploymentGroupRequest, lro::Operation>("CreateMirroringDeploymentGroup", grpcClient.CreateMirroringDeploymentGroupAsync, grpcClient.CreateMirroringDeploymentGroup, effectiveSettings.CreateMirroringDeploymentGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMirroringDeploymentGroup);
            Modify_CreateMirroringDeploymentGroupApiCall(ref _callCreateMirroringDeploymentGroup);
            _callUpdateMirroringDeploymentGroup = clientHelper.BuildApiCall<UpdateMirroringDeploymentGroupRequest, lro::Operation>("UpdateMirroringDeploymentGroup", grpcClient.UpdateMirroringDeploymentGroupAsync, grpcClient.UpdateMirroringDeploymentGroup, effectiveSettings.UpdateMirroringDeploymentGroupSettings).WithGoogleRequestParam("mirroring_deployment_group.name", request => request.MirroringDeploymentGroup?.Name);
            Modify_ApiCall(ref _callUpdateMirroringDeploymentGroup);
            Modify_UpdateMirroringDeploymentGroupApiCall(ref _callUpdateMirroringDeploymentGroup);
            _callDeleteMirroringDeploymentGroup = clientHelper.BuildApiCall<DeleteMirroringDeploymentGroupRequest, lro::Operation>("DeleteMirroringDeploymentGroup", grpcClient.DeleteMirroringDeploymentGroupAsync, grpcClient.DeleteMirroringDeploymentGroup, effectiveSettings.DeleteMirroringDeploymentGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMirroringDeploymentGroup);
            Modify_DeleteMirroringDeploymentGroupApiCall(ref _callDeleteMirroringDeploymentGroup);
            _callListMirroringDeployments = clientHelper.BuildApiCall<ListMirroringDeploymentsRequest, ListMirroringDeploymentsResponse>("ListMirroringDeployments", grpcClient.ListMirroringDeploymentsAsync, grpcClient.ListMirroringDeployments, effectiveSettings.ListMirroringDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMirroringDeployments);
            Modify_ListMirroringDeploymentsApiCall(ref _callListMirroringDeployments);
            _callGetMirroringDeployment = clientHelper.BuildApiCall<GetMirroringDeploymentRequest, MirroringDeployment>("GetMirroringDeployment", grpcClient.GetMirroringDeploymentAsync, grpcClient.GetMirroringDeployment, effectiveSettings.GetMirroringDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMirroringDeployment);
            Modify_GetMirroringDeploymentApiCall(ref _callGetMirroringDeployment);
            _callCreateMirroringDeployment = clientHelper.BuildApiCall<CreateMirroringDeploymentRequest, lro::Operation>("CreateMirroringDeployment", grpcClient.CreateMirroringDeploymentAsync, grpcClient.CreateMirroringDeployment, effectiveSettings.CreateMirroringDeploymentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMirroringDeployment);
            Modify_CreateMirroringDeploymentApiCall(ref _callCreateMirroringDeployment);
            _callUpdateMirroringDeployment = clientHelper.BuildApiCall<UpdateMirroringDeploymentRequest, lro::Operation>("UpdateMirroringDeployment", grpcClient.UpdateMirroringDeploymentAsync, grpcClient.UpdateMirroringDeployment, effectiveSettings.UpdateMirroringDeploymentSettings).WithGoogleRequestParam("mirroring_deployment.name", request => request.MirroringDeployment?.Name);
            Modify_ApiCall(ref _callUpdateMirroringDeployment);
            Modify_UpdateMirroringDeploymentApiCall(ref _callUpdateMirroringDeployment);
            _callDeleteMirroringDeployment = clientHelper.BuildApiCall<DeleteMirroringDeploymentRequest, lro::Operation>("DeleteMirroringDeployment", grpcClient.DeleteMirroringDeploymentAsync, grpcClient.DeleteMirroringDeployment, effectiveSettings.DeleteMirroringDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMirroringDeployment);
            Modify_DeleteMirroringDeploymentApiCall(ref _callDeleteMirroringDeployment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListMirroringEndpointGroupsApiCall(ref gaxgrpc::ApiCall<ListMirroringEndpointGroupsRequest, ListMirroringEndpointGroupsResponse> call);

        partial void Modify_GetMirroringEndpointGroupApiCall(ref gaxgrpc::ApiCall<GetMirroringEndpointGroupRequest, MirroringEndpointGroup> call);

        partial void Modify_CreateMirroringEndpointGroupApiCall(ref gaxgrpc::ApiCall<CreateMirroringEndpointGroupRequest, lro::Operation> call);

        partial void Modify_UpdateMirroringEndpointGroupApiCall(ref gaxgrpc::ApiCall<UpdateMirroringEndpointGroupRequest, lro::Operation> call);

        partial void Modify_DeleteMirroringEndpointGroupApiCall(ref gaxgrpc::ApiCall<DeleteMirroringEndpointGroupRequest, lro::Operation> call);

        partial void Modify_ListMirroringEndpointGroupAssociationsApiCall(ref gaxgrpc::ApiCall<ListMirroringEndpointGroupAssociationsRequest, ListMirroringEndpointGroupAssociationsResponse> call);

        partial void Modify_GetMirroringEndpointGroupAssociationApiCall(ref gaxgrpc::ApiCall<GetMirroringEndpointGroupAssociationRequest, MirroringEndpointGroupAssociation> call);

        partial void Modify_CreateMirroringEndpointGroupAssociationApiCall(ref gaxgrpc::ApiCall<CreateMirroringEndpointGroupAssociationRequest, lro::Operation> call);

        partial void Modify_UpdateMirroringEndpointGroupAssociationApiCall(ref gaxgrpc::ApiCall<UpdateMirroringEndpointGroupAssociationRequest, lro::Operation> call);

        partial void Modify_DeleteMirroringEndpointGroupAssociationApiCall(ref gaxgrpc::ApiCall<DeleteMirroringEndpointGroupAssociationRequest, lro::Operation> call);

        partial void Modify_ListMirroringDeploymentGroupsApiCall(ref gaxgrpc::ApiCall<ListMirroringDeploymentGroupsRequest, ListMirroringDeploymentGroupsResponse> call);

        partial void Modify_GetMirroringDeploymentGroupApiCall(ref gaxgrpc::ApiCall<GetMirroringDeploymentGroupRequest, MirroringDeploymentGroup> call);

        partial void Modify_CreateMirroringDeploymentGroupApiCall(ref gaxgrpc::ApiCall<CreateMirroringDeploymentGroupRequest, lro::Operation> call);

        partial void Modify_UpdateMirroringDeploymentGroupApiCall(ref gaxgrpc::ApiCall<UpdateMirroringDeploymentGroupRequest, lro::Operation> call);

        partial void Modify_DeleteMirroringDeploymentGroupApiCall(ref gaxgrpc::ApiCall<DeleteMirroringDeploymentGroupRequest, lro::Operation> call);

        partial void Modify_ListMirroringDeploymentsApiCall(ref gaxgrpc::ApiCall<ListMirroringDeploymentsRequest, ListMirroringDeploymentsResponse> call);

        partial void Modify_GetMirroringDeploymentApiCall(ref gaxgrpc::ApiCall<GetMirroringDeploymentRequest, MirroringDeployment> call);

        partial void Modify_CreateMirroringDeploymentApiCall(ref gaxgrpc::ApiCall<CreateMirroringDeploymentRequest, lro::Operation> call);

        partial void Modify_UpdateMirroringDeploymentApiCall(ref gaxgrpc::ApiCall<UpdateMirroringDeploymentRequest, lro::Operation> call);

        partial void Modify_DeleteMirroringDeploymentApiCall(ref gaxgrpc::ApiCall<DeleteMirroringDeploymentRequest, lro::Operation> call);

        partial void OnConstruction(Mirroring.MirroringClient grpcClient, MirroringSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Mirroring client</summary>
        public override Mirroring.MirroringClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListMirroringEndpointGroupsRequest(ref ListMirroringEndpointGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMirroringEndpointGroupRequest(ref GetMirroringEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMirroringEndpointGroupRequest(ref CreateMirroringEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMirroringEndpointGroupRequest(ref UpdateMirroringEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMirroringEndpointGroupRequest(ref DeleteMirroringEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMirroringEndpointGroupAssociationsRequest(ref ListMirroringEndpointGroupAssociationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMirroringEndpointGroupAssociationRequest(ref GetMirroringEndpointGroupAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMirroringEndpointGroupAssociationRequest(ref CreateMirroringEndpointGroupAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMirroringEndpointGroupAssociationRequest(ref UpdateMirroringEndpointGroupAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMirroringEndpointGroupAssociationRequest(ref DeleteMirroringEndpointGroupAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMirroringDeploymentGroupsRequest(ref ListMirroringDeploymentGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMirroringDeploymentGroupRequest(ref GetMirroringDeploymentGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMirroringDeploymentGroupRequest(ref CreateMirroringDeploymentGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMirroringDeploymentGroupRequest(ref UpdateMirroringDeploymentGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMirroringDeploymentGroupRequest(ref DeleteMirroringDeploymentGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMirroringDeploymentsRequest(ref ListMirroringDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMirroringDeploymentRequest(ref GetMirroringDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMirroringDeploymentRequest(ref CreateMirroringDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMirroringDeploymentRequest(ref UpdateMirroringDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMirroringDeploymentRequest(ref DeleteMirroringDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists endpoint groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MirroringEndpointGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> ListMirroringEndpointGroups(ListMirroringEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMirroringEndpointGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMirroringEndpointGroupsRequest, ListMirroringEndpointGroupsResponse, MirroringEndpointGroup>(_callListMirroringEndpointGroups, request, callSettings);
        }

        /// <summary>
        /// Lists endpoint groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MirroringEndpointGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> ListMirroringEndpointGroupsAsync(ListMirroringEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMirroringEndpointGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMirroringEndpointGroupsRequest, ListMirroringEndpointGroupsResponse, MirroringEndpointGroup>(_callListMirroringEndpointGroups, request, callSettings);
        }

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MirroringEndpointGroup GetMirroringEndpointGroup(GetMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMirroringEndpointGroupRequest(ref request, ref callSettings);
            return _callGetMirroringEndpointGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific endpoint group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MirroringEndpointGroup> GetMirroringEndpointGroupAsync(GetMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMirroringEndpointGroupRequest(ref request, ref callSettings);
            return _callGetMirroringEndpointGroup.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMirroringEndpointGroup</c>.</summary>
        public override lro::OperationsClient CreateMirroringEndpointGroupOperationsClient { get; }

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MirroringEndpointGroup, OperationMetadata> CreateMirroringEndpointGroup(CreateMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMirroringEndpointGroupRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringEndpointGroup, OperationMetadata>(_callCreateMirroringEndpointGroup.Sync(request, callSettings), CreateMirroringEndpointGroupOperationsClient);
        }

        /// <summary>
        /// Creates an endpoint group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> CreateMirroringEndpointGroupAsync(CreateMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMirroringEndpointGroupRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringEndpointGroup, OperationMetadata>(await _callCreateMirroringEndpointGroup.Async(request, callSettings).ConfigureAwait(false), CreateMirroringEndpointGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMirroringEndpointGroup</c>.</summary>
        public override lro::OperationsClient UpdateMirroringEndpointGroupOperationsClient { get; }

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MirroringEndpointGroup, OperationMetadata> UpdateMirroringEndpointGroup(UpdateMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMirroringEndpointGroupRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringEndpointGroup, OperationMetadata>(_callUpdateMirroringEndpointGroup.Sync(request, callSettings), UpdateMirroringEndpointGroupOperationsClient);
        }

        /// <summary>
        /// Updates an endpoint group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MirroringEndpointGroup, OperationMetadata>> UpdateMirroringEndpointGroupAsync(UpdateMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMirroringEndpointGroupRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringEndpointGroup, OperationMetadata>(await _callUpdateMirroringEndpointGroup.Async(request, callSettings).ConfigureAwait(false), UpdateMirroringEndpointGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMirroringEndpointGroup</c>.</summary>
        public override lro::OperationsClient DeleteMirroringEndpointGroupOperationsClient { get; }

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringEndpointGroup(DeleteMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMirroringEndpointGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMirroringEndpointGroup.Sync(request, callSettings), DeleteMirroringEndpointGroupOperationsClient);
        }

        /// <summary>
        /// Deletes an endpoint group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAsync(DeleteMirroringEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMirroringEndpointGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMirroringEndpointGroup.Async(request, callSettings).ConfigureAwait(false), DeleteMirroringEndpointGroupOperationsClient);
        }

        /// <summary>
        /// Lists associations in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MirroringEndpointGroupAssociation"/> resources.</returns>
        public override gax::PagedEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> ListMirroringEndpointGroupAssociations(ListMirroringEndpointGroupAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMirroringEndpointGroupAssociationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMirroringEndpointGroupAssociationsRequest, ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation>(_callListMirroringEndpointGroupAssociations, request, callSettings);
        }

        /// <summary>
        /// Lists associations in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="MirroringEndpointGroupAssociation"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> ListMirroringEndpointGroupAssociationsAsync(ListMirroringEndpointGroupAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMirroringEndpointGroupAssociationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMirroringEndpointGroupAssociationsRequest, ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation>(_callListMirroringEndpointGroupAssociations, request, callSettings);
        }

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MirroringEndpointGroupAssociation GetMirroringEndpointGroupAssociation(GetMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMirroringEndpointGroupAssociationRequest(ref request, ref callSettings);
            return _callGetMirroringEndpointGroupAssociation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific association.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MirroringEndpointGroupAssociation> GetMirroringEndpointGroupAssociationAsync(GetMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMirroringEndpointGroupAssociationRequest(ref request, ref callSettings);
            return _callGetMirroringEndpointGroupAssociation.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMirroringEndpointGroupAssociation</c>.</summary>
        public override lro::OperationsClient CreateMirroringEndpointGroupAssociationOperationsClient { get; }

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata> CreateMirroringEndpointGroupAssociation(CreateMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMirroringEndpointGroupAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>(_callCreateMirroringEndpointGroupAssociation.Sync(request, callSettings), CreateMirroringEndpointGroupAssociationOperationsClient);
        }

        /// <summary>
        /// Creates an association in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> CreateMirroringEndpointGroupAssociationAsync(CreateMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMirroringEndpointGroupAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>(await _callCreateMirroringEndpointGroupAssociation.Async(request, callSettings).ConfigureAwait(false), CreateMirroringEndpointGroupAssociationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMirroringEndpointGroupAssociation</c>.</summary>
        public override lro::OperationsClient UpdateMirroringEndpointGroupAssociationOperationsClient { get; }

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata> UpdateMirroringEndpointGroupAssociation(UpdateMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMirroringEndpointGroupAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>(_callUpdateMirroringEndpointGroupAssociation.Sync(request, callSettings), UpdateMirroringEndpointGroupAssociationOperationsClient);
        }

        /// <summary>
        /// Updates an association.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>> UpdateMirroringEndpointGroupAssociationAsync(UpdateMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMirroringEndpointGroupAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringEndpointGroupAssociation, OperationMetadata>(await _callUpdateMirroringEndpointGroupAssociation.Async(request, callSettings).ConfigureAwait(false), UpdateMirroringEndpointGroupAssociationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMirroringEndpointGroupAssociation</c>.</summary>
        public override lro::OperationsClient DeleteMirroringEndpointGroupAssociationOperationsClient { get; }

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringEndpointGroupAssociation(DeleteMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMirroringEndpointGroupAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMirroringEndpointGroupAssociation.Sync(request, callSettings), DeleteMirroringEndpointGroupAssociationOperationsClient);
        }

        /// <summary>
        /// Deletes an association.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringEndpointGroupAssociationAsync(DeleteMirroringEndpointGroupAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMirroringEndpointGroupAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMirroringEndpointGroupAssociation.Async(request, callSettings).ConfigureAwait(false), DeleteMirroringEndpointGroupAssociationOperationsClient);
        }

        /// <summary>
        /// Lists deployment groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MirroringDeploymentGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> ListMirroringDeploymentGroups(ListMirroringDeploymentGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMirroringDeploymentGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMirroringDeploymentGroupsRequest, ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup>(_callListMirroringDeploymentGroups, request, callSettings);
        }

        /// <summary>
        /// Lists deployment groups in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MirroringDeploymentGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> ListMirroringDeploymentGroupsAsync(ListMirroringDeploymentGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMirroringDeploymentGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMirroringDeploymentGroupsRequest, ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup>(_callListMirroringDeploymentGroups, request, callSettings);
        }

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MirroringDeploymentGroup GetMirroringDeploymentGroup(GetMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMirroringDeploymentGroupRequest(ref request, ref callSettings);
            return _callGetMirroringDeploymentGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific deployment group.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MirroringDeploymentGroup> GetMirroringDeploymentGroupAsync(GetMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMirroringDeploymentGroupRequest(ref request, ref callSettings);
            return _callGetMirroringDeploymentGroup.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMirroringDeploymentGroup</c>.</summary>
        public override lro::OperationsClient CreateMirroringDeploymentGroupOperationsClient { get; }

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MirroringDeploymentGroup, OperationMetadata> CreateMirroringDeploymentGroup(CreateMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMirroringDeploymentGroupRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringDeploymentGroup, OperationMetadata>(_callCreateMirroringDeploymentGroup.Sync(request, callSettings), CreateMirroringDeploymentGroupOperationsClient);
        }

        /// <summary>
        /// Creates a deployment group in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> CreateMirroringDeploymentGroupAsync(CreateMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMirroringDeploymentGroupRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringDeploymentGroup, OperationMetadata>(await _callCreateMirroringDeploymentGroup.Async(request, callSettings).ConfigureAwait(false), CreateMirroringDeploymentGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMirroringDeploymentGroup</c>.</summary>
        public override lro::OperationsClient UpdateMirroringDeploymentGroupOperationsClient { get; }

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MirroringDeploymentGroup, OperationMetadata> UpdateMirroringDeploymentGroup(UpdateMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMirroringDeploymentGroupRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringDeploymentGroup, OperationMetadata>(_callUpdateMirroringDeploymentGroup.Sync(request, callSettings), UpdateMirroringDeploymentGroupOperationsClient);
        }

        /// <summary>
        /// Updates a deployment group.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MirroringDeploymentGroup, OperationMetadata>> UpdateMirroringDeploymentGroupAsync(UpdateMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMirroringDeploymentGroupRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringDeploymentGroup, OperationMetadata>(await _callUpdateMirroringDeploymentGroup.Async(request, callSettings).ConfigureAwait(false), UpdateMirroringDeploymentGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMirroringDeploymentGroup</c>.</summary>
        public override lro::OperationsClient DeleteMirroringDeploymentGroupOperationsClient { get; }

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringDeploymentGroup(DeleteMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMirroringDeploymentGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMirroringDeploymentGroup.Sync(request, callSettings), DeleteMirroringDeploymentGroupOperationsClient);
        }

        /// <summary>
        /// Deletes a deployment group.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentGroupAsync(DeleteMirroringDeploymentGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMirroringDeploymentGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMirroringDeploymentGroup.Async(request, callSettings).ConfigureAwait(false), DeleteMirroringDeploymentGroupOperationsClient);
        }

        /// <summary>
        /// Lists deployments in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MirroringDeployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> ListMirroringDeployments(ListMirroringDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMirroringDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMirroringDeploymentsRequest, ListMirroringDeploymentsResponse, MirroringDeployment>(_callListMirroringDeployments, request, callSettings);
        }

        /// <summary>
        /// Lists deployments in a given project and location.
        /// See https://google.aip.dev/132.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MirroringDeployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> ListMirroringDeploymentsAsync(ListMirroringDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMirroringDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMirroringDeploymentsRequest, ListMirroringDeploymentsResponse, MirroringDeployment>(_callListMirroringDeployments, request, callSettings);
        }

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MirroringDeployment GetMirroringDeployment(GetMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMirroringDeploymentRequest(ref request, ref callSettings);
            return _callGetMirroringDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific deployment.
        /// See https://google.aip.dev/131.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MirroringDeployment> GetMirroringDeploymentAsync(GetMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMirroringDeploymentRequest(ref request, ref callSettings);
            return _callGetMirroringDeployment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMirroringDeployment</c>.</summary>
        public override lro::OperationsClient CreateMirroringDeploymentOperationsClient { get; }

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MirroringDeployment, OperationMetadata> CreateMirroringDeployment(CreateMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMirroringDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringDeployment, OperationMetadata>(_callCreateMirroringDeployment.Sync(request, callSettings), CreateMirroringDeploymentOperationsClient);
        }

        /// <summary>
        /// Creates a deployment in a given project and location.
        /// See https://google.aip.dev/133.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> CreateMirroringDeploymentAsync(CreateMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMirroringDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringDeployment, OperationMetadata>(await _callCreateMirroringDeployment.Async(request, callSettings).ConfigureAwait(false), CreateMirroringDeploymentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMirroringDeployment</c>.</summary>
        public override lro::OperationsClient UpdateMirroringDeploymentOperationsClient { get; }

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MirroringDeployment, OperationMetadata> UpdateMirroringDeployment(UpdateMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMirroringDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringDeployment, OperationMetadata>(_callUpdateMirroringDeployment.Sync(request, callSettings), UpdateMirroringDeploymentOperationsClient);
        }

        /// <summary>
        /// Updates a deployment.
        /// See https://google.aip.dev/134.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MirroringDeployment, OperationMetadata>> UpdateMirroringDeploymentAsync(UpdateMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMirroringDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<MirroringDeployment, OperationMetadata>(await _callUpdateMirroringDeployment.Async(request, callSettings).ConfigureAwait(false), UpdateMirroringDeploymentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMirroringDeployment</c>.</summary>
        public override lro::OperationsClient DeleteMirroringDeploymentOperationsClient { get; }

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMirroringDeployment(DeleteMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMirroringDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMirroringDeployment.Sync(request, callSettings), DeleteMirroringDeploymentOperationsClient);
        }

        /// <summary>
        /// Deletes a deployment.
        /// See https://google.aip.dev/135.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMirroringDeploymentAsync(DeleteMirroringDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMirroringDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMirroringDeployment.Async(request, callSettings).ConfigureAwait(false), DeleteMirroringDeploymentOperationsClient);
        }
    }

    public partial class ListMirroringEndpointGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMirroringEndpointGroupAssociationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMirroringDeploymentGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMirroringDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMirroringEndpointGroupsResponse : gaxgrpc::IPageResponse<MirroringEndpointGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MirroringEndpointGroup> GetEnumerator() => MirroringEndpointGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMirroringEndpointGroupAssociationsResponse : gaxgrpc::IPageResponse<MirroringEndpointGroupAssociation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MirroringEndpointGroupAssociation> GetEnumerator() =>
            MirroringEndpointGroupAssociations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMirroringDeploymentGroupsResponse : gaxgrpc::IPageResponse<MirroringDeploymentGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MirroringDeploymentGroup> GetEnumerator() => MirroringDeploymentGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMirroringDeploymentsResponse : gaxgrpc::IPageResponse<MirroringDeployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MirroringDeployment> GetEnumerator() => MirroringDeployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Mirroring
    {
        public partial class MirroringClient
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

    public static partial class Mirroring
    {
        public partial class MirroringClient
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
