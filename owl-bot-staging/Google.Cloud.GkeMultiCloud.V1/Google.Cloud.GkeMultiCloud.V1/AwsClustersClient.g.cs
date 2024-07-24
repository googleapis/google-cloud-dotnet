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
    /// <summary>Settings for <see cref="AwsClustersClient"/> instances.</summary>
    public sealed partial class AwsClustersSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AwsClustersSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AwsClustersSettings"/>.</returns>
        public static AwsClustersSettings GetDefault() => new AwsClustersSettings();

        /// <summary>Constructs a new <see cref="AwsClustersSettings"/> object with default settings.</summary>
        public AwsClustersSettings()
        {
        }

        private AwsClustersSettings(AwsClustersSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateAwsClusterSettings = existing.CreateAwsClusterSettings;
            CreateAwsClusterOperationsSettings = existing.CreateAwsClusterOperationsSettings.Clone();
            UpdateAwsClusterSettings = existing.UpdateAwsClusterSettings;
            UpdateAwsClusterOperationsSettings = existing.UpdateAwsClusterOperationsSettings.Clone();
            GetAwsClusterSettings = existing.GetAwsClusterSettings;
            ListAwsClustersSettings = existing.ListAwsClustersSettings;
            DeleteAwsClusterSettings = existing.DeleteAwsClusterSettings;
            DeleteAwsClusterOperationsSettings = existing.DeleteAwsClusterOperationsSettings.Clone();
            GenerateAwsClusterAgentTokenSettings = existing.GenerateAwsClusterAgentTokenSettings;
            GenerateAwsAccessTokenSettings = existing.GenerateAwsAccessTokenSettings;
            CreateAwsNodePoolSettings = existing.CreateAwsNodePoolSettings;
            CreateAwsNodePoolOperationsSettings = existing.CreateAwsNodePoolOperationsSettings.Clone();
            UpdateAwsNodePoolSettings = existing.UpdateAwsNodePoolSettings;
            UpdateAwsNodePoolOperationsSettings = existing.UpdateAwsNodePoolOperationsSettings.Clone();
            RollbackAwsNodePoolUpdateSettings = existing.RollbackAwsNodePoolUpdateSettings;
            RollbackAwsNodePoolUpdateOperationsSettings = existing.RollbackAwsNodePoolUpdateOperationsSettings.Clone();
            GetAwsNodePoolSettings = existing.GetAwsNodePoolSettings;
            ListAwsNodePoolsSettings = existing.ListAwsNodePoolsSettings;
            DeleteAwsNodePoolSettings = existing.DeleteAwsNodePoolSettings;
            DeleteAwsNodePoolOperationsSettings = existing.DeleteAwsNodePoolOperationsSettings.Clone();
            GetAwsOpenIdConfigSettings = existing.GetAwsOpenIdConfigSettings;
            GetAwsJsonWebKeysSettings = existing.GetAwsJsonWebKeysSettings;
            GetAwsServerConfigSettings = existing.GetAwsServerConfigSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AwsClustersSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.CreateAwsCluster</c> and <c>AwsClustersClient.CreateAwsClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAwsClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AwsClustersClient.CreateAwsCluster</c> and
        /// <c>AwsClustersClient.CreateAwsClusterAsync</c>.
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
        public lro::OperationsSettings CreateAwsClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.UpdateAwsCluster</c> and <c>AwsClustersClient.UpdateAwsClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAwsClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AwsClustersClient.UpdateAwsCluster</c> and
        /// <c>AwsClustersClient.UpdateAwsClusterAsync</c>.
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
        public lro::OperationsSettings UpdateAwsClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.GetAwsCluster</c> and <c>AwsClustersClient.GetAwsClusterAsync</c>.
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
        public gaxgrpc::CallSettings GetAwsClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.ListAwsClusters</c> and <c>AwsClustersClient.ListAwsClustersAsync</c>.
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
        public gaxgrpc::CallSettings ListAwsClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.DeleteAwsCluster</c> and <c>AwsClustersClient.DeleteAwsClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAwsClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AwsClustersClient.DeleteAwsCluster</c> and
        /// <c>AwsClustersClient.DeleteAwsClusterAsync</c>.
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
        public lro::OperationsSettings DeleteAwsClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.GenerateAwsClusterAgentToken</c> and
        /// <c>AwsClustersClient.GenerateAwsClusterAgentTokenAsync</c>.
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
        public gaxgrpc::CallSettings GenerateAwsClusterAgentTokenSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.GenerateAwsAccessToken</c> and <c>AwsClustersClient.GenerateAwsAccessTokenAsync</c>.
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
        public gaxgrpc::CallSettings GenerateAwsAccessTokenSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.CreateAwsNodePool</c> and <c>AwsClustersClient.CreateAwsNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAwsNodePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AwsClustersClient.CreateAwsNodePool</c> and
        /// <c>AwsClustersClient.CreateAwsNodePoolAsync</c>.
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
        public lro::OperationsSettings CreateAwsNodePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.UpdateAwsNodePool</c> and <c>AwsClustersClient.UpdateAwsNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAwsNodePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AwsClustersClient.UpdateAwsNodePool</c> and
        /// <c>AwsClustersClient.UpdateAwsNodePoolAsync</c>.
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
        public lro::OperationsSettings UpdateAwsNodePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.RollbackAwsNodePoolUpdate</c> and <c>AwsClustersClient.RollbackAwsNodePoolUpdateAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RollbackAwsNodePoolUpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AwsClustersClient.RollbackAwsNodePoolUpdate</c> and
        /// <c>AwsClustersClient.RollbackAwsNodePoolUpdateAsync</c>.
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
        public lro::OperationsSettings RollbackAwsNodePoolUpdateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.GetAwsNodePool</c> and <c>AwsClustersClient.GetAwsNodePoolAsync</c>.
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
        public gaxgrpc::CallSettings GetAwsNodePoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.ListAwsNodePools</c> and <c>AwsClustersClient.ListAwsNodePoolsAsync</c>.
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
        public gaxgrpc::CallSettings ListAwsNodePoolsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.DeleteAwsNodePool</c> and <c>AwsClustersClient.DeleteAwsNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAwsNodePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AwsClustersClient.DeleteAwsNodePool</c> and
        /// <c>AwsClustersClient.DeleteAwsNodePoolAsync</c>.
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
        public lro::OperationsSettings DeleteAwsNodePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.GetAwsOpenIdConfig</c> and <c>AwsClustersClient.GetAwsOpenIdConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetAwsOpenIdConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.GetAwsJsonWebKeys</c> and <c>AwsClustersClient.GetAwsJsonWebKeysAsync</c>.
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
        public gaxgrpc::CallSettings GetAwsJsonWebKeysSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AwsClustersClient.GetAwsServerConfig</c> and <c>AwsClustersClient.GetAwsServerConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetAwsServerConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AwsClustersSettings"/> object.</returns>
        public AwsClustersSettings Clone() => new AwsClustersSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AwsClustersClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AwsClustersClientBuilder : gaxgrpc::ClientBuilderBase<AwsClustersClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AwsClustersSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AwsClustersClientBuilder() : base(AwsClustersClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AwsClustersClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AwsClustersClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AwsClustersClient Build()
        {
            AwsClustersClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AwsClustersClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AwsClustersClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AwsClustersClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AwsClustersClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AwsClustersClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AwsClustersClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AwsClustersClient.ChannelPool;
    }

    /// <summary>AwsClusters client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The AwsClusters API provides a single centrally managed service
    /// to create and manage Anthos clusters that run on AWS infrastructure.
    /// </remarks>
    public abstract partial class AwsClustersClient
    {
        /// <summary>
        /// The default endpoint for the AwsClusters service, which is a host of "gkemulticloud.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gkemulticloud.googleapis.com:443";

        /// <summary>The default AwsClusters scopes.</summary>
        /// <remarks>
        /// The default AwsClusters scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AwsClusters.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AwsClustersClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AwsClustersClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AwsClustersClient"/>.</returns>
        public static stt::Task<AwsClustersClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AwsClustersClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AwsClustersClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AwsClustersClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AwsClustersClient"/>.</returns>
        public static AwsClustersClient Create() => new AwsClustersClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AwsClustersClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AwsClustersSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AwsClustersClient"/>.</returns>
        internal static AwsClustersClient Create(grpccore::CallInvoker callInvoker, AwsClustersSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AwsClusters.AwsClustersClient grpcClient = new AwsClusters.AwsClustersClient(callInvoker);
            return new AwsClustersClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AwsClusters client</summary>
        public virtual AwsClusters.AwsClustersClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AwsCluster, OperationMetadata> CreateAwsCluster(CreateAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsCluster, OperationMetadata>> CreateAwsClusterAsync(CreateAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsCluster, OperationMetadata>> CreateAwsClusterAsync(CreateAwsClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateAwsClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAwsCluster</c>.</summary>
        public virtual lro::OperationsClient CreateAwsClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAwsCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AwsCluster, OperationMetadata> PollOnceCreateAwsCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AwsCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAwsClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAwsCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AwsCluster, OperationMetadata>> PollOnceCreateAwsClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AwsCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAwsClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a new [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="awsCluster">
        /// Required. The specification of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] to create.
        /// </param>
        /// <param name="awsClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AwsCluster, OperationMetadata> CreateAwsCluster(string parent, AwsCluster awsCluster, string awsClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAwsCluster(new CreateAwsClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AwsCluster = gax::GaxPreconditions.CheckNotNull(awsCluster, nameof(awsCluster)),
                AwsClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(awsClusterId, nameof(awsClusterId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="awsCluster">
        /// Required. The specification of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] to create.
        /// </param>
        /// <param name="awsClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsCluster, OperationMetadata>> CreateAwsClusterAsync(string parent, AwsCluster awsCluster, string awsClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAwsClusterAsync(new CreateAwsClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AwsCluster = gax::GaxPreconditions.CheckNotNull(awsCluster, nameof(awsCluster)),
                AwsClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(awsClusterId, nameof(awsClusterId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="awsCluster">
        /// Required. The specification of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] to create.
        /// </param>
        /// <param name="awsClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsCluster, OperationMetadata>> CreateAwsClusterAsync(string parent, AwsCluster awsCluster, string awsClusterId, st::CancellationToken cancellationToken) =>
            CreateAwsClusterAsync(parent, awsCluster, awsClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="awsCluster">
        /// Required. The specification of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] to create.
        /// </param>
        /// <param name="awsClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AwsCluster, OperationMetadata> CreateAwsCluster(gagr::LocationName parent, AwsCluster awsCluster, string awsClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAwsCluster(new CreateAwsClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AwsCluster = gax::GaxPreconditions.CheckNotNull(awsCluster, nameof(awsCluster)),
                AwsClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(awsClusterId, nameof(awsClusterId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="awsCluster">
        /// Required. The specification of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] to create.
        /// </param>
        /// <param name="awsClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsCluster, OperationMetadata>> CreateAwsClusterAsync(gagr::LocationName parent, AwsCluster awsCluster, string awsClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAwsClusterAsync(new CreateAwsClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AwsCluster = gax::GaxPreconditions.CheckNotNull(awsCluster, nameof(awsCluster)),
                AwsClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(awsClusterId, nameof(awsClusterId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource will be
        /// created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="awsCluster">
        /// Required. The specification of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] to create.
        /// </param>
        /// <param name="awsClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsCluster, OperationMetadata>> CreateAwsClusterAsync(gagr::LocationName parent, AwsCluster awsCluster, string awsClusterId, st::CancellationToken cancellationToken) =>
            CreateAwsClusterAsync(parent, awsCluster, awsClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AwsCluster, OperationMetadata> UpdateAwsCluster(UpdateAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsCluster, OperationMetadata>> UpdateAwsClusterAsync(UpdateAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsCluster, OperationMetadata>> UpdateAwsClusterAsync(UpdateAwsClusterRequest request, st::CancellationToken cancellationToken) =>
            UpdateAwsClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAwsCluster</c>.</summary>
        public virtual lro::OperationsClient UpdateAwsClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAwsCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AwsCluster, OperationMetadata> PollOnceUpdateAwsCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AwsCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAwsClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAwsCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AwsCluster, OperationMetadata>> PollOnceUpdateAwsClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AwsCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAwsClusterOperationsClient, callSettings);

        /// <summary>
        /// Updates an [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="awsCluster">
        /// Required. The [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]:
        /// 
        /// *   `description`.
        /// *   `annotations`.
        /// *   `control_plane.version`.
        /// *   `authorization.admin_users`.
        /// *   `authorization.admin_groups`.
        /// *   `binary_authorization.evaluation_mode`.
        /// *   `control_plane.aws_services_authentication.role_arn`.
        /// *   `control_plane.aws_services_authentication.role_session_name`.
        /// *   `control_plane.config_encryption.kms_key_arn`.
        /// *   `control_plane.instance_type`.
        /// *   `control_plane.security_group_ids`.
        /// *   `control_plane.proxy_config`.
        /// *   `control_plane.proxy_config.secret_arn`.
        /// *   `control_plane.proxy_config.secret_version`.
        /// *   `control_plane.root_volume.size_gib`.
        /// *   `control_plane.root_volume.volume_type`.
        /// *   `control_plane.root_volume.iops`.
        /// *   `control_plane.root_volume.throughput`.
        /// *   `control_plane.root_volume.kms_key_arn`.
        /// *   `control_plane.ssh_config`.
        /// *   `control_plane.ssh_config.ec2_key_pair`.
        /// *   `control_plane.instance_placement.tenancy`.
        /// *   `control_plane.iam_instance_profile`.
        /// *   `logging_config.component_config.enable_components`.
        /// *   `control_plane.tags`.
        /// *   `monitoring_config.managed_prometheus_config.enabled`.
        /// *   `networking.per_node_pool_sg_rules_disabled`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AwsCluster, OperationMetadata> UpdateAwsCluster(AwsCluster awsCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAwsCluster(new UpdateAwsClusterRequest
            {
                AwsCluster = gax::GaxPreconditions.CheckNotNull(awsCluster, nameof(awsCluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="awsCluster">
        /// Required. The [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]:
        /// 
        /// *   `description`.
        /// *   `annotations`.
        /// *   `control_plane.version`.
        /// *   `authorization.admin_users`.
        /// *   `authorization.admin_groups`.
        /// *   `binary_authorization.evaluation_mode`.
        /// *   `control_plane.aws_services_authentication.role_arn`.
        /// *   `control_plane.aws_services_authentication.role_session_name`.
        /// *   `control_plane.config_encryption.kms_key_arn`.
        /// *   `control_plane.instance_type`.
        /// *   `control_plane.security_group_ids`.
        /// *   `control_plane.proxy_config`.
        /// *   `control_plane.proxy_config.secret_arn`.
        /// *   `control_plane.proxy_config.secret_version`.
        /// *   `control_plane.root_volume.size_gib`.
        /// *   `control_plane.root_volume.volume_type`.
        /// *   `control_plane.root_volume.iops`.
        /// *   `control_plane.root_volume.throughput`.
        /// *   `control_plane.root_volume.kms_key_arn`.
        /// *   `control_plane.ssh_config`.
        /// *   `control_plane.ssh_config.ec2_key_pair`.
        /// *   `control_plane.instance_placement.tenancy`.
        /// *   `control_plane.iam_instance_profile`.
        /// *   `logging_config.component_config.enable_components`.
        /// *   `control_plane.tags`.
        /// *   `monitoring_config.managed_prometheus_config.enabled`.
        /// *   `networking.per_node_pool_sg_rules_disabled`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsCluster, OperationMetadata>> UpdateAwsClusterAsync(AwsCluster awsCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAwsClusterAsync(new UpdateAwsClusterRequest
            {
                AwsCluster = gax::GaxPreconditions.CheckNotNull(awsCluster, nameof(awsCluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="awsCluster">
        /// Required. The [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]:
        /// 
        /// *   `description`.
        /// *   `annotations`.
        /// *   `control_plane.version`.
        /// *   `authorization.admin_users`.
        /// *   `authorization.admin_groups`.
        /// *   `binary_authorization.evaluation_mode`.
        /// *   `control_plane.aws_services_authentication.role_arn`.
        /// *   `control_plane.aws_services_authentication.role_session_name`.
        /// *   `control_plane.config_encryption.kms_key_arn`.
        /// *   `control_plane.instance_type`.
        /// *   `control_plane.security_group_ids`.
        /// *   `control_plane.proxy_config`.
        /// *   `control_plane.proxy_config.secret_arn`.
        /// *   `control_plane.proxy_config.secret_version`.
        /// *   `control_plane.root_volume.size_gib`.
        /// *   `control_plane.root_volume.volume_type`.
        /// *   `control_plane.root_volume.iops`.
        /// *   `control_plane.root_volume.throughput`.
        /// *   `control_plane.root_volume.kms_key_arn`.
        /// *   `control_plane.ssh_config`.
        /// *   `control_plane.ssh_config.ec2_key_pair`.
        /// *   `control_plane.instance_placement.tenancy`.
        /// *   `control_plane.iam_instance_profile`.
        /// *   `logging_config.component_config.enable_components`.
        /// *   `control_plane.tags`.
        /// *   `monitoring_config.managed_prometheus_config.enabled`.
        /// *   `networking.per_node_pool_sg_rules_disabled`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsCluster, OperationMetadata>> UpdateAwsClusterAsync(AwsCluster awsCluster, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAwsClusterAsync(awsCluster, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AwsCluster GetAwsCluster(GetAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsCluster> GetAwsClusterAsync(GetAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsCluster> GetAwsClusterAsync(GetAwsClusterRequest request, st::CancellationToken cancellationToken) =>
            GetAwsClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource to
        /// describe.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AwsCluster GetAwsCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAwsCluster(new GetAwsClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource to
        /// describe.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsCluster> GetAwsClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAwsClusterAsync(new GetAwsClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource to
        /// describe.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsCluster> GetAwsClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetAwsClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource to
        /// describe.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AwsCluster GetAwsCluster(AwsClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAwsCluster(new GetAwsClusterRequest
            {
                AwsClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource to
        /// describe.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsCluster> GetAwsClusterAsync(AwsClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAwsClusterAsync(new GetAwsClusterRequest
            {
                AwsClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource to
        /// describe.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsCluster> GetAwsClusterAsync(AwsClusterName name, st::CancellationToken cancellationToken) =>
            GetAwsClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resources
        /// on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AwsCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAwsClustersResponse, AwsCluster> ListAwsClusters(ListAwsClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resources
        /// on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AwsCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAwsClustersResponse, AwsCluster> ListAwsClustersAsync(ListAwsClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resources
        /// on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resources.
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
        /// <returns>A pageable sequence of <see cref="AwsCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAwsClustersResponse, AwsCluster> ListAwsClusters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAwsClustersRequest request = new ListAwsClustersRequest
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
            return ListAwsClusters(request, callSettings);
        }

        /// <summary>
        /// Lists all [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resources
        /// on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resources.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AwsCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAwsClustersResponse, AwsCluster> ListAwsClustersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAwsClustersRequest request = new ListAwsClustersRequest
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
            return ListAwsClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resources
        /// on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resources.
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
        /// <returns>A pageable sequence of <see cref="AwsCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAwsClustersResponse, AwsCluster> ListAwsClusters(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAwsClustersRequest request = new ListAwsClustersRequest
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
            return ListAwsClusters(request, callSettings);
        }

        /// <summary>
        /// Lists all [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resources
        /// on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resources.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AwsCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAwsClustersResponse, AwsCluster> ListAwsClustersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAwsClustersRequest request = new ListAwsClustersRequest
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
            return ListAwsClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAwsCluster(DeleteAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsClusterAsync(DeleteAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsClusterAsync(DeleteAwsClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteAwsClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAwsCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteAwsClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAwsCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAwsCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAwsClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAwsCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAwsClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAwsClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] to delete.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAwsCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAwsCluster(new DeleteAwsClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] to delete.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAwsClusterAsync(new DeleteAwsClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] to delete.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAwsClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] to delete.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAwsCluster(AwsClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAwsCluster(new DeleteAwsClusterRequest
            {
                AwsClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] to delete.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsClusterAsync(AwsClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAwsClusterAsync(new DeleteAwsClusterRequest
            {
                AwsClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] to delete.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsClusterAsync(AwsClusterName name, st::CancellationToken cancellationToken) =>
            DeleteAwsClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAwsClusterAgentTokenResponse GenerateAwsClusterAgentToken(GenerateAwsClusterAgentTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAwsClusterAgentTokenResponse> GenerateAwsClusterAgentTokenAsync(GenerateAwsClusterAgentTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAwsClusterAgentTokenResponse> GenerateAwsClusterAgentTokenAsync(GenerateAwsClusterAgentTokenRequest request, st::CancellationToken cancellationToken) =>
            GenerateAwsClusterAgentTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a short-lived access token to authenticate to a given
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAwsAccessTokenResponse GenerateAwsAccessToken(GenerateAwsAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a short-lived access token to authenticate to a given
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAwsAccessTokenResponse> GenerateAwsAccessTokenAsync(GenerateAwsAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a short-lived access token to authenticate to a given
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAwsAccessTokenResponse> GenerateAwsAccessTokenAsync(GenerateAwsAccessTokenRequest request, st::CancellationToken cancellationToken) =>
            GenerateAwsAccessTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool],
        /// attached to a given [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AwsNodePool, OperationMetadata> CreateAwsNodePool(CreateAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool],
        /// attached to a given [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> CreateAwsNodePoolAsync(CreateAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool],
        /// attached to a given [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> CreateAwsNodePoolAsync(CreateAwsNodePoolRequest request, st::CancellationToken cancellationToken) =>
            CreateAwsNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAwsNodePool</c>.</summary>
        public virtual lro::OperationsClient CreateAwsNodePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAwsNodePool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AwsNodePool, OperationMetadata> PollOnceCreateAwsNodePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AwsNodePool, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAwsNodePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAwsNodePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> PollOnceCreateAwsNodePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AwsNodePool, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAwsNodePoolOperationsClient, callSettings);

        /// <summary>
        /// Creates a new [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool],
        /// attached to a given [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource where this node pool will be created.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="awsNodePool">
        /// Required. The specification of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] to create.
        /// </param>
        /// <param name="awsNodePoolId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AwsNodePool, OperationMetadata> CreateAwsNodePool(string parent, AwsNodePool awsNodePool, string awsNodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAwsNodePool(new CreateAwsNodePoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AwsNodePool = gax::GaxPreconditions.CheckNotNull(awsNodePool, nameof(awsNodePool)),
                AwsNodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(awsNodePoolId, nameof(awsNodePoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool],
        /// attached to a given [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource where this node pool will be created.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="awsNodePool">
        /// Required. The specification of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] to create.
        /// </param>
        /// <param name="awsNodePoolId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> CreateAwsNodePoolAsync(string parent, AwsNodePool awsNodePool, string awsNodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAwsNodePoolAsync(new CreateAwsNodePoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AwsNodePool = gax::GaxPreconditions.CheckNotNull(awsNodePool, nameof(awsNodePool)),
                AwsNodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(awsNodePoolId, nameof(awsNodePoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool],
        /// attached to a given [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource where this node pool will be created.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="awsNodePool">
        /// Required. The specification of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] to create.
        /// </param>
        /// <param name="awsNodePoolId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> CreateAwsNodePoolAsync(string parent, AwsNodePool awsNodePool, string awsNodePoolId, st::CancellationToken cancellationToken) =>
            CreateAwsNodePoolAsync(parent, awsNodePool, awsNodePoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool],
        /// attached to a given [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource where this node pool will be created.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="awsNodePool">
        /// Required. The specification of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] to create.
        /// </param>
        /// <param name="awsNodePoolId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AwsNodePool, OperationMetadata> CreateAwsNodePool(AwsClusterName parent, AwsNodePool awsNodePool, string awsNodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAwsNodePool(new CreateAwsNodePoolRequest
            {
                ParentAsAwsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AwsNodePool = gax::GaxPreconditions.CheckNotNull(awsNodePool, nameof(awsNodePool)),
                AwsNodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(awsNodePoolId, nameof(awsNodePoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool],
        /// attached to a given [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource where this node pool will be created.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="awsNodePool">
        /// Required. The specification of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] to create.
        /// </param>
        /// <param name="awsNodePoolId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> CreateAwsNodePoolAsync(AwsClusterName parent, AwsNodePool awsNodePool, string awsNodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAwsNodePoolAsync(new CreateAwsNodePoolRequest
            {
                ParentAsAwsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AwsNodePool = gax::GaxPreconditions.CheckNotNull(awsNodePool, nameof(awsNodePool)),
                AwsNodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(awsNodePoolId, nameof(awsNodePoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool],
        /// attached to a given [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource where this node pool will be created.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="awsNodePool">
        /// Required. The specification of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] to create.
        /// </param>
        /// <param name="awsNodePoolId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource name
        /// formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> CreateAwsNodePoolAsync(AwsClusterName parent, AwsNodePool awsNodePool, string awsNodePoolId, st::CancellationToken cancellationToken) =>
            CreateAwsNodePoolAsync(parent, awsNodePool, awsNodePoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AwsNodePool, OperationMetadata> UpdateAwsNodePool(UpdateAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> UpdateAwsNodePoolAsync(UpdateAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> UpdateAwsNodePoolAsync(UpdateAwsNodePoolRequest request, st::CancellationToken cancellationToken) =>
            UpdateAwsNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAwsNodePool</c>.</summary>
        public virtual lro::OperationsClient UpdateAwsNodePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAwsNodePool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AwsNodePool, OperationMetadata> PollOnceUpdateAwsNodePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AwsNodePool, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAwsNodePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAwsNodePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> PollOnceUpdateAwsNodePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AwsNodePool, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAwsNodePoolOperationsClient, callSettings);

        /// <summary>
        /// Updates an [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool].
        /// </summary>
        /// <param name="awsNodePool">
        /// Required. The [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]:
        /// 
        /// *   `annotations`.
        /// *   `version`.
        /// *   `autoscaling.min_node_count`.
        /// *   `autoscaling.max_node_count`.
        /// *   `config.config_encryption.kms_key_arn`.
        /// *   `config.security_group_ids`.
        /// *   `config.root_volume.iops`.
        /// *   `config.root_volume.throughput`.
        /// *   `config.root_volume.kms_key_arn`.
        /// *   `config.root_volume.volume_type`.
        /// *   `config.root_volume.size_gib`.
        /// *   `config.proxy_config`.
        /// *   `config.proxy_config.secret_arn`.
        /// *   `config.proxy_config.secret_version`.
        /// *   `config.ssh_config`.
        /// *   `config.ssh_config.ec2_key_pair`.
        /// *   `config.instance_placement.tenancy`.
        /// *   `config.iam_instance_profile`.
        /// *   `config.labels`.
        /// *   `config.tags`.
        /// *   `config.autoscaling_metrics_collection`.
        /// *   `config.autoscaling_metrics_collection.granularity`.
        /// *   `config.autoscaling_metrics_collection.metrics`.
        /// *   `config.instance_type`.
        /// *   `management.auto_repair`.
        /// *   `management`.
        /// *   `update_settings`.
        /// *   `update_settings.surge_settings`.
        /// *   `update_settings.surge_settings.max_surge`.
        /// *   `update_settings.surge_settings.max_unavailable`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AwsNodePool, OperationMetadata> UpdateAwsNodePool(AwsNodePool awsNodePool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAwsNodePool(new UpdateAwsNodePoolRequest
            {
                AwsNodePool = gax::GaxPreconditions.CheckNotNull(awsNodePool, nameof(awsNodePool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool].
        /// </summary>
        /// <param name="awsNodePool">
        /// Required. The [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]:
        /// 
        /// *   `annotations`.
        /// *   `version`.
        /// *   `autoscaling.min_node_count`.
        /// *   `autoscaling.max_node_count`.
        /// *   `config.config_encryption.kms_key_arn`.
        /// *   `config.security_group_ids`.
        /// *   `config.root_volume.iops`.
        /// *   `config.root_volume.throughput`.
        /// *   `config.root_volume.kms_key_arn`.
        /// *   `config.root_volume.volume_type`.
        /// *   `config.root_volume.size_gib`.
        /// *   `config.proxy_config`.
        /// *   `config.proxy_config.secret_arn`.
        /// *   `config.proxy_config.secret_version`.
        /// *   `config.ssh_config`.
        /// *   `config.ssh_config.ec2_key_pair`.
        /// *   `config.instance_placement.tenancy`.
        /// *   `config.iam_instance_profile`.
        /// *   `config.labels`.
        /// *   `config.tags`.
        /// *   `config.autoscaling_metrics_collection`.
        /// *   `config.autoscaling_metrics_collection.granularity`.
        /// *   `config.autoscaling_metrics_collection.metrics`.
        /// *   `config.instance_type`.
        /// *   `management.auto_repair`.
        /// *   `management`.
        /// *   `update_settings`.
        /// *   `update_settings.surge_settings`.
        /// *   `update_settings.surge_settings.max_surge`.
        /// *   `update_settings.surge_settings.max_unavailable`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> UpdateAwsNodePoolAsync(AwsNodePool awsNodePool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAwsNodePoolAsync(new UpdateAwsNodePoolRequest
            {
                AwsNodePool = gax::GaxPreconditions.CheckNotNull(awsNodePool, nameof(awsNodePool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool].
        /// </summary>
        /// <param name="awsNodePool">
        /// Required. The [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]:
        /// 
        /// *   `annotations`.
        /// *   `version`.
        /// *   `autoscaling.min_node_count`.
        /// *   `autoscaling.max_node_count`.
        /// *   `config.config_encryption.kms_key_arn`.
        /// *   `config.security_group_ids`.
        /// *   `config.root_volume.iops`.
        /// *   `config.root_volume.throughput`.
        /// *   `config.root_volume.kms_key_arn`.
        /// *   `config.root_volume.volume_type`.
        /// *   `config.root_volume.size_gib`.
        /// *   `config.proxy_config`.
        /// *   `config.proxy_config.secret_arn`.
        /// *   `config.proxy_config.secret_version`.
        /// *   `config.ssh_config`.
        /// *   `config.ssh_config.ec2_key_pair`.
        /// *   `config.instance_placement.tenancy`.
        /// *   `config.iam_instance_profile`.
        /// *   `config.labels`.
        /// *   `config.tags`.
        /// *   `config.autoscaling_metrics_collection`.
        /// *   `config.autoscaling_metrics_collection.granularity`.
        /// *   `config.autoscaling_metrics_collection.metrics`.
        /// *   `config.instance_type`.
        /// *   `management.auto_repair`.
        /// *   `management`.
        /// *   `update_settings`.
        /// *   `update_settings.surge_settings`.
        /// *   `update_settings.surge_settings.max_surge`.
        /// *   `update_settings.surge_settings.max_unavailable`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> UpdateAwsNodePoolAsync(AwsNodePool awsNodePool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAwsNodePoolAsync(awsNodePool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a previously aborted or failed
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] update request.
        /// Makes no changes if the last update request successfully finished.
        /// If an update request is in progress, you cannot rollback the update.
        /// You must first cancel or let it finish unsuccessfully before you can
        /// rollback.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AwsNodePool, OperationMetadata> RollbackAwsNodePoolUpdate(RollbackAwsNodePoolUpdateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rolls back a previously aborted or failed
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] update request.
        /// Makes no changes if the last update request successfully finished.
        /// If an update request is in progress, you cannot rollback the update.
        /// You must first cancel or let it finish unsuccessfully before you can
        /// rollback.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> RollbackAwsNodePoolUpdateAsync(RollbackAwsNodePoolUpdateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rolls back a previously aborted or failed
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] update request.
        /// Makes no changes if the last update request successfully finished.
        /// If an update request is in progress, you cannot rollback the update.
        /// You must first cancel or let it finish unsuccessfully before you can
        /// rollback.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> RollbackAwsNodePoolUpdateAsync(RollbackAwsNodePoolUpdateRequest request, st::CancellationToken cancellationToken) =>
            RollbackAwsNodePoolUpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RollbackAwsNodePoolUpdate</c>.</summary>
        public virtual lro::OperationsClient RollbackAwsNodePoolUpdateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RollbackAwsNodePoolUpdate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AwsNodePool, OperationMetadata> PollOnceRollbackAwsNodePoolUpdate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AwsNodePool, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RollbackAwsNodePoolUpdateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RollbackAwsNodePoolUpdate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> PollOnceRollbackAwsNodePoolUpdateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AwsNodePool, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RollbackAwsNodePoolUpdateOperationsClient, callSettings);

        /// <summary>
        /// Rolls back a previously aborted or failed
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] update request.
        /// Makes no changes if the last update request successfully finished.
        /// If an update request is in progress, you cannot rollback the update.
        /// You must first cancel or let it finish unsuccessfully before you can
        /// rollback.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource to
        /// rollback.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AwsNodePool, OperationMetadata> RollbackAwsNodePoolUpdate(string name, gaxgrpc::CallSettings callSettings = null) =>
            RollbackAwsNodePoolUpdate(new RollbackAwsNodePoolUpdateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Rolls back a previously aborted or failed
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] update request.
        /// Makes no changes if the last update request successfully finished.
        /// If an update request is in progress, you cannot rollback the update.
        /// You must first cancel or let it finish unsuccessfully before you can
        /// rollback.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource to
        /// rollback.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> RollbackAwsNodePoolUpdateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RollbackAwsNodePoolUpdateAsync(new RollbackAwsNodePoolUpdateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Rolls back a previously aborted or failed
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] update request.
        /// Makes no changes if the last update request successfully finished.
        /// If an update request is in progress, you cannot rollback the update.
        /// You must first cancel or let it finish unsuccessfully before you can
        /// rollback.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource to
        /// rollback.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> RollbackAwsNodePoolUpdateAsync(string name, st::CancellationToken cancellationToken) =>
            RollbackAwsNodePoolUpdateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a previously aborted or failed
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] update request.
        /// Makes no changes if the last update request successfully finished.
        /// If an update request is in progress, you cannot rollback the update.
        /// You must first cancel or let it finish unsuccessfully before you can
        /// rollback.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource to
        /// rollback.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AwsNodePool, OperationMetadata> RollbackAwsNodePoolUpdate(AwsNodePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            RollbackAwsNodePoolUpdate(new RollbackAwsNodePoolUpdateRequest
            {
                AwsNodePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Rolls back a previously aborted or failed
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] update request.
        /// Makes no changes if the last update request successfully finished.
        /// If an update request is in progress, you cannot rollback the update.
        /// You must first cancel or let it finish unsuccessfully before you can
        /// rollback.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource to
        /// rollback.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> RollbackAwsNodePoolUpdateAsync(AwsNodePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            RollbackAwsNodePoolUpdateAsync(new RollbackAwsNodePoolUpdateRequest
            {
                AwsNodePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Rolls back a previously aborted or failed
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] update request.
        /// Makes no changes if the last update request successfully finished.
        /// If an update request is in progress, you cannot rollback the update.
        /// You must first cancel or let it finish unsuccessfully before you can
        /// rollback.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource to
        /// rollback.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> RollbackAwsNodePoolUpdateAsync(AwsNodePoolName name, st::CancellationToken cancellationToken) =>
            RollbackAwsNodePoolUpdateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AwsNodePool GetAwsNodePool(GetAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specific
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsNodePool> GetAwsNodePoolAsync(GetAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specific
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsNodePool> GetAwsNodePoolAsync(GetAwsNodePoolRequest request, st::CancellationToken cancellationToken) =>
            GetAwsNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource to
        /// describe.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AwsNodePool GetAwsNodePool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAwsNodePool(new GetAwsNodePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource to
        /// describe.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsNodePool> GetAwsNodePoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAwsNodePoolAsync(new GetAwsNodePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource to
        /// describe.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsNodePool> GetAwsNodePoolAsync(string name, st::CancellationToken cancellationToken) =>
            GetAwsNodePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource to
        /// describe.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AwsNodePool GetAwsNodePool(AwsNodePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAwsNodePool(new GetAwsNodePoolRequest
            {
                AwsNodePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource to
        /// describe.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsNodePool> GetAwsNodePoolAsync(AwsNodePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAwsNodePoolAsync(new GetAwsNodePoolRequest
            {
                AwsNodePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource to
        /// describe.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsNodePool> GetAwsNodePoolAsync(AwsNodePoolName name, st::CancellationToken cancellationToken) =>
            GetAwsNodePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resources on a given
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AwsNodePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAwsNodePoolsResponse, AwsNodePool> ListAwsNodePools(ListAwsNodePoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resources on a given
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AwsNodePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAwsNodePoolsResponse, AwsNodePool> ListAwsNodePoolsAsync(ListAwsNodePoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resources on a given
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `AwsCluster` which owns this collection of
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
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
        /// <returns>A pageable sequence of <see cref="AwsNodePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAwsNodePoolsResponse, AwsNodePool> ListAwsNodePools(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAwsNodePoolsRequest request = new ListAwsNodePoolsRequest
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
            return ListAwsNodePools(request, callSettings);
        }

        /// <summary>
        /// Lists all [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resources on a given
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `AwsCluster` which owns this collection of
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AwsNodePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAwsNodePoolsResponse, AwsNodePool> ListAwsNodePoolsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAwsNodePoolsRequest request = new ListAwsNodePoolsRequest
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
            return ListAwsNodePoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resources on a given
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `AwsCluster` which owns this collection of
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
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
        /// <returns>A pageable sequence of <see cref="AwsNodePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAwsNodePoolsResponse, AwsNodePool> ListAwsNodePools(AwsClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAwsNodePoolsRequest request = new ListAwsNodePoolsRequest
            {
                ParentAsAwsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAwsNodePools(request, callSettings);
        }

        /// <summary>
        /// Lists all [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resources on a given
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `AwsCluster` which owns this collection of
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// `AwsCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AwsNodePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAwsNodePoolsResponse, AwsNodePool> ListAwsNodePoolsAsync(AwsClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAwsNodePoolsRequest request = new ListAwsNodePoolsRequest
            {
                ParentAsAwsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAwsNodePoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a specific [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAwsNodePool(DeleteAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsNodePoolAsync(DeleteAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsNodePoolAsync(DeleteAwsNodePoolRequest request, st::CancellationToken cancellationToken) =>
            DeleteAwsNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAwsNodePool</c>.</summary>
        public virtual lro::OperationsClient DeleteAwsNodePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAwsNodePool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAwsNodePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAwsNodePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAwsNodePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAwsNodePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAwsNodePoolOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] to delete.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAwsNodePool(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAwsNodePool(new DeleteAwsNodePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] to delete.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsNodePoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAwsNodePoolAsync(new DeleteAwsNodePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] to delete.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsNodePoolAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAwsNodePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] to delete.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAwsNodePool(AwsNodePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAwsNodePool(new DeleteAwsNodePoolRequest
            {
                AwsNodePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] to delete.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsNodePoolAsync(AwsNodePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAwsNodePoolAsync(new DeleteAwsNodePoolRequest
            {
                AwsNodePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] to delete.
        /// 
        /// `AwsNodePool` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsClusters/&lt;cluster-id&gt;/awsNodePools/&lt;node-pool-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsNodePoolAsync(AwsNodePoolName name, st::CancellationToken cancellationToken) =>
            DeleteAwsNodePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual AwsOpenIdConfig GetAwsOpenIdConfig(GetAwsOpenIdConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<AwsOpenIdConfig> GetAwsOpenIdConfigAsync(GetAwsOpenIdConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<AwsOpenIdConfig> GetAwsOpenIdConfigAsync(GetAwsOpenIdConfigRequest request, st::CancellationToken cancellationToken) =>
            GetAwsOpenIdConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AwsJsonWebKeys GetAwsJsonWebKeys(GetAwsJsonWebKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsJsonWebKeys> GetAwsJsonWebKeysAsync(GetAwsJsonWebKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsJsonWebKeys> GetAwsJsonWebKeysAsync(GetAwsJsonWebKeysRequest request, st::CancellationToken cancellationToken) =>
            GetAwsJsonWebKeysAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information, such as supported AWS regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AwsServerConfig GetAwsServerConfig(GetAwsServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information, such as supported AWS regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsServerConfig> GetAwsServerConfigAsync(GetAwsServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information, such as supported AWS regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsServerConfig> GetAwsServerConfigAsync(GetAwsServerConfigRequest request, st::CancellationToken cancellationToken) =>
            GetAwsServerConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information, such as supported AWS regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsServerConfig][google.cloud.gkemulticloud.v1.AwsServerConfig] resource
        /// to describe.
        /// 
        /// `AwsServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AwsServerConfig GetAwsServerConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAwsServerConfig(new GetAwsServerConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information, such as supported AWS regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsServerConfig][google.cloud.gkemulticloud.v1.AwsServerConfig] resource
        /// to describe.
        /// 
        /// `AwsServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsServerConfig> GetAwsServerConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAwsServerConfigAsync(new GetAwsServerConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information, such as supported AWS regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsServerConfig][google.cloud.gkemulticloud.v1.AwsServerConfig] resource
        /// to describe.
        /// 
        /// `AwsServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsServerConfig> GetAwsServerConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetAwsServerConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information, such as supported AWS regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsServerConfig][google.cloud.gkemulticloud.v1.AwsServerConfig] resource
        /// to describe.
        /// 
        /// `AwsServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AwsServerConfig GetAwsServerConfig(AwsServerConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAwsServerConfig(new GetAwsServerConfigRequest
            {
                AwsServerConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information, such as supported AWS regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsServerConfig][google.cloud.gkemulticloud.v1.AwsServerConfig] resource
        /// to describe.
        /// 
        /// `AwsServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsServerConfig> GetAwsServerConfigAsync(AwsServerConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAwsServerConfigAsync(new GetAwsServerConfigRequest
            {
                AwsServerConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information, such as supported AWS regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AwsServerConfig][google.cloud.gkemulticloud.v1.AwsServerConfig] resource
        /// to describe.
        /// 
        /// `AwsServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/awsServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AwsServerConfig> GetAwsServerConfigAsync(AwsServerConfigName name, st::CancellationToken cancellationToken) =>
            GetAwsServerConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AwsClusters client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The AwsClusters API provides a single centrally managed service
    /// to create and manage Anthos clusters that run on AWS infrastructure.
    /// </remarks>
    public sealed partial class AwsClustersClientImpl : AwsClustersClient
    {
        private readonly gaxgrpc::ApiCall<CreateAwsClusterRequest, lro::Operation> _callCreateAwsCluster;

        private readonly gaxgrpc::ApiCall<UpdateAwsClusterRequest, lro::Operation> _callUpdateAwsCluster;

        private readonly gaxgrpc::ApiCall<GetAwsClusterRequest, AwsCluster> _callGetAwsCluster;

        private readonly gaxgrpc::ApiCall<ListAwsClustersRequest, ListAwsClustersResponse> _callListAwsClusters;

        private readonly gaxgrpc::ApiCall<DeleteAwsClusterRequest, lro::Operation> _callDeleteAwsCluster;

        private readonly gaxgrpc::ApiCall<GenerateAwsClusterAgentTokenRequest, GenerateAwsClusterAgentTokenResponse> _callGenerateAwsClusterAgentToken;

        private readonly gaxgrpc::ApiCall<GenerateAwsAccessTokenRequest, GenerateAwsAccessTokenResponse> _callGenerateAwsAccessToken;

        private readonly gaxgrpc::ApiCall<CreateAwsNodePoolRequest, lro::Operation> _callCreateAwsNodePool;

        private readonly gaxgrpc::ApiCall<UpdateAwsNodePoolRequest, lro::Operation> _callUpdateAwsNodePool;

        private readonly gaxgrpc::ApiCall<RollbackAwsNodePoolUpdateRequest, lro::Operation> _callRollbackAwsNodePoolUpdate;

        private readonly gaxgrpc::ApiCall<GetAwsNodePoolRequest, AwsNodePool> _callGetAwsNodePool;

        private readonly gaxgrpc::ApiCall<ListAwsNodePoolsRequest, ListAwsNodePoolsResponse> _callListAwsNodePools;

        private readonly gaxgrpc::ApiCall<DeleteAwsNodePoolRequest, lro::Operation> _callDeleteAwsNodePool;

        private readonly gaxgrpc::ApiCall<GetAwsOpenIdConfigRequest, AwsOpenIdConfig> _callGetAwsOpenIdConfig;

        private readonly gaxgrpc::ApiCall<GetAwsJsonWebKeysRequest, AwsJsonWebKeys> _callGetAwsJsonWebKeys;

        private readonly gaxgrpc::ApiCall<GetAwsServerConfigRequest, AwsServerConfig> _callGetAwsServerConfig;

        /// <summary>
        /// Constructs a client wrapper for the AwsClusters service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AwsClustersSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AwsClustersClientImpl(AwsClusters.AwsClustersClient grpcClient, AwsClustersSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AwsClustersSettings effectiveSettings = settings ?? AwsClustersSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateAwsClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAwsClusterOperationsSettings, logger);
            UpdateAwsClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAwsClusterOperationsSettings, logger);
            DeleteAwsClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAwsClusterOperationsSettings, logger);
            CreateAwsNodePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAwsNodePoolOperationsSettings, logger);
            UpdateAwsNodePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAwsNodePoolOperationsSettings, logger);
            RollbackAwsNodePoolUpdateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RollbackAwsNodePoolUpdateOperationsSettings, logger);
            DeleteAwsNodePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAwsNodePoolOperationsSettings, logger);
            _callCreateAwsCluster = clientHelper.BuildApiCall<CreateAwsClusterRequest, lro::Operation>("CreateAwsCluster", grpcClient.CreateAwsClusterAsync, grpcClient.CreateAwsCluster, effectiveSettings.CreateAwsClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAwsCluster);
            Modify_CreateAwsClusterApiCall(ref _callCreateAwsCluster);
            _callUpdateAwsCluster = clientHelper.BuildApiCall<UpdateAwsClusterRequest, lro::Operation>("UpdateAwsCluster", grpcClient.UpdateAwsClusterAsync, grpcClient.UpdateAwsCluster, effectiveSettings.UpdateAwsClusterSettings).WithGoogleRequestParam("aws_cluster.name", request => request.AwsCluster?.Name);
            Modify_ApiCall(ref _callUpdateAwsCluster);
            Modify_UpdateAwsClusterApiCall(ref _callUpdateAwsCluster);
            _callGetAwsCluster = clientHelper.BuildApiCall<GetAwsClusterRequest, AwsCluster>("GetAwsCluster", grpcClient.GetAwsClusterAsync, grpcClient.GetAwsCluster, effectiveSettings.GetAwsClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAwsCluster);
            Modify_GetAwsClusterApiCall(ref _callGetAwsCluster);
            _callListAwsClusters = clientHelper.BuildApiCall<ListAwsClustersRequest, ListAwsClustersResponse>("ListAwsClusters", grpcClient.ListAwsClustersAsync, grpcClient.ListAwsClusters, effectiveSettings.ListAwsClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAwsClusters);
            Modify_ListAwsClustersApiCall(ref _callListAwsClusters);
            _callDeleteAwsCluster = clientHelper.BuildApiCall<DeleteAwsClusterRequest, lro::Operation>("DeleteAwsCluster", grpcClient.DeleteAwsClusterAsync, grpcClient.DeleteAwsCluster, effectiveSettings.DeleteAwsClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAwsCluster);
            Modify_DeleteAwsClusterApiCall(ref _callDeleteAwsCluster);
            _callGenerateAwsClusterAgentToken = clientHelper.BuildApiCall<GenerateAwsClusterAgentTokenRequest, GenerateAwsClusterAgentTokenResponse>("GenerateAwsClusterAgentToken", grpcClient.GenerateAwsClusterAgentTokenAsync, grpcClient.GenerateAwsClusterAgentToken, effectiveSettings.GenerateAwsClusterAgentTokenSettings).WithGoogleRequestParam("aws_cluster", request => request.AwsCluster);
            Modify_ApiCall(ref _callGenerateAwsClusterAgentToken);
            Modify_GenerateAwsClusterAgentTokenApiCall(ref _callGenerateAwsClusterAgentToken);
            _callGenerateAwsAccessToken = clientHelper.BuildApiCall<GenerateAwsAccessTokenRequest, GenerateAwsAccessTokenResponse>("GenerateAwsAccessToken", grpcClient.GenerateAwsAccessTokenAsync, grpcClient.GenerateAwsAccessToken, effectiveSettings.GenerateAwsAccessTokenSettings).WithGoogleRequestParam("aws_cluster", request => request.AwsCluster);
            Modify_ApiCall(ref _callGenerateAwsAccessToken);
            Modify_GenerateAwsAccessTokenApiCall(ref _callGenerateAwsAccessToken);
            _callCreateAwsNodePool = clientHelper.BuildApiCall<CreateAwsNodePoolRequest, lro::Operation>("CreateAwsNodePool", grpcClient.CreateAwsNodePoolAsync, grpcClient.CreateAwsNodePool, effectiveSettings.CreateAwsNodePoolSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAwsNodePool);
            Modify_CreateAwsNodePoolApiCall(ref _callCreateAwsNodePool);
            _callUpdateAwsNodePool = clientHelper.BuildApiCall<UpdateAwsNodePoolRequest, lro::Operation>("UpdateAwsNodePool", grpcClient.UpdateAwsNodePoolAsync, grpcClient.UpdateAwsNodePool, effectiveSettings.UpdateAwsNodePoolSettings).WithGoogleRequestParam("aws_node_pool.name", request => request.AwsNodePool?.Name);
            Modify_ApiCall(ref _callUpdateAwsNodePool);
            Modify_UpdateAwsNodePoolApiCall(ref _callUpdateAwsNodePool);
            _callRollbackAwsNodePoolUpdate = clientHelper.BuildApiCall<RollbackAwsNodePoolUpdateRequest, lro::Operation>("RollbackAwsNodePoolUpdate", grpcClient.RollbackAwsNodePoolUpdateAsync, grpcClient.RollbackAwsNodePoolUpdate, effectiveSettings.RollbackAwsNodePoolUpdateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRollbackAwsNodePoolUpdate);
            Modify_RollbackAwsNodePoolUpdateApiCall(ref _callRollbackAwsNodePoolUpdate);
            _callGetAwsNodePool = clientHelper.BuildApiCall<GetAwsNodePoolRequest, AwsNodePool>("GetAwsNodePool", grpcClient.GetAwsNodePoolAsync, grpcClient.GetAwsNodePool, effectiveSettings.GetAwsNodePoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAwsNodePool);
            Modify_GetAwsNodePoolApiCall(ref _callGetAwsNodePool);
            _callListAwsNodePools = clientHelper.BuildApiCall<ListAwsNodePoolsRequest, ListAwsNodePoolsResponse>("ListAwsNodePools", grpcClient.ListAwsNodePoolsAsync, grpcClient.ListAwsNodePools, effectiveSettings.ListAwsNodePoolsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAwsNodePools);
            Modify_ListAwsNodePoolsApiCall(ref _callListAwsNodePools);
            _callDeleteAwsNodePool = clientHelper.BuildApiCall<DeleteAwsNodePoolRequest, lro::Operation>("DeleteAwsNodePool", grpcClient.DeleteAwsNodePoolAsync, grpcClient.DeleteAwsNodePool, effectiveSettings.DeleteAwsNodePoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAwsNodePool);
            Modify_DeleteAwsNodePoolApiCall(ref _callDeleteAwsNodePool);
            _callGetAwsOpenIdConfig = clientHelper.BuildApiCall<GetAwsOpenIdConfigRequest, AwsOpenIdConfig>("GetAwsOpenIdConfig", grpcClient.GetAwsOpenIdConfigAsync, grpcClient.GetAwsOpenIdConfig, effectiveSettings.GetAwsOpenIdConfigSettings).WithGoogleRequestParam("aws_cluster", request => request.AwsCluster);
            Modify_ApiCall(ref _callGetAwsOpenIdConfig);
            Modify_GetAwsOpenIdConfigApiCall(ref _callGetAwsOpenIdConfig);
            _callGetAwsJsonWebKeys = clientHelper.BuildApiCall<GetAwsJsonWebKeysRequest, AwsJsonWebKeys>("GetAwsJsonWebKeys", grpcClient.GetAwsJsonWebKeysAsync, grpcClient.GetAwsJsonWebKeys, effectiveSettings.GetAwsJsonWebKeysSettings).WithGoogleRequestParam("aws_cluster", request => request.AwsCluster);
            Modify_ApiCall(ref _callGetAwsJsonWebKeys);
            Modify_GetAwsJsonWebKeysApiCall(ref _callGetAwsJsonWebKeys);
            _callGetAwsServerConfig = clientHelper.BuildApiCall<GetAwsServerConfigRequest, AwsServerConfig>("GetAwsServerConfig", grpcClient.GetAwsServerConfigAsync, grpcClient.GetAwsServerConfig, effectiveSettings.GetAwsServerConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAwsServerConfig);
            Modify_GetAwsServerConfigApiCall(ref _callGetAwsServerConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateAwsClusterApiCall(ref gaxgrpc::ApiCall<CreateAwsClusterRequest, lro::Operation> call);

        partial void Modify_UpdateAwsClusterApiCall(ref gaxgrpc::ApiCall<UpdateAwsClusterRequest, lro::Operation> call);

        partial void Modify_GetAwsClusterApiCall(ref gaxgrpc::ApiCall<GetAwsClusterRequest, AwsCluster> call);

        partial void Modify_ListAwsClustersApiCall(ref gaxgrpc::ApiCall<ListAwsClustersRequest, ListAwsClustersResponse> call);

        partial void Modify_DeleteAwsClusterApiCall(ref gaxgrpc::ApiCall<DeleteAwsClusterRequest, lro::Operation> call);

        partial void Modify_GenerateAwsClusterAgentTokenApiCall(ref gaxgrpc::ApiCall<GenerateAwsClusterAgentTokenRequest, GenerateAwsClusterAgentTokenResponse> call);

        partial void Modify_GenerateAwsAccessTokenApiCall(ref gaxgrpc::ApiCall<GenerateAwsAccessTokenRequest, GenerateAwsAccessTokenResponse> call);

        partial void Modify_CreateAwsNodePoolApiCall(ref gaxgrpc::ApiCall<CreateAwsNodePoolRequest, lro::Operation> call);

        partial void Modify_UpdateAwsNodePoolApiCall(ref gaxgrpc::ApiCall<UpdateAwsNodePoolRequest, lro::Operation> call);

        partial void Modify_RollbackAwsNodePoolUpdateApiCall(ref gaxgrpc::ApiCall<RollbackAwsNodePoolUpdateRequest, lro::Operation> call);

        partial void Modify_GetAwsNodePoolApiCall(ref gaxgrpc::ApiCall<GetAwsNodePoolRequest, AwsNodePool> call);

        partial void Modify_ListAwsNodePoolsApiCall(ref gaxgrpc::ApiCall<ListAwsNodePoolsRequest, ListAwsNodePoolsResponse> call);

        partial void Modify_DeleteAwsNodePoolApiCall(ref gaxgrpc::ApiCall<DeleteAwsNodePoolRequest, lro::Operation> call);

        partial void Modify_GetAwsOpenIdConfigApiCall(ref gaxgrpc::ApiCall<GetAwsOpenIdConfigRequest, AwsOpenIdConfig> call);

        partial void Modify_GetAwsJsonWebKeysApiCall(ref gaxgrpc::ApiCall<GetAwsJsonWebKeysRequest, AwsJsonWebKeys> call);

        partial void Modify_GetAwsServerConfigApiCall(ref gaxgrpc::ApiCall<GetAwsServerConfigRequest, AwsServerConfig> call);

        partial void OnConstruction(AwsClusters.AwsClustersClient grpcClient, AwsClustersSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AwsClusters client</summary>
        public override AwsClusters.AwsClustersClient GrpcClient { get; }

        partial void Modify_CreateAwsClusterRequest(ref CreateAwsClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAwsClusterRequest(ref UpdateAwsClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAwsClusterRequest(ref GetAwsClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAwsClustersRequest(ref ListAwsClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAwsClusterRequest(ref DeleteAwsClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateAwsClusterAgentTokenRequest(ref GenerateAwsClusterAgentTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateAwsAccessTokenRequest(ref GenerateAwsAccessTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAwsNodePoolRequest(ref CreateAwsNodePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAwsNodePoolRequest(ref UpdateAwsNodePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RollbackAwsNodePoolUpdateRequest(ref RollbackAwsNodePoolUpdateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAwsNodePoolRequest(ref GetAwsNodePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAwsNodePoolsRequest(ref ListAwsNodePoolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAwsNodePoolRequest(ref DeleteAwsNodePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAwsOpenIdConfigRequest(ref GetAwsOpenIdConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAwsJsonWebKeysRequest(ref GetAwsJsonWebKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAwsServerConfigRequest(ref GetAwsServerConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateAwsCluster</c>.</summary>
        public override lro::OperationsClient CreateAwsClusterOperationsClient { get; }

        /// <summary>
        /// Creates a new [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AwsCluster, OperationMetadata> CreateAwsCluster(CreateAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAwsClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AwsCluster, OperationMetadata>(_callCreateAwsCluster.Sync(request, callSettings), CreateAwsClusterOperationsClient);
        }

        /// <summary>
        /// Creates a new [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AwsCluster, OperationMetadata>> CreateAwsClusterAsync(CreateAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAwsClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AwsCluster, OperationMetadata>(await _callCreateAwsCluster.Async(request, callSettings).ConfigureAwait(false), CreateAwsClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAwsCluster</c>.</summary>
        public override lro::OperationsClient UpdateAwsClusterOperationsClient { get; }

        /// <summary>
        /// Updates an [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AwsCluster, OperationMetadata> UpdateAwsCluster(UpdateAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAwsClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AwsCluster, OperationMetadata>(_callUpdateAwsCluster.Sync(request, callSettings), UpdateAwsClusterOperationsClient);
        }

        /// <summary>
        /// Updates an [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AwsCluster, OperationMetadata>> UpdateAwsClusterAsync(UpdateAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAwsClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AwsCluster, OperationMetadata>(await _callUpdateAwsCluster.Async(request, callSettings).ConfigureAwait(false), UpdateAwsClusterOperationsClient);
        }

        /// <summary>
        /// Describes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AwsCluster GetAwsCluster(GetAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAwsClusterRequest(ref request, ref callSettings);
            return _callGetAwsCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Describes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AwsCluster> GetAwsClusterAsync(GetAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAwsClusterRequest(ref request, ref callSettings);
            return _callGetAwsCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resources
        /// on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AwsCluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListAwsClustersResponse, AwsCluster> ListAwsClusters(ListAwsClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAwsClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAwsClustersRequest, ListAwsClustersResponse, AwsCluster>(_callListAwsClusters, request, callSettings);
        }

        /// <summary>
        /// Lists all [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resources
        /// on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AwsCluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAwsClustersResponse, AwsCluster> ListAwsClustersAsync(ListAwsClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAwsClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAwsClustersRequest, ListAwsClustersResponse, AwsCluster>(_callListAwsClusters, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteAwsCluster</c>.</summary>
        public override lro::OperationsClient DeleteAwsClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAwsCluster(DeleteAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAwsClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAwsCluster.Sync(request, callSettings), DeleteAwsClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a specific [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster]
        /// resource.
        /// 
        /// Fails if the cluster has one or more associated
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resources.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsClusterAsync(DeleteAwsClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAwsClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAwsCluster.Async(request, callSettings).ConfigureAwait(false), DeleteAwsClusterOperationsClient);
        }

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateAwsClusterAgentTokenResponse GenerateAwsClusterAgentToken(GenerateAwsClusterAgentTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAwsClusterAgentTokenRequest(ref request, ref callSettings);
            return _callGenerateAwsClusterAgentToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateAwsClusterAgentTokenResponse> GenerateAwsClusterAgentTokenAsync(GenerateAwsClusterAgentTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAwsClusterAgentTokenRequest(ref request, ref callSettings);
            return _callGenerateAwsClusterAgentToken.Async(request, callSettings);
        }

        /// <summary>
        /// Generates a short-lived access token to authenticate to a given
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateAwsAccessTokenResponse GenerateAwsAccessToken(GenerateAwsAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAwsAccessTokenRequest(ref request, ref callSettings);
            return _callGenerateAwsAccessToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a short-lived access token to authenticate to a given
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateAwsAccessTokenResponse> GenerateAwsAccessTokenAsync(GenerateAwsAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAwsAccessTokenRequest(ref request, ref callSettings);
            return _callGenerateAwsAccessToken.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAwsNodePool</c>.</summary>
        public override lro::OperationsClient CreateAwsNodePoolOperationsClient { get; }

        /// <summary>
        /// Creates a new [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool],
        /// attached to a given [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AwsNodePool, OperationMetadata> CreateAwsNodePool(CreateAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAwsNodePoolRequest(ref request, ref callSettings);
            return new lro::Operation<AwsNodePool, OperationMetadata>(_callCreateAwsNodePool.Sync(request, callSettings), CreateAwsNodePoolOperationsClient);
        }

        /// <summary>
        /// Creates a new [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool],
        /// attached to a given [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> CreateAwsNodePoolAsync(CreateAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAwsNodePoolRequest(ref request, ref callSettings);
            return new lro::Operation<AwsNodePool, OperationMetadata>(await _callCreateAwsNodePool.Async(request, callSettings).ConfigureAwait(false), CreateAwsNodePoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAwsNodePool</c>.</summary>
        public override lro::OperationsClient UpdateAwsNodePoolOperationsClient { get; }

        /// <summary>
        /// Updates an [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AwsNodePool, OperationMetadata> UpdateAwsNodePool(UpdateAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAwsNodePoolRequest(ref request, ref callSettings);
            return new lro::Operation<AwsNodePool, OperationMetadata>(_callUpdateAwsNodePool.Sync(request, callSettings), UpdateAwsNodePoolOperationsClient);
        }

        /// <summary>
        /// Updates an [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> UpdateAwsNodePoolAsync(UpdateAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAwsNodePoolRequest(ref request, ref callSettings);
            return new lro::Operation<AwsNodePool, OperationMetadata>(await _callUpdateAwsNodePool.Async(request, callSettings).ConfigureAwait(false), UpdateAwsNodePoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RollbackAwsNodePoolUpdate</c>.</summary>
        public override lro::OperationsClient RollbackAwsNodePoolUpdateOperationsClient { get; }

        /// <summary>
        /// Rolls back a previously aborted or failed
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] update request.
        /// Makes no changes if the last update request successfully finished.
        /// If an update request is in progress, you cannot rollback the update.
        /// You must first cancel or let it finish unsuccessfully before you can
        /// rollback.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AwsNodePool, OperationMetadata> RollbackAwsNodePoolUpdate(RollbackAwsNodePoolUpdateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackAwsNodePoolUpdateRequest(ref request, ref callSettings);
            return new lro::Operation<AwsNodePool, OperationMetadata>(_callRollbackAwsNodePoolUpdate.Sync(request, callSettings), RollbackAwsNodePoolUpdateOperationsClient);
        }

        /// <summary>
        /// Rolls back a previously aborted or failed
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] update request.
        /// Makes no changes if the last update request successfully finished.
        /// If an update request is in progress, you cannot rollback the update.
        /// You must first cancel or let it finish unsuccessfully before you can
        /// rollback.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AwsNodePool, OperationMetadata>> RollbackAwsNodePoolUpdateAsync(RollbackAwsNodePoolUpdateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackAwsNodePoolUpdateRequest(ref request, ref callSettings);
            return new lro::Operation<AwsNodePool, OperationMetadata>(await _callRollbackAwsNodePoolUpdate.Async(request, callSettings).ConfigureAwait(false), RollbackAwsNodePoolUpdateOperationsClient);
        }

        /// <summary>
        /// Describes a specific
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AwsNodePool GetAwsNodePool(GetAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAwsNodePoolRequest(ref request, ref callSettings);
            return _callGetAwsNodePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Describes a specific
        /// [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AwsNodePool> GetAwsNodePoolAsync(GetAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAwsNodePoolRequest(ref request, ref callSettings);
            return _callGetAwsNodePool.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resources on a given
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AwsNodePool"/> resources.</returns>
        public override gax::PagedEnumerable<ListAwsNodePoolsResponse, AwsNodePool> ListAwsNodePools(ListAwsNodePoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAwsNodePoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAwsNodePoolsRequest, ListAwsNodePoolsResponse, AwsNodePool>(_callListAwsNodePools, request, callSettings);
        }

        /// <summary>
        /// Lists all [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resources on a given
        /// [AwsCluster][google.cloud.gkemulticloud.v1.AwsCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AwsNodePool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAwsNodePoolsResponse, AwsNodePool> ListAwsNodePoolsAsync(ListAwsNodePoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAwsNodePoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAwsNodePoolsRequest, ListAwsNodePoolsResponse, AwsNodePool>(_callListAwsNodePools, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteAwsNodePool</c>.</summary>
        public override lro::OperationsClient DeleteAwsNodePoolOperationsClient { get; }

        /// <summary>
        /// Deletes a specific [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAwsNodePool(DeleteAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAwsNodePoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAwsNodePool.Sync(request, callSettings), DeleteAwsNodePoolOperationsClient);
        }

        /// <summary>
        /// Deletes a specific [AwsNodePool][google.cloud.gkemulticloud.v1.AwsNodePool]
        /// resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAwsNodePoolAsync(DeleteAwsNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAwsNodePoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAwsNodePool.Async(request, callSettings).ConfigureAwait(false), DeleteAwsNodePoolOperationsClient);
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
        public override AwsOpenIdConfig GetAwsOpenIdConfig(GetAwsOpenIdConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAwsOpenIdConfigRequest(ref request, ref callSettings);
            return _callGetAwsOpenIdConfig.Sync(request, callSettings);
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
        public override stt::Task<AwsOpenIdConfig> GetAwsOpenIdConfigAsync(GetAwsOpenIdConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAwsOpenIdConfigRequest(ref request, ref callSettings);
            return _callGetAwsOpenIdConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AwsJsonWebKeys GetAwsJsonWebKeys(GetAwsJsonWebKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAwsJsonWebKeysRequest(ref request, ref callSettings);
            return _callGetAwsJsonWebKeys.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the public component of the cluster signing keys in
        /// JSON Web Key format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AwsJsonWebKeys> GetAwsJsonWebKeysAsync(GetAwsJsonWebKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAwsJsonWebKeysRequest(ref request, ref callSettings);
            return _callGetAwsJsonWebKeys.Async(request, callSettings);
        }

        /// <summary>
        /// Returns information, such as supported AWS regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AwsServerConfig GetAwsServerConfig(GetAwsServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAwsServerConfigRequest(ref request, ref callSettings);
            return _callGetAwsServerConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information, such as supported AWS regions and Kubernetes
        /// versions, on a given Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AwsServerConfig> GetAwsServerConfigAsync(GetAwsServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAwsServerConfigRequest(ref request, ref callSettings);
            return _callGetAwsServerConfig.Async(request, callSettings);
        }
    }

    public partial class ListAwsClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAwsNodePoolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAwsClustersResponse : gaxgrpc::IPageResponse<AwsCluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AwsCluster> GetEnumerator() => AwsClusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAwsNodePoolsResponse : gaxgrpc::IPageResponse<AwsNodePool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AwsNodePool> GetEnumerator() => AwsNodePools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AwsClusters
    {
        public partial class AwsClustersClient
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
