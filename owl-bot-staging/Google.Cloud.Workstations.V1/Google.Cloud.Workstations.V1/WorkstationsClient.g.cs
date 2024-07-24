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

namespace Google.Cloud.Workstations.V1
{
    /// <summary>Settings for <see cref="WorkstationsClient"/> instances.</summary>
    public sealed partial class WorkstationsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WorkstationsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WorkstationsSettings"/>.</returns>
        public static WorkstationsSettings GetDefault() => new WorkstationsSettings();

        /// <summary>Constructs a new <see cref="WorkstationsSettings"/> object with default settings.</summary>
        public WorkstationsSettings()
        {
        }

        private WorkstationsSettings(WorkstationsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetWorkstationClusterSettings = existing.GetWorkstationClusterSettings;
            ListWorkstationClustersSettings = existing.ListWorkstationClustersSettings;
            CreateWorkstationClusterSettings = existing.CreateWorkstationClusterSettings;
            CreateWorkstationClusterOperationsSettings = existing.CreateWorkstationClusterOperationsSettings.Clone();
            UpdateWorkstationClusterSettings = existing.UpdateWorkstationClusterSettings;
            UpdateWorkstationClusterOperationsSettings = existing.UpdateWorkstationClusterOperationsSettings.Clone();
            DeleteWorkstationClusterSettings = existing.DeleteWorkstationClusterSettings;
            DeleteWorkstationClusterOperationsSettings = existing.DeleteWorkstationClusterOperationsSettings.Clone();
            GetWorkstationConfigSettings = existing.GetWorkstationConfigSettings;
            ListWorkstationConfigsSettings = existing.ListWorkstationConfigsSettings;
            ListUsableWorkstationConfigsSettings = existing.ListUsableWorkstationConfigsSettings;
            CreateWorkstationConfigSettings = existing.CreateWorkstationConfigSettings;
            CreateWorkstationConfigOperationsSettings = existing.CreateWorkstationConfigOperationsSettings.Clone();
            UpdateWorkstationConfigSettings = existing.UpdateWorkstationConfigSettings;
            UpdateWorkstationConfigOperationsSettings = existing.UpdateWorkstationConfigOperationsSettings.Clone();
            DeleteWorkstationConfigSettings = existing.DeleteWorkstationConfigSettings;
            DeleteWorkstationConfigOperationsSettings = existing.DeleteWorkstationConfigOperationsSettings.Clone();
            GetWorkstationSettings = existing.GetWorkstationSettings;
            ListWorkstationsSettings = existing.ListWorkstationsSettings;
            ListUsableWorkstationsSettings = existing.ListUsableWorkstationsSettings;
            CreateWorkstationSettings = existing.CreateWorkstationSettings;
            CreateWorkstationOperationsSettings = existing.CreateWorkstationOperationsSettings.Clone();
            UpdateWorkstationSettings = existing.UpdateWorkstationSettings;
            UpdateWorkstationOperationsSettings = existing.UpdateWorkstationOperationsSettings.Clone();
            DeleteWorkstationSettings = existing.DeleteWorkstationSettings;
            DeleteWorkstationOperationsSettings = existing.DeleteWorkstationOperationsSettings.Clone();
            StartWorkstationSettings = existing.StartWorkstationSettings;
            StartWorkstationOperationsSettings = existing.StartWorkstationOperationsSettings.Clone();
            StopWorkstationSettings = existing.StopWorkstationSettings;
            StopWorkstationOperationsSettings = existing.StopWorkstationOperationsSettings.Clone();
            GenerateAccessTokenSettings = existing.GenerateAccessTokenSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(WorkstationsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.GetWorkstationCluster</c> and <c>WorkstationsClient.GetWorkstationClusterAsync</c>.
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
        public gaxgrpc::CallSettings GetWorkstationClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.ListWorkstationClusters</c> and <c>WorkstationsClient.ListWorkstationClustersAsync</c>
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
        public gaxgrpc::CallSettings ListWorkstationClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.CreateWorkstationCluster</c> and <c>WorkstationsClient.CreateWorkstationClusterAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkstationClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkstationsClient.CreateWorkstationCluster</c> and
        /// <c>WorkstationsClient.CreateWorkstationClusterAsync</c>.
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
        public lro::OperationsSettings CreateWorkstationClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.UpdateWorkstationCluster</c> and <c>WorkstationsClient.UpdateWorkstationClusterAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWorkstationClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkstationsClient.UpdateWorkstationCluster</c> and
        /// <c>WorkstationsClient.UpdateWorkstationClusterAsync</c>.
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
        public lro::OperationsSettings UpdateWorkstationClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.DeleteWorkstationCluster</c> and <c>WorkstationsClient.DeleteWorkstationClusterAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkstationClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkstationsClient.DeleteWorkstationCluster</c> and
        /// <c>WorkstationsClient.DeleteWorkstationClusterAsync</c>.
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
        public lro::OperationsSettings DeleteWorkstationClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.GetWorkstationConfig</c> and <c>WorkstationsClient.GetWorkstationConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetWorkstationConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.ListWorkstationConfigs</c> and <c>WorkstationsClient.ListWorkstationConfigsAsync</c>.
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
        public gaxgrpc::CallSettings ListWorkstationConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.ListUsableWorkstationConfigs</c> and
        /// <c>WorkstationsClient.ListUsableWorkstationConfigsAsync</c>.
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
        public gaxgrpc::CallSettings ListUsableWorkstationConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.CreateWorkstationConfig</c> and <c>WorkstationsClient.CreateWorkstationConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkstationConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkstationsClient.CreateWorkstationConfig</c> and
        /// <c>WorkstationsClient.CreateWorkstationConfigAsync</c>.
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
        public lro::OperationsSettings CreateWorkstationConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.UpdateWorkstationConfig</c> and <c>WorkstationsClient.UpdateWorkstationConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWorkstationConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkstationsClient.UpdateWorkstationConfig</c> and
        /// <c>WorkstationsClient.UpdateWorkstationConfigAsync</c>.
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
        public lro::OperationsSettings UpdateWorkstationConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.DeleteWorkstationConfig</c> and <c>WorkstationsClient.DeleteWorkstationConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkstationConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkstationsClient.DeleteWorkstationConfig</c> and
        /// <c>WorkstationsClient.DeleteWorkstationConfigAsync</c>.
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
        public lro::OperationsSettings DeleteWorkstationConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.GetWorkstation</c> and <c>WorkstationsClient.GetWorkstationAsync</c>.
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
        public gaxgrpc::CallSettings GetWorkstationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.ListWorkstations</c> and <c>WorkstationsClient.ListWorkstationsAsync</c>.
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
        public gaxgrpc::CallSettings ListWorkstationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.ListUsableWorkstations</c> and <c>WorkstationsClient.ListUsableWorkstationsAsync</c>.
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
        public gaxgrpc::CallSettings ListUsableWorkstationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.CreateWorkstation</c> and <c>WorkstationsClient.CreateWorkstationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkstationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkstationsClient.CreateWorkstation</c> and
        /// <c>WorkstationsClient.CreateWorkstationAsync</c>.
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
        public lro::OperationsSettings CreateWorkstationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.UpdateWorkstation</c> and <c>WorkstationsClient.UpdateWorkstationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWorkstationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkstationsClient.UpdateWorkstation</c> and
        /// <c>WorkstationsClient.UpdateWorkstationAsync</c>.
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
        public lro::OperationsSettings UpdateWorkstationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.DeleteWorkstation</c> and <c>WorkstationsClient.DeleteWorkstationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkstationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkstationsClient.DeleteWorkstation</c> and
        /// <c>WorkstationsClient.DeleteWorkstationAsync</c>.
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
        public lro::OperationsSettings DeleteWorkstationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.StartWorkstation</c> and <c>WorkstationsClient.StartWorkstationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartWorkstationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkstationsClient.StartWorkstation</c> and
        /// <c>WorkstationsClient.StartWorkstationAsync</c>.
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
        public lro::OperationsSettings StartWorkstationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.StopWorkstation</c> and <c>WorkstationsClient.StopWorkstationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopWorkstationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkstationsClient.StopWorkstation</c> and
        /// <c>WorkstationsClient.StopWorkstationAsync</c>.
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
        public lro::OperationsSettings StopWorkstationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkstationsClient.GenerateAccessToken</c> and <c>WorkstationsClient.GenerateAccessTokenAsync</c>.
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
        public gaxgrpc::CallSettings GenerateAccessTokenSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WorkstationsSettings"/> object.</returns>
        public WorkstationsSettings Clone() => new WorkstationsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WorkstationsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class WorkstationsClientBuilder : gaxgrpc::ClientBuilderBase<WorkstationsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WorkstationsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WorkstationsClientBuilder() : base(WorkstationsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WorkstationsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WorkstationsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WorkstationsClient Build()
        {
            WorkstationsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WorkstationsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WorkstationsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WorkstationsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WorkstationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WorkstationsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WorkstationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WorkstationsClient.ChannelPool;
    }

    /// <summary>Workstations client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for interacting with Cloud Workstations.
    /// </remarks>
    public abstract partial class WorkstationsClient
    {
        /// <summary>
        /// The default endpoint for the Workstations service, which is a host of "workstations.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "workstations.googleapis.com:443";

        /// <summary>The default Workstations scopes.</summary>
        /// <remarks>
        /// The default Workstations scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Workstations.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WorkstationsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WorkstationsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WorkstationsClient"/>.</returns>
        public static stt::Task<WorkstationsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WorkstationsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WorkstationsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WorkstationsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WorkstationsClient"/>.</returns>
        public static WorkstationsClient Create() => new WorkstationsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WorkstationsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WorkstationsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WorkstationsClient"/>.</returns>
        internal static WorkstationsClient Create(grpccore::CallInvoker callInvoker, WorkstationsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Workstations.WorkstationsClient grpcClient = new Workstations.WorkstationsClient(callInvoker);
            return new WorkstationsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Workstations client</summary>
        public virtual Workstations.WorkstationsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkstationCluster GetWorkstationCluster(GetWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkstationCluster> GetWorkstationClusterAsync(GetWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkstationCluster> GetWorkstationClusterAsync(GetWorkstationClusterRequest request, st::CancellationToken cancellationToken) =>
            GetWorkstationClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested workstation cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkstationCluster GetWorkstationCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkstationCluster(new GetWorkstationClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested workstation cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkstationCluster> GetWorkstationClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkstationClusterAsync(new GetWorkstationClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested workstation cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkstationCluster> GetWorkstationClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkstationClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested workstation cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkstationCluster GetWorkstationCluster(WorkstationClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkstationCluster(new GetWorkstationClusterRequest
            {
                WorkstationClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested workstation cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkstationCluster> GetWorkstationClusterAsync(WorkstationClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkstationClusterAsync(new GetWorkstationClusterRequest
            {
                WorkstationClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested workstation cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkstationCluster> GetWorkstationClusterAsync(WorkstationClusterName name, st::CancellationToken cancellationToken) =>
            GetWorkstationClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all workstation clusters in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkstationCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkstationClustersResponse, WorkstationCluster> ListWorkstationClusters(ListWorkstationClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all workstation clusters in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkstationCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkstationClustersResponse, WorkstationCluster> ListWorkstationClustersAsync(ListWorkstationClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all workstation clusters in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable sequence of <see cref="WorkstationCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkstationClustersResponse, WorkstationCluster> ListWorkstationClusters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkstationClustersRequest request = new ListWorkstationClustersRequest
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
            return ListWorkstationClusters(request, callSettings);
        }

        /// <summary>
        /// Returns all workstation clusters in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkstationCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkstationClustersResponse, WorkstationCluster> ListWorkstationClustersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkstationClustersRequest request = new ListWorkstationClustersRequest
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
            return ListWorkstationClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all workstation clusters in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable sequence of <see cref="WorkstationCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkstationClustersResponse, WorkstationCluster> ListWorkstationClusters(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkstationClustersRequest request = new ListWorkstationClustersRequest
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
            return ListWorkstationClusters(request, callSettings);
        }

        /// <summary>
        /// Returns all workstation clusters in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkstationCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkstationClustersResponse, WorkstationCluster> ListWorkstationClustersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkstationClustersRequest request = new ListWorkstationClustersRequest
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
            return ListWorkstationClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationCluster, OperationMetadata> CreateWorkstationCluster(CreateWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> CreateWorkstationClusterAsync(CreateWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> CreateWorkstationClusterAsync(CreateWorkstationClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkstationClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateWorkstationCluster</c>.</summary>
        public virtual lro::OperationsClient CreateWorkstationClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkstationCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkstationCluster, OperationMetadata> PollOnceCreateWorkstationCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkstationCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkstationClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkstationCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> PollOnceCreateWorkstationClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkstationCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkstationClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a new workstation cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstationCluster">
        /// Required. Workstation cluster to create.
        /// </param>
        /// <param name="workstationClusterId">
        /// Required. ID to use for the workstation cluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationCluster, OperationMetadata> CreateWorkstationCluster(string parent, WorkstationCluster workstationCluster, string workstationClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkstationCluster(new CreateWorkstationClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkstationClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(workstationClusterId, nameof(workstationClusterId)),
                WorkstationCluster = gax::GaxPreconditions.CheckNotNull(workstationCluster, nameof(workstationCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new workstation cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstationCluster">
        /// Required. Workstation cluster to create.
        /// </param>
        /// <param name="workstationClusterId">
        /// Required. ID to use for the workstation cluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> CreateWorkstationClusterAsync(string parent, WorkstationCluster workstationCluster, string workstationClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkstationClusterAsync(new CreateWorkstationClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkstationClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(workstationClusterId, nameof(workstationClusterId)),
                WorkstationCluster = gax::GaxPreconditions.CheckNotNull(workstationCluster, nameof(workstationCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new workstation cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstationCluster">
        /// Required. Workstation cluster to create.
        /// </param>
        /// <param name="workstationClusterId">
        /// Required. ID to use for the workstation cluster.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> CreateWorkstationClusterAsync(string parent, WorkstationCluster workstationCluster, string workstationClusterId, st::CancellationToken cancellationToken) =>
            CreateWorkstationClusterAsync(parent, workstationCluster, workstationClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new workstation cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstationCluster">
        /// Required. Workstation cluster to create.
        /// </param>
        /// <param name="workstationClusterId">
        /// Required. ID to use for the workstation cluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationCluster, OperationMetadata> CreateWorkstationCluster(gagr::LocationName parent, WorkstationCluster workstationCluster, string workstationClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkstationCluster(new CreateWorkstationClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkstationClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(workstationClusterId, nameof(workstationClusterId)),
                WorkstationCluster = gax::GaxPreconditions.CheckNotNull(workstationCluster, nameof(workstationCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new workstation cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstationCluster">
        /// Required. Workstation cluster to create.
        /// </param>
        /// <param name="workstationClusterId">
        /// Required. ID to use for the workstation cluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> CreateWorkstationClusterAsync(gagr::LocationName parent, WorkstationCluster workstationCluster, string workstationClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkstationClusterAsync(new CreateWorkstationClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkstationClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(workstationClusterId, nameof(workstationClusterId)),
                WorkstationCluster = gax::GaxPreconditions.CheckNotNull(workstationCluster, nameof(workstationCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new workstation cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstationCluster">
        /// Required. Workstation cluster to create.
        /// </param>
        /// <param name="workstationClusterId">
        /// Required. ID to use for the workstation cluster.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> CreateWorkstationClusterAsync(gagr::LocationName parent, WorkstationCluster workstationCluster, string workstationClusterId, st::CancellationToken cancellationToken) =>
            CreateWorkstationClusterAsync(parent, workstationCluster, workstationClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationCluster, OperationMetadata> UpdateWorkstationCluster(UpdateWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> UpdateWorkstationClusterAsync(UpdateWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> UpdateWorkstationClusterAsync(UpdateWorkstationClusterRequest request, st::CancellationToken cancellationToken) =>
            UpdateWorkstationClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateWorkstationCluster</c>.</summary>
        public virtual lro::OperationsClient UpdateWorkstationClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateWorkstationCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkstationCluster, OperationMetadata> PollOnceUpdateWorkstationCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkstationCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkstationClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateWorkstationCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> PollOnceUpdateWorkstationClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkstationCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkstationClusterOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing workstation cluster.
        /// </summary>
        /// <param name="workstationCluster">
        /// Required. Workstation cluster to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask that specifies which fields in the workstation cluster
        /// should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationCluster, OperationMetadata> UpdateWorkstationCluster(WorkstationCluster workstationCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkstationCluster(new UpdateWorkstationClusterRequest
            {
                WorkstationCluster = gax::GaxPreconditions.CheckNotNull(workstationCluster, nameof(workstationCluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing workstation cluster.
        /// </summary>
        /// <param name="workstationCluster">
        /// Required. Workstation cluster to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask that specifies which fields in the workstation cluster
        /// should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> UpdateWorkstationClusterAsync(WorkstationCluster workstationCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkstationClusterAsync(new UpdateWorkstationClusterRequest
            {
                WorkstationCluster = gax::GaxPreconditions.CheckNotNull(workstationCluster, nameof(workstationCluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing workstation cluster.
        /// </summary>
        /// <param name="workstationCluster">
        /// Required. Workstation cluster to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask that specifies which fields in the workstation cluster
        /// should be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> UpdateWorkstationClusterAsync(WorkstationCluster workstationCluster, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWorkstationClusterAsync(workstationCluster, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationCluster, OperationMetadata> DeleteWorkstationCluster(DeleteWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> DeleteWorkstationClusterAsync(DeleteWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> DeleteWorkstationClusterAsync(DeleteWorkstationClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkstationClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteWorkstationCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteWorkstationClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteWorkstationCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkstationCluster, OperationMetadata> PollOnceDeleteWorkstationCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkstationCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkstationClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteWorkstationCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> PollOnceDeleteWorkstationClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkstationCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkstationClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified workstation cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation cluster to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationCluster, OperationMetadata> DeleteWorkstationCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkstationCluster(new DeleteWorkstationClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified workstation cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation cluster to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> DeleteWorkstationClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkstationClusterAsync(new DeleteWorkstationClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified workstation cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation cluster to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> DeleteWorkstationClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkstationClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified workstation cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation cluster to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationCluster, OperationMetadata> DeleteWorkstationCluster(WorkstationClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkstationCluster(new DeleteWorkstationClusterRequest
            {
                WorkstationClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified workstation cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation cluster to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> DeleteWorkstationClusterAsync(WorkstationClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkstationClusterAsync(new DeleteWorkstationClusterRequest
            {
                WorkstationClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified workstation cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation cluster to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> DeleteWorkstationClusterAsync(WorkstationClusterName name, st::CancellationToken cancellationToken) =>
            DeleteWorkstationClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkstationConfig GetWorkstationConfig(GetWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkstationConfig> GetWorkstationConfigAsync(GetWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkstationConfig> GetWorkstationConfigAsync(GetWorkstationConfigRequest request, st::CancellationToken cancellationToken) =>
            GetWorkstationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested workstation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkstationConfig GetWorkstationConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkstationConfig(new GetWorkstationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested workstation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkstationConfig> GetWorkstationConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkstationConfigAsync(new GetWorkstationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested workstation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkstationConfig> GetWorkstationConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkstationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested workstation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkstationConfig GetWorkstationConfig(WorkstationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkstationConfig(new GetWorkstationConfigRequest
            {
                WorkstationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested workstation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkstationConfig> GetWorkstationConfigAsync(WorkstationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkstationConfigAsync(new GetWorkstationConfigRequest
            {
                WorkstationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested workstation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkstationConfig> GetWorkstationConfigAsync(WorkstationConfigName name, st::CancellationToken cancellationToken) =>
            GetWorkstationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all workstation configurations in the specified cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> ListWorkstationConfigs(ListWorkstationConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all workstation configurations in the specified cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> ListWorkstationConfigsAsync(ListWorkstationConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all workstation configurations in the specified cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> ListWorkstationConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkstationConfigsRequest request = new ListWorkstationConfigsRequest
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
            return ListWorkstationConfigs(request, callSettings);
        }

        /// <summary>
        /// Returns all workstation configurations in the specified cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> ListWorkstationConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkstationConfigsRequest request = new ListWorkstationConfigsRequest
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
            return ListWorkstationConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all workstation configurations in the specified cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> ListWorkstationConfigs(WorkstationClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkstationConfigsRequest request = new ListWorkstationConfigsRequest
            {
                ParentAsWorkstationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkstationConfigs(request, callSettings);
        }

        /// <summary>
        /// Returns all workstation configurations in the specified cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> ListWorkstationConfigsAsync(WorkstationClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkstationConfigsRequest request = new ListWorkstationConfigsRequest
            {
                ParentAsWorkstationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkstationConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all workstation configurations in the specified cluster on which
        /// the caller has the "workstations.workstation.create" permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> ListUsableWorkstationConfigs(ListUsableWorkstationConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all workstation configurations in the specified cluster on which
        /// the caller has the "workstations.workstation.create" permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> ListUsableWorkstationConfigsAsync(ListUsableWorkstationConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all workstation configurations in the specified cluster on which
        /// the caller has the "workstations.workstation.create" permission.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> ListUsableWorkstationConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsableWorkstationConfigsRequest request = new ListUsableWorkstationConfigsRequest
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
            return ListUsableWorkstationConfigs(request, callSettings);
        }

        /// <summary>
        /// Returns all workstation configurations in the specified cluster on which
        /// the caller has the "workstations.workstation.create" permission.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> ListUsableWorkstationConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsableWorkstationConfigsRequest request = new ListUsableWorkstationConfigsRequest
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
            return ListUsableWorkstationConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all workstation configurations in the specified cluster on which
        /// the caller has the "workstations.workstation.create" permission.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> ListUsableWorkstationConfigs(WorkstationClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsableWorkstationConfigsRequest request = new ListUsableWorkstationConfigsRequest
            {
                ParentAsWorkstationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUsableWorkstationConfigs(request, callSettings);
        }

        /// <summary>
        /// Returns all workstation configurations in the specified cluster on which
        /// the caller has the "workstations.workstation.create" permission.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> ListUsableWorkstationConfigsAsync(WorkstationClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsableWorkstationConfigsRequest request = new ListUsableWorkstationConfigsRequest
            {
                ParentAsWorkstationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUsableWorkstationConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationConfig, OperationMetadata> CreateWorkstationConfig(CreateWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> CreateWorkstationConfigAsync(CreateWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> CreateWorkstationConfigAsync(CreateWorkstationConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkstationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateWorkstationConfig</c>.</summary>
        public virtual lro::OperationsClient CreateWorkstationConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkstationConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkstationConfig, OperationMetadata> PollOnceCreateWorkstationConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkstationConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkstationConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkstationConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> PollOnceCreateWorkstationConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkstationConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkstationConfigOperationsClient, callSettings);

        /// <summary>
        /// Creates a new workstation configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstationConfig">
        /// Required. Config to create.
        /// </param>
        /// <param name="workstationConfigId">
        /// Required. ID to use for the workstation configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationConfig, OperationMetadata> CreateWorkstationConfig(string parent, WorkstationConfig workstationConfig, string workstationConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkstationConfig(new CreateWorkstationConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkstationConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(workstationConfigId, nameof(workstationConfigId)),
                WorkstationConfig = gax::GaxPreconditions.CheckNotNull(workstationConfig, nameof(workstationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new workstation configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstationConfig">
        /// Required. Config to create.
        /// </param>
        /// <param name="workstationConfigId">
        /// Required. ID to use for the workstation configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> CreateWorkstationConfigAsync(string parent, WorkstationConfig workstationConfig, string workstationConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkstationConfigAsync(new CreateWorkstationConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkstationConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(workstationConfigId, nameof(workstationConfigId)),
                WorkstationConfig = gax::GaxPreconditions.CheckNotNull(workstationConfig, nameof(workstationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new workstation configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstationConfig">
        /// Required. Config to create.
        /// </param>
        /// <param name="workstationConfigId">
        /// Required. ID to use for the workstation configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> CreateWorkstationConfigAsync(string parent, WorkstationConfig workstationConfig, string workstationConfigId, st::CancellationToken cancellationToken) =>
            CreateWorkstationConfigAsync(parent, workstationConfig, workstationConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new workstation configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstationConfig">
        /// Required. Config to create.
        /// </param>
        /// <param name="workstationConfigId">
        /// Required. ID to use for the workstation configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationConfig, OperationMetadata> CreateWorkstationConfig(WorkstationClusterName parent, WorkstationConfig workstationConfig, string workstationConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkstationConfig(new CreateWorkstationConfigRequest
            {
                ParentAsWorkstationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkstationConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(workstationConfigId, nameof(workstationConfigId)),
                WorkstationConfig = gax::GaxPreconditions.CheckNotNull(workstationConfig, nameof(workstationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new workstation configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstationConfig">
        /// Required. Config to create.
        /// </param>
        /// <param name="workstationConfigId">
        /// Required. ID to use for the workstation configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> CreateWorkstationConfigAsync(WorkstationClusterName parent, WorkstationConfig workstationConfig, string workstationConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkstationConfigAsync(new CreateWorkstationConfigRequest
            {
                ParentAsWorkstationClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkstationConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(workstationConfigId, nameof(workstationConfigId)),
                WorkstationConfig = gax::GaxPreconditions.CheckNotNull(workstationConfig, nameof(workstationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new workstation configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstationConfig">
        /// Required. Config to create.
        /// </param>
        /// <param name="workstationConfigId">
        /// Required. ID to use for the workstation configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> CreateWorkstationConfigAsync(WorkstationClusterName parent, WorkstationConfig workstationConfig, string workstationConfigId, st::CancellationToken cancellationToken) =>
            CreateWorkstationConfigAsync(parent, workstationConfig, workstationConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationConfig, OperationMetadata> UpdateWorkstationConfig(UpdateWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> UpdateWorkstationConfigAsync(UpdateWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> UpdateWorkstationConfigAsync(UpdateWorkstationConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateWorkstationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateWorkstationConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateWorkstationConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateWorkstationConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkstationConfig, OperationMetadata> PollOnceUpdateWorkstationConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkstationConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkstationConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateWorkstationConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> PollOnceUpdateWorkstationConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkstationConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkstationConfigOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing workstation configuration.
        /// </summary>
        /// <param name="workstationConfig">
        /// Required. Config to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields in the workstation configuration
        /// should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationConfig, OperationMetadata> UpdateWorkstationConfig(WorkstationConfig workstationConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkstationConfig(new UpdateWorkstationConfigRequest
            {
                WorkstationConfig = gax::GaxPreconditions.CheckNotNull(workstationConfig, nameof(workstationConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing workstation configuration.
        /// </summary>
        /// <param name="workstationConfig">
        /// Required. Config to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields in the workstation configuration
        /// should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> UpdateWorkstationConfigAsync(WorkstationConfig workstationConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkstationConfigAsync(new UpdateWorkstationConfigRequest
            {
                WorkstationConfig = gax::GaxPreconditions.CheckNotNull(workstationConfig, nameof(workstationConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing workstation configuration.
        /// </summary>
        /// <param name="workstationConfig">
        /// Required. Config to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields in the workstation configuration
        /// should be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> UpdateWorkstationConfigAsync(WorkstationConfig workstationConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWorkstationConfigAsync(workstationConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationConfig, OperationMetadata> DeleteWorkstationConfig(DeleteWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> DeleteWorkstationConfigAsync(DeleteWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> DeleteWorkstationConfigAsync(DeleteWorkstationConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkstationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteWorkstationConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteWorkstationConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteWorkstationConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkstationConfig, OperationMetadata> PollOnceDeleteWorkstationConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkstationConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkstationConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteWorkstationConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> PollOnceDeleteWorkstationConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkstationConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkstationConfigOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified workstation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation configuration to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationConfig, OperationMetadata> DeleteWorkstationConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkstationConfig(new DeleteWorkstationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified workstation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation configuration to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> DeleteWorkstationConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkstationConfigAsync(new DeleteWorkstationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified workstation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation configuration to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> DeleteWorkstationConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkstationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified workstation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation configuration to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkstationConfig, OperationMetadata> DeleteWorkstationConfig(WorkstationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkstationConfig(new DeleteWorkstationConfigRequest
            {
                WorkstationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified workstation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation configuration to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> DeleteWorkstationConfigAsync(WorkstationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkstationConfigAsync(new DeleteWorkstationConfigRequest
            {
                WorkstationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified workstation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation configuration to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> DeleteWorkstationConfigAsync(WorkstationConfigName name, st::CancellationToken cancellationToken) =>
            DeleteWorkstationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workstation GetWorkstation(GetWorkstationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workstation> GetWorkstationAsync(GetWorkstationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workstation> GetWorkstationAsync(GetWorkstationRequest request, st::CancellationToken cancellationToken) =>
            GetWorkstationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested workstation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workstation GetWorkstation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkstation(new GetWorkstationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested workstation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workstation> GetWorkstationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkstationAsync(new GetWorkstationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested workstation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workstation> GetWorkstationAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkstationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested workstation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workstation GetWorkstation(WorkstationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkstation(new GetWorkstationRequest
            {
                WorkstationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested workstation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workstation> GetWorkstationAsync(WorkstationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkstationAsync(new GetWorkstationRequest
            {
                WorkstationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested workstation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workstation> GetWorkstationAsync(WorkstationName name, st::CancellationToken cancellationToken) =>
            GetWorkstationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all Workstations using the specified workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workstation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkstationsResponse, Workstation> ListWorkstations(ListWorkstationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all Workstations using the specified workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workstation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkstationsResponse, Workstation> ListWorkstationsAsync(ListWorkstationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all Workstations using the specified workstation configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable sequence of <see cref="Workstation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkstationsResponse, Workstation> ListWorkstations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkstationsRequest request = new ListWorkstationsRequest
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
            return ListWorkstations(request, callSettings);
        }

        /// <summary>
        /// Returns all Workstations using the specified workstation configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workstation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkstationsResponse, Workstation> ListWorkstationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkstationsRequest request = new ListWorkstationsRequest
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
            return ListWorkstationsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all Workstations using the specified workstation configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable sequence of <see cref="Workstation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkstationsResponse, Workstation> ListWorkstations(WorkstationConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkstationsRequest request = new ListWorkstationsRequest
            {
                ParentAsWorkstationConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkstations(request, callSettings);
        }

        /// <summary>
        /// Returns all Workstations using the specified workstation configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workstation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkstationsResponse, Workstation> ListWorkstationsAsync(WorkstationConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkstationsRequest request = new ListWorkstationsRequest
            {
                ParentAsWorkstationConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkstationsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all workstations using the specified workstation configuration
        /// on which the caller has the "workstations.workstations.use" permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workstation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsableWorkstationsResponse, Workstation> ListUsableWorkstations(ListUsableWorkstationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all workstations using the specified workstation configuration
        /// on which the caller has the "workstations.workstations.use" permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workstation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsableWorkstationsResponse, Workstation> ListUsableWorkstationsAsync(ListUsableWorkstationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all workstations using the specified workstation configuration
        /// on which the caller has the "workstations.workstations.use" permission.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable sequence of <see cref="Workstation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsableWorkstationsResponse, Workstation> ListUsableWorkstations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsableWorkstationsRequest request = new ListUsableWorkstationsRequest
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
            return ListUsableWorkstations(request, callSettings);
        }

        /// <summary>
        /// Returns all workstations using the specified workstation configuration
        /// on which the caller has the "workstations.workstations.use" permission.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workstation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsableWorkstationsResponse, Workstation> ListUsableWorkstationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsableWorkstationsRequest request = new ListUsableWorkstationsRequest
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
            return ListUsableWorkstationsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all workstations using the specified workstation configuration
        /// on which the caller has the "workstations.workstations.use" permission.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable sequence of <see cref="Workstation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsableWorkstationsResponse, Workstation> ListUsableWorkstations(WorkstationConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsableWorkstationsRequest request = new ListUsableWorkstationsRequest
            {
                ParentAsWorkstationConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUsableWorkstations(request, callSettings);
        }

        /// <summary>
        /// Returns all workstations using the specified workstation configuration
        /// on which the caller has the "workstations.workstations.use" permission.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workstation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsableWorkstationsResponse, Workstation> ListUsableWorkstationsAsync(WorkstationConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsableWorkstationsRequest request = new ListUsableWorkstationsRequest
            {
                ParentAsWorkstationConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUsableWorkstationsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> CreateWorkstation(CreateWorkstationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> CreateWorkstationAsync(CreateWorkstationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> CreateWorkstationAsync(CreateWorkstationRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkstationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateWorkstation</c>.</summary>
        public virtual lro::OperationsClient CreateWorkstationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateWorkstation</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> PollOnceCreateWorkstation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workstation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkstationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkstation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> PollOnceCreateWorkstationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workstation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkstationOperationsClient, callSettings);

        /// <summary>
        /// Creates a new workstation.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstation">
        /// Required. Workstation to create.
        /// </param>
        /// <param name="workstationId">
        /// Required. ID to use for the workstation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> CreateWorkstation(string parent, Workstation workstation, string workstationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkstation(new CreateWorkstationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkstationId = gax::GaxPreconditions.CheckNotNullOrEmpty(workstationId, nameof(workstationId)),
                Workstation = gax::GaxPreconditions.CheckNotNull(workstation, nameof(workstation)),
            }, callSettings);

        /// <summary>
        /// Creates a new workstation.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstation">
        /// Required. Workstation to create.
        /// </param>
        /// <param name="workstationId">
        /// Required. ID to use for the workstation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> CreateWorkstationAsync(string parent, Workstation workstation, string workstationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkstationAsync(new CreateWorkstationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkstationId = gax::GaxPreconditions.CheckNotNullOrEmpty(workstationId, nameof(workstationId)),
                Workstation = gax::GaxPreconditions.CheckNotNull(workstation, nameof(workstation)),
            }, callSettings);

        /// <summary>
        /// Creates a new workstation.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstation">
        /// Required. Workstation to create.
        /// </param>
        /// <param name="workstationId">
        /// Required. ID to use for the workstation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> CreateWorkstationAsync(string parent, Workstation workstation, string workstationId, st::CancellationToken cancellationToken) =>
            CreateWorkstationAsync(parent, workstation, workstationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new workstation.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstation">
        /// Required. Workstation to create.
        /// </param>
        /// <param name="workstationId">
        /// Required. ID to use for the workstation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> CreateWorkstation(WorkstationConfigName parent, Workstation workstation, string workstationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkstation(new CreateWorkstationRequest
            {
                ParentAsWorkstationConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkstationId = gax::GaxPreconditions.CheckNotNullOrEmpty(workstationId, nameof(workstationId)),
                Workstation = gax::GaxPreconditions.CheckNotNull(workstation, nameof(workstation)),
            }, callSettings);

        /// <summary>
        /// Creates a new workstation.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstation">
        /// Required. Workstation to create.
        /// </param>
        /// <param name="workstationId">
        /// Required. ID to use for the workstation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> CreateWorkstationAsync(WorkstationConfigName parent, Workstation workstation, string workstationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkstationAsync(new CreateWorkstationRequest
            {
                ParentAsWorkstationConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkstationId = gax::GaxPreconditions.CheckNotNullOrEmpty(workstationId, nameof(workstationId)),
                Workstation = gax::GaxPreconditions.CheckNotNull(workstation, nameof(workstation)),
            }, callSettings);

        /// <summary>
        /// Creates a new workstation.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// </param>
        /// <param name="workstation">
        /// Required. Workstation to create.
        /// </param>
        /// <param name="workstationId">
        /// Required. ID to use for the workstation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> CreateWorkstationAsync(WorkstationConfigName parent, Workstation workstation, string workstationId, st::CancellationToken cancellationToken) =>
            CreateWorkstationAsync(parent, workstation, workstationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> UpdateWorkstation(UpdateWorkstationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> UpdateWorkstationAsync(UpdateWorkstationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> UpdateWorkstationAsync(UpdateWorkstationRequest request, st::CancellationToken cancellationToken) =>
            UpdateWorkstationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateWorkstation</c>.</summary>
        public virtual lro::OperationsClient UpdateWorkstationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateWorkstation</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> PollOnceUpdateWorkstation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workstation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkstationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateWorkstation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> PollOnceUpdateWorkstationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workstation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkstationOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing workstation.
        /// </summary>
        /// <param name="workstation">
        /// Required. Workstation to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields in the workstation configuration
        /// should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> UpdateWorkstation(Workstation workstation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkstation(new UpdateWorkstationRequest
            {
                Workstation = gax::GaxPreconditions.CheckNotNull(workstation, nameof(workstation)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing workstation.
        /// </summary>
        /// <param name="workstation">
        /// Required. Workstation to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields in the workstation configuration
        /// should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> UpdateWorkstationAsync(Workstation workstation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkstationAsync(new UpdateWorkstationRequest
            {
                Workstation = gax::GaxPreconditions.CheckNotNull(workstation, nameof(workstation)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing workstation.
        /// </summary>
        /// <param name="workstation">
        /// Required. Workstation to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields in the workstation configuration
        /// should be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> UpdateWorkstationAsync(Workstation workstation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWorkstationAsync(workstation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> DeleteWorkstation(DeleteWorkstationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> DeleteWorkstationAsync(DeleteWorkstationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> DeleteWorkstationAsync(DeleteWorkstationRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkstationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteWorkstation</c>.</summary>
        public virtual lro::OperationsClient DeleteWorkstationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteWorkstation</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> PollOnceDeleteWorkstation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workstation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkstationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteWorkstation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> PollOnceDeleteWorkstationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workstation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkstationOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified workstation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> DeleteWorkstation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkstation(new DeleteWorkstationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified workstation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> DeleteWorkstationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkstationAsync(new DeleteWorkstationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified workstation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> DeleteWorkstationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkstationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified workstation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> DeleteWorkstation(WorkstationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkstation(new DeleteWorkstationRequest
            {
                WorkstationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified workstation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> DeleteWorkstationAsync(WorkstationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkstationAsync(new DeleteWorkstationRequest
            {
                WorkstationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified workstation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> DeleteWorkstationAsync(WorkstationName name, st::CancellationToken cancellationToken) =>
            DeleteWorkstationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts running a workstation so that users can connect to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> StartWorkstation(StartWorkstationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts running a workstation so that users can connect to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> StartWorkstationAsync(StartWorkstationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts running a workstation so that users can connect to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> StartWorkstationAsync(StartWorkstationRequest request, st::CancellationToken cancellationToken) =>
            StartWorkstationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartWorkstation</c>.</summary>
        public virtual lro::OperationsClient StartWorkstationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartWorkstation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> PollOnceStartWorkstation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workstation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartWorkstationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartWorkstation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> PollOnceStartWorkstationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workstation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartWorkstationOperationsClient, callSettings);

        /// <summary>
        /// Starts running a workstation so that users can connect to it.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to start.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> StartWorkstation(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartWorkstation(new StartWorkstationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts running a workstation so that users can connect to it.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to start.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> StartWorkstationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartWorkstationAsync(new StartWorkstationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts running a workstation so that users can connect to it.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to start.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> StartWorkstationAsync(string name, st::CancellationToken cancellationToken) =>
            StartWorkstationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts running a workstation so that users can connect to it.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to start.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> StartWorkstation(WorkstationName name, gaxgrpc::CallSettings callSettings = null) =>
            StartWorkstation(new StartWorkstationRequest
            {
                WorkstationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts running a workstation so that users can connect to it.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to start.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> StartWorkstationAsync(WorkstationName name, gaxgrpc::CallSettings callSettings = null) =>
            StartWorkstationAsync(new StartWorkstationRequest
            {
                WorkstationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts running a workstation so that users can connect to it.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to start.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> StartWorkstationAsync(WorkstationName name, st::CancellationToken cancellationToken) =>
            StartWorkstationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops running a workstation, reducing costs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> StopWorkstation(StopWorkstationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops running a workstation, reducing costs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> StopWorkstationAsync(StopWorkstationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops running a workstation, reducing costs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> StopWorkstationAsync(StopWorkstationRequest request, st::CancellationToken cancellationToken) =>
            StopWorkstationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopWorkstation</c>.</summary>
        public virtual lro::OperationsClient StopWorkstationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StopWorkstation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> PollOnceStopWorkstation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workstation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopWorkstationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopWorkstation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> PollOnceStopWorkstationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workstation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopWorkstationOperationsClient, callSettings);

        /// <summary>
        /// Stops running a workstation, reducing costs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to stop.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> StopWorkstation(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopWorkstation(new StopWorkstationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops running a workstation, reducing costs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to stop.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> StopWorkstationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopWorkstationAsync(new StopWorkstationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops running a workstation, reducing costs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to stop.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> StopWorkstationAsync(string name, st::CancellationToken cancellationToken) =>
            StopWorkstationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops running a workstation, reducing costs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to stop.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workstation, OperationMetadata> StopWorkstation(WorkstationName name, gaxgrpc::CallSettings callSettings = null) =>
            StopWorkstation(new StopWorkstationRequest
            {
                WorkstationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops running a workstation, reducing costs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to stop.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> StopWorkstationAsync(WorkstationName name, gaxgrpc::CallSettings callSettings = null) =>
            StopWorkstationAsync(new StopWorkstationRequest
            {
                WorkstationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops running a workstation, reducing costs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workstation to stop.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workstation, OperationMetadata>> StopWorkstationAsync(WorkstationName name, st::CancellationToken cancellationToken) =>
            StopWorkstationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a short-lived credential that can be used to send authenticated and
        /// authorized traffic to a workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAccessTokenResponse GenerateAccessToken(GenerateAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a short-lived credential that can be used to send authenticated and
        /// authorized traffic to a workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(GenerateAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a short-lived credential that can be used to send authenticated and
        /// authorized traffic to a workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(GenerateAccessTokenRequest request, st::CancellationToken cancellationToken) =>
            GenerateAccessTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a short-lived credential that can be used to send authenticated and
        /// authorized traffic to a workstation.
        /// </summary>
        /// <param name="workstation">
        /// Required. Name of the workstation for which the access token should be
        /// generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAccessTokenResponse GenerateAccessToken(string workstation, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAccessToken(new GenerateAccessTokenRequest
            {
                Workstation = gax::GaxPreconditions.CheckNotNullOrEmpty(workstation, nameof(workstation)),
            }, callSettings);

        /// <summary>
        /// Returns a short-lived credential that can be used to send authenticated and
        /// authorized traffic to a workstation.
        /// </summary>
        /// <param name="workstation">
        /// Required. Name of the workstation for which the access token should be
        /// generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(string workstation, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAccessTokenAsync(new GenerateAccessTokenRequest
            {
                Workstation = gax::GaxPreconditions.CheckNotNullOrEmpty(workstation, nameof(workstation)),
            }, callSettings);

        /// <summary>
        /// Returns a short-lived credential that can be used to send authenticated and
        /// authorized traffic to a workstation.
        /// </summary>
        /// <param name="workstation">
        /// Required. Name of the workstation for which the access token should be
        /// generated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(string workstation, st::CancellationToken cancellationToken) =>
            GenerateAccessTokenAsync(workstation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a short-lived credential that can be used to send authenticated and
        /// authorized traffic to a workstation.
        /// </summary>
        /// <param name="workstation">
        /// Required. Name of the workstation for which the access token should be
        /// generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAccessTokenResponse GenerateAccessToken(WorkstationName workstation, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAccessToken(new GenerateAccessTokenRequest
            {
                WorkstationAsWorkstationName = gax::GaxPreconditions.CheckNotNull(workstation, nameof(workstation)),
            }, callSettings);

        /// <summary>
        /// Returns a short-lived credential that can be used to send authenticated and
        /// authorized traffic to a workstation.
        /// </summary>
        /// <param name="workstation">
        /// Required. Name of the workstation for which the access token should be
        /// generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(WorkstationName workstation, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAccessTokenAsync(new GenerateAccessTokenRequest
            {
                WorkstationAsWorkstationName = gax::GaxPreconditions.CheckNotNull(workstation, nameof(workstation)),
            }, callSettings);

        /// <summary>
        /// Returns a short-lived credential that can be used to send authenticated and
        /// authorized traffic to a workstation.
        /// </summary>
        /// <param name="workstation">
        /// Required. Name of the workstation for which the access token should be
        /// generated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(WorkstationName workstation, st::CancellationToken cancellationToken) =>
            GenerateAccessTokenAsync(workstation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Workstations client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for interacting with Cloud Workstations.
    /// </remarks>
    public sealed partial class WorkstationsClientImpl : WorkstationsClient
    {
        private readonly gaxgrpc::ApiCall<GetWorkstationClusterRequest, WorkstationCluster> _callGetWorkstationCluster;

        private readonly gaxgrpc::ApiCall<ListWorkstationClustersRequest, ListWorkstationClustersResponse> _callListWorkstationClusters;

        private readonly gaxgrpc::ApiCall<CreateWorkstationClusterRequest, lro::Operation> _callCreateWorkstationCluster;

        private readonly gaxgrpc::ApiCall<UpdateWorkstationClusterRequest, lro::Operation> _callUpdateWorkstationCluster;

        private readonly gaxgrpc::ApiCall<DeleteWorkstationClusterRequest, lro::Operation> _callDeleteWorkstationCluster;

        private readonly gaxgrpc::ApiCall<GetWorkstationConfigRequest, WorkstationConfig> _callGetWorkstationConfig;

        private readonly gaxgrpc::ApiCall<ListWorkstationConfigsRequest, ListWorkstationConfigsResponse> _callListWorkstationConfigs;

        private readonly gaxgrpc::ApiCall<ListUsableWorkstationConfigsRequest, ListUsableWorkstationConfigsResponse> _callListUsableWorkstationConfigs;

        private readonly gaxgrpc::ApiCall<CreateWorkstationConfigRequest, lro::Operation> _callCreateWorkstationConfig;

        private readonly gaxgrpc::ApiCall<UpdateWorkstationConfigRequest, lro::Operation> _callUpdateWorkstationConfig;

        private readonly gaxgrpc::ApiCall<DeleteWorkstationConfigRequest, lro::Operation> _callDeleteWorkstationConfig;

        private readonly gaxgrpc::ApiCall<GetWorkstationRequest, Workstation> _callGetWorkstation;

        private readonly gaxgrpc::ApiCall<ListWorkstationsRequest, ListWorkstationsResponse> _callListWorkstations;

        private readonly gaxgrpc::ApiCall<ListUsableWorkstationsRequest, ListUsableWorkstationsResponse> _callListUsableWorkstations;

        private readonly gaxgrpc::ApiCall<CreateWorkstationRequest, lro::Operation> _callCreateWorkstation;

        private readonly gaxgrpc::ApiCall<UpdateWorkstationRequest, lro::Operation> _callUpdateWorkstation;

        private readonly gaxgrpc::ApiCall<DeleteWorkstationRequest, lro::Operation> _callDeleteWorkstation;

        private readonly gaxgrpc::ApiCall<StartWorkstationRequest, lro::Operation> _callStartWorkstation;

        private readonly gaxgrpc::ApiCall<StopWorkstationRequest, lro::Operation> _callStopWorkstation;

        private readonly gaxgrpc::ApiCall<GenerateAccessTokenRequest, GenerateAccessTokenResponse> _callGenerateAccessToken;

        /// <summary>
        /// Constructs a client wrapper for the Workstations service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WorkstationsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WorkstationsClientImpl(Workstations.WorkstationsClient grpcClient, WorkstationsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WorkstationsSettings effectiveSettings = settings ?? WorkstationsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateWorkstationClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateWorkstationClusterOperationsSettings, logger);
            UpdateWorkstationClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateWorkstationClusterOperationsSettings, logger);
            DeleteWorkstationClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteWorkstationClusterOperationsSettings, logger);
            CreateWorkstationConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateWorkstationConfigOperationsSettings, logger);
            UpdateWorkstationConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateWorkstationConfigOperationsSettings, logger);
            DeleteWorkstationConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteWorkstationConfigOperationsSettings, logger);
            CreateWorkstationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateWorkstationOperationsSettings, logger);
            UpdateWorkstationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateWorkstationOperationsSettings, logger);
            DeleteWorkstationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteWorkstationOperationsSettings, logger);
            StartWorkstationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartWorkstationOperationsSettings, logger);
            StopWorkstationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopWorkstationOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callGetWorkstationCluster = clientHelper.BuildApiCall<GetWorkstationClusterRequest, WorkstationCluster>("GetWorkstationCluster", grpcClient.GetWorkstationClusterAsync, grpcClient.GetWorkstationCluster, effectiveSettings.GetWorkstationClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkstationCluster);
            Modify_GetWorkstationClusterApiCall(ref _callGetWorkstationCluster);
            _callListWorkstationClusters = clientHelper.BuildApiCall<ListWorkstationClustersRequest, ListWorkstationClustersResponse>("ListWorkstationClusters", grpcClient.ListWorkstationClustersAsync, grpcClient.ListWorkstationClusters, effectiveSettings.ListWorkstationClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkstationClusters);
            Modify_ListWorkstationClustersApiCall(ref _callListWorkstationClusters);
            _callCreateWorkstationCluster = clientHelper.BuildApiCall<CreateWorkstationClusterRequest, lro::Operation>("CreateWorkstationCluster", grpcClient.CreateWorkstationClusterAsync, grpcClient.CreateWorkstationCluster, effectiveSettings.CreateWorkstationClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWorkstationCluster);
            Modify_CreateWorkstationClusterApiCall(ref _callCreateWorkstationCluster);
            _callUpdateWorkstationCluster = clientHelper.BuildApiCall<UpdateWorkstationClusterRequest, lro::Operation>("UpdateWorkstationCluster", grpcClient.UpdateWorkstationClusterAsync, grpcClient.UpdateWorkstationCluster, effectiveSettings.UpdateWorkstationClusterSettings).WithGoogleRequestParam("workstation_cluster.name", request => request.WorkstationCluster?.Name);
            Modify_ApiCall(ref _callUpdateWorkstationCluster);
            Modify_UpdateWorkstationClusterApiCall(ref _callUpdateWorkstationCluster);
            _callDeleteWorkstationCluster = clientHelper.BuildApiCall<DeleteWorkstationClusterRequest, lro::Operation>("DeleteWorkstationCluster", grpcClient.DeleteWorkstationClusterAsync, grpcClient.DeleteWorkstationCluster, effectiveSettings.DeleteWorkstationClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWorkstationCluster);
            Modify_DeleteWorkstationClusterApiCall(ref _callDeleteWorkstationCluster);
            _callGetWorkstationConfig = clientHelper.BuildApiCall<GetWorkstationConfigRequest, WorkstationConfig>("GetWorkstationConfig", grpcClient.GetWorkstationConfigAsync, grpcClient.GetWorkstationConfig, effectiveSettings.GetWorkstationConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkstationConfig);
            Modify_GetWorkstationConfigApiCall(ref _callGetWorkstationConfig);
            _callListWorkstationConfigs = clientHelper.BuildApiCall<ListWorkstationConfigsRequest, ListWorkstationConfigsResponse>("ListWorkstationConfigs", grpcClient.ListWorkstationConfigsAsync, grpcClient.ListWorkstationConfigs, effectiveSettings.ListWorkstationConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkstationConfigs);
            Modify_ListWorkstationConfigsApiCall(ref _callListWorkstationConfigs);
            _callListUsableWorkstationConfigs = clientHelper.BuildApiCall<ListUsableWorkstationConfigsRequest, ListUsableWorkstationConfigsResponse>("ListUsableWorkstationConfigs", grpcClient.ListUsableWorkstationConfigsAsync, grpcClient.ListUsableWorkstationConfigs, effectiveSettings.ListUsableWorkstationConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUsableWorkstationConfigs);
            Modify_ListUsableWorkstationConfigsApiCall(ref _callListUsableWorkstationConfigs);
            _callCreateWorkstationConfig = clientHelper.BuildApiCall<CreateWorkstationConfigRequest, lro::Operation>("CreateWorkstationConfig", grpcClient.CreateWorkstationConfigAsync, grpcClient.CreateWorkstationConfig, effectiveSettings.CreateWorkstationConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWorkstationConfig);
            Modify_CreateWorkstationConfigApiCall(ref _callCreateWorkstationConfig);
            _callUpdateWorkstationConfig = clientHelper.BuildApiCall<UpdateWorkstationConfigRequest, lro::Operation>("UpdateWorkstationConfig", grpcClient.UpdateWorkstationConfigAsync, grpcClient.UpdateWorkstationConfig, effectiveSettings.UpdateWorkstationConfigSettings).WithGoogleRequestParam("workstation_config.name", request => request.WorkstationConfig?.Name);
            Modify_ApiCall(ref _callUpdateWorkstationConfig);
            Modify_UpdateWorkstationConfigApiCall(ref _callUpdateWorkstationConfig);
            _callDeleteWorkstationConfig = clientHelper.BuildApiCall<DeleteWorkstationConfigRequest, lro::Operation>("DeleteWorkstationConfig", grpcClient.DeleteWorkstationConfigAsync, grpcClient.DeleteWorkstationConfig, effectiveSettings.DeleteWorkstationConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWorkstationConfig);
            Modify_DeleteWorkstationConfigApiCall(ref _callDeleteWorkstationConfig);
            _callGetWorkstation = clientHelper.BuildApiCall<GetWorkstationRequest, Workstation>("GetWorkstation", grpcClient.GetWorkstationAsync, grpcClient.GetWorkstation, effectiveSettings.GetWorkstationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkstation);
            Modify_GetWorkstationApiCall(ref _callGetWorkstation);
            _callListWorkstations = clientHelper.BuildApiCall<ListWorkstationsRequest, ListWorkstationsResponse>("ListWorkstations", grpcClient.ListWorkstationsAsync, grpcClient.ListWorkstations, effectiveSettings.ListWorkstationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkstations);
            Modify_ListWorkstationsApiCall(ref _callListWorkstations);
            _callListUsableWorkstations = clientHelper.BuildApiCall<ListUsableWorkstationsRequest, ListUsableWorkstationsResponse>("ListUsableWorkstations", grpcClient.ListUsableWorkstationsAsync, grpcClient.ListUsableWorkstations, effectiveSettings.ListUsableWorkstationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUsableWorkstations);
            Modify_ListUsableWorkstationsApiCall(ref _callListUsableWorkstations);
            _callCreateWorkstation = clientHelper.BuildApiCall<CreateWorkstationRequest, lro::Operation>("CreateWorkstation", grpcClient.CreateWorkstationAsync, grpcClient.CreateWorkstation, effectiveSettings.CreateWorkstationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWorkstation);
            Modify_CreateWorkstationApiCall(ref _callCreateWorkstation);
            _callUpdateWorkstation = clientHelper.BuildApiCall<UpdateWorkstationRequest, lro::Operation>("UpdateWorkstation", grpcClient.UpdateWorkstationAsync, grpcClient.UpdateWorkstation, effectiveSettings.UpdateWorkstationSettings).WithGoogleRequestParam("workstation.name", request => request.Workstation?.Name);
            Modify_ApiCall(ref _callUpdateWorkstation);
            Modify_UpdateWorkstationApiCall(ref _callUpdateWorkstation);
            _callDeleteWorkstation = clientHelper.BuildApiCall<DeleteWorkstationRequest, lro::Operation>("DeleteWorkstation", grpcClient.DeleteWorkstationAsync, grpcClient.DeleteWorkstation, effectiveSettings.DeleteWorkstationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWorkstation);
            Modify_DeleteWorkstationApiCall(ref _callDeleteWorkstation);
            _callStartWorkstation = clientHelper.BuildApiCall<StartWorkstationRequest, lro::Operation>("StartWorkstation", grpcClient.StartWorkstationAsync, grpcClient.StartWorkstation, effectiveSettings.StartWorkstationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartWorkstation);
            Modify_StartWorkstationApiCall(ref _callStartWorkstation);
            _callStopWorkstation = clientHelper.BuildApiCall<StopWorkstationRequest, lro::Operation>("StopWorkstation", grpcClient.StopWorkstationAsync, grpcClient.StopWorkstation, effectiveSettings.StopWorkstationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopWorkstation);
            Modify_StopWorkstationApiCall(ref _callStopWorkstation);
            _callGenerateAccessToken = clientHelper.BuildApiCall<GenerateAccessTokenRequest, GenerateAccessTokenResponse>("GenerateAccessToken", grpcClient.GenerateAccessTokenAsync, grpcClient.GenerateAccessToken, effectiveSettings.GenerateAccessTokenSettings).WithGoogleRequestParam("workstation", request => request.Workstation);
            Modify_ApiCall(ref _callGenerateAccessToken);
            Modify_GenerateAccessTokenApiCall(ref _callGenerateAccessToken);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetWorkstationClusterApiCall(ref gaxgrpc::ApiCall<GetWorkstationClusterRequest, WorkstationCluster> call);

        partial void Modify_ListWorkstationClustersApiCall(ref gaxgrpc::ApiCall<ListWorkstationClustersRequest, ListWorkstationClustersResponse> call);

        partial void Modify_CreateWorkstationClusterApiCall(ref gaxgrpc::ApiCall<CreateWorkstationClusterRequest, lro::Operation> call);

        partial void Modify_UpdateWorkstationClusterApiCall(ref gaxgrpc::ApiCall<UpdateWorkstationClusterRequest, lro::Operation> call);

        partial void Modify_DeleteWorkstationClusterApiCall(ref gaxgrpc::ApiCall<DeleteWorkstationClusterRequest, lro::Operation> call);

        partial void Modify_GetWorkstationConfigApiCall(ref gaxgrpc::ApiCall<GetWorkstationConfigRequest, WorkstationConfig> call);

        partial void Modify_ListWorkstationConfigsApiCall(ref gaxgrpc::ApiCall<ListWorkstationConfigsRequest, ListWorkstationConfigsResponse> call);

        partial void Modify_ListUsableWorkstationConfigsApiCall(ref gaxgrpc::ApiCall<ListUsableWorkstationConfigsRequest, ListUsableWorkstationConfigsResponse> call);

        partial void Modify_CreateWorkstationConfigApiCall(ref gaxgrpc::ApiCall<CreateWorkstationConfigRequest, lro::Operation> call);

        partial void Modify_UpdateWorkstationConfigApiCall(ref gaxgrpc::ApiCall<UpdateWorkstationConfigRequest, lro::Operation> call);

        partial void Modify_DeleteWorkstationConfigApiCall(ref gaxgrpc::ApiCall<DeleteWorkstationConfigRequest, lro::Operation> call);

        partial void Modify_GetWorkstationApiCall(ref gaxgrpc::ApiCall<GetWorkstationRequest, Workstation> call);

        partial void Modify_ListWorkstationsApiCall(ref gaxgrpc::ApiCall<ListWorkstationsRequest, ListWorkstationsResponse> call);

        partial void Modify_ListUsableWorkstationsApiCall(ref gaxgrpc::ApiCall<ListUsableWorkstationsRequest, ListUsableWorkstationsResponse> call);

        partial void Modify_CreateWorkstationApiCall(ref gaxgrpc::ApiCall<CreateWorkstationRequest, lro::Operation> call);

        partial void Modify_UpdateWorkstationApiCall(ref gaxgrpc::ApiCall<UpdateWorkstationRequest, lro::Operation> call);

        partial void Modify_DeleteWorkstationApiCall(ref gaxgrpc::ApiCall<DeleteWorkstationRequest, lro::Operation> call);

        partial void Modify_StartWorkstationApiCall(ref gaxgrpc::ApiCall<StartWorkstationRequest, lro::Operation> call);

        partial void Modify_StopWorkstationApiCall(ref gaxgrpc::ApiCall<StopWorkstationRequest, lro::Operation> call);

        partial void Modify_GenerateAccessTokenApiCall(ref gaxgrpc::ApiCall<GenerateAccessTokenRequest, GenerateAccessTokenResponse> call);

        partial void OnConstruction(Workstations.WorkstationsClient grpcClient, WorkstationsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Workstations client</summary>
        public override Workstations.WorkstationsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_GetWorkstationClusterRequest(ref GetWorkstationClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkstationClustersRequest(ref ListWorkstationClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateWorkstationClusterRequest(ref CreateWorkstationClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWorkstationClusterRequest(ref UpdateWorkstationClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkstationClusterRequest(ref DeleteWorkstationClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkstationConfigRequest(ref GetWorkstationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkstationConfigsRequest(ref ListWorkstationConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUsableWorkstationConfigsRequest(ref ListUsableWorkstationConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateWorkstationConfigRequest(ref CreateWorkstationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWorkstationConfigRequest(ref UpdateWorkstationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkstationConfigRequest(ref DeleteWorkstationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkstationRequest(ref GetWorkstationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkstationsRequest(ref ListWorkstationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUsableWorkstationsRequest(ref ListUsableWorkstationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateWorkstationRequest(ref CreateWorkstationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWorkstationRequest(ref UpdateWorkstationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkstationRequest(ref DeleteWorkstationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartWorkstationRequest(ref StartWorkstationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopWorkstationRequest(ref StopWorkstationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateAccessTokenRequest(ref GenerateAccessTokenRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkstationCluster GetWorkstationCluster(GetWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkstationClusterRequest(ref request, ref callSettings);
            return _callGetWorkstationCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkstationCluster> GetWorkstationClusterAsync(GetWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkstationClusterRequest(ref request, ref callSettings);
            return _callGetWorkstationCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Returns all workstation clusters in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkstationCluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkstationClustersResponse, WorkstationCluster> ListWorkstationClusters(ListWorkstationClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkstationClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkstationClustersRequest, ListWorkstationClustersResponse, WorkstationCluster>(_callListWorkstationClusters, request, callSettings);
        }

        /// <summary>
        /// Returns all workstation clusters in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkstationCluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkstationClustersResponse, WorkstationCluster> ListWorkstationClustersAsync(ListWorkstationClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkstationClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkstationClustersRequest, ListWorkstationClustersResponse, WorkstationCluster>(_callListWorkstationClusters, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateWorkstationCluster</c>.</summary>
        public override lro::OperationsClient CreateWorkstationClusterOperationsClient { get; }

        /// <summary>
        /// Creates a new workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkstationCluster, OperationMetadata> CreateWorkstationCluster(CreateWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkstationClusterRequest(ref request, ref callSettings);
            return new lro::Operation<WorkstationCluster, OperationMetadata>(_callCreateWorkstationCluster.Sync(request, callSettings), CreateWorkstationClusterOperationsClient);
        }

        /// <summary>
        /// Creates a new workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> CreateWorkstationClusterAsync(CreateWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkstationClusterRequest(ref request, ref callSettings);
            return new lro::Operation<WorkstationCluster, OperationMetadata>(await _callCreateWorkstationCluster.Async(request, callSettings).ConfigureAwait(false), CreateWorkstationClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateWorkstationCluster</c>.</summary>
        public override lro::OperationsClient UpdateWorkstationClusterOperationsClient { get; }

        /// <summary>
        /// Updates an existing workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkstationCluster, OperationMetadata> UpdateWorkstationCluster(UpdateWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkstationClusterRequest(ref request, ref callSettings);
            return new lro::Operation<WorkstationCluster, OperationMetadata>(_callUpdateWorkstationCluster.Sync(request, callSettings), UpdateWorkstationClusterOperationsClient);
        }

        /// <summary>
        /// Updates an existing workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> UpdateWorkstationClusterAsync(UpdateWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkstationClusterRequest(ref request, ref callSettings);
            return new lro::Operation<WorkstationCluster, OperationMetadata>(await _callUpdateWorkstationCluster.Async(request, callSettings).ConfigureAwait(false), UpdateWorkstationClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteWorkstationCluster</c>.</summary>
        public override lro::OperationsClient DeleteWorkstationClusterOperationsClient { get; }

        /// <summary>
        /// Deletes the specified workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkstationCluster, OperationMetadata> DeleteWorkstationCluster(DeleteWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkstationClusterRequest(ref request, ref callSettings);
            return new lro::Operation<WorkstationCluster, OperationMetadata>(_callDeleteWorkstationCluster.Sync(request, callSettings), DeleteWorkstationClusterOperationsClient);
        }

        /// <summary>
        /// Deletes the specified workstation cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkstationCluster, OperationMetadata>> DeleteWorkstationClusterAsync(DeleteWorkstationClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkstationClusterRequest(ref request, ref callSettings);
            return new lro::Operation<WorkstationCluster, OperationMetadata>(await _callDeleteWorkstationCluster.Async(request, callSettings).ConfigureAwait(false), DeleteWorkstationClusterOperationsClient);
        }

        /// <summary>
        /// Returns the requested workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkstationConfig GetWorkstationConfig(GetWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkstationConfigRequest(ref request, ref callSettings);
            return _callGetWorkstationConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkstationConfig> GetWorkstationConfigAsync(GetWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkstationConfigRequest(ref request, ref callSettings);
            return _callGetWorkstationConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Returns all workstation configurations in the specified cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> ListWorkstationConfigs(ListWorkstationConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkstationConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkstationConfigsRequest, ListWorkstationConfigsResponse, WorkstationConfig>(_callListWorkstationConfigs, request, callSettings);
        }

        /// <summary>
        /// Returns all workstation configurations in the specified cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> ListWorkstationConfigsAsync(ListWorkstationConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkstationConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkstationConfigsRequest, ListWorkstationConfigsResponse, WorkstationConfig>(_callListWorkstationConfigs, request, callSettings);
        }

        /// <summary>
        /// Returns all workstation configurations in the specified cluster on which
        /// the caller has the "workstations.workstation.create" permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> ListUsableWorkstationConfigs(ListUsableWorkstationConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUsableWorkstationConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUsableWorkstationConfigsRequest, ListUsableWorkstationConfigsResponse, WorkstationConfig>(_callListUsableWorkstationConfigs, request, callSettings);
        }

        /// <summary>
        /// Returns all workstation configurations in the specified cluster on which
        /// the caller has the "workstations.workstation.create" permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkstationConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> ListUsableWorkstationConfigsAsync(ListUsableWorkstationConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUsableWorkstationConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUsableWorkstationConfigsRequest, ListUsableWorkstationConfigsResponse, WorkstationConfig>(_callListUsableWorkstationConfigs, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateWorkstationConfig</c>.</summary>
        public override lro::OperationsClient CreateWorkstationConfigOperationsClient { get; }

        /// <summary>
        /// Creates a new workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkstationConfig, OperationMetadata> CreateWorkstationConfig(CreateWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkstationConfigRequest(ref request, ref callSettings);
            return new lro::Operation<WorkstationConfig, OperationMetadata>(_callCreateWorkstationConfig.Sync(request, callSettings), CreateWorkstationConfigOperationsClient);
        }

        /// <summary>
        /// Creates a new workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> CreateWorkstationConfigAsync(CreateWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkstationConfigRequest(ref request, ref callSettings);
            return new lro::Operation<WorkstationConfig, OperationMetadata>(await _callCreateWorkstationConfig.Async(request, callSettings).ConfigureAwait(false), CreateWorkstationConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateWorkstationConfig</c>.</summary>
        public override lro::OperationsClient UpdateWorkstationConfigOperationsClient { get; }

        /// <summary>
        /// Updates an existing workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkstationConfig, OperationMetadata> UpdateWorkstationConfig(UpdateWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkstationConfigRequest(ref request, ref callSettings);
            return new lro::Operation<WorkstationConfig, OperationMetadata>(_callUpdateWorkstationConfig.Sync(request, callSettings), UpdateWorkstationConfigOperationsClient);
        }

        /// <summary>
        /// Updates an existing workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> UpdateWorkstationConfigAsync(UpdateWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkstationConfigRequest(ref request, ref callSettings);
            return new lro::Operation<WorkstationConfig, OperationMetadata>(await _callUpdateWorkstationConfig.Async(request, callSettings).ConfigureAwait(false), UpdateWorkstationConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteWorkstationConfig</c>.</summary>
        public override lro::OperationsClient DeleteWorkstationConfigOperationsClient { get; }

        /// <summary>
        /// Deletes the specified workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkstationConfig, OperationMetadata> DeleteWorkstationConfig(DeleteWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkstationConfigRequest(ref request, ref callSettings);
            return new lro::Operation<WorkstationConfig, OperationMetadata>(_callDeleteWorkstationConfig.Sync(request, callSettings), DeleteWorkstationConfigOperationsClient);
        }

        /// <summary>
        /// Deletes the specified workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkstationConfig, OperationMetadata>> DeleteWorkstationConfigAsync(DeleteWorkstationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkstationConfigRequest(ref request, ref callSettings);
            return new lro::Operation<WorkstationConfig, OperationMetadata>(await _callDeleteWorkstationConfig.Async(request, callSettings).ConfigureAwait(false), DeleteWorkstationConfigOperationsClient);
        }

        /// <summary>
        /// Returns the requested workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Workstation GetWorkstation(GetWorkstationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkstationRequest(ref request, ref callSettings);
            return _callGetWorkstation.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Workstation> GetWorkstationAsync(GetWorkstationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkstationRequest(ref request, ref callSettings);
            return _callGetWorkstation.Async(request, callSettings);
        }

        /// <summary>
        /// Returns all Workstations using the specified workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workstation"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkstationsResponse, Workstation> ListWorkstations(ListWorkstationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkstationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkstationsRequest, ListWorkstationsResponse, Workstation>(_callListWorkstations, request, callSettings);
        }

        /// <summary>
        /// Returns all Workstations using the specified workstation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workstation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkstationsResponse, Workstation> ListWorkstationsAsync(ListWorkstationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkstationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkstationsRequest, ListWorkstationsResponse, Workstation>(_callListWorkstations, request, callSettings);
        }

        /// <summary>
        /// Returns all workstations using the specified workstation configuration
        /// on which the caller has the "workstations.workstations.use" permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workstation"/> resources.</returns>
        public override gax::PagedEnumerable<ListUsableWorkstationsResponse, Workstation> ListUsableWorkstations(ListUsableWorkstationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUsableWorkstationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUsableWorkstationsRequest, ListUsableWorkstationsResponse, Workstation>(_callListUsableWorkstations, request, callSettings);
        }

        /// <summary>
        /// Returns all workstations using the specified workstation configuration
        /// on which the caller has the "workstations.workstations.use" permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workstation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUsableWorkstationsResponse, Workstation> ListUsableWorkstationsAsync(ListUsableWorkstationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUsableWorkstationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUsableWorkstationsRequest, ListUsableWorkstationsResponse, Workstation>(_callListUsableWorkstations, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateWorkstation</c>.</summary>
        public override lro::OperationsClient CreateWorkstationOperationsClient { get; }

        /// <summary>
        /// Creates a new workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Workstation, OperationMetadata> CreateWorkstation(CreateWorkstationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkstationRequest(ref request, ref callSettings);
            return new lro::Operation<Workstation, OperationMetadata>(_callCreateWorkstation.Sync(request, callSettings), CreateWorkstationOperationsClient);
        }

        /// <summary>
        /// Creates a new workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Workstation, OperationMetadata>> CreateWorkstationAsync(CreateWorkstationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkstationRequest(ref request, ref callSettings);
            return new lro::Operation<Workstation, OperationMetadata>(await _callCreateWorkstation.Async(request, callSettings).ConfigureAwait(false), CreateWorkstationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateWorkstation</c>.</summary>
        public override lro::OperationsClient UpdateWorkstationOperationsClient { get; }

        /// <summary>
        /// Updates an existing workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Workstation, OperationMetadata> UpdateWorkstation(UpdateWorkstationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkstationRequest(ref request, ref callSettings);
            return new lro::Operation<Workstation, OperationMetadata>(_callUpdateWorkstation.Sync(request, callSettings), UpdateWorkstationOperationsClient);
        }

        /// <summary>
        /// Updates an existing workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Workstation, OperationMetadata>> UpdateWorkstationAsync(UpdateWorkstationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkstationRequest(ref request, ref callSettings);
            return new lro::Operation<Workstation, OperationMetadata>(await _callUpdateWorkstation.Async(request, callSettings).ConfigureAwait(false), UpdateWorkstationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteWorkstation</c>.</summary>
        public override lro::OperationsClient DeleteWorkstationOperationsClient { get; }

        /// <summary>
        /// Deletes the specified workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Workstation, OperationMetadata> DeleteWorkstation(DeleteWorkstationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkstationRequest(ref request, ref callSettings);
            return new lro::Operation<Workstation, OperationMetadata>(_callDeleteWorkstation.Sync(request, callSettings), DeleteWorkstationOperationsClient);
        }

        /// <summary>
        /// Deletes the specified workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Workstation, OperationMetadata>> DeleteWorkstationAsync(DeleteWorkstationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkstationRequest(ref request, ref callSettings);
            return new lro::Operation<Workstation, OperationMetadata>(await _callDeleteWorkstation.Async(request, callSettings).ConfigureAwait(false), DeleteWorkstationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartWorkstation</c>.</summary>
        public override lro::OperationsClient StartWorkstationOperationsClient { get; }

        /// <summary>
        /// Starts running a workstation so that users can connect to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Workstation, OperationMetadata> StartWorkstation(StartWorkstationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartWorkstationRequest(ref request, ref callSettings);
            return new lro::Operation<Workstation, OperationMetadata>(_callStartWorkstation.Sync(request, callSettings), StartWorkstationOperationsClient);
        }

        /// <summary>
        /// Starts running a workstation so that users can connect to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Workstation, OperationMetadata>> StartWorkstationAsync(StartWorkstationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartWorkstationRequest(ref request, ref callSettings);
            return new lro::Operation<Workstation, OperationMetadata>(await _callStartWorkstation.Async(request, callSettings).ConfigureAwait(false), StartWorkstationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopWorkstation</c>.</summary>
        public override lro::OperationsClient StopWorkstationOperationsClient { get; }

        /// <summary>
        /// Stops running a workstation, reducing costs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Workstation, OperationMetadata> StopWorkstation(StopWorkstationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopWorkstationRequest(ref request, ref callSettings);
            return new lro::Operation<Workstation, OperationMetadata>(_callStopWorkstation.Sync(request, callSettings), StopWorkstationOperationsClient);
        }

        /// <summary>
        /// Stops running a workstation, reducing costs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Workstation, OperationMetadata>> StopWorkstationAsync(StopWorkstationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopWorkstationRequest(ref request, ref callSettings);
            return new lro::Operation<Workstation, OperationMetadata>(await _callStopWorkstation.Async(request, callSettings).ConfigureAwait(false), StopWorkstationOperationsClient);
        }

        /// <summary>
        /// Returns a short-lived credential that can be used to send authenticated and
        /// authorized traffic to a workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateAccessTokenResponse GenerateAccessToken(GenerateAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAccessTokenRequest(ref request, ref callSettings);
            return _callGenerateAccessToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a short-lived credential that can be used to send authenticated and
        /// authorized traffic to a workstation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(GenerateAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAccessTokenRequest(ref request, ref callSettings);
            return _callGenerateAccessToken.Async(request, callSettings);
        }
    }

    public partial class ListWorkstationClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkstationConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUsableWorkstationConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkstationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUsableWorkstationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkstationClustersResponse : gaxgrpc::IPageResponse<WorkstationCluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<WorkstationCluster> GetEnumerator() => WorkstationClusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListWorkstationConfigsResponse : gaxgrpc::IPageResponse<WorkstationConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<WorkstationConfig> GetEnumerator() => WorkstationConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUsableWorkstationConfigsResponse : gaxgrpc::IPageResponse<WorkstationConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<WorkstationConfig> GetEnumerator() => WorkstationConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListWorkstationsResponse : gaxgrpc::IPageResponse<Workstation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Workstation> GetEnumerator() => Workstations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUsableWorkstationsResponse : gaxgrpc::IPageResponse<Workstation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Workstation> GetEnumerator() => Workstations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Workstations
    {
        public partial class WorkstationsClient
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

    public static partial class Workstations
    {
        public partial class WorkstationsClient
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
