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

namespace Google.Cloud.Eventarc.V1
{
    /// <summary>Settings for <see cref="EventarcClient"/> instances.</summary>
    public sealed partial class EventarcSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EventarcSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EventarcSettings"/>.</returns>
        public static EventarcSettings GetDefault() => new EventarcSettings();

        /// <summary>Constructs a new <see cref="EventarcSettings"/> object with default settings.</summary>
        public EventarcSettings()
        {
        }

        private EventarcSettings(EventarcSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetTriggerSettings = existing.GetTriggerSettings;
            ListTriggersSettings = existing.ListTriggersSettings;
            CreateTriggerSettings = existing.CreateTriggerSettings;
            CreateTriggerOperationsSettings = existing.CreateTriggerOperationsSettings.Clone();
            UpdateTriggerSettings = existing.UpdateTriggerSettings;
            UpdateTriggerOperationsSettings = existing.UpdateTriggerOperationsSettings.Clone();
            DeleteTriggerSettings = existing.DeleteTriggerSettings;
            DeleteTriggerOperationsSettings = existing.DeleteTriggerOperationsSettings.Clone();
            GetChannelSettings = existing.GetChannelSettings;
            ListChannelsSettings = existing.ListChannelsSettings;
            CreateChannelSettings = existing.CreateChannelSettings;
            CreateChannelOperationsSettings = existing.CreateChannelOperationsSettings.Clone();
            UpdateChannelSettings = existing.UpdateChannelSettings;
            UpdateChannelOperationsSettings = existing.UpdateChannelOperationsSettings.Clone();
            DeleteChannelSettings = existing.DeleteChannelSettings;
            DeleteChannelOperationsSettings = existing.DeleteChannelOperationsSettings.Clone();
            GetProviderSettings = existing.GetProviderSettings;
            ListProvidersSettings = existing.ListProvidersSettings;
            GetChannelConnectionSettings = existing.GetChannelConnectionSettings;
            ListChannelConnectionsSettings = existing.ListChannelConnectionsSettings;
            CreateChannelConnectionSettings = existing.CreateChannelConnectionSettings;
            CreateChannelConnectionOperationsSettings = existing.CreateChannelConnectionOperationsSettings.Clone();
            DeleteChannelConnectionSettings = existing.DeleteChannelConnectionSettings;
            DeleteChannelConnectionOperationsSettings = existing.DeleteChannelConnectionOperationsSettings.Clone();
            GetGoogleChannelConfigSettings = existing.GetGoogleChannelConfigSettings;
            UpdateGoogleChannelConfigSettings = existing.UpdateGoogleChannelConfigSettings;
            GetMessageBusSettings = existing.GetMessageBusSettings;
            ListMessageBusesSettings = existing.ListMessageBusesSettings;
            ListMessageBusEnrollmentsSettings = existing.ListMessageBusEnrollmentsSettings;
            CreateMessageBusSettings = existing.CreateMessageBusSettings;
            CreateMessageBusOperationsSettings = existing.CreateMessageBusOperationsSettings.Clone();
            UpdateMessageBusSettings = existing.UpdateMessageBusSettings;
            UpdateMessageBusOperationsSettings = existing.UpdateMessageBusOperationsSettings.Clone();
            DeleteMessageBusSettings = existing.DeleteMessageBusSettings;
            DeleteMessageBusOperationsSettings = existing.DeleteMessageBusOperationsSettings.Clone();
            GetEnrollmentSettings = existing.GetEnrollmentSettings;
            ListEnrollmentsSettings = existing.ListEnrollmentsSettings;
            CreateEnrollmentSettings = existing.CreateEnrollmentSettings;
            CreateEnrollmentOperationsSettings = existing.CreateEnrollmentOperationsSettings.Clone();
            UpdateEnrollmentSettings = existing.UpdateEnrollmentSettings;
            UpdateEnrollmentOperationsSettings = existing.UpdateEnrollmentOperationsSettings.Clone();
            DeleteEnrollmentSettings = existing.DeleteEnrollmentSettings;
            DeleteEnrollmentOperationsSettings = existing.DeleteEnrollmentOperationsSettings.Clone();
            GetPipelineSettings = existing.GetPipelineSettings;
            ListPipelinesSettings = existing.ListPipelinesSettings;
            CreatePipelineSettings = existing.CreatePipelineSettings;
            CreatePipelineOperationsSettings = existing.CreatePipelineOperationsSettings.Clone();
            UpdatePipelineSettings = existing.UpdatePipelineSettings;
            UpdatePipelineOperationsSettings = existing.UpdatePipelineOperationsSettings.Clone();
            DeletePipelineSettings = existing.DeletePipelineSettings;
            DeletePipelineOperationsSettings = existing.DeletePipelineOperationsSettings.Clone();
            GetGoogleApiSourceSettings = existing.GetGoogleApiSourceSettings;
            ListGoogleApiSourcesSettings = existing.ListGoogleApiSourcesSettings;
            CreateGoogleApiSourceSettings = existing.CreateGoogleApiSourceSettings;
            CreateGoogleApiSourceOperationsSettings = existing.CreateGoogleApiSourceOperationsSettings.Clone();
            UpdateGoogleApiSourceSettings = existing.UpdateGoogleApiSourceSettings;
            UpdateGoogleApiSourceOperationsSettings = existing.UpdateGoogleApiSourceOperationsSettings.Clone();
            DeleteGoogleApiSourceSettings = existing.DeleteGoogleApiSourceSettings;
            DeleteGoogleApiSourceOperationsSettings = existing.DeleteGoogleApiSourceOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(EventarcSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>EventarcClient.GetTrigger</c>
        ///  and <c>EventarcClient.GetTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTriggerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>EventarcClient.ListTriggers</c>
        ///  and <c>EventarcClient.ListTriggersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTriggersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.CreateTrigger</c> and <c>EventarcClient.CreateTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.CreateTrigger</c> and
        /// <c>EventarcClient.CreateTriggerAsync</c>.
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
        public lro::OperationsSettings CreateTriggerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.UpdateTrigger</c> and <c>EventarcClient.UpdateTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.UpdateTrigger</c> and
        /// <c>EventarcClient.UpdateTriggerAsync</c>.
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
        public lro::OperationsSettings UpdateTriggerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.DeleteTrigger</c> and <c>EventarcClient.DeleteTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.DeleteTrigger</c> and
        /// <c>EventarcClient.DeleteTriggerAsync</c>.
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
        public lro::OperationsSettings DeleteTriggerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>EventarcClient.GetChannel</c>
        ///  and <c>EventarcClient.GetChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetChannelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>EventarcClient.ListChannels</c>
        ///  and <c>EventarcClient.ListChannelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListChannelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.CreateChannel</c> and <c>EventarcClient.CreateChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateChannelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.CreateChannel</c> and
        /// <c>EventarcClient.CreateChannelAsync</c>.
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
        public lro::OperationsSettings CreateChannelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.UpdateChannel</c> and <c>EventarcClient.UpdateChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateChannelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.UpdateChannel</c> and
        /// <c>EventarcClient.UpdateChannelAsync</c>.
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
        public lro::OperationsSettings UpdateChannelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.DeleteChannel</c> and <c>EventarcClient.DeleteChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteChannelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.DeleteChannel</c> and
        /// <c>EventarcClient.DeleteChannelAsync</c>.
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
        public lro::OperationsSettings DeleteChannelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>EventarcClient.GetProvider</c>
        ///  and <c>EventarcClient.GetProviderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProviderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.ListProviders</c> and <c>EventarcClient.ListProvidersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProvidersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.GetChannelConnection</c> and <c>EventarcClient.GetChannelConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetChannelConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.ListChannelConnections</c> and <c>EventarcClient.ListChannelConnectionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListChannelConnectionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.CreateChannelConnection</c> and <c>EventarcClient.CreateChannelConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateChannelConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.CreateChannelConnection</c> and
        /// <c>EventarcClient.CreateChannelConnectionAsync</c>.
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
        public lro::OperationsSettings CreateChannelConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.DeleteChannelConnection</c> and <c>EventarcClient.DeleteChannelConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteChannelConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.DeleteChannelConnection</c> and
        /// <c>EventarcClient.DeleteChannelConnectionAsync</c>.
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
        public lro::OperationsSettings DeleteChannelConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.GetGoogleChannelConfig</c> and <c>EventarcClient.GetGoogleChannelConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGoogleChannelConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.UpdateGoogleChannelConfig</c> and <c>EventarcClient.UpdateGoogleChannelConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGoogleChannelConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.GetMessageBus</c> and <c>EventarcClient.GetMessageBusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMessageBusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.ListMessageBuses</c> and <c>EventarcClient.ListMessageBusesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMessageBusesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.ListMessageBusEnrollments</c> and <c>EventarcClient.ListMessageBusEnrollmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMessageBusEnrollmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.CreateMessageBus</c> and <c>EventarcClient.CreateMessageBusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMessageBusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.CreateMessageBus</c> and
        /// <c>EventarcClient.CreateMessageBusAsync</c>.
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
        public lro::OperationsSettings CreateMessageBusOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.UpdateMessageBus</c> and <c>EventarcClient.UpdateMessageBusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMessageBusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.UpdateMessageBus</c> and
        /// <c>EventarcClient.UpdateMessageBusAsync</c>.
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
        public lro::OperationsSettings UpdateMessageBusOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.DeleteMessageBus</c> and <c>EventarcClient.DeleteMessageBusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMessageBusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.DeleteMessageBus</c> and
        /// <c>EventarcClient.DeleteMessageBusAsync</c>.
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
        public lro::OperationsSettings DeleteMessageBusOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.GetEnrollment</c> and <c>EventarcClient.GetEnrollmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEnrollmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.ListEnrollments</c> and <c>EventarcClient.ListEnrollmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEnrollmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.CreateEnrollment</c> and <c>EventarcClient.CreateEnrollmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEnrollmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.CreateEnrollment</c> and
        /// <c>EventarcClient.CreateEnrollmentAsync</c>.
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
        public lro::OperationsSettings CreateEnrollmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.UpdateEnrollment</c> and <c>EventarcClient.UpdateEnrollmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEnrollmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.UpdateEnrollment</c> and
        /// <c>EventarcClient.UpdateEnrollmentAsync</c>.
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
        public lro::OperationsSettings UpdateEnrollmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.DeleteEnrollment</c> and <c>EventarcClient.DeleteEnrollmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEnrollmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.DeleteEnrollment</c> and
        /// <c>EventarcClient.DeleteEnrollmentAsync</c>.
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
        public lro::OperationsSettings DeleteEnrollmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>EventarcClient.GetPipeline</c>
        ///  and <c>EventarcClient.GetPipelineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPipelineSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.ListPipelines</c> and <c>EventarcClient.ListPipelinesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPipelinesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.CreatePipeline</c> and <c>EventarcClient.CreatePipelineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePipelineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.CreatePipeline</c> and
        /// <c>EventarcClient.CreatePipelineAsync</c>.
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
        public lro::OperationsSettings CreatePipelineOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.UpdatePipeline</c> and <c>EventarcClient.UpdatePipelineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePipelineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.UpdatePipeline</c> and
        /// <c>EventarcClient.UpdatePipelineAsync</c>.
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
        public lro::OperationsSettings UpdatePipelineOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.DeletePipeline</c> and <c>EventarcClient.DeletePipelineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePipelineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.DeletePipeline</c> and
        /// <c>EventarcClient.DeletePipelineAsync</c>.
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
        public lro::OperationsSettings DeletePipelineOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.GetGoogleApiSource</c> and <c>EventarcClient.GetGoogleApiSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGoogleApiSourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.ListGoogleApiSources</c> and <c>EventarcClient.ListGoogleApiSourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGoogleApiSourcesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.CreateGoogleApiSource</c> and <c>EventarcClient.CreateGoogleApiSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGoogleApiSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.CreateGoogleApiSource</c> and
        /// <c>EventarcClient.CreateGoogleApiSourceAsync</c>.
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
        public lro::OperationsSettings CreateGoogleApiSourceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.UpdateGoogleApiSource</c> and <c>EventarcClient.UpdateGoogleApiSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGoogleApiSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.UpdateGoogleApiSource</c> and
        /// <c>EventarcClient.UpdateGoogleApiSourceAsync</c>.
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
        public lro::OperationsSettings UpdateGoogleApiSourceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.DeleteGoogleApiSource</c> and <c>EventarcClient.DeleteGoogleApiSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGoogleApiSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.DeleteGoogleApiSource</c> and
        /// <c>EventarcClient.DeleteGoogleApiSourceAsync</c>.
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
        public lro::OperationsSettings DeleteGoogleApiSourceOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="EventarcSettings"/> object.</returns>
        public EventarcSettings Clone() => new EventarcSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EventarcClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class EventarcClientBuilder : gaxgrpc::ClientBuilderBase<EventarcClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EventarcSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EventarcClientBuilder() : base(EventarcClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EventarcClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EventarcClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EventarcClient Build()
        {
            EventarcClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EventarcClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EventarcClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EventarcClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EventarcClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EventarcClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EventarcClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EventarcClient.ChannelPool;
    }

    /// <summary>Eventarc client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Eventarc allows users to subscribe to various events that are provided by
    /// Google Cloud services and forward them to supported destinations.
    /// </remarks>
    public abstract partial class EventarcClient
    {
        /// <summary>
        /// The default endpoint for the Eventarc service, which is a host of "eventarc.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "eventarc.googleapis.com:443";

        /// <summary>The default Eventarc scopes.</summary>
        /// <remarks>
        /// The default Eventarc scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Eventarc.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EventarcClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="EventarcClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EventarcClient"/>.</returns>
        public static stt::Task<EventarcClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EventarcClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EventarcClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="EventarcClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EventarcClient"/>.</returns>
        public static EventarcClient Create() => new EventarcClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EventarcClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EventarcSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EventarcClient"/>.</returns>
        internal static EventarcClient Create(grpccore::CallInvoker callInvoker, EventarcSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Eventarc.EventarcClient grpcClient = new Eventarc.EventarcClient(callInvoker);
            return new EventarcClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Eventarc client</summary>
        public virtual Eventarc.EventarcClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trigger GetTrigger(GetTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trigger> GetTriggerAsync(GetTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trigger> GetTriggerAsync(GetTriggerRequest request, st::CancellationToken cancellationToken) =>
            GetTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trigger GetTrigger(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrigger(new GetTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trigger> GetTriggerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTriggerAsync(new GetTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trigger> GetTriggerAsync(string name, st::CancellationToken cancellationToken) =>
            GetTriggerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trigger GetTrigger(TriggerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrigger(new GetTriggerRequest
            {
                TriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trigger> GetTriggerAsync(TriggerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTriggerAsync(new GetTriggerRequest
            {
                TriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trigger> GetTriggerAsync(TriggerName name, st::CancellationToken cancellationToken) =>
            GetTriggerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Trigger"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTriggersResponse, Trigger> ListTriggers(ListTriggersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Trigger"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTriggersResponse, Trigger> ListTriggersAsync(ListTriggersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable sequence of <see cref="Trigger"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTriggersResponse, Trigger> ListTriggers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTriggersRequest request = new ListTriggersRequest
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
            return ListTriggers(request, callSettings);
        }

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Trigger"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTriggersResponse, Trigger> ListTriggersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTriggersRequest request = new ListTriggersRequest
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
            return ListTriggersAsync(request, callSettings);
        }

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable sequence of <see cref="Trigger"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTriggersResponse, Trigger> ListTriggers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTriggersRequest request = new ListTriggersRequest
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
            return ListTriggers(request, callSettings);
        }

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Trigger"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTriggersResponse, Trigger> ListTriggersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTriggersRequest request = new ListTriggersRequest
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
            return ListTriggersAsync(request, callSettings);
        }

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> CreateTrigger(CreateTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(CreateTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(CreateTriggerRequest request, st::CancellationToken cancellationToken) =>
            CreateTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTrigger</c>.</summary>
        public virtual lro::OperationsClient CreateTriggerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> PollOnceCreateTrigger(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Trigger, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTriggerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> PollOnceCreateTriggerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Trigger, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTriggerOperationsClient, callSettings);

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this trigger.
        /// </param>
        /// <param name="trigger">
        /// Required. The trigger to create.
        /// </param>
        /// <param name="triggerId">
        /// Required. The user-provided ID to be assigned to the trigger.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> CreateTrigger(string parent, Trigger trigger, string triggerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrigger(new CreateTriggerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Trigger = gax::GaxPreconditions.CheckNotNull(trigger, nameof(trigger)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
            }, callSettings);

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this trigger.
        /// </param>
        /// <param name="trigger">
        /// Required. The trigger to create.
        /// </param>
        /// <param name="triggerId">
        /// Required. The user-provided ID to be assigned to the trigger.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(string parent, Trigger trigger, string triggerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTriggerAsync(new CreateTriggerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Trigger = gax::GaxPreconditions.CheckNotNull(trigger, nameof(trigger)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
            }, callSettings);

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this trigger.
        /// </param>
        /// <param name="trigger">
        /// Required. The trigger to create.
        /// </param>
        /// <param name="triggerId">
        /// Required. The user-provided ID to be assigned to the trigger.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(string parent, Trigger trigger, string triggerId, st::CancellationToken cancellationToken) =>
            CreateTriggerAsync(parent, trigger, triggerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this trigger.
        /// </param>
        /// <param name="trigger">
        /// Required. The trigger to create.
        /// </param>
        /// <param name="triggerId">
        /// Required. The user-provided ID to be assigned to the trigger.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> CreateTrigger(gagr::LocationName parent, Trigger trigger, string triggerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrigger(new CreateTriggerRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Trigger = gax::GaxPreconditions.CheckNotNull(trigger, nameof(trigger)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
            }, callSettings);

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this trigger.
        /// </param>
        /// <param name="trigger">
        /// Required. The trigger to create.
        /// </param>
        /// <param name="triggerId">
        /// Required. The user-provided ID to be assigned to the trigger.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(gagr::LocationName parent, Trigger trigger, string triggerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTriggerAsync(new CreateTriggerRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Trigger = gax::GaxPreconditions.CheckNotNull(trigger, nameof(trigger)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
            }, callSettings);

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this trigger.
        /// </param>
        /// <param name="trigger">
        /// Required. The trigger to create.
        /// </param>
        /// <param name="triggerId">
        /// Required. The user-provided ID to be assigned to the trigger.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(gagr::LocationName parent, Trigger trigger, string triggerId, st::CancellationToken cancellationToken) =>
            CreateTriggerAsync(parent, trigger, triggerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> UpdateTrigger(UpdateTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> UpdateTriggerAsync(UpdateTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> UpdateTriggerAsync(UpdateTriggerRequest request, st::CancellationToken cancellationToken) =>
            UpdateTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateTrigger</c>.</summary>
        public virtual lro::OperationsClient UpdateTriggerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> PollOnceUpdateTrigger(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Trigger, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTriggerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> PollOnceUpdateTriggerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Trigger, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTriggerOperationsClient, callSettings);

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="trigger">
        /// The trigger to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The fields to be updated; only fields explicitly provided are updated.
        /// If no field mask is provided, all provided fields in the request are
        /// updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, a new trigger will be
        /// created. In this situation, `update_mask` is ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> UpdateTrigger(Trigger trigger, wkt::FieldMask updateMask, bool allowMissing, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTrigger(new UpdateTriggerRequest
            {
                Trigger = trigger,
                UpdateMask = updateMask,
                AllowMissing = allowMissing,
            }, callSettings);

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="trigger">
        /// The trigger to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The fields to be updated; only fields explicitly provided are updated.
        /// If no field mask is provided, all provided fields in the request are
        /// updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, a new trigger will be
        /// created. In this situation, `update_mask` is ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> UpdateTriggerAsync(Trigger trigger, wkt::FieldMask updateMask, bool allowMissing, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTriggerAsync(new UpdateTriggerRequest
            {
                Trigger = trigger,
                UpdateMask = updateMask,
                AllowMissing = allowMissing,
            }, callSettings);

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="trigger">
        /// The trigger to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The fields to be updated; only fields explicitly provided are updated.
        /// If no field mask is provided, all provided fields in the request are
        /// updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, a new trigger will be
        /// created. In this situation, `update_mask` is ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> UpdateTriggerAsync(Trigger trigger, wkt::FieldMask updateMask, bool allowMissing, st::CancellationToken cancellationToken) =>
            UpdateTriggerAsync(trigger, updateMask, allowMissing, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> DeleteTrigger(DeleteTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(DeleteTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(DeleteTriggerRequest request, st::CancellationToken cancellationToken) =>
            DeleteTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTrigger</c>.</summary>
        public virtual lro::OperationsClient DeleteTriggerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> PollOnceDeleteTrigger(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Trigger, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTriggerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> PollOnceDeleteTriggerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Trigger, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTriggerOperationsClient, callSettings);

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to be deleted.
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, the request will succeed
        /// but no action will be taken on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> DeleteTrigger(string name, bool allowMissing, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTrigger(new DeleteTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AllowMissing = allowMissing,
            }, callSettings);

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to be deleted.
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, the request will succeed
        /// but no action will be taken on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(string name, bool allowMissing, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTriggerAsync(new DeleteTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AllowMissing = allowMissing,
            }, callSettings);

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to be deleted.
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, the request will succeed
        /// but no action will be taken on the server.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(string name, bool allowMissing, st::CancellationToken cancellationToken) =>
            DeleteTriggerAsync(name, allowMissing, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to be deleted.
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, the request will succeed
        /// but no action will be taken on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> DeleteTrigger(TriggerName name, bool allowMissing, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTrigger(new DeleteTriggerRequest
            {
                TriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AllowMissing = allowMissing,
            }, callSettings);

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to be deleted.
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, the request will succeed
        /// but no action will be taken on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(TriggerName name, bool allowMissing, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTriggerAsync(new DeleteTriggerRequest
            {
                TriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AllowMissing = allowMissing,
            }, callSettings);

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to be deleted.
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, the request will succeed
        /// but no action will be taken on the server.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(TriggerName name, bool allowMissing, st::CancellationToken cancellationToken) =>
            DeleteTriggerAsync(name, allowMissing, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single Channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Channel GetChannel(GetChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single Channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Channel> GetChannelAsync(GetChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single Channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Channel> GetChannelAsync(GetChannelRequest request, st::CancellationToken cancellationToken) =>
            GetChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single Channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Channel GetChannel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannel(new GetChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Channel> GetChannelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannelAsync(new GetChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Channel> GetChannelAsync(string name, st::CancellationToken cancellationToken) =>
            GetChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single Channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Channel GetChannel(ChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannel(new GetChannelRequest
            {
                ChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Channel> GetChannelAsync(ChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannelAsync(new GetChannelRequest
            {
                ChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Channel> GetChannelAsync(ChannelName name, st::CancellationToken cancellationToken) =>
            GetChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List channels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Channel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelsResponse, Channel> ListChannels(ListChannelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List channels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Channel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelsResponse, Channel> ListChannelsAsync(ListChannelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List channels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list channels on.
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
        /// <returns>A pageable sequence of <see cref="Channel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelsResponse, Channel> ListChannels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChannelsRequest request = new ListChannelsRequest
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
            return ListChannels(request, callSettings);
        }

        /// <summary>
        /// List channels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list channels on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Channel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelsResponse, Channel> ListChannelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChannelsRequest request = new ListChannelsRequest
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
            return ListChannelsAsync(request, callSettings);
        }

        /// <summary>
        /// List channels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list channels on.
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
        /// <returns>A pageable sequence of <see cref="Channel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelsResponse, Channel> ListChannels(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChannelsRequest request = new ListChannelsRequest
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
            return ListChannels(request, callSettings);
        }

        /// <summary>
        /// List channels.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list channels on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Channel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelsResponse, Channel> ListChannelsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChannelsRequest request = new ListChannelsRequest
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
            return ListChannelsAsync(request, callSettings);
        }

        /// <summary>
        /// Create a new channel in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> CreateChannel(CreateChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new channel in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(CreateChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new channel in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(CreateChannelRequest request, st::CancellationToken cancellationToken) =>
            CreateChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateChannel</c>.</summary>
        public virtual lro::OperationsClient CreateChannelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> PollOnceCreateChannel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Channel, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateChannelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> PollOnceCreateChannelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Channel, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateChannelOperationsClient, callSettings);

        /// <summary>
        /// Create a new channel in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this channel.
        /// </param>
        /// <param name="channel">
        /// Required. The channel to create.
        /// </param>
        /// <param name="channelId">
        /// Required. The user-provided ID to be assigned to the channel.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> CreateChannel(string parent, Channel channel, string channelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannel(new CreateChannelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Channel = gax::GaxPreconditions.CheckNotNull(channel, nameof(channel)),
                ChannelId = gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)),
            }, callSettings);

        /// <summary>
        /// Create a new channel in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this channel.
        /// </param>
        /// <param name="channel">
        /// Required. The channel to create.
        /// </param>
        /// <param name="channelId">
        /// Required. The user-provided ID to be assigned to the channel.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(string parent, Channel channel, string channelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannelAsync(new CreateChannelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Channel = gax::GaxPreconditions.CheckNotNull(channel, nameof(channel)),
                ChannelId = gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)),
            }, callSettings);

        /// <summary>
        /// Create a new channel in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this channel.
        /// </param>
        /// <param name="channel">
        /// Required. The channel to create.
        /// </param>
        /// <param name="channelId">
        /// Required. The user-provided ID to be assigned to the channel.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(string parent, Channel channel, string channelId, st::CancellationToken cancellationToken) =>
            CreateChannelAsync(parent, channel, channelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new channel in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this channel.
        /// </param>
        /// <param name="channel">
        /// Required. The channel to create.
        /// </param>
        /// <param name="channelId">
        /// Required. The user-provided ID to be assigned to the channel.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> CreateChannel(gagr::LocationName parent, Channel channel, string channelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannel(new CreateChannelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Channel = gax::GaxPreconditions.CheckNotNull(channel, nameof(channel)),
                ChannelId = gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)),
            }, callSettings);

        /// <summary>
        /// Create a new channel in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this channel.
        /// </param>
        /// <param name="channel">
        /// Required. The channel to create.
        /// </param>
        /// <param name="channelId">
        /// Required. The user-provided ID to be assigned to the channel.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(gagr::LocationName parent, Channel channel, string channelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannelAsync(new CreateChannelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Channel = gax::GaxPreconditions.CheckNotNull(channel, nameof(channel)),
                ChannelId = gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)),
            }, callSettings);

        /// <summary>
        /// Create a new channel in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this channel.
        /// </param>
        /// <param name="channel">
        /// Required. The channel to create.
        /// </param>
        /// <param name="channelId">
        /// Required. The user-provided ID to be assigned to the channel.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(gagr::LocationName parent, Channel channel, string channelId, st::CancellationToken cancellationToken) =>
            CreateChannelAsync(parent, channel, channelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> UpdateChannel(UpdateChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> UpdateChannelAsync(UpdateChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> UpdateChannelAsync(UpdateChannelRequest request, st::CancellationToken cancellationToken) =>
            UpdateChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateChannel</c>.</summary>
        public virtual lro::OperationsClient UpdateChannelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> PollOnceUpdateChannel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Channel, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateChannelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> PollOnceUpdateChannelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Channel, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateChannelOperationsClient, callSettings);

        /// <summary>
        /// Update a single channel.
        /// </summary>
        /// <param name="channel">
        /// The channel to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The fields to be updated; only fields explicitly provided are updated.
        /// If no field mask is provided, all provided fields in the request are
        /// updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> UpdateChannel(Channel channel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateChannel(new UpdateChannelRequest
            {
                Channel = channel,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single channel.
        /// </summary>
        /// <param name="channel">
        /// The channel to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The fields to be updated; only fields explicitly provided are updated.
        /// If no field mask is provided, all provided fields in the request are
        /// updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> UpdateChannelAsync(Channel channel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateChannelAsync(new UpdateChannelRequest
            {
                Channel = channel,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single channel.
        /// </summary>
        /// <param name="channel">
        /// The channel to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The fields to be updated; only fields explicitly provided are updated.
        /// If no field mask is provided, all provided fields in the request are
        /// updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> UpdateChannelAsync(Channel channel, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateChannelAsync(channel, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> DeleteChannel(DeleteChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> DeleteChannelAsync(DeleteChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> DeleteChannelAsync(DeleteChannelRequest request, st::CancellationToken cancellationToken) =>
            DeleteChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteChannel</c>.</summary>
        public virtual lro::OperationsClient DeleteChannelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> PollOnceDeleteChannel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Channel, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteChannelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> PollOnceDeleteChannelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Channel, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteChannelOperationsClient, callSettings);

        /// <summary>
        /// Delete a single channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> DeleteChannel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannel(new DeleteChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> DeleteChannelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannelAsync(new DeleteChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> DeleteChannelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> DeleteChannel(ChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannel(new DeleteChannelRequest
            {
                ChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> DeleteChannelAsync(ChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannelAsync(new DeleteChannelRequest
            {
                ChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> DeleteChannelAsync(ChannelName name, st::CancellationToken cancellationToken) =>
            DeleteChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single Provider.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Provider GetProvider(GetProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single Provider.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Provider> GetProviderAsync(GetProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single Provider.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Provider> GetProviderAsync(GetProviderRequest request, st::CancellationToken cancellationToken) =>
            GetProviderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single Provider.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Provider GetProvider(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProvider(new GetProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Provider.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Provider> GetProviderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProviderAsync(new GetProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Provider.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Provider> GetProviderAsync(string name, st::CancellationToken cancellationToken) =>
            GetProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single Provider.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Provider GetProvider(ProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProvider(new GetProviderRequest
            {
                ProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Provider.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Provider> GetProviderAsync(ProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProviderAsync(new GetProviderRequest
            {
                ProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Provider.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the provider to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Provider> GetProviderAsync(ProviderName name, st::CancellationToken cancellationToken) =>
            GetProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List providers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Provider"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProvidersResponse, Provider> ListProviders(ListProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List providers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Provider"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProvidersResponse, Provider> ListProvidersAsync(ListProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List providers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the provider to get.
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
        /// List providers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the provider to get.
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
        /// List providers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the provider to get.
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
        /// List providers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the provider to get.
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
        /// Get a single ChannelConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelConnection GetChannelConnection(GetChannelConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single ChannelConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelConnection> GetChannelConnectionAsync(GetChannelConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single ChannelConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelConnection> GetChannelConnectionAsync(GetChannelConnectionRequest request, st::CancellationToken cancellationToken) =>
            GetChannelConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single ChannelConnection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel connection to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelConnection GetChannelConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannelConnection(new GetChannelConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single ChannelConnection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel connection to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelConnection> GetChannelConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannelConnectionAsync(new GetChannelConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single ChannelConnection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel connection to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelConnection> GetChannelConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetChannelConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single ChannelConnection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel connection to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelConnection GetChannelConnection(ChannelConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannelConnection(new GetChannelConnectionRequest
            {
                ChannelConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single ChannelConnection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel connection to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelConnection> GetChannelConnectionAsync(ChannelConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannelConnectionAsync(new GetChannelConnectionRequest
            {
                ChannelConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single ChannelConnection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel connection to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelConnection> GetChannelConnectionAsync(ChannelConnectionName name, st::CancellationToken cancellationToken) =>
            GetChannelConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List channel connections.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ChannelConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelConnectionsResponse, ChannelConnection> ListChannelConnections(ListChannelConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List channel connections.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ChannelConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelConnectionsResponse, ChannelConnection> ListChannelConnectionsAsync(ListChannelConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List channel connections.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection from which to list channel connections.
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
        /// <returns>A pageable sequence of <see cref="ChannelConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelConnectionsResponse, ChannelConnection> ListChannelConnections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChannelConnectionsRequest request = new ListChannelConnectionsRequest
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
            return ListChannelConnections(request, callSettings);
        }

        /// <summary>
        /// List channel connections.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection from which to list channel connections.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ChannelConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelConnectionsResponse, ChannelConnection> ListChannelConnectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChannelConnectionsRequest request = new ListChannelConnectionsRequest
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
            return ListChannelConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// List channel connections.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection from which to list channel connections.
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
        /// <returns>A pageable sequence of <see cref="ChannelConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelConnectionsResponse, ChannelConnection> ListChannelConnections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChannelConnectionsRequest request = new ListChannelConnectionsRequest
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
            return ListChannelConnections(request, callSettings);
        }

        /// <summary>
        /// List channel connections.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection from which to list channel connections.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ChannelConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelConnectionsResponse, ChannelConnection> ListChannelConnectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChannelConnectionsRequest request = new ListChannelConnectionsRequest
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
            return ListChannelConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Create a new ChannelConnection in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ChannelConnection, OperationMetadata> CreateChannelConnection(CreateChannelConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new ChannelConnection in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> CreateChannelConnectionAsync(CreateChannelConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new ChannelConnection in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> CreateChannelConnectionAsync(CreateChannelConnectionRequest request, st::CancellationToken cancellationToken) =>
            CreateChannelConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateChannelConnection</c>.</summary>
        public virtual lro::OperationsClient CreateChannelConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateChannelConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ChannelConnection, OperationMetadata> PollOnceCreateChannelConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ChannelConnection, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateChannelConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateChannelConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> PollOnceCreateChannelConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ChannelConnection, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateChannelConnectionOperationsClient, callSettings);

        /// <summary>
        /// Create a new ChannelConnection in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this channel connection.
        /// </param>
        /// <param name="channelConnection">
        /// Required. Channel connection to create.
        /// </param>
        /// <param name="channelConnectionId">
        /// Required. The user-provided ID to be assigned to the channel connection.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ChannelConnection, OperationMetadata> CreateChannelConnection(string parent, ChannelConnection channelConnection, string channelConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannelConnection(new CreateChannelConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ChannelConnection = gax::GaxPreconditions.CheckNotNull(channelConnection, nameof(channelConnection)),
                ChannelConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(channelConnectionId, nameof(channelConnectionId)),
            }, callSettings);

        /// <summary>
        /// Create a new ChannelConnection in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this channel connection.
        /// </param>
        /// <param name="channelConnection">
        /// Required. Channel connection to create.
        /// </param>
        /// <param name="channelConnectionId">
        /// Required. The user-provided ID to be assigned to the channel connection.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> CreateChannelConnectionAsync(string parent, ChannelConnection channelConnection, string channelConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannelConnectionAsync(new CreateChannelConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ChannelConnection = gax::GaxPreconditions.CheckNotNull(channelConnection, nameof(channelConnection)),
                ChannelConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(channelConnectionId, nameof(channelConnectionId)),
            }, callSettings);

        /// <summary>
        /// Create a new ChannelConnection in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this channel connection.
        /// </param>
        /// <param name="channelConnection">
        /// Required. Channel connection to create.
        /// </param>
        /// <param name="channelConnectionId">
        /// Required. The user-provided ID to be assigned to the channel connection.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> CreateChannelConnectionAsync(string parent, ChannelConnection channelConnection, string channelConnectionId, st::CancellationToken cancellationToken) =>
            CreateChannelConnectionAsync(parent, channelConnection, channelConnectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new ChannelConnection in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this channel connection.
        /// </param>
        /// <param name="channelConnection">
        /// Required. Channel connection to create.
        /// </param>
        /// <param name="channelConnectionId">
        /// Required. The user-provided ID to be assigned to the channel connection.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ChannelConnection, OperationMetadata> CreateChannelConnection(gagr::LocationName parent, ChannelConnection channelConnection, string channelConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannelConnection(new CreateChannelConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ChannelConnection = gax::GaxPreconditions.CheckNotNull(channelConnection, nameof(channelConnection)),
                ChannelConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(channelConnectionId, nameof(channelConnectionId)),
            }, callSettings);

        /// <summary>
        /// Create a new ChannelConnection in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this channel connection.
        /// </param>
        /// <param name="channelConnection">
        /// Required. Channel connection to create.
        /// </param>
        /// <param name="channelConnectionId">
        /// Required. The user-provided ID to be assigned to the channel connection.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> CreateChannelConnectionAsync(gagr::LocationName parent, ChannelConnection channelConnection, string channelConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannelConnectionAsync(new CreateChannelConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ChannelConnection = gax::GaxPreconditions.CheckNotNull(channelConnection, nameof(channelConnection)),
                ChannelConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(channelConnectionId, nameof(channelConnectionId)),
            }, callSettings);

        /// <summary>
        /// Create a new ChannelConnection in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this channel connection.
        /// </param>
        /// <param name="channelConnection">
        /// Required. Channel connection to create.
        /// </param>
        /// <param name="channelConnectionId">
        /// Required. The user-provided ID to be assigned to the channel connection.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> CreateChannelConnectionAsync(gagr::LocationName parent, ChannelConnection channelConnection, string channelConnectionId, st::CancellationToken cancellationToken) =>
            CreateChannelConnectionAsync(parent, channelConnection, channelConnectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single ChannelConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ChannelConnection, OperationMetadata> DeleteChannelConnection(DeleteChannelConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single ChannelConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> DeleteChannelConnectionAsync(DeleteChannelConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single ChannelConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> DeleteChannelConnectionAsync(DeleteChannelConnectionRequest request, st::CancellationToken cancellationToken) =>
            DeleteChannelConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteChannelConnection</c>.</summary>
        public virtual lro::OperationsClient DeleteChannelConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteChannelConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ChannelConnection, OperationMetadata> PollOnceDeleteChannelConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ChannelConnection, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteChannelConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteChannelConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> PollOnceDeleteChannelConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ChannelConnection, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteChannelConnectionOperationsClient, callSettings);

        /// <summary>
        /// Delete a single ChannelConnection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel connection to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ChannelConnection, OperationMetadata> DeleteChannelConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannelConnection(new DeleteChannelConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single ChannelConnection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel connection to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> DeleteChannelConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannelConnectionAsync(new DeleteChannelConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single ChannelConnection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel connection to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> DeleteChannelConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteChannelConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single ChannelConnection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel connection to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ChannelConnection, OperationMetadata> DeleteChannelConnection(ChannelConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannelConnection(new DeleteChannelConnectionRequest
            {
                ChannelConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single ChannelConnection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel connection to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> DeleteChannelConnectionAsync(ChannelConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannelConnectionAsync(new DeleteChannelConnectionRequest
            {
                ChannelConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single ChannelConnection.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel connection to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> DeleteChannelConnectionAsync(ChannelConnectionName name, st::CancellationToken cancellationToken) =>
            DeleteChannelConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a GoogleChannelConfig
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleChannelConfig GetGoogleChannelConfig(GetGoogleChannelConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a GoogleChannelConfig
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleChannelConfig> GetGoogleChannelConfigAsync(GetGoogleChannelConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a GoogleChannelConfig
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleChannelConfig> GetGoogleChannelConfigAsync(GetGoogleChannelConfigRequest request, st::CancellationToken cancellationToken) =>
            GetGoogleChannelConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a GoogleChannelConfig
        /// </summary>
        /// <param name="name">
        /// Required. The name of the config to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleChannelConfig GetGoogleChannelConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleChannelConfig(new GetGoogleChannelConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a GoogleChannelConfig
        /// </summary>
        /// <param name="name">
        /// Required. The name of the config to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleChannelConfig> GetGoogleChannelConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleChannelConfigAsync(new GetGoogleChannelConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a GoogleChannelConfig
        /// </summary>
        /// <param name="name">
        /// Required. The name of the config to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleChannelConfig> GetGoogleChannelConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetGoogleChannelConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a GoogleChannelConfig
        /// </summary>
        /// <param name="name">
        /// Required. The name of the config to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleChannelConfig GetGoogleChannelConfig(GoogleChannelConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleChannelConfig(new GetGoogleChannelConfigRequest
            {
                GoogleChannelConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a GoogleChannelConfig
        /// </summary>
        /// <param name="name">
        /// Required. The name of the config to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleChannelConfig> GetGoogleChannelConfigAsync(GoogleChannelConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleChannelConfigAsync(new GetGoogleChannelConfigRequest
            {
                GoogleChannelConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a GoogleChannelConfig
        /// </summary>
        /// <param name="name">
        /// Required. The name of the config to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleChannelConfig> GetGoogleChannelConfigAsync(GoogleChannelConfigName name, st::CancellationToken cancellationToken) =>
            GetGoogleChannelConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single GoogleChannelConfig
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleChannelConfig UpdateGoogleChannelConfig(UpdateGoogleChannelConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single GoogleChannelConfig
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleChannelConfig> UpdateGoogleChannelConfigAsync(UpdateGoogleChannelConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single GoogleChannelConfig
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleChannelConfig> UpdateGoogleChannelConfigAsync(UpdateGoogleChannelConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateGoogleChannelConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single GoogleChannelConfig
        /// </summary>
        /// <param name="googleChannelConfig">
        /// Required. The config to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The fields to be updated; only fields explicitly provided are updated.
        /// If no field mask is provided, all provided fields in the request are
        /// updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleChannelConfig UpdateGoogleChannelConfig(GoogleChannelConfig googleChannelConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGoogleChannelConfig(new UpdateGoogleChannelConfigRequest
            {
                GoogleChannelConfig = gax::GaxPreconditions.CheckNotNull(googleChannelConfig, nameof(googleChannelConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single GoogleChannelConfig
        /// </summary>
        /// <param name="googleChannelConfig">
        /// Required. The config to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The fields to be updated; only fields explicitly provided are updated.
        /// If no field mask is provided, all provided fields in the request are
        /// updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleChannelConfig> UpdateGoogleChannelConfigAsync(GoogleChannelConfig googleChannelConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGoogleChannelConfigAsync(new UpdateGoogleChannelConfigRequest
            {
                GoogleChannelConfig = gax::GaxPreconditions.CheckNotNull(googleChannelConfig, nameof(googleChannelConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single GoogleChannelConfig
        /// </summary>
        /// <param name="googleChannelConfig">
        /// Required. The config to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The fields to be updated; only fields explicitly provided are updated.
        /// If no field mask is provided, all provided fields in the request are
        /// updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleChannelConfig> UpdateGoogleChannelConfigAsync(GoogleChannelConfig googleChannelConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGoogleChannelConfigAsync(googleChannelConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single MessageBus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MessageBus GetMessageBus(GetMessageBusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single MessageBus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MessageBus> GetMessageBusAsync(GetMessageBusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single MessageBus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MessageBus> GetMessageBusAsync(GetMessageBusRequest request, st::CancellationToken cancellationToken) =>
            GetMessageBusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single MessageBus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the message bus to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MessageBus GetMessageBus(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMessageBus(new GetMessageBusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single MessageBus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the message bus to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MessageBus> GetMessageBusAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMessageBusAsync(new GetMessageBusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single MessageBus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the message bus to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MessageBus> GetMessageBusAsync(string name, st::CancellationToken cancellationToken) =>
            GetMessageBusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single MessageBus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the message bus to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MessageBus GetMessageBus(MessageBusName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMessageBus(new GetMessageBusRequest
            {
                MessageBusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single MessageBus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the message bus to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MessageBus> GetMessageBusAsync(MessageBusName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMessageBusAsync(new GetMessageBusRequest
            {
                MessageBusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single MessageBus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the message bus to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MessageBus> GetMessageBusAsync(MessageBusName name, st::CancellationToken cancellationToken) =>
            GetMessageBusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List message buses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MessageBus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMessageBusesResponse, MessageBus> ListMessageBuses(ListMessageBusesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List message buses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MessageBus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMessageBusesResponse, MessageBus> ListMessageBusesAsync(ListMessageBusesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List message buses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable sequence of <see cref="MessageBus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMessageBusesResponse, MessageBus> ListMessageBuses(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessageBusesRequest request = new ListMessageBusesRequest
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
            return ListMessageBuses(request, callSettings);
        }

        /// <summary>
        /// List message buses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MessageBus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMessageBusesResponse, MessageBus> ListMessageBusesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessageBusesRequest request = new ListMessageBusesRequest
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
            return ListMessageBusesAsync(request, callSettings);
        }

        /// <summary>
        /// List message buses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable sequence of <see cref="MessageBus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMessageBusesResponse, MessageBus> ListMessageBuses(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessageBusesRequest request = new ListMessageBusesRequest
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
            return ListMessageBuses(request, callSettings);
        }

        /// <summary>
        /// List message buses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MessageBus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMessageBusesResponse, MessageBus> ListMessageBusesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessageBusesRequest request = new ListMessageBusesRequest
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
            return ListMessageBusesAsync(request, callSettings);
        }

        /// <summary>
        /// List message bus enrollments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMessageBusEnrollmentsResponse, string> ListMessageBusEnrollments(ListMessageBusEnrollmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List message bus enrollments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMessageBusEnrollmentsResponse, string> ListMessageBusEnrollmentsAsync(ListMessageBusEnrollmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List message bus enrollments.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent message bus to list enrollments on.
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
        public virtual gax::PagedEnumerable<ListMessageBusEnrollmentsResponse, string> ListMessageBusEnrollments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessageBusEnrollmentsRequest request = new ListMessageBusEnrollmentsRequest
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
            return ListMessageBusEnrollments(request, callSettings);
        }

        /// <summary>
        /// List message bus enrollments.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent message bus to list enrollments on.
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
        public virtual gax::PagedAsyncEnumerable<ListMessageBusEnrollmentsResponse, string> ListMessageBusEnrollmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessageBusEnrollmentsRequest request = new ListMessageBusEnrollmentsRequest
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
            return ListMessageBusEnrollmentsAsync(request, callSettings);
        }

        /// <summary>
        /// List message bus enrollments.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent message bus to list enrollments on.
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
        public virtual gax::PagedEnumerable<ListMessageBusEnrollmentsResponse, string> ListMessageBusEnrollments(MessageBusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessageBusEnrollmentsRequest request = new ListMessageBusEnrollmentsRequest
            {
                ParentAsMessageBusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMessageBusEnrollments(request, callSettings);
        }

        /// <summary>
        /// List message bus enrollments.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent message bus to list enrollments on.
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
        public virtual gax::PagedAsyncEnumerable<ListMessageBusEnrollmentsResponse, string> ListMessageBusEnrollmentsAsync(MessageBusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessageBusEnrollmentsRequest request = new ListMessageBusEnrollmentsRequest
            {
                ParentAsMessageBusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMessageBusEnrollmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Create a new MessageBus in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MessageBus, OperationMetadata> CreateMessageBus(CreateMessageBusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new MessageBus in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> CreateMessageBusAsync(CreateMessageBusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new MessageBus in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> CreateMessageBusAsync(CreateMessageBusRequest request, st::CancellationToken cancellationToken) =>
            CreateMessageBusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMessageBus</c>.</summary>
        public virtual lro::OperationsClient CreateMessageBusOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateMessageBus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MessageBus, OperationMetadata> PollOnceCreateMessageBus(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MessageBus, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMessageBusOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMessageBus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> PollOnceCreateMessageBusAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MessageBus, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMessageBusOperationsClient, callSettings);

        /// <summary>
        /// Create a new MessageBus in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this message bus.
        /// </param>
        /// <param name="messageBus">
        /// Required. The message bus to create.
        /// </param>
        /// <param name="messageBusId">
        /// Required. The user-provided ID to be assigned to the MessageBus. It should
        /// match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MessageBus, OperationMetadata> CreateMessageBus(string parent, MessageBus messageBus, string messageBusId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMessageBus(new CreateMessageBusRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MessageBus = gax::GaxPreconditions.CheckNotNull(messageBus, nameof(messageBus)),
                MessageBusId = gax::GaxPreconditions.CheckNotNullOrEmpty(messageBusId, nameof(messageBusId)),
            }, callSettings);

        /// <summary>
        /// Create a new MessageBus in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this message bus.
        /// </param>
        /// <param name="messageBus">
        /// Required. The message bus to create.
        /// </param>
        /// <param name="messageBusId">
        /// Required. The user-provided ID to be assigned to the MessageBus. It should
        /// match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> CreateMessageBusAsync(string parent, MessageBus messageBus, string messageBusId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMessageBusAsync(new CreateMessageBusRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MessageBus = gax::GaxPreconditions.CheckNotNull(messageBus, nameof(messageBus)),
                MessageBusId = gax::GaxPreconditions.CheckNotNullOrEmpty(messageBusId, nameof(messageBusId)),
            }, callSettings);

        /// <summary>
        /// Create a new MessageBus in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this message bus.
        /// </param>
        /// <param name="messageBus">
        /// Required. The message bus to create.
        /// </param>
        /// <param name="messageBusId">
        /// Required. The user-provided ID to be assigned to the MessageBus. It should
        /// match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> CreateMessageBusAsync(string parent, MessageBus messageBus, string messageBusId, st::CancellationToken cancellationToken) =>
            CreateMessageBusAsync(parent, messageBus, messageBusId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new MessageBus in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this message bus.
        /// </param>
        /// <param name="messageBus">
        /// Required. The message bus to create.
        /// </param>
        /// <param name="messageBusId">
        /// Required. The user-provided ID to be assigned to the MessageBus. It should
        /// match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MessageBus, OperationMetadata> CreateMessageBus(gagr::LocationName parent, MessageBus messageBus, string messageBusId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMessageBus(new CreateMessageBusRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MessageBus = gax::GaxPreconditions.CheckNotNull(messageBus, nameof(messageBus)),
                MessageBusId = gax::GaxPreconditions.CheckNotNullOrEmpty(messageBusId, nameof(messageBusId)),
            }, callSettings);

        /// <summary>
        /// Create a new MessageBus in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this message bus.
        /// </param>
        /// <param name="messageBus">
        /// Required. The message bus to create.
        /// </param>
        /// <param name="messageBusId">
        /// Required. The user-provided ID to be assigned to the MessageBus. It should
        /// match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> CreateMessageBusAsync(gagr::LocationName parent, MessageBus messageBus, string messageBusId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMessageBusAsync(new CreateMessageBusRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MessageBus = gax::GaxPreconditions.CheckNotNull(messageBus, nameof(messageBus)),
                MessageBusId = gax::GaxPreconditions.CheckNotNullOrEmpty(messageBusId, nameof(messageBusId)),
            }, callSettings);

        /// <summary>
        /// Create a new MessageBus in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this message bus.
        /// </param>
        /// <param name="messageBus">
        /// Required. The message bus to create.
        /// </param>
        /// <param name="messageBusId">
        /// Required. The user-provided ID to be assigned to the MessageBus. It should
        /// match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> CreateMessageBusAsync(gagr::LocationName parent, MessageBus messageBus, string messageBusId, st::CancellationToken cancellationToken) =>
            CreateMessageBusAsync(parent, messageBus, messageBusId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MessageBus, OperationMetadata> UpdateMessageBus(UpdateMessageBusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> UpdateMessageBusAsync(UpdateMessageBusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> UpdateMessageBusAsync(UpdateMessageBusRequest request, st::CancellationToken cancellationToken) =>
            UpdateMessageBusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMessageBus</c>.</summary>
        public virtual lro::OperationsClient UpdateMessageBusOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateMessageBus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MessageBus, OperationMetadata> PollOnceUpdateMessageBus(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MessageBus, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMessageBusOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMessageBus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> PollOnceUpdateMessageBusAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MessageBus, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMessageBusOperationsClient, callSettings);

        /// <summary>
        /// Update a single message bus.
        /// </summary>
        /// <param name="messageBus">
        /// Required. The MessageBus to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to be updated; only fields explicitly provided are
        /// updated. If no field mask is provided, all provided fields in the request
        /// are updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MessageBus, OperationMetadata> UpdateMessageBus(MessageBus messageBus, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMessageBus(new UpdateMessageBusRequest
            {
                MessageBus = gax::GaxPreconditions.CheckNotNull(messageBus, nameof(messageBus)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single message bus.
        /// </summary>
        /// <param name="messageBus">
        /// Required. The MessageBus to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to be updated; only fields explicitly provided are
        /// updated. If no field mask is provided, all provided fields in the request
        /// are updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> UpdateMessageBusAsync(MessageBus messageBus, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMessageBusAsync(new UpdateMessageBusRequest
            {
                MessageBus = gax::GaxPreconditions.CheckNotNull(messageBus, nameof(messageBus)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single message bus.
        /// </summary>
        /// <param name="messageBus">
        /// Required. The MessageBus to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to be updated; only fields explicitly provided are
        /// updated. If no field mask is provided, all provided fields in the request
        /// are updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> UpdateMessageBusAsync(MessageBus messageBus, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMessageBusAsync(messageBus, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MessageBus, OperationMetadata> DeleteMessageBus(DeleteMessageBusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> DeleteMessageBusAsync(DeleteMessageBusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> DeleteMessageBusAsync(DeleteMessageBusRequest request, st::CancellationToken cancellationToken) =>
            DeleteMessageBusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMessageBus</c>.</summary>
        public virtual lro::OperationsClient DeleteMessageBusOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteMessageBus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MessageBus, OperationMetadata> PollOnceDeleteMessageBus(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MessageBus, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMessageBusOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMessageBus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> PollOnceDeleteMessageBusAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MessageBus, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMessageBusOperationsClient, callSettings);

        /// <summary>
        /// Delete a single message bus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MessageBus to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the MessageBus will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MessageBus, OperationMetadata> DeleteMessageBus(string name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMessageBus(new DeleteMessageBusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single message bus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MessageBus to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the MessageBus will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> DeleteMessageBusAsync(string name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMessageBusAsync(new DeleteMessageBusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single message bus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MessageBus to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the MessageBus will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> DeleteMessageBusAsync(string name, string etag, st::CancellationToken cancellationToken) =>
            DeleteMessageBusAsync(name, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single message bus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MessageBus to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the MessageBus will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MessageBus, OperationMetadata> DeleteMessageBus(MessageBusName name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMessageBus(new DeleteMessageBusRequest
            {
                MessageBusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single message bus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MessageBus to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the MessageBus will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> DeleteMessageBusAsync(MessageBusName name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMessageBusAsync(new DeleteMessageBusRequest
            {
                MessageBusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single message bus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MessageBus to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the MessageBus will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MessageBus, OperationMetadata>> DeleteMessageBusAsync(MessageBusName name, string etag, st::CancellationToken cancellationToken) =>
            DeleteMessageBusAsync(name, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Enrollment GetEnrollment(GetEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Enrollment> GetEnrollmentAsync(GetEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Enrollment> GetEnrollmentAsync(GetEnrollmentRequest request, st::CancellationToken cancellationToken) =>
            GetEnrollmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single Enrollment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Enrollment to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Enrollment GetEnrollment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnrollment(new GetEnrollmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Enrollment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Enrollment to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Enrollment> GetEnrollmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnrollmentAsync(new GetEnrollmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Enrollment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Enrollment to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Enrollment> GetEnrollmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetEnrollmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single Enrollment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Enrollment to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Enrollment GetEnrollment(EnrollmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnrollment(new GetEnrollmentRequest
            {
                EnrollmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Enrollment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Enrollment to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Enrollment> GetEnrollmentAsync(EnrollmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnrollmentAsync(new GetEnrollmentRequest
            {
                EnrollmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Enrollment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Enrollment to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Enrollment> GetEnrollmentAsync(EnrollmentName name, st::CancellationToken cancellationToken) =>
            GetEnrollmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List Enrollments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Enrollment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnrollmentsResponse, Enrollment> ListEnrollments(ListEnrollmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List Enrollments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Enrollment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnrollmentsResponse, Enrollment> ListEnrollmentsAsync(ListEnrollmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List Enrollments.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable sequence of <see cref="Enrollment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnrollmentsResponse, Enrollment> ListEnrollments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnrollmentsRequest request = new ListEnrollmentsRequest
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
            return ListEnrollments(request, callSettings);
        }

        /// <summary>
        /// List Enrollments.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Enrollment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnrollmentsResponse, Enrollment> ListEnrollmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnrollmentsRequest request = new ListEnrollmentsRequest
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
            return ListEnrollmentsAsync(request, callSettings);
        }

        /// <summary>
        /// List Enrollments.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable sequence of <see cref="Enrollment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnrollmentsResponse, Enrollment> ListEnrollments(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnrollmentsRequest request = new ListEnrollmentsRequest
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
            return ListEnrollments(request, callSettings);
        }

        /// <summary>
        /// List Enrollments.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Enrollment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnrollmentsResponse, Enrollment> ListEnrollmentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnrollmentsRequest request = new ListEnrollmentsRequest
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
            return ListEnrollmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Create a new Enrollment in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Enrollment, OperationMetadata> CreateEnrollment(CreateEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new Enrollment in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> CreateEnrollmentAsync(CreateEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new Enrollment in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> CreateEnrollmentAsync(CreateEnrollmentRequest request, st::CancellationToken cancellationToken) =>
            CreateEnrollmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEnrollment</c>.</summary>
        public virtual lro::OperationsClient CreateEnrollmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEnrollment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Enrollment, OperationMetadata> PollOnceCreateEnrollment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Enrollment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEnrollmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEnrollment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> PollOnceCreateEnrollmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Enrollment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEnrollmentOperationsClient, callSettings);

        /// <summary>
        /// Create a new Enrollment in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this enrollment.
        /// </param>
        /// <param name="enrollment">
        /// Required. The enrollment to create.
        /// </param>
        /// <param name="enrollmentId">
        /// Required. The user-provided ID to be assigned to the Enrollment. It should
        /// match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Enrollment, OperationMetadata> CreateEnrollment(string parent, Enrollment enrollment, string enrollmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnrollment(new CreateEnrollmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Enrollment = gax::GaxPreconditions.CheckNotNull(enrollment, nameof(enrollment)),
                EnrollmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)),
            }, callSettings);

        /// <summary>
        /// Create a new Enrollment in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this enrollment.
        /// </param>
        /// <param name="enrollment">
        /// Required. The enrollment to create.
        /// </param>
        /// <param name="enrollmentId">
        /// Required. The user-provided ID to be assigned to the Enrollment. It should
        /// match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> CreateEnrollmentAsync(string parent, Enrollment enrollment, string enrollmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnrollmentAsync(new CreateEnrollmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Enrollment = gax::GaxPreconditions.CheckNotNull(enrollment, nameof(enrollment)),
                EnrollmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)),
            }, callSettings);

        /// <summary>
        /// Create a new Enrollment in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this enrollment.
        /// </param>
        /// <param name="enrollment">
        /// Required. The enrollment to create.
        /// </param>
        /// <param name="enrollmentId">
        /// Required. The user-provided ID to be assigned to the Enrollment. It should
        /// match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> CreateEnrollmentAsync(string parent, Enrollment enrollment, string enrollmentId, st::CancellationToken cancellationToken) =>
            CreateEnrollmentAsync(parent, enrollment, enrollmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new Enrollment in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this enrollment.
        /// </param>
        /// <param name="enrollment">
        /// Required. The enrollment to create.
        /// </param>
        /// <param name="enrollmentId">
        /// Required. The user-provided ID to be assigned to the Enrollment. It should
        /// match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Enrollment, OperationMetadata> CreateEnrollment(gagr::LocationName parent, Enrollment enrollment, string enrollmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnrollment(new CreateEnrollmentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Enrollment = gax::GaxPreconditions.CheckNotNull(enrollment, nameof(enrollment)),
                EnrollmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)),
            }, callSettings);

        /// <summary>
        /// Create a new Enrollment in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this enrollment.
        /// </param>
        /// <param name="enrollment">
        /// Required. The enrollment to create.
        /// </param>
        /// <param name="enrollmentId">
        /// Required. The user-provided ID to be assigned to the Enrollment. It should
        /// match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> CreateEnrollmentAsync(gagr::LocationName parent, Enrollment enrollment, string enrollmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnrollmentAsync(new CreateEnrollmentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Enrollment = gax::GaxPreconditions.CheckNotNull(enrollment, nameof(enrollment)),
                EnrollmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(enrollmentId, nameof(enrollmentId)),
            }, callSettings);

        /// <summary>
        /// Create a new Enrollment in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this enrollment.
        /// </param>
        /// <param name="enrollment">
        /// Required. The enrollment to create.
        /// </param>
        /// <param name="enrollmentId">
        /// Required. The user-provided ID to be assigned to the Enrollment. It should
        /// match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> CreateEnrollmentAsync(gagr::LocationName parent, Enrollment enrollment, string enrollmentId, st::CancellationToken cancellationToken) =>
            CreateEnrollmentAsync(parent, enrollment, enrollmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Enrollment, OperationMetadata> UpdateEnrollment(UpdateEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> UpdateEnrollmentAsync(UpdateEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> UpdateEnrollmentAsync(UpdateEnrollmentRequest request, st::CancellationToken cancellationToken) =>
            UpdateEnrollmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEnrollment</c>.</summary>
        public virtual lro::OperationsClient UpdateEnrollmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateEnrollment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Enrollment, OperationMetadata> PollOnceUpdateEnrollment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Enrollment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEnrollmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEnrollment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> PollOnceUpdateEnrollmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Enrollment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEnrollmentOperationsClient, callSettings);

        /// <summary>
        /// Update a single Enrollment.
        /// </summary>
        /// <param name="enrollment">
        /// Required. The Enrollment to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to be updated; only fields explicitly provided are
        /// updated. If no field mask is provided, all provided fields in the request
        /// are updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Enrollment, OperationMetadata> UpdateEnrollment(Enrollment enrollment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEnrollment(new UpdateEnrollmentRequest
            {
                Enrollment = gax::GaxPreconditions.CheckNotNull(enrollment, nameof(enrollment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single Enrollment.
        /// </summary>
        /// <param name="enrollment">
        /// Required. The Enrollment to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to be updated; only fields explicitly provided are
        /// updated. If no field mask is provided, all provided fields in the request
        /// are updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> UpdateEnrollmentAsync(Enrollment enrollment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEnrollmentAsync(new UpdateEnrollmentRequest
            {
                Enrollment = gax::GaxPreconditions.CheckNotNull(enrollment, nameof(enrollment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single Enrollment.
        /// </summary>
        /// <param name="enrollment">
        /// Required. The Enrollment to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to be updated; only fields explicitly provided are
        /// updated. If no field mask is provided, all provided fields in the request
        /// are updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> UpdateEnrollmentAsync(Enrollment enrollment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEnrollmentAsync(enrollment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Enrollment, OperationMetadata> DeleteEnrollment(DeleteEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> DeleteEnrollmentAsync(DeleteEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> DeleteEnrollmentAsync(DeleteEnrollmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteEnrollmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEnrollment</c>.</summary>
        public virtual lro::OperationsClient DeleteEnrollmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEnrollment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Enrollment, OperationMetadata> PollOnceDeleteEnrollment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Enrollment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEnrollmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEnrollment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> PollOnceDeleteEnrollmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Enrollment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEnrollmentOperationsClient, callSettings);

        /// <summary>
        /// Delete a single Enrollment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Enrollment to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the Enrollment will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Enrollment, OperationMetadata> DeleteEnrollment(string name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnrollment(new DeleteEnrollmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single Enrollment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Enrollment to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the Enrollment will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> DeleteEnrollmentAsync(string name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnrollmentAsync(new DeleteEnrollmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single Enrollment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Enrollment to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the Enrollment will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> DeleteEnrollmentAsync(string name, string etag, st::CancellationToken cancellationToken) =>
            DeleteEnrollmentAsync(name, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single Enrollment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Enrollment to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the Enrollment will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Enrollment, OperationMetadata> DeleteEnrollment(EnrollmentName name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnrollment(new DeleteEnrollmentRequest
            {
                EnrollmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single Enrollment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Enrollment to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the Enrollment will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> DeleteEnrollmentAsync(EnrollmentName name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnrollmentAsync(new DeleteEnrollmentRequest
            {
                EnrollmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single Enrollment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Enrollment to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the Enrollment will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Enrollment, OperationMetadata>> DeleteEnrollmentAsync(EnrollmentName name, string etag, st::CancellationToken cancellationToken) =>
            DeleteEnrollmentAsync(name, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single Pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Pipeline GetPipeline(GetPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single Pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Pipeline> GetPipelineAsync(GetPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single Pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Pipeline> GetPipelineAsync(GetPipelineRequest request, st::CancellationToken cancellationToken) =>
            GetPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single Pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pipeline to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Pipeline GetPipeline(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPipeline(new GetPipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pipeline to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Pipeline> GetPipelineAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPipelineAsync(new GetPipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pipeline to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Pipeline> GetPipelineAsync(string name, st::CancellationToken cancellationToken) =>
            GetPipelineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single Pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pipeline to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Pipeline GetPipeline(PipelineName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPipeline(new GetPipelineRequest
            {
                PipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pipeline to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Pipeline> GetPipelineAsync(PipelineName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPipelineAsync(new GetPipelineRequest
            {
                PipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single Pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the pipeline to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Pipeline> GetPipelineAsync(PipelineName name, st::CancellationToken cancellationToken) =>
            GetPipelineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List pipelines.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Pipeline"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPipelinesResponse, Pipeline> ListPipelines(ListPipelinesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List pipelines.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Pipeline"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPipelinesResponse, Pipeline> ListPipelinesAsync(ListPipelinesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List pipelines.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list pipelines on.
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
        /// <returns>A pageable sequence of <see cref="Pipeline"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPipelinesResponse, Pipeline> ListPipelines(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPipelinesRequest request = new ListPipelinesRequest
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
            return ListPipelines(request, callSettings);
        }

        /// <summary>
        /// List pipelines.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list pipelines on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Pipeline"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPipelinesResponse, Pipeline> ListPipelinesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPipelinesRequest request = new ListPipelinesRequest
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
            return ListPipelinesAsync(request, callSettings);
        }

        /// <summary>
        /// List pipelines.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list pipelines on.
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
        /// <returns>A pageable sequence of <see cref="Pipeline"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPipelinesResponse, Pipeline> ListPipelines(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPipelinesRequest request = new ListPipelinesRequest
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
            return ListPipelines(request, callSettings);
        }

        /// <summary>
        /// List pipelines.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list pipelines on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Pipeline"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPipelinesResponse, Pipeline> ListPipelinesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPipelinesRequest request = new ListPipelinesRequest
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
            return ListPipelinesAsync(request, callSettings);
        }

        /// <summary>
        /// Create a new Pipeline in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Pipeline, OperationMetadata> CreatePipeline(CreatePipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new Pipeline in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> CreatePipelineAsync(CreatePipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new Pipeline in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> CreatePipelineAsync(CreatePipelineRequest request, st::CancellationToken cancellationToken) =>
            CreatePipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePipeline</c>.</summary>
        public virtual lro::OperationsClient CreatePipelineOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreatePipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Pipeline, OperationMetadata> PollOnceCreatePipeline(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Pipeline, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePipelineOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> PollOnceCreatePipelineAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Pipeline, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePipelineOperationsClient, callSettings);

        /// <summary>
        /// Create a new Pipeline in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this pipeline.
        /// </param>
        /// <param name="pipeline">
        /// Required. The pipeline to create.
        /// </param>
        /// <param name="pipelineId">
        /// Required. The user-provided ID to be assigned to the Pipeline.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Pipeline, OperationMetadata> CreatePipeline(string parent, Pipeline pipeline, string pipelineId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePipeline(new CreatePipelineRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Pipeline = gax::GaxPreconditions.CheckNotNull(pipeline, nameof(pipeline)),
                PipelineId = gax::GaxPreconditions.CheckNotNullOrEmpty(pipelineId, nameof(pipelineId)),
            }, callSettings);

        /// <summary>
        /// Create a new Pipeline in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this pipeline.
        /// </param>
        /// <param name="pipeline">
        /// Required. The pipeline to create.
        /// </param>
        /// <param name="pipelineId">
        /// Required. The user-provided ID to be assigned to the Pipeline.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> CreatePipelineAsync(string parent, Pipeline pipeline, string pipelineId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePipelineAsync(new CreatePipelineRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Pipeline = gax::GaxPreconditions.CheckNotNull(pipeline, nameof(pipeline)),
                PipelineId = gax::GaxPreconditions.CheckNotNullOrEmpty(pipelineId, nameof(pipelineId)),
            }, callSettings);

        /// <summary>
        /// Create a new Pipeline in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this pipeline.
        /// </param>
        /// <param name="pipeline">
        /// Required. The pipeline to create.
        /// </param>
        /// <param name="pipelineId">
        /// Required. The user-provided ID to be assigned to the Pipeline.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> CreatePipelineAsync(string parent, Pipeline pipeline, string pipelineId, st::CancellationToken cancellationToken) =>
            CreatePipelineAsync(parent, pipeline, pipelineId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new Pipeline in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this pipeline.
        /// </param>
        /// <param name="pipeline">
        /// Required. The pipeline to create.
        /// </param>
        /// <param name="pipelineId">
        /// Required. The user-provided ID to be assigned to the Pipeline.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Pipeline, OperationMetadata> CreatePipeline(gagr::LocationName parent, Pipeline pipeline, string pipelineId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePipeline(new CreatePipelineRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Pipeline = gax::GaxPreconditions.CheckNotNull(pipeline, nameof(pipeline)),
                PipelineId = gax::GaxPreconditions.CheckNotNullOrEmpty(pipelineId, nameof(pipelineId)),
            }, callSettings);

        /// <summary>
        /// Create a new Pipeline in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this pipeline.
        /// </param>
        /// <param name="pipeline">
        /// Required. The pipeline to create.
        /// </param>
        /// <param name="pipelineId">
        /// Required. The user-provided ID to be assigned to the Pipeline.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> CreatePipelineAsync(gagr::LocationName parent, Pipeline pipeline, string pipelineId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePipelineAsync(new CreatePipelineRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Pipeline = gax::GaxPreconditions.CheckNotNull(pipeline, nameof(pipeline)),
                PipelineId = gax::GaxPreconditions.CheckNotNullOrEmpty(pipelineId, nameof(pipelineId)),
            }, callSettings);

        /// <summary>
        /// Create a new Pipeline in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this pipeline.
        /// </param>
        /// <param name="pipeline">
        /// Required. The pipeline to create.
        /// </param>
        /// <param name="pipelineId">
        /// Required. The user-provided ID to be assigned to the Pipeline.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> CreatePipelineAsync(gagr::LocationName parent, Pipeline pipeline, string pipelineId, st::CancellationToken cancellationToken) =>
            CreatePipelineAsync(parent, pipeline, pipelineId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Pipeline, OperationMetadata> UpdatePipeline(UpdatePipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> UpdatePipelineAsync(UpdatePipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> UpdatePipelineAsync(UpdatePipelineRequest request, st::CancellationToken cancellationToken) =>
            UpdatePipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdatePipeline</c>.</summary>
        public virtual lro::OperationsClient UpdatePipelineOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdatePipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Pipeline, OperationMetadata> PollOnceUpdatePipeline(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Pipeline, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePipelineOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> PollOnceUpdatePipelineAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Pipeline, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePipelineOperationsClient, callSettings);

        /// <summary>
        /// Update a single pipeline.
        /// </summary>
        /// <param name="pipeline">
        /// Required. The Pipeline to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to be updated; only fields explicitly provided are
        /// updated. If no field mask is provided, all provided fields in the request
        /// are updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Pipeline, OperationMetadata> UpdatePipeline(Pipeline pipeline, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePipeline(new UpdatePipelineRequest
            {
                Pipeline = gax::GaxPreconditions.CheckNotNull(pipeline, nameof(pipeline)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single pipeline.
        /// </summary>
        /// <param name="pipeline">
        /// Required. The Pipeline to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to be updated; only fields explicitly provided are
        /// updated. If no field mask is provided, all provided fields in the request
        /// are updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> UpdatePipelineAsync(Pipeline pipeline, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePipelineAsync(new UpdatePipelineRequest
            {
                Pipeline = gax::GaxPreconditions.CheckNotNull(pipeline, nameof(pipeline)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single pipeline.
        /// </summary>
        /// <param name="pipeline">
        /// Required. The Pipeline to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to be updated; only fields explicitly provided are
        /// updated. If no field mask is provided, all provided fields in the request
        /// are updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> UpdatePipelineAsync(Pipeline pipeline, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePipelineAsync(pipeline, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Pipeline, OperationMetadata> DeletePipeline(DeletePipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> DeletePipelineAsync(DeletePipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> DeletePipelineAsync(DeletePipelineRequest request, st::CancellationToken cancellationToken) =>
            DeletePipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePipeline</c>.</summary>
        public virtual lro::OperationsClient DeletePipelineOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeletePipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Pipeline, OperationMetadata> PollOnceDeletePipeline(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Pipeline, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePipelineOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> PollOnceDeletePipelineAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Pipeline, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePipelineOperationsClient, callSettings);

        /// <summary>
        /// Delete a single pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Pipeline to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the Pipeline will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Pipeline, OperationMetadata> DeletePipeline(string name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeletePipeline(new DeletePipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Pipeline to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the Pipeline will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> DeletePipelineAsync(string name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeletePipelineAsync(new DeletePipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Pipeline to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the Pipeline will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> DeletePipelineAsync(string name, string etag, st::CancellationToken cancellationToken) =>
            DeletePipelineAsync(name, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Pipeline to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the Pipeline will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Pipeline, OperationMetadata> DeletePipeline(PipelineName name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeletePipeline(new DeletePipelineRequest
            {
                PipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Pipeline to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the Pipeline will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> DeletePipelineAsync(PipelineName name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeletePipelineAsync(new DeletePipelineRequest
            {
                PipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Pipeline to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the Pipeline will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Pipeline, OperationMetadata>> DeletePipelineAsync(PipelineName name, string etag, st::CancellationToken cancellationToken) =>
            DeletePipelineAsync(name, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleApiSource GetGoogleApiSource(GetGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleApiSource> GetGoogleApiSourceAsync(GetGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleApiSource> GetGoogleApiSourceAsync(GetGoogleApiSourceRequest request, st::CancellationToken cancellationToken) =>
            GetGoogleApiSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single GoogleApiSource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the google api source to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleApiSource GetGoogleApiSource(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleApiSource(new GetGoogleApiSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single GoogleApiSource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the google api source to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleApiSource> GetGoogleApiSourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleApiSourceAsync(new GetGoogleApiSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single GoogleApiSource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the google api source to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleApiSource> GetGoogleApiSourceAsync(string name, st::CancellationToken cancellationToken) =>
            GetGoogleApiSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single GoogleApiSource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the google api source to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleApiSource GetGoogleApiSource(GoogleApiSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleApiSource(new GetGoogleApiSourceRequest
            {
                GoogleApiSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single GoogleApiSource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the google api source to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleApiSource> GetGoogleApiSourceAsync(GoogleApiSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleApiSourceAsync(new GetGoogleApiSourceRequest
            {
                GoogleApiSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single GoogleApiSource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the google api source to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleApiSource> GetGoogleApiSourceAsync(GoogleApiSourceName name, st::CancellationToken cancellationToken) =>
            GetGoogleApiSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List GoogleApiSources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GoogleApiSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> ListGoogleApiSources(ListGoogleApiSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List GoogleApiSources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GoogleApiSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> ListGoogleApiSourcesAsync(ListGoogleApiSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List GoogleApiSources.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list GoogleApiSources on.
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
        /// <returns>A pageable sequence of <see cref="GoogleApiSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> ListGoogleApiSources(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGoogleApiSourcesRequest request = new ListGoogleApiSourcesRequest
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
            return ListGoogleApiSources(request, callSettings);
        }

        /// <summary>
        /// List GoogleApiSources.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list GoogleApiSources on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GoogleApiSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> ListGoogleApiSourcesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGoogleApiSourcesRequest request = new ListGoogleApiSourcesRequest
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
            return ListGoogleApiSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// List GoogleApiSources.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list GoogleApiSources on.
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
        /// <returns>A pageable sequence of <see cref="GoogleApiSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> ListGoogleApiSources(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGoogleApiSourcesRequest request = new ListGoogleApiSourcesRequest
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
            return ListGoogleApiSources(request, callSettings);
        }

        /// <summary>
        /// List GoogleApiSources.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list GoogleApiSources on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GoogleApiSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> ListGoogleApiSourcesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGoogleApiSourcesRequest request = new ListGoogleApiSourcesRequest
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
            return ListGoogleApiSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Create a new GoogleApiSource in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GoogleApiSource, OperationMetadata> CreateGoogleApiSource(CreateGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new GoogleApiSource in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> CreateGoogleApiSourceAsync(CreateGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new GoogleApiSource in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> CreateGoogleApiSourceAsync(CreateGoogleApiSourceRequest request, st::CancellationToken cancellationToken) =>
            CreateGoogleApiSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGoogleApiSource</c>.</summary>
        public virtual lro::OperationsClient CreateGoogleApiSourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateGoogleApiSource</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GoogleApiSource, OperationMetadata> PollOnceCreateGoogleApiSource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GoogleApiSource, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGoogleApiSourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGoogleApiSource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> PollOnceCreateGoogleApiSourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GoogleApiSource, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGoogleApiSourceOperationsClient, callSettings);

        /// <summary>
        /// Create a new GoogleApiSource in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this google api source.
        /// </param>
        /// <param name="googleApiSource">
        /// Required. The google api source to create.
        /// </param>
        /// <param name="googleApiSourceId">
        /// Required. The user-provided ID to be assigned to the GoogleApiSource. It
        /// should match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GoogleApiSource, OperationMetadata> CreateGoogleApiSource(string parent, GoogleApiSource googleApiSource, string googleApiSourceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGoogleApiSource(new CreateGoogleApiSourceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GoogleApiSource = gax::GaxPreconditions.CheckNotNull(googleApiSource, nameof(googleApiSource)),
                GoogleApiSourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(googleApiSourceId, nameof(googleApiSourceId)),
            }, callSettings);

        /// <summary>
        /// Create a new GoogleApiSource in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this google api source.
        /// </param>
        /// <param name="googleApiSource">
        /// Required. The google api source to create.
        /// </param>
        /// <param name="googleApiSourceId">
        /// Required. The user-provided ID to be assigned to the GoogleApiSource. It
        /// should match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> CreateGoogleApiSourceAsync(string parent, GoogleApiSource googleApiSource, string googleApiSourceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGoogleApiSourceAsync(new CreateGoogleApiSourceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GoogleApiSource = gax::GaxPreconditions.CheckNotNull(googleApiSource, nameof(googleApiSource)),
                GoogleApiSourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(googleApiSourceId, nameof(googleApiSourceId)),
            }, callSettings);

        /// <summary>
        /// Create a new GoogleApiSource in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this google api source.
        /// </param>
        /// <param name="googleApiSource">
        /// Required. The google api source to create.
        /// </param>
        /// <param name="googleApiSourceId">
        /// Required. The user-provided ID to be assigned to the GoogleApiSource. It
        /// should match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> CreateGoogleApiSourceAsync(string parent, GoogleApiSource googleApiSource, string googleApiSourceId, st::CancellationToken cancellationToken) =>
            CreateGoogleApiSourceAsync(parent, googleApiSource, googleApiSourceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new GoogleApiSource in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this google api source.
        /// </param>
        /// <param name="googleApiSource">
        /// Required. The google api source to create.
        /// </param>
        /// <param name="googleApiSourceId">
        /// Required. The user-provided ID to be assigned to the GoogleApiSource. It
        /// should match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GoogleApiSource, OperationMetadata> CreateGoogleApiSource(gagr::LocationName parent, GoogleApiSource googleApiSource, string googleApiSourceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGoogleApiSource(new CreateGoogleApiSourceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GoogleApiSource = gax::GaxPreconditions.CheckNotNull(googleApiSource, nameof(googleApiSource)),
                GoogleApiSourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(googleApiSourceId, nameof(googleApiSourceId)),
            }, callSettings);

        /// <summary>
        /// Create a new GoogleApiSource in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this google api source.
        /// </param>
        /// <param name="googleApiSource">
        /// Required. The google api source to create.
        /// </param>
        /// <param name="googleApiSourceId">
        /// Required. The user-provided ID to be assigned to the GoogleApiSource. It
        /// should match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> CreateGoogleApiSourceAsync(gagr::LocationName parent, GoogleApiSource googleApiSource, string googleApiSourceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGoogleApiSourceAsync(new CreateGoogleApiSourceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GoogleApiSource = gax::GaxPreconditions.CheckNotNull(googleApiSource, nameof(googleApiSource)),
                GoogleApiSourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(googleApiSourceId, nameof(googleApiSourceId)),
            }, callSettings);

        /// <summary>
        /// Create a new GoogleApiSource in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this google api source.
        /// </param>
        /// <param name="googleApiSource">
        /// Required. The google api source to create.
        /// </param>
        /// <param name="googleApiSourceId">
        /// Required. The user-provided ID to be assigned to the GoogleApiSource. It
        /// should match the format (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> CreateGoogleApiSourceAsync(gagr::LocationName parent, GoogleApiSource googleApiSource, string googleApiSourceId, st::CancellationToken cancellationToken) =>
            CreateGoogleApiSourceAsync(parent, googleApiSource, googleApiSourceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GoogleApiSource, OperationMetadata> UpdateGoogleApiSource(UpdateGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> UpdateGoogleApiSourceAsync(UpdateGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> UpdateGoogleApiSourceAsync(UpdateGoogleApiSourceRequest request, st::CancellationToken cancellationToken) =>
            UpdateGoogleApiSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateGoogleApiSource</c>.</summary>
        public virtual lro::OperationsClient UpdateGoogleApiSourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateGoogleApiSource</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GoogleApiSource, OperationMetadata> PollOnceUpdateGoogleApiSource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GoogleApiSource, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGoogleApiSourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGoogleApiSource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> PollOnceUpdateGoogleApiSourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GoogleApiSource, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGoogleApiSourceOperationsClient, callSettings);

        /// <summary>
        /// Update a single GoogleApiSource.
        /// </summary>
        /// <param name="googleApiSource">
        /// Required. The GoogleApiSource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to be updated; only fields explicitly provided are
        /// updated. If no field mask is provided, all provided fields in the request
        /// are updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GoogleApiSource, OperationMetadata> UpdateGoogleApiSource(GoogleApiSource googleApiSource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGoogleApiSource(new UpdateGoogleApiSourceRequest
            {
                GoogleApiSource = gax::GaxPreconditions.CheckNotNull(googleApiSource, nameof(googleApiSource)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single GoogleApiSource.
        /// </summary>
        /// <param name="googleApiSource">
        /// Required. The GoogleApiSource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to be updated; only fields explicitly provided are
        /// updated. If no field mask is provided, all provided fields in the request
        /// are updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> UpdateGoogleApiSourceAsync(GoogleApiSource googleApiSource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGoogleApiSourceAsync(new UpdateGoogleApiSourceRequest
            {
                GoogleApiSource = gax::GaxPreconditions.CheckNotNull(googleApiSource, nameof(googleApiSource)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single GoogleApiSource.
        /// </summary>
        /// <param name="googleApiSource">
        /// Required. The GoogleApiSource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to be updated; only fields explicitly provided are
        /// updated. If no field mask is provided, all provided fields in the request
        /// are updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> UpdateGoogleApiSourceAsync(GoogleApiSource googleApiSource, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGoogleApiSourceAsync(googleApiSource, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GoogleApiSource, OperationMetadata> DeleteGoogleApiSource(DeleteGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> DeleteGoogleApiSourceAsync(DeleteGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> DeleteGoogleApiSourceAsync(DeleteGoogleApiSourceRequest request, st::CancellationToken cancellationToken) =>
            DeleteGoogleApiSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGoogleApiSource</c>.</summary>
        public virtual lro::OperationsClient DeleteGoogleApiSourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteGoogleApiSource</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GoogleApiSource, OperationMetadata> PollOnceDeleteGoogleApiSource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GoogleApiSource, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGoogleApiSourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGoogleApiSource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> PollOnceDeleteGoogleApiSourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GoogleApiSource, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGoogleApiSourceOperationsClient, callSettings);

        /// <summary>
        /// Delete a single GoogleApiSource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GoogleApiSource to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the MessageBus will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GoogleApiSource, OperationMetadata> DeleteGoogleApiSource(string name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGoogleApiSource(new DeleteGoogleApiSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single GoogleApiSource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GoogleApiSource to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the MessageBus will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> DeleteGoogleApiSourceAsync(string name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGoogleApiSourceAsync(new DeleteGoogleApiSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single GoogleApiSource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GoogleApiSource to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the MessageBus will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> DeleteGoogleApiSourceAsync(string name, string etag, st::CancellationToken cancellationToken) =>
            DeleteGoogleApiSourceAsync(name, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single GoogleApiSource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GoogleApiSource to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the MessageBus will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GoogleApiSource, OperationMetadata> DeleteGoogleApiSource(GoogleApiSourceName name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGoogleApiSource(new DeleteGoogleApiSourceRequest
            {
                GoogleApiSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single GoogleApiSource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GoogleApiSource to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the MessageBus will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> DeleteGoogleApiSourceAsync(GoogleApiSourceName name, string etag, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGoogleApiSourceAsync(new DeleteGoogleApiSourceRequest
            {
                GoogleApiSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Etag = etag ?? "",
            }, callSettings);

        /// <summary>
        /// Delete a single GoogleApiSource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GoogleApiSource to be deleted.
        /// </param>
        /// <param name="etag">
        /// Optional. If provided, the MessageBus will only be deleted if the etag
        /// matches the current etag on the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> DeleteGoogleApiSourceAsync(GoogleApiSourceName name, string etag, st::CancellationToken cancellationToken) =>
            DeleteGoogleApiSourceAsync(name, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Eventarc client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Eventarc allows users to subscribe to various events that are provided by
    /// Google Cloud services and forward them to supported destinations.
    /// </remarks>
    public sealed partial class EventarcClientImpl : EventarcClient
    {
        private readonly gaxgrpc::ApiCall<GetTriggerRequest, Trigger> _callGetTrigger;

        private readonly gaxgrpc::ApiCall<ListTriggersRequest, ListTriggersResponse> _callListTriggers;

        private readonly gaxgrpc::ApiCall<CreateTriggerRequest, lro::Operation> _callCreateTrigger;

        private readonly gaxgrpc::ApiCall<UpdateTriggerRequest, lro::Operation> _callUpdateTrigger;

        private readonly gaxgrpc::ApiCall<DeleteTriggerRequest, lro::Operation> _callDeleteTrigger;

        private readonly gaxgrpc::ApiCall<GetChannelRequest, Channel> _callGetChannel;

        private readonly gaxgrpc::ApiCall<ListChannelsRequest, ListChannelsResponse> _callListChannels;

        private readonly gaxgrpc::ApiCall<CreateChannelRequest, lro::Operation> _callCreateChannel;

        private readonly gaxgrpc::ApiCall<UpdateChannelRequest, lro::Operation> _callUpdateChannel;

        private readonly gaxgrpc::ApiCall<DeleteChannelRequest, lro::Operation> _callDeleteChannel;

        private readonly gaxgrpc::ApiCall<GetProviderRequest, Provider> _callGetProvider;

        private readonly gaxgrpc::ApiCall<ListProvidersRequest, ListProvidersResponse> _callListProviders;

        private readonly gaxgrpc::ApiCall<GetChannelConnectionRequest, ChannelConnection> _callGetChannelConnection;

        private readonly gaxgrpc::ApiCall<ListChannelConnectionsRequest, ListChannelConnectionsResponse> _callListChannelConnections;

        private readonly gaxgrpc::ApiCall<CreateChannelConnectionRequest, lro::Operation> _callCreateChannelConnection;

        private readonly gaxgrpc::ApiCall<DeleteChannelConnectionRequest, lro::Operation> _callDeleteChannelConnection;

        private readonly gaxgrpc::ApiCall<GetGoogleChannelConfigRequest, GoogleChannelConfig> _callGetGoogleChannelConfig;

        private readonly gaxgrpc::ApiCall<UpdateGoogleChannelConfigRequest, GoogleChannelConfig> _callUpdateGoogleChannelConfig;

        private readonly gaxgrpc::ApiCall<GetMessageBusRequest, MessageBus> _callGetMessageBus;

        private readonly gaxgrpc::ApiCall<ListMessageBusesRequest, ListMessageBusesResponse> _callListMessageBuses;

        private readonly gaxgrpc::ApiCall<ListMessageBusEnrollmentsRequest, ListMessageBusEnrollmentsResponse> _callListMessageBusEnrollments;

        private readonly gaxgrpc::ApiCall<CreateMessageBusRequest, lro::Operation> _callCreateMessageBus;

        private readonly gaxgrpc::ApiCall<UpdateMessageBusRequest, lro::Operation> _callUpdateMessageBus;

        private readonly gaxgrpc::ApiCall<DeleteMessageBusRequest, lro::Operation> _callDeleteMessageBus;

        private readonly gaxgrpc::ApiCall<GetEnrollmentRequest, Enrollment> _callGetEnrollment;

        private readonly gaxgrpc::ApiCall<ListEnrollmentsRequest, ListEnrollmentsResponse> _callListEnrollments;

        private readonly gaxgrpc::ApiCall<CreateEnrollmentRequest, lro::Operation> _callCreateEnrollment;

        private readonly gaxgrpc::ApiCall<UpdateEnrollmentRequest, lro::Operation> _callUpdateEnrollment;

        private readonly gaxgrpc::ApiCall<DeleteEnrollmentRequest, lro::Operation> _callDeleteEnrollment;

        private readonly gaxgrpc::ApiCall<GetPipelineRequest, Pipeline> _callGetPipeline;

        private readonly gaxgrpc::ApiCall<ListPipelinesRequest, ListPipelinesResponse> _callListPipelines;

        private readonly gaxgrpc::ApiCall<CreatePipelineRequest, lro::Operation> _callCreatePipeline;

        private readonly gaxgrpc::ApiCall<UpdatePipelineRequest, lro::Operation> _callUpdatePipeline;

        private readonly gaxgrpc::ApiCall<DeletePipelineRequest, lro::Operation> _callDeletePipeline;

        private readonly gaxgrpc::ApiCall<GetGoogleApiSourceRequest, GoogleApiSource> _callGetGoogleApiSource;

        private readonly gaxgrpc::ApiCall<ListGoogleApiSourcesRequest, ListGoogleApiSourcesResponse> _callListGoogleApiSources;

        private readonly gaxgrpc::ApiCall<CreateGoogleApiSourceRequest, lro::Operation> _callCreateGoogleApiSource;

        private readonly gaxgrpc::ApiCall<UpdateGoogleApiSourceRequest, lro::Operation> _callUpdateGoogleApiSource;

        private readonly gaxgrpc::ApiCall<DeleteGoogleApiSourceRequest, lro::Operation> _callDeleteGoogleApiSource;

        /// <summary>
        /// Constructs a client wrapper for the Eventarc service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EventarcSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EventarcClientImpl(Eventarc.EventarcClient grpcClient, EventarcSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EventarcSettings effectiveSettings = settings ?? EventarcSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateTriggerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTriggerOperationsSettings, logger);
            UpdateTriggerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTriggerOperationsSettings, logger);
            DeleteTriggerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTriggerOperationsSettings, logger);
            CreateChannelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateChannelOperationsSettings, logger);
            UpdateChannelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateChannelOperationsSettings, logger);
            DeleteChannelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteChannelOperationsSettings, logger);
            CreateChannelConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateChannelConnectionOperationsSettings, logger);
            DeleteChannelConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteChannelConnectionOperationsSettings, logger);
            CreateMessageBusOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMessageBusOperationsSettings, logger);
            UpdateMessageBusOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMessageBusOperationsSettings, logger);
            DeleteMessageBusOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMessageBusOperationsSettings, logger);
            CreateEnrollmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEnrollmentOperationsSettings, logger);
            UpdateEnrollmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEnrollmentOperationsSettings, logger);
            DeleteEnrollmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEnrollmentOperationsSettings, logger);
            CreatePipelineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePipelineOperationsSettings, logger);
            UpdatePipelineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdatePipelineOperationsSettings, logger);
            DeletePipelineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePipelineOperationsSettings, logger);
            CreateGoogleApiSourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGoogleApiSourceOperationsSettings, logger);
            UpdateGoogleApiSourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGoogleApiSourceOperationsSettings, logger);
            DeleteGoogleApiSourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGoogleApiSourceOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callGetTrigger = clientHelper.BuildApiCall<GetTriggerRequest, Trigger>("GetTrigger", grpcClient.GetTriggerAsync, grpcClient.GetTrigger, effectiveSettings.GetTriggerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTrigger);
            Modify_GetTriggerApiCall(ref _callGetTrigger);
            _callListTriggers = clientHelper.BuildApiCall<ListTriggersRequest, ListTriggersResponse>("ListTriggers", grpcClient.ListTriggersAsync, grpcClient.ListTriggers, effectiveSettings.ListTriggersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTriggers);
            Modify_ListTriggersApiCall(ref _callListTriggers);
            _callCreateTrigger = clientHelper.BuildApiCall<CreateTriggerRequest, lro::Operation>("CreateTrigger", grpcClient.CreateTriggerAsync, grpcClient.CreateTrigger, effectiveSettings.CreateTriggerSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTrigger);
            Modify_CreateTriggerApiCall(ref _callCreateTrigger);
            _callUpdateTrigger = clientHelper.BuildApiCall<UpdateTriggerRequest, lro::Operation>("UpdateTrigger", grpcClient.UpdateTriggerAsync, grpcClient.UpdateTrigger, effectiveSettings.UpdateTriggerSettings).WithGoogleRequestParam("trigger.name", request => request.Trigger?.Name);
            Modify_ApiCall(ref _callUpdateTrigger);
            Modify_UpdateTriggerApiCall(ref _callUpdateTrigger);
            _callDeleteTrigger = clientHelper.BuildApiCall<DeleteTriggerRequest, lro::Operation>("DeleteTrigger", grpcClient.DeleteTriggerAsync, grpcClient.DeleteTrigger, effectiveSettings.DeleteTriggerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTrigger);
            Modify_DeleteTriggerApiCall(ref _callDeleteTrigger);
            _callGetChannel = clientHelper.BuildApiCall<GetChannelRequest, Channel>("GetChannel", grpcClient.GetChannelAsync, grpcClient.GetChannel, effectiveSettings.GetChannelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetChannel);
            Modify_GetChannelApiCall(ref _callGetChannel);
            _callListChannels = clientHelper.BuildApiCall<ListChannelsRequest, ListChannelsResponse>("ListChannels", grpcClient.ListChannelsAsync, grpcClient.ListChannels, effectiveSettings.ListChannelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListChannels);
            Modify_ListChannelsApiCall(ref _callListChannels);
            _callCreateChannel = clientHelper.BuildApiCall<CreateChannelRequest, lro::Operation>("CreateChannel", grpcClient.CreateChannelAsync, grpcClient.CreateChannel, effectiveSettings.CreateChannelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateChannel);
            Modify_CreateChannelApiCall(ref _callCreateChannel);
            _callUpdateChannel = clientHelper.BuildApiCall<UpdateChannelRequest, lro::Operation>("UpdateChannel", grpcClient.UpdateChannelAsync, grpcClient.UpdateChannel, effectiveSettings.UpdateChannelSettings).WithGoogleRequestParam("channel.name", request => request.Channel?.Name);
            Modify_ApiCall(ref _callUpdateChannel);
            Modify_UpdateChannelApiCall(ref _callUpdateChannel);
            _callDeleteChannel = clientHelper.BuildApiCall<DeleteChannelRequest, lro::Operation>("DeleteChannel", grpcClient.DeleteChannelAsync, grpcClient.DeleteChannel, effectiveSettings.DeleteChannelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteChannel);
            Modify_DeleteChannelApiCall(ref _callDeleteChannel);
            _callGetProvider = clientHelper.BuildApiCall<GetProviderRequest, Provider>("GetProvider", grpcClient.GetProviderAsync, grpcClient.GetProvider, effectiveSettings.GetProviderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProvider);
            Modify_GetProviderApiCall(ref _callGetProvider);
            _callListProviders = clientHelper.BuildApiCall<ListProvidersRequest, ListProvidersResponse>("ListProviders", grpcClient.ListProvidersAsync, grpcClient.ListProviders, effectiveSettings.ListProvidersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProviders);
            Modify_ListProvidersApiCall(ref _callListProviders);
            _callGetChannelConnection = clientHelper.BuildApiCall<GetChannelConnectionRequest, ChannelConnection>("GetChannelConnection", grpcClient.GetChannelConnectionAsync, grpcClient.GetChannelConnection, effectiveSettings.GetChannelConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetChannelConnection);
            Modify_GetChannelConnectionApiCall(ref _callGetChannelConnection);
            _callListChannelConnections = clientHelper.BuildApiCall<ListChannelConnectionsRequest, ListChannelConnectionsResponse>("ListChannelConnections", grpcClient.ListChannelConnectionsAsync, grpcClient.ListChannelConnections, effectiveSettings.ListChannelConnectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListChannelConnections);
            Modify_ListChannelConnectionsApiCall(ref _callListChannelConnections);
            _callCreateChannelConnection = clientHelper.BuildApiCall<CreateChannelConnectionRequest, lro::Operation>("CreateChannelConnection", grpcClient.CreateChannelConnectionAsync, grpcClient.CreateChannelConnection, effectiveSettings.CreateChannelConnectionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateChannelConnection);
            Modify_CreateChannelConnectionApiCall(ref _callCreateChannelConnection);
            _callDeleteChannelConnection = clientHelper.BuildApiCall<DeleteChannelConnectionRequest, lro::Operation>("DeleteChannelConnection", grpcClient.DeleteChannelConnectionAsync, grpcClient.DeleteChannelConnection, effectiveSettings.DeleteChannelConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteChannelConnection);
            Modify_DeleteChannelConnectionApiCall(ref _callDeleteChannelConnection);
            _callGetGoogleChannelConfig = clientHelper.BuildApiCall<GetGoogleChannelConfigRequest, GoogleChannelConfig>("GetGoogleChannelConfig", grpcClient.GetGoogleChannelConfigAsync, grpcClient.GetGoogleChannelConfig, effectiveSettings.GetGoogleChannelConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGoogleChannelConfig);
            Modify_GetGoogleChannelConfigApiCall(ref _callGetGoogleChannelConfig);
            _callUpdateGoogleChannelConfig = clientHelper.BuildApiCall<UpdateGoogleChannelConfigRequest, GoogleChannelConfig>("UpdateGoogleChannelConfig", grpcClient.UpdateGoogleChannelConfigAsync, grpcClient.UpdateGoogleChannelConfig, effectiveSettings.UpdateGoogleChannelConfigSettings).WithGoogleRequestParam("google_channel_config.name", request => request.GoogleChannelConfig?.Name);
            Modify_ApiCall(ref _callUpdateGoogleChannelConfig);
            Modify_UpdateGoogleChannelConfigApiCall(ref _callUpdateGoogleChannelConfig);
            _callGetMessageBus = clientHelper.BuildApiCall<GetMessageBusRequest, MessageBus>("GetMessageBus", grpcClient.GetMessageBusAsync, grpcClient.GetMessageBus, effectiveSettings.GetMessageBusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMessageBus);
            Modify_GetMessageBusApiCall(ref _callGetMessageBus);
            _callListMessageBuses = clientHelper.BuildApiCall<ListMessageBusesRequest, ListMessageBusesResponse>("ListMessageBuses", grpcClient.ListMessageBusesAsync, grpcClient.ListMessageBuses, effectiveSettings.ListMessageBusesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMessageBuses);
            Modify_ListMessageBusesApiCall(ref _callListMessageBuses);
            _callListMessageBusEnrollments = clientHelper.BuildApiCall<ListMessageBusEnrollmentsRequest, ListMessageBusEnrollmentsResponse>("ListMessageBusEnrollments", grpcClient.ListMessageBusEnrollmentsAsync, grpcClient.ListMessageBusEnrollments, effectiveSettings.ListMessageBusEnrollmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMessageBusEnrollments);
            Modify_ListMessageBusEnrollmentsApiCall(ref _callListMessageBusEnrollments);
            _callCreateMessageBus = clientHelper.BuildApiCall<CreateMessageBusRequest, lro::Operation>("CreateMessageBus", grpcClient.CreateMessageBusAsync, grpcClient.CreateMessageBus, effectiveSettings.CreateMessageBusSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMessageBus);
            Modify_CreateMessageBusApiCall(ref _callCreateMessageBus);
            _callUpdateMessageBus = clientHelper.BuildApiCall<UpdateMessageBusRequest, lro::Operation>("UpdateMessageBus", grpcClient.UpdateMessageBusAsync, grpcClient.UpdateMessageBus, effectiveSettings.UpdateMessageBusSettings).WithGoogleRequestParam("message_bus.name", request => request.MessageBus?.Name);
            Modify_ApiCall(ref _callUpdateMessageBus);
            Modify_UpdateMessageBusApiCall(ref _callUpdateMessageBus);
            _callDeleteMessageBus = clientHelper.BuildApiCall<DeleteMessageBusRequest, lro::Operation>("DeleteMessageBus", grpcClient.DeleteMessageBusAsync, grpcClient.DeleteMessageBus, effectiveSettings.DeleteMessageBusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMessageBus);
            Modify_DeleteMessageBusApiCall(ref _callDeleteMessageBus);
            _callGetEnrollment = clientHelper.BuildApiCall<GetEnrollmentRequest, Enrollment>("GetEnrollment", grpcClient.GetEnrollmentAsync, grpcClient.GetEnrollment, effectiveSettings.GetEnrollmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEnrollment);
            Modify_GetEnrollmentApiCall(ref _callGetEnrollment);
            _callListEnrollments = clientHelper.BuildApiCall<ListEnrollmentsRequest, ListEnrollmentsResponse>("ListEnrollments", grpcClient.ListEnrollmentsAsync, grpcClient.ListEnrollments, effectiveSettings.ListEnrollmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEnrollments);
            Modify_ListEnrollmentsApiCall(ref _callListEnrollments);
            _callCreateEnrollment = clientHelper.BuildApiCall<CreateEnrollmentRequest, lro::Operation>("CreateEnrollment", grpcClient.CreateEnrollmentAsync, grpcClient.CreateEnrollment, effectiveSettings.CreateEnrollmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEnrollment);
            Modify_CreateEnrollmentApiCall(ref _callCreateEnrollment);
            _callUpdateEnrollment = clientHelper.BuildApiCall<UpdateEnrollmentRequest, lro::Operation>("UpdateEnrollment", grpcClient.UpdateEnrollmentAsync, grpcClient.UpdateEnrollment, effectiveSettings.UpdateEnrollmentSettings).WithGoogleRequestParam("enrollment.name", request => request.Enrollment?.Name);
            Modify_ApiCall(ref _callUpdateEnrollment);
            Modify_UpdateEnrollmentApiCall(ref _callUpdateEnrollment);
            _callDeleteEnrollment = clientHelper.BuildApiCall<DeleteEnrollmentRequest, lro::Operation>("DeleteEnrollment", grpcClient.DeleteEnrollmentAsync, grpcClient.DeleteEnrollment, effectiveSettings.DeleteEnrollmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEnrollment);
            Modify_DeleteEnrollmentApiCall(ref _callDeleteEnrollment);
            _callGetPipeline = clientHelper.BuildApiCall<GetPipelineRequest, Pipeline>("GetPipeline", grpcClient.GetPipelineAsync, grpcClient.GetPipeline, effectiveSettings.GetPipelineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPipeline);
            Modify_GetPipelineApiCall(ref _callGetPipeline);
            _callListPipelines = clientHelper.BuildApiCall<ListPipelinesRequest, ListPipelinesResponse>("ListPipelines", grpcClient.ListPipelinesAsync, grpcClient.ListPipelines, effectiveSettings.ListPipelinesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPipelines);
            Modify_ListPipelinesApiCall(ref _callListPipelines);
            _callCreatePipeline = clientHelper.BuildApiCall<CreatePipelineRequest, lro::Operation>("CreatePipeline", grpcClient.CreatePipelineAsync, grpcClient.CreatePipeline, effectiveSettings.CreatePipelineSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePipeline);
            Modify_CreatePipelineApiCall(ref _callCreatePipeline);
            _callUpdatePipeline = clientHelper.BuildApiCall<UpdatePipelineRequest, lro::Operation>("UpdatePipeline", grpcClient.UpdatePipelineAsync, grpcClient.UpdatePipeline, effectiveSettings.UpdatePipelineSettings).WithGoogleRequestParam("pipeline.name", request => request.Pipeline?.Name);
            Modify_ApiCall(ref _callUpdatePipeline);
            Modify_UpdatePipelineApiCall(ref _callUpdatePipeline);
            _callDeletePipeline = clientHelper.BuildApiCall<DeletePipelineRequest, lro::Operation>("DeletePipeline", grpcClient.DeletePipelineAsync, grpcClient.DeletePipeline, effectiveSettings.DeletePipelineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePipeline);
            Modify_DeletePipelineApiCall(ref _callDeletePipeline);
            _callGetGoogleApiSource = clientHelper.BuildApiCall<GetGoogleApiSourceRequest, GoogleApiSource>("GetGoogleApiSource", grpcClient.GetGoogleApiSourceAsync, grpcClient.GetGoogleApiSource, effectiveSettings.GetGoogleApiSourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGoogleApiSource);
            Modify_GetGoogleApiSourceApiCall(ref _callGetGoogleApiSource);
            _callListGoogleApiSources = clientHelper.BuildApiCall<ListGoogleApiSourcesRequest, ListGoogleApiSourcesResponse>("ListGoogleApiSources", grpcClient.ListGoogleApiSourcesAsync, grpcClient.ListGoogleApiSources, effectiveSettings.ListGoogleApiSourcesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGoogleApiSources);
            Modify_ListGoogleApiSourcesApiCall(ref _callListGoogleApiSources);
            _callCreateGoogleApiSource = clientHelper.BuildApiCall<CreateGoogleApiSourceRequest, lro::Operation>("CreateGoogleApiSource", grpcClient.CreateGoogleApiSourceAsync, grpcClient.CreateGoogleApiSource, effectiveSettings.CreateGoogleApiSourceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGoogleApiSource);
            Modify_CreateGoogleApiSourceApiCall(ref _callCreateGoogleApiSource);
            _callUpdateGoogleApiSource = clientHelper.BuildApiCall<UpdateGoogleApiSourceRequest, lro::Operation>("UpdateGoogleApiSource", grpcClient.UpdateGoogleApiSourceAsync, grpcClient.UpdateGoogleApiSource, effectiveSettings.UpdateGoogleApiSourceSettings).WithGoogleRequestParam("google_api_source.name", request => request.GoogleApiSource?.Name);
            Modify_ApiCall(ref _callUpdateGoogleApiSource);
            Modify_UpdateGoogleApiSourceApiCall(ref _callUpdateGoogleApiSource);
            _callDeleteGoogleApiSource = clientHelper.BuildApiCall<DeleteGoogleApiSourceRequest, lro::Operation>("DeleteGoogleApiSource", grpcClient.DeleteGoogleApiSourceAsync, grpcClient.DeleteGoogleApiSource, effectiveSettings.DeleteGoogleApiSourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGoogleApiSource);
            Modify_DeleteGoogleApiSourceApiCall(ref _callDeleteGoogleApiSource);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetTriggerApiCall(ref gaxgrpc::ApiCall<GetTriggerRequest, Trigger> call);

        partial void Modify_ListTriggersApiCall(ref gaxgrpc::ApiCall<ListTriggersRequest, ListTriggersResponse> call);

        partial void Modify_CreateTriggerApiCall(ref gaxgrpc::ApiCall<CreateTriggerRequest, lro::Operation> call);

        partial void Modify_UpdateTriggerApiCall(ref gaxgrpc::ApiCall<UpdateTriggerRequest, lro::Operation> call);

        partial void Modify_DeleteTriggerApiCall(ref gaxgrpc::ApiCall<DeleteTriggerRequest, lro::Operation> call);

        partial void Modify_GetChannelApiCall(ref gaxgrpc::ApiCall<GetChannelRequest, Channel> call);

        partial void Modify_ListChannelsApiCall(ref gaxgrpc::ApiCall<ListChannelsRequest, ListChannelsResponse> call);

        partial void Modify_CreateChannelApiCall(ref gaxgrpc::ApiCall<CreateChannelRequest, lro::Operation> call);

        partial void Modify_UpdateChannelApiCall(ref gaxgrpc::ApiCall<UpdateChannelRequest, lro::Operation> call);

        partial void Modify_DeleteChannelApiCall(ref gaxgrpc::ApiCall<DeleteChannelRequest, lro::Operation> call);

        partial void Modify_GetProviderApiCall(ref gaxgrpc::ApiCall<GetProviderRequest, Provider> call);

        partial void Modify_ListProvidersApiCall(ref gaxgrpc::ApiCall<ListProvidersRequest, ListProvidersResponse> call);

        partial void Modify_GetChannelConnectionApiCall(ref gaxgrpc::ApiCall<GetChannelConnectionRequest, ChannelConnection> call);

        partial void Modify_ListChannelConnectionsApiCall(ref gaxgrpc::ApiCall<ListChannelConnectionsRequest, ListChannelConnectionsResponse> call);

        partial void Modify_CreateChannelConnectionApiCall(ref gaxgrpc::ApiCall<CreateChannelConnectionRequest, lro::Operation> call);

        partial void Modify_DeleteChannelConnectionApiCall(ref gaxgrpc::ApiCall<DeleteChannelConnectionRequest, lro::Operation> call);

        partial void Modify_GetGoogleChannelConfigApiCall(ref gaxgrpc::ApiCall<GetGoogleChannelConfigRequest, GoogleChannelConfig> call);

        partial void Modify_UpdateGoogleChannelConfigApiCall(ref gaxgrpc::ApiCall<UpdateGoogleChannelConfigRequest, GoogleChannelConfig> call);

        partial void Modify_GetMessageBusApiCall(ref gaxgrpc::ApiCall<GetMessageBusRequest, MessageBus> call);

        partial void Modify_ListMessageBusesApiCall(ref gaxgrpc::ApiCall<ListMessageBusesRequest, ListMessageBusesResponse> call);

        partial void Modify_ListMessageBusEnrollmentsApiCall(ref gaxgrpc::ApiCall<ListMessageBusEnrollmentsRequest, ListMessageBusEnrollmentsResponse> call);

        partial void Modify_CreateMessageBusApiCall(ref gaxgrpc::ApiCall<CreateMessageBusRequest, lro::Operation> call);

        partial void Modify_UpdateMessageBusApiCall(ref gaxgrpc::ApiCall<UpdateMessageBusRequest, lro::Operation> call);

        partial void Modify_DeleteMessageBusApiCall(ref gaxgrpc::ApiCall<DeleteMessageBusRequest, lro::Operation> call);

        partial void Modify_GetEnrollmentApiCall(ref gaxgrpc::ApiCall<GetEnrollmentRequest, Enrollment> call);

        partial void Modify_ListEnrollmentsApiCall(ref gaxgrpc::ApiCall<ListEnrollmentsRequest, ListEnrollmentsResponse> call);

        partial void Modify_CreateEnrollmentApiCall(ref gaxgrpc::ApiCall<CreateEnrollmentRequest, lro::Operation> call);

        partial void Modify_UpdateEnrollmentApiCall(ref gaxgrpc::ApiCall<UpdateEnrollmentRequest, lro::Operation> call);

        partial void Modify_DeleteEnrollmentApiCall(ref gaxgrpc::ApiCall<DeleteEnrollmentRequest, lro::Operation> call);

        partial void Modify_GetPipelineApiCall(ref gaxgrpc::ApiCall<GetPipelineRequest, Pipeline> call);

        partial void Modify_ListPipelinesApiCall(ref gaxgrpc::ApiCall<ListPipelinesRequest, ListPipelinesResponse> call);

        partial void Modify_CreatePipelineApiCall(ref gaxgrpc::ApiCall<CreatePipelineRequest, lro::Operation> call);

        partial void Modify_UpdatePipelineApiCall(ref gaxgrpc::ApiCall<UpdatePipelineRequest, lro::Operation> call);

        partial void Modify_DeletePipelineApiCall(ref gaxgrpc::ApiCall<DeletePipelineRequest, lro::Operation> call);

        partial void Modify_GetGoogleApiSourceApiCall(ref gaxgrpc::ApiCall<GetGoogleApiSourceRequest, GoogleApiSource> call);

        partial void Modify_ListGoogleApiSourcesApiCall(ref gaxgrpc::ApiCall<ListGoogleApiSourcesRequest, ListGoogleApiSourcesResponse> call);

        partial void Modify_CreateGoogleApiSourceApiCall(ref gaxgrpc::ApiCall<CreateGoogleApiSourceRequest, lro::Operation> call);

        partial void Modify_UpdateGoogleApiSourceApiCall(ref gaxgrpc::ApiCall<UpdateGoogleApiSourceRequest, lro::Operation> call);

        partial void Modify_DeleteGoogleApiSourceApiCall(ref gaxgrpc::ApiCall<DeleteGoogleApiSourceRequest, lro::Operation> call);

        partial void OnConstruction(Eventarc.EventarcClient grpcClient, EventarcSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Eventarc client</summary>
        public override Eventarc.EventarcClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_GetTriggerRequest(ref GetTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTriggersRequest(ref ListTriggersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTriggerRequest(ref CreateTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTriggerRequest(ref UpdateTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTriggerRequest(ref DeleteTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetChannelRequest(ref GetChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListChannelsRequest(ref ListChannelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateChannelRequest(ref CreateChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateChannelRequest(ref UpdateChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteChannelRequest(ref DeleteChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProviderRequest(ref GetProviderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProvidersRequest(ref ListProvidersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetChannelConnectionRequest(ref GetChannelConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListChannelConnectionsRequest(ref ListChannelConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateChannelConnectionRequest(ref CreateChannelConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteChannelConnectionRequest(ref DeleteChannelConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGoogleChannelConfigRequest(ref GetGoogleChannelConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGoogleChannelConfigRequest(ref UpdateGoogleChannelConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMessageBusRequest(ref GetMessageBusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMessageBusesRequest(ref ListMessageBusesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMessageBusEnrollmentsRequest(ref ListMessageBusEnrollmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMessageBusRequest(ref CreateMessageBusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMessageBusRequest(ref UpdateMessageBusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMessageBusRequest(ref DeleteMessageBusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEnrollmentRequest(ref GetEnrollmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEnrollmentsRequest(ref ListEnrollmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEnrollmentRequest(ref CreateEnrollmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEnrollmentRequest(ref UpdateEnrollmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEnrollmentRequest(ref DeleteEnrollmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPipelineRequest(ref GetPipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPipelinesRequest(ref ListPipelinesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePipelineRequest(ref CreatePipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePipelineRequest(ref UpdatePipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePipelineRequest(ref DeletePipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGoogleApiSourceRequest(ref GetGoogleApiSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGoogleApiSourcesRequest(ref ListGoogleApiSourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGoogleApiSourceRequest(ref CreateGoogleApiSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGoogleApiSourceRequest(ref UpdateGoogleApiSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGoogleApiSourceRequest(ref DeleteGoogleApiSourceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Trigger GetTrigger(GetTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTriggerRequest(ref request, ref callSettings);
            return _callGetTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Trigger> GetTriggerAsync(GetTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTriggerRequest(ref request, ref callSettings);
            return _callGetTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Trigger"/> resources.</returns>
        public override gax::PagedEnumerable<ListTriggersResponse, Trigger> ListTriggers(ListTriggersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTriggersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTriggersRequest, ListTriggersResponse, Trigger>(_callListTriggers, request, callSettings);
        }

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Trigger"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTriggersResponse, Trigger> ListTriggersAsync(ListTriggersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTriggersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTriggersRequest, ListTriggersResponse, Trigger>(_callListTriggers, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTrigger</c>.</summary>
        public override lro::OperationsClient CreateTriggerOperationsClient { get; }

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Trigger, OperationMetadata> CreateTrigger(CreateTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Trigger, OperationMetadata>(_callCreateTrigger.Sync(request, callSettings), CreateTriggerOperationsClient);
        }

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(CreateTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Trigger, OperationMetadata>(await _callCreateTrigger.Async(request, callSettings).ConfigureAwait(false), CreateTriggerOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateTrigger</c>.</summary>
        public override lro::OperationsClient UpdateTriggerOperationsClient { get; }

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Trigger, OperationMetadata> UpdateTrigger(UpdateTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Trigger, OperationMetadata>(_callUpdateTrigger.Sync(request, callSettings), UpdateTriggerOperationsClient);
        }

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Trigger, OperationMetadata>> UpdateTriggerAsync(UpdateTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Trigger, OperationMetadata>(await _callUpdateTrigger.Async(request, callSettings).ConfigureAwait(false), UpdateTriggerOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTrigger</c>.</summary>
        public override lro::OperationsClient DeleteTriggerOperationsClient { get; }

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Trigger, OperationMetadata> DeleteTrigger(DeleteTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Trigger, OperationMetadata>(_callDeleteTrigger.Sync(request, callSettings), DeleteTriggerOperationsClient);
        }

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(DeleteTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Trigger, OperationMetadata>(await _callDeleteTrigger.Async(request, callSettings).ConfigureAwait(false), DeleteTriggerOperationsClient);
        }

        /// <summary>
        /// Get a single Channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Channel GetChannel(GetChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChannelRequest(ref request, ref callSettings);
            return _callGetChannel.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a single Channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Channel> GetChannelAsync(GetChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChannelRequest(ref request, ref callSettings);
            return _callGetChannel.Async(request, callSettings);
        }

        /// <summary>
        /// List channels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Channel"/> resources.</returns>
        public override gax::PagedEnumerable<ListChannelsResponse, Channel> ListChannels(ListChannelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChannelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListChannelsRequest, ListChannelsResponse, Channel>(_callListChannels, request, callSettings);
        }

        /// <summary>
        /// List channels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Channel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListChannelsResponse, Channel> ListChannelsAsync(ListChannelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChannelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListChannelsRequest, ListChannelsResponse, Channel>(_callListChannels, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateChannel</c>.</summary>
        public override lro::OperationsClient CreateChannelOperationsClient { get; }

        /// <summary>
        /// Create a new channel in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Channel, OperationMetadata> CreateChannel(CreateChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChannelRequest(ref request, ref callSettings);
            return new lro::Operation<Channel, OperationMetadata>(_callCreateChannel.Sync(request, callSettings), CreateChannelOperationsClient);
        }

        /// <summary>
        /// Create a new channel in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(CreateChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChannelRequest(ref request, ref callSettings);
            return new lro::Operation<Channel, OperationMetadata>(await _callCreateChannel.Async(request, callSettings).ConfigureAwait(false), CreateChannelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateChannel</c>.</summary>
        public override lro::OperationsClient UpdateChannelOperationsClient { get; }

        /// <summary>
        /// Update a single channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Channel, OperationMetadata> UpdateChannel(UpdateChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateChannelRequest(ref request, ref callSettings);
            return new lro::Operation<Channel, OperationMetadata>(_callUpdateChannel.Sync(request, callSettings), UpdateChannelOperationsClient);
        }

        /// <summary>
        /// Update a single channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Channel, OperationMetadata>> UpdateChannelAsync(UpdateChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateChannelRequest(ref request, ref callSettings);
            return new lro::Operation<Channel, OperationMetadata>(await _callUpdateChannel.Async(request, callSettings).ConfigureAwait(false), UpdateChannelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteChannel</c>.</summary>
        public override lro::OperationsClient DeleteChannelOperationsClient { get; }

        /// <summary>
        /// Delete a single channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Channel, OperationMetadata> DeleteChannel(DeleteChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteChannelRequest(ref request, ref callSettings);
            return new lro::Operation<Channel, OperationMetadata>(_callDeleteChannel.Sync(request, callSettings), DeleteChannelOperationsClient);
        }

        /// <summary>
        /// Delete a single channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Channel, OperationMetadata>> DeleteChannelAsync(DeleteChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteChannelRequest(ref request, ref callSettings);
            return new lro::Operation<Channel, OperationMetadata>(await _callDeleteChannel.Async(request, callSettings).ConfigureAwait(false), DeleteChannelOperationsClient);
        }

        /// <summary>
        /// Get a single Provider.
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
        /// Get a single Provider.
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
        /// List providers.
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
        /// List providers.
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
        /// Get a single ChannelConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ChannelConnection GetChannelConnection(GetChannelConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChannelConnectionRequest(ref request, ref callSettings);
            return _callGetChannelConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a single ChannelConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ChannelConnection> GetChannelConnectionAsync(GetChannelConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChannelConnectionRequest(ref request, ref callSettings);
            return _callGetChannelConnection.Async(request, callSettings);
        }

        /// <summary>
        /// List channel connections.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ChannelConnection"/> resources.</returns>
        public override gax::PagedEnumerable<ListChannelConnectionsResponse, ChannelConnection> ListChannelConnections(ListChannelConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChannelConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListChannelConnectionsRequest, ListChannelConnectionsResponse, ChannelConnection>(_callListChannelConnections, request, callSettings);
        }

        /// <summary>
        /// List channel connections.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ChannelConnection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListChannelConnectionsResponse, ChannelConnection> ListChannelConnectionsAsync(ListChannelConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChannelConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListChannelConnectionsRequest, ListChannelConnectionsResponse, ChannelConnection>(_callListChannelConnections, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateChannelConnection</c>.</summary>
        public override lro::OperationsClient CreateChannelConnectionOperationsClient { get; }

        /// <summary>
        /// Create a new ChannelConnection in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ChannelConnection, OperationMetadata> CreateChannelConnection(CreateChannelConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChannelConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<ChannelConnection, OperationMetadata>(_callCreateChannelConnection.Sync(request, callSettings), CreateChannelConnectionOperationsClient);
        }

        /// <summary>
        /// Create a new ChannelConnection in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> CreateChannelConnectionAsync(CreateChannelConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChannelConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<ChannelConnection, OperationMetadata>(await _callCreateChannelConnection.Async(request, callSettings).ConfigureAwait(false), CreateChannelConnectionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteChannelConnection</c>.</summary>
        public override lro::OperationsClient DeleteChannelConnectionOperationsClient { get; }

        /// <summary>
        /// Delete a single ChannelConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ChannelConnection, OperationMetadata> DeleteChannelConnection(DeleteChannelConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteChannelConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<ChannelConnection, OperationMetadata>(_callDeleteChannelConnection.Sync(request, callSettings), DeleteChannelConnectionOperationsClient);
        }

        /// <summary>
        /// Delete a single ChannelConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ChannelConnection, OperationMetadata>> DeleteChannelConnectionAsync(DeleteChannelConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteChannelConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<ChannelConnection, OperationMetadata>(await _callDeleteChannelConnection.Async(request, callSettings).ConfigureAwait(false), DeleteChannelConnectionOperationsClient);
        }

        /// <summary>
        /// Get a GoogleChannelConfig
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GoogleChannelConfig GetGoogleChannelConfig(GetGoogleChannelConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGoogleChannelConfigRequest(ref request, ref callSettings);
            return _callGetGoogleChannelConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a GoogleChannelConfig
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GoogleChannelConfig> GetGoogleChannelConfigAsync(GetGoogleChannelConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGoogleChannelConfigRequest(ref request, ref callSettings);
            return _callGetGoogleChannelConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Update a single GoogleChannelConfig
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GoogleChannelConfig UpdateGoogleChannelConfig(UpdateGoogleChannelConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGoogleChannelConfigRequest(ref request, ref callSettings);
            return _callUpdateGoogleChannelConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a single GoogleChannelConfig
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GoogleChannelConfig> UpdateGoogleChannelConfigAsync(UpdateGoogleChannelConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGoogleChannelConfigRequest(ref request, ref callSettings);
            return _callUpdateGoogleChannelConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Get a single MessageBus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MessageBus GetMessageBus(GetMessageBusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMessageBusRequest(ref request, ref callSettings);
            return _callGetMessageBus.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a single MessageBus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MessageBus> GetMessageBusAsync(GetMessageBusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMessageBusRequest(ref request, ref callSettings);
            return _callGetMessageBus.Async(request, callSettings);
        }

        /// <summary>
        /// List message buses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MessageBus"/> resources.</returns>
        public override gax::PagedEnumerable<ListMessageBusesResponse, MessageBus> ListMessageBuses(ListMessageBusesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMessageBusesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMessageBusesRequest, ListMessageBusesResponse, MessageBus>(_callListMessageBuses, request, callSettings);
        }

        /// <summary>
        /// List message buses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MessageBus"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMessageBusesResponse, MessageBus> ListMessageBusesAsync(ListMessageBusesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMessageBusesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMessageBusesRequest, ListMessageBusesResponse, MessageBus>(_callListMessageBuses, request, callSettings);
        }

        /// <summary>
        /// List message bus enrollments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<ListMessageBusEnrollmentsResponse, string> ListMessageBusEnrollments(ListMessageBusEnrollmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMessageBusEnrollmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMessageBusEnrollmentsRequest, ListMessageBusEnrollmentsResponse, string>(_callListMessageBusEnrollments, request, callSettings);
        }

        /// <summary>
        /// List message bus enrollments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMessageBusEnrollmentsResponse, string> ListMessageBusEnrollmentsAsync(ListMessageBusEnrollmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMessageBusEnrollmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMessageBusEnrollmentsRequest, ListMessageBusEnrollmentsResponse, string>(_callListMessageBusEnrollments, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMessageBus</c>.</summary>
        public override lro::OperationsClient CreateMessageBusOperationsClient { get; }

        /// <summary>
        /// Create a new MessageBus in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MessageBus, OperationMetadata> CreateMessageBus(CreateMessageBusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMessageBusRequest(ref request, ref callSettings);
            return new lro::Operation<MessageBus, OperationMetadata>(_callCreateMessageBus.Sync(request, callSettings), CreateMessageBusOperationsClient);
        }

        /// <summary>
        /// Create a new MessageBus in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MessageBus, OperationMetadata>> CreateMessageBusAsync(CreateMessageBusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMessageBusRequest(ref request, ref callSettings);
            return new lro::Operation<MessageBus, OperationMetadata>(await _callCreateMessageBus.Async(request, callSettings).ConfigureAwait(false), CreateMessageBusOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMessageBus</c>.</summary>
        public override lro::OperationsClient UpdateMessageBusOperationsClient { get; }

        /// <summary>
        /// Update a single message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MessageBus, OperationMetadata> UpdateMessageBus(UpdateMessageBusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMessageBusRequest(ref request, ref callSettings);
            return new lro::Operation<MessageBus, OperationMetadata>(_callUpdateMessageBus.Sync(request, callSettings), UpdateMessageBusOperationsClient);
        }

        /// <summary>
        /// Update a single message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MessageBus, OperationMetadata>> UpdateMessageBusAsync(UpdateMessageBusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMessageBusRequest(ref request, ref callSettings);
            return new lro::Operation<MessageBus, OperationMetadata>(await _callUpdateMessageBus.Async(request, callSettings).ConfigureAwait(false), UpdateMessageBusOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMessageBus</c>.</summary>
        public override lro::OperationsClient DeleteMessageBusOperationsClient { get; }

        /// <summary>
        /// Delete a single message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MessageBus, OperationMetadata> DeleteMessageBus(DeleteMessageBusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMessageBusRequest(ref request, ref callSettings);
            return new lro::Operation<MessageBus, OperationMetadata>(_callDeleteMessageBus.Sync(request, callSettings), DeleteMessageBusOperationsClient);
        }

        /// <summary>
        /// Delete a single message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MessageBus, OperationMetadata>> DeleteMessageBusAsync(DeleteMessageBusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMessageBusRequest(ref request, ref callSettings);
            return new lro::Operation<MessageBus, OperationMetadata>(await _callDeleteMessageBus.Async(request, callSettings).ConfigureAwait(false), DeleteMessageBusOperationsClient);
        }

        /// <summary>
        /// Get a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Enrollment GetEnrollment(GetEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnrollmentRequest(ref request, ref callSettings);
            return _callGetEnrollment.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Enrollment> GetEnrollmentAsync(GetEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnrollmentRequest(ref request, ref callSettings);
            return _callGetEnrollment.Async(request, callSettings);
        }

        /// <summary>
        /// List Enrollments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Enrollment"/> resources.</returns>
        public override gax::PagedEnumerable<ListEnrollmentsResponse, Enrollment> ListEnrollments(ListEnrollmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnrollmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEnrollmentsRequest, ListEnrollmentsResponse, Enrollment>(_callListEnrollments, request, callSettings);
        }

        /// <summary>
        /// List Enrollments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Enrollment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEnrollmentsResponse, Enrollment> ListEnrollmentsAsync(ListEnrollmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnrollmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEnrollmentsRequest, ListEnrollmentsResponse, Enrollment>(_callListEnrollments, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEnrollment</c>.</summary>
        public override lro::OperationsClient CreateEnrollmentOperationsClient { get; }

        /// <summary>
        /// Create a new Enrollment in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Enrollment, OperationMetadata> CreateEnrollment(CreateEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnrollmentRequest(ref request, ref callSettings);
            return new lro::Operation<Enrollment, OperationMetadata>(_callCreateEnrollment.Sync(request, callSettings), CreateEnrollmentOperationsClient);
        }

        /// <summary>
        /// Create a new Enrollment in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Enrollment, OperationMetadata>> CreateEnrollmentAsync(CreateEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnrollmentRequest(ref request, ref callSettings);
            return new lro::Operation<Enrollment, OperationMetadata>(await _callCreateEnrollment.Async(request, callSettings).ConfigureAwait(false), CreateEnrollmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateEnrollment</c>.</summary>
        public override lro::OperationsClient UpdateEnrollmentOperationsClient { get; }

        /// <summary>
        /// Update a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Enrollment, OperationMetadata> UpdateEnrollment(UpdateEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEnrollmentRequest(ref request, ref callSettings);
            return new lro::Operation<Enrollment, OperationMetadata>(_callUpdateEnrollment.Sync(request, callSettings), UpdateEnrollmentOperationsClient);
        }

        /// <summary>
        /// Update a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Enrollment, OperationMetadata>> UpdateEnrollmentAsync(UpdateEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEnrollmentRequest(ref request, ref callSettings);
            return new lro::Operation<Enrollment, OperationMetadata>(await _callUpdateEnrollment.Async(request, callSettings).ConfigureAwait(false), UpdateEnrollmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEnrollment</c>.</summary>
        public override lro::OperationsClient DeleteEnrollmentOperationsClient { get; }

        /// <summary>
        /// Delete a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Enrollment, OperationMetadata> DeleteEnrollment(DeleteEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnrollmentRequest(ref request, ref callSettings);
            return new lro::Operation<Enrollment, OperationMetadata>(_callDeleteEnrollment.Sync(request, callSettings), DeleteEnrollmentOperationsClient);
        }

        /// <summary>
        /// Delete a single Enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Enrollment, OperationMetadata>> DeleteEnrollmentAsync(DeleteEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnrollmentRequest(ref request, ref callSettings);
            return new lro::Operation<Enrollment, OperationMetadata>(await _callDeleteEnrollment.Async(request, callSettings).ConfigureAwait(false), DeleteEnrollmentOperationsClient);
        }

        /// <summary>
        /// Get a single Pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Pipeline GetPipeline(GetPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPipelineRequest(ref request, ref callSettings);
            return _callGetPipeline.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a single Pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Pipeline> GetPipelineAsync(GetPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPipelineRequest(ref request, ref callSettings);
            return _callGetPipeline.Async(request, callSettings);
        }

        /// <summary>
        /// List pipelines.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Pipeline"/> resources.</returns>
        public override gax::PagedEnumerable<ListPipelinesResponse, Pipeline> ListPipelines(ListPipelinesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPipelinesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPipelinesRequest, ListPipelinesResponse, Pipeline>(_callListPipelines, request, callSettings);
        }

        /// <summary>
        /// List pipelines.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Pipeline"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPipelinesResponse, Pipeline> ListPipelinesAsync(ListPipelinesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPipelinesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPipelinesRequest, ListPipelinesResponse, Pipeline>(_callListPipelines, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreatePipeline</c>.</summary>
        public override lro::OperationsClient CreatePipelineOperationsClient { get; }

        /// <summary>
        /// Create a new Pipeline in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Pipeline, OperationMetadata> CreatePipeline(CreatePipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePipelineRequest(ref request, ref callSettings);
            return new lro::Operation<Pipeline, OperationMetadata>(_callCreatePipeline.Sync(request, callSettings), CreatePipelineOperationsClient);
        }

        /// <summary>
        /// Create a new Pipeline in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Pipeline, OperationMetadata>> CreatePipelineAsync(CreatePipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePipelineRequest(ref request, ref callSettings);
            return new lro::Operation<Pipeline, OperationMetadata>(await _callCreatePipeline.Async(request, callSettings).ConfigureAwait(false), CreatePipelineOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdatePipeline</c>.</summary>
        public override lro::OperationsClient UpdatePipelineOperationsClient { get; }

        /// <summary>
        /// Update a single pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Pipeline, OperationMetadata> UpdatePipeline(UpdatePipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePipelineRequest(ref request, ref callSettings);
            return new lro::Operation<Pipeline, OperationMetadata>(_callUpdatePipeline.Sync(request, callSettings), UpdatePipelineOperationsClient);
        }

        /// <summary>
        /// Update a single pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Pipeline, OperationMetadata>> UpdatePipelineAsync(UpdatePipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePipelineRequest(ref request, ref callSettings);
            return new lro::Operation<Pipeline, OperationMetadata>(await _callUpdatePipeline.Async(request, callSettings).ConfigureAwait(false), UpdatePipelineOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeletePipeline</c>.</summary>
        public override lro::OperationsClient DeletePipelineOperationsClient { get; }

        /// <summary>
        /// Delete a single pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Pipeline, OperationMetadata> DeletePipeline(DeletePipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePipelineRequest(ref request, ref callSettings);
            return new lro::Operation<Pipeline, OperationMetadata>(_callDeletePipeline.Sync(request, callSettings), DeletePipelineOperationsClient);
        }

        /// <summary>
        /// Delete a single pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Pipeline, OperationMetadata>> DeletePipelineAsync(DeletePipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePipelineRequest(ref request, ref callSettings);
            return new lro::Operation<Pipeline, OperationMetadata>(await _callDeletePipeline.Async(request, callSettings).ConfigureAwait(false), DeletePipelineOperationsClient);
        }

        /// <summary>
        /// Get a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GoogleApiSource GetGoogleApiSource(GetGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGoogleApiSourceRequest(ref request, ref callSettings);
            return _callGetGoogleApiSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GoogleApiSource> GetGoogleApiSourceAsync(GetGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGoogleApiSourceRequest(ref request, ref callSettings);
            return _callGetGoogleApiSource.Async(request, callSettings);
        }

        /// <summary>
        /// List GoogleApiSources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GoogleApiSource"/> resources.</returns>
        public override gax::PagedEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> ListGoogleApiSources(ListGoogleApiSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGoogleApiSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGoogleApiSourcesRequest, ListGoogleApiSourcesResponse, GoogleApiSource>(_callListGoogleApiSources, request, callSettings);
        }

        /// <summary>
        /// List GoogleApiSources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GoogleApiSource"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> ListGoogleApiSourcesAsync(ListGoogleApiSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGoogleApiSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGoogleApiSourcesRequest, ListGoogleApiSourcesResponse, GoogleApiSource>(_callListGoogleApiSources, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateGoogleApiSource</c>.</summary>
        public override lro::OperationsClient CreateGoogleApiSourceOperationsClient { get; }

        /// <summary>
        /// Create a new GoogleApiSource in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GoogleApiSource, OperationMetadata> CreateGoogleApiSource(CreateGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGoogleApiSourceRequest(ref request, ref callSettings);
            return new lro::Operation<GoogleApiSource, OperationMetadata>(_callCreateGoogleApiSource.Sync(request, callSettings), CreateGoogleApiSourceOperationsClient);
        }

        /// <summary>
        /// Create a new GoogleApiSource in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> CreateGoogleApiSourceAsync(CreateGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGoogleApiSourceRequest(ref request, ref callSettings);
            return new lro::Operation<GoogleApiSource, OperationMetadata>(await _callCreateGoogleApiSource.Async(request, callSettings).ConfigureAwait(false), CreateGoogleApiSourceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateGoogleApiSource</c>.</summary>
        public override lro::OperationsClient UpdateGoogleApiSourceOperationsClient { get; }

        /// <summary>
        /// Update a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GoogleApiSource, OperationMetadata> UpdateGoogleApiSource(UpdateGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGoogleApiSourceRequest(ref request, ref callSettings);
            return new lro::Operation<GoogleApiSource, OperationMetadata>(_callUpdateGoogleApiSource.Sync(request, callSettings), UpdateGoogleApiSourceOperationsClient);
        }

        /// <summary>
        /// Update a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> UpdateGoogleApiSourceAsync(UpdateGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGoogleApiSourceRequest(ref request, ref callSettings);
            return new lro::Operation<GoogleApiSource, OperationMetadata>(await _callUpdateGoogleApiSource.Async(request, callSettings).ConfigureAwait(false), UpdateGoogleApiSourceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteGoogleApiSource</c>.</summary>
        public override lro::OperationsClient DeleteGoogleApiSourceOperationsClient { get; }

        /// <summary>
        /// Delete a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GoogleApiSource, OperationMetadata> DeleteGoogleApiSource(DeleteGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGoogleApiSourceRequest(ref request, ref callSettings);
            return new lro::Operation<GoogleApiSource, OperationMetadata>(_callDeleteGoogleApiSource.Sync(request, callSettings), DeleteGoogleApiSourceOperationsClient);
        }

        /// <summary>
        /// Delete a single GoogleApiSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GoogleApiSource, OperationMetadata>> DeleteGoogleApiSourceAsync(DeleteGoogleApiSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGoogleApiSourceRequest(ref request, ref callSettings);
            return new lro::Operation<GoogleApiSource, OperationMetadata>(await _callDeleteGoogleApiSource.Async(request, callSettings).ConfigureAwait(false), DeleteGoogleApiSourceOperationsClient);
        }
    }

    public partial class ListTriggersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListChannelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProvidersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListChannelConnectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMessageBusesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMessageBusEnrollmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEnrollmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPipelinesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGoogleApiSourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTriggersResponse : gaxgrpc::IPageResponse<Trigger>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Trigger> GetEnumerator() => Triggers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListChannelsResponse : gaxgrpc::IPageResponse<Channel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Channel> GetEnumerator() => Channels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProvidersResponse : gaxgrpc::IPageResponse<Provider>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Provider> GetEnumerator() => Providers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListChannelConnectionsResponse : gaxgrpc::IPageResponse<ChannelConnection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ChannelConnection> GetEnumerator() => ChannelConnections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMessageBusesResponse : gaxgrpc::IPageResponse<MessageBus>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MessageBus> GetEnumerator() => MessageBuses.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMessageBusEnrollmentsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => Enrollments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEnrollmentsResponse : gaxgrpc::IPageResponse<Enrollment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Enrollment> GetEnumerator() => Enrollments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPipelinesResponse : gaxgrpc::IPageResponse<Pipeline>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Pipeline> GetEnumerator() => Pipelines.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGoogleApiSourcesResponse : gaxgrpc::IPageResponse<GoogleApiSource>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GoogleApiSource> GetEnumerator() => GoogleApiSources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Eventarc
    {
        public partial class EventarcClient
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

    public static partial class Eventarc
    {
        public partial class EventarcClient
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
