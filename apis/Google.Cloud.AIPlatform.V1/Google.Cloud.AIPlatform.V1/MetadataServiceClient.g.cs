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

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="MetadataServiceClient"/> instances.</summary>
    public sealed partial class MetadataServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MetadataServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MetadataServiceSettings"/>.</returns>
        public static MetadataServiceSettings GetDefault() => new MetadataServiceSettings();

        /// <summary>Constructs a new <see cref="MetadataServiceSettings"/> object with default settings.</summary>
        public MetadataServiceSettings()
        {
        }

        private MetadataServiceSettings(MetadataServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateMetadataStoreSettings = existing.CreateMetadataStoreSettings;
            CreateMetadataStoreOperationsSettings = existing.CreateMetadataStoreOperationsSettings.Clone();
            GetMetadataStoreSettings = existing.GetMetadataStoreSettings;
            ListMetadataStoresSettings = existing.ListMetadataStoresSettings;
            DeleteMetadataStoreSettings = existing.DeleteMetadataStoreSettings;
            DeleteMetadataStoreOperationsSettings = existing.DeleteMetadataStoreOperationsSettings.Clone();
            CreateArtifactSettings = existing.CreateArtifactSettings;
            GetArtifactSettings = existing.GetArtifactSettings;
            ListArtifactsSettings = existing.ListArtifactsSettings;
            UpdateArtifactSettings = existing.UpdateArtifactSettings;
            DeleteArtifactSettings = existing.DeleteArtifactSettings;
            DeleteArtifactOperationsSettings = existing.DeleteArtifactOperationsSettings.Clone();
            PurgeArtifactsSettings = existing.PurgeArtifactsSettings;
            PurgeArtifactsOperationsSettings = existing.PurgeArtifactsOperationsSettings.Clone();
            CreateContextSettings = existing.CreateContextSettings;
            GetContextSettings = existing.GetContextSettings;
            ListContextsSettings = existing.ListContextsSettings;
            UpdateContextSettings = existing.UpdateContextSettings;
            DeleteContextSettings = existing.DeleteContextSettings;
            DeleteContextOperationsSettings = existing.DeleteContextOperationsSettings.Clone();
            PurgeContextsSettings = existing.PurgeContextsSettings;
            PurgeContextsOperationsSettings = existing.PurgeContextsOperationsSettings.Clone();
            AddContextArtifactsAndExecutionsSettings = existing.AddContextArtifactsAndExecutionsSettings;
            AddContextChildrenSettings = existing.AddContextChildrenSettings;
            RemoveContextChildrenSettings = existing.RemoveContextChildrenSettings;
            QueryContextLineageSubgraphSettings = existing.QueryContextLineageSubgraphSettings;
            CreateExecutionSettings = existing.CreateExecutionSettings;
            GetExecutionSettings = existing.GetExecutionSettings;
            ListExecutionsSettings = existing.ListExecutionsSettings;
            UpdateExecutionSettings = existing.UpdateExecutionSettings;
            DeleteExecutionSettings = existing.DeleteExecutionSettings;
            DeleteExecutionOperationsSettings = existing.DeleteExecutionOperationsSettings.Clone();
            PurgeExecutionsSettings = existing.PurgeExecutionsSettings;
            PurgeExecutionsOperationsSettings = existing.PurgeExecutionsOperationsSettings.Clone();
            AddExecutionEventsSettings = existing.AddExecutionEventsSettings;
            QueryExecutionInputsAndOutputsSettings = existing.QueryExecutionInputsAndOutputsSettings;
            CreateMetadataSchemaSettings = existing.CreateMetadataSchemaSettings;
            GetMetadataSchemaSettings = existing.GetMetadataSchemaSettings;
            ListMetadataSchemasSettings = existing.ListMetadataSchemasSettings;
            QueryArtifactLineageSubgraphSettings = existing.QueryArtifactLineageSubgraphSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(MetadataServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.CreateMetadataStore</c> and <c>MetadataServiceClient.CreateMetadataStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMetadataStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MetadataServiceClient.CreateMetadataStore</c> and
        /// <c>MetadataServiceClient.CreateMetadataStoreAsync</c>.
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
        public lro::OperationsSettings CreateMetadataStoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.GetMetadataStore</c> and <c>MetadataServiceClient.GetMetadataStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMetadataStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.ListMetadataStores</c> and <c>MetadataServiceClient.ListMetadataStoresAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMetadataStoresSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.DeleteMetadataStore</c> and <c>MetadataServiceClient.DeleteMetadataStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMetadataStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MetadataServiceClient.DeleteMetadataStore</c> and
        /// <c>MetadataServiceClient.DeleteMetadataStoreAsync</c>.
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
        public lro::OperationsSettings DeleteMetadataStoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.CreateArtifact</c> and <c>MetadataServiceClient.CreateArtifactAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateArtifactSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.GetArtifact</c> and <c>MetadataServiceClient.GetArtifactAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetArtifactSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.ListArtifacts</c> and <c>MetadataServiceClient.ListArtifactsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListArtifactsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.UpdateArtifact</c> and <c>MetadataServiceClient.UpdateArtifactAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateArtifactSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.DeleteArtifact</c> and <c>MetadataServiceClient.DeleteArtifactAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteArtifactSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MetadataServiceClient.DeleteArtifact</c> and
        /// <c>MetadataServiceClient.DeleteArtifactAsync</c>.
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
        public lro::OperationsSettings DeleteArtifactOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.PurgeArtifacts</c> and <c>MetadataServiceClient.PurgeArtifactsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PurgeArtifactsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MetadataServiceClient.PurgeArtifacts</c> and
        /// <c>MetadataServiceClient.PurgeArtifactsAsync</c>.
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
        public lro::OperationsSettings PurgeArtifactsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.CreateContext</c> and <c>MetadataServiceClient.CreateContextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateContextSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.GetContext</c> and <c>MetadataServiceClient.GetContextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetContextSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.ListContexts</c> and <c>MetadataServiceClient.ListContextsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListContextsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.UpdateContext</c> and <c>MetadataServiceClient.UpdateContextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateContextSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.DeleteContext</c> and <c>MetadataServiceClient.DeleteContextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteContextSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MetadataServiceClient.DeleteContext</c> and
        /// <c>MetadataServiceClient.DeleteContextAsync</c>.
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
        public lro::OperationsSettings DeleteContextOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.PurgeContexts</c> and <c>MetadataServiceClient.PurgeContextsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PurgeContextsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MetadataServiceClient.PurgeContexts</c> and
        /// <c>MetadataServiceClient.PurgeContextsAsync</c>.
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
        public lro::OperationsSettings PurgeContextsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.AddContextArtifactsAndExecutions</c> and
        /// <c>MetadataServiceClient.AddContextArtifactsAndExecutionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddContextArtifactsAndExecutionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.AddContextChildren</c> and <c>MetadataServiceClient.AddContextChildrenAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddContextChildrenSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.RemoveContextChildren</c> and <c>MetadataServiceClient.RemoveContextChildrenAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveContextChildrenSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.QueryContextLineageSubgraph</c> and
        /// <c>MetadataServiceClient.QueryContextLineageSubgraphAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryContextLineageSubgraphSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.CreateExecution</c> and <c>MetadataServiceClient.CreateExecutionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateExecutionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.GetExecution</c> and <c>MetadataServiceClient.GetExecutionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExecutionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.ListExecutions</c> and <c>MetadataServiceClient.ListExecutionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListExecutionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.UpdateExecution</c> and <c>MetadataServiceClient.UpdateExecutionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateExecutionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.DeleteExecution</c> and <c>MetadataServiceClient.DeleteExecutionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteExecutionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MetadataServiceClient.DeleteExecution</c> and
        /// <c>MetadataServiceClient.DeleteExecutionAsync</c>.
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
        public lro::OperationsSettings DeleteExecutionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.PurgeExecutions</c> and <c>MetadataServiceClient.PurgeExecutionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PurgeExecutionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MetadataServiceClient.PurgeExecutions</c> and
        /// <c>MetadataServiceClient.PurgeExecutionsAsync</c>.
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
        public lro::OperationsSettings PurgeExecutionsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.AddExecutionEvents</c> and <c>MetadataServiceClient.AddExecutionEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddExecutionEventsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.QueryExecutionInputsAndOutputs</c> and
        /// <c>MetadataServiceClient.QueryExecutionInputsAndOutputsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryExecutionInputsAndOutputsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.CreateMetadataSchema</c> and <c>MetadataServiceClient.CreateMetadataSchemaAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMetadataSchemaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.GetMetadataSchema</c> and <c>MetadataServiceClient.GetMetadataSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMetadataSchemaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.ListMetadataSchemas</c> and <c>MetadataServiceClient.ListMetadataSchemasAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMetadataSchemasSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.QueryArtifactLineageSubgraph</c> and
        /// <c>MetadataServiceClient.QueryArtifactLineageSubgraphAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryArtifactLineageSubgraphSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MetadataServiceSettings"/> object.</returns>
        public MetadataServiceSettings Clone() => new MetadataServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MetadataServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class MetadataServiceClientBuilder : gaxgrpc::ClientBuilderBase<MetadataServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MetadataServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MetadataServiceClientBuilder() : base(MetadataServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MetadataServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MetadataServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MetadataServiceClient Build()
        {
            MetadataServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MetadataServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MetadataServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MetadataServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MetadataServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MetadataServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MetadataServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MetadataServiceClient.ChannelPool;
    }

    /// <summary>MetadataService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for reading and writing metadata entries.
    /// </remarks>
    public abstract partial class MetadataServiceClient
    {
        /// <summary>
        /// The default endpoint for the MetadataService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default MetadataService scopes.</summary>
        /// <remarks>
        /// The default MetadataService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MetadataService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MetadataServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MetadataServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MetadataServiceClient"/>.</returns>
        public static stt::Task<MetadataServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MetadataServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MetadataServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MetadataServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MetadataServiceClient"/>.</returns>
        public static MetadataServiceClient Create() => new MetadataServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MetadataServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MetadataServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MetadataServiceClient"/>.</returns>
        internal static MetadataServiceClient Create(grpccore::CallInvoker callInvoker, MetadataServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MetadataService.MetadataServiceClient grpcClient = new MetadataService.MetadataServiceClient(callInvoker);
            return new MetadataServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MetadataService client</summary>
        public virtual MetadataService.MetadataServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Initializes a MetadataStore, including allocation of resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata> CreateMetadataStore(CreateMetadataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initializes a MetadataStore, including allocation of resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata>> CreateMetadataStoreAsync(CreateMetadataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initializes a MetadataStore, including allocation of resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata>> CreateMetadataStoreAsync(CreateMetadataStoreRequest request, st::CancellationToken cancellationToken) =>
            CreateMetadataStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMetadataStore</c>.</summary>
        public virtual lro::OperationsClient CreateMetadataStoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateMetadataStore</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata> PollOnceCreateMetadataStore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMetadataStoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMetadataStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata>> PollOnceCreateMetadataStoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMetadataStoreOperationsClient, callSettings);

        /// <summary>
        /// Initializes a MetadataStore, including allocation of resources.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location where the MetadataStore should
        /// be created.
        /// Format: `projects/{project}/locations/{location}/`
        /// </param>
        /// <param name="metadataStore">
        /// Required. The MetadataStore to create.
        /// </param>
        /// <param name="metadataStoreId">
        /// The {metadatastore} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// If not provided, the MetadataStore's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all MetadataStores in the parent Location.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting MetadataStore.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata> CreateMetadataStore(string parent, MetadataStore metadataStore, string metadataStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetadataStore(new CreateMetadataStoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MetadataStore = gax::GaxPreconditions.CheckNotNull(metadataStore, nameof(metadataStore)),
                MetadataStoreId = metadataStoreId ?? "",
            }, callSettings);

        /// <summary>
        /// Initializes a MetadataStore, including allocation of resources.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location where the MetadataStore should
        /// be created.
        /// Format: `projects/{project}/locations/{location}/`
        /// </param>
        /// <param name="metadataStore">
        /// Required. The MetadataStore to create.
        /// </param>
        /// <param name="metadataStoreId">
        /// The {metadatastore} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// If not provided, the MetadataStore's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all MetadataStores in the parent Location.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting MetadataStore.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata>> CreateMetadataStoreAsync(string parent, MetadataStore metadataStore, string metadataStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetadataStoreAsync(new CreateMetadataStoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MetadataStore = gax::GaxPreconditions.CheckNotNull(metadataStore, nameof(metadataStore)),
                MetadataStoreId = metadataStoreId ?? "",
            }, callSettings);

        /// <summary>
        /// Initializes a MetadataStore, including allocation of resources.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location where the MetadataStore should
        /// be created.
        /// Format: `projects/{project}/locations/{location}/`
        /// </param>
        /// <param name="metadataStore">
        /// Required. The MetadataStore to create.
        /// </param>
        /// <param name="metadataStoreId">
        /// The {metadatastore} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// If not provided, the MetadataStore's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all MetadataStores in the parent Location.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting MetadataStore.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata>> CreateMetadataStoreAsync(string parent, MetadataStore metadataStore, string metadataStoreId, st::CancellationToken cancellationToken) =>
            CreateMetadataStoreAsync(parent, metadataStore, metadataStoreId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initializes a MetadataStore, including allocation of resources.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location where the MetadataStore should
        /// be created.
        /// Format: `projects/{project}/locations/{location}/`
        /// </param>
        /// <param name="metadataStore">
        /// Required. The MetadataStore to create.
        /// </param>
        /// <param name="metadataStoreId">
        /// The {metadatastore} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// If not provided, the MetadataStore's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all MetadataStores in the parent Location.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting MetadataStore.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata> CreateMetadataStore(gagr::LocationName parent, MetadataStore metadataStore, string metadataStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetadataStore(new CreateMetadataStoreRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MetadataStore = gax::GaxPreconditions.CheckNotNull(metadataStore, nameof(metadataStore)),
                MetadataStoreId = metadataStoreId ?? "",
            }, callSettings);

        /// <summary>
        /// Initializes a MetadataStore, including allocation of resources.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location where the MetadataStore should
        /// be created.
        /// Format: `projects/{project}/locations/{location}/`
        /// </param>
        /// <param name="metadataStore">
        /// Required. The MetadataStore to create.
        /// </param>
        /// <param name="metadataStoreId">
        /// The {metadatastore} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// If not provided, the MetadataStore's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all MetadataStores in the parent Location.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting MetadataStore.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata>> CreateMetadataStoreAsync(gagr::LocationName parent, MetadataStore metadataStore, string metadataStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetadataStoreAsync(new CreateMetadataStoreRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MetadataStore = gax::GaxPreconditions.CheckNotNull(metadataStore, nameof(metadataStore)),
                MetadataStoreId = metadataStoreId ?? "",
            }, callSettings);

        /// <summary>
        /// Initializes a MetadataStore, including allocation of resources.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location where the MetadataStore should
        /// be created.
        /// Format: `projects/{project}/locations/{location}/`
        /// </param>
        /// <param name="metadataStore">
        /// Required. The MetadataStore to create.
        /// </param>
        /// <param name="metadataStoreId">
        /// The {metadatastore} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// If not provided, the MetadataStore's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all MetadataStores in the parent Location.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting MetadataStore.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata>> CreateMetadataStoreAsync(gagr::LocationName parent, MetadataStore metadataStore, string metadataStoreId, st::CancellationToken cancellationToken) =>
            CreateMetadataStoreAsync(parent, metadataStore, metadataStoreId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetadataStore GetMetadataStore(GetMetadataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a specific MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataStore> GetMetadataStoreAsync(GetMetadataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a specific MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataStore> GetMetadataStoreAsync(GetMetadataStoreRequest request, st::CancellationToken cancellationToken) =>
            GetMetadataStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific MetadataStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataStore to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetadataStore GetMetadataStore(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataStore(new GetMetadataStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific MetadataStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataStore to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataStore> GetMetadataStoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataStoreAsync(new GetMetadataStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific MetadataStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataStore to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataStore> GetMetadataStoreAsync(string name, st::CancellationToken cancellationToken) =>
            GetMetadataStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific MetadataStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataStore to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetadataStore GetMetadataStore(MetadataStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataStore(new GetMetadataStoreRequest
            {
                MetadataStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific MetadataStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataStore to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataStore> GetMetadataStoreAsync(MetadataStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataStoreAsync(new GetMetadataStoreRequest
            {
                MetadataStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific MetadataStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataStore to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataStore> GetMetadataStoreAsync(MetadataStoreName name, st::CancellationToken cancellationToken) =>
            GetMetadataStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists MetadataStores for a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MetadataStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetadataStoresResponse, MetadataStore> ListMetadataStores(ListMetadataStoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MetadataStores for a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MetadataStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetadataStoresResponse, MetadataStore> ListMetadataStoresAsync(ListMetadataStoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MetadataStores for a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Location whose MetadataStores should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="MetadataStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetadataStoresResponse, MetadataStore> ListMetadataStores(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMetadataStores(new ListMetadataStoresRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists MetadataStores for a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Location whose MetadataStores should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MetadataStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetadataStoresResponse, MetadataStore> ListMetadataStoresAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMetadataStoresAsync(new ListMetadataStoresRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists MetadataStores for a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Location whose MetadataStores should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="MetadataStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetadataStoresResponse, MetadataStore> ListMetadataStores(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMetadataStores(new ListMetadataStoresRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists MetadataStores for a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Location whose MetadataStores should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MetadataStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetadataStoresResponse, MetadataStore> ListMetadataStoresAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMetadataStoresAsync(new ListMetadataStoresRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a single MetadataStore and all its child resources (Artifacts,
        /// Executions, and Contexts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata> DeleteMetadataStore(DeleteMetadataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single MetadataStore and all its child resources (Artifacts,
        /// Executions, and Contexts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata>> DeleteMetadataStoreAsync(DeleteMetadataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single MetadataStore and all its child resources (Artifacts,
        /// Executions, and Contexts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata>> DeleteMetadataStoreAsync(DeleteMetadataStoreRequest request, st::CancellationToken cancellationToken) =>
            DeleteMetadataStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMetadataStore</c>.</summary>
        public virtual lro::OperationsClient DeleteMetadataStoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteMetadataStore</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata> PollOnceDeleteMetadataStore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMetadataStoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMetadataStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata>> PollOnceDeleteMetadataStoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMetadataStoreOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single MetadataStore and all its child resources (Artifacts,
        /// Executions, and Contexts).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataStore to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata> DeleteMetadataStore(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMetadataStore(new DeleteMetadataStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single MetadataStore and all its child resources (Artifacts,
        /// Executions, and Contexts).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataStore to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata>> DeleteMetadataStoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMetadataStoreAsync(new DeleteMetadataStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single MetadataStore and all its child resources (Artifacts,
        /// Executions, and Contexts).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataStore to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata>> DeleteMetadataStoreAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMetadataStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single MetadataStore and all its child resources (Artifacts,
        /// Executions, and Contexts).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataStore to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata> DeleteMetadataStore(MetadataStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMetadataStore(new DeleteMetadataStoreRequest
            {
                MetadataStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single MetadataStore and all its child resources (Artifacts,
        /// Executions, and Contexts).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataStore to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata>> DeleteMetadataStoreAsync(MetadataStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMetadataStoreAsync(new DeleteMetadataStoreRequest
            {
                MetadataStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single MetadataStore and all its child resources (Artifacts,
        /// Executions, and Contexts).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataStore to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata>> DeleteMetadataStoreAsync(MetadataStoreName name, st::CancellationToken cancellationToken) =>
            DeleteMetadataStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Artifact associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact CreateArtifact(CreateArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Artifact associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(CreateArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Artifact associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(CreateArtifactRequest request, st::CancellationToken cancellationToken) =>
            CreateArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Artifact associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Artifact should
        /// be created.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="artifact">
        /// Required. The Artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// The {artifact} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// If not provided, the Artifact's ID will be a UUID generated by the service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Artifacts in the parent MetadataStore. (Otherwise
        /// the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED if the
        /// caller can't view the preexisting Artifact.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact CreateArtifact(string parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifact(new CreateArtifactRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = artifactId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an Artifact associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Artifact should
        /// be created.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="artifact">
        /// Required. The Artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// The {artifact} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// If not provided, the Artifact's ID will be a UUID generated by the service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Artifacts in the parent MetadataStore. (Otherwise
        /// the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED if the
        /// caller can't view the preexisting Artifact.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(string parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifactAsync(new CreateArtifactRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = artifactId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an Artifact associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Artifact should
        /// be created.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="artifact">
        /// Required. The Artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// The {artifact} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// If not provided, the Artifact's ID will be a UUID generated by the service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Artifacts in the parent MetadataStore. (Otherwise
        /// the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED if the
        /// caller can't view the preexisting Artifact.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(string parent, Artifact artifact, string artifactId, st::CancellationToken cancellationToken) =>
            CreateArtifactAsync(parent, artifact, artifactId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Artifact associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Artifact should
        /// be created.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="artifact">
        /// Required. The Artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// The {artifact} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// If not provided, the Artifact's ID will be a UUID generated by the service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Artifacts in the parent MetadataStore. (Otherwise
        /// the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED if the
        /// caller can't view the preexisting Artifact.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact CreateArtifact(MetadataStoreName parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifact(new CreateArtifactRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = artifactId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an Artifact associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Artifact should
        /// be created.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="artifact">
        /// Required. The Artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// The {artifact} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// If not provided, the Artifact's ID will be a UUID generated by the service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Artifacts in the parent MetadataStore. (Otherwise
        /// the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED if the
        /// caller can't view the preexisting Artifact.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(MetadataStoreName parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifactAsync(new CreateArtifactRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = artifactId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an Artifact associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Artifact should
        /// be created.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="artifact">
        /// Required. The Artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// The {artifact} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// If not provided, the Artifact's ID will be a UUID generated by the service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Artifacts in the parent MetadataStore. (Otherwise
        /// the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED if the
        /// caller can't view the preexisting Artifact.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(MetadataStoreName parent, Artifact artifact, string artifactId, st::CancellationToken cancellationToken) =>
            CreateArtifactAsync(parent, artifact, artifactId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact GetArtifact(GetArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a specific Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> GetArtifactAsync(GetArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a specific Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> GetArtifactAsync(GetArtifactRequest request, st::CancellationToken cancellationToken) =>
            GetArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific Artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Artifact to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact GetArtifact(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetArtifact(new GetArtifactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific Artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Artifact to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> GetArtifactAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetArtifactAsync(new GetArtifactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific Artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Artifact to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> GetArtifactAsync(string name, st::CancellationToken cancellationToken) =>
            GetArtifactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific Artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Artifact to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact GetArtifact(ArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetArtifact(new GetArtifactRequest
            {
                ArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific Artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Artifact to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> GetArtifactAsync(ArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetArtifactAsync(new GetArtifactRequest
            {
                ArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific Artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Artifact to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> GetArtifactAsync(ArtifactName name, st::CancellationToken cancellationToken) =>
            GetArtifactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Artifacts in the MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(ListArtifactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Artifacts in the MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(ListArtifactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Artifacts in the MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose Artifacts should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListArtifacts(new ListArtifactsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Artifacts in the MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose Artifacts should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListArtifactsAsync(new ListArtifactsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Artifacts in the MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose Artifacts should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(MetadataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListArtifacts(new ListArtifactsRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Artifacts in the MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose Artifacts should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(MetadataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListArtifactsAsync(new ListArtifactsRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates a stored Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact UpdateArtifact(UpdateArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a stored Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> UpdateArtifactAsync(UpdateArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a stored Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> UpdateArtifactAsync(UpdateArtifactRequest request, st::CancellationToken cancellationToken) =>
            UpdateArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a stored Artifact.
        /// </summary>
        /// <param name="artifact">
        /// Required. The Artifact containing updates.
        /// The Artifact's [Artifact.name][google.cloud.aiplatform.v1.Artifact.name]
        /// field is used to identify the Artifact to be updated. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. A FieldMask indicating which fields should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact UpdateArtifact(Artifact artifact, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateArtifact(new UpdateArtifactRequest
            {
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a stored Artifact.
        /// </summary>
        /// <param name="artifact">
        /// Required. The Artifact containing updates.
        /// The Artifact's [Artifact.name][google.cloud.aiplatform.v1.Artifact.name]
        /// field is used to identify the Artifact to be updated. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. A FieldMask indicating which fields should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> UpdateArtifactAsync(Artifact artifact, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateArtifactAsync(new UpdateArtifactRequest
            {
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a stored Artifact.
        /// </summary>
        /// <param name="artifact">
        /// Required. The Artifact containing updates.
        /// The Artifact's [Artifact.name][google.cloud.aiplatform.v1.Artifact.name]
        /// field is used to identify the Artifact to be updated. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. A FieldMask indicating which fields should be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> UpdateArtifactAsync(Artifact artifact, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateArtifactAsync(artifact, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteArtifact(DeleteArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteArtifactAsync(DeleteArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteArtifactAsync(DeleteArtifactRequest request, st::CancellationToken cancellationToken) =>
            DeleteArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteArtifact</c>.</summary>
        public virtual lro::OperationsClient DeleteArtifactOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteArtifact</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteArtifact(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteArtifactOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteArtifact</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteArtifactAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteArtifactOperationsClient, callSettings);

        /// <summary>
        /// Deletes an Artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Artifact to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteArtifact(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteArtifact(new DeleteArtifactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Artifact to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteArtifactAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteArtifactAsync(new DeleteArtifactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Artifact to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteArtifactAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteArtifactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Artifact to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteArtifact(ArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteArtifact(new DeleteArtifactRequest
            {
                ArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Artifact to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteArtifactAsync(ArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteArtifactAsync(new DeleteArtifactRequest
            {
                ArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Artifact to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteArtifactAsync(ArtifactName name, st::CancellationToken cancellationToken) =>
            DeleteArtifactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Purges Artifacts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> PurgeArtifacts(PurgeArtifactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Purges Artifacts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata>> PurgeArtifactsAsync(PurgeArtifactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Purges Artifacts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata>> PurgeArtifactsAsync(PurgeArtifactsRequest request, st::CancellationToken cancellationToken) =>
            PurgeArtifactsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PurgeArtifacts</c>.</summary>
        public virtual lro::OperationsClient PurgeArtifactsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PurgeArtifacts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> PollOncePurgeArtifacts(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeArtifactsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PurgeArtifacts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata>> PollOncePurgeArtifactsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeArtifactsOperationsClient, callSettings);

        /// <summary>
        /// Purges Artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Artifacts from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> PurgeArtifacts(string parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeArtifacts(new PurgeArtifactsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Purges Artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Artifacts from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata>> PurgeArtifactsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeArtifactsAsync(new PurgeArtifactsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Purges Artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Artifacts from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata>> PurgeArtifactsAsync(string parent, st::CancellationToken cancellationToken) =>
            PurgeArtifactsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Purges Artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Artifacts from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> PurgeArtifacts(MetadataStoreName parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeArtifacts(new PurgeArtifactsRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Purges Artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Artifacts from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata>> PurgeArtifactsAsync(MetadataStoreName parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeArtifactsAsync(new PurgeArtifactsRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Purges Artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Artifacts from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata>> PurgeArtifactsAsync(MetadataStoreName parent, st::CancellationToken cancellationToken) =>
            PurgeArtifactsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Context associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context CreateContext(CreateContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Context associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> CreateContextAsync(CreateContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Context associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> CreateContextAsync(CreateContextRequest request, st::CancellationToken cancellationToken) =>
            CreateContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Context associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Context should
        /// be created. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="context">
        /// Required. The Context to create.
        /// </param>
        /// <param name="contextId">
        /// The {context} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`.
        /// If not provided, the Context's ID will be a UUID generated by the service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Contexts in the parent MetadataStore. (Otherwise
        /// the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED if the
        /// caller can't view the preexisting Context.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context CreateContext(string parent, Context context, string contextId, gaxgrpc::CallSettings callSettings = null) =>
            CreateContext(new CreateContextRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                ContextId = contextId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a Context associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Context should
        /// be created. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="context">
        /// Required. The Context to create.
        /// </param>
        /// <param name="contextId">
        /// The {context} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`.
        /// If not provided, the Context's ID will be a UUID generated by the service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Contexts in the parent MetadataStore. (Otherwise
        /// the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED if the
        /// caller can't view the preexisting Context.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> CreateContextAsync(string parent, Context context, string contextId, gaxgrpc::CallSettings callSettings = null) =>
            CreateContextAsync(new CreateContextRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                ContextId = contextId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a Context associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Context should
        /// be created. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="context">
        /// Required. The Context to create.
        /// </param>
        /// <param name="contextId">
        /// The {context} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`.
        /// If not provided, the Context's ID will be a UUID generated by the service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Contexts in the parent MetadataStore. (Otherwise
        /// the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED if the
        /// caller can't view the preexisting Context.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> CreateContextAsync(string parent, Context context, string contextId, st::CancellationToken cancellationToken) =>
            CreateContextAsync(parent, context, contextId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Context associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Context should
        /// be created. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="context">
        /// Required. The Context to create.
        /// </param>
        /// <param name="contextId">
        /// The {context} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`.
        /// If not provided, the Context's ID will be a UUID generated by the service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Contexts in the parent MetadataStore. (Otherwise
        /// the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED if the
        /// caller can't view the preexisting Context.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context CreateContext(MetadataStoreName parent, Context context, string contextId, gaxgrpc::CallSettings callSettings = null) =>
            CreateContext(new CreateContextRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                ContextId = contextId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a Context associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Context should
        /// be created. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="context">
        /// Required. The Context to create.
        /// </param>
        /// <param name="contextId">
        /// The {context} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`.
        /// If not provided, the Context's ID will be a UUID generated by the service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Contexts in the parent MetadataStore. (Otherwise
        /// the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED if the
        /// caller can't view the preexisting Context.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> CreateContextAsync(MetadataStoreName parent, Context context, string contextId, gaxgrpc::CallSettings callSettings = null) =>
            CreateContextAsync(new CreateContextRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                ContextId = contextId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a Context associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Context should
        /// be created. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="context">
        /// Required. The Context to create.
        /// </param>
        /// <param name="contextId">
        /// The {context} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`.
        /// If not provided, the Context's ID will be a UUID generated by the service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Contexts in the parent MetadataStore. (Otherwise
        /// the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED if the
        /// caller can't view the preexisting Context.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> CreateContextAsync(MetadataStoreName parent, Context context, string contextId, st::CancellationToken cancellationToken) =>
            CreateContextAsync(parent, context, contextId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context GetContext(GetContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a specific Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> GetContextAsync(GetContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a specific Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> GetContextAsync(GetContextRequest request, st::CancellationToken cancellationToken) =>
            GetContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific Context.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Context to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context GetContext(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetContext(new GetContextRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific Context.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Context to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> GetContextAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetContextAsync(new GetContextRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific Context.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Context to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> GetContextAsync(string name, st::CancellationToken cancellationToken) =>
            GetContextAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific Context.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Context to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context GetContext(ContextName name, gaxgrpc::CallSettings callSettings = null) =>
            GetContext(new GetContextRequest
            {
                ContextName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific Context.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Context to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> GetContextAsync(ContextName name, gaxgrpc::CallSettings callSettings = null) =>
            GetContextAsync(new GetContextRequest
            {
                ContextName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific Context.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Context to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> GetContextAsync(ContextName name, st::CancellationToken cancellationToken) =>
            GetContextAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Contexts on the MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Context"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContextsResponse, Context> ListContexts(ListContextsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Contexts on the MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Context"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContextsResponse, Context> ListContextsAsync(ListContextsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Contexts on the MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose Contexts should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable sequence of <see cref="Context"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContextsResponse, Context> ListContexts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListContexts(new ListContextsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Contexts on the MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose Contexts should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Context"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContextsResponse, Context> ListContextsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListContextsAsync(new ListContextsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Contexts on the MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose Contexts should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable sequence of <see cref="Context"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContextsResponse, Context> ListContexts(MetadataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListContexts(new ListContextsRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Contexts on the MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose Contexts should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Context"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContextsResponse, Context> ListContextsAsync(MetadataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListContextsAsync(new ListContextsRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates a stored Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context UpdateContext(UpdateContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a stored Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> UpdateContextAsync(UpdateContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a stored Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> UpdateContextAsync(UpdateContextRequest request, st::CancellationToken cancellationToken) =>
            UpdateContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a stored Context.
        /// </summary>
        /// <param name="context">
        /// Required. The Context containing updates.
        /// The Context's [Context.name][google.cloud.aiplatform.v1.Context.name] field
        /// is used to identify the Context to be updated. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. A FieldMask indicating which fields should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context UpdateContext(Context context, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateContext(new UpdateContextRequest
            {
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a stored Context.
        /// </summary>
        /// <param name="context">
        /// Required. The Context containing updates.
        /// The Context's [Context.name][google.cloud.aiplatform.v1.Context.name] field
        /// is used to identify the Context to be updated. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. A FieldMask indicating which fields should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> UpdateContextAsync(Context context, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateContextAsync(new UpdateContextRequest
            {
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a stored Context.
        /// </summary>
        /// <param name="context">
        /// Required. The Context containing updates.
        /// The Context's [Context.name][google.cloud.aiplatform.v1.Context.name] field
        /// is used to identify the Context to be updated. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. A FieldMask indicating which fields should be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> UpdateContextAsync(Context context, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateContextAsync(context, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a stored Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteContext(DeleteContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a stored Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteContextAsync(DeleteContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a stored Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteContextAsync(DeleteContextRequest request, st::CancellationToken cancellationToken) =>
            DeleteContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteContext</c>.</summary>
        public virtual lro::OperationsClient DeleteContextOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteContext</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteContext(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteContextOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteContext</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteContextAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteContextOperationsClient, callSettings);

        /// <summary>
        /// Deletes a stored Context.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Context to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteContext(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContext(new DeleteContextRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a stored Context.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Context to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteContextAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContextAsync(new DeleteContextRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a stored Context.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Context to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteContextAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteContextAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a stored Context.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Context to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteContext(ContextName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContext(new DeleteContextRequest
            {
                ContextName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a stored Context.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Context to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteContextAsync(ContextName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContextAsync(new DeleteContextRequest
            {
                ContextName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a stored Context.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Context to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteContextAsync(ContextName name, st::CancellationToken cancellationToken) =>
            DeleteContextAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Purges Contexts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeContextsResponse, PurgeContextsMetadata> PurgeContexts(PurgeContextsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Purges Contexts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeContextsResponse, PurgeContextsMetadata>> PurgeContextsAsync(PurgeContextsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Purges Contexts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeContextsResponse, PurgeContextsMetadata>> PurgeContextsAsync(PurgeContextsRequest request, st::CancellationToken cancellationToken) =>
            PurgeContextsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PurgeContexts</c>.</summary>
        public virtual lro::OperationsClient PurgeContextsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PurgeContexts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PurgeContextsResponse, PurgeContextsMetadata> PollOncePurgeContexts(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeContextsResponse, PurgeContextsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeContextsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PurgeContexts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PurgeContextsResponse, PurgeContextsMetadata>> PollOncePurgeContextsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeContextsResponse, PurgeContextsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeContextsOperationsClient, callSettings);

        /// <summary>
        /// Purges Contexts.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Contexts from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeContextsResponse, PurgeContextsMetadata> PurgeContexts(string parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeContexts(new PurgeContextsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Purges Contexts.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Contexts from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeContextsResponse, PurgeContextsMetadata>> PurgeContextsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeContextsAsync(new PurgeContextsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Purges Contexts.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Contexts from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeContextsResponse, PurgeContextsMetadata>> PurgeContextsAsync(string parent, st::CancellationToken cancellationToken) =>
            PurgeContextsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Purges Contexts.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Contexts from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeContextsResponse, PurgeContextsMetadata> PurgeContexts(MetadataStoreName parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeContexts(new PurgeContextsRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Purges Contexts.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Contexts from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeContextsResponse, PurgeContextsMetadata>> PurgeContextsAsync(MetadataStoreName parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeContextsAsync(new PurgeContextsRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Purges Contexts.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Contexts from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeContextsResponse, PurgeContextsMetadata>> PurgeContextsAsync(MetadataStoreName parent, st::CancellationToken cancellationToken) =>
            PurgeContextsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a set of Artifacts and Executions to a Context. If any of the
        /// Artifacts or Executions have already been added to a Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddContextArtifactsAndExecutionsResponse AddContextArtifactsAndExecutions(AddContextArtifactsAndExecutionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a set of Artifacts and Executions to a Context. If any of the
        /// Artifacts or Executions have already been added to a Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddContextArtifactsAndExecutionsResponse> AddContextArtifactsAndExecutionsAsync(AddContextArtifactsAndExecutionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a set of Artifacts and Executions to a Context. If any of the
        /// Artifacts or Executions have already been added to a Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddContextArtifactsAndExecutionsResponse> AddContextArtifactsAndExecutionsAsync(AddContextArtifactsAndExecutionsRequest request, st::CancellationToken cancellationToken) =>
            AddContextArtifactsAndExecutionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a set of Artifacts and Executions to a Context. If any of the
        /// Artifacts or Executions have already been added to a Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the Context that the Artifacts and
        /// Executions belong to. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="artifacts">
        /// The resource names of the Artifacts to attribute to the Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="executions">
        /// The resource names of the Executions to associate with the
        /// Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddContextArtifactsAndExecutionsResponse AddContextArtifactsAndExecutions(string context, scg::IEnumerable<string> artifacts, scg::IEnumerable<string> executions, gaxgrpc::CallSettings callSettings = null) =>
            AddContextArtifactsAndExecutions(new AddContextArtifactsAndExecutionsRequest
            {
                Context = gax::GaxPreconditions.CheckNotNullOrEmpty(context, nameof(context)),
                Artifacts =
                {
                    artifacts ?? linq::Enumerable.Empty<string>(),
                },
                Executions =
                {
                    executions ?? linq::Enumerable.Empty<string>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds a set of Artifacts and Executions to a Context. If any of the
        /// Artifacts or Executions have already been added to a Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the Context that the Artifacts and
        /// Executions belong to. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="artifacts">
        /// The resource names of the Artifacts to attribute to the Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="executions">
        /// The resource names of the Executions to associate with the
        /// Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddContextArtifactsAndExecutionsResponse> AddContextArtifactsAndExecutionsAsync(string context, scg::IEnumerable<string> artifacts, scg::IEnumerable<string> executions, gaxgrpc::CallSettings callSettings = null) =>
            AddContextArtifactsAndExecutionsAsync(new AddContextArtifactsAndExecutionsRequest
            {
                Context = gax::GaxPreconditions.CheckNotNullOrEmpty(context, nameof(context)),
                Artifacts =
                {
                    artifacts ?? linq::Enumerable.Empty<string>(),
                },
                Executions =
                {
                    executions ?? linq::Enumerable.Empty<string>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds a set of Artifacts and Executions to a Context. If any of the
        /// Artifacts or Executions have already been added to a Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the Context that the Artifacts and
        /// Executions belong to. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="artifacts">
        /// The resource names of the Artifacts to attribute to the Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="executions">
        /// The resource names of the Executions to associate with the
        /// Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddContextArtifactsAndExecutionsResponse> AddContextArtifactsAndExecutionsAsync(string context, scg::IEnumerable<string> artifacts, scg::IEnumerable<string> executions, st::CancellationToken cancellationToken) =>
            AddContextArtifactsAndExecutionsAsync(context, artifacts, executions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a set of Artifacts and Executions to a Context. If any of the
        /// Artifacts or Executions have already been added to a Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the Context that the Artifacts and
        /// Executions belong to. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="artifacts">
        /// The resource names of the Artifacts to attribute to the Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="executions">
        /// The resource names of the Executions to associate with the
        /// Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddContextArtifactsAndExecutionsResponse AddContextArtifactsAndExecutions(ContextName context, scg::IEnumerable<ArtifactName> artifacts, scg::IEnumerable<ExecutionName> executions, gaxgrpc::CallSettings callSettings = null) =>
            AddContextArtifactsAndExecutions(new AddContextArtifactsAndExecutionsRequest
            {
                ContextAsContextName = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                ArtifactsAsArtifactNames =
                {
                    artifacts ?? linq::Enumerable.Empty<ArtifactName>(),
                },
                ExecutionsAsExecutionNames =
                {
                    executions ?? linq::Enumerable.Empty<ExecutionName>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds a set of Artifacts and Executions to a Context. If any of the
        /// Artifacts or Executions have already been added to a Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the Context that the Artifacts and
        /// Executions belong to. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="artifacts">
        /// The resource names of the Artifacts to attribute to the Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="executions">
        /// The resource names of the Executions to associate with the
        /// Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddContextArtifactsAndExecutionsResponse> AddContextArtifactsAndExecutionsAsync(ContextName context, scg::IEnumerable<ArtifactName> artifacts, scg::IEnumerable<ExecutionName> executions, gaxgrpc::CallSettings callSettings = null) =>
            AddContextArtifactsAndExecutionsAsync(new AddContextArtifactsAndExecutionsRequest
            {
                ContextAsContextName = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                ArtifactsAsArtifactNames =
                {
                    artifacts ?? linq::Enumerable.Empty<ArtifactName>(),
                },
                ExecutionsAsExecutionNames =
                {
                    executions ?? linq::Enumerable.Empty<ExecutionName>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds a set of Artifacts and Executions to a Context. If any of the
        /// Artifacts or Executions have already been added to a Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the Context that the Artifacts and
        /// Executions belong to. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="artifacts">
        /// The resource names of the Artifacts to attribute to the Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// </param>
        /// <param name="executions">
        /// The resource names of the Executions to associate with the
        /// Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddContextArtifactsAndExecutionsResponse> AddContextArtifactsAndExecutionsAsync(ContextName context, scg::IEnumerable<ArtifactName> artifacts, scg::IEnumerable<ExecutionName> executions, st::CancellationToken cancellationToken) =>
            AddContextArtifactsAndExecutionsAsync(context, artifacts, executions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a set of Contexts as children to a parent Context. If any of the
        /// child Contexts have already been added to the parent Context, they are
        /// simply skipped. If this call would create a cycle or cause any Context to
        /// have more than 10 parents, the request will fail with an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddContextChildrenResponse AddContextChildren(AddContextChildrenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a set of Contexts as children to a parent Context. If any of the
        /// child Contexts have already been added to the parent Context, they are
        /// simply skipped. If this call would create a cycle or cause any Context to
        /// have more than 10 parents, the request will fail with an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddContextChildrenResponse> AddContextChildrenAsync(AddContextChildrenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a set of Contexts as children to a parent Context. If any of the
        /// child Contexts have already been added to the parent Context, they are
        /// simply skipped. If this call would create a cycle or cause any Context to
        /// have more than 10 parents, the request will fail with an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddContextChildrenResponse> AddContextChildrenAsync(AddContextChildrenRequest request, st::CancellationToken cancellationToken) =>
            AddContextChildrenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a set of Contexts as children to a parent Context. If any of the
        /// child Contexts have already been added to the parent Context, they are
        /// simply skipped. If this call would create a cycle or cause any Context to
        /// have more than 10 parents, the request will fail with an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the parent Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="childContexts">
        /// The resource names of the child Contexts.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddContextChildrenResponse AddContextChildren(string context, scg::IEnumerable<string> childContexts, gaxgrpc::CallSettings callSettings = null) =>
            AddContextChildren(new AddContextChildrenRequest
            {
                Context = gax::GaxPreconditions.CheckNotNullOrEmpty(context, nameof(context)),
                ChildContexts =
                {
                    childContexts ?? linq::Enumerable.Empty<string>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds a set of Contexts as children to a parent Context. If any of the
        /// child Contexts have already been added to the parent Context, they are
        /// simply skipped. If this call would create a cycle or cause any Context to
        /// have more than 10 parents, the request will fail with an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the parent Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="childContexts">
        /// The resource names of the child Contexts.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddContextChildrenResponse> AddContextChildrenAsync(string context, scg::IEnumerable<string> childContexts, gaxgrpc::CallSettings callSettings = null) =>
            AddContextChildrenAsync(new AddContextChildrenRequest
            {
                Context = gax::GaxPreconditions.CheckNotNullOrEmpty(context, nameof(context)),
                ChildContexts =
                {
                    childContexts ?? linq::Enumerable.Empty<string>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds a set of Contexts as children to a parent Context. If any of the
        /// child Contexts have already been added to the parent Context, they are
        /// simply skipped. If this call would create a cycle or cause any Context to
        /// have more than 10 parents, the request will fail with an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the parent Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="childContexts">
        /// The resource names of the child Contexts.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddContextChildrenResponse> AddContextChildrenAsync(string context, scg::IEnumerable<string> childContexts, st::CancellationToken cancellationToken) =>
            AddContextChildrenAsync(context, childContexts, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a set of Contexts as children to a parent Context. If any of the
        /// child Contexts have already been added to the parent Context, they are
        /// simply skipped. If this call would create a cycle or cause any Context to
        /// have more than 10 parents, the request will fail with an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the parent Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="childContexts">
        /// The resource names of the child Contexts.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddContextChildrenResponse AddContextChildren(ContextName context, scg::IEnumerable<ContextName> childContexts, gaxgrpc::CallSettings callSettings = null) =>
            AddContextChildren(new AddContextChildrenRequest
            {
                ContextAsContextName = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                ChildContextsAsContextNames =
                {
                    childContexts ?? linq::Enumerable.Empty<ContextName>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds a set of Contexts as children to a parent Context. If any of the
        /// child Contexts have already been added to the parent Context, they are
        /// simply skipped. If this call would create a cycle or cause any Context to
        /// have more than 10 parents, the request will fail with an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the parent Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="childContexts">
        /// The resource names of the child Contexts.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddContextChildrenResponse> AddContextChildrenAsync(ContextName context, scg::IEnumerable<ContextName> childContexts, gaxgrpc::CallSettings callSettings = null) =>
            AddContextChildrenAsync(new AddContextChildrenRequest
            {
                ContextAsContextName = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                ChildContextsAsContextNames =
                {
                    childContexts ?? linq::Enumerable.Empty<ContextName>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds a set of Contexts as children to a parent Context. If any of the
        /// child Contexts have already been added to the parent Context, they are
        /// simply skipped. If this call would create a cycle or cause any Context to
        /// have more than 10 parents, the request will fail with an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the parent Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="childContexts">
        /// The resource names of the child Contexts.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddContextChildrenResponse> AddContextChildrenAsync(ContextName context, scg::IEnumerable<ContextName> childContexts, st::CancellationToken cancellationToken) =>
            AddContextChildrenAsync(context, childContexts, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove a set of children contexts from a parent Context. If any of the
        /// child Contexts were NOT added to the parent Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveContextChildrenResponse RemoveContextChildren(RemoveContextChildrenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove a set of children contexts from a parent Context. If any of the
        /// child Contexts were NOT added to the parent Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveContextChildrenResponse> RemoveContextChildrenAsync(RemoveContextChildrenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove a set of children contexts from a parent Context. If any of the
        /// child Contexts were NOT added to the parent Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveContextChildrenResponse> RemoveContextChildrenAsync(RemoveContextChildrenRequest request, st::CancellationToken cancellationToken) =>
            RemoveContextChildrenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove a set of children contexts from a parent Context. If any of the
        /// child Contexts were NOT added to the parent Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the parent Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="childContexts">
        /// The resource names of the child Contexts.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveContextChildrenResponse RemoveContextChildren(string context, scg::IEnumerable<string> childContexts, gaxgrpc::CallSettings callSettings = null) =>
            RemoveContextChildren(new RemoveContextChildrenRequest
            {
                Context = gax::GaxPreconditions.CheckNotNullOrEmpty(context, nameof(context)),
                ChildContexts =
                {
                    childContexts ?? linq::Enumerable.Empty<string>(),
                },
            }, callSettings);

        /// <summary>
        /// Remove a set of children contexts from a parent Context. If any of the
        /// child Contexts were NOT added to the parent Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the parent Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="childContexts">
        /// The resource names of the child Contexts.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveContextChildrenResponse> RemoveContextChildrenAsync(string context, scg::IEnumerable<string> childContexts, gaxgrpc::CallSettings callSettings = null) =>
            RemoveContextChildrenAsync(new RemoveContextChildrenRequest
            {
                Context = gax::GaxPreconditions.CheckNotNullOrEmpty(context, nameof(context)),
                ChildContexts =
                {
                    childContexts ?? linq::Enumerable.Empty<string>(),
                },
            }, callSettings);

        /// <summary>
        /// Remove a set of children contexts from a parent Context. If any of the
        /// child Contexts were NOT added to the parent Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the parent Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="childContexts">
        /// The resource names of the child Contexts.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveContextChildrenResponse> RemoveContextChildrenAsync(string context, scg::IEnumerable<string> childContexts, st::CancellationToken cancellationToken) =>
            RemoveContextChildrenAsync(context, childContexts, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove a set of children contexts from a parent Context. If any of the
        /// child Contexts were NOT added to the parent Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the parent Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="childContexts">
        /// The resource names of the child Contexts.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveContextChildrenResponse RemoveContextChildren(ContextName context, scg::IEnumerable<ContextName> childContexts, gaxgrpc::CallSettings callSettings = null) =>
            RemoveContextChildren(new RemoveContextChildrenRequest
            {
                ContextAsContextName = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                ChildContextsAsContextNames =
                {
                    childContexts ?? linq::Enumerable.Empty<ContextName>(),
                },
            }, callSettings);

        /// <summary>
        /// Remove a set of children contexts from a parent Context. If any of the
        /// child Contexts were NOT added to the parent Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the parent Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="childContexts">
        /// The resource names of the child Contexts.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveContextChildrenResponse> RemoveContextChildrenAsync(ContextName context, scg::IEnumerable<ContextName> childContexts, gaxgrpc::CallSettings callSettings = null) =>
            RemoveContextChildrenAsync(new RemoveContextChildrenRequest
            {
                ContextAsContextName = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                ChildContextsAsContextNames =
                {
                    childContexts ?? linq::Enumerable.Empty<ContextName>(),
                },
            }, callSettings);

        /// <summary>
        /// Remove a set of children contexts from a parent Context. If any of the
        /// child Contexts were NOT added to the parent Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the parent Context.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// </param>
        /// <param name="childContexts">
        /// The resource names of the child Contexts.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveContextChildrenResponse> RemoveContextChildrenAsync(ContextName context, scg::IEnumerable<ContextName> childContexts, st::CancellationToken cancellationToken) =>
            RemoveContextChildrenAsync(context, childContexts, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves Artifacts and Executions within the specified Context, connected
        /// by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageSubgraph QueryContextLineageSubgraph(QueryContextLineageSubgraphRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves Artifacts and Executions within the specified Context, connected
        /// by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryContextLineageSubgraphAsync(QueryContextLineageSubgraphRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves Artifacts and Executions within the specified Context, connected
        /// by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryContextLineageSubgraphAsync(QueryContextLineageSubgraphRequest request, st::CancellationToken cancellationToken) =>
            QueryContextLineageSubgraphAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves Artifacts and Executions within the specified Context, connected
        /// by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the Context whose Artifacts and Executions
        /// should be retrieved as a LineageSubgraph.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// 
        /// The request may error with FAILED_PRECONDITION if the number of Artifacts,
        /// the number of Executions, or the number of Events that would be returned
        /// for the Context exceeds 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageSubgraph QueryContextLineageSubgraph(string context, gaxgrpc::CallSettings callSettings = null) =>
            QueryContextLineageSubgraph(new QueryContextLineageSubgraphRequest
            {
                Context = gax::GaxPreconditions.CheckNotNullOrEmpty(context, nameof(context)),
            }, callSettings);

        /// <summary>
        /// Retrieves Artifacts and Executions within the specified Context, connected
        /// by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the Context whose Artifacts and Executions
        /// should be retrieved as a LineageSubgraph.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// 
        /// The request may error with FAILED_PRECONDITION if the number of Artifacts,
        /// the number of Executions, or the number of Events that would be returned
        /// for the Context exceeds 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryContextLineageSubgraphAsync(string context, gaxgrpc::CallSettings callSettings = null) =>
            QueryContextLineageSubgraphAsync(new QueryContextLineageSubgraphRequest
            {
                Context = gax::GaxPreconditions.CheckNotNullOrEmpty(context, nameof(context)),
            }, callSettings);

        /// <summary>
        /// Retrieves Artifacts and Executions within the specified Context, connected
        /// by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the Context whose Artifacts and Executions
        /// should be retrieved as a LineageSubgraph.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// 
        /// The request may error with FAILED_PRECONDITION if the number of Artifacts,
        /// the number of Executions, or the number of Events that would be returned
        /// for the Context exceeds 1000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryContextLineageSubgraphAsync(string context, st::CancellationToken cancellationToken) =>
            QueryContextLineageSubgraphAsync(context, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves Artifacts and Executions within the specified Context, connected
        /// by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the Context whose Artifacts and Executions
        /// should be retrieved as a LineageSubgraph.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// 
        /// The request may error with FAILED_PRECONDITION if the number of Artifacts,
        /// the number of Executions, or the number of Events that would be returned
        /// for the Context exceeds 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageSubgraph QueryContextLineageSubgraph(ContextName context, gaxgrpc::CallSettings callSettings = null) =>
            QueryContextLineageSubgraph(new QueryContextLineageSubgraphRequest
            {
                ContextAsContextName = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
            }, callSettings);

        /// <summary>
        /// Retrieves Artifacts and Executions within the specified Context, connected
        /// by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the Context whose Artifacts and Executions
        /// should be retrieved as a LineageSubgraph.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// 
        /// The request may error with FAILED_PRECONDITION if the number of Artifacts,
        /// the number of Executions, or the number of Events that would be returned
        /// for the Context exceeds 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryContextLineageSubgraphAsync(ContextName context, gaxgrpc::CallSettings callSettings = null) =>
            QueryContextLineageSubgraphAsync(new QueryContextLineageSubgraphRequest
            {
                ContextAsContextName = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
            }, callSettings);

        /// <summary>
        /// Retrieves Artifacts and Executions within the specified Context, connected
        /// by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="context">
        /// Required. The resource name of the Context whose Artifacts and Executions
        /// should be retrieved as a LineageSubgraph.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
        /// 
        /// The request may error with FAILED_PRECONDITION if the number of Artifacts,
        /// the number of Executions, or the number of Events that would be returned
        /// for the Context exceeds 1000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryContextLineageSubgraphAsync(ContextName context, st::CancellationToken cancellationToken) =>
            QueryContextLineageSubgraphAsync(context, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Execution associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution CreateExecution(CreateExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Execution associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CreateExecutionAsync(CreateExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Execution associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CreateExecutionAsync(CreateExecutionRequest request, st::CancellationToken cancellationToken) =>
            CreateExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Execution associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Execution should
        /// be created.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="execution">
        /// Required. The Execution to create.
        /// </param>
        /// <param name="executionId">
        /// The {execution} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// If not provided, the Execution's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Executions in the parent MetadataStore.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting Execution.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution CreateExecution(string parent, Execution execution, string executionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExecution(new CreateExecutionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
                ExecutionId = executionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an Execution associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Execution should
        /// be created.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="execution">
        /// Required. The Execution to create.
        /// </param>
        /// <param name="executionId">
        /// The {execution} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// If not provided, the Execution's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Executions in the parent MetadataStore.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting Execution.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CreateExecutionAsync(string parent, Execution execution, string executionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExecutionAsync(new CreateExecutionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
                ExecutionId = executionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an Execution associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Execution should
        /// be created.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="execution">
        /// Required. The Execution to create.
        /// </param>
        /// <param name="executionId">
        /// The {execution} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// If not provided, the Execution's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Executions in the parent MetadataStore.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting Execution.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CreateExecutionAsync(string parent, Execution execution, string executionId, st::CancellationToken cancellationToken) =>
            CreateExecutionAsync(parent, execution, executionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Execution associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Execution should
        /// be created.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="execution">
        /// Required. The Execution to create.
        /// </param>
        /// <param name="executionId">
        /// The {execution} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// If not provided, the Execution's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Executions in the parent MetadataStore.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting Execution.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution CreateExecution(MetadataStoreName parent, Execution execution, string executionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExecution(new CreateExecutionRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
                ExecutionId = executionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an Execution associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Execution should
        /// be created.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="execution">
        /// Required. The Execution to create.
        /// </param>
        /// <param name="executionId">
        /// The {execution} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// If not provided, the Execution's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Executions in the parent MetadataStore.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting Execution.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CreateExecutionAsync(MetadataStoreName parent, Execution execution, string executionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExecutionAsync(new CreateExecutionRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
                ExecutionId = executionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an Execution associated with a MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the Execution should
        /// be created.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="execution">
        /// Required. The Execution to create.
        /// </param>
        /// <param name="executionId">
        /// The {execution} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// If not provided, the Execution's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all Executions in the parent MetadataStore.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting Execution.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CreateExecutionAsync(MetadataStoreName parent, Execution execution, string executionId, st::CancellationToken cancellationToken) =>
            CreateExecutionAsync(parent, execution, executionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution GetExecution(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a specific Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a specific Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(GetExecutionRequest request, st::CancellationToken cancellationToken) =>
            GetExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific Execution.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Execution to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution GetExecution(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecution(new GetExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific Execution.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Execution to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecutionAsync(new GetExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific Execution.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Execution to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(string name, st::CancellationToken cancellationToken) =>
            GetExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific Execution.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Execution to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution GetExecution(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecution(new GetExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific Execution.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Execution to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecutionAsync(new GetExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific Execution.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Execution to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(ExecutionName name, st::CancellationToken cancellationToken) =>
            GetExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Executions in the MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Executions in the MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Executions in the MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose Executions should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExecutions(new ListExecutionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Executions in the MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose Executions should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExecutionsAsync(new ListExecutionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Executions in the MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose Executions should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(MetadataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExecutions(new ListExecutionsRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Executions in the MetadataStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose Executions should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(MetadataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExecutionsAsync(new ListExecutionsRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates a stored Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution UpdateExecution(UpdateExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a stored Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> UpdateExecutionAsync(UpdateExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a stored Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> UpdateExecutionAsync(UpdateExecutionRequest request, st::CancellationToken cancellationToken) =>
            UpdateExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a stored Execution.
        /// </summary>
        /// <param name="execution">
        /// Required. The Execution containing updates.
        /// The Execution's [Execution.name][google.cloud.aiplatform.v1.Execution.name]
        /// field is used to identify the Execution to be updated. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. A FieldMask indicating which fields should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution UpdateExecution(Execution execution, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExecution(new UpdateExecutionRequest
            {
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a stored Execution.
        /// </summary>
        /// <param name="execution">
        /// Required. The Execution containing updates.
        /// The Execution's [Execution.name][google.cloud.aiplatform.v1.Execution.name]
        /// field is used to identify the Execution to be updated. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. A FieldMask indicating which fields should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> UpdateExecutionAsync(Execution execution, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExecutionAsync(new UpdateExecutionRequest
            {
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a stored Execution.
        /// </summary>
        /// <param name="execution">
        /// Required. The Execution containing updates.
        /// The Execution's [Execution.name][google.cloud.aiplatform.v1.Execution.name]
        /// field is used to identify the Execution to be updated. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. A FieldMask indicating which fields should be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> UpdateExecutionAsync(Execution execution, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateExecutionAsync(execution, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteExecution(DeleteExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExecutionAsync(DeleteExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExecutionAsync(DeleteExecutionRequest request, st::CancellationToken cancellationToken) =>
            DeleteExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteExecution</c>.</summary>
        public virtual lro::OperationsClient DeleteExecutionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteExecution</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteExecution(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExecutionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteExecution</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteExecutionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExecutionOperationsClient, callSettings);

        /// <summary>
        /// Deletes an Execution.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Execution to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteExecution(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExecution(new DeleteExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Execution.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Execution to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExecutionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExecutionAsync(new DeleteExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Execution.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Execution to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExecutionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Execution.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Execution to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteExecution(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExecution(new DeleteExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Execution.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Execution to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExecutionAsync(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExecutionAsync(new DeleteExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Execution.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Execution to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExecutionAsync(ExecutionName name, st::CancellationToken cancellationToken) =>
            DeleteExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Purges Executions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> PurgeExecutions(PurgeExecutionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Purges Executions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata>> PurgeExecutionsAsync(PurgeExecutionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Purges Executions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata>> PurgeExecutionsAsync(PurgeExecutionsRequest request, st::CancellationToken cancellationToken) =>
            PurgeExecutionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PurgeExecutions</c>.</summary>
        public virtual lro::OperationsClient PurgeExecutionsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PurgeExecutions</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> PollOncePurgeExecutions(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeExecutionsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PurgeExecutions</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata>> PollOncePurgeExecutionsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeExecutionsOperationsClient, callSettings);

        /// <summary>
        /// Purges Executions.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Executions from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> PurgeExecutions(string parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeExecutions(new PurgeExecutionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Purges Executions.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Executions from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata>> PurgeExecutionsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeExecutionsAsync(new PurgeExecutionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Purges Executions.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Executions from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata>> PurgeExecutionsAsync(string parent, st::CancellationToken cancellationToken) =>
            PurgeExecutionsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Purges Executions.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Executions from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> PurgeExecutions(MetadataStoreName parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeExecutions(new PurgeExecutionsRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Purges Executions.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Executions from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata>> PurgeExecutionsAsync(MetadataStoreName parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeExecutionsAsync(new PurgeExecutionsRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Purges Executions.
        /// </summary>
        /// <param name="parent">
        /// Required. The metadata store to purge Executions from.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata>> PurgeExecutionsAsync(MetadataStoreName parent, st::CancellationToken cancellationToken) =>
            PurgeExecutionsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds Events to the specified Execution. An Event indicates whether an
        /// Artifact was used as an input or output for an Execution. If an Event
        /// already exists between the Execution and the Artifact, the Event is
        /// skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddExecutionEventsResponse AddExecutionEvents(AddExecutionEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds Events to the specified Execution. An Event indicates whether an
        /// Artifact was used as an input or output for an Execution. If an Event
        /// already exists between the Execution and the Artifact, the Event is
        /// skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddExecutionEventsResponse> AddExecutionEventsAsync(AddExecutionEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds Events to the specified Execution. An Event indicates whether an
        /// Artifact was used as an input or output for an Execution. If an Event
        /// already exists between the Execution and the Artifact, the Event is
        /// skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddExecutionEventsResponse> AddExecutionEventsAsync(AddExecutionEventsRequest request, st::CancellationToken cancellationToken) =>
            AddExecutionEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds Events to the specified Execution. An Event indicates whether an
        /// Artifact was used as an input or output for an Execution. If an Event
        /// already exists between the Execution and the Artifact, the Event is
        /// skipped.
        /// </summary>
        /// <param name="execution">
        /// Required. The resource name of the Execution that the Events connect
        /// Artifacts with.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="events">
        /// The Events to create and add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddExecutionEventsResponse AddExecutionEvents(string execution, scg::IEnumerable<Event> events, gaxgrpc::CallSettings callSettings = null) =>
            AddExecutionEvents(new AddExecutionEventsRequest
            {
                Execution = gax::GaxPreconditions.CheckNotNullOrEmpty(execution, nameof(execution)),
                Events =
                {
                    events ?? linq::Enumerable.Empty<Event>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds Events to the specified Execution. An Event indicates whether an
        /// Artifact was used as an input or output for an Execution. If an Event
        /// already exists between the Execution and the Artifact, the Event is
        /// skipped.
        /// </summary>
        /// <param name="execution">
        /// Required. The resource name of the Execution that the Events connect
        /// Artifacts with.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="events">
        /// The Events to create and add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddExecutionEventsResponse> AddExecutionEventsAsync(string execution, scg::IEnumerable<Event> events, gaxgrpc::CallSettings callSettings = null) =>
            AddExecutionEventsAsync(new AddExecutionEventsRequest
            {
                Execution = gax::GaxPreconditions.CheckNotNullOrEmpty(execution, nameof(execution)),
                Events =
                {
                    events ?? linq::Enumerable.Empty<Event>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds Events to the specified Execution. An Event indicates whether an
        /// Artifact was used as an input or output for an Execution. If an Event
        /// already exists between the Execution and the Artifact, the Event is
        /// skipped.
        /// </summary>
        /// <param name="execution">
        /// Required. The resource name of the Execution that the Events connect
        /// Artifacts with.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="events">
        /// The Events to create and add.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddExecutionEventsResponse> AddExecutionEventsAsync(string execution, scg::IEnumerable<Event> events, st::CancellationToken cancellationToken) =>
            AddExecutionEventsAsync(execution, events, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds Events to the specified Execution. An Event indicates whether an
        /// Artifact was used as an input or output for an Execution. If an Event
        /// already exists between the Execution and the Artifact, the Event is
        /// skipped.
        /// </summary>
        /// <param name="execution">
        /// Required. The resource name of the Execution that the Events connect
        /// Artifacts with.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="events">
        /// The Events to create and add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddExecutionEventsResponse AddExecutionEvents(ExecutionName execution, scg::IEnumerable<Event> events, gaxgrpc::CallSettings callSettings = null) =>
            AddExecutionEvents(new AddExecutionEventsRequest
            {
                ExecutionAsExecutionName = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
                Events =
                {
                    events ?? linq::Enumerable.Empty<Event>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds Events to the specified Execution. An Event indicates whether an
        /// Artifact was used as an input or output for an Execution. If an Event
        /// already exists between the Execution and the Artifact, the Event is
        /// skipped.
        /// </summary>
        /// <param name="execution">
        /// Required. The resource name of the Execution that the Events connect
        /// Artifacts with.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="events">
        /// The Events to create and add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddExecutionEventsResponse> AddExecutionEventsAsync(ExecutionName execution, scg::IEnumerable<Event> events, gaxgrpc::CallSettings callSettings = null) =>
            AddExecutionEventsAsync(new AddExecutionEventsRequest
            {
                ExecutionAsExecutionName = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
                Events =
                {
                    events ?? linq::Enumerable.Empty<Event>(),
                },
            }, callSettings);

        /// <summary>
        /// Adds Events to the specified Execution. An Event indicates whether an
        /// Artifact was used as an input or output for an Execution. If an Event
        /// already exists between the Execution and the Artifact, the Event is
        /// skipped.
        /// </summary>
        /// <param name="execution">
        /// Required. The resource name of the Execution that the Events connect
        /// Artifacts with.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="events">
        /// The Events to create and add.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddExecutionEventsResponse> AddExecutionEventsAsync(ExecutionName execution, scg::IEnumerable<Event> events, st::CancellationToken cancellationToken) =>
            AddExecutionEventsAsync(execution, events, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Obtains the set of input and output Artifacts for this Execution, in the
        /// form of LineageSubgraph that also contains the Execution and connecting
        /// Events.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageSubgraph QueryExecutionInputsAndOutputs(QueryExecutionInputsAndOutputsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Obtains the set of input and output Artifacts for this Execution, in the
        /// form of LineageSubgraph that also contains the Execution and connecting
        /// Events.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryExecutionInputsAndOutputsAsync(QueryExecutionInputsAndOutputsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Obtains the set of input and output Artifacts for this Execution, in the
        /// form of LineageSubgraph that also contains the Execution and connecting
        /// Events.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryExecutionInputsAndOutputsAsync(QueryExecutionInputsAndOutputsRequest request, st::CancellationToken cancellationToken) =>
            QueryExecutionInputsAndOutputsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Obtains the set of input and output Artifacts for this Execution, in the
        /// form of LineageSubgraph that also contains the Execution and connecting
        /// Events.
        /// </summary>
        /// <param name="execution">
        /// Required. The resource name of the Execution whose input and output
        /// Artifacts should be retrieved as a LineageSubgraph. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageSubgraph QueryExecutionInputsAndOutputs(string execution, gaxgrpc::CallSettings callSettings = null) =>
            QueryExecutionInputsAndOutputs(new QueryExecutionInputsAndOutputsRequest
            {
                Execution = gax::GaxPreconditions.CheckNotNullOrEmpty(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Obtains the set of input and output Artifacts for this Execution, in the
        /// form of LineageSubgraph that also contains the Execution and connecting
        /// Events.
        /// </summary>
        /// <param name="execution">
        /// Required. The resource name of the Execution whose input and output
        /// Artifacts should be retrieved as a LineageSubgraph. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryExecutionInputsAndOutputsAsync(string execution, gaxgrpc::CallSettings callSettings = null) =>
            QueryExecutionInputsAndOutputsAsync(new QueryExecutionInputsAndOutputsRequest
            {
                Execution = gax::GaxPreconditions.CheckNotNullOrEmpty(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Obtains the set of input and output Artifacts for this Execution, in the
        /// form of LineageSubgraph that also contains the Execution and connecting
        /// Events.
        /// </summary>
        /// <param name="execution">
        /// Required. The resource name of the Execution whose input and output
        /// Artifacts should be retrieved as a LineageSubgraph. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryExecutionInputsAndOutputsAsync(string execution, st::CancellationToken cancellationToken) =>
            QueryExecutionInputsAndOutputsAsync(execution, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Obtains the set of input and output Artifacts for this Execution, in the
        /// form of LineageSubgraph that also contains the Execution and connecting
        /// Events.
        /// </summary>
        /// <param name="execution">
        /// Required. The resource name of the Execution whose input and output
        /// Artifacts should be retrieved as a LineageSubgraph. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageSubgraph QueryExecutionInputsAndOutputs(ExecutionName execution, gaxgrpc::CallSettings callSettings = null) =>
            QueryExecutionInputsAndOutputs(new QueryExecutionInputsAndOutputsRequest
            {
                ExecutionAsExecutionName = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Obtains the set of input and output Artifacts for this Execution, in the
        /// form of LineageSubgraph that also contains the Execution and connecting
        /// Events.
        /// </summary>
        /// <param name="execution">
        /// Required. The resource name of the Execution whose input and output
        /// Artifacts should be retrieved as a LineageSubgraph. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryExecutionInputsAndOutputsAsync(ExecutionName execution, gaxgrpc::CallSettings callSettings = null) =>
            QueryExecutionInputsAndOutputsAsync(new QueryExecutionInputsAndOutputsRequest
            {
                ExecutionAsExecutionName = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Obtains the set of input and output Artifacts for this Execution, in the
        /// form of LineageSubgraph that also contains the Execution and connecting
        /// Events.
        /// </summary>
        /// <param name="execution">
        /// Required. The resource name of the Execution whose input and output
        /// Artifacts should be retrieved as a LineageSubgraph. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/executions/{execution}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryExecutionInputsAndOutputsAsync(ExecutionName execution, st::CancellationToken cancellationToken) =>
            QueryExecutionInputsAndOutputsAsync(execution, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a MetadataSchema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetadataSchema CreateMetadataSchema(CreateMetadataSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a MetadataSchema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataSchema> CreateMetadataSchemaAsync(CreateMetadataSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a MetadataSchema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataSchema> CreateMetadataSchemaAsync(CreateMetadataSchemaRequest request, st::CancellationToken cancellationToken) =>
            CreateMetadataSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a MetadataSchema.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the MetadataSchema
        /// should be created. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="metadataSchema">
        /// Required. The MetadataSchema to create.
        /// </param>
        /// <param name="metadataSchemaId">
        /// The {metadata_schema} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/metadataSchemas/{metadataschema}`
        /// If not provided, the MetadataStore's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all MetadataSchemas in the parent Location.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting MetadataSchema.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetadataSchema CreateMetadataSchema(string parent, MetadataSchema metadataSchema, string metadataSchemaId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetadataSchema(new CreateMetadataSchemaRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MetadataSchema = gax::GaxPreconditions.CheckNotNull(metadataSchema, nameof(metadataSchema)),
                MetadataSchemaId = metadataSchemaId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a MetadataSchema.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the MetadataSchema
        /// should be created. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="metadataSchema">
        /// Required. The MetadataSchema to create.
        /// </param>
        /// <param name="metadataSchemaId">
        /// The {metadata_schema} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/metadataSchemas/{metadataschema}`
        /// If not provided, the MetadataStore's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all MetadataSchemas in the parent Location.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting MetadataSchema.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataSchema> CreateMetadataSchemaAsync(string parent, MetadataSchema metadataSchema, string metadataSchemaId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetadataSchemaAsync(new CreateMetadataSchemaRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MetadataSchema = gax::GaxPreconditions.CheckNotNull(metadataSchema, nameof(metadataSchema)),
                MetadataSchemaId = metadataSchemaId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a MetadataSchema.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the MetadataSchema
        /// should be created. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="metadataSchema">
        /// Required. The MetadataSchema to create.
        /// </param>
        /// <param name="metadataSchemaId">
        /// The {metadata_schema} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/metadataSchemas/{metadataschema}`
        /// If not provided, the MetadataStore's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all MetadataSchemas in the parent Location.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting MetadataSchema.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataSchema> CreateMetadataSchemaAsync(string parent, MetadataSchema metadataSchema, string metadataSchemaId, st::CancellationToken cancellationToken) =>
            CreateMetadataSchemaAsync(parent, metadataSchema, metadataSchemaId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a MetadataSchema.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the MetadataSchema
        /// should be created. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="metadataSchema">
        /// Required. The MetadataSchema to create.
        /// </param>
        /// <param name="metadataSchemaId">
        /// The {metadata_schema} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/metadataSchemas/{metadataschema}`
        /// If not provided, the MetadataStore's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all MetadataSchemas in the parent Location.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting MetadataSchema.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetadataSchema CreateMetadataSchema(MetadataStoreName parent, MetadataSchema metadataSchema, string metadataSchemaId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetadataSchema(new CreateMetadataSchemaRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MetadataSchema = gax::GaxPreconditions.CheckNotNull(metadataSchema, nameof(metadataSchema)),
                MetadataSchemaId = metadataSchemaId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a MetadataSchema.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the MetadataSchema
        /// should be created. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="metadataSchema">
        /// Required. The MetadataSchema to create.
        /// </param>
        /// <param name="metadataSchemaId">
        /// The {metadata_schema} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/metadataSchemas/{metadataschema}`
        /// If not provided, the MetadataStore's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all MetadataSchemas in the parent Location.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting MetadataSchema.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataSchema> CreateMetadataSchemaAsync(MetadataStoreName parent, MetadataSchema metadataSchema, string metadataSchemaId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetadataSchemaAsync(new CreateMetadataSchemaRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MetadataSchema = gax::GaxPreconditions.CheckNotNull(metadataSchema, nameof(metadataSchema)),
                MetadataSchemaId = metadataSchemaId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a MetadataSchema.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the MetadataStore where the MetadataSchema
        /// should be created. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
        /// </param>
        /// <param name="metadataSchema">
        /// Required. The MetadataSchema to create.
        /// </param>
        /// <param name="metadataSchemaId">
        /// The {metadata_schema} portion of the resource name with the format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/metadataSchemas/{metadataschema}`
        /// If not provided, the MetadataStore's ID will be a UUID generated by the
        /// service.
        /// Must be 4-128 characters in length. Valid characters are `/[a-z][0-9]-/`.
        /// Must be unique across all MetadataSchemas in the parent Location.
        /// (Otherwise the request will fail with ALREADY_EXISTS, or PERMISSION_DENIED
        /// if the caller can't view the preexisting MetadataSchema.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataSchema> CreateMetadataSchemaAsync(MetadataStoreName parent, MetadataSchema metadataSchema, string metadataSchemaId, st::CancellationToken cancellationToken) =>
            CreateMetadataSchemaAsync(parent, metadataSchema, metadataSchemaId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific MetadataSchema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetadataSchema GetMetadataSchema(GetMetadataSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a specific MetadataSchema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataSchema> GetMetadataSchemaAsync(GetMetadataSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a specific MetadataSchema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataSchema> GetMetadataSchemaAsync(GetMetadataSchemaRequest request, st::CancellationToken cancellationToken) =>
            GetMetadataSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific MetadataSchema.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataSchema to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/metadataSchemas/{metadataschema}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetadataSchema GetMetadataSchema(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataSchema(new GetMetadataSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific MetadataSchema.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataSchema to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/metadataSchemas/{metadataschema}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataSchema> GetMetadataSchemaAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataSchemaAsync(new GetMetadataSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific MetadataSchema.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataSchema to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/metadataSchemas/{metadataschema}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataSchema> GetMetadataSchemaAsync(string name, st::CancellationToken cancellationToken) =>
            GetMetadataSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific MetadataSchema.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataSchema to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/metadataSchemas/{metadataschema}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetadataSchema GetMetadataSchema(MetadataSchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataSchema(new GetMetadataSchemaRequest
            {
                MetadataSchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific MetadataSchema.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataSchema to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/metadataSchemas/{metadataschema}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataSchema> GetMetadataSchemaAsync(MetadataSchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataSchemaAsync(new GetMetadataSchemaRequest
            {
                MetadataSchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific MetadataSchema.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MetadataSchema to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/metadataSchemas/{metadataschema}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataSchema> GetMetadataSchemaAsync(MetadataSchemaName name, st::CancellationToken cancellationToken) =>
            GetMetadataSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists MetadataSchemas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MetadataSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetadataSchemasResponse, MetadataSchema> ListMetadataSchemas(ListMetadataSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MetadataSchemas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MetadataSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetadataSchemasResponse, MetadataSchema> ListMetadataSchemasAsync(ListMetadataSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MetadataSchemas.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose MetadataSchemas should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable sequence of <see cref="MetadataSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetadataSchemasResponse, MetadataSchema> ListMetadataSchemas(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMetadataSchemas(new ListMetadataSchemasRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists MetadataSchemas.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose MetadataSchemas should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MetadataSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetadataSchemasResponse, MetadataSchema> ListMetadataSchemasAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMetadataSchemasAsync(new ListMetadataSchemasRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists MetadataSchemas.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose MetadataSchemas should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable sequence of <see cref="MetadataSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetadataSchemasResponse, MetadataSchema> ListMetadataSchemas(MetadataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMetadataSchemas(new ListMetadataSchemasRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists MetadataSchemas.
        /// </summary>
        /// <param name="parent">
        /// Required. The MetadataStore whose MetadataSchemas should be listed.
        /// Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MetadataSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetadataSchemasResponse, MetadataSchema> ListMetadataSchemasAsync(MetadataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMetadataSchemasAsync(new ListMetadataSchemasRequest
            {
                ParentAsMetadataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves lineage of an Artifact represented through Artifacts and
        /// Executions connected by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageSubgraph QueryArtifactLineageSubgraph(QueryArtifactLineageSubgraphRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves lineage of an Artifact represented through Artifacts and
        /// Executions connected by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryArtifactLineageSubgraphAsync(QueryArtifactLineageSubgraphRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves lineage of an Artifact represented through Artifacts and
        /// Executions connected by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryArtifactLineageSubgraphAsync(QueryArtifactLineageSubgraphRequest request, st::CancellationToken cancellationToken) =>
            QueryArtifactLineageSubgraphAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves lineage of an Artifact represented through Artifacts and
        /// Executions connected by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="artifact">
        /// Required. The resource name of the Artifact whose Lineage needs to be
        /// retrieved as a LineageSubgraph. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// 
        /// The request may error with FAILED_PRECONDITION if the number of Artifacts,
        /// the number of Executions, or the number of Events that would be returned
        /// for the Context exceeds 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageSubgraph QueryArtifactLineageSubgraph(string artifact, gaxgrpc::CallSettings callSettings = null) =>
            QueryArtifactLineageSubgraph(new QueryArtifactLineageSubgraphRequest
            {
                Artifact = gax::GaxPreconditions.CheckNotNullOrEmpty(artifact, nameof(artifact)),
            }, callSettings);

        /// <summary>
        /// Retrieves lineage of an Artifact represented through Artifacts and
        /// Executions connected by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="artifact">
        /// Required. The resource name of the Artifact whose Lineage needs to be
        /// retrieved as a LineageSubgraph. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// 
        /// The request may error with FAILED_PRECONDITION if the number of Artifacts,
        /// the number of Executions, or the number of Events that would be returned
        /// for the Context exceeds 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryArtifactLineageSubgraphAsync(string artifact, gaxgrpc::CallSettings callSettings = null) =>
            QueryArtifactLineageSubgraphAsync(new QueryArtifactLineageSubgraphRequest
            {
                Artifact = gax::GaxPreconditions.CheckNotNullOrEmpty(artifact, nameof(artifact)),
            }, callSettings);

        /// <summary>
        /// Retrieves lineage of an Artifact represented through Artifacts and
        /// Executions connected by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="artifact">
        /// Required. The resource name of the Artifact whose Lineage needs to be
        /// retrieved as a LineageSubgraph. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// 
        /// The request may error with FAILED_PRECONDITION if the number of Artifacts,
        /// the number of Executions, or the number of Events that would be returned
        /// for the Context exceeds 1000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryArtifactLineageSubgraphAsync(string artifact, st::CancellationToken cancellationToken) =>
            QueryArtifactLineageSubgraphAsync(artifact, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves lineage of an Artifact represented through Artifacts and
        /// Executions connected by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="artifact">
        /// Required. The resource name of the Artifact whose Lineage needs to be
        /// retrieved as a LineageSubgraph. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// 
        /// The request may error with FAILED_PRECONDITION if the number of Artifacts,
        /// the number of Executions, or the number of Events that would be returned
        /// for the Context exceeds 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageSubgraph QueryArtifactLineageSubgraph(ArtifactName artifact, gaxgrpc::CallSettings callSettings = null) =>
            QueryArtifactLineageSubgraph(new QueryArtifactLineageSubgraphRequest
            {
                ArtifactAsArtifactName = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
            }, callSettings);

        /// <summary>
        /// Retrieves lineage of an Artifact represented through Artifacts and
        /// Executions connected by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="artifact">
        /// Required. The resource name of the Artifact whose Lineage needs to be
        /// retrieved as a LineageSubgraph. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// 
        /// The request may error with FAILED_PRECONDITION if the number of Artifacts,
        /// the number of Executions, or the number of Events that would be returned
        /// for the Context exceeds 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryArtifactLineageSubgraphAsync(ArtifactName artifact, gaxgrpc::CallSettings callSettings = null) =>
            QueryArtifactLineageSubgraphAsync(new QueryArtifactLineageSubgraphRequest
            {
                ArtifactAsArtifactName = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
            }, callSettings);

        /// <summary>
        /// Retrieves lineage of an Artifact represented through Artifacts and
        /// Executions connected by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="artifact">
        /// Required. The resource name of the Artifact whose Lineage needs to be
        /// retrieved as a LineageSubgraph. Format:
        /// `projects/{project}/locations/{location}/metadataStores/{metadatastore}/artifacts/{artifact}`
        /// 
        /// The request may error with FAILED_PRECONDITION if the number of Artifacts,
        /// the number of Executions, or the number of Events that would be returned
        /// for the Context exceeds 1000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageSubgraph> QueryArtifactLineageSubgraphAsync(ArtifactName artifact, st::CancellationToken cancellationToken) =>
            QueryArtifactLineageSubgraphAsync(artifact, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MetadataService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for reading and writing metadata entries.
    /// </remarks>
    public sealed partial class MetadataServiceClientImpl : MetadataServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateMetadataStoreRequest, lro::Operation> _callCreateMetadataStore;

        private readonly gaxgrpc::ApiCall<GetMetadataStoreRequest, MetadataStore> _callGetMetadataStore;

        private readonly gaxgrpc::ApiCall<ListMetadataStoresRequest, ListMetadataStoresResponse> _callListMetadataStores;

        private readonly gaxgrpc::ApiCall<DeleteMetadataStoreRequest, lro::Operation> _callDeleteMetadataStore;

        private readonly gaxgrpc::ApiCall<CreateArtifactRequest, Artifact> _callCreateArtifact;

        private readonly gaxgrpc::ApiCall<GetArtifactRequest, Artifact> _callGetArtifact;

        private readonly gaxgrpc::ApiCall<ListArtifactsRequest, ListArtifactsResponse> _callListArtifacts;

        private readonly gaxgrpc::ApiCall<UpdateArtifactRequest, Artifact> _callUpdateArtifact;

        private readonly gaxgrpc::ApiCall<DeleteArtifactRequest, lro::Operation> _callDeleteArtifact;

        private readonly gaxgrpc::ApiCall<PurgeArtifactsRequest, lro::Operation> _callPurgeArtifacts;

        private readonly gaxgrpc::ApiCall<CreateContextRequest, Context> _callCreateContext;

        private readonly gaxgrpc::ApiCall<GetContextRequest, Context> _callGetContext;

        private readonly gaxgrpc::ApiCall<ListContextsRequest, ListContextsResponse> _callListContexts;

        private readonly gaxgrpc::ApiCall<UpdateContextRequest, Context> _callUpdateContext;

        private readonly gaxgrpc::ApiCall<DeleteContextRequest, lro::Operation> _callDeleteContext;

        private readonly gaxgrpc::ApiCall<PurgeContextsRequest, lro::Operation> _callPurgeContexts;

        private readonly gaxgrpc::ApiCall<AddContextArtifactsAndExecutionsRequest, AddContextArtifactsAndExecutionsResponse> _callAddContextArtifactsAndExecutions;

        private readonly gaxgrpc::ApiCall<AddContextChildrenRequest, AddContextChildrenResponse> _callAddContextChildren;

        private readonly gaxgrpc::ApiCall<RemoveContextChildrenRequest, RemoveContextChildrenResponse> _callRemoveContextChildren;

        private readonly gaxgrpc::ApiCall<QueryContextLineageSubgraphRequest, LineageSubgraph> _callQueryContextLineageSubgraph;

        private readonly gaxgrpc::ApiCall<CreateExecutionRequest, Execution> _callCreateExecution;

        private readonly gaxgrpc::ApiCall<GetExecutionRequest, Execution> _callGetExecution;

        private readonly gaxgrpc::ApiCall<ListExecutionsRequest, ListExecutionsResponse> _callListExecutions;

        private readonly gaxgrpc::ApiCall<UpdateExecutionRequest, Execution> _callUpdateExecution;

        private readonly gaxgrpc::ApiCall<DeleteExecutionRequest, lro::Operation> _callDeleteExecution;

        private readonly gaxgrpc::ApiCall<PurgeExecutionsRequest, lro::Operation> _callPurgeExecutions;

        private readonly gaxgrpc::ApiCall<AddExecutionEventsRequest, AddExecutionEventsResponse> _callAddExecutionEvents;

        private readonly gaxgrpc::ApiCall<QueryExecutionInputsAndOutputsRequest, LineageSubgraph> _callQueryExecutionInputsAndOutputs;

        private readonly gaxgrpc::ApiCall<CreateMetadataSchemaRequest, MetadataSchema> _callCreateMetadataSchema;

        private readonly gaxgrpc::ApiCall<GetMetadataSchemaRequest, MetadataSchema> _callGetMetadataSchema;

        private readonly gaxgrpc::ApiCall<ListMetadataSchemasRequest, ListMetadataSchemasResponse> _callListMetadataSchemas;

        private readonly gaxgrpc::ApiCall<QueryArtifactLineageSubgraphRequest, LineageSubgraph> _callQueryArtifactLineageSubgraph;

        /// <summary>
        /// Constructs a client wrapper for the MetadataService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MetadataServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MetadataServiceClientImpl(MetadataService.MetadataServiceClient grpcClient, MetadataServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MetadataServiceSettings effectiveSettings = settings ?? MetadataServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateMetadataStoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMetadataStoreOperationsSettings, logger);
            DeleteMetadataStoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMetadataStoreOperationsSettings, logger);
            DeleteArtifactOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteArtifactOperationsSettings, logger);
            PurgeArtifactsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PurgeArtifactsOperationsSettings, logger);
            DeleteContextOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteContextOperationsSettings, logger);
            PurgeContextsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PurgeContextsOperationsSettings, logger);
            DeleteExecutionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteExecutionOperationsSettings, logger);
            PurgeExecutionsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PurgeExecutionsOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateMetadataStore = clientHelper.BuildApiCall<CreateMetadataStoreRequest, lro::Operation>("CreateMetadataStore", grpcClient.CreateMetadataStoreAsync, grpcClient.CreateMetadataStore, effectiveSettings.CreateMetadataStoreSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMetadataStore);
            Modify_CreateMetadataStoreApiCall(ref _callCreateMetadataStore);
            _callGetMetadataStore = clientHelper.BuildApiCall<GetMetadataStoreRequest, MetadataStore>("GetMetadataStore", grpcClient.GetMetadataStoreAsync, grpcClient.GetMetadataStore, effectiveSettings.GetMetadataStoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMetadataStore);
            Modify_GetMetadataStoreApiCall(ref _callGetMetadataStore);
            _callListMetadataStores = clientHelper.BuildApiCall<ListMetadataStoresRequest, ListMetadataStoresResponse>("ListMetadataStores", grpcClient.ListMetadataStoresAsync, grpcClient.ListMetadataStores, effectiveSettings.ListMetadataStoresSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMetadataStores);
            Modify_ListMetadataStoresApiCall(ref _callListMetadataStores);
            _callDeleteMetadataStore = clientHelper.BuildApiCall<DeleteMetadataStoreRequest, lro::Operation>("DeleteMetadataStore", grpcClient.DeleteMetadataStoreAsync, grpcClient.DeleteMetadataStore, effectiveSettings.DeleteMetadataStoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMetadataStore);
            Modify_DeleteMetadataStoreApiCall(ref _callDeleteMetadataStore);
            _callCreateArtifact = clientHelper.BuildApiCall<CreateArtifactRequest, Artifact>("CreateArtifact", grpcClient.CreateArtifactAsync, grpcClient.CreateArtifact, effectiveSettings.CreateArtifactSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateArtifact);
            Modify_CreateArtifactApiCall(ref _callCreateArtifact);
            _callGetArtifact = clientHelper.BuildApiCall<GetArtifactRequest, Artifact>("GetArtifact", grpcClient.GetArtifactAsync, grpcClient.GetArtifact, effectiveSettings.GetArtifactSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetArtifact);
            Modify_GetArtifactApiCall(ref _callGetArtifact);
            _callListArtifacts = clientHelper.BuildApiCall<ListArtifactsRequest, ListArtifactsResponse>("ListArtifacts", grpcClient.ListArtifactsAsync, grpcClient.ListArtifacts, effectiveSettings.ListArtifactsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListArtifacts);
            Modify_ListArtifactsApiCall(ref _callListArtifacts);
            _callUpdateArtifact = clientHelper.BuildApiCall<UpdateArtifactRequest, Artifact>("UpdateArtifact", grpcClient.UpdateArtifactAsync, grpcClient.UpdateArtifact, effectiveSettings.UpdateArtifactSettings).WithGoogleRequestParam("artifact.name", request => request.Artifact?.Name);
            Modify_ApiCall(ref _callUpdateArtifact);
            Modify_UpdateArtifactApiCall(ref _callUpdateArtifact);
            _callDeleteArtifact = clientHelper.BuildApiCall<DeleteArtifactRequest, lro::Operation>("DeleteArtifact", grpcClient.DeleteArtifactAsync, grpcClient.DeleteArtifact, effectiveSettings.DeleteArtifactSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteArtifact);
            Modify_DeleteArtifactApiCall(ref _callDeleteArtifact);
            _callPurgeArtifacts = clientHelper.BuildApiCall<PurgeArtifactsRequest, lro::Operation>("PurgeArtifacts", grpcClient.PurgeArtifactsAsync, grpcClient.PurgeArtifacts, effectiveSettings.PurgeArtifactsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callPurgeArtifacts);
            Modify_PurgeArtifactsApiCall(ref _callPurgeArtifacts);
            _callCreateContext = clientHelper.BuildApiCall<CreateContextRequest, Context>("CreateContext", grpcClient.CreateContextAsync, grpcClient.CreateContext, effectiveSettings.CreateContextSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateContext);
            Modify_CreateContextApiCall(ref _callCreateContext);
            _callGetContext = clientHelper.BuildApiCall<GetContextRequest, Context>("GetContext", grpcClient.GetContextAsync, grpcClient.GetContext, effectiveSettings.GetContextSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetContext);
            Modify_GetContextApiCall(ref _callGetContext);
            _callListContexts = clientHelper.BuildApiCall<ListContextsRequest, ListContextsResponse>("ListContexts", grpcClient.ListContextsAsync, grpcClient.ListContexts, effectiveSettings.ListContextsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListContexts);
            Modify_ListContextsApiCall(ref _callListContexts);
            _callUpdateContext = clientHelper.BuildApiCall<UpdateContextRequest, Context>("UpdateContext", grpcClient.UpdateContextAsync, grpcClient.UpdateContext, effectiveSettings.UpdateContextSettings).WithGoogleRequestParam("context.name", request => request.Context?.Name);
            Modify_ApiCall(ref _callUpdateContext);
            Modify_UpdateContextApiCall(ref _callUpdateContext);
            _callDeleteContext = clientHelper.BuildApiCall<DeleteContextRequest, lro::Operation>("DeleteContext", grpcClient.DeleteContextAsync, grpcClient.DeleteContext, effectiveSettings.DeleteContextSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteContext);
            Modify_DeleteContextApiCall(ref _callDeleteContext);
            _callPurgeContexts = clientHelper.BuildApiCall<PurgeContextsRequest, lro::Operation>("PurgeContexts", grpcClient.PurgeContextsAsync, grpcClient.PurgeContexts, effectiveSettings.PurgeContextsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callPurgeContexts);
            Modify_PurgeContextsApiCall(ref _callPurgeContexts);
            _callAddContextArtifactsAndExecutions = clientHelper.BuildApiCall<AddContextArtifactsAndExecutionsRequest, AddContextArtifactsAndExecutionsResponse>("AddContextArtifactsAndExecutions", grpcClient.AddContextArtifactsAndExecutionsAsync, grpcClient.AddContextArtifactsAndExecutions, effectiveSettings.AddContextArtifactsAndExecutionsSettings).WithGoogleRequestParam("context", request => request.Context);
            Modify_ApiCall(ref _callAddContextArtifactsAndExecutions);
            Modify_AddContextArtifactsAndExecutionsApiCall(ref _callAddContextArtifactsAndExecutions);
            _callAddContextChildren = clientHelper.BuildApiCall<AddContextChildrenRequest, AddContextChildrenResponse>("AddContextChildren", grpcClient.AddContextChildrenAsync, grpcClient.AddContextChildren, effectiveSettings.AddContextChildrenSettings).WithGoogleRequestParam("context", request => request.Context);
            Modify_ApiCall(ref _callAddContextChildren);
            Modify_AddContextChildrenApiCall(ref _callAddContextChildren);
            _callRemoveContextChildren = clientHelper.BuildApiCall<RemoveContextChildrenRequest, RemoveContextChildrenResponse>("RemoveContextChildren", grpcClient.RemoveContextChildrenAsync, grpcClient.RemoveContextChildren, effectiveSettings.RemoveContextChildrenSettings).WithGoogleRequestParam("context", request => request.Context);
            Modify_ApiCall(ref _callRemoveContextChildren);
            Modify_RemoveContextChildrenApiCall(ref _callRemoveContextChildren);
            _callQueryContextLineageSubgraph = clientHelper.BuildApiCall<QueryContextLineageSubgraphRequest, LineageSubgraph>("QueryContextLineageSubgraph", grpcClient.QueryContextLineageSubgraphAsync, grpcClient.QueryContextLineageSubgraph, effectiveSettings.QueryContextLineageSubgraphSettings).WithGoogleRequestParam("context", request => request.Context);
            Modify_ApiCall(ref _callQueryContextLineageSubgraph);
            Modify_QueryContextLineageSubgraphApiCall(ref _callQueryContextLineageSubgraph);
            _callCreateExecution = clientHelper.BuildApiCall<CreateExecutionRequest, Execution>("CreateExecution", grpcClient.CreateExecutionAsync, grpcClient.CreateExecution, effectiveSettings.CreateExecutionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateExecution);
            Modify_CreateExecutionApiCall(ref _callCreateExecution);
            _callGetExecution = clientHelper.BuildApiCall<GetExecutionRequest, Execution>("GetExecution", grpcClient.GetExecutionAsync, grpcClient.GetExecution, effectiveSettings.GetExecutionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExecution);
            Modify_GetExecutionApiCall(ref _callGetExecution);
            _callListExecutions = clientHelper.BuildApiCall<ListExecutionsRequest, ListExecutionsResponse>("ListExecutions", grpcClient.ListExecutionsAsync, grpcClient.ListExecutions, effectiveSettings.ListExecutionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExecutions);
            Modify_ListExecutionsApiCall(ref _callListExecutions);
            _callUpdateExecution = clientHelper.BuildApiCall<UpdateExecutionRequest, Execution>("UpdateExecution", grpcClient.UpdateExecutionAsync, grpcClient.UpdateExecution, effectiveSettings.UpdateExecutionSettings).WithGoogleRequestParam("execution.name", request => request.Execution?.Name);
            Modify_ApiCall(ref _callUpdateExecution);
            Modify_UpdateExecutionApiCall(ref _callUpdateExecution);
            _callDeleteExecution = clientHelper.BuildApiCall<DeleteExecutionRequest, lro::Operation>("DeleteExecution", grpcClient.DeleteExecutionAsync, grpcClient.DeleteExecution, effectiveSettings.DeleteExecutionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteExecution);
            Modify_DeleteExecutionApiCall(ref _callDeleteExecution);
            _callPurgeExecutions = clientHelper.BuildApiCall<PurgeExecutionsRequest, lro::Operation>("PurgeExecutions", grpcClient.PurgeExecutionsAsync, grpcClient.PurgeExecutions, effectiveSettings.PurgeExecutionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callPurgeExecutions);
            Modify_PurgeExecutionsApiCall(ref _callPurgeExecutions);
            _callAddExecutionEvents = clientHelper.BuildApiCall<AddExecutionEventsRequest, AddExecutionEventsResponse>("AddExecutionEvents", grpcClient.AddExecutionEventsAsync, grpcClient.AddExecutionEvents, effectiveSettings.AddExecutionEventsSettings).WithGoogleRequestParam("execution", request => request.Execution);
            Modify_ApiCall(ref _callAddExecutionEvents);
            Modify_AddExecutionEventsApiCall(ref _callAddExecutionEvents);
            _callQueryExecutionInputsAndOutputs = clientHelper.BuildApiCall<QueryExecutionInputsAndOutputsRequest, LineageSubgraph>("QueryExecutionInputsAndOutputs", grpcClient.QueryExecutionInputsAndOutputsAsync, grpcClient.QueryExecutionInputsAndOutputs, effectiveSettings.QueryExecutionInputsAndOutputsSettings).WithGoogleRequestParam("execution", request => request.Execution);
            Modify_ApiCall(ref _callQueryExecutionInputsAndOutputs);
            Modify_QueryExecutionInputsAndOutputsApiCall(ref _callQueryExecutionInputsAndOutputs);
            _callCreateMetadataSchema = clientHelper.BuildApiCall<CreateMetadataSchemaRequest, MetadataSchema>("CreateMetadataSchema", grpcClient.CreateMetadataSchemaAsync, grpcClient.CreateMetadataSchema, effectiveSettings.CreateMetadataSchemaSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMetadataSchema);
            Modify_CreateMetadataSchemaApiCall(ref _callCreateMetadataSchema);
            _callGetMetadataSchema = clientHelper.BuildApiCall<GetMetadataSchemaRequest, MetadataSchema>("GetMetadataSchema", grpcClient.GetMetadataSchemaAsync, grpcClient.GetMetadataSchema, effectiveSettings.GetMetadataSchemaSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMetadataSchema);
            Modify_GetMetadataSchemaApiCall(ref _callGetMetadataSchema);
            _callListMetadataSchemas = clientHelper.BuildApiCall<ListMetadataSchemasRequest, ListMetadataSchemasResponse>("ListMetadataSchemas", grpcClient.ListMetadataSchemasAsync, grpcClient.ListMetadataSchemas, effectiveSettings.ListMetadataSchemasSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMetadataSchemas);
            Modify_ListMetadataSchemasApiCall(ref _callListMetadataSchemas);
            _callQueryArtifactLineageSubgraph = clientHelper.BuildApiCall<QueryArtifactLineageSubgraphRequest, LineageSubgraph>("QueryArtifactLineageSubgraph", grpcClient.QueryArtifactLineageSubgraphAsync, grpcClient.QueryArtifactLineageSubgraph, effectiveSettings.QueryArtifactLineageSubgraphSettings).WithGoogleRequestParam("artifact", request => request.Artifact);
            Modify_ApiCall(ref _callQueryArtifactLineageSubgraph);
            Modify_QueryArtifactLineageSubgraphApiCall(ref _callQueryArtifactLineageSubgraph);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateMetadataStoreApiCall(ref gaxgrpc::ApiCall<CreateMetadataStoreRequest, lro::Operation> call);

        partial void Modify_GetMetadataStoreApiCall(ref gaxgrpc::ApiCall<GetMetadataStoreRequest, MetadataStore> call);

        partial void Modify_ListMetadataStoresApiCall(ref gaxgrpc::ApiCall<ListMetadataStoresRequest, ListMetadataStoresResponse> call);

        partial void Modify_DeleteMetadataStoreApiCall(ref gaxgrpc::ApiCall<DeleteMetadataStoreRequest, lro::Operation> call);

        partial void Modify_CreateArtifactApiCall(ref gaxgrpc::ApiCall<CreateArtifactRequest, Artifact> call);

        partial void Modify_GetArtifactApiCall(ref gaxgrpc::ApiCall<GetArtifactRequest, Artifact> call);

        partial void Modify_ListArtifactsApiCall(ref gaxgrpc::ApiCall<ListArtifactsRequest, ListArtifactsResponse> call);

        partial void Modify_UpdateArtifactApiCall(ref gaxgrpc::ApiCall<UpdateArtifactRequest, Artifact> call);

        partial void Modify_DeleteArtifactApiCall(ref gaxgrpc::ApiCall<DeleteArtifactRequest, lro::Operation> call);

        partial void Modify_PurgeArtifactsApiCall(ref gaxgrpc::ApiCall<PurgeArtifactsRequest, lro::Operation> call);

        partial void Modify_CreateContextApiCall(ref gaxgrpc::ApiCall<CreateContextRequest, Context> call);

        partial void Modify_GetContextApiCall(ref gaxgrpc::ApiCall<GetContextRequest, Context> call);

        partial void Modify_ListContextsApiCall(ref gaxgrpc::ApiCall<ListContextsRequest, ListContextsResponse> call);

        partial void Modify_UpdateContextApiCall(ref gaxgrpc::ApiCall<UpdateContextRequest, Context> call);

        partial void Modify_DeleteContextApiCall(ref gaxgrpc::ApiCall<DeleteContextRequest, lro::Operation> call);

        partial void Modify_PurgeContextsApiCall(ref gaxgrpc::ApiCall<PurgeContextsRequest, lro::Operation> call);

        partial void Modify_AddContextArtifactsAndExecutionsApiCall(ref gaxgrpc::ApiCall<AddContextArtifactsAndExecutionsRequest, AddContextArtifactsAndExecutionsResponse> call);

        partial void Modify_AddContextChildrenApiCall(ref gaxgrpc::ApiCall<AddContextChildrenRequest, AddContextChildrenResponse> call);

        partial void Modify_RemoveContextChildrenApiCall(ref gaxgrpc::ApiCall<RemoveContextChildrenRequest, RemoveContextChildrenResponse> call);

        partial void Modify_QueryContextLineageSubgraphApiCall(ref gaxgrpc::ApiCall<QueryContextLineageSubgraphRequest, LineageSubgraph> call);

        partial void Modify_CreateExecutionApiCall(ref gaxgrpc::ApiCall<CreateExecutionRequest, Execution> call);

        partial void Modify_GetExecutionApiCall(ref gaxgrpc::ApiCall<GetExecutionRequest, Execution> call);

        partial void Modify_ListExecutionsApiCall(ref gaxgrpc::ApiCall<ListExecutionsRequest, ListExecutionsResponse> call);

        partial void Modify_UpdateExecutionApiCall(ref gaxgrpc::ApiCall<UpdateExecutionRequest, Execution> call);

        partial void Modify_DeleteExecutionApiCall(ref gaxgrpc::ApiCall<DeleteExecutionRequest, lro::Operation> call);

        partial void Modify_PurgeExecutionsApiCall(ref gaxgrpc::ApiCall<PurgeExecutionsRequest, lro::Operation> call);

        partial void Modify_AddExecutionEventsApiCall(ref gaxgrpc::ApiCall<AddExecutionEventsRequest, AddExecutionEventsResponse> call);

        partial void Modify_QueryExecutionInputsAndOutputsApiCall(ref gaxgrpc::ApiCall<QueryExecutionInputsAndOutputsRequest, LineageSubgraph> call);

        partial void Modify_CreateMetadataSchemaApiCall(ref gaxgrpc::ApiCall<CreateMetadataSchemaRequest, MetadataSchema> call);

        partial void Modify_GetMetadataSchemaApiCall(ref gaxgrpc::ApiCall<GetMetadataSchemaRequest, MetadataSchema> call);

        partial void Modify_ListMetadataSchemasApiCall(ref gaxgrpc::ApiCall<ListMetadataSchemasRequest, ListMetadataSchemasResponse> call);

        partial void Modify_QueryArtifactLineageSubgraphApiCall(ref gaxgrpc::ApiCall<QueryArtifactLineageSubgraphRequest, LineageSubgraph> call);

        partial void OnConstruction(MetadataService.MetadataServiceClient grpcClient, MetadataServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MetadataService client</summary>
        public override MetadataService.MetadataServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateMetadataStoreRequest(ref CreateMetadataStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMetadataStoreRequest(ref GetMetadataStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMetadataStoresRequest(ref ListMetadataStoresRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMetadataStoreRequest(ref DeleteMetadataStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateArtifactRequest(ref CreateArtifactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetArtifactRequest(ref GetArtifactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListArtifactsRequest(ref ListArtifactsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateArtifactRequest(ref UpdateArtifactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteArtifactRequest(ref DeleteArtifactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PurgeArtifactsRequest(ref PurgeArtifactsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateContextRequest(ref CreateContextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetContextRequest(ref GetContextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListContextsRequest(ref ListContextsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateContextRequest(ref UpdateContextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteContextRequest(ref DeleteContextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PurgeContextsRequest(ref PurgeContextsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddContextArtifactsAndExecutionsRequest(ref AddContextArtifactsAndExecutionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddContextChildrenRequest(ref AddContextChildrenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveContextChildrenRequest(ref RemoveContextChildrenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryContextLineageSubgraphRequest(ref QueryContextLineageSubgraphRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateExecutionRequest(ref CreateExecutionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExecutionRequest(ref GetExecutionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExecutionsRequest(ref ListExecutionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateExecutionRequest(ref UpdateExecutionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteExecutionRequest(ref DeleteExecutionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PurgeExecutionsRequest(ref PurgeExecutionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddExecutionEventsRequest(ref AddExecutionEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryExecutionInputsAndOutputsRequest(ref QueryExecutionInputsAndOutputsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMetadataSchemaRequest(ref CreateMetadataSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMetadataSchemaRequest(ref GetMetadataSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMetadataSchemasRequest(ref ListMetadataSchemasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryArtifactLineageSubgraphRequest(ref QueryArtifactLineageSubgraphRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateMetadataStore</c>.</summary>
        public override lro::OperationsClient CreateMetadataStoreOperationsClient { get; }

        /// <summary>
        /// Initializes a MetadataStore, including allocation of resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata> CreateMetadataStore(CreateMetadataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMetadataStoreRequest(ref request, ref callSettings);
            return new lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata>(_callCreateMetadataStore.Sync(request, callSettings), CreateMetadataStoreOperationsClient);
        }

        /// <summary>
        /// Initializes a MetadataStore, including allocation of resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata>> CreateMetadataStoreAsync(CreateMetadataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMetadataStoreRequest(ref request, ref callSettings);
            return new lro::Operation<MetadataStore, CreateMetadataStoreOperationMetadata>(await _callCreateMetadataStore.Async(request, callSettings).ConfigureAwait(false), CreateMetadataStoreOperationsClient);
        }

        /// <summary>
        /// Retrieves a specific MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MetadataStore GetMetadataStore(GetMetadataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetadataStoreRequest(ref request, ref callSettings);
            return _callGetMetadataStore.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a specific MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MetadataStore> GetMetadataStoreAsync(GetMetadataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetadataStoreRequest(ref request, ref callSettings);
            return _callGetMetadataStore.Async(request, callSettings);
        }

        /// <summary>
        /// Lists MetadataStores for a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MetadataStore"/> resources.</returns>
        public override gax::PagedEnumerable<ListMetadataStoresResponse, MetadataStore> ListMetadataStores(ListMetadataStoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMetadataStoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMetadataStoresRequest, ListMetadataStoresResponse, MetadataStore>(_callListMetadataStores, request, callSettings);
        }

        /// <summary>
        /// Lists MetadataStores for a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MetadataStore"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMetadataStoresResponse, MetadataStore> ListMetadataStoresAsync(ListMetadataStoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMetadataStoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMetadataStoresRequest, ListMetadataStoresResponse, MetadataStore>(_callListMetadataStores, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteMetadataStore</c>.</summary>
        public override lro::OperationsClient DeleteMetadataStoreOperationsClient { get; }

        /// <summary>
        /// Deletes a single MetadataStore and all its child resources (Artifacts,
        /// Executions, and Contexts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata> DeleteMetadataStore(DeleteMetadataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMetadataStoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata>(_callDeleteMetadataStore.Sync(request, callSettings), DeleteMetadataStoreOperationsClient);
        }

        /// <summary>
        /// Deletes a single MetadataStore and all its child resources (Artifacts,
        /// Executions, and Contexts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata>> DeleteMetadataStoreAsync(DeleteMetadataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMetadataStoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteMetadataStoreOperationMetadata>(await _callDeleteMetadataStore.Async(request, callSettings).ConfigureAwait(false), DeleteMetadataStoreOperationsClient);
        }

        /// <summary>
        /// Creates an Artifact associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Artifact CreateArtifact(CreateArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateArtifactRequest(ref request, ref callSettings);
            return _callCreateArtifact.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an Artifact associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Artifact> CreateArtifactAsync(CreateArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateArtifactRequest(ref request, ref callSettings);
            return _callCreateArtifact.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a specific Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Artifact GetArtifact(GetArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetArtifactRequest(ref request, ref callSettings);
            return _callGetArtifact.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a specific Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Artifact> GetArtifactAsync(GetArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetArtifactRequest(ref request, ref callSettings);
            return _callGetArtifact.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Artifacts in the MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Artifact"/> resources.</returns>
        public override gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(ListArtifactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListArtifactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListArtifactsRequest, ListArtifactsResponse, Artifact>(_callListArtifacts, request, callSettings);
        }

        /// <summary>
        /// Lists Artifacts in the MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Artifact"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(ListArtifactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListArtifactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListArtifactsRequest, ListArtifactsResponse, Artifact>(_callListArtifacts, request, callSettings);
        }

        /// <summary>
        /// Updates a stored Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Artifact UpdateArtifact(UpdateArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateArtifactRequest(ref request, ref callSettings);
            return _callUpdateArtifact.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a stored Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Artifact> UpdateArtifactAsync(UpdateArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateArtifactRequest(ref request, ref callSettings);
            return _callUpdateArtifact.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteArtifact</c>.</summary>
        public override lro::OperationsClient DeleteArtifactOperationsClient { get; }

        /// <summary>
        /// Deletes an Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteArtifact(DeleteArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteArtifactRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteArtifact.Sync(request, callSettings), DeleteArtifactOperationsClient);
        }

        /// <summary>
        /// Deletes an Artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteArtifactAsync(DeleteArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteArtifactRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteArtifact.Async(request, callSettings).ConfigureAwait(false), DeleteArtifactOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PurgeArtifacts</c>.</summary>
        public override lro::OperationsClient PurgeArtifactsOperationsClient { get; }

        /// <summary>
        /// Purges Artifacts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> PurgeArtifacts(PurgeArtifactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeArtifactsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata>(_callPurgeArtifacts.Sync(request, callSettings), PurgeArtifactsOperationsClient);
        }

        /// <summary>
        /// Purges Artifacts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata>> PurgeArtifactsAsync(PurgeArtifactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeArtifactsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata>(await _callPurgeArtifacts.Async(request, callSettings).ConfigureAwait(false), PurgeArtifactsOperationsClient);
        }

        /// <summary>
        /// Creates a Context associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Context CreateContext(CreateContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateContextRequest(ref request, ref callSettings);
            return _callCreateContext.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Context associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Context> CreateContextAsync(CreateContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateContextRequest(ref request, ref callSettings);
            return _callCreateContext.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a specific Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Context GetContext(GetContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetContextRequest(ref request, ref callSettings);
            return _callGetContext.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a specific Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Context> GetContextAsync(GetContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetContextRequest(ref request, ref callSettings);
            return _callGetContext.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Contexts on the MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Context"/> resources.</returns>
        public override gax::PagedEnumerable<ListContextsResponse, Context> ListContexts(ListContextsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContextsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListContextsRequest, ListContextsResponse, Context>(_callListContexts, request, callSettings);
        }

        /// <summary>
        /// Lists Contexts on the MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Context"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListContextsResponse, Context> ListContextsAsync(ListContextsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContextsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListContextsRequest, ListContextsResponse, Context>(_callListContexts, request, callSettings);
        }

        /// <summary>
        /// Updates a stored Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Context UpdateContext(UpdateContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateContextRequest(ref request, ref callSettings);
            return _callUpdateContext.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a stored Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Context> UpdateContextAsync(UpdateContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateContextRequest(ref request, ref callSettings);
            return _callUpdateContext.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteContext</c>.</summary>
        public override lro::OperationsClient DeleteContextOperationsClient { get; }

        /// <summary>
        /// Deletes a stored Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteContext(DeleteContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteContextRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteContext.Sync(request, callSettings), DeleteContextOperationsClient);
        }

        /// <summary>
        /// Deletes a stored Context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteContextAsync(DeleteContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteContextRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteContext.Async(request, callSettings).ConfigureAwait(false), DeleteContextOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PurgeContexts</c>.</summary>
        public override lro::OperationsClient PurgeContextsOperationsClient { get; }

        /// <summary>
        /// Purges Contexts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PurgeContextsResponse, PurgeContextsMetadata> PurgeContexts(PurgeContextsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeContextsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeContextsResponse, PurgeContextsMetadata>(_callPurgeContexts.Sync(request, callSettings), PurgeContextsOperationsClient);
        }

        /// <summary>
        /// Purges Contexts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PurgeContextsResponse, PurgeContextsMetadata>> PurgeContextsAsync(PurgeContextsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeContextsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeContextsResponse, PurgeContextsMetadata>(await _callPurgeContexts.Async(request, callSettings).ConfigureAwait(false), PurgeContextsOperationsClient);
        }

        /// <summary>
        /// Adds a set of Artifacts and Executions to a Context. If any of the
        /// Artifacts or Executions have already been added to a Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AddContextArtifactsAndExecutionsResponse AddContextArtifactsAndExecutions(AddContextArtifactsAndExecutionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddContextArtifactsAndExecutionsRequest(ref request, ref callSettings);
            return _callAddContextArtifactsAndExecutions.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a set of Artifacts and Executions to a Context. If any of the
        /// Artifacts or Executions have already been added to a Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AddContextArtifactsAndExecutionsResponse> AddContextArtifactsAndExecutionsAsync(AddContextArtifactsAndExecutionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddContextArtifactsAndExecutionsRequest(ref request, ref callSettings);
            return _callAddContextArtifactsAndExecutions.Async(request, callSettings);
        }

        /// <summary>
        /// Adds a set of Contexts as children to a parent Context. If any of the
        /// child Contexts have already been added to the parent Context, they are
        /// simply skipped. If this call would create a cycle or cause any Context to
        /// have more than 10 parents, the request will fail with an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AddContextChildrenResponse AddContextChildren(AddContextChildrenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddContextChildrenRequest(ref request, ref callSettings);
            return _callAddContextChildren.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a set of Contexts as children to a parent Context. If any of the
        /// child Contexts have already been added to the parent Context, they are
        /// simply skipped. If this call would create a cycle or cause any Context to
        /// have more than 10 parents, the request will fail with an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AddContextChildrenResponse> AddContextChildrenAsync(AddContextChildrenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddContextChildrenRequest(ref request, ref callSettings);
            return _callAddContextChildren.Async(request, callSettings);
        }

        /// <summary>
        /// Remove a set of children contexts from a parent Context. If any of the
        /// child Contexts were NOT added to the parent Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoveContextChildrenResponse RemoveContextChildren(RemoveContextChildrenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveContextChildrenRequest(ref request, ref callSettings);
            return _callRemoveContextChildren.Sync(request, callSettings);
        }

        /// <summary>
        /// Remove a set of children contexts from a parent Context. If any of the
        /// child Contexts were NOT added to the parent Context, they are
        /// simply skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoveContextChildrenResponse> RemoveContextChildrenAsync(RemoveContextChildrenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveContextChildrenRequest(ref request, ref callSettings);
            return _callRemoveContextChildren.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves Artifacts and Executions within the specified Context, connected
        /// by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LineageSubgraph QueryContextLineageSubgraph(QueryContextLineageSubgraphRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryContextLineageSubgraphRequest(ref request, ref callSettings);
            return _callQueryContextLineageSubgraph.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves Artifacts and Executions within the specified Context, connected
        /// by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LineageSubgraph> QueryContextLineageSubgraphAsync(QueryContextLineageSubgraphRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryContextLineageSubgraphRequest(ref request, ref callSettings);
            return _callQueryContextLineageSubgraph.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an Execution associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Execution CreateExecution(CreateExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExecutionRequest(ref request, ref callSettings);
            return _callCreateExecution.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an Execution associated with a MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Execution> CreateExecutionAsync(CreateExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExecutionRequest(ref request, ref callSettings);
            return _callCreateExecution.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a specific Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Execution GetExecution(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExecutionRequest(ref request, ref callSettings);
            return _callGetExecution.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a specific Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Execution> GetExecutionAsync(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExecutionRequest(ref request, ref callSettings);
            return _callGetExecution.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Executions in the MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public override gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExecutionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExecutionsRequest, ListExecutionsResponse, Execution>(_callListExecutions, request, callSettings);
        }

        /// <summary>
        /// Lists Executions in the MetadataStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExecutionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExecutionsRequest, ListExecutionsResponse, Execution>(_callListExecutions, request, callSettings);
        }

        /// <summary>
        /// Updates a stored Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Execution UpdateExecution(UpdateExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExecutionRequest(ref request, ref callSettings);
            return _callUpdateExecution.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a stored Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Execution> UpdateExecutionAsync(UpdateExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExecutionRequest(ref request, ref callSettings);
            return _callUpdateExecution.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteExecution</c>.</summary>
        public override lro::OperationsClient DeleteExecutionOperationsClient { get; }

        /// <summary>
        /// Deletes an Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteExecution(DeleteExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExecutionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteExecution.Sync(request, callSettings), DeleteExecutionOperationsClient);
        }

        /// <summary>
        /// Deletes an Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExecutionAsync(DeleteExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExecutionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteExecution.Async(request, callSettings).ConfigureAwait(false), DeleteExecutionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PurgeExecutions</c>.</summary>
        public override lro::OperationsClient PurgeExecutionsOperationsClient { get; }

        /// <summary>
        /// Purges Executions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> PurgeExecutions(PurgeExecutionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeExecutionsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata>(_callPurgeExecutions.Sync(request, callSettings), PurgeExecutionsOperationsClient);
        }

        /// <summary>
        /// Purges Executions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata>> PurgeExecutionsAsync(PurgeExecutionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeExecutionsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata>(await _callPurgeExecutions.Async(request, callSettings).ConfigureAwait(false), PurgeExecutionsOperationsClient);
        }

        /// <summary>
        /// Adds Events to the specified Execution. An Event indicates whether an
        /// Artifact was used as an input or output for an Execution. If an Event
        /// already exists between the Execution and the Artifact, the Event is
        /// skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AddExecutionEventsResponse AddExecutionEvents(AddExecutionEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddExecutionEventsRequest(ref request, ref callSettings);
            return _callAddExecutionEvents.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds Events to the specified Execution. An Event indicates whether an
        /// Artifact was used as an input or output for an Execution. If an Event
        /// already exists between the Execution and the Artifact, the Event is
        /// skipped.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AddExecutionEventsResponse> AddExecutionEventsAsync(AddExecutionEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddExecutionEventsRequest(ref request, ref callSettings);
            return _callAddExecutionEvents.Async(request, callSettings);
        }

        /// <summary>
        /// Obtains the set of input and output Artifacts for this Execution, in the
        /// form of LineageSubgraph that also contains the Execution and connecting
        /// Events.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LineageSubgraph QueryExecutionInputsAndOutputs(QueryExecutionInputsAndOutputsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryExecutionInputsAndOutputsRequest(ref request, ref callSettings);
            return _callQueryExecutionInputsAndOutputs.Sync(request, callSettings);
        }

        /// <summary>
        /// Obtains the set of input and output Artifacts for this Execution, in the
        /// form of LineageSubgraph that also contains the Execution and connecting
        /// Events.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LineageSubgraph> QueryExecutionInputsAndOutputsAsync(QueryExecutionInputsAndOutputsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryExecutionInputsAndOutputsRequest(ref request, ref callSettings);
            return _callQueryExecutionInputsAndOutputs.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a MetadataSchema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MetadataSchema CreateMetadataSchema(CreateMetadataSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMetadataSchemaRequest(ref request, ref callSettings);
            return _callCreateMetadataSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a MetadataSchema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MetadataSchema> CreateMetadataSchemaAsync(CreateMetadataSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMetadataSchemaRequest(ref request, ref callSettings);
            return _callCreateMetadataSchema.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a specific MetadataSchema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MetadataSchema GetMetadataSchema(GetMetadataSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetadataSchemaRequest(ref request, ref callSettings);
            return _callGetMetadataSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a specific MetadataSchema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MetadataSchema> GetMetadataSchemaAsync(GetMetadataSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetadataSchemaRequest(ref request, ref callSettings);
            return _callGetMetadataSchema.Async(request, callSettings);
        }

        /// <summary>
        /// Lists MetadataSchemas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MetadataSchema"/> resources.</returns>
        public override gax::PagedEnumerable<ListMetadataSchemasResponse, MetadataSchema> ListMetadataSchemas(ListMetadataSchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMetadataSchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMetadataSchemasRequest, ListMetadataSchemasResponse, MetadataSchema>(_callListMetadataSchemas, request, callSettings);
        }

        /// <summary>
        /// Lists MetadataSchemas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MetadataSchema"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMetadataSchemasResponse, MetadataSchema> ListMetadataSchemasAsync(ListMetadataSchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMetadataSchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMetadataSchemasRequest, ListMetadataSchemasResponse, MetadataSchema>(_callListMetadataSchemas, request, callSettings);
        }

        /// <summary>
        /// Retrieves lineage of an Artifact represented through Artifacts and
        /// Executions connected by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LineageSubgraph QueryArtifactLineageSubgraph(QueryArtifactLineageSubgraphRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryArtifactLineageSubgraphRequest(ref request, ref callSettings);
            return _callQueryArtifactLineageSubgraph.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves lineage of an Artifact represented through Artifacts and
        /// Executions connected by Event edges and returned as a LineageSubgraph.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LineageSubgraph> QueryArtifactLineageSubgraphAsync(QueryArtifactLineageSubgraphRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryArtifactLineageSubgraphRequest(ref request, ref callSettings);
            return _callQueryArtifactLineageSubgraph.Async(request, callSettings);
        }
    }

    public partial class ListMetadataStoresRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListArtifactsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListContextsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExecutionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMetadataSchemasRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMetadataStoresResponse : gaxgrpc::IPageResponse<MetadataStore>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MetadataStore> GetEnumerator() => MetadataStores.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListArtifactsResponse : gaxgrpc::IPageResponse<Artifact>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Artifact> GetEnumerator() => Artifacts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListContextsResponse : gaxgrpc::IPageResponse<Context>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Context> GetEnumerator() => Contexts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListExecutionsResponse : gaxgrpc::IPageResponse<Execution>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Execution> GetEnumerator() => Executions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMetadataSchemasResponse : gaxgrpc::IPageResponse<MetadataSchema>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MetadataSchema> GetEnumerator() => MetadataSchemas.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class MetadataService
    {
        public partial class MetadataServiceClient
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

    public static partial class MetadataService
    {
        public partial class MetadataServiceClient
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
