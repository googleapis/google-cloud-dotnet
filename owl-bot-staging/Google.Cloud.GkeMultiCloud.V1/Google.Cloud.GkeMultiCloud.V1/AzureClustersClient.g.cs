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

namespace Google.Cloud.GkeMultiCloud.V1
{
    /// <summary>Settings for <see cref="AzureClustersClient"/> instances.</summary>
    public sealed partial class AzureClustersSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AzureClustersSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AzureClustersSettings"/>.</returns>
        public static AzureClustersSettings GetDefault() => new AzureClustersSettings();

        /// <summary>Constructs a new <see cref="AzureClustersSettings"/> object with default settings.</summary>
        public AzureClustersSettings()
        {
        }

        private AzureClustersSettings(AzureClustersSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateAzureClientSettings = existing.CreateAzureClientSettings;
            CreateAzureClientOperationsSettings = existing.CreateAzureClientOperationsSettings.Clone();
            GetAzureClientSettings = existing.GetAzureClientSettings;
            ListAzureClientsSettings = existing.ListAzureClientsSettings;
            DeleteAzureClientSettings = existing.DeleteAzureClientSettings;
            DeleteAzureClientOperationsSettings = existing.DeleteAzureClientOperationsSettings.Clone();
            CreateAzureClusterSettings = existing.CreateAzureClusterSettings;
            CreateAzureClusterOperationsSettings = existing.CreateAzureClusterOperationsSettings.Clone();
            UpdateAzureClusterSettings = existing.UpdateAzureClusterSettings;
            UpdateAzureClusterOperationsSettings = existing.UpdateAzureClusterOperationsSettings.Clone();
            GetAzureClusterSettings = existing.GetAzureClusterSettings;
            ListAzureClustersSettings = existing.ListAzureClustersSettings;
            DeleteAzureClusterSettings = existing.DeleteAzureClusterSettings;
            DeleteAzureClusterOperationsSettings = existing.DeleteAzureClusterOperationsSettings.Clone();
            GenerateAzureClusterAgentTokenSettings = existing.GenerateAzureClusterAgentTokenSettings;
            GenerateAzureAccessTokenSettings = existing.GenerateAzureAccessTokenSettings;
            CreateAzureNodePoolSettings = existing.CreateAzureNodePoolSettings;
            CreateAzureNodePoolOperationsSettings = existing.CreateAzureNodePoolOperationsSettings.Clone();
            UpdateAzureNodePoolSettings = existing.UpdateAzureNodePoolSettings;
            UpdateAzureNodePoolOperationsSettings = existing.UpdateAzureNodePoolOperationsSettings.Clone();
            GetAzureNodePoolSettings = existing.GetAzureNodePoolSettings;
            ListAzureNodePoolsSettings = existing.ListAzureNodePoolsSettings;
            DeleteAzureNodePoolSettings = existing.DeleteAzureNodePoolSettings;
            DeleteAzureNodePoolOperationsSettings = existing.DeleteAzureNodePoolOperationsSettings.Clone();
            GetAzureOpenIdConfigSettings = existing.GetAzureOpenIdConfigSettings;
            GetAzureJsonWebKeysSettings = existing.GetAzureJsonWebKeysSettings;
            GetAzureServerConfigSettings = existing.GetAzureServerConfigSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AzureClustersSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.CreateAzureClient</c> and <c>AzureClustersClient.CreateAzureClientAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAzureClientSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AzureClustersClient.CreateAzureClient</c> and
        /// <c>AzureClustersClient.CreateAzureClientAsync</c>.
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
        public lro::OperationsSettings CreateAzureClientOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.GetAzureClient</c> and <c>AzureClustersClient.GetAzureClientAsync</c>.
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
        public gaxgrpc::CallSettings GetAzureClientSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.ListAzureClients</c> and <c>AzureClustersClient.ListAzureClientsAsync</c>.
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
        public gaxgrpc::CallSettings ListAzureClientsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.DeleteAzureClient</c> and <c>AzureClustersClient.DeleteAzureClientAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAzureClientSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AzureClustersClient.DeleteAzureClient</c> and
        /// <c>AzureClustersClient.DeleteAzureClientAsync</c>.
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
        public lro::OperationsSettings DeleteAzureClientOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.CreateAzureCluster</c> and <c>AzureClustersClient.CreateAzureClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAzureClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AzureClustersClient.CreateAzureCluster</c> and
        /// <c>AzureClustersClient.CreateAzureClusterAsync</c>.
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
        public lro::OperationsSettings CreateAzureClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.UpdateAzureCluster</c> and <c>AzureClustersClient.UpdateAzureClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAzureClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AzureClustersClient.UpdateAzureCluster</c> and
        /// <c>AzureClustersClient.UpdateAzureClusterAsync</c>.
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
        public lro::OperationsSettings UpdateAzureClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.GetAzureCluster</c> and <c>AzureClustersClient.GetAzureClusterAsync</c>.
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
        public gaxgrpc::CallSettings GetAzureClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.ListAzureClusters</c> and <c>AzureClustersClient.ListAzureClustersAsync</c>.
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
        public gaxgrpc::CallSettings ListAzureClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.DeleteAzureCluster</c> and <c>AzureClustersClient.DeleteAzureClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAzureClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AzureClustersClient.DeleteAzureCluster</c> and
        /// <c>AzureClustersClient.DeleteAzureClusterAsync</c>.
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
        public lro::OperationsSettings DeleteAzureClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.GenerateAzureClusterAgentToken</c> and
        /// <c>AzureClustersClient.GenerateAzureClusterAgentTokenAsync</c>.
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
        public gaxgrpc::CallSettings GenerateAzureClusterAgentTokenSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.GenerateAzureAccessToken</c> and <c>AzureClustersClient.GenerateAzureAccessTokenAsync</c>
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
        public gaxgrpc::CallSettings GenerateAzureAccessTokenSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.CreateAzureNodePool</c> and <c>AzureClustersClient.CreateAzureNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAzureNodePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AzureClustersClient.CreateAzureNodePool</c> and
        /// <c>AzureClustersClient.CreateAzureNodePoolAsync</c>.
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
        public lro::OperationsSettings CreateAzureNodePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.UpdateAzureNodePool</c> and <c>AzureClustersClient.UpdateAzureNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAzureNodePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AzureClustersClient.UpdateAzureNodePool</c> and
        /// <c>AzureClustersClient.UpdateAzureNodePoolAsync</c>.
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
        public lro::OperationsSettings UpdateAzureNodePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.GetAzureNodePool</c> and <c>AzureClustersClient.GetAzureNodePoolAsync</c>.
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
        public gaxgrpc::CallSettings GetAzureNodePoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.ListAzureNodePools</c> and <c>AzureClustersClient.ListAzureNodePoolsAsync</c>.
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
        public gaxgrpc::CallSettings ListAzureNodePoolsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.DeleteAzureNodePool</c> and <c>AzureClustersClient.DeleteAzureNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAzureNodePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AzureClustersClient.DeleteAzureNodePool</c> and
        /// <c>AzureClustersClient.DeleteAzureNodePoolAsync</c>.
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
        public lro::OperationsSettings DeleteAzureNodePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.GetAzureOpenIdConfig</c> and <c>AzureClustersClient.GetAzureOpenIdConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetAzureOpenIdConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.GetAzureJsonWebKeys</c> and <c>AzureClustersClient.GetAzureJsonWebKeysAsync</c>.
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
        public gaxgrpc::CallSettings GetAzureJsonWebKeysSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AzureClustersClient.GetAzureServerConfig</c> and <c>AzureClustersClient.GetAzureServerConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetAzureServerConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AzureClustersSettings"/> object.</returns>
        public AzureClustersSettings Clone() => new AzureClustersSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AzureClustersClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AzureClustersClientBuilder : gaxgrpc::ClientBuilderBase<AzureClustersClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AzureClustersSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AzureClustersClientBuilder() : base(AzureClustersClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AzureClustersClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AzureClustersClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AzureClustersClient Build()
        {
            AzureClustersClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AzureClustersClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AzureClustersClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AzureClustersClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AzureClustersClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AzureClustersClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AzureClustersClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AzureClustersClient.ChannelPool;
    }

    /// <summary>AzureClusters client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The AzureClusters API provides a single centrally managed service
    /// to create and manage Anthos clusters that run on Azure infrastructure.
    /// </remarks>
    public abstract partial class AzureClustersClient
    {
        /// <summary>
        /// The default endpoint for the AzureClusters service, which is a host of "gkemulticloud.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gkemulticloud.googleapis.com:443";

        /// <summary>The default AzureClusters scopes.</summary>
        /// <remarks>
        /// The default AzureClusters scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AzureClusters.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AzureClustersClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AzureClustersClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AzureClustersClient"/>.</returns>
        public static stt::Task<AzureClustersClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AzureClustersClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AzureClustersClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AzureClustersClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AzureClustersClient"/>.</returns>
        public static AzureClustersClient Create() => new AzureClustersClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AzureClustersClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AzureClustersSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AzureClustersClient"/>.</returns>
        internal static AzureClustersClient Create(grpccore::CallInvoker callInvoker, AzureClustersSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AzureClusters.AzureClustersClient grpcClient = new AzureClusters.AzureClustersClient(callInvoker);
            return new AzureClustersClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AzureClusters client</summary>
        public virtual AzureClusters.AzureClustersClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource on a given Google Cloud project and region.
        /// 
        /// `AzureClient` resources hold client authentication
        /// information needed by the Anthos Multicloud API to manage Azure resources
        /// on your Azure subscription on your behalf.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AzureClient, OperationMetadata> CreateAzureClient(CreateAzureClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource on a given Google Cloud project and region.
        /// 
        /// `AzureClient` resources hold client authentication
        /// information needed by the Anthos Multicloud API to manage Azure resources
        /// on your Azure subscription on your behalf.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureClient, OperationMetadata>> CreateAzureClientAsync(CreateAzureClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource on a given Google Cloud project and region.
        /// 
        /// `AzureClient` resources hold client authentication
        /// information needed by the Anthos Multicloud API to manage Azure resources
        /// on your Azure subscription on your behalf.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureClient, OperationMetadata>> CreateAzureClientAsync(CreateAzureClientRequest request, st::CancellationToken cancellationToken) =>
            CreateAzureClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAzureClient</c>.</summary>
        public virtual lro::OperationsClient CreateAzureClientOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAzureClient</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AzureClient, OperationMetadata> PollOnceCreateAzureClient(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AzureClient, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAzureClientOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAzureClient</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AzureClient, OperationMetadata>> PollOnceCreateAzureClientAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AzureClient, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAzureClientOperationsClient, callSettings);

        /// <summary>
        /// Creates a new [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource on a given Google Cloud project and region.
        /// 
        /// `AzureClient` resources hold client authentication
        /// information needed by the Anthos Multicloud API to manage Azure resources
        /// on your Azure subscription on your behalf.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureClient">
        /// Required. The specification of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] to create.
        /// </param>
        /// <param name="azureClientId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AzureClient, OperationMetadata> CreateAzureClient(string parent, AzureClient azureClient, string azureClientId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAzureClient(new CreateAzureClientRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AzureClient = gax::GaxPreconditions.CheckNotNull(azureClient, nameof(azureClient)),
                AzureClientId = gax::GaxPreconditions.CheckNotNullOrEmpty(azureClientId, nameof(azureClientId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource on a given Google Cloud project and region.
        /// 
        /// `AzureClient` resources hold client authentication
        /// information needed by the Anthos Multicloud API to manage Azure resources
        /// on your Azure subscription on your behalf.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureClient">
        /// Required. The specification of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] to create.
        /// </param>
        /// <param name="azureClientId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureClient, OperationMetadata>> CreateAzureClientAsync(string parent, AzureClient azureClient, string azureClientId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAzureClientAsync(new CreateAzureClientRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AzureClient = gax::GaxPreconditions.CheckNotNull(azureClient, nameof(azureClient)),
                AzureClientId = gax::GaxPreconditions.CheckNotNullOrEmpty(azureClientId, nameof(azureClientId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource on a given Google Cloud project and region.
        /// 
        /// `AzureClient` resources hold client authentication
        /// information needed by the Anthos Multicloud API to manage Azure resources
        /// on your Azure subscription on your behalf.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureClient">
        /// Required. The specification of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] to create.
        /// </param>
        /// <param name="azureClientId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureClient, OperationMetadata>> CreateAzureClientAsync(string parent, AzureClient azureClient, string azureClientId, st::CancellationToken cancellationToken) =>
            CreateAzureClientAsync(parent, azureClient, azureClientId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource on a given Google Cloud project and region.
        /// 
        /// `AzureClient` resources hold client authentication
        /// information needed by the Anthos Multicloud API to manage Azure resources
        /// on your Azure subscription on your behalf.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureClient">
        /// Required. The specification of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] to create.
        /// </param>
        /// <param name="azureClientId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AzureClient, OperationMetadata> CreateAzureClient(gagr::LocationName parent, AzureClient azureClient, string azureClientId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAzureClient(new CreateAzureClientRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AzureClient = gax::GaxPreconditions.CheckNotNull(azureClient, nameof(azureClient)),
                AzureClientId = gax::GaxPreconditions.CheckNotNullOrEmpty(azureClientId, nameof(azureClientId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource on a given Google Cloud project and region.
        /// 
        /// `AzureClient` resources hold client authentication
        /// information needed by the Anthos Multicloud API to manage Azure resources
        /// on your Azure subscription on your behalf.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureClient">
        /// Required. The specification of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] to create.
        /// </param>
        /// <param name="azureClientId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureClient, OperationMetadata>> CreateAzureClientAsync(gagr::LocationName parent, AzureClient azureClient, string azureClientId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAzureClientAsync(new CreateAzureClientRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AzureClient = gax::GaxPreconditions.CheckNotNull(azureClient, nameof(azureClient)),
                AzureClientId = gax::GaxPreconditions.CheckNotNullOrEmpty(azureClientId, nameof(azureClientId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource on a given Google Cloud project and region.
        /// 
        /// `AzureClient` resources hold client authentication
        /// information needed by the Anthos Multicloud API to manage Azure resources
        /// on your Azure subscription on your behalf.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureClient">
        /// Required. The specification of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] to create.
        /// </param>
        /// <param name="azureClientId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureClient, OperationMetadata>> CreateAzureClientAsync(gagr::LocationName parent, AzureClient azureClient, string azureClientId, st::CancellationToken cancellationToken) =>
            CreateAzureClientAsync(parent, azureClient, azureClientId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureClient GetAzureClient(GetAzureClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specific
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureClient> GetAzureClientAsync(GetAzureClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specific
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureClient> GetAzureClientAsync(GetAzureClientRequest request, st::CancellationToken cancellationToken) =>
            GetAzureClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource to
        /// describe.
        /// 
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] names are
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureClient GetAzureClient(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureClient(new GetAzureClientRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource to
        /// describe.
        /// 
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] names are
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureClient> GetAzureClientAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureClientAsync(new GetAzureClientRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource to
        /// describe.
        /// 
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] names are
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureClient> GetAzureClientAsync(string name, st::CancellationToken cancellationToken) =>
            GetAzureClientAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource to
        /// describe.
        /// 
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] names are
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureClient GetAzureClient(AzureClientName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureClient(new GetAzureClientRequest
            {
                AzureClientName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource to
        /// describe.
        /// 
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] names are
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureClient> GetAzureClientAsync(AzureClientName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureClientAsync(new GetAzureClientRequest
            {
                AzureClientName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource to
        /// describe.
        /// 
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] names are
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureClient> GetAzureClientAsync(AzureClientName name, st::CancellationToken cancellationToken) =>
            GetAzureClientAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AzureClient"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAzureClientsResponse, AzureClient> ListAzureClients(ListAzureClientsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AzureClient"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAzureClientsResponse, AzureClient> ListAzureClientsAsync(ListAzureClientsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resources.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
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
        /// <returns>A pageable sequence of <see cref="AzureClient"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAzureClientsResponse, AzureClient> ListAzureClients(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAzureClientsRequest request = new ListAzureClientsRequest
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
            return ListAzureClients(request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resources.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AzureClient"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAzureClientsResponse, AzureClient> ListAzureClientsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAzureClientsRequest request = new ListAzureClientsRequest
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
            return ListAzureClientsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resources.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
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
        /// <returns>A pageable sequence of <see cref="AzureClient"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAzureClientsResponse, AzureClient> ListAzureClients(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAzureClientsRequest request = new ListAzureClientsRequest
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
            return ListAzureClients(request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resources.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AzureClient"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAzureClientsResponse, AzureClient> ListAzureClientsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAzureClientsRequest request = new ListAzureClientsRequest
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
            return ListAzureClientsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a specific [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource.
        /// 
        /// If the client is used by one or more clusters, deletion will
        /// fail and a `FAILED_PRECONDITION` error will be returned.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAzureClient(DeleteAzureClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource.
        /// 
        /// If the client is used by one or more clusters, deletion will
        /// fail and a `FAILED_PRECONDITION` error will be returned.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClientAsync(DeleteAzureClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource.
        /// 
        /// If the client is used by one or more clusters, deletion will
        /// fail and a `FAILED_PRECONDITION` error will be returned.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClientAsync(DeleteAzureClientRequest request, st::CancellationToken cancellationToken) =>
            DeleteAzureClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAzureClient</c>.</summary>
        public virtual lro::OperationsClient DeleteAzureClientOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAzureClient</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAzureClient(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAzureClientOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAzureClient</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAzureClientAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAzureClientOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource.
        /// 
        /// If the client is used by one or more clusters, deletion will
        /// fail and a `FAILED_PRECONDITION` error will be returned.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] to delete.
        /// 
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] names are
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAzureClient(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAzureClient(new DeleteAzureClientRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource.
        /// 
        /// If the client is used by one or more clusters, deletion will
        /// fail and a `FAILED_PRECONDITION` error will be returned.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] to delete.
        /// 
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] names are
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClientAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAzureClientAsync(new DeleteAzureClientRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource.
        /// 
        /// If the client is used by one or more clusters, deletion will
        /// fail and a `FAILED_PRECONDITION` error will be returned.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] to delete.
        /// 
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] names are
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClientAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAzureClientAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource.
        /// 
        /// If the client is used by one or more clusters, deletion will
        /// fail and a `FAILED_PRECONDITION` error will be returned.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] to delete.
        /// 
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] names are
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAzureClient(AzureClientName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAzureClient(new DeleteAzureClientRequest
            {
                AzureClientName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource.
        /// 
        /// If the client is used by one or more clusters, deletion will
        /// fail and a `FAILED_PRECONDITION` error will be returned.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] to delete.
        /// 
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] names are
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClientAsync(AzureClientName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAzureClientAsync(new DeleteAzureClientRequest
            {
                AzureClientName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource.
        /// 
        /// If the client is used by one or more clusters, deletion will
        /// fail and a `FAILED_PRECONDITION` error will be returned.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] to delete.
        /// 
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] names are
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClients/&lt;client-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClientAsync(AzureClientName name, st::CancellationToken cancellationToken) =>
            DeleteAzureClientAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AzureCluster, OperationMetadata> CreateAzureCluster(CreateAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureCluster, OperationMetadata>> CreateAzureClusterAsync(CreateAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureCluster, OperationMetadata>> CreateAzureClusterAsync(CreateAzureClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateAzureClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAzureCluster</c>.</summary>
        public virtual lro::OperationsClient CreateAzureClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAzureCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AzureCluster, OperationMetadata> PollOnceCreateAzureCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AzureCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAzureClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAzureCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AzureCluster, OperationMetadata>> PollOnceCreateAzureClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AzureCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAzureClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a new [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureCluster">
        /// Required. The specification of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] to create.
        /// </param>
        /// <param name="azureClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AzureCluster, OperationMetadata> CreateAzureCluster(string parent, AzureCluster azureCluster, string azureClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAzureCluster(new CreateAzureClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AzureCluster = gax::GaxPreconditions.CheckNotNull(azureCluster, nameof(azureCluster)),
                AzureClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(azureClusterId, nameof(azureClusterId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureCluster">
        /// Required. The specification of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] to create.
        /// </param>
        /// <param name="azureClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureCluster, OperationMetadata>> CreateAzureClusterAsync(string parent, AzureCluster azureCluster, string azureClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAzureClusterAsync(new CreateAzureClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AzureCluster = gax::GaxPreconditions.CheckNotNull(azureCluster, nameof(azureCluster)),
                AzureClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(azureClusterId, nameof(azureClusterId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureCluster">
        /// Required. The specification of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] to create.
        /// </param>
        /// <param name="azureClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureCluster, OperationMetadata>> CreateAzureClusterAsync(string parent, AzureCluster azureCluster, string azureClusterId, st::CancellationToken cancellationToken) =>
            CreateAzureClusterAsync(parent, azureCluster, azureClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureCluster">
        /// Required. The specification of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] to create.
        /// </param>
        /// <param name="azureClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AzureCluster, OperationMetadata> CreateAzureCluster(gagr::LocationName parent, AzureCluster azureCluster, string azureClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAzureCluster(new CreateAzureClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AzureCluster = gax::GaxPreconditions.CheckNotNull(azureCluster, nameof(azureCluster)),
                AzureClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(azureClusterId, nameof(azureClusterId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureCluster">
        /// Required. The specification of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] to create.
        /// </param>
        /// <param name="azureClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureCluster, OperationMetadata>> CreateAzureClusterAsync(gagr::LocationName parent, AzureCluster azureCluster, string azureClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAzureClusterAsync(new CreateAzureClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AzureCluster = gax::GaxPreconditions.CheckNotNull(azureCluster, nameof(azureCluster)),
                AzureClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(azureClusterId, nameof(azureClusterId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureCluster">
        /// Required. The specification of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] to create.
        /// </param>
        /// <param name="azureClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureCluster, OperationMetadata>> CreateAzureClusterAsync(gagr::LocationName parent, AzureCluster azureCluster, string azureClusterId, st::CancellationToken cancellationToken) =>
            CreateAzureClusterAsync(parent, azureCluster, azureClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AzureCluster, OperationMetadata> UpdateAzureCluster(UpdateAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureCluster, OperationMetadata>> UpdateAzureClusterAsync(UpdateAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureCluster, OperationMetadata>> UpdateAzureClusterAsync(UpdateAzureClusterRequest request, st::CancellationToken cancellationToken) =>
            UpdateAzureClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAzureCluster</c>.</summary>
        public virtual lro::OperationsClient UpdateAzureClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAzureCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AzureCluster, OperationMetadata> PollOnceUpdateAzureCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AzureCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAzureClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAzureCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AzureCluster, OperationMetadata>> PollOnceUpdateAzureClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AzureCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAzureClusterOperationsClient, callSettings);

        /// <summary>
        /// Updates an [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]:
        /// 
        /// *   `description`.
        /// *   `azureClient`.
        /// *   `control_plane.version`.
        /// *   `control_plane.vm_size`.
        /// *   `annotations`.
        /// *   `authorization.admin_users`.
        /// *   `authorization.admin_groups`.
        /// *   `control_plane.root_volume.size_gib`.
        /// *   `azure_services_authentication`.
        /// *   `azure_services_authentication.tenant_id`.
        /// *   `azure_services_authentication.application_id`.
        /// *   `control_plane.proxy_config`.
        /// *   `control_plane.proxy_config.resource_group_id`.
        /// *   `control_plane.proxy_config.secret_id`.
        /// *   `control_plane.ssh_config.authorized_key`.
        /// *   `logging_config.component_config.enable_components`
        /// *   `monitoring_config.managed_prometheus_config.enabled`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AzureCluster, OperationMetadata> UpdateAzureCluster(AzureCluster azureCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAzureCluster(new UpdateAzureClusterRequest
            {
                AzureCluster = gax::GaxPreconditions.CheckNotNull(azureCluster, nameof(azureCluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]:
        /// 
        /// *   `description`.
        /// *   `azureClient`.
        /// *   `control_plane.version`.
        /// *   `control_plane.vm_size`.
        /// *   `annotations`.
        /// *   `authorization.admin_users`.
        /// *   `authorization.admin_groups`.
        /// *   `control_plane.root_volume.size_gib`.
        /// *   `azure_services_authentication`.
        /// *   `azure_services_authentication.tenant_id`.
        /// *   `azure_services_authentication.application_id`.
        /// *   `control_plane.proxy_config`.
        /// *   `control_plane.proxy_config.resource_group_id`.
        /// *   `control_plane.proxy_config.secret_id`.
        /// *   `control_plane.ssh_config.authorized_key`.
        /// *   `logging_config.component_config.enable_components`
        /// *   `monitoring_config.managed_prometheus_config.enabled`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureCluster, OperationMetadata>> UpdateAzureClusterAsync(AzureCluster azureCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAzureClusterAsync(new UpdateAzureClusterRequest
            {
                AzureCluster = gax::GaxPreconditions.CheckNotNull(azureCluster, nameof(azureCluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]:
        /// 
        /// *   `description`.
        /// *   `azureClient`.
        /// *   `control_plane.version`.
        /// *   `control_plane.vm_size`.
        /// *   `annotations`.
        /// *   `authorization.admin_users`.
        /// *   `authorization.admin_groups`.
        /// *   `control_plane.root_volume.size_gib`.
        /// *   `azure_services_authentication`.
        /// *   `azure_services_authentication.tenant_id`.
        /// *   `azure_services_authentication.application_id`.
        /// *   `control_plane.proxy_config`.
        /// *   `control_plane.proxy_config.resource_group_id`.
        /// *   `control_plane.proxy_config.secret_id`.
        /// *   `control_plane.ssh_config.authorized_key`.
        /// *   `logging_config.component_config.enable_components`
        /// *   `monitoring_config.managed_prometheus_config.enabled`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureCluster, OperationMetadata>> UpdateAzureClusterAsync(AzureCluster azureCluster, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAzureClusterAsync(azureCluster, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureCluster GetAzureCluster(GetAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureCluster> GetAzureClusterAsync(GetAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureCluster> GetAzureClusterAsync(GetAzureClusterRequest request, st::CancellationToken cancellationToken) =>
            GetAzureClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource to
        /// describe.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureCluster GetAzureCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureCluster(new GetAzureClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource to
        /// describe.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureCluster> GetAzureClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureClusterAsync(new GetAzureClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource to
        /// describe.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureCluster> GetAzureClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetAzureClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource to
        /// describe.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureCluster GetAzureCluster(AzureClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureCluster(new GetAzureClusterRequest
            {
                AzureClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource to
        /// describe.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureCluster> GetAzureClusterAsync(AzureClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureClusterAsync(new GetAzureClusterRequest
            {
                AzureClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource to
        /// describe.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureCluster> GetAzureClusterAsync(AzureClusterName name, st::CancellationToken cancellationToken) =>
            GetAzureClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AzureCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAzureClustersResponse, AzureCluster> ListAzureClusters(ListAzureClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AzureCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAzureClustersResponse, AzureCluster> ListAzureClustersAsync(ListAzureClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resources.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
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
        /// <returns>A pageable sequence of <see cref="AzureCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAzureClustersResponse, AzureCluster> ListAzureClusters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAzureClustersRequest request = new ListAzureClustersRequest
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
            return ListAzureClusters(request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resources.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AzureCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAzureClustersResponse, AzureCluster> ListAzureClustersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAzureClustersRequest request = new ListAzureClustersRequest
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
            return ListAzureClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resources.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
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
        /// <returns>A pageable sequence of <see cref="AzureCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAzureClustersResponse, AzureCluster> ListAzureClusters(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAzureClustersRequest request = new ListAzureClustersRequest
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
            return ListAzureClusters(request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resources.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AzureCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAzureClustersResponse, AzureCluster> ListAzureClustersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAzureClustersRequest request = new ListAzureClustersRequest
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
            return ListAzureClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAzureCluster(DeleteAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClusterAsync(DeleteAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClusterAsync(DeleteAzureClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteAzureClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAzureCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteAzureClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAzureCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAzureCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAzureClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAzureCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAzureClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAzureClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] to delete.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAzureCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAzureCluster(new DeleteAzureClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] to delete.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAzureClusterAsync(new DeleteAzureClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] to delete.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAzureClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] to delete.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAzureCluster(AzureClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAzureCluster(new DeleteAzureClusterRequest
            {
                AzureClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] to delete.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClusterAsync(AzureClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAzureClusterAsync(new DeleteAzureClusterRequest
            {
                AzureClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] to delete.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClusterAsync(AzureClusterName name, st::CancellationToken cancellationToken) =>
            DeleteAzureClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAzureClusterAgentTokenResponse GenerateAzureClusterAgentToken(GenerateAzureClusterAgentTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAzureClusterAgentTokenResponse> GenerateAzureClusterAgentTokenAsync(GenerateAzureClusterAgentTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAzureClusterAgentTokenResponse> GenerateAzureClusterAgentTokenAsync(GenerateAzureClusterAgentTokenRequest request, st::CancellationToken cancellationToken) =>
            GenerateAzureClusterAgentTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a short-lived access token to authenticate to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAzureAccessTokenResponse GenerateAzureAccessToken(GenerateAzureAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a short-lived access token to authenticate to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAzureAccessTokenResponse> GenerateAzureAccessTokenAsync(GenerateAzureAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a short-lived access token to authenticate to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAzureAccessTokenResponse> GenerateAzureAccessTokenAsync(GenerateAzureAccessTokenRequest request, st::CancellationToken cancellationToken) =>
            GenerateAzureAccessTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool],
        /// attached to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AzureNodePool, OperationMetadata> CreateAzureNodePool(CreateAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool],
        /// attached to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> CreateAzureNodePoolAsync(CreateAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool],
        /// attached to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> CreateAzureNodePoolAsync(CreateAzureNodePoolRequest request, st::CancellationToken cancellationToken) =>
            CreateAzureNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAzureNodePool</c>.</summary>
        public virtual lro::OperationsClient CreateAzureNodePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAzureNodePool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AzureNodePool, OperationMetadata> PollOnceCreateAzureNodePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AzureNodePool, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAzureNodePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAzureNodePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> PollOnceCreateAzureNodePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AzureNodePool, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAzureNodePoolOperationsClient, callSettings);

        /// <summary>
        /// Creates a new [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool],
        /// attached to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource where this node pool will be created.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureNodePool">
        /// Required. The specification of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] to create.
        /// </param>
        /// <param name="azureNodePoolId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AzureNodePool, OperationMetadata> CreateAzureNodePool(string parent, AzureNodePool azureNodePool, string azureNodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAzureNodePool(new CreateAzureNodePoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AzureNodePool = gax::GaxPreconditions.CheckNotNull(azureNodePool, nameof(azureNodePool)),
                AzureNodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(azureNodePoolId, nameof(azureNodePoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool],
        /// attached to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource where this node pool will be created.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureNodePool">
        /// Required. The specification of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] to create.
        /// </param>
        /// <param name="azureNodePoolId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> CreateAzureNodePoolAsync(string parent, AzureNodePool azureNodePool, string azureNodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAzureNodePoolAsync(new CreateAzureNodePoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AzureNodePool = gax::GaxPreconditions.CheckNotNull(azureNodePool, nameof(azureNodePool)),
                AzureNodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(azureNodePoolId, nameof(azureNodePoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool],
        /// attached to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource where this node pool will be created.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureNodePool">
        /// Required. The specification of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] to create.
        /// </param>
        /// <param name="azureNodePoolId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> CreateAzureNodePoolAsync(string parent, AzureNodePool azureNodePool, string azureNodePoolId, st::CancellationToken cancellationToken) =>
            CreateAzureNodePoolAsync(parent, azureNodePool, azureNodePoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool],
        /// attached to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource where this node pool will be created.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureNodePool">
        /// Required. The specification of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] to create.
        /// </param>
        /// <param name="azureNodePoolId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AzureNodePool, OperationMetadata> CreateAzureNodePool(AzureClusterName parent, AzureNodePool azureNodePool, string azureNodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAzureNodePool(new CreateAzureNodePoolRequest
            {
                ParentAsAzureClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AzureNodePool = gax::GaxPreconditions.CheckNotNull(azureNodePool, nameof(azureNodePool)),
                AzureNodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(azureNodePoolId, nameof(azureNodePoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool],
        /// attached to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource where this node pool will be created.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureNodePool">
        /// Required. The specification of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] to create.
        /// </param>
        /// <param name="azureNodePoolId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> CreateAzureNodePoolAsync(AzureClusterName parent, AzureNodePool azureNodePool, string azureNodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAzureNodePoolAsync(new CreateAzureNodePoolRequest
            {
                ParentAsAzureClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AzureNodePool = gax::GaxPreconditions.CheckNotNull(azureNodePool, nameof(azureNodePool)),
                AzureNodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(azureNodePoolId, nameof(azureNodePoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool],
        /// attached to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource where this node pool will be created.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="azureNodePool">
        /// Required. The specification of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] to create.
        /// </param>
        /// <param name="azureNodePoolId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> CreateAzureNodePoolAsync(AzureClusterName parent, AzureNodePool azureNodePool, string azureNodePoolId, st::CancellationToken cancellationToken) =>
            CreateAzureNodePoolAsync(parent, azureNodePool, azureNodePoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AzureNodePool, OperationMetadata> UpdateAzureNodePool(UpdateAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> UpdateAzureNodePoolAsync(UpdateAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> UpdateAzureNodePoolAsync(UpdateAzureNodePoolRequest request, st::CancellationToken cancellationToken) =>
            UpdateAzureNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAzureNodePool</c>.</summary>
        public virtual lro::OperationsClient UpdateAzureNodePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAzureNodePool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AzureNodePool, OperationMetadata> PollOnceUpdateAzureNodePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AzureNodePool, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAzureNodePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAzureNodePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> PollOnceUpdateAzureNodePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AzureNodePool, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAzureNodePoolOperationsClient, callSettings);

        /// <summary>
        /// Updates an [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool].
        /// </summary>
        /// <param name="azureNodePool">
        /// Required. The [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]
        /// resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]:
        /// 
        /// *.  `annotations`.
        /// *   `version`.
        /// *   `autoscaling.min_node_count`.
        /// *   `autoscaling.max_node_count`.
        /// *   `config.ssh_config.authorized_key`.
        /// *   `management.auto_repair`.
        /// *   `management`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AzureNodePool, OperationMetadata> UpdateAzureNodePool(AzureNodePool azureNodePool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAzureNodePool(new UpdateAzureNodePoolRequest
            {
                AzureNodePool = gax::GaxPreconditions.CheckNotNull(azureNodePool, nameof(azureNodePool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool].
        /// </summary>
        /// <param name="azureNodePool">
        /// Required. The [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]
        /// resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]:
        /// 
        /// *.  `annotations`.
        /// *   `version`.
        /// *   `autoscaling.min_node_count`.
        /// *   `autoscaling.max_node_count`.
        /// *   `config.ssh_config.authorized_key`.
        /// *   `management.auto_repair`.
        /// *   `management`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> UpdateAzureNodePoolAsync(AzureNodePool azureNodePool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAzureNodePoolAsync(new UpdateAzureNodePoolRequest
            {
                AzureNodePool = gax::GaxPreconditions.CheckNotNull(azureNodePool, nameof(azureNodePool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool].
        /// </summary>
        /// <param name="azureNodePool">
        /// Required. The [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]
        /// resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]:
        /// 
        /// *.  `annotations`.
        /// *   `version`.
        /// *   `autoscaling.min_node_count`.
        /// *   `autoscaling.max_node_count`.
        /// *   `config.ssh_config.authorized_key`.
        /// *   `management.auto_repair`.
        /// *   `management`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> UpdateAzureNodePoolAsync(AzureNodePool azureNodePool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAzureNodePoolAsync(azureNodePool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureNodePool GetAzureNodePool(GetAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureNodePool> GetAzureNodePoolAsync(GetAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureNodePool> GetAzureNodePoolAsync(GetAzureNodePoolRequest request, st::CancellationToken cancellationToken) =>
            GetAzureNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource to
        /// describe.
        /// 
        /// `AzureNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureNodePool GetAzureNodePool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureNodePool(new GetAzureNodePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource to
        /// describe.
        /// 
        /// `AzureNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureNodePool> GetAzureNodePoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureNodePoolAsync(new GetAzureNodePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource to
        /// describe.
        /// 
        /// `AzureNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureNodePool> GetAzureNodePoolAsync(string name, st::CancellationToken cancellationToken) =>
            GetAzureNodePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource to
        /// describe.
        /// 
        /// `AzureNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureNodePool GetAzureNodePool(AzureNodePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureNodePool(new GetAzureNodePoolRequest
            {
                AzureNodePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource to
        /// describe.
        /// 
        /// `AzureNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureNodePool> GetAzureNodePoolAsync(AzureNodePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureNodePoolAsync(new GetAzureNodePoolRequest
            {
                AzureNodePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource to
        /// describe.
        /// 
        /// `AzureNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureNodePool> GetAzureNodePoolAsync(AzureNodePoolName name, st::CancellationToken cancellationToken) =>
            GetAzureNodePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]
        /// resources on a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AzureNodePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAzureNodePoolsResponse, AzureNodePool> ListAzureNodePools(ListAzureNodePoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]
        /// resources on a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AzureNodePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAzureNodePoolsResponse, AzureNodePool> ListAzureNodePoolsAsync(ListAzureNodePoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]
        /// resources on a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `AzureCluster` which owns this collection of
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
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
        /// <returns>A pageable sequence of <see cref="AzureNodePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAzureNodePoolsResponse, AzureNodePool> ListAzureNodePools(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAzureNodePoolsRequest request = new ListAzureNodePoolsRequest
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
            return ListAzureNodePools(request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]
        /// resources on a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `AzureCluster` which owns this collection of
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AzureNodePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAzureNodePoolsResponse, AzureNodePool> ListAzureNodePoolsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAzureNodePoolsRequest request = new ListAzureNodePoolsRequest
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
            return ListAzureNodePoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]
        /// resources on a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `AzureCluster` which owns this collection of
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
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
        /// <returns>A pageable sequence of <see cref="AzureNodePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAzureNodePoolsResponse, AzureNodePool> ListAzureNodePools(AzureClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAzureNodePoolsRequest request = new ListAzureNodePoolsRequest
            {
                ParentAsAzureClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAzureNodePools(request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]
        /// resources on a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `AzureCluster` which owns this collection of
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// `AzureCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AzureNodePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAzureNodePoolsResponse, AzureNodePool> ListAzureNodePoolsAsync(AzureClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAzureNodePoolsRequest request = new ListAzureNodePoolsRequest
            {
                ParentAsAzureClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAzureNodePoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAzureNodePool(DeleteAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureNodePoolAsync(DeleteAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureNodePoolAsync(DeleteAzureNodePoolRequest request, st::CancellationToken cancellationToken) =>
            DeleteAzureNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAzureNodePool</c>.</summary>
        public virtual lro::OperationsClient DeleteAzureNodePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAzureNodePool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAzureNodePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAzureNodePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAzureNodePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAzureNodePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAzureNodePoolOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] to delete.
        /// 
        /// `AzureNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAzureNodePool(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAzureNodePool(new DeleteAzureNodePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] to delete.
        /// 
        /// `AzureNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureNodePoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAzureNodePoolAsync(new DeleteAzureNodePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] to delete.
        /// 
        /// `AzureNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureNodePoolAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAzureNodePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] to delete.
        /// 
        /// `AzureNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAzureNodePool(AzureNodePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAzureNodePool(new DeleteAzureNodePoolRequest
            {
                AzureNodePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] to delete.
        /// 
        /// `AzureNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureNodePoolAsync(AzureNodePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAzureNodePoolAsync(new DeleteAzureNodePoolRequest
            {
                AzureNodePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] to delete.
        /// 
        /// `AzureNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;/azureNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureNodePoolAsync(AzureNodePoolName name, st::CancellationToken cancellationToken) =>
            DeleteAzureNodePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the OIDC discovery document for the cluster.
        /// See the
        /// [OpenID Connect Discovery 1.0
        /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html)
        /// for details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureOpenIdConfig GetAzureOpenIdConfig(GetAzureOpenIdConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the OIDC discovery document for the cluster.
        /// See the
        /// [OpenID Connect Discovery 1.0
        /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html)
        /// for details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureOpenIdConfig> GetAzureOpenIdConfigAsync(GetAzureOpenIdConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the OIDC discovery document for the cluster.
        /// See the
        /// [OpenID Connect Discovery 1.0
        /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html)
        /// for details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureOpenIdConfig> GetAzureOpenIdConfigAsync(GetAzureOpenIdConfigRequest request, st::CancellationToken cancellationToken) =>
            GetAzureOpenIdConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the OIDC discovery document for the cluster.
        /// See the
        /// [OpenID Connect Discovery 1.0
        /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html)
        /// for details.
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The AzureCluster, which owns the OIDC discovery document.
        /// Format:
        /// projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureOpenIdConfig GetAzureOpenIdConfig(string azureCluster, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureOpenIdConfig(new GetAzureOpenIdConfigRequest
            {
                AzureCluster = gax::GaxPreconditions.CheckNotNullOrEmpty(azureCluster, nameof(azureCluster)),
            }, callSettings);

        /// <summary>
        /// Gets the OIDC discovery document for the cluster.
        /// See the
        /// [OpenID Connect Discovery 1.0
        /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html)
        /// for details.
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The AzureCluster, which owns the OIDC discovery document.
        /// Format:
        /// projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureOpenIdConfig> GetAzureOpenIdConfigAsync(string azureCluster, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureOpenIdConfigAsync(new GetAzureOpenIdConfigRequest
            {
                AzureCluster = gax::GaxPreconditions.CheckNotNullOrEmpty(azureCluster, nameof(azureCluster)),
            }, callSettings);

        /// <summary>
        /// Gets the OIDC discovery document for the cluster.
        /// See the
        /// [OpenID Connect Discovery 1.0
        /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html)
        /// for details.
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The AzureCluster, which owns the OIDC discovery document.
        /// Format:
        /// projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureOpenIdConfig> GetAzureOpenIdConfigAsync(string azureCluster, st::CancellationToken cancellationToken) =>
            GetAzureOpenIdConfigAsync(azureCluster, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the OIDC discovery document for the cluster.
        /// See the
        /// [OpenID Connect Discovery 1.0
        /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html)
        /// for details.
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The AzureCluster, which owns the OIDC discovery document.
        /// Format:
        /// projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureOpenIdConfig GetAzureOpenIdConfig(AzureClusterName azureCluster, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureOpenIdConfig(new GetAzureOpenIdConfigRequest
            {
                AzureClusterAsAzureClusterName = gax::GaxPreconditions.CheckNotNull(azureCluster, nameof(azureCluster)),
            }, callSettings);

        /// <summary>
        /// Gets the OIDC discovery document for the cluster.
        /// See the
        /// [OpenID Connect Discovery 1.0
        /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html)
        /// for details.
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The AzureCluster, which owns the OIDC discovery document.
        /// Format:
        /// projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureOpenIdConfig> GetAzureOpenIdConfigAsync(AzureClusterName azureCluster, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureOpenIdConfigAsync(new GetAzureOpenIdConfigRequest
            {
                AzureClusterAsAzureClusterName = gax::GaxPreconditions.CheckNotNull(azureCluster, nameof(azureCluster)),
            }, callSettings);

        /// <summary>
        /// Gets the OIDC discovery document for the cluster.
        /// See the
        /// [OpenID Connect Discovery 1.0
        /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html)
        /// for details.
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The AzureCluster, which owns the OIDC discovery document.
        /// Format:
        /// projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureOpenIdConfig> GetAzureOpenIdConfigAsync(AzureClusterName azureCluster, st::CancellationToken cancellationToken) =>
            GetAzureOpenIdConfigAsync(azureCluster, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureJsonWebKeys GetAzureJsonWebKeys(GetAzureJsonWebKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureJsonWebKeys> GetAzureJsonWebKeysAsync(GetAzureJsonWebKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureJsonWebKeys> GetAzureJsonWebKeysAsync(GetAzureJsonWebKeysRequest request, st::CancellationToken cancellationToken) =>
            GetAzureJsonWebKeysAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The AzureCluster, which owns the JsonWebKeys.
        /// Format:
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureJsonWebKeys GetAzureJsonWebKeys(string azureCluster, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureJsonWebKeys(new GetAzureJsonWebKeysRequest
            {
                AzureCluster = gax::GaxPreconditions.CheckNotNullOrEmpty(azureCluster, nameof(azureCluster)),
            }, callSettings);

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The AzureCluster, which owns the JsonWebKeys.
        /// Format:
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureJsonWebKeys> GetAzureJsonWebKeysAsync(string azureCluster, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureJsonWebKeysAsync(new GetAzureJsonWebKeysRequest
            {
                AzureCluster = gax::GaxPreconditions.CheckNotNullOrEmpty(azureCluster, nameof(azureCluster)),
            }, callSettings);

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The AzureCluster, which owns the JsonWebKeys.
        /// Format:
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureJsonWebKeys> GetAzureJsonWebKeysAsync(string azureCluster, st::CancellationToken cancellationToken) =>
            GetAzureJsonWebKeysAsync(azureCluster, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The AzureCluster, which owns the JsonWebKeys.
        /// Format:
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureJsonWebKeys GetAzureJsonWebKeys(AzureClusterName azureCluster, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureJsonWebKeys(new GetAzureJsonWebKeysRequest
            {
                AzureClusterAsAzureClusterName = gax::GaxPreconditions.CheckNotNull(azureCluster, nameof(azureCluster)),
            }, callSettings);

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The AzureCluster, which owns the JsonWebKeys.
        /// Format:
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureJsonWebKeys> GetAzureJsonWebKeysAsync(AzureClusterName azureCluster, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureJsonWebKeysAsync(new GetAzureJsonWebKeysRequest
            {
                AzureClusterAsAzureClusterName = gax::GaxPreconditions.CheckNotNull(azureCluster, nameof(azureCluster)),
            }, callSettings);

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="azureCluster">
        /// Required. The AzureCluster, which owns the JsonWebKeys.
        /// Format:
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureClusters/&lt;cluster-id&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureJsonWebKeys> GetAzureJsonWebKeysAsync(AzureClusterName azureCluster, st::CancellationToken cancellationToken) =>
            GetAzureJsonWebKeysAsync(azureCluster, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information, such as supported Azure regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureServerConfig GetAzureServerConfig(GetAzureServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information, such as supported Azure regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureServerConfig> GetAzureServerConfigAsync(GetAzureServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information, such as supported Azure regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureServerConfig> GetAzureServerConfigAsync(GetAzureServerConfigRequest request, st::CancellationToken cancellationToken) =>
            GetAzureServerConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information, such as supported Azure regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureServerConfig][google.cloud.gkemulticloud.v1.AzureServerConfig]
        /// resource to describe.
        /// 
        /// `AzureServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureServerConfig GetAzureServerConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureServerConfig(new GetAzureServerConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information, such as supported Azure regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureServerConfig][google.cloud.gkemulticloud.v1.AzureServerConfig]
        /// resource to describe.
        /// 
        /// `AzureServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureServerConfig> GetAzureServerConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureServerConfigAsync(new GetAzureServerConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information, such as supported Azure regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureServerConfig][google.cloud.gkemulticloud.v1.AzureServerConfig]
        /// resource to describe.
        /// 
        /// `AzureServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureServerConfig> GetAzureServerConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetAzureServerConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information, such as supported Azure regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureServerConfig][google.cloud.gkemulticloud.v1.AzureServerConfig]
        /// resource to describe.
        /// 
        /// `AzureServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AzureServerConfig GetAzureServerConfig(AzureServerConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureServerConfig(new GetAzureServerConfigRequest
            {
                AzureServerConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information, such as supported Azure regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureServerConfig][google.cloud.gkemulticloud.v1.AzureServerConfig]
        /// resource to describe.
        /// 
        /// `AzureServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureServerConfig> GetAzureServerConfigAsync(AzureServerConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAzureServerConfigAsync(new GetAzureServerConfigRequest
            {
                AzureServerConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information, such as supported Azure regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AzureServerConfig][google.cloud.gkemulticloud.v1.AzureServerConfig]
        /// resource to describe.
        /// 
        /// `AzureServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/azureServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AzureServerConfig> GetAzureServerConfigAsync(AzureServerConfigName name, st::CancellationToken cancellationToken) =>
            GetAzureServerConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AzureClusters client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The AzureClusters API provides a single centrally managed service
    /// to create and manage Anthos clusters that run on Azure infrastructure.
    /// </remarks>
    public sealed partial class AzureClustersClientImpl : AzureClustersClient
    {
        private readonly gaxgrpc::ApiCall<CreateAzureClientRequest, lro::Operation> _callCreateAzureClient;

        private readonly gaxgrpc::ApiCall<GetAzureClientRequest, AzureClient> _callGetAzureClient;

        private readonly gaxgrpc::ApiCall<ListAzureClientsRequest, ListAzureClientsResponse> _callListAzureClients;

        private readonly gaxgrpc::ApiCall<DeleteAzureClientRequest, lro::Operation> _callDeleteAzureClient;

        private readonly gaxgrpc::ApiCall<CreateAzureClusterRequest, lro::Operation> _callCreateAzureCluster;

        private readonly gaxgrpc::ApiCall<UpdateAzureClusterRequest, lro::Operation> _callUpdateAzureCluster;

        private readonly gaxgrpc::ApiCall<GetAzureClusterRequest, AzureCluster> _callGetAzureCluster;

        private readonly gaxgrpc::ApiCall<ListAzureClustersRequest, ListAzureClustersResponse> _callListAzureClusters;

        private readonly gaxgrpc::ApiCall<DeleteAzureClusterRequest, lro::Operation> _callDeleteAzureCluster;

        private readonly gaxgrpc::ApiCall<GenerateAzureClusterAgentTokenRequest, GenerateAzureClusterAgentTokenResponse> _callGenerateAzureClusterAgentToken;

        private readonly gaxgrpc::ApiCall<GenerateAzureAccessTokenRequest, GenerateAzureAccessTokenResponse> _callGenerateAzureAccessToken;

        private readonly gaxgrpc::ApiCall<CreateAzureNodePoolRequest, lro::Operation> _callCreateAzureNodePool;

        private readonly gaxgrpc::ApiCall<UpdateAzureNodePoolRequest, lro::Operation> _callUpdateAzureNodePool;

        private readonly gaxgrpc::ApiCall<GetAzureNodePoolRequest, AzureNodePool> _callGetAzureNodePool;

        private readonly gaxgrpc::ApiCall<ListAzureNodePoolsRequest, ListAzureNodePoolsResponse> _callListAzureNodePools;

        private readonly gaxgrpc::ApiCall<DeleteAzureNodePoolRequest, lro::Operation> _callDeleteAzureNodePool;

        private readonly gaxgrpc::ApiCall<GetAzureOpenIdConfigRequest, AzureOpenIdConfig> _callGetAzureOpenIdConfig;

        private readonly gaxgrpc::ApiCall<GetAzureJsonWebKeysRequest, AzureJsonWebKeys> _callGetAzureJsonWebKeys;

        private readonly gaxgrpc::ApiCall<GetAzureServerConfigRequest, AzureServerConfig> _callGetAzureServerConfig;

        /// <summary>
        /// Constructs a client wrapper for the AzureClusters service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AzureClustersSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AzureClustersClientImpl(AzureClusters.AzureClustersClient grpcClient, AzureClustersSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AzureClustersSettings effectiveSettings = settings ?? AzureClustersSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateAzureClientOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAzureClientOperationsSettings, logger);
            DeleteAzureClientOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAzureClientOperationsSettings, logger);
            CreateAzureClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAzureClusterOperationsSettings, logger);
            UpdateAzureClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAzureClusterOperationsSettings, logger);
            DeleteAzureClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAzureClusterOperationsSettings, logger);
            CreateAzureNodePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAzureNodePoolOperationsSettings, logger);
            UpdateAzureNodePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAzureNodePoolOperationsSettings, logger);
            DeleteAzureNodePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAzureNodePoolOperationsSettings, logger);
            _callCreateAzureClient = clientHelper.BuildApiCall<CreateAzureClientRequest, lro::Operation>("CreateAzureClient", grpcClient.CreateAzureClientAsync, grpcClient.CreateAzureClient, effectiveSettings.CreateAzureClientSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAzureClient);
            Modify_CreateAzureClientApiCall(ref _callCreateAzureClient);
            _callGetAzureClient = clientHelper.BuildApiCall<GetAzureClientRequest, AzureClient>("GetAzureClient", grpcClient.GetAzureClientAsync, grpcClient.GetAzureClient, effectiveSettings.GetAzureClientSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAzureClient);
            Modify_GetAzureClientApiCall(ref _callGetAzureClient);
            _callListAzureClients = clientHelper.BuildApiCall<ListAzureClientsRequest, ListAzureClientsResponse>("ListAzureClients", grpcClient.ListAzureClientsAsync, grpcClient.ListAzureClients, effectiveSettings.ListAzureClientsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAzureClients);
            Modify_ListAzureClientsApiCall(ref _callListAzureClients);
            _callDeleteAzureClient = clientHelper.BuildApiCall<DeleteAzureClientRequest, lro::Operation>("DeleteAzureClient", grpcClient.DeleteAzureClientAsync, grpcClient.DeleteAzureClient, effectiveSettings.DeleteAzureClientSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAzureClient);
            Modify_DeleteAzureClientApiCall(ref _callDeleteAzureClient);
            _callCreateAzureCluster = clientHelper.BuildApiCall<CreateAzureClusterRequest, lro::Operation>("CreateAzureCluster", grpcClient.CreateAzureClusterAsync, grpcClient.CreateAzureCluster, effectiveSettings.CreateAzureClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAzureCluster);
            Modify_CreateAzureClusterApiCall(ref _callCreateAzureCluster);
            _callUpdateAzureCluster = clientHelper.BuildApiCall<UpdateAzureClusterRequest, lro::Operation>("UpdateAzureCluster", grpcClient.UpdateAzureClusterAsync, grpcClient.UpdateAzureCluster, effectiveSettings.UpdateAzureClusterSettings).WithGoogleRequestParam("azure_cluster.name", request => request.AzureCluster?.Name);
            Modify_ApiCall(ref _callUpdateAzureCluster);
            Modify_UpdateAzureClusterApiCall(ref _callUpdateAzureCluster);
            _callGetAzureCluster = clientHelper.BuildApiCall<GetAzureClusterRequest, AzureCluster>("GetAzureCluster", grpcClient.GetAzureClusterAsync, grpcClient.GetAzureCluster, effectiveSettings.GetAzureClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAzureCluster);
            Modify_GetAzureClusterApiCall(ref _callGetAzureCluster);
            _callListAzureClusters = clientHelper.BuildApiCall<ListAzureClustersRequest, ListAzureClustersResponse>("ListAzureClusters", grpcClient.ListAzureClustersAsync, grpcClient.ListAzureClusters, effectiveSettings.ListAzureClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAzureClusters);
            Modify_ListAzureClustersApiCall(ref _callListAzureClusters);
            _callDeleteAzureCluster = clientHelper.BuildApiCall<DeleteAzureClusterRequest, lro::Operation>("DeleteAzureCluster", grpcClient.DeleteAzureClusterAsync, grpcClient.DeleteAzureCluster, effectiveSettings.DeleteAzureClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAzureCluster);
            Modify_DeleteAzureClusterApiCall(ref _callDeleteAzureCluster);
            _callGenerateAzureClusterAgentToken = clientHelper.BuildApiCall<GenerateAzureClusterAgentTokenRequest, GenerateAzureClusterAgentTokenResponse>("GenerateAzureClusterAgentToken", grpcClient.GenerateAzureClusterAgentTokenAsync, grpcClient.GenerateAzureClusterAgentToken, effectiveSettings.GenerateAzureClusterAgentTokenSettings).WithGoogleRequestParam("azure_cluster", request => request.AzureCluster);
            Modify_ApiCall(ref _callGenerateAzureClusterAgentToken);
            Modify_GenerateAzureClusterAgentTokenApiCall(ref _callGenerateAzureClusterAgentToken);
            _callGenerateAzureAccessToken = clientHelper.BuildApiCall<GenerateAzureAccessTokenRequest, GenerateAzureAccessTokenResponse>("GenerateAzureAccessToken", grpcClient.GenerateAzureAccessTokenAsync, grpcClient.GenerateAzureAccessToken, effectiveSettings.GenerateAzureAccessTokenSettings).WithGoogleRequestParam("azure_cluster", request => request.AzureCluster);
            Modify_ApiCall(ref _callGenerateAzureAccessToken);
            Modify_GenerateAzureAccessTokenApiCall(ref _callGenerateAzureAccessToken);
            _callCreateAzureNodePool = clientHelper.BuildApiCall<CreateAzureNodePoolRequest, lro::Operation>("CreateAzureNodePool", grpcClient.CreateAzureNodePoolAsync, grpcClient.CreateAzureNodePool, effectiveSettings.CreateAzureNodePoolSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAzureNodePool);
            Modify_CreateAzureNodePoolApiCall(ref _callCreateAzureNodePool);
            _callUpdateAzureNodePool = clientHelper.BuildApiCall<UpdateAzureNodePoolRequest, lro::Operation>("UpdateAzureNodePool", grpcClient.UpdateAzureNodePoolAsync, grpcClient.UpdateAzureNodePool, effectiveSettings.UpdateAzureNodePoolSettings).WithGoogleRequestParam("azure_node_pool.name", request => request.AzureNodePool?.Name);
            Modify_ApiCall(ref _callUpdateAzureNodePool);
            Modify_UpdateAzureNodePoolApiCall(ref _callUpdateAzureNodePool);
            _callGetAzureNodePool = clientHelper.BuildApiCall<GetAzureNodePoolRequest, AzureNodePool>("GetAzureNodePool", grpcClient.GetAzureNodePoolAsync, grpcClient.GetAzureNodePool, effectiveSettings.GetAzureNodePoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAzureNodePool);
            Modify_GetAzureNodePoolApiCall(ref _callGetAzureNodePool);
            _callListAzureNodePools = clientHelper.BuildApiCall<ListAzureNodePoolsRequest, ListAzureNodePoolsResponse>("ListAzureNodePools", grpcClient.ListAzureNodePoolsAsync, grpcClient.ListAzureNodePools, effectiveSettings.ListAzureNodePoolsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAzureNodePools);
            Modify_ListAzureNodePoolsApiCall(ref _callListAzureNodePools);
            _callDeleteAzureNodePool = clientHelper.BuildApiCall<DeleteAzureNodePoolRequest, lro::Operation>("DeleteAzureNodePool", grpcClient.DeleteAzureNodePoolAsync, grpcClient.DeleteAzureNodePool, effectiveSettings.DeleteAzureNodePoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAzureNodePool);
            Modify_DeleteAzureNodePoolApiCall(ref _callDeleteAzureNodePool);
            _callGetAzureOpenIdConfig = clientHelper.BuildApiCall<GetAzureOpenIdConfigRequest, AzureOpenIdConfig>("GetAzureOpenIdConfig", grpcClient.GetAzureOpenIdConfigAsync, grpcClient.GetAzureOpenIdConfig, effectiveSettings.GetAzureOpenIdConfigSettings).WithGoogleRequestParam("azure_cluster", request => request.AzureCluster);
            Modify_ApiCall(ref _callGetAzureOpenIdConfig);
            Modify_GetAzureOpenIdConfigApiCall(ref _callGetAzureOpenIdConfig);
            _callGetAzureJsonWebKeys = clientHelper.BuildApiCall<GetAzureJsonWebKeysRequest, AzureJsonWebKeys>("GetAzureJsonWebKeys", grpcClient.GetAzureJsonWebKeysAsync, grpcClient.GetAzureJsonWebKeys, effectiveSettings.GetAzureJsonWebKeysSettings).WithGoogleRequestParam("azure_cluster", request => request.AzureCluster);
            Modify_ApiCall(ref _callGetAzureJsonWebKeys);
            Modify_GetAzureJsonWebKeysApiCall(ref _callGetAzureJsonWebKeys);
            _callGetAzureServerConfig = clientHelper.BuildApiCall<GetAzureServerConfigRequest, AzureServerConfig>("GetAzureServerConfig", grpcClient.GetAzureServerConfigAsync, grpcClient.GetAzureServerConfig, effectiveSettings.GetAzureServerConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAzureServerConfig);
            Modify_GetAzureServerConfigApiCall(ref _callGetAzureServerConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateAzureClientApiCall(ref gaxgrpc::ApiCall<CreateAzureClientRequest, lro::Operation> call);

        partial void Modify_GetAzureClientApiCall(ref gaxgrpc::ApiCall<GetAzureClientRequest, AzureClient> call);

        partial void Modify_ListAzureClientsApiCall(ref gaxgrpc::ApiCall<ListAzureClientsRequest, ListAzureClientsResponse> call);

        partial void Modify_DeleteAzureClientApiCall(ref gaxgrpc::ApiCall<DeleteAzureClientRequest, lro::Operation> call);

        partial void Modify_CreateAzureClusterApiCall(ref gaxgrpc::ApiCall<CreateAzureClusterRequest, lro::Operation> call);

        partial void Modify_UpdateAzureClusterApiCall(ref gaxgrpc::ApiCall<UpdateAzureClusterRequest, lro::Operation> call);

        partial void Modify_GetAzureClusterApiCall(ref gaxgrpc::ApiCall<GetAzureClusterRequest, AzureCluster> call);

        partial void Modify_ListAzureClustersApiCall(ref gaxgrpc::ApiCall<ListAzureClustersRequest, ListAzureClustersResponse> call);

        partial void Modify_DeleteAzureClusterApiCall(ref gaxgrpc::ApiCall<DeleteAzureClusterRequest, lro::Operation> call);

        partial void Modify_GenerateAzureClusterAgentTokenApiCall(ref gaxgrpc::ApiCall<GenerateAzureClusterAgentTokenRequest, GenerateAzureClusterAgentTokenResponse> call);

        partial void Modify_GenerateAzureAccessTokenApiCall(ref gaxgrpc::ApiCall<GenerateAzureAccessTokenRequest, GenerateAzureAccessTokenResponse> call);

        partial void Modify_CreateAzureNodePoolApiCall(ref gaxgrpc::ApiCall<CreateAzureNodePoolRequest, lro::Operation> call);

        partial void Modify_UpdateAzureNodePoolApiCall(ref gaxgrpc::ApiCall<UpdateAzureNodePoolRequest, lro::Operation> call);

        partial void Modify_GetAzureNodePoolApiCall(ref gaxgrpc::ApiCall<GetAzureNodePoolRequest, AzureNodePool> call);

        partial void Modify_ListAzureNodePoolsApiCall(ref gaxgrpc::ApiCall<ListAzureNodePoolsRequest, ListAzureNodePoolsResponse> call);

        partial void Modify_DeleteAzureNodePoolApiCall(ref gaxgrpc::ApiCall<DeleteAzureNodePoolRequest, lro::Operation> call);

        partial void Modify_GetAzureOpenIdConfigApiCall(ref gaxgrpc::ApiCall<GetAzureOpenIdConfigRequest, AzureOpenIdConfig> call);

        partial void Modify_GetAzureJsonWebKeysApiCall(ref gaxgrpc::ApiCall<GetAzureJsonWebKeysRequest, AzureJsonWebKeys> call);

        partial void Modify_GetAzureServerConfigApiCall(ref gaxgrpc::ApiCall<GetAzureServerConfigRequest, AzureServerConfig> call);

        partial void OnConstruction(AzureClusters.AzureClustersClient grpcClient, AzureClustersSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AzureClusters client</summary>
        public override AzureClusters.AzureClustersClient GrpcClient { get; }

        partial void Modify_CreateAzureClientRequest(ref CreateAzureClientRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAzureClientRequest(ref GetAzureClientRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAzureClientsRequest(ref ListAzureClientsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAzureClientRequest(ref DeleteAzureClientRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAzureClusterRequest(ref CreateAzureClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAzureClusterRequest(ref UpdateAzureClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAzureClusterRequest(ref GetAzureClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAzureClustersRequest(ref ListAzureClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAzureClusterRequest(ref DeleteAzureClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateAzureClusterAgentTokenRequest(ref GenerateAzureClusterAgentTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateAzureAccessTokenRequest(ref GenerateAzureAccessTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAzureNodePoolRequest(ref CreateAzureNodePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAzureNodePoolRequest(ref UpdateAzureNodePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAzureNodePoolRequest(ref GetAzureNodePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAzureNodePoolsRequest(ref ListAzureNodePoolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAzureNodePoolRequest(ref DeleteAzureNodePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAzureOpenIdConfigRequest(ref GetAzureOpenIdConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAzureJsonWebKeysRequest(ref GetAzureJsonWebKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAzureServerConfigRequest(ref GetAzureServerConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateAzureClient</c>.</summary>
        public override lro::OperationsClient CreateAzureClientOperationsClient { get; }

        /// <summary>
        /// Creates a new [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource on a given Google Cloud project and region.
        /// 
        /// `AzureClient` resources hold client authentication
        /// information needed by the Anthos Multicloud API to manage Azure resources
        /// on your Azure subscription on your behalf.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AzureClient, OperationMetadata> CreateAzureClient(CreateAzureClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAzureClientRequest(ref request, ref callSettings);
            return new lro::Operation<AzureClient, OperationMetadata>(_callCreateAzureClient.Sync(request, callSettings), CreateAzureClientOperationsClient);
        }

        /// <summary>
        /// Creates a new [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource on a given Google Cloud project and region.
        /// 
        /// `AzureClient` resources hold client authentication
        /// information needed by the Anthos Multicloud API to manage Azure resources
        /// on your Azure subscription on your behalf.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AzureClient, OperationMetadata>> CreateAzureClientAsync(CreateAzureClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAzureClientRequest(ref request, ref callSettings);
            return new lro::Operation<AzureClient, OperationMetadata>(await _callCreateAzureClient.Async(request, callSettings).ConfigureAwait(false), CreateAzureClientOperationsClient);
        }

        /// <summary>
        /// Describes a specific
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AzureClient GetAzureClient(GetAzureClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAzureClientRequest(ref request, ref callSettings);
            return _callGetAzureClient.Sync(request, callSettings);
        }

        /// <summary>
        /// Describes a specific
        /// [AzureClient][google.cloud.gkemulticloud.v1.AzureClient] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AzureClient> GetAzureClientAsync(GetAzureClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAzureClientRequest(ref request, ref callSettings);
            return _callGetAzureClient.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AzureClient"/> resources.</returns>
        public override gax::PagedEnumerable<ListAzureClientsResponse, AzureClient> ListAzureClients(ListAzureClientsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAzureClientsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAzureClientsRequest, ListAzureClientsResponse, AzureClient>(_callListAzureClients, request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AzureClient"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAzureClientsResponse, AzureClient> ListAzureClientsAsync(ListAzureClientsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAzureClientsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAzureClientsRequest, ListAzureClientsResponse, AzureClient>(_callListAzureClients, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteAzureClient</c>.</summary>
        public override lro::OperationsClient DeleteAzureClientOperationsClient { get; }

        /// <summary>
        /// Deletes a specific [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource.
        /// 
        /// If the client is used by one or more clusters, deletion will
        /// fail and a `FAILED_PRECONDITION` error will be returned.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAzureClient(DeleteAzureClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAzureClientRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAzureClient.Sync(request, callSettings), DeleteAzureClientOperationsClient);
        }

        /// <summary>
        /// Deletes a specific [AzureClient][google.cloud.gkemulticloud.v1.AzureClient]
        /// resource.
        /// 
        /// If the client is used by one or more clusters, deletion will
        /// fail and a `FAILED_PRECONDITION` error will be returned.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClientAsync(DeleteAzureClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAzureClientRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAzureClient.Async(request, callSettings).ConfigureAwait(false), DeleteAzureClientOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateAzureCluster</c>.</summary>
        public override lro::OperationsClient CreateAzureClusterOperationsClient { get; }

        /// <summary>
        /// Creates a new [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AzureCluster, OperationMetadata> CreateAzureCluster(CreateAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAzureClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AzureCluster, OperationMetadata>(_callCreateAzureCluster.Sync(request, callSettings), CreateAzureClusterOperationsClient);
        }

        /// <summary>
        /// Creates a new [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AzureCluster, OperationMetadata>> CreateAzureClusterAsync(CreateAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAzureClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AzureCluster, OperationMetadata>(await _callCreateAzureCluster.Async(request, callSettings).ConfigureAwait(false), CreateAzureClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAzureCluster</c>.</summary>
        public override lro::OperationsClient UpdateAzureClusterOperationsClient { get; }

        /// <summary>
        /// Updates an [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AzureCluster, OperationMetadata> UpdateAzureCluster(UpdateAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAzureClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AzureCluster, OperationMetadata>(_callUpdateAzureCluster.Sync(request, callSettings), UpdateAzureClusterOperationsClient);
        }

        /// <summary>
        /// Updates an [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AzureCluster, OperationMetadata>> UpdateAzureClusterAsync(UpdateAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAzureClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AzureCluster, OperationMetadata>(await _callUpdateAzureCluster.Async(request, callSettings).ConfigureAwait(false), UpdateAzureClusterOperationsClient);
        }

        /// <summary>
        /// Describes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AzureCluster GetAzureCluster(GetAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAzureClusterRequest(ref request, ref callSettings);
            return _callGetAzureCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Describes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AzureCluster> GetAzureClusterAsync(GetAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAzureClusterRequest(ref request, ref callSettings);
            return _callGetAzureCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AzureCluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListAzureClustersResponse, AzureCluster> ListAzureClusters(ListAzureClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAzureClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAzureClustersRequest, ListAzureClustersResponse, AzureCluster>(_callListAzureClusters, request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AzureCluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAzureClustersResponse, AzureCluster> ListAzureClustersAsync(ListAzureClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAzureClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAzureClustersRequest, ListAzureClustersResponse, AzureCluster>(_callListAzureClusters, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteAzureCluster</c>.</summary>
        public override lro::OperationsClient DeleteAzureClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAzureCluster(DeleteAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAzureClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAzureCluster.Sync(request, callSettings), DeleteAzureClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a specific
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureClusterAsync(DeleteAzureClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAzureClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAzureCluster.Async(request, callSettings).ConfigureAwait(false), DeleteAzureClusterOperationsClient);
        }

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateAzureClusterAgentTokenResponse GenerateAzureClusterAgentToken(GenerateAzureClusterAgentTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAzureClusterAgentTokenRequest(ref request, ref callSettings);
            return _callGenerateAzureClusterAgentToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateAzureClusterAgentTokenResponse> GenerateAzureClusterAgentTokenAsync(GenerateAzureClusterAgentTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAzureClusterAgentTokenRequest(ref request, ref callSettings);
            return _callGenerateAzureClusterAgentToken.Async(request, callSettings);
        }

        /// <summary>
        /// Generates a short-lived access token to authenticate to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateAzureAccessTokenResponse GenerateAzureAccessToken(GenerateAzureAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAzureAccessTokenRequest(ref request, ref callSettings);
            return _callGenerateAzureAccessToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a short-lived access token to authenticate to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateAzureAccessTokenResponse> GenerateAzureAccessTokenAsync(GenerateAzureAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAzureAccessTokenRequest(ref request, ref callSettings);
            return _callGenerateAzureAccessToken.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAzureNodePool</c>.</summary>
        public override lro::OperationsClient CreateAzureNodePoolOperationsClient { get; }

        /// <summary>
        /// Creates a new [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool],
        /// attached to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AzureNodePool, OperationMetadata> CreateAzureNodePool(CreateAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAzureNodePoolRequest(ref request, ref callSettings);
            return new lro::Operation<AzureNodePool, OperationMetadata>(_callCreateAzureNodePool.Sync(request, callSettings), CreateAzureNodePoolOperationsClient);
        }

        /// <summary>
        /// Creates a new [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool],
        /// attached to a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> CreateAzureNodePoolAsync(CreateAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAzureNodePoolRequest(ref request, ref callSettings);
            return new lro::Operation<AzureNodePool, OperationMetadata>(await _callCreateAzureNodePool.Async(request, callSettings).ConfigureAwait(false), CreateAzureNodePoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAzureNodePool</c>.</summary>
        public override lro::OperationsClient UpdateAzureNodePoolOperationsClient { get; }

        /// <summary>
        /// Updates an [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AzureNodePool, OperationMetadata> UpdateAzureNodePool(UpdateAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAzureNodePoolRequest(ref request, ref callSettings);
            return new lro::Operation<AzureNodePool, OperationMetadata>(_callUpdateAzureNodePool.Sync(request, callSettings), UpdateAzureNodePoolOperationsClient);
        }

        /// <summary>
        /// Updates an [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AzureNodePool, OperationMetadata>> UpdateAzureNodePoolAsync(UpdateAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAzureNodePoolRequest(ref request, ref callSettings);
            return new lro::Operation<AzureNodePool, OperationMetadata>(await _callUpdateAzureNodePool.Async(request, callSettings).ConfigureAwait(false), UpdateAzureNodePoolOperationsClient);
        }

        /// <summary>
        /// Describes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AzureNodePool GetAzureNodePool(GetAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAzureNodePoolRequest(ref request, ref callSettings);
            return _callGetAzureNodePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Describes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AzureNodePool> GetAzureNodePoolAsync(GetAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAzureNodePoolRequest(ref request, ref callSettings);
            return _callGetAzureNodePool.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]
        /// resources on a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AzureNodePool"/> resources.</returns>
        public override gax::PagedEnumerable<ListAzureNodePoolsResponse, AzureNodePool> ListAzureNodePools(ListAzureNodePoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAzureNodePoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAzureNodePoolsRequest, ListAzureNodePoolsResponse, AzureNodePool>(_callListAzureNodePools, request, callSettings);
        }

        /// <summary>
        /// Lists all [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool]
        /// resources on a given
        /// [AzureCluster][google.cloud.gkemulticloud.v1.AzureCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AzureNodePool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAzureNodePoolsResponse, AzureNodePool> ListAzureNodePoolsAsync(ListAzureNodePoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAzureNodePoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAzureNodePoolsRequest, ListAzureNodePoolsResponse, AzureNodePool>(_callListAzureNodePools, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteAzureNodePool</c>.</summary>
        public override lro::OperationsClient DeleteAzureNodePoolOperationsClient { get; }

        /// <summary>
        /// Deletes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAzureNodePool(DeleteAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAzureNodePoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAzureNodePool.Sync(request, callSettings), DeleteAzureNodePoolOperationsClient);
        }

        /// <summary>
        /// Deletes a specific
        /// [AzureNodePool][google.cloud.gkemulticloud.v1.AzureNodePool] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAzureNodePoolAsync(DeleteAzureNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAzureNodePoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAzureNodePool.Async(request, callSettings).ConfigureAwait(false), DeleteAzureNodePoolOperationsClient);
        }

        /// <summary>
        /// Gets the OIDC discovery document for the cluster.
        /// See the
        /// [OpenID Connect Discovery 1.0
        /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html)
        /// for details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AzureOpenIdConfig GetAzureOpenIdConfig(GetAzureOpenIdConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAzureOpenIdConfigRequest(ref request, ref callSettings);
            return _callGetAzureOpenIdConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the OIDC discovery document for the cluster.
        /// See the
        /// [OpenID Connect Discovery 1.0
        /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html)
        /// for details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AzureOpenIdConfig> GetAzureOpenIdConfigAsync(GetAzureOpenIdConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAzureOpenIdConfigRequest(ref request, ref callSettings);
            return _callGetAzureOpenIdConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AzureJsonWebKeys GetAzureJsonWebKeys(GetAzureJsonWebKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAzureJsonWebKeysRequest(ref request, ref callSettings);
            return _callGetAzureJsonWebKeys.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AzureJsonWebKeys> GetAzureJsonWebKeysAsync(GetAzureJsonWebKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAzureJsonWebKeysRequest(ref request, ref callSettings);
            return _callGetAzureJsonWebKeys.Async(request, callSettings);
        }

        /// <summary>
        /// Returns information, such as supported Azure regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AzureServerConfig GetAzureServerConfig(GetAzureServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAzureServerConfigRequest(ref request, ref callSettings);
            return _callGetAzureServerConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information, such as supported Azure regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AzureServerConfig> GetAzureServerConfigAsync(GetAzureServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAzureServerConfigRequest(ref request, ref callSettings);
            return _callGetAzureServerConfig.Async(request, callSettings);
        }
    }

    public partial class ListAzureClientsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAzureClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAzureNodePoolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAzureClientsResponse : gaxgrpc::IPageResponse<AzureClient>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AzureClient> GetEnumerator() => AzureClients.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAzureClustersResponse : gaxgrpc::IPageResponse<AzureCluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AzureCluster> GetEnumerator() => AzureClusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAzureNodePoolsResponse : gaxgrpc::IPageResponse<AzureNodePool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AzureNodePool> GetEnumerator() => AzureNodePools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AzureClusters
    {
        public partial class AzureClustersClient
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
