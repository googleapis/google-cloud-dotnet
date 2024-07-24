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

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Settings for <see cref="DataplexServiceClient"/> instances.</summary>
    public sealed partial class DataplexServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataplexServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataplexServiceSettings"/>.</returns>
        public static DataplexServiceSettings GetDefault() => new DataplexServiceSettings();

        /// <summary>Constructs a new <see cref="DataplexServiceSettings"/> object with default settings.</summary>
        public DataplexServiceSettings()
        {
        }

        private DataplexServiceSettings(DataplexServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateLakeSettings = existing.CreateLakeSettings;
            CreateLakeOperationsSettings = existing.CreateLakeOperationsSettings.Clone();
            UpdateLakeSettings = existing.UpdateLakeSettings;
            UpdateLakeOperationsSettings = existing.UpdateLakeOperationsSettings.Clone();
            DeleteLakeSettings = existing.DeleteLakeSettings;
            DeleteLakeOperationsSettings = existing.DeleteLakeOperationsSettings.Clone();
            ListLakesSettings = existing.ListLakesSettings;
            GetLakeSettings = existing.GetLakeSettings;
            ListLakeActionsSettings = existing.ListLakeActionsSettings;
            CreateZoneSettings = existing.CreateZoneSettings;
            CreateZoneOperationsSettings = existing.CreateZoneOperationsSettings.Clone();
            UpdateZoneSettings = existing.UpdateZoneSettings;
            UpdateZoneOperationsSettings = existing.UpdateZoneOperationsSettings.Clone();
            DeleteZoneSettings = existing.DeleteZoneSettings;
            DeleteZoneOperationsSettings = existing.DeleteZoneOperationsSettings.Clone();
            ListZonesSettings = existing.ListZonesSettings;
            GetZoneSettings = existing.GetZoneSettings;
            ListZoneActionsSettings = existing.ListZoneActionsSettings;
            CreateAssetSettings = existing.CreateAssetSettings;
            CreateAssetOperationsSettings = existing.CreateAssetOperationsSettings.Clone();
            UpdateAssetSettings = existing.UpdateAssetSettings;
            UpdateAssetOperationsSettings = existing.UpdateAssetOperationsSettings.Clone();
            DeleteAssetSettings = existing.DeleteAssetSettings;
            DeleteAssetOperationsSettings = existing.DeleteAssetOperationsSettings.Clone();
            ListAssetsSettings = existing.ListAssetsSettings;
            GetAssetSettings = existing.GetAssetSettings;
            ListAssetActionsSettings = existing.ListAssetActionsSettings;
            CreateTaskSettings = existing.CreateTaskSettings;
            CreateTaskOperationsSettings = existing.CreateTaskOperationsSettings.Clone();
            UpdateTaskSettings = existing.UpdateTaskSettings;
            UpdateTaskOperationsSettings = existing.UpdateTaskOperationsSettings.Clone();
            DeleteTaskSettings = existing.DeleteTaskSettings;
            DeleteTaskOperationsSettings = existing.DeleteTaskOperationsSettings.Clone();
            ListTasksSettings = existing.ListTasksSettings;
            GetTaskSettings = existing.GetTaskSettings;
            ListJobsSettings = existing.ListJobsSettings;
            RunTaskSettings = existing.RunTaskSettings;
            GetJobSettings = existing.GetJobSettings;
            CancelJobSettings = existing.CancelJobSettings;
            CreateEnvironmentSettings = existing.CreateEnvironmentSettings;
            CreateEnvironmentOperationsSettings = existing.CreateEnvironmentOperationsSettings.Clone();
            UpdateEnvironmentSettings = existing.UpdateEnvironmentSettings;
            UpdateEnvironmentOperationsSettings = existing.UpdateEnvironmentOperationsSettings.Clone();
            DeleteEnvironmentSettings = existing.DeleteEnvironmentSettings;
            DeleteEnvironmentOperationsSettings = existing.DeleteEnvironmentOperationsSettings.Clone();
            ListEnvironmentsSettings = existing.ListEnvironmentsSettings;
            GetEnvironmentSettings = existing.GetEnvironmentSettings;
            ListSessionsSettings = existing.ListSessionsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataplexServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.CreateLake</c> and <c>DataplexServiceClient.CreateLakeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateLakeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.CreateLake</c> and
        /// <c>DataplexServiceClient.CreateLakeAsync</c>.
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
        public lro::OperationsSettings CreateLakeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.UpdateLake</c> and <c>DataplexServiceClient.UpdateLakeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateLakeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.UpdateLake</c> and
        /// <c>DataplexServiceClient.UpdateLakeAsync</c>.
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
        public lro::OperationsSettings UpdateLakeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.DeleteLake</c> and <c>DataplexServiceClient.DeleteLakeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteLakeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.DeleteLake</c> and
        /// <c>DataplexServiceClient.DeleteLakeAsync</c>.
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
        public lro::OperationsSettings DeleteLakeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.ListLakes</c> and <c>DataplexServiceClient.ListLakesAsync</c>.
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
        public gaxgrpc::CallSettings ListLakesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.GetLake</c> and <c>DataplexServiceClient.GetLakeAsync</c>.
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
        public gaxgrpc::CallSettings GetLakeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.ListLakeActions</c> and <c>DataplexServiceClient.ListLakeActionsAsync</c>.
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
        public gaxgrpc::CallSettings ListLakeActionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.CreateZone</c> and <c>DataplexServiceClient.CreateZoneAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateZoneSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.CreateZone</c> and
        /// <c>DataplexServiceClient.CreateZoneAsync</c>.
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
        public lro::OperationsSettings CreateZoneOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.UpdateZone</c> and <c>DataplexServiceClient.UpdateZoneAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateZoneSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.UpdateZone</c> and
        /// <c>DataplexServiceClient.UpdateZoneAsync</c>.
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
        public lro::OperationsSettings UpdateZoneOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.DeleteZone</c> and <c>DataplexServiceClient.DeleteZoneAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteZoneSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.DeleteZone</c> and
        /// <c>DataplexServiceClient.DeleteZoneAsync</c>.
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
        public lro::OperationsSettings DeleteZoneOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.ListZones</c> and <c>DataplexServiceClient.ListZonesAsync</c>.
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
        public gaxgrpc::CallSettings ListZonesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.GetZone</c> and <c>DataplexServiceClient.GetZoneAsync</c>.
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
        public gaxgrpc::CallSettings GetZoneSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.ListZoneActions</c> and <c>DataplexServiceClient.ListZoneActionsAsync</c>.
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
        public gaxgrpc::CallSettings ListZoneActionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.CreateAsset</c> and <c>DataplexServiceClient.CreateAssetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAssetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.CreateAsset</c> and
        /// <c>DataplexServiceClient.CreateAssetAsync</c>.
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
        public lro::OperationsSettings CreateAssetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.UpdateAsset</c> and <c>DataplexServiceClient.UpdateAssetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAssetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.UpdateAsset</c> and
        /// <c>DataplexServiceClient.UpdateAssetAsync</c>.
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
        public lro::OperationsSettings UpdateAssetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.DeleteAsset</c> and <c>DataplexServiceClient.DeleteAssetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAssetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.DeleteAsset</c> and
        /// <c>DataplexServiceClient.DeleteAssetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.ListAssets</c> and <c>DataplexServiceClient.ListAssetsAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.GetAsset</c> and <c>DataplexServiceClient.GetAssetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.ListAssetActions</c> and <c>DataplexServiceClient.ListAssetActionsAsync</c>.
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
        public gaxgrpc::CallSettings ListAssetActionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.CreateTask</c> and <c>DataplexServiceClient.CreateTaskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTaskSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.CreateTask</c> and
        /// <c>DataplexServiceClient.CreateTaskAsync</c>.
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
        public lro::OperationsSettings CreateTaskOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.UpdateTask</c> and <c>DataplexServiceClient.UpdateTaskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTaskSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.UpdateTask</c> and
        /// <c>DataplexServiceClient.UpdateTaskAsync</c>.
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
        public lro::OperationsSettings UpdateTaskOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.DeleteTask</c> and <c>DataplexServiceClient.DeleteTaskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTaskSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.DeleteTask</c> and
        /// <c>DataplexServiceClient.DeleteTaskAsync</c>.
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
        public lro::OperationsSettings DeleteTaskOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.ListTasks</c> and <c>DataplexServiceClient.ListTasksAsync</c>.
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
        public gaxgrpc::CallSettings ListTasksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.GetTask</c> and <c>DataplexServiceClient.GetTaskAsync</c>.
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
        public gaxgrpc::CallSettings GetTaskSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.ListJobs</c> and <c>DataplexServiceClient.ListJobsAsync</c>.
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
        public gaxgrpc::CallSettings ListJobsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.RunTask</c> and <c>DataplexServiceClient.RunTaskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunTaskSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.GetJob</c> and <c>DataplexServiceClient.GetJobAsync</c>.
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
        public gaxgrpc::CallSettings GetJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.CancelJob</c> and <c>DataplexServiceClient.CancelJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.CreateEnvironment</c> and <c>DataplexServiceClient.CreateEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.CreateEnvironment</c> and
        /// <c>DataplexServiceClient.CreateEnvironmentAsync</c>.
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
        public lro::OperationsSettings CreateEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.UpdateEnvironment</c> and <c>DataplexServiceClient.UpdateEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.UpdateEnvironment</c> and
        /// <c>DataplexServiceClient.UpdateEnvironmentAsync</c>.
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
        public lro::OperationsSettings UpdateEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.DeleteEnvironment</c> and <c>DataplexServiceClient.DeleteEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataplexServiceClient.DeleteEnvironment</c> and
        /// <c>DataplexServiceClient.DeleteEnvironmentAsync</c>.
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
        public lro::OperationsSettings DeleteEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.ListEnvironments</c> and <c>DataplexServiceClient.ListEnvironmentsAsync</c>.
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
        public gaxgrpc::CallSettings ListEnvironmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.GetEnvironment</c> and <c>DataplexServiceClient.GetEnvironmentAsync</c>.
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
        public gaxgrpc::CallSettings GetEnvironmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataplexServiceClient.ListSessions</c> and <c>DataplexServiceClient.ListSessionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSessionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataplexServiceSettings"/> object.</returns>
        public DataplexServiceSettings Clone() => new DataplexServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataplexServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DataplexServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataplexServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataplexServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataplexServiceClientBuilder() : base(DataplexServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataplexServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataplexServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataplexServiceClient Build()
        {
            DataplexServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataplexServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataplexServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataplexServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataplexServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataplexServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataplexServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataplexServiceClient.ChannelPool;
    }

    /// <summary>DataplexService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Dataplex service provides data lakes as a service. The primary resources
    /// offered by this service are Lakes, Zones and Assets which collectively allow
    /// a data administrator to organize, manage, secure and catalog data across
    /// their organization located across cloud projects in a variety of storage
    /// systems including Cloud Storage and BigQuery.
    /// </remarks>
    public abstract partial class DataplexServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataplexService service, which is a host of "dataplex.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataplex.googleapis.com:443";

        /// <summary>The default DataplexService scopes.</summary>
        /// <remarks>
        /// The default DataplexService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataplexService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataplexServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataplexServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataplexServiceClient"/>.</returns>
        public static stt::Task<DataplexServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataplexServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataplexServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataplexServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataplexServiceClient"/>.</returns>
        public static DataplexServiceClient Create() => new DataplexServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataplexServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataplexServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataplexServiceClient"/>.</returns>
        internal static DataplexServiceClient Create(grpccore::CallInvoker callInvoker, DataplexServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataplexService.DataplexServiceClient grpcClient = new DataplexService.DataplexServiceClient(callInvoker);
            return new DataplexServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataplexService client</summary>
        public virtual DataplexService.DataplexServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Lake, OperationMetadata> CreateLake(CreateLakeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Lake, OperationMetadata>> CreateLakeAsync(CreateLakeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Lake, OperationMetadata>> CreateLakeAsync(CreateLakeRequest request, st::CancellationToken cancellationToken) =>
            CreateLakeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateLake</c>.</summary>
        public virtual lro::OperationsClient CreateLakeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateLake</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Lake, OperationMetadata> PollOnceCreateLake(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Lake, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateLakeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateLake</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Lake, OperationMetadata>> PollOnceCreateLakeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Lake, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateLakeOperationsClient, callSettings);

        /// <summary>
        /// Creates a lake resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the lake location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="lake">
        /// Required. Lake resource
        /// </param>
        /// <param name="lakeId">
        /// Required. Lake identifier.
        /// This ID will be used to generate names such as database and dataset names
        /// when publishing metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the customer project / location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Lake, OperationMetadata> CreateLake(string parent, Lake lake, string lakeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLake(new CreateLakeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LakeId = gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)),
                Lake = gax::GaxPreconditions.CheckNotNull(lake, nameof(lake)),
            }, callSettings);

        /// <summary>
        /// Creates a lake resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the lake location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="lake">
        /// Required. Lake resource
        /// </param>
        /// <param name="lakeId">
        /// Required. Lake identifier.
        /// This ID will be used to generate names such as database and dataset names
        /// when publishing metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the customer project / location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Lake, OperationMetadata>> CreateLakeAsync(string parent, Lake lake, string lakeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLakeAsync(new CreateLakeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LakeId = gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)),
                Lake = gax::GaxPreconditions.CheckNotNull(lake, nameof(lake)),
            }, callSettings);

        /// <summary>
        /// Creates a lake resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the lake location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="lake">
        /// Required. Lake resource
        /// </param>
        /// <param name="lakeId">
        /// Required. Lake identifier.
        /// This ID will be used to generate names such as database and dataset names
        /// when publishing metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the customer project / location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Lake, OperationMetadata>> CreateLakeAsync(string parent, Lake lake, string lakeId, st::CancellationToken cancellationToken) =>
            CreateLakeAsync(parent, lake, lakeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a lake resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the lake location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="lake">
        /// Required. Lake resource
        /// </param>
        /// <param name="lakeId">
        /// Required. Lake identifier.
        /// This ID will be used to generate names such as database and dataset names
        /// when publishing metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the customer project / location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Lake, OperationMetadata> CreateLake(gagr::LocationName parent, Lake lake, string lakeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLake(new CreateLakeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LakeId = gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)),
                Lake = gax::GaxPreconditions.CheckNotNull(lake, nameof(lake)),
            }, callSettings);

        /// <summary>
        /// Creates a lake resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the lake location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="lake">
        /// Required. Lake resource
        /// </param>
        /// <param name="lakeId">
        /// Required. Lake identifier.
        /// This ID will be used to generate names such as database and dataset names
        /// when publishing metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the customer project / location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Lake, OperationMetadata>> CreateLakeAsync(gagr::LocationName parent, Lake lake, string lakeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLakeAsync(new CreateLakeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LakeId = gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)),
                Lake = gax::GaxPreconditions.CheckNotNull(lake, nameof(lake)),
            }, callSettings);

        /// <summary>
        /// Creates a lake resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the lake location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="lake">
        /// Required. Lake resource
        /// </param>
        /// <param name="lakeId">
        /// Required. Lake identifier.
        /// This ID will be used to generate names such as database and dataset names
        /// when publishing metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the customer project / location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Lake, OperationMetadata>> CreateLakeAsync(gagr::LocationName parent, Lake lake, string lakeId, st::CancellationToken cancellationToken) =>
            CreateLakeAsync(parent, lake, lakeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Lake, OperationMetadata> UpdateLake(UpdateLakeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Lake, OperationMetadata>> UpdateLakeAsync(UpdateLakeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Lake, OperationMetadata>> UpdateLakeAsync(UpdateLakeRequest request, st::CancellationToken cancellationToken) =>
            UpdateLakeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateLake</c>.</summary>
        public virtual lro::OperationsClient UpdateLakeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateLake</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Lake, OperationMetadata> PollOnceUpdateLake(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Lake, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateLakeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateLake</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Lake, OperationMetadata>> PollOnceUpdateLakeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Lake, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateLakeOperationsClient, callSettings);

        /// <summary>
        /// Updates a lake resource.
        /// </summary>
        /// <param name="lake">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Lake, OperationMetadata> UpdateLake(Lake lake, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLake(new UpdateLakeRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Lake = gax::GaxPreconditions.CheckNotNull(lake, nameof(lake)),
            }, callSettings);

        /// <summary>
        /// Updates a lake resource.
        /// </summary>
        /// <param name="lake">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Lake, OperationMetadata>> UpdateLakeAsync(Lake lake, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLakeAsync(new UpdateLakeRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Lake = gax::GaxPreconditions.CheckNotNull(lake, nameof(lake)),
            }, callSettings);

        /// <summary>
        /// Updates a lake resource.
        /// </summary>
        /// <param name="lake">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Lake, OperationMetadata>> UpdateLakeAsync(Lake lake, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateLakeAsync(lake, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a lake resource. All zones within the lake must be deleted before
        /// the lake can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteLake(DeleteLakeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a lake resource. All zones within the lake must be deleted before
        /// the lake can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLakeAsync(DeleteLakeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a lake resource. All zones within the lake must be deleted before
        /// the lake can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLakeAsync(DeleteLakeRequest request, st::CancellationToken cancellationToken) =>
            DeleteLakeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteLake</c>.</summary>
        public virtual lro::OperationsClient DeleteLakeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteLake</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteLake(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteLakeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteLake</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteLakeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteLakeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a lake resource. All zones within the lake must be deleted before
        /// the lake can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteLake(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLake(new DeleteLakeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a lake resource. All zones within the lake must be deleted before
        /// the lake can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLakeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLakeAsync(new DeleteLakeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a lake resource. All zones within the lake must be deleted before
        /// the lake can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLakeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteLakeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a lake resource. All zones within the lake must be deleted before
        /// the lake can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteLake(LakeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLake(new DeleteLakeRequest
            {
                LakeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a lake resource. All zones within the lake must be deleted before
        /// the lake can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLakeAsync(LakeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLakeAsync(new DeleteLakeRequest
            {
                LakeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a lake resource. All zones within the lake must be deleted before
        /// the lake can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLakeAsync(LakeName name, st::CancellationToken cancellationToken) =>
            DeleteLakeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists lake resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Lake"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLakesResponse, Lake> ListLakes(ListLakesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists lake resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Lake"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLakesResponse, Lake> ListLakesAsync(ListLakesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists lake resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the lake location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="Lake"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLakesResponse, Lake> ListLakes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLakesRequest request = new ListLakesRequest
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
            return ListLakes(request, callSettings);
        }

        /// <summary>
        /// Lists lake resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the lake location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Lake"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLakesResponse, Lake> ListLakesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLakesRequest request = new ListLakesRequest
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
            return ListLakesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists lake resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the lake location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="Lake"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLakesResponse, Lake> ListLakes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLakesRequest request = new ListLakesRequest
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
            return ListLakes(request, callSettings);
        }

        /// <summary>
        /// Lists lake resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the lake location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Lake"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLakesResponse, Lake> ListLakesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLakesRequest request = new ListLakesRequest
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
            return ListLakesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Lake GetLake(GetLakeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lake> GetLakeAsync(GetLakeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lake> GetLakeAsync(GetLakeRequest request, st::CancellationToken cancellationToken) =>
            GetLakeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a lake resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Lake GetLake(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLake(new GetLakeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a lake resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lake> GetLakeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLakeAsync(new GetLakeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a lake resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lake> GetLakeAsync(string name, st::CancellationToken cancellationToken) =>
            GetLakeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a lake resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Lake GetLake(LakeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLake(new GetLakeRequest
            {
                LakeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a lake resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lake> GetLakeAsync(LakeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLakeAsync(new GetLakeRequest
            {
                LakeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a lake resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lake> GetLakeAsync(LakeName name, st::CancellationToken cancellationToken) =>
            GetLakeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists action resources in a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActionsResponse, Action> ListLakeActions(ListLakeActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists action resources in a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActionsResponse, Action> ListLakeActionsAsync(ListLakeActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists action resources in a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActionsResponse, Action> ListLakeActions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLakeActionsRequest request = new ListLakeActionsRequest
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
            return ListLakeActions(request, callSettings);
        }

        /// <summary>
        /// Lists action resources in a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActionsResponse, Action> ListLakeActionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLakeActionsRequest request = new ListLakeActionsRequest
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
            return ListLakeActionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists action resources in a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActionsResponse, Action> ListLakeActions(LakeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLakeActionsRequest request = new ListLakeActionsRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLakeActions(request, callSettings);
        }

        /// <summary>
        /// Lists action resources in a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActionsResponse, Action> ListLakeActionsAsync(LakeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLakeActionsRequest request = new ListLakeActionsRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLakeActionsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a zone resource within a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> CreateZone(CreateZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a zone resource within a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(CreateZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a zone resource within a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(CreateZoneRequest request, st::CancellationToken cancellationToken) =>
            CreateZoneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateZone</c>.</summary>
        public virtual lro::OperationsClient CreateZoneOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> PollOnceCreateZone(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Zone, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateZoneOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> PollOnceCreateZoneAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Zone, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateZoneOperationsClient, callSettings);

        /// <summary>
        /// Creates a zone resource within a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="zone">
        /// Required. Zone resource.
        /// </param>
        /// <param name="zoneId">
        /// Required. Zone identifier.
        /// This ID will be used to generate names such as database and dataset names
        /// when publishing metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique across all lakes from all locations in a project.
        /// * Must not be one of the reserved IDs (i.e. "default", "global-temp")
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> CreateZone(string parent, Zone zone, string zoneId, gaxgrpc::CallSettings callSettings = null) =>
            CreateZone(new CreateZoneRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ZoneId = gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)),
                Zone = gax::GaxPreconditions.CheckNotNull(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a zone resource within a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="zone">
        /// Required. Zone resource.
        /// </param>
        /// <param name="zoneId">
        /// Required. Zone identifier.
        /// This ID will be used to generate names such as database and dataset names
        /// when publishing metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique across all lakes from all locations in a project.
        /// * Must not be one of the reserved IDs (i.e. "default", "global-temp")
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(string parent, Zone zone, string zoneId, gaxgrpc::CallSettings callSettings = null) =>
            CreateZoneAsync(new CreateZoneRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ZoneId = gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)),
                Zone = gax::GaxPreconditions.CheckNotNull(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a zone resource within a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="zone">
        /// Required. Zone resource.
        /// </param>
        /// <param name="zoneId">
        /// Required. Zone identifier.
        /// This ID will be used to generate names such as database and dataset names
        /// when publishing metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique across all lakes from all locations in a project.
        /// * Must not be one of the reserved IDs (i.e. "default", "global-temp")
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(string parent, Zone zone, string zoneId, st::CancellationToken cancellationToken) =>
            CreateZoneAsync(parent, zone, zoneId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a zone resource within a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="zone">
        /// Required. Zone resource.
        /// </param>
        /// <param name="zoneId">
        /// Required. Zone identifier.
        /// This ID will be used to generate names such as database and dataset names
        /// when publishing metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique across all lakes from all locations in a project.
        /// * Must not be one of the reserved IDs (i.e. "default", "global-temp")
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> CreateZone(LakeName parent, Zone zone, string zoneId, gaxgrpc::CallSettings callSettings = null) =>
            CreateZone(new CreateZoneRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ZoneId = gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)),
                Zone = gax::GaxPreconditions.CheckNotNull(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a zone resource within a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="zone">
        /// Required. Zone resource.
        /// </param>
        /// <param name="zoneId">
        /// Required. Zone identifier.
        /// This ID will be used to generate names such as database and dataset names
        /// when publishing metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique across all lakes from all locations in a project.
        /// * Must not be one of the reserved IDs (i.e. "default", "global-temp")
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(LakeName parent, Zone zone, string zoneId, gaxgrpc::CallSettings callSettings = null) =>
            CreateZoneAsync(new CreateZoneRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ZoneId = gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)),
                Zone = gax::GaxPreconditions.CheckNotNull(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a zone resource within a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="zone">
        /// Required. Zone resource.
        /// </param>
        /// <param name="zoneId">
        /// Required. Zone identifier.
        /// This ID will be used to generate names such as database and dataset names
        /// when publishing metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique across all lakes from all locations in a project.
        /// * Must not be one of the reserved IDs (i.e. "default", "global-temp")
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(LakeName parent, Zone zone, string zoneId, st::CancellationToken cancellationToken) =>
            CreateZoneAsync(parent, zone, zoneId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a zone resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> UpdateZone(UpdateZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a zone resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> UpdateZoneAsync(UpdateZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a zone resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> UpdateZoneAsync(UpdateZoneRequest request, st::CancellationToken cancellationToken) =>
            UpdateZoneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateZone</c>.</summary>
        public virtual lro::OperationsClient UpdateZoneOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> PollOnceUpdateZone(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Zone, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateZoneOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> PollOnceUpdateZoneAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Zone, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateZoneOperationsClient, callSettings);

        /// <summary>
        /// Updates a zone resource.
        /// </summary>
        /// <param name="zone">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Zone, OperationMetadata> UpdateZone(Zone zone, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateZone(new UpdateZoneRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Zone = gax::GaxPreconditions.CheckNotNull(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates a zone resource.
        /// </summary>
        /// <param name="zone">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> UpdateZoneAsync(Zone zone, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateZoneAsync(new UpdateZoneRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Zone = gax::GaxPreconditions.CheckNotNull(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Updates a zone resource.
        /// </summary>
        /// <param name="zone">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Zone, OperationMetadata>> UpdateZoneAsync(Zone zone, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateZoneAsync(zone, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a zone resource. All assets within a zone must be deleted before
        /// the zone can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteZone(DeleteZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a zone resource. All assets within a zone must be deleted before
        /// the zone can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(DeleteZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a zone resource. All assets within a zone must be deleted before
        /// the zone can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(DeleteZoneRequest request, st::CancellationToken cancellationToken) =>
            DeleteZoneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteZone</c>.</summary>
        public virtual lro::OperationsClient DeleteZoneOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteZone(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteZoneOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteZoneAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteZoneOperationsClient, callSettings);

        /// <summary>
        /// Deletes a zone resource. All assets within a zone must be deleted before
        /// the zone can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteZone(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteZone(new DeleteZoneRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a zone resource. All assets within a zone must be deleted before
        /// the zone can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteZoneAsync(new DeleteZoneRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a zone resource. All assets within a zone must be deleted before
        /// the zone can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteZoneAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a zone resource. All assets within a zone must be deleted before
        /// the zone can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteZone(ZoneName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteZone(new DeleteZoneRequest
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a zone resource. All assets within a zone must be deleted before
        /// the zone can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(ZoneName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteZoneAsync(new DeleteZoneRequest
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a zone resource. All assets within a zone must be deleted before
        /// the zone can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(ZoneName name, st::CancellationToken cancellationToken) =>
            DeleteZoneAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists zone resources in a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Zone"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListZonesResponse, Zone> ListZones(ListZonesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists zone resources in a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Zone"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListZonesResponse, Zone> ListZonesAsync(ListZonesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists zone resources in a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable sequence of <see cref="Zone"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListZonesResponse, Zone> ListZones(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListZonesRequest request = new ListZonesRequest
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
            return ListZones(request, callSettings);
        }

        /// <summary>
        /// Lists zone resources in a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Zone"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListZonesResponse, Zone> ListZonesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListZonesRequest request = new ListZonesRequest
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
            return ListZonesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists zone resources in a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable sequence of <see cref="Zone"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListZonesResponse, Zone> ListZones(LakeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListZonesRequest request = new ListZonesRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListZones(request, callSettings);
        }

        /// <summary>
        /// Lists zone resources in a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Zone"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListZonesResponse, Zone> ListZonesAsync(LakeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListZonesRequest request = new ListZonesRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListZonesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a zone resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Zone GetZone(GetZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a zone resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Zone> GetZoneAsync(GetZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a zone resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Zone> GetZoneAsync(GetZoneRequest request, st::CancellationToken cancellationToken) =>
            GetZoneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a zone resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Zone GetZone(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetZone(new GetZoneRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a zone resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Zone> GetZoneAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetZoneAsync(new GetZoneRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a zone resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Zone> GetZoneAsync(string name, st::CancellationToken cancellationToken) =>
            GetZoneAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a zone resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Zone GetZone(ZoneName name, gaxgrpc::CallSettings callSettings = null) =>
            GetZone(new GetZoneRequest
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a zone resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Zone> GetZoneAsync(ZoneName name, gaxgrpc::CallSettings callSettings = null) =>
            GetZoneAsync(new GetZoneRequest
            {
                ZoneName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a zone resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Zone> GetZoneAsync(ZoneName name, st::CancellationToken cancellationToken) =>
            GetZoneAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists action resources in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActionsResponse, Action> ListZoneActions(ListZoneActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists action resources in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActionsResponse, Action> ListZoneActionsAsync(ListZoneActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists action resources in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// <returns>A pageable sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActionsResponse, Action> ListZoneActions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListZoneActionsRequest request = new ListZoneActionsRequest
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
            return ListZoneActions(request, callSettings);
        }

        /// <summary>
        /// Lists action resources in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActionsResponse, Action> ListZoneActionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListZoneActionsRequest request = new ListZoneActionsRequest
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
            return ListZoneActionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists action resources in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// <returns>A pageable sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActionsResponse, Action> ListZoneActions(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListZoneActionsRequest request = new ListZoneActionsRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListZoneActions(request, callSettings);
        }

        /// <summary>
        /// Lists action resources in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActionsResponse, Action> ListZoneActionsAsync(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListZoneActionsRequest request = new ListZoneActionsRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListZoneActionsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates an asset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Asset, OperationMetadata> CreateAsset(CreateAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an asset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Asset, OperationMetadata>> CreateAssetAsync(CreateAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an asset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Asset, OperationMetadata>> CreateAssetAsync(CreateAssetRequest request, st::CancellationToken cancellationToken) =>
            CreateAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAsset</c>.</summary>
        public virtual lro::OperationsClient CreateAssetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Asset, OperationMetadata> PollOnceCreateAsset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Asset, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAssetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Asset, OperationMetadata>> PollOnceCreateAssetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Asset, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAssetOperationsClient, callSettings);

        /// <summary>
        /// Creates an asset resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="asset">
        /// Required. Asset resource.
        /// </param>
        /// <param name="assetId">
        /// Required. Asset identifier.
        /// This ID will be used to generate names such as table names when publishing
        /// metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the zone.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Asset, OperationMetadata> CreateAsset(string parent, Asset asset, string assetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAsset(new CreateAssetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AssetId = gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)),
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
            }, callSettings);

        /// <summary>
        /// Creates an asset resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="asset">
        /// Required. Asset resource.
        /// </param>
        /// <param name="assetId">
        /// Required. Asset identifier.
        /// This ID will be used to generate names such as table names when publishing
        /// metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the zone.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Asset, OperationMetadata>> CreateAssetAsync(string parent, Asset asset, string assetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssetAsync(new CreateAssetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AssetId = gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)),
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
            }, callSettings);

        /// <summary>
        /// Creates an asset resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="asset">
        /// Required. Asset resource.
        /// </param>
        /// <param name="assetId">
        /// Required. Asset identifier.
        /// This ID will be used to generate names such as table names when publishing
        /// metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the zone.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Asset, OperationMetadata>> CreateAssetAsync(string parent, Asset asset, string assetId, st::CancellationToken cancellationToken) =>
            CreateAssetAsync(parent, asset, assetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an asset resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="asset">
        /// Required. Asset resource.
        /// </param>
        /// <param name="assetId">
        /// Required. Asset identifier.
        /// This ID will be used to generate names such as table names when publishing
        /// metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the zone.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Asset, OperationMetadata> CreateAsset(ZoneName parent, Asset asset, string assetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAsset(new CreateAssetRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AssetId = gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)),
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
            }, callSettings);

        /// <summary>
        /// Creates an asset resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="asset">
        /// Required. Asset resource.
        /// </param>
        /// <param name="assetId">
        /// Required. Asset identifier.
        /// This ID will be used to generate names such as table names when publishing
        /// metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the zone.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Asset, OperationMetadata>> CreateAssetAsync(ZoneName parent, Asset asset, string assetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssetAsync(new CreateAssetRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AssetId = gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)),
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
            }, callSettings);

        /// <summary>
        /// Creates an asset resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="asset">
        /// Required. Asset resource.
        /// </param>
        /// <param name="assetId">
        /// Required. Asset identifier.
        /// This ID will be used to generate names such as table names when publishing
        /// metadata to Hive Metastore and BigQuery.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the zone.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Asset, OperationMetadata>> CreateAssetAsync(ZoneName parent, Asset asset, string assetId, st::CancellationToken cancellationToken) =>
            CreateAssetAsync(parent, asset, assetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an asset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Asset, OperationMetadata> UpdateAsset(UpdateAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an asset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Asset, OperationMetadata>> UpdateAssetAsync(UpdateAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an asset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Asset, OperationMetadata>> UpdateAssetAsync(UpdateAssetRequest request, st::CancellationToken cancellationToken) =>
            UpdateAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAsset</c>.</summary>
        public virtual lro::OperationsClient UpdateAssetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Asset, OperationMetadata> PollOnceUpdateAsset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Asset, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAssetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Asset, OperationMetadata>> PollOnceUpdateAssetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Asset, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAssetOperationsClient, callSettings);

        /// <summary>
        /// Updates an asset resource.
        /// </summary>
        /// <param name="asset">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Asset, OperationMetadata> UpdateAsset(Asset asset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsset(new UpdateAssetRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
            }, callSettings);

        /// <summary>
        /// Updates an asset resource.
        /// </summary>
        /// <param name="asset">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Asset, OperationMetadata>> UpdateAssetAsync(Asset asset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAssetAsync(new UpdateAssetRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
            }, callSettings);

        /// <summary>
        /// Updates an asset resource.
        /// </summary>
        /// <param name="asset">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Asset, OperationMetadata>> UpdateAssetAsync(Asset asset, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAssetAsync(asset, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an asset resource. The referenced storage resource is detached
        /// (default) or deleted based on the associated Lifecycle policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAsset(DeleteAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an asset resource. The referenced storage resource is detached
        /// (default) or deleted based on the associated Lifecycle policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAssetAsync(DeleteAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an asset resource. The referenced storage resource is detached
        /// (default) or deleted based on the associated Lifecycle policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAssetAsync(DeleteAssetRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAsset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAssetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAssetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAssetOperationsClient, callSettings);

        /// <summary>
        /// Deletes an asset resource. The referenced storage resource is detached
        /// (default) or deleted based on the associated Lifecycle policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAsset(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsset(new DeleteAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset resource. The referenced storage resource is detached
        /// (default) or deleted based on the associated Lifecycle policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAssetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssetAsync(new DeleteAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset resource. The referenced storage resource is detached
        /// (default) or deleted based on the associated Lifecycle policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAssetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an asset resource. The referenced storage resource is detached
        /// (default) or deleted based on the associated Lifecycle policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAsset(AssetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsset(new DeleteAssetRequest
            {
                AssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset resource. The referenced storage resource is detached
        /// (default) or deleted based on the associated Lifecycle policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAssetAsync(AssetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssetAsync(new DeleteAssetRequest
            {
                AssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset resource. The referenced storage resource is detached
        /// (default) or deleted based on the associated Lifecycle policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAssetAsync(AssetName name, st::CancellationToken cancellationToken) =>
            DeleteAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists asset resources in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssetsResponse, Asset> ListAssets(ListAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists asset resources in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssetsResponse, Asset> ListAssetsAsync(ListAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists asset resources in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// Lists asset resources in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// Lists asset resources in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        public virtual gax::PagedEnumerable<ListAssetsResponse, Asset> ListAssets(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetsRequest request = new ListAssetsRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists asset resources in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        public virtual gax::PagedAsyncEnumerable<ListAssetsResponse, Asset> ListAssetsAsync(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetsRequest request = new ListAssetsRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Retrieves an asset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset GetAsset(GetAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an asset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(GetAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an asset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(GetAssetRequest request, st::CancellationToken cancellationToken) =>
            GetAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an asset resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset GetAsset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAsset(new GetAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an asset resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssetAsync(new GetAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an asset resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(string name, st::CancellationToken cancellationToken) =>
            GetAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an asset resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset GetAsset(AssetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAsset(new GetAssetRequest
            {
                AssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an asset resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(AssetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssetAsync(new GetAssetRequest
            {
                AssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an asset resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(AssetName name, st::CancellationToken cancellationToken) =>
            GetAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists action resources in an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActionsResponse, Action> ListAssetActions(ListAssetActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists action resources in an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActionsResponse, Action> ListAssetActionsAsync(ListAssetActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists action resources in an asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
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
        /// <returns>A pageable sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActionsResponse, Action> ListAssetActions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetActionsRequest request = new ListAssetActionsRequest
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
            return ListAssetActions(request, callSettings);
        }

        /// <summary>
        /// Lists action resources in an asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActionsResponse, Action> ListAssetActionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetActionsRequest request = new ListAssetActionsRequest
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
            return ListAssetActionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists action resources in an asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
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
        /// <returns>A pageable sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActionsResponse, Action> ListAssetActions(AssetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetActionsRequest request = new ListAssetActionsRequest
            {
                ParentAsAssetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAssetActions(request, callSettings);
        }

        /// <summary>
        /// Lists action resources in an asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent asset:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Action"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActionsResponse, Action> ListAssetActionsAsync(AssetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetActionsRequest request = new ListAssetActionsRequest
            {
                ParentAsAssetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAssetActionsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a task resource within a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Task, OperationMetadata> CreateTask(CreateTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a task resource within a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Task, OperationMetadata>> CreateTaskAsync(CreateTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a task resource within a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Task, OperationMetadata>> CreateTaskAsync(CreateTaskRequest request, st::CancellationToken cancellationToken) =>
            CreateTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTask</c>.</summary>
        public virtual lro::OperationsClient CreateTaskOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTask</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Task, OperationMetadata> PollOnceCreateTask(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Task, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTaskOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTask</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Task, OperationMetadata>> PollOnceCreateTaskAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Task, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTaskOperationsClient, callSettings);

        /// <summary>
        /// Creates a task resource within a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="task">
        /// Required. Task resource.
        /// </param>
        /// <param name="taskId">
        /// Required. Task identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Task, OperationMetadata> CreateTask(string parent, Task task, string taskId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTask(new CreateTaskRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TaskId = gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)),
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
            }, callSettings);

        /// <summary>
        /// Creates a task resource within a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="task">
        /// Required. Task resource.
        /// </param>
        /// <param name="taskId">
        /// Required. Task identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Task, OperationMetadata>> CreateTaskAsync(string parent, Task task, string taskId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTaskAsync(new CreateTaskRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TaskId = gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)),
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
            }, callSettings);

        /// <summary>
        /// Creates a task resource within a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="task">
        /// Required. Task resource.
        /// </param>
        /// <param name="taskId">
        /// Required. Task identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Task, OperationMetadata>> CreateTaskAsync(string parent, Task task, string taskId, st::CancellationToken cancellationToken) =>
            CreateTaskAsync(parent, task, taskId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a task resource within a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="task">
        /// Required. Task resource.
        /// </param>
        /// <param name="taskId">
        /// Required. Task identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Task, OperationMetadata> CreateTask(LakeName parent, Task task, string taskId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTask(new CreateTaskRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TaskId = gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)),
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
            }, callSettings);

        /// <summary>
        /// Creates a task resource within a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="task">
        /// Required. Task resource.
        /// </param>
        /// <param name="taskId">
        /// Required. Task identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Task, OperationMetadata>> CreateTaskAsync(LakeName parent, Task task, string taskId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTaskAsync(new CreateTaskRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TaskId = gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)),
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
            }, callSettings);

        /// <summary>
        /// Creates a task resource within a lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="task">
        /// Required. Task resource.
        /// </param>
        /// <param name="taskId">
        /// Required. Task identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Task, OperationMetadata>> CreateTaskAsync(LakeName parent, Task task, string taskId, st::CancellationToken cancellationToken) =>
            CreateTaskAsync(parent, task, taskId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Task, OperationMetadata> UpdateTask(UpdateTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Task, OperationMetadata>> UpdateTaskAsync(UpdateTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Task, OperationMetadata>> UpdateTaskAsync(UpdateTaskRequest request, st::CancellationToken cancellationToken) =>
            UpdateTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateTask</c>.</summary>
        public virtual lro::OperationsClient UpdateTaskOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateTask</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Task, OperationMetadata> PollOnceUpdateTask(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Task, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTaskOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTask</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Task, OperationMetadata>> PollOnceUpdateTaskAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Task, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTaskOperationsClient, callSettings);

        /// <summary>
        /// Update the task resource.
        /// </summary>
        /// <param name="task">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Task, OperationMetadata> UpdateTask(Task task, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTask(new UpdateTaskRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
            }, callSettings);

        /// <summary>
        /// Update the task resource.
        /// </summary>
        /// <param name="task">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Task, OperationMetadata>> UpdateTaskAsync(Task task, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTaskAsync(new UpdateTaskRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
            }, callSettings);

        /// <summary>
        /// Update the task resource.
        /// </summary>
        /// <param name="task">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Task, OperationMetadata>> UpdateTaskAsync(Task task, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTaskAsync(task, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTask(DeleteTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTaskAsync(DeleteTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTaskAsync(DeleteTaskRequest request, st::CancellationToken cancellationToken) =>
            DeleteTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTask</c>.</summary>
        public virtual lro::OperationsClient DeleteTaskOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTask</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteTask(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTaskOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTask</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteTaskAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTaskOperationsClient, callSettings);

        /// <summary>
        /// Delete the task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/task/{task_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTask(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTask(new DeleteTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/task/{task_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTaskAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTaskAsync(new DeleteTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/task/{task_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTaskAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/task/{task_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTask(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTask(new DeleteTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/task/{task_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTaskAsync(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTaskAsync(new DeleteTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/task/{task_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTaskAsync(TaskName name, st::CancellationToken cancellationToken) =>
            DeleteTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists tasks under the given lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists tasks under the given lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists tasks under the given lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
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
            return ListTasks(request, callSettings);
        }

        /// <summary>
        /// Lists tasks under the given lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
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
            return ListTasksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists tasks under the given lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(LakeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTasks(request, callSettings);
        }

        /// <summary>
        /// Lists tasks under the given lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(LakeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTasksAsync(request, callSettings);
        }

        /// <summary>
        /// Get task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(GetTaskRequest request, st::CancellationToken cancellationToken) =>
            GetTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{tasks_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTask(new GetTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{tasks_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskAsync(new GetTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{tasks_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(string name, st::CancellationToken cancellationToken) =>
            GetTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{tasks_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTask(new GetTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{tasks_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskAsync(new GetTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{tasks_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(TaskName name, st::CancellationToken cancellationToken) =>
            GetTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Jobs under the given task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Jobs under the given task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Jobs under the given task.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent environment:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}`.
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
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
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
            return ListJobs(request, callSettings);
        }

        /// <summary>
        /// Lists Jobs under the given task.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent environment:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
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
            return ListJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Jobs under the given task.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent environment:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}`.
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
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(TaskName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsTaskName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListJobs(request, callSettings);
        }

        /// <summary>
        /// Lists Jobs under the given task.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent environment:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(TaskName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsTaskName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Run an on demand execution of a Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunTaskResponse RunTask(RunTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Run an on demand execution of a Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunTaskResponse> RunTaskAsync(RunTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Run an on demand execution of a Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunTaskResponse> RunTaskAsync(RunTaskRequest request, st::CancellationToken cancellationToken) =>
            RunTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Run an on demand execution of a Task.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunTaskResponse RunTask(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunTask(new RunTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Run an on demand execution of a Task.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunTaskResponse> RunTaskAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunTaskAsync(new RunTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Run an on demand execution of a Task.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunTaskResponse> RunTaskAsync(string name, st::CancellationToken cancellationToken) =>
            RunTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Run an on demand execution of a Task.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunTaskResponse RunTask(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            RunTask(new RunTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Run an on demand execution of a Task.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunTaskResponse> RunTaskAsync(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            RunTaskAsync(new RunTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Run an on demand execution of a Task.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the task:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunTaskResponse> RunTaskAsync(TaskName name, st::CancellationToken cancellationToken) =>
            RunTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get job resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get job resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get job resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, st::CancellationToken cancellationToken) =>
            GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get job resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}/jobs/{job_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJob(new GetJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get job resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}/jobs/{job_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobAsync(new GetJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get job resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}/jobs/{job_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get job resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}/jobs/{job_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJob(new GetJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get job resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}/jobs/{job_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobAsync(new GetJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get job resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/tasks/{task_id}/jobs/{job_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            GetJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancel jobs running for the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelJob(CancelJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancel jobs running for the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelJobAsync(CancelJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancel jobs running for the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelJobAsync(CancelJobRequest request, st::CancellationToken cancellationToken) =>
            CancelJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancel jobs running for the task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/task/{task_id}/job/{job_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelJob(new CancelJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancel jobs running for the task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/task/{task_id}/job/{job_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelJobAsync(new CancelJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancel jobs running for the task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/task/{task_id}/job/{job_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelJobAsync(string name, st::CancellationToken cancellationToken) =>
            CancelJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancel jobs running for the task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/task/{task_id}/job/{job_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelJob(new CancelJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancel jobs running for the task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/task/{task_id}/job/{job_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelJobAsync(new CancelJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancel jobs running for the task resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/task/{task_id}/job/{job_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            CancelJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> CreateEnvironment(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(CreateEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            CreateEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEnvironment</c>.</summary>
        public virtual lro::OperationsClient CreateEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> PollOnceCreateEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> PollOnceCreateEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Create an environment resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="environment">
        /// Required. Environment resource.
        /// </param>
        /// <param name="environmentId">
        /// Required. Environment identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the lake.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> CreateEnvironment(string parent, Environment environment, string environmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironment(new CreateEnvironmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EnvironmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)),
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
            }, callSettings);

        /// <summary>
        /// Create an environment resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="environment">
        /// Required. Environment resource.
        /// </param>
        /// <param name="environmentId">
        /// Required. Environment identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the lake.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(string parent, Environment environment, string environmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironmentAsync(new CreateEnvironmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EnvironmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)),
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
            }, callSettings);

        /// <summary>
        /// Create an environment resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="environment">
        /// Required. Environment resource.
        /// </param>
        /// <param name="environmentId">
        /// Required. Environment identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the lake.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(string parent, Environment environment, string environmentId, st::CancellationToken cancellationToken) =>
            CreateEnvironmentAsync(parent, environment, environmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an environment resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="environment">
        /// Required. Environment resource.
        /// </param>
        /// <param name="environmentId">
        /// Required. Environment identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the lake.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> CreateEnvironment(LakeName parent, Environment environment, string environmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironment(new CreateEnvironmentRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EnvironmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)),
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
            }, callSettings);

        /// <summary>
        /// Create an environment resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="environment">
        /// Required. Environment resource.
        /// </param>
        /// <param name="environmentId">
        /// Required. Environment identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the lake.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(LakeName parent, Environment environment, string environmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironmentAsync(new CreateEnvironmentRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EnvironmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)),
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
            }, callSettings);

        /// <summary>
        /// Create an environment resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}`.
        /// </param>
        /// <param name="environment">
        /// Required. Environment resource.
        /// </param>
        /// <param name="environmentId">
        /// Required. Environment identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the lake.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(LakeName parent, Environment environment, string environmentId, st::CancellationToken cancellationToken) =>
            CreateEnvironmentAsync(parent, environment, environmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> UpdateEnvironment(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            UpdateEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEnvironment</c>.</summary>
        public virtual lro::OperationsClient UpdateEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> PollOnceUpdateEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> PollOnceUpdateEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Update the environment resource.
        /// </summary>
        /// <param name="environment">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> UpdateEnvironment(Environment environment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEnvironment(new UpdateEnvironmentRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
            }, callSettings);

        /// <summary>
        /// Update the environment resource.
        /// </summary>
        /// <param name="environment">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(Environment environment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEnvironmentAsync(new UpdateEnvironmentRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
            }, callSettings);

        /// <summary>
        /// Update the environment resource.
        /// </summary>
        /// <param name="environment">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(Environment environment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEnvironmentAsync(environment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the environment resource. All the child resources must have been
        /// deleted before environment deletion can be initiated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEnvironment(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the environment resource. All the child resources must have been
        /// deleted before environment deletion can be initiated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the environment resource. All the child resources must have been
        /// deleted before environment deletion can be initiated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEnvironment</c>.</summary>
        public virtual lro::OperationsClient DeleteEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Delete the environment resource. All the child resources must have been
        /// deleted before environment deletion can be initiated.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the environment:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEnvironment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironment(new DeleteEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the environment resource. All the child resources must have been
        /// deleted before environment deletion can be initiated.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the environment:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironmentAsync(new DeleteEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the environment resource. All the child resources must have been
        /// deleted before environment deletion can be initiated.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the environment:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the environment resource. All the child resources must have been
        /// deleted before environment deletion can be initiated.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the environment:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEnvironment(EnvironmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironment(new DeleteEnvironmentRequest
            {
                EnvironmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the environment resource. All the child resources must have been
        /// deleted before environment deletion can be initiated.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the environment:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(EnvironmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironmentAsync(new DeleteEnvironmentRequest
            {
                EnvironmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the environment resource. All the child resources must have been
        /// deleted before environment deletion can be initiated.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the environment:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(EnvironmentName name, st::CancellationToken cancellationToken) =>
            DeleteEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists environments under the given lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists environments under the given lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists environments under the given lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
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
            return ListEnvironments(request, callSettings);
        }

        /// <summary>
        /// Lists environments under the given lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
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
            return ListEnvironmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists environments under the given lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(LakeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEnvironments(request, callSettings);
        }

        /// <summary>
        /// Lists environments under the given lake.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(LakeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEnvironmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Get environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get environment resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the environment:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironment(new GetEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get environment resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the environment:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironmentAsync(new GetEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get environment resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the environment:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get environment resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the environment:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(EnvironmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironment(new GetEnvironmentRequest
            {
                EnvironmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get environment resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the environment:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(EnvironmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironmentAsync(new GetEnvironmentRequest
            {
                EnvironmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get environment resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the environment:
        /// `projects/{project_id}/locations/{location_id}/lakes/{lake_id}/environments/{environment_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(EnvironmentName name, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists session resources in an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists session resources in an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists session resources in an environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent environment:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/environment/{environment_id}`.
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
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
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
            return ListSessions(request, callSettings);
        }

        /// <summary>
        /// Lists session resources in an environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent environment:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/environment/{environment_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
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
            return ListSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists session resources in an environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent environment:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/environment/{environment_id}`.
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
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSessions(request, callSettings);
        }

        /// <summary>
        /// Lists session resources in an environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent environment:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/environment/{environment_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSessionsAsync(request, callSettings);
        }
    }

    /// <summary>DataplexService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Dataplex service provides data lakes as a service. The primary resources
    /// offered by this service are Lakes, Zones and Assets which collectively allow
    /// a data administrator to organize, manage, secure and catalog data across
    /// their organization located across cloud projects in a variety of storage
    /// systems including Cloud Storage and BigQuery.
    /// </remarks>
    public sealed partial class DataplexServiceClientImpl : DataplexServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateLakeRequest, lro::Operation> _callCreateLake;

        private readonly gaxgrpc::ApiCall<UpdateLakeRequest, lro::Operation> _callUpdateLake;

        private readonly gaxgrpc::ApiCall<DeleteLakeRequest, lro::Operation> _callDeleteLake;

        private readonly gaxgrpc::ApiCall<ListLakesRequest, ListLakesResponse> _callListLakes;

        private readonly gaxgrpc::ApiCall<GetLakeRequest, Lake> _callGetLake;

        private readonly gaxgrpc::ApiCall<ListLakeActionsRequest, ListActionsResponse> _callListLakeActions;

        private readonly gaxgrpc::ApiCall<CreateZoneRequest, lro::Operation> _callCreateZone;

        private readonly gaxgrpc::ApiCall<UpdateZoneRequest, lro::Operation> _callUpdateZone;

        private readonly gaxgrpc::ApiCall<DeleteZoneRequest, lro::Operation> _callDeleteZone;

        private readonly gaxgrpc::ApiCall<ListZonesRequest, ListZonesResponse> _callListZones;

        private readonly gaxgrpc::ApiCall<GetZoneRequest, Zone> _callGetZone;

        private readonly gaxgrpc::ApiCall<ListZoneActionsRequest, ListActionsResponse> _callListZoneActions;

        private readonly gaxgrpc::ApiCall<CreateAssetRequest, lro::Operation> _callCreateAsset;

        private readonly gaxgrpc::ApiCall<UpdateAssetRequest, lro::Operation> _callUpdateAsset;

        private readonly gaxgrpc::ApiCall<DeleteAssetRequest, lro::Operation> _callDeleteAsset;

        private readonly gaxgrpc::ApiCall<ListAssetsRequest, ListAssetsResponse> _callListAssets;

        private readonly gaxgrpc::ApiCall<GetAssetRequest, Asset> _callGetAsset;

        private readonly gaxgrpc::ApiCall<ListAssetActionsRequest, ListActionsResponse> _callListAssetActions;

        private readonly gaxgrpc::ApiCall<CreateTaskRequest, lro::Operation> _callCreateTask;

        private readonly gaxgrpc::ApiCall<UpdateTaskRequest, lro::Operation> _callUpdateTask;

        private readonly gaxgrpc::ApiCall<DeleteTaskRequest, lro::Operation> _callDeleteTask;

        private readonly gaxgrpc::ApiCall<ListTasksRequest, ListTasksResponse> _callListTasks;

        private readonly gaxgrpc::ApiCall<GetTaskRequest, Task> _callGetTask;

        private readonly gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> _callListJobs;

        private readonly gaxgrpc::ApiCall<RunTaskRequest, RunTaskResponse> _callRunTask;

        private readonly gaxgrpc::ApiCall<GetJobRequest, Job> _callGetJob;

        private readonly gaxgrpc::ApiCall<CancelJobRequest, wkt::Empty> _callCancelJob;

        private readonly gaxgrpc::ApiCall<CreateEnvironmentRequest, lro::Operation> _callCreateEnvironment;

        private readonly gaxgrpc::ApiCall<UpdateEnvironmentRequest, lro::Operation> _callUpdateEnvironment;

        private readonly gaxgrpc::ApiCall<DeleteEnvironmentRequest, lro::Operation> _callDeleteEnvironment;

        private readonly gaxgrpc::ApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse> _callListEnvironments;

        private readonly gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> _callGetEnvironment;

        private readonly gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> _callListSessions;

        /// <summary>
        /// Constructs a client wrapper for the DataplexService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataplexServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataplexServiceClientImpl(DataplexService.DataplexServiceClient grpcClient, DataplexServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataplexServiceSettings effectiveSettings = settings ?? DataplexServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateLakeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateLakeOperationsSettings, logger);
            UpdateLakeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateLakeOperationsSettings, logger);
            DeleteLakeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteLakeOperationsSettings, logger);
            CreateZoneOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateZoneOperationsSettings, logger);
            UpdateZoneOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateZoneOperationsSettings, logger);
            DeleteZoneOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteZoneOperationsSettings, logger);
            CreateAssetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAssetOperationsSettings, logger);
            UpdateAssetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAssetOperationsSettings, logger);
            DeleteAssetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAssetOperationsSettings, logger);
            CreateTaskOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTaskOperationsSettings, logger);
            UpdateTaskOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTaskOperationsSettings, logger);
            DeleteTaskOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTaskOperationsSettings, logger);
            CreateEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEnvironmentOperationsSettings, logger);
            UpdateEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEnvironmentOperationsSettings, logger);
            DeleteEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEnvironmentOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateLake = clientHelper.BuildApiCall<CreateLakeRequest, lro::Operation>("CreateLake", grpcClient.CreateLakeAsync, grpcClient.CreateLake, effectiveSettings.CreateLakeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateLake);
            Modify_CreateLakeApiCall(ref _callCreateLake);
            _callUpdateLake = clientHelper.BuildApiCall<UpdateLakeRequest, lro::Operation>("UpdateLake", grpcClient.UpdateLakeAsync, grpcClient.UpdateLake, effectiveSettings.UpdateLakeSettings).WithGoogleRequestParam("lake.name", request => request.Lake?.Name);
            Modify_ApiCall(ref _callUpdateLake);
            Modify_UpdateLakeApiCall(ref _callUpdateLake);
            _callDeleteLake = clientHelper.BuildApiCall<DeleteLakeRequest, lro::Operation>("DeleteLake", grpcClient.DeleteLakeAsync, grpcClient.DeleteLake, effectiveSettings.DeleteLakeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteLake);
            Modify_DeleteLakeApiCall(ref _callDeleteLake);
            _callListLakes = clientHelper.BuildApiCall<ListLakesRequest, ListLakesResponse>("ListLakes", grpcClient.ListLakesAsync, grpcClient.ListLakes, effectiveSettings.ListLakesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLakes);
            Modify_ListLakesApiCall(ref _callListLakes);
            _callGetLake = clientHelper.BuildApiCall<GetLakeRequest, Lake>("GetLake", grpcClient.GetLakeAsync, grpcClient.GetLake, effectiveSettings.GetLakeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLake);
            Modify_GetLakeApiCall(ref _callGetLake);
            _callListLakeActions = clientHelper.BuildApiCall<ListLakeActionsRequest, ListActionsResponse>("ListLakeActions", grpcClient.ListLakeActionsAsync, grpcClient.ListLakeActions, effectiveSettings.ListLakeActionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLakeActions);
            Modify_ListLakeActionsApiCall(ref _callListLakeActions);
            _callCreateZone = clientHelper.BuildApiCall<CreateZoneRequest, lro::Operation>("CreateZone", grpcClient.CreateZoneAsync, grpcClient.CreateZone, effectiveSettings.CreateZoneSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateZone);
            Modify_CreateZoneApiCall(ref _callCreateZone);
            _callUpdateZone = clientHelper.BuildApiCall<UpdateZoneRequest, lro::Operation>("UpdateZone", grpcClient.UpdateZoneAsync, grpcClient.UpdateZone, effectiveSettings.UpdateZoneSettings).WithGoogleRequestParam("zone.name", request => request.Zone?.Name);
            Modify_ApiCall(ref _callUpdateZone);
            Modify_UpdateZoneApiCall(ref _callUpdateZone);
            _callDeleteZone = clientHelper.BuildApiCall<DeleteZoneRequest, lro::Operation>("DeleteZone", grpcClient.DeleteZoneAsync, grpcClient.DeleteZone, effectiveSettings.DeleteZoneSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteZone);
            Modify_DeleteZoneApiCall(ref _callDeleteZone);
            _callListZones = clientHelper.BuildApiCall<ListZonesRequest, ListZonesResponse>("ListZones", grpcClient.ListZonesAsync, grpcClient.ListZones, effectiveSettings.ListZonesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListZones);
            Modify_ListZonesApiCall(ref _callListZones);
            _callGetZone = clientHelper.BuildApiCall<GetZoneRequest, Zone>("GetZone", grpcClient.GetZoneAsync, grpcClient.GetZone, effectiveSettings.GetZoneSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetZone);
            Modify_GetZoneApiCall(ref _callGetZone);
            _callListZoneActions = clientHelper.BuildApiCall<ListZoneActionsRequest, ListActionsResponse>("ListZoneActions", grpcClient.ListZoneActionsAsync, grpcClient.ListZoneActions, effectiveSettings.ListZoneActionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListZoneActions);
            Modify_ListZoneActionsApiCall(ref _callListZoneActions);
            _callCreateAsset = clientHelper.BuildApiCall<CreateAssetRequest, lro::Operation>("CreateAsset", grpcClient.CreateAssetAsync, grpcClient.CreateAsset, effectiveSettings.CreateAssetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAsset);
            Modify_CreateAssetApiCall(ref _callCreateAsset);
            _callUpdateAsset = clientHelper.BuildApiCall<UpdateAssetRequest, lro::Operation>("UpdateAsset", grpcClient.UpdateAssetAsync, grpcClient.UpdateAsset, effectiveSettings.UpdateAssetSettings).WithGoogleRequestParam("asset.name", request => request.Asset?.Name);
            Modify_ApiCall(ref _callUpdateAsset);
            Modify_UpdateAssetApiCall(ref _callUpdateAsset);
            _callDeleteAsset = clientHelper.BuildApiCall<DeleteAssetRequest, lro::Operation>("DeleteAsset", grpcClient.DeleteAssetAsync, grpcClient.DeleteAsset, effectiveSettings.DeleteAssetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAsset);
            Modify_DeleteAssetApiCall(ref _callDeleteAsset);
            _callListAssets = clientHelper.BuildApiCall<ListAssetsRequest, ListAssetsResponse>("ListAssets", grpcClient.ListAssetsAsync, grpcClient.ListAssets, effectiveSettings.ListAssetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAssets);
            Modify_ListAssetsApiCall(ref _callListAssets);
            _callGetAsset = clientHelper.BuildApiCall<GetAssetRequest, Asset>("GetAsset", grpcClient.GetAssetAsync, grpcClient.GetAsset, effectiveSettings.GetAssetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAsset);
            Modify_GetAssetApiCall(ref _callGetAsset);
            _callListAssetActions = clientHelper.BuildApiCall<ListAssetActionsRequest, ListActionsResponse>("ListAssetActions", grpcClient.ListAssetActionsAsync, grpcClient.ListAssetActions, effectiveSettings.ListAssetActionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAssetActions);
            Modify_ListAssetActionsApiCall(ref _callListAssetActions);
            _callCreateTask = clientHelper.BuildApiCall<CreateTaskRequest, lro::Operation>("CreateTask", grpcClient.CreateTaskAsync, grpcClient.CreateTask, effectiveSettings.CreateTaskSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTask);
            Modify_CreateTaskApiCall(ref _callCreateTask);
            _callUpdateTask = clientHelper.BuildApiCall<UpdateTaskRequest, lro::Operation>("UpdateTask", grpcClient.UpdateTaskAsync, grpcClient.UpdateTask, effectiveSettings.UpdateTaskSettings).WithGoogleRequestParam("task.name", request => request.Task?.Name);
            Modify_ApiCall(ref _callUpdateTask);
            Modify_UpdateTaskApiCall(ref _callUpdateTask);
            _callDeleteTask = clientHelper.BuildApiCall<DeleteTaskRequest, lro::Operation>("DeleteTask", grpcClient.DeleteTaskAsync, grpcClient.DeleteTask, effectiveSettings.DeleteTaskSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTask);
            Modify_DeleteTaskApiCall(ref _callDeleteTask);
            _callListTasks = clientHelper.BuildApiCall<ListTasksRequest, ListTasksResponse>("ListTasks", grpcClient.ListTasksAsync, grpcClient.ListTasks, effectiveSettings.ListTasksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTasks);
            Modify_ListTasksApiCall(ref _callListTasks);
            _callGetTask = clientHelper.BuildApiCall<GetTaskRequest, Task>("GetTask", grpcClient.GetTaskAsync, grpcClient.GetTask, effectiveSettings.GetTaskSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTask);
            Modify_GetTaskApiCall(ref _callGetTask);
            _callListJobs = clientHelper.BuildApiCall<ListJobsRequest, ListJobsResponse>("ListJobs", grpcClient.ListJobsAsync, grpcClient.ListJobs, effectiveSettings.ListJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListJobs);
            Modify_ListJobsApiCall(ref _callListJobs);
            _callRunTask = clientHelper.BuildApiCall<RunTaskRequest, RunTaskResponse>("RunTask", grpcClient.RunTaskAsync, grpcClient.RunTask, effectiveSettings.RunTaskSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRunTask);
            Modify_RunTaskApiCall(ref _callRunTask);
            _callGetJob = clientHelper.BuildApiCall<GetJobRequest, Job>("GetJob", grpcClient.GetJobAsync, grpcClient.GetJob, effectiveSettings.GetJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetJob);
            Modify_GetJobApiCall(ref _callGetJob);
            _callCancelJob = clientHelper.BuildApiCall<CancelJobRequest, wkt::Empty>("CancelJob", grpcClient.CancelJobAsync, grpcClient.CancelJob, effectiveSettings.CancelJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelJob);
            Modify_CancelJobApiCall(ref _callCancelJob);
            _callCreateEnvironment = clientHelper.BuildApiCall<CreateEnvironmentRequest, lro::Operation>("CreateEnvironment", grpcClient.CreateEnvironmentAsync, grpcClient.CreateEnvironment, effectiveSettings.CreateEnvironmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEnvironment);
            Modify_CreateEnvironmentApiCall(ref _callCreateEnvironment);
            _callUpdateEnvironment = clientHelper.BuildApiCall<UpdateEnvironmentRequest, lro::Operation>("UpdateEnvironment", grpcClient.UpdateEnvironmentAsync, grpcClient.UpdateEnvironment, effectiveSettings.UpdateEnvironmentSettings).WithGoogleRequestParam("environment.name", request => request.Environment?.Name);
            Modify_ApiCall(ref _callUpdateEnvironment);
            Modify_UpdateEnvironmentApiCall(ref _callUpdateEnvironment);
            _callDeleteEnvironment = clientHelper.BuildApiCall<DeleteEnvironmentRequest, lro::Operation>("DeleteEnvironment", grpcClient.DeleteEnvironmentAsync, grpcClient.DeleteEnvironment, effectiveSettings.DeleteEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEnvironment);
            Modify_DeleteEnvironmentApiCall(ref _callDeleteEnvironment);
            _callListEnvironments = clientHelper.BuildApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse>("ListEnvironments", grpcClient.ListEnvironmentsAsync, grpcClient.ListEnvironments, effectiveSettings.ListEnvironmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEnvironments);
            Modify_ListEnvironmentsApiCall(ref _callListEnvironments);
            _callGetEnvironment = clientHelper.BuildApiCall<GetEnvironmentRequest, Environment>("GetEnvironment", grpcClient.GetEnvironmentAsync, grpcClient.GetEnvironment, effectiveSettings.GetEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEnvironment);
            Modify_GetEnvironmentApiCall(ref _callGetEnvironment);
            _callListSessions = clientHelper.BuildApiCall<ListSessionsRequest, ListSessionsResponse>("ListSessions", grpcClient.ListSessionsAsync, grpcClient.ListSessions, effectiveSettings.ListSessionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSessions);
            Modify_ListSessionsApiCall(ref _callListSessions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateLakeApiCall(ref gaxgrpc::ApiCall<CreateLakeRequest, lro::Operation> call);

        partial void Modify_UpdateLakeApiCall(ref gaxgrpc::ApiCall<UpdateLakeRequest, lro::Operation> call);

        partial void Modify_DeleteLakeApiCall(ref gaxgrpc::ApiCall<DeleteLakeRequest, lro::Operation> call);

        partial void Modify_ListLakesApiCall(ref gaxgrpc::ApiCall<ListLakesRequest, ListLakesResponse> call);

        partial void Modify_GetLakeApiCall(ref gaxgrpc::ApiCall<GetLakeRequest, Lake> call);

        partial void Modify_ListLakeActionsApiCall(ref gaxgrpc::ApiCall<ListLakeActionsRequest, ListActionsResponse> call);

        partial void Modify_CreateZoneApiCall(ref gaxgrpc::ApiCall<CreateZoneRequest, lro::Operation> call);

        partial void Modify_UpdateZoneApiCall(ref gaxgrpc::ApiCall<UpdateZoneRequest, lro::Operation> call);

        partial void Modify_DeleteZoneApiCall(ref gaxgrpc::ApiCall<DeleteZoneRequest, lro::Operation> call);

        partial void Modify_ListZonesApiCall(ref gaxgrpc::ApiCall<ListZonesRequest, ListZonesResponse> call);

        partial void Modify_GetZoneApiCall(ref gaxgrpc::ApiCall<GetZoneRequest, Zone> call);

        partial void Modify_ListZoneActionsApiCall(ref gaxgrpc::ApiCall<ListZoneActionsRequest, ListActionsResponse> call);

        partial void Modify_CreateAssetApiCall(ref gaxgrpc::ApiCall<CreateAssetRequest, lro::Operation> call);

        partial void Modify_UpdateAssetApiCall(ref gaxgrpc::ApiCall<UpdateAssetRequest, lro::Operation> call);

        partial void Modify_DeleteAssetApiCall(ref gaxgrpc::ApiCall<DeleteAssetRequest, lro::Operation> call);

        partial void Modify_ListAssetsApiCall(ref gaxgrpc::ApiCall<ListAssetsRequest, ListAssetsResponse> call);

        partial void Modify_GetAssetApiCall(ref gaxgrpc::ApiCall<GetAssetRequest, Asset> call);

        partial void Modify_ListAssetActionsApiCall(ref gaxgrpc::ApiCall<ListAssetActionsRequest, ListActionsResponse> call);

        partial void Modify_CreateTaskApiCall(ref gaxgrpc::ApiCall<CreateTaskRequest, lro::Operation> call);

        partial void Modify_UpdateTaskApiCall(ref gaxgrpc::ApiCall<UpdateTaskRequest, lro::Operation> call);

        partial void Modify_DeleteTaskApiCall(ref gaxgrpc::ApiCall<DeleteTaskRequest, lro::Operation> call);

        partial void Modify_ListTasksApiCall(ref gaxgrpc::ApiCall<ListTasksRequest, ListTasksResponse> call);

        partial void Modify_GetTaskApiCall(ref gaxgrpc::ApiCall<GetTaskRequest, Task> call);

        partial void Modify_ListJobsApiCall(ref gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> call);

        partial void Modify_RunTaskApiCall(ref gaxgrpc::ApiCall<RunTaskRequest, RunTaskResponse> call);

        partial void Modify_GetJobApiCall(ref gaxgrpc::ApiCall<GetJobRequest, Job> call);

        partial void Modify_CancelJobApiCall(ref gaxgrpc::ApiCall<CancelJobRequest, wkt::Empty> call);

        partial void Modify_CreateEnvironmentApiCall(ref gaxgrpc::ApiCall<CreateEnvironmentRequest, lro::Operation> call);

        partial void Modify_UpdateEnvironmentApiCall(ref gaxgrpc::ApiCall<UpdateEnvironmentRequest, lro::Operation> call);

        partial void Modify_DeleteEnvironmentApiCall(ref gaxgrpc::ApiCall<DeleteEnvironmentRequest, lro::Operation> call);

        partial void Modify_ListEnvironmentsApiCall(ref gaxgrpc::ApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse> call);

        partial void Modify_GetEnvironmentApiCall(ref gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> call);

        partial void Modify_ListSessionsApiCall(ref gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> call);

        partial void OnConstruction(DataplexService.DataplexServiceClient grpcClient, DataplexServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataplexService client</summary>
        public override DataplexService.DataplexServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateLakeRequest(ref CreateLakeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateLakeRequest(ref UpdateLakeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteLakeRequest(ref DeleteLakeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLakesRequest(ref ListLakesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLakeRequest(ref GetLakeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLakeActionsRequest(ref ListLakeActionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateZoneRequest(ref CreateZoneRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateZoneRequest(ref UpdateZoneRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteZoneRequest(ref DeleteZoneRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListZonesRequest(ref ListZonesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetZoneRequest(ref GetZoneRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListZoneActionsRequest(ref ListZoneActionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAssetRequest(ref CreateAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAssetRequest(ref UpdateAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAssetRequest(ref DeleteAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAssetsRequest(ref ListAssetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAssetRequest(ref GetAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAssetActionsRequest(ref ListAssetActionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTaskRequest(ref CreateTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTaskRequest(ref UpdateTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTaskRequest(ref DeleteTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTasksRequest(ref ListTasksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTaskRequest(ref GetTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListJobsRequest(ref ListJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunTaskRequest(ref RunTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetJobRequest(ref GetJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelJobRequest(ref CancelJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEnvironmentRequest(ref CreateEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEnvironmentRequest(ref UpdateEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEnvironmentRequest(ref DeleteEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEnvironmentsRequest(ref ListEnvironmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEnvironmentRequest(ref GetEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSessionsRequest(ref ListSessionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateLake</c>.</summary>
        public override lro::OperationsClient CreateLakeOperationsClient { get; }

        /// <summary>
        /// Creates a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Lake, OperationMetadata> CreateLake(CreateLakeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLakeRequest(ref request, ref callSettings);
            return new lro::Operation<Lake, OperationMetadata>(_callCreateLake.Sync(request, callSettings), CreateLakeOperationsClient);
        }

        /// <summary>
        /// Creates a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Lake, OperationMetadata>> CreateLakeAsync(CreateLakeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLakeRequest(ref request, ref callSettings);
            return new lro::Operation<Lake, OperationMetadata>(await _callCreateLake.Async(request, callSettings).ConfigureAwait(false), CreateLakeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateLake</c>.</summary>
        public override lro::OperationsClient UpdateLakeOperationsClient { get; }

        /// <summary>
        /// Updates a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Lake, OperationMetadata> UpdateLake(UpdateLakeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLakeRequest(ref request, ref callSettings);
            return new lro::Operation<Lake, OperationMetadata>(_callUpdateLake.Sync(request, callSettings), UpdateLakeOperationsClient);
        }

        /// <summary>
        /// Updates a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Lake, OperationMetadata>> UpdateLakeAsync(UpdateLakeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLakeRequest(ref request, ref callSettings);
            return new lro::Operation<Lake, OperationMetadata>(await _callUpdateLake.Async(request, callSettings).ConfigureAwait(false), UpdateLakeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteLake</c>.</summary>
        public override lro::OperationsClient DeleteLakeOperationsClient { get; }

        /// <summary>
        /// Deletes a lake resource. All zones within the lake must be deleted before
        /// the lake can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteLake(DeleteLakeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLakeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteLake.Sync(request, callSettings), DeleteLakeOperationsClient);
        }

        /// <summary>
        /// Deletes a lake resource. All zones within the lake must be deleted before
        /// the lake can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLakeAsync(DeleteLakeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLakeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteLake.Async(request, callSettings).ConfigureAwait(false), DeleteLakeOperationsClient);
        }

        /// <summary>
        /// Lists lake resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Lake"/> resources.</returns>
        public override gax::PagedEnumerable<ListLakesResponse, Lake> ListLakes(ListLakesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLakesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLakesRequest, ListLakesResponse, Lake>(_callListLakes, request, callSettings);
        }

        /// <summary>
        /// Lists lake resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Lake"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLakesResponse, Lake> ListLakesAsync(ListLakesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLakesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLakesRequest, ListLakesResponse, Lake>(_callListLakes, request, callSettings);
        }

        /// <summary>
        /// Retrieves a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Lake GetLake(GetLakeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLakeRequest(ref request, ref callSettings);
            return _callGetLake.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a lake resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Lake> GetLakeAsync(GetLakeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLakeRequest(ref request, ref callSettings);
            return _callGetLake.Async(request, callSettings);
        }

        /// <summary>
        /// Lists action resources in a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Action"/> resources.</returns>
        public override gax::PagedEnumerable<ListActionsResponse, Action> ListLakeActions(ListLakeActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLakeActionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLakeActionsRequest, ListActionsResponse, Action>(_callListLakeActions, request, callSettings);
        }

        /// <summary>
        /// Lists action resources in a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Action"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListActionsResponse, Action> ListLakeActionsAsync(ListLakeActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLakeActionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLakeActionsRequest, ListActionsResponse, Action>(_callListLakeActions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateZone</c>.</summary>
        public override lro::OperationsClient CreateZoneOperationsClient { get; }

        /// <summary>
        /// Creates a zone resource within a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Zone, OperationMetadata> CreateZone(CreateZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateZoneRequest(ref request, ref callSettings);
            return new lro::Operation<Zone, OperationMetadata>(_callCreateZone.Sync(request, callSettings), CreateZoneOperationsClient);
        }

        /// <summary>
        /// Creates a zone resource within a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Zone, OperationMetadata>> CreateZoneAsync(CreateZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateZoneRequest(ref request, ref callSettings);
            return new lro::Operation<Zone, OperationMetadata>(await _callCreateZone.Async(request, callSettings).ConfigureAwait(false), CreateZoneOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateZone</c>.</summary>
        public override lro::OperationsClient UpdateZoneOperationsClient { get; }

        /// <summary>
        /// Updates a zone resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Zone, OperationMetadata> UpdateZone(UpdateZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateZoneRequest(ref request, ref callSettings);
            return new lro::Operation<Zone, OperationMetadata>(_callUpdateZone.Sync(request, callSettings), UpdateZoneOperationsClient);
        }

        /// <summary>
        /// Updates a zone resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Zone, OperationMetadata>> UpdateZoneAsync(UpdateZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateZoneRequest(ref request, ref callSettings);
            return new lro::Operation<Zone, OperationMetadata>(await _callUpdateZone.Async(request, callSettings).ConfigureAwait(false), UpdateZoneOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteZone</c>.</summary>
        public override lro::OperationsClient DeleteZoneOperationsClient { get; }

        /// <summary>
        /// Deletes a zone resource. All assets within a zone must be deleted before
        /// the zone can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteZone(DeleteZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteZoneRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteZone.Sync(request, callSettings), DeleteZoneOperationsClient);
        }

        /// <summary>
        /// Deletes a zone resource. All assets within a zone must be deleted before
        /// the zone can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteZoneAsync(DeleteZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteZoneRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteZone.Async(request, callSettings).ConfigureAwait(false), DeleteZoneOperationsClient);
        }

        /// <summary>
        /// Lists zone resources in a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Zone"/> resources.</returns>
        public override gax::PagedEnumerable<ListZonesResponse, Zone> ListZones(ListZonesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListZonesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListZonesRequest, ListZonesResponse, Zone>(_callListZones, request, callSettings);
        }

        /// <summary>
        /// Lists zone resources in a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Zone"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListZonesResponse, Zone> ListZonesAsync(ListZonesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListZonesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListZonesRequest, ListZonesResponse, Zone>(_callListZones, request, callSettings);
        }

        /// <summary>
        /// Retrieves a zone resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Zone GetZone(GetZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetZoneRequest(ref request, ref callSettings);
            return _callGetZone.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a zone resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Zone> GetZoneAsync(GetZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetZoneRequest(ref request, ref callSettings);
            return _callGetZone.Async(request, callSettings);
        }

        /// <summary>
        /// Lists action resources in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Action"/> resources.</returns>
        public override gax::PagedEnumerable<ListActionsResponse, Action> ListZoneActions(ListZoneActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListZoneActionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListZoneActionsRequest, ListActionsResponse, Action>(_callListZoneActions, request, callSettings);
        }

        /// <summary>
        /// Lists action resources in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Action"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListActionsResponse, Action> ListZoneActionsAsync(ListZoneActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListZoneActionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListZoneActionsRequest, ListActionsResponse, Action>(_callListZoneActions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAsset</c>.</summary>
        public override lro::OperationsClient CreateAssetOperationsClient { get; }

        /// <summary>
        /// Creates an asset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Asset, OperationMetadata> CreateAsset(CreateAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssetRequest(ref request, ref callSettings);
            return new lro::Operation<Asset, OperationMetadata>(_callCreateAsset.Sync(request, callSettings), CreateAssetOperationsClient);
        }

        /// <summary>
        /// Creates an asset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Asset, OperationMetadata>> CreateAssetAsync(CreateAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssetRequest(ref request, ref callSettings);
            return new lro::Operation<Asset, OperationMetadata>(await _callCreateAsset.Async(request, callSettings).ConfigureAwait(false), CreateAssetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAsset</c>.</summary>
        public override lro::OperationsClient UpdateAssetOperationsClient { get; }

        /// <summary>
        /// Updates an asset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Asset, OperationMetadata> UpdateAsset(UpdateAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAssetRequest(ref request, ref callSettings);
            return new lro::Operation<Asset, OperationMetadata>(_callUpdateAsset.Sync(request, callSettings), UpdateAssetOperationsClient);
        }

        /// <summary>
        /// Updates an asset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Asset, OperationMetadata>> UpdateAssetAsync(UpdateAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAssetRequest(ref request, ref callSettings);
            return new lro::Operation<Asset, OperationMetadata>(await _callUpdateAsset.Async(request, callSettings).ConfigureAwait(false), UpdateAssetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAsset</c>.</summary>
        public override lro::OperationsClient DeleteAssetOperationsClient { get; }

        /// <summary>
        /// Deletes an asset resource. The referenced storage resource is detached
        /// (default) or deleted based on the associated Lifecycle policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAsset(DeleteAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAssetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAsset.Sync(request, callSettings), DeleteAssetOperationsClient);
        }

        /// <summary>
        /// Deletes an asset resource. The referenced storage resource is detached
        /// (default) or deleted based on the associated Lifecycle policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAssetAsync(DeleteAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAssetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAsset.Async(request, callSettings).ConfigureAwait(false), DeleteAssetOperationsClient);
        }

        /// <summary>
        /// Lists asset resources in a zone.
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
        /// Lists asset resources in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Asset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAssetsResponse, Asset> ListAssetsAsync(ListAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAssetsRequest, ListAssetsResponse, Asset>(_callListAssets, request, callSettings);
        }

        /// <summary>
        /// Retrieves an asset resource.
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
        /// Retrieves an asset resource.
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
        /// Lists action resources in an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Action"/> resources.</returns>
        public override gax::PagedEnumerable<ListActionsResponse, Action> ListAssetActions(ListAssetActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssetActionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAssetActionsRequest, ListActionsResponse, Action>(_callListAssetActions, request, callSettings);
        }

        /// <summary>
        /// Lists action resources in an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Action"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListActionsResponse, Action> ListAssetActionsAsync(ListAssetActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssetActionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAssetActionsRequest, ListActionsResponse, Action>(_callListAssetActions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTask</c>.</summary>
        public override lro::OperationsClient CreateTaskOperationsClient { get; }

        /// <summary>
        /// Creates a task resource within a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Task, OperationMetadata> CreateTask(CreateTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTaskRequest(ref request, ref callSettings);
            return new lro::Operation<Task, OperationMetadata>(_callCreateTask.Sync(request, callSettings), CreateTaskOperationsClient);
        }

        /// <summary>
        /// Creates a task resource within a lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Task, OperationMetadata>> CreateTaskAsync(CreateTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTaskRequest(ref request, ref callSettings);
            return new lro::Operation<Task, OperationMetadata>(await _callCreateTask.Async(request, callSettings).ConfigureAwait(false), CreateTaskOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateTask</c>.</summary>
        public override lro::OperationsClient UpdateTaskOperationsClient { get; }

        /// <summary>
        /// Update the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Task, OperationMetadata> UpdateTask(UpdateTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTaskRequest(ref request, ref callSettings);
            return new lro::Operation<Task, OperationMetadata>(_callUpdateTask.Sync(request, callSettings), UpdateTaskOperationsClient);
        }

        /// <summary>
        /// Update the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Task, OperationMetadata>> UpdateTaskAsync(UpdateTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTaskRequest(ref request, ref callSettings);
            return new lro::Operation<Task, OperationMetadata>(await _callUpdateTask.Async(request, callSettings).ConfigureAwait(false), UpdateTaskOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTask</c>.</summary>
        public override lro::OperationsClient DeleteTaskOperationsClient { get; }

        /// <summary>
        /// Delete the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteTask(DeleteTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTaskRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteTask.Sync(request, callSettings), DeleteTaskOperationsClient);
        }

        /// <summary>
        /// Delete the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTaskAsync(DeleteTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTaskRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteTask.Async(request, callSettings).ConfigureAwait(false), DeleteTaskOperationsClient);
        }

        /// <summary>
        /// Lists tasks under the given lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public override gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTasksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTasksRequest, ListTasksResponse, Task>(_callListTasks, request, callSettings);
        }

        /// <summary>
        /// Lists tasks under the given lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTasksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTasksRequest, ListTasksResponse, Task>(_callListTasks, request, callSettings);
        }

        /// <summary>
        /// Get task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Task GetTask(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaskRequest(ref request, ref callSettings);
            return _callGetTask.Sync(request, callSettings);
        }

        /// <summary>
        /// Get task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Task> GetTaskAsync(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaskRequest(ref request, ref callSettings);
            return _callGetTask.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Jobs under the given task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public override gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListJobsRequest, ListJobsResponse, Job>(_callListJobs, request, callSettings);
        }

        /// <summary>
        /// Lists Jobs under the given task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListJobsRequest, ListJobsResponse, Job>(_callListJobs, request, callSettings);
        }

        /// <summary>
        /// Run an on demand execution of a Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunTaskResponse RunTask(RunTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunTaskRequest(ref request, ref callSettings);
            return _callRunTask.Sync(request, callSettings);
        }

        /// <summary>
        /// Run an on demand execution of a Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunTaskResponse> RunTaskAsync(RunTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunTaskRequest(ref request, ref callSettings);
            return _callRunTask.Async(request, callSettings);
        }

        /// <summary>
        /// Get job resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Job GetJob(GetJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobRequest(ref request, ref callSettings);
            return _callGetJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Get job resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> GetJobAsync(GetJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobRequest(ref request, ref callSettings);
            return _callGetJob.Async(request, callSettings);
        }

        /// <summary>
        /// Cancel jobs running for the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelJob(CancelJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelJobRequest(ref request, ref callSettings);
            _callCancelJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancel jobs running for the task resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelJobAsync(CancelJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelJobRequest(ref request, ref callSettings);
            return _callCancelJob.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEnvironment</c>.</summary>
        public override lro::OperationsClient CreateEnvironmentOperationsClient { get; }

        /// <summary>
        /// Create an environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Environment, OperationMetadata> CreateEnvironment(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(_callCreateEnvironment.Sync(request, callSettings), CreateEnvironmentOperationsClient);
        }

        /// <summary>
        /// Create an environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(await _callCreateEnvironment.Async(request, callSettings).ConfigureAwait(false), CreateEnvironmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateEnvironment</c>.</summary>
        public override lro::OperationsClient UpdateEnvironmentOperationsClient { get; }

        /// <summary>
        /// Update the environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Environment, OperationMetadata> UpdateEnvironment(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(_callUpdateEnvironment.Sync(request, callSettings), UpdateEnvironmentOperationsClient);
        }

        /// <summary>
        /// Update the environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(await _callUpdateEnvironment.Async(request, callSettings).ConfigureAwait(false), UpdateEnvironmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEnvironment</c>.</summary>
        public override lro::OperationsClient DeleteEnvironmentOperationsClient { get; }

        /// <summary>
        /// Delete the environment resource. All the child resources must have been
        /// deleted before environment deletion can be initiated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteEnvironment(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteEnvironment.Sync(request, callSettings), DeleteEnvironmentOperationsClient);
        }

        /// <summary>
        /// Delete the environment resource. All the child resources must have been
        /// deleted before environment deletion can be initiated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteEnvironment.Async(request, callSettings).ConfigureAwait(false), DeleteEnvironmentOperationsClient);
        }

        /// <summary>
        /// Lists environments under the given lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnvironmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEnvironmentsRequest, ListEnvironmentsResponse, Environment>(_callListEnvironments, request, callSettings);
        }

        /// <summary>
        /// Lists environments under the given lake.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnvironmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEnvironmentsRequest, ListEnvironmentsResponse, Environment>(_callListEnvironments, request, callSettings);
        }

        /// <summary>
        /// Get environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Sync(request, callSettings);
        }

        /// <summary>
        /// Get environment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists session resources in an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public override gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSessionsRequest, ListSessionsResponse, Session>(_callListSessions, request, callSettings);
        }

        /// <summary>
        /// Lists session resources in an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSessionsRequest, ListSessionsResponse, Session>(_callListSessions, request, callSettings);
        }
    }

    public partial class ListLakesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLakeActionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListZonesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListZoneActionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAssetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAssetActionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTasksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEnvironmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSessionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLakesResponse : gaxgrpc::IPageResponse<Lake>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Lake> GetEnumerator() => Lakes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListActionsResponse : gaxgrpc::IPageResponse<Action>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Action> GetEnumerator() => Actions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListZonesResponse : gaxgrpc::IPageResponse<Zone>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Zone> GetEnumerator() => Zones.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAssetsResponse : gaxgrpc::IPageResponse<Asset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Asset> GetEnumerator() => Assets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTasksResponse : gaxgrpc::IPageResponse<Task>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Task> GetEnumerator() => Tasks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListJobsResponse : gaxgrpc::IPageResponse<Job>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Job> GetEnumerator() => Jobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEnvironmentsResponse : gaxgrpc::IPageResponse<Environment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Environment> GetEnumerator() => Environments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSessionsResponse : gaxgrpc::IPageResponse<Session>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Session> GetEnumerator() => Sessions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataplexService
    {
        public partial class DataplexServiceClient
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

    public static partial class DataplexService
    {
        public partial class DataplexServiceClient
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
