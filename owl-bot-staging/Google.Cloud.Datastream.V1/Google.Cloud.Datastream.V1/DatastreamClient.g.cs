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

namespace Google.Cloud.Datastream.V1
{
    /// <summary>Settings for <see cref="DatastreamClient"/> instances.</summary>
    public sealed partial class DatastreamSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DatastreamSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DatastreamSettings"/>.</returns>
        public static DatastreamSettings GetDefault() => new DatastreamSettings();

        /// <summary>Constructs a new <see cref="DatastreamSettings"/> object with default settings.</summary>
        public DatastreamSettings()
        {
        }

        private DatastreamSettings(DatastreamSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListConnectionProfilesSettings = existing.ListConnectionProfilesSettings;
            GetConnectionProfileSettings = existing.GetConnectionProfileSettings;
            CreateConnectionProfileSettings = existing.CreateConnectionProfileSettings;
            CreateConnectionProfileOperationsSettings = existing.CreateConnectionProfileOperationsSettings.Clone();
            UpdateConnectionProfileSettings = existing.UpdateConnectionProfileSettings;
            UpdateConnectionProfileOperationsSettings = existing.UpdateConnectionProfileOperationsSettings.Clone();
            DeleteConnectionProfileSettings = existing.DeleteConnectionProfileSettings;
            DeleteConnectionProfileOperationsSettings = existing.DeleteConnectionProfileOperationsSettings.Clone();
            DiscoverConnectionProfileSettings = existing.DiscoverConnectionProfileSettings;
            ListStreamsSettings = existing.ListStreamsSettings;
            GetStreamSettings = existing.GetStreamSettings;
            CreateStreamSettings = existing.CreateStreamSettings;
            CreateStreamOperationsSettings = existing.CreateStreamOperationsSettings.Clone();
            UpdateStreamSettings = existing.UpdateStreamSettings;
            UpdateStreamOperationsSettings = existing.UpdateStreamOperationsSettings.Clone();
            DeleteStreamSettings = existing.DeleteStreamSettings;
            DeleteStreamOperationsSettings = existing.DeleteStreamOperationsSettings.Clone();
            RunStreamSettings = existing.RunStreamSettings;
            RunStreamOperationsSettings = existing.RunStreamOperationsSettings.Clone();
            GetStreamObjectSettings = existing.GetStreamObjectSettings;
            LookupStreamObjectSettings = existing.LookupStreamObjectSettings;
            ListStreamObjectsSettings = existing.ListStreamObjectsSettings;
            StartBackfillJobSettings = existing.StartBackfillJobSettings;
            StopBackfillJobSettings = existing.StopBackfillJobSettings;
            FetchStaticIpsSettings = existing.FetchStaticIpsSettings;
            CreatePrivateConnectionSettings = existing.CreatePrivateConnectionSettings;
            CreatePrivateConnectionOperationsSettings = existing.CreatePrivateConnectionOperationsSettings.Clone();
            GetPrivateConnectionSettings = existing.GetPrivateConnectionSettings;
            ListPrivateConnectionsSettings = existing.ListPrivateConnectionsSettings;
            DeletePrivateConnectionSettings = existing.DeletePrivateConnectionSettings;
            DeletePrivateConnectionOperationsSettings = existing.DeletePrivateConnectionOperationsSettings.Clone();
            CreateRouteSettings = existing.CreateRouteSettings;
            CreateRouteOperationsSettings = existing.CreateRouteOperationsSettings.Clone();
            GetRouteSettings = existing.GetRouteSettings;
            ListRoutesSettings = existing.ListRoutesSettings;
            DeleteRouteSettings = existing.DeleteRouteSettings;
            DeleteRouteOperationsSettings = existing.DeleteRouteOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DatastreamSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.ListConnectionProfiles</c> and <c>DatastreamClient.ListConnectionProfilesAsync</c>.
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
        public gaxgrpc::CallSettings ListConnectionProfilesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.GetConnectionProfile</c> and <c>DatastreamClient.GetConnectionProfileAsync</c>.
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
        public gaxgrpc::CallSettings GetConnectionProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.CreateConnectionProfile</c> and <c>DatastreamClient.CreateConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConnectionProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastreamClient.CreateConnectionProfile</c> and
        /// <c>DatastreamClient.CreateConnectionProfileAsync</c>.
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
        public lro::OperationsSettings CreateConnectionProfileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.UpdateConnectionProfile</c> and <c>DatastreamClient.UpdateConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConnectionProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastreamClient.UpdateConnectionProfile</c> and
        /// <c>DatastreamClient.UpdateConnectionProfileAsync</c>.
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
        public lro::OperationsSettings UpdateConnectionProfileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.DeleteConnectionProfile</c> and <c>DatastreamClient.DeleteConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConnectionProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastreamClient.DeleteConnectionProfile</c> and
        /// <c>DatastreamClient.DeleteConnectionProfileAsync</c>.
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
        public lro::OperationsSettings DeleteConnectionProfileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.DiscoverConnectionProfile</c> and <c>DatastreamClient.DiscoverConnectionProfileAsync</c>
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
        public gaxgrpc::CallSettings DiscoverConnectionProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.ListStreams</c> and <c>DatastreamClient.ListStreamsAsync</c>.
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
        public gaxgrpc::CallSettings ListStreamsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DatastreamClient.GetStream</c>
        ///  and <c>DatastreamClient.GetStreamAsync</c>.
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
        public gaxgrpc::CallSettings GetStreamSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.CreateStream</c> and <c>DatastreamClient.CreateStreamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateStreamSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastreamClient.CreateStream</c> and
        /// <c>DatastreamClient.CreateStreamAsync</c>.
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
        public lro::OperationsSettings CreateStreamOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.UpdateStream</c> and <c>DatastreamClient.UpdateStreamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateStreamSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastreamClient.UpdateStream</c> and
        /// <c>DatastreamClient.UpdateStreamAsync</c>.
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
        public lro::OperationsSettings UpdateStreamOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.DeleteStream</c> and <c>DatastreamClient.DeleteStreamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteStreamSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastreamClient.DeleteStream</c> and
        /// <c>DatastreamClient.DeleteStreamAsync</c>.
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
        public lro::OperationsSettings DeleteStreamOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DatastreamClient.RunStream</c>
        ///  and <c>DatastreamClient.RunStreamAsync</c>.
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
        public gaxgrpc::CallSettings RunStreamSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastreamClient.RunStream</c> and
        /// <c>DatastreamClient.RunStreamAsync</c>.
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
        public lro::OperationsSettings RunStreamOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.GetStreamObject</c> and <c>DatastreamClient.GetStreamObjectAsync</c>.
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
        public gaxgrpc::CallSettings GetStreamObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.LookupStreamObject</c> and <c>DatastreamClient.LookupStreamObjectAsync</c>.
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
        public gaxgrpc::CallSettings LookupStreamObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.ListStreamObjects</c> and <c>DatastreamClient.ListStreamObjectsAsync</c>.
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
        public gaxgrpc::CallSettings ListStreamObjectsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.StartBackfillJob</c> and <c>DatastreamClient.StartBackfillJobAsync</c>.
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
        public gaxgrpc::CallSettings StartBackfillJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.StopBackfillJob</c> and <c>DatastreamClient.StopBackfillJobAsync</c>.
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
        public gaxgrpc::CallSettings StopBackfillJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.FetchStaticIps</c> and <c>DatastreamClient.FetchStaticIpsAsync</c>.
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
        public gaxgrpc::CallSettings FetchStaticIpsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.CreatePrivateConnection</c> and <c>DatastreamClient.CreatePrivateConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePrivateConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastreamClient.CreatePrivateConnection</c> and
        /// <c>DatastreamClient.CreatePrivateConnectionAsync</c>.
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
        public lro::OperationsSettings CreatePrivateConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.GetPrivateConnection</c> and <c>DatastreamClient.GetPrivateConnectionAsync</c>.
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
        public gaxgrpc::CallSettings GetPrivateConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.ListPrivateConnections</c> and <c>DatastreamClient.ListPrivateConnectionsAsync</c>.
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
        public gaxgrpc::CallSettings ListPrivateConnectionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.DeletePrivateConnection</c> and <c>DatastreamClient.DeletePrivateConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePrivateConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastreamClient.DeletePrivateConnection</c> and
        /// <c>DatastreamClient.DeletePrivateConnectionAsync</c>.
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
        public lro::OperationsSettings DeletePrivateConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.CreateRoute</c> and <c>DatastreamClient.CreateRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastreamClient.CreateRoute</c> and
        /// <c>DatastreamClient.CreateRouteAsync</c>.
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
        public lro::OperationsSettings CreateRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DatastreamClient.GetRoute</c>
        ///  and <c>DatastreamClient.GetRouteAsync</c>.
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
        public gaxgrpc::CallSettings GetRouteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DatastreamClient.ListRoutes</c>
        ///  and <c>DatastreamClient.ListRoutesAsync</c>.
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
        public gaxgrpc::CallSettings ListRoutesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastreamClient.DeleteRoute</c> and <c>DatastreamClient.DeleteRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastreamClient.DeleteRoute</c> and
        /// <c>DatastreamClient.DeleteRouteAsync</c>.
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
        public lro::OperationsSettings DeleteRouteOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="DatastreamSettings"/> object.</returns>
        public DatastreamSettings Clone() => new DatastreamSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DatastreamClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DatastreamClientBuilder : gaxgrpc::ClientBuilderBase<DatastreamClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DatastreamSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DatastreamClientBuilder() : base(DatastreamClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DatastreamClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DatastreamClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DatastreamClient Build()
        {
            DatastreamClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DatastreamClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DatastreamClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DatastreamClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DatastreamClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DatastreamClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DatastreamClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DatastreamClient.ChannelPool;
    }

    /// <summary>Datastream client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Datastream service
    /// </remarks>
    public abstract partial class DatastreamClient
    {
        /// <summary>
        /// The default endpoint for the Datastream service, which is a host of "datastream.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datastream.googleapis.com:443";

        /// <summary>The default Datastream scopes.</summary>
        /// <remarks>
        /// The default Datastream scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Datastream.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DatastreamClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DatastreamClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DatastreamClient"/>.</returns>
        public static stt::Task<DatastreamClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DatastreamClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DatastreamClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="DatastreamClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DatastreamClient"/>.</returns>
        public static DatastreamClient Create() => new DatastreamClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DatastreamClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DatastreamSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DatastreamClient"/>.</returns>
        internal static DatastreamClient Create(grpccore::CallInvoker callInvoker, DatastreamSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Datastream.DatastreamClient grpcClient = new Datastream.DatastreamClient(callInvoker);
            return new DatastreamClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Datastream client</summary>
        public virtual Datastream.DatastreamClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to list connection profiles created in a project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfiles(ListConnectionProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to list connection profiles created in a project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfilesAsync(ListConnectionProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to list connection profiles created in a project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of connection profiles.
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
        /// <returns>A pageable sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionProfilesRequest request = new ListConnectionProfilesRequest
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
            return ListConnectionProfiles(request, callSettings);
        }

        /// <summary>
        /// Use this method to list connection profiles created in a project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of connection profiles.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionProfilesRequest request = new ListConnectionProfilesRequest
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
            return ListConnectionProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Use this method to list connection profiles created in a project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of connection profiles.
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
        /// <returns>A pageable sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfiles(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionProfilesRequest request = new ListConnectionProfilesRequest
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
            return ListConnectionProfiles(request, callSettings);
        }

        /// <summary>
        /// Use this method to list connection profiles created in a project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of connection profiles.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfilesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionProfilesRequest request = new ListConnectionProfilesRequest
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
            return ListConnectionProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Use this method to get details about a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionProfile GetConnectionProfile(GetConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to get details about a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(GetConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to get details about a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(GetConnectionProfileRequest request, st::CancellationToken cancellationToken) =>
            GetConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to get details about a connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connection profile resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionProfile GetConnectionProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionProfile(new GetConnectionProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connection profile resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionProfileAsync(new GetConnectionProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connection profile resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectionProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to get details about a connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connection profile resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionProfile GetConnectionProfile(ConnectionProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionProfile(new GetConnectionProfileRequest
            {
                ConnectionProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connection profile resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(ConnectionProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionProfileAsync(new GetConnectionProfileRequest
            {
                ConnectionProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connection profile resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(ConnectionProfileName name, st::CancellationToken cancellationToken) =>
            GetConnectionProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to create a connection profile in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> CreateConnectionProfile(CreateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to create a connection profile in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(CreateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to create a connection profile in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(CreateConnectionProfileRequest request, st::CancellationToken cancellationToken) =>
            CreateConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConnectionProfile</c>.</summary>
        public virtual lro::OperationsClient CreateConnectionProfileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> PollOnceCreateConnectionProfile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionProfile, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> PollOnceCreateConnectionProfileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionProfile, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Use this method to create a connection profile in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of ConnectionProfiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The connection profile resource to create.
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> CreateConnectionProfile(string parent, ConnectionProfile connectionProfile, string connectionProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionProfile(new CreateConnectionProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectionProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a connection profile in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of ConnectionProfiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The connection profile resource to create.
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(string parent, ConnectionProfile connectionProfile, string connectionProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionProfileAsync(new CreateConnectionProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectionProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a connection profile in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of ConnectionProfiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The connection profile resource to create.
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(string parent, ConnectionProfile connectionProfile, string connectionProfileId, st::CancellationToken cancellationToken) =>
            CreateConnectionProfileAsync(parent, connectionProfile, connectionProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to create a connection profile in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of ConnectionProfiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The connection profile resource to create.
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> CreateConnectionProfile(gagr::LocationName parent, ConnectionProfile connectionProfile, string connectionProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionProfile(new CreateConnectionProfileRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectionProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a connection profile in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of ConnectionProfiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The connection profile resource to create.
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(gagr::LocationName parent, ConnectionProfile connectionProfile, string connectionProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionProfileAsync(new CreateConnectionProfileRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectionProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a connection profile in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of ConnectionProfiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The connection profile resource to create.
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(gagr::LocationName parent, ConnectionProfile connectionProfile, string connectionProfileId, st::CancellationToken cancellationToken) =>
            CreateConnectionProfileAsync(parent, connectionProfile, connectionProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to update the parameters of a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> UpdateConnectionProfile(UpdateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to update the parameters of a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(UpdateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to update the parameters of a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(UpdateConnectionProfileRequest request, st::CancellationToken cancellationToken) =>
            UpdateConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateConnectionProfile</c>.</summary>
        public virtual lro::OperationsClient UpdateConnectionProfileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> PollOnceUpdateConnectionProfile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionProfile, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> PollOnceUpdateConnectionProfileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionProfile, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Use this method to update the parameters of a connection profile.
        /// </summary>
        /// <param name="connectionProfile">
        /// Required. The connection profile to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ConnectionProfile resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> UpdateConnectionProfile(ConnectionProfile connectionProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectionProfile(new UpdateConnectionProfileRequest
            {
                UpdateMask = updateMask,
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Use this method to update the parameters of a connection profile.
        /// </summary>
        /// <param name="connectionProfile">
        /// Required. The connection profile to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ConnectionProfile resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(ConnectionProfile connectionProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectionProfileAsync(new UpdateConnectionProfileRequest
            {
                UpdateMask = updateMask,
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Use this method to update the parameters of a connection profile.
        /// </summary>
        /// <param name="connectionProfile">
        /// Required. The connection profile to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ConnectionProfile resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(ConnectionProfile connectionProfile, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConnectionProfileAsync(connectionProfile, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to delete a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectionProfile(DeleteConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to delete a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(DeleteConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to delete a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(DeleteConnectionProfileRequest request, st::CancellationToken cancellationToken) =>
            DeleteConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteConnectionProfile</c>.</summary>
        public virtual lro::OperationsClient DeleteConnectionProfileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteConnectionProfile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteConnectionProfileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Use this method to delete a connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connection profile resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectionProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionProfile(new DeleteConnectionProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connection profile resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionProfileAsync(new DeleteConnectionProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connection profile resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConnectionProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to delete a connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connection profile resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectionProfile(ConnectionProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionProfile(new DeleteConnectionProfileRequest
            {
                ConnectionProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connection profile resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(ConnectionProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionProfileAsync(new DeleteConnectionProfileRequest
            {
                ConnectionProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connection profile resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(ConnectionProfileName name, st::CancellationToken cancellationToken) =>
            DeleteConnectionProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to discover a connection profile.
        /// The discover API call exposes the data objects and metadata belonging to
        /// the profile. Typically, a request returns children data objects of a
        /// parent data object that's optionally supplied in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoverConnectionProfileResponse DiscoverConnectionProfile(DiscoverConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to discover a connection profile.
        /// The discover API call exposes the data objects and metadata belonging to
        /// the profile. Typically, a request returns children data objects of a
        /// parent data object that's optionally supplied in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoverConnectionProfileResponse> DiscoverConnectionProfileAsync(DiscoverConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to discover a connection profile.
        /// The discover API call exposes the data objects and metadata belonging to
        /// the profile. Typically, a request returns children data objects of a
        /// parent data object that's optionally supplied in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoverConnectionProfileResponse> DiscoverConnectionProfileAsync(DiscoverConnectionProfileRequest request, st::CancellationToken cancellationToken) =>
            DiscoverConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to list streams in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Stream"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStreamsResponse, Stream> ListStreams(ListStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to list streams in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Stream"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStreamsResponse, Stream> ListStreamsAsync(ListStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to list streams in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of streams.
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
        /// <returns>A pageable sequence of <see cref="Stream"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStreamsResponse, Stream> ListStreams(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStreamsRequest request = new ListStreamsRequest
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
            return ListStreams(request, callSettings);
        }

        /// <summary>
        /// Use this method to list streams in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of streams.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Stream"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStreamsResponse, Stream> ListStreamsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStreamsRequest request = new ListStreamsRequest
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
            return ListStreamsAsync(request, callSettings);
        }

        /// <summary>
        /// Use this method to list streams in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of streams.
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
        /// <returns>A pageable sequence of <see cref="Stream"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStreamsResponse, Stream> ListStreams(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStreamsRequest request = new ListStreamsRequest
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
            return ListStreams(request, callSettings);
        }

        /// <summary>
        /// Use this method to list streams in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of streams.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Stream"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStreamsResponse, Stream> ListStreamsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStreamsRequest request = new ListStreamsRequest
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
            return ListStreamsAsync(request, callSettings);
        }

        /// <summary>
        /// Use this method to get details about a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Stream GetStream(GetStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to get details about a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Stream> GetStreamAsync(GetStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to get details about a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Stream> GetStreamAsync(GetStreamRequest request, st::CancellationToken cancellationToken) =>
            GetStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to get details about a stream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Stream GetStream(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStream(new GetStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a stream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Stream> GetStreamAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStreamAsync(new GetStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a stream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Stream> GetStreamAsync(string name, st::CancellationToken cancellationToken) =>
            GetStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to get details about a stream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Stream GetStream(StreamName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStream(new GetStreamRequest
            {
                StreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a stream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Stream> GetStreamAsync(StreamName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStreamAsync(new GetStreamRequest
            {
                StreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a stream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Stream> GetStreamAsync(StreamName name, st::CancellationToken cancellationToken) =>
            GetStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to create a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Stream, OperationMetadata> CreateStream(CreateStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to create a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> CreateStreamAsync(CreateStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to create a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> CreateStreamAsync(CreateStreamRequest request, st::CancellationToken cancellationToken) =>
            CreateStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateStream</c>.</summary>
        public virtual lro::OperationsClient CreateStreamOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateStream</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Stream, OperationMetadata> PollOnceCreateStream(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Stream, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateStreamOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateStream</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> PollOnceCreateStreamAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Stream, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateStreamOperationsClient, callSettings);

        /// <summary>
        /// Use this method to create a stream.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of streams.
        /// </param>
        /// <param name="stream">
        /// Required. The stream resource to create.
        /// </param>
        /// <param name="streamId">
        /// Required. The stream identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Stream, OperationMetadata> CreateStream(string parent, Stream stream, string streamId, gaxgrpc::CallSettings callSettings = null) =>
            CreateStream(new CreateStreamRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                StreamId = gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)),
                Stream = gax::GaxPreconditions.CheckNotNull(stream, nameof(stream)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a stream.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of streams.
        /// </param>
        /// <param name="stream">
        /// Required. The stream resource to create.
        /// </param>
        /// <param name="streamId">
        /// Required. The stream identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> CreateStreamAsync(string parent, Stream stream, string streamId, gaxgrpc::CallSettings callSettings = null) =>
            CreateStreamAsync(new CreateStreamRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                StreamId = gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)),
                Stream = gax::GaxPreconditions.CheckNotNull(stream, nameof(stream)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a stream.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of streams.
        /// </param>
        /// <param name="stream">
        /// Required. The stream resource to create.
        /// </param>
        /// <param name="streamId">
        /// Required. The stream identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> CreateStreamAsync(string parent, Stream stream, string streamId, st::CancellationToken cancellationToken) =>
            CreateStreamAsync(parent, stream, streamId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to create a stream.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of streams.
        /// </param>
        /// <param name="stream">
        /// Required. The stream resource to create.
        /// </param>
        /// <param name="streamId">
        /// Required. The stream identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Stream, OperationMetadata> CreateStream(gagr::LocationName parent, Stream stream, string streamId, gaxgrpc::CallSettings callSettings = null) =>
            CreateStream(new CreateStreamRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                StreamId = gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)),
                Stream = gax::GaxPreconditions.CheckNotNull(stream, nameof(stream)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a stream.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of streams.
        /// </param>
        /// <param name="stream">
        /// Required. The stream resource to create.
        /// </param>
        /// <param name="streamId">
        /// Required. The stream identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> CreateStreamAsync(gagr::LocationName parent, Stream stream, string streamId, gaxgrpc::CallSettings callSettings = null) =>
            CreateStreamAsync(new CreateStreamRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                StreamId = gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)),
                Stream = gax::GaxPreconditions.CheckNotNull(stream, nameof(stream)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a stream.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of streams.
        /// </param>
        /// <param name="stream">
        /// Required. The stream resource to create.
        /// </param>
        /// <param name="streamId">
        /// Required. The stream identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> CreateStreamAsync(gagr::LocationName parent, Stream stream, string streamId, st::CancellationToken cancellationToken) =>
            CreateStreamAsync(parent, stream, streamId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to update the configuration of a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Stream, OperationMetadata> UpdateStream(UpdateStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to update the configuration of a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> UpdateStreamAsync(UpdateStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to update the configuration of a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> UpdateStreamAsync(UpdateStreamRequest request, st::CancellationToken cancellationToken) =>
            UpdateStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateStream</c>.</summary>
        public virtual lro::OperationsClient UpdateStreamOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateStream</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Stream, OperationMetadata> PollOnceUpdateStream(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Stream, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateStreamOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateStream</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> PollOnceUpdateStreamAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Stream, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateStreamOperationsClient, callSettings);

        /// <summary>
        /// Use this method to update the configuration of a stream.
        /// </summary>
        /// <param name="stream">
        /// Required. The stream resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// stream resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Stream, OperationMetadata> UpdateStream(Stream stream, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStream(new UpdateStreamRequest
            {
                UpdateMask = updateMask,
                Stream = gax::GaxPreconditions.CheckNotNull(stream, nameof(stream)),
            }, callSettings);

        /// <summary>
        /// Use this method to update the configuration of a stream.
        /// </summary>
        /// <param name="stream">
        /// Required. The stream resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// stream resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> UpdateStreamAsync(Stream stream, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStreamAsync(new UpdateStreamRequest
            {
                UpdateMask = updateMask,
                Stream = gax::GaxPreconditions.CheckNotNull(stream, nameof(stream)),
            }, callSettings);

        /// <summary>
        /// Use this method to update the configuration of a stream.
        /// </summary>
        /// <param name="stream">
        /// Required. The stream resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// stream resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> UpdateStreamAsync(Stream stream, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateStreamAsync(stream, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to delete a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteStream(DeleteStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to delete a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStreamAsync(DeleteStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to delete a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStreamAsync(DeleteStreamRequest request, st::CancellationToken cancellationToken) =>
            DeleteStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteStream</c>.</summary>
        public virtual lro::OperationsClient DeleteStreamOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteStream</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteStream(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteStreamOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteStream</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteStreamAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteStreamOperationsClient, callSettings);

        /// <summary>
        /// Use this method to delete a stream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteStream(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStream(new DeleteStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a stream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStreamAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStreamAsync(new DeleteStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a stream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStreamAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to delete a stream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteStream(StreamName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStream(new DeleteStreamRequest
            {
                StreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a stream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStreamAsync(StreamName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStreamAsync(new DeleteStreamRequest
            {
                StreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a stream.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStreamAsync(StreamName name, st::CancellationToken cancellationToken) =>
            DeleteStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to start, resume or recover a stream with a non default CDC
        /// strategy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Stream, OperationMetadata> RunStream(RunStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to start, resume or recover a stream with a non default CDC
        /// strategy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> RunStreamAsync(RunStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to start, resume or recover a stream with a non default CDC
        /// strategy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> RunStreamAsync(RunStreamRequest request, st::CancellationToken cancellationToken) =>
            RunStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunStream</c>.</summary>
        public virtual lro::OperationsClient RunStreamOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunStream</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Stream, OperationMetadata> PollOnceRunStream(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Stream, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunStreamOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunStream</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Stream, OperationMetadata>> PollOnceRunStreamAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Stream, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunStreamOperationsClient, callSettings);

        /// <summary>
        /// Use this method to get details about a stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StreamObject GetStreamObject(GetStreamObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to get details about a stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StreamObject> GetStreamObjectAsync(GetStreamObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to get details about a stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StreamObject> GetStreamObjectAsync(GetStreamObjectRequest request, st::CancellationToken cancellationToken) =>
            GetStreamObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to get details about a stream object.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream object resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StreamObject GetStreamObject(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStreamObject(new GetStreamObjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a stream object.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream object resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StreamObject> GetStreamObjectAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStreamObjectAsync(new GetStreamObjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a stream object.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream object resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StreamObject> GetStreamObjectAsync(string name, st::CancellationToken cancellationToken) =>
            GetStreamObjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to get details about a stream object.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream object resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StreamObject GetStreamObject(StreamObjectName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStreamObject(new GetStreamObjectRequest
            {
                StreamObjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a stream object.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream object resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StreamObject> GetStreamObjectAsync(StreamObjectName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStreamObjectAsync(new GetStreamObjectRequest
            {
                StreamObjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a stream object.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stream object resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StreamObject> GetStreamObjectAsync(StreamObjectName name, st::CancellationToken cancellationToken) =>
            GetStreamObjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to look up a stream object by its source object identifier.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StreamObject LookupStreamObject(LookupStreamObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to look up a stream object by its source object identifier.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StreamObject> LookupStreamObjectAsync(LookupStreamObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to look up a stream object by its source object identifier.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StreamObject> LookupStreamObjectAsync(LookupStreamObjectRequest request, st::CancellationToken cancellationToken) =>
            LookupStreamObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to list the objects of a specific stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StreamObject"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStreamObjectsResponse, StreamObject> ListStreamObjects(ListStreamObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to list the objects of a specific stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StreamObject"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStreamObjectsResponse, StreamObject> ListStreamObjectsAsync(ListStreamObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to list the objects of a specific stream.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent stream that owns the collection of objects.
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
        /// <returns>A pageable sequence of <see cref="StreamObject"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStreamObjectsResponse, StreamObject> ListStreamObjects(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStreamObjectsRequest request = new ListStreamObjectsRequest
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
            return ListStreamObjects(request, callSettings);
        }

        /// <summary>
        /// Use this method to list the objects of a specific stream.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent stream that owns the collection of objects.
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
        /// <returns>A pageable asynchronous sequence of <see cref="StreamObject"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStreamObjectsResponse, StreamObject> ListStreamObjectsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStreamObjectsRequest request = new ListStreamObjectsRequest
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
            return ListStreamObjectsAsync(request, callSettings);
        }

        /// <summary>
        /// Use this method to list the objects of a specific stream.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent stream that owns the collection of objects.
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
        /// <returns>A pageable sequence of <see cref="StreamObject"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStreamObjectsResponse, StreamObject> ListStreamObjects(StreamName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStreamObjectsRequest request = new ListStreamObjectsRequest
            {
                ParentAsStreamName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStreamObjects(request, callSettings);
        }

        /// <summary>
        /// Use this method to list the objects of a specific stream.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent stream that owns the collection of objects.
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
        /// <returns>A pageable asynchronous sequence of <see cref="StreamObject"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStreamObjectsResponse, StreamObject> ListStreamObjectsAsync(StreamName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStreamObjectsRequest request = new ListStreamObjectsRequest
            {
                ParentAsStreamName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStreamObjectsAsync(request, callSettings);
        }

        /// <summary>
        /// Use this method to start a backfill job for the specified stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StartBackfillJobResponse StartBackfillJob(StartBackfillJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to start a backfill job for the specified stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartBackfillJobResponse> StartBackfillJobAsync(StartBackfillJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to start a backfill job for the specified stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartBackfillJobResponse> StartBackfillJobAsync(StartBackfillJobRequest request, st::CancellationToken cancellationToken) =>
            StartBackfillJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to start a backfill job for the specified stream object.
        /// </summary>
        /// <param name="object">
        /// Required. The name of the stream object resource to start a backfill job
        /// for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StartBackfillJobResponse StartBackfillJob(string @object, gaxgrpc::CallSettings callSettings = null) =>
            StartBackfillJob(new StartBackfillJobRequest
            {
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Use this method to start a backfill job for the specified stream object.
        /// </summary>
        /// <param name="object">
        /// Required. The name of the stream object resource to start a backfill job
        /// for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartBackfillJobResponse> StartBackfillJobAsync(string @object, gaxgrpc::CallSettings callSettings = null) =>
            StartBackfillJobAsync(new StartBackfillJobRequest
            {
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Use this method to start a backfill job for the specified stream object.
        /// </summary>
        /// <param name="object">
        /// Required. The name of the stream object resource to start a backfill job
        /// for.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartBackfillJobResponse> StartBackfillJobAsync(string @object, st::CancellationToken cancellationToken) =>
            StartBackfillJobAsync(@object, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to start a backfill job for the specified stream object.
        /// </summary>
        /// <param name="object">
        /// Required. The name of the stream object resource to start a backfill job
        /// for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StartBackfillJobResponse StartBackfillJob(StreamObjectName @object, gaxgrpc::CallSettings callSettings = null) =>
            StartBackfillJob(new StartBackfillJobRequest
            {
                ObjectAsStreamObjectName = gax::GaxPreconditions.CheckNotNull(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Use this method to start a backfill job for the specified stream object.
        /// </summary>
        /// <param name="object">
        /// Required. The name of the stream object resource to start a backfill job
        /// for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartBackfillJobResponse> StartBackfillJobAsync(StreamObjectName @object, gaxgrpc::CallSettings callSettings = null) =>
            StartBackfillJobAsync(new StartBackfillJobRequest
            {
                ObjectAsStreamObjectName = gax::GaxPreconditions.CheckNotNull(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Use this method to start a backfill job for the specified stream object.
        /// </summary>
        /// <param name="object">
        /// Required. The name of the stream object resource to start a backfill job
        /// for.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartBackfillJobResponse> StartBackfillJobAsync(StreamObjectName @object, st::CancellationToken cancellationToken) =>
            StartBackfillJobAsync(@object, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to stop a backfill job for the specified stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StopBackfillJobResponse StopBackfillJob(StopBackfillJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to stop a backfill job for the specified stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopBackfillJobResponse> StopBackfillJobAsync(StopBackfillJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to stop a backfill job for the specified stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopBackfillJobResponse> StopBackfillJobAsync(StopBackfillJobRequest request, st::CancellationToken cancellationToken) =>
            StopBackfillJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to stop a backfill job for the specified stream object.
        /// </summary>
        /// <param name="object">
        /// Required. The name of the stream object resource to stop the backfill job
        /// for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StopBackfillJobResponse StopBackfillJob(string @object, gaxgrpc::CallSettings callSettings = null) =>
            StopBackfillJob(new StopBackfillJobRequest
            {
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Use this method to stop a backfill job for the specified stream object.
        /// </summary>
        /// <param name="object">
        /// Required. The name of the stream object resource to stop the backfill job
        /// for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopBackfillJobResponse> StopBackfillJobAsync(string @object, gaxgrpc::CallSettings callSettings = null) =>
            StopBackfillJobAsync(new StopBackfillJobRequest
            {
                Object = gax::GaxPreconditions.CheckNotNullOrEmpty(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Use this method to stop a backfill job for the specified stream object.
        /// </summary>
        /// <param name="object">
        /// Required. The name of the stream object resource to stop the backfill job
        /// for.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopBackfillJobResponse> StopBackfillJobAsync(string @object, st::CancellationToken cancellationToken) =>
            StopBackfillJobAsync(@object, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to stop a backfill job for the specified stream object.
        /// </summary>
        /// <param name="object">
        /// Required. The name of the stream object resource to stop the backfill job
        /// for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StopBackfillJobResponse StopBackfillJob(StreamObjectName @object, gaxgrpc::CallSettings callSettings = null) =>
            StopBackfillJob(new StopBackfillJobRequest
            {
                ObjectAsStreamObjectName = gax::GaxPreconditions.CheckNotNull(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Use this method to stop a backfill job for the specified stream object.
        /// </summary>
        /// <param name="object">
        /// Required. The name of the stream object resource to stop the backfill job
        /// for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopBackfillJobResponse> StopBackfillJobAsync(StreamObjectName @object, gaxgrpc::CallSettings callSettings = null) =>
            StopBackfillJobAsync(new StopBackfillJobRequest
            {
                ObjectAsStreamObjectName = gax::GaxPreconditions.CheckNotNull(@object, nameof(@object)),
            }, callSettings);

        /// <summary>
        /// Use this method to stop a backfill job for the specified stream object.
        /// </summary>
        /// <param name="object">
        /// Required. The name of the stream object resource to stop the backfill job
        /// for.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopBackfillJobResponse> StopBackfillJobAsync(StreamObjectName @object, st::CancellationToken cancellationToken) =>
            StopBackfillJobAsync(@object, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// The FetchStaticIps API call exposes the static IP addresses used by
        /// Datastream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchStaticIpsResponse, string> FetchStaticIps(FetchStaticIpsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// The FetchStaticIps API call exposes the static IP addresses used by
        /// Datastream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchStaticIpsResponse, string> FetchStaticIpsAsync(FetchStaticIpsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// The FetchStaticIps API call exposes the static IP addresses used by
        /// Datastream.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the location for which static IPs should be
        /// returned. Must be in the format `projects/*/locations/*`.
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
        public virtual gax::PagedEnumerable<FetchStaticIpsResponse, string> FetchStaticIps(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchStaticIpsRequest request = new FetchStaticIpsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchStaticIps(request, callSettings);
        }

        /// <summary>
        /// The FetchStaticIps API call exposes the static IP addresses used by
        /// Datastream.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the location for which static IPs should be
        /// returned. Must be in the format `projects/*/locations/*`.
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
        public virtual gax::PagedAsyncEnumerable<FetchStaticIpsResponse, string> FetchStaticIpsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchStaticIpsRequest request = new FetchStaticIpsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchStaticIpsAsync(request, callSettings);
        }

        /// <summary>
        /// The FetchStaticIps API call exposes the static IP addresses used by
        /// Datastream.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the location for which static IPs should be
        /// returned. Must be in the format `projects/*/locations/*`.
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
        public virtual gax::PagedEnumerable<FetchStaticIpsResponse, string> FetchStaticIps(gagr::LocationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchStaticIpsRequest request = new FetchStaticIpsRequest
            {
                LocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchStaticIps(request, callSettings);
        }

        /// <summary>
        /// The FetchStaticIps API call exposes the static IP addresses used by
        /// Datastream.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the location for which static IPs should be
        /// returned. Must be in the format `projects/*/locations/*`.
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
        public virtual gax::PagedAsyncEnumerable<FetchStaticIpsResponse, string> FetchStaticIpsAsync(gagr::LocationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchStaticIpsRequest request = new FetchStaticIpsRequest
            {
                LocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchStaticIpsAsync(request, callSettings);
        }

        /// <summary>
        /// Use this method to create a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateConnection, OperationMetadata> CreatePrivateConnection(CreatePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to create a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(CreatePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to create a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(CreatePrivateConnectionRequest request, st::CancellationToken cancellationToken) =>
            CreatePrivateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePrivateConnection</c>.</summary>
        public virtual lro::OperationsClient CreatePrivateConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePrivateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PrivateConnection, OperationMetadata> PollOnceCreatePrivateConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateConnection, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePrivateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePrivateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> PollOnceCreatePrivateConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrivateConnection, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePrivateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Use this method to create a private connectivity configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of PrivateConnections.
        /// </param>
        /// <param name="privateConnection">
        /// Required. The Private Connectivity resource to create.
        /// </param>
        /// <param name="privateConnectionId">
        /// Required. The private connectivity identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateConnection, OperationMetadata> CreatePrivateConnection(string parent, PrivateConnection privateConnection, string privateConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateConnection(new CreatePrivateConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PrivateConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)),
                PrivateConnection = gax::GaxPreconditions.CheckNotNull(privateConnection, nameof(privateConnection)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a private connectivity configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of PrivateConnections.
        /// </param>
        /// <param name="privateConnection">
        /// Required. The Private Connectivity resource to create.
        /// </param>
        /// <param name="privateConnectionId">
        /// Required. The private connectivity identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(string parent, PrivateConnection privateConnection, string privateConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateConnectionAsync(new CreatePrivateConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PrivateConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)),
                PrivateConnection = gax::GaxPreconditions.CheckNotNull(privateConnection, nameof(privateConnection)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a private connectivity configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of PrivateConnections.
        /// </param>
        /// <param name="privateConnection">
        /// Required. The Private Connectivity resource to create.
        /// </param>
        /// <param name="privateConnectionId">
        /// Required. The private connectivity identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(string parent, PrivateConnection privateConnection, string privateConnectionId, st::CancellationToken cancellationToken) =>
            CreatePrivateConnectionAsync(parent, privateConnection, privateConnectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to create a private connectivity configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of PrivateConnections.
        /// </param>
        /// <param name="privateConnection">
        /// Required. The Private Connectivity resource to create.
        /// </param>
        /// <param name="privateConnectionId">
        /// Required. The private connectivity identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrivateConnection, OperationMetadata> CreatePrivateConnection(gagr::LocationName parent, PrivateConnection privateConnection, string privateConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateConnection(new CreatePrivateConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PrivateConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)),
                PrivateConnection = gax::GaxPreconditions.CheckNotNull(privateConnection, nameof(privateConnection)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a private connectivity configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of PrivateConnections.
        /// </param>
        /// <param name="privateConnection">
        /// Required. The Private Connectivity resource to create.
        /// </param>
        /// <param name="privateConnectionId">
        /// Required. The private connectivity identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(gagr::LocationName parent, PrivateConnection privateConnection, string privateConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateConnectionAsync(new CreatePrivateConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PrivateConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)),
                PrivateConnection = gax::GaxPreconditions.CheckNotNull(privateConnection, nameof(privateConnection)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a private connectivity configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of PrivateConnections.
        /// </param>
        /// <param name="privateConnection">
        /// Required. The Private Connectivity resource to create.
        /// </param>
        /// <param name="privateConnectionId">
        /// Required. The private connectivity identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(gagr::LocationName parent, PrivateConnection privateConnection, string privateConnectionId, st::CancellationToken cancellationToken) =>
            CreatePrivateConnectionAsync(parent, privateConnection, privateConnectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to get details about a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateConnection GetPrivateConnection(GetPrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to get details about a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateConnection> GetPrivateConnectionAsync(GetPrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to get details about a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateConnection> GetPrivateConnectionAsync(GetPrivateConnectionRequest request, st::CancellationToken cancellationToken) =>
            GetPrivateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to get details about a private connectivity configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the  private connectivity configuration to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateConnection GetPrivateConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateConnection(new GetPrivateConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a private connectivity configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the  private connectivity configuration to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateConnection> GetPrivateConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateConnectionAsync(new GetPrivateConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a private connectivity configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the  private connectivity configuration to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateConnection> GetPrivateConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetPrivateConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to get details about a private connectivity configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the  private connectivity configuration to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateConnection GetPrivateConnection(PrivateConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateConnection(new GetPrivateConnectionRequest
            {
                PrivateConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a private connectivity configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the  private connectivity configuration to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateConnection> GetPrivateConnectionAsync(PrivateConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateConnectionAsync(new GetPrivateConnectionRequest
            {
                PrivateConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a private connectivity configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the  private connectivity configuration to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateConnection> GetPrivateConnectionAsync(PrivateConnectionName name, st::CancellationToken cancellationToken) =>
            GetPrivateConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to list private connectivity configurations in a project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnections(ListPrivateConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to list private connectivity configurations in a project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnectionsAsync(ListPrivateConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to list private connectivity configurations in a project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of private connectivity
        /// configurations.
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
        /// <returns>A pageable sequence of <see cref="PrivateConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
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
            return ListPrivateConnections(request, callSettings);
        }

        /// <summary>
        /// Use this method to list private connectivity configurations in a project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of private connectivity
        /// configurations.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
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
            return ListPrivateConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Use this method to list private connectivity configurations in a project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of private connectivity
        /// configurations.
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
        /// <returns>A pageable sequence of <see cref="PrivateConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
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
            return ListPrivateConnections(request, callSettings);
        }

        /// <summary>
        /// Use this method to list private connectivity configurations in a project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of private connectivity
        /// configurations.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
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
            return ListPrivateConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Use this method to delete a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePrivateConnection(DeletePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to delete a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(DeletePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to delete a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(DeletePrivateConnectionRequest request, st::CancellationToken cancellationToken) =>
            DeletePrivateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePrivateConnection</c>.</summary>
        public virtual lro::OperationsClient DeletePrivateConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePrivateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeletePrivateConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePrivateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePrivateConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeletePrivateConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePrivateConnectionOperationsClient, callSettings);

        /// <summary>
        /// Use this method to delete a private connectivity configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connectivity configuration to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePrivateConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateConnection(new DeletePrivateConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a private connectivity configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connectivity configuration to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateConnectionAsync(new DeletePrivateConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a private connectivity configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connectivity configuration to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePrivateConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to delete a private connectivity configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connectivity configuration to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePrivateConnection(PrivateConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateConnection(new DeletePrivateConnectionRequest
            {
                PrivateConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a private connectivity configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connectivity configuration to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(PrivateConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateConnectionAsync(new DeletePrivateConnectionRequest
            {
                PrivateConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a private connectivity configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the private connectivity configuration to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(PrivateConnectionName name, st::CancellationToken cancellationToken) =>
            DeletePrivateConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to create a route for a private connectivity configuration
        /// in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Route, OperationMetadata> CreateRoute(CreateRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to create a route for a private connectivity configuration
        /// in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Route, OperationMetadata>> CreateRouteAsync(CreateRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to create a route for a private connectivity configuration
        /// in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Route, OperationMetadata>> CreateRouteAsync(CreateRouteRequest request, st::CancellationToken cancellationToken) =>
            CreateRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRoute</c>.</summary>
        public virtual lro::OperationsClient CreateRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Route, OperationMetadata> PollOnceCreateRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Route, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Route, OperationMetadata>> PollOnceCreateRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Route, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRouteOperationsClient, callSettings);

        /// <summary>
        /// Use this method to create a route for a private connectivity configuration
        /// in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of Routes.
        /// </param>
        /// <param name="route">
        /// Required. The Route resource to create.
        /// </param>
        /// <param name="routeId">
        /// Required. The Route identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Route, OperationMetadata> CreateRoute(string parent, Route route, string routeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRoute(new CreateRouteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(routeId, nameof(routeId)),
                Route = gax::GaxPreconditions.CheckNotNull(route, nameof(route)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a route for a private connectivity configuration
        /// in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of Routes.
        /// </param>
        /// <param name="route">
        /// Required. The Route resource to create.
        /// </param>
        /// <param name="routeId">
        /// Required. The Route identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Route, OperationMetadata>> CreateRouteAsync(string parent, Route route, string routeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRouteAsync(new CreateRouteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(routeId, nameof(routeId)),
                Route = gax::GaxPreconditions.CheckNotNull(route, nameof(route)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a route for a private connectivity configuration
        /// in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of Routes.
        /// </param>
        /// <param name="route">
        /// Required. The Route resource to create.
        /// </param>
        /// <param name="routeId">
        /// Required. The Route identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Route, OperationMetadata>> CreateRouteAsync(string parent, Route route, string routeId, st::CancellationToken cancellationToken) =>
            CreateRouteAsync(parent, route, routeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to create a route for a private connectivity configuration
        /// in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of Routes.
        /// </param>
        /// <param name="route">
        /// Required. The Route resource to create.
        /// </param>
        /// <param name="routeId">
        /// Required. The Route identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Route, OperationMetadata> CreateRoute(PrivateConnectionName parent, Route route, string routeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRoute(new CreateRouteRequest
            {
                ParentAsPrivateConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(routeId, nameof(routeId)),
                Route = gax::GaxPreconditions.CheckNotNull(route, nameof(route)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a route for a private connectivity configuration
        /// in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of Routes.
        /// </param>
        /// <param name="route">
        /// Required. The Route resource to create.
        /// </param>
        /// <param name="routeId">
        /// Required. The Route identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Route, OperationMetadata>> CreateRouteAsync(PrivateConnectionName parent, Route route, string routeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRouteAsync(new CreateRouteRequest
            {
                ParentAsPrivateConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(routeId, nameof(routeId)),
                Route = gax::GaxPreconditions.CheckNotNull(route, nameof(route)),
            }, callSettings);

        /// <summary>
        /// Use this method to create a route for a private connectivity configuration
        /// in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of Routes.
        /// </param>
        /// <param name="route">
        /// Required. The Route resource to create.
        /// </param>
        /// <param name="routeId">
        /// Required. The Route identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Route, OperationMetadata>> CreateRouteAsync(PrivateConnectionName parent, Route route, string routeId, st::CancellationToken cancellationToken) =>
            CreateRouteAsync(parent, route, routeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to get details about a route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Route GetRoute(GetRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to get details about a route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Route> GetRouteAsync(GetRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to get details about a route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Route> GetRouteAsync(GetRouteRequest request, st::CancellationToken cancellationToken) =>
            GetRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to get details about a route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Route resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Route GetRoute(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRoute(new GetRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Route resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Route> GetRouteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRouteAsync(new GetRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Route resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Route> GetRouteAsync(string name, st::CancellationToken cancellationToken) =>
            GetRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to get details about a route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Route resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Route GetRoute(RouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRoute(new GetRouteRequest
            {
                RouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Route resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Route> GetRouteAsync(RouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRouteAsync(new GetRouteRequest
            {
                RouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to get details about a route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Route resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Route> GetRouteAsync(RouteName name, st::CancellationToken cancellationToken) =>
            GetRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to list routes created for a private connectivity
        /// configuration in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Route"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRoutesResponse, Route> ListRoutes(ListRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to list routes created for a private connectivity
        /// configuration in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Route"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRoutesResponse, Route> ListRoutesAsync(ListRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to list routes created for a private connectivity
        /// configuration in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of Routess.
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
        /// <returns>A pageable sequence of <see cref="Route"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRoutesResponse, Route> ListRoutes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRoutesRequest request = new ListRoutesRequest
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
            return ListRoutes(request, callSettings);
        }

        /// <summary>
        /// Use this method to list routes created for a private connectivity
        /// configuration in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of Routess.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Route"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRoutesResponse, Route> ListRoutesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRoutesRequest request = new ListRoutesRequest
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
            return ListRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Use this method to list routes created for a private connectivity
        /// configuration in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of Routess.
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
        /// <returns>A pageable sequence of <see cref="Route"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRoutesResponse, Route> ListRoutes(PrivateConnectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRoutesRequest request = new ListRoutesRequest
            {
                ParentAsPrivateConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRoutes(request, callSettings);
        }

        /// <summary>
        /// Use this method to list routes created for a private connectivity
        /// configuration in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns the collection of Routess.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Route"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRoutesResponse, Route> ListRoutesAsync(PrivateConnectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRoutesRequest request = new ListRoutesRequest
            {
                ParentAsPrivateConnectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Use this method to delete a route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRoute(DeleteRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to delete a route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouteAsync(DeleteRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Use this method to delete a route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouteAsync(DeleteRouteRequest request, st::CancellationToken cancellationToken) =>
            DeleteRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRoute</c>.</summary>
        public virtual lro::OperationsClient DeleteRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRouteOperationsClient, callSettings);

        /// <summary>
        /// Use this method to delete a route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Route resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRoute(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRoute(new DeleteRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Route resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRouteAsync(new DeleteRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Route resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouteAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Use this method to delete a route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Route resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRoute(RouteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRoute(new DeleteRouteRequest
            {
                RouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Route resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouteAsync(RouteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRouteAsync(new DeleteRouteRequest
            {
                RouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Use this method to delete a route.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Route resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouteAsync(RouteName name, st::CancellationToken cancellationToken) =>
            DeleteRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Datastream client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Datastream service
    /// </remarks>
    public sealed partial class DatastreamClientImpl : DatastreamClient
    {
        private readonly gaxgrpc::ApiCall<ListConnectionProfilesRequest, ListConnectionProfilesResponse> _callListConnectionProfiles;

        private readonly gaxgrpc::ApiCall<GetConnectionProfileRequest, ConnectionProfile> _callGetConnectionProfile;

        private readonly gaxgrpc::ApiCall<CreateConnectionProfileRequest, lro::Operation> _callCreateConnectionProfile;

        private readonly gaxgrpc::ApiCall<UpdateConnectionProfileRequest, lro::Operation> _callUpdateConnectionProfile;

        private readonly gaxgrpc::ApiCall<DeleteConnectionProfileRequest, lro::Operation> _callDeleteConnectionProfile;

        private readonly gaxgrpc::ApiCall<DiscoverConnectionProfileRequest, DiscoverConnectionProfileResponse> _callDiscoverConnectionProfile;

        private readonly gaxgrpc::ApiCall<ListStreamsRequest, ListStreamsResponse> _callListStreams;

        private readonly gaxgrpc::ApiCall<GetStreamRequest, Stream> _callGetStream;

        private readonly gaxgrpc::ApiCall<CreateStreamRequest, lro::Operation> _callCreateStream;

        private readonly gaxgrpc::ApiCall<UpdateStreamRequest, lro::Operation> _callUpdateStream;

        private readonly gaxgrpc::ApiCall<DeleteStreamRequest, lro::Operation> _callDeleteStream;

        private readonly gaxgrpc::ApiCall<RunStreamRequest, lro::Operation> _callRunStream;

        private readonly gaxgrpc::ApiCall<GetStreamObjectRequest, StreamObject> _callGetStreamObject;

        private readonly gaxgrpc::ApiCall<LookupStreamObjectRequest, StreamObject> _callLookupStreamObject;

        private readonly gaxgrpc::ApiCall<ListStreamObjectsRequest, ListStreamObjectsResponse> _callListStreamObjects;

        private readonly gaxgrpc::ApiCall<StartBackfillJobRequest, StartBackfillJobResponse> _callStartBackfillJob;

        private readonly gaxgrpc::ApiCall<StopBackfillJobRequest, StopBackfillJobResponse> _callStopBackfillJob;

        private readonly gaxgrpc::ApiCall<FetchStaticIpsRequest, FetchStaticIpsResponse> _callFetchStaticIps;

        private readonly gaxgrpc::ApiCall<CreatePrivateConnectionRequest, lro::Operation> _callCreatePrivateConnection;

        private readonly gaxgrpc::ApiCall<GetPrivateConnectionRequest, PrivateConnection> _callGetPrivateConnection;

        private readonly gaxgrpc::ApiCall<ListPrivateConnectionsRequest, ListPrivateConnectionsResponse> _callListPrivateConnections;

        private readonly gaxgrpc::ApiCall<DeletePrivateConnectionRequest, lro::Operation> _callDeletePrivateConnection;

        private readonly gaxgrpc::ApiCall<CreateRouteRequest, lro::Operation> _callCreateRoute;

        private readonly gaxgrpc::ApiCall<GetRouteRequest, Route> _callGetRoute;

        private readonly gaxgrpc::ApiCall<ListRoutesRequest, ListRoutesResponse> _callListRoutes;

        private readonly gaxgrpc::ApiCall<DeleteRouteRequest, lro::Operation> _callDeleteRoute;

        /// <summary>
        /// Constructs a client wrapper for the Datastream service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DatastreamSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DatastreamClientImpl(Datastream.DatastreamClient grpcClient, DatastreamSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DatastreamSettings effectiveSettings = settings ?? DatastreamSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateConnectionProfileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConnectionProfileOperationsSettings, logger);
            UpdateConnectionProfileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateConnectionProfileOperationsSettings, logger);
            DeleteConnectionProfileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConnectionProfileOperationsSettings, logger);
            CreateStreamOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateStreamOperationsSettings, logger);
            UpdateStreamOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateStreamOperationsSettings, logger);
            DeleteStreamOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteStreamOperationsSettings, logger);
            RunStreamOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunStreamOperationsSettings, logger);
            CreatePrivateConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePrivateConnectionOperationsSettings, logger);
            DeletePrivateConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePrivateConnectionOperationsSettings, logger);
            CreateRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRouteOperationsSettings, logger);
            DeleteRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRouteOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListConnectionProfiles = clientHelper.BuildApiCall<ListConnectionProfilesRequest, ListConnectionProfilesResponse>("ListConnectionProfiles", grpcClient.ListConnectionProfilesAsync, grpcClient.ListConnectionProfiles, effectiveSettings.ListConnectionProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConnectionProfiles);
            Modify_ListConnectionProfilesApiCall(ref _callListConnectionProfiles);
            _callGetConnectionProfile = clientHelper.BuildApiCall<GetConnectionProfileRequest, ConnectionProfile>("GetConnectionProfile", grpcClient.GetConnectionProfileAsync, grpcClient.GetConnectionProfile, effectiveSettings.GetConnectionProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnectionProfile);
            Modify_GetConnectionProfileApiCall(ref _callGetConnectionProfile);
            _callCreateConnectionProfile = clientHelper.BuildApiCall<CreateConnectionProfileRequest, lro::Operation>("CreateConnectionProfile", grpcClient.CreateConnectionProfileAsync, grpcClient.CreateConnectionProfile, effectiveSettings.CreateConnectionProfileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConnectionProfile);
            Modify_CreateConnectionProfileApiCall(ref _callCreateConnectionProfile);
            _callUpdateConnectionProfile = clientHelper.BuildApiCall<UpdateConnectionProfileRequest, lro::Operation>("UpdateConnectionProfile", grpcClient.UpdateConnectionProfileAsync, grpcClient.UpdateConnectionProfile, effectiveSettings.UpdateConnectionProfileSettings).WithGoogleRequestParam("connection_profile.name", request => request.ConnectionProfile?.Name);
            Modify_ApiCall(ref _callUpdateConnectionProfile);
            Modify_UpdateConnectionProfileApiCall(ref _callUpdateConnectionProfile);
            _callDeleteConnectionProfile = clientHelper.BuildApiCall<DeleteConnectionProfileRequest, lro::Operation>("DeleteConnectionProfile", grpcClient.DeleteConnectionProfileAsync, grpcClient.DeleteConnectionProfile, effectiveSettings.DeleteConnectionProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConnectionProfile);
            Modify_DeleteConnectionProfileApiCall(ref _callDeleteConnectionProfile);
            _callDiscoverConnectionProfile = clientHelper.BuildApiCall<DiscoverConnectionProfileRequest, DiscoverConnectionProfileResponse>("DiscoverConnectionProfile", grpcClient.DiscoverConnectionProfileAsync, grpcClient.DiscoverConnectionProfile, effectiveSettings.DiscoverConnectionProfileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callDiscoverConnectionProfile);
            Modify_DiscoverConnectionProfileApiCall(ref _callDiscoverConnectionProfile);
            _callListStreams = clientHelper.BuildApiCall<ListStreamsRequest, ListStreamsResponse>("ListStreams", grpcClient.ListStreamsAsync, grpcClient.ListStreams, effectiveSettings.ListStreamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListStreams);
            Modify_ListStreamsApiCall(ref _callListStreams);
            _callGetStream = clientHelper.BuildApiCall<GetStreamRequest, Stream>("GetStream", grpcClient.GetStreamAsync, grpcClient.GetStream, effectiveSettings.GetStreamSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetStream);
            Modify_GetStreamApiCall(ref _callGetStream);
            _callCreateStream = clientHelper.BuildApiCall<CreateStreamRequest, lro::Operation>("CreateStream", grpcClient.CreateStreamAsync, grpcClient.CreateStream, effectiveSettings.CreateStreamSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateStream);
            Modify_CreateStreamApiCall(ref _callCreateStream);
            _callUpdateStream = clientHelper.BuildApiCall<UpdateStreamRequest, lro::Operation>("UpdateStream", grpcClient.UpdateStreamAsync, grpcClient.UpdateStream, effectiveSettings.UpdateStreamSettings).WithGoogleRequestParam("stream.name", request => request.Stream?.Name);
            Modify_ApiCall(ref _callUpdateStream);
            Modify_UpdateStreamApiCall(ref _callUpdateStream);
            _callDeleteStream = clientHelper.BuildApiCall<DeleteStreamRequest, lro::Operation>("DeleteStream", grpcClient.DeleteStreamAsync, grpcClient.DeleteStream, effectiveSettings.DeleteStreamSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteStream);
            Modify_DeleteStreamApiCall(ref _callDeleteStream);
            _callRunStream = clientHelper.BuildApiCall<RunStreamRequest, lro::Operation>("RunStream", grpcClient.RunStreamAsync, grpcClient.RunStream, effectiveSettings.RunStreamSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRunStream);
            Modify_RunStreamApiCall(ref _callRunStream);
            _callGetStreamObject = clientHelper.BuildApiCall<GetStreamObjectRequest, StreamObject>("GetStreamObject", grpcClient.GetStreamObjectAsync, grpcClient.GetStreamObject, effectiveSettings.GetStreamObjectSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetStreamObject);
            Modify_GetStreamObjectApiCall(ref _callGetStreamObject);
            _callLookupStreamObject = clientHelper.BuildApiCall<LookupStreamObjectRequest, StreamObject>("LookupStreamObject", grpcClient.LookupStreamObjectAsync, grpcClient.LookupStreamObject, effectiveSettings.LookupStreamObjectSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callLookupStreamObject);
            Modify_LookupStreamObjectApiCall(ref _callLookupStreamObject);
            _callListStreamObjects = clientHelper.BuildApiCall<ListStreamObjectsRequest, ListStreamObjectsResponse>("ListStreamObjects", grpcClient.ListStreamObjectsAsync, grpcClient.ListStreamObjects, effectiveSettings.ListStreamObjectsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListStreamObjects);
            Modify_ListStreamObjectsApiCall(ref _callListStreamObjects);
            _callStartBackfillJob = clientHelper.BuildApiCall<StartBackfillJobRequest, StartBackfillJobResponse>("StartBackfillJob", grpcClient.StartBackfillJobAsync, grpcClient.StartBackfillJob, effectiveSettings.StartBackfillJobSettings).WithGoogleRequestParam("object", request => request.Object);
            Modify_ApiCall(ref _callStartBackfillJob);
            Modify_StartBackfillJobApiCall(ref _callStartBackfillJob);
            _callStopBackfillJob = clientHelper.BuildApiCall<StopBackfillJobRequest, StopBackfillJobResponse>("StopBackfillJob", grpcClient.StopBackfillJobAsync, grpcClient.StopBackfillJob, effectiveSettings.StopBackfillJobSettings).WithGoogleRequestParam("object", request => request.Object);
            Modify_ApiCall(ref _callStopBackfillJob);
            Modify_StopBackfillJobApiCall(ref _callStopBackfillJob);
            _callFetchStaticIps = clientHelper.BuildApiCall<FetchStaticIpsRequest, FetchStaticIpsResponse>("FetchStaticIps", grpcClient.FetchStaticIpsAsync, grpcClient.FetchStaticIps, effectiveSettings.FetchStaticIpsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFetchStaticIps);
            Modify_FetchStaticIpsApiCall(ref _callFetchStaticIps);
            _callCreatePrivateConnection = clientHelper.BuildApiCall<CreatePrivateConnectionRequest, lro::Operation>("CreatePrivateConnection", grpcClient.CreatePrivateConnectionAsync, grpcClient.CreatePrivateConnection, effectiveSettings.CreatePrivateConnectionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePrivateConnection);
            Modify_CreatePrivateConnectionApiCall(ref _callCreatePrivateConnection);
            _callGetPrivateConnection = clientHelper.BuildApiCall<GetPrivateConnectionRequest, PrivateConnection>("GetPrivateConnection", grpcClient.GetPrivateConnectionAsync, grpcClient.GetPrivateConnection, effectiveSettings.GetPrivateConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPrivateConnection);
            Modify_GetPrivateConnectionApiCall(ref _callGetPrivateConnection);
            _callListPrivateConnections = clientHelper.BuildApiCall<ListPrivateConnectionsRequest, ListPrivateConnectionsResponse>("ListPrivateConnections", grpcClient.ListPrivateConnectionsAsync, grpcClient.ListPrivateConnections, effectiveSettings.ListPrivateConnectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPrivateConnections);
            Modify_ListPrivateConnectionsApiCall(ref _callListPrivateConnections);
            _callDeletePrivateConnection = clientHelper.BuildApiCall<DeletePrivateConnectionRequest, lro::Operation>("DeletePrivateConnection", grpcClient.DeletePrivateConnectionAsync, grpcClient.DeletePrivateConnection, effectiveSettings.DeletePrivateConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePrivateConnection);
            Modify_DeletePrivateConnectionApiCall(ref _callDeletePrivateConnection);
            _callCreateRoute = clientHelper.BuildApiCall<CreateRouteRequest, lro::Operation>("CreateRoute", grpcClient.CreateRouteAsync, grpcClient.CreateRoute, effectiveSettings.CreateRouteSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRoute);
            Modify_CreateRouteApiCall(ref _callCreateRoute);
            _callGetRoute = clientHelper.BuildApiCall<GetRouteRequest, Route>("GetRoute", grpcClient.GetRouteAsync, grpcClient.GetRoute, effectiveSettings.GetRouteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRoute);
            Modify_GetRouteApiCall(ref _callGetRoute);
            _callListRoutes = clientHelper.BuildApiCall<ListRoutesRequest, ListRoutesResponse>("ListRoutes", grpcClient.ListRoutesAsync, grpcClient.ListRoutes, effectiveSettings.ListRoutesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRoutes);
            Modify_ListRoutesApiCall(ref _callListRoutes);
            _callDeleteRoute = clientHelper.BuildApiCall<DeleteRouteRequest, lro::Operation>("DeleteRoute", grpcClient.DeleteRouteAsync, grpcClient.DeleteRoute, effectiveSettings.DeleteRouteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRoute);
            Modify_DeleteRouteApiCall(ref _callDeleteRoute);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListConnectionProfilesApiCall(ref gaxgrpc::ApiCall<ListConnectionProfilesRequest, ListConnectionProfilesResponse> call);

        partial void Modify_GetConnectionProfileApiCall(ref gaxgrpc::ApiCall<GetConnectionProfileRequest, ConnectionProfile> call);

        partial void Modify_CreateConnectionProfileApiCall(ref gaxgrpc::ApiCall<CreateConnectionProfileRequest, lro::Operation> call);

        partial void Modify_UpdateConnectionProfileApiCall(ref gaxgrpc::ApiCall<UpdateConnectionProfileRequest, lro::Operation> call);

        partial void Modify_DeleteConnectionProfileApiCall(ref gaxgrpc::ApiCall<DeleteConnectionProfileRequest, lro::Operation> call);

        partial void Modify_DiscoverConnectionProfileApiCall(ref gaxgrpc::ApiCall<DiscoverConnectionProfileRequest, DiscoverConnectionProfileResponse> call);

        partial void Modify_ListStreamsApiCall(ref gaxgrpc::ApiCall<ListStreamsRequest, ListStreamsResponse> call);

        partial void Modify_GetStreamApiCall(ref gaxgrpc::ApiCall<GetStreamRequest, Stream> call);

        partial void Modify_CreateStreamApiCall(ref gaxgrpc::ApiCall<CreateStreamRequest, lro::Operation> call);

        partial void Modify_UpdateStreamApiCall(ref gaxgrpc::ApiCall<UpdateStreamRequest, lro::Operation> call);

        partial void Modify_DeleteStreamApiCall(ref gaxgrpc::ApiCall<DeleteStreamRequest, lro::Operation> call);

        partial void Modify_RunStreamApiCall(ref gaxgrpc::ApiCall<RunStreamRequest, lro::Operation> call);

        partial void Modify_GetStreamObjectApiCall(ref gaxgrpc::ApiCall<GetStreamObjectRequest, StreamObject> call);

        partial void Modify_LookupStreamObjectApiCall(ref gaxgrpc::ApiCall<LookupStreamObjectRequest, StreamObject> call);

        partial void Modify_ListStreamObjectsApiCall(ref gaxgrpc::ApiCall<ListStreamObjectsRequest, ListStreamObjectsResponse> call);

        partial void Modify_StartBackfillJobApiCall(ref gaxgrpc::ApiCall<StartBackfillJobRequest, StartBackfillJobResponse> call);

        partial void Modify_StopBackfillJobApiCall(ref gaxgrpc::ApiCall<StopBackfillJobRequest, StopBackfillJobResponse> call);

        partial void Modify_FetchStaticIpsApiCall(ref gaxgrpc::ApiCall<FetchStaticIpsRequest, FetchStaticIpsResponse> call);

        partial void Modify_CreatePrivateConnectionApiCall(ref gaxgrpc::ApiCall<CreatePrivateConnectionRequest, lro::Operation> call);

        partial void Modify_GetPrivateConnectionApiCall(ref gaxgrpc::ApiCall<GetPrivateConnectionRequest, PrivateConnection> call);

        partial void Modify_ListPrivateConnectionsApiCall(ref gaxgrpc::ApiCall<ListPrivateConnectionsRequest, ListPrivateConnectionsResponse> call);

        partial void Modify_DeletePrivateConnectionApiCall(ref gaxgrpc::ApiCall<DeletePrivateConnectionRequest, lro::Operation> call);

        partial void Modify_CreateRouteApiCall(ref gaxgrpc::ApiCall<CreateRouteRequest, lro::Operation> call);

        partial void Modify_GetRouteApiCall(ref gaxgrpc::ApiCall<GetRouteRequest, Route> call);

        partial void Modify_ListRoutesApiCall(ref gaxgrpc::ApiCall<ListRoutesRequest, ListRoutesResponse> call);

        partial void Modify_DeleteRouteApiCall(ref gaxgrpc::ApiCall<DeleteRouteRequest, lro::Operation> call);

        partial void OnConstruction(Datastream.DatastreamClient grpcClient, DatastreamSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Datastream client</summary>
        public override Datastream.DatastreamClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListConnectionProfilesRequest(ref ListConnectionProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectionProfileRequest(ref GetConnectionProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConnectionProfileRequest(ref CreateConnectionProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConnectionProfileRequest(ref UpdateConnectionProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConnectionProfileRequest(ref DeleteConnectionProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DiscoverConnectionProfileRequest(ref DiscoverConnectionProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListStreamsRequest(ref ListStreamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStreamRequest(ref GetStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateStreamRequest(ref CreateStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateStreamRequest(ref UpdateStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteStreamRequest(ref DeleteStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunStreamRequest(ref RunStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStreamObjectRequest(ref GetStreamObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupStreamObjectRequest(ref LookupStreamObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListStreamObjectsRequest(ref ListStreamObjectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartBackfillJobRequest(ref StartBackfillJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopBackfillJobRequest(ref StopBackfillJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchStaticIpsRequest(ref FetchStaticIpsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePrivateConnectionRequest(ref CreatePrivateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPrivateConnectionRequest(ref GetPrivateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPrivateConnectionsRequest(ref ListPrivateConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePrivateConnectionRequest(ref DeletePrivateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRouteRequest(ref CreateRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRouteRequest(ref GetRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRoutesRequest(ref ListRoutesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRouteRequest(ref DeleteRouteRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Use this method to list connection profiles created in a project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public override gax::PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfiles(ListConnectionProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectionProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConnectionProfilesRequest, ListConnectionProfilesResponse, ConnectionProfile>(_callListConnectionProfiles, request, callSettings);
        }

        /// <summary>
        /// Use this method to list connection profiles created in a project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfilesAsync(ListConnectionProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectionProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConnectionProfilesRequest, ListConnectionProfilesResponse, ConnectionProfile>(_callListConnectionProfiles, request, callSettings);
        }

        /// <summary>
        /// Use this method to get details about a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConnectionProfile GetConnectionProfile(GetConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionProfileRequest(ref request, ref callSettings);
            return _callGetConnectionProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Use this method to get details about a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConnectionProfile> GetConnectionProfileAsync(GetConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionProfileRequest(ref request, ref callSettings);
            return _callGetConnectionProfile.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateConnectionProfile</c>.</summary>
        public override lro::OperationsClient CreateConnectionProfileOperationsClient { get; }

        /// <summary>
        /// Use this method to create a connection profile in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConnectionProfile, OperationMetadata> CreateConnectionProfile(CreateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionProfile, OperationMetadata>(_callCreateConnectionProfile.Sync(request, callSettings), CreateConnectionProfileOperationsClient);
        }

        /// <summary>
        /// Use this method to create a connection profile in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(CreateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionProfile, OperationMetadata>(await _callCreateConnectionProfile.Async(request, callSettings).ConfigureAwait(false), CreateConnectionProfileOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateConnectionProfile</c>.</summary>
        public override lro::OperationsClient UpdateConnectionProfileOperationsClient { get; }

        /// <summary>
        /// Use this method to update the parameters of a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConnectionProfile, OperationMetadata> UpdateConnectionProfile(UpdateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionProfile, OperationMetadata>(_callUpdateConnectionProfile.Sync(request, callSettings), UpdateConnectionProfileOperationsClient);
        }

        /// <summary>
        /// Use this method to update the parameters of a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(UpdateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionProfile, OperationMetadata>(await _callUpdateConnectionProfile.Async(request, callSettings).ConfigureAwait(false), UpdateConnectionProfileOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteConnectionProfile</c>.</summary>
        public override lro::OperationsClient DeleteConnectionProfileOperationsClient { get; }

        /// <summary>
        /// Use this method to delete a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectionProfile(DeleteConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteConnectionProfile.Sync(request, callSettings), DeleteConnectionProfileOperationsClient);
        }

        /// <summary>
        /// Use this method to delete a connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(DeleteConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteConnectionProfile.Async(request, callSettings).ConfigureAwait(false), DeleteConnectionProfileOperationsClient);
        }

        /// <summary>
        /// Use this method to discover a connection profile.
        /// The discover API call exposes the data objects and metadata belonging to
        /// the profile. Typically, a request returns children data objects of a
        /// parent data object that's optionally supplied in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiscoverConnectionProfileResponse DiscoverConnectionProfile(DiscoverConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiscoverConnectionProfileRequest(ref request, ref callSettings);
            return _callDiscoverConnectionProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Use this method to discover a connection profile.
        /// The discover API call exposes the data objects and metadata belonging to
        /// the profile. Typically, a request returns children data objects of a
        /// parent data object that's optionally supplied in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiscoverConnectionProfileResponse> DiscoverConnectionProfileAsync(DiscoverConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiscoverConnectionProfileRequest(ref request, ref callSettings);
            return _callDiscoverConnectionProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Use this method to list streams in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Stream"/> resources.</returns>
        public override gax::PagedEnumerable<ListStreamsResponse, Stream> ListStreams(ListStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStreamsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListStreamsRequest, ListStreamsResponse, Stream>(_callListStreams, request, callSettings);
        }

        /// <summary>
        /// Use this method to list streams in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Stream"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListStreamsResponse, Stream> ListStreamsAsync(ListStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStreamsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListStreamsRequest, ListStreamsResponse, Stream>(_callListStreams, request, callSettings);
        }

        /// <summary>
        /// Use this method to get details about a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Stream GetStream(GetStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStreamRequest(ref request, ref callSettings);
            return _callGetStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Use this method to get details about a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Stream> GetStreamAsync(GetStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStreamRequest(ref request, ref callSettings);
            return _callGetStream.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateStream</c>.</summary>
        public override lro::OperationsClient CreateStreamOperationsClient { get; }

        /// <summary>
        /// Use this method to create a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Stream, OperationMetadata> CreateStream(CreateStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStreamRequest(ref request, ref callSettings);
            return new lro::Operation<Stream, OperationMetadata>(_callCreateStream.Sync(request, callSettings), CreateStreamOperationsClient);
        }

        /// <summary>
        /// Use this method to create a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Stream, OperationMetadata>> CreateStreamAsync(CreateStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStreamRequest(ref request, ref callSettings);
            return new lro::Operation<Stream, OperationMetadata>(await _callCreateStream.Async(request, callSettings).ConfigureAwait(false), CreateStreamOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateStream</c>.</summary>
        public override lro::OperationsClient UpdateStreamOperationsClient { get; }

        /// <summary>
        /// Use this method to update the configuration of a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Stream, OperationMetadata> UpdateStream(UpdateStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStreamRequest(ref request, ref callSettings);
            return new lro::Operation<Stream, OperationMetadata>(_callUpdateStream.Sync(request, callSettings), UpdateStreamOperationsClient);
        }

        /// <summary>
        /// Use this method to update the configuration of a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Stream, OperationMetadata>> UpdateStreamAsync(UpdateStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStreamRequest(ref request, ref callSettings);
            return new lro::Operation<Stream, OperationMetadata>(await _callUpdateStream.Async(request, callSettings).ConfigureAwait(false), UpdateStreamOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteStream</c>.</summary>
        public override lro::OperationsClient DeleteStreamOperationsClient { get; }

        /// <summary>
        /// Use this method to delete a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteStream(DeleteStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStreamRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteStream.Sync(request, callSettings), DeleteStreamOperationsClient);
        }

        /// <summary>
        /// Use this method to delete a stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStreamAsync(DeleteStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStreamRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteStream.Async(request, callSettings).ConfigureAwait(false), DeleteStreamOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RunStream</c>.</summary>
        public override lro::OperationsClient RunStreamOperationsClient { get; }

        /// <summary>
        /// Use this method to start, resume or recover a stream with a non default CDC
        /// strategy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Stream, OperationMetadata> RunStream(RunStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunStreamRequest(ref request, ref callSettings);
            return new lro::Operation<Stream, OperationMetadata>(_callRunStream.Sync(request, callSettings), RunStreamOperationsClient);
        }

        /// <summary>
        /// Use this method to start, resume or recover a stream with a non default CDC
        /// strategy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Stream, OperationMetadata>> RunStreamAsync(RunStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunStreamRequest(ref request, ref callSettings);
            return new lro::Operation<Stream, OperationMetadata>(await _callRunStream.Async(request, callSettings).ConfigureAwait(false), RunStreamOperationsClient);
        }

        /// <summary>
        /// Use this method to get details about a stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StreamObject GetStreamObject(GetStreamObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStreamObjectRequest(ref request, ref callSettings);
            return _callGetStreamObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Use this method to get details about a stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StreamObject> GetStreamObjectAsync(GetStreamObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStreamObjectRequest(ref request, ref callSettings);
            return _callGetStreamObject.Async(request, callSettings);
        }

        /// <summary>
        /// Use this method to look up a stream object by its source object identifier.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StreamObject LookupStreamObject(LookupStreamObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupStreamObjectRequest(ref request, ref callSettings);
            return _callLookupStreamObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Use this method to look up a stream object by its source object identifier.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StreamObject> LookupStreamObjectAsync(LookupStreamObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupStreamObjectRequest(ref request, ref callSettings);
            return _callLookupStreamObject.Async(request, callSettings);
        }

        /// <summary>
        /// Use this method to list the objects of a specific stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StreamObject"/> resources.</returns>
        public override gax::PagedEnumerable<ListStreamObjectsResponse, StreamObject> ListStreamObjects(ListStreamObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStreamObjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListStreamObjectsRequest, ListStreamObjectsResponse, StreamObject>(_callListStreamObjects, request, callSettings);
        }

        /// <summary>
        /// Use this method to list the objects of a specific stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StreamObject"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListStreamObjectsResponse, StreamObject> ListStreamObjectsAsync(ListStreamObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStreamObjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListStreamObjectsRequest, ListStreamObjectsResponse, StreamObject>(_callListStreamObjects, request, callSettings);
        }

        /// <summary>
        /// Use this method to start a backfill job for the specified stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StartBackfillJobResponse StartBackfillJob(StartBackfillJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartBackfillJobRequest(ref request, ref callSettings);
            return _callStartBackfillJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Use this method to start a backfill job for the specified stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StartBackfillJobResponse> StartBackfillJobAsync(StartBackfillJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartBackfillJobRequest(ref request, ref callSettings);
            return _callStartBackfillJob.Async(request, callSettings);
        }

        /// <summary>
        /// Use this method to stop a backfill job for the specified stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StopBackfillJobResponse StopBackfillJob(StopBackfillJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopBackfillJobRequest(ref request, ref callSettings);
            return _callStopBackfillJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Use this method to stop a backfill job for the specified stream object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StopBackfillJobResponse> StopBackfillJobAsync(StopBackfillJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopBackfillJobRequest(ref request, ref callSettings);
            return _callStopBackfillJob.Async(request, callSettings);
        }

        /// <summary>
        /// The FetchStaticIps API call exposes the static IP addresses used by
        /// Datastream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<FetchStaticIpsResponse, string> FetchStaticIps(FetchStaticIpsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchStaticIpsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchStaticIpsRequest, FetchStaticIpsResponse, string>(_callFetchStaticIps, request, callSettings);
        }

        /// <summary>
        /// The FetchStaticIps API call exposes the static IP addresses used by
        /// Datastream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchStaticIpsResponse, string> FetchStaticIpsAsync(FetchStaticIpsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchStaticIpsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchStaticIpsRequest, FetchStaticIpsResponse, string>(_callFetchStaticIps, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreatePrivateConnection</c>.</summary>
        public override lro::OperationsClient CreatePrivateConnectionOperationsClient { get; }

        /// <summary>
        /// Use this method to create a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PrivateConnection, OperationMetadata> CreatePrivateConnection(CreatePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateConnection, OperationMetadata>(_callCreatePrivateConnection.Sync(request, callSettings), CreatePrivateConnectionOperationsClient);
        }

        /// <summary>
        /// Use this method to create a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PrivateConnection, OperationMetadata>> CreatePrivateConnectionAsync(CreatePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<PrivateConnection, OperationMetadata>(await _callCreatePrivateConnection.Async(request, callSettings).ConfigureAwait(false), CreatePrivateConnectionOperationsClient);
        }

        /// <summary>
        /// Use this method to get details about a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateConnection GetPrivateConnection(GetPrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateConnectionRequest(ref request, ref callSettings);
            return _callGetPrivateConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Use this method to get details about a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateConnection> GetPrivateConnectionAsync(GetPrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateConnectionRequest(ref request, ref callSettings);
            return _callGetPrivateConnection.Async(request, callSettings);
        }

        /// <summary>
        /// Use this method to list private connectivity configurations in a project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateConnection"/> resources.</returns>
        public override gax::PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnections(ListPrivateConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPrivateConnectionsRequest, ListPrivateConnectionsResponse, PrivateConnection>(_callListPrivateConnections, request, callSettings);
        }

        /// <summary>
        /// Use this method to list private connectivity configurations in a project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateConnection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> ListPrivateConnectionsAsync(ListPrivateConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPrivateConnectionsRequest, ListPrivateConnectionsResponse, PrivateConnection>(_callListPrivateConnections, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeletePrivateConnection</c>.</summary>
        public override lro::OperationsClient DeletePrivateConnectionOperationsClient { get; }

        /// <summary>
        /// Use this method to delete a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeletePrivateConnection(DeletePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePrivateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeletePrivateConnection.Sync(request, callSettings), DeletePrivateConnectionOperationsClient);
        }

        /// <summary>
        /// Use this method to delete a private connectivity configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrivateConnectionAsync(DeletePrivateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePrivateConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeletePrivateConnection.Async(request, callSettings).ConfigureAwait(false), DeletePrivateConnectionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateRoute</c>.</summary>
        public override lro::OperationsClient CreateRouteOperationsClient { get; }

        /// <summary>
        /// Use this method to create a route for a private connectivity configuration
        /// in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Route, OperationMetadata> CreateRoute(CreateRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRouteRequest(ref request, ref callSettings);
            return new lro::Operation<Route, OperationMetadata>(_callCreateRoute.Sync(request, callSettings), CreateRouteOperationsClient);
        }

        /// <summary>
        /// Use this method to create a route for a private connectivity configuration
        /// in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Route, OperationMetadata>> CreateRouteAsync(CreateRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRouteRequest(ref request, ref callSettings);
            return new lro::Operation<Route, OperationMetadata>(await _callCreateRoute.Async(request, callSettings).ConfigureAwait(false), CreateRouteOperationsClient);
        }

        /// <summary>
        /// Use this method to get details about a route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Route GetRoute(GetRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRouteRequest(ref request, ref callSettings);
            return _callGetRoute.Sync(request, callSettings);
        }

        /// <summary>
        /// Use this method to get details about a route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Route> GetRouteAsync(GetRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRouteRequest(ref request, ref callSettings);
            return _callGetRoute.Async(request, callSettings);
        }

        /// <summary>
        /// Use this method to list routes created for a private connectivity
        /// configuration in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Route"/> resources.</returns>
        public override gax::PagedEnumerable<ListRoutesResponse, Route> ListRoutes(ListRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRoutesRequest, ListRoutesResponse, Route>(_callListRoutes, request, callSettings);
        }

        /// <summary>
        /// Use this method to list routes created for a private connectivity
        /// configuration in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Route"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRoutesResponse, Route> ListRoutesAsync(ListRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRoutesRequest, ListRoutesResponse, Route>(_callListRoutes, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteRoute</c>.</summary>
        public override lro::OperationsClient DeleteRouteOperationsClient { get; }

        /// <summary>
        /// Use this method to delete a route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteRoute(DeleteRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRouteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteRoute.Sync(request, callSettings), DeleteRouteOperationsClient);
        }

        /// <summary>
        /// Use this method to delete a route.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRouteAsync(DeleteRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRouteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteRoute.Async(request, callSettings).ConfigureAwait(false), DeleteRouteOperationsClient);
        }
    }

    public partial class ListConnectionProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListStreamsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListStreamObjectsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchStaticIpsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPrivateConnectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRoutesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectionProfilesResponse : gaxgrpc::IPageResponse<ConnectionProfile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConnectionProfile> GetEnumerator() => ConnectionProfiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListStreamsResponse : gaxgrpc::IPageResponse<Stream>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Stream> GetEnumerator() => Streams.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListStreamObjectsResponse : gaxgrpc::IPageResponse<StreamObject>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<StreamObject> GetEnumerator() => StreamObjects.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchStaticIpsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => StaticIps.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPrivateConnectionsResponse : gaxgrpc::IPageResponse<PrivateConnection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PrivateConnection> GetEnumerator() => PrivateConnections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRoutesResponse : gaxgrpc::IPageResponse<Route>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Route> GetEnumerator() => Routes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Datastream
    {
        public partial class DatastreamClient
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

    public static partial class Datastream
    {
        public partial class DatastreamClient
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
