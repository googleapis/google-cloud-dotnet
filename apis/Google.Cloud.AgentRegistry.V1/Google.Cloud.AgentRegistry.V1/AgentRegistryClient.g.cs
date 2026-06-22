// Copyright 2026 Google LLC
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

namespace Google.Cloud.AgentRegistry.V1
{
    /// <summary>Settings for <see cref="AgentRegistryClient"/> instances.</summary>
    public sealed partial class AgentRegistrySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AgentRegistrySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AgentRegistrySettings"/>.</returns>
        public static AgentRegistrySettings GetDefault() => new AgentRegistrySettings();

        /// <summary>Constructs a new <see cref="AgentRegistrySettings"/> object with default settings.</summary>
        public AgentRegistrySettings()
        {
        }

        private AgentRegistrySettings(AgentRegistrySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAgentsSettings = existing.ListAgentsSettings;
            SearchAgentsSettings = existing.SearchAgentsSettings;
            GetAgentSettings = existing.GetAgentSettings;
            ListEndpointsSettings = existing.ListEndpointsSettings;
            GetEndpointSettings = existing.GetEndpointSettings;
            ListMcpServersSettings = existing.ListMcpServersSettings;
            SearchMcpServersSettings = existing.SearchMcpServersSettings;
            GetMcpServerSettings = existing.GetMcpServerSettings;
            ListServicesSettings = existing.ListServicesSettings;
            GetServiceSettings = existing.GetServiceSettings;
            CreateServiceSettings = existing.CreateServiceSettings;
            CreateServiceOperationsSettings = existing.CreateServiceOperationsSettings.Clone();
            UpdateServiceSettings = existing.UpdateServiceSettings;
            UpdateServiceOperationsSettings = existing.UpdateServiceOperationsSettings.Clone();
            DeleteServiceSettings = existing.DeleteServiceSettings;
            DeleteServiceOperationsSettings = existing.DeleteServiceOperationsSettings.Clone();
            ListBindingsSettings = existing.ListBindingsSettings;
            GetBindingSettings = existing.GetBindingSettings;
            CreateBindingSettings = existing.CreateBindingSettings;
            CreateBindingOperationsSettings = existing.CreateBindingOperationsSettings.Clone();
            UpdateBindingSettings = existing.UpdateBindingSettings;
            UpdateBindingOperationsSettings = existing.UpdateBindingOperationsSettings.Clone();
            DeleteBindingSettings = existing.DeleteBindingSettings;
            DeleteBindingOperationsSettings = existing.DeleteBindingOperationsSettings.Clone();
            FetchAvailableBindingsSettings = existing.FetchAvailableBindingsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AgentRegistrySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.ListAgents</c> and <c>AgentRegistryClient.ListAgentsAsync</c>.
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
        public gaxgrpc::CallSettings ListAgentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.SearchAgents</c> and <c>AgentRegistryClient.SearchAgentsAsync</c>.
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
        public gaxgrpc::CallSettings SearchAgentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetAgent</c> and <c>AgentRegistryClient.GetAgentAsync</c>.
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
        public gaxgrpc::CallSettings GetAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.ListEndpoints</c> and <c>AgentRegistryClient.ListEndpointsAsync</c>.
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
        public gaxgrpc::CallSettings ListEndpointsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetEndpoint</c> and <c>AgentRegistryClient.GetEndpointAsync</c>.
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
        public gaxgrpc::CallSettings GetEndpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.ListMcpServers</c> and <c>AgentRegistryClient.ListMcpServersAsync</c>.
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
        public gaxgrpc::CallSettings ListMcpServersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.SearchMcpServers</c> and <c>AgentRegistryClient.SearchMcpServersAsync</c>.
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
        public gaxgrpc::CallSettings SearchMcpServersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetMcpServer</c> and <c>AgentRegistryClient.GetMcpServerAsync</c>.
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
        public gaxgrpc::CallSettings GetMcpServerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.ListServices</c> and <c>AgentRegistryClient.ListServicesAsync</c>.
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
        public gaxgrpc::CallSettings ListServicesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetService</c> and <c>AgentRegistryClient.GetServiceAsync</c>.
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
        public gaxgrpc::CallSettings GetServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.CreateService</c> and <c>AgentRegistryClient.CreateServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentRegistryClient.CreateService</c> and
        /// <c>AgentRegistryClient.CreateServiceAsync</c>.
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
        public lro::OperationsSettings CreateServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.UpdateService</c> and <c>AgentRegistryClient.UpdateServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentRegistryClient.UpdateService</c> and
        /// <c>AgentRegistryClient.UpdateServiceAsync</c>.
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
        public lro::OperationsSettings UpdateServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.DeleteService</c> and <c>AgentRegistryClient.DeleteServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentRegistryClient.DeleteService</c> and
        /// <c>AgentRegistryClient.DeleteServiceAsync</c>.
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
        public lro::OperationsSettings DeleteServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.ListBindings</c> and <c>AgentRegistryClient.ListBindingsAsync</c>.
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
        public gaxgrpc::CallSettings ListBindingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetBinding</c> and <c>AgentRegistryClient.GetBindingAsync</c>.
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
        public gaxgrpc::CallSettings GetBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.CreateBinding</c> and <c>AgentRegistryClient.CreateBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentRegistryClient.CreateBinding</c> and
        /// <c>AgentRegistryClient.CreateBindingAsync</c>.
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
        public lro::OperationsSettings CreateBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.UpdateBinding</c> and <c>AgentRegistryClient.UpdateBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentRegistryClient.UpdateBinding</c> and
        /// <c>AgentRegistryClient.UpdateBindingAsync</c>.
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
        public lro::OperationsSettings UpdateBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.DeleteBinding</c> and <c>AgentRegistryClient.DeleteBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentRegistryClient.DeleteBinding</c> and
        /// <c>AgentRegistryClient.DeleteBindingAsync</c>.
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
        public lro::OperationsSettings DeleteBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.FetchAvailableBindings</c> and <c>AgentRegistryClient.FetchAvailableBindingsAsync</c>
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
        public gaxgrpc::CallSettings FetchAvailableBindingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AgentRegistrySettings"/> object.</returns>
        public AgentRegistrySettings Clone() => new AgentRegistrySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AgentRegistryClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AgentRegistryClientBuilder : gaxgrpc::ClientBuilderBase<AgentRegistryClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AgentRegistrySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AgentRegistryClientBuilder() : base(AgentRegistryClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AgentRegistryClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AgentRegistryClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AgentRegistryClient Build()
        {
            AgentRegistryClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AgentRegistryClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AgentRegistryClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AgentRegistryClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AgentRegistryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AgentRegistryClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AgentRegistryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AgentRegistryClient.ChannelPool;
    }

    /// <summary>AgentRegistry client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Agents, Endpoints, McpServers, Services, and Bindings.
    /// </remarks>
    public abstract partial class AgentRegistryClient
    {
        /// <summary>
        /// The default endpoint for the AgentRegistry service, which is a host of "agentregistry.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "agentregistry.googleapis.com:443";

        /// <summary>The default AgentRegistry scopes.</summary>
        /// <remarks>
        /// The default AgentRegistry scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/agentregistry.read-only</description></item>
        /// <item><description>https://www.googleapis.com/auth/agentregistry.read-write</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/agentregistry.read-only",
            "https://www.googleapis.com/auth/agentregistry.read-write",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AgentRegistry.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AgentRegistryClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AgentRegistryClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AgentRegistryClient"/>.</returns>
        public static stt::Task<AgentRegistryClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AgentRegistryClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AgentRegistryClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AgentRegistryClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AgentRegistryClient"/>.</returns>
        public static AgentRegistryClient Create() => new AgentRegistryClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AgentRegistryClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AgentRegistrySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AgentRegistryClient"/>.</returns>
        internal static AgentRegistryClient Create(grpccore::CallInvoker callInvoker, AgentRegistrySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AgentRegistry.AgentRegistryClient grpcClient = new AgentRegistry.AgentRegistryClient(callInvoker);
            return new AgentRegistryClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AgentRegistry client</summary>
        public virtual AgentRegistry.AgentRegistryClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Agents in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAgentsResponse, Agent> ListAgents(ListAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Agents in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAgentsResponse, Agent> ListAgentsAsync(ListAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Agents in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAgentsRequest
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
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAgentsResponse, Agent> ListAgents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAgentsRequest request = new ListAgentsRequest
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
            return ListAgents(request, callSettings);
        }

        /// <summary>
        /// Lists Agents in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAgentsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAgentsResponse, Agent> ListAgentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAgentsRequest request = new ListAgentsRequest
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
            return ListAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Agents in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAgentsRequest
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
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAgentsResponse, Agent> ListAgents(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAgentsRequest request = new ListAgentsRequest
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
            return ListAgents(request, callSettings);
        }

        /// <summary>
        /// Lists Agents in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAgentsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAgentsResponse, Agent> ListAgentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAgentsRequest request = new ListAgentsRequest
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
            return ListAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Searches Agents in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAgentsResponse, Agent> SearchAgents(SearchAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches Agents in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAgentsResponse, Agent> SearchAgentsAsync(SearchAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches Agents in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for SearchAgentsRequest. Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAgentsResponse, Agent> SearchAgents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAgentsRequest request = new SearchAgentsRequest
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
            return SearchAgents(request, callSettings);
        }

        /// <summary>
        /// Searches Agents in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for SearchAgentsRequest. Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAgentsResponse, Agent> SearchAgentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAgentsRequest request = new SearchAgentsRequest
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
            return SearchAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Searches Agents in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for SearchAgentsRequest. Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAgentsResponse, Agent> SearchAgents(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAgentsRequest request = new SearchAgentsRequest
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
            return SearchAgents(request, callSettings);
        }

        /// <summary>
        /// Searches Agents in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for SearchAgentsRequest. Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAgentsResponse, Agent> SearchAgentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAgentsRequest request = new SearchAgentsRequest
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
            return SearchAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAgent(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(GetAgentRequest request, st::CancellationToken cancellationToken) =>
            GetAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Agent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAgent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgent(new GetAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Agent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentAsync(new GetAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Agent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(string name, st::CancellationToken cancellationToken) =>
            GetAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Agent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAgent(AgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgent(new GetAgentRequest
            {
                AgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Agent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(AgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentAsync(new GetAgentRequest
            {
                AgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Agent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(AgentName name, st::CancellationToken cancellationToken) =>
            GetAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list endpoints in.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
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
            return ListEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list endpoints in.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
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
            return ListEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list endpoints in.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
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
            return ListEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list endpoints in.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
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
            return ListEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetEndpoint(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(GetEndpointRequest request, st::CancellationToken cancellationToken) =>
            GetEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to retrieve.
        /// Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpoint(new GetEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to retrieve.
        /// Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointAsync(new GetEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to retrieve.
        /// Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            GetEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to retrieve.
        /// Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetEndpoint(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpoint(new GetEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to retrieve.
        /// Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointAsync(new GetEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to retrieve.
        /// Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(EndpointName name, st::CancellationToken cancellationToken) =>
            GetEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists McpServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMcpServersResponse, McpServer> ListMcpServers(ListMcpServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists McpServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMcpServersResponse, McpServer> ListMcpServersAsync(ListMcpServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists McpServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListMcpServersRequest. Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMcpServersResponse, McpServer> ListMcpServers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMcpServersRequest request = new ListMcpServersRequest
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
            return ListMcpServers(request, callSettings);
        }

        /// <summary>
        /// Lists McpServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListMcpServersRequest. Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMcpServersResponse, McpServer> ListMcpServersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMcpServersRequest request = new ListMcpServersRequest
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
            return ListMcpServersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists McpServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListMcpServersRequest. Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMcpServersResponse, McpServer> ListMcpServers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMcpServersRequest request = new ListMcpServersRequest
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
            return ListMcpServers(request, callSettings);
        }

        /// <summary>
        /// Lists McpServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListMcpServersRequest. Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMcpServersResponse, McpServer> ListMcpServersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMcpServersRequest request = new ListMcpServersRequest
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
            return ListMcpServersAsync(request, callSettings);
        }

        /// <summary>
        /// Searches McpServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchMcpServersResponse, McpServer> SearchMcpServers(SearchMcpServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches McpServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchMcpServersResponse, McpServer> SearchMcpServersAsync(SearchMcpServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches McpServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for SearchMcpServersRequest. Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchMcpServersResponse, McpServer> SearchMcpServers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchMcpServersRequest request = new SearchMcpServersRequest
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
            return SearchMcpServers(request, callSettings);
        }

        /// <summary>
        /// Searches McpServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for SearchMcpServersRequest. Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchMcpServersResponse, McpServer> SearchMcpServersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchMcpServersRequest request = new SearchMcpServersRequest
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
            return SearchMcpServersAsync(request, callSettings);
        }

        /// <summary>
        /// Searches McpServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for SearchMcpServersRequest. Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchMcpServersResponse, McpServer> SearchMcpServers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchMcpServersRequest request = new SearchMcpServersRequest
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
            return SearchMcpServers(request, callSettings);
        }

        /// <summary>
        /// Searches McpServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for SearchMcpServersRequest. Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchMcpServersResponse, McpServer> SearchMcpServersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchMcpServersRequest request = new SearchMcpServersRequest
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
            return SearchMcpServersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual McpServer GetMcpServer(GetMcpServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetMcpServerAsync(GetMcpServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetMcpServerAsync(GetMcpServerRequest request, st::CancellationToken cancellationToken) =>
            GetMcpServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single McpServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual McpServer GetMcpServer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMcpServer(new GetMcpServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single McpServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetMcpServerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMcpServerAsync(new GetMcpServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single McpServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetMcpServerAsync(string name, st::CancellationToken cancellationToken) =>
            GetMcpServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single McpServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual McpServer GetMcpServer(McpServerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMcpServer(new GetMcpServerRequest
            {
                McpServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single McpServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetMcpServerAsync(McpServerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMcpServerAsync(new GetMcpServerRequest
            {
                McpServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single McpServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetMcpServerAsync(McpServerName name, st::CancellationToken cancellationToken) =>
            GetMcpServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list services in.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServices(request, callSettings);
        }

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list services in.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list services in.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServices(request, callSettings);
        }

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list services in.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, st::CancellationToken cancellationToken) =>
            GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Service.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Service.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Service.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Service.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Service.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Service.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(ServiceName name, st::CancellationToken cancellationToken) =>
            GetServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Service in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> CreateService(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Service in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Service in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(CreateServiceRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateService</c>.</summary>
        public virtual lro::OperationsClient CreateServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Service, OperationMetadata> PollOnceCreateService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Service, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> PollOnceCreateServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Service, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Service in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the Service in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="service">
        /// Required. The Service resource that is being created.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="serviceId">
        /// Required. The ID to use for the service, which will become the final
        /// component of the service's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> CreateService(string parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a new Service in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the Service in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="service">
        /// Required. The Service resource that is being created.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="serviceId">
        /// Required. The ID to use for the service, which will become the final
        /// component of the service's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(string parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a new Service in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the Service in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="service">
        /// Required. The Service resource that is being created.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="serviceId">
        /// Required. The ID to use for the service, which will become the final
        /// component of the service's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(string parent, Service service, string serviceId, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(parent, service, serviceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Service in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the Service in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="service">
        /// Required. The Service resource that is being created.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="serviceId">
        /// Required. The ID to use for the service, which will become the final
        /// component of the service's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> CreateService(gagr::LocationName parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a new Service in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the Service in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="service">
        /// Required. The Service resource that is being created.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="serviceId">
        /// Required. The ID to use for the service, which will become the final
        /// component of the service's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(gagr::LocationName parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a new Service in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the Service in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="service">
        /// Required. The Service resource that is being created.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="serviceId">
        /// Required. The ID to use for the service, which will become the final
        /// component of the service's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(gagr::LocationName parent, Service service, string serviceId, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(parent, service, serviceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> UpdateService(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(UpdateServiceRequest request, st::CancellationToken cancellationToken) =>
            UpdateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateService</c>.</summary>
        public virtual lro::OperationsClient UpdateServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Service, OperationMetadata> PollOnceUpdateService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Service, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> PollOnceUpdateServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Service, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Service.
        /// </summary>
        /// <param name="service">
        /// Required. The Service resource that is being updated.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Service resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> UpdateService(Service service, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateService(new UpdateServiceRequest
            {
                UpdateMask = updateMask,
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Service.
        /// </summary>
        /// <param name="service">
        /// Required. The Service resource that is being updated.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Service resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(Service service, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceAsync(new UpdateServiceRequest
            {
                UpdateMask = updateMask,
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Service.
        /// </summary>
        /// <param name="service">
        /// Required. The Service resource that is being updated.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Service resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(Service service, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateServiceAsync(service, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteService(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(DeleteServiceRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteService</c>.</summary>
        public virtual lro::OperationsClient DeleteServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Service.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteService(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteService(new DeleteServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Service.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAsync(new DeleteServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Service.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Service.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteService(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteService(new DeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Service.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAsync(new DeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Service.
        /// Format: `projects/{project}/locations/{location}/services/{service}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(ServiceName name, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Bindings in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Binding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBindingsResponse, Binding> ListBindings(ListBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Bindings in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Binding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBindingsResponse, Binding> ListBindingsAsync(ListBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Bindings in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list bindings in.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Binding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBindingsResponse, Binding> ListBindings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBindingsRequest request = new ListBindingsRequest
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
            return ListBindings(request, callSettings);
        }

        /// <summary>
        /// Lists Bindings in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list bindings in.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Binding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBindingsResponse, Binding> ListBindingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBindingsRequest request = new ListBindingsRequest
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
            return ListBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Bindings in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list bindings in.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Binding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBindingsResponse, Binding> ListBindings(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBindingsRequest request = new ListBindingsRequest
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
            return ListBindings(request, callSettings);
        }

        /// <summary>
        /// Lists Bindings in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to list bindings in.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Binding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBindingsResponse, Binding> ListBindingsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBindingsRequest request = new ListBindingsRequest
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
            return ListBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Binding GetBinding(GetBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Binding> GetBindingAsync(GetBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Binding> GetBindingAsync(GetBindingRequest request, st::CancellationToken cancellationToken) =>
            GetBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Binding.
        /// Format: `projects/{project}/locations/{location}/bindings/{binding}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Binding GetBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBinding(new GetBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Binding.
        /// Format: `projects/{project}/locations/{location}/bindings/{binding}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Binding> GetBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBindingAsync(new GetBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Binding.
        /// Format: `projects/{project}/locations/{location}/bindings/{binding}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Binding> GetBindingAsync(string name, st::CancellationToken cancellationToken) =>
            GetBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Binding.
        /// Format: `projects/{project}/locations/{location}/bindings/{binding}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Binding GetBinding(BindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBinding(new GetBindingRequest
            {
                BindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Binding.
        /// Format: `projects/{project}/locations/{location}/bindings/{binding}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Binding> GetBindingAsync(BindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBindingAsync(new GetBindingRequest
            {
                BindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Binding.
        /// Format: `projects/{project}/locations/{location}/bindings/{binding}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Binding> GetBindingAsync(BindingName name, st::CancellationToken cancellationToken) =>
            GetBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Binding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Binding, OperationMetadata> CreateBinding(CreateBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Binding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Binding, OperationMetadata>> CreateBindingAsync(CreateBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Binding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Binding, OperationMetadata>> CreateBindingAsync(CreateBindingRequest request, st::CancellationToken cancellationToken) =>
            CreateBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateBinding</c>.</summary>
        public virtual lro::OperationsClient CreateBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Binding, OperationMetadata> PollOnceCreateBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Binding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Binding, OperationMetadata>> PollOnceCreateBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Binding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBindingOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Binding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the Binding in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="binding">
        /// Required. The Binding resource that is being created.
        /// </param>
        /// <param name="bindingId">
        /// Required. The ID to use for the binding, which will become the final
        /// component of the binding's resource name.
        /// 
        /// This value should be 4-63 characters, and must conform to RFC-1034.
        /// Specifically, it must match the regular expression
        /// `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Binding, OperationMetadata> CreateBinding(string parent, Binding binding, string bindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBinding(new CreateBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(bindingId, nameof(bindingId)),
                Binding = gax::GaxPreconditions.CheckNotNull(binding, nameof(binding)),
            }, callSettings);

        /// <summary>
        /// Creates a new Binding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the Binding in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="binding">
        /// Required. The Binding resource that is being created.
        /// </param>
        /// <param name="bindingId">
        /// Required. The ID to use for the binding, which will become the final
        /// component of the binding's resource name.
        /// 
        /// This value should be 4-63 characters, and must conform to RFC-1034.
        /// Specifically, it must match the regular expression
        /// `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Binding, OperationMetadata>> CreateBindingAsync(string parent, Binding binding, string bindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBindingAsync(new CreateBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(bindingId, nameof(bindingId)),
                Binding = gax::GaxPreconditions.CheckNotNull(binding, nameof(binding)),
            }, callSettings);

        /// <summary>
        /// Creates a new Binding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the Binding in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="binding">
        /// Required. The Binding resource that is being created.
        /// </param>
        /// <param name="bindingId">
        /// Required. The ID to use for the binding, which will become the final
        /// component of the binding's resource name.
        /// 
        /// This value should be 4-63 characters, and must conform to RFC-1034.
        /// Specifically, it must match the regular expression
        /// `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Binding, OperationMetadata>> CreateBindingAsync(string parent, Binding binding, string bindingId, st::CancellationToken cancellationToken) =>
            CreateBindingAsync(parent, binding, bindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Binding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the Binding in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="binding">
        /// Required. The Binding resource that is being created.
        /// </param>
        /// <param name="bindingId">
        /// Required. The ID to use for the binding, which will become the final
        /// component of the binding's resource name.
        /// 
        /// This value should be 4-63 characters, and must conform to RFC-1034.
        /// Specifically, it must match the regular expression
        /// `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Binding, OperationMetadata> CreateBinding(gagr::LocationName parent, Binding binding, string bindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBinding(new CreateBindingRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(bindingId, nameof(bindingId)),
                Binding = gax::GaxPreconditions.CheckNotNull(binding, nameof(binding)),
            }, callSettings);

        /// <summary>
        /// Creates a new Binding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the Binding in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="binding">
        /// Required. The Binding resource that is being created.
        /// </param>
        /// <param name="bindingId">
        /// Required. The ID to use for the binding, which will become the final
        /// component of the binding's resource name.
        /// 
        /// This value should be 4-63 characters, and must conform to RFC-1034.
        /// Specifically, it must match the regular expression
        /// `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Binding, OperationMetadata>> CreateBindingAsync(gagr::LocationName parent, Binding binding, string bindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBindingAsync(new CreateBindingRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(bindingId, nameof(bindingId)),
                Binding = gax::GaxPreconditions.CheckNotNull(binding, nameof(binding)),
            }, callSettings);

        /// <summary>
        /// Creates a new Binding in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location to create the Binding in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="binding">
        /// Required. The Binding resource that is being created.
        /// </param>
        /// <param name="bindingId">
        /// Required. The ID to use for the binding, which will become the final
        /// component of the binding's resource name.
        /// 
        /// This value should be 4-63 characters, and must conform to RFC-1034.
        /// Specifically, it must match the regular expression
        /// `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Binding, OperationMetadata>> CreateBindingAsync(gagr::LocationName parent, Binding binding, string bindingId, st::CancellationToken cancellationToken) =>
            CreateBindingAsync(parent, binding, bindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Binding, OperationMetadata> UpdateBinding(UpdateBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Binding, OperationMetadata>> UpdateBindingAsync(UpdateBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Binding, OperationMetadata>> UpdateBindingAsync(UpdateBindingRequest request, st::CancellationToken cancellationToken) =>
            UpdateBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateBinding</c>.</summary>
        public virtual lro::OperationsClient UpdateBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Binding, OperationMetadata> PollOnceUpdateBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Binding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Binding, OperationMetadata>> PollOnceUpdateBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Binding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBindingOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Binding.
        /// </summary>
        /// <param name="binding">
        /// Required. The Binding resource that is being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Binding resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Binding, OperationMetadata> UpdateBinding(Binding binding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBinding(new UpdateBindingRequest
            {
                Binding = gax::GaxPreconditions.CheckNotNull(binding, nameof(binding)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Binding.
        /// </summary>
        /// <param name="binding">
        /// Required. The Binding resource that is being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Binding resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Binding, OperationMetadata>> UpdateBindingAsync(Binding binding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBindingAsync(new UpdateBindingRequest
            {
                Binding = gax::GaxPreconditions.CheckNotNull(binding, nameof(binding)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Binding.
        /// </summary>
        /// <param name="binding">
        /// Required. The Binding resource that is being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Binding resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Binding, OperationMetadata>> UpdateBindingAsync(Binding binding, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBindingAsync(binding, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBinding(DeleteBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBindingAsync(DeleteBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBindingAsync(DeleteBindingRequest request, st::CancellationToken cancellationToken) =>
            DeleteBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteBinding</c>.</summary>
        public virtual lro::OperationsClient DeleteBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBindingOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Binding.
        /// Format: `projects/{project}/locations/{location}/bindings/{binding}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBinding(new DeleteBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Binding.
        /// Format: `projects/{project}/locations/{location}/bindings/{binding}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBindingAsync(new DeleteBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Binding.
        /// Format: `projects/{project}/locations/{location}/bindings/{binding}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBindingAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Binding.
        /// Format: `projects/{project}/locations/{location}/bindings/{binding}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBinding(BindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBinding(new DeleteBindingRequest
            {
                BindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Binding.
        /// Format: `projects/{project}/locations/{location}/bindings/{binding}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBindingAsync(BindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBindingAsync(new DeleteBindingRequest
            {
                BindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Binding.
        /// Format: `projects/{project}/locations/{location}/bindings/{binding}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBindingAsync(BindingName name, st::CancellationToken cancellationToken) =>
            DeleteBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches available Bindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Binding"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchAvailableBindingsResponse, Binding> FetchAvailableBindings(FetchAvailableBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches available Bindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Binding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchAvailableBindingsResponse, Binding> FetchAvailableBindingsAsync(FetchAvailableBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches available Bindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the format
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Binding"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchAvailableBindingsResponse, Binding> FetchAvailableBindings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchAvailableBindingsRequest request = new FetchAvailableBindingsRequest
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
            return FetchAvailableBindings(request, callSettings);
        }

        /// <summary>
        /// Fetches available Bindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the format
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Binding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchAvailableBindingsResponse, Binding> FetchAvailableBindingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchAvailableBindingsRequest request = new FetchAvailableBindingsRequest
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
            return FetchAvailableBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches available Bindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the format
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Binding"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchAvailableBindingsResponse, Binding> FetchAvailableBindings(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchAvailableBindingsRequest request = new FetchAvailableBindingsRequest
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
            return FetchAvailableBindings(request, callSettings);
        }

        /// <summary>
        /// Fetches available Bindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the format
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Binding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchAvailableBindingsResponse, Binding> FetchAvailableBindingsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchAvailableBindingsRequest request = new FetchAvailableBindingsRequest
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
            return FetchAvailableBindingsAsync(request, callSettings);
        }
    }

    /// <summary>AgentRegistry client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Agents, Endpoints, McpServers, Services, and Bindings.
    /// </remarks>
    public sealed partial class AgentRegistryClientImpl : AgentRegistryClient
    {
        private readonly gaxgrpc::ApiCall<ListAgentsRequest, ListAgentsResponse> _callListAgents;

        private readonly gaxgrpc::ApiCall<SearchAgentsRequest, SearchAgentsResponse> _callSearchAgents;

        private readonly gaxgrpc::ApiCall<GetAgentRequest, Agent> _callGetAgent;

        private readonly gaxgrpc::ApiCall<ListEndpointsRequest, ListEndpointsResponse> _callListEndpoints;

        private readonly gaxgrpc::ApiCall<GetEndpointRequest, Endpoint> _callGetEndpoint;

        private readonly gaxgrpc::ApiCall<ListMcpServersRequest, ListMcpServersResponse> _callListMcpServers;

        private readonly gaxgrpc::ApiCall<SearchMcpServersRequest, SearchMcpServersResponse> _callSearchMcpServers;

        private readonly gaxgrpc::ApiCall<GetMcpServerRequest, McpServer> _callGetMcpServer;

        private readonly gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> _callListServices;

        private readonly gaxgrpc::ApiCall<GetServiceRequest, Service> _callGetService;

        private readonly gaxgrpc::ApiCall<CreateServiceRequest, lro::Operation> _callCreateService;

        private readonly gaxgrpc::ApiCall<UpdateServiceRequest, lro::Operation> _callUpdateService;

        private readonly gaxgrpc::ApiCall<DeleteServiceRequest, lro::Operation> _callDeleteService;

        private readonly gaxgrpc::ApiCall<ListBindingsRequest, ListBindingsResponse> _callListBindings;

        private readonly gaxgrpc::ApiCall<GetBindingRequest, Binding> _callGetBinding;

        private readonly gaxgrpc::ApiCall<CreateBindingRequest, lro::Operation> _callCreateBinding;

        private readonly gaxgrpc::ApiCall<UpdateBindingRequest, lro::Operation> _callUpdateBinding;

        private readonly gaxgrpc::ApiCall<DeleteBindingRequest, lro::Operation> _callDeleteBinding;

        private readonly gaxgrpc::ApiCall<FetchAvailableBindingsRequest, FetchAvailableBindingsResponse> _callFetchAvailableBindings;

        /// <summary>
        /// Constructs a client wrapper for the AgentRegistry service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AgentRegistrySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AgentRegistryClientImpl(AgentRegistry.AgentRegistryClient grpcClient, AgentRegistrySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AgentRegistrySettings effectiveSettings = settings ?? AgentRegistrySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServiceOperationsSettings, logger);
            UpdateServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateServiceOperationsSettings, logger);
            DeleteServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServiceOperationsSettings, logger);
            CreateBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBindingOperationsSettings, logger);
            UpdateBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBindingOperationsSettings, logger);
            DeleteBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBindingOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListAgents = clientHelper.BuildApiCall<ListAgentsRequest, ListAgentsResponse>("ListAgents", grpcClient.ListAgentsAsync, grpcClient.ListAgents, effectiveSettings.ListAgentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAgents);
            Modify_ListAgentsApiCall(ref _callListAgents);
            _callSearchAgents = clientHelper.BuildApiCall<SearchAgentsRequest, SearchAgentsResponse>("SearchAgents", grpcClient.SearchAgentsAsync, grpcClient.SearchAgents, effectiveSettings.SearchAgentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchAgents);
            Modify_SearchAgentsApiCall(ref _callSearchAgents);
            _callGetAgent = clientHelper.BuildApiCall<GetAgentRequest, Agent>("GetAgent", grpcClient.GetAgentAsync, grpcClient.GetAgent, effectiveSettings.GetAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAgent);
            Modify_GetAgentApiCall(ref _callGetAgent);
            _callListEndpoints = clientHelper.BuildApiCall<ListEndpointsRequest, ListEndpointsResponse>("ListEndpoints", grpcClient.ListEndpointsAsync, grpcClient.ListEndpoints, effectiveSettings.ListEndpointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEndpoints);
            Modify_ListEndpointsApiCall(ref _callListEndpoints);
            _callGetEndpoint = clientHelper.BuildApiCall<GetEndpointRequest, Endpoint>("GetEndpoint", grpcClient.GetEndpointAsync, grpcClient.GetEndpoint, effectiveSettings.GetEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEndpoint);
            Modify_GetEndpointApiCall(ref _callGetEndpoint);
            _callListMcpServers = clientHelper.BuildApiCall<ListMcpServersRequest, ListMcpServersResponse>("ListMcpServers", grpcClient.ListMcpServersAsync, grpcClient.ListMcpServers, effectiveSettings.ListMcpServersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMcpServers);
            Modify_ListMcpServersApiCall(ref _callListMcpServers);
            _callSearchMcpServers = clientHelper.BuildApiCall<SearchMcpServersRequest, SearchMcpServersResponse>("SearchMcpServers", grpcClient.SearchMcpServersAsync, grpcClient.SearchMcpServers, effectiveSettings.SearchMcpServersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchMcpServers);
            Modify_SearchMcpServersApiCall(ref _callSearchMcpServers);
            _callGetMcpServer = clientHelper.BuildApiCall<GetMcpServerRequest, McpServer>("GetMcpServer", grpcClient.GetMcpServerAsync, grpcClient.GetMcpServer, effectiveSettings.GetMcpServerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMcpServer);
            Modify_GetMcpServerApiCall(ref _callGetMcpServer);
            _callListServices = clientHelper.BuildApiCall<ListServicesRequest, ListServicesResponse>("ListServices", grpcClient.ListServicesAsync, grpcClient.ListServices, effectiveSettings.ListServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServices);
            Modify_ListServicesApiCall(ref _callListServices);
            _callGetService = clientHelper.BuildApiCall<GetServiceRequest, Service>("GetService", grpcClient.GetServiceAsync, grpcClient.GetService, effectiveSettings.GetServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetService);
            Modify_GetServiceApiCall(ref _callGetService);
            _callCreateService = clientHelper.BuildApiCall<CreateServiceRequest, lro::Operation>("CreateService", grpcClient.CreateServiceAsync, grpcClient.CreateService, effectiveSettings.CreateServiceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateService);
            Modify_CreateServiceApiCall(ref _callCreateService);
            _callUpdateService = clientHelper.BuildApiCall<UpdateServiceRequest, lro::Operation>("UpdateService", grpcClient.UpdateServiceAsync, grpcClient.UpdateService, effectiveSettings.UpdateServiceSettings).WithGoogleRequestParam("service.name", request => request.Service?.Name);
            Modify_ApiCall(ref _callUpdateService);
            Modify_UpdateServiceApiCall(ref _callUpdateService);
            _callDeleteService = clientHelper.BuildApiCall<DeleteServiceRequest, lro::Operation>("DeleteService", grpcClient.DeleteServiceAsync, grpcClient.DeleteService, effectiveSettings.DeleteServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteService);
            Modify_DeleteServiceApiCall(ref _callDeleteService);
            _callListBindings = clientHelper.BuildApiCall<ListBindingsRequest, ListBindingsResponse>("ListBindings", grpcClient.ListBindingsAsync, grpcClient.ListBindings, effectiveSettings.ListBindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBindings);
            Modify_ListBindingsApiCall(ref _callListBindings);
            _callGetBinding = clientHelper.BuildApiCall<GetBindingRequest, Binding>("GetBinding", grpcClient.GetBindingAsync, grpcClient.GetBinding, effectiveSettings.GetBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBinding);
            Modify_GetBindingApiCall(ref _callGetBinding);
            _callCreateBinding = clientHelper.BuildApiCall<CreateBindingRequest, lro::Operation>("CreateBinding", grpcClient.CreateBindingAsync, grpcClient.CreateBinding, effectiveSettings.CreateBindingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBinding);
            Modify_CreateBindingApiCall(ref _callCreateBinding);
            _callUpdateBinding = clientHelper.BuildApiCall<UpdateBindingRequest, lro::Operation>("UpdateBinding", grpcClient.UpdateBindingAsync, grpcClient.UpdateBinding, effectiveSettings.UpdateBindingSettings).WithGoogleRequestParam("binding.name", request => request.Binding?.Name);
            Modify_ApiCall(ref _callUpdateBinding);
            Modify_UpdateBindingApiCall(ref _callUpdateBinding);
            _callDeleteBinding = clientHelper.BuildApiCall<DeleteBindingRequest, lro::Operation>("DeleteBinding", grpcClient.DeleteBindingAsync, grpcClient.DeleteBinding, effectiveSettings.DeleteBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBinding);
            Modify_DeleteBindingApiCall(ref _callDeleteBinding);
            _callFetchAvailableBindings = clientHelper.BuildApiCall<FetchAvailableBindingsRequest, FetchAvailableBindingsResponse>("FetchAvailableBindings", grpcClient.FetchAvailableBindingsAsync, grpcClient.FetchAvailableBindings, effectiveSettings.FetchAvailableBindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callFetchAvailableBindings);
            Modify_FetchAvailableBindingsApiCall(ref _callFetchAvailableBindings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAgentsApiCall(ref gaxgrpc::ApiCall<ListAgentsRequest, ListAgentsResponse> call);

        partial void Modify_SearchAgentsApiCall(ref gaxgrpc::ApiCall<SearchAgentsRequest, SearchAgentsResponse> call);

        partial void Modify_GetAgentApiCall(ref gaxgrpc::ApiCall<GetAgentRequest, Agent> call);

        partial void Modify_ListEndpointsApiCall(ref gaxgrpc::ApiCall<ListEndpointsRequest, ListEndpointsResponse> call);

        partial void Modify_GetEndpointApiCall(ref gaxgrpc::ApiCall<GetEndpointRequest, Endpoint> call);

        partial void Modify_ListMcpServersApiCall(ref gaxgrpc::ApiCall<ListMcpServersRequest, ListMcpServersResponse> call);

        partial void Modify_SearchMcpServersApiCall(ref gaxgrpc::ApiCall<SearchMcpServersRequest, SearchMcpServersResponse> call);

        partial void Modify_GetMcpServerApiCall(ref gaxgrpc::ApiCall<GetMcpServerRequest, McpServer> call);

        partial void Modify_ListServicesApiCall(ref gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> call);

        partial void Modify_GetServiceApiCall(ref gaxgrpc::ApiCall<GetServiceRequest, Service> call);

        partial void Modify_CreateServiceApiCall(ref gaxgrpc::ApiCall<CreateServiceRequest, lro::Operation> call);

        partial void Modify_UpdateServiceApiCall(ref gaxgrpc::ApiCall<UpdateServiceRequest, lro::Operation> call);

        partial void Modify_DeleteServiceApiCall(ref gaxgrpc::ApiCall<DeleteServiceRequest, lro::Operation> call);

        partial void Modify_ListBindingsApiCall(ref gaxgrpc::ApiCall<ListBindingsRequest, ListBindingsResponse> call);

        partial void Modify_GetBindingApiCall(ref gaxgrpc::ApiCall<GetBindingRequest, Binding> call);

        partial void Modify_CreateBindingApiCall(ref gaxgrpc::ApiCall<CreateBindingRequest, lro::Operation> call);

        partial void Modify_UpdateBindingApiCall(ref gaxgrpc::ApiCall<UpdateBindingRequest, lro::Operation> call);

        partial void Modify_DeleteBindingApiCall(ref gaxgrpc::ApiCall<DeleteBindingRequest, lro::Operation> call);

        partial void Modify_FetchAvailableBindingsApiCall(ref gaxgrpc::ApiCall<FetchAvailableBindingsRequest, FetchAvailableBindingsResponse> call);

        partial void OnConstruction(AgentRegistry.AgentRegistryClient grpcClient, AgentRegistrySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AgentRegistry client</summary>
        public override AgentRegistry.AgentRegistryClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListAgentsRequest(ref ListAgentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchAgentsRequest(ref SearchAgentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAgentRequest(ref GetAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEndpointsRequest(ref ListEndpointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEndpointRequest(ref GetEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMcpServersRequest(ref ListMcpServersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchMcpServersRequest(ref SearchMcpServersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMcpServerRequest(ref GetMcpServerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServicesRequest(ref ListServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceRequest(ref GetServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceRequest(ref CreateServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServiceRequest(ref UpdateServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceRequest(ref DeleteServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBindingsRequest(ref ListBindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBindingRequest(ref GetBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBindingRequest(ref CreateBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBindingRequest(ref UpdateBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBindingRequest(ref DeleteBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchAvailableBindingsRequest(ref FetchAvailableBindingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Agents in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public override gax::PagedEnumerable<ListAgentsResponse, Agent> ListAgents(ListAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAgentsRequest, ListAgentsResponse, Agent>(_callListAgents, request, callSettings);
        }

        /// <summary>
        /// Lists Agents in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAgentsResponse, Agent> ListAgentsAsync(ListAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAgentsRequest, ListAgentsResponse, Agent>(_callListAgents, request, callSettings);
        }

        /// <summary>
        /// Searches Agents in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public override gax::PagedEnumerable<SearchAgentsResponse, Agent> SearchAgents(SearchAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchAgentsRequest, SearchAgentsResponse, Agent>(_callSearchAgents, request, callSettings);
        }

        /// <summary>
        /// Searches Agents in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchAgentsResponse, Agent> SearchAgentsAsync(SearchAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchAgentsRequest, SearchAgentsResponse, Agent>(_callSearchAgents, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Agent GetAgent(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentRequest(ref request, ref callSettings);
            return _callGetAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Agent> GetAgentAsync(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentRequest(ref request, ref callSettings);
            return _callGetAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public override gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEndpointsRequest, ListEndpointsResponse, Endpoint>(_callListEndpoints, request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEndpointsRequest, ListEndpointsResponse, Endpoint>(_callListEndpoints, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Endpoint GetEndpoint(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEndpointRequest(ref request, ref callSettings);
            return _callGetEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Endpoint> GetEndpointAsync(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEndpointRequest(ref request, ref callSettings);
            return _callGetEndpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Lists McpServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public override gax::PagedEnumerable<ListMcpServersResponse, McpServer> ListMcpServers(ListMcpServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMcpServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMcpServersRequest, ListMcpServersResponse, McpServer>(_callListMcpServers, request, callSettings);
        }

        /// <summary>
        /// Lists McpServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMcpServersResponse, McpServer> ListMcpServersAsync(ListMcpServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMcpServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMcpServersRequest, ListMcpServersResponse, McpServer>(_callListMcpServers, request, callSettings);
        }

        /// <summary>
        /// Searches McpServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public override gax::PagedEnumerable<SearchMcpServersResponse, McpServer> SearchMcpServers(SearchMcpServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchMcpServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchMcpServersRequest, SearchMcpServersResponse, McpServer>(_callSearchMcpServers, request, callSettings);
        }

        /// <summary>
        /// Searches McpServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchMcpServersResponse, McpServer> SearchMcpServersAsync(SearchMcpServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchMcpServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchMcpServersRequest, SearchMcpServersResponse, McpServer>(_callSearchMcpServers, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override McpServer GetMcpServer(GetMcpServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMcpServerRequest(ref request, ref callSettings);
            return _callGetMcpServer.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<McpServer> GetMcpServerAsync(GetMcpServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMcpServerRequest(ref request, ref callSettings);
            return _callGetMcpServer.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateService</c>.</summary>
        public override lro::OperationsClient CreateServiceOperationsClient { get; }

        /// <summary>
        /// Creates a new Service in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Service, OperationMetadata> CreateService(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Service, OperationMetadata>(_callCreateService.Sync(request, callSettings), CreateServiceOperationsClient);
        }

        /// <summary>
        /// Creates a new Service in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Service, OperationMetadata>(await _callCreateService.Async(request, callSettings).ConfigureAwait(false), CreateServiceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateService</c>.</summary>
        public override lro::OperationsClient UpdateServiceOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Service, OperationMetadata> UpdateService(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Service, OperationMetadata>(_callUpdateService.Sync(request, callSettings), UpdateServiceOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Service, OperationMetadata>(await _callUpdateService.Async(request, callSettings).ConfigureAwait(false), UpdateServiceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteService</c>.</summary>
        public override lro::OperationsClient DeleteServiceOperationsClient { get; }

        /// <summary>
        /// Deletes a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteService(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteService.Sync(request, callSettings), DeleteServiceOperationsClient);
        }

        /// <summary>
        /// Deletes a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteService.Async(request, callSettings).ConfigureAwait(false), DeleteServiceOperationsClient);
        }

        /// <summary>
        /// Lists Bindings in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Binding"/> resources.</returns>
        public override gax::PagedEnumerable<ListBindingsResponse, Binding> ListBindings(ListBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBindingsRequest, ListBindingsResponse, Binding>(_callListBindings, request, callSettings);
        }

        /// <summary>
        /// Lists Bindings in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Binding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBindingsResponse, Binding> ListBindingsAsync(ListBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBindingsRequest, ListBindingsResponse, Binding>(_callListBindings, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Binding GetBinding(GetBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBindingRequest(ref request, ref callSettings);
            return _callGetBinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Binding> GetBindingAsync(GetBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBindingRequest(ref request, ref callSettings);
            return _callGetBinding.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateBinding</c>.</summary>
        public override lro::OperationsClient CreateBindingOperationsClient { get; }

        /// <summary>
        /// Creates a new Binding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Binding, OperationMetadata> CreateBinding(CreateBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBindingRequest(ref request, ref callSettings);
            return new lro::Operation<Binding, OperationMetadata>(_callCreateBinding.Sync(request, callSettings), CreateBindingOperationsClient);
        }

        /// <summary>
        /// Creates a new Binding in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Binding, OperationMetadata>> CreateBindingAsync(CreateBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBindingRequest(ref request, ref callSettings);
            return new lro::Operation<Binding, OperationMetadata>(await _callCreateBinding.Async(request, callSettings).ConfigureAwait(false), CreateBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateBinding</c>.</summary>
        public override lro::OperationsClient UpdateBindingOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Binding, OperationMetadata> UpdateBinding(UpdateBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBindingRequest(ref request, ref callSettings);
            return new lro::Operation<Binding, OperationMetadata>(_callUpdateBinding.Sync(request, callSettings), UpdateBindingOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Binding, OperationMetadata>> UpdateBindingAsync(UpdateBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBindingRequest(ref request, ref callSettings);
            return new lro::Operation<Binding, OperationMetadata>(await _callUpdateBinding.Async(request, callSettings).ConfigureAwait(false), UpdateBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteBinding</c>.</summary>
        public override lro::OperationsClient DeleteBindingOperationsClient { get; }

        /// <summary>
        /// Deletes a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteBinding(DeleteBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteBinding.Sync(request, callSettings), DeleteBindingOperationsClient);
        }

        /// <summary>
        /// Deletes a single Binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBindingAsync(DeleteBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBinding.Async(request, callSettings).ConfigureAwait(false), DeleteBindingOperationsClient);
        }

        /// <summary>
        /// Fetches available Bindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Binding"/> resources.</returns>
        public override gax::PagedEnumerable<FetchAvailableBindingsResponse, Binding> FetchAvailableBindings(FetchAvailableBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchAvailableBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchAvailableBindingsRequest, FetchAvailableBindingsResponse, Binding>(_callFetchAvailableBindings, request, callSettings);
        }

        /// <summary>
        /// Fetches available Bindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Binding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchAvailableBindingsResponse, Binding> FetchAvailableBindingsAsync(FetchAvailableBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchAvailableBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchAvailableBindingsRequest, FetchAvailableBindingsResponse, Binding>(_callFetchAvailableBindings, request, callSettings);
        }
    }

    public partial class ListAgentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchAgentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEndpointsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMcpServersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchMcpServersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchAvailableBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAgentsResponse : gaxgrpc::IPageResponse<Agent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Agent> GetEnumerator() => Agents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchAgentsResponse : gaxgrpc::IPageResponse<Agent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Agent> GetEnumerator() => Agents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEndpointsResponse : gaxgrpc::IPageResponse<Endpoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Endpoint> GetEnumerator() => Endpoints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMcpServersResponse : gaxgrpc::IPageResponse<McpServer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<McpServer> GetEnumerator() => McpServers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchMcpServersResponse : gaxgrpc::IPageResponse<McpServer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<McpServer> GetEnumerator() => McpServers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServicesResponse : gaxgrpc::IPageResponse<Service>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Service> GetEnumerator() => Services.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBindingsResponse : gaxgrpc::IPageResponse<Binding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Binding> GetEnumerator() => Bindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchAvailableBindingsResponse : gaxgrpc::IPageResponse<Binding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Binding> GetEnumerator() => Bindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AgentRegistry
    {
        public partial class AgentRegistryClient
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

    public static partial class AgentRegistry
    {
        public partial class AgentRegistryClient
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
