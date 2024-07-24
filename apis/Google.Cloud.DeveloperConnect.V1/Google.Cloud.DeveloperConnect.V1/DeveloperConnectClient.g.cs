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

namespace Google.Cloud.DeveloperConnect.V1
{
    /// <summary>Settings for <see cref="DeveloperConnectClient"/> instances.</summary>
    public sealed partial class DeveloperConnectSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DeveloperConnectSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DeveloperConnectSettings"/>.</returns>
        public static DeveloperConnectSettings GetDefault() => new DeveloperConnectSettings();

        /// <summary>Constructs a new <see cref="DeveloperConnectSettings"/> object with default settings.</summary>
        public DeveloperConnectSettings()
        {
        }

        private DeveloperConnectSettings(DeveloperConnectSettings existing) : base(existing)
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
            CreateGitRepositoryLinkSettings = existing.CreateGitRepositoryLinkSettings;
            CreateGitRepositoryLinkOperationsSettings = existing.CreateGitRepositoryLinkOperationsSettings.Clone();
            DeleteGitRepositoryLinkSettings = existing.DeleteGitRepositoryLinkSettings;
            DeleteGitRepositoryLinkOperationsSettings = existing.DeleteGitRepositoryLinkOperationsSettings.Clone();
            ListGitRepositoryLinksSettings = existing.ListGitRepositoryLinksSettings;
            GetGitRepositoryLinkSettings = existing.GetGitRepositoryLinkSettings;
            FetchReadWriteTokenSettings = existing.FetchReadWriteTokenSettings;
            FetchReadTokenSettings = existing.FetchReadTokenSettings;
            FetchLinkableGitRepositoriesSettings = existing.FetchLinkableGitRepositoriesSettings;
            FetchGitHubInstallationsSettings = existing.FetchGitHubInstallationsSettings;
            FetchGitRefsSettings = existing.FetchGitRefsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DeveloperConnectSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperConnectClient.ListConnections</c> and <c>DeveloperConnectClient.ListConnectionsAsync</c>.
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
        /// <c>DeveloperConnectClient.GetConnection</c> and <c>DeveloperConnectClient.GetConnectionAsync</c>.
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
        /// <c>DeveloperConnectClient.CreateConnection</c> and <c>DeveloperConnectClient.CreateConnectionAsync</c>.
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
        public gaxgrpc::CallSettings CreateConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DeveloperConnectClient.CreateConnection</c> and
        /// <c>DeveloperConnectClient.CreateConnectionAsync</c>.
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
        /// <c>DeveloperConnectClient.UpdateConnection</c> and <c>DeveloperConnectClient.UpdateConnectionAsync</c>.
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
        public gaxgrpc::CallSettings UpdateConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DeveloperConnectClient.UpdateConnection</c> and
        /// <c>DeveloperConnectClient.UpdateConnectionAsync</c>.
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
        /// <c>DeveloperConnectClient.DeleteConnection</c> and <c>DeveloperConnectClient.DeleteConnectionAsync</c>.
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
        public gaxgrpc::CallSettings DeleteConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DeveloperConnectClient.DeleteConnection</c> and
        /// <c>DeveloperConnectClient.DeleteConnectionAsync</c>.
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
        /// <c>DeveloperConnectClient.CreateGitRepositoryLink</c> and
        /// <c>DeveloperConnectClient.CreateGitRepositoryLinkAsync</c>.
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
        public gaxgrpc::CallSettings CreateGitRepositoryLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DeveloperConnectClient.CreateGitRepositoryLink</c> and
        /// <c>DeveloperConnectClient.CreateGitRepositoryLinkAsync</c>.
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
        public lro::OperationsSettings CreateGitRepositoryLinkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperConnectClient.DeleteGitRepositoryLink</c> and
        /// <c>DeveloperConnectClient.DeleteGitRepositoryLinkAsync</c>.
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
        public gaxgrpc::CallSettings DeleteGitRepositoryLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DeveloperConnectClient.DeleteGitRepositoryLink</c> and
        /// <c>DeveloperConnectClient.DeleteGitRepositoryLinkAsync</c>.
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
        public lro::OperationsSettings DeleteGitRepositoryLinkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperConnectClient.ListGitRepositoryLinks</c> and
        /// <c>DeveloperConnectClient.ListGitRepositoryLinksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGitRepositoryLinksSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperConnectClient.GetGitRepositoryLink</c> and <c>DeveloperConnectClient.GetGitRepositoryLinkAsync</c>
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
        public gaxgrpc::CallSettings GetGitRepositoryLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperConnectClient.FetchReadWriteToken</c> and <c>DeveloperConnectClient.FetchReadWriteTokenAsync</c>
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
        public gaxgrpc::CallSettings FetchReadWriteTokenSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperConnectClient.FetchReadToken</c> and <c>DeveloperConnectClient.FetchReadTokenAsync</c>.
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
        public gaxgrpc::CallSettings FetchReadTokenSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperConnectClient.FetchLinkableGitRepositories</c> and
        /// <c>DeveloperConnectClient.FetchLinkableGitRepositoriesAsync</c>.
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
        public gaxgrpc::CallSettings FetchLinkableGitRepositoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperConnectClient.FetchGitHubInstallations</c> and
        /// <c>DeveloperConnectClient.FetchGitHubInstallationsAsync</c>.
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
        public gaxgrpc::CallSettings FetchGitHubInstallationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperConnectClient.FetchGitRefs</c> and <c>DeveloperConnectClient.FetchGitRefsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchGitRefsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DeveloperConnectSettings"/> object.</returns>
        public DeveloperConnectSettings Clone() => new DeveloperConnectSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DeveloperConnectClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DeveloperConnectClientBuilder : gaxgrpc::ClientBuilderBase<DeveloperConnectClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DeveloperConnectSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DeveloperConnectClientBuilder() : base(DeveloperConnectClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DeveloperConnectClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DeveloperConnectClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DeveloperConnectClient Build()
        {
            DeveloperConnectClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DeveloperConnectClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DeveloperConnectClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DeveloperConnectClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DeveloperConnectClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DeveloperConnectClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DeveloperConnectClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DeveloperConnectClient.ChannelPool;
    }

    /// <summary>DeveloperConnect client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class DeveloperConnectClient
    {
        /// <summary>
        /// The default endpoint for the DeveloperConnect service, which is a host of "developerconnect.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "developerconnect.googleapis.com:443";

        /// <summary>The default DeveloperConnect scopes.</summary>
        /// <remarks>
        /// The default DeveloperConnect scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DeveloperConnect.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DeveloperConnectClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DeveloperConnectClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DeveloperConnectClient"/>.</returns>
        public static stt::Task<DeveloperConnectClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DeveloperConnectClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DeveloperConnectClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DeveloperConnectClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DeveloperConnectClient"/>.</returns>
        public static DeveloperConnectClient Create() => new DeveloperConnectClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DeveloperConnectClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DeveloperConnectSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DeveloperConnectClient"/>.</returns>
        internal static DeveloperConnectClient Create(grpccore::CallInvoker callInvoker, DeveloperConnectSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DeveloperConnect.DeveloperConnectClient grpcClient = new DeveloperConnect.DeveloperConnectClient(callInvoker);
            return new DeveloperConnectClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DeveloperConnect client</summary>
        public virtual DeveloperConnect.DeveloperConnectClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

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
        /// Required. Parent value for ListConnectionsRequest
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
        /// Required. Parent value for ListConnectionsRequest
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
        /// Required. Parent value for ListConnectionsRequest
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
        /// Required. Parent value for ListConnectionsRequest
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
        /// Required. Name of the resource
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
        /// Required. Name of the resource
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
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
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
        /// Required. Name of the resource
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
        /// Required. Name of the resource
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
        /// Required. Value for parent.
        /// </param>
        /// <param name="connection">
        /// Required. The resource being created
        /// </param>
        /// <param name="connectionId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// connection_id from the method_signature of Create RPC
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
        /// Required. Value for parent.
        /// </param>
        /// <param name="connection">
        /// Required. The resource being created
        /// </param>
        /// <param name="connectionId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// connection_id from the method_signature of Create RPC
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
        /// Required. Value for parent.
        /// </param>
        /// <param name="connection">
        /// Required. The resource being created
        /// </param>
        /// <param name="connectionId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// connection_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> CreateConnectionAsync(string parent, Connection connection, string connectionId, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(parent, connection, connectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Connection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="connection">
        /// Required. The resource being created
        /// </param>
        /// <param name="connectionId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// connection_id from the method_signature of Create RPC
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
        /// Required. Value for parent.
        /// </param>
        /// <param name="connection">
        /// Required. The resource being created
        /// </param>
        /// <param name="connectionId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// connection_id from the method_signature of Create RPC
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
        /// Required. Value for parent.
        /// </param>
        /// <param name="connection">
        /// Required. The resource being created
        /// </param>
        /// <param name="connectionId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// connection_id from the method_signature of Create RPC
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
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Connection resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connection, OperationMetadata> UpdateConnection(Connection connection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnection(new UpdateConnectionRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Connection.
        /// </summary>
        /// <param name="connection">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Connection resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connection, OperationMetadata>> UpdateConnectionAsync(Connection connection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectionAsync(new UpdateConnectionRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Connection.
        /// </summary>
        /// <param name="connection">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Connection resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
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
        /// Required. Name of the resource
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
        /// Required. Name of the resource
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
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
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
        /// Required. Name of the resource
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
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionAsync(ConnectionName name, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a GitRepositoryLink. Upon linking a Git Repository, Developer
        /// Connect will configure the Git Repository to send webhook events to
        /// Developer Connect. Connections that use Firebase GitHub Application will
        /// have events forwarded to the Firebase service. All other Connections will
        /// have events forwarded to Cloud Build.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GitRepositoryLink, OperationMetadata> CreateGitRepositoryLink(CreateGitRepositoryLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a GitRepositoryLink. Upon linking a Git Repository, Developer
        /// Connect will configure the Git Repository to send webhook events to
        /// Developer Connect. Connections that use Firebase GitHub Application will
        /// have events forwarded to the Firebase service. All other Connections will
        /// have events forwarded to Cloud Build.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GitRepositoryLink, OperationMetadata>> CreateGitRepositoryLinkAsync(CreateGitRepositoryLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a GitRepositoryLink. Upon linking a Git Repository, Developer
        /// Connect will configure the Git Repository to send webhook events to
        /// Developer Connect. Connections that use Firebase GitHub Application will
        /// have events forwarded to the Firebase service. All other Connections will
        /// have events forwarded to Cloud Build.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GitRepositoryLink, OperationMetadata>> CreateGitRepositoryLinkAsync(CreateGitRepositoryLinkRequest request, st::CancellationToken cancellationToken) =>
            CreateGitRepositoryLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGitRepositoryLink</c>.</summary>
        public virtual lro::OperationsClient CreateGitRepositoryLinkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGitRepositoryLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GitRepositoryLink, OperationMetadata> PollOnceCreateGitRepositoryLink(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GitRepositoryLink, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGitRepositoryLinkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGitRepositoryLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GitRepositoryLink, OperationMetadata>> PollOnceCreateGitRepositoryLinkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GitRepositoryLink, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGitRepositoryLinkOperationsClient, callSettings);

        /// <summary>
        /// Creates a GitRepositoryLink. Upon linking a Git Repository, Developer
        /// Connect will configure the Git Repository to send webhook events to
        /// Developer Connect. Connections that use Firebase GitHub Application will
        /// have events forwarded to the Firebase service. All other Connections will
        /// have events forwarded to Cloud Build.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="gitRepositoryLink">
        /// Required. The resource being created
        /// </param>
        /// <param name="gitRepositoryLinkId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This ID should be unique in
        /// the connection. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GitRepositoryLink, OperationMetadata> CreateGitRepositoryLink(string parent, GitRepositoryLink gitRepositoryLink, string gitRepositoryLinkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGitRepositoryLink(new CreateGitRepositoryLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GitRepositoryLink = gax::GaxPreconditions.CheckNotNull(gitRepositoryLink, nameof(gitRepositoryLink)),
                GitRepositoryLinkId = gax::GaxPreconditions.CheckNotNullOrEmpty(gitRepositoryLinkId, nameof(gitRepositoryLinkId)),
            }, callSettings);

        /// <summary>
        /// Creates a GitRepositoryLink. Upon linking a Git Repository, Developer
        /// Connect will configure the Git Repository to send webhook events to
        /// Developer Connect. Connections that use Firebase GitHub Application will
        /// have events forwarded to the Firebase service. All other Connections will
        /// have events forwarded to Cloud Build.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="gitRepositoryLink">
        /// Required. The resource being created
        /// </param>
        /// <param name="gitRepositoryLinkId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This ID should be unique in
        /// the connection. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GitRepositoryLink, OperationMetadata>> CreateGitRepositoryLinkAsync(string parent, GitRepositoryLink gitRepositoryLink, string gitRepositoryLinkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGitRepositoryLinkAsync(new CreateGitRepositoryLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GitRepositoryLink = gax::GaxPreconditions.CheckNotNull(gitRepositoryLink, nameof(gitRepositoryLink)),
                GitRepositoryLinkId = gax::GaxPreconditions.CheckNotNullOrEmpty(gitRepositoryLinkId, nameof(gitRepositoryLinkId)),
            }, callSettings);

        /// <summary>
        /// Creates a GitRepositoryLink. Upon linking a Git Repository, Developer
        /// Connect will configure the Git Repository to send webhook events to
        /// Developer Connect. Connections that use Firebase GitHub Application will
        /// have events forwarded to the Firebase service. All other Connections will
        /// have events forwarded to Cloud Build.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="gitRepositoryLink">
        /// Required. The resource being created
        /// </param>
        /// <param name="gitRepositoryLinkId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This ID should be unique in
        /// the connection. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GitRepositoryLink, OperationMetadata>> CreateGitRepositoryLinkAsync(string parent, GitRepositoryLink gitRepositoryLink, string gitRepositoryLinkId, st::CancellationToken cancellationToken) =>
            CreateGitRepositoryLinkAsync(parent, gitRepositoryLink, gitRepositoryLinkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a GitRepositoryLink. Upon linking a Git Repository, Developer
        /// Connect will configure the Git Repository to send webhook events to
        /// Developer Connect. Connections that use Firebase GitHub Application will
        /// have events forwarded to the Firebase service. All other Connections will
        /// have events forwarded to Cloud Build.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="gitRepositoryLink">
        /// Required. The resource being created
        /// </param>
        /// <param name="gitRepositoryLinkId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This ID should be unique in
        /// the connection. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GitRepositoryLink, OperationMetadata> CreateGitRepositoryLink(ConnectionName parent, GitRepositoryLink gitRepositoryLink, string gitRepositoryLinkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGitRepositoryLink(new CreateGitRepositoryLinkRequest
            {
                ParentAsConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GitRepositoryLink = gax::GaxPreconditions.CheckNotNull(gitRepositoryLink, nameof(gitRepositoryLink)),
                GitRepositoryLinkId = gax::GaxPreconditions.CheckNotNullOrEmpty(gitRepositoryLinkId, nameof(gitRepositoryLinkId)),
            }, callSettings);

        /// <summary>
        /// Creates a GitRepositoryLink. Upon linking a Git Repository, Developer
        /// Connect will configure the Git Repository to send webhook events to
        /// Developer Connect. Connections that use Firebase GitHub Application will
        /// have events forwarded to the Firebase service. All other Connections will
        /// have events forwarded to Cloud Build.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="gitRepositoryLink">
        /// Required. The resource being created
        /// </param>
        /// <param name="gitRepositoryLinkId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This ID should be unique in
        /// the connection. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GitRepositoryLink, OperationMetadata>> CreateGitRepositoryLinkAsync(ConnectionName parent, GitRepositoryLink gitRepositoryLink, string gitRepositoryLinkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGitRepositoryLinkAsync(new CreateGitRepositoryLinkRequest
            {
                ParentAsConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GitRepositoryLink = gax::GaxPreconditions.CheckNotNull(gitRepositoryLink, nameof(gitRepositoryLink)),
                GitRepositoryLinkId = gax::GaxPreconditions.CheckNotNullOrEmpty(gitRepositoryLinkId, nameof(gitRepositoryLinkId)),
            }, callSettings);

        /// <summary>
        /// Creates a GitRepositoryLink. Upon linking a Git Repository, Developer
        /// Connect will configure the Git Repository to send webhook events to
        /// Developer Connect. Connections that use Firebase GitHub Application will
        /// have events forwarded to the Firebase service. All other Connections will
        /// have events forwarded to Cloud Build.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="gitRepositoryLink">
        /// Required. The resource being created
        /// </param>
        /// <param name="gitRepositoryLinkId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name. This ID should be unique in
        /// the connection. Allows alphanumeric characters and any of
        /// -._~%!$&amp;'()*+,;=@.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GitRepositoryLink, OperationMetadata>> CreateGitRepositoryLinkAsync(ConnectionName parent, GitRepositoryLink gitRepositoryLink, string gitRepositoryLinkId, st::CancellationToken cancellationToken) =>
            CreateGitRepositoryLinkAsync(parent, gitRepositoryLink, gitRepositoryLinkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single GitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGitRepositoryLink(DeleteGitRepositoryLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single GitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGitRepositoryLinkAsync(DeleteGitRepositoryLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single GitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGitRepositoryLinkAsync(DeleteGitRepositoryLinkRequest request, st::CancellationToken cancellationToken) =>
            DeleteGitRepositoryLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGitRepositoryLink</c>.</summary>
        public virtual lro::OperationsClient DeleteGitRepositoryLinkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGitRepositoryLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteGitRepositoryLink(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGitRepositoryLinkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGitRepositoryLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteGitRepositoryLinkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGitRepositoryLinkOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single GitRepositoryLink.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGitRepositoryLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGitRepositoryLink(new DeleteGitRepositoryLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GitRepositoryLink.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGitRepositoryLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGitRepositoryLinkAsync(new DeleteGitRepositoryLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GitRepositoryLink.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGitRepositoryLinkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGitRepositoryLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single GitRepositoryLink.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGitRepositoryLink(GitRepositoryLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGitRepositoryLink(new DeleteGitRepositoryLinkRequest
            {
                GitRepositoryLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GitRepositoryLink.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGitRepositoryLinkAsync(GitRepositoryLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGitRepositoryLinkAsync(new DeleteGitRepositoryLinkRequest
            {
                GitRepositoryLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single GitRepositoryLink.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGitRepositoryLinkAsync(GitRepositoryLinkName name, st::CancellationToken cancellationToken) =>
            DeleteGitRepositoryLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists GitRepositoryLinks in a given project, location, and connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GitRepositoryLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> ListGitRepositoryLinks(ListGitRepositoryLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GitRepositoryLinks in a given project, location, and connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GitRepositoryLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> ListGitRepositoryLinksAsync(ListGitRepositoryLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GitRepositoryLinks in a given project, location, and connection.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListGitRepositoryLinksRequest
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
        /// <returns>A pageable sequence of <see cref="GitRepositoryLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> ListGitRepositoryLinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGitRepositoryLinksRequest request = new ListGitRepositoryLinksRequest
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
            return ListGitRepositoryLinks(request, callSettings);
        }

        /// <summary>
        /// Lists GitRepositoryLinks in a given project, location, and connection.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListGitRepositoryLinksRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="GitRepositoryLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> ListGitRepositoryLinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGitRepositoryLinksRequest request = new ListGitRepositoryLinksRequest
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
            return ListGitRepositoryLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists GitRepositoryLinks in a given project, location, and connection.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListGitRepositoryLinksRequest
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
        /// <returns>A pageable sequence of <see cref="GitRepositoryLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> ListGitRepositoryLinks(ConnectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGitRepositoryLinksRequest request = new ListGitRepositoryLinksRequest
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
            return ListGitRepositoryLinks(request, callSettings);
        }

        /// <summary>
        /// Lists GitRepositoryLinks in a given project, location, and connection.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListGitRepositoryLinksRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="GitRepositoryLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> ListGitRepositoryLinksAsync(ConnectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGitRepositoryLinksRequest request = new ListGitRepositoryLinksRequest
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
            return ListGitRepositoryLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single GitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GitRepositoryLink GetGitRepositoryLink(GetGitRepositoryLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single GitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GitRepositoryLink> GetGitRepositoryLinkAsync(GetGitRepositoryLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single GitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GitRepositoryLink> GetGitRepositoryLinkAsync(GetGitRepositoryLinkRequest request, st::CancellationToken cancellationToken) =>
            GetGitRepositoryLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single GitRepositoryLink.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GitRepositoryLink GetGitRepositoryLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGitRepositoryLink(new GetGitRepositoryLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GitRepositoryLink.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GitRepositoryLink> GetGitRepositoryLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGitRepositoryLinkAsync(new GetGitRepositoryLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GitRepositoryLink.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GitRepositoryLink> GetGitRepositoryLinkAsync(string name, st::CancellationToken cancellationToken) =>
            GetGitRepositoryLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single GitRepositoryLink.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GitRepositoryLink GetGitRepositoryLink(GitRepositoryLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGitRepositoryLink(new GetGitRepositoryLinkRequest
            {
                GitRepositoryLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GitRepositoryLink.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GitRepositoryLink> GetGitRepositoryLinkAsync(GitRepositoryLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGitRepositoryLinkAsync(new GetGitRepositoryLinkRequest
            {
                GitRepositoryLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single GitRepositoryLink.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GitRepositoryLink> GetGitRepositoryLinkAsync(GitRepositoryLinkName name, st::CancellationToken cancellationToken) =>
            GetGitRepositoryLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches read/write token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchReadWriteTokenResponse FetchReadWriteToken(FetchReadWriteTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches read/write token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(FetchReadWriteTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches read/write token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(FetchReadWriteTokenRequest request, st::CancellationToken cancellationToken) =>
            FetchReadWriteTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches read/write token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of the gitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchReadWriteTokenResponse FetchReadWriteToken(string gitRepositoryLink, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadWriteToken(new FetchReadWriteTokenRequest
            {
                GitRepositoryLink = gax::GaxPreconditions.CheckNotNullOrEmpty(gitRepositoryLink, nameof(gitRepositoryLink)),
            }, callSettings);

        /// <summary>
        /// Fetches read/write token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of the gitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(string gitRepositoryLink, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadWriteTokenAsync(new FetchReadWriteTokenRequest
            {
                GitRepositoryLink = gax::GaxPreconditions.CheckNotNullOrEmpty(gitRepositoryLink, nameof(gitRepositoryLink)),
            }, callSettings);

        /// <summary>
        /// Fetches read/write token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of the gitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(string gitRepositoryLink, st::CancellationToken cancellationToken) =>
            FetchReadWriteTokenAsync(gitRepositoryLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches read/write token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of the gitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchReadWriteTokenResponse FetchReadWriteToken(GitRepositoryLinkName gitRepositoryLink, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadWriteToken(new FetchReadWriteTokenRequest
            {
                GitRepositoryLinkAsGitRepositoryLinkName = gax::GaxPreconditions.CheckNotNull(gitRepositoryLink, nameof(gitRepositoryLink)),
            }, callSettings);

        /// <summary>
        /// Fetches read/write token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of the gitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(GitRepositoryLinkName gitRepositoryLink, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadWriteTokenAsync(new FetchReadWriteTokenRequest
            {
                GitRepositoryLinkAsGitRepositoryLinkName = gax::GaxPreconditions.CheckNotNull(gitRepositoryLink, nameof(gitRepositoryLink)),
            }, callSettings);

        /// <summary>
        /// Fetches read/write token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of the gitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(GitRepositoryLinkName gitRepositoryLink, st::CancellationToken cancellationToken) =>
            FetchReadWriteTokenAsync(gitRepositoryLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches read token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchReadTokenResponse FetchReadToken(FetchReadTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches read token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(FetchReadTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches read token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(FetchReadTokenRequest request, st::CancellationToken cancellationToken) =>
            FetchReadTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches read token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of the gitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchReadTokenResponse FetchReadToken(string gitRepositoryLink, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadToken(new FetchReadTokenRequest
            {
                GitRepositoryLink = gax::GaxPreconditions.CheckNotNullOrEmpty(gitRepositoryLink, nameof(gitRepositoryLink)),
            }, callSettings);

        /// <summary>
        /// Fetches read token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of the gitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(string gitRepositoryLink, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadTokenAsync(new FetchReadTokenRequest
            {
                GitRepositoryLink = gax::GaxPreconditions.CheckNotNullOrEmpty(gitRepositoryLink, nameof(gitRepositoryLink)),
            }, callSettings);

        /// <summary>
        /// Fetches read token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of the gitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(string gitRepositoryLink, st::CancellationToken cancellationToken) =>
            FetchReadTokenAsync(gitRepositoryLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches read token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of the gitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchReadTokenResponse FetchReadToken(GitRepositoryLinkName gitRepositoryLink, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadToken(new FetchReadTokenRequest
            {
                GitRepositoryLinkAsGitRepositoryLinkName = gax::GaxPreconditions.CheckNotNull(gitRepositoryLink, nameof(gitRepositoryLink)),
            }, callSettings);

        /// <summary>
        /// Fetches read token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of the gitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(GitRepositoryLinkName gitRepositoryLink, gaxgrpc::CallSettings callSettings = null) =>
            FetchReadTokenAsync(new FetchReadTokenRequest
            {
                GitRepositoryLinkAsGitRepositoryLinkName = gax::GaxPreconditions.CheckNotNull(gitRepositoryLink, nameof(gitRepositoryLink)),
            }, callSettings);

        /// <summary>
        /// Fetches read token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of the gitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(GitRepositoryLinkName gitRepositoryLink, st::CancellationToken cancellationToken) =>
            FetchReadTokenAsync(gitRepositoryLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// FetchLinkableGitRepositories returns a list of git repositories from an SCM
        /// that are available to be added to a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LinkableGitRepository"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> FetchLinkableGitRepositories(FetchLinkableGitRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// FetchLinkableGitRepositories returns a list of git repositories from an SCM
        /// that are available to be added to a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LinkableGitRepository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> FetchLinkableGitRepositoriesAsync(FetchLinkableGitRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// FetchLinkableGitRepositories returns a list of git repositories from an SCM
        /// that are available to be added to a Connection.
        /// </summary>
        /// <param name="connection">
        /// Required. The name of the Connection.
        /// Format: `projects/*/locations/*/connections/*`.
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
        /// <returns>A pageable sequence of <see cref="LinkableGitRepository"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> FetchLinkableGitRepositories(string connection, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchLinkableGitRepositoriesRequest request = new FetchLinkableGitRepositoriesRequest
            {
                Connection = gax::GaxPreconditions.CheckNotNullOrEmpty(connection, nameof(connection)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchLinkableGitRepositories(request, callSettings);
        }

        /// <summary>
        /// FetchLinkableGitRepositories returns a list of git repositories from an SCM
        /// that are available to be added to a Connection.
        /// </summary>
        /// <param name="connection">
        /// Required. The name of the Connection.
        /// Format: `projects/*/locations/*/connections/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LinkableGitRepository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> FetchLinkableGitRepositoriesAsync(string connection, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchLinkableGitRepositoriesRequest request = new FetchLinkableGitRepositoriesRequest
            {
                Connection = gax::GaxPreconditions.CheckNotNullOrEmpty(connection, nameof(connection)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchLinkableGitRepositoriesAsync(request, callSettings);
        }

        /// <summary>
        /// FetchLinkableGitRepositories returns a list of git repositories from an SCM
        /// that are available to be added to a Connection.
        /// </summary>
        /// <param name="connection">
        /// Required. The name of the Connection.
        /// Format: `projects/*/locations/*/connections/*`.
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
        /// <returns>A pageable sequence of <see cref="LinkableGitRepository"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> FetchLinkableGitRepositories(ConnectionName connection, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchLinkableGitRepositoriesRequest request = new FetchLinkableGitRepositoriesRequest
            {
                ConnectionAsConnectionName = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchLinkableGitRepositories(request, callSettings);
        }

        /// <summary>
        /// FetchLinkableGitRepositories returns a list of git repositories from an SCM
        /// that are available to be added to a Connection.
        /// </summary>
        /// <param name="connection">
        /// Required. The name of the Connection.
        /// Format: `projects/*/locations/*/connections/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LinkableGitRepository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> FetchLinkableGitRepositoriesAsync(ConnectionName connection, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchLinkableGitRepositoriesRequest request = new FetchLinkableGitRepositoriesRequest
            {
                ConnectionAsConnectionName = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchLinkableGitRepositoriesAsync(request, callSettings);
        }

        /// <summary>
        /// FetchGitHubInstallations returns the list of GitHub Installations that
        /// are available to be added to a Connection.
        /// For github.com, only installations accessible to the authorizer token
        /// are returned. For GitHub Enterprise, all installations are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchGitHubInstallationsResponse FetchGitHubInstallations(FetchGitHubInstallationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// FetchGitHubInstallations returns the list of GitHub Installations that
        /// are available to be added to a Connection.
        /// For github.com, only installations accessible to the authorizer token
        /// are returned. For GitHub Enterprise, all installations are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitHubInstallationsResponse> FetchGitHubInstallationsAsync(FetchGitHubInstallationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// FetchGitHubInstallations returns the list of GitHub Installations that
        /// are available to be added to a Connection.
        /// For github.com, only installations accessible to the authorizer token
        /// are returned. For GitHub Enterprise, all installations are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitHubInstallationsResponse> FetchGitHubInstallationsAsync(FetchGitHubInstallationsRequest request, st::CancellationToken cancellationToken) =>
            FetchGitHubInstallationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// FetchGitHubInstallations returns the list of GitHub Installations that
        /// are available to be added to a Connection.
        /// For github.com, only installations accessible to the authorizer token
        /// are returned. For GitHub Enterprise, all installations are returned.
        /// </summary>
        /// <param name="connection">
        /// Required. The resource name of the connection in the format
        /// `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchGitHubInstallationsResponse FetchGitHubInstallations(string connection, gaxgrpc::CallSettings callSettings = null) =>
            FetchGitHubInstallations(new FetchGitHubInstallationsRequest
            {
                Connection = gax::GaxPreconditions.CheckNotNullOrEmpty(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// FetchGitHubInstallations returns the list of GitHub Installations that
        /// are available to be added to a Connection.
        /// For github.com, only installations accessible to the authorizer token
        /// are returned. For GitHub Enterprise, all installations are returned.
        /// </summary>
        /// <param name="connection">
        /// Required. The resource name of the connection in the format
        /// `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitHubInstallationsResponse> FetchGitHubInstallationsAsync(string connection, gaxgrpc::CallSettings callSettings = null) =>
            FetchGitHubInstallationsAsync(new FetchGitHubInstallationsRequest
            {
                Connection = gax::GaxPreconditions.CheckNotNullOrEmpty(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// FetchGitHubInstallations returns the list of GitHub Installations that
        /// are available to be added to a Connection.
        /// For github.com, only installations accessible to the authorizer token
        /// are returned. For GitHub Enterprise, all installations are returned.
        /// </summary>
        /// <param name="connection">
        /// Required. The resource name of the connection in the format
        /// `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitHubInstallationsResponse> FetchGitHubInstallationsAsync(string connection, st::CancellationToken cancellationToken) =>
            FetchGitHubInstallationsAsync(connection, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// FetchGitHubInstallations returns the list of GitHub Installations that
        /// are available to be added to a Connection.
        /// For github.com, only installations accessible to the authorizer token
        /// are returned. For GitHub Enterprise, all installations are returned.
        /// </summary>
        /// <param name="connection">
        /// Required. The resource name of the connection in the format
        /// `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchGitHubInstallationsResponse FetchGitHubInstallations(ConnectionName connection, gaxgrpc::CallSettings callSettings = null) =>
            FetchGitHubInstallations(new FetchGitHubInstallationsRequest
            {
                ConnectionAsConnectionName = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// FetchGitHubInstallations returns the list of GitHub Installations that
        /// are available to be added to a Connection.
        /// For github.com, only installations accessible to the authorizer token
        /// are returned. For GitHub Enterprise, all installations are returned.
        /// </summary>
        /// <param name="connection">
        /// Required. The resource name of the connection in the format
        /// `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitHubInstallationsResponse> FetchGitHubInstallationsAsync(ConnectionName connection, gaxgrpc::CallSettings callSettings = null) =>
            FetchGitHubInstallationsAsync(new FetchGitHubInstallationsRequest
            {
                ConnectionAsConnectionName = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// FetchGitHubInstallations returns the list of GitHub Installations that
        /// are available to be added to a Connection.
        /// For github.com, only installations accessible to the authorizer token
        /// are returned. For GitHub Enterprise, all installations are returned.
        /// </summary>
        /// <param name="connection">
        /// Required. The resource name of the connection in the format
        /// `projects/*/locations/*/connections/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitHubInstallationsResponse> FetchGitHubInstallationsAsync(ConnectionName connection, st::CancellationToken cancellationToken) =>
            FetchGitHubInstallationsAsync(connection, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchGitRefsResponse, string> FetchGitRefs(FetchGitRefsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchGitRefsResponse, string> FetchGitRefsAsync(FetchGitRefsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of GitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="refType">
        /// Required. Type of refs to fetch.
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchGitRefsResponse, string> FetchGitRefs(string gitRepositoryLink, FetchGitRefsRequest.Types.RefType refType, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchGitRefsRequest request = new FetchGitRefsRequest
            {
                GitRepositoryLink = gax::GaxPreconditions.CheckNotNullOrEmpty(gitRepositoryLink, nameof(gitRepositoryLink)),
                RefType = refType,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchGitRefs(request, callSettings);
        }

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of GitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="refType">
        /// Required. Type of refs to fetch.
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchGitRefsResponse, string> FetchGitRefsAsync(string gitRepositoryLink, FetchGitRefsRequest.Types.RefType refType, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchGitRefsRequest request = new FetchGitRefsRequest
            {
                GitRepositoryLink = gax::GaxPreconditions.CheckNotNullOrEmpty(gitRepositoryLink, nameof(gitRepositoryLink)),
                RefType = refType,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchGitRefsAsync(request, callSettings);
        }

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of GitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="refType">
        /// Required. Type of refs to fetch.
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchGitRefsResponse, string> FetchGitRefs(GitRepositoryLinkName gitRepositoryLink, FetchGitRefsRequest.Types.RefType refType, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchGitRefsRequest request = new FetchGitRefsRequest
            {
                GitRepositoryLinkAsGitRepositoryLinkName = gax::GaxPreconditions.CheckNotNull(gitRepositoryLink, nameof(gitRepositoryLink)),
                RefType = refType,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchGitRefs(request, callSettings);
        }

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="gitRepositoryLink">
        /// Required. The resource name of GitRepositoryLink in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </param>
        /// <param name="refType">
        /// Required. Type of refs to fetch.
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchGitRefsResponse, string> FetchGitRefsAsync(GitRepositoryLinkName gitRepositoryLink, FetchGitRefsRequest.Types.RefType refType, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchGitRefsRequest request = new FetchGitRefsRequest
            {
                GitRepositoryLinkAsGitRepositoryLinkName = gax::GaxPreconditions.CheckNotNull(gitRepositoryLink, nameof(gitRepositoryLink)),
                RefType = refType,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchGitRefsAsync(request, callSettings);
        }
    }

    /// <summary>DeveloperConnect client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class DeveloperConnectClientImpl : DeveloperConnectClient
    {
        private readonly gaxgrpc::ApiCall<ListConnectionsRequest, ListConnectionsResponse> _callListConnections;

        private readonly gaxgrpc::ApiCall<GetConnectionRequest, Connection> _callGetConnection;

        private readonly gaxgrpc::ApiCall<CreateConnectionRequest, lro::Operation> _callCreateConnection;

        private readonly gaxgrpc::ApiCall<UpdateConnectionRequest, lro::Operation> _callUpdateConnection;

        private readonly gaxgrpc::ApiCall<DeleteConnectionRequest, lro::Operation> _callDeleteConnection;

        private readonly gaxgrpc::ApiCall<CreateGitRepositoryLinkRequest, lro::Operation> _callCreateGitRepositoryLink;

        private readonly gaxgrpc::ApiCall<DeleteGitRepositoryLinkRequest, lro::Operation> _callDeleteGitRepositoryLink;

        private readonly gaxgrpc::ApiCall<ListGitRepositoryLinksRequest, ListGitRepositoryLinksResponse> _callListGitRepositoryLinks;

        private readonly gaxgrpc::ApiCall<GetGitRepositoryLinkRequest, GitRepositoryLink> _callGetGitRepositoryLink;

        private readonly gaxgrpc::ApiCall<FetchReadWriteTokenRequest, FetchReadWriteTokenResponse> _callFetchReadWriteToken;

        private readonly gaxgrpc::ApiCall<FetchReadTokenRequest, FetchReadTokenResponse> _callFetchReadToken;

        private readonly gaxgrpc::ApiCall<FetchLinkableGitRepositoriesRequest, FetchLinkableGitRepositoriesResponse> _callFetchLinkableGitRepositories;

        private readonly gaxgrpc::ApiCall<FetchGitHubInstallationsRequest, FetchGitHubInstallationsResponse> _callFetchGitHubInstallations;

        private readonly gaxgrpc::ApiCall<FetchGitRefsRequest, FetchGitRefsResponse> _callFetchGitRefs;

        /// <summary>
        /// Constructs a client wrapper for the DeveloperConnect service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DeveloperConnectSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DeveloperConnectClientImpl(DeveloperConnect.DeveloperConnectClient grpcClient, DeveloperConnectSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DeveloperConnectSettings effectiveSettings = settings ?? DeveloperConnectSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConnectionOperationsSettings, logger);
            UpdateConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateConnectionOperationsSettings, logger);
            DeleteConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConnectionOperationsSettings, logger);
            CreateGitRepositoryLinkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGitRepositoryLinkOperationsSettings, logger);
            DeleteGitRepositoryLinkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGitRepositoryLinkOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
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
            _callCreateGitRepositoryLink = clientHelper.BuildApiCall<CreateGitRepositoryLinkRequest, lro::Operation>("CreateGitRepositoryLink", grpcClient.CreateGitRepositoryLinkAsync, grpcClient.CreateGitRepositoryLink, effectiveSettings.CreateGitRepositoryLinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGitRepositoryLink);
            Modify_CreateGitRepositoryLinkApiCall(ref _callCreateGitRepositoryLink);
            _callDeleteGitRepositoryLink = clientHelper.BuildApiCall<DeleteGitRepositoryLinkRequest, lro::Operation>("DeleteGitRepositoryLink", grpcClient.DeleteGitRepositoryLinkAsync, grpcClient.DeleteGitRepositoryLink, effectiveSettings.DeleteGitRepositoryLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGitRepositoryLink);
            Modify_DeleteGitRepositoryLinkApiCall(ref _callDeleteGitRepositoryLink);
            _callListGitRepositoryLinks = clientHelper.BuildApiCall<ListGitRepositoryLinksRequest, ListGitRepositoryLinksResponse>("ListGitRepositoryLinks", grpcClient.ListGitRepositoryLinksAsync, grpcClient.ListGitRepositoryLinks, effectiveSettings.ListGitRepositoryLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGitRepositoryLinks);
            Modify_ListGitRepositoryLinksApiCall(ref _callListGitRepositoryLinks);
            _callGetGitRepositoryLink = clientHelper.BuildApiCall<GetGitRepositoryLinkRequest, GitRepositoryLink>("GetGitRepositoryLink", grpcClient.GetGitRepositoryLinkAsync, grpcClient.GetGitRepositoryLink, effectiveSettings.GetGitRepositoryLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGitRepositoryLink);
            Modify_GetGitRepositoryLinkApiCall(ref _callGetGitRepositoryLink);
            _callFetchReadWriteToken = clientHelper.BuildApiCall<FetchReadWriteTokenRequest, FetchReadWriteTokenResponse>("FetchReadWriteToken", grpcClient.FetchReadWriteTokenAsync, grpcClient.FetchReadWriteToken, effectiveSettings.FetchReadWriteTokenSettings).WithGoogleRequestParam("git_repository_link", request => request.GitRepositoryLink);
            Modify_ApiCall(ref _callFetchReadWriteToken);
            Modify_FetchReadWriteTokenApiCall(ref _callFetchReadWriteToken);
            _callFetchReadToken = clientHelper.BuildApiCall<FetchReadTokenRequest, FetchReadTokenResponse>("FetchReadToken", grpcClient.FetchReadTokenAsync, grpcClient.FetchReadToken, effectiveSettings.FetchReadTokenSettings).WithGoogleRequestParam("git_repository_link", request => request.GitRepositoryLink);
            Modify_ApiCall(ref _callFetchReadToken);
            Modify_FetchReadTokenApiCall(ref _callFetchReadToken);
            _callFetchLinkableGitRepositories = clientHelper.BuildApiCall<FetchLinkableGitRepositoriesRequest, FetchLinkableGitRepositoriesResponse>("FetchLinkableGitRepositories", grpcClient.FetchLinkableGitRepositoriesAsync, grpcClient.FetchLinkableGitRepositories, effectiveSettings.FetchLinkableGitRepositoriesSettings).WithGoogleRequestParam("connection", request => request.Connection);
            Modify_ApiCall(ref _callFetchLinkableGitRepositories);
            Modify_FetchLinkableGitRepositoriesApiCall(ref _callFetchLinkableGitRepositories);
            _callFetchGitHubInstallations = clientHelper.BuildApiCall<FetchGitHubInstallationsRequest, FetchGitHubInstallationsResponse>("FetchGitHubInstallations", grpcClient.FetchGitHubInstallationsAsync, grpcClient.FetchGitHubInstallations, effectiveSettings.FetchGitHubInstallationsSettings).WithGoogleRequestParam("connection", request => request.Connection);
            Modify_ApiCall(ref _callFetchGitHubInstallations);
            Modify_FetchGitHubInstallationsApiCall(ref _callFetchGitHubInstallations);
            _callFetchGitRefs = clientHelper.BuildApiCall<FetchGitRefsRequest, FetchGitRefsResponse>("FetchGitRefs", grpcClient.FetchGitRefsAsync, grpcClient.FetchGitRefs, effectiveSettings.FetchGitRefsSettings).WithGoogleRequestParam("git_repository_link", request => request.GitRepositoryLink);
            Modify_ApiCall(ref _callFetchGitRefs);
            Modify_FetchGitRefsApiCall(ref _callFetchGitRefs);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListConnectionsApiCall(ref gaxgrpc::ApiCall<ListConnectionsRequest, ListConnectionsResponse> call);

        partial void Modify_GetConnectionApiCall(ref gaxgrpc::ApiCall<GetConnectionRequest, Connection> call);

        partial void Modify_CreateConnectionApiCall(ref gaxgrpc::ApiCall<CreateConnectionRequest, lro::Operation> call);

        partial void Modify_UpdateConnectionApiCall(ref gaxgrpc::ApiCall<UpdateConnectionRequest, lro::Operation> call);

        partial void Modify_DeleteConnectionApiCall(ref gaxgrpc::ApiCall<DeleteConnectionRequest, lro::Operation> call);

        partial void Modify_CreateGitRepositoryLinkApiCall(ref gaxgrpc::ApiCall<CreateGitRepositoryLinkRequest, lro::Operation> call);

        partial void Modify_DeleteGitRepositoryLinkApiCall(ref gaxgrpc::ApiCall<DeleteGitRepositoryLinkRequest, lro::Operation> call);

        partial void Modify_ListGitRepositoryLinksApiCall(ref gaxgrpc::ApiCall<ListGitRepositoryLinksRequest, ListGitRepositoryLinksResponse> call);

        partial void Modify_GetGitRepositoryLinkApiCall(ref gaxgrpc::ApiCall<GetGitRepositoryLinkRequest, GitRepositoryLink> call);

        partial void Modify_FetchReadWriteTokenApiCall(ref gaxgrpc::ApiCall<FetchReadWriteTokenRequest, FetchReadWriteTokenResponse> call);

        partial void Modify_FetchReadTokenApiCall(ref gaxgrpc::ApiCall<FetchReadTokenRequest, FetchReadTokenResponse> call);

        partial void Modify_FetchLinkableGitRepositoriesApiCall(ref gaxgrpc::ApiCall<FetchLinkableGitRepositoriesRequest, FetchLinkableGitRepositoriesResponse> call);

        partial void Modify_FetchGitHubInstallationsApiCall(ref gaxgrpc::ApiCall<FetchGitHubInstallationsRequest, FetchGitHubInstallationsResponse> call);

        partial void Modify_FetchGitRefsApiCall(ref gaxgrpc::ApiCall<FetchGitRefsRequest, FetchGitRefsResponse> call);

        partial void OnConstruction(DeveloperConnect.DeveloperConnectClient grpcClient, DeveloperConnectSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DeveloperConnect client</summary>
        public override DeveloperConnect.DeveloperConnectClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListConnectionsRequest(ref ListConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectionRequest(ref GetConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConnectionRequest(ref CreateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConnectionRequest(ref UpdateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConnectionRequest(ref DeleteConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGitRepositoryLinkRequest(ref CreateGitRepositoryLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGitRepositoryLinkRequest(ref DeleteGitRepositoryLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGitRepositoryLinksRequest(ref ListGitRepositoryLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGitRepositoryLinkRequest(ref GetGitRepositoryLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchReadWriteTokenRequest(ref FetchReadWriteTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchReadTokenRequest(ref FetchReadTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchLinkableGitRepositoriesRequest(ref FetchLinkableGitRepositoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchGitHubInstallationsRequest(ref FetchGitHubInstallationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchGitRefsRequest(ref FetchGitRefsRequest request, ref gaxgrpc::CallSettings settings);

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

        /// <summary>The long-running operations client for <c>CreateGitRepositoryLink</c>.</summary>
        public override lro::OperationsClient CreateGitRepositoryLinkOperationsClient { get; }

        /// <summary>
        /// Creates a GitRepositoryLink. Upon linking a Git Repository, Developer
        /// Connect will configure the Git Repository to send webhook events to
        /// Developer Connect. Connections that use Firebase GitHub Application will
        /// have events forwarded to the Firebase service. All other Connections will
        /// have events forwarded to Cloud Build.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GitRepositoryLink, OperationMetadata> CreateGitRepositoryLink(CreateGitRepositoryLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGitRepositoryLinkRequest(ref request, ref callSettings);
            return new lro::Operation<GitRepositoryLink, OperationMetadata>(_callCreateGitRepositoryLink.Sync(request, callSettings), CreateGitRepositoryLinkOperationsClient);
        }

        /// <summary>
        /// Creates a GitRepositoryLink. Upon linking a Git Repository, Developer
        /// Connect will configure the Git Repository to send webhook events to
        /// Developer Connect. Connections that use Firebase GitHub Application will
        /// have events forwarded to the Firebase service. All other Connections will
        /// have events forwarded to Cloud Build.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GitRepositoryLink, OperationMetadata>> CreateGitRepositoryLinkAsync(CreateGitRepositoryLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGitRepositoryLinkRequest(ref request, ref callSettings);
            return new lro::Operation<GitRepositoryLink, OperationMetadata>(await _callCreateGitRepositoryLink.Async(request, callSettings).ConfigureAwait(false), CreateGitRepositoryLinkOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteGitRepositoryLink</c>.</summary>
        public override lro::OperationsClient DeleteGitRepositoryLinkOperationsClient { get; }

        /// <summary>
        /// Deletes a single GitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteGitRepositoryLink(DeleteGitRepositoryLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGitRepositoryLinkRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteGitRepositoryLink.Sync(request, callSettings), DeleteGitRepositoryLinkOperationsClient);
        }

        /// <summary>
        /// Deletes a single GitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGitRepositoryLinkAsync(DeleteGitRepositoryLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGitRepositoryLinkRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteGitRepositoryLink.Async(request, callSettings).ConfigureAwait(false), DeleteGitRepositoryLinkOperationsClient);
        }

        /// <summary>
        /// Lists GitRepositoryLinks in a given project, location, and connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GitRepositoryLink"/> resources.</returns>
        public override gax::PagedEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> ListGitRepositoryLinks(ListGitRepositoryLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGitRepositoryLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGitRepositoryLinksRequest, ListGitRepositoryLinksResponse, GitRepositoryLink>(_callListGitRepositoryLinks, request, callSettings);
        }

        /// <summary>
        /// Lists GitRepositoryLinks in a given project, location, and connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GitRepositoryLink"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> ListGitRepositoryLinksAsync(ListGitRepositoryLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGitRepositoryLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGitRepositoryLinksRequest, ListGitRepositoryLinksResponse, GitRepositoryLink>(_callListGitRepositoryLinks, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single GitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GitRepositoryLink GetGitRepositoryLink(GetGitRepositoryLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGitRepositoryLinkRequest(ref request, ref callSettings);
            return _callGetGitRepositoryLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single GitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GitRepositoryLink> GetGitRepositoryLinkAsync(GetGitRepositoryLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGitRepositoryLinkRequest(ref request, ref callSettings);
            return _callGetGitRepositoryLink.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches read/write token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchReadWriteTokenResponse FetchReadWriteToken(FetchReadWriteTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchReadWriteTokenRequest(ref request, ref callSettings);
            return _callFetchReadWriteToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches read/write token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchReadWriteTokenResponse> FetchReadWriteTokenAsync(FetchReadWriteTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchReadWriteTokenRequest(ref request, ref callSettings);
            return _callFetchReadWriteToken.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches read token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchReadTokenResponse FetchReadToken(FetchReadTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchReadTokenRequest(ref request, ref callSettings);
            return _callFetchReadToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches read token of a given gitRepositoryLink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchReadTokenResponse> FetchReadTokenAsync(FetchReadTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchReadTokenRequest(ref request, ref callSettings);
            return _callFetchReadToken.Async(request, callSettings);
        }

        /// <summary>
        /// FetchLinkableGitRepositories returns a list of git repositories from an SCM
        /// that are available to be added to a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LinkableGitRepository"/> resources.</returns>
        public override gax::PagedEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> FetchLinkableGitRepositories(FetchLinkableGitRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchLinkableGitRepositoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchLinkableGitRepositoriesRequest, FetchLinkableGitRepositoriesResponse, LinkableGitRepository>(_callFetchLinkableGitRepositories, request, callSettings);
        }

        /// <summary>
        /// FetchLinkableGitRepositories returns a list of git repositories from an SCM
        /// that are available to be added to a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LinkableGitRepository"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> FetchLinkableGitRepositoriesAsync(FetchLinkableGitRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchLinkableGitRepositoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchLinkableGitRepositoriesRequest, FetchLinkableGitRepositoriesResponse, LinkableGitRepository>(_callFetchLinkableGitRepositories, request, callSettings);
        }

        /// <summary>
        /// FetchGitHubInstallations returns the list of GitHub Installations that
        /// are available to be added to a Connection.
        /// For github.com, only installations accessible to the authorizer token
        /// are returned. For GitHub Enterprise, all installations are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchGitHubInstallationsResponse FetchGitHubInstallations(FetchGitHubInstallationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchGitHubInstallationsRequest(ref request, ref callSettings);
            return _callFetchGitHubInstallations.Sync(request, callSettings);
        }

        /// <summary>
        /// FetchGitHubInstallations returns the list of GitHub Installations that
        /// are available to be added to a Connection.
        /// For github.com, only installations accessible to the authorizer token
        /// are returned. For GitHub Enterprise, all installations are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchGitHubInstallationsResponse> FetchGitHubInstallationsAsync(FetchGitHubInstallationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchGitHubInstallationsRequest(ref request, ref callSettings);
            return _callFetchGitHubInstallations.Async(request, callSettings);
        }

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<FetchGitRefsResponse, string> FetchGitRefs(FetchGitRefsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchGitRefsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchGitRefsRequest, FetchGitRefsResponse, string>(_callFetchGitRefs, request, callSettings);
        }

        /// <summary>
        /// Fetch the list of branches or tags for a given repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchGitRefsResponse, string> FetchGitRefsAsync(FetchGitRefsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchGitRefsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchGitRefsRequest, FetchGitRefsResponse, string>(_callFetchGitRefs, request, callSettings);
        }
    }

    public partial class ListConnectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGitRepositoryLinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchLinkableGitRepositoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchGitRefsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectionsResponse : gaxgrpc::IPageResponse<Connection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Connection> GetEnumerator() => Connections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGitRepositoryLinksResponse : gaxgrpc::IPageResponse<GitRepositoryLink>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GitRepositoryLink> GetEnumerator() => GitRepositoryLinks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchLinkableGitRepositoriesResponse : gaxgrpc::IPageResponse<LinkableGitRepository>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LinkableGitRepository> GetEnumerator() => LinkableGitRepositories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchGitRefsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => RefNames.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DeveloperConnect
    {
        public partial class DeveloperConnectClient
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

    public static partial class DeveloperConnect
    {
        public partial class DeveloperConnectClient
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
