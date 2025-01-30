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
using linq = System.Linq;
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

namespace Google.Cloud.VisionAI.V1
{
    /// <summary>Settings for <see cref="AppPlatformClient"/> instances.</summary>
    public sealed partial class AppPlatformSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AppPlatformSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AppPlatformSettings"/>.</returns>
        public static AppPlatformSettings GetDefault() => new AppPlatformSettings();

        /// <summary>Constructs a new <see cref="AppPlatformSettings"/> object with default settings.</summary>
        public AppPlatformSettings()
        {
        }

        private AppPlatformSettings(AppPlatformSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListApplicationsSettings = existing.ListApplicationsSettings;
            GetApplicationSettings = existing.GetApplicationSettings;
            CreateApplicationSettings = existing.CreateApplicationSettings;
            CreateApplicationOperationsSettings = existing.CreateApplicationOperationsSettings.Clone();
            UpdateApplicationSettings = existing.UpdateApplicationSettings;
            UpdateApplicationOperationsSettings = existing.UpdateApplicationOperationsSettings.Clone();
            DeleteApplicationSettings = existing.DeleteApplicationSettings;
            DeleteApplicationOperationsSettings = existing.DeleteApplicationOperationsSettings.Clone();
            DeployApplicationSettings = existing.DeployApplicationSettings;
            DeployApplicationOperationsSettings = existing.DeployApplicationOperationsSettings.Clone();
            UndeployApplicationSettings = existing.UndeployApplicationSettings;
            UndeployApplicationOperationsSettings = existing.UndeployApplicationOperationsSettings.Clone();
            AddApplicationStreamInputSettings = existing.AddApplicationStreamInputSettings;
            AddApplicationStreamInputOperationsSettings = existing.AddApplicationStreamInputOperationsSettings.Clone();
            RemoveApplicationStreamInputSettings = existing.RemoveApplicationStreamInputSettings;
            RemoveApplicationStreamInputOperationsSettings = existing.RemoveApplicationStreamInputOperationsSettings.Clone();
            UpdateApplicationStreamInputSettings = existing.UpdateApplicationStreamInputSettings;
            UpdateApplicationStreamInputOperationsSettings = existing.UpdateApplicationStreamInputOperationsSettings.Clone();
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            CreateApplicationInstancesSettings = existing.CreateApplicationInstancesSettings;
            CreateApplicationInstancesOperationsSettings = existing.CreateApplicationInstancesOperationsSettings.Clone();
            DeleteApplicationInstancesSettings = existing.DeleteApplicationInstancesSettings;
            DeleteApplicationInstancesOperationsSettings = existing.DeleteApplicationInstancesOperationsSettings.Clone();
            UpdateApplicationInstancesSettings = existing.UpdateApplicationInstancesSettings;
            UpdateApplicationInstancesOperationsSettings = existing.UpdateApplicationInstancesOperationsSettings.Clone();
            ListDraftsSettings = existing.ListDraftsSettings;
            GetDraftSettings = existing.GetDraftSettings;
            CreateDraftSettings = existing.CreateDraftSettings;
            CreateDraftOperationsSettings = existing.CreateDraftOperationsSettings.Clone();
            UpdateDraftSettings = existing.UpdateDraftSettings;
            UpdateDraftOperationsSettings = existing.UpdateDraftOperationsSettings.Clone();
            DeleteDraftSettings = existing.DeleteDraftSettings;
            DeleteDraftOperationsSettings = existing.DeleteDraftOperationsSettings.Clone();
            ListProcessorsSettings = existing.ListProcessorsSettings;
            ListPrebuiltProcessorsSettings = existing.ListPrebuiltProcessorsSettings;
            GetProcessorSettings = existing.GetProcessorSettings;
            CreateProcessorSettings = existing.CreateProcessorSettings;
            CreateProcessorOperationsSettings = existing.CreateProcessorOperationsSettings.Clone();
            UpdateProcessorSettings = existing.UpdateProcessorSettings;
            UpdateProcessorOperationsSettings = existing.UpdateProcessorOperationsSettings.Clone();
            DeleteProcessorSettings = existing.DeleteProcessorSettings;
            DeleteProcessorOperationsSettings = existing.DeleteProcessorOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AppPlatformSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.ListApplications</c> and <c>AppPlatformClient.ListApplicationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListApplicationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.GetApplication</c> and <c>AppPlatformClient.GetApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.CreateApplication</c> and <c>AppPlatformClient.CreateApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.CreateApplication</c> and
        /// <c>AppPlatformClient.CreateApplicationAsync</c>.
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
        public lro::OperationsSettings CreateApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.UpdateApplication</c> and <c>AppPlatformClient.UpdateApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.UpdateApplication</c> and
        /// <c>AppPlatformClient.UpdateApplicationAsync</c>.
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
        public lro::OperationsSettings UpdateApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.DeleteApplication</c> and <c>AppPlatformClient.DeleteApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.DeleteApplication</c> and
        /// <c>AppPlatformClient.DeleteApplicationAsync</c>.
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
        public lro::OperationsSettings DeleteApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.DeployApplication</c> and <c>AppPlatformClient.DeployApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeployApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.DeployApplication</c> and
        /// <c>AppPlatformClient.DeployApplicationAsync</c>.
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
        public lro::OperationsSettings DeployApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.UndeployApplication</c> and <c>AppPlatformClient.UndeployApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeployApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.UndeployApplication</c> and
        /// <c>AppPlatformClient.UndeployApplicationAsync</c>.
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
        public lro::OperationsSettings UndeployApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.AddApplicationStreamInput</c> and <c>AppPlatformClient.AddApplicationStreamInputAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddApplicationStreamInputSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.AddApplicationStreamInput</c> and
        /// <c>AppPlatformClient.AddApplicationStreamInputAsync</c>.
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
        public lro::OperationsSettings AddApplicationStreamInputOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.RemoveApplicationStreamInput</c> and
        /// <c>AppPlatformClient.RemoveApplicationStreamInputAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveApplicationStreamInputSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.RemoveApplicationStreamInput</c> and
        /// <c>AppPlatformClient.RemoveApplicationStreamInputAsync</c>.
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
        public lro::OperationsSettings RemoveApplicationStreamInputOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.UpdateApplicationStreamInput</c> and
        /// <c>AppPlatformClient.UpdateApplicationStreamInputAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApplicationStreamInputSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.UpdateApplicationStreamInput</c> and
        /// <c>AppPlatformClient.UpdateApplicationStreamInputAsync</c>.
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
        public lro::OperationsSettings UpdateApplicationStreamInputOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.ListInstances</c> and <c>AppPlatformClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.GetInstance</c> and <c>AppPlatformClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.CreateApplicationInstances</c> and <c>AppPlatformClient.CreateApplicationInstancesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApplicationInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.CreateApplicationInstances</c> and
        /// <c>AppPlatformClient.CreateApplicationInstancesAsync</c>.
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
        public lro::OperationsSettings CreateApplicationInstancesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.DeleteApplicationInstances</c> and <c>AppPlatformClient.DeleteApplicationInstancesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApplicationInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.DeleteApplicationInstances</c> and
        /// <c>AppPlatformClient.DeleteApplicationInstancesAsync</c>.
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
        public lro::OperationsSettings DeleteApplicationInstancesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.UpdateApplicationInstances</c> and <c>AppPlatformClient.UpdateApplicationInstancesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApplicationInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.UpdateApplicationInstances</c> and
        /// <c>AppPlatformClient.UpdateApplicationInstancesAsync</c>.
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
        public lro::OperationsSettings UpdateApplicationInstancesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.ListDrafts</c> and <c>AppPlatformClient.ListDraftsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDraftsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppPlatformClient.GetDraft</c>
        ///  and <c>AppPlatformClient.GetDraftAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDraftSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.CreateDraft</c> and <c>AppPlatformClient.CreateDraftAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDraftSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.CreateDraft</c> and
        /// <c>AppPlatformClient.CreateDraftAsync</c>.
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
        public lro::OperationsSettings CreateDraftOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.UpdateDraft</c> and <c>AppPlatformClient.UpdateDraftAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDraftSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.UpdateDraft</c> and
        /// <c>AppPlatformClient.UpdateDraftAsync</c>.
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
        public lro::OperationsSettings UpdateDraftOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.DeleteDraft</c> and <c>AppPlatformClient.DeleteDraftAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDraftSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.DeleteDraft</c> and
        /// <c>AppPlatformClient.DeleteDraftAsync</c>.
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
        public lro::OperationsSettings DeleteDraftOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.ListProcessors</c> and <c>AppPlatformClient.ListProcessorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProcessorsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.ListPrebuiltProcessors</c> and <c>AppPlatformClient.ListPrebuiltProcessorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPrebuiltProcessorsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.GetProcessor</c> and <c>AppPlatformClient.GetProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProcessorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.CreateProcessor</c> and <c>AppPlatformClient.CreateProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProcessorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.CreateProcessor</c> and
        /// <c>AppPlatformClient.CreateProcessorAsync</c>.
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
        public lro::OperationsSettings CreateProcessorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.UpdateProcessor</c> and <c>AppPlatformClient.UpdateProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProcessorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.UpdateProcessor</c> and
        /// <c>AppPlatformClient.UpdateProcessorAsync</c>.
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
        public lro::OperationsSettings UpdateProcessorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppPlatformClient.DeleteProcessor</c> and <c>AppPlatformClient.DeleteProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProcessorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppPlatformClient.DeleteProcessor</c> and
        /// <c>AppPlatformClient.DeleteProcessorAsync</c>.
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
        public lro::OperationsSettings DeleteProcessorOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="AppPlatformSettings"/> object.</returns>
        public AppPlatformSettings Clone() => new AppPlatformSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AppPlatformClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AppPlatformClientBuilder : gaxgrpc::ClientBuilderBase<AppPlatformClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AppPlatformSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AppPlatformClientBuilder() : base(AppPlatformClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AppPlatformClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AppPlatformClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AppPlatformClient Build()
        {
            AppPlatformClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AppPlatformClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AppPlatformClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AppPlatformClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AppPlatformClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AppPlatformClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AppPlatformClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AppPlatformClient.ChannelPool;
    }

    /// <summary>AppPlatform client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class AppPlatformClient
    {
        /// <summary>
        /// The default endpoint for the AppPlatform service, which is a host of "visionai.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "visionai.googleapis.com:443";

        /// <summary>The default AppPlatform scopes.</summary>
        /// <remarks>
        /// The default AppPlatform scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AppPlatform.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AppPlatformClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AppPlatformClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AppPlatformClient"/>.</returns>
        public static stt::Task<AppPlatformClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AppPlatformClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AppPlatformClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AppPlatformClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AppPlatformClient"/>.</returns>
        public static AppPlatformClient Create() => new AppPlatformClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AppPlatformClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AppPlatformSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AppPlatformClient"/>.</returns>
        internal static AppPlatformClient Create(grpccore::CallInvoker callInvoker, AppPlatformSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AppPlatform.AppPlatformClient grpcClient = new AppPlatform.AppPlatformClient(callInvoker);
            return new AppPlatformClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AppPlatform client</summary>
        public virtual AppPlatform.AppPlatformClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Applications in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Applications in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Applications in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListApplicationsRequest.
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
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplications(request, callSettings);
        }

        /// <summary>
        /// Lists Applications in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListApplicationsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplicationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Applications in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListApplicationsRequest.
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
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplications(request, callSettings);
        }

        /// <summary>
        /// Lists Applications in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListApplicationsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplicationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplication(new GetApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationAsync(new GetApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplication(new GetApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationAsync(new GetApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Application in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Application, OperationMetadata> CreateApplication(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Application in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Application in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(CreateApplicationRequest request, st::CancellationToken cancellationToken) =>
            CreateApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateApplication</c>.</summary>
        public virtual lro::OperationsClient CreateApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Application, OperationMetadata> PollOnceCreateApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> PollOnceCreateApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApplicationOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Application in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="application">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Application, OperationMetadata> CreateApplication(string parent, Application application, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplication(new CreateApplicationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates a new Application in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="application">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(string parent, Application application, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationAsync(new CreateApplicationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates a new Application in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="application">
        /// Required. The resource being created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(string parent, Application application, st::CancellationToken cancellationToken) =>
            CreateApplicationAsync(parent, application, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Application in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="application">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Application, OperationMetadata> CreateApplication(gagr::LocationName parent, Application application, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplication(new CreateApplicationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates a new Application in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="application">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(gagr::LocationName parent, Application application, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationAsync(new CreateApplicationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates a new Application in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="application">
        /// Required. The resource being created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(gagr::LocationName parent, Application application, st::CancellationToken cancellationToken) =>
            CreateApplicationAsync(parent, application, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Application, OperationMetadata> UpdateApplication(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> UpdateApplicationAsync(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> UpdateApplicationAsync(UpdateApplicationRequest request, st::CancellationToken cancellationToken) =>
            UpdateApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateApplication</c>.</summary>
        public virtual lro::OperationsClient UpdateApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Application, OperationMetadata> PollOnceUpdateApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> PollOnceUpdateApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApplicationOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Application.
        /// </summary>
        /// <param name="application">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Application resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Application, OperationMetadata> UpdateApplication(Application application, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplication(new UpdateApplicationRequest
            {
                UpdateMask = updateMask,
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Application.
        /// </summary>
        /// <param name="application">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Application resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> UpdateApplicationAsync(Application application, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationAsync(new UpdateApplicationRequest
            {
                UpdateMask = updateMask,
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Application.
        /// </summary>
        /// <param name="application">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Application resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> UpdateApplicationAsync(Application application, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateApplicationAsync(application, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApplication(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(DeleteApplicationRequest request, st::CancellationToken cancellationToken) =>
            DeleteApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteApplication</c>.</summary>
        public virtual lro::OperationsClient DeleteApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteApplicationOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplication(new DeleteApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationAsync(new DeleteApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApplication(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplication(new DeleteApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationAsync(new DeleteApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            DeleteApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployApplicationResponse, OperationMetadata> DeployApplication(DeployApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(DeployApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(DeployApplicationRequest request, st::CancellationToken cancellationToken) =>
            DeployApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeployApplication</c>.</summary>
        public virtual lro::OperationsClient DeployApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeployApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeployApplicationResponse, OperationMetadata> PollOnceDeployApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployApplicationResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeployApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> PollOnceDeployApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployApplicationResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployApplicationOperationsClient, callSettings);

        /// <summary>
        /// Deploys a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployApplicationResponse, OperationMetadata> DeployApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeployApplication(new DeployApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeployApplicationAsync(new DeployApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            DeployApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployApplicationResponse, OperationMetadata> DeployApplication(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeployApplication(new DeployApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeployApplicationAsync(new DeployApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            DeployApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployApplicationResponse, OperationMetadata> UndeployApplication(UndeployApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployApplicationResponse, OperationMetadata>> UndeployApplicationAsync(UndeployApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployApplicationResponse, OperationMetadata>> UndeployApplicationAsync(UndeployApplicationRequest request, st::CancellationToken cancellationToken) =>
            UndeployApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeployApplication</c>.</summary>
        public virtual lro::OperationsClient UndeployApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeployApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UndeployApplicationResponse, OperationMetadata> PollOnceUndeployApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployApplicationResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeployApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UndeployApplicationResponse, OperationMetadata>> PollOnceUndeployApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployApplicationResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployApplicationOperationsClient, callSettings);

        /// <summary>
        /// Undeploys a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployApplicationResponse, OperationMetadata> UndeployApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployApplication(new UndeployApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployApplicationResponse, OperationMetadata>> UndeployApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployApplicationAsync(new UndeployApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployApplicationResponse, OperationMetadata>> UndeployApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            UndeployApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployApplicationResponse, OperationMetadata> UndeployApplication(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployApplication(new UndeployApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployApplicationResponse, OperationMetadata>> UndeployApplicationAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployApplicationAsync(new UndeployApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys a single Application.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployApplicationResponse, OperationMetadata>> UndeployApplicationAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            UndeployApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddApplicationStreamInputResponse, OperationMetadata> AddApplicationStreamInput(AddApplicationStreamInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddApplicationStreamInputResponse, OperationMetadata>> AddApplicationStreamInputAsync(AddApplicationStreamInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddApplicationStreamInputResponse, OperationMetadata>> AddApplicationStreamInputAsync(AddApplicationStreamInputRequest request, st::CancellationToken cancellationToken) =>
            AddApplicationStreamInputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddApplicationStreamInput</c>.</summary>
        public virtual lro::OperationsClient AddApplicationStreamInputOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddApplicationStreamInput</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AddApplicationStreamInputResponse, OperationMetadata> PollOnceAddApplicationStreamInput(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddApplicationStreamInputResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddApplicationStreamInputOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddApplicationStreamInput</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AddApplicationStreamInputResponse, OperationMetadata>> PollOnceAddApplicationStreamInputAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddApplicationStreamInputResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddApplicationStreamInputOperationsClient, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddApplicationStreamInputResponse, OperationMetadata> AddApplicationStreamInput(string name, gaxgrpc::CallSettings callSettings = null) =>
            AddApplicationStreamInput(new AddApplicationStreamInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddApplicationStreamInputResponse, OperationMetadata>> AddApplicationStreamInputAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            AddApplicationStreamInputAsync(new AddApplicationStreamInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddApplicationStreamInputResponse, OperationMetadata>> AddApplicationStreamInputAsync(string name, st::CancellationToken cancellationToken) =>
            AddApplicationStreamInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddApplicationStreamInputResponse, OperationMetadata> AddApplicationStreamInput(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            AddApplicationStreamInput(new AddApplicationStreamInputRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddApplicationStreamInputResponse, OperationMetadata>> AddApplicationStreamInputAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            AddApplicationStreamInputAsync(new AddApplicationStreamInputRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddApplicationStreamInputResponse, OperationMetadata>> AddApplicationStreamInputAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            AddApplicationStreamInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata> RemoveApplicationStreamInput(RemoveApplicationStreamInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata>> RemoveApplicationStreamInputAsync(RemoveApplicationStreamInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata>> RemoveApplicationStreamInputAsync(RemoveApplicationStreamInputRequest request, st::CancellationToken cancellationToken) =>
            RemoveApplicationStreamInputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveApplicationStreamInput</c>.</summary>
        public virtual lro::OperationsClient RemoveApplicationStreamInputOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveApplicationStreamInput</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata> PollOnceRemoveApplicationStreamInput(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveApplicationStreamInputOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveApplicationStreamInput</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata>> PollOnceRemoveApplicationStreamInputAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveApplicationStreamInputOperationsClient, callSettings);

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata> RemoveApplicationStreamInput(string name, gaxgrpc::CallSettings callSettings = null) =>
            RemoveApplicationStreamInput(new RemoveApplicationStreamInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata>> RemoveApplicationStreamInputAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RemoveApplicationStreamInputAsync(new RemoveApplicationStreamInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata>> RemoveApplicationStreamInputAsync(string name, st::CancellationToken cancellationToken) =>
            RemoveApplicationStreamInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata> RemoveApplicationStreamInput(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            RemoveApplicationStreamInput(new RemoveApplicationStreamInputRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata>> RemoveApplicationStreamInputAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            RemoveApplicationStreamInputAsync(new RemoveApplicationStreamInputRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata>> RemoveApplicationStreamInputAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            RemoveApplicationStreamInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deployed. For
        /// CreateOrUpdate behavior, set allow_missing to true.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata> UpdateApplicationStreamInput(UpdateApplicationStreamInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deployed. For
        /// CreateOrUpdate behavior, set allow_missing to true.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata>> UpdateApplicationStreamInputAsync(UpdateApplicationStreamInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deployed. For
        /// CreateOrUpdate behavior, set allow_missing to true.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata>> UpdateApplicationStreamInputAsync(UpdateApplicationStreamInputRequest request, st::CancellationToken cancellationToken) =>
            UpdateApplicationStreamInputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateApplicationStreamInput</c>.</summary>
        public virtual lro::OperationsClient UpdateApplicationStreamInputOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateApplicationStreamInput</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata> PollOnceUpdateApplicationStreamInput(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApplicationStreamInputOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateApplicationStreamInput</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata>> PollOnceUpdateApplicationStreamInputAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApplicationStreamInputOperationsClient, callSettings);

        /// <summary>
        /// Update target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deployed. For
        /// CreateOrUpdate behavior, set allow_missing to true.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata> UpdateApplicationStreamInput(string name, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationStreamInput(new UpdateApplicationStreamInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Update target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deployed. For
        /// CreateOrUpdate behavior, set allow_missing to true.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata>> UpdateApplicationStreamInputAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationStreamInputAsync(new UpdateApplicationStreamInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Update target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deployed. For
        /// CreateOrUpdate behavior, set allow_missing to true.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata>> UpdateApplicationStreamInputAsync(string name, st::CancellationToken cancellationToken) =>
            UpdateApplicationStreamInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deployed. For
        /// CreateOrUpdate behavior, set allow_missing to true.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata> UpdateApplicationStreamInput(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationStreamInput(new UpdateApplicationStreamInputRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Update target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deployed. For
        /// CreateOrUpdate behavior, set allow_missing to true.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata>> UpdateApplicationStreamInputAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationStreamInputAsync(new UpdateApplicationStreamInputRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Update target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deployed. For
        /// CreateOrUpdate behavior, set allow_missing to true.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata>> UpdateApplicationStreamInputAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            UpdateApplicationStreamInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Instance.
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
        /// Gets details of a single Instance.
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
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Instance.
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
        /// Gets details of a single Instance.
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
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CreateApplicationInstancesResponse, OperationMetadata> CreateApplicationInstances(CreateApplicationInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CreateApplicationInstancesResponse, OperationMetadata>> CreateApplicationInstancesAsync(CreateApplicationInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CreateApplicationInstancesResponse, OperationMetadata>> CreateApplicationInstancesAsync(CreateApplicationInstancesRequest request, st::CancellationToken cancellationToken) =>
            CreateApplicationInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateApplicationInstances</c>.</summary>
        public virtual lro::OperationsClient CreateApplicationInstancesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateApplicationInstances</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CreateApplicationInstancesResponse, OperationMetadata> PollOnceCreateApplicationInstances(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CreateApplicationInstancesResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApplicationInstancesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateApplicationInstances</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CreateApplicationInstancesResponse, OperationMetadata>> PollOnceCreateApplicationInstancesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CreateApplicationInstancesResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApplicationInstancesOperationsClient, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CreateApplicationInstancesResponse, OperationMetadata> CreateApplicationInstances(string name, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationInstances(new CreateApplicationInstancesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CreateApplicationInstancesResponse, OperationMetadata>> CreateApplicationInstancesAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationInstancesAsync(new CreateApplicationInstancesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CreateApplicationInstancesResponse, OperationMetadata>> CreateApplicationInstancesAsync(string name, st::CancellationToken cancellationToken) =>
            CreateApplicationInstancesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CreateApplicationInstancesResponse, OperationMetadata> CreateApplicationInstances(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationInstances(new CreateApplicationInstancesRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CreateApplicationInstancesResponse, OperationMetadata>> CreateApplicationInstancesAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationInstancesAsync(new CreateApplicationInstancesRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CreateApplicationInstancesResponse, OperationMetadata>> CreateApplicationInstancesAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            CreateApplicationInstancesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> DeleteApplicationInstances(DeleteApplicationInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DeleteApplicationInstancesAsync(DeleteApplicationInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DeleteApplicationInstancesAsync(DeleteApplicationInstancesRequest request, st::CancellationToken cancellationToken) =>
            DeleteApplicationInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteApplicationInstances</c>.</summary>
        public virtual lro::OperationsClient DeleteApplicationInstancesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteApplicationInstances</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceDeleteApplicationInstances(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteApplicationInstancesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteApplicationInstances</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceDeleteApplicationInstancesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteApplicationInstancesOperationsClient, callSettings);

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> DeleteApplicationInstances(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationInstances(new DeleteApplicationInstancesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DeleteApplicationInstancesAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationInstancesAsync(new DeleteApplicationInstancesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DeleteApplicationInstancesAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApplicationInstancesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> DeleteApplicationInstances(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationInstances(new DeleteApplicationInstancesRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DeleteApplicationInstancesAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationInstancesAsync(new DeleteApplicationInstancesRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DeleteApplicationInstancesAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            DeleteApplicationInstancesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata> UpdateApplicationInstances(UpdateApplicationInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata>> UpdateApplicationInstancesAsync(UpdateApplicationInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata>> UpdateApplicationInstancesAsync(UpdateApplicationInstancesRequest request, st::CancellationToken cancellationToken) =>
            UpdateApplicationInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateApplicationInstances</c>.</summary>
        public virtual lro::OperationsClient UpdateApplicationInstancesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateApplicationInstances</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata> PollOnceUpdateApplicationInstances(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApplicationInstancesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateApplicationInstances</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata>> PollOnceUpdateApplicationInstancesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApplicationInstancesOperationsClient, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="applicationInstances">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata> UpdateApplicationInstances(string name, scg::IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance> applicationInstances, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationInstances(new UpdateApplicationInstancesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ApplicationInstances =
                {
                    applicationInstances ?? linq::Enumerable.Empty<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="applicationInstances">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata>> UpdateApplicationInstancesAsync(string name, scg::IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance> applicationInstances, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationInstancesAsync(new UpdateApplicationInstancesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ApplicationInstances =
                {
                    applicationInstances ?? linq::Enumerable.Empty<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="applicationInstances">
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata>> UpdateApplicationInstancesAsync(string name, scg::IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance> applicationInstances, st::CancellationToken cancellationToken) =>
            UpdateApplicationInstancesAsync(name, applicationInstances, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="applicationInstances">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata> UpdateApplicationInstances(ApplicationName name, scg::IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance> applicationInstances, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationInstances(new UpdateApplicationInstancesRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ApplicationInstances =
                {
                    applicationInstances ?? linq::Enumerable.Empty<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="applicationInstances">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata>> UpdateApplicationInstancesAsync(ApplicationName name, scg::IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance> applicationInstances, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationInstancesAsync(new UpdateApplicationInstancesRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ApplicationInstances =
                {
                    applicationInstances ?? linq::Enumerable.Empty<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="name">
        /// Required. the name of the application to retrieve.
        /// Format:
        /// "projects/{project}/locations/{location}/applications/{application}"
        /// </param>
        /// <param name="applicationInstances">
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata>> UpdateApplicationInstancesAsync(ApplicationName name, scg::IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance> applicationInstances, st::CancellationToken cancellationToken) =>
            UpdateApplicationInstancesAsync(name, applicationInstances, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Drafts in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Draft"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDraftsResponse, Draft> ListDrafts(ListDraftsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Drafts in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Draft"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDraftsResponse, Draft> ListDraftsAsync(ListDraftsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Drafts in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDraftsRequest.
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
        /// <returns>A pageable sequence of <see cref="Draft"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDraftsResponse, Draft> ListDrafts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDraftsRequest request = new ListDraftsRequest
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
            return ListDrafts(request, callSettings);
        }

        /// <summary>
        /// Lists Drafts in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDraftsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Draft"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDraftsResponse, Draft> ListDraftsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDraftsRequest request = new ListDraftsRequest
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
            return ListDraftsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Drafts in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDraftsRequest.
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
        /// <returns>A pageable sequence of <see cref="Draft"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDraftsResponse, Draft> ListDrafts(ApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDraftsRequest request = new ListDraftsRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDrafts(request, callSettings);
        }

        /// <summary>
        /// Lists Drafts in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDraftsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Draft"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDraftsResponse, Draft> ListDraftsAsync(ApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDraftsRequest request = new ListDraftsRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDraftsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Draft GetDraft(GetDraftRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Draft> GetDraftAsync(GetDraftRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Draft> GetDraftAsync(GetDraftRequest request, st::CancellationToken cancellationToken) =>
            GetDraftAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Draft.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Draft GetDraft(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDraft(new GetDraftRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Draft.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Draft> GetDraftAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDraftAsync(new GetDraftRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Draft.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Draft> GetDraftAsync(string name, st::CancellationToken cancellationToken) =>
            GetDraftAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Draft.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Draft GetDraft(DraftName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDraft(new GetDraftRequest
            {
                DraftName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Draft.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Draft> GetDraftAsync(DraftName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDraftAsync(new GetDraftRequest
            {
                DraftName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Draft.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Draft> GetDraftAsync(DraftName name, st::CancellationToken cancellationToken) =>
            GetDraftAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Draft in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Draft, OperationMetadata> CreateDraft(CreateDraftRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Draft in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Draft, OperationMetadata>> CreateDraftAsync(CreateDraftRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Draft in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Draft, OperationMetadata>> CreateDraftAsync(CreateDraftRequest request, st::CancellationToken cancellationToken) =>
            CreateDraftAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDraft</c>.</summary>
        public virtual lro::OperationsClient CreateDraftOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDraft</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Draft, OperationMetadata> PollOnceCreateDraft(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Draft, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDraftOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDraft</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Draft, OperationMetadata>> PollOnceCreateDraftAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Draft, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDraftOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Draft in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="draft">
        /// Required. The resource being created.
        /// </param>
        /// <param name="draftId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Draft, OperationMetadata> CreateDraft(string parent, Draft draft, string draftId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDraft(new CreateDraftRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DraftId = gax::GaxPreconditions.CheckNotNullOrEmpty(draftId, nameof(draftId)),
                Draft = gax::GaxPreconditions.CheckNotNull(draft, nameof(draft)),
            }, callSettings);

        /// <summary>
        /// Creates a new Draft in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="draft">
        /// Required. The resource being created.
        /// </param>
        /// <param name="draftId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Draft, OperationMetadata>> CreateDraftAsync(string parent, Draft draft, string draftId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDraftAsync(new CreateDraftRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DraftId = gax::GaxPreconditions.CheckNotNullOrEmpty(draftId, nameof(draftId)),
                Draft = gax::GaxPreconditions.CheckNotNull(draft, nameof(draft)),
            }, callSettings);

        /// <summary>
        /// Creates a new Draft in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="draft">
        /// Required. The resource being created.
        /// </param>
        /// <param name="draftId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Draft, OperationMetadata>> CreateDraftAsync(string parent, Draft draft, string draftId, st::CancellationToken cancellationToken) =>
            CreateDraftAsync(parent, draft, draftId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Draft in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="draft">
        /// Required. The resource being created.
        /// </param>
        /// <param name="draftId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Draft, OperationMetadata> CreateDraft(ApplicationName parent, Draft draft, string draftId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDraft(new CreateDraftRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DraftId = gax::GaxPreconditions.CheckNotNullOrEmpty(draftId, nameof(draftId)),
                Draft = gax::GaxPreconditions.CheckNotNull(draft, nameof(draft)),
            }, callSettings);

        /// <summary>
        /// Creates a new Draft in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="draft">
        /// Required. The resource being created.
        /// </param>
        /// <param name="draftId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Draft, OperationMetadata>> CreateDraftAsync(ApplicationName parent, Draft draft, string draftId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDraftAsync(new CreateDraftRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DraftId = gax::GaxPreconditions.CheckNotNullOrEmpty(draftId, nameof(draftId)),
                Draft = gax::GaxPreconditions.CheckNotNull(draft, nameof(draft)),
            }, callSettings);

        /// <summary>
        /// Creates a new Draft in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="draft">
        /// Required. The resource being created.
        /// </param>
        /// <param name="draftId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Draft, OperationMetadata>> CreateDraftAsync(ApplicationName parent, Draft draft, string draftId, st::CancellationToken cancellationToken) =>
            CreateDraftAsync(parent, draft, draftId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Draft, OperationMetadata> UpdateDraft(UpdateDraftRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Draft, OperationMetadata>> UpdateDraftAsync(UpdateDraftRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Draft, OperationMetadata>> UpdateDraftAsync(UpdateDraftRequest request, st::CancellationToken cancellationToken) =>
            UpdateDraftAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDraft</c>.</summary>
        public virtual lro::OperationsClient UpdateDraftOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDraft</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Draft, OperationMetadata> PollOnceUpdateDraft(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Draft, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDraftOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDraft</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Draft, OperationMetadata>> PollOnceUpdateDraftAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Draft, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDraftOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Draft.
        /// </summary>
        /// <param name="draft">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Draft resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Draft, OperationMetadata> UpdateDraft(Draft draft, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDraft(new UpdateDraftRequest
            {
                UpdateMask = updateMask,
                Draft = gax::GaxPreconditions.CheckNotNull(draft, nameof(draft)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Draft.
        /// </summary>
        /// <param name="draft">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Draft resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Draft, OperationMetadata>> UpdateDraftAsync(Draft draft, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDraftAsync(new UpdateDraftRequest
            {
                UpdateMask = updateMask,
                Draft = gax::GaxPreconditions.CheckNotNull(draft, nameof(draft)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Draft.
        /// </summary>
        /// <param name="draft">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Draft resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Draft, OperationMetadata>> UpdateDraftAsync(Draft draft, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDraftAsync(draft, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDraft(DeleteDraftRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDraftAsync(DeleteDraftRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDraftAsync(DeleteDraftRequest request, st::CancellationToken cancellationToken) =>
            DeleteDraftAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDraft</c>.</summary>
        public virtual lro::OperationsClient DeleteDraftOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDraft</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDraft(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDraftOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDraft</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDraftAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDraftOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Draft.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDraft(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDraft(new DeleteDraftRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Draft.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDraftAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDraftAsync(new DeleteDraftRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Draft.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDraftAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDraftAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Draft.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDraft(DraftName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDraft(new DeleteDraftRequest
            {
                DraftName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Draft.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDraftAsync(DraftName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDraftAsync(new DeleteDraftRequest
            {
                DraftName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Draft.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDraftAsync(DraftName name, st::CancellationToken cancellationToken) =>
            DeleteDraftAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Processors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorsResponse, Processor> ListProcessors(ListProcessorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Processors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorsResponse, Processor> ListProcessorsAsync(ListProcessorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Processors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProcessorsRequest.
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
        /// <returns>A pageable sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorsResponse, Processor> ListProcessors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorsRequest request = new ListProcessorsRequest
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
            return ListProcessors(request, callSettings);
        }

        /// <summary>
        /// Lists Processors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProcessorsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorsResponse, Processor> ListProcessorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorsRequest request = new ListProcessorsRequest
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
            return ListProcessorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Processors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProcessorsRequest.
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
        /// <returns>A pageable sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorsResponse, Processor> ListProcessors(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorsRequest request = new ListProcessorsRequest
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
            return ListProcessors(request, callSettings);
        }

        /// <summary>
        /// Lists Processors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProcessorsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorsResponse, Processor> ListProcessorsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorsRequest request = new ListProcessorsRequest
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
            return ListProcessorsAsync(request, callSettings);
        }

        /// <summary>
        /// ListPrebuiltProcessors is a custom pass-through verb that Lists Prebuilt
        /// Processors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListPrebuiltProcessorsResponse ListPrebuiltProcessors(ListPrebuiltProcessorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ListPrebuiltProcessors is a custom pass-through verb that Lists Prebuilt
        /// Processors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPrebuiltProcessorsResponse> ListPrebuiltProcessorsAsync(ListPrebuiltProcessorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ListPrebuiltProcessors is a custom pass-through verb that Lists Prebuilt
        /// Processors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPrebuiltProcessorsResponse> ListPrebuiltProcessorsAsync(ListPrebuiltProcessorsRequest request, st::CancellationToken cancellationToken) =>
            ListPrebuiltProcessorsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// ListPrebuiltProcessors is a custom pass-through verb that Lists Prebuilt
        /// Processors.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent path.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListPrebuiltProcessorsResponse ListPrebuiltProcessors(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListPrebuiltProcessors(new ListPrebuiltProcessorsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// ListPrebuiltProcessors is a custom pass-through verb that Lists Prebuilt
        /// Processors.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent path.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPrebuiltProcessorsResponse> ListPrebuiltProcessorsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListPrebuiltProcessorsAsync(new ListPrebuiltProcessorsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// ListPrebuiltProcessors is a custom pass-through verb that Lists Prebuilt
        /// Processors.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent path.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPrebuiltProcessorsResponse> ListPrebuiltProcessorsAsync(string parent, st::CancellationToken cancellationToken) =>
            ListPrebuiltProcessorsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// ListPrebuiltProcessors is a custom pass-through verb that Lists Prebuilt
        /// Processors.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent path.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListPrebuiltProcessorsResponse ListPrebuiltProcessors(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListPrebuiltProcessors(new ListPrebuiltProcessorsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// ListPrebuiltProcessors is a custom pass-through verb that Lists Prebuilt
        /// Processors.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent path.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPrebuiltProcessorsResponse> ListPrebuiltProcessorsAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListPrebuiltProcessorsAsync(new ListPrebuiltProcessorsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// ListPrebuiltProcessors is a custom pass-through verb that Lists Prebuilt
        /// Processors.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent path.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPrebuiltProcessorsResponse> ListPrebuiltProcessorsAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            ListPrebuiltProcessorsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Processor GetProcessor(GetProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> GetProcessorAsync(GetProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> GetProcessorAsync(GetProcessorRequest request, st::CancellationToken cancellationToken) =>
            GetProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Processor.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Processor GetProcessor(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessor(new GetProcessorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Processor.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> GetProcessorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessorAsync(new GetProcessorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Processor.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> GetProcessorAsync(string name, st::CancellationToken cancellationToken) =>
            GetProcessorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Processor.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Processor GetProcessor(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessor(new GetProcessorRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Processor.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> GetProcessorAsync(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessorAsync(new GetProcessorRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Processor.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> GetProcessorAsync(ProcessorName name, st::CancellationToken cancellationToken) =>
            GetProcessorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Processor in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Processor, OperationMetadata> CreateProcessor(CreateProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Processor in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Processor, OperationMetadata>> CreateProcessorAsync(CreateProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Processor in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Processor, OperationMetadata>> CreateProcessorAsync(CreateProcessorRequest request, st::CancellationToken cancellationToken) =>
            CreateProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateProcessor</c>.</summary>
        public virtual lro::OperationsClient CreateProcessorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Processor, OperationMetadata> PollOnceCreateProcessor(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Processor, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateProcessorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Processor, OperationMetadata>> PollOnceCreateProcessorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Processor, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateProcessorOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Processor in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="processor">
        /// Required. The resource being created.
        /// </param>
        /// <param name="processorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Processor, OperationMetadata> CreateProcessor(string parent, Processor processor, string processorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessor(new CreateProcessorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ProcessorId = gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a new Processor in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="processor">
        /// Required. The resource being created.
        /// </param>
        /// <param name="processorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Processor, OperationMetadata>> CreateProcessorAsync(string parent, Processor processor, string processorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessorAsync(new CreateProcessorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ProcessorId = gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a new Processor in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="processor">
        /// Required. The resource being created.
        /// </param>
        /// <param name="processorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Processor, OperationMetadata>> CreateProcessorAsync(string parent, Processor processor, string processorId, st::CancellationToken cancellationToken) =>
            CreateProcessorAsync(parent, processor, processorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Processor in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="processor">
        /// Required. The resource being created.
        /// </param>
        /// <param name="processorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Processor, OperationMetadata> CreateProcessor(gagr::LocationName parent, Processor processor, string processorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessor(new CreateProcessorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProcessorId = gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a new Processor in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="processor">
        /// Required. The resource being created.
        /// </param>
        /// <param name="processorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Processor, OperationMetadata>> CreateProcessorAsync(gagr::LocationName parent, Processor processor, string processorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessorAsync(new CreateProcessorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProcessorId = gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a new Processor in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="processor">
        /// Required. The resource being created.
        /// </param>
        /// <param name="processorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Processor, OperationMetadata>> CreateProcessorAsync(gagr::LocationName parent, Processor processor, string processorId, st::CancellationToken cancellationToken) =>
            CreateProcessorAsync(parent, processor, processorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Processor, OperationMetadata> UpdateProcessor(UpdateProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Processor, OperationMetadata>> UpdateProcessorAsync(UpdateProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Processor, OperationMetadata>> UpdateProcessorAsync(UpdateProcessorRequest request, st::CancellationToken cancellationToken) =>
            UpdateProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateProcessor</c>.</summary>
        public virtual lro::OperationsClient UpdateProcessorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Processor, OperationMetadata> PollOnceUpdateProcessor(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Processor, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateProcessorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Processor, OperationMetadata>> PollOnceUpdateProcessorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Processor, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateProcessorOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Processor.
        /// </summary>
        /// <param name="processor">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Processor resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Processor, OperationMetadata> UpdateProcessor(Processor processor, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProcessor(new UpdateProcessorRequest
            {
                UpdateMask = updateMask,
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Processor.
        /// </summary>
        /// <param name="processor">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Processor resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Processor, OperationMetadata>> UpdateProcessorAsync(Processor processor, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProcessorAsync(new UpdateProcessorRequest
            {
                UpdateMask = updateMask,
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Processor.
        /// </summary>
        /// <param name="processor">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Processor resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Processor, OperationMetadata>> UpdateProcessorAsync(Processor processor, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProcessorAsync(processor, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteProcessor(DeleteProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessorAsync(DeleteProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessorAsync(DeleteProcessorRequest request, st::CancellationToken cancellationToken) =>
            DeleteProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteProcessor</c>.</summary>
        public virtual lro::OperationsClient DeleteProcessorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteProcessor(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProcessorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteProcessorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProcessorOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Processor.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteProcessor(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessor(new DeleteProcessorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Processor.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessorAsync(new DeleteProcessorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Processor.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProcessorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Processor.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteProcessor(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessor(new DeleteProcessorRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Processor.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessorAsync(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessorAsync(new DeleteProcessorRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Processor.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessorAsync(ProcessorName name, st::CancellationToken cancellationToken) =>
            DeleteProcessorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AppPlatform client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class AppPlatformClientImpl : AppPlatformClient
    {
        private readonly gaxgrpc::ApiCall<ListApplicationsRequest, ListApplicationsResponse> _callListApplications;

        private readonly gaxgrpc::ApiCall<GetApplicationRequest, Application> _callGetApplication;

        private readonly gaxgrpc::ApiCall<CreateApplicationRequest, lro::Operation> _callCreateApplication;

        private readonly gaxgrpc::ApiCall<UpdateApplicationRequest, lro::Operation> _callUpdateApplication;

        private readonly gaxgrpc::ApiCall<DeleteApplicationRequest, lro::Operation> _callDeleteApplication;

        private readonly gaxgrpc::ApiCall<DeployApplicationRequest, lro::Operation> _callDeployApplication;

        private readonly gaxgrpc::ApiCall<UndeployApplicationRequest, lro::Operation> _callUndeployApplication;

        private readonly gaxgrpc::ApiCall<AddApplicationStreamInputRequest, lro::Operation> _callAddApplicationStreamInput;

        private readonly gaxgrpc::ApiCall<RemoveApplicationStreamInputRequest, lro::Operation> _callRemoveApplicationStreamInput;

        private readonly gaxgrpc::ApiCall<UpdateApplicationStreamInputRequest, lro::Operation> _callUpdateApplicationStreamInput;

        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<CreateApplicationInstancesRequest, lro::Operation> _callCreateApplicationInstances;

        private readonly gaxgrpc::ApiCall<DeleteApplicationInstancesRequest, lro::Operation> _callDeleteApplicationInstances;

        private readonly gaxgrpc::ApiCall<UpdateApplicationInstancesRequest, lro::Operation> _callUpdateApplicationInstances;

        private readonly gaxgrpc::ApiCall<ListDraftsRequest, ListDraftsResponse> _callListDrafts;

        private readonly gaxgrpc::ApiCall<GetDraftRequest, Draft> _callGetDraft;

        private readonly gaxgrpc::ApiCall<CreateDraftRequest, lro::Operation> _callCreateDraft;

        private readonly gaxgrpc::ApiCall<UpdateDraftRequest, lro::Operation> _callUpdateDraft;

        private readonly gaxgrpc::ApiCall<DeleteDraftRequest, lro::Operation> _callDeleteDraft;

        private readonly gaxgrpc::ApiCall<ListProcessorsRequest, ListProcessorsResponse> _callListProcessors;

        private readonly gaxgrpc::ApiCall<ListPrebuiltProcessorsRequest, ListPrebuiltProcessorsResponse> _callListPrebuiltProcessors;

        private readonly gaxgrpc::ApiCall<GetProcessorRequest, Processor> _callGetProcessor;

        private readonly gaxgrpc::ApiCall<CreateProcessorRequest, lro::Operation> _callCreateProcessor;

        private readonly gaxgrpc::ApiCall<UpdateProcessorRequest, lro::Operation> _callUpdateProcessor;

        private readonly gaxgrpc::ApiCall<DeleteProcessorRequest, lro::Operation> _callDeleteProcessor;

        /// <summary>
        /// Constructs a client wrapper for the AppPlatform service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AppPlatformSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AppPlatformClientImpl(AppPlatform.AppPlatformClient grpcClient, AppPlatformSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AppPlatformSettings effectiveSettings = settings ?? AppPlatformSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateApplicationOperationsSettings, logger);
            UpdateApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateApplicationOperationsSettings, logger);
            DeleteApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteApplicationOperationsSettings, logger);
            DeployApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeployApplicationOperationsSettings, logger);
            UndeployApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeployApplicationOperationsSettings, logger);
            AddApplicationStreamInputOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AddApplicationStreamInputOperationsSettings, logger);
            RemoveApplicationStreamInputOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RemoveApplicationStreamInputOperationsSettings, logger);
            UpdateApplicationStreamInputOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateApplicationStreamInputOperationsSettings, logger);
            CreateApplicationInstancesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateApplicationInstancesOperationsSettings, logger);
            DeleteApplicationInstancesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteApplicationInstancesOperationsSettings, logger);
            UpdateApplicationInstancesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateApplicationInstancesOperationsSettings, logger);
            CreateDraftOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDraftOperationsSettings, logger);
            UpdateDraftOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDraftOperationsSettings, logger);
            DeleteDraftOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDraftOperationsSettings, logger);
            CreateProcessorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateProcessorOperationsSettings, logger);
            UpdateProcessorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateProcessorOperationsSettings, logger);
            DeleteProcessorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteProcessorOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListApplications = clientHelper.BuildApiCall<ListApplicationsRequest, ListApplicationsResponse>("ListApplications", grpcClient.ListApplicationsAsync, grpcClient.ListApplications, effectiveSettings.ListApplicationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApplications);
            Modify_ListApplicationsApiCall(ref _callListApplications);
            _callGetApplication = clientHelper.BuildApiCall<GetApplicationRequest, Application>("GetApplication", grpcClient.GetApplicationAsync, grpcClient.GetApplication, effectiveSettings.GetApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApplication);
            Modify_GetApplicationApiCall(ref _callGetApplication);
            _callCreateApplication = clientHelper.BuildApiCall<CreateApplicationRequest, lro::Operation>("CreateApplication", grpcClient.CreateApplicationAsync, grpcClient.CreateApplication, effectiveSettings.CreateApplicationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApplication);
            Modify_CreateApplicationApiCall(ref _callCreateApplication);
            _callUpdateApplication = clientHelper.BuildApiCall<UpdateApplicationRequest, lro::Operation>("UpdateApplication", grpcClient.UpdateApplicationAsync, grpcClient.UpdateApplication, effectiveSettings.UpdateApplicationSettings).WithGoogleRequestParam("application.name", request => request.Application?.Name);
            Modify_ApiCall(ref _callUpdateApplication);
            Modify_UpdateApplicationApiCall(ref _callUpdateApplication);
            _callDeleteApplication = clientHelper.BuildApiCall<DeleteApplicationRequest, lro::Operation>("DeleteApplication", grpcClient.DeleteApplicationAsync, grpcClient.DeleteApplication, effectiveSettings.DeleteApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApplication);
            Modify_DeleteApplicationApiCall(ref _callDeleteApplication);
            _callDeployApplication = clientHelper.BuildApiCall<DeployApplicationRequest, lro::Operation>("DeployApplication", grpcClient.DeployApplicationAsync, grpcClient.DeployApplication, effectiveSettings.DeployApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeployApplication);
            Modify_DeployApplicationApiCall(ref _callDeployApplication);
            _callUndeployApplication = clientHelper.BuildApiCall<UndeployApplicationRequest, lro::Operation>("UndeployApplication", grpcClient.UndeployApplicationAsync, grpcClient.UndeployApplication, effectiveSettings.UndeployApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeployApplication);
            Modify_UndeployApplicationApiCall(ref _callUndeployApplication);
            _callAddApplicationStreamInput = clientHelper.BuildApiCall<AddApplicationStreamInputRequest, lro::Operation>("AddApplicationStreamInput", grpcClient.AddApplicationStreamInputAsync, grpcClient.AddApplicationStreamInput, effectiveSettings.AddApplicationStreamInputSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAddApplicationStreamInput);
            Modify_AddApplicationStreamInputApiCall(ref _callAddApplicationStreamInput);
            _callRemoveApplicationStreamInput = clientHelper.BuildApiCall<RemoveApplicationStreamInputRequest, lro::Operation>("RemoveApplicationStreamInput", grpcClient.RemoveApplicationStreamInputAsync, grpcClient.RemoveApplicationStreamInput, effectiveSettings.RemoveApplicationStreamInputSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRemoveApplicationStreamInput);
            Modify_RemoveApplicationStreamInputApiCall(ref _callRemoveApplicationStreamInput);
            _callUpdateApplicationStreamInput = clientHelper.BuildApiCall<UpdateApplicationStreamInputRequest, lro::Operation>("UpdateApplicationStreamInput", grpcClient.UpdateApplicationStreamInputAsync, grpcClient.UpdateApplicationStreamInput, effectiveSettings.UpdateApplicationStreamInputSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateApplicationStreamInput);
            Modify_UpdateApplicationStreamInputApiCall(ref _callUpdateApplicationStreamInput);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("GetInstance", grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callCreateApplicationInstances = clientHelper.BuildApiCall<CreateApplicationInstancesRequest, lro::Operation>("CreateApplicationInstances", grpcClient.CreateApplicationInstancesAsync, grpcClient.CreateApplicationInstances, effectiveSettings.CreateApplicationInstancesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateApplicationInstances);
            Modify_CreateApplicationInstancesApiCall(ref _callCreateApplicationInstances);
            _callDeleteApplicationInstances = clientHelper.BuildApiCall<DeleteApplicationInstancesRequest, lro::Operation>("DeleteApplicationInstances", grpcClient.DeleteApplicationInstancesAsync, grpcClient.DeleteApplicationInstances, effectiveSettings.DeleteApplicationInstancesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApplicationInstances);
            Modify_DeleteApplicationInstancesApiCall(ref _callDeleteApplicationInstances);
            _callUpdateApplicationInstances = clientHelper.BuildApiCall<UpdateApplicationInstancesRequest, lro::Operation>("UpdateApplicationInstances", grpcClient.UpdateApplicationInstancesAsync, grpcClient.UpdateApplicationInstances, effectiveSettings.UpdateApplicationInstancesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateApplicationInstances);
            Modify_UpdateApplicationInstancesApiCall(ref _callUpdateApplicationInstances);
            _callListDrafts = clientHelper.BuildApiCall<ListDraftsRequest, ListDraftsResponse>("ListDrafts", grpcClient.ListDraftsAsync, grpcClient.ListDrafts, effectiveSettings.ListDraftsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDrafts);
            Modify_ListDraftsApiCall(ref _callListDrafts);
            _callGetDraft = clientHelper.BuildApiCall<GetDraftRequest, Draft>("GetDraft", grpcClient.GetDraftAsync, grpcClient.GetDraft, effectiveSettings.GetDraftSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDraft);
            Modify_GetDraftApiCall(ref _callGetDraft);
            _callCreateDraft = clientHelper.BuildApiCall<CreateDraftRequest, lro::Operation>("CreateDraft", grpcClient.CreateDraftAsync, grpcClient.CreateDraft, effectiveSettings.CreateDraftSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDraft);
            Modify_CreateDraftApiCall(ref _callCreateDraft);
            _callUpdateDraft = clientHelper.BuildApiCall<UpdateDraftRequest, lro::Operation>("UpdateDraft", grpcClient.UpdateDraftAsync, grpcClient.UpdateDraft, effectiveSettings.UpdateDraftSettings).WithGoogleRequestParam("draft.name", request => request.Draft?.Name);
            Modify_ApiCall(ref _callUpdateDraft);
            Modify_UpdateDraftApiCall(ref _callUpdateDraft);
            _callDeleteDraft = clientHelper.BuildApiCall<DeleteDraftRequest, lro::Operation>("DeleteDraft", grpcClient.DeleteDraftAsync, grpcClient.DeleteDraft, effectiveSettings.DeleteDraftSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDraft);
            Modify_DeleteDraftApiCall(ref _callDeleteDraft);
            _callListProcessors = clientHelper.BuildApiCall<ListProcessorsRequest, ListProcessorsResponse>("ListProcessors", grpcClient.ListProcessorsAsync, grpcClient.ListProcessors, effectiveSettings.ListProcessorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProcessors);
            Modify_ListProcessorsApiCall(ref _callListProcessors);
            _callListPrebuiltProcessors = clientHelper.BuildApiCall<ListPrebuiltProcessorsRequest, ListPrebuiltProcessorsResponse>("ListPrebuiltProcessors", grpcClient.ListPrebuiltProcessorsAsync, grpcClient.ListPrebuiltProcessors, effectiveSettings.ListPrebuiltProcessorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPrebuiltProcessors);
            Modify_ListPrebuiltProcessorsApiCall(ref _callListPrebuiltProcessors);
            _callGetProcessor = clientHelper.BuildApiCall<GetProcessorRequest, Processor>("GetProcessor", grpcClient.GetProcessorAsync, grpcClient.GetProcessor, effectiveSettings.GetProcessorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProcessor);
            Modify_GetProcessorApiCall(ref _callGetProcessor);
            _callCreateProcessor = clientHelper.BuildApiCall<CreateProcessorRequest, lro::Operation>("CreateProcessor", grpcClient.CreateProcessorAsync, grpcClient.CreateProcessor, effectiveSettings.CreateProcessorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProcessor);
            Modify_CreateProcessorApiCall(ref _callCreateProcessor);
            _callUpdateProcessor = clientHelper.BuildApiCall<UpdateProcessorRequest, lro::Operation>("UpdateProcessor", grpcClient.UpdateProcessorAsync, grpcClient.UpdateProcessor, effectiveSettings.UpdateProcessorSettings).WithGoogleRequestParam("processor.name", request => request.Processor?.Name);
            Modify_ApiCall(ref _callUpdateProcessor);
            Modify_UpdateProcessorApiCall(ref _callUpdateProcessor);
            _callDeleteProcessor = clientHelper.BuildApiCall<DeleteProcessorRequest, lro::Operation>("DeleteProcessor", grpcClient.DeleteProcessorAsync, grpcClient.DeleteProcessor, effectiveSettings.DeleteProcessorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProcessor);
            Modify_DeleteProcessorApiCall(ref _callDeleteProcessor);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListApplicationsApiCall(ref gaxgrpc::ApiCall<ListApplicationsRequest, ListApplicationsResponse> call);

        partial void Modify_GetApplicationApiCall(ref gaxgrpc::ApiCall<GetApplicationRequest, Application> call);

        partial void Modify_CreateApplicationApiCall(ref gaxgrpc::ApiCall<CreateApplicationRequest, lro::Operation> call);

        partial void Modify_UpdateApplicationApiCall(ref gaxgrpc::ApiCall<UpdateApplicationRequest, lro::Operation> call);

        partial void Modify_DeleteApplicationApiCall(ref gaxgrpc::ApiCall<DeleteApplicationRequest, lro::Operation> call);

        partial void Modify_DeployApplicationApiCall(ref gaxgrpc::ApiCall<DeployApplicationRequest, lro::Operation> call);

        partial void Modify_UndeployApplicationApiCall(ref gaxgrpc::ApiCall<UndeployApplicationRequest, lro::Operation> call);

        partial void Modify_AddApplicationStreamInputApiCall(ref gaxgrpc::ApiCall<AddApplicationStreamInputRequest, lro::Operation> call);

        partial void Modify_RemoveApplicationStreamInputApiCall(ref gaxgrpc::ApiCall<RemoveApplicationStreamInputRequest, lro::Operation> call);

        partial void Modify_UpdateApplicationStreamInputApiCall(ref gaxgrpc::ApiCall<UpdateApplicationStreamInputRequest, lro::Operation> call);

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_CreateApplicationInstancesApiCall(ref gaxgrpc::ApiCall<CreateApplicationInstancesRequest, lro::Operation> call);

        partial void Modify_DeleteApplicationInstancesApiCall(ref gaxgrpc::ApiCall<DeleteApplicationInstancesRequest, lro::Operation> call);

        partial void Modify_UpdateApplicationInstancesApiCall(ref gaxgrpc::ApiCall<UpdateApplicationInstancesRequest, lro::Operation> call);

        partial void Modify_ListDraftsApiCall(ref gaxgrpc::ApiCall<ListDraftsRequest, ListDraftsResponse> call);

        partial void Modify_GetDraftApiCall(ref gaxgrpc::ApiCall<GetDraftRequest, Draft> call);

        partial void Modify_CreateDraftApiCall(ref gaxgrpc::ApiCall<CreateDraftRequest, lro::Operation> call);

        partial void Modify_UpdateDraftApiCall(ref gaxgrpc::ApiCall<UpdateDraftRequest, lro::Operation> call);

        partial void Modify_DeleteDraftApiCall(ref gaxgrpc::ApiCall<DeleteDraftRequest, lro::Operation> call);

        partial void Modify_ListProcessorsApiCall(ref gaxgrpc::ApiCall<ListProcessorsRequest, ListProcessorsResponse> call);

        partial void Modify_ListPrebuiltProcessorsApiCall(ref gaxgrpc::ApiCall<ListPrebuiltProcessorsRequest, ListPrebuiltProcessorsResponse> call);

        partial void Modify_GetProcessorApiCall(ref gaxgrpc::ApiCall<GetProcessorRequest, Processor> call);

        partial void Modify_CreateProcessorApiCall(ref gaxgrpc::ApiCall<CreateProcessorRequest, lro::Operation> call);

        partial void Modify_UpdateProcessorApiCall(ref gaxgrpc::ApiCall<UpdateProcessorRequest, lro::Operation> call);

        partial void Modify_DeleteProcessorApiCall(ref gaxgrpc::ApiCall<DeleteProcessorRequest, lro::Operation> call);

        partial void OnConstruction(AppPlatform.AppPlatformClient grpcClient, AppPlatformSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AppPlatform client</summary>
        public override AppPlatform.AppPlatformClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListApplicationsRequest(ref ListApplicationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApplicationRequest(ref GetApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateApplicationRequest(ref CreateApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApplicationRequest(ref UpdateApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApplicationRequest(ref DeleteApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeployApplicationRequest(ref DeployApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeployApplicationRequest(ref UndeployApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddApplicationStreamInputRequest(ref AddApplicationStreamInputRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveApplicationStreamInputRequest(ref RemoveApplicationStreamInputRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApplicationStreamInputRequest(ref UpdateApplicationStreamInputRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateApplicationInstancesRequest(ref CreateApplicationInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApplicationInstancesRequest(ref DeleteApplicationInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApplicationInstancesRequest(ref UpdateApplicationInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDraftsRequest(ref ListDraftsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDraftRequest(ref GetDraftRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDraftRequest(ref CreateDraftRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDraftRequest(ref UpdateDraftRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDraftRequest(ref DeleteDraftRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProcessorsRequest(ref ListProcessorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPrebuiltProcessorsRequest(ref ListPrebuiltProcessorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProcessorRequest(ref GetProcessorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateProcessorRequest(ref CreateProcessorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProcessorRequest(ref UpdateProcessorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProcessorRequest(ref DeleteProcessorRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Applications in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public override gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApplicationsRequest, ListApplicationsResponse, Application>(_callListApplications, request, callSettings);
        }

        /// <summary>
        /// Lists Applications in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApplicationsRequest, ListApplicationsResponse, Application>(_callListApplications, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Application GetApplication(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateApplication</c>.</summary>
        public override lro::OperationsClient CreateApplicationOperationsClient { get; }

        /// <summary>
        /// Creates a new Application in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Application, OperationMetadata> CreateApplication(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadata>(_callCreateApplication.Sync(request, callSettings), CreateApplicationOperationsClient);
        }

        /// <summary>
        /// Creates a new Application in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadata>(await _callCreateApplication.Async(request, callSettings).ConfigureAwait(false), CreateApplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateApplication</c>.</summary>
        public override lro::OperationsClient UpdateApplicationOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Application, OperationMetadata> UpdateApplication(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadata>(_callUpdateApplication.Sync(request, callSettings), UpdateApplicationOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Application, OperationMetadata>> UpdateApplicationAsync(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadata>(await _callUpdateApplication.Async(request, callSettings).ConfigureAwait(false), UpdateApplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteApplication</c>.</summary>
        public override lro::OperationsClient DeleteApplicationOperationsClient { get; }

        /// <summary>
        /// Deletes a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteApplication(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteApplication.Sync(request, callSettings), DeleteApplicationOperationsClient);
        }

        /// <summary>
        /// Deletes a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteApplication.Async(request, callSettings).ConfigureAwait(false), DeleteApplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeployApplication</c>.</summary>
        public override lro::OperationsClient DeployApplicationOperationsClient { get; }

        /// <summary>
        /// Deploys a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeployApplicationResponse, OperationMetadata> DeployApplication(DeployApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<DeployApplicationResponse, OperationMetadata>(_callDeployApplication.Sync(request, callSettings), DeployApplicationOperationsClient);
        }

        /// <summary>
        /// Deploys a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(DeployApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<DeployApplicationResponse, OperationMetadata>(await _callDeployApplication.Async(request, callSettings).ConfigureAwait(false), DeployApplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeployApplication</c>.</summary>
        public override lro::OperationsClient UndeployApplicationOperationsClient { get; }

        /// <summary>
        /// Undeploys a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UndeployApplicationResponse, OperationMetadata> UndeployApplication(UndeployApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployApplicationResponse, OperationMetadata>(_callUndeployApplication.Sync(request, callSettings), UndeployApplicationOperationsClient);
        }

        /// <summary>
        /// Undeploys a single Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UndeployApplicationResponse, OperationMetadata>> UndeployApplicationAsync(UndeployApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployApplicationResponse, OperationMetadata>(await _callUndeployApplication.Async(request, callSettings).ConfigureAwait(false), UndeployApplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AddApplicationStreamInput</c>.</summary>
        public override lro::OperationsClient AddApplicationStreamInputOperationsClient { get; }

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AddApplicationStreamInputResponse, OperationMetadata> AddApplicationStreamInput(AddApplicationStreamInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddApplicationStreamInputRequest(ref request, ref callSettings);
            return new lro::Operation<AddApplicationStreamInputResponse, OperationMetadata>(_callAddApplicationStreamInput.Sync(request, callSettings), AddApplicationStreamInputOperationsClient);
        }

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AddApplicationStreamInputResponse, OperationMetadata>> AddApplicationStreamInputAsync(AddApplicationStreamInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddApplicationStreamInputRequest(ref request, ref callSettings);
            return new lro::Operation<AddApplicationStreamInputResponse, OperationMetadata>(await _callAddApplicationStreamInput.Async(request, callSettings).ConfigureAwait(false), AddApplicationStreamInputOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveApplicationStreamInput</c>.</summary>
        public override lro::OperationsClient RemoveApplicationStreamInputOperationsClient { get; }

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata> RemoveApplicationStreamInput(RemoveApplicationStreamInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveApplicationStreamInputRequest(ref request, ref callSettings);
            return new lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata>(_callRemoveApplicationStreamInput.Sync(request, callSettings), RemoveApplicationStreamInputOperationsClient);
        }

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata>> RemoveApplicationStreamInputAsync(RemoveApplicationStreamInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveApplicationStreamInputRequest(ref request, ref callSettings);
            return new lro::Operation<RemoveApplicationStreamInputResponse, OperationMetadata>(await _callRemoveApplicationStreamInput.Async(request, callSettings).ConfigureAwait(false), RemoveApplicationStreamInputOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateApplicationStreamInput</c>.</summary>
        public override lro::OperationsClient UpdateApplicationStreamInputOperationsClient { get; }

        /// <summary>
        /// Update target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deployed. For
        /// CreateOrUpdate behavior, set allow_missing to true.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata> UpdateApplicationStreamInput(UpdateApplicationStreamInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationStreamInputRequest(ref request, ref callSettings);
            return new lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata>(_callUpdateApplicationStreamInput.Sync(request, callSettings), UpdateApplicationStreamInputOperationsClient);
        }

        /// <summary>
        /// Update target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deployed. For
        /// CreateOrUpdate behavior, set allow_missing to true.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata>> UpdateApplicationStreamInputAsync(UpdateApplicationStreamInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationStreamInputRequest(ref request, ref callSettings);
            return new lro::Operation<UpdateApplicationStreamInputResponse, OperationMetadata>(await _callUpdateApplicationStreamInput.Async(request, callSettings).ConfigureAwait(false), UpdateApplicationStreamInputOperationsClient);
        }

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
        /// Gets details of a single Instance.
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
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateApplicationInstances</c>.</summary>
        public override lro::OperationsClient CreateApplicationInstancesOperationsClient { get; }

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CreateApplicationInstancesResponse, OperationMetadata> CreateApplicationInstances(CreateApplicationInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationInstancesRequest(ref request, ref callSettings);
            return new lro::Operation<CreateApplicationInstancesResponse, OperationMetadata>(_callCreateApplicationInstances.Sync(request, callSettings), CreateApplicationInstancesOperationsClient);
        }

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CreateApplicationInstancesResponse, OperationMetadata>> CreateApplicationInstancesAsync(CreateApplicationInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationInstancesRequest(ref request, ref callSettings);
            return new lro::Operation<CreateApplicationInstancesResponse, OperationMetadata>(await _callCreateApplicationInstances.Async(request, callSettings).ConfigureAwait(false), CreateApplicationInstancesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteApplicationInstances</c>.</summary>
        public override lro::OperationsClient DeleteApplicationInstancesOperationsClient { get; }

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> DeleteApplicationInstances(DeleteApplicationInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationInstancesRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callDeleteApplicationInstances.Sync(request, callSettings), DeleteApplicationInstancesOperationsClient);
        }

        /// <summary>
        /// Remove target stream input to the Application, if the Application is
        /// deployed, the corresponding instance based will be deleted. If the stream
        /// is not in the Application, the RPC will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> DeleteApplicationInstancesAsync(DeleteApplicationInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationInstancesRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callDeleteApplicationInstances.Async(request, callSettings).ConfigureAwait(false), DeleteApplicationInstancesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateApplicationInstances</c>.</summary>
        public override lro::OperationsClient UpdateApplicationInstancesOperationsClient { get; }

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata> UpdateApplicationInstances(UpdateApplicationInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationInstancesRequest(ref request, ref callSettings);
            return new lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata>(_callUpdateApplicationInstances.Sync(request, callSettings), UpdateApplicationInstancesOperationsClient);
        }

        /// <summary>
        /// Adds target stream input to the Application.
        /// If the Application is deployed, the corresponding new Application instance
        /// will be created. If the stream has already been in the Application, the RPC
        /// will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata>> UpdateApplicationInstancesAsync(UpdateApplicationInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationInstancesRequest(ref request, ref callSettings);
            return new lro::Operation<UpdateApplicationInstancesResponse, OperationMetadata>(await _callUpdateApplicationInstances.Async(request, callSettings).ConfigureAwait(false), UpdateApplicationInstancesOperationsClient);
        }

        /// <summary>
        /// Lists Drafts in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Draft"/> resources.</returns>
        public override gax::PagedEnumerable<ListDraftsResponse, Draft> ListDrafts(ListDraftsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDraftsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDraftsRequest, ListDraftsResponse, Draft>(_callListDrafts, request, callSettings);
        }

        /// <summary>
        /// Lists Drafts in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Draft"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDraftsResponse, Draft> ListDraftsAsync(ListDraftsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDraftsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDraftsRequest, ListDraftsResponse, Draft>(_callListDrafts, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Draft GetDraft(GetDraftRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDraftRequest(ref request, ref callSettings);
            return _callGetDraft.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Draft> GetDraftAsync(GetDraftRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDraftRequest(ref request, ref callSettings);
            return _callGetDraft.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDraft</c>.</summary>
        public override lro::OperationsClient CreateDraftOperationsClient { get; }

        /// <summary>
        /// Creates a new Draft in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Draft, OperationMetadata> CreateDraft(CreateDraftRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDraftRequest(ref request, ref callSettings);
            return new lro::Operation<Draft, OperationMetadata>(_callCreateDraft.Sync(request, callSettings), CreateDraftOperationsClient);
        }

        /// <summary>
        /// Creates a new Draft in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Draft, OperationMetadata>> CreateDraftAsync(CreateDraftRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDraftRequest(ref request, ref callSettings);
            return new lro::Operation<Draft, OperationMetadata>(await _callCreateDraft.Async(request, callSettings).ConfigureAwait(false), CreateDraftOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDraft</c>.</summary>
        public override lro::OperationsClient UpdateDraftOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Draft, OperationMetadata> UpdateDraft(UpdateDraftRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDraftRequest(ref request, ref callSettings);
            return new lro::Operation<Draft, OperationMetadata>(_callUpdateDraft.Sync(request, callSettings), UpdateDraftOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Draft, OperationMetadata>> UpdateDraftAsync(UpdateDraftRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDraftRequest(ref request, ref callSettings);
            return new lro::Operation<Draft, OperationMetadata>(await _callUpdateDraft.Async(request, callSettings).ConfigureAwait(false), UpdateDraftOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDraft</c>.</summary>
        public override lro::OperationsClient DeleteDraftOperationsClient { get; }

        /// <summary>
        /// Deletes a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDraft(DeleteDraftRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDraftRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDraft.Sync(request, callSettings), DeleteDraftOperationsClient);
        }

        /// <summary>
        /// Deletes a single Draft.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDraftAsync(DeleteDraftRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDraftRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDraft.Async(request, callSettings).ConfigureAwait(false), DeleteDraftOperationsClient);
        }

        /// <summary>
        /// Lists Processors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Processor"/> resources.</returns>
        public override gax::PagedEnumerable<ListProcessorsResponse, Processor> ListProcessors(ListProcessorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProcessorsRequest, ListProcessorsResponse, Processor>(_callListProcessors, request, callSettings);
        }

        /// <summary>
        /// Lists Processors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Processor"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProcessorsResponse, Processor> ListProcessorsAsync(ListProcessorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProcessorsRequest, ListProcessorsResponse, Processor>(_callListProcessors, request, callSettings);
        }

        /// <summary>
        /// ListPrebuiltProcessors is a custom pass-through verb that Lists Prebuilt
        /// Processors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListPrebuiltProcessorsResponse ListPrebuiltProcessors(ListPrebuiltProcessorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrebuiltProcessorsRequest(ref request, ref callSettings);
            return _callListPrebuiltProcessors.Sync(request, callSettings);
        }

        /// <summary>
        /// ListPrebuiltProcessors is a custom pass-through verb that Lists Prebuilt
        /// Processors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListPrebuiltProcessorsResponse> ListPrebuiltProcessorsAsync(ListPrebuiltProcessorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrebuiltProcessorsRequest(ref request, ref callSettings);
            return _callListPrebuiltProcessors.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Processor GetProcessor(GetProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProcessorRequest(ref request, ref callSettings);
            return _callGetProcessor.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Processor> GetProcessorAsync(GetProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProcessorRequest(ref request, ref callSettings);
            return _callGetProcessor.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateProcessor</c>.</summary>
        public override lro::OperationsClient CreateProcessorOperationsClient { get; }

        /// <summary>
        /// Creates a new Processor in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Processor, OperationMetadata> CreateProcessor(CreateProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<Processor, OperationMetadata>(_callCreateProcessor.Sync(request, callSettings), CreateProcessorOperationsClient);
        }

        /// <summary>
        /// Creates a new Processor in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Processor, OperationMetadata>> CreateProcessorAsync(CreateProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<Processor, OperationMetadata>(await _callCreateProcessor.Async(request, callSettings).ConfigureAwait(false), CreateProcessorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateProcessor</c>.</summary>
        public override lro::OperationsClient UpdateProcessorOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Processor, OperationMetadata> UpdateProcessor(UpdateProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<Processor, OperationMetadata>(_callUpdateProcessor.Sync(request, callSettings), UpdateProcessorOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Processor, OperationMetadata>> UpdateProcessorAsync(UpdateProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<Processor, OperationMetadata>(await _callUpdateProcessor.Async(request, callSettings).ConfigureAwait(false), UpdateProcessorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteProcessor</c>.</summary>
        public override lro::OperationsClient DeleteProcessorOperationsClient { get; }

        /// <summary>
        /// Deletes a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteProcessor(DeleteProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteProcessor.Sync(request, callSettings), DeleteProcessorOperationsClient);
        }

        /// <summary>
        /// Deletes a single Processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessorAsync(DeleteProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteProcessor.Async(request, callSettings).ConfigureAwait(false), DeleteProcessorOperationsClient);
        }
    }

    public partial class ListApplicationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDraftsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProcessorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApplicationsResponse : gaxgrpc::IPageResponse<Application>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Application> GetEnumerator() => Applications.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDraftsResponse : gaxgrpc::IPageResponse<Draft>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Draft> GetEnumerator() => Drafts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProcessorsResponse : gaxgrpc::IPageResponse<Processor>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Processor> GetEnumerator() => Processors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AppPlatform
    {
        public partial class AppPlatformClient
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

    public static partial class AppPlatform
    {
        public partial class AppPlatformClient
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
