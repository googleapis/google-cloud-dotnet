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
            CreateSkillSettings = existing.CreateSkillSettings;
            CreateSkillOperationsSettings = existing.CreateSkillOperationsSettings.Clone();
            GetSkillSettings = existing.GetSkillSettings;
            UpdateSkillSettings = existing.UpdateSkillSettings;
            UpdateSkillOperationsSettings = existing.UpdateSkillOperationsSettings.Clone();
            DeleteSkillSettings = existing.DeleteSkillSettings;
            DeleteSkillOperationsSettings = existing.DeleteSkillOperationsSettings.Clone();
            ListSkillsSettings = existing.ListSkillsSettings;
            SearchSkillsSettings = existing.SearchSkillsSettings;
            CreateSkillRevisionSettings = existing.CreateSkillRevisionSettings;
            CreateSkillRevisionOperationsSettings = existing.CreateSkillRevisionOperationsSettings.Clone();
            GetSkillRevisionSettings = existing.GetSkillRevisionSettings;
            DeleteSkillRevisionSettings = existing.DeleteSkillRevisionSettings;
            DeleteSkillRevisionOperationsSettings = existing.DeleteSkillRevisionOperationsSettings.Clone();
            ListSkillRevisionsSettings = existing.ListSkillRevisionsSettings;
            GetPublisherSettings = existing.GetPublisherSettings;
            ListPublishersSettings = existing.ListPublishersSettings;
            GetAiApplicationSettings = existing.GetAiApplicationSettings;
            ListAiApplicationsSettings = existing.ListAiApplicationsSettings;
            GetAiApplicationAgentSettings = existing.GetAiApplicationAgentSettings;
            ListAiApplicationAgentsSettings = existing.ListAiApplicationAgentsSettings;
            GetAiApplicationMcpServerSettings = existing.GetAiApplicationMcpServerSettings;
            ListAiApplicationMcpServersSettings = existing.ListAiApplicationMcpServersSettings;
            GetFindingSettings = existing.GetFindingSettings;
            ListFindingsSettings = existing.ListFindingsSettings;
            GetAiApplicationEndpointSettings = existing.GetAiApplicationEndpointSettings;
            ListAiApplicationEndpointsSettings = existing.ListAiApplicationEndpointsSettings;
            GetSkillEncryptionSpecSettings = existing.GetSkillEncryptionSpecSettings;
            UpdateSkillEncryptionSpecSettings = existing.UpdateSkillEncryptionSpecSettings;
            UpdateSkillEncryptionSpecOperationsSettings = existing.UpdateSkillEncryptionSpecOperationsSettings.Clone();
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.CreateSkill</c> and <c>AgentRegistryClient.CreateSkillAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSkillSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentRegistryClient.CreateSkill</c> and
        /// <c>AgentRegistryClient.CreateSkillAsync</c>.
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
        public lro::OperationsSettings CreateSkillOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetSkill</c> and <c>AgentRegistryClient.GetSkillAsync</c>.
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
        public gaxgrpc::CallSettings GetSkillSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.UpdateSkill</c> and <c>AgentRegistryClient.UpdateSkillAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSkillSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentRegistryClient.UpdateSkill</c> and
        /// <c>AgentRegistryClient.UpdateSkillAsync</c>.
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
        public lro::OperationsSettings UpdateSkillOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.DeleteSkill</c> and <c>AgentRegistryClient.DeleteSkillAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSkillSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentRegistryClient.DeleteSkill</c> and
        /// <c>AgentRegistryClient.DeleteSkillAsync</c>.
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
        public lro::OperationsSettings DeleteSkillOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.ListSkills</c> and <c>AgentRegistryClient.ListSkillsAsync</c>.
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
        public gaxgrpc::CallSettings ListSkillsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.SearchSkills</c> and <c>AgentRegistryClient.SearchSkillsAsync</c>.
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
        public gaxgrpc::CallSettings SearchSkillsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.CreateSkillRevision</c> and <c>AgentRegistryClient.CreateSkillRevisionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSkillRevisionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentRegistryClient.CreateSkillRevision</c> and
        /// <c>AgentRegistryClient.CreateSkillRevisionAsync</c>.
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
        public lro::OperationsSettings CreateSkillRevisionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetSkillRevision</c> and <c>AgentRegistryClient.GetSkillRevisionAsync</c>.
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
        public gaxgrpc::CallSettings GetSkillRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.DeleteSkillRevision</c> and <c>AgentRegistryClient.DeleteSkillRevisionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSkillRevisionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentRegistryClient.DeleteSkillRevision</c> and
        /// <c>AgentRegistryClient.DeleteSkillRevisionAsync</c>.
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
        public lro::OperationsSettings DeleteSkillRevisionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.ListSkillRevisions</c> and <c>AgentRegistryClient.ListSkillRevisionsAsync</c>.
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
        public gaxgrpc::CallSettings ListSkillRevisionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetPublisher</c> and <c>AgentRegistryClient.GetPublisherAsync</c>.
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
        public gaxgrpc::CallSettings GetPublisherSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.ListPublishers</c> and <c>AgentRegistryClient.ListPublishersAsync</c>.
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
        public gaxgrpc::CallSettings ListPublishersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetAiApplication</c> and <c>AgentRegistryClient.GetAiApplicationAsync</c>.
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
        public gaxgrpc::CallSettings GetAiApplicationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.ListAiApplications</c> and <c>AgentRegistryClient.ListAiApplicationsAsync</c>.
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
        public gaxgrpc::CallSettings ListAiApplicationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetAiApplicationAgent</c> and <c>AgentRegistryClient.GetAiApplicationAgentAsync</c>.
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
        public gaxgrpc::CallSettings GetAiApplicationAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.ListAiApplicationAgents</c> and <c>AgentRegistryClient.ListAiApplicationAgentsAsync</c>
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
        public gaxgrpc::CallSettings ListAiApplicationAgentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetAiApplicationMcpServer</c> and
        /// <c>AgentRegistryClient.GetAiApplicationMcpServerAsync</c>.
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
        public gaxgrpc::CallSettings GetAiApplicationMcpServerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.ListAiApplicationMcpServers</c> and
        /// <c>AgentRegistryClient.ListAiApplicationMcpServersAsync</c>.
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
        public gaxgrpc::CallSettings ListAiApplicationMcpServersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetFinding</c> and <c>AgentRegistryClient.GetFindingAsync</c>.
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
        public gaxgrpc::CallSettings GetFindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.ListFindings</c> and <c>AgentRegistryClient.ListFindingsAsync</c>.
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
        public gaxgrpc::CallSettings ListFindingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetAiApplicationEndpoint</c> and <c>AgentRegistryClient.GetAiApplicationEndpointAsync</c>
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
        public gaxgrpc::CallSettings GetAiApplicationEndpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.ListAiApplicationEndpoints</c> and
        /// <c>AgentRegistryClient.ListAiApplicationEndpointsAsync</c>.
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
        public gaxgrpc::CallSettings ListAiApplicationEndpointsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.GetSkillEncryptionSpec</c> and <c>AgentRegistryClient.GetSkillEncryptionSpecAsync</c>
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
        public gaxgrpc::CallSettings GetSkillEncryptionSpecSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentRegistryClient.UpdateSkillEncryptionSpec</c> and
        /// <c>AgentRegistryClient.UpdateSkillEncryptionSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSkillEncryptionSpecSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentRegistryClient.UpdateSkillEncryptionSpec</c> and
        /// <c>AgentRegistryClient.UpdateSkillEncryptionSpecAsync</c>.
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
        public lro::OperationsSettings UpdateSkillEncryptionSpecOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

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
    /// Service for managing Agent Registry resources.
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

        /// <summary>
        /// =========================================================================
        /// # Skills Collection APIs
        /// 
        /// Creates a Skill resource container, optionally publishing the initial
        /// SkillRevision inline in a single, atomic CRUD roundtrip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Skill, OperationMetadata> CreateSkill(CreateSkillRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// =========================================================================
        /// # Skills Collection APIs
        /// 
        /// Creates a Skill resource container, optionally publishing the initial
        /// SkillRevision inline in a single, atomic CRUD roundtrip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Skill, OperationMetadata>> CreateSkillAsync(CreateSkillRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// =========================================================================
        /// # Skills Collection APIs
        /// 
        /// Creates a Skill resource container, optionally publishing the initial
        /// SkillRevision inline in a single, atomic CRUD roundtrip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Skill, OperationMetadata>> CreateSkillAsync(CreateSkillRequest request, st::CancellationToken cancellationToken) =>
            CreateSkillAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSkill</c>.</summary>
        public virtual lro::OperationsClient CreateSkillOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSkill</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Skill, OperationMetadata> PollOnceCreateSkill(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Skill, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSkillOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSkill</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Skill, OperationMetadata>> PollOnceCreateSkillAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Skill, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSkillOperationsClient, callSettings);

        /// <summary>
        /// =========================================================================
        /// # Skills Collection APIs
        /// 
        /// Creates a Skill resource container, optionally publishing the initial
        /// SkillRevision inline in a single, atomic CRUD roundtrip.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location location to bootstrap.
        /// </param>
        /// <param name="skill">
        /// Required. Skill container body config.
        /// </param>
        /// <param name="skillId">
        /// Required. Custom, user-defined unique container identifier.
        /// Must be unique within the parent project and location.
        /// This value should be 4-64 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Skill, OperationMetadata> CreateSkill(string parent, Skill skill, string skillId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSkill(new CreateSkillRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SkillId = gax::GaxPreconditions.CheckNotNullOrEmpty(skillId, nameof(skillId)),
                Skill = gax::GaxPreconditions.CheckNotNull(skill, nameof(skill)),
            }, callSettings);

        /// <summary>
        /// =========================================================================
        /// # Skills Collection APIs
        /// 
        /// Creates a Skill resource container, optionally publishing the initial
        /// SkillRevision inline in a single, atomic CRUD roundtrip.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location location to bootstrap.
        /// </param>
        /// <param name="skill">
        /// Required. Skill container body config.
        /// </param>
        /// <param name="skillId">
        /// Required. Custom, user-defined unique container identifier.
        /// Must be unique within the parent project and location.
        /// This value should be 4-64 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Skill, OperationMetadata>> CreateSkillAsync(string parent, Skill skill, string skillId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSkillAsync(new CreateSkillRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SkillId = gax::GaxPreconditions.CheckNotNullOrEmpty(skillId, nameof(skillId)),
                Skill = gax::GaxPreconditions.CheckNotNull(skill, nameof(skill)),
            }, callSettings);

        /// <summary>
        /// =========================================================================
        /// # Skills Collection APIs
        /// 
        /// Creates a Skill resource container, optionally publishing the initial
        /// SkillRevision inline in a single, atomic CRUD roundtrip.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location location to bootstrap.
        /// </param>
        /// <param name="skill">
        /// Required. Skill container body config.
        /// </param>
        /// <param name="skillId">
        /// Required. Custom, user-defined unique container identifier.
        /// Must be unique within the parent project and location.
        /// This value should be 4-64 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Skill, OperationMetadata>> CreateSkillAsync(string parent, Skill skill, string skillId, st::CancellationToken cancellationToken) =>
            CreateSkillAsync(parent, skill, skillId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// =========================================================================
        /// # Skills Collection APIs
        /// 
        /// Creates a Skill resource container, optionally publishing the initial
        /// SkillRevision inline in a single, atomic CRUD roundtrip.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location location to bootstrap.
        /// </param>
        /// <param name="skill">
        /// Required. Skill container body config.
        /// </param>
        /// <param name="skillId">
        /// Required. Custom, user-defined unique container identifier.
        /// Must be unique within the parent project and location.
        /// This value should be 4-64 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Skill, OperationMetadata> CreateSkill(gagr::LocationName parent, Skill skill, string skillId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSkill(new CreateSkillRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SkillId = gax::GaxPreconditions.CheckNotNullOrEmpty(skillId, nameof(skillId)),
                Skill = gax::GaxPreconditions.CheckNotNull(skill, nameof(skill)),
            }, callSettings);

        /// <summary>
        /// =========================================================================
        /// # Skills Collection APIs
        /// 
        /// Creates a Skill resource container, optionally publishing the initial
        /// SkillRevision inline in a single, atomic CRUD roundtrip.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location location to bootstrap.
        /// </param>
        /// <param name="skill">
        /// Required. Skill container body config.
        /// </param>
        /// <param name="skillId">
        /// Required. Custom, user-defined unique container identifier.
        /// Must be unique within the parent project and location.
        /// This value should be 4-64 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Skill, OperationMetadata>> CreateSkillAsync(gagr::LocationName parent, Skill skill, string skillId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSkillAsync(new CreateSkillRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SkillId = gax::GaxPreconditions.CheckNotNullOrEmpty(skillId, nameof(skillId)),
                Skill = gax::GaxPreconditions.CheckNotNull(skill, nameof(skill)),
            }, callSettings);

        /// <summary>
        /// =========================================================================
        /// # Skills Collection APIs
        /// 
        /// Creates a Skill resource container, optionally publishing the initial
        /// SkillRevision inline in a single, atomic CRUD roundtrip.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location location to bootstrap.
        /// </param>
        /// <param name="skill">
        /// Required. Skill container body config.
        /// </param>
        /// <param name="skillId">
        /// Required. Custom, user-defined unique container identifier.
        /// Must be unique within the parent project and location.
        /// This value should be 4-64 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Skill, OperationMetadata>> CreateSkillAsync(gagr::LocationName parent, Skill skill, string skillId, st::CancellationToken cancellationToken) =>
            CreateSkillAsync(parent, skill, skillId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches the active configuration and metadata of a Skill.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Skill GetSkill(GetSkillRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches the active configuration and metadata of a Skill.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Skill> GetSkillAsync(GetSkillRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches the active configuration and metadata of a Skill.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Skill> GetSkillAsync(GetSkillRequest request, st::CancellationToken cancellationToken) =>
            GetSkillAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches the active configuration and metadata of a Skill.
        /// </summary>
        /// <param name="name">
        /// Required. Target resource container name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Skill GetSkill(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkill(new GetSkillRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the active configuration and metadata of a Skill.
        /// </summary>
        /// <param name="name">
        /// Required. Target resource container name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Skill> GetSkillAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkillAsync(new GetSkillRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the active configuration and metadata of a Skill.
        /// </summary>
        /// <param name="name">
        /// Required. Target resource container name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Skill> GetSkillAsync(string name, st::CancellationToken cancellationToken) =>
            GetSkillAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches the active configuration and metadata of a Skill.
        /// </summary>
        /// <param name="name">
        /// Required. Target resource container name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Skill GetSkill(SkillName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkill(new GetSkillRequest
            {
                SkillName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the active configuration and metadata of a Skill.
        /// </summary>
        /// <param name="name">
        /// Required. Target resource container name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Skill> GetSkillAsync(SkillName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkillAsync(new GetSkillRequest
            {
                SkillName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the active configuration and metadata of a Skill.
        /// </summary>
        /// <param name="name">
        /// Required. Target resource container name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Skill> GetSkillAsync(SkillName name, st::CancellationToken cancellationToken) =>
            GetSkillAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates Skill metadata or overrides active pointers/state using REST
        /// standard PATCH.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Skill, OperationMetadata> UpdateSkill(UpdateSkillRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates Skill metadata or overrides active pointers/state using REST
        /// standard PATCH.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Skill, OperationMetadata>> UpdateSkillAsync(UpdateSkillRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates Skill metadata or overrides active pointers/state using REST
        /// standard PATCH.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Skill, OperationMetadata>> UpdateSkillAsync(UpdateSkillRequest request, st::CancellationToken cancellationToken) =>
            UpdateSkillAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSkill</c>.</summary>
        public virtual lro::OperationsClient UpdateSkillOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSkill</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Skill, OperationMetadata> PollOnceUpdateSkill(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Skill, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSkillOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSkill</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Skill, OperationMetadata>> PollOnceUpdateSkillAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Skill, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSkillOperationsClient, callSettings);

        /// <summary>
        /// Updates Skill metadata or overrides active pointers/state using REST
        /// standard PATCH.
        /// </summary>
        /// <param name="skill">
        /// Required. Mutable Skill container config fields to write.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Standard update target mask mapping relative fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Skill, OperationMetadata> UpdateSkill(Skill skill, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSkill(new UpdateSkillRequest
            {
                Skill = gax::GaxPreconditions.CheckNotNull(skill, nameof(skill)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates Skill metadata or overrides active pointers/state using REST
        /// standard PATCH.
        /// </summary>
        /// <param name="skill">
        /// Required. Mutable Skill container config fields to write.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Standard update target mask mapping relative fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Skill, OperationMetadata>> UpdateSkillAsync(Skill skill, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSkillAsync(new UpdateSkillRequest
            {
                Skill = gax::GaxPreconditions.CheckNotNull(skill, nameof(skill)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates Skill metadata or overrides active pointers/state using REST
        /// standard PATCH.
        /// </summary>
        /// <param name="skill">
        /// Required. Mutable Skill container config fields to write.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Standard update target mask mapping relative fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Skill, OperationMetadata>> UpdateSkillAsync(Skill skill, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSkillAsync(skill, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Skill container along with all its revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSkill(DeleteSkillRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Skill container along with all its revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillAsync(DeleteSkillRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Skill container along with all its revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillAsync(DeleteSkillRequest request, st::CancellationToken cancellationToken) =>
            DeleteSkillAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSkill</c>.</summary>
        public virtual lro::OperationsClient DeleteSkillOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSkill</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSkill(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSkillOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSkill</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSkillAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSkillOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Skill container along with all its revisions.
        /// </summary>
        /// <param name="name">
        /// Required. Target Skill container name to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSkill(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSkill(new DeleteSkillRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Skill container along with all its revisions.
        /// </summary>
        /// <param name="name">
        /// Required. Target Skill container name to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSkillAsync(new DeleteSkillRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Skill container along with all its revisions.
        /// </summary>
        /// <param name="name">
        /// Required. Target Skill container name to remove.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSkillAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Skill container along with all its revisions.
        /// </summary>
        /// <param name="name">
        /// Required. Target Skill container name to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSkill(SkillName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSkill(new DeleteSkillRequest
            {
                SkillName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Skill container along with all its revisions.
        /// </summary>
        /// <param name="name">
        /// Required. Target Skill container name to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillAsync(SkillName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSkillAsync(new DeleteSkillRequest
            {
                SkillName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Skill container along with all its revisions.
        /// </summary>
        /// <param name="name">
        /// Required. Target Skill container name to remove.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillAsync(SkillName name, st::CancellationToken cancellationToken) =>
            DeleteSkillAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists logical Skills available in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Skill"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkillsResponse, Skill> ListSkills(ListSkillsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists logical Skills available in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Skill"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkillsResponse, Skill> ListSkillsAsync(ListSkillsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists logical Skills available in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSkillsRequest
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
        /// <returns>A pageable sequence of <see cref="Skill"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkillsResponse, Skill> ListSkills(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkillsRequest request = new ListSkillsRequest
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
            return ListSkills(request, callSettings);
        }

        /// <summary>
        /// Lists logical Skills available in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSkillsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Skill"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkillsResponse, Skill> ListSkillsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkillsRequest request = new ListSkillsRequest
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
            return ListSkillsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists logical Skills available in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSkillsRequest
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
        /// <returns>A pageable sequence of <see cref="Skill"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkillsResponse, Skill> ListSkills(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkillsRequest request = new ListSkillsRequest
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
            return ListSkills(request, callSettings);
        }

        /// <summary>
        /// Lists logical Skills available in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSkillsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Skill"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkillsResponse, Skill> ListSkillsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkillsRequest request = new ListSkillsRequest
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
            return ListSkillsAsync(request, callSettings);
        }

        /// <summary>
        /// Custom deep-search method to filter by frontmatter or query SKILL.md text
        /// blobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Skill"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchSkillsResponse, Skill> SearchSkills(SearchSkillsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Custom deep-search method to filter by frontmatter or query SKILL.md text
        /// blobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Skill"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchSkillsResponse, Skill> SearchSkillsAsync(SearchSkillsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new immutable revision and triggers validation pipelines.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SkillRevision, OperationMetadata> CreateSkillRevision(CreateSkillRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new immutable revision and triggers validation pipelines.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SkillRevision, OperationMetadata>> CreateSkillRevisionAsync(CreateSkillRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new immutable revision and triggers validation pipelines.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SkillRevision, OperationMetadata>> CreateSkillRevisionAsync(CreateSkillRevisionRequest request, st::CancellationToken cancellationToken) =>
            CreateSkillRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSkillRevision</c>.</summary>
        public virtual lro::OperationsClient CreateSkillRevisionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSkillRevision</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SkillRevision, OperationMetadata> PollOnceCreateSkillRevision(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SkillRevision, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSkillRevisionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSkillRevision</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SkillRevision, OperationMetadata>> PollOnceCreateSkillRevisionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SkillRevision, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSkillRevisionOperationsClient, callSettings);

        /// <summary>
        /// Creates a new immutable revision and triggers validation pipelines.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical container name.
        /// </param>
        /// <param name="skillRevision">
        /// Required. Immutable SkillRevision snapshot definition schema.
        /// </param>
        /// <param name="skillRevisionId">
        /// Optional. Custom, user-defined unique revision identifier.
        /// Format: 4-63 characters, matching regex `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SkillRevision, OperationMetadata> CreateSkillRevision(string parent, SkillRevision skillRevision, string skillRevisionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSkillRevision(new CreateSkillRevisionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SkillRevision = gax::GaxPreconditions.CheckNotNull(skillRevision, nameof(skillRevision)),
                SkillRevisionId = skillRevisionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new immutable revision and triggers validation pipelines.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical container name.
        /// </param>
        /// <param name="skillRevision">
        /// Required. Immutable SkillRevision snapshot definition schema.
        /// </param>
        /// <param name="skillRevisionId">
        /// Optional. Custom, user-defined unique revision identifier.
        /// Format: 4-63 characters, matching regex `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SkillRevision, OperationMetadata>> CreateSkillRevisionAsync(string parent, SkillRevision skillRevision, string skillRevisionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSkillRevisionAsync(new CreateSkillRevisionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SkillRevision = gax::GaxPreconditions.CheckNotNull(skillRevision, nameof(skillRevision)),
                SkillRevisionId = skillRevisionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new immutable revision and triggers validation pipelines.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical container name.
        /// </param>
        /// <param name="skillRevision">
        /// Required. Immutable SkillRevision snapshot definition schema.
        /// </param>
        /// <param name="skillRevisionId">
        /// Optional. Custom, user-defined unique revision identifier.
        /// Format: 4-63 characters, matching regex `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SkillRevision, OperationMetadata>> CreateSkillRevisionAsync(string parent, SkillRevision skillRevision, string skillRevisionId, st::CancellationToken cancellationToken) =>
            CreateSkillRevisionAsync(parent, skillRevision, skillRevisionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new immutable revision and triggers validation pipelines.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical container name.
        /// </param>
        /// <param name="skillRevision">
        /// Required. Immutable SkillRevision snapshot definition schema.
        /// </param>
        /// <param name="skillRevisionId">
        /// Optional. Custom, user-defined unique revision identifier.
        /// Format: 4-63 characters, matching regex `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SkillRevision, OperationMetadata> CreateSkillRevision(SkillName parent, SkillRevision skillRevision, string skillRevisionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSkillRevision(new CreateSkillRevisionRequest
            {
                ParentAsSkillName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SkillRevision = gax::GaxPreconditions.CheckNotNull(skillRevision, nameof(skillRevision)),
                SkillRevisionId = skillRevisionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new immutable revision and triggers validation pipelines.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical container name.
        /// </param>
        /// <param name="skillRevision">
        /// Required. Immutable SkillRevision snapshot definition schema.
        /// </param>
        /// <param name="skillRevisionId">
        /// Optional. Custom, user-defined unique revision identifier.
        /// Format: 4-63 characters, matching regex `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SkillRevision, OperationMetadata>> CreateSkillRevisionAsync(SkillName parent, SkillRevision skillRevision, string skillRevisionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSkillRevisionAsync(new CreateSkillRevisionRequest
            {
                ParentAsSkillName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SkillRevision = gax::GaxPreconditions.CheckNotNull(skillRevision, nameof(skillRevision)),
                SkillRevisionId = skillRevisionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new immutable revision and triggers validation pipelines.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical container name.
        /// </param>
        /// <param name="skillRevision">
        /// Required. Immutable SkillRevision snapshot definition schema.
        /// </param>
        /// <param name="skillRevisionId">
        /// Optional. Custom, user-defined unique revision identifier.
        /// Format: 4-63 characters, matching regex `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SkillRevision, OperationMetadata>> CreateSkillRevisionAsync(SkillName parent, SkillRevision skillRevision, string skillRevisionId, st::CancellationToken cancellationToken) =>
            CreateSkillRevisionAsync(parent, skillRevision, skillRevisionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single immutable Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SkillRevision GetSkillRevision(GetSkillRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single immutable Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkillRevision> GetSkillRevisionAsync(GetSkillRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single immutable Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkillRevision> GetSkillRevisionAsync(GetSkillRevisionRequest request, st::CancellationToken cancellationToken) =>
            GetSkillRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single immutable Revision.
        /// </summary>
        /// <param name="name">
        /// Required. Target revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SkillRevision GetSkillRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkillRevision(new GetSkillRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single immutable Revision.
        /// </summary>
        /// <param name="name">
        /// Required. Target revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkillRevision> GetSkillRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkillRevisionAsync(new GetSkillRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single immutable Revision.
        /// </summary>
        /// <param name="name">
        /// Required. Target revision name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkillRevision> GetSkillRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            GetSkillRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single immutable Revision.
        /// </summary>
        /// <param name="name">
        /// Required. Target revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SkillRevision GetSkillRevision(SkillRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkillRevision(new GetSkillRevisionRequest
            {
                SkillRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single immutable Revision.
        /// </summary>
        /// <param name="name">
        /// Required. Target revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkillRevision> GetSkillRevisionAsync(SkillRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkillRevisionAsync(new GetSkillRevisionRequest
            {
                SkillRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single immutable Revision.
        /// </summary>
        /// <param name="name">
        /// Required. Target revision name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkillRevision> GetSkillRevisionAsync(SkillRevisionName name, st::CancellationToken cancellationToken) =>
            GetSkillRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific revision (restricted to admins to purge accidentally
        /// committed secrets).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSkillRevision(DeleteSkillRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific revision (restricted to admins to purge accidentally
        /// committed secrets).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillRevisionAsync(DeleteSkillRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific revision (restricted to admins to purge accidentally
        /// committed secrets).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillRevisionAsync(DeleteSkillRevisionRequest request, st::CancellationToken cancellationToken) =>
            DeleteSkillRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSkillRevision</c>.</summary>
        public virtual lro::OperationsClient DeleteSkillRevisionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSkillRevision</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSkillRevision(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSkillRevisionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSkillRevision</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSkillRevisionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSkillRevisionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific revision (restricted to admins to purge accidentally
        /// committed secrets).
        /// </summary>
        /// <param name="name">
        /// Required. Target revision name to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSkillRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSkillRevision(new DeleteSkillRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific revision (restricted to admins to purge accidentally
        /// committed secrets).
        /// </summary>
        /// <param name="name">
        /// Required. Target revision name to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSkillRevisionAsync(new DeleteSkillRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific revision (restricted to admins to purge accidentally
        /// committed secrets).
        /// </summary>
        /// <param name="name">
        /// Required. Target revision name to remove.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSkillRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific revision (restricted to admins to purge accidentally
        /// committed secrets).
        /// </summary>
        /// <param name="name">
        /// Required. Target revision name to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSkillRevision(SkillRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSkillRevision(new DeleteSkillRevisionRequest
            {
                SkillRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific revision (restricted to admins to purge accidentally
        /// committed secrets).
        /// </summary>
        /// <param name="name">
        /// Required. Target revision name to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillRevisionAsync(SkillRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSkillRevisionAsync(new DeleteSkillRevisionRequest
            {
                SkillRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific revision (restricted to admins to purge accidentally
        /// committed secrets).
        /// </summary>
        /// <param name="name">
        /// Required. Target revision name to remove.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillRevisionAsync(SkillRevisionName name, st::CancellationToken cancellationToken) =>
            DeleteSkillRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all revisions belonging to a parent Skill.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SkillRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkillRevisionsResponse, SkillRevision> ListSkillRevisions(ListSkillRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all revisions belonging to a parent Skill.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SkillRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkillRevisionsResponse, SkillRevision> ListSkillRevisionsAsync(ListSkillRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all revisions belonging to a parent Skill.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical container name to query.
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
        /// <returns>A pageable sequence of <see cref="SkillRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkillRevisionsResponse, SkillRevision> ListSkillRevisions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkillRevisionsRequest request = new ListSkillRevisionsRequest
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
            return ListSkillRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists all revisions belonging to a parent Skill.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical container name to query.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SkillRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkillRevisionsResponse, SkillRevision> ListSkillRevisionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkillRevisionsRequest request = new ListSkillRevisionsRequest
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
            return ListSkillRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all revisions belonging to a parent Skill.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical container name to query.
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
        /// <returns>A pageable sequence of <see cref="SkillRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkillRevisionsResponse, SkillRevision> ListSkillRevisions(SkillName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkillRevisionsRequest request = new ListSkillRevisionsRequest
            {
                ParentAsSkillName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSkillRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists all revisions belonging to a parent Skill.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical container name to query.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SkillRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkillRevisionsResponse, SkillRevision> ListSkillRevisionsAsync(SkillName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkillRevisionsRequest request = new ListSkillRevisionsRequest
            {
                ParentAsSkillName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSkillRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches details of a specific Publisher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Publisher GetPublisher(GetPublisherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches details of a specific Publisher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Publisher> GetPublisherAsync(GetPublisherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches details of a specific Publisher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Publisher> GetPublisherAsync(GetPublisherRequest request, st::CancellationToken cancellationToken) =>
            GetPublisherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches details of a specific Publisher.
        /// </summary>
        /// <param name="name">
        /// Required. Target publisher resource name.
        /// Format: `projects/{project}/locations/{location}/publishers/{publisher}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Publisher GetPublisher(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublisher(new GetPublisherRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches details of a specific Publisher.
        /// </summary>
        /// <param name="name">
        /// Required. Target publisher resource name.
        /// Format: `projects/{project}/locations/{location}/publishers/{publisher}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Publisher> GetPublisherAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublisherAsync(new GetPublisherRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches details of a specific Publisher.
        /// </summary>
        /// <param name="name">
        /// Required. Target publisher resource name.
        /// Format: `projects/{project}/locations/{location}/publishers/{publisher}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Publisher> GetPublisherAsync(string name, st::CancellationToken cancellationToken) =>
            GetPublisherAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches details of a specific Publisher.
        /// </summary>
        /// <param name="name">
        /// Required. Target publisher resource name.
        /// Format: `projects/{project}/locations/{location}/publishers/{publisher}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Publisher GetPublisher(PublisherName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublisher(new GetPublisherRequest
            {
                PublisherName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches details of a specific Publisher.
        /// </summary>
        /// <param name="name">
        /// Required. Target publisher resource name.
        /// Format: `projects/{project}/locations/{location}/publishers/{publisher}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Publisher> GetPublisherAsync(PublisherName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublisherAsync(new GetPublisherRequest
            {
                PublisherName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches details of a specific Publisher.
        /// </summary>
        /// <param name="name">
        /// Required. Target publisher resource name.
        /// Format: `projects/{project}/locations/{location}/publishers/{publisher}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Publisher> GetPublisherAsync(PublisherName name, st::CancellationToken cancellationToken) =>
            GetPublisherAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all Publishers in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Publisher"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPublishersResponse, Publisher> ListPublishers(ListPublishersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Publishers in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Publisher"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPublishersResponse, Publisher> ListPublishersAsync(ListPublishersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Publishers in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent location to query.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Publisher"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPublishersResponse, Publisher> ListPublishers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublishersRequest request = new ListPublishersRequest
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
            return ListPublishers(request, callSettings);
        }

        /// <summary>
        /// Lists all Publishers in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent location to query.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Publisher"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPublishersResponse, Publisher> ListPublishersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublishersRequest request = new ListPublishersRequest
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
            return ListPublishersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Publishers in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent location to query.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Publisher"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPublishersResponse, Publisher> ListPublishers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublishersRequest request = new ListPublishersRequest
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
            return ListPublishers(request, callSettings);
        }

        /// <summary>
        /// Lists all Publishers in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent location to query.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Publisher"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPublishersResponse, Publisher> ListPublishersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublishersRequest request = new ListPublishersRequest
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
            return ListPublishersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AiApplication GetAiApplication(GetAiApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AiApplication> GetAiApplicationAsync(GetAiApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AiApplication> GetAiApplicationAsync(GetAiApplicationRequest request, st::CancellationToken cancellationToken) =>
            GetAiApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Target AI Application resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AiApplication GetAiApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplication(new GetAiApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Target AI Application resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AiApplication> GetAiApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationAsync(new GetAiApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Target AI Application resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AiApplication> GetAiApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            GetAiApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Target AI Application resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AiApplication GetAiApplication(AiApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplication(new GetAiApplicationRequest
            {
                AiApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Target AI Application resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AiApplication> GetAiApplicationAsync(AiApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationAsync(new GetAiApplicationRequest
            {
                AiApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Target AI Application resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AiApplication> GetAiApplicationAsync(AiApplicationName name, st::CancellationToken cancellationToken) =>
            GetAiApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists AI Applications in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AiApplication"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAiApplicationsResponse, AiApplication> ListAiApplications(ListAiApplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AI Applications in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AiApplication"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAiApplicationsResponse, AiApplication> ListAiApplicationsAsync(ListAiApplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AI Applications in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project and location to query.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="AiApplication"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAiApplicationsResponse, AiApplication> ListAiApplications(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationsRequest request = new ListAiApplicationsRequest
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
            return ListAiApplications(request, callSettings);
        }

        /// <summary>
        /// Lists AI Applications in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project and location to query.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AiApplication"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAiApplicationsResponse, AiApplication> ListAiApplicationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationsRequest request = new ListAiApplicationsRequest
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
            return ListAiApplicationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists AI Applications in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project and location to query.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="AiApplication"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAiApplicationsResponse, AiApplication> ListAiApplications(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationsRequest request = new ListAiApplicationsRequest
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
            return ListAiApplications(request, callSettings);
        }

        /// <summary>
        /// Lists AI Applications in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project and location to query.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AiApplication"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAiApplicationsResponse, AiApplication> ListAiApplicationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationsRequest request = new ListAiApplicationsRequest
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
            return ListAiApplicationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Agent under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAiApplicationAgent(GetAiApplicationAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Agent under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAiApplicationAgentAsync(GetAiApplicationAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Agent under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAiApplicationAgentAsync(GetAiApplicationAgentRequest request, st::CancellationToken cancellationToken) =>
            GetAiApplicationAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Agent under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/agents/{agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAiApplicationAgent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationAgent(new GetAiApplicationAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Agent under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/agents/{agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAiApplicationAgentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationAgentAsync(new GetAiApplicationAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Agent under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/agents/{agent}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAiApplicationAgentAsync(string name, st::CancellationToken cancellationToken) =>
            GetAiApplicationAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Agent under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/agents/{agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAiApplicationAgent(AgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationAgent(new GetAiApplicationAgentRequest
            {
                AgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Agent under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/agents/{agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAiApplicationAgentAsync(AgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationAgentAsync(new GetAiApplicationAgentRequest
            {
                AgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Agent under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/agents/{agent}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAiApplicationAgentAsync(AgentName name, st::CancellationToken cancellationToken) =>
            GetAiApplicationAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Agents under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAiApplicationAgentsResponse, Agent> ListAiApplicationAgents(ListAiApplicationAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Agents under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAiApplicationAgentsResponse, Agent> ListAiApplicationAgentsAsync(ListAiApplicationAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Agents under an AI Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (AI Application) for ListAiApplicationAgentsRequest.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
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
        public virtual gax::PagedEnumerable<ListAiApplicationAgentsResponse, Agent> ListAiApplicationAgents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationAgentsRequest request = new ListAiApplicationAgentsRequest
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
            return ListAiApplicationAgents(request, callSettings);
        }

        /// <summary>
        /// Lists Agents under an AI Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (AI Application) for ListAiApplicationAgentsRequest.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
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
        public virtual gax::PagedAsyncEnumerable<ListAiApplicationAgentsResponse, Agent> ListAiApplicationAgentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationAgentsRequest request = new ListAiApplicationAgentsRequest
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
            return ListAiApplicationAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Agents under an AI Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (AI Application) for ListAiApplicationAgentsRequest.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
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
        public virtual gax::PagedEnumerable<ListAiApplicationAgentsResponse, Agent> ListAiApplicationAgents(AiApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationAgentsRequest request = new ListAiApplicationAgentsRequest
            {
                ParentAsAiApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAiApplicationAgents(request, callSettings);
        }

        /// <summary>
        /// Lists Agents under an AI Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (AI Application) for ListAiApplicationAgentsRequest.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
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
        public virtual gax::PagedAsyncEnumerable<ListAiApplicationAgentsResponse, Agent> ListAiApplicationAgentsAsync(AiApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationAgentsRequest request = new ListAiApplicationAgentsRequest
            {
                ParentAsAiApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAiApplicationAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single McpServer under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual McpServer GetAiApplicationMcpServer(GetAiApplicationMcpServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single McpServer under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetAiApplicationMcpServerAsync(GetAiApplicationMcpServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single McpServer under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetAiApplicationMcpServerAsync(GetAiApplicationMcpServerRequest request, st::CancellationToken cancellationToken) =>
            GetAiApplicationMcpServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single McpServer under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/mcpServers/{mcp_server}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual McpServer GetAiApplicationMcpServer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationMcpServer(new GetAiApplicationMcpServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single McpServer under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/mcpServers/{mcp_server}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetAiApplicationMcpServerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationMcpServerAsync(new GetAiApplicationMcpServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single McpServer under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/mcpServers/{mcp_server}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetAiApplicationMcpServerAsync(string name, st::CancellationToken cancellationToken) =>
            GetAiApplicationMcpServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single McpServer under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/mcpServers/{mcp_server}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual McpServer GetAiApplicationMcpServer(McpServerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationMcpServer(new GetAiApplicationMcpServerRequest
            {
                McpServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single McpServer under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/mcpServers/{mcp_server}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetAiApplicationMcpServerAsync(McpServerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationMcpServerAsync(new GetAiApplicationMcpServerRequest
            {
                McpServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single McpServer under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/mcpServers/{mcp_server}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetAiApplicationMcpServerAsync(McpServerName name, st::CancellationToken cancellationToken) =>
            GetAiApplicationMcpServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists McpServers under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAiApplicationMcpServersResponse, McpServer> ListAiApplicationMcpServers(ListAiApplicationMcpServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists McpServers under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAiApplicationMcpServersResponse, McpServer> ListAiApplicationMcpServersAsync(ListAiApplicationMcpServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists McpServers under an AI Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (AI Application) for
        /// ListAiApplicationMcpServersRequest.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
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
        public virtual gax::PagedEnumerable<ListAiApplicationMcpServersResponse, McpServer> ListAiApplicationMcpServers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationMcpServersRequest request = new ListAiApplicationMcpServersRequest
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
            return ListAiApplicationMcpServers(request, callSettings);
        }

        /// <summary>
        /// Lists McpServers under an AI Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (AI Application) for
        /// ListAiApplicationMcpServersRequest.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
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
        public virtual gax::PagedAsyncEnumerable<ListAiApplicationMcpServersResponse, McpServer> ListAiApplicationMcpServersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationMcpServersRequest request = new ListAiApplicationMcpServersRequest
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
            return ListAiApplicationMcpServersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists McpServers under an AI Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (AI Application) for
        /// ListAiApplicationMcpServersRequest.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
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
        public virtual gax::PagedEnumerable<ListAiApplicationMcpServersResponse, McpServer> ListAiApplicationMcpServers(AiApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationMcpServersRequest request = new ListAiApplicationMcpServersRequest
            {
                ParentAsAiApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAiApplicationMcpServers(request, callSettings);
        }

        /// <summary>
        /// Lists McpServers under an AI Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (AI Application) for
        /// ListAiApplicationMcpServersRequest.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
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
        public virtual gax::PagedAsyncEnumerable<ListAiApplicationMcpServersResponse, McpServer> ListAiApplicationMcpServersAsync(AiApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationMcpServersRequest request = new ListAiApplicationMcpServersRequest
            {
                ParentAsAiApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAiApplicationMcpServersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Finding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding GetFinding(GetFindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Finding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> GetFindingAsync(GetFindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Finding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> GetFindingAsync(GetFindingRequest request, st::CancellationToken cancellationToken) =>
            GetFindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Finding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Finding to retrieve.
        /// Format: `projects/{project}/locations/{location}/findings/{finding}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding GetFinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFinding(new GetFindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Finding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Finding to retrieve.
        /// Format: `projects/{project}/locations/{location}/findings/{finding}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> GetFindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFindingAsync(new GetFindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Finding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Finding to retrieve.
        /// Format: `projects/{project}/locations/{location}/findings/{finding}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> GetFindingAsync(string name, st::CancellationToken cancellationToken) =>
            GetFindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Finding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Finding to retrieve.
        /// Format: `projects/{project}/locations/{location}/findings/{finding}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding GetFinding(FindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFinding(new GetFindingRequest
            {
                FindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Finding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Finding to retrieve.
        /// Format: `projects/{project}/locations/{location}/findings/{finding}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> GetFindingAsync(FindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFindingAsync(new GetFindingRequest
            {
                FindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Finding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Finding to retrieve.
        /// Format: `projects/{project}/locations/{location}/findings/{finding}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> GetFindingAsync(FindingName name, st::CancellationToken cancellationToken) =>
            GetFindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Findings in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Finding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingsResponse, Finding> ListFindings(ListFindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Findings in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Finding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingsResponse, Finding> ListFindingsAsync(ListFindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Findings in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListFindingsRequest. Format:
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
        /// <returns>A pageable sequence of <see cref="Finding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingsResponse, Finding> ListFindings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingsRequest request = new ListFindingsRequest
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
            return ListFindings(request, callSettings);
        }

        /// <summary>
        /// Lists Findings in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListFindingsRequest. Format:
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
        /// <returns>A pageable asynchronous sequence of <see cref="Finding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingsResponse, Finding> ListFindingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingsRequest request = new ListFindingsRequest
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
            return ListFindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Findings in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListFindingsRequest. Format:
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
        /// <returns>A pageable sequence of <see cref="Finding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingsResponse, Finding> ListFindings(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingsRequest request = new ListFindingsRequest
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
            return ListFindings(request, callSettings);
        }

        /// <summary>
        /// Lists Findings in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListFindingsRequest. Format:
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
        /// <returns>A pageable asynchronous sequence of <see cref="Finding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingsResponse, Finding> ListFindingsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingsRequest request = new ListFindingsRequest
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
            return ListFindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Endpoint under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetAiApplicationEndpoint(GetAiApplicationEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Endpoint under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetAiApplicationEndpointAsync(GetAiApplicationEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Endpoint under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetAiApplicationEndpointAsync(GetAiApplicationEndpointRequest request, st::CancellationToken cancellationToken) =>
            GetAiApplicationEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Endpoint under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetAiApplicationEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationEndpoint(new GetAiApplicationEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Endpoint under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetAiApplicationEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationEndpointAsync(new GetAiApplicationEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Endpoint under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/endpoints/{endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetAiApplicationEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            GetAiApplicationEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Endpoint under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetAiApplicationEndpoint(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationEndpoint(new GetAiApplicationEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Endpoint under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetAiApplicationEndpointAsync(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAiApplicationEndpointAsync(new GetAiApplicationEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Endpoint under an AI Application.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}/endpoints/{endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetAiApplicationEndpointAsync(EndpointName name, st::CancellationToken cancellationToken) =>
            GetAiApplicationEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Endpoints under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAiApplicationEndpointsResponse, Endpoint> ListAiApplicationEndpoints(ListAiApplicationEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Endpoints under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAiApplicationEndpointsResponse, Endpoint> ListAiApplicationEndpointsAsync(ListAiApplicationEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Endpoints under an AI Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (AI Application) for
        /// ListAiApplicationEndpointsRequest.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
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
        public virtual gax::PagedEnumerable<ListAiApplicationEndpointsResponse, Endpoint> ListAiApplicationEndpoints(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationEndpointsRequest request = new ListAiApplicationEndpointsRequest
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
            return ListAiApplicationEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints under an AI Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (AI Application) for
        /// ListAiApplicationEndpointsRequest.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
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
        public virtual gax::PagedAsyncEnumerable<ListAiApplicationEndpointsResponse, Endpoint> ListAiApplicationEndpointsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationEndpointsRequest request = new ListAiApplicationEndpointsRequest
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
            return ListAiApplicationEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints under an AI Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (AI Application) for
        /// ListAiApplicationEndpointsRequest.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
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
        public virtual gax::PagedEnumerable<ListAiApplicationEndpointsResponse, Endpoint> ListAiApplicationEndpoints(AiApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationEndpointsRequest request = new ListAiApplicationEndpointsRequest
            {
                ParentAsAiApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAiApplicationEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints under an AI Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (AI Application) for
        /// ListAiApplicationEndpointsRequest.
        /// Format:
        /// `projects/{project}/locations/{location}/aiApplications/{ai_application}`
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
        public virtual gax::PagedAsyncEnumerable<ListAiApplicationEndpointsResponse, Endpoint> ListAiApplicationEndpointsAsync(AiApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAiApplicationEndpointsRequest request = new ListAiApplicationEndpointsRequest
            {
                ParentAsAiApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAiApplicationEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// =========================================================================
        /// # Skill Encryption Spec Service Methods
        /// 
        /// Gets the customer-managed encryption key (CMEK) configuration for Skills in
        /// a specific project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SkillEncryptionSpec GetSkillEncryptionSpec(GetSkillEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// =========================================================================
        /// # Skill Encryption Spec Service Methods
        /// 
        /// Gets the customer-managed encryption key (CMEK) configuration for Skills in
        /// a specific project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkillEncryptionSpec> GetSkillEncryptionSpecAsync(GetSkillEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// =========================================================================
        /// # Skill Encryption Spec Service Methods
        /// 
        /// Gets the customer-managed encryption key (CMEK) configuration for Skills in
        /// a specific project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkillEncryptionSpec> GetSkillEncryptionSpecAsync(GetSkillEncryptionSpecRequest request, st::CancellationToken cancellationToken) =>
            GetSkillEncryptionSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// =========================================================================
        /// # Skill Encryption Spec Service Methods
        /// 
        /// Gets the customer-managed encryption key (CMEK) configuration for Skills in
        /// a specific project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SkillEncryptionSpec to retrieve.
        /// Format: `projects/{project}/locations/{location}/skillEncryptionSpec`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SkillEncryptionSpec GetSkillEncryptionSpec(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkillEncryptionSpec(new GetSkillEncryptionSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// =========================================================================
        /// # Skill Encryption Spec Service Methods
        /// 
        /// Gets the customer-managed encryption key (CMEK) configuration for Skills in
        /// a specific project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SkillEncryptionSpec to retrieve.
        /// Format: `projects/{project}/locations/{location}/skillEncryptionSpec`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkillEncryptionSpec> GetSkillEncryptionSpecAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkillEncryptionSpecAsync(new GetSkillEncryptionSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// =========================================================================
        /// # Skill Encryption Spec Service Methods
        /// 
        /// Gets the customer-managed encryption key (CMEK) configuration for Skills in
        /// a specific project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SkillEncryptionSpec to retrieve.
        /// Format: `projects/{project}/locations/{location}/skillEncryptionSpec`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkillEncryptionSpec> GetSkillEncryptionSpecAsync(string name, st::CancellationToken cancellationToken) =>
            GetSkillEncryptionSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// =========================================================================
        /// # Skill Encryption Spec Service Methods
        /// 
        /// Gets the customer-managed encryption key (CMEK) configuration for Skills in
        /// a specific project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SkillEncryptionSpec to retrieve.
        /// Format: `projects/{project}/locations/{location}/skillEncryptionSpec`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SkillEncryptionSpec GetSkillEncryptionSpec(SkillEncryptionSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkillEncryptionSpec(new GetSkillEncryptionSpecRequest
            {
                SkillEncryptionSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// =========================================================================
        /// # Skill Encryption Spec Service Methods
        /// 
        /// Gets the customer-managed encryption key (CMEK) configuration for Skills in
        /// a specific project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SkillEncryptionSpec to retrieve.
        /// Format: `projects/{project}/locations/{location}/skillEncryptionSpec`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkillEncryptionSpec> GetSkillEncryptionSpecAsync(SkillEncryptionSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkillEncryptionSpecAsync(new GetSkillEncryptionSpecRequest
            {
                SkillEncryptionSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// =========================================================================
        /// # Skill Encryption Spec Service Methods
        /// 
        /// Gets the customer-managed encryption key (CMEK) configuration for Skills in
        /// a specific project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SkillEncryptionSpec to retrieve.
        /// Format: `projects/{project}/locations/{location}/skillEncryptionSpec`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkillEncryptionSpec> GetSkillEncryptionSpecAsync(SkillEncryptionSpecName name, st::CancellationToken cancellationToken) =>
            GetSkillEncryptionSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the customer-managed encryption key (CMEK) configuration for Skills
        /// in a specific project and location.
        /// 
        /// This method is only allowed when no Skills exist in the target project and
        /// location. If any Skill already exists in the location, the request fails
        /// with `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SkillEncryptionSpec, OperationMetadata> UpdateSkillEncryptionSpec(UpdateSkillEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the customer-managed encryption key (CMEK) configuration for Skills
        /// in a specific project and location.
        /// 
        /// This method is only allowed when no Skills exist in the target project and
        /// location. If any Skill already exists in the location, the request fails
        /// with `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SkillEncryptionSpec, OperationMetadata>> UpdateSkillEncryptionSpecAsync(UpdateSkillEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the customer-managed encryption key (CMEK) configuration for Skills
        /// in a specific project and location.
        /// 
        /// This method is only allowed when no Skills exist in the target project and
        /// location. If any Skill already exists in the location, the request fails
        /// with `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SkillEncryptionSpec, OperationMetadata>> UpdateSkillEncryptionSpecAsync(UpdateSkillEncryptionSpecRequest request, st::CancellationToken cancellationToken) =>
            UpdateSkillEncryptionSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSkillEncryptionSpec</c>.</summary>
        public virtual lro::OperationsClient UpdateSkillEncryptionSpecOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSkillEncryptionSpec</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SkillEncryptionSpec, OperationMetadata> PollOnceUpdateSkillEncryptionSpec(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SkillEncryptionSpec, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSkillEncryptionSpecOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSkillEncryptionSpec</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SkillEncryptionSpec, OperationMetadata>> PollOnceUpdateSkillEncryptionSpecAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SkillEncryptionSpec, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSkillEncryptionSpecOperationsClient, callSettings);

        /// <summary>
        /// Updates the customer-managed encryption key (CMEK) configuration for Skills
        /// in a specific project and location.
        /// 
        /// This method is only allowed when no Skills exist in the target project and
        /// location. If any Skill already exists in the location, the request fails
        /// with `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="skillEncryptionSpec">
        /// Required. The SkillEncryptionSpec to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// SkillEncryptionSpec resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SkillEncryptionSpec, OperationMetadata> UpdateSkillEncryptionSpec(SkillEncryptionSpec skillEncryptionSpec, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSkillEncryptionSpec(new UpdateSkillEncryptionSpecRequest
            {
                SkillEncryptionSpec = gax::GaxPreconditions.CheckNotNull(skillEncryptionSpec, nameof(skillEncryptionSpec)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the customer-managed encryption key (CMEK) configuration for Skills
        /// in a specific project and location.
        /// 
        /// This method is only allowed when no Skills exist in the target project and
        /// location. If any Skill already exists in the location, the request fails
        /// with `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="skillEncryptionSpec">
        /// Required. The SkillEncryptionSpec to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// SkillEncryptionSpec resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SkillEncryptionSpec, OperationMetadata>> UpdateSkillEncryptionSpecAsync(SkillEncryptionSpec skillEncryptionSpec, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSkillEncryptionSpecAsync(new UpdateSkillEncryptionSpecRequest
            {
                SkillEncryptionSpec = gax::GaxPreconditions.CheckNotNull(skillEncryptionSpec, nameof(skillEncryptionSpec)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the customer-managed encryption key (CMEK) configuration for Skills
        /// in a specific project and location.
        /// 
        /// This method is only allowed when no Skills exist in the target project and
        /// location. If any Skill already exists in the location, the request fails
        /// with `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="skillEncryptionSpec">
        /// Required. The SkillEncryptionSpec to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// SkillEncryptionSpec resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SkillEncryptionSpec, OperationMetadata>> UpdateSkillEncryptionSpecAsync(SkillEncryptionSpec skillEncryptionSpec, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSkillEncryptionSpecAsync(skillEncryptionSpec, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AgentRegistry client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Agent Registry resources.
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

        private readonly gaxgrpc::ApiCall<CreateSkillRequest, lro::Operation> _callCreateSkill;

        private readonly gaxgrpc::ApiCall<GetSkillRequest, Skill> _callGetSkill;

        private readonly gaxgrpc::ApiCall<UpdateSkillRequest, lro::Operation> _callUpdateSkill;

        private readonly gaxgrpc::ApiCall<DeleteSkillRequest, lro::Operation> _callDeleteSkill;

        private readonly gaxgrpc::ApiCall<ListSkillsRequest, ListSkillsResponse> _callListSkills;

        private readonly gaxgrpc::ApiCall<SearchSkillsRequest, SearchSkillsResponse> _callSearchSkills;

        private readonly gaxgrpc::ApiCall<CreateSkillRevisionRequest, lro::Operation> _callCreateSkillRevision;

        private readonly gaxgrpc::ApiCall<GetSkillRevisionRequest, SkillRevision> _callGetSkillRevision;

        private readonly gaxgrpc::ApiCall<DeleteSkillRevisionRequest, lro::Operation> _callDeleteSkillRevision;

        private readonly gaxgrpc::ApiCall<ListSkillRevisionsRequest, ListSkillRevisionsResponse> _callListSkillRevisions;

        private readonly gaxgrpc::ApiCall<GetPublisherRequest, Publisher> _callGetPublisher;

        private readonly gaxgrpc::ApiCall<ListPublishersRequest, ListPublishersResponse> _callListPublishers;

        private readonly gaxgrpc::ApiCall<GetAiApplicationRequest, AiApplication> _callGetAiApplication;

        private readonly gaxgrpc::ApiCall<ListAiApplicationsRequest, ListAiApplicationsResponse> _callListAiApplications;

        private readonly gaxgrpc::ApiCall<GetAiApplicationAgentRequest, Agent> _callGetAiApplicationAgent;

        private readonly gaxgrpc::ApiCall<ListAiApplicationAgentsRequest, ListAiApplicationAgentsResponse> _callListAiApplicationAgents;

        private readonly gaxgrpc::ApiCall<GetAiApplicationMcpServerRequest, McpServer> _callGetAiApplicationMcpServer;

        private readonly gaxgrpc::ApiCall<ListAiApplicationMcpServersRequest, ListAiApplicationMcpServersResponse> _callListAiApplicationMcpServers;

        private readonly gaxgrpc::ApiCall<GetFindingRequest, Finding> _callGetFinding;

        private readonly gaxgrpc::ApiCall<ListFindingsRequest, ListFindingsResponse> _callListFindings;

        private readonly gaxgrpc::ApiCall<GetAiApplicationEndpointRequest, Endpoint> _callGetAiApplicationEndpoint;

        private readonly gaxgrpc::ApiCall<ListAiApplicationEndpointsRequest, ListAiApplicationEndpointsResponse> _callListAiApplicationEndpoints;

        private readonly gaxgrpc::ApiCall<GetSkillEncryptionSpecRequest, SkillEncryptionSpec> _callGetSkillEncryptionSpec;

        private readonly gaxgrpc::ApiCall<UpdateSkillEncryptionSpecRequest, lro::Operation> _callUpdateSkillEncryptionSpec;

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
            CreateSkillOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSkillOperationsSettings, logger);
            UpdateSkillOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSkillOperationsSettings, logger);
            DeleteSkillOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSkillOperationsSettings, logger);
            CreateSkillRevisionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSkillRevisionOperationsSettings, logger);
            DeleteSkillRevisionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSkillRevisionOperationsSettings, logger);
            UpdateSkillEncryptionSpecOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSkillEncryptionSpecOperationsSettings, logger);
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
            _callCreateSkill = clientHelper.BuildApiCall<CreateSkillRequest, lro::Operation>("CreateSkill", grpcClient.CreateSkillAsync, grpcClient.CreateSkill, effectiveSettings.CreateSkillSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSkill);
            Modify_CreateSkillApiCall(ref _callCreateSkill);
            _callGetSkill = clientHelper.BuildApiCall<GetSkillRequest, Skill>("GetSkill", grpcClient.GetSkillAsync, grpcClient.GetSkill, effectiveSettings.GetSkillSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSkill);
            Modify_GetSkillApiCall(ref _callGetSkill);
            _callUpdateSkill = clientHelper.BuildApiCall<UpdateSkillRequest, lro::Operation>("UpdateSkill", grpcClient.UpdateSkillAsync, grpcClient.UpdateSkill, effectiveSettings.UpdateSkillSettings).WithGoogleRequestParam("skill.name", request => request.Skill?.Name);
            Modify_ApiCall(ref _callUpdateSkill);
            Modify_UpdateSkillApiCall(ref _callUpdateSkill);
            _callDeleteSkill = clientHelper.BuildApiCall<DeleteSkillRequest, lro::Operation>("DeleteSkill", grpcClient.DeleteSkillAsync, grpcClient.DeleteSkill, effectiveSettings.DeleteSkillSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSkill);
            Modify_DeleteSkillApiCall(ref _callDeleteSkill);
            _callListSkills = clientHelper.BuildApiCall<ListSkillsRequest, ListSkillsResponse>("ListSkills", grpcClient.ListSkillsAsync, grpcClient.ListSkills, effectiveSettings.ListSkillsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSkills);
            Modify_ListSkillsApiCall(ref _callListSkills);
            _callSearchSkills = clientHelper.BuildApiCall<SearchSkillsRequest, SearchSkillsResponse>("SearchSkills", grpcClient.SearchSkillsAsync, grpcClient.SearchSkills, effectiveSettings.SearchSkillsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchSkills);
            Modify_SearchSkillsApiCall(ref _callSearchSkills);
            _callCreateSkillRevision = clientHelper.BuildApiCall<CreateSkillRevisionRequest, lro::Operation>("CreateSkillRevision", grpcClient.CreateSkillRevisionAsync, grpcClient.CreateSkillRevision, effectiveSettings.CreateSkillRevisionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSkillRevision);
            Modify_CreateSkillRevisionApiCall(ref _callCreateSkillRevision);
            _callGetSkillRevision = clientHelper.BuildApiCall<GetSkillRevisionRequest, SkillRevision>("GetSkillRevision", grpcClient.GetSkillRevisionAsync, grpcClient.GetSkillRevision, effectiveSettings.GetSkillRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSkillRevision);
            Modify_GetSkillRevisionApiCall(ref _callGetSkillRevision);
            _callDeleteSkillRevision = clientHelper.BuildApiCall<DeleteSkillRevisionRequest, lro::Operation>("DeleteSkillRevision", grpcClient.DeleteSkillRevisionAsync, grpcClient.DeleteSkillRevision, effectiveSettings.DeleteSkillRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSkillRevision);
            Modify_DeleteSkillRevisionApiCall(ref _callDeleteSkillRevision);
            _callListSkillRevisions = clientHelper.BuildApiCall<ListSkillRevisionsRequest, ListSkillRevisionsResponse>("ListSkillRevisions", grpcClient.ListSkillRevisionsAsync, grpcClient.ListSkillRevisions, effectiveSettings.ListSkillRevisionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSkillRevisions);
            Modify_ListSkillRevisionsApiCall(ref _callListSkillRevisions);
            _callGetPublisher = clientHelper.BuildApiCall<GetPublisherRequest, Publisher>("GetPublisher", grpcClient.GetPublisherAsync, grpcClient.GetPublisher, effectiveSettings.GetPublisherSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPublisher);
            Modify_GetPublisherApiCall(ref _callGetPublisher);
            _callListPublishers = clientHelper.BuildApiCall<ListPublishersRequest, ListPublishersResponse>("ListPublishers", grpcClient.ListPublishersAsync, grpcClient.ListPublishers, effectiveSettings.ListPublishersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPublishers);
            Modify_ListPublishersApiCall(ref _callListPublishers);
            _callGetAiApplication = clientHelper.BuildApiCall<GetAiApplicationRequest, AiApplication>("GetAiApplication", grpcClient.GetAiApplicationAsync, grpcClient.GetAiApplication, effectiveSettings.GetAiApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAiApplication);
            Modify_GetAiApplicationApiCall(ref _callGetAiApplication);
            _callListAiApplications = clientHelper.BuildApiCall<ListAiApplicationsRequest, ListAiApplicationsResponse>("ListAiApplications", grpcClient.ListAiApplicationsAsync, grpcClient.ListAiApplications, effectiveSettings.ListAiApplicationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAiApplications);
            Modify_ListAiApplicationsApiCall(ref _callListAiApplications);
            _callGetAiApplicationAgent = clientHelper.BuildApiCall<GetAiApplicationAgentRequest, Agent>("GetAiApplicationAgent", grpcClient.GetAiApplicationAgentAsync, grpcClient.GetAiApplicationAgent, effectiveSettings.GetAiApplicationAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAiApplicationAgent);
            Modify_GetAiApplicationAgentApiCall(ref _callGetAiApplicationAgent);
            _callListAiApplicationAgents = clientHelper.BuildApiCall<ListAiApplicationAgentsRequest, ListAiApplicationAgentsResponse>("ListAiApplicationAgents", grpcClient.ListAiApplicationAgentsAsync, grpcClient.ListAiApplicationAgents, effectiveSettings.ListAiApplicationAgentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAiApplicationAgents);
            Modify_ListAiApplicationAgentsApiCall(ref _callListAiApplicationAgents);
            _callGetAiApplicationMcpServer = clientHelper.BuildApiCall<GetAiApplicationMcpServerRequest, McpServer>("GetAiApplicationMcpServer", grpcClient.GetAiApplicationMcpServerAsync, grpcClient.GetAiApplicationMcpServer, effectiveSettings.GetAiApplicationMcpServerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAiApplicationMcpServer);
            Modify_GetAiApplicationMcpServerApiCall(ref _callGetAiApplicationMcpServer);
            _callListAiApplicationMcpServers = clientHelper.BuildApiCall<ListAiApplicationMcpServersRequest, ListAiApplicationMcpServersResponse>("ListAiApplicationMcpServers", grpcClient.ListAiApplicationMcpServersAsync, grpcClient.ListAiApplicationMcpServers, effectiveSettings.ListAiApplicationMcpServersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAiApplicationMcpServers);
            Modify_ListAiApplicationMcpServersApiCall(ref _callListAiApplicationMcpServers);
            _callGetFinding = clientHelper.BuildApiCall<GetFindingRequest, Finding>("GetFinding", grpcClient.GetFindingAsync, grpcClient.GetFinding, effectiveSettings.GetFindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFinding);
            Modify_GetFindingApiCall(ref _callGetFinding);
            _callListFindings = clientHelper.BuildApiCall<ListFindingsRequest, ListFindingsResponse>("ListFindings", grpcClient.ListFindingsAsync, grpcClient.ListFindings, effectiveSettings.ListFindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFindings);
            Modify_ListFindingsApiCall(ref _callListFindings);
            _callGetAiApplicationEndpoint = clientHelper.BuildApiCall<GetAiApplicationEndpointRequest, Endpoint>("GetAiApplicationEndpoint", grpcClient.GetAiApplicationEndpointAsync, grpcClient.GetAiApplicationEndpoint, effectiveSettings.GetAiApplicationEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAiApplicationEndpoint);
            Modify_GetAiApplicationEndpointApiCall(ref _callGetAiApplicationEndpoint);
            _callListAiApplicationEndpoints = clientHelper.BuildApiCall<ListAiApplicationEndpointsRequest, ListAiApplicationEndpointsResponse>("ListAiApplicationEndpoints", grpcClient.ListAiApplicationEndpointsAsync, grpcClient.ListAiApplicationEndpoints, effectiveSettings.ListAiApplicationEndpointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAiApplicationEndpoints);
            Modify_ListAiApplicationEndpointsApiCall(ref _callListAiApplicationEndpoints);
            _callGetSkillEncryptionSpec = clientHelper.BuildApiCall<GetSkillEncryptionSpecRequest, SkillEncryptionSpec>("GetSkillEncryptionSpec", grpcClient.GetSkillEncryptionSpecAsync, grpcClient.GetSkillEncryptionSpec, effectiveSettings.GetSkillEncryptionSpecSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSkillEncryptionSpec);
            Modify_GetSkillEncryptionSpecApiCall(ref _callGetSkillEncryptionSpec);
            _callUpdateSkillEncryptionSpec = clientHelper.BuildApiCall<UpdateSkillEncryptionSpecRequest, lro::Operation>("UpdateSkillEncryptionSpec", grpcClient.UpdateSkillEncryptionSpecAsync, grpcClient.UpdateSkillEncryptionSpec, effectiveSettings.UpdateSkillEncryptionSpecSettings).WithGoogleRequestParam("skill_encryption_spec.name", request => request.SkillEncryptionSpec?.Name);
            Modify_ApiCall(ref _callUpdateSkillEncryptionSpec);
            Modify_UpdateSkillEncryptionSpecApiCall(ref _callUpdateSkillEncryptionSpec);
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

        partial void Modify_CreateSkillApiCall(ref gaxgrpc::ApiCall<CreateSkillRequest, lro::Operation> call);

        partial void Modify_GetSkillApiCall(ref gaxgrpc::ApiCall<GetSkillRequest, Skill> call);

        partial void Modify_UpdateSkillApiCall(ref gaxgrpc::ApiCall<UpdateSkillRequest, lro::Operation> call);

        partial void Modify_DeleteSkillApiCall(ref gaxgrpc::ApiCall<DeleteSkillRequest, lro::Operation> call);

        partial void Modify_ListSkillsApiCall(ref gaxgrpc::ApiCall<ListSkillsRequest, ListSkillsResponse> call);

        partial void Modify_SearchSkillsApiCall(ref gaxgrpc::ApiCall<SearchSkillsRequest, SearchSkillsResponse> call);

        partial void Modify_CreateSkillRevisionApiCall(ref gaxgrpc::ApiCall<CreateSkillRevisionRequest, lro::Operation> call);

        partial void Modify_GetSkillRevisionApiCall(ref gaxgrpc::ApiCall<GetSkillRevisionRequest, SkillRevision> call);

        partial void Modify_DeleteSkillRevisionApiCall(ref gaxgrpc::ApiCall<DeleteSkillRevisionRequest, lro::Operation> call);

        partial void Modify_ListSkillRevisionsApiCall(ref gaxgrpc::ApiCall<ListSkillRevisionsRequest, ListSkillRevisionsResponse> call);

        partial void Modify_GetPublisherApiCall(ref gaxgrpc::ApiCall<GetPublisherRequest, Publisher> call);

        partial void Modify_ListPublishersApiCall(ref gaxgrpc::ApiCall<ListPublishersRequest, ListPublishersResponse> call);

        partial void Modify_GetAiApplicationApiCall(ref gaxgrpc::ApiCall<GetAiApplicationRequest, AiApplication> call);

        partial void Modify_ListAiApplicationsApiCall(ref gaxgrpc::ApiCall<ListAiApplicationsRequest, ListAiApplicationsResponse> call);

        partial void Modify_GetAiApplicationAgentApiCall(ref gaxgrpc::ApiCall<GetAiApplicationAgentRequest, Agent> call);

        partial void Modify_ListAiApplicationAgentsApiCall(ref gaxgrpc::ApiCall<ListAiApplicationAgentsRequest, ListAiApplicationAgentsResponse> call);

        partial void Modify_GetAiApplicationMcpServerApiCall(ref gaxgrpc::ApiCall<GetAiApplicationMcpServerRequest, McpServer> call);

        partial void Modify_ListAiApplicationMcpServersApiCall(ref gaxgrpc::ApiCall<ListAiApplicationMcpServersRequest, ListAiApplicationMcpServersResponse> call);

        partial void Modify_GetFindingApiCall(ref gaxgrpc::ApiCall<GetFindingRequest, Finding> call);

        partial void Modify_ListFindingsApiCall(ref gaxgrpc::ApiCall<ListFindingsRequest, ListFindingsResponse> call);

        partial void Modify_GetAiApplicationEndpointApiCall(ref gaxgrpc::ApiCall<GetAiApplicationEndpointRequest, Endpoint> call);

        partial void Modify_ListAiApplicationEndpointsApiCall(ref gaxgrpc::ApiCall<ListAiApplicationEndpointsRequest, ListAiApplicationEndpointsResponse> call);

        partial void Modify_GetSkillEncryptionSpecApiCall(ref gaxgrpc::ApiCall<GetSkillEncryptionSpecRequest, SkillEncryptionSpec> call);

        partial void Modify_UpdateSkillEncryptionSpecApiCall(ref gaxgrpc::ApiCall<UpdateSkillEncryptionSpecRequest, lro::Operation> call);

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

        partial void Modify_CreateSkillRequest(ref CreateSkillRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSkillRequest(ref GetSkillRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSkillRequest(ref UpdateSkillRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSkillRequest(ref DeleteSkillRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSkillsRequest(ref ListSkillsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchSkillsRequest(ref SearchSkillsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSkillRevisionRequest(ref CreateSkillRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSkillRevisionRequest(ref GetSkillRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSkillRevisionRequest(ref DeleteSkillRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSkillRevisionsRequest(ref ListSkillRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPublisherRequest(ref GetPublisherRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPublishersRequest(ref ListPublishersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAiApplicationRequest(ref GetAiApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAiApplicationsRequest(ref ListAiApplicationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAiApplicationAgentRequest(ref GetAiApplicationAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAiApplicationAgentsRequest(ref ListAiApplicationAgentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAiApplicationMcpServerRequest(ref GetAiApplicationMcpServerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAiApplicationMcpServersRequest(ref ListAiApplicationMcpServersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFindingRequest(ref GetFindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFindingsRequest(ref ListFindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAiApplicationEndpointRequest(ref GetAiApplicationEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAiApplicationEndpointsRequest(ref ListAiApplicationEndpointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSkillEncryptionSpecRequest(ref GetSkillEncryptionSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSkillEncryptionSpecRequest(ref UpdateSkillEncryptionSpecRequest request, ref gaxgrpc::CallSettings settings);

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

        /// <summary>The long-running operations client for <c>CreateSkill</c>.</summary>
        public override lro::OperationsClient CreateSkillOperationsClient { get; }

        /// <summary>
        /// =========================================================================
        /// # Skills Collection APIs
        /// 
        /// Creates a Skill resource container, optionally publishing the initial
        /// SkillRevision inline in a single, atomic CRUD roundtrip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Skill, OperationMetadata> CreateSkill(CreateSkillRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSkillRequest(ref request, ref callSettings);
            return new lro::Operation<Skill, OperationMetadata>(_callCreateSkill.Sync(request, callSettings), CreateSkillOperationsClient);
        }

        /// <summary>
        /// =========================================================================
        /// # Skills Collection APIs
        /// 
        /// Creates a Skill resource container, optionally publishing the initial
        /// SkillRevision inline in a single, atomic CRUD roundtrip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Skill, OperationMetadata>> CreateSkillAsync(CreateSkillRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSkillRequest(ref request, ref callSettings);
            return new lro::Operation<Skill, OperationMetadata>(await _callCreateSkill.Async(request, callSettings).ConfigureAwait(false), CreateSkillOperationsClient);
        }

        /// <summary>
        /// Fetches the active configuration and metadata of a Skill.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Skill GetSkill(GetSkillRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSkillRequest(ref request, ref callSettings);
            return _callGetSkill.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches the active configuration and metadata of a Skill.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Skill> GetSkillAsync(GetSkillRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSkillRequest(ref request, ref callSettings);
            return _callGetSkill.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateSkill</c>.</summary>
        public override lro::OperationsClient UpdateSkillOperationsClient { get; }

        /// <summary>
        /// Updates Skill metadata or overrides active pointers/state using REST
        /// standard PATCH.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Skill, OperationMetadata> UpdateSkill(UpdateSkillRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSkillRequest(ref request, ref callSettings);
            return new lro::Operation<Skill, OperationMetadata>(_callUpdateSkill.Sync(request, callSettings), UpdateSkillOperationsClient);
        }

        /// <summary>
        /// Updates Skill metadata or overrides active pointers/state using REST
        /// standard PATCH.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Skill, OperationMetadata>> UpdateSkillAsync(UpdateSkillRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSkillRequest(ref request, ref callSettings);
            return new lro::Operation<Skill, OperationMetadata>(await _callUpdateSkill.Async(request, callSettings).ConfigureAwait(false), UpdateSkillOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSkill</c>.</summary>
        public override lro::OperationsClient DeleteSkillOperationsClient { get; }

        /// <summary>
        /// Deletes a Skill container along with all its revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSkill(DeleteSkillRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSkillRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSkill.Sync(request, callSettings), DeleteSkillOperationsClient);
        }

        /// <summary>
        /// Deletes a Skill container along with all its revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillAsync(DeleteSkillRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSkillRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSkill.Async(request, callSettings).ConfigureAwait(false), DeleteSkillOperationsClient);
        }

        /// <summary>
        /// Lists logical Skills available in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Skill"/> resources.</returns>
        public override gax::PagedEnumerable<ListSkillsResponse, Skill> ListSkills(ListSkillsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSkillsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSkillsRequest, ListSkillsResponse, Skill>(_callListSkills, request, callSettings);
        }

        /// <summary>
        /// Lists logical Skills available in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Skill"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSkillsResponse, Skill> ListSkillsAsync(ListSkillsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSkillsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSkillsRequest, ListSkillsResponse, Skill>(_callListSkills, request, callSettings);
        }

        /// <summary>
        /// Custom deep-search method to filter by frontmatter or query SKILL.md text
        /// blobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Skill"/> resources.</returns>
        public override gax::PagedEnumerable<SearchSkillsResponse, Skill> SearchSkills(SearchSkillsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchSkillsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchSkillsRequest, SearchSkillsResponse, Skill>(_callSearchSkills, request, callSettings);
        }

        /// <summary>
        /// Custom deep-search method to filter by frontmatter or query SKILL.md text
        /// blobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Skill"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchSkillsResponse, Skill> SearchSkillsAsync(SearchSkillsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchSkillsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchSkillsRequest, SearchSkillsResponse, Skill>(_callSearchSkills, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSkillRevision</c>.</summary>
        public override lro::OperationsClient CreateSkillRevisionOperationsClient { get; }

        /// <summary>
        /// Creates a new immutable revision and triggers validation pipelines.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SkillRevision, OperationMetadata> CreateSkillRevision(CreateSkillRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSkillRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<SkillRevision, OperationMetadata>(_callCreateSkillRevision.Sync(request, callSettings), CreateSkillRevisionOperationsClient);
        }

        /// <summary>
        /// Creates a new immutable revision and triggers validation pipelines.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SkillRevision, OperationMetadata>> CreateSkillRevisionAsync(CreateSkillRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSkillRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<SkillRevision, OperationMetadata>(await _callCreateSkillRevision.Async(request, callSettings).ConfigureAwait(false), CreateSkillRevisionOperationsClient);
        }

        /// <summary>
        /// Gets details of a single immutable Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SkillRevision GetSkillRevision(GetSkillRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSkillRevisionRequest(ref request, ref callSettings);
            return _callGetSkillRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single immutable Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SkillRevision> GetSkillRevisionAsync(GetSkillRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSkillRevisionRequest(ref request, ref callSettings);
            return _callGetSkillRevision.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteSkillRevision</c>.</summary>
        public override lro::OperationsClient DeleteSkillRevisionOperationsClient { get; }

        /// <summary>
        /// Deletes a specific revision (restricted to admins to purge accidentally
        /// committed secrets).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSkillRevision(DeleteSkillRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSkillRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSkillRevision.Sync(request, callSettings), DeleteSkillRevisionOperationsClient);
        }

        /// <summary>
        /// Deletes a specific revision (restricted to admins to purge accidentally
        /// committed secrets).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSkillRevisionAsync(DeleteSkillRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSkillRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSkillRevision.Async(request, callSettings).ConfigureAwait(false), DeleteSkillRevisionOperationsClient);
        }

        /// <summary>
        /// Lists all revisions belonging to a parent Skill.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SkillRevision"/> resources.</returns>
        public override gax::PagedEnumerable<ListSkillRevisionsResponse, SkillRevision> ListSkillRevisions(ListSkillRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSkillRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSkillRevisionsRequest, ListSkillRevisionsResponse, SkillRevision>(_callListSkillRevisions, request, callSettings);
        }

        /// <summary>
        /// Lists all revisions belonging to a parent Skill.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SkillRevision"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSkillRevisionsResponse, SkillRevision> ListSkillRevisionsAsync(ListSkillRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSkillRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSkillRevisionsRequest, ListSkillRevisionsResponse, SkillRevision>(_callListSkillRevisions, request, callSettings);
        }

        /// <summary>
        /// Fetches details of a specific Publisher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Publisher GetPublisher(GetPublisherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPublisherRequest(ref request, ref callSettings);
            return _callGetPublisher.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches details of a specific Publisher.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Publisher> GetPublisherAsync(GetPublisherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPublisherRequest(ref request, ref callSettings);
            return _callGetPublisher.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all Publishers in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Publisher"/> resources.</returns>
        public override gax::PagedEnumerable<ListPublishersResponse, Publisher> ListPublishers(ListPublishersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublishersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPublishersRequest, ListPublishersResponse, Publisher>(_callListPublishers, request, callSettings);
        }

        /// <summary>
        /// Lists all Publishers in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Publisher"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPublishersResponse, Publisher> ListPublishersAsync(ListPublishersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublishersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPublishersRequest, ListPublishersResponse, Publisher>(_callListPublishers, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AiApplication GetAiApplication(GetAiApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAiApplicationRequest(ref request, ref callSettings);
            return _callGetAiApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AiApplication> GetAiApplicationAsync(GetAiApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAiApplicationRequest(ref request, ref callSettings);
            return _callGetAiApplication.Async(request, callSettings);
        }

        /// <summary>
        /// Lists AI Applications in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AiApplication"/> resources.</returns>
        public override gax::PagedEnumerable<ListAiApplicationsResponse, AiApplication> ListAiApplications(ListAiApplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAiApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAiApplicationsRequest, ListAiApplicationsResponse, AiApplication>(_callListAiApplications, request, callSettings);
        }

        /// <summary>
        /// Lists AI Applications in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AiApplication"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAiApplicationsResponse, AiApplication> ListAiApplicationsAsync(ListAiApplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAiApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAiApplicationsRequest, ListAiApplicationsResponse, AiApplication>(_callListAiApplications, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Agent under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Agent GetAiApplicationAgent(GetAiApplicationAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAiApplicationAgentRequest(ref request, ref callSettings);
            return _callGetAiApplicationAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Agent under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Agent> GetAiApplicationAgentAsync(GetAiApplicationAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAiApplicationAgentRequest(ref request, ref callSettings);
            return _callGetAiApplicationAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Agents under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public override gax::PagedEnumerable<ListAiApplicationAgentsResponse, Agent> ListAiApplicationAgents(ListAiApplicationAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAiApplicationAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAiApplicationAgentsRequest, ListAiApplicationAgentsResponse, Agent>(_callListAiApplicationAgents, request, callSettings);
        }

        /// <summary>
        /// Lists Agents under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAiApplicationAgentsResponse, Agent> ListAiApplicationAgentsAsync(ListAiApplicationAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAiApplicationAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAiApplicationAgentsRequest, ListAiApplicationAgentsResponse, Agent>(_callListAiApplicationAgents, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single McpServer under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override McpServer GetAiApplicationMcpServer(GetAiApplicationMcpServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAiApplicationMcpServerRequest(ref request, ref callSettings);
            return _callGetAiApplicationMcpServer.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single McpServer under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<McpServer> GetAiApplicationMcpServerAsync(GetAiApplicationMcpServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAiApplicationMcpServerRequest(ref request, ref callSettings);
            return _callGetAiApplicationMcpServer.Async(request, callSettings);
        }

        /// <summary>
        /// Lists McpServers under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public override gax::PagedEnumerable<ListAiApplicationMcpServersResponse, McpServer> ListAiApplicationMcpServers(ListAiApplicationMcpServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAiApplicationMcpServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAiApplicationMcpServersRequest, ListAiApplicationMcpServersResponse, McpServer>(_callListAiApplicationMcpServers, request, callSettings);
        }

        /// <summary>
        /// Lists McpServers under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAiApplicationMcpServersResponse, McpServer> ListAiApplicationMcpServersAsync(ListAiApplicationMcpServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAiApplicationMcpServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAiApplicationMcpServersRequest, ListAiApplicationMcpServersResponse, McpServer>(_callListAiApplicationMcpServers, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Finding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Finding GetFinding(GetFindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFindingRequest(ref request, ref callSettings);
            return _callGetFinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Finding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Finding> GetFindingAsync(GetFindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFindingRequest(ref request, ref callSettings);
            return _callGetFinding.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Findings in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Finding"/> resources.</returns>
        public override gax::PagedEnumerable<ListFindingsResponse, Finding> ListFindings(ListFindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFindingsRequest, ListFindingsResponse, Finding>(_callListFindings, request, callSettings);
        }

        /// <summary>
        /// Lists Findings in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Finding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFindingsResponse, Finding> ListFindingsAsync(ListFindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFindingsRequest, ListFindingsResponse, Finding>(_callListFindings, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Endpoint under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Endpoint GetAiApplicationEndpoint(GetAiApplicationEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAiApplicationEndpointRequest(ref request, ref callSettings);
            return _callGetAiApplicationEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Endpoint under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Endpoint> GetAiApplicationEndpointAsync(GetAiApplicationEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAiApplicationEndpointRequest(ref request, ref callSettings);
            return _callGetAiApplicationEndpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public override gax::PagedEnumerable<ListAiApplicationEndpointsResponse, Endpoint> ListAiApplicationEndpoints(ListAiApplicationEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAiApplicationEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAiApplicationEndpointsRequest, ListAiApplicationEndpointsResponse, Endpoint>(_callListAiApplicationEndpoints, request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints under an AI Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAiApplicationEndpointsResponse, Endpoint> ListAiApplicationEndpointsAsync(ListAiApplicationEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAiApplicationEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAiApplicationEndpointsRequest, ListAiApplicationEndpointsResponse, Endpoint>(_callListAiApplicationEndpoints, request, callSettings);
        }

        /// <summary>
        /// =========================================================================
        /// # Skill Encryption Spec Service Methods
        /// 
        /// Gets the customer-managed encryption key (CMEK) configuration for Skills in
        /// a specific project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SkillEncryptionSpec GetSkillEncryptionSpec(GetSkillEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSkillEncryptionSpecRequest(ref request, ref callSettings);
            return _callGetSkillEncryptionSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// =========================================================================
        /// # Skill Encryption Spec Service Methods
        /// 
        /// Gets the customer-managed encryption key (CMEK) configuration for Skills in
        /// a specific project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SkillEncryptionSpec> GetSkillEncryptionSpecAsync(GetSkillEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSkillEncryptionSpecRequest(ref request, ref callSettings);
            return _callGetSkillEncryptionSpec.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateSkillEncryptionSpec</c>.</summary>
        public override lro::OperationsClient UpdateSkillEncryptionSpecOperationsClient { get; }

        /// <summary>
        /// Updates the customer-managed encryption key (CMEK) configuration for Skills
        /// in a specific project and location.
        /// 
        /// This method is only allowed when no Skills exist in the target project and
        /// location. If any Skill already exists in the location, the request fails
        /// with `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SkillEncryptionSpec, OperationMetadata> UpdateSkillEncryptionSpec(UpdateSkillEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSkillEncryptionSpecRequest(ref request, ref callSettings);
            return new lro::Operation<SkillEncryptionSpec, OperationMetadata>(_callUpdateSkillEncryptionSpec.Sync(request, callSettings), UpdateSkillEncryptionSpecOperationsClient);
        }

        /// <summary>
        /// Updates the customer-managed encryption key (CMEK) configuration for Skills
        /// in a specific project and location.
        /// 
        /// This method is only allowed when no Skills exist in the target project and
        /// location. If any Skill already exists in the location, the request fails
        /// with `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SkillEncryptionSpec, OperationMetadata>> UpdateSkillEncryptionSpecAsync(UpdateSkillEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSkillEncryptionSpecRequest(ref request, ref callSettings);
            return new lro::Operation<SkillEncryptionSpec, OperationMetadata>(await _callUpdateSkillEncryptionSpec.Async(request, callSettings).ConfigureAwait(false), UpdateSkillEncryptionSpecOperationsClient);
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

    public partial class ListSkillsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchSkillsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSkillRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPublishersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAiApplicationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAiApplicationAgentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAiApplicationMcpServersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAiApplicationEndpointsRequest : gaxgrpc::IPageRequest
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

    public partial class ListSkillsResponse : gaxgrpc::IPageResponse<Skill>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Skill> GetEnumerator() => Skills.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchSkillsResponse : gaxgrpc::IPageResponse<Skill>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Skill> GetEnumerator() => Skills.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSkillRevisionsResponse : gaxgrpc::IPageResponse<SkillRevision>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SkillRevision> GetEnumerator() => SkillRevisions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPublishersResponse : gaxgrpc::IPageResponse<Publisher>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Publisher> GetEnumerator() => Publishers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAiApplicationsResponse : gaxgrpc::IPageResponse<AiApplication>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AiApplication> GetEnumerator() => AiApplications.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAiApplicationAgentsResponse : gaxgrpc::IPageResponse<Agent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Agent> GetEnumerator() => Agents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAiApplicationMcpServersResponse : gaxgrpc::IPageResponse<McpServer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<McpServer> GetEnumerator() => McpServers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFindingsResponse : gaxgrpc::IPageResponse<Finding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Finding> GetEnumerator() => Findings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAiApplicationEndpointsResponse : gaxgrpc::IPageResponse<Endpoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Endpoint> GetEnumerator() => Endpoints.GetEnumerator();

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
