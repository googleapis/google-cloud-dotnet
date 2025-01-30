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

namespace Google.Cloud.TelcoAutomation.V1
{
    /// <summary>Settings for <see cref="TelcoAutomationClient"/> instances.</summary>
    public sealed partial class TelcoAutomationSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TelcoAutomationSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TelcoAutomationSettings"/>.</returns>
        public static TelcoAutomationSettings GetDefault() => new TelcoAutomationSettings();

        /// <summary>Constructs a new <see cref="TelcoAutomationSettings"/> object with default settings.</summary>
        public TelcoAutomationSettings()
        {
        }

        private TelcoAutomationSettings(TelcoAutomationSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListOrchestrationClustersSettings = existing.ListOrchestrationClustersSettings;
            GetOrchestrationClusterSettings = existing.GetOrchestrationClusterSettings;
            CreateOrchestrationClusterSettings = existing.CreateOrchestrationClusterSettings;
            CreateOrchestrationClusterOperationsSettings = existing.CreateOrchestrationClusterOperationsSettings.Clone();
            DeleteOrchestrationClusterSettings = existing.DeleteOrchestrationClusterSettings;
            DeleteOrchestrationClusterOperationsSettings = existing.DeleteOrchestrationClusterOperationsSettings.Clone();
            ListEdgeSlmsSettings = existing.ListEdgeSlmsSettings;
            GetEdgeSlmSettings = existing.GetEdgeSlmSettings;
            CreateEdgeSlmSettings = existing.CreateEdgeSlmSettings;
            CreateEdgeSlmOperationsSettings = existing.CreateEdgeSlmOperationsSettings.Clone();
            DeleteEdgeSlmSettings = existing.DeleteEdgeSlmSettings;
            DeleteEdgeSlmOperationsSettings = existing.DeleteEdgeSlmOperationsSettings.Clone();
            CreateBlueprintSettings = existing.CreateBlueprintSettings;
            UpdateBlueprintSettings = existing.UpdateBlueprintSettings;
            GetBlueprintSettings = existing.GetBlueprintSettings;
            DeleteBlueprintSettings = existing.DeleteBlueprintSettings;
            ListBlueprintsSettings = existing.ListBlueprintsSettings;
            ApproveBlueprintSettings = existing.ApproveBlueprintSettings;
            ProposeBlueprintSettings = existing.ProposeBlueprintSettings;
            RejectBlueprintSettings = existing.RejectBlueprintSettings;
            ListBlueprintRevisionsSettings = existing.ListBlueprintRevisionsSettings;
            SearchBlueprintRevisionsSettings = existing.SearchBlueprintRevisionsSettings;
            SearchDeploymentRevisionsSettings = existing.SearchDeploymentRevisionsSettings;
            DiscardBlueprintChangesSettings = existing.DiscardBlueprintChangesSettings;
            ListPublicBlueprintsSettings = existing.ListPublicBlueprintsSettings;
            GetPublicBlueprintSettings = existing.GetPublicBlueprintSettings;
            CreateDeploymentSettings = existing.CreateDeploymentSettings;
            UpdateDeploymentSettings = existing.UpdateDeploymentSettings;
            GetDeploymentSettings = existing.GetDeploymentSettings;
            RemoveDeploymentSettings = existing.RemoveDeploymentSettings;
            ListDeploymentsSettings = existing.ListDeploymentsSettings;
            ListDeploymentRevisionsSettings = existing.ListDeploymentRevisionsSettings;
            DiscardDeploymentChangesSettings = existing.DiscardDeploymentChangesSettings;
            ApplyDeploymentSettings = existing.ApplyDeploymentSettings;
            ComputeDeploymentStatusSettings = existing.ComputeDeploymentStatusSettings;
            RollbackDeploymentSettings = existing.RollbackDeploymentSettings;
            GetHydratedDeploymentSettings = existing.GetHydratedDeploymentSettings;
            ListHydratedDeploymentsSettings = existing.ListHydratedDeploymentsSettings;
            UpdateHydratedDeploymentSettings = existing.UpdateHydratedDeploymentSettings;
            ApplyHydratedDeploymentSettings = existing.ApplyHydratedDeploymentSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TelcoAutomationSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.ListOrchestrationClusters</c> and
        /// <c>TelcoAutomationClient.ListOrchestrationClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOrchestrationClustersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.GetOrchestrationCluster</c> and
        /// <c>TelcoAutomationClient.GetOrchestrationClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOrchestrationClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.CreateOrchestrationCluster</c> and
        /// <c>TelcoAutomationClient.CreateOrchestrationClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateOrchestrationClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>TelcoAutomationClient.CreateOrchestrationCluster</c> and
        /// <c>TelcoAutomationClient.CreateOrchestrationClusterAsync</c>.
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
        public lro::OperationsSettings CreateOrchestrationClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.DeleteOrchestrationCluster</c> and
        /// <c>TelcoAutomationClient.DeleteOrchestrationClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteOrchestrationClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>TelcoAutomationClient.DeleteOrchestrationCluster</c> and
        /// <c>TelcoAutomationClient.DeleteOrchestrationClusterAsync</c>.
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
        public lro::OperationsSettings DeleteOrchestrationClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.ListEdgeSlms</c> and <c>TelcoAutomationClient.ListEdgeSlmsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEdgeSlmsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.GetEdgeSlm</c> and <c>TelcoAutomationClient.GetEdgeSlmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEdgeSlmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.CreateEdgeSlm</c> and <c>TelcoAutomationClient.CreateEdgeSlmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEdgeSlmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>TelcoAutomationClient.CreateEdgeSlm</c> and
        /// <c>TelcoAutomationClient.CreateEdgeSlmAsync</c>.
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
        public lro::OperationsSettings CreateEdgeSlmOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.DeleteEdgeSlm</c> and <c>TelcoAutomationClient.DeleteEdgeSlmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEdgeSlmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>TelcoAutomationClient.DeleteEdgeSlm</c> and
        /// <c>TelcoAutomationClient.DeleteEdgeSlmAsync</c>.
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
        public lro::OperationsSettings DeleteEdgeSlmOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.CreateBlueprint</c> and <c>TelcoAutomationClient.CreateBlueprintAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBlueprintSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.UpdateBlueprint</c> and <c>TelcoAutomationClient.UpdateBlueprintAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBlueprintSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.GetBlueprint</c> and <c>TelcoAutomationClient.GetBlueprintAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBlueprintSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.DeleteBlueprint</c> and <c>TelcoAutomationClient.DeleteBlueprintAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBlueprintSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.ListBlueprints</c> and <c>TelcoAutomationClient.ListBlueprintsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBlueprintsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.ApproveBlueprint</c> and <c>TelcoAutomationClient.ApproveBlueprintAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ApproveBlueprintSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.ProposeBlueprint</c> and <c>TelcoAutomationClient.ProposeBlueprintAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ProposeBlueprintSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.RejectBlueprint</c> and <c>TelcoAutomationClient.RejectBlueprintAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RejectBlueprintSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.ListBlueprintRevisions</c> and <c>TelcoAutomationClient.ListBlueprintRevisionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBlueprintRevisionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.SearchBlueprintRevisions</c> and
        /// <c>TelcoAutomationClient.SearchBlueprintRevisionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchBlueprintRevisionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.SearchDeploymentRevisions</c> and
        /// <c>TelcoAutomationClient.SearchDeploymentRevisionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchDeploymentRevisionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.DiscardBlueprintChanges</c> and
        /// <c>TelcoAutomationClient.DiscardBlueprintChangesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DiscardBlueprintChangesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.ListPublicBlueprints</c> and <c>TelcoAutomationClient.ListPublicBlueprintsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPublicBlueprintsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.GetPublicBlueprint</c> and <c>TelcoAutomationClient.GetPublicBlueprintAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPublicBlueprintSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.CreateDeployment</c> and <c>TelcoAutomationClient.CreateDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.UpdateDeployment</c> and <c>TelcoAutomationClient.UpdateDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.GetDeployment</c> and <c>TelcoAutomationClient.GetDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.RemoveDeployment</c> and <c>TelcoAutomationClient.RemoveDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.ListDeployments</c> and <c>TelcoAutomationClient.ListDeploymentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeploymentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.ListDeploymentRevisions</c> and
        /// <c>TelcoAutomationClient.ListDeploymentRevisionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeploymentRevisionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.DiscardDeploymentChanges</c> and
        /// <c>TelcoAutomationClient.DiscardDeploymentChangesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DiscardDeploymentChangesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.ApplyDeployment</c> and <c>TelcoAutomationClient.ApplyDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ApplyDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.ComputeDeploymentStatus</c> and
        /// <c>TelcoAutomationClient.ComputeDeploymentStatusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ComputeDeploymentStatusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.RollbackDeployment</c> and <c>TelcoAutomationClient.RollbackDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RollbackDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.GetHydratedDeployment</c> and <c>TelcoAutomationClient.GetHydratedDeploymentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetHydratedDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.ListHydratedDeployments</c> and
        /// <c>TelcoAutomationClient.ListHydratedDeploymentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListHydratedDeploymentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.UpdateHydratedDeployment</c> and
        /// <c>TelcoAutomationClient.UpdateHydratedDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateHydratedDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TelcoAutomationClient.ApplyHydratedDeployment</c> and
        /// <c>TelcoAutomationClient.ApplyHydratedDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ApplyHydratedDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TelcoAutomationSettings"/> object.</returns>
        public TelcoAutomationSettings Clone() => new TelcoAutomationSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TelcoAutomationClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class TelcoAutomationClientBuilder : gaxgrpc::ClientBuilderBase<TelcoAutomationClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TelcoAutomationSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TelcoAutomationClientBuilder() : base(TelcoAutomationClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TelcoAutomationClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TelcoAutomationClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TelcoAutomationClient Build()
        {
            TelcoAutomationClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TelcoAutomationClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TelcoAutomationClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TelcoAutomationClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TelcoAutomationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TelcoAutomationClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TelcoAutomationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TelcoAutomationClient.ChannelPool;
    }

    /// <summary>TelcoAutomation client wrapper, for convenient use.</summary>
    /// <remarks>
    /// TelcoAutomation Service manages the control plane cluster a.k.a.
    /// Orchestration Cluster (GKE cluster with config controller) of TNA. It also
    /// exposes blueprint APIs which manages the lifecycle of blueprints that control
    /// the infrastructure setup (e.g GDCE clusters) and deployment of network
    /// functions.
    /// </remarks>
    public abstract partial class TelcoAutomationClient
    {
        /// <summary>
        /// The default endpoint for the TelcoAutomation service, which is a host of "telcoautomation.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "telcoautomation.googleapis.com:443";

        /// <summary>The default TelcoAutomation scopes.</summary>
        /// <remarks>
        /// The default TelcoAutomation scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TelcoAutomation.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TelcoAutomationClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TelcoAutomationClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TelcoAutomationClient"/>.</returns>
        public static stt::Task<TelcoAutomationClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TelcoAutomationClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TelcoAutomationClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TelcoAutomationClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TelcoAutomationClient"/>.</returns>
        public static TelcoAutomationClient Create() => new TelcoAutomationClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TelcoAutomationClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TelcoAutomationSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TelcoAutomationClient"/>.</returns>
        internal static TelcoAutomationClient Create(grpccore::CallInvoker callInvoker, TelcoAutomationSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TelcoAutomation.TelcoAutomationClient grpcClient = new TelcoAutomation.TelcoAutomationClient(callInvoker);
            return new TelcoAutomationClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TelcoAutomation client</summary>
        public virtual TelcoAutomation.TelcoAutomationClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists OrchestrationClusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OrchestrationCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> ListOrchestrationClusters(ListOrchestrationClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists OrchestrationClusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OrchestrationCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> ListOrchestrationClustersAsync(ListOrchestrationClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists OrchestrationClusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListOrchestrationClustersRequest
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
        /// <returns>A pageable sequence of <see cref="OrchestrationCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> ListOrchestrationClusters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrchestrationClustersRequest request = new ListOrchestrationClustersRequest
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
            return ListOrchestrationClusters(request, callSettings);
        }

        /// <summary>
        /// Lists OrchestrationClusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListOrchestrationClustersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="OrchestrationCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> ListOrchestrationClustersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrchestrationClustersRequest request = new ListOrchestrationClustersRequest
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
            return ListOrchestrationClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists OrchestrationClusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListOrchestrationClustersRequest
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
        /// <returns>A pageable sequence of <see cref="OrchestrationCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> ListOrchestrationClusters(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrchestrationClustersRequest request = new ListOrchestrationClustersRequest
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
            return ListOrchestrationClusters(request, callSettings);
        }

        /// <summary>
        /// Lists OrchestrationClusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListOrchestrationClustersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="OrchestrationCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> ListOrchestrationClustersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrchestrationClustersRequest request = new ListOrchestrationClustersRequest
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
            return ListOrchestrationClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single OrchestrationCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrchestrationCluster GetOrchestrationCluster(GetOrchestrationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single OrchestrationCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrchestrationCluster> GetOrchestrationClusterAsync(GetOrchestrationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single OrchestrationCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrchestrationCluster> GetOrchestrationClusterAsync(GetOrchestrationClusterRequest request, st::CancellationToken cancellationToken) =>
            GetOrchestrationClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single OrchestrationCluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrchestrationCluster GetOrchestrationCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrchestrationCluster(new GetOrchestrationClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single OrchestrationCluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrchestrationCluster> GetOrchestrationClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrchestrationClusterAsync(new GetOrchestrationClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single OrchestrationCluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrchestrationCluster> GetOrchestrationClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetOrchestrationClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single OrchestrationCluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrchestrationCluster GetOrchestrationCluster(OrchestrationClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrchestrationCluster(new GetOrchestrationClusterRequest
            {
                OrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single OrchestrationCluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrchestrationCluster> GetOrchestrationClusterAsync(OrchestrationClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrchestrationClusterAsync(new GetOrchestrationClusterRequest
            {
                OrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single OrchestrationCluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrchestrationCluster> GetOrchestrationClusterAsync(OrchestrationClusterName name, st::CancellationToken cancellationToken) =>
            GetOrchestrationClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new OrchestrationCluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OrchestrationCluster, OperationMetadata> CreateOrchestrationCluster(CreateOrchestrationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new OrchestrationCluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OrchestrationCluster, OperationMetadata>> CreateOrchestrationClusterAsync(CreateOrchestrationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new OrchestrationCluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OrchestrationCluster, OperationMetadata>> CreateOrchestrationClusterAsync(CreateOrchestrationClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateOrchestrationClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateOrchestrationCluster</c>.</summary>
        public virtual lro::OperationsClient CreateOrchestrationClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateOrchestrationCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<OrchestrationCluster, OperationMetadata> PollOnceCreateOrchestrationCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OrchestrationCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOrchestrationClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateOrchestrationCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<OrchestrationCluster, OperationMetadata>> PollOnceCreateOrchestrationClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OrchestrationCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOrchestrationClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a new OrchestrationCluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="orchestrationCluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="orchestrationClusterId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// orchestration_cluster_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OrchestrationCluster, OperationMetadata> CreateOrchestrationCluster(string parent, OrchestrationCluster orchestrationCluster, string orchestrationClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrchestrationCluster(new CreateOrchestrationClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OrchestrationClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)),
                OrchestrationCluster = gax::GaxPreconditions.CheckNotNull(orchestrationCluster, nameof(orchestrationCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new OrchestrationCluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="orchestrationCluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="orchestrationClusterId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// orchestration_cluster_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OrchestrationCluster, OperationMetadata>> CreateOrchestrationClusterAsync(string parent, OrchestrationCluster orchestrationCluster, string orchestrationClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrchestrationClusterAsync(new CreateOrchestrationClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OrchestrationClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)),
                OrchestrationCluster = gax::GaxPreconditions.CheckNotNull(orchestrationCluster, nameof(orchestrationCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new OrchestrationCluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="orchestrationCluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="orchestrationClusterId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// orchestration_cluster_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OrchestrationCluster, OperationMetadata>> CreateOrchestrationClusterAsync(string parent, OrchestrationCluster orchestrationCluster, string orchestrationClusterId, st::CancellationToken cancellationToken) =>
            CreateOrchestrationClusterAsync(parent, orchestrationCluster, orchestrationClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new OrchestrationCluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="orchestrationCluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="orchestrationClusterId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// orchestration_cluster_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OrchestrationCluster, OperationMetadata> CreateOrchestrationCluster(gagr::LocationName parent, OrchestrationCluster orchestrationCluster, string orchestrationClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrchestrationCluster(new CreateOrchestrationClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrchestrationClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)),
                OrchestrationCluster = gax::GaxPreconditions.CheckNotNull(orchestrationCluster, nameof(orchestrationCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new OrchestrationCluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="orchestrationCluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="orchestrationClusterId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// orchestration_cluster_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OrchestrationCluster, OperationMetadata>> CreateOrchestrationClusterAsync(gagr::LocationName parent, OrchestrationCluster orchestrationCluster, string orchestrationClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrchestrationClusterAsync(new CreateOrchestrationClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrchestrationClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)),
                OrchestrationCluster = gax::GaxPreconditions.CheckNotNull(orchestrationCluster, nameof(orchestrationCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new OrchestrationCluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="orchestrationCluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="orchestrationClusterId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// orchestration_cluster_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OrchestrationCluster, OperationMetadata>> CreateOrchestrationClusterAsync(gagr::LocationName parent, OrchestrationCluster orchestrationCluster, string orchestrationClusterId, st::CancellationToken cancellationToken) =>
            CreateOrchestrationClusterAsync(parent, orchestrationCluster, orchestrationClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single OrchestrationCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOrchestrationCluster(DeleteOrchestrationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single OrchestrationCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrchestrationClusterAsync(DeleteOrchestrationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single OrchestrationCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrchestrationClusterAsync(DeleteOrchestrationClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteOrchestrationClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteOrchestrationCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteOrchestrationClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteOrchestrationCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteOrchestrationCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOrchestrationClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteOrchestrationCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteOrchestrationClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOrchestrationClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single OrchestrationCluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOrchestrationCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOrchestrationCluster(new DeleteOrchestrationClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single OrchestrationCluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrchestrationClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOrchestrationClusterAsync(new DeleteOrchestrationClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single OrchestrationCluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrchestrationClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteOrchestrationClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single OrchestrationCluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOrchestrationCluster(OrchestrationClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOrchestrationCluster(new DeleteOrchestrationClusterRequest
            {
                OrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single OrchestrationCluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrchestrationClusterAsync(OrchestrationClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOrchestrationClusterAsync(new DeleteOrchestrationClusterRequest
            {
                OrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single OrchestrationCluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrchestrationClusterAsync(OrchestrationClusterName name, st::CancellationToken cancellationToken) =>
            DeleteOrchestrationClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists EdgeSlms in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EdgeSlm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEdgeSlmsResponse, EdgeSlm> ListEdgeSlms(ListEdgeSlmsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EdgeSlms in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EdgeSlm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEdgeSlmsResponse, EdgeSlm> ListEdgeSlmsAsync(ListEdgeSlmsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EdgeSlms in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEdgeSlmsRequest
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
        /// <returns>A pageable sequence of <see cref="EdgeSlm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEdgeSlmsResponse, EdgeSlm> ListEdgeSlms(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEdgeSlmsRequest request = new ListEdgeSlmsRequest
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
            return ListEdgeSlms(request, callSettings);
        }

        /// <summary>
        /// Lists EdgeSlms in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEdgeSlmsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="EdgeSlm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEdgeSlmsResponse, EdgeSlm> ListEdgeSlmsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEdgeSlmsRequest request = new ListEdgeSlmsRequest
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
            return ListEdgeSlmsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists EdgeSlms in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEdgeSlmsRequest
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
        /// <returns>A pageable sequence of <see cref="EdgeSlm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEdgeSlmsResponse, EdgeSlm> ListEdgeSlms(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEdgeSlmsRequest request = new ListEdgeSlmsRequest
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
            return ListEdgeSlms(request, callSettings);
        }

        /// <summary>
        /// Lists EdgeSlms in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEdgeSlmsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="EdgeSlm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEdgeSlmsResponse, EdgeSlm> ListEdgeSlmsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEdgeSlmsRequest request = new ListEdgeSlmsRequest
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
            return ListEdgeSlmsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single EdgeSlm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EdgeSlm GetEdgeSlm(GetEdgeSlmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single EdgeSlm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EdgeSlm> GetEdgeSlmAsync(GetEdgeSlmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single EdgeSlm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EdgeSlm> GetEdgeSlmAsync(GetEdgeSlmRequest request, st::CancellationToken cancellationToken) =>
            GetEdgeSlmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single EdgeSlm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EdgeSlm GetEdgeSlm(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEdgeSlm(new GetEdgeSlmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EdgeSlm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EdgeSlm> GetEdgeSlmAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEdgeSlmAsync(new GetEdgeSlmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EdgeSlm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EdgeSlm> GetEdgeSlmAsync(string name, st::CancellationToken cancellationToken) =>
            GetEdgeSlmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single EdgeSlm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EdgeSlm GetEdgeSlm(EdgeSlmName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEdgeSlm(new GetEdgeSlmRequest
            {
                EdgeSlmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EdgeSlm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EdgeSlm> GetEdgeSlmAsync(EdgeSlmName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEdgeSlmAsync(new GetEdgeSlmRequest
            {
                EdgeSlmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EdgeSlm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EdgeSlm> GetEdgeSlmAsync(EdgeSlmName name, st::CancellationToken cancellationToken) =>
            GetEdgeSlmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new EdgeSlm in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EdgeSlm, OperationMetadata> CreateEdgeSlm(CreateEdgeSlmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new EdgeSlm in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EdgeSlm, OperationMetadata>> CreateEdgeSlmAsync(CreateEdgeSlmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new EdgeSlm in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EdgeSlm, OperationMetadata>> CreateEdgeSlmAsync(CreateEdgeSlmRequest request, st::CancellationToken cancellationToken) =>
            CreateEdgeSlmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEdgeSlm</c>.</summary>
        public virtual lro::OperationsClient CreateEdgeSlmOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEdgeSlm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EdgeSlm, OperationMetadata> PollOnceCreateEdgeSlm(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EdgeSlm, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEdgeSlmOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEdgeSlm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EdgeSlm, OperationMetadata>> PollOnceCreateEdgeSlmAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EdgeSlm, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEdgeSlmOperationsClient, callSettings);

        /// <summary>
        /// Creates a new EdgeSlm in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="edgeSlm">
        /// Required. The resource being created
        /// </param>
        /// <param name="edgeSlmId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// edge_slm_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EdgeSlm, OperationMetadata> CreateEdgeSlm(string parent, EdgeSlm edgeSlm, string edgeSlmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEdgeSlm(new CreateEdgeSlmRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EdgeSlmId = gax::GaxPreconditions.CheckNotNullOrEmpty(edgeSlmId, nameof(edgeSlmId)),
                EdgeSlm = gax::GaxPreconditions.CheckNotNull(edgeSlm, nameof(edgeSlm)),
            }, callSettings);

        /// <summary>
        /// Creates a new EdgeSlm in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="edgeSlm">
        /// Required. The resource being created
        /// </param>
        /// <param name="edgeSlmId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// edge_slm_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EdgeSlm, OperationMetadata>> CreateEdgeSlmAsync(string parent, EdgeSlm edgeSlm, string edgeSlmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEdgeSlmAsync(new CreateEdgeSlmRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EdgeSlmId = gax::GaxPreconditions.CheckNotNullOrEmpty(edgeSlmId, nameof(edgeSlmId)),
                EdgeSlm = gax::GaxPreconditions.CheckNotNull(edgeSlm, nameof(edgeSlm)),
            }, callSettings);

        /// <summary>
        /// Creates a new EdgeSlm in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="edgeSlm">
        /// Required. The resource being created
        /// </param>
        /// <param name="edgeSlmId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// edge_slm_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EdgeSlm, OperationMetadata>> CreateEdgeSlmAsync(string parent, EdgeSlm edgeSlm, string edgeSlmId, st::CancellationToken cancellationToken) =>
            CreateEdgeSlmAsync(parent, edgeSlm, edgeSlmId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new EdgeSlm in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="edgeSlm">
        /// Required. The resource being created
        /// </param>
        /// <param name="edgeSlmId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// edge_slm_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EdgeSlm, OperationMetadata> CreateEdgeSlm(gagr::LocationName parent, EdgeSlm edgeSlm, string edgeSlmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEdgeSlm(new CreateEdgeSlmRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EdgeSlmId = gax::GaxPreconditions.CheckNotNullOrEmpty(edgeSlmId, nameof(edgeSlmId)),
                EdgeSlm = gax::GaxPreconditions.CheckNotNull(edgeSlm, nameof(edgeSlm)),
            }, callSettings);

        /// <summary>
        /// Creates a new EdgeSlm in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="edgeSlm">
        /// Required. The resource being created
        /// </param>
        /// <param name="edgeSlmId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// edge_slm_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EdgeSlm, OperationMetadata>> CreateEdgeSlmAsync(gagr::LocationName parent, EdgeSlm edgeSlm, string edgeSlmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEdgeSlmAsync(new CreateEdgeSlmRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EdgeSlmId = gax::GaxPreconditions.CheckNotNullOrEmpty(edgeSlmId, nameof(edgeSlmId)),
                EdgeSlm = gax::GaxPreconditions.CheckNotNull(edgeSlm, nameof(edgeSlm)),
            }, callSettings);

        /// <summary>
        /// Creates a new EdgeSlm in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="edgeSlm">
        /// Required. The resource being created
        /// </param>
        /// <param name="edgeSlmId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// edge_slm_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EdgeSlm, OperationMetadata>> CreateEdgeSlmAsync(gagr::LocationName parent, EdgeSlm edgeSlm, string edgeSlmId, st::CancellationToken cancellationToken) =>
            CreateEdgeSlmAsync(parent, edgeSlm, edgeSlmId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single EdgeSlm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEdgeSlm(DeleteEdgeSlmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single EdgeSlm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEdgeSlmAsync(DeleteEdgeSlmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single EdgeSlm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEdgeSlmAsync(DeleteEdgeSlmRequest request, st::CancellationToken cancellationToken) =>
            DeleteEdgeSlmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEdgeSlm</c>.</summary>
        public virtual lro::OperationsClient DeleteEdgeSlmOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEdgeSlm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteEdgeSlm(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEdgeSlmOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEdgeSlm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteEdgeSlmAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEdgeSlmOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single EdgeSlm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEdgeSlm(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEdgeSlm(new DeleteEdgeSlmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EdgeSlm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEdgeSlmAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEdgeSlmAsync(new DeleteEdgeSlmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EdgeSlm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEdgeSlmAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEdgeSlmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single EdgeSlm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEdgeSlm(EdgeSlmName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEdgeSlm(new DeleteEdgeSlmRequest
            {
                EdgeSlmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EdgeSlm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEdgeSlmAsync(EdgeSlmName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEdgeSlmAsync(new DeleteEdgeSlmRequest
            {
                EdgeSlmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EdgeSlm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEdgeSlmAsync(EdgeSlmName name, st::CancellationToken cancellationToken) =>
            DeleteEdgeSlmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint CreateBlueprint(CreateBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> CreateBlueprintAsync(CreateBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> CreateBlueprintAsync(CreateBlueprintRequest request, st::CancellationToken cancellationToken) =>
            CreateBlueprintAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a blueprint.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="blueprint">
        /// Required. The `Blueprint` to create.
        /// </param>
        /// <param name="blueprintId">
        /// Optional. The name of the blueprint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint CreateBlueprint(string parent, Blueprint blueprint, string blueprintId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBlueprint(new CreateBlueprintRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BlueprintId = blueprintId ?? "",
                Blueprint = gax::GaxPreconditions.CheckNotNull(blueprint, nameof(blueprint)),
            }, callSettings);

        /// <summary>
        /// Creates a blueprint.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="blueprint">
        /// Required. The `Blueprint` to create.
        /// </param>
        /// <param name="blueprintId">
        /// Optional. The name of the blueprint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> CreateBlueprintAsync(string parent, Blueprint blueprint, string blueprintId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBlueprintAsync(new CreateBlueprintRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BlueprintId = blueprintId ?? "",
                Blueprint = gax::GaxPreconditions.CheckNotNull(blueprint, nameof(blueprint)),
            }, callSettings);

        /// <summary>
        /// Creates a blueprint.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="blueprint">
        /// Required. The `Blueprint` to create.
        /// </param>
        /// <param name="blueprintId">
        /// Optional. The name of the blueprint.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> CreateBlueprintAsync(string parent, Blueprint blueprint, string blueprintId, st::CancellationToken cancellationToken) =>
            CreateBlueprintAsync(parent, blueprint, blueprintId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a blueprint.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="blueprint">
        /// Required. The `Blueprint` to create.
        /// </param>
        /// <param name="blueprintId">
        /// Optional. The name of the blueprint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint CreateBlueprint(OrchestrationClusterName parent, Blueprint blueprint, string blueprintId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBlueprint(new CreateBlueprintRequest
            {
                ParentAsOrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BlueprintId = blueprintId ?? "",
                Blueprint = gax::GaxPreconditions.CheckNotNull(blueprint, nameof(blueprint)),
            }, callSettings);

        /// <summary>
        /// Creates a blueprint.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="blueprint">
        /// Required. The `Blueprint` to create.
        /// </param>
        /// <param name="blueprintId">
        /// Optional. The name of the blueprint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> CreateBlueprintAsync(OrchestrationClusterName parent, Blueprint blueprint, string blueprintId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBlueprintAsync(new CreateBlueprintRequest
            {
                ParentAsOrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BlueprintId = blueprintId ?? "",
                Blueprint = gax::GaxPreconditions.CheckNotNull(blueprint, nameof(blueprint)),
            }, callSettings);

        /// <summary>
        /// Creates a blueprint.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="blueprint">
        /// Required. The `Blueprint` to create.
        /// </param>
        /// <param name="blueprintId">
        /// Optional. The name of the blueprint.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> CreateBlueprintAsync(OrchestrationClusterName parent, Blueprint blueprint, string blueprintId, st::CancellationToken cancellationToken) =>
            CreateBlueprintAsync(parent, blueprint, blueprintId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint UpdateBlueprint(UpdateBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> UpdateBlueprintAsync(UpdateBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> UpdateBlueprintAsync(UpdateBlueprintRequest request, st::CancellationToken cancellationToken) =>
            UpdateBlueprintAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a blueprint.
        /// </summary>
        /// <param name="blueprint">
        /// Required. The `blueprint` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Update mask is used to specify the fields to be overwritten in
        /// the `blueprint` resource by the update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint UpdateBlueprint(Blueprint blueprint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBlueprint(new UpdateBlueprintRequest
            {
                Blueprint = gax::GaxPreconditions.CheckNotNull(blueprint, nameof(blueprint)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a blueprint.
        /// </summary>
        /// <param name="blueprint">
        /// Required. The `blueprint` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Update mask is used to specify the fields to be overwritten in
        /// the `blueprint` resource by the update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> UpdateBlueprintAsync(Blueprint blueprint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBlueprintAsync(new UpdateBlueprintRequest
            {
                Blueprint = gax::GaxPreconditions.CheckNotNull(blueprint, nameof(blueprint)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a blueprint.
        /// </summary>
        /// <param name="blueprint">
        /// Required. The `blueprint` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Update mask is used to specify the fields to be overwritten in
        /// the `blueprint` resource by the update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> UpdateBlueprintAsync(Blueprint blueprint, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBlueprintAsync(blueprint, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint GetBlueprint(GetBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> GetBlueprintAsync(GetBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> GetBlueprintAsync(GetBlueprintRequest request, st::CancellationToken cancellationToken) =>
            GetBlueprintAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint.
        /// Case 1: If the name provided in the request is
        /// {blueprint_id}@{revision_id}, then the revision with revision_id will be
        /// returned. Case 2: If the name provided in the request is {blueprint}, then
        /// the current state of the blueprint is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint GetBlueprint(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBlueprint(new GetBlueprintRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint.
        /// Case 1: If the name provided in the request is
        /// {blueprint_id}@{revision_id}, then the revision with revision_id will be
        /// returned. Case 2: If the name provided in the request is {blueprint}, then
        /// the current state of the blueprint is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> GetBlueprintAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBlueprintAsync(new GetBlueprintRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint.
        /// Case 1: If the name provided in the request is
        /// {blueprint_id}@{revision_id}, then the revision with revision_id will be
        /// returned. Case 2: If the name provided in the request is {blueprint}, then
        /// the current state of the blueprint is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> GetBlueprintAsync(string name, st::CancellationToken cancellationToken) =>
            GetBlueprintAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint.
        /// Case 1: If the name provided in the request is
        /// {blueprint_id}@{revision_id}, then the revision with revision_id will be
        /// returned. Case 2: If the name provided in the request is {blueprint}, then
        /// the current state of the blueprint is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint GetBlueprint(BlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBlueprint(new GetBlueprintRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint.
        /// Case 1: If the name provided in the request is
        /// {blueprint_id}@{revision_id}, then the revision with revision_id will be
        /// returned. Case 2: If the name provided in the request is {blueprint}, then
        /// the current state of the blueprint is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> GetBlueprintAsync(BlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBlueprintAsync(new GetBlueprintRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint.
        /// Case 1: If the name provided in the request is
        /// {blueprint_id}@{revision_id}, then the revision with revision_id will be
        /// returned. Case 2: If the name provided in the request is {blueprint}, then
        /// the current state of the blueprint is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> GetBlueprintAsync(BlueprintName name, st::CancellationToken cancellationToken) =>
            GetBlueprintAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a blueprint and all its revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBlueprint(DeleteBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a blueprint and all its revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBlueprintAsync(DeleteBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a blueprint and all its revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBlueprintAsync(DeleteBlueprintRequest request, st::CancellationToken cancellationToken) =>
            DeleteBlueprintAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a blueprint and all its revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of blueprint to delete.
        /// Blueprint name should be in the format {blueprint_id}, if
        /// {blueprint_id}@{revision_id} is passed then the API throws invalid
        /// argument.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBlueprint(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBlueprint(new DeleteBlueprintRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a blueprint and all its revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of blueprint to delete.
        /// Blueprint name should be in the format {blueprint_id}, if
        /// {blueprint_id}@{revision_id} is passed then the API throws invalid
        /// argument.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBlueprintAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBlueprintAsync(new DeleteBlueprintRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a blueprint and all its revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of blueprint to delete.
        /// Blueprint name should be in the format {blueprint_id}, if
        /// {blueprint_id}@{revision_id} is passed then the API throws invalid
        /// argument.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBlueprintAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBlueprintAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a blueprint and all its revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of blueprint to delete.
        /// Blueprint name should be in the format {blueprint_id}, if
        /// {blueprint_id}@{revision_id} is passed then the API throws invalid
        /// argument.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBlueprint(BlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBlueprint(new DeleteBlueprintRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a blueprint and all its revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of blueprint to delete.
        /// Blueprint name should be in the format {blueprint_id}, if
        /// {blueprint_id}@{revision_id} is passed then the API throws invalid
        /// argument.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBlueprintAsync(BlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBlueprintAsync(new DeleteBlueprintRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a blueprint and all its revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of blueprint to delete.
        /// Blueprint name should be in the format {blueprint_id}, if
        /// {blueprint_id}@{revision_id} is passed then the API throws invalid
        /// argument.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBlueprintAsync(BlueprintName name, st::CancellationToken cancellationToken) =>
            DeleteBlueprintAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all blueprints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBlueprintsResponse, Blueprint> ListBlueprints(ListBlueprintsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all blueprints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBlueprintsResponse, Blueprint> ListBlueprintsAsync(ListBlueprintsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all blueprints.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
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
        /// <returns>A pageable sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBlueprintsResponse, Blueprint> ListBlueprints(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBlueprintsRequest request = new ListBlueprintsRequest
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
            return ListBlueprints(request, callSettings);
        }

        /// <summary>
        /// List all blueprints.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
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
        /// <returns>A pageable asynchronous sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBlueprintsResponse, Blueprint> ListBlueprintsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBlueprintsRequest request = new ListBlueprintsRequest
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
            return ListBlueprintsAsync(request, callSettings);
        }

        /// <summary>
        /// List all blueprints.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
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
        /// <returns>A pageable sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBlueprintsResponse, Blueprint> ListBlueprints(OrchestrationClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBlueprintsRequest request = new ListBlueprintsRequest
            {
                ParentAsOrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBlueprints(request, callSettings);
        }

        /// <summary>
        /// List all blueprints.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
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
        /// <returns>A pageable asynchronous sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBlueprintsResponse, Blueprint> ListBlueprintsAsync(OrchestrationClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBlueprintsRequest request = new ListBlueprintsRequest
            {
                ParentAsOrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBlueprintsAsync(request, callSettings);
        }

        /// <summary>
        /// Approves a blueprint and commits a new revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint ApproveBlueprint(ApproveBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a blueprint and commits a new revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> ApproveBlueprintAsync(ApproveBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a blueprint and commits a new revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> ApproveBlueprintAsync(ApproveBlueprintRequest request, st::CancellationToken cancellationToken) =>
            ApproveBlueprintAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a blueprint and commits a new revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint to approve. The blueprint must be in
        /// Proposed state. A new revision is committed on approval.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint ApproveBlueprint(string name, gaxgrpc::CallSettings callSettings = null) =>
            ApproveBlueprint(new ApproveBlueprintRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Approves a blueprint and commits a new revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint to approve. The blueprint must be in
        /// Proposed state. A new revision is committed on approval.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> ApproveBlueprintAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ApproveBlueprintAsync(new ApproveBlueprintRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Approves a blueprint and commits a new revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint to approve. The blueprint must be in
        /// Proposed state. A new revision is committed on approval.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> ApproveBlueprintAsync(string name, st::CancellationToken cancellationToken) =>
            ApproveBlueprintAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a blueprint and commits a new revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint to approve. The blueprint must be in
        /// Proposed state. A new revision is committed on approval.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint ApproveBlueprint(BlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            ApproveBlueprint(new ApproveBlueprintRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Approves a blueprint and commits a new revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint to approve. The blueprint must be in
        /// Proposed state. A new revision is committed on approval.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> ApproveBlueprintAsync(BlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            ApproveBlueprintAsync(new ApproveBlueprintRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Approves a blueprint and commits a new revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint to approve. The blueprint must be in
        /// Proposed state. A new revision is committed on approval.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> ApproveBlueprintAsync(BlueprintName name, st::CancellationToken cancellationToken) =>
            ApproveBlueprintAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Proposes a blueprint for approval of changes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint ProposeBlueprint(ProposeBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Proposes a blueprint for approval of changes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> ProposeBlueprintAsync(ProposeBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Proposes a blueprint for approval of changes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> ProposeBlueprintAsync(ProposeBlueprintRequest request, st::CancellationToken cancellationToken) =>
            ProposeBlueprintAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Proposes a blueprint for approval of changes.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint being proposed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint ProposeBlueprint(string name, gaxgrpc::CallSettings callSettings = null) =>
            ProposeBlueprint(new ProposeBlueprintRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Proposes a blueprint for approval of changes.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint being proposed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> ProposeBlueprintAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ProposeBlueprintAsync(new ProposeBlueprintRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Proposes a blueprint for approval of changes.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint being proposed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> ProposeBlueprintAsync(string name, st::CancellationToken cancellationToken) =>
            ProposeBlueprintAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Proposes a blueprint for approval of changes.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint being proposed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint ProposeBlueprint(BlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            ProposeBlueprint(new ProposeBlueprintRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Proposes a blueprint for approval of changes.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint being proposed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> ProposeBlueprintAsync(BlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            ProposeBlueprintAsync(new ProposeBlueprintRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Proposes a blueprint for approval of changes.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint being proposed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> ProposeBlueprintAsync(BlueprintName name, st::CancellationToken cancellationToken) =>
            ProposeBlueprintAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rejects a blueprint revision proposal and flips it back to Draft state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint RejectBlueprint(RejectBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rejects a blueprint revision proposal and flips it back to Draft state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> RejectBlueprintAsync(RejectBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rejects a blueprint revision proposal and flips it back to Draft state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> RejectBlueprintAsync(RejectBlueprintRequest request, st::CancellationToken cancellationToken) =>
            RejectBlueprintAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rejects a blueprint revision proposal and flips it back to Draft state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint being rejected.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint RejectBlueprint(string name, gaxgrpc::CallSettings callSettings = null) =>
            RejectBlueprint(new RejectBlueprintRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Rejects a blueprint revision proposal and flips it back to Draft state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint being rejected.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> RejectBlueprintAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RejectBlueprintAsync(new RejectBlueprintRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Rejects a blueprint revision proposal and flips it back to Draft state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint being rejected.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> RejectBlueprintAsync(string name, st::CancellationToken cancellationToken) =>
            RejectBlueprintAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rejects a blueprint revision proposal and flips it back to Draft state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint being rejected.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Blueprint RejectBlueprint(BlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            RejectBlueprint(new RejectBlueprintRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Rejects a blueprint revision proposal and flips it back to Draft state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint being rejected.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> RejectBlueprintAsync(BlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            RejectBlueprintAsync(new RejectBlueprintRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Rejects a blueprint revision proposal and flips it back to Draft state.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint being rejected.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Blueprint> RejectBlueprintAsync(BlueprintName name, st::CancellationToken cancellationToken) =>
            RejectBlueprintAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List blueprint revisions of a given blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBlueprintRevisionsResponse, Blueprint> ListBlueprintRevisions(ListBlueprintRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List blueprint revisions of a given blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBlueprintRevisionsResponse, Blueprint> ListBlueprintRevisionsAsync(ListBlueprintRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List blueprint revisions of a given blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint to list revisions for.
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
        /// <returns>A pageable sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBlueprintRevisionsResponse, Blueprint> ListBlueprintRevisions(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBlueprintRevisionsRequest request = new ListBlueprintRevisionsRequest
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
            return ListBlueprintRevisions(request, callSettings);
        }

        /// <summary>
        /// List blueprint revisions of a given blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint to list revisions for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBlueprintRevisionsResponse, Blueprint> ListBlueprintRevisionsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBlueprintRevisionsRequest request = new ListBlueprintRevisionsRequest
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
            return ListBlueprintRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// List blueprint revisions of a given blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint to list revisions for.
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
        /// <returns>A pageable sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBlueprintRevisionsResponse, Blueprint> ListBlueprintRevisions(BlueprintName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBlueprintRevisionsRequest request = new ListBlueprintRevisionsRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBlueprintRevisions(request, callSettings);
        }

        /// <summary>
        /// List blueprint revisions of a given blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint to list revisions for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBlueprintRevisionsResponse, Blueprint> ListBlueprintRevisionsAsync(BlueprintName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBlueprintRevisionsRequest request = new ListBlueprintRevisionsRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBlueprintRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Searches across blueprint revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchBlueprintRevisionsResponse, Blueprint> SearchBlueprintRevisions(SearchBlueprintRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches across blueprint revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchBlueprintRevisionsResponse, Blueprint> SearchBlueprintRevisionsAsync(SearchBlueprintRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches across blueprint revisions.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="query">
        /// Required. Supported queries:
        /// 1. ""                       : Lists all revisions across all blueprints.
        /// 2. "latest=true"            : Lists latest revisions across all blueprints.
        /// 3. "name={name}"            : Lists all revisions of blueprint with name
        /// {name}.
        /// 4. "name={name} latest=true": Lists latest revision of blueprint with name
        /// {name}
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
        /// <returns>A pageable sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchBlueprintRevisionsResponse, Blueprint> SearchBlueprintRevisions(string parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchBlueprintRevisionsRequest request = new SearchBlueprintRevisionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchBlueprintRevisions(request, callSettings);
        }

        /// <summary>
        /// Searches across blueprint revisions.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="query">
        /// Required. Supported queries:
        /// 1. ""                       : Lists all revisions across all blueprints.
        /// 2. "latest=true"            : Lists latest revisions across all blueprints.
        /// 3. "name={name}"            : Lists all revisions of blueprint with name
        /// {name}.
        /// 4. "name={name} latest=true": Lists latest revision of blueprint with name
        /// {name}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchBlueprintRevisionsResponse, Blueprint> SearchBlueprintRevisionsAsync(string parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchBlueprintRevisionsRequest request = new SearchBlueprintRevisionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchBlueprintRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Searches across blueprint revisions.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="query">
        /// Required. Supported queries:
        /// 1. ""                       : Lists all revisions across all blueprints.
        /// 2. "latest=true"            : Lists latest revisions across all blueprints.
        /// 3. "name={name}"            : Lists all revisions of blueprint with name
        /// {name}.
        /// 4. "name={name} latest=true": Lists latest revision of blueprint with name
        /// {name}
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
        /// <returns>A pageable sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchBlueprintRevisionsResponse, Blueprint> SearchBlueprintRevisions(OrchestrationClusterName parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchBlueprintRevisionsRequest request = new SearchBlueprintRevisionsRequest
            {
                ParentAsOrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchBlueprintRevisions(request, callSettings);
        }

        /// <summary>
        /// Searches across blueprint revisions.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="query">
        /// Required. Supported queries:
        /// 1. ""                       : Lists all revisions across all blueprints.
        /// 2. "latest=true"            : Lists latest revisions across all blueprints.
        /// 3. "name={name}"            : Lists all revisions of blueprint with name
        /// {name}.
        /// 4. "name={name} latest=true": Lists latest revision of blueprint with name
        /// {name}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Blueprint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchBlueprintRevisionsResponse, Blueprint> SearchBlueprintRevisionsAsync(OrchestrationClusterName parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchBlueprintRevisionsRequest request = new SearchBlueprintRevisionsRequest
            {
                ParentAsOrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchBlueprintRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Searches across deployment revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchDeploymentRevisionsResponse, Deployment> SearchDeploymentRevisions(SearchDeploymentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches across deployment revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchDeploymentRevisionsResponse, Deployment> SearchDeploymentRevisionsAsync(SearchDeploymentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches across deployment revisions.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="query">
        /// Required. Supported queries:
        /// 1. ""                       : Lists all revisions across all deployments.
        /// 2. "latest=true"            : Lists latest revisions across all
        /// deployments.
        /// 3. "name={name}"            : Lists all revisions of deployment with name
        /// {name}.
        /// 4. "name={name} latest=true": Lists latest revision of deployment with name
        /// {name}
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchDeploymentRevisionsResponse, Deployment> SearchDeploymentRevisions(string parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchDeploymentRevisionsRequest request = new SearchDeploymentRevisionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchDeploymentRevisions(request, callSettings);
        }

        /// <summary>
        /// Searches across deployment revisions.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="query">
        /// Required. Supported queries:
        /// 1. ""                       : Lists all revisions across all deployments.
        /// 2. "latest=true"            : Lists latest revisions across all
        /// deployments.
        /// 3. "name={name}"            : Lists all revisions of deployment with name
        /// {name}.
        /// 4. "name={name} latest=true": Lists latest revision of deployment with name
        /// {name}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchDeploymentRevisionsResponse, Deployment> SearchDeploymentRevisionsAsync(string parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchDeploymentRevisionsRequest request = new SearchDeploymentRevisionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchDeploymentRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Searches across deployment revisions.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="query">
        /// Required. Supported queries:
        /// 1. ""                       : Lists all revisions across all deployments.
        /// 2. "latest=true"            : Lists latest revisions across all
        /// deployments.
        /// 3. "name={name}"            : Lists all revisions of deployment with name
        /// {name}.
        /// 4. "name={name} latest=true": Lists latest revision of deployment with name
        /// {name}
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchDeploymentRevisionsResponse, Deployment> SearchDeploymentRevisions(OrchestrationClusterName parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchDeploymentRevisionsRequest request = new SearchDeploymentRevisionsRequest
            {
                ParentAsOrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchDeploymentRevisions(request, callSettings);
        }

        /// <summary>
        /// Searches across deployment revisions.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="query">
        /// Required. Supported queries:
        /// 1. ""                       : Lists all revisions across all deployments.
        /// 2. "latest=true"            : Lists latest revisions across all
        /// deployments.
        /// 3. "name={name}"            : Lists all revisions of deployment with name
        /// {name}.
        /// 4. "name={name} latest=true": Lists latest revision of deployment with name
        /// {name}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchDeploymentRevisionsResponse, Deployment> SearchDeploymentRevisionsAsync(OrchestrationClusterName parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchDeploymentRevisionsRequest request = new SearchDeploymentRevisionsRequest
            {
                ParentAsOrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchDeploymentRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Discards the changes in a blueprint and reverts the blueprint to the last
        /// approved blueprint revision. No changes take place if a blueprint does not
        /// have revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscardBlueprintChangesResponse DiscardBlueprintChanges(DiscardBlueprintChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Discards the changes in a blueprint and reverts the blueprint to the last
        /// approved blueprint revision. No changes take place if a blueprint does not
        /// have revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscardBlueprintChangesResponse> DiscardBlueprintChangesAsync(DiscardBlueprintChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Discards the changes in a blueprint and reverts the blueprint to the last
        /// approved blueprint revision. No changes take place if a blueprint does not
        /// have revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscardBlueprintChangesResponse> DiscardBlueprintChangesAsync(DiscardBlueprintChangesRequest request, st::CancellationToken cancellationToken) =>
            DiscardBlueprintChangesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Discards the changes in a blueprint and reverts the blueprint to the last
        /// approved blueprint revision. No changes take place if a blueprint does not
        /// have revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint of which changes are being discarded.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscardBlueprintChangesResponse DiscardBlueprintChanges(string name, gaxgrpc::CallSettings callSettings = null) =>
            DiscardBlueprintChanges(new DiscardBlueprintChangesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Discards the changes in a blueprint and reverts the blueprint to the last
        /// approved blueprint revision. No changes take place if a blueprint does not
        /// have revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint of which changes are being discarded.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscardBlueprintChangesResponse> DiscardBlueprintChangesAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DiscardBlueprintChangesAsync(new DiscardBlueprintChangesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Discards the changes in a blueprint and reverts the blueprint to the last
        /// approved blueprint revision. No changes take place if a blueprint does not
        /// have revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint of which changes are being discarded.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscardBlueprintChangesResponse> DiscardBlueprintChangesAsync(string name, st::CancellationToken cancellationToken) =>
            DiscardBlueprintChangesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Discards the changes in a blueprint and reverts the blueprint to the last
        /// approved blueprint revision. No changes take place if a blueprint does not
        /// have revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint of which changes are being discarded.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscardBlueprintChangesResponse DiscardBlueprintChanges(BlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            DiscardBlueprintChanges(new DiscardBlueprintChangesRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Discards the changes in a blueprint and reverts the blueprint to the last
        /// approved blueprint revision. No changes take place if a blueprint does not
        /// have revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint of which changes are being discarded.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscardBlueprintChangesResponse> DiscardBlueprintChangesAsync(BlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            DiscardBlueprintChangesAsync(new DiscardBlueprintChangesRequest
            {
                BlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Discards the changes in a blueprint and reverts the blueprint to the last
        /// approved blueprint revision. No changes take place if a blueprint does not
        /// have revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blueprint of which changes are being discarded.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscardBlueprintChangesResponse> DiscardBlueprintChangesAsync(BlueprintName name, st::CancellationToken cancellationToken) =>
            DiscardBlueprintChangesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the blueprints in TNA's public catalog. Default page size = 20,
        /// Max Page Size = 100.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PublicBlueprint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> ListPublicBlueprints(ListPublicBlueprintsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the blueprints in TNA's public catalog. Default page size = 20,
        /// Max Page Size = 100.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PublicBlueprint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> ListPublicBlueprintsAsync(ListPublicBlueprintsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the blueprints in TNA's public catalog. Default page size = 20,
        /// Max Page Size = 100.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of public blueprint.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}".
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
        /// <returns>A pageable sequence of <see cref="PublicBlueprint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> ListPublicBlueprints(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublicBlueprintsRequest request = new ListPublicBlueprintsRequest
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
            return ListPublicBlueprints(request, callSettings);
        }

        /// <summary>
        /// Lists the blueprints in TNA's public catalog. Default page size = 20,
        /// Max Page Size = 100.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of public blueprint.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}".
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
        /// <returns>A pageable asynchronous sequence of <see cref="PublicBlueprint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> ListPublicBlueprintsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublicBlueprintsRequest request = new ListPublicBlueprintsRequest
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
            return ListPublicBlueprintsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the blueprints in TNA's public catalog. Default page size = 20,
        /// Max Page Size = 100.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of public blueprint.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}".
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
        /// <returns>A pageable sequence of <see cref="PublicBlueprint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> ListPublicBlueprints(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublicBlueprintsRequest request = new ListPublicBlueprintsRequest
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
            return ListPublicBlueprints(request, callSettings);
        }

        /// <summary>
        /// Lists the blueprints in TNA's public catalog. Default page size = 20,
        /// Max Page Size = 100.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of public blueprint.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}".
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
        /// <returns>A pageable asynchronous sequence of <see cref="PublicBlueprint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> ListPublicBlueprintsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublicBlueprintsRequest request = new ListPublicBlueprintsRequest
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
            return ListPublicBlueprintsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested public blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicBlueprint GetPublicBlueprint(GetPublicBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested public blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicBlueprint> GetPublicBlueprintAsync(GetPublicBlueprintRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested public blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicBlueprint> GetPublicBlueprintAsync(GetPublicBlueprintRequest request, st::CancellationToken cancellationToken) =>
            GetPublicBlueprintAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested public blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the public blueprint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicBlueprint GetPublicBlueprint(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublicBlueprint(new GetPublicBlueprintRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested public blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the public blueprint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicBlueprint> GetPublicBlueprintAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublicBlueprintAsync(new GetPublicBlueprintRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested public blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the public blueprint.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicBlueprint> GetPublicBlueprintAsync(string name, st::CancellationToken cancellationToken) =>
            GetPublicBlueprintAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested public blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the public blueprint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicBlueprint GetPublicBlueprint(PublicBlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublicBlueprint(new GetPublicBlueprintRequest
            {
                PublicBlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested public blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the public blueprint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicBlueprint> GetPublicBlueprintAsync(PublicBlueprintName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublicBlueprintAsync(new GetPublicBlueprintRequest
            {
                PublicBlueprintName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested public blueprint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the public blueprint.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicBlueprint> GetPublicBlueprintAsync(PublicBlueprintName name, st::CancellationToken cancellationToken) =>
            GetPublicBlueprintAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(CreateDeploymentRequest request, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="deployment">
        /// Required. The `Deployment` to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The name of the deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(string parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployment(new CreateDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeploymentId = deploymentId ?? "",
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="deployment">
        /// Required. The `Deployment` to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The name of the deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(string parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentAsync(new CreateDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeploymentId = deploymentId ?? "",
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="deployment">
        /// Required. The `Deployment` to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The name of the deployment.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(string parent, Deployment deployment, string deploymentId, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(parent, deployment, deploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="deployment">
        /// Required. The `Deployment` to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The name of the deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(OrchestrationClusterName parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployment(new CreateDeploymentRequest
            {
                ParentAsOrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeploymentId = deploymentId ?? "",
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="deployment">
        /// Required. The `Deployment` to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The name of the deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(OrchestrationClusterName parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentAsync(new CreateDeploymentRequest
            {
                ParentAsOrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeploymentId = deploymentId ?? "",
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
        /// </param>
        /// <param name="deployment">
        /// Required. The `Deployment` to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The name of the deployment.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(OrchestrationClusterName parent, Deployment deployment, string deploymentId, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(parent, deployment, deploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment UpdateDeployment(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> UpdateDeploymentAsync(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> UpdateDeploymentAsync(UpdateDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UpdateDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a deployment.
        /// </summary>
        /// <param name="deployment">
        /// Required. The `deployment` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Update mask is used to specify the fields to be overwritten in
        /// the `deployment` resource by the update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment UpdateDeployment(Deployment deployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeployment(new UpdateDeploymentRequest
            {
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a deployment.
        /// </summary>
        /// <param name="deployment">
        /// Required. The `deployment` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Update mask is used to specify the fields to be overwritten in
        /// the `deployment` resource by the update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> UpdateDeploymentAsync(Deployment deployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeploymentAsync(new UpdateDeploymentRequest
            {
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a deployment.
        /// </summary>
        /// <param name="deployment">
        /// Required. The `deployment` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Update mask is used to specify the fields to be overwritten in
        /// the `deployment` resource by the update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> UpdateDeploymentAsync(Deployment deployment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDeploymentAsync(deployment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment.
        /// Case 1: If the name provided in the request is
        /// {deployment_id}@{revision_id}, then the revision with revision_id will be
        /// returned.
        /// Case 2: If the name provided in the request is {deployment}, then
        /// the current state of the deployment is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployment(new GetDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment.
        /// Case 1: If the name provided in the request is
        /// {deployment_id}@{revision_id}, then the revision with revision_id will be
        /// returned.
        /// Case 2: If the name provided in the request is {deployment}, then
        /// the current state of the deployment is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentAsync(new GetDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment.
        /// Case 1: If the name provided in the request is
        /// {deployment_id}@{revision_id}, then the revision with revision_id will be
        /// returned.
        /// Case 2: If the name provided in the request is {deployment}, then
        /// the current state of the deployment is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment.
        /// Case 1: If the name provided in the request is
        /// {deployment_id}@{revision_id}, then the revision with revision_id will be
        /// returned.
        /// Case 2: If the name provided in the request is {deployment}, then
        /// the current state of the deployment is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployment(new GetDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment.
        /// Case 1: If the name provided in the request is
        /// {deployment_id}@{revision_id}, then the revision with revision_id will be
        /// returned.
        /// Case 2: If the name provided in the request is {deployment}, then
        /// the current state of the deployment is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentAsync(new GetDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment.
        /// Case 1: If the name provided in the request is
        /// {deployment_id}@{revision_id}, then the revision with revision_id will be
        /// returned.
        /// Case 2: If the name provided in the request is {deployment}, then
        /// the current state of the deployment is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes the deployment by marking it as DELETING. Post which deployment and
        /// it's revisions gets deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void RemoveDeployment(RemoveDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes the deployment by marking it as DELETING. Post which deployment and
        /// it's revisions gets deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveDeploymentAsync(RemoveDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes the deployment by marking it as DELETING. Post which deployment and
        /// it's revisions gets deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveDeploymentAsync(RemoveDeploymentRequest request, st::CancellationToken cancellationToken) =>
            RemoveDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes the deployment by marking it as DELETING. Post which deployment and
        /// it's revisions gets deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of deployment to initiate delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void RemoveDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            RemoveDeployment(new RemoveDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes the deployment by marking it as DELETING. Post which deployment and
        /// it's revisions gets deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of deployment to initiate delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RemoveDeploymentAsync(new RemoveDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes the deployment by marking it as DELETING. Post which deployment and
        /// it's revisions gets deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of deployment to initiate delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            RemoveDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes the deployment by marking it as DELETING. Post which deployment and
        /// it's revisions gets deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of deployment to initiate delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void RemoveDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            RemoveDeployment(new RemoveDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes the deployment by marking it as DELETING. Post which deployment and
        /// it's revisions gets deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of deployment to initiate delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            RemoveDeploymentAsync(new RemoveDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes the deployment by marking it as DELETING. Post which deployment and
        /// it's revisions gets deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of deployment to initiate delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            RemoveDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all deployments.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeployments(request, callSettings);
        }

        /// <summary>
        /// List all deployments.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// List all deployments.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(OrchestrationClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsOrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeployments(request, callSettings);
        }

        /// <summary>
        /// List all deployments.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of parent orchestration cluster resource.
        /// Format should be -
        /// "projects/{project_id}/locations/{location_name}/orchestrationClusters/{orchestration_cluster}".
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(OrchestrationClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsOrchestrationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// List deployment revisions of a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentRevisionsResponse, Deployment> ListDeploymentRevisions(ListDeploymentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List deployment revisions of a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentRevisionsResponse, Deployment> ListDeploymentRevisionsAsync(ListDeploymentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List deployment revisions of a given deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to list revisions for.
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentRevisionsResponse, Deployment> ListDeploymentRevisions(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentRevisionsRequest request = new ListDeploymentRevisionsRequest
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
            return ListDeploymentRevisions(request, callSettings);
        }

        /// <summary>
        /// List deployment revisions of a given deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to list revisions for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentRevisionsResponse, Deployment> ListDeploymentRevisionsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentRevisionsRequest request = new ListDeploymentRevisionsRequest
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
            return ListDeploymentRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// List deployment revisions of a given deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to list revisions for.
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentRevisionsResponse, Deployment> ListDeploymentRevisions(DeploymentName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentRevisionsRequest request = new ListDeploymentRevisionsRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeploymentRevisions(request, callSettings);
        }

        /// <summary>
        /// List deployment revisions of a given deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to list revisions for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentRevisionsResponse, Deployment> ListDeploymentRevisionsAsync(DeploymentName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentRevisionsRequest request = new ListDeploymentRevisionsRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeploymentRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Discards the changes in a deployment and reverts the deployment to the last
        /// approved deployment revision. No changes take place if a deployment does
        /// not have revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscardDeploymentChangesResponse DiscardDeploymentChanges(DiscardDeploymentChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Discards the changes in a deployment and reverts the deployment to the last
        /// approved deployment revision. No changes take place if a deployment does
        /// not have revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscardDeploymentChangesResponse> DiscardDeploymentChangesAsync(DiscardDeploymentChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Discards the changes in a deployment and reverts the deployment to the last
        /// approved deployment revision. No changes take place if a deployment does
        /// not have revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscardDeploymentChangesResponse> DiscardDeploymentChangesAsync(DiscardDeploymentChangesRequest request, st::CancellationToken cancellationToken) =>
            DiscardDeploymentChangesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Discards the changes in a deployment and reverts the deployment to the last
        /// approved deployment revision. No changes take place if a deployment does
        /// not have revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment of which changes are being discarded.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscardDeploymentChangesResponse DiscardDeploymentChanges(string name, gaxgrpc::CallSettings callSettings = null) =>
            DiscardDeploymentChanges(new DiscardDeploymentChangesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Discards the changes in a deployment and reverts the deployment to the last
        /// approved deployment revision. No changes take place if a deployment does
        /// not have revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment of which changes are being discarded.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscardDeploymentChangesResponse> DiscardDeploymentChangesAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DiscardDeploymentChangesAsync(new DiscardDeploymentChangesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Discards the changes in a deployment and reverts the deployment to the last
        /// approved deployment revision. No changes take place if a deployment does
        /// not have revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment of which changes are being discarded.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscardDeploymentChangesResponse> DiscardDeploymentChangesAsync(string name, st::CancellationToken cancellationToken) =>
            DiscardDeploymentChangesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Discards the changes in a deployment and reverts the deployment to the last
        /// approved deployment revision. No changes take place if a deployment does
        /// not have revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment of which changes are being discarded.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscardDeploymentChangesResponse DiscardDeploymentChanges(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DiscardDeploymentChanges(new DiscardDeploymentChangesRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Discards the changes in a deployment and reverts the deployment to the last
        /// approved deployment revision. No changes take place if a deployment does
        /// not have revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment of which changes are being discarded.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscardDeploymentChangesResponse> DiscardDeploymentChangesAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DiscardDeploymentChangesAsync(new DiscardDeploymentChangesRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Discards the changes in a deployment and reverts the deployment to the last
        /// approved deployment revision. No changes take place if a deployment does
        /// not have revisions.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment of which changes are being discarded.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscardDeploymentChangesResponse> DiscardDeploymentChangesAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            DiscardDeploymentChangesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Applies the deployment's YAML files to the parent orchestration cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment ApplyDeployment(ApplyDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies the deployment's YAML files to the parent orchestration cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> ApplyDeploymentAsync(ApplyDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies the deployment's YAML files to the parent orchestration cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> ApplyDeploymentAsync(ApplyDeploymentRequest request, st::CancellationToken cancellationToken) =>
            ApplyDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Applies the deployment's YAML files to the parent orchestration cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to apply to orchestration cluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment ApplyDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            ApplyDeployment(new ApplyDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Applies the deployment's YAML files to the parent orchestration cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to apply to orchestration cluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> ApplyDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ApplyDeploymentAsync(new ApplyDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Applies the deployment's YAML files to the parent orchestration cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to apply to orchestration cluster.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> ApplyDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            ApplyDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Applies the deployment's YAML files to the parent orchestration cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to apply to orchestration cluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment ApplyDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            ApplyDeployment(new ApplyDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Applies the deployment's YAML files to the parent orchestration cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to apply to orchestration cluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> ApplyDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            ApplyDeploymentAsync(new ApplyDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Applies the deployment's YAML files to the parent orchestration cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to apply to orchestration cluster.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> ApplyDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            ApplyDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested deployment status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeDeploymentStatusResponse ComputeDeploymentStatus(ComputeDeploymentStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested deployment status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeDeploymentStatusResponse> ComputeDeploymentStatusAsync(ComputeDeploymentStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested deployment status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeDeploymentStatusResponse> ComputeDeploymentStatusAsync(ComputeDeploymentStatusRequest request, st::CancellationToken cancellationToken) =>
            ComputeDeploymentStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested deployment status.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment without revisionID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeDeploymentStatusResponse ComputeDeploymentStatus(string name, gaxgrpc::CallSettings callSettings = null) =>
            ComputeDeploymentStatus(new ComputeDeploymentStatusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested deployment status.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment without revisionID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeDeploymentStatusResponse> ComputeDeploymentStatusAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ComputeDeploymentStatusAsync(new ComputeDeploymentStatusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested deployment status.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment without revisionID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeDeploymentStatusResponse> ComputeDeploymentStatusAsync(string name, st::CancellationToken cancellationToken) =>
            ComputeDeploymentStatusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested deployment status.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment without revisionID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeDeploymentStatusResponse ComputeDeploymentStatus(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            ComputeDeploymentStatus(new ComputeDeploymentStatusRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested deployment status.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment without revisionID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeDeploymentStatusResponse> ComputeDeploymentStatusAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            ComputeDeploymentStatusAsync(new ComputeDeploymentStatusRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested deployment status.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment without revisionID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeDeploymentStatusResponse> ComputeDeploymentStatusAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            ComputeDeploymentStatusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rollback the active deployment to the given past approved deployment
        /// revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment RollbackDeployment(RollbackDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rollback the active deployment to the given past approved deployment
        /// revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> RollbackDeploymentAsync(RollbackDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rollback the active deployment to the given past approved deployment
        /// revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> RollbackDeploymentAsync(RollbackDeploymentRequest request, st::CancellationToken cancellationToken) =>
            RollbackDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rollback the active deployment to the given past approved deployment
        /// revision.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the deployment.
        /// </param>
        /// <param name="revisionId">
        /// Required. The revision id of deployment to roll back to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment RollbackDeployment(string name, string revisionId, gaxgrpc::CallSettings callSettings = null) =>
            RollbackDeployment(new RollbackDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RevisionId = gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)),
            }, callSettings);

        /// <summary>
        /// Rollback the active deployment to the given past approved deployment
        /// revision.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the deployment.
        /// </param>
        /// <param name="revisionId">
        /// Required. The revision id of deployment to roll back to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> RollbackDeploymentAsync(string name, string revisionId, gaxgrpc::CallSettings callSettings = null) =>
            RollbackDeploymentAsync(new RollbackDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RevisionId = gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)),
            }, callSettings);

        /// <summary>
        /// Rollback the active deployment to the given past approved deployment
        /// revision.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the deployment.
        /// </param>
        /// <param name="revisionId">
        /// Required. The revision id of deployment to roll back to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> RollbackDeploymentAsync(string name, string revisionId, st::CancellationToken cancellationToken) =>
            RollbackDeploymentAsync(name, revisionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rollback the active deployment to the given past approved deployment
        /// revision.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the deployment.
        /// </param>
        /// <param name="revisionId">
        /// Required. The revision id of deployment to roll back to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment RollbackDeployment(DeploymentName name, string revisionId, gaxgrpc::CallSettings callSettings = null) =>
            RollbackDeployment(new RollbackDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RevisionId = gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)),
            }, callSettings);

        /// <summary>
        /// Rollback the active deployment to the given past approved deployment
        /// revision.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the deployment.
        /// </param>
        /// <param name="revisionId">
        /// Required. The revision id of deployment to roll back to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> RollbackDeploymentAsync(DeploymentName name, string revisionId, gaxgrpc::CallSettings callSettings = null) =>
            RollbackDeploymentAsync(new RollbackDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RevisionId = gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)),
            }, callSettings);

        /// <summary>
        /// Rollback the active deployment to the given past approved deployment
        /// revision.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the deployment.
        /// </param>
        /// <param name="revisionId">
        /// Required. The revision id of deployment to roll back to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> RollbackDeploymentAsync(DeploymentName name, string revisionId, st::CancellationToken cancellationToken) =>
            RollbackDeploymentAsync(name, revisionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested hydrated deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HydratedDeployment GetHydratedDeployment(GetHydratedDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested hydrated deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> GetHydratedDeploymentAsync(GetHydratedDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested hydrated deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> GetHydratedDeploymentAsync(GetHydratedDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetHydratedDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested hydrated deployment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hydrated deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HydratedDeployment GetHydratedDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHydratedDeployment(new GetHydratedDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested hydrated deployment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hydrated deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> GetHydratedDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHydratedDeploymentAsync(new GetHydratedDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested hydrated deployment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hydrated deployment.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> GetHydratedDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetHydratedDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested hydrated deployment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hydrated deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HydratedDeployment GetHydratedDeployment(HydratedDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHydratedDeployment(new GetHydratedDeploymentRequest
            {
                HydratedDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested hydrated deployment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hydrated deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> GetHydratedDeploymentAsync(HydratedDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHydratedDeploymentAsync(new GetHydratedDeploymentRequest
            {
                HydratedDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested hydrated deployment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the hydrated deployment.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> GetHydratedDeploymentAsync(HydratedDeploymentName name, st::CancellationToken cancellationToken) =>
            GetHydratedDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all hydrated deployments present under a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HydratedDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> ListHydratedDeployments(ListHydratedDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all hydrated deployments present under a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HydratedDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> ListHydratedDeploymentsAsync(ListHydratedDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all hydrated deployments present under a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The deployment managing the hydrated deployments.
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
        /// <returns>A pageable sequence of <see cref="HydratedDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> ListHydratedDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHydratedDeploymentsRequest request = new ListHydratedDeploymentsRequest
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
            return ListHydratedDeployments(request, callSettings);
        }

        /// <summary>
        /// List all hydrated deployments present under a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The deployment managing the hydrated deployments.
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
        /// <returns>A pageable asynchronous sequence of <see cref="HydratedDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> ListHydratedDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHydratedDeploymentsRequest request = new ListHydratedDeploymentsRequest
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
            return ListHydratedDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// List all hydrated deployments present under a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The deployment managing the hydrated deployments.
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
        /// <returns>A pageable sequence of <see cref="HydratedDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> ListHydratedDeployments(DeploymentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHydratedDeploymentsRequest request = new ListHydratedDeploymentsRequest
            {
                ParentAsDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListHydratedDeployments(request, callSettings);
        }

        /// <summary>
        /// List all hydrated deployments present under a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The deployment managing the hydrated deployments.
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
        /// <returns>A pageable asynchronous sequence of <see cref="HydratedDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> ListHydratedDeploymentsAsync(DeploymentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHydratedDeploymentsRequest request = new ListHydratedDeploymentsRequest
            {
                ParentAsDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListHydratedDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a hydrated deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HydratedDeployment UpdateHydratedDeployment(UpdateHydratedDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a hydrated deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> UpdateHydratedDeploymentAsync(UpdateHydratedDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a hydrated deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> UpdateHydratedDeploymentAsync(UpdateHydratedDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UpdateHydratedDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a hydrated deployment.
        /// </summary>
        /// <param name="hydratedDeployment">
        /// Required. The hydrated deployment to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Update mask supports a special
        /// value `*` which fully replaces (equivalent to PUT) the resource provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HydratedDeployment UpdateHydratedDeployment(HydratedDeployment hydratedDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHydratedDeployment(new UpdateHydratedDeploymentRequest
            {
                HydratedDeployment = gax::GaxPreconditions.CheckNotNull(hydratedDeployment, nameof(hydratedDeployment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a hydrated deployment.
        /// </summary>
        /// <param name="hydratedDeployment">
        /// Required. The hydrated deployment to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Update mask supports a special
        /// value `*` which fully replaces (equivalent to PUT) the resource provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> UpdateHydratedDeploymentAsync(HydratedDeployment hydratedDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHydratedDeploymentAsync(new UpdateHydratedDeploymentRequest
            {
                HydratedDeployment = gax::GaxPreconditions.CheckNotNull(hydratedDeployment, nameof(hydratedDeployment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a hydrated deployment.
        /// </summary>
        /// <param name="hydratedDeployment">
        /// Required. The hydrated deployment to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Update mask supports a special
        /// value `*` which fully replaces (equivalent to PUT) the resource provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> UpdateHydratedDeploymentAsync(HydratedDeployment hydratedDeployment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateHydratedDeploymentAsync(hydratedDeployment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Applies a hydrated deployment to a workload cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HydratedDeployment ApplyHydratedDeployment(ApplyHydratedDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies a hydrated deployment to a workload cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> ApplyHydratedDeploymentAsync(ApplyHydratedDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies a hydrated deployment to a workload cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> ApplyHydratedDeploymentAsync(ApplyHydratedDeploymentRequest request, st::CancellationToken cancellationToken) =>
            ApplyHydratedDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Applies a hydrated deployment to a workload cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hydrated deployment to apply.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HydratedDeployment ApplyHydratedDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            ApplyHydratedDeployment(new ApplyHydratedDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Applies a hydrated deployment to a workload cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hydrated deployment to apply.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> ApplyHydratedDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ApplyHydratedDeploymentAsync(new ApplyHydratedDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Applies a hydrated deployment to a workload cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hydrated deployment to apply.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> ApplyHydratedDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            ApplyHydratedDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Applies a hydrated deployment to a workload cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hydrated deployment to apply.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HydratedDeployment ApplyHydratedDeployment(HydratedDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            ApplyHydratedDeployment(new ApplyHydratedDeploymentRequest
            {
                HydratedDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Applies a hydrated deployment to a workload cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hydrated deployment to apply.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> ApplyHydratedDeploymentAsync(HydratedDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            ApplyHydratedDeploymentAsync(new ApplyHydratedDeploymentRequest
            {
                HydratedDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Applies a hydrated deployment to a workload cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the hydrated deployment to apply.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HydratedDeployment> ApplyHydratedDeploymentAsync(HydratedDeploymentName name, st::CancellationToken cancellationToken) =>
            ApplyHydratedDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TelcoAutomation client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// TelcoAutomation Service manages the control plane cluster a.k.a.
    /// Orchestration Cluster (GKE cluster with config controller) of TNA. It also
    /// exposes blueprint APIs which manages the lifecycle of blueprints that control
    /// the infrastructure setup (e.g GDCE clusters) and deployment of network
    /// functions.
    /// </remarks>
    public sealed partial class TelcoAutomationClientImpl : TelcoAutomationClient
    {
        private readonly gaxgrpc::ApiCall<ListOrchestrationClustersRequest, ListOrchestrationClustersResponse> _callListOrchestrationClusters;

        private readonly gaxgrpc::ApiCall<GetOrchestrationClusterRequest, OrchestrationCluster> _callGetOrchestrationCluster;

        private readonly gaxgrpc::ApiCall<CreateOrchestrationClusterRequest, lro::Operation> _callCreateOrchestrationCluster;

        private readonly gaxgrpc::ApiCall<DeleteOrchestrationClusterRequest, lro::Operation> _callDeleteOrchestrationCluster;

        private readonly gaxgrpc::ApiCall<ListEdgeSlmsRequest, ListEdgeSlmsResponse> _callListEdgeSlms;

        private readonly gaxgrpc::ApiCall<GetEdgeSlmRequest, EdgeSlm> _callGetEdgeSlm;

        private readonly gaxgrpc::ApiCall<CreateEdgeSlmRequest, lro::Operation> _callCreateEdgeSlm;

        private readonly gaxgrpc::ApiCall<DeleteEdgeSlmRequest, lro::Operation> _callDeleteEdgeSlm;

        private readonly gaxgrpc::ApiCall<CreateBlueprintRequest, Blueprint> _callCreateBlueprint;

        private readonly gaxgrpc::ApiCall<UpdateBlueprintRequest, Blueprint> _callUpdateBlueprint;

        private readonly gaxgrpc::ApiCall<GetBlueprintRequest, Blueprint> _callGetBlueprint;

        private readonly gaxgrpc::ApiCall<DeleteBlueprintRequest, wkt::Empty> _callDeleteBlueprint;

        private readonly gaxgrpc::ApiCall<ListBlueprintsRequest, ListBlueprintsResponse> _callListBlueprints;

        private readonly gaxgrpc::ApiCall<ApproveBlueprintRequest, Blueprint> _callApproveBlueprint;

        private readonly gaxgrpc::ApiCall<ProposeBlueprintRequest, Blueprint> _callProposeBlueprint;

        private readonly gaxgrpc::ApiCall<RejectBlueprintRequest, Blueprint> _callRejectBlueprint;

        private readonly gaxgrpc::ApiCall<ListBlueprintRevisionsRequest, ListBlueprintRevisionsResponse> _callListBlueprintRevisions;

        private readonly gaxgrpc::ApiCall<SearchBlueprintRevisionsRequest, SearchBlueprintRevisionsResponse> _callSearchBlueprintRevisions;

        private readonly gaxgrpc::ApiCall<SearchDeploymentRevisionsRequest, SearchDeploymentRevisionsResponse> _callSearchDeploymentRevisions;

        private readonly gaxgrpc::ApiCall<DiscardBlueprintChangesRequest, DiscardBlueprintChangesResponse> _callDiscardBlueprintChanges;

        private readonly gaxgrpc::ApiCall<ListPublicBlueprintsRequest, ListPublicBlueprintsResponse> _callListPublicBlueprints;

        private readonly gaxgrpc::ApiCall<GetPublicBlueprintRequest, PublicBlueprint> _callGetPublicBlueprint;

        private readonly gaxgrpc::ApiCall<CreateDeploymentRequest, Deployment> _callCreateDeployment;

        private readonly gaxgrpc::ApiCall<UpdateDeploymentRequest, Deployment> _callUpdateDeployment;

        private readonly gaxgrpc::ApiCall<GetDeploymentRequest, Deployment> _callGetDeployment;

        private readonly gaxgrpc::ApiCall<RemoveDeploymentRequest, wkt::Empty> _callRemoveDeployment;

        private readonly gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> _callListDeployments;

        private readonly gaxgrpc::ApiCall<ListDeploymentRevisionsRequest, ListDeploymentRevisionsResponse> _callListDeploymentRevisions;

        private readonly gaxgrpc::ApiCall<DiscardDeploymentChangesRequest, DiscardDeploymentChangesResponse> _callDiscardDeploymentChanges;

        private readonly gaxgrpc::ApiCall<ApplyDeploymentRequest, Deployment> _callApplyDeployment;

        private readonly gaxgrpc::ApiCall<ComputeDeploymentStatusRequest, ComputeDeploymentStatusResponse> _callComputeDeploymentStatus;

        private readonly gaxgrpc::ApiCall<RollbackDeploymentRequest, Deployment> _callRollbackDeployment;

        private readonly gaxgrpc::ApiCall<GetHydratedDeploymentRequest, HydratedDeployment> _callGetHydratedDeployment;

        private readonly gaxgrpc::ApiCall<ListHydratedDeploymentsRequest, ListHydratedDeploymentsResponse> _callListHydratedDeployments;

        private readonly gaxgrpc::ApiCall<UpdateHydratedDeploymentRequest, HydratedDeployment> _callUpdateHydratedDeployment;

        private readonly gaxgrpc::ApiCall<ApplyHydratedDeploymentRequest, HydratedDeployment> _callApplyHydratedDeployment;

        /// <summary>
        /// Constructs a client wrapper for the TelcoAutomation service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TelcoAutomationSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TelcoAutomationClientImpl(TelcoAutomation.TelcoAutomationClient grpcClient, TelcoAutomationSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TelcoAutomationSettings effectiveSettings = settings ?? TelcoAutomationSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateOrchestrationClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateOrchestrationClusterOperationsSettings, logger);
            DeleteOrchestrationClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteOrchestrationClusterOperationsSettings, logger);
            CreateEdgeSlmOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEdgeSlmOperationsSettings, logger);
            DeleteEdgeSlmOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEdgeSlmOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListOrchestrationClusters = clientHelper.BuildApiCall<ListOrchestrationClustersRequest, ListOrchestrationClustersResponse>("ListOrchestrationClusters", grpcClient.ListOrchestrationClustersAsync, grpcClient.ListOrchestrationClusters, effectiveSettings.ListOrchestrationClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOrchestrationClusters);
            Modify_ListOrchestrationClustersApiCall(ref _callListOrchestrationClusters);
            _callGetOrchestrationCluster = clientHelper.BuildApiCall<GetOrchestrationClusterRequest, OrchestrationCluster>("GetOrchestrationCluster", grpcClient.GetOrchestrationClusterAsync, grpcClient.GetOrchestrationCluster, effectiveSettings.GetOrchestrationClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOrchestrationCluster);
            Modify_GetOrchestrationClusterApiCall(ref _callGetOrchestrationCluster);
            _callCreateOrchestrationCluster = clientHelper.BuildApiCall<CreateOrchestrationClusterRequest, lro::Operation>("CreateOrchestrationCluster", grpcClient.CreateOrchestrationClusterAsync, grpcClient.CreateOrchestrationCluster, effectiveSettings.CreateOrchestrationClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateOrchestrationCluster);
            Modify_CreateOrchestrationClusterApiCall(ref _callCreateOrchestrationCluster);
            _callDeleteOrchestrationCluster = clientHelper.BuildApiCall<DeleteOrchestrationClusterRequest, lro::Operation>("DeleteOrchestrationCluster", grpcClient.DeleteOrchestrationClusterAsync, grpcClient.DeleteOrchestrationCluster, effectiveSettings.DeleteOrchestrationClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteOrchestrationCluster);
            Modify_DeleteOrchestrationClusterApiCall(ref _callDeleteOrchestrationCluster);
            _callListEdgeSlms = clientHelper.BuildApiCall<ListEdgeSlmsRequest, ListEdgeSlmsResponse>("ListEdgeSlms", grpcClient.ListEdgeSlmsAsync, grpcClient.ListEdgeSlms, effectiveSettings.ListEdgeSlmsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEdgeSlms);
            Modify_ListEdgeSlmsApiCall(ref _callListEdgeSlms);
            _callGetEdgeSlm = clientHelper.BuildApiCall<GetEdgeSlmRequest, EdgeSlm>("GetEdgeSlm", grpcClient.GetEdgeSlmAsync, grpcClient.GetEdgeSlm, effectiveSettings.GetEdgeSlmSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEdgeSlm);
            Modify_GetEdgeSlmApiCall(ref _callGetEdgeSlm);
            _callCreateEdgeSlm = clientHelper.BuildApiCall<CreateEdgeSlmRequest, lro::Operation>("CreateEdgeSlm", grpcClient.CreateEdgeSlmAsync, grpcClient.CreateEdgeSlm, effectiveSettings.CreateEdgeSlmSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEdgeSlm);
            Modify_CreateEdgeSlmApiCall(ref _callCreateEdgeSlm);
            _callDeleteEdgeSlm = clientHelper.BuildApiCall<DeleteEdgeSlmRequest, lro::Operation>("DeleteEdgeSlm", grpcClient.DeleteEdgeSlmAsync, grpcClient.DeleteEdgeSlm, effectiveSettings.DeleteEdgeSlmSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEdgeSlm);
            Modify_DeleteEdgeSlmApiCall(ref _callDeleteEdgeSlm);
            _callCreateBlueprint = clientHelper.BuildApiCall<CreateBlueprintRequest, Blueprint>("CreateBlueprint", grpcClient.CreateBlueprintAsync, grpcClient.CreateBlueprint, effectiveSettings.CreateBlueprintSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBlueprint);
            Modify_CreateBlueprintApiCall(ref _callCreateBlueprint);
            _callUpdateBlueprint = clientHelper.BuildApiCall<UpdateBlueprintRequest, Blueprint>("UpdateBlueprint", grpcClient.UpdateBlueprintAsync, grpcClient.UpdateBlueprint, effectiveSettings.UpdateBlueprintSettings).WithGoogleRequestParam("blueprint.name", request => request.Blueprint?.Name);
            Modify_ApiCall(ref _callUpdateBlueprint);
            Modify_UpdateBlueprintApiCall(ref _callUpdateBlueprint);
            _callGetBlueprint = clientHelper.BuildApiCall<GetBlueprintRequest, Blueprint>("GetBlueprint", grpcClient.GetBlueprintAsync, grpcClient.GetBlueprint, effectiveSettings.GetBlueprintSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBlueprint);
            Modify_GetBlueprintApiCall(ref _callGetBlueprint);
            _callDeleteBlueprint = clientHelper.BuildApiCall<DeleteBlueprintRequest, wkt::Empty>("DeleteBlueprint", grpcClient.DeleteBlueprintAsync, grpcClient.DeleteBlueprint, effectiveSettings.DeleteBlueprintSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBlueprint);
            Modify_DeleteBlueprintApiCall(ref _callDeleteBlueprint);
            _callListBlueprints = clientHelper.BuildApiCall<ListBlueprintsRequest, ListBlueprintsResponse>("ListBlueprints", grpcClient.ListBlueprintsAsync, grpcClient.ListBlueprints, effectiveSettings.ListBlueprintsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBlueprints);
            Modify_ListBlueprintsApiCall(ref _callListBlueprints);
            _callApproveBlueprint = clientHelper.BuildApiCall<ApproveBlueprintRequest, Blueprint>("ApproveBlueprint", grpcClient.ApproveBlueprintAsync, grpcClient.ApproveBlueprint, effectiveSettings.ApproveBlueprintSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callApproveBlueprint);
            Modify_ApproveBlueprintApiCall(ref _callApproveBlueprint);
            _callProposeBlueprint = clientHelper.BuildApiCall<ProposeBlueprintRequest, Blueprint>("ProposeBlueprint", grpcClient.ProposeBlueprintAsync, grpcClient.ProposeBlueprint, effectiveSettings.ProposeBlueprintSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callProposeBlueprint);
            Modify_ProposeBlueprintApiCall(ref _callProposeBlueprint);
            _callRejectBlueprint = clientHelper.BuildApiCall<RejectBlueprintRequest, Blueprint>("RejectBlueprint", grpcClient.RejectBlueprintAsync, grpcClient.RejectBlueprint, effectiveSettings.RejectBlueprintSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRejectBlueprint);
            Modify_RejectBlueprintApiCall(ref _callRejectBlueprint);
            _callListBlueprintRevisions = clientHelper.BuildApiCall<ListBlueprintRevisionsRequest, ListBlueprintRevisionsResponse>("ListBlueprintRevisions", grpcClient.ListBlueprintRevisionsAsync, grpcClient.ListBlueprintRevisions, effectiveSettings.ListBlueprintRevisionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListBlueprintRevisions);
            Modify_ListBlueprintRevisionsApiCall(ref _callListBlueprintRevisions);
            _callSearchBlueprintRevisions = clientHelper.BuildApiCall<SearchBlueprintRevisionsRequest, SearchBlueprintRevisionsResponse>("SearchBlueprintRevisions", grpcClient.SearchBlueprintRevisionsAsync, grpcClient.SearchBlueprintRevisions, effectiveSettings.SearchBlueprintRevisionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchBlueprintRevisions);
            Modify_SearchBlueprintRevisionsApiCall(ref _callSearchBlueprintRevisions);
            _callSearchDeploymentRevisions = clientHelper.BuildApiCall<SearchDeploymentRevisionsRequest, SearchDeploymentRevisionsResponse>("SearchDeploymentRevisions", grpcClient.SearchDeploymentRevisionsAsync, grpcClient.SearchDeploymentRevisions, effectiveSettings.SearchDeploymentRevisionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchDeploymentRevisions);
            Modify_SearchDeploymentRevisionsApiCall(ref _callSearchDeploymentRevisions);
            _callDiscardBlueprintChanges = clientHelper.BuildApiCall<DiscardBlueprintChangesRequest, DiscardBlueprintChangesResponse>("DiscardBlueprintChanges", grpcClient.DiscardBlueprintChangesAsync, grpcClient.DiscardBlueprintChanges, effectiveSettings.DiscardBlueprintChangesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDiscardBlueprintChanges);
            Modify_DiscardBlueprintChangesApiCall(ref _callDiscardBlueprintChanges);
            _callListPublicBlueprints = clientHelper.BuildApiCall<ListPublicBlueprintsRequest, ListPublicBlueprintsResponse>("ListPublicBlueprints", grpcClient.ListPublicBlueprintsAsync, grpcClient.ListPublicBlueprints, effectiveSettings.ListPublicBlueprintsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPublicBlueprints);
            Modify_ListPublicBlueprintsApiCall(ref _callListPublicBlueprints);
            _callGetPublicBlueprint = clientHelper.BuildApiCall<GetPublicBlueprintRequest, PublicBlueprint>("GetPublicBlueprint", grpcClient.GetPublicBlueprintAsync, grpcClient.GetPublicBlueprint, effectiveSettings.GetPublicBlueprintSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPublicBlueprint);
            Modify_GetPublicBlueprintApiCall(ref _callGetPublicBlueprint);
            _callCreateDeployment = clientHelper.BuildApiCall<CreateDeploymentRequest, Deployment>("CreateDeployment", grpcClient.CreateDeploymentAsync, grpcClient.CreateDeployment, effectiveSettings.CreateDeploymentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDeployment);
            Modify_CreateDeploymentApiCall(ref _callCreateDeployment);
            _callUpdateDeployment = clientHelper.BuildApiCall<UpdateDeploymentRequest, Deployment>("UpdateDeployment", grpcClient.UpdateDeploymentAsync, grpcClient.UpdateDeployment, effectiveSettings.UpdateDeploymentSettings).WithGoogleRequestParam("deployment.name", request => request.Deployment?.Name);
            Modify_ApiCall(ref _callUpdateDeployment);
            Modify_UpdateDeploymentApiCall(ref _callUpdateDeployment);
            _callGetDeployment = clientHelper.BuildApiCall<GetDeploymentRequest, Deployment>("GetDeployment", grpcClient.GetDeploymentAsync, grpcClient.GetDeployment, effectiveSettings.GetDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeployment);
            Modify_GetDeploymentApiCall(ref _callGetDeployment);
            _callRemoveDeployment = clientHelper.BuildApiCall<RemoveDeploymentRequest, wkt::Empty>("RemoveDeployment", grpcClient.RemoveDeploymentAsync, grpcClient.RemoveDeployment, effectiveSettings.RemoveDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRemoveDeployment);
            Modify_RemoveDeploymentApiCall(ref _callRemoveDeployment);
            _callListDeployments = clientHelper.BuildApiCall<ListDeploymentsRequest, ListDeploymentsResponse>("ListDeployments", grpcClient.ListDeploymentsAsync, grpcClient.ListDeployments, effectiveSettings.ListDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeployments);
            Modify_ListDeploymentsApiCall(ref _callListDeployments);
            _callListDeploymentRevisions = clientHelper.BuildApiCall<ListDeploymentRevisionsRequest, ListDeploymentRevisionsResponse>("ListDeploymentRevisions", grpcClient.ListDeploymentRevisionsAsync, grpcClient.ListDeploymentRevisions, effectiveSettings.ListDeploymentRevisionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListDeploymentRevisions);
            Modify_ListDeploymentRevisionsApiCall(ref _callListDeploymentRevisions);
            _callDiscardDeploymentChanges = clientHelper.BuildApiCall<DiscardDeploymentChangesRequest, DiscardDeploymentChangesResponse>("DiscardDeploymentChanges", grpcClient.DiscardDeploymentChangesAsync, grpcClient.DiscardDeploymentChanges, effectiveSettings.DiscardDeploymentChangesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDiscardDeploymentChanges);
            Modify_DiscardDeploymentChangesApiCall(ref _callDiscardDeploymentChanges);
            _callApplyDeployment = clientHelper.BuildApiCall<ApplyDeploymentRequest, Deployment>("ApplyDeployment", grpcClient.ApplyDeploymentAsync, grpcClient.ApplyDeployment, effectiveSettings.ApplyDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callApplyDeployment);
            Modify_ApplyDeploymentApiCall(ref _callApplyDeployment);
            _callComputeDeploymentStatus = clientHelper.BuildApiCall<ComputeDeploymentStatusRequest, ComputeDeploymentStatusResponse>("ComputeDeploymentStatus", grpcClient.ComputeDeploymentStatusAsync, grpcClient.ComputeDeploymentStatus, effectiveSettings.ComputeDeploymentStatusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callComputeDeploymentStatus);
            Modify_ComputeDeploymentStatusApiCall(ref _callComputeDeploymentStatus);
            _callRollbackDeployment = clientHelper.BuildApiCall<RollbackDeploymentRequest, Deployment>("RollbackDeployment", grpcClient.RollbackDeploymentAsync, grpcClient.RollbackDeployment, effectiveSettings.RollbackDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRollbackDeployment);
            Modify_RollbackDeploymentApiCall(ref _callRollbackDeployment);
            _callGetHydratedDeployment = clientHelper.BuildApiCall<GetHydratedDeploymentRequest, HydratedDeployment>("GetHydratedDeployment", grpcClient.GetHydratedDeploymentAsync, grpcClient.GetHydratedDeployment, effectiveSettings.GetHydratedDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetHydratedDeployment);
            Modify_GetHydratedDeploymentApiCall(ref _callGetHydratedDeployment);
            _callListHydratedDeployments = clientHelper.BuildApiCall<ListHydratedDeploymentsRequest, ListHydratedDeploymentsResponse>("ListHydratedDeployments", grpcClient.ListHydratedDeploymentsAsync, grpcClient.ListHydratedDeployments, effectiveSettings.ListHydratedDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListHydratedDeployments);
            Modify_ListHydratedDeploymentsApiCall(ref _callListHydratedDeployments);
            _callUpdateHydratedDeployment = clientHelper.BuildApiCall<UpdateHydratedDeploymentRequest, HydratedDeployment>("UpdateHydratedDeployment", grpcClient.UpdateHydratedDeploymentAsync, grpcClient.UpdateHydratedDeployment, effectiveSettings.UpdateHydratedDeploymentSettings).WithGoogleRequestParam("hydrated_deployment.name", request => request.HydratedDeployment?.Name);
            Modify_ApiCall(ref _callUpdateHydratedDeployment);
            Modify_UpdateHydratedDeploymentApiCall(ref _callUpdateHydratedDeployment);
            _callApplyHydratedDeployment = clientHelper.BuildApiCall<ApplyHydratedDeploymentRequest, HydratedDeployment>("ApplyHydratedDeployment", grpcClient.ApplyHydratedDeploymentAsync, grpcClient.ApplyHydratedDeployment, effectiveSettings.ApplyHydratedDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callApplyHydratedDeployment);
            Modify_ApplyHydratedDeploymentApiCall(ref _callApplyHydratedDeployment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListOrchestrationClustersApiCall(ref gaxgrpc::ApiCall<ListOrchestrationClustersRequest, ListOrchestrationClustersResponse> call);

        partial void Modify_GetOrchestrationClusterApiCall(ref gaxgrpc::ApiCall<GetOrchestrationClusterRequest, OrchestrationCluster> call);

        partial void Modify_CreateOrchestrationClusterApiCall(ref gaxgrpc::ApiCall<CreateOrchestrationClusterRequest, lro::Operation> call);

        partial void Modify_DeleteOrchestrationClusterApiCall(ref gaxgrpc::ApiCall<DeleteOrchestrationClusterRequest, lro::Operation> call);

        partial void Modify_ListEdgeSlmsApiCall(ref gaxgrpc::ApiCall<ListEdgeSlmsRequest, ListEdgeSlmsResponse> call);

        partial void Modify_GetEdgeSlmApiCall(ref gaxgrpc::ApiCall<GetEdgeSlmRequest, EdgeSlm> call);

        partial void Modify_CreateEdgeSlmApiCall(ref gaxgrpc::ApiCall<CreateEdgeSlmRequest, lro::Operation> call);

        partial void Modify_DeleteEdgeSlmApiCall(ref gaxgrpc::ApiCall<DeleteEdgeSlmRequest, lro::Operation> call);

        partial void Modify_CreateBlueprintApiCall(ref gaxgrpc::ApiCall<CreateBlueprintRequest, Blueprint> call);

        partial void Modify_UpdateBlueprintApiCall(ref gaxgrpc::ApiCall<UpdateBlueprintRequest, Blueprint> call);

        partial void Modify_GetBlueprintApiCall(ref gaxgrpc::ApiCall<GetBlueprintRequest, Blueprint> call);

        partial void Modify_DeleteBlueprintApiCall(ref gaxgrpc::ApiCall<DeleteBlueprintRequest, wkt::Empty> call);

        partial void Modify_ListBlueprintsApiCall(ref gaxgrpc::ApiCall<ListBlueprintsRequest, ListBlueprintsResponse> call);

        partial void Modify_ApproveBlueprintApiCall(ref gaxgrpc::ApiCall<ApproveBlueprintRequest, Blueprint> call);

        partial void Modify_ProposeBlueprintApiCall(ref gaxgrpc::ApiCall<ProposeBlueprintRequest, Blueprint> call);

        partial void Modify_RejectBlueprintApiCall(ref gaxgrpc::ApiCall<RejectBlueprintRequest, Blueprint> call);

        partial void Modify_ListBlueprintRevisionsApiCall(ref gaxgrpc::ApiCall<ListBlueprintRevisionsRequest, ListBlueprintRevisionsResponse> call);

        partial void Modify_SearchBlueprintRevisionsApiCall(ref gaxgrpc::ApiCall<SearchBlueprintRevisionsRequest, SearchBlueprintRevisionsResponse> call);

        partial void Modify_SearchDeploymentRevisionsApiCall(ref gaxgrpc::ApiCall<SearchDeploymentRevisionsRequest, SearchDeploymentRevisionsResponse> call);

        partial void Modify_DiscardBlueprintChangesApiCall(ref gaxgrpc::ApiCall<DiscardBlueprintChangesRequest, DiscardBlueprintChangesResponse> call);

        partial void Modify_ListPublicBlueprintsApiCall(ref gaxgrpc::ApiCall<ListPublicBlueprintsRequest, ListPublicBlueprintsResponse> call);

        partial void Modify_GetPublicBlueprintApiCall(ref gaxgrpc::ApiCall<GetPublicBlueprintRequest, PublicBlueprint> call);

        partial void Modify_CreateDeploymentApiCall(ref gaxgrpc::ApiCall<CreateDeploymentRequest, Deployment> call);

        partial void Modify_UpdateDeploymentApiCall(ref gaxgrpc::ApiCall<UpdateDeploymentRequest, Deployment> call);

        partial void Modify_GetDeploymentApiCall(ref gaxgrpc::ApiCall<GetDeploymentRequest, Deployment> call);

        partial void Modify_RemoveDeploymentApiCall(ref gaxgrpc::ApiCall<RemoveDeploymentRequest, wkt::Empty> call);

        partial void Modify_ListDeploymentsApiCall(ref gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> call);

        partial void Modify_ListDeploymentRevisionsApiCall(ref gaxgrpc::ApiCall<ListDeploymentRevisionsRequest, ListDeploymentRevisionsResponse> call);

        partial void Modify_DiscardDeploymentChangesApiCall(ref gaxgrpc::ApiCall<DiscardDeploymentChangesRequest, DiscardDeploymentChangesResponse> call);

        partial void Modify_ApplyDeploymentApiCall(ref gaxgrpc::ApiCall<ApplyDeploymentRequest, Deployment> call);

        partial void Modify_ComputeDeploymentStatusApiCall(ref gaxgrpc::ApiCall<ComputeDeploymentStatusRequest, ComputeDeploymentStatusResponse> call);

        partial void Modify_RollbackDeploymentApiCall(ref gaxgrpc::ApiCall<RollbackDeploymentRequest, Deployment> call);

        partial void Modify_GetHydratedDeploymentApiCall(ref gaxgrpc::ApiCall<GetHydratedDeploymentRequest, HydratedDeployment> call);

        partial void Modify_ListHydratedDeploymentsApiCall(ref gaxgrpc::ApiCall<ListHydratedDeploymentsRequest, ListHydratedDeploymentsResponse> call);

        partial void Modify_UpdateHydratedDeploymentApiCall(ref gaxgrpc::ApiCall<UpdateHydratedDeploymentRequest, HydratedDeployment> call);

        partial void Modify_ApplyHydratedDeploymentApiCall(ref gaxgrpc::ApiCall<ApplyHydratedDeploymentRequest, HydratedDeployment> call);

        partial void OnConstruction(TelcoAutomation.TelcoAutomationClient grpcClient, TelcoAutomationSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TelcoAutomation client</summary>
        public override TelcoAutomation.TelcoAutomationClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListOrchestrationClustersRequest(ref ListOrchestrationClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOrchestrationClusterRequest(ref GetOrchestrationClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateOrchestrationClusterRequest(ref CreateOrchestrationClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteOrchestrationClusterRequest(ref DeleteOrchestrationClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEdgeSlmsRequest(ref ListEdgeSlmsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEdgeSlmRequest(ref GetEdgeSlmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEdgeSlmRequest(ref CreateEdgeSlmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEdgeSlmRequest(ref DeleteEdgeSlmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBlueprintRequest(ref CreateBlueprintRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBlueprintRequest(ref UpdateBlueprintRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBlueprintRequest(ref GetBlueprintRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBlueprintRequest(ref DeleteBlueprintRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBlueprintsRequest(ref ListBlueprintsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApproveBlueprintRequest(ref ApproveBlueprintRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ProposeBlueprintRequest(ref ProposeBlueprintRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RejectBlueprintRequest(ref RejectBlueprintRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBlueprintRevisionsRequest(ref ListBlueprintRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchBlueprintRevisionsRequest(ref SearchBlueprintRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchDeploymentRevisionsRequest(ref SearchDeploymentRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DiscardBlueprintChangesRequest(ref DiscardBlueprintChangesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPublicBlueprintsRequest(ref ListPublicBlueprintsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPublicBlueprintRequest(ref GetPublicBlueprintRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDeploymentRequest(ref CreateDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDeploymentRequest(ref UpdateDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeploymentRequest(ref GetDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveDeploymentRequest(ref RemoveDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeploymentsRequest(ref ListDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeploymentRevisionsRequest(ref ListDeploymentRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DiscardDeploymentChangesRequest(ref DiscardDeploymentChangesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApplyDeploymentRequest(ref ApplyDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ComputeDeploymentStatusRequest(ref ComputeDeploymentStatusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RollbackDeploymentRequest(ref RollbackDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetHydratedDeploymentRequest(ref GetHydratedDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListHydratedDeploymentsRequest(ref ListHydratedDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateHydratedDeploymentRequest(ref UpdateHydratedDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApplyHydratedDeploymentRequest(ref ApplyHydratedDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists OrchestrationClusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OrchestrationCluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> ListOrchestrationClusters(ListOrchestrationClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrchestrationClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOrchestrationClustersRequest, ListOrchestrationClustersResponse, OrchestrationCluster>(_callListOrchestrationClusters, request, callSettings);
        }

        /// <summary>
        /// Lists OrchestrationClusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OrchestrationCluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> ListOrchestrationClustersAsync(ListOrchestrationClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrchestrationClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOrchestrationClustersRequest, ListOrchestrationClustersResponse, OrchestrationCluster>(_callListOrchestrationClusters, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single OrchestrationCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OrchestrationCluster GetOrchestrationCluster(GetOrchestrationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrchestrationClusterRequest(ref request, ref callSettings);
            return _callGetOrchestrationCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single OrchestrationCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OrchestrationCluster> GetOrchestrationClusterAsync(GetOrchestrationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrchestrationClusterRequest(ref request, ref callSettings);
            return _callGetOrchestrationCluster.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateOrchestrationCluster</c>.</summary>
        public override lro::OperationsClient CreateOrchestrationClusterOperationsClient { get; }

        /// <summary>
        /// Creates a new OrchestrationCluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<OrchestrationCluster, OperationMetadata> CreateOrchestrationCluster(CreateOrchestrationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOrchestrationClusterRequest(ref request, ref callSettings);
            return new lro::Operation<OrchestrationCluster, OperationMetadata>(_callCreateOrchestrationCluster.Sync(request, callSettings), CreateOrchestrationClusterOperationsClient);
        }

        /// <summary>
        /// Creates a new OrchestrationCluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<OrchestrationCluster, OperationMetadata>> CreateOrchestrationClusterAsync(CreateOrchestrationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOrchestrationClusterRequest(ref request, ref callSettings);
            return new lro::Operation<OrchestrationCluster, OperationMetadata>(await _callCreateOrchestrationCluster.Async(request, callSettings).ConfigureAwait(false), CreateOrchestrationClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteOrchestrationCluster</c>.</summary>
        public override lro::OperationsClient DeleteOrchestrationClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a single OrchestrationCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteOrchestrationCluster(DeleteOrchestrationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOrchestrationClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteOrchestrationCluster.Sync(request, callSettings), DeleteOrchestrationClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a single OrchestrationCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOrchestrationClusterAsync(DeleteOrchestrationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOrchestrationClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteOrchestrationCluster.Async(request, callSettings).ConfigureAwait(false), DeleteOrchestrationClusterOperationsClient);
        }

        /// <summary>
        /// Lists EdgeSlms in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EdgeSlm"/> resources.</returns>
        public override gax::PagedEnumerable<ListEdgeSlmsResponse, EdgeSlm> ListEdgeSlms(ListEdgeSlmsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEdgeSlmsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEdgeSlmsRequest, ListEdgeSlmsResponse, EdgeSlm>(_callListEdgeSlms, request, callSettings);
        }

        /// <summary>
        /// Lists EdgeSlms in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EdgeSlm"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEdgeSlmsResponse, EdgeSlm> ListEdgeSlmsAsync(ListEdgeSlmsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEdgeSlmsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEdgeSlmsRequest, ListEdgeSlmsResponse, EdgeSlm>(_callListEdgeSlms, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single EdgeSlm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EdgeSlm GetEdgeSlm(GetEdgeSlmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEdgeSlmRequest(ref request, ref callSettings);
            return _callGetEdgeSlm.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single EdgeSlm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EdgeSlm> GetEdgeSlmAsync(GetEdgeSlmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEdgeSlmRequest(ref request, ref callSettings);
            return _callGetEdgeSlm.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEdgeSlm</c>.</summary>
        public override lro::OperationsClient CreateEdgeSlmOperationsClient { get; }

        /// <summary>
        /// Creates a new EdgeSlm in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EdgeSlm, OperationMetadata> CreateEdgeSlm(CreateEdgeSlmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEdgeSlmRequest(ref request, ref callSettings);
            return new lro::Operation<EdgeSlm, OperationMetadata>(_callCreateEdgeSlm.Sync(request, callSettings), CreateEdgeSlmOperationsClient);
        }

        /// <summary>
        /// Creates a new EdgeSlm in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EdgeSlm, OperationMetadata>> CreateEdgeSlmAsync(CreateEdgeSlmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEdgeSlmRequest(ref request, ref callSettings);
            return new lro::Operation<EdgeSlm, OperationMetadata>(await _callCreateEdgeSlm.Async(request, callSettings).ConfigureAwait(false), CreateEdgeSlmOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEdgeSlm</c>.</summary>
        public override lro::OperationsClient DeleteEdgeSlmOperationsClient { get; }

        /// <summary>
        /// Deletes a single EdgeSlm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteEdgeSlm(DeleteEdgeSlmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEdgeSlmRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteEdgeSlm.Sync(request, callSettings), DeleteEdgeSlmOperationsClient);
        }

        /// <summary>
        /// Deletes a single EdgeSlm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEdgeSlmAsync(DeleteEdgeSlmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEdgeSlmRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteEdgeSlm.Async(request, callSettings).ConfigureAwait(false), DeleteEdgeSlmOperationsClient);
        }

        /// <summary>
        /// Creates a blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Blueprint CreateBlueprint(CreateBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBlueprintRequest(ref request, ref callSettings);
            return _callCreateBlueprint.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Blueprint> CreateBlueprintAsync(CreateBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBlueprintRequest(ref request, ref callSettings);
            return _callCreateBlueprint.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Blueprint UpdateBlueprint(UpdateBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBlueprintRequest(ref request, ref callSettings);
            return _callUpdateBlueprint.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Blueprint> UpdateBlueprintAsync(UpdateBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBlueprintRequest(ref request, ref callSettings);
            return _callUpdateBlueprint.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Blueprint GetBlueprint(GetBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBlueprintRequest(ref request, ref callSettings);
            return _callGetBlueprint.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Blueprint> GetBlueprintAsync(GetBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBlueprintRequest(ref request, ref callSettings);
            return _callGetBlueprint.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a blueprint and all its revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteBlueprint(DeleteBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBlueprintRequest(ref request, ref callSettings);
            _callDeleteBlueprint.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a blueprint and all its revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteBlueprintAsync(DeleteBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBlueprintRequest(ref request, ref callSettings);
            return _callDeleteBlueprint.Async(request, callSettings);
        }

        /// <summary>
        /// List all blueprints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Blueprint"/> resources.</returns>
        public override gax::PagedEnumerable<ListBlueprintsResponse, Blueprint> ListBlueprints(ListBlueprintsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBlueprintsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBlueprintsRequest, ListBlueprintsResponse, Blueprint>(_callListBlueprints, request, callSettings);
        }

        /// <summary>
        /// List all blueprints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Blueprint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBlueprintsResponse, Blueprint> ListBlueprintsAsync(ListBlueprintsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBlueprintsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBlueprintsRequest, ListBlueprintsResponse, Blueprint>(_callListBlueprints, request, callSettings);
        }

        /// <summary>
        /// Approves a blueprint and commits a new revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Blueprint ApproveBlueprint(ApproveBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveBlueprintRequest(ref request, ref callSettings);
            return _callApproveBlueprint.Sync(request, callSettings);
        }

        /// <summary>
        /// Approves a blueprint and commits a new revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Blueprint> ApproveBlueprintAsync(ApproveBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveBlueprintRequest(ref request, ref callSettings);
            return _callApproveBlueprint.Async(request, callSettings);
        }

        /// <summary>
        /// Proposes a blueprint for approval of changes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Blueprint ProposeBlueprint(ProposeBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProposeBlueprintRequest(ref request, ref callSettings);
            return _callProposeBlueprint.Sync(request, callSettings);
        }

        /// <summary>
        /// Proposes a blueprint for approval of changes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Blueprint> ProposeBlueprintAsync(ProposeBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProposeBlueprintRequest(ref request, ref callSettings);
            return _callProposeBlueprint.Async(request, callSettings);
        }

        /// <summary>
        /// Rejects a blueprint revision proposal and flips it back to Draft state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Blueprint RejectBlueprint(RejectBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RejectBlueprintRequest(ref request, ref callSettings);
            return _callRejectBlueprint.Sync(request, callSettings);
        }

        /// <summary>
        /// Rejects a blueprint revision proposal and flips it back to Draft state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Blueprint> RejectBlueprintAsync(RejectBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RejectBlueprintRequest(ref request, ref callSettings);
            return _callRejectBlueprint.Async(request, callSettings);
        }

        /// <summary>
        /// List blueprint revisions of a given blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Blueprint"/> resources.</returns>
        public override gax::PagedEnumerable<ListBlueprintRevisionsResponse, Blueprint> ListBlueprintRevisions(ListBlueprintRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBlueprintRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBlueprintRevisionsRequest, ListBlueprintRevisionsResponse, Blueprint>(_callListBlueprintRevisions, request, callSettings);
        }

        /// <summary>
        /// List blueprint revisions of a given blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Blueprint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBlueprintRevisionsResponse, Blueprint> ListBlueprintRevisionsAsync(ListBlueprintRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBlueprintRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBlueprintRevisionsRequest, ListBlueprintRevisionsResponse, Blueprint>(_callListBlueprintRevisions, request, callSettings);
        }

        /// <summary>
        /// Searches across blueprint revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Blueprint"/> resources.</returns>
        public override gax::PagedEnumerable<SearchBlueprintRevisionsResponse, Blueprint> SearchBlueprintRevisions(SearchBlueprintRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchBlueprintRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchBlueprintRevisionsRequest, SearchBlueprintRevisionsResponse, Blueprint>(_callSearchBlueprintRevisions, request, callSettings);
        }

        /// <summary>
        /// Searches across blueprint revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Blueprint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchBlueprintRevisionsResponse, Blueprint> SearchBlueprintRevisionsAsync(SearchBlueprintRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchBlueprintRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchBlueprintRevisionsRequest, SearchBlueprintRevisionsResponse, Blueprint>(_callSearchBlueprintRevisions, request, callSettings);
        }

        /// <summary>
        /// Searches across deployment revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedEnumerable<SearchDeploymentRevisionsResponse, Deployment> SearchDeploymentRevisions(SearchDeploymentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchDeploymentRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchDeploymentRevisionsRequest, SearchDeploymentRevisionsResponse, Deployment>(_callSearchDeploymentRevisions, request, callSettings);
        }

        /// <summary>
        /// Searches across deployment revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchDeploymentRevisionsResponse, Deployment> SearchDeploymentRevisionsAsync(SearchDeploymentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchDeploymentRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchDeploymentRevisionsRequest, SearchDeploymentRevisionsResponse, Deployment>(_callSearchDeploymentRevisions, request, callSettings);
        }

        /// <summary>
        /// Discards the changes in a blueprint and reverts the blueprint to the last
        /// approved blueprint revision. No changes take place if a blueprint does not
        /// have revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiscardBlueprintChangesResponse DiscardBlueprintChanges(DiscardBlueprintChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiscardBlueprintChangesRequest(ref request, ref callSettings);
            return _callDiscardBlueprintChanges.Sync(request, callSettings);
        }

        /// <summary>
        /// Discards the changes in a blueprint and reverts the blueprint to the last
        /// approved blueprint revision. No changes take place if a blueprint does not
        /// have revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiscardBlueprintChangesResponse> DiscardBlueprintChangesAsync(DiscardBlueprintChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiscardBlueprintChangesRequest(ref request, ref callSettings);
            return _callDiscardBlueprintChanges.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the blueprints in TNA's public catalog. Default page size = 20,
        /// Max Page Size = 100.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PublicBlueprint"/> resources.</returns>
        public override gax::PagedEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> ListPublicBlueprints(ListPublicBlueprintsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublicBlueprintsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPublicBlueprintsRequest, ListPublicBlueprintsResponse, PublicBlueprint>(_callListPublicBlueprints, request, callSettings);
        }

        /// <summary>
        /// Lists the blueprints in TNA's public catalog. Default page size = 20,
        /// Max Page Size = 100.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PublicBlueprint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> ListPublicBlueprintsAsync(ListPublicBlueprintsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublicBlueprintsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPublicBlueprintsRequest, ListPublicBlueprintsResponse, PublicBlueprint>(_callListPublicBlueprints, request, callSettings);
        }

        /// <summary>
        /// Returns the requested public blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublicBlueprint GetPublicBlueprint(GetPublicBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPublicBlueprintRequest(ref request, ref callSettings);
            return _callGetPublicBlueprint.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested public blueprint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublicBlueprint> GetPublicBlueprintAsync(GetPublicBlueprintRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPublicBlueprintRequest(ref request, ref callSettings);
            return _callGetPublicBlueprint.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment CreateDeployment(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentRequest(ref request, ref callSettings);
            return _callCreateDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> CreateDeploymentAsync(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentRequest(ref request, ref callSettings);
            return _callCreateDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment UpdateDeployment(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeploymentRequest(ref request, ref callSettings);
            return _callUpdateDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> UpdateDeploymentAsync(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeploymentRequest(ref request, ref callSettings);
            return _callUpdateDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment GetDeployment(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentRequest(ref request, ref callSettings);
            return _callGetDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentRequest(ref request, ref callSettings);
            return _callGetDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Removes the deployment by marking it as DELETING. Post which deployment and
        /// it's revisions gets deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void RemoveDeployment(RemoveDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveDeploymentRequest(ref request, ref callSettings);
            _callRemoveDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes the deployment by marking it as DELETING. Post which deployment and
        /// it's revisions gets deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task RemoveDeploymentAsync(RemoveDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveDeploymentRequest(ref request, ref callSettings);
            return _callRemoveDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// List all deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeploymentsRequest, ListDeploymentsResponse, Deployment>(_callListDeployments, request, callSettings);
        }

        /// <summary>
        /// List all deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeploymentsRequest, ListDeploymentsResponse, Deployment>(_callListDeployments, request, callSettings);
        }

        /// <summary>
        /// List deployment revisions of a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeploymentRevisionsResponse, Deployment> ListDeploymentRevisions(ListDeploymentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeploymentRevisionsRequest, ListDeploymentRevisionsResponse, Deployment>(_callListDeploymentRevisions, request, callSettings);
        }

        /// <summary>
        /// List deployment revisions of a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeploymentRevisionsResponse, Deployment> ListDeploymentRevisionsAsync(ListDeploymentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeploymentRevisionsRequest, ListDeploymentRevisionsResponse, Deployment>(_callListDeploymentRevisions, request, callSettings);
        }

        /// <summary>
        /// Discards the changes in a deployment and reverts the deployment to the last
        /// approved deployment revision. No changes take place if a deployment does
        /// not have revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiscardDeploymentChangesResponse DiscardDeploymentChanges(DiscardDeploymentChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiscardDeploymentChangesRequest(ref request, ref callSettings);
            return _callDiscardDeploymentChanges.Sync(request, callSettings);
        }

        /// <summary>
        /// Discards the changes in a deployment and reverts the deployment to the last
        /// approved deployment revision. No changes take place if a deployment does
        /// not have revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiscardDeploymentChangesResponse> DiscardDeploymentChangesAsync(DiscardDeploymentChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiscardDeploymentChangesRequest(ref request, ref callSettings);
            return _callDiscardDeploymentChanges.Async(request, callSettings);
        }

        /// <summary>
        /// Applies the deployment's YAML files to the parent orchestration cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment ApplyDeployment(ApplyDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyDeploymentRequest(ref request, ref callSettings);
            return _callApplyDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Applies the deployment's YAML files to the parent orchestration cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> ApplyDeploymentAsync(ApplyDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyDeploymentRequest(ref request, ref callSettings);
            return _callApplyDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested deployment status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ComputeDeploymentStatusResponse ComputeDeploymentStatus(ComputeDeploymentStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeDeploymentStatusRequest(ref request, ref callSettings);
            return _callComputeDeploymentStatus.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested deployment status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ComputeDeploymentStatusResponse> ComputeDeploymentStatusAsync(ComputeDeploymentStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeDeploymentStatusRequest(ref request, ref callSettings);
            return _callComputeDeploymentStatus.Async(request, callSettings);
        }

        /// <summary>
        /// Rollback the active deployment to the given past approved deployment
        /// revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment RollbackDeployment(RollbackDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackDeploymentRequest(ref request, ref callSettings);
            return _callRollbackDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Rollback the active deployment to the given past approved deployment
        /// revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> RollbackDeploymentAsync(RollbackDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackDeploymentRequest(ref request, ref callSettings);
            return _callRollbackDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested hydrated deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HydratedDeployment GetHydratedDeployment(GetHydratedDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHydratedDeploymentRequest(ref request, ref callSettings);
            return _callGetHydratedDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested hydrated deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HydratedDeployment> GetHydratedDeploymentAsync(GetHydratedDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHydratedDeploymentRequest(ref request, ref callSettings);
            return _callGetHydratedDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// List all hydrated deployments present under a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HydratedDeployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> ListHydratedDeployments(ListHydratedDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHydratedDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHydratedDeploymentsRequest, ListHydratedDeploymentsResponse, HydratedDeployment>(_callListHydratedDeployments, request, callSettings);
        }

        /// <summary>
        /// List all hydrated deployments present under a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HydratedDeployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> ListHydratedDeploymentsAsync(ListHydratedDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHydratedDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHydratedDeploymentsRequest, ListHydratedDeploymentsResponse, HydratedDeployment>(_callListHydratedDeployments, request, callSettings);
        }

        /// <summary>
        /// Updates a hydrated deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HydratedDeployment UpdateHydratedDeployment(UpdateHydratedDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHydratedDeploymentRequest(ref request, ref callSettings);
            return _callUpdateHydratedDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a hydrated deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HydratedDeployment> UpdateHydratedDeploymentAsync(UpdateHydratedDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHydratedDeploymentRequest(ref request, ref callSettings);
            return _callUpdateHydratedDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Applies a hydrated deployment to a workload cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HydratedDeployment ApplyHydratedDeployment(ApplyHydratedDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyHydratedDeploymentRequest(ref request, ref callSettings);
            return _callApplyHydratedDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Applies a hydrated deployment to a workload cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HydratedDeployment> ApplyHydratedDeploymentAsync(ApplyHydratedDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyHydratedDeploymentRequest(ref request, ref callSettings);
            return _callApplyHydratedDeployment.Async(request, callSettings);
        }
    }

    public partial class ListOrchestrationClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEdgeSlmsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBlueprintsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBlueprintRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchBlueprintRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchDeploymentRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPublicBlueprintsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeploymentRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListHydratedDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOrchestrationClustersResponse : gaxgrpc::IPageResponse<OrchestrationCluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OrchestrationCluster> GetEnumerator() => OrchestrationClusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEdgeSlmsResponse : gaxgrpc::IPageResponse<EdgeSlm>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EdgeSlm> GetEnumerator() => EdgeSlms.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBlueprintsResponse : gaxgrpc::IPageResponse<Blueprint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Blueprint> GetEnumerator() => Blueprints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBlueprintRevisionsResponse : gaxgrpc::IPageResponse<Blueprint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Blueprint> GetEnumerator() => Blueprints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchBlueprintRevisionsResponse : gaxgrpc::IPageResponse<Blueprint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Blueprint> GetEnumerator() => Blueprints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchDeploymentRevisionsResponse : gaxgrpc::IPageResponse<Deployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Deployment> GetEnumerator() => Deployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPublicBlueprintsResponse : gaxgrpc::IPageResponse<PublicBlueprint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PublicBlueprint> GetEnumerator() => PublicBlueprints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDeploymentsResponse : gaxgrpc::IPageResponse<Deployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Deployment> GetEnumerator() => Deployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDeploymentRevisionsResponse : gaxgrpc::IPageResponse<Deployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Deployment> GetEnumerator() => Deployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListHydratedDeploymentsResponse : gaxgrpc::IPageResponse<HydratedDeployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<HydratedDeployment> GetEnumerator() => HydratedDeployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class TelcoAutomation
    {
        public partial class TelcoAutomationClient
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

    public static partial class TelcoAutomation
    {
        public partial class TelcoAutomationClient
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
        }
    }
}
