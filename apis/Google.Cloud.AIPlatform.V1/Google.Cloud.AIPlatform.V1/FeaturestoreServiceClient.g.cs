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
    /// <summary>Settings for <see cref="FeaturestoreServiceClient"/> instances.</summary>
    public sealed partial class FeaturestoreServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeaturestoreServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeaturestoreServiceSettings"/>.</returns>
        public static FeaturestoreServiceSettings GetDefault() => new FeaturestoreServiceSettings();

        /// <summary>Constructs a new <see cref="FeaturestoreServiceSettings"/> object with default settings.</summary>
        public FeaturestoreServiceSettings()
        {
        }

        private FeaturestoreServiceSettings(FeaturestoreServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateFeaturestoreSettings = existing.CreateFeaturestoreSettings;
            CreateFeaturestoreOperationsSettings = existing.CreateFeaturestoreOperationsSettings.Clone();
            GetFeaturestoreSettings = existing.GetFeaturestoreSettings;
            ListFeaturestoresSettings = existing.ListFeaturestoresSettings;
            UpdateFeaturestoreSettings = existing.UpdateFeaturestoreSettings;
            UpdateFeaturestoreOperationsSettings = existing.UpdateFeaturestoreOperationsSettings.Clone();
            DeleteFeaturestoreSettings = existing.DeleteFeaturestoreSettings;
            DeleteFeaturestoreOperationsSettings = existing.DeleteFeaturestoreOperationsSettings.Clone();
            CreateEntityTypeSettings = existing.CreateEntityTypeSettings;
            CreateEntityTypeOperationsSettings = existing.CreateEntityTypeOperationsSettings.Clone();
            GetEntityTypeSettings = existing.GetEntityTypeSettings;
            ListEntityTypesSettings = existing.ListEntityTypesSettings;
            UpdateEntityTypeSettings = existing.UpdateEntityTypeSettings;
            DeleteEntityTypeSettings = existing.DeleteEntityTypeSettings;
            DeleteEntityTypeOperationsSettings = existing.DeleteEntityTypeOperationsSettings.Clone();
            CreateFeatureSettings = existing.CreateFeatureSettings;
            CreateFeatureOperationsSettings = existing.CreateFeatureOperationsSettings.Clone();
            BatchCreateFeaturesSettings = existing.BatchCreateFeaturesSettings;
            BatchCreateFeaturesOperationsSettings = existing.BatchCreateFeaturesOperationsSettings.Clone();
            GetFeatureSettings = existing.GetFeatureSettings;
            ListFeaturesSettings = existing.ListFeaturesSettings;
            UpdateFeatureSettings = existing.UpdateFeatureSettings;
            DeleteFeatureSettings = existing.DeleteFeatureSettings;
            DeleteFeatureOperationsSettings = existing.DeleteFeatureOperationsSettings.Clone();
            ImportFeatureValuesSettings = existing.ImportFeatureValuesSettings;
            ImportFeatureValuesOperationsSettings = existing.ImportFeatureValuesOperationsSettings.Clone();
            BatchReadFeatureValuesSettings = existing.BatchReadFeatureValuesSettings;
            BatchReadFeatureValuesOperationsSettings = existing.BatchReadFeatureValuesOperationsSettings.Clone();
            ExportFeatureValuesSettings = existing.ExportFeatureValuesSettings;
            ExportFeatureValuesOperationsSettings = existing.ExportFeatureValuesOperationsSettings.Clone();
            DeleteFeatureValuesSettings = existing.DeleteFeatureValuesSettings;
            DeleteFeatureValuesOperationsSettings = existing.DeleteFeatureValuesOperationsSettings.Clone();
            SearchFeaturesSettings = existing.SearchFeaturesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeaturestoreServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.CreateFeaturestore</c> and <c>FeaturestoreServiceClient.CreateFeaturestoreAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFeaturestoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeaturestoreServiceClient.CreateFeaturestore</c> and
        /// <c>FeaturestoreServiceClient.CreateFeaturestoreAsync</c>.
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
        public lro::OperationsSettings CreateFeaturestoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.GetFeaturestore</c> and <c>FeaturestoreServiceClient.GetFeaturestoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeaturestoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.ListFeaturestores</c> and <c>FeaturestoreServiceClient.ListFeaturestoresAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFeaturestoresSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.UpdateFeaturestore</c> and <c>FeaturestoreServiceClient.UpdateFeaturestoreAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFeaturestoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeaturestoreServiceClient.UpdateFeaturestore</c> and
        /// <c>FeaturestoreServiceClient.UpdateFeaturestoreAsync</c>.
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
        public lro::OperationsSettings UpdateFeaturestoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.DeleteFeaturestore</c> and <c>FeaturestoreServiceClient.DeleteFeaturestoreAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFeaturestoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeaturestoreServiceClient.DeleteFeaturestore</c> and
        /// <c>FeaturestoreServiceClient.DeleteFeaturestoreAsync</c>.
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
        public lro::OperationsSettings DeleteFeaturestoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.CreateEntityType</c> and <c>FeaturestoreServiceClient.CreateEntityTypeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEntityTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeaturestoreServiceClient.CreateEntityType</c> and
        /// <c>FeaturestoreServiceClient.CreateEntityTypeAsync</c>.
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
        public lro::OperationsSettings CreateEntityTypeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.GetEntityType</c> and <c>FeaturestoreServiceClient.GetEntityTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEntityTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.ListEntityTypes</c> and <c>FeaturestoreServiceClient.ListEntityTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntityTypesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.UpdateEntityType</c> and <c>FeaturestoreServiceClient.UpdateEntityTypeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEntityTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.DeleteEntityType</c> and <c>FeaturestoreServiceClient.DeleteEntityTypeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEntityTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeaturestoreServiceClient.DeleteEntityType</c> and
        /// <c>FeaturestoreServiceClient.DeleteEntityTypeAsync</c>.
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
        public lro::OperationsSettings DeleteEntityTypeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.CreateFeature</c> and <c>FeaturestoreServiceClient.CreateFeatureAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFeatureSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeaturestoreServiceClient.CreateFeature</c> and
        /// <c>FeaturestoreServiceClient.CreateFeatureAsync</c>.
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
        /// <c>FeaturestoreServiceClient.BatchCreateFeatures</c> and
        /// <c>FeaturestoreServiceClient.BatchCreateFeaturesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateFeaturesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeaturestoreServiceClient.BatchCreateFeatures</c> and
        /// <c>FeaturestoreServiceClient.BatchCreateFeaturesAsync</c>.
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
        public lro::OperationsSettings BatchCreateFeaturesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.GetFeature</c> and <c>FeaturestoreServiceClient.GetFeatureAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeatureSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.ListFeatures</c> and <c>FeaturestoreServiceClient.ListFeaturesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFeaturesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.UpdateFeature</c> and <c>FeaturestoreServiceClient.UpdateFeatureAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFeatureSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.DeleteFeature</c> and <c>FeaturestoreServiceClient.DeleteFeatureAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFeatureSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeaturestoreServiceClient.DeleteFeature</c> and
        /// <c>FeaturestoreServiceClient.DeleteFeatureAsync</c>.
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
        /// <c>FeaturestoreServiceClient.ImportFeatureValues</c> and
        /// <c>FeaturestoreServiceClient.ImportFeatureValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportFeatureValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeaturestoreServiceClient.ImportFeatureValues</c> and
        /// <c>FeaturestoreServiceClient.ImportFeatureValuesAsync</c>.
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
        public lro::OperationsSettings ImportFeatureValuesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.BatchReadFeatureValues</c> and
        /// <c>FeaturestoreServiceClient.BatchReadFeatureValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchReadFeatureValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeaturestoreServiceClient.BatchReadFeatureValues</c> and
        /// <c>FeaturestoreServiceClient.BatchReadFeatureValuesAsync</c>.
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
        public lro::OperationsSettings BatchReadFeatureValuesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.ExportFeatureValues</c> and
        /// <c>FeaturestoreServiceClient.ExportFeatureValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportFeatureValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeaturestoreServiceClient.ExportFeatureValues</c> and
        /// <c>FeaturestoreServiceClient.ExportFeatureValuesAsync</c>.
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
        public lro::OperationsSettings ExportFeatureValuesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.DeleteFeatureValues</c> and
        /// <c>FeaturestoreServiceClient.DeleteFeatureValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFeatureValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeaturestoreServiceClient.DeleteFeatureValues</c> and
        /// <c>FeaturestoreServiceClient.DeleteFeatureValuesAsync</c>.
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
        public lro::OperationsSettings DeleteFeatureValuesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreServiceClient.SearchFeatures</c> and <c>FeaturestoreServiceClient.SearchFeaturesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchFeaturesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeaturestoreServiceSettings"/> object.</returns>
        public FeaturestoreServiceSettings Clone() => new FeaturestoreServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeaturestoreServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class FeaturestoreServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeaturestoreServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeaturestoreServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FeaturestoreServiceClientBuilder() : base(FeaturestoreServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FeaturestoreServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeaturestoreServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeaturestoreServiceClient Build()
        {
            FeaturestoreServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeaturestoreServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeaturestoreServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeaturestoreServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeaturestoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FeaturestoreServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeaturestoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeaturestoreServiceClient.ChannelPool;
    }

    /// <summary>FeaturestoreService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that handles CRUD and List for resources for Featurestore.
    /// </remarks>
    public abstract partial class FeaturestoreServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeaturestoreService service, which is a host of "aiplatform.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default FeaturestoreService scopes.</summary>
        /// <remarks>
        /// The default FeaturestoreService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FeaturestoreService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FeaturestoreServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="FeaturestoreServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeaturestoreServiceClient"/>.</returns>
        public static stt::Task<FeaturestoreServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeaturestoreServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeaturestoreServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="FeaturestoreServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FeaturestoreServiceClient"/>.</returns>
        public static FeaturestoreServiceClient Create() => new FeaturestoreServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeaturestoreServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeaturestoreServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FeaturestoreServiceClient"/>.</returns>
        internal static FeaturestoreServiceClient Create(grpccore::CallInvoker callInvoker, FeaturestoreServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeaturestoreService.FeaturestoreServiceClient grpcClient = new FeaturestoreService.FeaturestoreServiceClient(callInvoker);
            return new FeaturestoreServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FeaturestoreService client</summary>
        public virtual FeaturestoreService.FeaturestoreServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata> CreateFeaturestore(CreateFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>> CreateFeaturestoreAsync(CreateFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>> CreateFeaturestoreAsync(CreateFeaturestoreRequest request, st::CancellationToken cancellationToken) =>
            CreateFeaturestoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFeaturestore</c>.</summary>
        public virtual lro::OperationsClient CreateFeaturestoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateFeaturestore</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata> PollOnceCreateFeaturestore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeaturestoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFeaturestore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>> PollOnceCreateFeaturestoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeaturestoreOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create Featurestores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featurestore">
        /// Required. The Featurestore to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata> CreateFeaturestore(string parent, Featurestore featurestore, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeaturestore(new CreateFeaturestoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Featurestore = gax::GaxPreconditions.CheckNotNull(featurestore, nameof(featurestore)),
            }, callSettings);

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create Featurestores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featurestore">
        /// Required. The Featurestore to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>> CreateFeaturestoreAsync(string parent, Featurestore featurestore, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeaturestoreAsync(new CreateFeaturestoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Featurestore = gax::GaxPreconditions.CheckNotNull(featurestore, nameof(featurestore)),
            }, callSettings);

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create Featurestores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featurestore">
        /// Required. The Featurestore to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>> CreateFeaturestoreAsync(string parent, Featurestore featurestore, st::CancellationToken cancellationToken) =>
            CreateFeaturestoreAsync(parent, featurestore, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create Featurestores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featurestore">
        /// Required. The Featurestore to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata> CreateFeaturestore(gagr::LocationName parent, Featurestore featurestore, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeaturestore(new CreateFeaturestoreRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Featurestore = gax::GaxPreconditions.CheckNotNull(featurestore, nameof(featurestore)),
            }, callSettings);

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create Featurestores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featurestore">
        /// Required. The Featurestore to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>> CreateFeaturestoreAsync(gagr::LocationName parent, Featurestore featurestore, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeaturestoreAsync(new CreateFeaturestoreRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Featurestore = gax::GaxPreconditions.CheckNotNull(featurestore, nameof(featurestore)),
            }, callSettings);

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create Featurestores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featurestore">
        /// Required. The Featurestore to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>> CreateFeaturestoreAsync(gagr::LocationName parent, Featurestore featurestore, st::CancellationToken cancellationToken) =>
            CreateFeaturestoreAsync(parent, featurestore, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create Featurestores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featurestore">
        /// Required. The Featurestore to create.
        /// </param>
        /// <param name="featurestoreId">
        /// Required. The ID to use for this Featurestore, which will become the final
        /// component of the Featurestore's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata> CreateFeaturestore(string parent, Featurestore featurestore, string featurestoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeaturestore(new CreateFeaturestoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Featurestore = gax::GaxPreconditions.CheckNotNull(featurestore, nameof(featurestore)),
                FeaturestoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(featurestoreId, nameof(featurestoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create Featurestores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featurestore">
        /// Required. The Featurestore to create.
        /// </param>
        /// <param name="featurestoreId">
        /// Required. The ID to use for this Featurestore, which will become the final
        /// component of the Featurestore's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>> CreateFeaturestoreAsync(string parent, Featurestore featurestore, string featurestoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeaturestoreAsync(new CreateFeaturestoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Featurestore = gax::GaxPreconditions.CheckNotNull(featurestore, nameof(featurestore)),
                FeaturestoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(featurestoreId, nameof(featurestoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create Featurestores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featurestore">
        /// Required. The Featurestore to create.
        /// </param>
        /// <param name="featurestoreId">
        /// Required. The ID to use for this Featurestore, which will become the final
        /// component of the Featurestore's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>> CreateFeaturestoreAsync(string parent, Featurestore featurestore, string featurestoreId, st::CancellationToken cancellationToken) =>
            CreateFeaturestoreAsync(parent, featurestore, featurestoreId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create Featurestores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featurestore">
        /// Required. The Featurestore to create.
        /// </param>
        /// <param name="featurestoreId">
        /// Required. The ID to use for this Featurestore, which will become the final
        /// component of the Featurestore's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata> CreateFeaturestore(gagr::LocationName parent, Featurestore featurestore, string featurestoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeaturestore(new CreateFeaturestoreRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Featurestore = gax::GaxPreconditions.CheckNotNull(featurestore, nameof(featurestore)),
                FeaturestoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(featurestoreId, nameof(featurestoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create Featurestores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featurestore">
        /// Required. The Featurestore to create.
        /// </param>
        /// <param name="featurestoreId">
        /// Required. The ID to use for this Featurestore, which will become the final
        /// component of the Featurestore's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>> CreateFeaturestoreAsync(gagr::LocationName parent, Featurestore featurestore, string featurestoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeaturestoreAsync(new CreateFeaturestoreRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Featurestore = gax::GaxPreconditions.CheckNotNull(featurestore, nameof(featurestore)),
                FeaturestoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(featurestoreId, nameof(featurestoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create Featurestores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featurestore">
        /// Required. The Featurestore to create.
        /// </param>
        /// <param name="featurestoreId">
        /// Required. The ID to use for this Featurestore, which will become the final
        /// component of the Featurestore's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>> CreateFeaturestoreAsync(gagr::LocationName parent, Featurestore featurestore, string featurestoreId, st::CancellationToken cancellationToken) =>
            CreateFeaturestoreAsync(parent, featurestore, featurestoreId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Featurestore GetFeaturestore(GetFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Featurestore> GetFeaturestoreAsync(GetFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Featurestore> GetFeaturestoreAsync(GetFeaturestoreRequest request, st::CancellationToken cancellationToken) =>
            GetFeaturestoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Featurestore.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Featurestore GetFeaturestore(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeaturestore(new GetFeaturestoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Featurestore.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Featurestore> GetFeaturestoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeaturestoreAsync(new GetFeaturestoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Featurestore.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Featurestore> GetFeaturestoreAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeaturestoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Featurestore.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Featurestore GetFeaturestore(FeaturestoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeaturestore(new GetFeaturestoreRequest
            {
                FeaturestoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Featurestore.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Featurestore> GetFeaturestoreAsync(FeaturestoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeaturestoreAsync(new GetFeaturestoreRequest
            {
                FeaturestoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Featurestore.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Featurestore> GetFeaturestoreAsync(FeaturestoreName name, st::CancellationToken cancellationToken) =>
            GetFeaturestoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Featurestores in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Featurestore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturestoresResponse, Featurestore> ListFeaturestores(ListFeaturestoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Featurestores in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Featurestore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturestoresResponse, Featurestore> ListFeaturestoresAsync(ListFeaturestoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Featurestores in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Featurestores.
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
        /// <returns>A pageable sequence of <see cref="Featurestore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturestoresResponse, Featurestore> ListFeaturestores(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturestoresRequest request = new ListFeaturestoresRequest
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
            return ListFeaturestores(request, callSettings);
        }

        /// <summary>
        /// Lists Featurestores in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Featurestores.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Featurestore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturestoresResponse, Featurestore> ListFeaturestoresAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturestoresRequest request = new ListFeaturestoresRequest
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
            return ListFeaturestoresAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Featurestores in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Featurestores.
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
        /// <returns>A pageable sequence of <see cref="Featurestore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturestoresResponse, Featurestore> ListFeaturestores(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturestoresRequest request = new ListFeaturestoresRequest
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
            return ListFeaturestores(request, callSettings);
        }

        /// <summary>
        /// Lists Featurestores in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Featurestores.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Featurestore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturestoresResponse, Featurestore> ListFeaturestoresAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturestoresRequest request = new ListFeaturestoresRequest
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
            return ListFeaturestoresAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata> UpdateFeaturestore(UpdateFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata>> UpdateFeaturestoreAsync(UpdateFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata>> UpdateFeaturestoreAsync(UpdateFeaturestoreRequest request, st::CancellationToken cancellationToken) =>
            UpdateFeaturestoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFeaturestore</c>.</summary>
        public virtual lro::OperationsClient UpdateFeaturestoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateFeaturestore</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata> PollOnceUpdateFeaturestore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeaturestoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFeaturestore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata>> PollOnceUpdateFeaturestoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeaturestoreOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Featurestore.
        /// </summary>
        /// <param name="featurestore">
        /// Required. The Featurestore's `name` field is used to identify the
        /// Featurestore to be updated. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Featurestore resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `labels`
        /// * `online_serving_config.fixed_node_count`
        /// * `online_serving_config.scaling`
        /// * `online_storage_ttl_days`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata> UpdateFeaturestore(Featurestore featurestore, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeaturestore(new UpdateFeaturestoreRequest
            {
                Featurestore = gax::GaxPreconditions.CheckNotNull(featurestore, nameof(featurestore)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Featurestore.
        /// </summary>
        /// <param name="featurestore">
        /// Required. The Featurestore's `name` field is used to identify the
        /// Featurestore to be updated. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Featurestore resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `labels`
        /// * `online_serving_config.fixed_node_count`
        /// * `online_serving_config.scaling`
        /// * `online_storage_ttl_days`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata>> UpdateFeaturestoreAsync(Featurestore featurestore, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeaturestoreAsync(new UpdateFeaturestoreRequest
            {
                Featurestore = gax::GaxPreconditions.CheckNotNull(featurestore, nameof(featurestore)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Featurestore.
        /// </summary>
        /// <param name="featurestore">
        /// Required. The Featurestore's `name` field is used to identify the
        /// Featurestore to be updated. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Featurestore resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `labels`
        /// * `online_serving_config.fixed_node_count`
        /// * `online_serving_config.scaling`
        /// * `online_storage_ttl_days`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata>> UpdateFeaturestoreAsync(Featurestore featurestore, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFeaturestoreAsync(featurestore, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeaturestore(DeleteFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeaturestoreAsync(DeleteFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeaturestoreAsync(DeleteFeaturestoreRequest request, st::CancellationToken cancellationToken) =>
            DeleteFeaturestoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFeaturestore</c>.</summary>
        public virtual lro::OperationsClient DeleteFeaturestoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFeaturestore</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteFeaturestore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeaturestoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFeaturestore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteFeaturestoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeaturestoreOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeaturestore(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeaturestore(new DeleteFeaturestoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeaturestoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeaturestoreAsync(new DeleteFeaturestoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeaturestoreAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFeaturestoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeaturestore(FeaturestoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeaturestore(new DeleteFeaturestoreRequest
            {
                FeaturestoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeaturestoreAsync(FeaturestoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeaturestoreAsync(new DeleteFeaturestoreRequest
            {
                FeaturestoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeaturestoreAsync(FeaturestoreName name, st::CancellationToken cancellationToken) =>
            DeleteFeaturestoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="force">
        /// If set to true, any EntityTypes and Features for this Featurestore will
        /// also be deleted. (Otherwise, the request will only work if the Featurestore
        /// has no EntityTypes.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeaturestore(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeaturestore(new DeleteFeaturestoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="force">
        /// If set to true, any EntityTypes and Features for this Featurestore will
        /// also be deleted. (Otherwise, the request will only work if the Featurestore
        /// has no EntityTypes.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeaturestoreAsync(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeaturestoreAsync(new DeleteFeaturestoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="force">
        /// If set to true, any EntityTypes and Features for this Featurestore will
        /// also be deleted. (Otherwise, the request will only work if the Featurestore
        /// has no EntityTypes.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeaturestoreAsync(string name, bool force, st::CancellationToken cancellationToken) =>
            DeleteFeaturestoreAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="force">
        /// If set to true, any EntityTypes and Features for this Featurestore will
        /// also be deleted. (Otherwise, the request will only work if the Featurestore
        /// has no EntityTypes.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeaturestore(FeaturestoreName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeaturestore(new DeleteFeaturestoreRequest
            {
                FeaturestoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="force">
        /// If set to true, any EntityTypes and Features for this Featurestore will
        /// also be deleted. (Otherwise, the request will only work if the Featurestore
        /// has no EntityTypes.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeaturestoreAsync(FeaturestoreName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeaturestoreAsync(new DeleteFeaturestoreRequest
            {
                FeaturestoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Featurestore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="force">
        /// If set to true, any EntityTypes and Features for this Featurestore will
        /// also be deleted. (Otherwise, the request will only work if the Featurestore
        /// has no EntityTypes.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeaturestoreAsync(FeaturestoreName name, bool force, st::CancellationToken cancellationToken) =>
            DeleteFeaturestoreAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntityType, CreateEntityTypeOperationMetadata> CreateEntityType(CreateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntityType, CreateEntityTypeOperationMetadata>> CreateEntityTypeAsync(CreateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntityType, CreateEntityTypeOperationMetadata>> CreateEntityTypeAsync(CreateEntityTypeRequest request, st::CancellationToken cancellationToken) =>
            CreateEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEntityType</c>.</summary>
        public virtual lro::OperationsClient CreateEntityTypeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEntityType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EntityType, CreateEntityTypeOperationMetadata> PollOnceCreateEntityType(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EntityType, CreateEntityTypeOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEntityTypeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEntityType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EntityType, CreateEntityTypeOperationMetadata>> PollOnceCreateEntityTypeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EntityType, CreateEntityTypeOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEntityTypeOperationsClient, callSettings);

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to create EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="entityType">
        /// The EntityType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntityType, CreateEntityTypeOperationMetadata> CreateEntityType(string parent, EntityType entityType, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityType(new CreateEntityTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityType = entityType,
            }, callSettings);

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to create EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="entityType">
        /// The EntityType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntityType, CreateEntityTypeOperationMetadata>> CreateEntityTypeAsync(string parent, EntityType entityType, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityTypeAsync(new CreateEntityTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityType = entityType,
            }, callSettings);

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to create EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="entityType">
        /// The EntityType to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntityType, CreateEntityTypeOperationMetadata>> CreateEntityTypeAsync(string parent, EntityType entityType, st::CancellationToken cancellationToken) =>
            CreateEntityTypeAsync(parent, entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to create EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="entityType">
        /// The EntityType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntityType, CreateEntityTypeOperationMetadata> CreateEntityType(FeaturestoreName parent, EntityType entityType, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityType(new CreateEntityTypeRequest
            {
                ParentAsFeaturestoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityType = entityType,
            }, callSettings);

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to create EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="entityType">
        /// The EntityType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntityType, CreateEntityTypeOperationMetadata>> CreateEntityTypeAsync(FeaturestoreName parent, EntityType entityType, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityTypeAsync(new CreateEntityTypeRequest
            {
                ParentAsFeaturestoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityType = entityType,
            }, callSettings);

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to create EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="entityType">
        /// The EntityType to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntityType, CreateEntityTypeOperationMetadata>> CreateEntityTypeAsync(FeaturestoreName parent, EntityType entityType, st::CancellationToken cancellationToken) =>
            CreateEntityTypeAsync(parent, entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to create EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="entityType">
        /// The EntityType to create.
        /// </param>
        /// <param name="entityTypeId">
        /// Required. The ID to use for the EntityType, which will become the final
        /// component of the EntityType's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within a featurestore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntityType, CreateEntityTypeOperationMetadata> CreateEntityType(string parent, EntityType entityType, string entityTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityType(new CreateEntityTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityType = entityType,
                EntityTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)),
            }, callSettings);

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to create EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="entityType">
        /// The EntityType to create.
        /// </param>
        /// <param name="entityTypeId">
        /// Required. The ID to use for the EntityType, which will become the final
        /// component of the EntityType's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within a featurestore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntityType, CreateEntityTypeOperationMetadata>> CreateEntityTypeAsync(string parent, EntityType entityType, string entityTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityTypeAsync(new CreateEntityTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityType = entityType,
                EntityTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)),
            }, callSettings);

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to create EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="entityType">
        /// The EntityType to create.
        /// </param>
        /// <param name="entityTypeId">
        /// Required. The ID to use for the EntityType, which will become the final
        /// component of the EntityType's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within a featurestore.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntityType, CreateEntityTypeOperationMetadata>> CreateEntityTypeAsync(string parent, EntityType entityType, string entityTypeId, st::CancellationToken cancellationToken) =>
            CreateEntityTypeAsync(parent, entityType, entityTypeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to create EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="entityType">
        /// The EntityType to create.
        /// </param>
        /// <param name="entityTypeId">
        /// Required. The ID to use for the EntityType, which will become the final
        /// component of the EntityType's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within a featurestore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntityType, CreateEntityTypeOperationMetadata> CreateEntityType(FeaturestoreName parent, EntityType entityType, string entityTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityType(new CreateEntityTypeRequest
            {
                ParentAsFeaturestoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityType = entityType,
                EntityTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)),
            }, callSettings);

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to create EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="entityType">
        /// The EntityType to create.
        /// </param>
        /// <param name="entityTypeId">
        /// Required. The ID to use for the EntityType, which will become the final
        /// component of the EntityType's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within a featurestore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntityType, CreateEntityTypeOperationMetadata>> CreateEntityTypeAsync(FeaturestoreName parent, EntityType entityType, string entityTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityTypeAsync(new CreateEntityTypeRequest
            {
                ParentAsFeaturestoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityType = entityType,
                EntityTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)),
            }, callSettings);

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to create EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="entityType">
        /// The EntityType to create.
        /// </param>
        /// <param name="entityTypeId">
        /// Required. The ID to use for the EntityType, which will become the final
        /// component of the EntityType's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within a featurestore.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntityType, CreateEntityTypeOperationMetadata>> CreateEntityTypeAsync(FeaturestoreName parent, EntityType entityType, string entityTypeId, st::CancellationToken cancellationToken) =>
            CreateEntityTypeAsync(parent, entityType, entityTypeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType GetEntityType(GetEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(GetEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(GetEntityTypeRequest request, st::CancellationToken cancellationToken) =>
            GetEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single EntityType.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType GetEntityType(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityType(new GetEntityTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EntityType.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityTypeAsync(new GetEntityTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EntityType.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(string name, st::CancellationToken cancellationToken) =>
            GetEntityTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single EntityType.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType GetEntityType(EntityTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityType(new GetEntityTypeRequest
            {
                EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EntityType.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(EntityTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityTypeAsync(new GetEntityTypeRequest
            {
                EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EntityType.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(EntityTypeName name, st::CancellationToken cancellationToken) =>
            GetEntityTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists EntityTypes in a given Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntityType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(ListEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EntityTypes in a given Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntityType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(ListEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EntityTypes in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to list EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
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
        /// <returns>A pageable sequence of <see cref="EntityType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntityTypesRequest request = new ListEntityTypesRequest
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
            return ListEntityTypes(request, callSettings);
        }

        /// <summary>
        /// Lists EntityTypes in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to list EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntityType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntityTypesRequest request = new ListEntityTypesRequest
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
            return ListEntityTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists EntityTypes in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to list EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
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
        /// <returns>A pageable sequence of <see cref="EntityType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(FeaturestoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                ParentAsFeaturestoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntityTypes(request, callSettings);
        }

        /// <summary>
        /// Lists EntityTypes in a given Featurestore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Featurestore to list EntityTypes.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntityType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(FeaturestoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                ParentAsFeaturestoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntityTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType UpdateEntityType(UpdateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(UpdateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(UpdateEntityTypeRequest request, st::CancellationToken cancellationToken) =>
            UpdateEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single EntityType.
        /// </summary>
        /// <param name="entityType">
        /// Required. The EntityType's `name` field is used to identify the EntityType
        /// to be updated. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// EntityType resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `description`
        /// * `labels`
        /// * `monitoring_config.snapshot_analysis.disabled`
        /// * `monitoring_config.snapshot_analysis.monitoring_interval_days`
        /// * `monitoring_config.snapshot_analysis.staleness_days`
        /// * `monitoring_config.import_features_analysis.state`
        /// * `monitoring_config.import_features_analysis.anomaly_detection_baseline`
        /// * `monitoring_config.numerical_threshold_config.value`
        /// * `monitoring_config.categorical_threshold_config.value`
        /// * `offline_storage_ttl_days`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType UpdateEntityType(EntityType entityType, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntityType(new UpdateEntityTypeRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single EntityType.
        /// </summary>
        /// <param name="entityType">
        /// Required. The EntityType's `name` field is used to identify the EntityType
        /// to be updated. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// EntityType resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `description`
        /// * `labels`
        /// * `monitoring_config.snapshot_analysis.disabled`
        /// * `monitoring_config.snapshot_analysis.monitoring_interval_days`
        /// * `monitoring_config.snapshot_analysis.staleness_days`
        /// * `monitoring_config.import_features_analysis.state`
        /// * `monitoring_config.import_features_analysis.anomaly_detection_baseline`
        /// * `monitoring_config.numerical_threshold_config.value`
        /// * `monitoring_config.categorical_threshold_config.value`
        /// * `offline_storage_ttl_days`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(EntityType entityType, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntityTypeAsync(new UpdateEntityTypeRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single EntityType.
        /// </summary>
        /// <param name="entityType">
        /// Required. The EntityType's `name` field is used to identify the EntityType
        /// to be updated. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// EntityType resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `description`
        /// * `labels`
        /// * `monitoring_config.snapshot_analysis.disabled`
        /// * `monitoring_config.snapshot_analysis.monitoring_interval_days`
        /// * `monitoring_config.snapshot_analysis.staleness_days`
        /// * `monitoring_config.import_features_analysis.state`
        /// * `monitoring_config.import_features_analysis.anomaly_detection_baseline`
        /// * `monitoring_config.numerical_threshold_config.value`
        /// * `monitoring_config.categorical_threshold_config.value`
        /// * `offline_storage_ttl_days`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(EntityType entityType, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEntityTypeAsync(entityType, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteEntityType(DeleteEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEntityTypeAsync(DeleteEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEntityTypeAsync(DeleteEntityTypeRequest request, st::CancellationToken cancellationToken) =>
            DeleteEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEntityType</c>.</summary>
        public virtual lro::OperationsClient DeleteEntityTypeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEntityType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteEntityType(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEntityTypeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEntityType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteEntityTypeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEntityTypeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteEntityType(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityType(new DeleteEntityTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEntityTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityTypeAsync(new DeleteEntityTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEntityTypeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEntityTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteEntityType(EntityTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityType(new DeleteEntityTypeRequest
            {
                EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEntityTypeAsync(EntityTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityTypeAsync(new DeleteEntityTypeRequest
            {
                EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEntityTypeAsync(EntityTypeName name, st::CancellationToken cancellationToken) =>
            DeleteEntityTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="force">
        /// If set to true, any Features for this EntityType will also be deleted.
        /// (Otherwise, the request will only work if the EntityType has no Features.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteEntityType(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityType(new DeleteEntityTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="force">
        /// If set to true, any Features for this EntityType will also be deleted.
        /// (Otherwise, the request will only work if the EntityType has no Features.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEntityTypeAsync(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityTypeAsync(new DeleteEntityTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="force">
        /// If set to true, any Features for this EntityType will also be deleted.
        /// (Otherwise, the request will only work if the EntityType has no Features.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEntityTypeAsync(string name, bool force, st::CancellationToken cancellationToken) =>
            DeleteEntityTypeAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="force">
        /// If set to true, any Features for this EntityType will also be deleted.
        /// (Otherwise, the request will only work if the EntityType has no Features.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteEntityType(EntityTypeName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityType(new DeleteEntityTypeRequest
            {
                EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="force">
        /// If set to true, any Features for this EntityType will also be deleted.
        /// (Otherwise, the request will only work if the EntityType has no Features.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEntityTypeAsync(EntityTypeName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityTypeAsync(new DeleteEntityTypeRequest
            {
                EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityType to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="force">
        /// If set to true, any Features for this EntityType will also be deleted.
        /// (Otherwise, the request will only work if the EntityType has no Features.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEntityTypeAsync(EntityTypeName name, bool force, st::CancellationToken cancellationToken) =>
            DeleteEntityTypeAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, CreateFeatureOperationMetadata> CreateFeature(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(CreateFeatureRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Feature, CreateFeatureOperationMetadata> PollOnceCreateFeature(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, CreateFeatureOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> PollOnceCreateFeatureAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, CreateFeatureOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, CreateFeatureOperationMetadata> CreateFeature(string parent, Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeature(new CreateFeatureRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(string parent, Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureAsync(new CreateFeatureRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(string parent, Feature feature, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(parent, feature, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, CreateFeatureOperationMetadata> CreateFeature(EntityTypeName parent, Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeature(new CreateFeatureRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(EntityTypeName parent, Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureAsync(new CreateFeatureRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(EntityTypeName parent, Feature feature, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(parent, feature, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, CreateFeatureOperationMetadata> CreateFeature(FeatureGroupName parent, Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeature(new CreateFeatureRequest
            {
                ParentAsFeatureGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(FeatureGroupName parent, Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureAsync(new CreateFeatureRequest
            {
                ParentAsFeatureGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(FeatureGroupName parent, Feature feature, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(parent, feature, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, CreateFeatureOperationMetadata> CreateFeature(string parent, Feature feature, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeature(new CreateFeatureRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                FeatureId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(string parent, Feature feature, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureAsync(new CreateFeatureRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                FeatureId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(string parent, Feature feature, string featureId, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(parent, feature, featureId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, CreateFeatureOperationMetadata> CreateFeature(EntityTypeName parent, Feature feature, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeature(new CreateFeatureRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                FeatureId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(EntityTypeName parent, Feature feature, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureAsync(new CreateFeatureRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                FeatureId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(EntityTypeName parent, Feature feature, string featureId, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(parent, feature, featureId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, CreateFeatureOperationMetadata> CreateFeature(FeatureGroupName parent, Feature feature, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeature(new CreateFeatureRequest
            {
                ParentAsFeatureGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                FeatureId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(FeatureGroupName parent, Feature feature, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureAsync(new CreateFeatureRequest
            {
                ParentAsFeatureGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                FeatureId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(FeatureGroupName parent, Feature feature, string featureId, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(parent, feature, featureId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> BatchCreateFeatures(BatchCreateFeaturesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>> BatchCreateFeaturesAsync(BatchCreateFeaturesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>> BatchCreateFeaturesAsync(BatchCreateFeaturesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateFeaturesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchCreateFeatures</c>.</summary>
        public virtual lro::OperationsClient BatchCreateFeaturesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchCreateFeatures</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> PollOnceBatchCreateFeatures(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreateFeaturesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchCreateFeatures</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>> PollOnceBatchCreateFeaturesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreateFeaturesOperationsClient, callSettings);

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType/FeatureGroup to create the
        /// batch of Features under. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the Features to create. All
        /// Features must be created under the same parent EntityType / FeatureGroup.
        /// The `parent` field in each child request message can be omitted. If
        /// `parent` is set in a child request, then the value must match the `parent`
        /// value in this request message.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> BatchCreateFeatures(string parent, scg::IEnumerable<CreateFeatureRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateFeatures(new BatchCreateFeaturesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType/FeatureGroup to create the
        /// batch of Features under. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the Features to create. All
        /// Features must be created under the same parent EntityType / FeatureGroup.
        /// The `parent` field in each child request message can be omitted. If
        /// `parent` is set in a child request, then the value must match the `parent`
        /// value in this request message.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>> BatchCreateFeaturesAsync(string parent, scg::IEnumerable<CreateFeatureRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateFeaturesAsync(new BatchCreateFeaturesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType/FeatureGroup to create the
        /// batch of Features under. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the Features to create. All
        /// Features must be created under the same parent EntityType / FeatureGroup.
        /// The `parent` field in each child request message can be omitted. If
        /// `parent` is set in a child request, then the value must match the `parent`
        /// value in this request message.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>> BatchCreateFeaturesAsync(string parent, scg::IEnumerable<CreateFeatureRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateFeaturesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType/FeatureGroup to create the
        /// batch of Features under. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the Features to create. All
        /// Features must be created under the same parent EntityType / FeatureGroup.
        /// The `parent` field in each child request message can be omitted. If
        /// `parent` is set in a child request, then the value must match the `parent`
        /// value in this request message.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> BatchCreateFeatures(EntityTypeName parent, scg::IEnumerable<CreateFeatureRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateFeatures(new BatchCreateFeaturesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType/FeatureGroup to create the
        /// batch of Features under. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the Features to create. All
        /// Features must be created under the same parent EntityType / FeatureGroup.
        /// The `parent` field in each child request message can be omitted. If
        /// `parent` is set in a child request, then the value must match the `parent`
        /// value in this request message.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>> BatchCreateFeaturesAsync(EntityTypeName parent, scg::IEnumerable<CreateFeatureRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateFeaturesAsync(new BatchCreateFeaturesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType/FeatureGroup to create the
        /// batch of Features under. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the Features to create. All
        /// Features must be created under the same parent EntityType / FeatureGroup.
        /// The `parent` field in each child request message can be omitted. If
        /// `parent` is set in a child request, then the value must match the `parent`
        /// value in this request message.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>> BatchCreateFeaturesAsync(EntityTypeName parent, scg::IEnumerable<CreateFeatureRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateFeaturesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType/FeatureGroup to create the
        /// batch of Features under. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the Features to create. All
        /// Features must be created under the same parent EntityType / FeatureGroup.
        /// The `parent` field in each child request message can be omitted. If
        /// `parent` is set in a child request, then the value must match the `parent`
        /// value in this request message.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> BatchCreateFeatures(FeatureGroupName parent, scg::IEnumerable<CreateFeatureRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateFeatures(new BatchCreateFeaturesRequest
            {
                ParentAsFeatureGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType/FeatureGroup to create the
        /// batch of Features under. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the Features to create. All
        /// Features must be created under the same parent EntityType / FeatureGroup.
        /// The `parent` field in each child request message can be omitted. If
        /// `parent` is set in a child request, then the value must match the `parent`
        /// value in this request message.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>> BatchCreateFeaturesAsync(FeatureGroupName parent, scg::IEnumerable<CreateFeatureRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateFeaturesAsync(new BatchCreateFeaturesRequest
            {
                ParentAsFeatureGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType/FeatureGroup to create the
        /// batch of Features under. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the Features to create. All
        /// Features must be created under the same parent EntityType / FeatureGroup.
        /// The `parent` field in each child request message can be omitted. If
        /// `parent` is set in a child request, then the value must match the `parent`
        /// value in this request message.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>> BatchCreateFeaturesAsync(FeatureGroupName parent, scg::IEnumerable<CreateFeatureRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateFeaturesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. The name of the Feature resource.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feature GetFeature(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeature(new GetFeatureRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feature resource.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureAsync(new GetFeatureRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feature resource.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feature resource.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feature GetFeature(FeatureName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeature(new GetFeatureRequest
            {
                FeatureName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feature resource.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(FeatureName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureAsync(new GetFeatureRequest
            {
                FeatureName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feature resource.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(FeatureName name, st::CancellationToken cancellationToken) =>
            GetFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Features in a given EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Features in a given EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Features.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
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
            ListFeaturesRequest request = new ListFeaturesRequest
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
            return ListFeatures(request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Features.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
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
            ListFeaturesRequest request = new ListFeaturesRequest
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
            return ListFeaturesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Features.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
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
        public virtual gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(EntityTypeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Features.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
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
        public virtual gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(EntityTypeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Features.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
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
        public virtual gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(FeatureGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsFeatureGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists Features in a given EntityType.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Features.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
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
        public virtual gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(FeatureGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsFeatureGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feature UpdateFeature(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> UpdateFeatureAsync(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> UpdateFeatureAsync(UpdateFeatureRequest request, st::CancellationToken cancellationToken) =>
            UpdateFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="feature">
        /// Required. The Feature's `name` field is used to identify the Feature to be
        /// updated.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Features resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `description`
        /// * `labels`
        /// * `disable_monitoring` (Not supported for FeatureRegistryService Feature)
        /// * `point_of_contact` (Not supported for FeaturestoreService FeatureStore)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feature UpdateFeature(Feature feature, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeature(new UpdateFeatureRequest
            {
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="feature">
        /// Required. The Feature's `name` field is used to identify the Feature to be
        /// updated.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Features resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `description`
        /// * `labels`
        /// * `disable_monitoring` (Not supported for FeatureRegistryService Feature)
        /// * `point_of_contact` (Not supported for FeaturestoreService FeatureStore)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> UpdateFeatureAsync(Feature feature, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeatureAsync(new UpdateFeatureRequest
            {
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="feature">
        /// Required. The Feature's `name` field is used to identify the Feature to be
        /// updated.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Features resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `description`
        /// * `labels`
        /// * `disable_monitoring` (Not supported for FeatureRegistryService Feature)
        /// * `point_of_contact` (Not supported for FeaturestoreService FeatureStore)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> UpdateFeatureAsync(Feature feature, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFeatureAsync(feature, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeature(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(DeleteFeatureRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteFeature(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteFeatureAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Features to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeature(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeature(new DeleteFeatureRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Features to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureAsync(new DeleteFeatureRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Features to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Features to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeature(FeatureName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeature(new DeleteFeatureRequest
            {
                FeatureName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Features to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(FeatureName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureAsync(new DeleteFeatureRequest
            {
                FeatureName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Features to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(FeatureName name, st::CancellationToken cancellationToken) =>
            DeleteFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports Feature values into the Featurestore from a source storage.
        /// 
        /// The progress of the import is tracked by the returned operation. The
        /// imported features are guaranteed to be visible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If an import operation fails, the Feature values returned from
        /// reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same import request again and wait till
        /// the new operation returned is marked as successfully done.
        /// 
        /// There are also scenarios where the caller can cause inconsistency.
        /// 
        /// - Source data for import contains multiple distinct Feature values for
        /// the same entity ID and timestamp.
        /// - Source is modified during an import. This includes adding, updating, or
        /// removing source data and/or metadata. Examples of updating metadata
        /// include but are not limited to changing storage location, storage class,
        /// or retention policy.
        /// - Online serving cluster is under-provisioned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> ImportFeatureValues(ImportFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports Feature values into the Featurestore from a source storage.
        /// 
        /// The progress of the import is tracked by the returned operation. The
        /// imported features are guaranteed to be visible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If an import operation fails, the Feature values returned from
        /// reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same import request again and wait till
        /// the new operation returned is marked as successfully done.
        /// 
        /// There are also scenarios where the caller can cause inconsistency.
        /// 
        /// - Source data for import contains multiple distinct Feature values for
        /// the same entity ID and timestamp.
        /// - Source is modified during an import. This includes adding, updating, or
        /// removing source data and/or metadata. Examples of updating metadata
        /// include but are not limited to changing storage location, storage class,
        /// or retention policy.
        /// - Online serving cluster is under-provisioned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata>> ImportFeatureValuesAsync(ImportFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports Feature values into the Featurestore from a source storage.
        /// 
        /// The progress of the import is tracked by the returned operation. The
        /// imported features are guaranteed to be visible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If an import operation fails, the Feature values returned from
        /// reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same import request again and wait till
        /// the new operation returned is marked as successfully done.
        /// 
        /// There are also scenarios where the caller can cause inconsistency.
        /// 
        /// - Source data for import contains multiple distinct Feature values for
        /// the same entity ID and timestamp.
        /// - Source is modified during an import. This includes adding, updating, or
        /// removing source data and/or metadata. Examples of updating metadata
        /// include but are not limited to changing storage location, storage class,
        /// or retention policy.
        /// - Online serving cluster is under-provisioned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata>> ImportFeatureValuesAsync(ImportFeatureValuesRequest request, st::CancellationToken cancellationToken) =>
            ImportFeatureValuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportFeatureValues</c>.</summary>
        public virtual lro::OperationsClient ImportFeatureValuesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportFeatureValues</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> PollOnceImportFeatureValues(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportFeatureValuesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportFeatureValues</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata>> PollOnceImportFeatureValuesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportFeatureValuesOperationsClient, callSettings);

        /// <summary>
        /// Imports Feature values into the Featurestore from a source storage.
        /// 
        /// The progress of the import is tracked by the returned operation. The
        /// imported features are guaranteed to be visible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If an import operation fails, the Feature values returned from
        /// reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same import request again and wait till
        /// the new operation returned is marked as successfully done.
        /// 
        /// There are also scenarios where the caller can cause inconsistency.
        /// 
        /// - Source data for import contains multiple distinct Feature values for
        /// the same entity ID and timestamp.
        /// - Source is modified during an import. This includes adding, updating, or
        /// removing source data and/or metadata. Examples of updating metadata
        /// include but are not limited to changing storage location, storage class,
        /// or retention policy.
        /// - Online serving cluster is under-provisioned.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType grouping the Features for
        /// which values are being imported. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> ImportFeatureValues(string entityType, gaxgrpc::CallSettings callSettings = null) =>
            ImportFeatureValues(new ImportFeatureValuesRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNullOrEmpty(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Imports Feature values into the Featurestore from a source storage.
        /// 
        /// The progress of the import is tracked by the returned operation. The
        /// imported features are guaranteed to be visible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If an import operation fails, the Feature values returned from
        /// reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same import request again and wait till
        /// the new operation returned is marked as successfully done.
        /// 
        /// There are also scenarios where the caller can cause inconsistency.
        /// 
        /// - Source data for import contains multiple distinct Feature values for
        /// the same entity ID and timestamp.
        /// - Source is modified during an import. This includes adding, updating, or
        /// removing source data and/or metadata. Examples of updating metadata
        /// include but are not limited to changing storage location, storage class,
        /// or retention policy.
        /// - Online serving cluster is under-provisioned.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType grouping the Features for
        /// which values are being imported. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata>> ImportFeatureValuesAsync(string entityType, gaxgrpc::CallSettings callSettings = null) =>
            ImportFeatureValuesAsync(new ImportFeatureValuesRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNullOrEmpty(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Imports Feature values into the Featurestore from a source storage.
        /// 
        /// The progress of the import is tracked by the returned operation. The
        /// imported features are guaranteed to be visible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If an import operation fails, the Feature values returned from
        /// reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same import request again and wait till
        /// the new operation returned is marked as successfully done.
        /// 
        /// There are also scenarios where the caller can cause inconsistency.
        /// 
        /// - Source data for import contains multiple distinct Feature values for
        /// the same entity ID and timestamp.
        /// - Source is modified during an import. This includes adding, updating, or
        /// removing source data and/or metadata. Examples of updating metadata
        /// include but are not limited to changing storage location, storage class,
        /// or retention policy.
        /// - Online serving cluster is under-provisioned.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType grouping the Features for
        /// which values are being imported. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata>> ImportFeatureValuesAsync(string entityType, st::CancellationToken cancellationToken) =>
            ImportFeatureValuesAsync(entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports Feature values into the Featurestore from a source storage.
        /// 
        /// The progress of the import is tracked by the returned operation. The
        /// imported features are guaranteed to be visible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If an import operation fails, the Feature values returned from
        /// reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same import request again and wait till
        /// the new operation returned is marked as successfully done.
        /// 
        /// There are also scenarios where the caller can cause inconsistency.
        /// 
        /// - Source data for import contains multiple distinct Feature values for
        /// the same entity ID and timestamp.
        /// - Source is modified during an import. This includes adding, updating, or
        /// removing source data and/or metadata. Examples of updating metadata
        /// include but are not limited to changing storage location, storage class,
        /// or retention policy.
        /// - Online serving cluster is under-provisioned.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType grouping the Features for
        /// which values are being imported. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> ImportFeatureValues(EntityTypeName entityType, gaxgrpc::CallSettings callSettings = null) =>
            ImportFeatureValues(new ImportFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Imports Feature values into the Featurestore from a source storage.
        /// 
        /// The progress of the import is tracked by the returned operation. The
        /// imported features are guaranteed to be visible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If an import operation fails, the Feature values returned from
        /// reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same import request again and wait till
        /// the new operation returned is marked as successfully done.
        /// 
        /// There are also scenarios where the caller can cause inconsistency.
        /// 
        /// - Source data for import contains multiple distinct Feature values for
        /// the same entity ID and timestamp.
        /// - Source is modified during an import. This includes adding, updating, or
        /// removing source data and/or metadata. Examples of updating metadata
        /// include but are not limited to changing storage location, storage class,
        /// or retention policy.
        /// - Online serving cluster is under-provisioned.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType grouping the Features for
        /// which values are being imported. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata>> ImportFeatureValuesAsync(EntityTypeName entityType, gaxgrpc::CallSettings callSettings = null) =>
            ImportFeatureValuesAsync(new ImportFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Imports Feature values into the Featurestore from a source storage.
        /// 
        /// The progress of the import is tracked by the returned operation. The
        /// imported features are guaranteed to be visible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If an import operation fails, the Feature values returned from
        /// reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same import request again and wait till
        /// the new operation returned is marked as successfully done.
        /// 
        /// There are also scenarios where the caller can cause inconsistency.
        /// 
        /// - Source data for import contains multiple distinct Feature values for
        /// the same entity ID and timestamp.
        /// - Source is modified during an import. This includes adding, updating, or
        /// removing source data and/or metadata. Examples of updating metadata
        /// include but are not limited to changing storage location, storage class,
        /// or retention policy.
        /// - Online serving cluster is under-provisioned.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType grouping the Features for
        /// which values are being imported. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata>> ImportFeatureValuesAsync(EntityTypeName entityType, st::CancellationToken cancellationToken) =>
            ImportFeatureValuesAsync(entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch reads Feature values from a Featurestore.
        /// 
        /// This API enables batch reading Feature values, where each read
        /// instance in the batch may read Feature values of entities from one or
        /// more EntityTypes. Point-in-time correctness is guaranteed for Feature
        /// values of each read instance as of each instance's read timestamp.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> BatchReadFeatureValues(BatchReadFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch reads Feature values from a Featurestore.
        /// 
        /// This API enables batch reading Feature values, where each read
        /// instance in the batch may read Feature values of entities from one or
        /// more EntityTypes. Point-in-time correctness is guaranteed for Feature
        /// values of each read instance as of each instance's read timestamp.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata>> BatchReadFeatureValuesAsync(BatchReadFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch reads Feature values from a Featurestore.
        /// 
        /// This API enables batch reading Feature values, where each read
        /// instance in the batch may read Feature values of entities from one or
        /// more EntityTypes. Point-in-time correctness is guaranteed for Feature
        /// values of each read instance as of each instance's read timestamp.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata>> BatchReadFeatureValuesAsync(BatchReadFeatureValuesRequest request, st::CancellationToken cancellationToken) =>
            BatchReadFeatureValuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchReadFeatureValues</c>.</summary>
        public virtual lro::OperationsClient BatchReadFeatureValuesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchReadFeatureValues</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> PollOnceBatchReadFeatureValues(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchReadFeatureValuesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchReadFeatureValues</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata>> PollOnceBatchReadFeatureValuesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchReadFeatureValuesOperationsClient, callSettings);

        /// <summary>
        /// Batch reads Feature values from a Featurestore.
        /// 
        /// This API enables batch reading Feature values, where each read
        /// instance in the batch may read Feature values of entities from one or
        /// more EntityTypes. Point-in-time correctness is guaranteed for Feature
        /// values of each read instance as of each instance's read timestamp.
        /// </summary>
        /// <param name="featurestore">
        /// Required. The resource name of the Featurestore from which to query Feature
        /// values. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> BatchReadFeatureValues(string featurestore, gaxgrpc::CallSettings callSettings = null) =>
            BatchReadFeatureValues(new BatchReadFeatureValuesRequest
            {
                Featurestore = gax::GaxPreconditions.CheckNotNullOrEmpty(featurestore, nameof(featurestore)),
            }, callSettings);

        /// <summary>
        /// Batch reads Feature values from a Featurestore.
        /// 
        /// This API enables batch reading Feature values, where each read
        /// instance in the batch may read Feature values of entities from one or
        /// more EntityTypes. Point-in-time correctness is guaranteed for Feature
        /// values of each read instance as of each instance's read timestamp.
        /// </summary>
        /// <param name="featurestore">
        /// Required. The resource name of the Featurestore from which to query Feature
        /// values. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata>> BatchReadFeatureValuesAsync(string featurestore, gaxgrpc::CallSettings callSettings = null) =>
            BatchReadFeatureValuesAsync(new BatchReadFeatureValuesRequest
            {
                Featurestore = gax::GaxPreconditions.CheckNotNullOrEmpty(featurestore, nameof(featurestore)),
            }, callSettings);

        /// <summary>
        /// Batch reads Feature values from a Featurestore.
        /// 
        /// This API enables batch reading Feature values, where each read
        /// instance in the batch may read Feature values of entities from one or
        /// more EntityTypes. Point-in-time correctness is guaranteed for Feature
        /// values of each read instance as of each instance's read timestamp.
        /// </summary>
        /// <param name="featurestore">
        /// Required. The resource name of the Featurestore from which to query Feature
        /// values. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata>> BatchReadFeatureValuesAsync(string featurestore, st::CancellationToken cancellationToken) =>
            BatchReadFeatureValuesAsync(featurestore, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch reads Feature values from a Featurestore.
        /// 
        /// This API enables batch reading Feature values, where each read
        /// instance in the batch may read Feature values of entities from one or
        /// more EntityTypes. Point-in-time correctness is guaranteed for Feature
        /// values of each read instance as of each instance's read timestamp.
        /// </summary>
        /// <param name="featurestore">
        /// Required. The resource name of the Featurestore from which to query Feature
        /// values. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> BatchReadFeatureValues(FeaturestoreName featurestore, gaxgrpc::CallSettings callSettings = null) =>
            BatchReadFeatureValues(new BatchReadFeatureValuesRequest
            {
                FeaturestoreAsFeaturestoreName = gax::GaxPreconditions.CheckNotNull(featurestore, nameof(featurestore)),
            }, callSettings);

        /// <summary>
        /// Batch reads Feature values from a Featurestore.
        /// 
        /// This API enables batch reading Feature values, where each read
        /// instance in the batch may read Feature values of entities from one or
        /// more EntityTypes. Point-in-time correctness is guaranteed for Feature
        /// values of each read instance as of each instance's read timestamp.
        /// </summary>
        /// <param name="featurestore">
        /// Required. The resource name of the Featurestore from which to query Feature
        /// values. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata>> BatchReadFeatureValuesAsync(FeaturestoreName featurestore, gaxgrpc::CallSettings callSettings = null) =>
            BatchReadFeatureValuesAsync(new BatchReadFeatureValuesRequest
            {
                FeaturestoreAsFeaturestoreName = gax::GaxPreconditions.CheckNotNull(featurestore, nameof(featurestore)),
            }, callSettings);

        /// <summary>
        /// Batch reads Feature values from a Featurestore.
        /// 
        /// This API enables batch reading Feature values, where each read
        /// instance in the batch may read Feature values of entities from one or
        /// more EntityTypes. Point-in-time correctness is guaranteed for Feature
        /// values of each read instance as of each instance's read timestamp.
        /// </summary>
        /// <param name="featurestore">
        /// Required. The resource name of the Featurestore from which to query Feature
        /// values. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata>> BatchReadFeatureValuesAsync(FeaturestoreName featurestore, st::CancellationToken cancellationToken) =>
            BatchReadFeatureValuesAsync(featurestore, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports Feature values from all the entities of a target EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> ExportFeatureValues(ExportFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports Feature values from all the entities of a target EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata>> ExportFeatureValuesAsync(ExportFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports Feature values from all the entities of a target EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata>> ExportFeatureValuesAsync(ExportFeatureValuesRequest request, st::CancellationToken cancellationToken) =>
            ExportFeatureValuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportFeatureValues</c>.</summary>
        public virtual lro::OperationsClient ExportFeatureValuesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportFeatureValues</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> PollOnceExportFeatureValues(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportFeatureValuesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportFeatureValues</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata>> PollOnceExportFeatureValuesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportFeatureValuesOperationsClient, callSettings);

        /// <summary>
        /// Exports Feature values from all the entities of a target EntityType.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType from which to export Feature
        /// values. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> ExportFeatureValues(string entityType, gaxgrpc::CallSettings callSettings = null) =>
            ExportFeatureValues(new ExportFeatureValuesRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNullOrEmpty(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Exports Feature values from all the entities of a target EntityType.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType from which to export Feature
        /// values. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata>> ExportFeatureValuesAsync(string entityType, gaxgrpc::CallSettings callSettings = null) =>
            ExportFeatureValuesAsync(new ExportFeatureValuesRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNullOrEmpty(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Exports Feature values from all the entities of a target EntityType.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType from which to export Feature
        /// values. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata>> ExportFeatureValuesAsync(string entityType, st::CancellationToken cancellationToken) =>
            ExportFeatureValuesAsync(entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports Feature values from all the entities of a target EntityType.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType from which to export Feature
        /// values. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> ExportFeatureValues(EntityTypeName entityType, gaxgrpc::CallSettings callSettings = null) =>
            ExportFeatureValues(new ExportFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Exports Feature values from all the entities of a target EntityType.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType from which to export Feature
        /// values. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata>> ExportFeatureValuesAsync(EntityTypeName entityType, gaxgrpc::CallSettings callSettings = null) =>
            ExportFeatureValuesAsync(new ExportFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Exports Feature values from all the entities of a target EntityType.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType from which to export Feature
        /// values. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata>> ExportFeatureValuesAsync(EntityTypeName entityType, st::CancellationToken cancellationToken) =>
            ExportFeatureValuesAsync(entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete Feature values from Featurestore.
        /// 
        /// The progress of the deletion is tracked by the returned operation. The
        /// deleted feature values are guaranteed to be invisible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If a delete feature values operation fails, the feature values
        /// returned from reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same delete request again and wait till
        /// the new operation returned is marked as successfully done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> DeleteFeatureValues(DeleteFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete Feature values from Featurestore.
        /// 
        /// The progress of the deletion is tracked by the returned operation. The
        /// deleted feature values are guaranteed to be invisible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If a delete feature values operation fails, the feature values
        /// returned from reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same delete request again and wait till
        /// the new operation returned is marked as successfully done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata>> DeleteFeatureValuesAsync(DeleteFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete Feature values from Featurestore.
        /// 
        /// The progress of the deletion is tracked by the returned operation. The
        /// deleted feature values are guaranteed to be invisible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If a delete feature values operation fails, the feature values
        /// returned from reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same delete request again and wait till
        /// the new operation returned is marked as successfully done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata>> DeleteFeatureValuesAsync(DeleteFeatureValuesRequest request, st::CancellationToken cancellationToken) =>
            DeleteFeatureValuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFeatureValues</c>.</summary>
        public virtual lro::OperationsClient DeleteFeatureValuesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFeatureValues</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> PollOnceDeleteFeatureValues(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureValuesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFeatureValues</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata>> PollOnceDeleteFeatureValuesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureValuesOperationsClient, callSettings);

        /// <summary>
        /// Delete Feature values from Featurestore.
        /// 
        /// The progress of the deletion is tracked by the returned operation. The
        /// deleted feature values are guaranteed to be invisible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If a delete feature values operation fails, the feature values
        /// returned from reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same delete request again and wait till
        /// the new operation returned is marked as successfully done.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType grouping the Features for
        /// which values are being deleted from. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> DeleteFeatureValues(string entityType, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureValues(new DeleteFeatureValuesRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNullOrEmpty(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Delete Feature values from Featurestore.
        /// 
        /// The progress of the deletion is tracked by the returned operation. The
        /// deleted feature values are guaranteed to be invisible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If a delete feature values operation fails, the feature values
        /// returned from reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same delete request again and wait till
        /// the new operation returned is marked as successfully done.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType grouping the Features for
        /// which values are being deleted from. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata>> DeleteFeatureValuesAsync(string entityType, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureValuesAsync(new DeleteFeatureValuesRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNullOrEmpty(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Delete Feature values from Featurestore.
        /// 
        /// The progress of the deletion is tracked by the returned operation. The
        /// deleted feature values are guaranteed to be invisible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If a delete feature values operation fails, the feature values
        /// returned from reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same delete request again and wait till
        /// the new operation returned is marked as successfully done.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType grouping the Features for
        /// which values are being deleted from. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata>> DeleteFeatureValuesAsync(string entityType, st::CancellationToken cancellationToken) =>
            DeleteFeatureValuesAsync(entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete Feature values from Featurestore.
        /// 
        /// The progress of the deletion is tracked by the returned operation. The
        /// deleted feature values are guaranteed to be invisible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If a delete feature values operation fails, the feature values
        /// returned from reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same delete request again and wait till
        /// the new operation returned is marked as successfully done.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType grouping the Features for
        /// which values are being deleted from. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> DeleteFeatureValues(EntityTypeName entityType, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureValues(new DeleteFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Delete Feature values from Featurestore.
        /// 
        /// The progress of the deletion is tracked by the returned operation. The
        /// deleted feature values are guaranteed to be invisible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If a delete feature values operation fails, the feature values
        /// returned from reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same delete request again and wait till
        /// the new operation returned is marked as successfully done.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType grouping the Features for
        /// which values are being deleted from. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata>> DeleteFeatureValuesAsync(EntityTypeName entityType, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureValuesAsync(new DeleteFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Delete Feature values from Featurestore.
        /// 
        /// The progress of the deletion is tracked by the returned operation. The
        /// deleted feature values are guaranteed to be invisible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If a delete feature values operation fails, the feature values
        /// returned from reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same delete request again and wait till
        /// the new operation returned is marked as successfully done.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType grouping the Features for
        /// which values are being deleted from. Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata>> DeleteFeatureValuesAsync(EntityTypeName entityType, st::CancellationToken cancellationToken) =>
            DeleteFeatureValuesAsync(entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches Features matching a query in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchFeaturesResponse, Feature> SearchFeatures(SearchFeaturesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches Features matching a query in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchFeaturesResponse, Feature> SearchFeaturesAsync(SearchFeaturesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches Features matching a query in a given project.
        /// </summary>
        /// <param name="location">
        /// Required. The resource name of the Location to search Features.
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
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchFeaturesResponse, Feature> SearchFeatures(string location, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchFeaturesRequest request = new SearchFeaturesRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchFeatures(request, callSettings);
        }

        /// <summary>
        /// Searches Features matching a query in a given project.
        /// </summary>
        /// <param name="location">
        /// Required. The resource name of the Location to search Features.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchFeaturesResponse, Feature> SearchFeaturesAsync(string location, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchFeaturesRequest request = new SearchFeaturesRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchFeaturesAsync(request, callSettings);
        }

        /// <summary>
        /// Searches Features matching a query in a given project.
        /// </summary>
        /// <param name="location">
        /// Required. The resource name of the Location to search Features.
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
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchFeaturesResponse, Feature> SearchFeatures(gagr::LocationName location, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchFeaturesRequest request = new SearchFeaturesRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchFeatures(request, callSettings);
        }

        /// <summary>
        /// Searches Features matching a query in a given project.
        /// </summary>
        /// <param name="location">
        /// Required. The resource name of the Location to search Features.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchFeaturesResponse, Feature> SearchFeaturesAsync(gagr::LocationName location, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchFeaturesRequest request = new SearchFeaturesRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchFeaturesAsync(request, callSettings);
        }

        /// <summary>
        /// Searches Features matching a query in a given project.
        /// </summary>
        /// <param name="location">
        /// Required. The resource name of the Location to search Features.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="query">
        /// Query string that is a conjunction of field-restricted queries and/or
        /// field-restricted filters.  Field-restricted queries and filters can be
        /// combined using `AND` to form a conjunction.
        /// 
        /// A field query is in the form FIELD:QUERY. This implicitly checks if QUERY
        /// exists as a substring within Feature's FIELD. The QUERY
        /// and the FIELD are converted to a sequence of words (i.e. tokens) for
        /// comparison. This is done by:
        /// 
        /// * Removing leading/trailing whitespace and tokenizing the search value.
        /// Characters that are not one of alphanumeric `[a-zA-Z0-9]`, underscore
        /// `_`, or asterisk `*` are treated as delimiters for tokens. `*` is treated
        /// as a wildcard that matches characters within a token.
        /// * Ignoring case.
        /// * Prepending an asterisk to the first and appending an asterisk to the
        /// last token in QUERY.
        /// 
        /// A QUERY must be either a singular token or a phrase. A phrase is one or
        /// multiple words enclosed in double quotation marks ("). With phrases, the
        /// order of the words is important. Words in the phrase must be matching in
        /// order and consecutively.
        /// 
        /// Supported FIELDs for field-restricted queries:
        /// 
        /// * `feature_id`
        /// * `description`
        /// * `entity_type_id`
        /// 
        /// Examples:
        /// 
        /// * `feature_id: foo` --&gt; Matches a Feature with ID containing the substring
        /// `foo` (eg. `foo`, `foofeature`, `barfoo`).
        /// * `feature_id: foo*feature` --&gt; Matches a Feature with ID containing the
        /// substring `foo*feature` (eg. `foobarfeature`).
        /// * `feature_id: foo AND description: bar` --&gt; Matches a Feature with ID
        /// containing the substring `foo` and description containing the substring
        /// `bar`.
        /// 
        /// 
        /// Besides field queries, the following exact-match filters are
        /// supported. The exact-match filters do not support wildcards. Unlike
        /// field-restricted queries, exact-match filters are case-sensitive.
        /// 
        /// * `feature_id`: Supports = comparisons.
        /// * `description`: Supports = comparisons. Multi-token filters should be
        /// enclosed in quotes.
        /// * `entity_type_id`: Supports = comparisons.
        /// * `value_type`: Supports = and != comparisons.
        /// * `labels`: Supports key-value equality as well as key presence.
        /// * `featurestore_id`: Supports = comparisons.
        /// 
        /// Examples:
        /// 
        /// * `description = "foo bar"` --&gt; Any Feature with description exactly equal
        /// to `foo bar`
        /// * `value_type = DOUBLE` --&gt; Features whose type is DOUBLE.
        /// * `labels.active = yes AND labels.env = prod` --&gt; Features having both
        /// (active: yes) and (env: prod) labels.
        /// * `labels.env: *` --&gt; Any Feature which has a label with `env` as the
        /// key.
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
        public virtual gax::PagedEnumerable<SearchFeaturesResponse, Feature> SearchFeatures(string location, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchFeaturesRequest request = new SearchFeaturesRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchFeatures(request, callSettings);
        }

        /// <summary>
        /// Searches Features matching a query in a given project.
        /// </summary>
        /// <param name="location">
        /// Required. The resource name of the Location to search Features.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="query">
        /// Query string that is a conjunction of field-restricted queries and/or
        /// field-restricted filters.  Field-restricted queries and filters can be
        /// combined using `AND` to form a conjunction.
        /// 
        /// A field query is in the form FIELD:QUERY. This implicitly checks if QUERY
        /// exists as a substring within Feature's FIELD. The QUERY
        /// and the FIELD are converted to a sequence of words (i.e. tokens) for
        /// comparison. This is done by:
        /// 
        /// * Removing leading/trailing whitespace and tokenizing the search value.
        /// Characters that are not one of alphanumeric `[a-zA-Z0-9]`, underscore
        /// `_`, or asterisk `*` are treated as delimiters for tokens. `*` is treated
        /// as a wildcard that matches characters within a token.
        /// * Ignoring case.
        /// * Prepending an asterisk to the first and appending an asterisk to the
        /// last token in QUERY.
        /// 
        /// A QUERY must be either a singular token or a phrase. A phrase is one or
        /// multiple words enclosed in double quotation marks ("). With phrases, the
        /// order of the words is important. Words in the phrase must be matching in
        /// order and consecutively.
        /// 
        /// Supported FIELDs for field-restricted queries:
        /// 
        /// * `feature_id`
        /// * `description`
        /// * `entity_type_id`
        /// 
        /// Examples:
        /// 
        /// * `feature_id: foo` --&gt; Matches a Feature with ID containing the substring
        /// `foo` (eg. `foo`, `foofeature`, `barfoo`).
        /// * `feature_id: foo*feature` --&gt; Matches a Feature with ID containing the
        /// substring `foo*feature` (eg. `foobarfeature`).
        /// * `feature_id: foo AND description: bar` --&gt; Matches a Feature with ID
        /// containing the substring `foo` and description containing the substring
        /// `bar`.
        /// 
        /// 
        /// Besides field queries, the following exact-match filters are
        /// supported. The exact-match filters do not support wildcards. Unlike
        /// field-restricted queries, exact-match filters are case-sensitive.
        /// 
        /// * `feature_id`: Supports = comparisons.
        /// * `description`: Supports = comparisons. Multi-token filters should be
        /// enclosed in quotes.
        /// * `entity_type_id`: Supports = comparisons.
        /// * `value_type`: Supports = and != comparisons.
        /// * `labels`: Supports key-value equality as well as key presence.
        /// * `featurestore_id`: Supports = comparisons.
        /// 
        /// Examples:
        /// 
        /// * `description = "foo bar"` --&gt; Any Feature with description exactly equal
        /// to `foo bar`
        /// * `value_type = DOUBLE` --&gt; Features whose type is DOUBLE.
        /// * `labels.active = yes AND labels.env = prod` --&gt; Features having both
        /// (active: yes) and (env: prod) labels.
        /// * `labels.env: *` --&gt; Any Feature which has a label with `env` as the
        /// key.
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
        public virtual gax::PagedAsyncEnumerable<SearchFeaturesResponse, Feature> SearchFeaturesAsync(string location, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchFeaturesRequest request = new SearchFeaturesRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchFeaturesAsync(request, callSettings);
        }

        /// <summary>
        /// Searches Features matching a query in a given project.
        /// </summary>
        /// <param name="location">
        /// Required. The resource name of the Location to search Features.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="query">
        /// Query string that is a conjunction of field-restricted queries and/or
        /// field-restricted filters.  Field-restricted queries and filters can be
        /// combined using `AND` to form a conjunction.
        /// 
        /// A field query is in the form FIELD:QUERY. This implicitly checks if QUERY
        /// exists as a substring within Feature's FIELD. The QUERY
        /// and the FIELD are converted to a sequence of words (i.e. tokens) for
        /// comparison. This is done by:
        /// 
        /// * Removing leading/trailing whitespace and tokenizing the search value.
        /// Characters that are not one of alphanumeric `[a-zA-Z0-9]`, underscore
        /// `_`, or asterisk `*` are treated as delimiters for tokens. `*` is treated
        /// as a wildcard that matches characters within a token.
        /// * Ignoring case.
        /// * Prepending an asterisk to the first and appending an asterisk to the
        /// last token in QUERY.
        /// 
        /// A QUERY must be either a singular token or a phrase. A phrase is one or
        /// multiple words enclosed in double quotation marks ("). With phrases, the
        /// order of the words is important. Words in the phrase must be matching in
        /// order and consecutively.
        /// 
        /// Supported FIELDs for field-restricted queries:
        /// 
        /// * `feature_id`
        /// * `description`
        /// * `entity_type_id`
        /// 
        /// Examples:
        /// 
        /// * `feature_id: foo` --&gt; Matches a Feature with ID containing the substring
        /// `foo` (eg. `foo`, `foofeature`, `barfoo`).
        /// * `feature_id: foo*feature` --&gt; Matches a Feature with ID containing the
        /// substring `foo*feature` (eg. `foobarfeature`).
        /// * `feature_id: foo AND description: bar` --&gt; Matches a Feature with ID
        /// containing the substring `foo` and description containing the substring
        /// `bar`.
        /// 
        /// 
        /// Besides field queries, the following exact-match filters are
        /// supported. The exact-match filters do not support wildcards. Unlike
        /// field-restricted queries, exact-match filters are case-sensitive.
        /// 
        /// * `feature_id`: Supports = comparisons.
        /// * `description`: Supports = comparisons. Multi-token filters should be
        /// enclosed in quotes.
        /// * `entity_type_id`: Supports = comparisons.
        /// * `value_type`: Supports = and != comparisons.
        /// * `labels`: Supports key-value equality as well as key presence.
        /// * `featurestore_id`: Supports = comparisons.
        /// 
        /// Examples:
        /// 
        /// * `description = "foo bar"` --&gt; Any Feature with description exactly equal
        /// to `foo bar`
        /// * `value_type = DOUBLE` --&gt; Features whose type is DOUBLE.
        /// * `labels.active = yes AND labels.env = prod` --&gt; Features having both
        /// (active: yes) and (env: prod) labels.
        /// * `labels.env: *` --&gt; Any Feature which has a label with `env` as the
        /// key.
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
        public virtual gax::PagedEnumerable<SearchFeaturesResponse, Feature> SearchFeatures(gagr::LocationName location, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchFeaturesRequest request = new SearchFeaturesRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchFeatures(request, callSettings);
        }

        /// <summary>
        /// Searches Features matching a query in a given project.
        /// </summary>
        /// <param name="location">
        /// Required. The resource name of the Location to search Features.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="query">
        /// Query string that is a conjunction of field-restricted queries and/or
        /// field-restricted filters.  Field-restricted queries and filters can be
        /// combined using `AND` to form a conjunction.
        /// 
        /// A field query is in the form FIELD:QUERY. This implicitly checks if QUERY
        /// exists as a substring within Feature's FIELD. The QUERY
        /// and the FIELD are converted to a sequence of words (i.e. tokens) for
        /// comparison. This is done by:
        /// 
        /// * Removing leading/trailing whitespace and tokenizing the search value.
        /// Characters that are not one of alphanumeric `[a-zA-Z0-9]`, underscore
        /// `_`, or asterisk `*` are treated as delimiters for tokens. `*` is treated
        /// as a wildcard that matches characters within a token.
        /// * Ignoring case.
        /// * Prepending an asterisk to the first and appending an asterisk to the
        /// last token in QUERY.
        /// 
        /// A QUERY must be either a singular token or a phrase. A phrase is one or
        /// multiple words enclosed in double quotation marks ("). With phrases, the
        /// order of the words is important. Words in the phrase must be matching in
        /// order and consecutively.
        /// 
        /// Supported FIELDs for field-restricted queries:
        /// 
        /// * `feature_id`
        /// * `description`
        /// * `entity_type_id`
        /// 
        /// Examples:
        /// 
        /// * `feature_id: foo` --&gt; Matches a Feature with ID containing the substring
        /// `foo` (eg. `foo`, `foofeature`, `barfoo`).
        /// * `feature_id: foo*feature` --&gt; Matches a Feature with ID containing the
        /// substring `foo*feature` (eg. `foobarfeature`).
        /// * `feature_id: foo AND description: bar` --&gt; Matches a Feature with ID
        /// containing the substring `foo` and description containing the substring
        /// `bar`.
        /// 
        /// 
        /// Besides field queries, the following exact-match filters are
        /// supported. The exact-match filters do not support wildcards. Unlike
        /// field-restricted queries, exact-match filters are case-sensitive.
        /// 
        /// * `feature_id`: Supports = comparisons.
        /// * `description`: Supports = comparisons. Multi-token filters should be
        /// enclosed in quotes.
        /// * `entity_type_id`: Supports = comparisons.
        /// * `value_type`: Supports = and != comparisons.
        /// * `labels`: Supports key-value equality as well as key presence.
        /// * `featurestore_id`: Supports = comparisons.
        /// 
        /// Examples:
        /// 
        /// * `description = "foo bar"` --&gt; Any Feature with description exactly equal
        /// to `foo bar`
        /// * `value_type = DOUBLE` --&gt; Features whose type is DOUBLE.
        /// * `labels.active = yes AND labels.env = prod` --&gt; Features having both
        /// (active: yes) and (env: prod) labels.
        /// * `labels.env: *` --&gt; Any Feature which has a label with `env` as the
        /// key.
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
        public virtual gax::PagedAsyncEnumerable<SearchFeaturesResponse, Feature> SearchFeaturesAsync(gagr::LocationName location, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchFeaturesRequest request = new SearchFeaturesRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchFeaturesAsync(request, callSettings);
        }
    }

    /// <summary>FeaturestoreService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that handles CRUD and List for resources for Featurestore.
    /// </remarks>
    public sealed partial class FeaturestoreServiceClientImpl : FeaturestoreServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateFeaturestoreRequest, lro::Operation> _callCreateFeaturestore;

        private readonly gaxgrpc::ApiCall<GetFeaturestoreRequest, Featurestore> _callGetFeaturestore;

        private readonly gaxgrpc::ApiCall<ListFeaturestoresRequest, ListFeaturestoresResponse> _callListFeaturestores;

        private readonly gaxgrpc::ApiCall<UpdateFeaturestoreRequest, lro::Operation> _callUpdateFeaturestore;

        private readonly gaxgrpc::ApiCall<DeleteFeaturestoreRequest, lro::Operation> _callDeleteFeaturestore;

        private readonly gaxgrpc::ApiCall<CreateEntityTypeRequest, lro::Operation> _callCreateEntityType;

        private readonly gaxgrpc::ApiCall<GetEntityTypeRequest, EntityType> _callGetEntityType;

        private readonly gaxgrpc::ApiCall<ListEntityTypesRequest, ListEntityTypesResponse> _callListEntityTypes;

        private readonly gaxgrpc::ApiCall<UpdateEntityTypeRequest, EntityType> _callUpdateEntityType;

        private readonly gaxgrpc::ApiCall<DeleteEntityTypeRequest, lro::Operation> _callDeleteEntityType;

        private readonly gaxgrpc::ApiCall<CreateFeatureRequest, lro::Operation> _callCreateFeature;

        private readonly gaxgrpc::ApiCall<BatchCreateFeaturesRequest, lro::Operation> _callBatchCreateFeatures;

        private readonly gaxgrpc::ApiCall<GetFeatureRequest, Feature> _callGetFeature;

        private readonly gaxgrpc::ApiCall<ListFeaturesRequest, ListFeaturesResponse> _callListFeatures;

        private readonly gaxgrpc::ApiCall<UpdateFeatureRequest, Feature> _callUpdateFeature;

        private readonly gaxgrpc::ApiCall<DeleteFeatureRequest, lro::Operation> _callDeleteFeature;

        private readonly gaxgrpc::ApiCall<ImportFeatureValuesRequest, lro::Operation> _callImportFeatureValues;

        private readonly gaxgrpc::ApiCall<BatchReadFeatureValuesRequest, lro::Operation> _callBatchReadFeatureValues;

        private readonly gaxgrpc::ApiCall<ExportFeatureValuesRequest, lro::Operation> _callExportFeatureValues;

        private readonly gaxgrpc::ApiCall<DeleteFeatureValuesRequest, lro::Operation> _callDeleteFeatureValues;

        private readonly gaxgrpc::ApiCall<SearchFeaturesRequest, SearchFeaturesResponse> _callSearchFeatures;

        /// <summary>
        /// Constructs a client wrapper for the FeaturestoreService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FeaturestoreServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FeaturestoreServiceClientImpl(FeaturestoreService.FeaturestoreServiceClient grpcClient, FeaturestoreServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FeaturestoreServiceSettings effectiveSettings = settings ?? FeaturestoreServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateFeaturestoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFeaturestoreOperationsSettings, logger);
            UpdateFeaturestoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFeaturestoreOperationsSettings, logger);
            DeleteFeaturestoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFeaturestoreOperationsSettings, logger);
            CreateEntityTypeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEntityTypeOperationsSettings, logger);
            DeleteEntityTypeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEntityTypeOperationsSettings, logger);
            CreateFeatureOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFeatureOperationsSettings, logger);
            BatchCreateFeaturesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchCreateFeaturesOperationsSettings, logger);
            DeleteFeatureOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFeatureOperationsSettings, logger);
            ImportFeatureValuesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportFeatureValuesOperationsSettings, logger);
            BatchReadFeatureValuesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchReadFeatureValuesOperationsSettings, logger);
            ExportFeatureValuesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportFeatureValuesOperationsSettings, logger);
            DeleteFeatureValuesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFeatureValuesOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateFeaturestore = clientHelper.BuildApiCall<CreateFeaturestoreRequest, lro::Operation>("CreateFeaturestore", grpcClient.CreateFeaturestoreAsync, grpcClient.CreateFeaturestore, effectiveSettings.CreateFeaturestoreSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFeaturestore);
            Modify_CreateFeaturestoreApiCall(ref _callCreateFeaturestore);
            _callGetFeaturestore = clientHelper.BuildApiCall<GetFeaturestoreRequest, Featurestore>("GetFeaturestore", grpcClient.GetFeaturestoreAsync, grpcClient.GetFeaturestore, effectiveSettings.GetFeaturestoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeaturestore);
            Modify_GetFeaturestoreApiCall(ref _callGetFeaturestore);
            _callListFeaturestores = clientHelper.BuildApiCall<ListFeaturestoresRequest, ListFeaturestoresResponse>("ListFeaturestores", grpcClient.ListFeaturestoresAsync, grpcClient.ListFeaturestores, effectiveSettings.ListFeaturestoresSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeaturestores);
            Modify_ListFeaturestoresApiCall(ref _callListFeaturestores);
            _callUpdateFeaturestore = clientHelper.BuildApiCall<UpdateFeaturestoreRequest, lro::Operation>("UpdateFeaturestore", grpcClient.UpdateFeaturestoreAsync, grpcClient.UpdateFeaturestore, effectiveSettings.UpdateFeaturestoreSettings).WithGoogleRequestParam("featurestore.name", request => request.Featurestore?.Name);
            Modify_ApiCall(ref _callUpdateFeaturestore);
            Modify_UpdateFeaturestoreApiCall(ref _callUpdateFeaturestore);
            _callDeleteFeaturestore = clientHelper.BuildApiCall<DeleteFeaturestoreRequest, lro::Operation>("DeleteFeaturestore", grpcClient.DeleteFeaturestoreAsync, grpcClient.DeleteFeaturestore, effectiveSettings.DeleteFeaturestoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFeaturestore);
            Modify_DeleteFeaturestoreApiCall(ref _callDeleteFeaturestore);
            _callCreateEntityType = clientHelper.BuildApiCall<CreateEntityTypeRequest, lro::Operation>("CreateEntityType", grpcClient.CreateEntityTypeAsync, grpcClient.CreateEntityType, effectiveSettings.CreateEntityTypeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEntityType);
            Modify_CreateEntityTypeApiCall(ref _callCreateEntityType);
            _callGetEntityType = clientHelper.BuildApiCall<GetEntityTypeRequest, EntityType>("GetEntityType", grpcClient.GetEntityTypeAsync, grpcClient.GetEntityType, effectiveSettings.GetEntityTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntityType);
            Modify_GetEntityTypeApiCall(ref _callGetEntityType);
            _callListEntityTypes = clientHelper.BuildApiCall<ListEntityTypesRequest, ListEntityTypesResponse>("ListEntityTypes", grpcClient.ListEntityTypesAsync, grpcClient.ListEntityTypes, effectiveSettings.ListEntityTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntityTypes);
            Modify_ListEntityTypesApiCall(ref _callListEntityTypes);
            _callUpdateEntityType = clientHelper.BuildApiCall<UpdateEntityTypeRequest, EntityType>("UpdateEntityType", grpcClient.UpdateEntityTypeAsync, grpcClient.UpdateEntityType, effectiveSettings.UpdateEntityTypeSettings).WithGoogleRequestParam("entity_type.name", request => request.EntityType?.Name);
            Modify_ApiCall(ref _callUpdateEntityType);
            Modify_UpdateEntityTypeApiCall(ref _callUpdateEntityType);
            _callDeleteEntityType = clientHelper.BuildApiCall<DeleteEntityTypeRequest, lro::Operation>("DeleteEntityType", grpcClient.DeleteEntityTypeAsync, grpcClient.DeleteEntityType, effectiveSettings.DeleteEntityTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEntityType);
            Modify_DeleteEntityTypeApiCall(ref _callDeleteEntityType);
            _callCreateFeature = clientHelper.BuildApiCall<CreateFeatureRequest, lro::Operation>("CreateFeature", grpcClient.CreateFeatureAsync, grpcClient.CreateFeature, effectiveSettings.CreateFeatureSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFeature);
            Modify_CreateFeatureApiCall(ref _callCreateFeature);
            _callBatchCreateFeatures = clientHelper.BuildApiCall<BatchCreateFeaturesRequest, lro::Operation>("BatchCreateFeatures", grpcClient.BatchCreateFeaturesAsync, grpcClient.BatchCreateFeatures, effectiveSettings.BatchCreateFeaturesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateFeatures);
            Modify_BatchCreateFeaturesApiCall(ref _callBatchCreateFeatures);
            _callGetFeature = clientHelper.BuildApiCall<GetFeatureRequest, Feature>("GetFeature", grpcClient.GetFeatureAsync, grpcClient.GetFeature, effectiveSettings.GetFeatureSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeature);
            Modify_GetFeatureApiCall(ref _callGetFeature);
            _callListFeatures = clientHelper.BuildApiCall<ListFeaturesRequest, ListFeaturesResponse>("ListFeatures", grpcClient.ListFeaturesAsync, grpcClient.ListFeatures, effectiveSettings.ListFeaturesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeatures);
            Modify_ListFeaturesApiCall(ref _callListFeatures);
            _callUpdateFeature = clientHelper.BuildApiCall<UpdateFeatureRequest, Feature>("UpdateFeature", grpcClient.UpdateFeatureAsync, grpcClient.UpdateFeature, effectiveSettings.UpdateFeatureSettings).WithGoogleRequestParam("feature.name", request => request.Feature?.Name);
            Modify_ApiCall(ref _callUpdateFeature);
            Modify_UpdateFeatureApiCall(ref _callUpdateFeature);
            _callDeleteFeature = clientHelper.BuildApiCall<DeleteFeatureRequest, lro::Operation>("DeleteFeature", grpcClient.DeleteFeatureAsync, grpcClient.DeleteFeature, effectiveSettings.DeleteFeatureSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFeature);
            Modify_DeleteFeatureApiCall(ref _callDeleteFeature);
            _callImportFeatureValues = clientHelper.BuildApiCall<ImportFeatureValuesRequest, lro::Operation>("ImportFeatureValues", grpcClient.ImportFeatureValuesAsync, grpcClient.ImportFeatureValues, effectiveSettings.ImportFeatureValuesSettings).WithGoogleRequestParam("entity_type", request => request.EntityType);
            Modify_ApiCall(ref _callImportFeatureValues);
            Modify_ImportFeatureValuesApiCall(ref _callImportFeatureValues);
            _callBatchReadFeatureValues = clientHelper.BuildApiCall<BatchReadFeatureValuesRequest, lro::Operation>("BatchReadFeatureValues", grpcClient.BatchReadFeatureValuesAsync, grpcClient.BatchReadFeatureValues, effectiveSettings.BatchReadFeatureValuesSettings).WithGoogleRequestParam("featurestore", request => request.Featurestore);
            Modify_ApiCall(ref _callBatchReadFeatureValues);
            Modify_BatchReadFeatureValuesApiCall(ref _callBatchReadFeatureValues);
            _callExportFeatureValues = clientHelper.BuildApiCall<ExportFeatureValuesRequest, lro::Operation>("ExportFeatureValues", grpcClient.ExportFeatureValuesAsync, grpcClient.ExportFeatureValues, effectiveSettings.ExportFeatureValuesSettings).WithGoogleRequestParam("entity_type", request => request.EntityType);
            Modify_ApiCall(ref _callExportFeatureValues);
            Modify_ExportFeatureValuesApiCall(ref _callExportFeatureValues);
            _callDeleteFeatureValues = clientHelper.BuildApiCall<DeleteFeatureValuesRequest, lro::Operation>("DeleteFeatureValues", grpcClient.DeleteFeatureValuesAsync, grpcClient.DeleteFeatureValues, effectiveSettings.DeleteFeatureValuesSettings).WithGoogleRequestParam("entity_type", request => request.EntityType);
            Modify_ApiCall(ref _callDeleteFeatureValues);
            Modify_DeleteFeatureValuesApiCall(ref _callDeleteFeatureValues);
            _callSearchFeatures = clientHelper.BuildApiCall<SearchFeaturesRequest, SearchFeaturesResponse>("SearchFeatures", grpcClient.SearchFeaturesAsync, grpcClient.SearchFeatures, effectiveSettings.SearchFeaturesSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callSearchFeatures);
            Modify_SearchFeaturesApiCall(ref _callSearchFeatures);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateFeaturestoreApiCall(ref gaxgrpc::ApiCall<CreateFeaturestoreRequest, lro::Operation> call);

        partial void Modify_GetFeaturestoreApiCall(ref gaxgrpc::ApiCall<GetFeaturestoreRequest, Featurestore> call);

        partial void Modify_ListFeaturestoresApiCall(ref gaxgrpc::ApiCall<ListFeaturestoresRequest, ListFeaturestoresResponse> call);

        partial void Modify_UpdateFeaturestoreApiCall(ref gaxgrpc::ApiCall<UpdateFeaturestoreRequest, lro::Operation> call);

        partial void Modify_DeleteFeaturestoreApiCall(ref gaxgrpc::ApiCall<DeleteFeaturestoreRequest, lro::Operation> call);

        partial void Modify_CreateEntityTypeApiCall(ref gaxgrpc::ApiCall<CreateEntityTypeRequest, lro::Operation> call);

        partial void Modify_GetEntityTypeApiCall(ref gaxgrpc::ApiCall<GetEntityTypeRequest, EntityType> call);

        partial void Modify_ListEntityTypesApiCall(ref gaxgrpc::ApiCall<ListEntityTypesRequest, ListEntityTypesResponse> call);

        partial void Modify_UpdateEntityTypeApiCall(ref gaxgrpc::ApiCall<UpdateEntityTypeRequest, EntityType> call);

        partial void Modify_DeleteEntityTypeApiCall(ref gaxgrpc::ApiCall<DeleteEntityTypeRequest, lro::Operation> call);

        partial void Modify_CreateFeatureApiCall(ref gaxgrpc::ApiCall<CreateFeatureRequest, lro::Operation> call);

        partial void Modify_BatchCreateFeaturesApiCall(ref gaxgrpc::ApiCall<BatchCreateFeaturesRequest, lro::Operation> call);

        partial void Modify_GetFeatureApiCall(ref gaxgrpc::ApiCall<GetFeatureRequest, Feature> call);

        partial void Modify_ListFeaturesApiCall(ref gaxgrpc::ApiCall<ListFeaturesRequest, ListFeaturesResponse> call);

        partial void Modify_UpdateFeatureApiCall(ref gaxgrpc::ApiCall<UpdateFeatureRequest, Feature> call);

        partial void Modify_DeleteFeatureApiCall(ref gaxgrpc::ApiCall<DeleteFeatureRequest, lro::Operation> call);

        partial void Modify_ImportFeatureValuesApiCall(ref gaxgrpc::ApiCall<ImportFeatureValuesRequest, lro::Operation> call);

        partial void Modify_BatchReadFeatureValuesApiCall(ref gaxgrpc::ApiCall<BatchReadFeatureValuesRequest, lro::Operation> call);

        partial void Modify_ExportFeatureValuesApiCall(ref gaxgrpc::ApiCall<ExportFeatureValuesRequest, lro::Operation> call);

        partial void Modify_DeleteFeatureValuesApiCall(ref gaxgrpc::ApiCall<DeleteFeatureValuesRequest, lro::Operation> call);

        partial void Modify_SearchFeaturesApiCall(ref gaxgrpc::ApiCall<SearchFeaturesRequest, SearchFeaturesResponse> call);

        partial void OnConstruction(FeaturestoreService.FeaturestoreServiceClient grpcClient, FeaturestoreServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeaturestoreService client</summary>
        public override FeaturestoreService.FeaturestoreServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateFeaturestoreRequest(ref CreateFeaturestoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeaturestoreRequest(ref GetFeaturestoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeaturestoresRequest(ref ListFeaturestoresRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFeaturestoreRequest(ref UpdateFeaturestoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFeaturestoreRequest(ref DeleteFeaturestoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEntityTypeRequest(ref CreateEntityTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEntityTypeRequest(ref GetEntityTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntityTypesRequest(ref ListEntityTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEntityTypeRequest(ref UpdateEntityTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEntityTypeRequest(ref DeleteEntityTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFeatureRequest(ref CreateFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateFeaturesRequest(ref BatchCreateFeaturesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeatureRequest(ref GetFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeaturesRequest(ref ListFeaturesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFeatureRequest(ref UpdateFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFeatureRequest(ref DeleteFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportFeatureValuesRequest(ref ImportFeatureValuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchReadFeatureValuesRequest(ref BatchReadFeatureValuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportFeatureValuesRequest(ref ExportFeatureValuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFeatureValuesRequest(ref DeleteFeatureValuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchFeaturesRequest(ref SearchFeaturesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateFeaturestore</c>.</summary>
        public override lro::OperationsClient CreateFeaturestoreOperationsClient { get; }

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata> CreateFeaturestore(CreateFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeaturestoreRequest(ref request, ref callSettings);
            return new lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>(_callCreateFeaturestore.Sync(request, callSettings), CreateFeaturestoreOperationsClient);
        }

        /// <summary>
        /// Creates a new Featurestore in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>> CreateFeaturestoreAsync(CreateFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeaturestoreRequest(ref request, ref callSettings);
            return new lro::Operation<Featurestore, CreateFeaturestoreOperationMetadata>(await _callCreateFeaturestore.Async(request, callSettings).ConfigureAwait(false), CreateFeaturestoreOperationsClient);
        }

        /// <summary>
        /// Gets details of a single Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Featurestore GetFeaturestore(GetFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeaturestoreRequest(ref request, ref callSettings);
            return _callGetFeaturestore.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Featurestore> GetFeaturestoreAsync(GetFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeaturestoreRequest(ref request, ref callSettings);
            return _callGetFeaturestore.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Featurestores in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Featurestore"/> resources.</returns>
        public override gax::PagedEnumerable<ListFeaturestoresResponse, Featurestore> ListFeaturestores(ListFeaturestoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeaturestoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFeaturestoresRequest, ListFeaturestoresResponse, Featurestore>(_callListFeaturestores, request, callSettings);
        }

        /// <summary>
        /// Lists Featurestores in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Featurestore"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFeaturestoresResponse, Featurestore> ListFeaturestoresAsync(ListFeaturestoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeaturestoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFeaturestoresRequest, ListFeaturestoresResponse, Featurestore>(_callListFeaturestores, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateFeaturestore</c>.</summary>
        public override lro::OperationsClient UpdateFeaturestoreOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata> UpdateFeaturestore(UpdateFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeaturestoreRequest(ref request, ref callSettings);
            return new lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata>(_callUpdateFeaturestore.Sync(request, callSettings), UpdateFeaturestoreOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata>> UpdateFeaturestoreAsync(UpdateFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeaturestoreRequest(ref request, ref callSettings);
            return new lro::Operation<Featurestore, UpdateFeaturestoreOperationMetadata>(await _callUpdateFeaturestore.Async(request, callSettings).ConfigureAwait(false), UpdateFeaturestoreOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFeaturestore</c>.</summary>
        public override lro::OperationsClient DeleteFeaturestoreOperationsClient { get; }

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeaturestore(DeleteFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeaturestoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteFeaturestore.Sync(request, callSettings), DeleteFeaturestoreOperationsClient);
        }

        /// <summary>
        /// Deletes a single Featurestore. The Featurestore must not contain any
        /// EntityTypes or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeaturestoreAsync(DeleteFeaturestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeaturestoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteFeaturestore.Async(request, callSettings).ConfigureAwait(false), DeleteFeaturestoreOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateEntityType</c>.</summary>
        public override lro::OperationsClient CreateEntityTypeOperationsClient { get; }

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EntityType, CreateEntityTypeOperationMetadata> CreateEntityType(CreateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntityTypeRequest(ref request, ref callSettings);
            return new lro::Operation<EntityType, CreateEntityTypeOperationMetadata>(_callCreateEntityType.Sync(request, callSettings), CreateEntityTypeOperationsClient);
        }

        /// <summary>
        /// Creates a new EntityType in a given Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EntityType, CreateEntityTypeOperationMetadata>> CreateEntityTypeAsync(CreateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntityTypeRequest(ref request, ref callSettings);
            return new lro::Operation<EntityType, CreateEntityTypeOperationMetadata>(await _callCreateEntityType.Async(request, callSettings).ConfigureAwait(false), CreateEntityTypeOperationsClient);
        }

        /// <summary>
        /// Gets details of a single EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntityType GetEntityType(GetEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntityTypeRequest(ref request, ref callSettings);
            return _callGetEntityType.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntityType> GetEntityTypeAsync(GetEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntityTypeRequest(ref request, ref callSettings);
            return _callGetEntityType.Async(request, callSettings);
        }

        /// <summary>
        /// Lists EntityTypes in a given Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntityType"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(ListEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntityTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntityTypesRequest, ListEntityTypesResponse, EntityType>(_callListEntityTypes, request, callSettings);
        }

        /// <summary>
        /// Lists EntityTypes in a given Featurestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntityType"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(ListEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntityTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntityTypesRequest, ListEntityTypesResponse, EntityType>(_callListEntityTypes, request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntityType UpdateEntityType(UpdateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntityTypeRequest(ref request, ref callSettings);
            return _callUpdateEntityType.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntityType> UpdateEntityTypeAsync(UpdateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntityTypeRequest(ref request, ref callSettings);
            return _callUpdateEntityType.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteEntityType</c>.</summary>
        public override lro::OperationsClient DeleteEntityTypeOperationsClient { get; }

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteEntityType(DeleteEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntityTypeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteEntityType.Sync(request, callSettings), DeleteEntityTypeOperationsClient);
        }

        /// <summary>
        /// Deletes a single EntityType. The EntityType must not have any Features
        /// or `force` must be set to true for the request to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEntityTypeAsync(DeleteEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntityTypeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteEntityType.Async(request, callSettings).ConfigureAwait(false), DeleteEntityTypeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateFeature</c>.</summary>
        public override lro::OperationsClient CreateFeatureOperationsClient { get; }

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Feature, CreateFeatureOperationMetadata> CreateFeature(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, CreateFeatureOperationMetadata>(_callCreateFeature.Sync(request, callSettings), CreateFeatureOperationsClient);
        }

        /// <summary>
        /// Creates a new Feature in a given EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, CreateFeatureOperationMetadata>(await _callCreateFeature.Async(request, callSettings).ConfigureAwait(false), CreateFeatureOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchCreateFeatures</c>.</summary>
        public override lro::OperationsClient BatchCreateFeaturesOperationsClient { get; }

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> BatchCreateFeatures(BatchCreateFeaturesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateFeaturesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>(_callBatchCreateFeatures.Sync(request, callSettings), BatchCreateFeaturesOperationsClient);
        }

        /// <summary>
        /// Creates a batch of Features in a given EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>> BatchCreateFeaturesAsync(BatchCreateFeaturesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateFeaturesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata>(await _callBatchCreateFeatures.Async(request, callSettings).ConfigureAwait(false), BatchCreateFeaturesOperationsClient);
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

        /// <summary>
        /// Lists Features in a given EntityType.
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
        /// Lists Features in a given EntityType.
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
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Feature UpdateFeature(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureRequest(ref request, ref callSettings);
            return _callUpdateFeature.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Feature> UpdateFeatureAsync(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureRequest(ref request, ref callSettings);
            return _callUpdateFeature.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteFeature</c>.</summary>
        public override lro::OperationsClient DeleteFeatureOperationsClient { get; }

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeature(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteFeature.Sync(request, callSettings), DeleteFeatureOperationsClient);
        }

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteFeature.Async(request, callSettings).ConfigureAwait(false), DeleteFeatureOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportFeatureValues</c>.</summary>
        public override lro::OperationsClient ImportFeatureValuesOperationsClient { get; }

        /// <summary>
        /// Imports Feature values into the Featurestore from a source storage.
        /// 
        /// The progress of the import is tracked by the returned operation. The
        /// imported features are guaranteed to be visible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If an import operation fails, the Feature values returned from
        /// reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same import request again and wait till
        /// the new operation returned is marked as successfully done.
        /// 
        /// There are also scenarios where the caller can cause inconsistency.
        /// 
        /// - Source data for import contains multiple distinct Feature values for
        /// the same entity ID and timestamp.
        /// - Source is modified during an import. This includes adding, updating, or
        /// removing source data and/or metadata. Examples of updating metadata
        /// include but are not limited to changing storage location, storage class,
        /// or retention policy.
        /// - Online serving cluster is under-provisioned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> ImportFeatureValues(ImportFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportFeatureValuesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata>(_callImportFeatureValues.Sync(request, callSettings), ImportFeatureValuesOperationsClient);
        }

        /// <summary>
        /// Imports Feature values into the Featurestore from a source storage.
        /// 
        /// The progress of the import is tracked by the returned operation. The
        /// imported features are guaranteed to be visible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If an import operation fails, the Feature values returned from
        /// reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same import request again and wait till
        /// the new operation returned is marked as successfully done.
        /// 
        /// There are also scenarios where the caller can cause inconsistency.
        /// 
        /// - Source data for import contains multiple distinct Feature values for
        /// the same entity ID and timestamp.
        /// - Source is modified during an import. This includes adding, updating, or
        /// removing source data and/or metadata. Examples of updating metadata
        /// include but are not limited to changing storage location, storage class,
        /// or retention policy.
        /// - Online serving cluster is under-provisioned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata>> ImportFeatureValuesAsync(ImportFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportFeatureValuesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata>(await _callImportFeatureValues.Async(request, callSettings).ConfigureAwait(false), ImportFeatureValuesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchReadFeatureValues</c>.</summary>
        public override lro::OperationsClient BatchReadFeatureValuesOperationsClient { get; }

        /// <summary>
        /// Batch reads Feature values from a Featurestore.
        /// 
        /// This API enables batch reading Feature values, where each read
        /// instance in the batch may read Feature values of entities from one or
        /// more EntityTypes. Point-in-time correctness is guaranteed for Feature
        /// values of each read instance as of each instance's read timestamp.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> BatchReadFeatureValues(BatchReadFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchReadFeatureValuesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata>(_callBatchReadFeatureValues.Sync(request, callSettings), BatchReadFeatureValuesOperationsClient);
        }

        /// <summary>
        /// Batch reads Feature values from a Featurestore.
        /// 
        /// This API enables batch reading Feature values, where each read
        /// instance in the batch may read Feature values of entities from one or
        /// more EntityTypes. Point-in-time correctness is guaranteed for Feature
        /// values of each read instance as of each instance's read timestamp.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata>> BatchReadFeatureValuesAsync(BatchReadFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchReadFeatureValuesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata>(await _callBatchReadFeatureValues.Async(request, callSettings).ConfigureAwait(false), BatchReadFeatureValuesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportFeatureValues</c>.</summary>
        public override lro::OperationsClient ExportFeatureValuesOperationsClient { get; }

        /// <summary>
        /// Exports Feature values from all the entities of a target EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> ExportFeatureValues(ExportFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportFeatureValuesRequest(ref request, ref callSettings);
            return new lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata>(_callExportFeatureValues.Sync(request, callSettings), ExportFeatureValuesOperationsClient);
        }

        /// <summary>
        /// Exports Feature values from all the entities of a target EntityType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata>> ExportFeatureValuesAsync(ExportFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportFeatureValuesRequest(ref request, ref callSettings);
            return new lro::Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata>(await _callExportFeatureValues.Async(request, callSettings).ConfigureAwait(false), ExportFeatureValuesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFeatureValues</c>.</summary>
        public override lro::OperationsClient DeleteFeatureValuesOperationsClient { get; }

        /// <summary>
        /// Delete Feature values from Featurestore.
        /// 
        /// The progress of the deletion is tracked by the returned operation. The
        /// deleted feature values are guaranteed to be invisible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If a delete feature values operation fails, the feature values
        /// returned from reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same delete request again and wait till
        /// the new operation returned is marked as successfully done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> DeleteFeatureValues(DeleteFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureValuesRequest(ref request, ref callSettings);
            return new lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata>(_callDeleteFeatureValues.Sync(request, callSettings), DeleteFeatureValuesOperationsClient);
        }

        /// <summary>
        /// Delete Feature values from Featurestore.
        /// 
        /// The progress of the deletion is tracked by the returned operation. The
        /// deleted feature values are guaranteed to be invisible to subsequent read
        /// operations after the operation is marked as successfully done.
        /// 
        /// If a delete feature values operation fails, the feature values
        /// returned from reads and exports may be inconsistent. If consistency is
        /// required, the caller must retry the same delete request again and wait till
        /// the new operation returned is marked as successfully done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata>> DeleteFeatureValuesAsync(DeleteFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureValuesRequest(ref request, ref callSettings);
            return new lro::Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata>(await _callDeleteFeatureValues.Async(request, callSettings).ConfigureAwait(false), DeleteFeatureValuesOperationsClient);
        }

        /// <summary>
        /// Searches Features matching a query in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public override gax::PagedEnumerable<SearchFeaturesResponse, Feature> SearchFeatures(SearchFeaturesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchFeaturesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchFeaturesRequest, SearchFeaturesResponse, Feature>(_callSearchFeatures, request, callSettings);
        }

        /// <summary>
        /// Searches Features matching a query in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchFeaturesResponse, Feature> SearchFeaturesAsync(SearchFeaturesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchFeaturesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchFeaturesRequest, SearchFeaturesResponse, Feature>(_callSearchFeatures, request, callSettings);
        }
    }

    public partial class ListFeaturestoresRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntityTypesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeaturesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchFeaturesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeaturestoresResponse : gaxgrpc::IPageResponse<Featurestore>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Featurestore> GetEnumerator() => Featurestores.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEntityTypesResponse : gaxgrpc::IPageResponse<EntityType>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EntityType> GetEnumerator() => EntityTypes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFeaturesResponse : gaxgrpc::IPageResponse<Feature>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Feature> GetEnumerator() => Features.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchFeaturesResponse : gaxgrpc::IPageResponse<Feature>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Feature> GetEnumerator() => Features.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class FeaturestoreService
    {
        public partial class FeaturestoreServiceClient
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

    public static partial class FeaturestoreService
    {
        public partial class FeaturestoreServiceClient
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
