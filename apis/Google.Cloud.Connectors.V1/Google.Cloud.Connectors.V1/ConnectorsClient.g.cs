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

namespace Google.Cloud.Connectors.V1
{
    /// <summary>Settings for <see cref="ConnectorsClient"/> instances.</summary>
    public sealed partial class ConnectorsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConnectorsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConnectorsSettings"/>.</returns>
        public static ConnectorsSettings GetDefault() => new ConnectorsSettings();

        /// <summary>Constructs a new <see cref="ConnectorsSettings"/> object with default settings.</summary>
        public ConnectorsSettings()
        {
        }

        private ConnectorsSettings(ConnectorsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListConnectionsSettings = existing.ListConnectionsSettings;
            GetConnectionSettings = existing.GetConnectionSettings;
            CreateConnectionSettings = existing.CreateConnectionSettings;
            CreateConnectionOperationsSettings = existing.CreateConnectionOperationsSettings.Clone();
            UpdateConnectionSettings = existing.UpdateConnectionSettings;
            UpdateConnectionOperationsSettings = existing.UpdateConnectionOperationsSettings.Clone();
            DeleteConnectionSettings = existing.DeleteConnectionSettings;
            DeleteConnectionOperationsSettings = existing.DeleteConnectionOperationsSettings.Clone();
            ListProvidersSettings = existing.ListProvidersSettings;
            GetProviderSettings = existing.GetProviderSettings;
            ListConnectorsSettings = existing.ListConnectorsSettings;
            GetConnectorSettings = existing.GetConnectorSettings;
            ListConnectorVersionsSettings = existing.ListConnectorVersionsSettings;
            GetConnectorVersionSettings = existing.GetConnectorVersionSettings;
            GetConnectionSchemaMetadataSettings = existing.GetConnectionSchemaMetadataSettings;
            RefreshConnectionSchemaMetadataSettings = existing.RefreshConnectionSchemaMetadataSettings;
            RefreshConnectionSchemaMetadataOperationsSettings = existing.RefreshConnectionSchemaMetadataOperationsSettings.Clone();
            ListRuntimeEntitySchemasSettings = existing.ListRuntimeEntitySchemasSettings;
            ListRuntimeActionSchemasSettings = existing.ListRuntimeActionSchemasSettings;
            GetRuntimeConfigSettings = existing.GetRuntimeConfigSettings;
            GetGlobalSettingsSettings = existing.GetGlobalSettingsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConnectorsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.ListConnections</c> and <c>ConnectorsClient.ListConnectionsAsync</c>.
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
        public gaxgrpc::CallSettings ListConnectionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.GetConnection</c> and <c>ConnectorsClient.GetConnectionAsync</c>.
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
        public gaxgrpc::CallSettings GetConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.CreateConnection</c> and <c>ConnectorsClient.CreateConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConnectorsClient.CreateConnection</c> and
        /// <c>ConnectorsClient.CreateConnectionAsync</c>.
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
        public lro::OperationsSettings CreateConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.UpdateConnection</c> and <c>ConnectorsClient.UpdateConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConnectorsClient.UpdateConnection</c> and
        /// <c>ConnectorsClient.UpdateConnectionAsync</c>.
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
        public lro::OperationsSettings UpdateConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.DeleteConnection</c> and <c>ConnectorsClient.DeleteConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConnectorsClient.DeleteConnection</c> and
        /// <c>ConnectorsClient.DeleteConnectionAsync</c>.
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
        public lro::OperationsSettings DeleteConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.ListProviders</c> and <c>ConnectorsClient.ListProvidersAsync</c>.
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
        public gaxgrpc::CallSettings ListProvidersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.GetProvider</c> and <c>ConnectorsClient.GetProviderAsync</c>.
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
        public gaxgrpc::CallSettings GetProviderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.ListConnectors</c> and <c>ConnectorsClient.ListConnectorsAsync</c>.
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
        public gaxgrpc::CallSettings ListConnectorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.GetConnector</c> and <c>ConnectorsClient.GetConnectorAsync</c>.
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
        public gaxgrpc::CallSettings GetConnectorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.ListConnectorVersions</c> and <c>ConnectorsClient.ListConnectorVersionsAsync</c>.
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
        public gaxgrpc::CallSettings ListConnectorVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.GetConnectorVersion</c> and <c>ConnectorsClient.GetConnectorVersionAsync</c>.
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
        public gaxgrpc::CallSettings GetConnectorVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.GetConnectionSchemaMetadata</c> and <c>ConnectorsClient.GetConnectionSchemaMetadataAsync</c>
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
        public gaxgrpc::CallSettings GetConnectionSchemaMetadataSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.RefreshConnectionSchemaMetadata</c> and
        /// <c>ConnectorsClient.RefreshConnectionSchemaMetadataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RefreshConnectionSchemaMetadataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConnectorsClient.RefreshConnectionSchemaMetadata</c> and
        /// <c>ConnectorsClient.RefreshConnectionSchemaMetadataAsync</c>.
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
        public lro::OperationsSettings RefreshConnectionSchemaMetadataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.ListRuntimeEntitySchemas</c> and <c>ConnectorsClient.ListRuntimeEntitySchemasAsync</c>.
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
        public gaxgrpc::CallSettings ListRuntimeEntitySchemasSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.ListRuntimeActionSchemas</c> and <c>ConnectorsClient.ListRuntimeActionSchemasAsync</c>.
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
        public gaxgrpc::CallSettings ListRuntimeActionSchemasSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.GetRuntimeConfig</c> and <c>ConnectorsClient.GetRuntimeConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetRuntimeConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConnectorsClient.GetGlobalSettings</c> and <c>ConnectorsClient.GetGlobalSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGlobalSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConnectorsSettings"/> object.</returns>
        public ConnectorsSettings Clone() => new ConnectorsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConnectorsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ConnectorsClientBuilder : gaxgrpc::ClientBuilderBase<ConnectorsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConnectorsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConnectorsClientBuilder() : base(ConnectorsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConnectorsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConnectorsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConnectorsClient Build()
        {
            ConnectorsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConnectorsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConnectorsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConnectorsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConnectorsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConnectorsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConnectorsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConnectorsClient.ChannelPool;
    }

    /// <summary>Connectors client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Connectors is the interface for managing Connectors.
    /// </remarks>
    public abstract partial class ConnectorsClient
    {
        /// <summary>
        /// The default endpoint for the Connectors service, which is a host of "connectors.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "connectors.googleapis.com:443";

        /// <summary>The default Connectors scopes.</summary>
        /// <remarks>
        /// The default Connectors scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Connectors.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConnectorsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ConnectorsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConnectorsClient"/>.</returns>
        public static stt::Task<ConnectorsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConnectorsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConnectorsClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="ConnectorsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConnectorsClient"/>.</returns>
        public static ConnectorsClient Create() => new ConnectorsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConnectorsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConnectorsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConnectorsClient"/>.</returns>
        internal static ConnectorsClient Create(grpccore::CallInvoker callInvoker, ConnectorsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Connectors.ConnectorsClient grpcClient = new Connectors.ConnectorsClient(callInvoker);
            return new ConnectorsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Connectors client</summary>
        public virtual Connectors.ConnectorsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Connection, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
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
            return ListConnections(request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Connection, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
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
            return ListConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Connection, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
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
            return ListConnections(request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Connection, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
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
            return ListConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection GetConnection(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(GetConnectionRequest request, st::CancellationToken cancellationToken) =>
            GetConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/connections/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection GetConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnection(new GetConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/connections/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionAsync(new GetConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/connections/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/connections/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection GetConnection(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnection(new GetConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/connections/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionAsync(new GetConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/connections/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(ConnectionName name, st::CancellationToken cancellationToken) =>
            GetConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Connection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> CreateConnection(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Connection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Connection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(CreateConnectionRequest request, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConnection</c>.</summary>
        public virtual lro::OperationsClient CreateConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> PollOnceCreateConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Connection, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> PollOnceCreateConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Connection, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Connection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Connection, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="connection">
        /// Required. Connection resource.
        /// </param>
        /// <param name="connectionId">
        /// Required. Identifier to assign to the Connection. Must be unique within
        /// scope of the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> CreateConnection(string parent, Connection connection, string connectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnection(new CreateConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Creates a new Connection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Connection, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="connection">
        /// Required. Connection resource.
        /// </param>
        /// <param name="connectionId">
        /// Required. Identifier to assign to the Connection. Must be unique within
        /// scope of the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(string parent, Connection connection, string connectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionAsync(new CreateConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Creates a new Connection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Connection, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="connection">
        /// Required. Connection resource.
        /// </param>
        /// <param name="connectionId">
        /// Required. Identifier to assign to the Connection. Must be unique within
        /// scope of the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(string parent, Connection connection, string connectionId, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(parent, connection, connectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Connection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Connection, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="connection">
        /// Required. Connection resource.
        /// </param>
        /// <param name="connectionId">
        /// Required. Identifier to assign to the Connection. Must be unique within
        /// scope of the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> CreateConnection(gagr::LocationName parent, Connection connection, string connectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnection(new CreateConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Creates a new Connection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Connection, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="connection">
        /// Required. Connection resource.
        /// </param>
        /// <param name="connectionId">
        /// Required. Identifier to assign to the Connection. Must be unique within
        /// scope of the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(gagr::LocationName parent, Connection connection, string connectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionAsync(new CreateConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Creates a new Connection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Connection, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="connection">
        /// Required. Connection resource.
        /// </param>
        /// <param name="connectionId">
        /// Required. Identifier to assign to the Connection. Must be unique within
        /// scope of the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(gagr::LocationName parent, Connection connection, string connectionId, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(parent, connection, connectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> UpdateConnection(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> UpdateConnectionAsync(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> UpdateConnectionAsync(UpdateConnectionRequest request, st::CancellationToken cancellationToken) =>
            UpdateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateConnection</c>.</summary>
        public virtual lro::OperationsClient UpdateConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> PollOnceUpdateConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Connection, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> PollOnceUpdateConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Connection, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Connection.
        /// </summary>
        /// <param name="connection">
        /// Required. Connection resource.
        /// </param>
        /// <param name="updateMask">
        /// Required. You can modify only the fields listed below.
        /// 
        /// To lock/unlock a connection:
        /// * `lock_config`
        /// 
        /// To suspend/resume a connection:
        /// * `suspended`
        /// 
        /// To update the connection details:
        /// * `description`
        /// * `labels`
        /// * `connector_version`
        /// * `config_variables`
        /// * `auth_config`
        /// * `destination_configs`
        /// * `node_config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> UpdateConnection(Connection connection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnection(new UpdateConnectionRequest
            {
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Connection.
        /// </summary>
        /// <param name="connection">
        /// Required. Connection resource.
        /// </param>
        /// <param name="updateMask">
        /// Required. You can modify only the fields listed below.
        /// 
        /// To lock/unlock a connection:
        /// * `lock_config`
        /// 
        /// To suspend/resume a connection:
        /// * `suspended`
        /// 
        /// To update the connection details:
        /// * `description`
        /// * `labels`
        /// * `connector_version`
        /// * `config_variables`
        /// * `auth_config`
        /// * `destination_configs`
        /// * `node_config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> UpdateConnectionAsync(Connection connection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectionAsync(new UpdateConnectionRequest
            {
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Connection.
        /// </summary>
        /// <param name="connection">
        /// Required. Connection resource.
        /// </param>
        /// <param name="updateMask">
        /// Required. You can modify only the fields listed below.
        /// 
        /// To lock/unlock a connection:
        /// * `lock_config`
        /// 
        /// To suspend/resume a connection:
        /// * `suspended`
        /// 
        /// To update the connection details:
        /// * `description`
        /// * `labels`
        /// * `connector_version`
        /// * `config_variables`
        /// * `auth_config`
        /// * `destination_configs`
        /// * `node_config`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> UpdateConnectionAsync(Connection connection, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConnectionAsync(connection, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnection(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(DeleteConnectionRequest request, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteConnection</c>.</summary>
        public virtual lro::OperationsClient DeleteConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/connections/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnection(new DeleteConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/connections/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionAsync(new DeleteConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/connections/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/connections/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnection(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnection(new DeleteConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/connections/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionAsync(new DeleteConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/connections/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(ConnectionName name, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Providers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Provider"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProvidersResponse, Provider> ListProviders(ListProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Providers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Provider"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProvidersResponse, Provider> ListProvidersAsync(ListProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Providers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/*`
        /// Only global location is supported for Provider resource.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Provider"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProvidersResponse, Provider> ListProviders(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProvidersRequest request = new ListProvidersRequest
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
            return ListProviders(request, callSettings);
        }

        /// <summary>
        /// Lists Providers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/*`
        /// Only global location is supported for Provider resource.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Provider"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProvidersResponse, Provider> ListProvidersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProvidersRequest request = new ListProvidersRequest
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
            return ListProvidersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Providers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/*`
        /// Only global location is supported for Provider resource.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Provider"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProvidersResponse, Provider> ListProviders(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProvidersRequest request = new ListProvidersRequest
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
            return ListProviders(request, callSettings);
        }

        /// <summary>
        /// Lists Providers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/*`
        /// Only global location is supported for Provider resource.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Provider"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProvidersResponse, Provider> ListProvidersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProvidersRequest request = new ListProvidersRequest
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
            return ListProvidersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a provider.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Provider GetProvider(GetProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a provider.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Provider> GetProviderAsync(GetProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a provider.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Provider> GetProviderAsync(GetProviderRequest request, st::CancellationToken cancellationToken) =>
            GetProviderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a provider.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*`
        /// Only global location is supported for Provider resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Provider GetProvider(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProvider(new GetProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a provider.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*`
        /// Only global location is supported for Provider resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Provider> GetProviderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProviderAsync(new GetProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a provider.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*`
        /// Only global location is supported for Provider resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Provider> GetProviderAsync(string name, st::CancellationToken cancellationToken) =>
            GetProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a provider.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*`
        /// Only global location is supported for Provider resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Provider GetProvider(ProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProvider(new GetProviderRequest
            {
                ProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a provider.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*`
        /// Only global location is supported for Provider resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Provider> GetProviderAsync(ProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProviderAsync(new GetProviderRequest
            {
                ProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a provider.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*`
        /// Only global location is supported for Provider resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Provider> GetProviderAsync(ProviderName name, st::CancellationToken cancellationToken) =>
            GetProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Connectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectorsResponse, Connector> ListConnectors(ListConnectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Connectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectorsResponse, Connector> ListConnectorsAsync(ListConnectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Connectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the connectors, of the form:
        /// `projects/*/locations/*/providers/*`
        /// Only global location is supported for Connector resource.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectorsResponse, Connector> ListConnectors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorsRequest request = new ListConnectorsRequest
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
            return ListConnectors(request, callSettings);
        }

        /// <summary>
        /// Lists Connectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the connectors, of the form:
        /// `projects/*/locations/*/providers/*`
        /// Only global location is supported for Connector resource.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectorsResponse, Connector> ListConnectorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorsRequest request = new ListConnectorsRequest
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
            return ListConnectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Connectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the connectors, of the form:
        /// `projects/*/locations/*/providers/*`
        /// Only global location is supported for Connector resource.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectorsResponse, Connector> ListConnectors(ProviderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                ParentAsProviderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConnectors(request, callSettings);
        }

        /// <summary>
        /// Lists Connectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the connectors, of the form:
        /// `projects/*/locations/*/providers/*`
        /// Only global location is supported for Connector resource.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectorsResponse, Connector> ListConnectorsAsync(ProviderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                ParentAsProviderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConnectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector GetConnector(GetConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(GetConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(GetConnectorRequest request, st::CancellationToken cancellationToken) =>
            GetConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Connector.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*/connectors/*`
        /// Only global location is supported for Connector resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector GetConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnector(new GetConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Connector.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*/connectors/*`
        /// Only global location is supported for Connector resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectorAsync(new GetConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Connector.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*/connectors/*`
        /// Only global location is supported for Connector resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Connector.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*/connectors/*`
        /// Only global location is supported for Connector resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector GetConnector(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnector(new GetConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Connector.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*/connectors/*`
        /// Only global location is supported for Connector resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectorAsync(new GetConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Connector.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*/connectors/*`
        /// Only global location is supported for Connector resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(ConnectorName name, st::CancellationToken cancellationToken) =>
            GetConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Connector Versions in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectorVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectorVersionsResponse, ConnectorVersion> ListConnectorVersions(ListConnectorVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Connector Versions in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectorVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectorVersionsResponse, ConnectorVersion> ListConnectorVersionsAsync(ListConnectorVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Connector Versions in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the connectors, of the form:
        /// `projects/*/locations/*/providers/*/connectors/*`
        /// Only global location is supported for ConnectorVersion resource.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectorVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectorVersionsResponse, ConnectorVersion> ListConnectorVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorVersionsRequest request = new ListConnectorVersionsRequest
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
            return ListConnectorVersions(request, callSettings);
        }

        /// <summary>
        /// Lists Connector Versions in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the connectors, of the form:
        /// `projects/*/locations/*/providers/*/connectors/*`
        /// Only global location is supported for ConnectorVersion resource.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectorVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectorVersionsResponse, ConnectorVersion> ListConnectorVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorVersionsRequest request = new ListConnectorVersionsRequest
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
            return ListConnectorVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Connector Versions in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the connectors, of the form:
        /// `projects/*/locations/*/providers/*/connectors/*`
        /// Only global location is supported for ConnectorVersion resource.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectorVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectorVersionsResponse, ConnectorVersion> ListConnectorVersions(ConnectorName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorVersionsRequest request = new ListConnectorVersionsRequest
            {
                ParentAsConnectorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConnectorVersions(request, callSettings);
        }

        /// <summary>
        /// Lists Connector Versions in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the connectors, of the form:
        /// `projects/*/locations/*/providers/*/connectors/*`
        /// Only global location is supported for ConnectorVersion resource.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectorVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectorVersionsResponse, ConnectorVersion> ListConnectorVersionsAsync(ConnectorName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorVersionsRequest request = new ListConnectorVersionsRequest
            {
                ParentAsConnectorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConnectorVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single connector version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectorVersion GetConnectorVersion(GetConnectorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single connector version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectorVersion> GetConnectorVersionAsync(GetConnectorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single connector version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectorVersion> GetConnectorVersionAsync(GetConnectorVersionRequest request, st::CancellationToken cancellationToken) =>
            GetConnectorVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single connector version.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*/connectors/*/versions/*`
        /// Only global location is supported for ConnectorVersion resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectorVersion GetConnectorVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectorVersion(new GetConnectorVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connector version.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*/connectors/*/versions/*`
        /// Only global location is supported for ConnectorVersion resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectorVersion> GetConnectorVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectorVersionAsync(new GetConnectorVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connector version.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*/connectors/*/versions/*`
        /// Only global location is supported for ConnectorVersion resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectorVersion> GetConnectorVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectorVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single connector version.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*/connectors/*/versions/*`
        /// Only global location is supported for ConnectorVersion resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectorVersion GetConnectorVersion(ConnectorVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectorVersion(new GetConnectorVersionRequest
            {
                ConnectorVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connector version.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*/connectors/*/versions/*`
        /// Only global location is supported for ConnectorVersion resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectorVersion> GetConnectorVersionAsync(ConnectorVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectorVersionAsync(new GetConnectorVersionRequest
            {
                ConnectorVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connector version.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/providers/*/connectors/*/versions/*`
        /// Only global location is supported for ConnectorVersion resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectorVersion> GetConnectorVersionAsync(ConnectorVersionName name, st::CancellationToken cancellationToken) =>
            GetConnectorVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets schema metadata of a connection.
        /// SchemaMetadata is a singleton resource for each connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionSchemaMetadata GetConnectionSchemaMetadata(GetConnectionSchemaMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets schema metadata of a connection.
        /// SchemaMetadata is a singleton resource for each connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionSchemaMetadata> GetConnectionSchemaMetadataAsync(GetConnectionSchemaMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets schema metadata of a connection.
        /// SchemaMetadata is a singleton resource for each connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionSchemaMetadata> GetConnectionSchemaMetadataAsync(GetConnectionSchemaMetadataRequest request, st::CancellationToken cancellationToken) =>
            GetConnectionSchemaMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets schema metadata of a connection.
        /// SchemaMetadata is a singleton resource for each connection.
        /// </summary>
        /// <param name="name">
        /// Required. Connection name
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionSchemaMetadata GetConnectionSchemaMetadata(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionSchemaMetadata(new GetConnectionSchemaMetadataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets schema metadata of a connection.
        /// SchemaMetadata is a singleton resource for each connection.
        /// </summary>
        /// <param name="name">
        /// Required. Connection name
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionSchemaMetadata> GetConnectionSchemaMetadataAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionSchemaMetadataAsync(new GetConnectionSchemaMetadataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets schema metadata of a connection.
        /// SchemaMetadata is a singleton resource for each connection.
        /// </summary>
        /// <param name="name">
        /// Required. Connection name
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionSchemaMetadata> GetConnectionSchemaMetadataAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectionSchemaMetadataAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets schema metadata of a connection.
        /// SchemaMetadata is a singleton resource for each connection.
        /// </summary>
        /// <param name="name">
        /// Required. Connection name
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionSchemaMetadata GetConnectionSchemaMetadata(ConnectionSchemaMetadataName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionSchemaMetadata(new GetConnectionSchemaMetadataRequest
            {
                ConnectionSchemaMetadataName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets schema metadata of a connection.
        /// SchemaMetadata is a singleton resource for each connection.
        /// </summary>
        /// <param name="name">
        /// Required. Connection name
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionSchemaMetadata> GetConnectionSchemaMetadataAsync(ConnectionSchemaMetadataName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionSchemaMetadataAsync(new GetConnectionSchemaMetadataRequest
            {
                ConnectionSchemaMetadataName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets schema metadata of a connection.
        /// SchemaMetadata is a singleton resource for each connection.
        /// </summary>
        /// <param name="name">
        /// Required. Connection name
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionSchemaMetadata> GetConnectionSchemaMetadataAsync(ConnectionSchemaMetadataName name, st::CancellationToken cancellationToken) =>
            GetConnectionSchemaMetadataAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Refresh runtime schema of a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionSchemaMetadata, OperationMetadata> RefreshConnectionSchemaMetadata(RefreshConnectionSchemaMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Refresh runtime schema of a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionSchemaMetadata, OperationMetadata>> RefreshConnectionSchemaMetadataAsync(RefreshConnectionSchemaMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Refresh runtime schema of a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionSchemaMetadata, OperationMetadata>> RefreshConnectionSchemaMetadataAsync(RefreshConnectionSchemaMetadataRequest request, st::CancellationToken cancellationToken) =>
            RefreshConnectionSchemaMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RefreshConnectionSchemaMetadata</c>.</summary>
        public virtual lro::OperationsClient RefreshConnectionSchemaMetadataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RefreshConnectionSchemaMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConnectionSchemaMetadata, OperationMetadata> PollOnceRefreshConnectionSchemaMetadata(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionSchemaMetadata, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RefreshConnectionSchemaMetadataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RefreshConnectionSchemaMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConnectionSchemaMetadata, OperationMetadata>> PollOnceRefreshConnectionSchemaMetadataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionSchemaMetadata, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RefreshConnectionSchemaMetadataOperationsClient, callSettings);

        /// <summary>
        /// Refresh runtime schema of a connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name.
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionSchemaMetadata, OperationMetadata> RefreshConnectionSchemaMetadata(string name, gaxgrpc::CallSettings callSettings = null) =>
            RefreshConnectionSchemaMetadata(new RefreshConnectionSchemaMetadataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Refresh runtime schema of a connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name.
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionSchemaMetadata, OperationMetadata>> RefreshConnectionSchemaMetadataAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RefreshConnectionSchemaMetadataAsync(new RefreshConnectionSchemaMetadataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Refresh runtime schema of a connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name.
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionSchemaMetadata, OperationMetadata>> RefreshConnectionSchemaMetadataAsync(string name, st::CancellationToken cancellationToken) =>
            RefreshConnectionSchemaMetadataAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Refresh runtime schema of a connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name.
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionSchemaMetadata, OperationMetadata> RefreshConnectionSchemaMetadata(ConnectionSchemaMetadataName name, gaxgrpc::CallSettings callSettings = null) =>
            RefreshConnectionSchemaMetadata(new RefreshConnectionSchemaMetadataRequest
            {
                ConnectionSchemaMetadataName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Refresh runtime schema of a connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name.
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionSchemaMetadata, OperationMetadata>> RefreshConnectionSchemaMetadataAsync(ConnectionSchemaMetadataName name, gaxgrpc::CallSettings callSettings = null) =>
            RefreshConnectionSchemaMetadataAsync(new RefreshConnectionSchemaMetadataRequest
            {
                ConnectionSchemaMetadataName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Refresh runtime schema of a connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name.
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionSchemaMetadata, OperationMetadata>> RefreshConnectionSchemaMetadataAsync(ConnectionSchemaMetadataName name, st::CancellationToken cancellationToken) =>
            RefreshConnectionSchemaMetadataAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List schema of a runtime entities filtered by entity name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuntimeEntitySchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> ListRuntimeEntitySchemas(ListRuntimeEntitySchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List schema of a runtime entities filtered by entity name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuntimeEntitySchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> ListRuntimeEntitySchemasAsync(ListRuntimeEntitySchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List schema of a runtime entities filtered by entity name.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of RuntimeEntitySchema
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuntimeEntitySchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> ListRuntimeEntitySchemas(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimeEntitySchemasRequest request = new ListRuntimeEntitySchemasRequest
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
            return ListRuntimeEntitySchemas(request, callSettings);
        }

        /// <summary>
        /// List schema of a runtime entities filtered by entity name.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of RuntimeEntitySchema
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuntimeEntitySchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> ListRuntimeEntitySchemasAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimeEntitySchemasRequest request = new ListRuntimeEntitySchemasRequest
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
            return ListRuntimeEntitySchemasAsync(request, callSettings);
        }

        /// <summary>
        /// List schema of a runtime entities filtered by entity name.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of RuntimeEntitySchema
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuntimeEntitySchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> ListRuntimeEntitySchemas(ConnectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimeEntitySchemasRequest request = new ListRuntimeEntitySchemasRequest
            {
                ParentAsConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuntimeEntitySchemas(request, callSettings);
        }

        /// <summary>
        /// List schema of a runtime entities filtered by entity name.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of RuntimeEntitySchema
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuntimeEntitySchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> ListRuntimeEntitySchemasAsync(ConnectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimeEntitySchemasRequest request = new ListRuntimeEntitySchemasRequest
            {
                ParentAsConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuntimeEntitySchemasAsync(request, callSettings);
        }

        /// <summary>
        /// List schema of a runtime actions filtered by action name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuntimeActionSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> ListRuntimeActionSchemas(ListRuntimeActionSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List schema of a runtime actions filtered by action name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuntimeActionSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> ListRuntimeActionSchemasAsync(ListRuntimeActionSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List schema of a runtime actions filtered by action name.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of RuntimeActionSchema
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuntimeActionSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> ListRuntimeActionSchemas(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimeActionSchemasRequest request = new ListRuntimeActionSchemasRequest
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
            return ListRuntimeActionSchemas(request, callSettings);
        }

        /// <summary>
        /// List schema of a runtime actions filtered by action name.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of RuntimeActionSchema
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuntimeActionSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> ListRuntimeActionSchemasAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimeActionSchemasRequest request = new ListRuntimeActionSchemasRequest
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
            return ListRuntimeActionSchemasAsync(request, callSettings);
        }

        /// <summary>
        /// List schema of a runtime actions filtered by action name.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of RuntimeActionSchema
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuntimeActionSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> ListRuntimeActionSchemas(ConnectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimeActionSchemasRequest request = new ListRuntimeActionSchemasRequest
            {
                ParentAsConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuntimeActionSchemas(request, callSettings);
        }

        /// <summary>
        /// List schema of a runtime actions filtered by action name.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of RuntimeActionSchema
        /// Format:
        /// projects/{project}/locations/{location}/connections/{connection}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuntimeActionSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> ListRuntimeActionSchemasAsync(ConnectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimeActionSchemasRequest request = new ListRuntimeActionSchemasRequest
            {
                ParentAsConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuntimeActionSchemasAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the runtimeConfig of a location.
        /// RuntimeConfig is a singleton resource for each location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuntimeConfig GetRuntimeConfig(GetRuntimeConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the runtimeConfig of a location.
        /// RuntimeConfig is a singleton resource for each location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeConfig> GetRuntimeConfigAsync(GetRuntimeConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the runtimeConfig of a location.
        /// RuntimeConfig is a singleton resource for each location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeConfig> GetRuntimeConfigAsync(GetRuntimeConfigRequest request, st::CancellationToken cancellationToken) =>
            GetRuntimeConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the runtimeConfig of a location.
        /// RuntimeConfig is a singleton resource for each location.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/runtimeConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuntimeConfig GetRuntimeConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuntimeConfig(new GetRuntimeConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the runtimeConfig of a location.
        /// RuntimeConfig is a singleton resource for each location.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/runtimeConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeConfig> GetRuntimeConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuntimeConfigAsync(new GetRuntimeConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the runtimeConfig of a location.
        /// RuntimeConfig is a singleton resource for each location.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/runtimeConfig`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeConfig> GetRuntimeConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetRuntimeConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the runtimeConfig of a location.
        /// RuntimeConfig is a singleton resource for each location.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/runtimeConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuntimeConfig GetRuntimeConfig(RuntimeConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuntimeConfig(new GetRuntimeConfigRequest
            {
                RuntimeConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the runtimeConfig of a location.
        /// RuntimeConfig is a singleton resource for each location.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/runtimeConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeConfig> GetRuntimeConfigAsync(RuntimeConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuntimeConfigAsync(new GetRuntimeConfigRequest
            {
                RuntimeConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the runtimeConfig of a location.
        /// RuntimeConfig is a singleton resource for each location.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/runtimeConfig`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeConfig> GetRuntimeConfigAsync(RuntimeConfigName name, st::CancellationToken cancellationToken) =>
            GetRuntimeConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// GetGlobalSettings gets settings of a project.
        /// GlobalSettings is a singleton resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetGlobalSettings(GetGlobalSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GetGlobalSettings gets settings of a project.
        /// GlobalSettings is a singleton resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetGlobalSettingsAsync(GetGlobalSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GetGlobalSettings gets settings of a project.
        /// GlobalSettings is a singleton resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetGlobalSettingsAsync(GetGlobalSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetGlobalSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// GetGlobalSettings gets settings of a project.
        /// GlobalSettings is a singleton resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetGlobalSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlobalSettings(new GetGlobalSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// GetGlobalSettings gets settings of a project.
        /// GlobalSettings is a singleton resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetGlobalSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlobalSettingsAsync(new GetGlobalSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// GetGlobalSettings gets settings of a project.
        /// GlobalSettings is a singleton resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Settings.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetGlobalSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetGlobalSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// GetGlobalSettings gets settings of a project.
        /// GlobalSettings is a singleton resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetGlobalSettings(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlobalSettings(new GetGlobalSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// GetGlobalSettings gets settings of a project.
        /// GlobalSettings is a singleton resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetGlobalSettingsAsync(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlobalSettingsAsync(new GetGlobalSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// GetGlobalSettings gets settings of a project.
        /// GlobalSettings is a singleton resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Settings.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetGlobalSettingsAsync(SettingsName name, st::CancellationToken cancellationToken) =>
            GetGlobalSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Connectors client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Connectors is the interface for managing Connectors.
    /// </remarks>
    public sealed partial class ConnectorsClientImpl : ConnectorsClient
    {
        private readonly gaxgrpc::ApiCall<ListConnectionsRequest, ListConnectionsResponse> _callListConnections;

        private readonly gaxgrpc::ApiCall<GetConnectionRequest, Connection> _callGetConnection;

        private readonly gaxgrpc::ApiCall<CreateConnectionRequest, lro::Operation> _callCreateConnection;

        private readonly gaxgrpc::ApiCall<UpdateConnectionRequest, lro::Operation> _callUpdateConnection;

        private readonly gaxgrpc::ApiCall<DeleteConnectionRequest, lro::Operation> _callDeleteConnection;

        private readonly gaxgrpc::ApiCall<ListProvidersRequest, ListProvidersResponse> _callListProviders;

        private readonly gaxgrpc::ApiCall<GetProviderRequest, Provider> _callGetProvider;

        private readonly gaxgrpc::ApiCall<ListConnectorsRequest, ListConnectorsResponse> _callListConnectors;

        private readonly gaxgrpc::ApiCall<GetConnectorRequest, Connector> _callGetConnector;

        private readonly gaxgrpc::ApiCall<ListConnectorVersionsRequest, ListConnectorVersionsResponse> _callListConnectorVersions;

        private readonly gaxgrpc::ApiCall<GetConnectorVersionRequest, ConnectorVersion> _callGetConnectorVersion;

        private readonly gaxgrpc::ApiCall<GetConnectionSchemaMetadataRequest, ConnectionSchemaMetadata> _callGetConnectionSchemaMetadata;

        private readonly gaxgrpc::ApiCall<RefreshConnectionSchemaMetadataRequest, lro::Operation> _callRefreshConnectionSchemaMetadata;

        private readonly gaxgrpc::ApiCall<ListRuntimeEntitySchemasRequest, ListRuntimeEntitySchemasResponse> _callListRuntimeEntitySchemas;

        private readonly gaxgrpc::ApiCall<ListRuntimeActionSchemasRequest, ListRuntimeActionSchemasResponse> _callListRuntimeActionSchemas;

        private readonly gaxgrpc::ApiCall<GetRuntimeConfigRequest, RuntimeConfig> _callGetRuntimeConfig;

        private readonly gaxgrpc::ApiCall<GetGlobalSettingsRequest, Settings> _callGetGlobalSettings;

        /// <summary>
        /// Constructs a client wrapper for the Connectors service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConnectorsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConnectorsClientImpl(Connectors.ConnectorsClient grpcClient, ConnectorsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConnectorsSettings effectiveSettings = settings ?? ConnectorsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConnectionOperationsSettings, logger);
            UpdateConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateConnectionOperationsSettings, logger);
            DeleteConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConnectionOperationsSettings, logger);
            RefreshConnectionSchemaMetadataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RefreshConnectionSchemaMetadataOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListConnections = clientHelper.BuildApiCall<ListConnectionsRequest, ListConnectionsResponse>("ListConnections", grpcClient.ListConnectionsAsync, grpcClient.ListConnections, effectiveSettings.ListConnectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConnections);
            Modify_ListConnectionsApiCall(ref _callListConnections);
            _callGetConnection = clientHelper.BuildApiCall<GetConnectionRequest, Connection>("GetConnection", grpcClient.GetConnectionAsync, grpcClient.GetConnection, effectiveSettings.GetConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnection);
            Modify_GetConnectionApiCall(ref _callGetConnection);
            _callCreateConnection = clientHelper.BuildApiCall<CreateConnectionRequest, lro::Operation>("CreateConnection", grpcClient.CreateConnectionAsync, grpcClient.CreateConnection, effectiveSettings.CreateConnectionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConnection);
            Modify_CreateConnectionApiCall(ref _callCreateConnection);
            _callUpdateConnection = clientHelper.BuildApiCall<UpdateConnectionRequest, lro::Operation>("UpdateConnection", grpcClient.UpdateConnectionAsync, grpcClient.UpdateConnection, effectiveSettings.UpdateConnectionSettings).WithGoogleRequestParam("connection.name", request => request.Connection?.Name);
            Modify_ApiCall(ref _callUpdateConnection);
            Modify_UpdateConnectionApiCall(ref _callUpdateConnection);
            _callDeleteConnection = clientHelper.BuildApiCall<DeleteConnectionRequest, lro::Operation>("DeleteConnection", grpcClient.DeleteConnectionAsync, grpcClient.DeleteConnection, effectiveSettings.DeleteConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConnection);
            Modify_DeleteConnectionApiCall(ref _callDeleteConnection);
            _callListProviders = clientHelper.BuildApiCall<ListProvidersRequest, ListProvidersResponse>("ListProviders", grpcClient.ListProvidersAsync, grpcClient.ListProviders, effectiveSettings.ListProvidersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProviders);
            Modify_ListProvidersApiCall(ref _callListProviders);
            _callGetProvider = clientHelper.BuildApiCall<GetProviderRequest, Provider>("GetProvider", grpcClient.GetProviderAsync, grpcClient.GetProvider, effectiveSettings.GetProviderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProvider);
            Modify_GetProviderApiCall(ref _callGetProvider);
            _callListConnectors = clientHelper.BuildApiCall<ListConnectorsRequest, ListConnectorsResponse>("ListConnectors", grpcClient.ListConnectorsAsync, grpcClient.ListConnectors, effectiveSettings.ListConnectorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConnectors);
            Modify_ListConnectorsApiCall(ref _callListConnectors);
            _callGetConnector = clientHelper.BuildApiCall<GetConnectorRequest, Connector>("GetConnector", grpcClient.GetConnectorAsync, grpcClient.GetConnector, effectiveSettings.GetConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnector);
            Modify_GetConnectorApiCall(ref _callGetConnector);
            _callListConnectorVersions = clientHelper.BuildApiCall<ListConnectorVersionsRequest, ListConnectorVersionsResponse>("ListConnectorVersions", grpcClient.ListConnectorVersionsAsync, grpcClient.ListConnectorVersions, effectiveSettings.ListConnectorVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConnectorVersions);
            Modify_ListConnectorVersionsApiCall(ref _callListConnectorVersions);
            _callGetConnectorVersion = clientHelper.BuildApiCall<GetConnectorVersionRequest, ConnectorVersion>("GetConnectorVersion", grpcClient.GetConnectorVersionAsync, grpcClient.GetConnectorVersion, effectiveSettings.GetConnectorVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnectorVersion);
            Modify_GetConnectorVersionApiCall(ref _callGetConnectorVersion);
            _callGetConnectionSchemaMetadata = clientHelper.BuildApiCall<GetConnectionSchemaMetadataRequest, ConnectionSchemaMetadata>("GetConnectionSchemaMetadata", grpcClient.GetConnectionSchemaMetadataAsync, grpcClient.GetConnectionSchemaMetadata, effectiveSettings.GetConnectionSchemaMetadataSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnectionSchemaMetadata);
            Modify_GetConnectionSchemaMetadataApiCall(ref _callGetConnectionSchemaMetadata);
            _callRefreshConnectionSchemaMetadata = clientHelper.BuildApiCall<RefreshConnectionSchemaMetadataRequest, lro::Operation>("RefreshConnectionSchemaMetadata", grpcClient.RefreshConnectionSchemaMetadataAsync, grpcClient.RefreshConnectionSchemaMetadata, effectiveSettings.RefreshConnectionSchemaMetadataSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRefreshConnectionSchemaMetadata);
            Modify_RefreshConnectionSchemaMetadataApiCall(ref _callRefreshConnectionSchemaMetadata);
            _callListRuntimeEntitySchemas = clientHelper.BuildApiCall<ListRuntimeEntitySchemasRequest, ListRuntimeEntitySchemasResponse>("ListRuntimeEntitySchemas", grpcClient.ListRuntimeEntitySchemasAsync, grpcClient.ListRuntimeEntitySchemas, effectiveSettings.ListRuntimeEntitySchemasSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRuntimeEntitySchemas);
            Modify_ListRuntimeEntitySchemasApiCall(ref _callListRuntimeEntitySchemas);
            _callListRuntimeActionSchemas = clientHelper.BuildApiCall<ListRuntimeActionSchemasRequest, ListRuntimeActionSchemasResponse>("ListRuntimeActionSchemas", grpcClient.ListRuntimeActionSchemasAsync, grpcClient.ListRuntimeActionSchemas, effectiveSettings.ListRuntimeActionSchemasSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRuntimeActionSchemas);
            Modify_ListRuntimeActionSchemasApiCall(ref _callListRuntimeActionSchemas);
            _callGetRuntimeConfig = clientHelper.BuildApiCall<GetRuntimeConfigRequest, RuntimeConfig>("GetRuntimeConfig", grpcClient.GetRuntimeConfigAsync, grpcClient.GetRuntimeConfig, effectiveSettings.GetRuntimeConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRuntimeConfig);
            Modify_GetRuntimeConfigApiCall(ref _callGetRuntimeConfig);
            _callGetGlobalSettings = clientHelper.BuildApiCall<GetGlobalSettingsRequest, Settings>("GetGlobalSettings", grpcClient.GetGlobalSettingsAsync, grpcClient.GetGlobalSettings, effectiveSettings.GetGlobalSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGlobalSettings);
            Modify_GetGlobalSettingsApiCall(ref _callGetGlobalSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListConnectionsApiCall(ref gaxgrpc::ApiCall<ListConnectionsRequest, ListConnectionsResponse> call);

        partial void Modify_GetConnectionApiCall(ref gaxgrpc::ApiCall<GetConnectionRequest, Connection> call);

        partial void Modify_CreateConnectionApiCall(ref gaxgrpc::ApiCall<CreateConnectionRequest, lro::Operation> call);

        partial void Modify_UpdateConnectionApiCall(ref gaxgrpc::ApiCall<UpdateConnectionRequest, lro::Operation> call);

        partial void Modify_DeleteConnectionApiCall(ref gaxgrpc::ApiCall<DeleteConnectionRequest, lro::Operation> call);

        partial void Modify_ListProvidersApiCall(ref gaxgrpc::ApiCall<ListProvidersRequest, ListProvidersResponse> call);

        partial void Modify_GetProviderApiCall(ref gaxgrpc::ApiCall<GetProviderRequest, Provider> call);

        partial void Modify_ListConnectorsApiCall(ref gaxgrpc::ApiCall<ListConnectorsRequest, ListConnectorsResponse> call);

        partial void Modify_GetConnectorApiCall(ref gaxgrpc::ApiCall<GetConnectorRequest, Connector> call);

        partial void Modify_ListConnectorVersionsApiCall(ref gaxgrpc::ApiCall<ListConnectorVersionsRequest, ListConnectorVersionsResponse> call);

        partial void Modify_GetConnectorVersionApiCall(ref gaxgrpc::ApiCall<GetConnectorVersionRequest, ConnectorVersion> call);

        partial void Modify_GetConnectionSchemaMetadataApiCall(ref gaxgrpc::ApiCall<GetConnectionSchemaMetadataRequest, ConnectionSchemaMetadata> call);

        partial void Modify_RefreshConnectionSchemaMetadataApiCall(ref gaxgrpc::ApiCall<RefreshConnectionSchemaMetadataRequest, lro::Operation> call);

        partial void Modify_ListRuntimeEntitySchemasApiCall(ref gaxgrpc::ApiCall<ListRuntimeEntitySchemasRequest, ListRuntimeEntitySchemasResponse> call);

        partial void Modify_ListRuntimeActionSchemasApiCall(ref gaxgrpc::ApiCall<ListRuntimeActionSchemasRequest, ListRuntimeActionSchemasResponse> call);

        partial void Modify_GetRuntimeConfigApiCall(ref gaxgrpc::ApiCall<GetRuntimeConfigRequest, RuntimeConfig> call);

        partial void Modify_GetGlobalSettingsApiCall(ref gaxgrpc::ApiCall<GetGlobalSettingsRequest, Settings> call);

        partial void OnConstruction(Connectors.ConnectorsClient grpcClient, ConnectorsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Connectors client</summary>
        public override Connectors.ConnectorsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListConnectionsRequest(ref ListConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectionRequest(ref GetConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConnectionRequest(ref CreateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConnectionRequest(ref UpdateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConnectionRequest(ref DeleteConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProvidersRequest(ref ListProvidersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProviderRequest(ref GetProviderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConnectorsRequest(ref ListConnectorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectorRequest(ref GetConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConnectorVersionsRequest(ref ListConnectorVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectorVersionRequest(ref GetConnectorVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectionSchemaMetadataRequest(ref GetConnectionSchemaMetadataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RefreshConnectionSchemaMetadataRequest(ref RefreshConnectionSchemaMetadataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRuntimeEntitySchemasRequest(ref ListRuntimeEntitySchemasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRuntimeActionSchemasRequest(ref ListRuntimeActionSchemasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRuntimeConfigRequest(ref GetRuntimeConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGlobalSettingsRequest(ref GetGlobalSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public override gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConnectionsRequest, ListConnectionsResponse, Connection>(_callListConnections, request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConnectionsRequest, ListConnectionsResponse, Connection>(_callListConnections, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Connection GetConnection(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionRequest(ref request, ref callSettings);
            return _callGetConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Connection> GetConnectionAsync(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionRequest(ref request, ref callSettings);
            return _callGetConnection.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateConnection</c>.</summary>
        public override lro::OperationsClient CreateConnectionOperationsClient { get; }

        /// <summary>
        /// Creates a new Connection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Connection, OperationMetadata> CreateConnection(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<Connection, OperationMetadata>(_callCreateConnection.Sync(request, callSettings), CreateConnectionOperationsClient);
        }

        /// <summary>
        /// Creates a new Connection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<Connection, OperationMetadata>(await _callCreateConnection.Async(request, callSettings).ConfigureAwait(false), CreateConnectionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateConnection</c>.</summary>
        public override lro::OperationsClient UpdateConnectionOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Connection, OperationMetadata> UpdateConnection(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<Connection, OperationMetadata>(_callUpdateConnection.Sync(request, callSettings), UpdateConnectionOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Connection, OperationMetadata>> UpdateConnectionAsync(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<Connection, OperationMetadata>(await _callUpdateConnection.Async(request, callSettings).ConfigureAwait(false), UpdateConnectionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteConnection</c>.</summary>
        public override lro::OperationsClient DeleteConnectionOperationsClient { get; }

        /// <summary>
        /// Deletes a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteConnection(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteConnection.Sync(request, callSettings), DeleteConnectionOperationsClient);
        }

        /// <summary>
        /// Deletes a single Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteConnection.Async(request, callSettings).ConfigureAwait(false), DeleteConnectionOperationsClient);
        }

        /// <summary>
        /// Lists Providers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Provider"/> resources.</returns>
        public override gax::PagedEnumerable<ListProvidersResponse, Provider> ListProviders(ListProvidersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProvidersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProvidersRequest, ListProvidersResponse, Provider>(_callListProviders, request, callSettings);
        }

        /// <summary>
        /// Lists Providers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Provider"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProvidersResponse, Provider> ListProvidersAsync(ListProvidersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProvidersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProvidersRequest, ListProvidersResponse, Provider>(_callListProviders, request, callSettings);
        }

        /// <summary>
        /// Gets details of a provider.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Provider GetProvider(GetProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProviderRequest(ref request, ref callSettings);
            return _callGetProvider.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a provider.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Provider> GetProviderAsync(GetProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProviderRequest(ref request, ref callSettings);
            return _callGetProvider.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Connectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connector"/> resources.</returns>
        public override gax::PagedEnumerable<ListConnectorsResponse, Connector> ListConnectors(ListConnectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConnectorsRequest, ListConnectorsResponse, Connector>(_callListConnectors, request, callSettings);
        }

        /// <summary>
        /// Lists Connectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connector"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConnectorsResponse, Connector> ListConnectorsAsync(ListConnectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConnectorsRequest, ListConnectorsResponse, Connector>(_callListConnectors, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Connector GetConnector(GetConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectorRequest(ref request, ref callSettings);
            return _callGetConnector.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Connector> GetConnectorAsync(GetConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectorRequest(ref request, ref callSettings);
            return _callGetConnector.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Connector Versions in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectorVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListConnectorVersionsResponse, ConnectorVersion> ListConnectorVersions(ListConnectorVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectorVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConnectorVersionsRequest, ListConnectorVersionsResponse, ConnectorVersion>(_callListConnectorVersions, request, callSettings);
        }

        /// <summary>
        /// Lists Connector Versions in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectorVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConnectorVersionsResponse, ConnectorVersion> ListConnectorVersionsAsync(ListConnectorVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectorVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConnectorVersionsRequest, ListConnectorVersionsResponse, ConnectorVersion>(_callListConnectorVersions, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single connector version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConnectorVersion GetConnectorVersion(GetConnectorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectorVersionRequest(ref request, ref callSettings);
            return _callGetConnectorVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single connector version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConnectorVersion> GetConnectorVersionAsync(GetConnectorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectorVersionRequest(ref request, ref callSettings);
            return _callGetConnectorVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Gets schema metadata of a connection.
        /// SchemaMetadata is a singleton resource for each connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConnectionSchemaMetadata GetConnectionSchemaMetadata(GetConnectionSchemaMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionSchemaMetadataRequest(ref request, ref callSettings);
            return _callGetConnectionSchemaMetadata.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets schema metadata of a connection.
        /// SchemaMetadata is a singleton resource for each connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConnectionSchemaMetadata> GetConnectionSchemaMetadataAsync(GetConnectionSchemaMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionSchemaMetadataRequest(ref request, ref callSettings);
            return _callGetConnectionSchemaMetadata.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RefreshConnectionSchemaMetadata</c>.</summary>
        public override lro::OperationsClient RefreshConnectionSchemaMetadataOperationsClient { get; }

        /// <summary>
        /// Refresh runtime schema of a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConnectionSchemaMetadata, OperationMetadata> RefreshConnectionSchemaMetadata(RefreshConnectionSchemaMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RefreshConnectionSchemaMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionSchemaMetadata, OperationMetadata>(_callRefreshConnectionSchemaMetadata.Sync(request, callSettings), RefreshConnectionSchemaMetadataOperationsClient);
        }

        /// <summary>
        /// Refresh runtime schema of a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConnectionSchemaMetadata, OperationMetadata>> RefreshConnectionSchemaMetadataAsync(RefreshConnectionSchemaMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RefreshConnectionSchemaMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionSchemaMetadata, OperationMetadata>(await _callRefreshConnectionSchemaMetadata.Async(request, callSettings).ConfigureAwait(false), RefreshConnectionSchemaMetadataOperationsClient);
        }

        /// <summary>
        /// List schema of a runtime entities filtered by entity name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuntimeEntitySchema"/> resources.</returns>
        public override gax::PagedEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> ListRuntimeEntitySchemas(ListRuntimeEntitySchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuntimeEntitySchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRuntimeEntitySchemasRequest, ListRuntimeEntitySchemasResponse, RuntimeEntitySchema>(_callListRuntimeEntitySchemas, request, callSettings);
        }

        /// <summary>
        /// List schema of a runtime entities filtered by entity name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuntimeEntitySchema"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> ListRuntimeEntitySchemasAsync(ListRuntimeEntitySchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuntimeEntitySchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRuntimeEntitySchemasRequest, ListRuntimeEntitySchemasResponse, RuntimeEntitySchema>(_callListRuntimeEntitySchemas, request, callSettings);
        }

        /// <summary>
        /// List schema of a runtime actions filtered by action name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuntimeActionSchema"/> resources.</returns>
        public override gax::PagedEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> ListRuntimeActionSchemas(ListRuntimeActionSchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuntimeActionSchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRuntimeActionSchemasRequest, ListRuntimeActionSchemasResponse, RuntimeActionSchema>(_callListRuntimeActionSchemas, request, callSettings);
        }

        /// <summary>
        /// List schema of a runtime actions filtered by action name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuntimeActionSchema"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> ListRuntimeActionSchemasAsync(ListRuntimeActionSchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuntimeActionSchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRuntimeActionSchemasRequest, ListRuntimeActionSchemasResponse, RuntimeActionSchema>(_callListRuntimeActionSchemas, request, callSettings);
        }

        /// <summary>
        /// Gets the runtimeConfig of a location.
        /// RuntimeConfig is a singleton resource for each location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RuntimeConfig GetRuntimeConfig(GetRuntimeConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuntimeConfigRequest(ref request, ref callSettings);
            return _callGetRuntimeConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the runtimeConfig of a location.
        /// RuntimeConfig is a singleton resource for each location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RuntimeConfig> GetRuntimeConfigAsync(GetRuntimeConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuntimeConfigRequest(ref request, ref callSettings);
            return _callGetRuntimeConfig.Async(request, callSettings);
        }

        /// <summary>
        /// GetGlobalSettings gets settings of a project.
        /// GlobalSettings is a singleton resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings GetGlobalSettings(GetGlobalSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlobalSettingsRequest(ref request, ref callSettings);
            return _callGetGlobalSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// GetGlobalSettings gets settings of a project.
        /// GlobalSettings is a singleton resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> GetGlobalSettingsAsync(GetGlobalSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlobalSettingsRequest(ref request, ref callSettings);
            return _callGetGlobalSettings.Async(request, callSettings);
        }
    }

    public partial class ListConnectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProvidersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectorVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRuntimeEntitySchemasRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRuntimeActionSchemasRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectionsResponse : gaxgrpc::IPageResponse<Connection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Connection> GetEnumerator() => Connections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProvidersResponse : gaxgrpc::IPageResponse<Provider>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Provider> GetEnumerator() => Providers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConnectorsResponse : gaxgrpc::IPageResponse<Connector>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Connector> GetEnumerator() => Connectors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConnectorVersionsResponse : gaxgrpc::IPageResponse<ConnectorVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConnectorVersion> GetEnumerator() => ConnectorVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRuntimeEntitySchemasResponse : gaxgrpc::IPageResponse<RuntimeEntitySchema>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RuntimeEntitySchema> GetEnumerator() => RuntimeEntitySchemas.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRuntimeActionSchemasResponse : gaxgrpc::IPageResponse<RuntimeActionSchema>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RuntimeActionSchema> GetEnumerator() => RuntimeActionSchemas.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Connectors
    {
        public partial class ConnectorsClient
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

    public static partial class Connectors
    {
        public partial class ConnectorsClient
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
