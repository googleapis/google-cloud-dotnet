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

namespace Google.Cloud.ApiGateway.V1
{
    /// <summary>Settings for <see cref="ApiGatewayServiceClient"/> instances.</summary>
    public sealed partial class ApiGatewayServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ApiGatewayServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ApiGatewayServiceSettings"/>.</returns>
        public static ApiGatewayServiceSettings GetDefault() => new ApiGatewayServiceSettings();

        /// <summary>Constructs a new <see cref="ApiGatewayServiceSettings"/> object with default settings.</summary>
        public ApiGatewayServiceSettings()
        {
        }

        private ApiGatewayServiceSettings(ApiGatewayServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListGatewaysSettings = existing.ListGatewaysSettings;
            GetGatewaySettings = existing.GetGatewaySettings;
            CreateGatewaySettings = existing.CreateGatewaySettings;
            CreateGatewayOperationsSettings = existing.CreateGatewayOperationsSettings.Clone();
            UpdateGatewaySettings = existing.UpdateGatewaySettings;
            UpdateGatewayOperationsSettings = existing.UpdateGatewayOperationsSettings.Clone();
            DeleteGatewaySettings = existing.DeleteGatewaySettings;
            DeleteGatewayOperationsSettings = existing.DeleteGatewayOperationsSettings.Clone();
            ListApisSettings = existing.ListApisSettings;
            GetApiSettings = existing.GetApiSettings;
            CreateApiSettings = existing.CreateApiSettings;
            CreateApiOperationsSettings = existing.CreateApiOperationsSettings.Clone();
            UpdateApiSettings = existing.UpdateApiSettings;
            UpdateApiOperationsSettings = existing.UpdateApiOperationsSettings.Clone();
            DeleteApiSettings = existing.DeleteApiSettings;
            DeleteApiOperationsSettings = existing.DeleteApiOperationsSettings.Clone();
            ListApiConfigsSettings = existing.ListApiConfigsSettings;
            GetApiConfigSettings = existing.GetApiConfigSettings;
            CreateApiConfigSettings = existing.CreateApiConfigSettings;
            CreateApiConfigOperationsSettings = existing.CreateApiConfigOperationsSettings.Clone();
            UpdateApiConfigSettings = existing.UpdateApiConfigSettings;
            UpdateApiConfigOperationsSettings = existing.UpdateApiConfigOperationsSettings.Clone();
            DeleteApiConfigSettings = existing.DeleteApiConfigSettings;
            DeleteApiConfigOperationsSettings = existing.DeleteApiConfigOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ApiGatewayServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.ListGateways</c> and <c>ApiGatewayServiceClient.ListGatewaysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGatewaysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.GetGateway</c> and <c>ApiGatewayServiceClient.GetGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGatewaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.CreateGateway</c> and <c>ApiGatewayServiceClient.CreateGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGatewaySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiGatewayServiceClient.CreateGateway</c> and
        /// <c>ApiGatewayServiceClient.CreateGatewayAsync</c>.
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
        public lro::OperationsSettings CreateGatewayOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.UpdateGateway</c> and <c>ApiGatewayServiceClient.UpdateGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGatewaySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiGatewayServiceClient.UpdateGateway</c> and
        /// <c>ApiGatewayServiceClient.UpdateGatewayAsync</c>.
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
        public lro::OperationsSettings UpdateGatewayOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.DeleteGateway</c> and <c>ApiGatewayServiceClient.DeleteGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGatewaySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiGatewayServiceClient.DeleteGateway</c> and
        /// <c>ApiGatewayServiceClient.DeleteGatewayAsync</c>.
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
        public lro::OperationsSettings DeleteGatewayOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.ListApis</c> and <c>ApiGatewayServiceClient.ListApisAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListApisSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.GetApi</c> and <c>ApiGatewayServiceClient.GetApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetApiSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.CreateApi</c> and <c>ApiGatewayServiceClient.CreateApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApiSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiGatewayServiceClient.CreateApi</c> and
        /// <c>ApiGatewayServiceClient.CreateApiAsync</c>.
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
        public lro::OperationsSettings CreateApiOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.UpdateApi</c> and <c>ApiGatewayServiceClient.UpdateApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApiSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiGatewayServiceClient.UpdateApi</c> and
        /// <c>ApiGatewayServiceClient.UpdateApiAsync</c>.
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
        public lro::OperationsSettings UpdateApiOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.DeleteApi</c> and <c>ApiGatewayServiceClient.DeleteApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApiSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiGatewayServiceClient.DeleteApi</c> and
        /// <c>ApiGatewayServiceClient.DeleteApiAsync</c>.
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
        public lro::OperationsSettings DeleteApiOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.ListApiConfigs</c> and <c>ApiGatewayServiceClient.ListApiConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListApiConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.GetApiConfig</c> and <c>ApiGatewayServiceClient.GetApiConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetApiConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.CreateApiConfig</c> and <c>ApiGatewayServiceClient.CreateApiConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApiConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiGatewayServiceClient.CreateApiConfig</c> and
        /// <c>ApiGatewayServiceClient.CreateApiConfigAsync</c>.
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
        public lro::OperationsSettings CreateApiConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.UpdateApiConfig</c> and <c>ApiGatewayServiceClient.UpdateApiConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApiConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiGatewayServiceClient.UpdateApiConfig</c> and
        /// <c>ApiGatewayServiceClient.UpdateApiConfigAsync</c>.
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
        public lro::OperationsSettings UpdateApiConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiGatewayServiceClient.DeleteApiConfig</c> and <c>ApiGatewayServiceClient.DeleteApiConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApiConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiGatewayServiceClient.DeleteApiConfig</c> and
        /// <c>ApiGatewayServiceClient.DeleteApiConfigAsync</c>.
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
        public lro::OperationsSettings DeleteApiConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ApiGatewayServiceSettings"/> object.</returns>
        public ApiGatewayServiceSettings Clone() => new ApiGatewayServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ApiGatewayServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ApiGatewayServiceClientBuilder : gaxgrpc::ClientBuilderBase<ApiGatewayServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ApiGatewayServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ApiGatewayServiceClientBuilder() : base(ApiGatewayServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ApiGatewayServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ApiGatewayServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ApiGatewayServiceClient Build()
        {
            ApiGatewayServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ApiGatewayServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ApiGatewayServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ApiGatewayServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ApiGatewayServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ApiGatewayServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ApiGatewayServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ApiGatewayServiceClient.ChannelPool;
    }

    /// <summary>ApiGatewayService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The API Gateway Service is the interface for managing API Gateways.
    /// </remarks>
    public abstract partial class ApiGatewayServiceClient
    {
        /// <summary>
        /// The default endpoint for the ApiGatewayService service, which is a host of "apigateway.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apigateway.googleapis.com:443";

        /// <summary>The default ApiGatewayService scopes.</summary>
        /// <remarks>
        /// The default ApiGatewayService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ApiGatewayService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ApiGatewayServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApiGatewayServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ApiGatewayServiceClient"/>.</returns>
        public static stt::Task<ApiGatewayServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ApiGatewayServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ApiGatewayServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApiGatewayServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ApiGatewayServiceClient"/>.</returns>
        public static ApiGatewayServiceClient Create() => new ApiGatewayServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ApiGatewayServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ApiGatewayServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ApiGatewayServiceClient"/>.</returns>
        internal static ApiGatewayServiceClient Create(grpccore::CallInvoker callInvoker, ApiGatewayServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ApiGatewayService.ApiGatewayServiceClient grpcClient = new ApiGatewayService.ApiGatewayServiceClient(callInvoker);
            return new ApiGatewayServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ApiGatewayService client</summary>
        public virtual ApiGatewayService.ApiGatewayServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Gateway"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewaysResponse, Gateway> ListGateways(ListGatewaysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Gateway"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewaysResponse, Gateway> ListGatewaysAsync(ListGatewaysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Gateway, of the form:
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
        /// <returns>A pageable sequence of <see cref="Gateway"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewaysResponse, Gateway> ListGateways(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaysRequest request = new ListGatewaysRequest
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
            return ListGateways(request, callSettings);
        }

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Gateway, of the form:
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
        /// <returns>A pageable asynchronous sequence of <see cref="Gateway"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewaysResponse, Gateway> ListGatewaysAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaysRequest request = new ListGatewaysRequest
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
            return ListGatewaysAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Gateway, of the form:
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
        /// <returns>A pageable sequence of <see cref="Gateway"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGatewaysResponse, Gateway> ListGateways(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaysRequest request = new ListGatewaysRequest
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
            return ListGateways(request, callSettings);
        }

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Gateway, of the form:
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
        /// <returns>A pageable asynchronous sequence of <see cref="Gateway"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGatewaysResponse, Gateway> ListGatewaysAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGatewaysRequest request = new ListGatewaysRequest
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
            return ListGatewaysAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Gateway GetGateway(GetGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Gateway> GetGatewayAsync(GetGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Gateway> GetGatewayAsync(GetGatewayRequest request, st::CancellationToken cancellationToken) =>
            GetGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/gateways/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Gateway GetGateway(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGateway(new GetGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/gateways/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Gateway> GetGatewayAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewayAsync(new GetGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/gateways/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Gateway> GetGatewayAsync(string name, st::CancellationToken cancellationToken) =>
            GetGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/gateways/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Gateway GetGateway(GatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGateway(new GetGatewayRequest
            {
                GatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/gateways/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Gateway> GetGatewayAsync(GatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGatewayAsync(new GetGatewayRequest
            {
                GatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/gateways/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Gateway> GetGatewayAsync(GatewayName name, st::CancellationToken cancellationToken) =>
            GetGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> CreateGateway(CreateGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(CreateGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(CreateGatewayRequest request, st::CancellationToken cancellationToken) =>
            CreateGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGateway</c>.</summary>
        public virtual lro::OperationsClient CreateGatewayOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> PollOnceCreateGateway(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Gateway, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGatewayOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> PollOnceCreateGatewayAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Gateway, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGatewayOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Gateway, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="gateway">
        /// Required. Gateway resource.
        /// </param>
        /// <param name="gatewayId">
        /// Required. Identifier to assign to the Gateway. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> CreateGateway(string parent, Gateway gateway, string gatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGateway(new CreateGatewayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                Gateway = gax::GaxPreconditions.CheckNotNull(gateway, nameof(gateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Gateway, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="gateway">
        /// Required. Gateway resource.
        /// </param>
        /// <param name="gatewayId">
        /// Required. Identifier to assign to the Gateway. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(string parent, Gateway gateway, string gatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGatewayAsync(new CreateGatewayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                Gateway = gax::GaxPreconditions.CheckNotNull(gateway, nameof(gateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Gateway, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="gateway">
        /// Required. Gateway resource.
        /// </param>
        /// <param name="gatewayId">
        /// Required. Identifier to assign to the Gateway. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(string parent, Gateway gateway, string gatewayId, st::CancellationToken cancellationToken) =>
            CreateGatewayAsync(parent, gateway, gatewayId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Gateway, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="gateway">
        /// Required. Gateway resource.
        /// </param>
        /// <param name="gatewayId">
        /// Required. Identifier to assign to the Gateway. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> CreateGateway(gagr::LocationName parent, Gateway gateway, string gatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGateway(new CreateGatewayRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                Gateway = gax::GaxPreconditions.CheckNotNull(gateway, nameof(gateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Gateway, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="gateway">
        /// Required. Gateway resource.
        /// </param>
        /// <param name="gatewayId">
        /// Required. Identifier to assign to the Gateway. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(gagr::LocationName parent, Gateway gateway, string gatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGatewayAsync(new CreateGatewayRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GatewayId = gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)),
                Gateway = gax::GaxPreconditions.CheckNotNull(gateway, nameof(gateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the Gateway, of the form:
        /// `projects/*/locations/*`
        /// </param>
        /// <param name="gateway">
        /// Required. Gateway resource.
        /// </param>
        /// <param name="gatewayId">
        /// Required. Identifier to assign to the Gateway. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(gagr::LocationName parent, Gateway gateway, string gatewayId, st::CancellationToken cancellationToken) =>
            CreateGatewayAsync(parent, gateway, gatewayId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> UpdateGateway(UpdateGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> UpdateGatewayAsync(UpdateGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> UpdateGatewayAsync(UpdateGatewayRequest request, st::CancellationToken cancellationToken) =>
            UpdateGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateGateway</c>.</summary>
        public virtual lro::OperationsClient UpdateGatewayOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> PollOnceUpdateGateway(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Gateway, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGatewayOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> PollOnceUpdateGatewayAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Gateway, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGatewayOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="gateway">
        /// Required. Gateway resource.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Gateway resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Gateway, OperationMetadata> UpdateGateway(Gateway gateway, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGateway(new UpdateGatewayRequest
            {
                UpdateMask = updateMask,
                Gateway = gax::GaxPreconditions.CheckNotNull(gateway, nameof(gateway)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="gateway">
        /// Required. Gateway resource.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Gateway resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> UpdateGatewayAsync(Gateway gateway, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGatewayAsync(new UpdateGatewayRequest
            {
                UpdateMask = updateMask,
                Gateway = gax::GaxPreconditions.CheckNotNull(gateway, nameof(gateway)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="gateway">
        /// Required. Gateway resource.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Gateway resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Gateway, OperationMetadata>> UpdateGatewayAsync(Gateway gateway, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGatewayAsync(gateway, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGateway(DeleteGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(DeleteGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(DeleteGatewayRequest request, st::CancellationToken cancellationToken) =>
            DeleteGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGateway</c>.</summary>
        public virtual lro::OperationsClient DeleteGatewayOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteGateway(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGatewayOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteGatewayAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGatewayOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/gateways/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGateway(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGateway(new DeleteGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/gateways/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGatewayAsync(new DeleteGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/gateways/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/gateways/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGateway(GatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGateway(new DeleteGatewayRequest
            {
                GatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/gateways/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(GatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGatewayAsync(new DeleteGatewayRequest
            {
                GatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/*/gateways/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(GatewayName name, st::CancellationToken cancellationToken) =>
            DeleteGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Apis in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApisResponse, Api> ListApis(ListApisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Apis in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApisResponse, Api> ListApisAsync(ListApisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Apis in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/global`
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
        /// <returns>A pageable sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApisResponse, Api> ListApis(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApisRequest request = new ListApisRequest
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
            return ListApis(request, callSettings);
        }

        /// <summary>
        /// Lists Apis in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/global`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApisResponse, Api> ListApisAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApisRequest request = new ListApisRequest
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
            return ListApisAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Apis in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/global`
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
        /// <returns>A pageable sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApisResponse, Api> ListApis(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApisRequest request = new ListApisRequest
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
            return ListApis(request, callSettings);
        }

        /// <summary>
        /// Lists Apis in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/global`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApisResponse, Api> ListApisAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApisRequest request = new ListApisRequest
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
            return ListApisAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api GetApi(GetApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(GetApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(GetApiRequest request, st::CancellationToken cancellationToken) =>
            GetApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Api.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api GetApi(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApi(new GetApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Api.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiAsync(new GetApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Api.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(string name, st::CancellationToken cancellationToken) =>
            GetApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Api.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api GetApi(ApiName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApi(new GetApiRequest
            {
                ApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Api.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(ApiName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiAsync(new GetApiRequest
            {
                ApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Api.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(ApiName name, st::CancellationToken cancellationToken) =>
            GetApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Api in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Api, OperationMetadata> CreateApi(CreateApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Api in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Api, OperationMetadata>> CreateApiAsync(CreateApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Api in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Api, OperationMetadata>> CreateApiAsync(CreateApiRequest request, st::CancellationToken cancellationToken) =>
            CreateApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateApi</c>.</summary>
        public virtual lro::OperationsClient CreateApiOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateApi</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Api, OperationMetadata> PollOnceCreateApi(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Api, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApiOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateApi</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Api, OperationMetadata>> PollOnceCreateApiAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Api, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApiOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Api in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/global`
        /// </param>
        /// <param name="api">
        /// Required. API resource.
        /// </param>
        /// <param name="apiId">
        /// Required. Identifier to assign to the API. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Api, OperationMetadata> CreateApi(string parent, Api api, string apiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApi(new CreateApiRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)),
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
            }, callSettings);

        /// <summary>
        /// Creates a new Api in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/global`
        /// </param>
        /// <param name="api">
        /// Required. API resource.
        /// </param>
        /// <param name="apiId">
        /// Required. Identifier to assign to the API. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Api, OperationMetadata>> CreateApiAsync(string parent, Api api, string apiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiAsync(new CreateApiRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)),
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
            }, callSettings);

        /// <summary>
        /// Creates a new Api in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/global`
        /// </param>
        /// <param name="api">
        /// Required. API resource.
        /// </param>
        /// <param name="apiId">
        /// Required. Identifier to assign to the API. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Api, OperationMetadata>> CreateApiAsync(string parent, Api api, string apiId, st::CancellationToken cancellationToken) =>
            CreateApiAsync(parent, api, apiId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Api in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/global`
        /// </param>
        /// <param name="api">
        /// Required. API resource.
        /// </param>
        /// <param name="apiId">
        /// Required. Identifier to assign to the API. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Api, OperationMetadata> CreateApi(gagr::LocationName parent, Api api, string apiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApi(new CreateApiRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)),
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
            }, callSettings);

        /// <summary>
        /// Creates a new Api in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/global`
        /// </param>
        /// <param name="api">
        /// Required. API resource.
        /// </param>
        /// <param name="apiId">
        /// Required. Identifier to assign to the API. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Api, OperationMetadata>> CreateApiAsync(gagr::LocationName parent, Api api, string apiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiAsync(new CreateApiRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)),
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
            }, callSettings);

        /// <summary>
        /// Creates a new Api in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API, of the form:
        /// `projects/*/locations/global`
        /// </param>
        /// <param name="api">
        /// Required. API resource.
        /// </param>
        /// <param name="apiId">
        /// Required. Identifier to assign to the API. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Api, OperationMetadata>> CreateApiAsync(gagr::LocationName parent, Api api, string apiId, st::CancellationToken cancellationToken) =>
            CreateApiAsync(parent, api, apiId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Api, OperationMetadata> UpdateApi(UpdateApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Api, OperationMetadata>> UpdateApiAsync(UpdateApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Api, OperationMetadata>> UpdateApiAsync(UpdateApiRequest request, st::CancellationToken cancellationToken) =>
            UpdateApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateApi</c>.</summary>
        public virtual lro::OperationsClient UpdateApiOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateApi</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Api, OperationMetadata> PollOnceUpdateApi(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Api, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApiOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateApi</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Api, OperationMetadata>> PollOnceUpdateApiAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Api, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApiOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Api.
        /// </summary>
        /// <param name="api">
        /// Required. API resource.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Api resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Api, OperationMetadata> UpdateApi(Api api, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApi(new UpdateApiRequest
            {
                UpdateMask = updateMask,
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Api.
        /// </summary>
        /// <param name="api">
        /// Required. API resource.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Api resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Api, OperationMetadata>> UpdateApiAsync(Api api, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApiAsync(new UpdateApiRequest
            {
                UpdateMask = updateMask,
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Api.
        /// </summary>
        /// <param name="api">
        /// Required. API resource.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Api resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Api, OperationMetadata>> UpdateApiAsync(Api api, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateApiAsync(api, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApi(DeleteApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiAsync(DeleteApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiAsync(DeleteApiRequest request, st::CancellationToken cancellationToken) =>
            DeleteApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteApi</c>.</summary>
        public virtual lro::OperationsClient DeleteApiOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteApi</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteApi(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteApiOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteApi</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteApiAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteApiOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Api.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApi(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApi(new DeleteApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Api.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiAsync(new DeleteApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Api.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Api.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApi(ApiName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApi(new DeleteApiRequest
            {
                ApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Api.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiAsync(ApiName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiAsync(new DeleteApiRequest
            {
                ApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Api.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiAsync(ApiName name, st::CancellationToken cancellationToken) =>
            DeleteApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ApiConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiConfigsResponse, ApiConfig> ListApiConfigs(ListApiConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ApiConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiConfigsResponse, ApiConfig> ListApiConfigsAsync(ListApiConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ApiConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API Config, of the form:
        /// `projects/*/locations/global/apis/*`
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
        /// <returns>A pageable sequence of <see cref="ApiConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiConfigsResponse, ApiConfig> ListApiConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiConfigsRequest request = new ListApiConfigsRequest
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
            return ListApiConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists ApiConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API Config, of the form:
        /// `projects/*/locations/global/apis/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApiConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiConfigsResponse, ApiConfig> ListApiConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiConfigsRequest request = new ListApiConfigsRequest
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
            return ListApiConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ApiConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API Config, of the form:
        /// `projects/*/locations/global/apis/*`
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
        /// <returns>A pageable sequence of <see cref="ApiConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiConfigsResponse, ApiConfig> ListApiConfigs(ApiName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiConfigsRequest request = new ListApiConfigsRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApiConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists ApiConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API Config, of the form:
        /// `projects/*/locations/global/apis/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApiConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiConfigsResponse, ApiConfig> ListApiConfigsAsync(ApiName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiConfigsRequest request = new ListApiConfigsRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApiConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiConfig GetApiConfig(GetApiConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiConfig> GetApiConfigAsync(GetApiConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiConfig> GetApiConfigAsync(GetApiConfigRequest request, st::CancellationToken cancellationToken) =>
            GetApiConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ApiConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*/configs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiConfig GetApiConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiConfig(new GetApiConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ApiConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*/configs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiConfig> GetApiConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiConfigAsync(new GetApiConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ApiConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*/configs/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiConfig> GetApiConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetApiConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ApiConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*/configs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiConfig GetApiConfig(ApiConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiConfig(new GetApiConfigRequest
            {
                ApiConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ApiConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*/configs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiConfig> GetApiConfigAsync(ApiConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiConfigAsync(new GetApiConfigRequest
            {
                ApiConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ApiConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*/configs/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiConfig> GetApiConfigAsync(ApiConfigName name, st::CancellationToken cancellationToken) =>
            GetApiConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ApiConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ApiConfig, OperationMetadata> CreateApiConfig(CreateApiConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ApiConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiConfig, OperationMetadata>> CreateApiConfigAsync(CreateApiConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ApiConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiConfig, OperationMetadata>> CreateApiConfigAsync(CreateApiConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateApiConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateApiConfig</c>.</summary>
        public virtual lro::OperationsClient CreateApiConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateApiConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ApiConfig, OperationMetadata> PollOnceCreateApiConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ApiConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApiConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateApiConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ApiConfig, OperationMetadata>> PollOnceCreateApiConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ApiConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApiConfigOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ApiConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API Config, of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="apiConfig">
        /// Required. API resource.
        /// </param>
        /// <param name="apiConfigId">
        /// Required. Identifier to assign to the API Config. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ApiConfig, OperationMetadata> CreateApiConfig(string parent, ApiConfig apiConfig, string apiConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiConfig(new CreateApiConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiConfigId, nameof(apiConfigId)),
                ApiConfig = gax::GaxPreconditions.CheckNotNull(apiConfig, nameof(apiConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ApiConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API Config, of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="apiConfig">
        /// Required. API resource.
        /// </param>
        /// <param name="apiConfigId">
        /// Required. Identifier to assign to the API Config. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiConfig, OperationMetadata>> CreateApiConfigAsync(string parent, ApiConfig apiConfig, string apiConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiConfigAsync(new CreateApiConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiConfigId, nameof(apiConfigId)),
                ApiConfig = gax::GaxPreconditions.CheckNotNull(apiConfig, nameof(apiConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ApiConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API Config, of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="apiConfig">
        /// Required. API resource.
        /// </param>
        /// <param name="apiConfigId">
        /// Required. Identifier to assign to the API Config. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiConfig, OperationMetadata>> CreateApiConfigAsync(string parent, ApiConfig apiConfig, string apiConfigId, st::CancellationToken cancellationToken) =>
            CreateApiConfigAsync(parent, apiConfig, apiConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ApiConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API Config, of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="apiConfig">
        /// Required. API resource.
        /// </param>
        /// <param name="apiConfigId">
        /// Required. Identifier to assign to the API Config. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ApiConfig, OperationMetadata> CreateApiConfig(ApiName parent, ApiConfig apiConfig, string apiConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiConfig(new CreateApiConfigRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiConfigId, nameof(apiConfigId)),
                ApiConfig = gax::GaxPreconditions.CheckNotNull(apiConfig, nameof(apiConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ApiConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API Config, of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="apiConfig">
        /// Required. API resource.
        /// </param>
        /// <param name="apiConfigId">
        /// Required. Identifier to assign to the API Config. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiConfig, OperationMetadata>> CreateApiConfigAsync(ApiName parent, ApiConfig apiConfig, string apiConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiConfigAsync(new CreateApiConfigRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiConfigId, nameof(apiConfigId)),
                ApiConfig = gax::GaxPreconditions.CheckNotNull(apiConfig, nameof(apiConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ApiConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource of the API Config, of the form:
        /// `projects/*/locations/global/apis/*`
        /// </param>
        /// <param name="apiConfig">
        /// Required. API resource.
        /// </param>
        /// <param name="apiConfigId">
        /// Required. Identifier to assign to the API Config. Must be unique within scope of
        /// the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiConfig, OperationMetadata>> CreateApiConfigAsync(ApiName parent, ApiConfig apiConfig, string apiConfigId, st::CancellationToken cancellationToken) =>
            CreateApiConfigAsync(parent, apiConfig, apiConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ApiConfig, OperationMetadata> UpdateApiConfig(UpdateApiConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiConfig, OperationMetadata>> UpdateApiConfigAsync(UpdateApiConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiConfig, OperationMetadata>> UpdateApiConfigAsync(UpdateApiConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateApiConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateApiConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateApiConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateApiConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ApiConfig, OperationMetadata> PollOnceUpdateApiConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ApiConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApiConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateApiConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ApiConfig, OperationMetadata>> PollOnceUpdateApiConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ApiConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApiConfigOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single ApiConfig.
        /// </summary>
        /// <param name="apiConfig">
        /// Required. API Config resource.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// ApiConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ApiConfig, OperationMetadata> UpdateApiConfig(ApiConfig apiConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApiConfig(new UpdateApiConfigRequest
            {
                UpdateMask = updateMask,
                ApiConfig = gax::GaxPreconditions.CheckNotNull(apiConfig, nameof(apiConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ApiConfig.
        /// </summary>
        /// <param name="apiConfig">
        /// Required. API Config resource.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// ApiConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiConfig, OperationMetadata>> UpdateApiConfigAsync(ApiConfig apiConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApiConfigAsync(new UpdateApiConfigRequest
            {
                UpdateMask = updateMask,
                ApiConfig = gax::GaxPreconditions.CheckNotNull(apiConfig, nameof(apiConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ApiConfig.
        /// </summary>
        /// <param name="apiConfig">
        /// Required. API Config resource.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// ApiConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiConfig, OperationMetadata>> UpdateApiConfigAsync(ApiConfig apiConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateApiConfigAsync(apiConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApiConfig(DeleteApiConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiConfigAsync(DeleteApiConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiConfigAsync(DeleteApiConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteApiConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteApiConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteApiConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteApiConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteApiConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteApiConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteApiConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteApiConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteApiConfigOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ApiConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*/configs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApiConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiConfig(new DeleteApiConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ApiConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*/configs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiConfigAsync(new DeleteApiConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ApiConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*/configs/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApiConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ApiConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*/configs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApiConfig(ApiConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiConfig(new DeleteApiConfigRequest
            {
                ApiConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ApiConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*/configs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiConfigAsync(ApiConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiConfigAsync(new DeleteApiConfigRequest
            {
                ApiConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ApiConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the form:
        /// `projects/*/locations/global/apis/*/configs/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiConfigAsync(ApiConfigName name, st::CancellationToken cancellationToken) =>
            DeleteApiConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ApiGatewayService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The API Gateway Service is the interface for managing API Gateways.
    /// </remarks>
    public sealed partial class ApiGatewayServiceClientImpl : ApiGatewayServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListGatewaysRequest, ListGatewaysResponse> _callListGateways;

        private readonly gaxgrpc::ApiCall<GetGatewayRequest, Gateway> _callGetGateway;

        private readonly gaxgrpc::ApiCall<CreateGatewayRequest, lro::Operation> _callCreateGateway;

        private readonly gaxgrpc::ApiCall<UpdateGatewayRequest, lro::Operation> _callUpdateGateway;

        private readonly gaxgrpc::ApiCall<DeleteGatewayRequest, lro::Operation> _callDeleteGateway;

        private readonly gaxgrpc::ApiCall<ListApisRequest, ListApisResponse> _callListApis;

        private readonly gaxgrpc::ApiCall<GetApiRequest, Api> _callGetApi;

        private readonly gaxgrpc::ApiCall<CreateApiRequest, lro::Operation> _callCreateApi;

        private readonly gaxgrpc::ApiCall<UpdateApiRequest, lro::Operation> _callUpdateApi;

        private readonly gaxgrpc::ApiCall<DeleteApiRequest, lro::Operation> _callDeleteApi;

        private readonly gaxgrpc::ApiCall<ListApiConfigsRequest, ListApiConfigsResponse> _callListApiConfigs;

        private readonly gaxgrpc::ApiCall<GetApiConfigRequest, ApiConfig> _callGetApiConfig;

        private readonly gaxgrpc::ApiCall<CreateApiConfigRequest, lro::Operation> _callCreateApiConfig;

        private readonly gaxgrpc::ApiCall<UpdateApiConfigRequest, lro::Operation> _callUpdateApiConfig;

        private readonly gaxgrpc::ApiCall<DeleteApiConfigRequest, lro::Operation> _callDeleteApiConfig;

        /// <summary>
        /// Constructs a client wrapper for the ApiGatewayService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ApiGatewayServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ApiGatewayServiceClientImpl(ApiGatewayService.ApiGatewayServiceClient grpcClient, ApiGatewayServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ApiGatewayServiceSettings effectiveSettings = settings ?? ApiGatewayServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateGatewayOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGatewayOperationsSettings, logger);
            UpdateGatewayOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGatewayOperationsSettings, logger);
            DeleteGatewayOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGatewayOperationsSettings, logger);
            CreateApiOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateApiOperationsSettings, logger);
            UpdateApiOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateApiOperationsSettings, logger);
            DeleteApiOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteApiOperationsSettings, logger);
            CreateApiConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateApiConfigOperationsSettings, logger);
            UpdateApiConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateApiConfigOperationsSettings, logger);
            DeleteApiConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteApiConfigOperationsSettings, logger);
            _callListGateways = clientHelper.BuildApiCall<ListGatewaysRequest, ListGatewaysResponse>("ListGateways", grpcClient.ListGatewaysAsync, grpcClient.ListGateways, effectiveSettings.ListGatewaysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGateways);
            Modify_ListGatewaysApiCall(ref _callListGateways);
            _callGetGateway = clientHelper.BuildApiCall<GetGatewayRequest, Gateway>("GetGateway", grpcClient.GetGatewayAsync, grpcClient.GetGateway, effectiveSettings.GetGatewaySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGateway);
            Modify_GetGatewayApiCall(ref _callGetGateway);
            _callCreateGateway = clientHelper.BuildApiCall<CreateGatewayRequest, lro::Operation>("CreateGateway", grpcClient.CreateGatewayAsync, grpcClient.CreateGateway, effectiveSettings.CreateGatewaySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGateway);
            Modify_CreateGatewayApiCall(ref _callCreateGateway);
            _callUpdateGateway = clientHelper.BuildApiCall<UpdateGatewayRequest, lro::Operation>("UpdateGateway", grpcClient.UpdateGatewayAsync, grpcClient.UpdateGateway, effectiveSettings.UpdateGatewaySettings).WithGoogleRequestParam("gateway.name", request => request.Gateway?.Name);
            Modify_ApiCall(ref _callUpdateGateway);
            Modify_UpdateGatewayApiCall(ref _callUpdateGateway);
            _callDeleteGateway = clientHelper.BuildApiCall<DeleteGatewayRequest, lro::Operation>("DeleteGateway", grpcClient.DeleteGatewayAsync, grpcClient.DeleteGateway, effectiveSettings.DeleteGatewaySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGateway);
            Modify_DeleteGatewayApiCall(ref _callDeleteGateway);
            _callListApis = clientHelper.BuildApiCall<ListApisRequest, ListApisResponse>("ListApis", grpcClient.ListApisAsync, grpcClient.ListApis, effectiveSettings.ListApisSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApis);
            Modify_ListApisApiCall(ref _callListApis);
            _callGetApi = clientHelper.BuildApiCall<GetApiRequest, Api>("GetApi", grpcClient.GetApiAsync, grpcClient.GetApi, effectiveSettings.GetApiSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApi);
            Modify_GetApiApiCall(ref _callGetApi);
            _callCreateApi = clientHelper.BuildApiCall<CreateApiRequest, lro::Operation>("CreateApi", grpcClient.CreateApiAsync, grpcClient.CreateApi, effectiveSettings.CreateApiSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApi);
            Modify_CreateApiApiCall(ref _callCreateApi);
            _callUpdateApi = clientHelper.BuildApiCall<UpdateApiRequest, lro::Operation>("UpdateApi", grpcClient.UpdateApiAsync, grpcClient.UpdateApi, effectiveSettings.UpdateApiSettings).WithGoogleRequestParam("api.name", request => request.Api?.Name);
            Modify_ApiCall(ref _callUpdateApi);
            Modify_UpdateApiApiCall(ref _callUpdateApi);
            _callDeleteApi = clientHelper.BuildApiCall<DeleteApiRequest, lro::Operation>("DeleteApi", grpcClient.DeleteApiAsync, grpcClient.DeleteApi, effectiveSettings.DeleteApiSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApi);
            Modify_DeleteApiApiCall(ref _callDeleteApi);
            _callListApiConfigs = clientHelper.BuildApiCall<ListApiConfigsRequest, ListApiConfigsResponse>("ListApiConfigs", grpcClient.ListApiConfigsAsync, grpcClient.ListApiConfigs, effectiveSettings.ListApiConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApiConfigs);
            Modify_ListApiConfigsApiCall(ref _callListApiConfigs);
            _callGetApiConfig = clientHelper.BuildApiCall<GetApiConfigRequest, ApiConfig>("GetApiConfig", grpcClient.GetApiConfigAsync, grpcClient.GetApiConfig, effectiveSettings.GetApiConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApiConfig);
            Modify_GetApiConfigApiCall(ref _callGetApiConfig);
            _callCreateApiConfig = clientHelper.BuildApiCall<CreateApiConfigRequest, lro::Operation>("CreateApiConfig", grpcClient.CreateApiConfigAsync, grpcClient.CreateApiConfig, effectiveSettings.CreateApiConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApiConfig);
            Modify_CreateApiConfigApiCall(ref _callCreateApiConfig);
            _callUpdateApiConfig = clientHelper.BuildApiCall<UpdateApiConfigRequest, lro::Operation>("UpdateApiConfig", grpcClient.UpdateApiConfigAsync, grpcClient.UpdateApiConfig, effectiveSettings.UpdateApiConfigSettings).WithGoogleRequestParam("api_config.name", request => request.ApiConfig?.Name);
            Modify_ApiCall(ref _callUpdateApiConfig);
            Modify_UpdateApiConfigApiCall(ref _callUpdateApiConfig);
            _callDeleteApiConfig = clientHelper.BuildApiCall<DeleteApiConfigRequest, lro::Operation>("DeleteApiConfig", grpcClient.DeleteApiConfigAsync, grpcClient.DeleteApiConfig, effectiveSettings.DeleteApiConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApiConfig);
            Modify_DeleteApiConfigApiCall(ref _callDeleteApiConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListGatewaysApiCall(ref gaxgrpc::ApiCall<ListGatewaysRequest, ListGatewaysResponse> call);

        partial void Modify_GetGatewayApiCall(ref gaxgrpc::ApiCall<GetGatewayRequest, Gateway> call);

        partial void Modify_CreateGatewayApiCall(ref gaxgrpc::ApiCall<CreateGatewayRequest, lro::Operation> call);

        partial void Modify_UpdateGatewayApiCall(ref gaxgrpc::ApiCall<UpdateGatewayRequest, lro::Operation> call);

        partial void Modify_DeleteGatewayApiCall(ref gaxgrpc::ApiCall<DeleteGatewayRequest, lro::Operation> call);

        partial void Modify_ListApisApiCall(ref gaxgrpc::ApiCall<ListApisRequest, ListApisResponse> call);

        partial void Modify_GetApiApiCall(ref gaxgrpc::ApiCall<GetApiRequest, Api> call);

        partial void Modify_CreateApiApiCall(ref gaxgrpc::ApiCall<CreateApiRequest, lro::Operation> call);

        partial void Modify_UpdateApiApiCall(ref gaxgrpc::ApiCall<UpdateApiRequest, lro::Operation> call);

        partial void Modify_DeleteApiApiCall(ref gaxgrpc::ApiCall<DeleteApiRequest, lro::Operation> call);

        partial void Modify_ListApiConfigsApiCall(ref gaxgrpc::ApiCall<ListApiConfigsRequest, ListApiConfigsResponse> call);

        partial void Modify_GetApiConfigApiCall(ref gaxgrpc::ApiCall<GetApiConfigRequest, ApiConfig> call);

        partial void Modify_CreateApiConfigApiCall(ref gaxgrpc::ApiCall<CreateApiConfigRequest, lro::Operation> call);

        partial void Modify_UpdateApiConfigApiCall(ref gaxgrpc::ApiCall<UpdateApiConfigRequest, lro::Operation> call);

        partial void Modify_DeleteApiConfigApiCall(ref gaxgrpc::ApiCall<DeleteApiConfigRequest, lro::Operation> call);

        partial void OnConstruction(ApiGatewayService.ApiGatewayServiceClient grpcClient, ApiGatewayServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ApiGatewayService client</summary>
        public override ApiGatewayService.ApiGatewayServiceClient GrpcClient { get; }

        partial void Modify_ListGatewaysRequest(ref ListGatewaysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGatewayRequest(ref GetGatewayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGatewayRequest(ref CreateGatewayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGatewayRequest(ref UpdateGatewayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGatewayRequest(ref DeleteGatewayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApisRequest(ref ListApisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApiRequest(ref GetApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateApiRequest(ref CreateApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApiRequest(ref UpdateApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApiRequest(ref DeleteApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApiConfigsRequest(ref ListApiConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApiConfigRequest(ref GetApiConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateApiConfigRequest(ref CreateApiConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApiConfigRequest(ref UpdateApiConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApiConfigRequest(ref DeleteApiConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Gateway"/> resources.</returns>
        public override gax::PagedEnumerable<ListGatewaysResponse, Gateway> ListGateways(ListGatewaysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGatewaysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGatewaysRequest, ListGatewaysResponse, Gateway>(_callListGateways, request, callSettings);
        }

        /// <summary>
        /// Lists Gateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Gateway"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGatewaysResponse, Gateway> ListGatewaysAsync(ListGatewaysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGatewaysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGatewaysRequest, ListGatewaysResponse, Gateway>(_callListGateways, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Gateway GetGateway(GetGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGatewayRequest(ref request, ref callSettings);
            return _callGetGateway.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Gateway> GetGatewayAsync(GetGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGatewayRequest(ref request, ref callSettings);
            return _callGetGateway.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateGateway</c>.</summary>
        public override lro::OperationsClient CreateGatewayOperationsClient { get; }

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Gateway, OperationMetadata> CreateGateway(CreateGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<Gateway, OperationMetadata>(_callCreateGateway.Sync(request, callSettings), CreateGatewayOperationsClient);
        }

        /// <summary>
        /// Creates a new Gateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Gateway, OperationMetadata>> CreateGatewayAsync(CreateGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<Gateway, OperationMetadata>(await _callCreateGateway.Async(request, callSettings).ConfigureAwait(false), CreateGatewayOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateGateway</c>.</summary>
        public override lro::OperationsClient UpdateGatewayOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Gateway, OperationMetadata> UpdateGateway(UpdateGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<Gateway, OperationMetadata>(_callUpdateGateway.Sync(request, callSettings), UpdateGatewayOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Gateway, OperationMetadata>> UpdateGatewayAsync(UpdateGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<Gateway, OperationMetadata>(await _callUpdateGateway.Async(request, callSettings).ConfigureAwait(false), UpdateGatewayOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteGateway</c>.</summary>
        public override lro::OperationsClient DeleteGatewayOperationsClient { get; }

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteGateway(DeleteGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteGateway.Sync(request, callSettings), DeleteGatewayOperationsClient);
        }

        /// <summary>
        /// Deletes a single Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGatewayAsync(DeleteGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteGateway.Async(request, callSettings).ConfigureAwait(false), DeleteGatewayOperationsClient);
        }

        /// <summary>
        /// Lists Apis in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Api"/> resources.</returns>
        public override gax::PagedEnumerable<ListApisResponse, Api> ListApis(ListApisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApisRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApisRequest, ListApisResponse, Api>(_callListApis, request, callSettings);
        }

        /// <summary>
        /// Lists Apis in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Api"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApisResponse, Api> ListApisAsync(ListApisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApisRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApisRequest, ListApisResponse, Api>(_callListApis, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Api GetApi(GetApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiRequest(ref request, ref callSettings);
            return _callGetApi.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Api> GetApiAsync(GetApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiRequest(ref request, ref callSettings);
            return _callGetApi.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateApi</c>.</summary>
        public override lro::OperationsClient CreateApiOperationsClient { get; }

        /// <summary>
        /// Creates a new Api in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Api, OperationMetadata> CreateApi(CreateApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiRequest(ref request, ref callSettings);
            return new lro::Operation<Api, OperationMetadata>(_callCreateApi.Sync(request, callSettings), CreateApiOperationsClient);
        }

        /// <summary>
        /// Creates a new Api in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Api, OperationMetadata>> CreateApiAsync(CreateApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiRequest(ref request, ref callSettings);
            return new lro::Operation<Api, OperationMetadata>(await _callCreateApi.Async(request, callSettings).ConfigureAwait(false), CreateApiOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateApi</c>.</summary>
        public override lro::OperationsClient UpdateApiOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Api, OperationMetadata> UpdateApi(UpdateApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApiRequest(ref request, ref callSettings);
            return new lro::Operation<Api, OperationMetadata>(_callUpdateApi.Sync(request, callSettings), UpdateApiOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Api, OperationMetadata>> UpdateApiAsync(UpdateApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApiRequest(ref request, ref callSettings);
            return new lro::Operation<Api, OperationMetadata>(await _callUpdateApi.Async(request, callSettings).ConfigureAwait(false), UpdateApiOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteApi</c>.</summary>
        public override lro::OperationsClient DeleteApiOperationsClient { get; }

        /// <summary>
        /// Deletes a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteApi(DeleteApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteApi.Sync(request, callSettings), DeleteApiOperationsClient);
        }

        /// <summary>
        /// Deletes a single Api.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiAsync(DeleteApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteApi.Async(request, callSettings).ConfigureAwait(false), DeleteApiOperationsClient);
        }

        /// <summary>
        /// Lists ApiConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListApiConfigsResponse, ApiConfig> ListApiConfigs(ListApiConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApiConfigsRequest, ListApiConfigsResponse, ApiConfig>(_callListApiConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists ApiConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApiConfigsResponse, ApiConfig> ListApiConfigsAsync(ListApiConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApiConfigsRequest, ListApiConfigsResponse, ApiConfig>(_callListApiConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiConfig GetApiConfig(GetApiConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiConfigRequest(ref request, ref callSettings);
            return _callGetApiConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiConfig> GetApiConfigAsync(GetApiConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiConfigRequest(ref request, ref callSettings);
            return _callGetApiConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateApiConfig</c>.</summary>
        public override lro::OperationsClient CreateApiConfigOperationsClient { get; }

        /// <summary>
        /// Creates a new ApiConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ApiConfig, OperationMetadata> CreateApiConfig(CreateApiConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiConfigRequest(ref request, ref callSettings);
            return new lro::Operation<ApiConfig, OperationMetadata>(_callCreateApiConfig.Sync(request, callSettings), CreateApiConfigOperationsClient);
        }

        /// <summary>
        /// Creates a new ApiConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ApiConfig, OperationMetadata>> CreateApiConfigAsync(CreateApiConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiConfigRequest(ref request, ref callSettings);
            return new lro::Operation<ApiConfig, OperationMetadata>(await _callCreateApiConfig.Async(request, callSettings).ConfigureAwait(false), CreateApiConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateApiConfig</c>.</summary>
        public override lro::OperationsClient UpdateApiConfigOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ApiConfig, OperationMetadata> UpdateApiConfig(UpdateApiConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApiConfigRequest(ref request, ref callSettings);
            return new lro::Operation<ApiConfig, OperationMetadata>(_callUpdateApiConfig.Sync(request, callSettings), UpdateApiConfigOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ApiConfig, OperationMetadata>> UpdateApiConfigAsync(UpdateApiConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApiConfigRequest(ref request, ref callSettings);
            return new lro::Operation<ApiConfig, OperationMetadata>(await _callUpdateApiConfig.Async(request, callSettings).ConfigureAwait(false), UpdateApiConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteApiConfig</c>.</summary>
        public override lro::OperationsClient DeleteApiConfigOperationsClient { get; }

        /// <summary>
        /// Deletes a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteApiConfig(DeleteApiConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteApiConfig.Sync(request, callSettings), DeleteApiConfigOperationsClient);
        }

        /// <summary>
        /// Deletes a single ApiConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApiConfigAsync(DeleteApiConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteApiConfig.Async(request, callSettings).ConfigureAwait(false), DeleteApiConfigOperationsClient);
        }
    }

    public partial class ListGatewaysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApisRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApiConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGatewaysResponse : gaxgrpc::IPageResponse<Gateway>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Gateway> GetEnumerator() => Gateways.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListApisResponse : gaxgrpc::IPageResponse<Api>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Api> GetEnumerator() => Apis.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListApiConfigsResponse : gaxgrpc::IPageResponse<ApiConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ApiConfig> GetEnumerator() => ApiConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ApiGatewayService
    {
        public partial class ApiGatewayServiceClient
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
