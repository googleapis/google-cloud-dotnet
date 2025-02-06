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
    /// <summary>Settings for <see cref="WarehouseClient"/> instances.</summary>
    public sealed partial class WarehouseSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WarehouseSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WarehouseSettings"/>.</returns>
        public static WarehouseSettings GetDefault() => new WarehouseSettings();

        /// <summary>Constructs a new <see cref="WarehouseSettings"/> object with default settings.</summary>
        public WarehouseSettings()
        {
        }

        private WarehouseSettings(WarehouseSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateAssetSettings = existing.CreateAssetSettings;
            UpdateAssetSettings = existing.UpdateAssetSettings;
            GetAssetSettings = existing.GetAssetSettings;
            ListAssetsSettings = existing.ListAssetsSettings;
            DeleteAssetSettings = existing.DeleteAssetSettings;
            DeleteAssetOperationsSettings = existing.DeleteAssetOperationsSettings.Clone();
            UploadAssetSettings = existing.UploadAssetSettings;
            UploadAssetOperationsSettings = existing.UploadAssetOperationsSettings.Clone();
            GenerateRetrievalUrlSettings = existing.GenerateRetrievalUrlSettings;
            AnalyzeAssetSettings = existing.AnalyzeAssetSettings;
            AnalyzeAssetOperationsSettings = existing.AnalyzeAssetOperationsSettings.Clone();
            IndexAssetSettings = existing.IndexAssetSettings;
            IndexAssetOperationsSettings = existing.IndexAssetOperationsSettings.Clone();
            RemoveIndexAssetSettings = existing.RemoveIndexAssetSettings;
            RemoveIndexAssetOperationsSettings = existing.RemoveIndexAssetOperationsSettings.Clone();
            ViewIndexedAssetsSettings = existing.ViewIndexedAssetsSettings;
            CreateIndexSettings = existing.CreateIndexSettings;
            CreateIndexOperationsSettings = existing.CreateIndexOperationsSettings.Clone();
            UpdateIndexSettings = existing.UpdateIndexSettings;
            UpdateIndexOperationsSettings = existing.UpdateIndexOperationsSettings.Clone();
            GetIndexSettings = existing.GetIndexSettings;
            ListIndexesSettings = existing.ListIndexesSettings;
            DeleteIndexSettings = existing.DeleteIndexSettings;
            DeleteIndexOperationsSettings = existing.DeleteIndexOperationsSettings.Clone();
            CreateCorpusSettings = existing.CreateCorpusSettings;
            CreateCorpusOperationsSettings = existing.CreateCorpusOperationsSettings.Clone();
            GetCorpusSettings = existing.GetCorpusSettings;
            UpdateCorpusSettings = existing.UpdateCorpusSettings;
            ListCorporaSettings = existing.ListCorporaSettings;
            DeleteCorpusSettings = existing.DeleteCorpusSettings;
            AnalyzeCorpusSettings = existing.AnalyzeCorpusSettings;
            AnalyzeCorpusOperationsSettings = existing.AnalyzeCorpusOperationsSettings.Clone();
            CreateDataSchemaSettings = existing.CreateDataSchemaSettings;
            UpdateDataSchemaSettings = existing.UpdateDataSchemaSettings;
            GetDataSchemaSettings = existing.GetDataSchemaSettings;
            DeleteDataSchemaSettings = existing.DeleteDataSchemaSettings;
            ListDataSchemasSettings = existing.ListDataSchemasSettings;
            CreateAnnotationSettings = existing.CreateAnnotationSettings;
            GetAnnotationSettings = existing.GetAnnotationSettings;
            ListAnnotationsSettings = existing.ListAnnotationsSettings;
            UpdateAnnotationSettings = existing.UpdateAnnotationSettings;
            DeleteAnnotationSettings = existing.DeleteAnnotationSettings;
            IngestAssetSettings = existing.IngestAssetSettings;
            IngestAssetStreamingSettings = existing.IngestAssetStreamingSettings;
            ClipAssetSettings = existing.ClipAssetSettings;
            GenerateHlsUriSettings = existing.GenerateHlsUriSettings;
            ImportAssetsSettings = existing.ImportAssetsSettings;
            ImportAssetsOperationsSettings = existing.ImportAssetsOperationsSettings.Clone();
            CreateSearchConfigSettings = existing.CreateSearchConfigSettings;
            UpdateSearchConfigSettings = existing.UpdateSearchConfigSettings;
            GetSearchConfigSettings = existing.GetSearchConfigSettings;
            DeleteSearchConfigSettings = existing.DeleteSearchConfigSettings;
            ListSearchConfigsSettings = existing.ListSearchConfigsSettings;
            CreateSearchHypernymSettings = existing.CreateSearchHypernymSettings;
            UpdateSearchHypernymSettings = existing.UpdateSearchHypernymSettings;
            GetSearchHypernymSettings = existing.GetSearchHypernymSettings;
            DeleteSearchHypernymSettings = existing.DeleteSearchHypernymSettings;
            ListSearchHypernymsSettings = existing.ListSearchHypernymsSettings;
            SearchAssetsSettings = existing.SearchAssetsSettings;
            SearchIndexEndpointSettings = existing.SearchIndexEndpointSettings;
            CreateIndexEndpointSettings = existing.CreateIndexEndpointSettings;
            CreateIndexEndpointOperationsSettings = existing.CreateIndexEndpointOperationsSettings.Clone();
            GetIndexEndpointSettings = existing.GetIndexEndpointSettings;
            ListIndexEndpointsSettings = existing.ListIndexEndpointsSettings;
            UpdateIndexEndpointSettings = existing.UpdateIndexEndpointSettings;
            UpdateIndexEndpointOperationsSettings = existing.UpdateIndexEndpointOperationsSettings.Clone();
            DeleteIndexEndpointSettings = existing.DeleteIndexEndpointSettings;
            DeleteIndexEndpointOperationsSettings = existing.DeleteIndexEndpointOperationsSettings.Clone();
            DeployIndexSettings = existing.DeployIndexSettings;
            DeployIndexOperationsSettings = existing.DeployIndexOperationsSettings.Clone();
            UndeployIndexSettings = existing.UndeployIndexSettings;
            UndeployIndexOperationsSettings = existing.UndeployIndexOperationsSettings.Clone();
            CreateCollectionSettings = existing.CreateCollectionSettings;
            CreateCollectionOperationsSettings = existing.CreateCollectionOperationsSettings.Clone();
            DeleteCollectionSettings = existing.DeleteCollectionSettings;
            DeleteCollectionOperationsSettings = existing.DeleteCollectionOperationsSettings.Clone();
            GetCollectionSettings = existing.GetCollectionSettings;
            UpdateCollectionSettings = existing.UpdateCollectionSettings;
            ListCollectionsSettings = existing.ListCollectionsSettings;
            AddCollectionItemSettings = existing.AddCollectionItemSettings;
            RemoveCollectionItemSettings = existing.RemoveCollectionItemSettings;
            ViewCollectionItemsSettings = existing.ViewCollectionItemsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(WarehouseSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.CreateAsset</c>
        ///  and <c>WarehouseClient.CreateAssetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2.5</description></item>
        /// <item><description>Retry maximum delay: 120000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAssetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(120000), backoffMultiplier: 2.5, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.UpdateAsset</c>
        ///  and <c>WarehouseClient.UpdateAssetAsync</c>.
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
        public gaxgrpc::CallSettings UpdateAssetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.GetAsset</c>
        ///  and <c>WarehouseClient.GetAssetAsync</c>.
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
        public gaxgrpc::CallSettings GetAssetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.ListAssets</c>
        ///  and <c>WarehouseClient.ListAssetsAsync</c>.
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
        public gaxgrpc::CallSettings ListAssetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.DeleteAsset</c>
        ///  and <c>WarehouseClient.DeleteAssetAsync</c>.
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
        public gaxgrpc::CallSettings DeleteAssetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.DeleteAsset</c> and
        /// <c>WarehouseClient.DeleteAssetAsync</c>.
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
        public lro::OperationsSettings DeleteAssetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.UploadAsset</c>
        ///  and <c>WarehouseClient.UploadAssetAsync</c>.
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
        public gaxgrpc::CallSettings UploadAssetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.UploadAsset</c> and
        /// <c>WarehouseClient.UploadAssetAsync</c>.
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
        public lro::OperationsSettings UploadAssetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.GenerateRetrievalUrl</c> and <c>WarehouseClient.GenerateRetrievalUrlAsync</c>.
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
        public gaxgrpc::CallSettings GenerateRetrievalUrlSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.AnalyzeAsset</c> and <c>WarehouseClient.AnalyzeAssetAsync</c>.
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
        public gaxgrpc::CallSettings AnalyzeAssetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.AnalyzeAsset</c> and
        /// <c>WarehouseClient.AnalyzeAssetAsync</c>.
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
        public lro::OperationsSettings AnalyzeAssetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.IndexAsset</c>
        ///  and <c>WarehouseClient.IndexAssetAsync</c>.
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
        public gaxgrpc::CallSettings IndexAssetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.IndexAsset</c> and
        /// <c>WarehouseClient.IndexAssetAsync</c>.
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
        public lro::OperationsSettings IndexAssetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.RemoveIndexAsset</c> and <c>WarehouseClient.RemoveIndexAssetAsync</c>.
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
        public gaxgrpc::CallSettings RemoveIndexAssetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.RemoveIndexAsset</c> and
        /// <c>WarehouseClient.RemoveIndexAssetAsync</c>.
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
        public lro::OperationsSettings RemoveIndexAssetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.ViewIndexedAssets</c> and <c>WarehouseClient.ViewIndexedAssetsAsync</c>.
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
        public gaxgrpc::CallSettings ViewIndexedAssetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.CreateIndex</c>
        ///  and <c>WarehouseClient.CreateIndexAsync</c>.
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
        public gaxgrpc::CallSettings CreateIndexSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.CreateIndex</c> and
        /// <c>WarehouseClient.CreateIndexAsync</c>.
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
        public lro::OperationsSettings CreateIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.UpdateIndex</c>
        ///  and <c>WarehouseClient.UpdateIndexAsync</c>.
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
        public gaxgrpc::CallSettings UpdateIndexSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.UpdateIndex</c> and
        /// <c>WarehouseClient.UpdateIndexAsync</c>.
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
        public lro::OperationsSettings UpdateIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.GetIndex</c>
        ///  and <c>WarehouseClient.GetIndexAsync</c>.
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
        public gaxgrpc::CallSettings GetIndexSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.ListIndexes</c>
        ///  and <c>WarehouseClient.ListIndexesAsync</c>.
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
        public gaxgrpc::CallSettings ListIndexesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.DeleteIndex</c>
        ///  and <c>WarehouseClient.DeleteIndexAsync</c>.
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
        public gaxgrpc::CallSettings DeleteIndexSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.DeleteIndex</c> and
        /// <c>WarehouseClient.DeleteIndexAsync</c>.
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
        public lro::OperationsSettings DeleteIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.CreateCorpus</c> and <c>WarehouseClient.CreateCorpusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2.5</description></item>
        /// <item><description>Retry maximum delay: 120000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCorpusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(120000), backoffMultiplier: 2.5, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.CreateCorpus</c> and
        /// <c>WarehouseClient.CreateCorpusAsync</c>.
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
        public lro::OperationsSettings CreateCorpusOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.GetCorpus</c>
        ///  and <c>WarehouseClient.GetCorpusAsync</c>.
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
        public gaxgrpc::CallSettings GetCorpusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.UpdateCorpus</c> and <c>WarehouseClient.UpdateCorpusAsync</c>.
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
        public gaxgrpc::CallSettings UpdateCorpusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.ListCorpora</c>
        ///  and <c>WarehouseClient.ListCorporaAsync</c>.
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
        public gaxgrpc::CallSettings ListCorporaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.DeleteCorpus</c> and <c>WarehouseClient.DeleteCorpusAsync</c>.
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
        public gaxgrpc::CallSettings DeleteCorpusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.AnalyzeCorpus</c> and <c>WarehouseClient.AnalyzeCorpusAsync</c>.
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
        public gaxgrpc::CallSettings AnalyzeCorpusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.AnalyzeCorpus</c> and
        /// <c>WarehouseClient.AnalyzeCorpusAsync</c>.
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
        public lro::OperationsSettings AnalyzeCorpusOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.CreateDataSchema</c> and <c>WarehouseClient.CreateDataSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2.5</description></item>
        /// <item><description>Retry maximum delay: 120000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataSchemaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(120000), backoffMultiplier: 2.5, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.UpdateDataSchema</c> and <c>WarehouseClient.UpdateDataSchemaAsync</c>.
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
        public gaxgrpc::CallSettings UpdateDataSchemaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.GetDataSchema</c> and <c>WarehouseClient.GetDataSchemaAsync</c>.
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
        public gaxgrpc::CallSettings GetDataSchemaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.DeleteDataSchema</c> and <c>WarehouseClient.DeleteDataSchemaAsync</c>.
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
        public gaxgrpc::CallSettings DeleteDataSchemaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.ListDataSchemas</c> and <c>WarehouseClient.ListDataSchemasAsync</c>.
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
        public gaxgrpc::CallSettings ListDataSchemasSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.CreateAnnotation</c> and <c>WarehouseClient.CreateAnnotationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2.5</description></item>
        /// <item><description>Retry maximum delay: 120000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAnnotationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(120000), backoffMultiplier: 2.5, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.GetAnnotation</c> and <c>WarehouseClient.GetAnnotationAsync</c>.
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
        public gaxgrpc::CallSettings GetAnnotationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.ListAnnotations</c> and <c>WarehouseClient.ListAnnotationsAsync</c>.
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
        public gaxgrpc::CallSettings ListAnnotationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.UpdateAnnotation</c> and <c>WarehouseClient.UpdateAnnotationAsync</c>.
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
        public gaxgrpc::CallSettings UpdateAnnotationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.DeleteAnnotation</c> and <c>WarehouseClient.DeleteAnnotationAsync</c>.
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
        public gaxgrpc::CallSettings DeleteAnnotationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.IngestAsset</c>
        ///  and <c>WarehouseClient.IngestAssetAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 120 seconds.</remarks>
        public gaxgrpc::CallSettings IngestAssetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>WarehouseClient.IngestAsset</c> and
        /// <c>WarehouseClient.IngestAssetAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings IngestAssetStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.ClipAsset</c>
        ///  and <c>WarehouseClient.ClipAssetAsync</c>.
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
        public gaxgrpc::CallSettings ClipAssetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.GenerateHlsUri</c> and <c>WarehouseClient.GenerateHlsUriAsync</c>.
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
        public gaxgrpc::CallSettings GenerateHlsUriSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.ImportAssets</c> and <c>WarehouseClient.ImportAssetsAsync</c>.
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
        public gaxgrpc::CallSettings ImportAssetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.ImportAssets</c> and
        /// <c>WarehouseClient.ImportAssetsAsync</c>.
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
        public lro::OperationsSettings ImportAssetsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.CreateSearchConfig</c> and <c>WarehouseClient.CreateSearchConfigAsync</c>.
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
        public gaxgrpc::CallSettings CreateSearchConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.UpdateSearchConfig</c> and <c>WarehouseClient.UpdateSearchConfigAsync</c>.
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
        public gaxgrpc::CallSettings UpdateSearchConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.GetSearchConfig</c> and <c>WarehouseClient.GetSearchConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetSearchConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.DeleteSearchConfig</c> and <c>WarehouseClient.DeleteSearchConfigAsync</c>.
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
        public gaxgrpc::CallSettings DeleteSearchConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.ListSearchConfigs</c> and <c>WarehouseClient.ListSearchConfigsAsync</c>.
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
        public gaxgrpc::CallSettings ListSearchConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.CreateSearchHypernym</c> and <c>WarehouseClient.CreateSearchHypernymAsync</c>.
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
        public gaxgrpc::CallSettings CreateSearchHypernymSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.UpdateSearchHypernym</c> and <c>WarehouseClient.UpdateSearchHypernymAsync</c>.
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
        public gaxgrpc::CallSettings UpdateSearchHypernymSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.GetSearchHypernym</c> and <c>WarehouseClient.GetSearchHypernymAsync</c>.
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
        public gaxgrpc::CallSettings GetSearchHypernymSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.DeleteSearchHypernym</c> and <c>WarehouseClient.DeleteSearchHypernymAsync</c>.
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
        public gaxgrpc::CallSettings DeleteSearchHypernymSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.ListSearchHypernyms</c> and <c>WarehouseClient.ListSearchHypernymsAsync</c>.
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
        public gaxgrpc::CallSettings ListSearchHypernymsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.SearchAssets</c> and <c>WarehouseClient.SearchAssetsAsync</c>.
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
        public gaxgrpc::CallSettings SearchAssetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.SearchIndexEndpoint</c> and <c>WarehouseClient.SearchIndexEndpointAsync</c>.
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
        public gaxgrpc::CallSettings SearchIndexEndpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.CreateIndexEndpoint</c> and <c>WarehouseClient.CreateIndexEndpointAsync</c>.
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
        public gaxgrpc::CallSettings CreateIndexEndpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.CreateIndexEndpoint</c> and
        /// <c>WarehouseClient.CreateIndexEndpointAsync</c>.
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
        public lro::OperationsSettings CreateIndexEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.GetIndexEndpoint</c> and <c>WarehouseClient.GetIndexEndpointAsync</c>.
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
        public gaxgrpc::CallSettings GetIndexEndpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.ListIndexEndpoints</c> and <c>WarehouseClient.ListIndexEndpointsAsync</c>.
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
        public gaxgrpc::CallSettings ListIndexEndpointsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.UpdateIndexEndpoint</c> and <c>WarehouseClient.UpdateIndexEndpointAsync</c>.
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
        public gaxgrpc::CallSettings UpdateIndexEndpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.UpdateIndexEndpoint</c> and
        /// <c>WarehouseClient.UpdateIndexEndpointAsync</c>.
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
        public lro::OperationsSettings UpdateIndexEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.DeleteIndexEndpoint</c> and <c>WarehouseClient.DeleteIndexEndpointAsync</c>.
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
        public gaxgrpc::CallSettings DeleteIndexEndpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.DeleteIndexEndpoint</c> and
        /// <c>WarehouseClient.DeleteIndexEndpointAsync</c>.
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
        public lro::OperationsSettings DeleteIndexEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WarehouseClient.DeployIndex</c>
        ///  and <c>WarehouseClient.DeployIndexAsync</c>.
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
        public gaxgrpc::CallSettings DeployIndexSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.DeployIndex</c> and
        /// <c>WarehouseClient.DeployIndexAsync</c>.
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
        public lro::OperationsSettings DeployIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.UndeployIndex</c> and <c>WarehouseClient.UndeployIndexAsync</c>.
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
        public gaxgrpc::CallSettings UndeployIndexSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.UndeployIndex</c> and
        /// <c>WarehouseClient.UndeployIndexAsync</c>.
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
        public lro::OperationsSettings UndeployIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.CreateCollection</c> and <c>WarehouseClient.CreateCollectionAsync</c>.
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
        public gaxgrpc::CallSettings CreateCollectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.CreateCollection</c> and
        /// <c>WarehouseClient.CreateCollectionAsync</c>.
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
        public lro::OperationsSettings CreateCollectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.DeleteCollection</c> and <c>WarehouseClient.DeleteCollectionAsync</c>.
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
        public gaxgrpc::CallSettings DeleteCollectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WarehouseClient.DeleteCollection</c> and
        /// <c>WarehouseClient.DeleteCollectionAsync</c>.
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
        public lro::OperationsSettings DeleteCollectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.GetCollection</c> and <c>WarehouseClient.GetCollectionAsync</c>.
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
        public gaxgrpc::CallSettings GetCollectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.UpdateCollection</c> and <c>WarehouseClient.UpdateCollectionAsync</c>.
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
        public gaxgrpc::CallSettings UpdateCollectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.ListCollections</c> and <c>WarehouseClient.ListCollectionsAsync</c>.
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
        public gaxgrpc::CallSettings ListCollectionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.AddCollectionItem</c> and <c>WarehouseClient.AddCollectionItemAsync</c>.
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
        public gaxgrpc::CallSettings AddCollectionItemSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.RemoveCollectionItem</c> and <c>WarehouseClient.RemoveCollectionItemAsync</c>.
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
        public gaxgrpc::CallSettings RemoveCollectionItemSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WarehouseClient.ViewCollectionItems</c> and <c>WarehouseClient.ViewCollectionItemsAsync</c>.
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
        public gaxgrpc::CallSettings ViewCollectionItemsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WarehouseSettings"/> object.</returns>
        public WarehouseSettings Clone() => new WarehouseSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WarehouseClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class WarehouseClientBuilder : gaxgrpc::ClientBuilderBase<WarehouseClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WarehouseSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WarehouseClientBuilder() : base(WarehouseClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WarehouseClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WarehouseClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WarehouseClient Build()
        {
            WarehouseClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WarehouseClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WarehouseClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WarehouseClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WarehouseClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WarehouseClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WarehouseClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WarehouseClient.ChannelPool;
    }

    /// <summary>Warehouse client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service that manages media content + metadata for streaming.
    /// </remarks>
    public abstract partial class WarehouseClient
    {
        /// <summary>
        /// The default endpoint for the Warehouse service, which is a host of "visionai.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "visionai.googleapis.com:443";

        /// <summary>The default Warehouse scopes.</summary>
        /// <remarks>
        /// The default Warehouse scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Warehouse.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WarehouseClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="WarehouseClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WarehouseClient"/>.</returns>
        public static stt::Task<WarehouseClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WarehouseClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WarehouseClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="WarehouseClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WarehouseClient"/>.</returns>
        public static WarehouseClient Create() => new WarehouseClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WarehouseClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WarehouseSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WarehouseClient"/>.</returns>
        internal static WarehouseClient Create(grpccore::CallInvoker callInvoker, WarehouseSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Warehouse.WarehouseClient grpcClient = new Warehouse.WarehouseClient(callInvoker);
            return new WarehouseClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Warehouse client</summary>
        public virtual Warehouse.WarehouseClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset CreateAsset(CreateAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> CreateAssetAsync(CreateAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> CreateAssetAsync(CreateAssetRequest request, st::CancellationToken cancellationToken) =>
            CreateAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an asset inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this asset will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="asset">
        /// Required. The asset to create.
        /// </param>
        /// <param name="assetId">
        /// Optional. The ID to use for the asset, which will become the final
        /// component of the asset's resource name if user choose to specify.
        /// Otherwise, asset id will be generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset CreateAsset(string parent, Asset asset, string assetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAsset(new CreateAssetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
                AssetId = assetId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an asset inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this asset will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="asset">
        /// Required. The asset to create.
        /// </param>
        /// <param name="assetId">
        /// Optional. The ID to use for the asset, which will become the final
        /// component of the asset's resource name if user choose to specify.
        /// Otherwise, asset id will be generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> CreateAssetAsync(string parent, Asset asset, string assetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssetAsync(new CreateAssetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
                AssetId = assetId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an asset inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this asset will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="asset">
        /// Required. The asset to create.
        /// </param>
        /// <param name="assetId">
        /// Optional. The ID to use for the asset, which will become the final
        /// component of the asset's resource name if user choose to specify.
        /// Otherwise, asset id will be generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> CreateAssetAsync(string parent, Asset asset, string assetId, st::CancellationToken cancellationToken) =>
            CreateAssetAsync(parent, asset, assetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an asset inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this asset will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="asset">
        /// Required. The asset to create.
        /// </param>
        /// <param name="assetId">
        /// Optional. The ID to use for the asset, which will become the final
        /// component of the asset's resource name if user choose to specify.
        /// Otherwise, asset id will be generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset CreateAsset(CorpusName parent, Asset asset, string assetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAsset(new CreateAssetRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
                AssetId = assetId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an asset inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this asset will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="asset">
        /// Required. The asset to create.
        /// </param>
        /// <param name="assetId">
        /// Optional. The ID to use for the asset, which will become the final
        /// component of the asset's resource name if user choose to specify.
        /// Otherwise, asset id will be generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> CreateAssetAsync(CorpusName parent, Asset asset, string assetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssetAsync(new CreateAssetRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
                AssetId = assetId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an asset inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this asset will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="asset">
        /// Required. The asset to create.
        /// </param>
        /// <param name="assetId">
        /// Optional. The ID to use for the asset, which will become the final
        /// component of the asset's resource name if user choose to specify.
        /// Otherwise, asset id will be generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> CreateAssetAsync(CorpusName parent, Asset asset, string assetId, st::CancellationToken cancellationToken) =>
            CreateAssetAsync(parent, asset, assetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset UpdateAsset(UpdateAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> UpdateAssetAsync(UpdateAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> UpdateAssetAsync(UpdateAssetRequest request, st::CancellationToken cancellationToken) =>
            UpdateAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an asset inside corpus.
        /// </summary>
        /// <param name="asset">
        /// Required. The asset to update.
        /// 
        /// The asset's `name` field is used to identify the asset to be updated.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset UpdateAsset(Asset asset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsset(new UpdateAssetRequest
            {
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an asset inside corpus.
        /// </summary>
        /// <param name="asset">
        /// Required. The asset to update.
        /// 
        /// The asset's `name` field is used to identify the asset to be updated.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> UpdateAssetAsync(Asset asset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAssetAsync(new UpdateAssetRequest
            {
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an asset inside corpus.
        /// </summary>
        /// <param name="asset">
        /// Required. The asset to update.
        /// 
        /// The asset's `name` field is used to identify the asset to be updated.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> UpdateAssetAsync(Asset asset, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAssetAsync(asset, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset GetAsset(GetAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(GetAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(GetAssetRequest request, st::CancellationToken cancellationToken) =>
            GetAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads an asset inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the asset to retrieve.
        /// Format:
        /// projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset GetAsset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAsset(new GetAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reads an asset inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the asset to retrieve.
        /// Format:
        /// projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssetAsync(new GetAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reads an asset inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the asset to retrieve.
        /// Format:
        /// projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(string name, st::CancellationToken cancellationToken) =>
            GetAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads an asset inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the asset to retrieve.
        /// Format:
        /// projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset GetAsset(AssetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAsset(new GetAssetRequest
            {
                AssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reads an asset inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the asset to retrieve.
        /// Format:
        /// projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(AssetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssetAsync(new GetAssetRequest
            {
                AssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reads an asset inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the asset to retrieve.
        /// Format:
        /// projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(AssetName name, st::CancellationToken cancellationToken) =>
            GetAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists an list of assets inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssetsResponse, Asset> ListAssets(ListAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists an list of assets inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssetsResponse, Asset> ListAssetsAsync(ListAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists an list of assets inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of assets.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssetsResponse, Asset> ListAssets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetsRequest request = new ListAssetsRequest
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
            return ListAssets(request, callSettings);
        }

        /// <summary>
        /// Lists an list of assets inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of assets.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssetsResponse, Asset> ListAssetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetsRequest request = new ListAssetsRequest
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
            return ListAssetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists an list of assets inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of assets.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssetsResponse, Asset> ListAssets(CorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetsRequest request = new ListAssetsRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAssets(request, callSettings);
        }

        /// <summary>
        /// Lists an list of assets inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of assets.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssetsResponse, Asset> ListAssetsAsync(CorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetsRequest request = new ListAssetsRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAssetsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteAssetMetadata> DeleteAsset(DeleteAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAssetMetadata>> DeleteAssetAsync(DeleteAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAssetMetadata>> DeleteAssetAsync(DeleteAssetRequest request, st::CancellationToken cancellationToken) =>
            DeleteAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAsset</c>.</summary>
        public virtual lro::OperationsClient DeleteAssetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteAssetMetadata> PollOnceDeleteAsset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteAssetMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAssetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAssetMetadata>> PollOnceDeleteAssetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteAssetMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAssetOperationsClient, callSettings);

        /// <summary>
        /// Deletes asset inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the asset to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteAssetMetadata> DeleteAsset(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsset(new DeleteAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes asset inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the asset to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAssetMetadata>> DeleteAssetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssetAsync(new DeleteAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes asset inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the asset to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAssetMetadata>> DeleteAssetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes asset inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the asset to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteAssetMetadata> DeleteAsset(AssetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsset(new DeleteAssetRequest
            {
                AssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes asset inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the asset to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAssetMetadata>> DeleteAssetAsync(AssetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssetAsync(new DeleteAssetRequest
            {
                AssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes asset inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the asset to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAssetMetadata>> DeleteAssetAsync(AssetName name, st::CancellationToken cancellationToken) =>
            DeleteAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upload asset by specifing the asset Cloud Storage uri.
        /// For video warehouse, it requires users who call this API have read access
        /// to the cloud storage file. Once it is uploaded, it can be retrieved by
        /// GenerateRetrievalUrl API which by default, only can retrieve cloud storage
        /// files from the same project of the warehouse. To allow retrieval cloud
        /// storage files that are in a separate project, it requires to find the
        /// vision ai service account (Go to IAM, check checkbox to show "Include
        /// Google-provided role grants", search for "Cloud Vision AI Service Agent")
        /// and grant the read access of the cloud storage files to that service
        /// account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UploadAssetResponse, UploadAssetMetadata> UploadAsset(UploadAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upload asset by specifing the asset Cloud Storage uri.
        /// For video warehouse, it requires users who call this API have read access
        /// to the cloud storage file. Once it is uploaded, it can be retrieved by
        /// GenerateRetrievalUrl API which by default, only can retrieve cloud storage
        /// files from the same project of the warehouse. To allow retrieval cloud
        /// storage files that are in a separate project, it requires to find the
        /// vision ai service account (Go to IAM, check checkbox to show "Include
        /// Google-provided role grants", search for "Cloud Vision AI Service Agent")
        /// and grant the read access of the cloud storage files to that service
        /// account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UploadAssetResponse, UploadAssetMetadata>> UploadAssetAsync(UploadAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upload asset by specifing the asset Cloud Storage uri.
        /// For video warehouse, it requires users who call this API have read access
        /// to the cloud storage file. Once it is uploaded, it can be retrieved by
        /// GenerateRetrievalUrl API which by default, only can retrieve cloud storage
        /// files from the same project of the warehouse. To allow retrieval cloud
        /// storage files that are in a separate project, it requires to find the
        /// vision ai service account (Go to IAM, check checkbox to show "Include
        /// Google-provided role grants", search for "Cloud Vision AI Service Agent")
        /// and grant the read access of the cloud storage files to that service
        /// account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UploadAssetResponse, UploadAssetMetadata>> UploadAssetAsync(UploadAssetRequest request, st::CancellationToken cancellationToken) =>
            UploadAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UploadAsset</c>.</summary>
        public virtual lro::OperationsClient UploadAssetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UploadAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UploadAssetResponse, UploadAssetMetadata> PollOnceUploadAsset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UploadAssetResponse, UploadAssetMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UploadAssetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UploadAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UploadAssetResponse, UploadAssetMetadata>> PollOnceUploadAssetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UploadAssetResponse, UploadAssetMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UploadAssetOperationsClient, callSettings);

        /// <summary>
        /// Generates a signed url for downloading the asset.
        /// For video warehouse, please see comment of UploadAsset about how to allow
        /// retrieval of cloud storage files in a different project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateRetrievalUrlResponse GenerateRetrievalUrl(GenerateRetrievalUrlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a signed url for downloading the asset.
        /// For video warehouse, please see comment of UploadAsset about how to allow
        /// retrieval of cloud storage files in a different project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateRetrievalUrlResponse> GenerateRetrievalUrlAsync(GenerateRetrievalUrlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a signed url for downloading the asset.
        /// For video warehouse, please see comment of UploadAsset about how to allow
        /// retrieval of cloud storage files in a different project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateRetrievalUrlResponse> GenerateRetrievalUrlAsync(GenerateRetrievalUrlRequest request, st::CancellationToken cancellationToken) =>
            GenerateRetrievalUrlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Analyze asset to power search capability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnalyzeAssetResponse, AnalyzeAssetMetadata> AnalyzeAsset(AnalyzeAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyze asset to power search capability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnalyzeAssetResponse, AnalyzeAssetMetadata>> AnalyzeAssetAsync(AnalyzeAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyze asset to power search capability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnalyzeAssetResponse, AnalyzeAssetMetadata>> AnalyzeAssetAsync(AnalyzeAssetRequest request, st::CancellationToken cancellationToken) =>
            AnalyzeAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AnalyzeAsset</c>.</summary>
        public virtual lro::OperationsClient AnalyzeAssetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AnalyzeAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AnalyzeAssetResponse, AnalyzeAssetMetadata> PollOnceAnalyzeAsset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnalyzeAssetResponse, AnalyzeAssetMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AnalyzeAssetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AnalyzeAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AnalyzeAssetResponse, AnalyzeAssetMetadata>> PollOnceAnalyzeAssetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnalyzeAssetResponse, AnalyzeAssetMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AnalyzeAssetOperationsClient, callSettings);

        /// <summary>
        /// Index one asset for search.
        /// Supported corpus type: Corpus.Type.VIDEO_ON_DEMAND
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IndexAssetResponse, IndexAssetMetadata> IndexAsset(IndexAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Index one asset for search.
        /// Supported corpus type: Corpus.Type.VIDEO_ON_DEMAND
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexAssetResponse, IndexAssetMetadata>> IndexAssetAsync(IndexAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Index one asset for search.
        /// Supported corpus type: Corpus.Type.VIDEO_ON_DEMAND
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexAssetResponse, IndexAssetMetadata>> IndexAssetAsync(IndexAssetRequest request, st::CancellationToken cancellationToken) =>
            IndexAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>IndexAsset</c>.</summary>
        public virtual lro::OperationsClient IndexAssetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>IndexAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<IndexAssetResponse, IndexAssetMetadata> PollOnceIndexAsset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IndexAssetResponse, IndexAssetMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), IndexAssetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>IndexAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<IndexAssetResponse, IndexAssetMetadata>> PollOnceIndexAssetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IndexAssetResponse, IndexAssetMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), IndexAssetOperationsClient, callSettings);

        /// <summary>
        /// Remove one asset's index data for search.
        /// Supported corpus type: Corpus.Type.VIDEO_ON_DEMAND
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemoveIndexAssetResponse, RemoveIndexAssetMetadata> RemoveIndexAsset(RemoveIndexAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove one asset's index data for search.
        /// Supported corpus type: Corpus.Type.VIDEO_ON_DEMAND
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveIndexAssetResponse, RemoveIndexAssetMetadata>> RemoveIndexAssetAsync(RemoveIndexAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove one asset's index data for search.
        /// Supported corpus type: Corpus.Type.VIDEO_ON_DEMAND
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveIndexAssetResponse, RemoveIndexAssetMetadata>> RemoveIndexAssetAsync(RemoveIndexAssetRequest request, st::CancellationToken cancellationToken) =>
            RemoveIndexAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveIndexAsset</c>.</summary>
        public virtual lro::OperationsClient RemoveIndexAssetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RemoveIndexAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RemoveIndexAssetResponse, RemoveIndexAssetMetadata> PollOnceRemoveIndexAsset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RemoveIndexAssetResponse, RemoveIndexAssetMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveIndexAssetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveIndexAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RemoveIndexAssetResponse, RemoveIndexAssetMetadata>> PollOnceRemoveIndexAssetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RemoveIndexAssetResponse, RemoveIndexAssetMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveIndexAssetOperationsClient, callSettings);

        /// <summary>
        /// Lists assets inside an index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IndexedAsset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ViewIndexedAssetsResponse, IndexedAsset> ViewIndexedAssets(ViewIndexedAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists assets inside an index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IndexedAsset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ViewIndexedAssetsResponse, IndexedAsset> ViewIndexedAssetsAsync(ViewIndexedAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists assets inside an index.
        /// </summary>
        /// <param name="index">
        /// Required. The index that owns this collection of assets.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
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
        /// <returns>A pageable sequence of <see cref="IndexedAsset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ViewIndexedAssetsResponse, IndexedAsset> ViewIndexedAssets(string index, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ViewIndexedAssetsRequest request = new ViewIndexedAssetsRequest
            {
                Index = gax::GaxPreconditions.CheckNotNullOrEmpty(index, nameof(index)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ViewIndexedAssets(request, callSettings);
        }

        /// <summary>
        /// Lists assets inside an index.
        /// </summary>
        /// <param name="index">
        /// Required. The index that owns this collection of assets.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="IndexedAsset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ViewIndexedAssetsResponse, IndexedAsset> ViewIndexedAssetsAsync(string index, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ViewIndexedAssetsRequest request = new ViewIndexedAssetsRequest
            {
                Index = gax::GaxPreconditions.CheckNotNullOrEmpty(index, nameof(index)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ViewIndexedAssetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists assets inside an index.
        /// </summary>
        /// <param name="index">
        /// Required. The index that owns this collection of assets.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
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
        /// <returns>A pageable sequence of <see cref="IndexedAsset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ViewIndexedAssetsResponse, IndexedAsset> ViewIndexedAssets(IndexName index, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ViewIndexedAssetsRequest request = new ViewIndexedAssetsRequest
            {
                IndexAsIndexName = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ViewIndexedAssets(request, callSettings);
        }

        /// <summary>
        /// Lists assets inside an index.
        /// </summary>
        /// <param name="index">
        /// Required. The index that owns this collection of assets.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="IndexedAsset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ViewIndexedAssetsResponse, IndexedAsset> ViewIndexedAssetsAsync(IndexName index, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ViewIndexedAssetsRequest request = new ViewIndexedAssetsRequest
            {
                IndexAsIndexName = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ViewIndexedAssetsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates an Index under the corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, CreateIndexMetadata> CreateIndex(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Index under the corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexMetadata>> CreateIndexAsync(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Index under the corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexMetadata>> CreateIndexAsync(CreateIndexRequest request, st::CancellationToken cancellationToken) =>
            CreateIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateIndex</c>.</summary>
        public virtual lro::OperationsClient CreateIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Index, CreateIndexMetadata> PollOnceCreateIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, CreateIndexMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexMetadata>> PollOnceCreateIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, CreateIndexMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexOperationsClient, callSettings);

        /// <summary>
        /// Creates an Index under the corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for the parent. The resource name of the Corpus under which
        /// this index is created. Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="index">
        /// Required. The index being created.
        /// </param>
        /// <param name="indexId">
        /// Optional. The ID for the index. This will become the final resource name
        /// for the index. If the user does not specify this value, it will be
        /// generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, CreateIndexMetadata> CreateIndex(string parent, Index index, string indexId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndex(new CreateIndexRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IndexId = indexId ?? "",
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates an Index under the corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for the parent. The resource name of the Corpus under which
        /// this index is created. Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="index">
        /// Required. The index being created.
        /// </param>
        /// <param name="indexId">
        /// Optional. The ID for the index. This will become the final resource name
        /// for the index. If the user does not specify this value, it will be
        /// generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexMetadata>> CreateIndexAsync(string parent, Index index, string indexId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexAsync(new CreateIndexRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IndexId = indexId ?? "",
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates an Index under the corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for the parent. The resource name of the Corpus under which
        /// this index is created. Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="index">
        /// Required. The index being created.
        /// </param>
        /// <param name="indexId">
        /// Optional. The ID for the index. This will become the final resource name
        /// for the index. If the user does not specify this value, it will be
        /// generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexMetadata>> CreateIndexAsync(string parent, Index index, string indexId, st::CancellationToken cancellationToken) =>
            CreateIndexAsync(parent, index, indexId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Index under the corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for the parent. The resource name of the Corpus under which
        /// this index is created. Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="index">
        /// Required. The index being created.
        /// </param>
        /// <param name="indexId">
        /// Optional. The ID for the index. This will become the final resource name
        /// for the index. If the user does not specify this value, it will be
        /// generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, CreateIndexMetadata> CreateIndex(CorpusName parent, Index index, string indexId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndex(new CreateIndexRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IndexId = indexId ?? "",
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates an Index under the corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for the parent. The resource name of the Corpus under which
        /// this index is created. Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="index">
        /// Required. The index being created.
        /// </param>
        /// <param name="indexId">
        /// Optional. The ID for the index. This will become the final resource name
        /// for the index. If the user does not specify this value, it will be
        /// generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexMetadata>> CreateIndexAsync(CorpusName parent, Index index, string indexId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexAsync(new CreateIndexRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IndexId = indexId ?? "",
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates an Index under the corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for the parent. The resource name of the Corpus under which
        /// this index is created. Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="index">
        /// Required. The index being created.
        /// </param>
        /// <param name="indexId">
        /// Optional. The ID for the index. This will become the final resource name
        /// for the index. If the user does not specify this value, it will be
        /// generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexMetadata>> CreateIndexAsync(CorpusName parent, Index index, string indexId, st::CancellationToken cancellationToken) =>
            CreateIndexAsync(parent, index, indexId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an Index under the corpus.
        /// Users can perform a metadata-only update or trigger a full index rebuild
        /// with different update_mask values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, UpdateIndexMetadata> UpdateIndex(UpdateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Index under the corpus.
        /// Users can perform a metadata-only update or trigger a full index rebuild
        /// with different update_mask values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, UpdateIndexMetadata>> UpdateIndexAsync(UpdateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Index under the corpus.
        /// Users can perform a metadata-only update or trigger a full index rebuild
        /// with different update_mask values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, UpdateIndexMetadata>> UpdateIndexAsync(UpdateIndexRequest request, st::CancellationToken cancellationToken) =>
            UpdateIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateIndex</c>.</summary>
        public virtual lro::OperationsClient UpdateIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Index, UpdateIndexMetadata> PollOnceUpdateIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, UpdateIndexMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Index, UpdateIndexMetadata>> PollOnceUpdateIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, UpdateIndexMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateIndexOperationsClient, callSettings);

        /// <summary>
        /// Updates an Index under the corpus.
        /// Users can perform a metadata-only update or trigger a full index rebuild
        /// with different update_mask values.
        /// </summary>
        /// <param name="index">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Index resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field of the resource
        /// will be overwritten if it is in the mask. Empty field mask is not allowed.
        /// If the mask is "*", it triggers a full update of the index, and also a
        /// whole rebuild of index data.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, UpdateIndexMetadata> UpdateIndex(Index index, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIndex(new UpdateIndexRequest
            {
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an Index under the corpus.
        /// Users can perform a metadata-only update or trigger a full index rebuild
        /// with different update_mask values.
        /// </summary>
        /// <param name="index">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Index resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field of the resource
        /// will be overwritten if it is in the mask. Empty field mask is not allowed.
        /// If the mask is "*", it triggers a full update of the index, and also a
        /// whole rebuild of index data.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, UpdateIndexMetadata>> UpdateIndexAsync(Index index, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIndexAsync(new UpdateIndexRequest
            {
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an Index under the corpus.
        /// Users can perform a metadata-only update or trigger a full index rebuild
        /// with different update_mask values.
        /// </summary>
        /// <param name="index">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Index resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field of the resource
        /// will be overwritten if it is in the mask. Empty field mask is not allowed.
        /// If the mask is "*", it triggers a full update of the index, and also a
        /// whole rebuild of index data.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, UpdateIndexMetadata>> UpdateIndexAsync(Index index, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateIndexAsync(index, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a single Index under a Corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Index GetIndex(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a single Index under a Corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a single Index under a Corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(GetIndexRequest request, st::CancellationToken cancellationToken) =>
            GetIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a single Index under a Corpus.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Index resource.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Index GetIndex(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndex(new GetIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single Index under a Corpus.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Index resource.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexAsync(new GetIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single Index under a Corpus.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Index resource.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(string name, st::CancellationToken cancellationToken) =>
            GetIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a single Index under a Corpus.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Index resource.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Index GetIndex(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndex(new GetIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single Index under a Corpus.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Index resource.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexAsync(new GetIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single Index under a Corpus.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Index resource.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(IndexName name, st::CancellationToken cancellationToken) =>
            GetIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all Indexes in a given Corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all Indexes in a given Corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all Indexes in a given Corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent corpus that owns this collection of indexes.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexesRequest request = new ListIndexesRequest
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
            return ListIndexes(request, callSettings);
        }

        /// <summary>
        /// List all Indexes in a given Corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent corpus that owns this collection of indexes.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexesRequest request = new ListIndexesRequest
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
            return ListIndexesAsync(request, callSettings);
        }

        /// <summary>
        /// List all Indexes in a given Corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent corpus that owns this collection of indexes.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(CorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexesRequest request = new ListIndexesRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListIndexes(request, callSettings);
        }

        /// <summary>
        /// List all Indexes in a given Corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent corpus that owns this collection of indexes.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(CorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexesRequest request = new ListIndexesRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListIndexesAsync(request, callSettings);
        }

        /// <summary>
        /// Delete a single Index. In order to delete an index, the caller must
        /// make sure that it is not deployed to any index endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIndexMetadata> DeleteIndex(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single Index. In order to delete an index, the caller must
        /// make sure that it is not deployed to any index endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexMetadata>> DeleteIndexAsync(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single Index. In order to delete an index, the caller must
        /// make sure that it is not deployed to any index endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexMetadata>> DeleteIndexAsync(DeleteIndexRequest request, st::CancellationToken cancellationToken) =>
            DeleteIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteIndex</c>.</summary>
        public virtual lro::OperationsClient DeleteIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIndexMetadata> PollOnceDeleteIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteIndexMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexMetadata>> PollOnceDeleteIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteIndexMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIndexOperationsClient, callSettings);

        /// <summary>
        /// Delete a single Index. In order to delete an index, the caller must
        /// make sure that it is not deployed to any index endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the index to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIndexMetadata> DeleteIndex(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndex(new DeleteIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single Index. In order to delete an index, the caller must
        /// make sure that it is not deployed to any index endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the index to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexMetadata>> DeleteIndexAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexAsync(new DeleteIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single Index. In order to delete an index, the caller must
        /// make sure that it is not deployed to any index endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the index to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexMetadata>> DeleteIndexAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single Index. In order to delete an index, the caller must
        /// make sure that it is not deployed to any index endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the index to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIndexMetadata> DeleteIndex(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndex(new DeleteIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single Index. In order to delete an index, the caller must
        /// make sure that it is not deployed to any index endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the index to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexMetadata>> DeleteIndexAsync(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexAsync(new DeleteIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single Index. In order to delete an index, the caller must
        /// make sure that it is not deployed to any index endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the index to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/indexes/{index}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexMetadata>> DeleteIndexAsync(IndexName name, st::CancellationToken cancellationToken) =>
            DeleteIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a corpus inside a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Corpus, CreateCorpusMetadata> CreateCorpus(CreateCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a corpus inside a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Corpus, CreateCorpusMetadata>> CreateCorpusAsync(CreateCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a corpus inside a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Corpus, CreateCorpusMetadata>> CreateCorpusAsync(CreateCorpusRequest request, st::CancellationToken cancellationToken) =>
            CreateCorpusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCorpus</c>.</summary>
        public virtual lro::OperationsClient CreateCorpusOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCorpus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Corpus, CreateCorpusMetadata> PollOnceCreateCorpus(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Corpus, CreateCorpusMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCorpusOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCorpus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Corpus, CreateCorpusMetadata>> PollOnceCreateCorpusAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Corpus, CreateCorpusMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCorpusOperationsClient, callSettings);

        /// <summary>
        /// Creates a corpus inside a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Form: `projects/{project_number}/locations/{location_id}`
        /// </param>
        /// <param name="corpus">
        /// Required. The corpus to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Corpus, CreateCorpusMetadata> CreateCorpus(string parent, Corpus corpus, gaxgrpc::CallSettings callSettings = null) =>
            CreateCorpus(new CreateCorpusRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Corpus = gax::GaxPreconditions.CheckNotNull(corpus, nameof(corpus)),
            }, callSettings);

        /// <summary>
        /// Creates a corpus inside a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Form: `projects/{project_number}/locations/{location_id}`
        /// </param>
        /// <param name="corpus">
        /// Required. The corpus to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Corpus, CreateCorpusMetadata>> CreateCorpusAsync(string parent, Corpus corpus, gaxgrpc::CallSettings callSettings = null) =>
            CreateCorpusAsync(new CreateCorpusRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Corpus = gax::GaxPreconditions.CheckNotNull(corpus, nameof(corpus)),
            }, callSettings);

        /// <summary>
        /// Creates a corpus inside a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Form: `projects/{project_number}/locations/{location_id}`
        /// </param>
        /// <param name="corpus">
        /// Required. The corpus to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Corpus, CreateCorpusMetadata>> CreateCorpusAsync(string parent, Corpus corpus, st::CancellationToken cancellationToken) =>
            CreateCorpusAsync(parent, corpus, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets corpus details inside a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Corpus GetCorpus(GetCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets corpus details inside a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Corpus> GetCorpusAsync(GetCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets corpus details inside a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Corpus> GetCorpusAsync(GetCorpusRequest request, st::CancellationToken cancellationToken) =>
            GetCorpusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets corpus details inside a project.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the corpus to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Corpus GetCorpus(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCorpus(new GetCorpusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets corpus details inside a project.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the corpus to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Corpus> GetCorpusAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCorpusAsync(new GetCorpusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets corpus details inside a project.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the corpus to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Corpus> GetCorpusAsync(string name, st::CancellationToken cancellationToken) =>
            GetCorpusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets corpus details inside a project.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the corpus to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Corpus GetCorpus(CorpusName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCorpus(new GetCorpusRequest
            {
                CorpusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets corpus details inside a project.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the corpus to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Corpus> GetCorpusAsync(CorpusName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCorpusAsync(new GetCorpusRequest
            {
                CorpusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets corpus details inside a project.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the corpus to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Corpus> GetCorpusAsync(CorpusName name, st::CancellationToken cancellationToken) =>
            GetCorpusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a corpus in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Corpus UpdateCorpus(UpdateCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a corpus in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Corpus> UpdateCorpusAsync(UpdateCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a corpus in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Corpus> UpdateCorpusAsync(UpdateCorpusRequest request, st::CancellationToken cancellationToken) =>
            UpdateCorpusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a corpus in a project.
        /// </summary>
        /// <param name="corpus">
        /// Required. The corpus which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Corpus UpdateCorpus(Corpus corpus, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCorpus(new UpdateCorpusRequest
            {
                Corpus = gax::GaxPreconditions.CheckNotNull(corpus, nameof(corpus)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a corpus in a project.
        /// </summary>
        /// <param name="corpus">
        /// Required. The corpus which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Corpus> UpdateCorpusAsync(Corpus corpus, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCorpusAsync(new UpdateCorpusRequest
            {
                Corpus = gax::GaxPreconditions.CheckNotNull(corpus, nameof(corpus)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a corpus in a project.
        /// </summary>
        /// <param name="corpus">
        /// Required. The corpus which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Corpus> UpdateCorpusAsync(Corpus corpus, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCorpusAsync(corpus, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all corpora in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Corpus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCorporaResponse, Corpus> ListCorpora(ListCorporaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all corpora in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Corpus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCorporaResponse, Corpus> ListCorporaAsync(ListCorporaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all corpora in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project from which to list corpora.
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
        /// <returns>A pageable sequence of <see cref="Corpus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCorporaResponse, Corpus> ListCorpora(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCorporaRequest request = new ListCorporaRequest
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
            return ListCorpora(request, callSettings);
        }

        /// <summary>
        /// Lists all corpora in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project from which to list corpora.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Corpus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCorporaResponse, Corpus> ListCorporaAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCorporaRequest request = new ListCorporaRequest
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
            return ListCorporaAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a corpus only if its empty.
        /// Returns empty response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCorpus(DeleteCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a corpus only if its empty.
        /// Returns empty response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCorpusAsync(DeleteCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a corpus only if its empty.
        /// Returns empty response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCorpusAsync(DeleteCorpusRequest request, st::CancellationToken cancellationToken) =>
            DeleteCorpusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a corpus only if its empty.
        /// Returns empty response.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the corpus to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCorpus(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCorpus(new DeleteCorpusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a corpus only if its empty.
        /// Returns empty response.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the corpus to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCorpusAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCorpusAsync(new DeleteCorpusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a corpus only if its empty.
        /// Returns empty response.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the corpus to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCorpusAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCorpusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a corpus only if its empty.
        /// Returns empty response.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the corpus to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCorpus(CorpusName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCorpus(new DeleteCorpusRequest
            {
                CorpusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a corpus only if its empty.
        /// Returns empty response.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the corpus to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCorpusAsync(CorpusName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCorpusAsync(new DeleteCorpusRequest
            {
                CorpusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a corpus only if its empty.
        /// Returns empty response.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the corpus to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCorpusAsync(CorpusName name, st::CancellationToken cancellationToken) =>
            DeleteCorpusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Analyzes a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnalyzeCorpusResponse, AnalyzeCorpusMetadata> AnalyzeCorpus(AnalyzeCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnalyzeCorpusResponse, AnalyzeCorpusMetadata>> AnalyzeCorpusAsync(AnalyzeCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnalyzeCorpusResponse, AnalyzeCorpusMetadata>> AnalyzeCorpusAsync(AnalyzeCorpusRequest request, st::CancellationToken cancellationToken) =>
            AnalyzeCorpusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AnalyzeCorpus</c>.</summary>
        public virtual lro::OperationsClient AnalyzeCorpusOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AnalyzeCorpus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AnalyzeCorpusResponse, AnalyzeCorpusMetadata> PollOnceAnalyzeCorpus(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnalyzeCorpusResponse, AnalyzeCorpusMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AnalyzeCorpusOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AnalyzeCorpus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AnalyzeCorpusResponse, AnalyzeCorpusMetadata>> PollOnceAnalyzeCorpusAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnalyzeCorpusResponse, AnalyzeCorpusMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AnalyzeCorpusOperationsClient, callSettings);

        /// <summary>
        /// Creates data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSchema CreateDataSchema(CreateDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> CreateDataSchemaAsync(CreateDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> CreateDataSchemaAsync(CreateDataSchemaRequest request, st::CancellationToken cancellationToken) =>
            CreateDataSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates data schema inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data schema will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="dataSchema">
        /// Required. The data schema to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSchema CreateDataSchema(string parent, DataSchema dataSchema, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataSchema(new CreateDataSchemaRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataSchema = gax::GaxPreconditions.CheckNotNull(dataSchema, nameof(dataSchema)),
            }, callSettings);

        /// <summary>
        /// Creates data schema inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data schema will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="dataSchema">
        /// Required. The data schema to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> CreateDataSchemaAsync(string parent, DataSchema dataSchema, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataSchemaAsync(new CreateDataSchemaRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataSchema = gax::GaxPreconditions.CheckNotNull(dataSchema, nameof(dataSchema)),
            }, callSettings);

        /// <summary>
        /// Creates data schema inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data schema will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="dataSchema">
        /// Required. The data schema to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> CreateDataSchemaAsync(string parent, DataSchema dataSchema, st::CancellationToken cancellationToken) =>
            CreateDataSchemaAsync(parent, dataSchema, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates data schema inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data schema will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="dataSchema">
        /// Required. The data schema to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSchema CreateDataSchema(CorpusName parent, DataSchema dataSchema, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataSchema(new CreateDataSchemaRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataSchema = gax::GaxPreconditions.CheckNotNull(dataSchema, nameof(dataSchema)),
            }, callSettings);

        /// <summary>
        /// Creates data schema inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data schema will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="dataSchema">
        /// Required. The data schema to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> CreateDataSchemaAsync(CorpusName parent, DataSchema dataSchema, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataSchemaAsync(new CreateDataSchemaRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataSchema = gax::GaxPreconditions.CheckNotNull(dataSchema, nameof(dataSchema)),
            }, callSettings);

        /// <summary>
        /// Creates data schema inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data schema will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="dataSchema">
        /// Required. The data schema to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> CreateDataSchemaAsync(CorpusName parent, DataSchema dataSchema, st::CancellationToken cancellationToken) =>
            CreateDataSchemaAsync(parent, dataSchema, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSchema UpdateDataSchema(UpdateDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> UpdateDataSchemaAsync(UpdateDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> UpdateDataSchemaAsync(UpdateDataSchemaRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates data schema inside corpus.
        /// </summary>
        /// <param name="dataSchema">
        /// Required. The data schema's `name` field is used to identify the data
        /// schema to be updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSchema UpdateDataSchema(DataSchema dataSchema, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataSchema(new UpdateDataSchemaRequest
            {
                DataSchema = gax::GaxPreconditions.CheckNotNull(dataSchema, nameof(dataSchema)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates data schema inside corpus.
        /// </summary>
        /// <param name="dataSchema">
        /// Required. The data schema's `name` field is used to identify the data
        /// schema to be updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> UpdateDataSchemaAsync(DataSchema dataSchema, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataSchemaAsync(new UpdateDataSchemaRequest
            {
                DataSchema = gax::GaxPreconditions.CheckNotNull(dataSchema, nameof(dataSchema)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates data schema inside corpus.
        /// </summary>
        /// <param name="dataSchema">
        /// Required. The data schema's `name` field is used to identify the data
        /// schema to be updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/dataSchemas/{data_schema}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> UpdateDataSchemaAsync(DataSchema dataSchema, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataSchemaAsync(dataSchema, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSchema GetDataSchema(GetDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> GetDataSchemaAsync(GetDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> GetDataSchemaAsync(GetDataSchemaRequest request, st::CancellationToken cancellationToken) =>
            GetDataSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets data schema inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data schema to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/dataSchemas/{data_schema_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSchema GetDataSchema(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSchema(new GetDataSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets data schema inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data schema to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/dataSchemas/{data_schema_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> GetDataSchemaAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSchemaAsync(new GetDataSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets data schema inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data schema to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/dataSchemas/{data_schema_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> GetDataSchemaAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets data schema inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data schema to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/dataSchemas/{data_schema_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSchema GetDataSchema(DataSchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSchema(new GetDataSchemaRequest
            {
                DataSchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets data schema inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data schema to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/dataSchemas/{data_schema_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> GetDataSchemaAsync(DataSchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSchemaAsync(new GetDataSchemaRequest
            {
                DataSchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets data schema inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data schema to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/dataSchemas/{data_schema_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSchema> GetDataSchemaAsync(DataSchemaName name, st::CancellationToken cancellationToken) =>
            GetDataSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataSchema(DeleteDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataSchemaAsync(DeleteDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataSchemaAsync(DeleteDataSchemaRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes data schema inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data schema to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/dataSchemas/{data_schema_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataSchema(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataSchema(new DeleteDataSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes data schema inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data schema to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/dataSchemas/{data_schema_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataSchemaAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataSchemaAsync(new DeleteDataSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes data schema inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data schema to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/dataSchemas/{data_schema_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataSchemaAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes data schema inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data schema to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/dataSchemas/{data_schema_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataSchema(DataSchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataSchema(new DeleteDataSchemaRequest
            {
                DataSchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes data schema inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data schema to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/dataSchemas/{data_schema_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataSchemaAsync(DataSchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataSchemaAsync(new DeleteDataSchemaRequest
            {
                DataSchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes data schema inside corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data schema to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/dataSchemas/{data_schema_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataSchemaAsync(DataSchemaName name, st::CancellationToken cancellationToken) =>
            DeleteDataSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists a list of data schemas inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataSchemasResponse, DataSchema> ListDataSchemas(ListDataSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a list of data schemas inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSchemasResponse, DataSchema> ListDataSchemasAsync(ListDataSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a list of data schemas inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of data schemas.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
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
        /// <returns>A pageable sequence of <see cref="DataSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataSchemasResponse, DataSchema> ListDataSchemas(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSchemasRequest request = new ListDataSchemasRequest
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
            return ListDataSchemas(request, callSettings);
        }

        /// <summary>
        /// Lists a list of data schemas inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of data schemas.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSchemasResponse, DataSchema> ListDataSchemasAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSchemasRequest request = new ListDataSchemasRequest
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
            return ListDataSchemasAsync(request, callSettings);
        }

        /// <summary>
        /// Lists a list of data schemas inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of data schemas.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
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
        /// <returns>A pageable sequence of <see cref="DataSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataSchemasResponse, DataSchema> ListDataSchemas(CorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSchemasRequest request = new ListDataSchemasRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataSchemas(request, callSettings);
        }

        /// <summary>
        /// Lists a list of data schemas inside corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of data schemas.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSchemasResponse, DataSchema> ListDataSchemasAsync(CorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSchemasRequest request = new ListDataSchemasRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataSchemasAsync(request, callSettings);
        }

        /// <summary>
        /// Creates annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Annotation CreateAnnotation(CreateAnnotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> CreateAnnotationAsync(CreateAnnotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> CreateAnnotationAsync(CreateAnnotationRequest request, st::CancellationToken cancellationToken) =>
            CreateAnnotationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates annotation inside asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this annotation will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/assets/{asset_id}`
        /// </param>
        /// <param name="annotation">
        /// Required. The annotation to create.
        /// </param>
        /// <param name="annotationId">
        /// Optional. The ID to use for the annotation, which will become the final
        /// component of the annotation's resource name if user choose to specify.
        /// Otherwise, annotation id will be generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Annotation CreateAnnotation(string parent, Annotation annotation, string annotationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnnotation(new CreateAnnotationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
                AnnotationId = annotationId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates annotation inside asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this annotation will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/assets/{asset_id}`
        /// </param>
        /// <param name="annotation">
        /// Required. The annotation to create.
        /// </param>
        /// <param name="annotationId">
        /// Optional. The ID to use for the annotation, which will become the final
        /// component of the annotation's resource name if user choose to specify.
        /// Otherwise, annotation id will be generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> CreateAnnotationAsync(string parent, Annotation annotation, string annotationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnnotationAsync(new CreateAnnotationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
                AnnotationId = annotationId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates annotation inside asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this annotation will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/assets/{asset_id}`
        /// </param>
        /// <param name="annotation">
        /// Required. The annotation to create.
        /// </param>
        /// <param name="annotationId">
        /// Optional. The ID to use for the annotation, which will become the final
        /// component of the annotation's resource name if user choose to specify.
        /// Otherwise, annotation id will be generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> CreateAnnotationAsync(string parent, Annotation annotation, string annotationId, st::CancellationToken cancellationToken) =>
            CreateAnnotationAsync(parent, annotation, annotationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates annotation inside asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this annotation will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/assets/{asset_id}`
        /// </param>
        /// <param name="annotation">
        /// Required. The annotation to create.
        /// </param>
        /// <param name="annotationId">
        /// Optional. The ID to use for the annotation, which will become the final
        /// component of the annotation's resource name if user choose to specify.
        /// Otherwise, annotation id will be generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Annotation CreateAnnotation(AssetName parent, Annotation annotation, string annotationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnnotation(new CreateAnnotationRequest
            {
                ParentAsAssetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
                AnnotationId = annotationId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates annotation inside asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this annotation will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/assets/{asset_id}`
        /// </param>
        /// <param name="annotation">
        /// Required. The annotation to create.
        /// </param>
        /// <param name="annotationId">
        /// Optional. The ID to use for the annotation, which will become the final
        /// component of the annotation's resource name if user choose to specify.
        /// Otherwise, annotation id will be generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> CreateAnnotationAsync(AssetName parent, Annotation annotation, string annotationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnnotationAsync(new CreateAnnotationRequest
            {
                ParentAsAssetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
                AnnotationId = annotationId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates annotation inside asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this annotation will be created.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}/assets/{asset_id}`
        /// </param>
        /// <param name="annotation">
        /// Required. The annotation to create.
        /// </param>
        /// <param name="annotationId">
        /// Optional. The ID to use for the annotation, which will become the final
        /// component of the annotation's resource name if user choose to specify.
        /// Otherwise, annotation id will be generated by system.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> CreateAnnotationAsync(AssetName parent, Annotation annotation, string annotationId, st::CancellationToken cancellationToken) =>
            CreateAnnotationAsync(parent, annotation, annotationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Annotation GetAnnotation(GetAnnotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> GetAnnotationAsync(GetAnnotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> GetAnnotationAsync(GetAnnotationRequest request, st::CancellationToken cancellationToken) =>
            GetAnnotationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads annotation inside asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the annotation to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Annotation GetAnnotation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotation(new GetAnnotationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reads annotation inside asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the annotation to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> GetAnnotationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationAsync(new GetAnnotationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reads annotation inside asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the annotation to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> GetAnnotationAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnnotationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads annotation inside asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the annotation to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Annotation GetAnnotation(AnnotationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotation(new GetAnnotationRequest
            {
                AnnotationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reads annotation inside asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the annotation to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> GetAnnotationAsync(AnnotationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationAsync(new GetAnnotationRequest
            {
                AnnotationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reads annotation inside asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the annotation to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> GetAnnotationAsync(AnnotationName name, st::CancellationToken cancellationToken) =>
            GetAnnotationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists a list of annotations inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Annotation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnnotationsResponse, Annotation> ListAnnotations(ListAnnotationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a list of annotations inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Annotation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> ListAnnotationsAsync(ListAnnotationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a list of annotations inside asset.
        /// </summary>
        /// <param name="parent">
        /// The parent, which owns this collection of annotations.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}`
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
        /// <returns>A pageable sequence of <see cref="Annotation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnnotationsResponse, Annotation> ListAnnotations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnnotationsRequest request = new ListAnnotationsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnnotations(request, callSettings);
        }

        /// <summary>
        /// Lists a list of annotations inside asset.
        /// </summary>
        /// <param name="parent">
        /// The parent, which owns this collection of annotations.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Annotation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> ListAnnotationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnnotationsRequest request = new ListAnnotationsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnnotationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists a list of annotations inside asset.
        /// </summary>
        /// <param name="parent">
        /// The parent, which owns this collection of annotations.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}`
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
        /// <returns>A pageable sequence of <see cref="Annotation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnnotationsResponse, Annotation> ListAnnotations(AssetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnnotationsRequest request = new ListAnnotationsRequest
            {
                ParentAsAssetName = parent,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnnotations(request, callSettings);
        }

        /// <summary>
        /// Lists a list of annotations inside asset.
        /// </summary>
        /// <param name="parent">
        /// The parent, which owns this collection of annotations.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Annotation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> ListAnnotationsAsync(AssetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnnotationsRequest request = new ListAnnotationsRequest
            {
                ParentAsAssetName = parent,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnnotationsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Annotation UpdateAnnotation(UpdateAnnotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> UpdateAnnotationAsync(UpdateAnnotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> UpdateAnnotationAsync(UpdateAnnotationRequest request, st::CancellationToken cancellationToken) =>
            UpdateAnnotationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates annotation inside asset.
        /// </summary>
        /// <param name="annotation">
        /// Required. The annotation to update.
        /// The annotation's `name` field is used to identify the annotation to be
        /// updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Annotation UpdateAnnotation(Annotation annotation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAnnotation(new UpdateAnnotationRequest
            {
                Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates annotation inside asset.
        /// </summary>
        /// <param name="annotation">
        /// Required. The annotation to update.
        /// The annotation's `name` field is used to identify the annotation to be
        /// updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> UpdateAnnotationAsync(Annotation annotation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAnnotationAsync(new UpdateAnnotationRequest
            {
                Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates annotation inside asset.
        /// </summary>
        /// <param name="annotation">
        /// Required. The annotation to update.
        /// The annotation's `name` field is used to identify the annotation to be
        /// updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> UpdateAnnotationAsync(Annotation annotation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAnnotationAsync(annotation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnnotation(DeleteAnnotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotationAsync(DeleteAnnotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotationAsync(DeleteAnnotationRequest request, st::CancellationToken cancellationToken) =>
            DeleteAnnotationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes annotation inside asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the annotation to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnnotation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnnotation(new DeleteAnnotationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes annotation inside asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the annotation to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnnotationAsync(new DeleteAnnotationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes annotation inside asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the annotation to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAnnotationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes annotation inside asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the annotation to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnnotation(AnnotationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnnotation(new DeleteAnnotationRequest
            {
                AnnotationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes annotation inside asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the annotation to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotationAsync(AnnotationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnnotationAsync(new DeleteAnnotationRequest
            {
                AnnotationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes annotation inside asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the annotation to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/assets/{asset}/annotations/{annotation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotationAsync(AnnotationName name, st::CancellationToken cancellationToken) =>
            DeleteAnnotationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="IngestAsset(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class IngestAssetStream : gaxgrpc::BidirectionalStreamingBase<IngestAssetRequest, IngestAssetResponse>
        {
        }

        /// <summary>
        /// Ingests data for the asset. It is not allowed to ingest a data chunk which
        /// is already expired according to TTL.
        /// This method is only available via the gRPC API (not HTTP since
        /// bi-directional streaming is not supported via HTTP).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual IngestAssetStream IngestAsset(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Supported by STREAM_VIDEO corpus type.
        /// Generates clips for downloading. The api takes in a time range, and
        /// generates a clip of the first content available after start_time and
        /// before end_time, which may overflow beyond these bounds.
        /// Returned clips are truncated if the total size of the clips are larger
        /// than 100MB.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClipAssetResponse ClipAsset(ClipAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Supported by STREAM_VIDEO corpus type.
        /// Generates clips for downloading. The api takes in a time range, and
        /// generates a clip of the first content available after start_time and
        /// before end_time, which may overflow beyond these bounds.
        /// Returned clips are truncated if the total size of the clips are larger
        /// than 100MB.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClipAssetResponse> ClipAssetAsync(ClipAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Supported by STREAM_VIDEO corpus type.
        /// Generates clips for downloading. The api takes in a time range, and
        /// generates a clip of the first content available after start_time and
        /// before end_time, which may overflow beyond these bounds.
        /// Returned clips are truncated if the total size of the clips are larger
        /// than 100MB.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClipAssetResponse> ClipAssetAsync(ClipAssetRequest request, st::CancellationToken cancellationToken) =>
            ClipAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a uri for an HLS manifest. The api takes in a collection of time
        /// ranges, and generates a URI for an HLS manifest that covers all the
        /// requested time ranges.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateHlsUriResponse GenerateHlsUri(GenerateHlsUriRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a uri for an HLS manifest. The api takes in a collection of time
        /// ranges, and generates a URI for an HLS manifest that covers all the
        /// requested time ranges.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateHlsUriResponse> GenerateHlsUriAsync(GenerateHlsUriRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a uri for an HLS manifest. The api takes in a collection of time
        /// ranges, and generates a URI for an HLS manifest that covers all the
        /// requested time ranges.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateHlsUriResponse> GenerateHlsUriAsync(GenerateHlsUriRequest request, st::CancellationToken cancellationToken) =>
            GenerateHlsUriAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports assets (images plus annotations) from a meta file on cloud storage.
        /// Each row in the meta file is corresponding to an image (specified by a
        /// cloud storage uri) and its annotations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportAssetsResponse, ImportAssetsMetadata> ImportAssets(ImportAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports assets (images plus annotations) from a meta file on cloud storage.
        /// Each row in the meta file is corresponding to an image (specified by a
        /// cloud storage uri) and its annotations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportAssetsResponse, ImportAssetsMetadata>> ImportAssetsAsync(ImportAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports assets (images plus annotations) from a meta file on cloud storage.
        /// Each row in the meta file is corresponding to an image (specified by a
        /// cloud storage uri) and its annotations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportAssetsResponse, ImportAssetsMetadata>> ImportAssetsAsync(ImportAssetsRequest request, st::CancellationToken cancellationToken) =>
            ImportAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportAssets</c>.</summary>
        public virtual lro::OperationsClient ImportAssetsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportAssets</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportAssetsResponse, ImportAssetsMetadata> PollOnceImportAssets(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportAssetsResponse, ImportAssetsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportAssetsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportAssets</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportAssetsResponse, ImportAssetsMetadata>> PollOnceImportAssetsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportAssetsResponse, ImportAssetsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportAssetsOperationsClient, callSettings);

        /// <summary>
        /// Creates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid CreateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_config_id must not be associated with an existing
        /// SearchConfig.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchConfig CreateSearchConfig(CreateSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid CreateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_config_id must not be associated with an existing
        /// SearchConfig.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> CreateSearchConfigAsync(CreateSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid CreateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_config_id must not be associated with an existing
        /// SearchConfig.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> CreateSearchConfigAsync(CreateSearchConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateSearchConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid CreateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_config_id must not be associated with an existing
        /// SearchConfig.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search configuration will be
        /// created. Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="searchConfig">
        /// Required. The search config to create.
        /// </param>
        /// <param name="searchConfigId">
        /// Required. ID to use for the new search config. Will become the final
        /// component of the SearchConfig's resource name. This value should be up to
        /// 63 characters, and valid characters are /[a-z][0-9]-_/. The first character
        /// must be a letter, the last could be a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchConfig CreateSearchConfig(string parent, SearchConfig searchConfig, string searchConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSearchConfig(new CreateSearchConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SearchConfig = gax::GaxPreconditions.CheckNotNull(searchConfig, nameof(searchConfig)),
                SearchConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(searchConfigId, nameof(searchConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid CreateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_config_id must not be associated with an existing
        /// SearchConfig.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search configuration will be
        /// created. Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="searchConfig">
        /// Required. The search config to create.
        /// </param>
        /// <param name="searchConfigId">
        /// Required. ID to use for the new search config. Will become the final
        /// component of the SearchConfig's resource name. This value should be up to
        /// 63 characters, and valid characters are /[a-z][0-9]-_/. The first character
        /// must be a letter, the last could be a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> CreateSearchConfigAsync(string parent, SearchConfig searchConfig, string searchConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSearchConfigAsync(new CreateSearchConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SearchConfig = gax::GaxPreconditions.CheckNotNull(searchConfig, nameof(searchConfig)),
                SearchConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(searchConfigId, nameof(searchConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid CreateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_config_id must not be associated with an existing
        /// SearchConfig.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search configuration will be
        /// created. Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="searchConfig">
        /// Required. The search config to create.
        /// </param>
        /// <param name="searchConfigId">
        /// Required. ID to use for the new search config. Will become the final
        /// component of the SearchConfig's resource name. This value should be up to
        /// 63 characters, and valid characters are /[a-z][0-9]-_/. The first character
        /// must be a letter, the last could be a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> CreateSearchConfigAsync(string parent, SearchConfig searchConfig, string searchConfigId, st::CancellationToken cancellationToken) =>
            CreateSearchConfigAsync(parent, searchConfig, searchConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid CreateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_config_id must not be associated with an existing
        /// SearchConfig.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search configuration will be
        /// created. Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="searchConfig">
        /// Required. The search config to create.
        /// </param>
        /// <param name="searchConfigId">
        /// Required. ID to use for the new search config. Will become the final
        /// component of the SearchConfig's resource name. This value should be up to
        /// 63 characters, and valid characters are /[a-z][0-9]-_/. The first character
        /// must be a letter, the last could be a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchConfig CreateSearchConfig(CorpusName parent, SearchConfig searchConfig, string searchConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSearchConfig(new CreateSearchConfigRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SearchConfig = gax::GaxPreconditions.CheckNotNull(searchConfig, nameof(searchConfig)),
                SearchConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(searchConfigId, nameof(searchConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid CreateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_config_id must not be associated with an existing
        /// SearchConfig.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search configuration will be
        /// created. Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="searchConfig">
        /// Required. The search config to create.
        /// </param>
        /// <param name="searchConfigId">
        /// Required. ID to use for the new search config. Will become the final
        /// component of the SearchConfig's resource name. This value should be up to
        /// 63 characters, and valid characters are /[a-z][0-9]-_/. The first character
        /// must be a letter, the last could be a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> CreateSearchConfigAsync(CorpusName parent, SearchConfig searchConfig, string searchConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSearchConfigAsync(new CreateSearchConfigRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SearchConfig = gax::GaxPreconditions.CheckNotNull(searchConfig, nameof(searchConfig)),
                SearchConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(searchConfigId, nameof(searchConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid CreateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_config_id must not be associated with an existing
        /// SearchConfig.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search configuration will be
        /// created. Format:
        /// `projects/{project_number}/locations/{location_id}/corpora/{corpus_id}`
        /// </param>
        /// <param name="searchConfig">
        /// Required. The search config to create.
        /// </param>
        /// <param name="searchConfigId">
        /// Required. ID to use for the new search config. Will become the final
        /// component of the SearchConfig's resource name. This value should be up to
        /// 63 characters, and valid characters are /[a-z][0-9]-_/. The first character
        /// must be a letter, the last could be a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> CreateSearchConfigAsync(CorpusName parent, SearchConfig searchConfig, string searchConfigId, st::CancellationToken cancellationToken) =>
            CreateSearchConfigAsync(parent, searchConfig, searchConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid UpdateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_configuration.name must already exist.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchConfig UpdateSearchConfig(UpdateSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid UpdateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_configuration.name must already exist.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> UpdateSearchConfigAsync(UpdateSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid UpdateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_configuration.name must already exist.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> UpdateSearchConfigAsync(UpdateSearchConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateSearchConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid UpdateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_configuration.name must already exist.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="searchConfig">
        /// Required. The search configuration to update.
        /// 
        /// The search configuration's `name` field is used to identify the resource to
        /// be updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If left unset, all field paths will be
        /// updated/overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchConfig UpdateSearchConfig(SearchConfig searchConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSearchConfig(new UpdateSearchConfigRequest
            {
                SearchConfig = gax::GaxPreconditions.CheckNotNull(searchConfig, nameof(searchConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid UpdateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_configuration.name must already exist.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="searchConfig">
        /// Required. The search configuration to update.
        /// 
        /// The search configuration's `name` field is used to identify the resource to
        /// be updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If left unset, all field paths will be
        /// updated/overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> UpdateSearchConfigAsync(SearchConfig searchConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSearchConfigAsync(new UpdateSearchConfigRequest
            {
                SearchConfig = gax::GaxPreconditions.CheckNotNull(searchConfig, nameof(searchConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid UpdateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_configuration.name must already exist.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="searchConfig">
        /// Required. The search configuration to update.
        /// 
        /// The search configuration's `name` field is used to identify the resource to
        /// be updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If left unset, all field paths will be
        /// updated/overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> UpdateSearchConfigAsync(SearchConfig searchConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSearchConfigAsync(searchConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a search configuration inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchConfig GetSearchConfig(GetSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a search configuration inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> GetSearchConfigAsync(GetSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a search configuration inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> GetSearchConfigAsync(GetSearchConfigRequest request, st::CancellationToken cancellationToken) =>
            GetSearchConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a search configuration inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the search configuration to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchConfig GetSearchConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSearchConfig(new GetSearchConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a search configuration inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the search configuration to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> GetSearchConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSearchConfigAsync(new GetSearchConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a search configuration inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the search configuration to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> GetSearchConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetSearchConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a search configuration inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the search configuration to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchConfig GetSearchConfig(SearchConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSearchConfig(new GetSearchConfigRequest
            {
                SearchConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a search configuration inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the search configuration to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> GetSearchConfigAsync(SearchConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSearchConfigAsync(new GetSearchConfigRequest
            {
                SearchConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a search configuration inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the search configuration to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchConfig> GetSearchConfigAsync(SearchConfigName name, st::CancellationToken cancellationToken) =>
            GetSearchConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a search configuration inside a corpus.
        /// 
        /// For a DeleteSearchConfigRequest to be valid,
        /// Request.search_configuration.name must already exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSearchConfig(DeleteSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a search configuration inside a corpus.
        /// 
        /// For a DeleteSearchConfigRequest to be valid,
        /// Request.search_configuration.name must already exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSearchConfigAsync(DeleteSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a search configuration inside a corpus.
        /// 
        /// For a DeleteSearchConfigRequest to be valid,
        /// Request.search_configuration.name must already exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSearchConfigAsync(DeleteSearchConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteSearchConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a search configuration inside a corpus.
        /// 
        /// For a DeleteSearchConfigRequest to be valid,
        /// Request.search_configuration.name must already exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the search configuration to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSearchConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSearchConfig(new DeleteSearchConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a search configuration inside a corpus.
        /// 
        /// For a DeleteSearchConfigRequest to be valid,
        /// Request.search_configuration.name must already exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the search configuration to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSearchConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSearchConfigAsync(new DeleteSearchConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a search configuration inside a corpus.
        /// 
        /// For a DeleteSearchConfigRequest to be valid,
        /// Request.search_configuration.name must already exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the search configuration to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSearchConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSearchConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a search configuration inside a corpus.
        /// 
        /// For a DeleteSearchConfigRequest to be valid,
        /// Request.search_configuration.name must already exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the search configuration to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSearchConfig(SearchConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSearchConfig(new DeleteSearchConfigRequest
            {
                SearchConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a search configuration inside a corpus.
        /// 
        /// For a DeleteSearchConfigRequest to be valid,
        /// Request.search_configuration.name must already exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the search configuration to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSearchConfigAsync(SearchConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSearchConfigAsync(new DeleteSearchConfigRequest
            {
                SearchConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a search configuration inside a corpus.
        /// 
        /// For a DeleteSearchConfigRequest to be valid,
        /// Request.search_configuration.name must already exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the search configuration to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchConfigs/{search_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSearchConfigAsync(SearchConfigName name, st::CancellationToken cancellationToken) =>
            DeleteSearchConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all search configurations inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSearchConfigsResponse, SearchConfig> ListSearchConfigs(ListSearchConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all search configurations inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSearchConfigsResponse, SearchConfig> ListSearchConfigsAsync(ListSearchConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all search configurations inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of search configurations.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable sequence of <see cref="SearchConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSearchConfigsResponse, SearchConfig> ListSearchConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSearchConfigsRequest request = new ListSearchConfigsRequest
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
            return ListSearchConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists all search configurations inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of search configurations.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SearchConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSearchConfigsResponse, SearchConfig> ListSearchConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSearchConfigsRequest request = new ListSearchConfigsRequest
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
            return ListSearchConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all search configurations inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of search configurations.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable sequence of <see cref="SearchConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSearchConfigsResponse, SearchConfig> ListSearchConfigs(CorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSearchConfigsRequest request = new ListSearchConfigsRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSearchConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists all search configurations inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of search configurations.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SearchConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSearchConfigsResponse, SearchConfig> ListSearchConfigsAsync(CorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSearchConfigsRequest request = new ListSearchConfigsRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSearchConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchHypernym CreateSearchHypernym(CreateSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> CreateSearchHypernymAsync(CreateSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> CreateSearchHypernymAsync(CreateSearchHypernymRequest request, st::CancellationToken cancellationToken) =>
            CreateSearchHypernymAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this SearchHypernym will be created.
        /// Format: `projects/{project_number}/locations/{location}/corpora/{corpus}`
        /// </param>
        /// <param name="searchHypernym">
        /// Required. The SearchHypernym to create.
        /// </param>
        /// <param name="searchHypernymId">
        /// Optional. The search hypernym id.
        /// If omitted, a random UUID will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchHypernym CreateSearchHypernym(string parent, SearchHypernym searchHypernym, string searchHypernymId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSearchHypernym(new CreateSearchHypernymRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SearchHypernym = gax::GaxPreconditions.CheckNotNull(searchHypernym, nameof(searchHypernym)),
                SearchHypernymId = searchHypernymId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this SearchHypernym will be created.
        /// Format: `projects/{project_number}/locations/{location}/corpora/{corpus}`
        /// </param>
        /// <param name="searchHypernym">
        /// Required. The SearchHypernym to create.
        /// </param>
        /// <param name="searchHypernymId">
        /// Optional. The search hypernym id.
        /// If omitted, a random UUID will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> CreateSearchHypernymAsync(string parent, SearchHypernym searchHypernym, string searchHypernymId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSearchHypernymAsync(new CreateSearchHypernymRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SearchHypernym = gax::GaxPreconditions.CheckNotNull(searchHypernym, nameof(searchHypernym)),
                SearchHypernymId = searchHypernymId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this SearchHypernym will be created.
        /// Format: `projects/{project_number}/locations/{location}/corpora/{corpus}`
        /// </param>
        /// <param name="searchHypernym">
        /// Required. The SearchHypernym to create.
        /// </param>
        /// <param name="searchHypernymId">
        /// Optional. The search hypernym id.
        /// If omitted, a random UUID will be generated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> CreateSearchHypernymAsync(string parent, SearchHypernym searchHypernym, string searchHypernymId, st::CancellationToken cancellationToken) =>
            CreateSearchHypernymAsync(parent, searchHypernym, searchHypernymId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this SearchHypernym will be created.
        /// Format: `projects/{project_number}/locations/{location}/corpora/{corpus}`
        /// </param>
        /// <param name="searchHypernym">
        /// Required. The SearchHypernym to create.
        /// </param>
        /// <param name="searchHypernymId">
        /// Optional. The search hypernym id.
        /// If omitted, a random UUID will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchHypernym CreateSearchHypernym(CorpusName parent, SearchHypernym searchHypernym, string searchHypernymId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSearchHypernym(new CreateSearchHypernymRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SearchHypernym = gax::GaxPreconditions.CheckNotNull(searchHypernym, nameof(searchHypernym)),
                SearchHypernymId = searchHypernymId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this SearchHypernym will be created.
        /// Format: `projects/{project_number}/locations/{location}/corpora/{corpus}`
        /// </param>
        /// <param name="searchHypernym">
        /// Required. The SearchHypernym to create.
        /// </param>
        /// <param name="searchHypernymId">
        /// Optional. The search hypernym id.
        /// If omitted, a random UUID will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> CreateSearchHypernymAsync(CorpusName parent, SearchHypernym searchHypernym, string searchHypernymId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSearchHypernymAsync(new CreateSearchHypernymRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SearchHypernym = gax::GaxPreconditions.CheckNotNull(searchHypernym, nameof(searchHypernym)),
                SearchHypernymId = searchHypernymId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this SearchHypernym will be created.
        /// Format: `projects/{project_number}/locations/{location}/corpora/{corpus}`
        /// </param>
        /// <param name="searchHypernym">
        /// Required. The SearchHypernym to create.
        /// </param>
        /// <param name="searchHypernymId">
        /// Optional. The search hypernym id.
        /// If omitted, a random UUID will be generated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> CreateSearchHypernymAsync(CorpusName parent, SearchHypernym searchHypernym, string searchHypernymId, st::CancellationToken cancellationToken) =>
            CreateSearchHypernymAsync(parent, searchHypernym, searchHypernymId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchHypernym UpdateSearchHypernym(UpdateSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> UpdateSearchHypernymAsync(UpdateSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> UpdateSearchHypernymAsync(UpdateSearchHypernymRequest request, st::CancellationToken cancellationToken) =>
            UpdateSearchHypernymAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="searchHypernym">
        /// Required. The SearchHypernym to update.
        /// The search hypernym's `name` field is used to identify the search hypernym
        /// to be updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If left unset, all field paths will be
        /// updated/overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchHypernym UpdateSearchHypernym(SearchHypernym searchHypernym, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSearchHypernym(new UpdateSearchHypernymRequest
            {
                SearchHypernym = gax::GaxPreconditions.CheckNotNull(searchHypernym, nameof(searchHypernym)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="searchHypernym">
        /// Required. The SearchHypernym to update.
        /// The search hypernym's `name` field is used to identify the search hypernym
        /// to be updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If left unset, all field paths will be
        /// updated/overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> UpdateSearchHypernymAsync(SearchHypernym searchHypernym, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSearchHypernymAsync(new UpdateSearchHypernymRequest
            {
                SearchHypernym = gax::GaxPreconditions.CheckNotNull(searchHypernym, nameof(searchHypernym)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="searchHypernym">
        /// Required. The SearchHypernym to update.
        /// The search hypernym's `name` field is used to identify the search hypernym
        /// to be updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If left unset, all field paths will be
        /// updated/overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> UpdateSearchHypernymAsync(SearchHypernym searchHypernym, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSearchHypernymAsync(searchHypernym, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchHypernym GetSearchHypernym(GetSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> GetSearchHypernymAsync(GetSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> GetSearchHypernymAsync(GetSearchHypernymRequest request, st::CancellationToken cancellationToken) =>
            GetSearchHypernymAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SearchHypernym to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchHypernym GetSearchHypernym(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSearchHypernym(new GetSearchHypernymRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SearchHypernym to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> GetSearchHypernymAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSearchHypernymAsync(new GetSearchHypernymRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SearchHypernym to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> GetSearchHypernymAsync(string name, st::CancellationToken cancellationToken) =>
            GetSearchHypernymAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SearchHypernym to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchHypernym GetSearchHypernym(SearchHypernymName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSearchHypernym(new GetSearchHypernymRequest
            {
                SearchHypernymName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SearchHypernym to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> GetSearchHypernymAsync(SearchHypernymName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSearchHypernymAsync(new GetSearchHypernymRequest
            {
                SearchHypernymName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SearchHypernym to retrieve.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHypernym> GetSearchHypernymAsync(SearchHypernymName name, st::CancellationToken cancellationToken) =>
            GetSearchHypernymAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSearchHypernym(DeleteSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSearchHypernymAsync(DeleteSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSearchHypernymAsync(DeleteSearchHypernymRequest request, st::CancellationToken cancellationToken) =>
            DeleteSearchHypernymAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SearchHypernym to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSearchHypernym(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSearchHypernym(new DeleteSearchHypernymRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SearchHypernym to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSearchHypernymAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSearchHypernymAsync(new DeleteSearchHypernymRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SearchHypernym to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSearchHypernymAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSearchHypernymAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SearchHypernym to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSearchHypernym(SearchHypernymName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSearchHypernym(new DeleteSearchHypernymRequest
            {
                SearchHypernymName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SearchHypernym to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSearchHypernymAsync(SearchHypernymName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSearchHypernymAsync(new DeleteSearchHypernymRequest
            {
                SearchHypernymName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SearchHypernym to delete.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/searchHypernyms/{search_hypernym}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSearchHypernymAsync(SearchHypernymName name, st::CancellationToken cancellationToken) =>
            DeleteSearchHypernymAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists SearchHypernyms inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchHypernym"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSearchHypernymsResponse, SearchHypernym> ListSearchHypernyms(ListSearchHypernymsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SearchHypernyms inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchHypernym"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSearchHypernymsResponse, SearchHypernym> ListSearchHypernymsAsync(ListSearchHypernymsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SearchHypernyms inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of SearchHypernyms.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable sequence of <see cref="SearchHypernym"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSearchHypernymsResponse, SearchHypernym> ListSearchHypernyms(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSearchHypernymsRequest request = new ListSearchHypernymsRequest
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
            return ListSearchHypernyms(request, callSettings);
        }

        /// <summary>
        /// Lists SearchHypernyms inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of SearchHypernyms.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SearchHypernym"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSearchHypernymsResponse, SearchHypernym> ListSearchHypernymsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSearchHypernymsRequest request = new ListSearchHypernymsRequest
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
            return ListSearchHypernymsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists SearchHypernyms inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of SearchHypernyms.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable sequence of <see cref="SearchHypernym"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSearchHypernymsResponse, SearchHypernym> ListSearchHypernyms(CorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSearchHypernymsRequest request = new ListSearchHypernymsRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSearchHypernyms(request, callSettings);
        }

        /// <summary>
        /// Lists SearchHypernyms inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of SearchHypernyms.
        /// Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SearchHypernym"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSearchHypernymsResponse, SearchHypernym> ListSearchHypernymsAsync(CorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSearchHypernymsRequest request = new ListSearchHypernymsRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSearchHypernymsAsync(request, callSettings);
        }

        /// <summary>
        /// Search media asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchResultItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAssetsResponse, SearchResultItem> SearchAssets(SearchAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search media asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchResultItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAssetsResponse, SearchResultItem> SearchAssetsAsync(SearchAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search a deployed index endpoint (IMAGE corpus type only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchResultItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchIndexEndpointResponse, SearchResultItem> SearchIndexEndpoint(SearchIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search a deployed index endpoint (IMAGE corpus type only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchResultItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchIndexEndpointResponse, SearchResultItem> SearchIndexEndpointAsync(SearchIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata> CreateIndexEndpoint(CreateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata>> CreateIndexEndpointAsync(CreateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata>> CreateIndexEndpointAsync(CreateIndexEndpointRequest request, st::CancellationToken cancellationToken) =>
            CreateIndexEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateIndexEndpoint</c>.</summary>
        public virtual lro::OperationsClient CreateIndexEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateIndexEndpoint</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata> PollOnceCreateIndexEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateIndexEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata>> PollOnceCreateIndexEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexEndpointOperationsClient, callSettings);

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="indexEndpoint">
        /// Required. The resource being created.
        /// </param>
        /// <param name="indexEndpointId">
        /// Optional. The ID to use for the IndexEndpoint, which will become the final
        /// component of the IndexEndpoint's resource name if the user specifies it.
        /// Otherwise, IndexEndpoint id will be autogenerated.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are a-z, 0-9 and dash (-). The first character must be a letter, the last
        /// must be a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata> CreateIndexEndpoint(string parent, IndexEndpoint indexEndpoint, string indexEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexEndpoint(new CreateIndexEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IndexEndpointId = indexEndpointId ?? "",
                IndexEndpoint = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="indexEndpoint">
        /// Required. The resource being created.
        /// </param>
        /// <param name="indexEndpointId">
        /// Optional. The ID to use for the IndexEndpoint, which will become the final
        /// component of the IndexEndpoint's resource name if the user specifies it.
        /// Otherwise, IndexEndpoint id will be autogenerated.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are a-z, 0-9 and dash (-). The first character must be a letter, the last
        /// must be a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata>> CreateIndexEndpointAsync(string parent, IndexEndpoint indexEndpoint, string indexEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexEndpointAsync(new CreateIndexEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IndexEndpointId = indexEndpointId ?? "",
                IndexEndpoint = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="indexEndpoint">
        /// Required. The resource being created.
        /// </param>
        /// <param name="indexEndpointId">
        /// Optional. The ID to use for the IndexEndpoint, which will become the final
        /// component of the IndexEndpoint's resource name if the user specifies it.
        /// Otherwise, IndexEndpoint id will be autogenerated.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are a-z, 0-9 and dash (-). The first character must be a letter, the last
        /// must be a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata>> CreateIndexEndpointAsync(string parent, IndexEndpoint indexEndpoint, string indexEndpointId, st::CancellationToken cancellationToken) =>
            CreateIndexEndpointAsync(parent, indexEndpoint, indexEndpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="indexEndpoint">
        /// Required. The resource being created.
        /// </param>
        /// <param name="indexEndpointId">
        /// Optional. The ID to use for the IndexEndpoint, which will become the final
        /// component of the IndexEndpoint's resource name if the user specifies it.
        /// Otherwise, IndexEndpoint id will be autogenerated.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are a-z, 0-9 and dash (-). The first character must be a letter, the last
        /// must be a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata> CreateIndexEndpoint(gagr::LocationName parent, IndexEndpoint indexEndpoint, string indexEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexEndpoint(new CreateIndexEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IndexEndpointId = indexEndpointId ?? "",
                IndexEndpoint = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="indexEndpoint">
        /// Required. The resource being created.
        /// </param>
        /// <param name="indexEndpointId">
        /// Optional. The ID to use for the IndexEndpoint, which will become the final
        /// component of the IndexEndpoint's resource name if the user specifies it.
        /// Otherwise, IndexEndpoint id will be autogenerated.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are a-z, 0-9 and dash (-). The first character must be a letter, the last
        /// must be a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata>> CreateIndexEndpointAsync(gagr::LocationName parent, IndexEndpoint indexEndpoint, string indexEndpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexEndpointAsync(new CreateIndexEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IndexEndpointId = indexEndpointId ?? "",
                IndexEndpoint = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="indexEndpoint">
        /// Required. The resource being created.
        /// </param>
        /// <param name="indexEndpointId">
        /// Optional. The ID to use for the IndexEndpoint, which will become the final
        /// component of the IndexEndpoint's resource name if the user specifies it.
        /// Otherwise, IndexEndpoint id will be autogenerated.
        /// 
        /// This value should be up to 63 characters, and valid characters
        /// are a-z, 0-9 and dash (-). The first character must be a letter, the last
        /// must be a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata>> CreateIndexEndpointAsync(gagr::LocationName parent, IndexEndpoint indexEndpoint, string indexEndpointId, st::CancellationToken cancellationToken) =>
            CreateIndexEndpointAsync(parent, indexEndpoint, indexEndpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IndexEndpoint GetIndexEndpoint(GetIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> GetIndexEndpointAsync(GetIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> GetIndexEndpointAsync(GetIndexEndpointRequest request, st::CancellationToken cancellationToken) =>
            GetIndexEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the IndexEndpoint resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IndexEndpoint GetIndexEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexEndpoint(new GetIndexEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the IndexEndpoint resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> GetIndexEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexEndpointAsync(new GetIndexEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the IndexEndpoint resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> GetIndexEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            GetIndexEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the IndexEndpoint resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IndexEndpoint GetIndexEndpoint(IndexEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexEndpoint(new GetIndexEndpointRequest
            {
                IndexEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the IndexEndpoint resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> GetIndexEndpointAsync(IndexEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexEndpointAsync(new GetIndexEndpointRequest
            {
                IndexEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the IndexEndpoint resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> GetIndexEndpointAsync(IndexEndpointName name, st::CancellationToken cancellationToken) =>
            GetIndexEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all IndexEndpoints in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpoints(ListIndexEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all IndexEndpoints in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpointsAsync(ListIndexEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all IndexEndpoints in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpoints(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexEndpointsRequest request = new ListIndexEndpointsRequest
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
            return ListIndexEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists all IndexEndpoints in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpointsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexEndpointsRequest request = new ListIndexEndpointsRequest
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
            return ListIndexEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all IndexEndpoints in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpoints(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexEndpointsRequest request = new ListIndexEndpointsRequest
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
            return ListIndexEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists all IndexEndpoints in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpointsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexEndpointsRequest request = new ListIndexEndpointsRequest
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
            return ListIndexEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata> UpdateIndexEndpoint(UpdateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata>> UpdateIndexEndpointAsync(UpdateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata>> UpdateIndexEndpointAsync(UpdateIndexEndpointRequest request, st::CancellationToken cancellationToken) =>
            UpdateIndexEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateIndexEndpoint</c>.</summary>
        public virtual lro::OperationsClient UpdateIndexEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateIndexEndpoint</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata> PollOnceUpdateIndexEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateIndexEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateIndexEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata>> PollOnceUpdateIndexEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateIndexEndpointOperationsClient, callSettings);

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// IndexEndpoint resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request.
        /// A field of the resource will be overwritten if it is in the mask.
        /// Empty field mask is not allowed.
        /// If the mask is "*", then this is a full replacement of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata> UpdateIndexEndpoint(IndexEndpoint indexEndpoint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIndexEndpoint(new UpdateIndexEndpointRequest
            {
                IndexEndpoint = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// IndexEndpoint resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request.
        /// A field of the resource will be overwritten if it is in the mask.
        /// Empty field mask is not allowed.
        /// If the mask is "*", then this is a full replacement of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata>> UpdateIndexEndpointAsync(IndexEndpoint indexEndpoint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIndexEndpointAsync(new UpdateIndexEndpointRequest
            {
                IndexEndpoint = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// IndexEndpoint resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request.
        /// A field of the resource will be overwritten if it is in the mask.
        /// Empty field mask is not allowed.
        /// If the mask is "*", then this is a full replacement of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata>> UpdateIndexEndpointAsync(IndexEndpoint indexEndpoint, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateIndexEndpointAsync(indexEndpoint, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata> DeleteIndexEndpoint(DeleteIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata>> DeleteIndexEndpointAsync(DeleteIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata>> DeleteIndexEndpointAsync(DeleteIndexEndpointRequest request, st::CancellationToken cancellationToken) =>
            DeleteIndexEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteIndexEndpoint</c>.</summary>
        public virtual lro::OperationsClient DeleteIndexEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteIndexEndpoint</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata> PollOnceDeleteIndexEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIndexEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteIndexEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata>> PollOnceDeleteIndexEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIndexEndpointOperationsClient, callSettings);

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata> DeleteIndexEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexEndpoint(new DeleteIndexEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata>> DeleteIndexEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexEndpointAsync(new DeleteIndexEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata>> DeleteIndexEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteIndexEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata> DeleteIndexEndpoint(IndexEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexEndpoint(new DeleteIndexEndpointRequest
            {
                IndexEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata>> DeleteIndexEndpointAsync(IndexEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexEndpointAsync(new DeleteIndexEndpointRequest
            {
                IndexEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata>> DeleteIndexEndpointAsync(IndexEndpointName name, st::CancellationToken cancellationToken) =>
            DeleteIndexEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys an Index to IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployIndexResponse, DeployIndexMetadata> DeployIndex(DeployIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys an Index to IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIndexResponse, DeployIndexMetadata>> DeployIndexAsync(DeployIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys an Index to IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIndexResponse, DeployIndexMetadata>> DeployIndexAsync(DeployIndexRequest request, st::CancellationToken cancellationToken) =>
            DeployIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeployIndex</c>.</summary>
        public virtual lro::OperationsClient DeployIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeployIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeployIndexResponse, DeployIndexMetadata> PollOnceDeployIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployIndexResponse, DeployIndexMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeployIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeployIndexResponse, DeployIndexMetadata>> PollOnceDeployIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployIndexResponse, DeployIndexMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployIndexOperationsClient, callSettings);

        /// <summary>
        /// Undeploys an Index from IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployIndexResponse, UndeployIndexMetadata> UndeployIndex(UndeployIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys an Index from IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIndexResponse, UndeployIndexMetadata>> UndeployIndexAsync(UndeployIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys an Index from IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIndexResponse, UndeployIndexMetadata>> UndeployIndexAsync(UndeployIndexRequest request, st::CancellationToken cancellationToken) =>
            UndeployIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeployIndex</c>.</summary>
        public virtual lro::OperationsClient UndeployIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeployIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UndeployIndexResponse, UndeployIndexMetadata> PollOnceUndeployIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployIndexResponse, UndeployIndexMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeployIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UndeployIndexResponse, UndeployIndexMetadata>> PollOnceUndeployIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployIndexResponse, UndeployIndexMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployIndexOperationsClient, callSettings);

        /// <summary>
        /// Creates a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collection, CreateCollectionMetadata> CreateCollection(CreateCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, CreateCollectionMetadata>> CreateCollectionAsync(CreateCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, CreateCollectionMetadata>> CreateCollectionAsync(CreateCollectionRequest request, st::CancellationToken cancellationToken) =>
            CreateCollectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCollection</c>.</summary>
        public virtual lro::OperationsClient CreateCollectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCollection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Collection, CreateCollectionMetadata> PollOnceCreateCollection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collection, CreateCollectionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCollectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCollection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Collection, CreateCollectionMetadata>> PollOnceCreateCollectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collection, CreateCollectionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCollectionOperationsClient, callSettings);

        /// <summary>
        /// Creates a collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this collection will be created.
        /// Format: `projects/{project_number}/locations/{location}/corpora/{corpus}`
        /// </param>
        /// <param name="collection">
        /// Required. The collection resource to be created.
        /// </param>
        /// <param name="collectionId">
        /// Optional. The ID to use for the collection, which will become the final
        /// component of the resource name if user choose to specify. Otherwise,
        /// collection id will be generated by system.
        /// 
        /// This value should be up to 55 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collection, CreateCollectionMetadata> CreateCollection(string parent, Collection collection, string collectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCollection(new CreateCollectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Collection = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
                CollectionId = collectionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this collection will be created.
        /// Format: `projects/{project_number}/locations/{location}/corpora/{corpus}`
        /// </param>
        /// <param name="collection">
        /// Required. The collection resource to be created.
        /// </param>
        /// <param name="collectionId">
        /// Optional. The ID to use for the collection, which will become the final
        /// component of the resource name if user choose to specify. Otherwise,
        /// collection id will be generated by system.
        /// 
        /// This value should be up to 55 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, CreateCollectionMetadata>> CreateCollectionAsync(string parent, Collection collection, string collectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCollectionAsync(new CreateCollectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Collection = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
                CollectionId = collectionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this collection will be created.
        /// Format: `projects/{project_number}/locations/{location}/corpora/{corpus}`
        /// </param>
        /// <param name="collection">
        /// Required. The collection resource to be created.
        /// </param>
        /// <param name="collectionId">
        /// Optional. The ID to use for the collection, which will become the final
        /// component of the resource name if user choose to specify. Otherwise,
        /// collection id will be generated by system.
        /// 
        /// This value should be up to 55 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, CreateCollectionMetadata>> CreateCollectionAsync(string parent, Collection collection, string collectionId, st::CancellationToken cancellationToken) =>
            CreateCollectionAsync(parent, collection, collectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this collection will be created.
        /// Format: `projects/{project_number}/locations/{location}/corpora/{corpus}`
        /// </param>
        /// <param name="collection">
        /// Required. The collection resource to be created.
        /// </param>
        /// <param name="collectionId">
        /// Optional. The ID to use for the collection, which will become the final
        /// component of the resource name if user choose to specify. Otherwise,
        /// collection id will be generated by system.
        /// 
        /// This value should be up to 55 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collection, CreateCollectionMetadata> CreateCollection(CorpusName parent, Collection collection, string collectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCollection(new CreateCollectionRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Collection = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
                CollectionId = collectionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this collection will be created.
        /// Format: `projects/{project_number}/locations/{location}/corpora/{corpus}`
        /// </param>
        /// <param name="collection">
        /// Required. The collection resource to be created.
        /// </param>
        /// <param name="collectionId">
        /// Optional. The ID to use for the collection, which will become the final
        /// component of the resource name if user choose to specify. Otherwise,
        /// collection id will be generated by system.
        /// 
        /// This value should be up to 55 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, CreateCollectionMetadata>> CreateCollectionAsync(CorpusName parent, Collection collection, string collectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCollectionAsync(new CreateCollectionRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Collection = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
                CollectionId = collectionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this collection will be created.
        /// Format: `projects/{project_number}/locations/{location}/corpora/{corpus}`
        /// </param>
        /// <param name="collection">
        /// Required. The collection resource to be created.
        /// </param>
        /// <param name="collectionId">
        /// Optional. The ID to use for the collection, which will become the final
        /// component of the resource name if user choose to specify. Otherwise,
        /// collection id will be generated by system.
        /// 
        /// This value should be up to 55 characters, and valid characters
        /// are /[a-z][0-9]-/. The first character must be a letter, the last could be
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, CreateCollectionMetadata>> CreateCollectionAsync(CorpusName parent, Collection collection, string collectionId, st::CancellationToken cancellationToken) =>
            CreateCollectionAsync(parent, collection, collectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteCollectionMetadata> DeleteCollection(DeleteCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(DeleteCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(DeleteCollectionRequest request, st::CancellationToken cancellationToken) =>
            DeleteCollectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCollection</c>.</summary>
        public virtual lro::OperationsClient DeleteCollectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCollection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteCollectionMetadata> PollOnceDeleteCollection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteCollectionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCollectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCollection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> PollOnceDeleteCollectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteCollectionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCollectionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the collection to delete. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteCollectionMetadata> DeleteCollection(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollection(new DeleteCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the collection to delete. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollectionAsync(new DeleteCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the collection to delete. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the collection to delete. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteCollectionMetadata> DeleteCollection(CollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollection(new DeleteCollectionRequest
            {
                CollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the collection to delete. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(CollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollectionAsync(new DeleteCollectionRequest
            {
                CollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the collection to delete. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(CollectionName name, st::CancellationToken cancellationToken) =>
            DeleteCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Collection GetCollection(GetCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> GetCollectionAsync(GetCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> GetCollectionAsync(GetCollectionRequest request, st::CancellationToken cancellationToken) =>
            GetCollectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a collection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the collection to retrieve. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Collection GetCollection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCollection(new GetCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a collection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the collection to retrieve. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> GetCollectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCollectionAsync(new GetCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a collection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the collection to retrieve. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> GetCollectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a collection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the collection to retrieve. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Collection GetCollection(CollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCollection(new GetCollectionRequest
            {
                CollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a collection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the collection to retrieve. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> GetCollectionAsync(CollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCollectionAsync(new GetCollectionRequest
            {
                CollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a collection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the collection to retrieve. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> GetCollectionAsync(CollectionName name, st::CancellationToken cancellationToken) =>
            GetCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Collection UpdateCollection(UpdateCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> UpdateCollectionAsync(UpdateCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> UpdateCollectionAsync(UpdateCollectionRequest request, st::CancellationToken cancellationToken) =>
            UpdateCollectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a collection.
        /// </summary>
        /// <param name="collection">
        /// Required. The collection to update.
        /// 
        /// The collection's `name` field is used to identify the collection to be
        /// updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// - Unset `update_mask` or set `update_mask` to be a single "*" only will
        /// update all updatable fields with the value provided in `collection`.
        /// - To update `display_name` value to empty string, set it in the
        /// `collection`
        /// to empty string, and set `update_mask` with "display_name". Same applies
        /// to other updatable string fields in the `collection`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Collection UpdateCollection(Collection collection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCollection(new UpdateCollectionRequest
            {
                Collection = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a collection.
        /// </summary>
        /// <param name="collection">
        /// Required. The collection to update.
        /// 
        /// The collection's `name` field is used to identify the collection to be
        /// updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// - Unset `update_mask` or set `update_mask` to be a single "*" only will
        /// update all updatable fields with the value provided in `collection`.
        /// - To update `display_name` value to empty string, set it in the
        /// `collection`
        /// to empty string, and set `update_mask` with "display_name". Same applies
        /// to other updatable string fields in the `collection`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> UpdateCollectionAsync(Collection collection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCollectionAsync(new UpdateCollectionRequest
            {
                Collection = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a collection.
        /// </summary>
        /// <param name="collection">
        /// Required. The collection to update.
        /// 
        /// The collection's `name` field is used to identify the collection to be
        /// updated. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// - Unset `update_mask` or set `update_mask` to be a single "*" only will
        /// update all updatable fields with the value provided in `collection`.
        /// - To update `display_name` value to empty string, set it in the
        /// `collection`
        /// to empty string, and set `update_mask` with "display_name". Same applies
        /// to other updatable string fields in the `collection`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> UpdateCollectionAsync(Collection collection, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCollectionAsync(collection, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists collections inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Collection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCollectionsResponse, Collection> ListCollections(ListCollectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists collections inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Collection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCollectionsResponse, Collection> ListCollectionsAsync(ListCollectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists collections inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent corpus. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable sequence of <see cref="Collection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCollectionsResponse, Collection> ListCollections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectionsRequest request = new ListCollectionsRequest
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
            return ListCollections(request, callSettings);
        }

        /// <summary>
        /// Lists collections inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent corpus. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Collection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCollectionsResponse, Collection> ListCollectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectionsRequest request = new ListCollectionsRequest
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
            return ListCollectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists collections inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent corpus. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable sequence of <see cref="Collection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCollectionsResponse, Collection> ListCollections(CorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectionsRequest request = new ListCollectionsRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCollections(request, callSettings);
        }

        /// <summary>
        /// Lists collections inside a corpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent corpus. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Collection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCollectionsResponse, Collection> ListCollectionsAsync(CorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectionsRequest request = new ListCollectionsRequest
            {
                ParentAsCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCollectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Adds an item into a Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddCollectionItemResponse AddCollectionItem(AddCollectionItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an item into a Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddCollectionItemResponse> AddCollectionItemAsync(AddCollectionItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an item into a Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddCollectionItemResponse> AddCollectionItemAsync(AddCollectionItemRequest request, st::CancellationToken cancellationToken) =>
            AddCollectionItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds an item into a Collection.
        /// </summary>
        /// <param name="item">
        /// Required. The item to be added.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddCollectionItemResponse AddCollectionItem(CollectionItem item, gaxgrpc::CallSettings callSettings = null) =>
            AddCollectionItem(new AddCollectionItemRequest
            {
                Item = gax::GaxPreconditions.CheckNotNull(item, nameof(item)),
            }, callSettings);

        /// <summary>
        /// Adds an item into a Collection.
        /// </summary>
        /// <param name="item">
        /// Required. The item to be added.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddCollectionItemResponse> AddCollectionItemAsync(CollectionItem item, gaxgrpc::CallSettings callSettings = null) =>
            AddCollectionItemAsync(new AddCollectionItemRequest
            {
                Item = gax::GaxPreconditions.CheckNotNull(item, nameof(item)),
            }, callSettings);

        /// <summary>
        /// Adds an item into a Collection.
        /// </summary>
        /// <param name="item">
        /// Required. The item to be added.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddCollectionItemResponse> AddCollectionItemAsync(CollectionItem item, st::CancellationToken cancellationToken) =>
            AddCollectionItemAsync(item, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes an item from a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveCollectionItemResponse RemoveCollectionItem(RemoveCollectionItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes an item from a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveCollectionItemResponse> RemoveCollectionItemAsync(RemoveCollectionItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes an item from a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveCollectionItemResponse> RemoveCollectionItemAsync(RemoveCollectionItemRequest request, st::CancellationToken cancellationToken) =>
            RemoveCollectionItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes an item from a collection.
        /// </summary>
        /// <param name="item">
        /// Required. The item to be removed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveCollectionItemResponse RemoveCollectionItem(CollectionItem item, gaxgrpc::CallSettings callSettings = null) =>
            RemoveCollectionItem(new RemoveCollectionItemRequest
            {
                Item = gax::GaxPreconditions.CheckNotNull(item, nameof(item)),
            }, callSettings);

        /// <summary>
        /// Removes an item from a collection.
        /// </summary>
        /// <param name="item">
        /// Required. The item to be removed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveCollectionItemResponse> RemoveCollectionItemAsync(CollectionItem item, gaxgrpc::CallSettings callSettings = null) =>
            RemoveCollectionItemAsync(new RemoveCollectionItemRequest
            {
                Item = gax::GaxPreconditions.CheckNotNull(item, nameof(item)),
            }, callSettings);

        /// <summary>
        /// Removes an item from a collection.
        /// </summary>
        /// <param name="item">
        /// Required. The item to be removed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveCollectionItemResponse> RemoveCollectionItemAsync(CollectionItem item, st::CancellationToken cancellationToken) =>
            RemoveCollectionItemAsync(item, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// View items inside a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CollectionItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ViewCollectionItemsResponse, CollectionItem> ViewCollectionItems(ViewCollectionItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// View items inside a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CollectionItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ViewCollectionItemsResponse, CollectionItem> ViewCollectionItemsAsync(ViewCollectionItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// View items inside a collection.
        /// </summary>
        /// <param name="collection">
        /// Required. The collection to view. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
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
        /// <returns>A pageable sequence of <see cref="CollectionItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ViewCollectionItemsResponse, CollectionItem> ViewCollectionItems(string collection, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ViewCollectionItemsRequest request = new ViewCollectionItemsRequest
            {
                Collection = gax::GaxPreconditions.CheckNotNullOrEmpty(collection, nameof(collection)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ViewCollectionItems(request, callSettings);
        }

        /// <summary>
        /// View items inside a collection.
        /// </summary>
        /// <param name="collection">
        /// Required. The collection to view. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="CollectionItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ViewCollectionItemsResponse, CollectionItem> ViewCollectionItemsAsync(string collection, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ViewCollectionItemsRequest request = new ViewCollectionItemsRequest
            {
                Collection = gax::GaxPreconditions.CheckNotNullOrEmpty(collection, nameof(collection)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ViewCollectionItemsAsync(request, callSettings);
        }

        /// <summary>
        /// View items inside a collection.
        /// </summary>
        /// <param name="collection">
        /// Required. The collection to view. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
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
        /// <returns>A pageable sequence of <see cref="CollectionItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ViewCollectionItemsResponse, CollectionItem> ViewCollectionItems(CollectionName collection, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ViewCollectionItemsRequest request = new ViewCollectionItemsRequest
            {
                CollectionAsCollectionName = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ViewCollectionItems(request, callSettings);
        }

        /// <summary>
        /// View items inside a collection.
        /// </summary>
        /// <param name="collection">
        /// Required. The collection to view. Format:
        /// `projects/{project_number}/locations/{location}/corpora/{corpus}/collections/{collection}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="CollectionItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ViewCollectionItemsResponse, CollectionItem> ViewCollectionItemsAsync(CollectionName collection, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ViewCollectionItemsRequest request = new ViewCollectionItemsRequest
            {
                CollectionAsCollectionName = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ViewCollectionItemsAsync(request, callSettings);
        }
    }

    /// <summary>Warehouse client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service that manages media content + metadata for streaming.
    /// </remarks>
    public sealed partial class WarehouseClientImpl : WarehouseClient
    {
        private readonly gaxgrpc::ApiCall<CreateAssetRequest, Asset> _callCreateAsset;

        private readonly gaxgrpc::ApiCall<UpdateAssetRequest, Asset> _callUpdateAsset;

        private readonly gaxgrpc::ApiCall<GetAssetRequest, Asset> _callGetAsset;

        private readonly gaxgrpc::ApiCall<ListAssetsRequest, ListAssetsResponse> _callListAssets;

        private readonly gaxgrpc::ApiCall<DeleteAssetRequest, lro::Operation> _callDeleteAsset;

        private readonly gaxgrpc::ApiCall<UploadAssetRequest, lro::Operation> _callUploadAsset;

        private readonly gaxgrpc::ApiCall<GenerateRetrievalUrlRequest, GenerateRetrievalUrlResponse> _callGenerateRetrievalUrl;

        private readonly gaxgrpc::ApiCall<AnalyzeAssetRequest, lro::Operation> _callAnalyzeAsset;

        private readonly gaxgrpc::ApiCall<IndexAssetRequest, lro::Operation> _callIndexAsset;

        private readonly gaxgrpc::ApiCall<RemoveIndexAssetRequest, lro::Operation> _callRemoveIndexAsset;

        private readonly gaxgrpc::ApiCall<ViewIndexedAssetsRequest, ViewIndexedAssetsResponse> _callViewIndexedAssets;

        private readonly gaxgrpc::ApiCall<CreateIndexRequest, lro::Operation> _callCreateIndex;

        private readonly gaxgrpc::ApiCall<UpdateIndexRequest, lro::Operation> _callUpdateIndex;

        private readonly gaxgrpc::ApiCall<GetIndexRequest, Index> _callGetIndex;

        private readonly gaxgrpc::ApiCall<ListIndexesRequest, ListIndexesResponse> _callListIndexes;

        private readonly gaxgrpc::ApiCall<DeleteIndexRequest, lro::Operation> _callDeleteIndex;

        private readonly gaxgrpc::ApiCall<CreateCorpusRequest, lro::Operation> _callCreateCorpus;

        private readonly gaxgrpc::ApiCall<GetCorpusRequest, Corpus> _callGetCorpus;

        private readonly gaxgrpc::ApiCall<UpdateCorpusRequest, Corpus> _callUpdateCorpus;

        private readonly gaxgrpc::ApiCall<ListCorporaRequest, ListCorporaResponse> _callListCorpora;

        private readonly gaxgrpc::ApiCall<DeleteCorpusRequest, wkt::Empty> _callDeleteCorpus;

        private readonly gaxgrpc::ApiCall<AnalyzeCorpusRequest, lro::Operation> _callAnalyzeCorpus;

        private readonly gaxgrpc::ApiCall<CreateDataSchemaRequest, DataSchema> _callCreateDataSchema;

        private readonly gaxgrpc::ApiCall<UpdateDataSchemaRequest, DataSchema> _callUpdateDataSchema;

        private readonly gaxgrpc::ApiCall<GetDataSchemaRequest, DataSchema> _callGetDataSchema;

        private readonly gaxgrpc::ApiCall<DeleteDataSchemaRequest, wkt::Empty> _callDeleteDataSchema;

        private readonly gaxgrpc::ApiCall<ListDataSchemasRequest, ListDataSchemasResponse> _callListDataSchemas;

        private readonly gaxgrpc::ApiCall<CreateAnnotationRequest, Annotation> _callCreateAnnotation;

        private readonly gaxgrpc::ApiCall<GetAnnotationRequest, Annotation> _callGetAnnotation;

        private readonly gaxgrpc::ApiCall<ListAnnotationsRequest, ListAnnotationsResponse> _callListAnnotations;

        private readonly gaxgrpc::ApiCall<UpdateAnnotationRequest, Annotation> _callUpdateAnnotation;

        private readonly gaxgrpc::ApiCall<DeleteAnnotationRequest, wkt::Empty> _callDeleteAnnotation;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<IngestAssetRequest, IngestAssetResponse> _callIngestAsset;

        private readonly gaxgrpc::ApiCall<ClipAssetRequest, ClipAssetResponse> _callClipAsset;

        private readonly gaxgrpc::ApiCall<GenerateHlsUriRequest, GenerateHlsUriResponse> _callGenerateHlsUri;

        private readonly gaxgrpc::ApiCall<ImportAssetsRequest, lro::Operation> _callImportAssets;

        private readonly gaxgrpc::ApiCall<CreateSearchConfigRequest, SearchConfig> _callCreateSearchConfig;

        private readonly gaxgrpc::ApiCall<UpdateSearchConfigRequest, SearchConfig> _callUpdateSearchConfig;

        private readonly gaxgrpc::ApiCall<GetSearchConfigRequest, SearchConfig> _callGetSearchConfig;

        private readonly gaxgrpc::ApiCall<DeleteSearchConfigRequest, wkt::Empty> _callDeleteSearchConfig;

        private readonly gaxgrpc::ApiCall<ListSearchConfigsRequest, ListSearchConfigsResponse> _callListSearchConfigs;

        private readonly gaxgrpc::ApiCall<CreateSearchHypernymRequest, SearchHypernym> _callCreateSearchHypernym;

        private readonly gaxgrpc::ApiCall<UpdateSearchHypernymRequest, SearchHypernym> _callUpdateSearchHypernym;

        private readonly gaxgrpc::ApiCall<GetSearchHypernymRequest, SearchHypernym> _callGetSearchHypernym;

        private readonly gaxgrpc::ApiCall<DeleteSearchHypernymRequest, wkt::Empty> _callDeleteSearchHypernym;

        private readonly gaxgrpc::ApiCall<ListSearchHypernymsRequest, ListSearchHypernymsResponse> _callListSearchHypernyms;

        private readonly gaxgrpc::ApiCall<SearchAssetsRequest, SearchAssetsResponse> _callSearchAssets;

        private readonly gaxgrpc::ApiCall<SearchIndexEndpointRequest, SearchIndexEndpointResponse> _callSearchIndexEndpoint;

        private readonly gaxgrpc::ApiCall<CreateIndexEndpointRequest, lro::Operation> _callCreateIndexEndpoint;

        private readonly gaxgrpc::ApiCall<GetIndexEndpointRequest, IndexEndpoint> _callGetIndexEndpoint;

        private readonly gaxgrpc::ApiCall<ListIndexEndpointsRequest, ListIndexEndpointsResponse> _callListIndexEndpoints;

        private readonly gaxgrpc::ApiCall<UpdateIndexEndpointRequest, lro::Operation> _callUpdateIndexEndpoint;

        private readonly gaxgrpc::ApiCall<DeleteIndexEndpointRequest, lro::Operation> _callDeleteIndexEndpoint;

        private readonly gaxgrpc::ApiCall<DeployIndexRequest, lro::Operation> _callDeployIndex;

        private readonly gaxgrpc::ApiCall<UndeployIndexRequest, lro::Operation> _callUndeployIndex;

        private readonly gaxgrpc::ApiCall<CreateCollectionRequest, lro::Operation> _callCreateCollection;

        private readonly gaxgrpc::ApiCall<DeleteCollectionRequest, lro::Operation> _callDeleteCollection;

        private readonly gaxgrpc::ApiCall<GetCollectionRequest, Collection> _callGetCollection;

        private readonly gaxgrpc::ApiCall<UpdateCollectionRequest, Collection> _callUpdateCollection;

        private readonly gaxgrpc::ApiCall<ListCollectionsRequest, ListCollectionsResponse> _callListCollections;

        private readonly gaxgrpc::ApiCall<AddCollectionItemRequest, AddCollectionItemResponse> _callAddCollectionItem;

        private readonly gaxgrpc::ApiCall<RemoveCollectionItemRequest, RemoveCollectionItemResponse> _callRemoveCollectionItem;

        private readonly gaxgrpc::ApiCall<ViewCollectionItemsRequest, ViewCollectionItemsResponse> _callViewCollectionItems;

        /// <summary>
        /// Constructs a client wrapper for the Warehouse service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WarehouseSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WarehouseClientImpl(Warehouse.WarehouseClient grpcClient, WarehouseSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WarehouseSettings effectiveSettings = settings ?? WarehouseSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteAssetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAssetOperationsSettings, logger);
            UploadAssetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UploadAssetOperationsSettings, logger);
            AnalyzeAssetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AnalyzeAssetOperationsSettings, logger);
            IndexAssetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.IndexAssetOperationsSettings, logger);
            RemoveIndexAssetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RemoveIndexAssetOperationsSettings, logger);
            CreateIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateIndexOperationsSettings, logger);
            UpdateIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateIndexOperationsSettings, logger);
            DeleteIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteIndexOperationsSettings, logger);
            CreateCorpusOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCorpusOperationsSettings, logger);
            AnalyzeCorpusOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AnalyzeCorpusOperationsSettings, logger);
            ImportAssetsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportAssetsOperationsSettings, logger);
            CreateIndexEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateIndexEndpointOperationsSettings, logger);
            UpdateIndexEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateIndexEndpointOperationsSettings, logger);
            DeleteIndexEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteIndexEndpointOperationsSettings, logger);
            DeployIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeployIndexOperationsSettings, logger);
            UndeployIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeployIndexOperationsSettings, logger);
            CreateCollectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCollectionOperationsSettings, logger);
            DeleteCollectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCollectionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateAsset = clientHelper.BuildApiCall<CreateAssetRequest, Asset>("CreateAsset", grpcClient.CreateAssetAsync, grpcClient.CreateAsset, effectiveSettings.CreateAssetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAsset);
            Modify_CreateAssetApiCall(ref _callCreateAsset);
            _callUpdateAsset = clientHelper.BuildApiCall<UpdateAssetRequest, Asset>("UpdateAsset", grpcClient.UpdateAssetAsync, grpcClient.UpdateAsset, effectiveSettings.UpdateAssetSettings).WithGoogleRequestParam("asset.name", request => request.Asset?.Name);
            Modify_ApiCall(ref _callUpdateAsset);
            Modify_UpdateAssetApiCall(ref _callUpdateAsset);
            _callGetAsset = clientHelper.BuildApiCall<GetAssetRequest, Asset>("GetAsset", grpcClient.GetAssetAsync, grpcClient.GetAsset, effectiveSettings.GetAssetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAsset);
            Modify_GetAssetApiCall(ref _callGetAsset);
            _callListAssets = clientHelper.BuildApiCall<ListAssetsRequest, ListAssetsResponse>("ListAssets", grpcClient.ListAssetsAsync, grpcClient.ListAssets, effectiveSettings.ListAssetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAssets);
            Modify_ListAssetsApiCall(ref _callListAssets);
            _callDeleteAsset = clientHelper.BuildApiCall<DeleteAssetRequest, lro::Operation>("DeleteAsset", grpcClient.DeleteAssetAsync, grpcClient.DeleteAsset, effectiveSettings.DeleteAssetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAsset);
            Modify_DeleteAssetApiCall(ref _callDeleteAsset);
            _callUploadAsset = clientHelper.BuildApiCall<UploadAssetRequest, lro::Operation>("UploadAsset", grpcClient.UploadAssetAsync, grpcClient.UploadAsset, effectiveSettings.UploadAssetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUploadAsset);
            Modify_UploadAssetApiCall(ref _callUploadAsset);
            _callGenerateRetrievalUrl = clientHelper.BuildApiCall<GenerateRetrievalUrlRequest, GenerateRetrievalUrlResponse>("GenerateRetrievalUrl", grpcClient.GenerateRetrievalUrlAsync, grpcClient.GenerateRetrievalUrl, effectiveSettings.GenerateRetrievalUrlSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateRetrievalUrl);
            Modify_GenerateRetrievalUrlApiCall(ref _callGenerateRetrievalUrl);
            _callAnalyzeAsset = clientHelper.BuildApiCall<AnalyzeAssetRequest, lro::Operation>("AnalyzeAsset", grpcClient.AnalyzeAssetAsync, grpcClient.AnalyzeAsset, effectiveSettings.AnalyzeAssetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAnalyzeAsset);
            Modify_AnalyzeAssetApiCall(ref _callAnalyzeAsset);
            _callIndexAsset = clientHelper.BuildApiCall<IndexAssetRequest, lro::Operation>("IndexAsset", grpcClient.IndexAssetAsync, grpcClient.IndexAsset, effectiveSettings.IndexAssetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callIndexAsset);
            Modify_IndexAssetApiCall(ref _callIndexAsset);
            _callRemoveIndexAsset = clientHelper.BuildApiCall<RemoveIndexAssetRequest, lro::Operation>("RemoveIndexAsset", grpcClient.RemoveIndexAssetAsync, grpcClient.RemoveIndexAsset, effectiveSettings.RemoveIndexAssetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRemoveIndexAsset);
            Modify_RemoveIndexAssetApiCall(ref _callRemoveIndexAsset);
            _callViewIndexedAssets = clientHelper.BuildApiCall<ViewIndexedAssetsRequest, ViewIndexedAssetsResponse>("ViewIndexedAssets", grpcClient.ViewIndexedAssetsAsync, grpcClient.ViewIndexedAssets, effectiveSettings.ViewIndexedAssetsSettings).WithGoogleRequestParam("index", request => request.Index);
            Modify_ApiCall(ref _callViewIndexedAssets);
            Modify_ViewIndexedAssetsApiCall(ref _callViewIndexedAssets);
            _callCreateIndex = clientHelper.BuildApiCall<CreateIndexRequest, lro::Operation>("CreateIndex", grpcClient.CreateIndexAsync, grpcClient.CreateIndex, effectiveSettings.CreateIndexSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIndex);
            Modify_CreateIndexApiCall(ref _callCreateIndex);
            _callUpdateIndex = clientHelper.BuildApiCall<UpdateIndexRequest, lro::Operation>("UpdateIndex", grpcClient.UpdateIndexAsync, grpcClient.UpdateIndex, effectiveSettings.UpdateIndexSettings).WithGoogleRequestParam("index.name", request => request.Index?.Name);
            Modify_ApiCall(ref _callUpdateIndex);
            Modify_UpdateIndexApiCall(ref _callUpdateIndex);
            _callGetIndex = clientHelper.BuildApiCall<GetIndexRequest, Index>("GetIndex", grpcClient.GetIndexAsync, grpcClient.GetIndex, effectiveSettings.GetIndexSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIndex);
            Modify_GetIndexApiCall(ref _callGetIndex);
            _callListIndexes = clientHelper.BuildApiCall<ListIndexesRequest, ListIndexesResponse>("ListIndexes", grpcClient.ListIndexesAsync, grpcClient.ListIndexes, effectiveSettings.ListIndexesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIndexes);
            Modify_ListIndexesApiCall(ref _callListIndexes);
            _callDeleteIndex = clientHelper.BuildApiCall<DeleteIndexRequest, lro::Operation>("DeleteIndex", grpcClient.DeleteIndexAsync, grpcClient.DeleteIndex, effectiveSettings.DeleteIndexSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIndex);
            Modify_DeleteIndexApiCall(ref _callDeleteIndex);
            _callCreateCorpus = clientHelper.BuildApiCall<CreateCorpusRequest, lro::Operation>("CreateCorpus", grpcClient.CreateCorpusAsync, grpcClient.CreateCorpus, effectiveSettings.CreateCorpusSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCorpus);
            Modify_CreateCorpusApiCall(ref _callCreateCorpus);
            _callGetCorpus = clientHelper.BuildApiCall<GetCorpusRequest, Corpus>("GetCorpus", grpcClient.GetCorpusAsync, grpcClient.GetCorpus, effectiveSettings.GetCorpusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCorpus);
            Modify_GetCorpusApiCall(ref _callGetCorpus);
            _callUpdateCorpus = clientHelper.BuildApiCall<UpdateCorpusRequest, Corpus>("UpdateCorpus", grpcClient.UpdateCorpusAsync, grpcClient.UpdateCorpus, effectiveSettings.UpdateCorpusSettings).WithGoogleRequestParam("corpus.name", request => request.Corpus?.Name);
            Modify_ApiCall(ref _callUpdateCorpus);
            Modify_UpdateCorpusApiCall(ref _callUpdateCorpus);
            _callListCorpora = clientHelper.BuildApiCall<ListCorporaRequest, ListCorporaResponse>("ListCorpora", grpcClient.ListCorporaAsync, grpcClient.ListCorpora, effectiveSettings.ListCorporaSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCorpora);
            Modify_ListCorporaApiCall(ref _callListCorpora);
            _callDeleteCorpus = clientHelper.BuildApiCall<DeleteCorpusRequest, wkt::Empty>("DeleteCorpus", grpcClient.DeleteCorpusAsync, grpcClient.DeleteCorpus, effectiveSettings.DeleteCorpusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCorpus);
            Modify_DeleteCorpusApiCall(ref _callDeleteCorpus);
            _callAnalyzeCorpus = clientHelper.BuildApiCall<AnalyzeCorpusRequest, lro::Operation>("AnalyzeCorpus", grpcClient.AnalyzeCorpusAsync, grpcClient.AnalyzeCorpus, effectiveSettings.AnalyzeCorpusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAnalyzeCorpus);
            Modify_AnalyzeCorpusApiCall(ref _callAnalyzeCorpus);
            _callCreateDataSchema = clientHelper.BuildApiCall<CreateDataSchemaRequest, DataSchema>("CreateDataSchema", grpcClient.CreateDataSchemaAsync, grpcClient.CreateDataSchema, effectiveSettings.CreateDataSchemaSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataSchema);
            Modify_CreateDataSchemaApiCall(ref _callCreateDataSchema);
            _callUpdateDataSchema = clientHelper.BuildApiCall<UpdateDataSchemaRequest, DataSchema>("UpdateDataSchema", grpcClient.UpdateDataSchemaAsync, grpcClient.UpdateDataSchema, effectiveSettings.UpdateDataSchemaSettings).WithGoogleRequestParam("data_schema.name", request => request.DataSchema?.Name);
            Modify_ApiCall(ref _callUpdateDataSchema);
            Modify_UpdateDataSchemaApiCall(ref _callUpdateDataSchema);
            _callGetDataSchema = clientHelper.BuildApiCall<GetDataSchemaRequest, DataSchema>("GetDataSchema", grpcClient.GetDataSchemaAsync, grpcClient.GetDataSchema, effectiveSettings.GetDataSchemaSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataSchema);
            Modify_GetDataSchemaApiCall(ref _callGetDataSchema);
            _callDeleteDataSchema = clientHelper.BuildApiCall<DeleteDataSchemaRequest, wkt::Empty>("DeleteDataSchema", grpcClient.DeleteDataSchemaAsync, grpcClient.DeleteDataSchema, effectiveSettings.DeleteDataSchemaSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataSchema);
            Modify_DeleteDataSchemaApiCall(ref _callDeleteDataSchema);
            _callListDataSchemas = clientHelper.BuildApiCall<ListDataSchemasRequest, ListDataSchemasResponse>("ListDataSchemas", grpcClient.ListDataSchemasAsync, grpcClient.ListDataSchemas, effectiveSettings.ListDataSchemasSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataSchemas);
            Modify_ListDataSchemasApiCall(ref _callListDataSchemas);
            _callCreateAnnotation = clientHelper.BuildApiCall<CreateAnnotationRequest, Annotation>("CreateAnnotation", grpcClient.CreateAnnotationAsync, grpcClient.CreateAnnotation, effectiveSettings.CreateAnnotationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAnnotation);
            Modify_CreateAnnotationApiCall(ref _callCreateAnnotation);
            _callGetAnnotation = clientHelper.BuildApiCall<GetAnnotationRequest, Annotation>("GetAnnotation", grpcClient.GetAnnotationAsync, grpcClient.GetAnnotation, effectiveSettings.GetAnnotationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAnnotation);
            Modify_GetAnnotationApiCall(ref _callGetAnnotation);
            _callListAnnotations = clientHelper.BuildApiCall<ListAnnotationsRequest, ListAnnotationsResponse>("ListAnnotations", grpcClient.ListAnnotationsAsync, grpcClient.ListAnnotations, effectiveSettings.ListAnnotationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAnnotations);
            Modify_ListAnnotationsApiCall(ref _callListAnnotations);
            _callUpdateAnnotation = clientHelper.BuildApiCall<UpdateAnnotationRequest, Annotation>("UpdateAnnotation", grpcClient.UpdateAnnotationAsync, grpcClient.UpdateAnnotation, effectiveSettings.UpdateAnnotationSettings).WithGoogleRequestParam("annotation.name", request => request.Annotation?.Name);
            Modify_ApiCall(ref _callUpdateAnnotation);
            Modify_UpdateAnnotationApiCall(ref _callUpdateAnnotation);
            _callDeleteAnnotation = clientHelper.BuildApiCall<DeleteAnnotationRequest, wkt::Empty>("DeleteAnnotation", grpcClient.DeleteAnnotationAsync, grpcClient.DeleteAnnotation, effectiveSettings.DeleteAnnotationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAnnotation);
            Modify_DeleteAnnotationApiCall(ref _callDeleteAnnotation);
            _callIngestAsset = clientHelper.BuildApiCall<IngestAssetRequest, IngestAssetResponse>("IngestAsset", grpcClient.IngestAsset, effectiveSettings.IngestAssetSettings, effectiveSettings.IngestAssetStreamingSettings);
            Modify_ApiCall(ref _callIngestAsset);
            Modify_IngestAssetApiCall(ref _callIngestAsset);
            _callClipAsset = clientHelper.BuildApiCall<ClipAssetRequest, ClipAssetResponse>("ClipAsset", grpcClient.ClipAssetAsync, grpcClient.ClipAsset, effectiveSettings.ClipAssetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callClipAsset);
            Modify_ClipAssetApiCall(ref _callClipAsset);
            _callGenerateHlsUri = clientHelper.BuildApiCall<GenerateHlsUriRequest, GenerateHlsUriResponse>("GenerateHlsUri", grpcClient.GenerateHlsUriAsync, grpcClient.GenerateHlsUri, effectiveSettings.GenerateHlsUriSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateHlsUri);
            Modify_GenerateHlsUriApiCall(ref _callGenerateHlsUri);
            _callImportAssets = clientHelper.BuildApiCall<ImportAssetsRequest, lro::Operation>("ImportAssets", grpcClient.ImportAssetsAsync, grpcClient.ImportAssets, effectiveSettings.ImportAssetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportAssets);
            Modify_ImportAssetsApiCall(ref _callImportAssets);
            _callCreateSearchConfig = clientHelper.BuildApiCall<CreateSearchConfigRequest, SearchConfig>("CreateSearchConfig", grpcClient.CreateSearchConfigAsync, grpcClient.CreateSearchConfig, effectiveSettings.CreateSearchConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSearchConfig);
            Modify_CreateSearchConfigApiCall(ref _callCreateSearchConfig);
            _callUpdateSearchConfig = clientHelper.BuildApiCall<UpdateSearchConfigRequest, SearchConfig>("UpdateSearchConfig", grpcClient.UpdateSearchConfigAsync, grpcClient.UpdateSearchConfig, effectiveSettings.UpdateSearchConfigSettings).WithGoogleRequestParam("search_config.name", request => request.SearchConfig?.Name);
            Modify_ApiCall(ref _callUpdateSearchConfig);
            Modify_UpdateSearchConfigApiCall(ref _callUpdateSearchConfig);
            _callGetSearchConfig = clientHelper.BuildApiCall<GetSearchConfigRequest, SearchConfig>("GetSearchConfig", grpcClient.GetSearchConfigAsync, grpcClient.GetSearchConfig, effectiveSettings.GetSearchConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSearchConfig);
            Modify_GetSearchConfigApiCall(ref _callGetSearchConfig);
            _callDeleteSearchConfig = clientHelper.BuildApiCall<DeleteSearchConfigRequest, wkt::Empty>("DeleteSearchConfig", grpcClient.DeleteSearchConfigAsync, grpcClient.DeleteSearchConfig, effectiveSettings.DeleteSearchConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSearchConfig);
            Modify_DeleteSearchConfigApiCall(ref _callDeleteSearchConfig);
            _callListSearchConfigs = clientHelper.BuildApiCall<ListSearchConfigsRequest, ListSearchConfigsResponse>("ListSearchConfigs", grpcClient.ListSearchConfigsAsync, grpcClient.ListSearchConfigs, effectiveSettings.ListSearchConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSearchConfigs);
            Modify_ListSearchConfigsApiCall(ref _callListSearchConfigs);
            _callCreateSearchHypernym = clientHelper.BuildApiCall<CreateSearchHypernymRequest, SearchHypernym>("CreateSearchHypernym", grpcClient.CreateSearchHypernymAsync, grpcClient.CreateSearchHypernym, effectiveSettings.CreateSearchHypernymSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSearchHypernym);
            Modify_CreateSearchHypernymApiCall(ref _callCreateSearchHypernym);
            _callUpdateSearchHypernym = clientHelper.BuildApiCall<UpdateSearchHypernymRequest, SearchHypernym>("UpdateSearchHypernym", grpcClient.UpdateSearchHypernymAsync, grpcClient.UpdateSearchHypernym, effectiveSettings.UpdateSearchHypernymSettings).WithGoogleRequestParam("search_hypernym.name", request => request.SearchHypernym?.Name);
            Modify_ApiCall(ref _callUpdateSearchHypernym);
            Modify_UpdateSearchHypernymApiCall(ref _callUpdateSearchHypernym);
            _callGetSearchHypernym = clientHelper.BuildApiCall<GetSearchHypernymRequest, SearchHypernym>("GetSearchHypernym", grpcClient.GetSearchHypernymAsync, grpcClient.GetSearchHypernym, effectiveSettings.GetSearchHypernymSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSearchHypernym);
            Modify_GetSearchHypernymApiCall(ref _callGetSearchHypernym);
            _callDeleteSearchHypernym = clientHelper.BuildApiCall<DeleteSearchHypernymRequest, wkt::Empty>("DeleteSearchHypernym", grpcClient.DeleteSearchHypernymAsync, grpcClient.DeleteSearchHypernym, effectiveSettings.DeleteSearchHypernymSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSearchHypernym);
            Modify_DeleteSearchHypernymApiCall(ref _callDeleteSearchHypernym);
            _callListSearchHypernyms = clientHelper.BuildApiCall<ListSearchHypernymsRequest, ListSearchHypernymsResponse>("ListSearchHypernyms", grpcClient.ListSearchHypernymsAsync, grpcClient.ListSearchHypernyms, effectiveSettings.ListSearchHypernymsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSearchHypernyms);
            Modify_ListSearchHypernymsApiCall(ref _callListSearchHypernyms);
            _callSearchAssets = clientHelper.BuildApiCall<SearchAssetsRequest, SearchAssetsResponse>("SearchAssets", grpcClient.SearchAssetsAsync, grpcClient.SearchAssets, effectiveSettings.SearchAssetsSettings).WithGoogleRequestParam("corpus", request => request.Corpus);
            Modify_ApiCall(ref _callSearchAssets);
            Modify_SearchAssetsApiCall(ref _callSearchAssets);
            _callSearchIndexEndpoint = clientHelper.BuildApiCall<SearchIndexEndpointRequest, SearchIndexEndpointResponse>("SearchIndexEndpoint", grpcClient.SearchIndexEndpointAsync, grpcClient.SearchIndexEndpoint, effectiveSettings.SearchIndexEndpointSettings).WithGoogleRequestParam("index_endpoint", request => request.IndexEndpoint);
            Modify_ApiCall(ref _callSearchIndexEndpoint);
            Modify_SearchIndexEndpointApiCall(ref _callSearchIndexEndpoint);
            _callCreateIndexEndpoint = clientHelper.BuildApiCall<CreateIndexEndpointRequest, lro::Operation>("CreateIndexEndpoint", grpcClient.CreateIndexEndpointAsync, grpcClient.CreateIndexEndpoint, effectiveSettings.CreateIndexEndpointSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIndexEndpoint);
            Modify_CreateIndexEndpointApiCall(ref _callCreateIndexEndpoint);
            _callGetIndexEndpoint = clientHelper.BuildApiCall<GetIndexEndpointRequest, IndexEndpoint>("GetIndexEndpoint", grpcClient.GetIndexEndpointAsync, grpcClient.GetIndexEndpoint, effectiveSettings.GetIndexEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIndexEndpoint);
            Modify_GetIndexEndpointApiCall(ref _callGetIndexEndpoint);
            _callListIndexEndpoints = clientHelper.BuildApiCall<ListIndexEndpointsRequest, ListIndexEndpointsResponse>("ListIndexEndpoints", grpcClient.ListIndexEndpointsAsync, grpcClient.ListIndexEndpoints, effectiveSettings.ListIndexEndpointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIndexEndpoints);
            Modify_ListIndexEndpointsApiCall(ref _callListIndexEndpoints);
            _callUpdateIndexEndpoint = clientHelper.BuildApiCall<UpdateIndexEndpointRequest, lro::Operation>("UpdateIndexEndpoint", grpcClient.UpdateIndexEndpointAsync, grpcClient.UpdateIndexEndpoint, effectiveSettings.UpdateIndexEndpointSettings).WithGoogleRequestParam("index_endpoint.name", request => request.IndexEndpoint?.Name);
            Modify_ApiCall(ref _callUpdateIndexEndpoint);
            Modify_UpdateIndexEndpointApiCall(ref _callUpdateIndexEndpoint);
            _callDeleteIndexEndpoint = clientHelper.BuildApiCall<DeleteIndexEndpointRequest, lro::Operation>("DeleteIndexEndpoint", grpcClient.DeleteIndexEndpointAsync, grpcClient.DeleteIndexEndpoint, effectiveSettings.DeleteIndexEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIndexEndpoint);
            Modify_DeleteIndexEndpointApiCall(ref _callDeleteIndexEndpoint);
            _callDeployIndex = clientHelper.BuildApiCall<DeployIndexRequest, lro::Operation>("DeployIndex", grpcClient.DeployIndexAsync, grpcClient.DeployIndex, effectiveSettings.DeployIndexSettings).WithGoogleRequestParam("index_endpoint", request => request.IndexEndpoint);
            Modify_ApiCall(ref _callDeployIndex);
            Modify_DeployIndexApiCall(ref _callDeployIndex);
            _callUndeployIndex = clientHelper.BuildApiCall<UndeployIndexRequest, lro::Operation>("UndeployIndex", grpcClient.UndeployIndexAsync, grpcClient.UndeployIndex, effectiveSettings.UndeployIndexSettings).WithGoogleRequestParam("index_endpoint", request => request.IndexEndpoint);
            Modify_ApiCall(ref _callUndeployIndex);
            Modify_UndeployIndexApiCall(ref _callUndeployIndex);
            _callCreateCollection = clientHelper.BuildApiCall<CreateCollectionRequest, lro::Operation>("CreateCollection", grpcClient.CreateCollectionAsync, grpcClient.CreateCollection, effectiveSettings.CreateCollectionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCollection);
            Modify_CreateCollectionApiCall(ref _callCreateCollection);
            _callDeleteCollection = clientHelper.BuildApiCall<DeleteCollectionRequest, lro::Operation>("DeleteCollection", grpcClient.DeleteCollectionAsync, grpcClient.DeleteCollection, effectiveSettings.DeleteCollectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCollection);
            Modify_DeleteCollectionApiCall(ref _callDeleteCollection);
            _callGetCollection = clientHelper.BuildApiCall<GetCollectionRequest, Collection>("GetCollection", grpcClient.GetCollectionAsync, grpcClient.GetCollection, effectiveSettings.GetCollectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCollection);
            Modify_GetCollectionApiCall(ref _callGetCollection);
            _callUpdateCollection = clientHelper.BuildApiCall<UpdateCollectionRequest, Collection>("UpdateCollection", grpcClient.UpdateCollectionAsync, grpcClient.UpdateCollection, effectiveSettings.UpdateCollectionSettings).WithGoogleRequestParam("collection.name", request => request.Collection?.Name);
            Modify_ApiCall(ref _callUpdateCollection);
            Modify_UpdateCollectionApiCall(ref _callUpdateCollection);
            _callListCollections = clientHelper.BuildApiCall<ListCollectionsRequest, ListCollectionsResponse>("ListCollections", grpcClient.ListCollectionsAsync, grpcClient.ListCollections, effectiveSettings.ListCollectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCollections);
            Modify_ListCollectionsApiCall(ref _callListCollections);
            _callAddCollectionItem = clientHelper.BuildApiCall<AddCollectionItemRequest, AddCollectionItemResponse>("AddCollectionItem", grpcClient.AddCollectionItemAsync, grpcClient.AddCollectionItem, effectiveSettings.AddCollectionItemSettings).WithGoogleRequestParam("item.collection", request => request.Item?.Collection);
            Modify_ApiCall(ref _callAddCollectionItem);
            Modify_AddCollectionItemApiCall(ref _callAddCollectionItem);
            _callRemoveCollectionItem = clientHelper.BuildApiCall<RemoveCollectionItemRequest, RemoveCollectionItemResponse>("RemoveCollectionItem", grpcClient.RemoveCollectionItemAsync, grpcClient.RemoveCollectionItem, effectiveSettings.RemoveCollectionItemSettings).WithGoogleRequestParam("item.collection", request => request.Item?.Collection);
            Modify_ApiCall(ref _callRemoveCollectionItem);
            Modify_RemoveCollectionItemApiCall(ref _callRemoveCollectionItem);
            _callViewCollectionItems = clientHelper.BuildApiCall<ViewCollectionItemsRequest, ViewCollectionItemsResponse>("ViewCollectionItems", grpcClient.ViewCollectionItemsAsync, grpcClient.ViewCollectionItems, effectiveSettings.ViewCollectionItemsSettings).WithGoogleRequestParam("collection", request => request.Collection);
            Modify_ApiCall(ref _callViewCollectionItems);
            Modify_ViewCollectionItemsApiCall(ref _callViewCollectionItems);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateAssetApiCall(ref gaxgrpc::ApiCall<CreateAssetRequest, Asset> call);

        partial void Modify_UpdateAssetApiCall(ref gaxgrpc::ApiCall<UpdateAssetRequest, Asset> call);

        partial void Modify_GetAssetApiCall(ref gaxgrpc::ApiCall<GetAssetRequest, Asset> call);

        partial void Modify_ListAssetsApiCall(ref gaxgrpc::ApiCall<ListAssetsRequest, ListAssetsResponse> call);

        partial void Modify_DeleteAssetApiCall(ref gaxgrpc::ApiCall<DeleteAssetRequest, lro::Operation> call);

        partial void Modify_UploadAssetApiCall(ref gaxgrpc::ApiCall<UploadAssetRequest, lro::Operation> call);

        partial void Modify_GenerateRetrievalUrlApiCall(ref gaxgrpc::ApiCall<GenerateRetrievalUrlRequest, GenerateRetrievalUrlResponse> call);

        partial void Modify_AnalyzeAssetApiCall(ref gaxgrpc::ApiCall<AnalyzeAssetRequest, lro::Operation> call);

        partial void Modify_IndexAssetApiCall(ref gaxgrpc::ApiCall<IndexAssetRequest, lro::Operation> call);

        partial void Modify_RemoveIndexAssetApiCall(ref gaxgrpc::ApiCall<RemoveIndexAssetRequest, lro::Operation> call);

        partial void Modify_ViewIndexedAssetsApiCall(ref gaxgrpc::ApiCall<ViewIndexedAssetsRequest, ViewIndexedAssetsResponse> call);

        partial void Modify_CreateIndexApiCall(ref gaxgrpc::ApiCall<CreateIndexRequest, lro::Operation> call);

        partial void Modify_UpdateIndexApiCall(ref gaxgrpc::ApiCall<UpdateIndexRequest, lro::Operation> call);

        partial void Modify_GetIndexApiCall(ref gaxgrpc::ApiCall<GetIndexRequest, Index> call);

        partial void Modify_ListIndexesApiCall(ref gaxgrpc::ApiCall<ListIndexesRequest, ListIndexesResponse> call);

        partial void Modify_DeleteIndexApiCall(ref gaxgrpc::ApiCall<DeleteIndexRequest, lro::Operation> call);

        partial void Modify_CreateCorpusApiCall(ref gaxgrpc::ApiCall<CreateCorpusRequest, lro::Operation> call);

        partial void Modify_GetCorpusApiCall(ref gaxgrpc::ApiCall<GetCorpusRequest, Corpus> call);

        partial void Modify_UpdateCorpusApiCall(ref gaxgrpc::ApiCall<UpdateCorpusRequest, Corpus> call);

        partial void Modify_ListCorporaApiCall(ref gaxgrpc::ApiCall<ListCorporaRequest, ListCorporaResponse> call);

        partial void Modify_DeleteCorpusApiCall(ref gaxgrpc::ApiCall<DeleteCorpusRequest, wkt::Empty> call);

        partial void Modify_AnalyzeCorpusApiCall(ref gaxgrpc::ApiCall<AnalyzeCorpusRequest, lro::Operation> call);

        partial void Modify_CreateDataSchemaApiCall(ref gaxgrpc::ApiCall<CreateDataSchemaRequest, DataSchema> call);

        partial void Modify_UpdateDataSchemaApiCall(ref gaxgrpc::ApiCall<UpdateDataSchemaRequest, DataSchema> call);

        partial void Modify_GetDataSchemaApiCall(ref gaxgrpc::ApiCall<GetDataSchemaRequest, DataSchema> call);

        partial void Modify_DeleteDataSchemaApiCall(ref gaxgrpc::ApiCall<DeleteDataSchemaRequest, wkt::Empty> call);

        partial void Modify_ListDataSchemasApiCall(ref gaxgrpc::ApiCall<ListDataSchemasRequest, ListDataSchemasResponse> call);

        partial void Modify_CreateAnnotationApiCall(ref gaxgrpc::ApiCall<CreateAnnotationRequest, Annotation> call);

        partial void Modify_GetAnnotationApiCall(ref gaxgrpc::ApiCall<GetAnnotationRequest, Annotation> call);

        partial void Modify_ListAnnotationsApiCall(ref gaxgrpc::ApiCall<ListAnnotationsRequest, ListAnnotationsResponse> call);

        partial void Modify_UpdateAnnotationApiCall(ref gaxgrpc::ApiCall<UpdateAnnotationRequest, Annotation> call);

        partial void Modify_DeleteAnnotationApiCall(ref gaxgrpc::ApiCall<DeleteAnnotationRequest, wkt::Empty> call);

        partial void Modify_IngestAssetApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<IngestAssetRequest, IngestAssetResponse> call);

        partial void Modify_ClipAssetApiCall(ref gaxgrpc::ApiCall<ClipAssetRequest, ClipAssetResponse> call);

        partial void Modify_GenerateHlsUriApiCall(ref gaxgrpc::ApiCall<GenerateHlsUriRequest, GenerateHlsUriResponse> call);

        partial void Modify_ImportAssetsApiCall(ref gaxgrpc::ApiCall<ImportAssetsRequest, lro::Operation> call);

        partial void Modify_CreateSearchConfigApiCall(ref gaxgrpc::ApiCall<CreateSearchConfigRequest, SearchConfig> call);

        partial void Modify_UpdateSearchConfigApiCall(ref gaxgrpc::ApiCall<UpdateSearchConfigRequest, SearchConfig> call);

        partial void Modify_GetSearchConfigApiCall(ref gaxgrpc::ApiCall<GetSearchConfigRequest, SearchConfig> call);

        partial void Modify_DeleteSearchConfigApiCall(ref gaxgrpc::ApiCall<DeleteSearchConfigRequest, wkt::Empty> call);

        partial void Modify_ListSearchConfigsApiCall(ref gaxgrpc::ApiCall<ListSearchConfigsRequest, ListSearchConfigsResponse> call);

        partial void Modify_CreateSearchHypernymApiCall(ref gaxgrpc::ApiCall<CreateSearchHypernymRequest, SearchHypernym> call);

        partial void Modify_UpdateSearchHypernymApiCall(ref gaxgrpc::ApiCall<UpdateSearchHypernymRequest, SearchHypernym> call);

        partial void Modify_GetSearchHypernymApiCall(ref gaxgrpc::ApiCall<GetSearchHypernymRequest, SearchHypernym> call);

        partial void Modify_DeleteSearchHypernymApiCall(ref gaxgrpc::ApiCall<DeleteSearchHypernymRequest, wkt::Empty> call);

        partial void Modify_ListSearchHypernymsApiCall(ref gaxgrpc::ApiCall<ListSearchHypernymsRequest, ListSearchHypernymsResponse> call);

        partial void Modify_SearchAssetsApiCall(ref gaxgrpc::ApiCall<SearchAssetsRequest, SearchAssetsResponse> call);

        partial void Modify_SearchIndexEndpointApiCall(ref gaxgrpc::ApiCall<SearchIndexEndpointRequest, SearchIndexEndpointResponse> call);

        partial void Modify_CreateIndexEndpointApiCall(ref gaxgrpc::ApiCall<CreateIndexEndpointRequest, lro::Operation> call);

        partial void Modify_GetIndexEndpointApiCall(ref gaxgrpc::ApiCall<GetIndexEndpointRequest, IndexEndpoint> call);

        partial void Modify_ListIndexEndpointsApiCall(ref gaxgrpc::ApiCall<ListIndexEndpointsRequest, ListIndexEndpointsResponse> call);

        partial void Modify_UpdateIndexEndpointApiCall(ref gaxgrpc::ApiCall<UpdateIndexEndpointRequest, lro::Operation> call);

        partial void Modify_DeleteIndexEndpointApiCall(ref gaxgrpc::ApiCall<DeleteIndexEndpointRequest, lro::Operation> call);

        partial void Modify_DeployIndexApiCall(ref gaxgrpc::ApiCall<DeployIndexRequest, lro::Operation> call);

        partial void Modify_UndeployIndexApiCall(ref gaxgrpc::ApiCall<UndeployIndexRequest, lro::Operation> call);

        partial void Modify_CreateCollectionApiCall(ref gaxgrpc::ApiCall<CreateCollectionRequest, lro::Operation> call);

        partial void Modify_DeleteCollectionApiCall(ref gaxgrpc::ApiCall<DeleteCollectionRequest, lro::Operation> call);

        partial void Modify_GetCollectionApiCall(ref gaxgrpc::ApiCall<GetCollectionRequest, Collection> call);

        partial void Modify_UpdateCollectionApiCall(ref gaxgrpc::ApiCall<UpdateCollectionRequest, Collection> call);

        partial void Modify_ListCollectionsApiCall(ref gaxgrpc::ApiCall<ListCollectionsRequest, ListCollectionsResponse> call);

        partial void Modify_AddCollectionItemApiCall(ref gaxgrpc::ApiCall<AddCollectionItemRequest, AddCollectionItemResponse> call);

        partial void Modify_RemoveCollectionItemApiCall(ref gaxgrpc::ApiCall<RemoveCollectionItemRequest, RemoveCollectionItemResponse> call);

        partial void Modify_ViewCollectionItemsApiCall(ref gaxgrpc::ApiCall<ViewCollectionItemsRequest, ViewCollectionItemsResponse> call);

        partial void OnConstruction(Warehouse.WarehouseClient grpcClient, WarehouseSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Warehouse client</summary>
        public override Warehouse.WarehouseClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateAssetRequest(ref CreateAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAssetRequest(ref UpdateAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAssetRequest(ref GetAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAssetsRequest(ref ListAssetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAssetRequest(ref DeleteAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UploadAssetRequest(ref UploadAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateRetrievalUrlRequest(ref GenerateRetrievalUrlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnalyzeAssetRequest(ref AnalyzeAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_IndexAssetRequest(ref IndexAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveIndexAssetRequest(ref RemoveIndexAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ViewIndexedAssetsRequest(ref ViewIndexedAssetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateIndexRequest(ref CreateIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateIndexRequest(ref UpdateIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIndexRequest(ref GetIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIndexesRequest(ref ListIndexesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIndexRequest(ref DeleteIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCorpusRequest(ref CreateCorpusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCorpusRequest(ref GetCorpusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCorpusRequest(ref UpdateCorpusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCorporaRequest(ref ListCorporaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCorpusRequest(ref DeleteCorpusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnalyzeCorpusRequest(ref AnalyzeCorpusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDataSchemaRequest(ref CreateDataSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataSchemaRequest(ref UpdateDataSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataSchemaRequest(ref GetDataSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataSchemaRequest(ref DeleteDataSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataSchemasRequest(ref ListDataSchemasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAnnotationRequest(ref CreateAnnotationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnnotationRequest(ref GetAnnotationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAnnotationsRequest(ref ListAnnotationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAnnotationRequest(ref UpdateAnnotationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAnnotationRequest(ref DeleteAnnotationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_IngestAssetRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_IngestAssetRequestRequest(ref IngestAssetRequest request);

        partial void Modify_ClipAssetRequest(ref ClipAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateHlsUriRequest(ref GenerateHlsUriRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportAssetsRequest(ref ImportAssetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSearchConfigRequest(ref CreateSearchConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSearchConfigRequest(ref UpdateSearchConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSearchConfigRequest(ref GetSearchConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSearchConfigRequest(ref DeleteSearchConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSearchConfigsRequest(ref ListSearchConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSearchHypernymRequest(ref CreateSearchHypernymRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSearchHypernymRequest(ref UpdateSearchHypernymRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSearchHypernymRequest(ref GetSearchHypernymRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSearchHypernymRequest(ref DeleteSearchHypernymRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSearchHypernymsRequest(ref ListSearchHypernymsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchAssetsRequest(ref SearchAssetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchIndexEndpointRequest(ref SearchIndexEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateIndexEndpointRequest(ref CreateIndexEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIndexEndpointRequest(ref GetIndexEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIndexEndpointsRequest(ref ListIndexEndpointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateIndexEndpointRequest(ref UpdateIndexEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIndexEndpointRequest(ref DeleteIndexEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeployIndexRequest(ref DeployIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeployIndexRequest(ref UndeployIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCollectionRequest(ref CreateCollectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCollectionRequest(ref DeleteCollectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCollectionRequest(ref GetCollectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCollectionRequest(ref UpdateCollectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCollectionsRequest(ref ListCollectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddCollectionItemRequest(ref AddCollectionItemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveCollectionItemRequest(ref RemoveCollectionItemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ViewCollectionItemsRequest(ref ViewCollectionItemsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Asset CreateAsset(CreateAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssetRequest(ref request, ref callSettings);
            return _callCreateAsset.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Asset> CreateAssetAsync(CreateAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssetRequest(ref request, ref callSettings);
            return _callCreateAsset.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Asset UpdateAsset(UpdateAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAssetRequest(ref request, ref callSettings);
            return _callUpdateAsset.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Asset> UpdateAssetAsync(UpdateAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAssetRequest(ref request, ref callSettings);
            return _callUpdateAsset.Async(request, callSettings);
        }

        /// <summary>
        /// Reads an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Asset GetAsset(GetAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssetRequest(ref request, ref callSettings);
            return _callGetAsset.Sync(request, callSettings);
        }

        /// <summary>
        /// Reads an asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Asset> GetAssetAsync(GetAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssetRequest(ref request, ref callSettings);
            return _callGetAsset.Async(request, callSettings);
        }

        /// <summary>
        /// Lists an list of assets inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Asset"/> resources.</returns>
        public override gax::PagedEnumerable<ListAssetsResponse, Asset> ListAssets(ListAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAssetsRequest, ListAssetsResponse, Asset>(_callListAssets, request, callSettings);
        }

        /// <summary>
        /// Lists an list of assets inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Asset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAssetsResponse, Asset> ListAssetsAsync(ListAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAssetsRequest, ListAssetsResponse, Asset>(_callListAssets, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteAsset</c>.</summary>
        public override lro::OperationsClient DeleteAssetOperationsClient { get; }

        /// <summary>
        /// Deletes asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteAssetMetadata> DeleteAsset(DeleteAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAssetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteAssetMetadata>(_callDeleteAsset.Sync(request, callSettings), DeleteAssetOperationsClient);
        }

        /// <summary>
        /// Deletes asset inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteAssetMetadata>> DeleteAssetAsync(DeleteAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAssetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteAssetMetadata>(await _callDeleteAsset.Async(request, callSettings).ConfigureAwait(false), DeleteAssetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UploadAsset</c>.</summary>
        public override lro::OperationsClient UploadAssetOperationsClient { get; }

        /// <summary>
        /// Upload asset by specifing the asset Cloud Storage uri.
        /// For video warehouse, it requires users who call this API have read access
        /// to the cloud storage file. Once it is uploaded, it can be retrieved by
        /// GenerateRetrievalUrl API which by default, only can retrieve cloud storage
        /// files from the same project of the warehouse. To allow retrieval cloud
        /// storage files that are in a separate project, it requires to find the
        /// vision ai service account (Go to IAM, check checkbox to show "Include
        /// Google-provided role grants", search for "Cloud Vision AI Service Agent")
        /// and grant the read access of the cloud storage files to that service
        /// account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UploadAssetResponse, UploadAssetMetadata> UploadAsset(UploadAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadAssetRequest(ref request, ref callSettings);
            return new lro::Operation<UploadAssetResponse, UploadAssetMetadata>(_callUploadAsset.Sync(request, callSettings), UploadAssetOperationsClient);
        }

        /// <summary>
        /// Upload asset by specifing the asset Cloud Storage uri.
        /// For video warehouse, it requires users who call this API have read access
        /// to the cloud storage file. Once it is uploaded, it can be retrieved by
        /// GenerateRetrievalUrl API which by default, only can retrieve cloud storage
        /// files from the same project of the warehouse. To allow retrieval cloud
        /// storage files that are in a separate project, it requires to find the
        /// vision ai service account (Go to IAM, check checkbox to show "Include
        /// Google-provided role grants", search for "Cloud Vision AI Service Agent")
        /// and grant the read access of the cloud storage files to that service
        /// account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UploadAssetResponse, UploadAssetMetadata>> UploadAssetAsync(UploadAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadAssetRequest(ref request, ref callSettings);
            return new lro::Operation<UploadAssetResponse, UploadAssetMetadata>(await _callUploadAsset.Async(request, callSettings).ConfigureAwait(false), UploadAssetOperationsClient);
        }

        /// <summary>
        /// Generates a signed url for downloading the asset.
        /// For video warehouse, please see comment of UploadAsset about how to allow
        /// retrieval of cloud storage files in a different project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateRetrievalUrlResponse GenerateRetrievalUrl(GenerateRetrievalUrlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateRetrievalUrlRequest(ref request, ref callSettings);
            return _callGenerateRetrievalUrl.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a signed url for downloading the asset.
        /// For video warehouse, please see comment of UploadAsset about how to allow
        /// retrieval of cloud storage files in a different project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateRetrievalUrlResponse> GenerateRetrievalUrlAsync(GenerateRetrievalUrlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateRetrievalUrlRequest(ref request, ref callSettings);
            return _callGenerateRetrievalUrl.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>AnalyzeAsset</c>.</summary>
        public override lro::OperationsClient AnalyzeAssetOperationsClient { get; }

        /// <summary>
        /// Analyze asset to power search capability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AnalyzeAssetResponse, AnalyzeAssetMetadata> AnalyzeAsset(AnalyzeAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeAssetRequest(ref request, ref callSettings);
            return new lro::Operation<AnalyzeAssetResponse, AnalyzeAssetMetadata>(_callAnalyzeAsset.Sync(request, callSettings), AnalyzeAssetOperationsClient);
        }

        /// <summary>
        /// Analyze asset to power search capability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AnalyzeAssetResponse, AnalyzeAssetMetadata>> AnalyzeAssetAsync(AnalyzeAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeAssetRequest(ref request, ref callSettings);
            return new lro::Operation<AnalyzeAssetResponse, AnalyzeAssetMetadata>(await _callAnalyzeAsset.Async(request, callSettings).ConfigureAwait(false), AnalyzeAssetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>IndexAsset</c>.</summary>
        public override lro::OperationsClient IndexAssetOperationsClient { get; }

        /// <summary>
        /// Index one asset for search.
        /// Supported corpus type: Corpus.Type.VIDEO_ON_DEMAND
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<IndexAssetResponse, IndexAssetMetadata> IndexAsset(IndexAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IndexAssetRequest(ref request, ref callSettings);
            return new lro::Operation<IndexAssetResponse, IndexAssetMetadata>(_callIndexAsset.Sync(request, callSettings), IndexAssetOperationsClient);
        }

        /// <summary>
        /// Index one asset for search.
        /// Supported corpus type: Corpus.Type.VIDEO_ON_DEMAND
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<IndexAssetResponse, IndexAssetMetadata>> IndexAssetAsync(IndexAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IndexAssetRequest(ref request, ref callSettings);
            return new lro::Operation<IndexAssetResponse, IndexAssetMetadata>(await _callIndexAsset.Async(request, callSettings).ConfigureAwait(false), IndexAssetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveIndexAsset</c>.</summary>
        public override lro::OperationsClient RemoveIndexAssetOperationsClient { get; }

        /// <summary>
        /// Remove one asset's index data for search.
        /// Supported corpus type: Corpus.Type.VIDEO_ON_DEMAND
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RemoveIndexAssetResponse, RemoveIndexAssetMetadata> RemoveIndexAsset(RemoveIndexAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveIndexAssetRequest(ref request, ref callSettings);
            return new lro::Operation<RemoveIndexAssetResponse, RemoveIndexAssetMetadata>(_callRemoveIndexAsset.Sync(request, callSettings), RemoveIndexAssetOperationsClient);
        }

        /// <summary>
        /// Remove one asset's index data for search.
        /// Supported corpus type: Corpus.Type.VIDEO_ON_DEMAND
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RemoveIndexAssetResponse, RemoveIndexAssetMetadata>> RemoveIndexAssetAsync(RemoveIndexAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveIndexAssetRequest(ref request, ref callSettings);
            return new lro::Operation<RemoveIndexAssetResponse, RemoveIndexAssetMetadata>(await _callRemoveIndexAsset.Async(request, callSettings).ConfigureAwait(false), RemoveIndexAssetOperationsClient);
        }

        /// <summary>
        /// Lists assets inside an index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IndexedAsset"/> resources.</returns>
        public override gax::PagedEnumerable<ViewIndexedAssetsResponse, IndexedAsset> ViewIndexedAssets(ViewIndexedAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ViewIndexedAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ViewIndexedAssetsRequest, ViewIndexedAssetsResponse, IndexedAsset>(_callViewIndexedAssets, request, callSettings);
        }

        /// <summary>
        /// Lists assets inside an index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IndexedAsset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ViewIndexedAssetsResponse, IndexedAsset> ViewIndexedAssetsAsync(ViewIndexedAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ViewIndexedAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ViewIndexedAssetsRequest, ViewIndexedAssetsResponse, IndexedAsset>(_callViewIndexedAssets, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateIndex</c>.</summary>
        public override lro::OperationsClient CreateIndexOperationsClient { get; }

        /// <summary>
        /// Creates an Index under the corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Index, CreateIndexMetadata> CreateIndex(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, CreateIndexMetadata>(_callCreateIndex.Sync(request, callSettings), CreateIndexOperationsClient);
        }

        /// <summary>
        /// Creates an Index under the corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Index, CreateIndexMetadata>> CreateIndexAsync(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, CreateIndexMetadata>(await _callCreateIndex.Async(request, callSettings).ConfigureAwait(false), CreateIndexOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateIndex</c>.</summary>
        public override lro::OperationsClient UpdateIndexOperationsClient { get; }

        /// <summary>
        /// Updates an Index under the corpus.
        /// Users can perform a metadata-only update or trigger a full index rebuild
        /// with different update_mask values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Index, UpdateIndexMetadata> UpdateIndex(UpdateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, UpdateIndexMetadata>(_callUpdateIndex.Sync(request, callSettings), UpdateIndexOperationsClient);
        }

        /// <summary>
        /// Updates an Index under the corpus.
        /// Users can perform a metadata-only update or trigger a full index rebuild
        /// with different update_mask values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Index, UpdateIndexMetadata>> UpdateIndexAsync(UpdateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, UpdateIndexMetadata>(await _callUpdateIndex.Async(request, callSettings).ConfigureAwait(false), UpdateIndexOperationsClient);
        }

        /// <summary>
        /// Gets the details of a single Index under a Corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Index GetIndex(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexRequest(ref request, ref callSettings);
            return _callGetIndex.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a single Index under a Corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Index> GetIndexAsync(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexRequest(ref request, ref callSettings);
            return _callGetIndex.Async(request, callSettings);
        }

        /// <summary>
        /// List all Indexes in a given Corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public override gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIndexesRequest, ListIndexesResponse, Index>(_callListIndexes, request, callSettings);
        }

        /// <summary>
        /// List all Indexes in a given Corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIndexesRequest, ListIndexesResponse, Index>(_callListIndexes, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteIndex</c>.</summary>
        public override lro::OperationsClient DeleteIndexOperationsClient { get; }

        /// <summary>
        /// Delete a single Index. In order to delete an index, the caller must
        /// make sure that it is not deployed to any index endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteIndexMetadata> DeleteIndex(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteIndexMetadata>(_callDeleteIndex.Sync(request, callSettings), DeleteIndexOperationsClient);
        }

        /// <summary>
        /// Delete a single Index. In order to delete an index, the caller must
        /// make sure that it is not deployed to any index endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteIndexMetadata>> DeleteIndexAsync(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteIndexMetadata>(await _callDeleteIndex.Async(request, callSettings).ConfigureAwait(false), DeleteIndexOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateCorpus</c>.</summary>
        public override lro::OperationsClient CreateCorpusOperationsClient { get; }

        /// <summary>
        /// Creates a corpus inside a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Corpus, CreateCorpusMetadata> CreateCorpus(CreateCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCorpusRequest(ref request, ref callSettings);
            return new lro::Operation<Corpus, CreateCorpusMetadata>(_callCreateCorpus.Sync(request, callSettings), CreateCorpusOperationsClient);
        }

        /// <summary>
        /// Creates a corpus inside a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Corpus, CreateCorpusMetadata>> CreateCorpusAsync(CreateCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCorpusRequest(ref request, ref callSettings);
            return new lro::Operation<Corpus, CreateCorpusMetadata>(await _callCreateCorpus.Async(request, callSettings).ConfigureAwait(false), CreateCorpusOperationsClient);
        }

        /// <summary>
        /// Gets corpus details inside a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Corpus GetCorpus(GetCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCorpusRequest(ref request, ref callSettings);
            return _callGetCorpus.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets corpus details inside a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Corpus> GetCorpusAsync(GetCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCorpusRequest(ref request, ref callSettings);
            return _callGetCorpus.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a corpus in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Corpus UpdateCorpus(UpdateCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCorpusRequest(ref request, ref callSettings);
            return _callUpdateCorpus.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a corpus in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Corpus> UpdateCorpusAsync(UpdateCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCorpusRequest(ref request, ref callSettings);
            return _callUpdateCorpus.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all corpora in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Corpus"/> resources.</returns>
        public override gax::PagedEnumerable<ListCorporaResponse, Corpus> ListCorpora(ListCorporaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCorporaRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCorporaRequest, ListCorporaResponse, Corpus>(_callListCorpora, request, callSettings);
        }

        /// <summary>
        /// Lists all corpora in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Corpus"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCorporaResponse, Corpus> ListCorporaAsync(ListCorporaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCorporaRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCorporaRequest, ListCorporaResponse, Corpus>(_callListCorpora, request, callSettings);
        }

        /// <summary>
        /// Deletes a corpus only if its empty.
        /// Returns empty response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCorpus(DeleteCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCorpusRequest(ref request, ref callSettings);
            _callDeleteCorpus.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a corpus only if its empty.
        /// Returns empty response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCorpusAsync(DeleteCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCorpusRequest(ref request, ref callSettings);
            return _callDeleteCorpus.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>AnalyzeCorpus</c>.</summary>
        public override lro::OperationsClient AnalyzeCorpusOperationsClient { get; }

        /// <summary>
        /// Analyzes a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AnalyzeCorpusResponse, AnalyzeCorpusMetadata> AnalyzeCorpus(AnalyzeCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeCorpusRequest(ref request, ref callSettings);
            return new lro::Operation<AnalyzeCorpusResponse, AnalyzeCorpusMetadata>(_callAnalyzeCorpus.Sync(request, callSettings), AnalyzeCorpusOperationsClient);
        }

        /// <summary>
        /// Analyzes a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AnalyzeCorpusResponse, AnalyzeCorpusMetadata>> AnalyzeCorpusAsync(AnalyzeCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeCorpusRequest(ref request, ref callSettings);
            return new lro::Operation<AnalyzeCorpusResponse, AnalyzeCorpusMetadata>(await _callAnalyzeCorpus.Async(request, callSettings).ConfigureAwait(false), AnalyzeCorpusOperationsClient);
        }

        /// <summary>
        /// Creates data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataSchema CreateDataSchema(CreateDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataSchemaRequest(ref request, ref callSettings);
            return _callCreateDataSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataSchema> CreateDataSchemaAsync(CreateDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataSchemaRequest(ref request, ref callSettings);
            return _callCreateDataSchema.Async(request, callSettings);
        }

        /// <summary>
        /// Updates data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataSchema UpdateDataSchema(UpdateDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataSchemaRequest(ref request, ref callSettings);
            return _callUpdateDataSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataSchema> UpdateDataSchemaAsync(UpdateDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataSchemaRequest(ref request, ref callSettings);
            return _callUpdateDataSchema.Async(request, callSettings);
        }

        /// <summary>
        /// Gets data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataSchema GetDataSchema(GetDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSchemaRequest(ref request, ref callSettings);
            return _callGetDataSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataSchema> GetDataSchemaAsync(GetDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSchemaRequest(ref request, ref callSettings);
            return _callGetDataSchema.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDataSchema(DeleteDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataSchemaRequest(ref request, ref callSettings);
            _callDeleteDataSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes data schema inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDataSchemaAsync(DeleteDataSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataSchemaRequest(ref request, ref callSettings);
            return _callDeleteDataSchema.Async(request, callSettings);
        }

        /// <summary>
        /// Lists a list of data schemas inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataSchema"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataSchemasResponse, DataSchema> ListDataSchemas(ListDataSchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataSchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataSchemasRequest, ListDataSchemasResponse, DataSchema>(_callListDataSchemas, request, callSettings);
        }

        /// <summary>
        /// Lists a list of data schemas inside corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataSchema"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataSchemasResponse, DataSchema> ListDataSchemasAsync(ListDataSchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataSchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataSchemasRequest, ListDataSchemasResponse, DataSchema>(_callListDataSchemas, request, callSettings);
        }

        /// <summary>
        /// Creates annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Annotation CreateAnnotation(CreateAnnotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnnotationRequest(ref request, ref callSettings);
            return _callCreateAnnotation.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Annotation> CreateAnnotationAsync(CreateAnnotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnnotationRequest(ref request, ref callSettings);
            return _callCreateAnnotation.Async(request, callSettings);
        }

        /// <summary>
        /// Reads annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Annotation GetAnnotation(GetAnnotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnnotationRequest(ref request, ref callSettings);
            return _callGetAnnotation.Sync(request, callSettings);
        }

        /// <summary>
        /// Reads annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Annotation> GetAnnotationAsync(GetAnnotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnnotationRequest(ref request, ref callSettings);
            return _callGetAnnotation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists a list of annotations inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Annotation"/> resources.</returns>
        public override gax::PagedEnumerable<ListAnnotationsResponse, Annotation> ListAnnotations(ListAnnotationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnnotationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnnotationsRequest, ListAnnotationsResponse, Annotation>(_callListAnnotations, request, callSettings);
        }

        /// <summary>
        /// Lists a list of annotations inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Annotation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> ListAnnotationsAsync(ListAnnotationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnnotationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnnotationsRequest, ListAnnotationsResponse, Annotation>(_callListAnnotations, request, callSettings);
        }

        /// <summary>
        /// Updates annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Annotation UpdateAnnotation(UpdateAnnotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAnnotationRequest(ref request, ref callSettings);
            return _callUpdateAnnotation.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Annotation> UpdateAnnotationAsync(UpdateAnnotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAnnotationRequest(ref request, ref callSettings);
            return _callUpdateAnnotation.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAnnotation(DeleteAnnotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnnotationRequest(ref request, ref callSettings);
            _callDeleteAnnotation.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes annotation inside asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAnnotationAsync(DeleteAnnotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnnotationRequest(ref request, ref callSettings);
            return _callDeleteAnnotation.Async(request, callSettings);
        }

        internal sealed partial class IngestAssetStreamImpl : IngestAssetStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>IngestAsset</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{IngestAssetRequest}"/> instance associated with this
            /// streaming call.
            /// </param>
            public IngestAssetStreamImpl(WarehouseClientImpl service, grpccore::AsyncDuplexStreamingCall<IngestAssetRequest, IngestAssetResponse> call, gaxgrpc::BufferedClientStreamWriter<IngestAssetRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private WarehouseClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<IngestAssetRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<IngestAssetRequest, IngestAssetResponse> GrpcCall { get; }

            private IngestAssetRequest ModifyRequest(IngestAssetRequest request)
            {
                _service.Modify_IngestAssetRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(IngestAssetRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(IngestAssetRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(IngestAssetRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(IngestAssetRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Ingests data for the asset. It is not allowed to ingest a data chunk which
        /// is already expired according to TTL.
        /// This method is only available via the gRPC API (not HTTP since
        /// bi-directional streaming is not supported via HTTP).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override WarehouseClient.IngestAssetStream IngestAsset(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_IngestAssetRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callIngestAsset.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<IngestAssetRequest, IngestAssetResponse> call = _callIngestAsset.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<IngestAssetRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<IngestAssetRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new IngestAssetStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// Supported by STREAM_VIDEO corpus type.
        /// Generates clips for downloading. The api takes in a time range, and
        /// generates a clip of the first content available after start_time and
        /// before end_time, which may overflow beyond these bounds.
        /// Returned clips are truncated if the total size of the clips are larger
        /// than 100MB.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ClipAssetResponse ClipAsset(ClipAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClipAssetRequest(ref request, ref callSettings);
            return _callClipAsset.Sync(request, callSettings);
        }

        /// <summary>
        /// Supported by STREAM_VIDEO corpus type.
        /// Generates clips for downloading. The api takes in a time range, and
        /// generates a clip of the first content available after start_time and
        /// before end_time, which may overflow beyond these bounds.
        /// Returned clips are truncated if the total size of the clips are larger
        /// than 100MB.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ClipAssetResponse> ClipAssetAsync(ClipAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClipAssetRequest(ref request, ref callSettings);
            return _callClipAsset.Async(request, callSettings);
        }

        /// <summary>
        /// Generates a uri for an HLS manifest. The api takes in a collection of time
        /// ranges, and generates a URI for an HLS manifest that covers all the
        /// requested time ranges.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateHlsUriResponse GenerateHlsUri(GenerateHlsUriRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateHlsUriRequest(ref request, ref callSettings);
            return _callGenerateHlsUri.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a uri for an HLS manifest. The api takes in a collection of time
        /// ranges, and generates a URI for an HLS manifest that covers all the
        /// requested time ranges.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateHlsUriResponse> GenerateHlsUriAsync(GenerateHlsUriRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateHlsUriRequest(ref request, ref callSettings);
            return _callGenerateHlsUri.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportAssets</c>.</summary>
        public override lro::OperationsClient ImportAssetsOperationsClient { get; }

        /// <summary>
        /// Imports assets (images plus annotations) from a meta file on cloud storage.
        /// Each row in the meta file is corresponding to an image (specified by a
        /// cloud storage uri) and its annotations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportAssetsResponse, ImportAssetsMetadata> ImportAssets(ImportAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAssetsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportAssetsResponse, ImportAssetsMetadata>(_callImportAssets.Sync(request, callSettings), ImportAssetsOperationsClient);
        }

        /// <summary>
        /// Imports assets (images plus annotations) from a meta file on cloud storage.
        /// Each row in the meta file is corresponding to an image (specified by a
        /// cloud storage uri) and its annotations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportAssetsResponse, ImportAssetsMetadata>> ImportAssetsAsync(ImportAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAssetsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportAssetsResponse, ImportAssetsMetadata>(await _callImportAssets.Async(request, callSettings).ConfigureAwait(false), ImportAssetsOperationsClient);
        }

        /// <summary>
        /// Creates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid CreateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_config_id must not be associated with an existing
        /// SearchConfig.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchConfig CreateSearchConfig(CreateSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSearchConfigRequest(ref request, ref callSettings);
            return _callCreateSearchConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid CreateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_config_id must not be associated with an existing
        /// SearchConfig.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchConfig> CreateSearchConfigAsync(CreateSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSearchConfigRequest(ref request, ref callSettings);
            return _callCreateSearchConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid UpdateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_configuration.name must already exist.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchConfig UpdateSearchConfig(UpdateSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSearchConfigRequest(ref request, ref callSettings);
            return _callUpdateSearchConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a search configuration inside a corpus.
        /// 
        /// Please follow the rules below to create a valid UpdateSearchConfigRequest.
        /// --- General Rules ---
        /// 1. Request.search_configuration.name must already exist.
        /// 2. Request must contain at least one non-empty search_criteria_property or
        /// facet_property.
        /// 3. mapped_fields must not be empty, and must map to existing UGA keys.
        /// 4. All mapped_fields must be of the same type.
        /// 5. All mapped_fields must share the same granularity.
        /// 6. All mapped_fields must share the same semantic SearchConfig match
        /// options.
        /// For property-specific rules, please reference the comments for
        /// FacetProperty and SearchCriteriaProperty.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchConfig> UpdateSearchConfigAsync(UpdateSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSearchConfigRequest(ref request, ref callSettings);
            return _callUpdateSearchConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a search configuration inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchConfig GetSearchConfig(GetSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSearchConfigRequest(ref request, ref callSettings);
            return _callGetSearchConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a search configuration inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchConfig> GetSearchConfigAsync(GetSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSearchConfigRequest(ref request, ref callSettings);
            return _callGetSearchConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a search configuration inside a corpus.
        /// 
        /// For a DeleteSearchConfigRequest to be valid,
        /// Request.search_configuration.name must already exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSearchConfig(DeleteSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSearchConfigRequest(ref request, ref callSettings);
            _callDeleteSearchConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a search configuration inside a corpus.
        /// 
        /// For a DeleteSearchConfigRequest to be valid,
        /// Request.search_configuration.name must already exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSearchConfigAsync(DeleteSearchConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSearchConfigRequest(ref request, ref callSettings);
            return _callDeleteSearchConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all search configurations inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListSearchConfigsResponse, SearchConfig> ListSearchConfigs(ListSearchConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSearchConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSearchConfigsRequest, ListSearchConfigsResponse, SearchConfig>(_callListSearchConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists all search configurations inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSearchConfigsResponse, SearchConfig> ListSearchConfigsAsync(ListSearchConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSearchConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSearchConfigsRequest, ListSearchConfigsResponse, SearchConfig>(_callListSearchConfigs, request, callSettings);
        }

        /// <summary>
        /// Creates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchHypernym CreateSearchHypernym(CreateSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSearchHypernymRequest(ref request, ref callSettings);
            return _callCreateSearchHypernym.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchHypernym> CreateSearchHypernymAsync(CreateSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSearchHypernymRequest(ref request, ref callSettings);
            return _callCreateSearchHypernym.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchHypernym UpdateSearchHypernym(UpdateSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSearchHypernymRequest(ref request, ref callSettings);
            return _callUpdateSearchHypernym.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchHypernym> UpdateSearchHypernymAsync(UpdateSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSearchHypernymRequest(ref request, ref callSettings);
            return _callUpdateSearchHypernym.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchHypernym GetSearchHypernym(GetSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSearchHypernymRequest(ref request, ref callSettings);
            return _callGetSearchHypernym.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchHypernym> GetSearchHypernymAsync(GetSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSearchHypernymRequest(ref request, ref callSettings);
            return _callGetSearchHypernym.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSearchHypernym(DeleteSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSearchHypernymRequest(ref request, ref callSettings);
            _callDeleteSearchHypernym.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a SearchHypernym inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSearchHypernymAsync(DeleteSearchHypernymRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSearchHypernymRequest(ref request, ref callSettings);
            return _callDeleteSearchHypernym.Async(request, callSettings);
        }

        /// <summary>
        /// Lists SearchHypernyms inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchHypernym"/> resources.</returns>
        public override gax::PagedEnumerable<ListSearchHypernymsResponse, SearchHypernym> ListSearchHypernyms(ListSearchHypernymsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSearchHypernymsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSearchHypernymsRequest, ListSearchHypernymsResponse, SearchHypernym>(_callListSearchHypernyms, request, callSettings);
        }

        /// <summary>
        /// Lists SearchHypernyms inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchHypernym"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSearchHypernymsResponse, SearchHypernym> ListSearchHypernymsAsync(ListSearchHypernymsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSearchHypernymsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSearchHypernymsRequest, ListSearchHypernymsResponse, SearchHypernym>(_callListSearchHypernyms, request, callSettings);
        }

        /// <summary>
        /// Search media asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchResultItem"/> resources.</returns>
        public override gax::PagedEnumerable<SearchAssetsResponse, SearchResultItem> SearchAssets(SearchAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchAssetsRequest, SearchAssetsResponse, SearchResultItem>(_callSearchAssets, request, callSettings);
        }

        /// <summary>
        /// Search media asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchResultItem"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchAssetsResponse, SearchResultItem> SearchAssetsAsync(SearchAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchAssetsRequest, SearchAssetsResponse, SearchResultItem>(_callSearchAssets, request, callSettings);
        }

        /// <summary>
        /// Search a deployed index endpoint (IMAGE corpus type only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchResultItem"/> resources.</returns>
        public override gax::PagedEnumerable<SearchIndexEndpointResponse, SearchResultItem> SearchIndexEndpoint(SearchIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchIndexEndpointRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchIndexEndpointRequest, SearchIndexEndpointResponse, SearchResultItem>(_callSearchIndexEndpoint, request, callSettings);
        }

        /// <summary>
        /// Search a deployed index endpoint (IMAGE corpus type only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchResultItem"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchIndexEndpointResponse, SearchResultItem> SearchIndexEndpointAsync(SearchIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchIndexEndpointRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchIndexEndpointRequest, SearchIndexEndpointResponse, SearchResultItem>(_callSearchIndexEndpoint, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateIndexEndpoint</c>.</summary>
        public override lro::OperationsClient CreateIndexEndpointOperationsClient { get; }

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata> CreateIndexEndpoint(CreateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata>(_callCreateIndexEndpoint.Sync(request, callSettings), CreateIndexEndpointOperationsClient);
        }

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata>> CreateIndexEndpointAsync(CreateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<IndexEndpoint, CreateIndexEndpointMetadata>(await _callCreateIndexEndpoint.Async(request, callSettings).ConfigureAwait(false), CreateIndexEndpointOperationsClient);
        }

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IndexEndpoint GetIndexEndpoint(GetIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexEndpointRequest(ref request, ref callSettings);
            return _callGetIndexEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IndexEndpoint> GetIndexEndpointAsync(GetIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexEndpointRequest(ref request, ref callSettings);
            return _callGetIndexEndpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all IndexEndpoints in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public override gax::PagedEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpoints(ListIndexEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIndexEndpointsRequest, ListIndexEndpointsResponse, IndexEndpoint>(_callListIndexEndpoints, request, callSettings);
        }

        /// <summary>
        /// Lists all IndexEndpoints in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpointsAsync(ListIndexEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIndexEndpointsRequest, ListIndexEndpointsResponse, IndexEndpoint>(_callListIndexEndpoints, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateIndexEndpoint</c>.</summary>
        public override lro::OperationsClient UpdateIndexEndpointOperationsClient { get; }

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata> UpdateIndexEndpoint(UpdateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIndexEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata>(_callUpdateIndexEndpoint.Sync(request, callSettings), UpdateIndexEndpointOperationsClient);
        }

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata>> UpdateIndexEndpointAsync(UpdateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIndexEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<IndexEndpoint, UpdateIndexEndpointMetadata>(await _callUpdateIndexEndpoint.Async(request, callSettings).ConfigureAwait(false), UpdateIndexEndpointOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteIndexEndpoint</c>.</summary>
        public override lro::OperationsClient DeleteIndexEndpointOperationsClient { get; }

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata> DeleteIndexEndpoint(DeleteIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata>(_callDeleteIndexEndpoint.Sync(request, callSettings), DeleteIndexEndpointOperationsClient);
        }

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata>> DeleteIndexEndpointAsync(DeleteIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteIndexEndpointMetadata>(await _callDeleteIndexEndpoint.Async(request, callSettings).ConfigureAwait(false), DeleteIndexEndpointOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeployIndex</c>.</summary>
        public override lro::OperationsClient DeployIndexOperationsClient { get; }

        /// <summary>
        /// Deploys an Index to IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeployIndexResponse, DeployIndexMetadata> DeployIndex(DeployIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployIndexRequest(ref request, ref callSettings);
            return new lro::Operation<DeployIndexResponse, DeployIndexMetadata>(_callDeployIndex.Sync(request, callSettings), DeployIndexOperationsClient);
        }

        /// <summary>
        /// Deploys an Index to IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeployIndexResponse, DeployIndexMetadata>> DeployIndexAsync(DeployIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployIndexRequest(ref request, ref callSettings);
            return new lro::Operation<DeployIndexResponse, DeployIndexMetadata>(await _callDeployIndex.Async(request, callSettings).ConfigureAwait(false), DeployIndexOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeployIndex</c>.</summary>
        public override lro::OperationsClient UndeployIndexOperationsClient { get; }

        /// <summary>
        /// Undeploys an Index from IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UndeployIndexResponse, UndeployIndexMetadata> UndeployIndex(UndeployIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployIndexRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployIndexResponse, UndeployIndexMetadata>(_callUndeployIndex.Sync(request, callSettings), UndeployIndexOperationsClient);
        }

        /// <summary>
        /// Undeploys an Index from IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UndeployIndexResponse, UndeployIndexMetadata>> UndeployIndexAsync(UndeployIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployIndexRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployIndexResponse, UndeployIndexMetadata>(await _callUndeployIndex.Async(request, callSettings).ConfigureAwait(false), UndeployIndexOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateCollection</c>.</summary>
        public override lro::OperationsClient CreateCollectionOperationsClient { get; }

        /// <summary>
        /// Creates a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Collection, CreateCollectionMetadata> CreateCollection(CreateCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCollectionRequest(ref request, ref callSettings);
            return new lro::Operation<Collection, CreateCollectionMetadata>(_callCreateCollection.Sync(request, callSettings), CreateCollectionOperationsClient);
        }

        /// <summary>
        /// Creates a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Collection, CreateCollectionMetadata>> CreateCollectionAsync(CreateCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCollectionRequest(ref request, ref callSettings);
            return new lro::Operation<Collection, CreateCollectionMetadata>(await _callCreateCollection.Async(request, callSettings).ConfigureAwait(false), CreateCollectionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCollection</c>.</summary>
        public override lro::OperationsClient DeleteCollectionOperationsClient { get; }

        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteCollectionMetadata> DeleteCollection(DeleteCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCollectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteCollectionMetadata>(_callDeleteCollection.Sync(request, callSettings), DeleteCollectionOperationsClient);
        }

        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(DeleteCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCollectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteCollectionMetadata>(await _callDeleteCollection.Async(request, callSettings).ConfigureAwait(false), DeleteCollectionOperationsClient);
        }

        /// <summary>
        /// Gets a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Collection GetCollection(GetCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCollectionRequest(ref request, ref callSettings);
            return _callGetCollection.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Collection> GetCollectionAsync(GetCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCollectionRequest(ref request, ref callSettings);
            return _callGetCollection.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Collection UpdateCollection(UpdateCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCollectionRequest(ref request, ref callSettings);
            return _callUpdateCollection.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Collection> UpdateCollectionAsync(UpdateCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCollectionRequest(ref request, ref callSettings);
            return _callUpdateCollection.Async(request, callSettings);
        }

        /// <summary>
        /// Lists collections inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Collection"/> resources.</returns>
        public override gax::PagedEnumerable<ListCollectionsResponse, Collection> ListCollections(ListCollectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCollectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCollectionsRequest, ListCollectionsResponse, Collection>(_callListCollections, request, callSettings);
        }

        /// <summary>
        /// Lists collections inside a corpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Collection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCollectionsResponse, Collection> ListCollectionsAsync(ListCollectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCollectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCollectionsRequest, ListCollectionsResponse, Collection>(_callListCollections, request, callSettings);
        }

        /// <summary>
        /// Adds an item into a Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AddCollectionItemResponse AddCollectionItem(AddCollectionItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddCollectionItemRequest(ref request, ref callSettings);
            return _callAddCollectionItem.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds an item into a Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AddCollectionItemResponse> AddCollectionItemAsync(AddCollectionItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddCollectionItemRequest(ref request, ref callSettings);
            return _callAddCollectionItem.Async(request, callSettings);
        }

        /// <summary>
        /// Removes an item from a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoveCollectionItemResponse RemoveCollectionItem(RemoveCollectionItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveCollectionItemRequest(ref request, ref callSettings);
            return _callRemoveCollectionItem.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes an item from a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoveCollectionItemResponse> RemoveCollectionItemAsync(RemoveCollectionItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveCollectionItemRequest(ref request, ref callSettings);
            return _callRemoveCollectionItem.Async(request, callSettings);
        }

        /// <summary>
        /// View items inside a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CollectionItem"/> resources.</returns>
        public override gax::PagedEnumerable<ViewCollectionItemsResponse, CollectionItem> ViewCollectionItems(ViewCollectionItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ViewCollectionItemsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ViewCollectionItemsRequest, ViewCollectionItemsResponse, CollectionItem>(_callViewCollectionItems, request, callSettings);
        }

        /// <summary>
        /// View items inside a collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CollectionItem"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ViewCollectionItemsResponse, CollectionItem> ViewCollectionItemsAsync(ViewCollectionItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ViewCollectionItemsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ViewCollectionItemsRequest, ViewCollectionItemsResponse, CollectionItem>(_callViewCollectionItems, request, callSettings);
        }
    }

    public partial class ListAssetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ViewIndexedAssetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIndexesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCorporaRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataSchemasRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnnotationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSearchConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSearchHypernymsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchAssetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchIndexEndpointRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIndexEndpointsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCollectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ViewCollectionItemsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAssetsResponse : gaxgrpc::IPageResponse<Asset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Asset> GetEnumerator() => Assets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ViewIndexedAssetsResponse : gaxgrpc::IPageResponse<IndexedAsset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<IndexedAsset> GetEnumerator() => IndexedAssets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListIndexesResponse : gaxgrpc::IPageResponse<Index>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Index> GetEnumerator() => Indexes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCorporaResponse : gaxgrpc::IPageResponse<Corpus>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Corpus> GetEnumerator() => Corpora.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDataSchemasResponse : gaxgrpc::IPageResponse<DataSchema>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataSchema> GetEnumerator() => DataSchemas.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAnnotationsResponse : gaxgrpc::IPageResponse<Annotation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Annotation> GetEnumerator() => Annotations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSearchConfigsResponse : gaxgrpc::IPageResponse<SearchConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SearchConfig> GetEnumerator() => SearchConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSearchHypernymsResponse : gaxgrpc::IPageResponse<SearchHypernym>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SearchHypernym> GetEnumerator() => SearchHypernyms.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchAssetsResponse : gaxgrpc::IPageResponse<SearchResultItem>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SearchResultItem> GetEnumerator() => SearchResultItems.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchIndexEndpointResponse : gaxgrpc::IPageResponse<SearchResultItem>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SearchResultItem> GetEnumerator() => SearchResultItems.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListIndexEndpointsResponse : gaxgrpc::IPageResponse<IndexEndpoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<IndexEndpoint> GetEnumerator() => IndexEndpoints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCollectionsResponse : gaxgrpc::IPageResponse<Collection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Collection> GetEnumerator() => Collections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ViewCollectionItemsResponse : gaxgrpc::IPageResponse<CollectionItem>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CollectionItem> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Warehouse
    {
        public partial class WarehouseClient
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

    public static partial class Warehouse
    {
        public partial class WarehouseClient
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
