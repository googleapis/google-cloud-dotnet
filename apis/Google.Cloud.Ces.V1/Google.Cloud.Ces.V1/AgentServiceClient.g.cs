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

namespace Google.Cloud.Ces.V1
{
    /// <summary>Settings for <see cref="AgentServiceClient"/> instances.</summary>
    public sealed partial class AgentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AgentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AgentServiceSettings"/>.</returns>
        public static AgentServiceSettings GetDefault() => new AgentServiceSettings();

        /// <summary>Constructs a new <see cref="AgentServiceSettings"/> object with default settings.</summary>
        public AgentServiceSettings()
        {
        }

        private AgentServiceSettings(AgentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAppsSettings = existing.ListAppsSettings;
            GetAppSettings = existing.GetAppSettings;
            CreateAppSettings = existing.CreateAppSettings;
            CreateAppOperationsSettings = existing.CreateAppOperationsSettings.Clone();
            UpdateAppSettings = existing.UpdateAppSettings;
            DeleteAppSettings = existing.DeleteAppSettings;
            DeleteAppOperationsSettings = existing.DeleteAppOperationsSettings.Clone();
            ExportAppSettings = existing.ExportAppSettings;
            ExportAppOperationsSettings = existing.ExportAppOperationsSettings.Clone();
            ImportAppSettings = existing.ImportAppSettings;
            ImportAppOperationsSettings = existing.ImportAppOperationsSettings.Clone();
            ListAgentsSettings = existing.ListAgentsSettings;
            GetAgentSettings = existing.GetAgentSettings;
            CreateAgentSettings = existing.CreateAgentSettings;
            UpdateAgentSettings = existing.UpdateAgentSettings;
            DeleteAgentSettings = existing.DeleteAgentSettings;
            ListExamplesSettings = existing.ListExamplesSettings;
            GetExampleSettings = existing.GetExampleSettings;
            CreateExampleSettings = existing.CreateExampleSettings;
            UpdateExampleSettings = existing.UpdateExampleSettings;
            DeleteExampleSettings = existing.DeleteExampleSettings;
            ListToolsSettings = existing.ListToolsSettings;
            GetToolSettings = existing.GetToolSettings;
            ListConversationsSettings = existing.ListConversationsSettings;
            GetConversationSettings = existing.GetConversationSettings;
            DeleteConversationSettings = existing.DeleteConversationSettings;
            BatchDeleteConversationsSettings = existing.BatchDeleteConversationsSettings;
            BatchDeleteConversationsOperationsSettings = existing.BatchDeleteConversationsOperationsSettings.Clone();
            CreateToolSettings = existing.CreateToolSettings;
            UpdateToolSettings = existing.UpdateToolSettings;
            DeleteToolSettings = existing.DeleteToolSettings;
            ListGuardrailsSettings = existing.ListGuardrailsSettings;
            GetGuardrailSettings = existing.GetGuardrailSettings;
            CreateGuardrailSettings = existing.CreateGuardrailSettings;
            UpdateGuardrailSettings = existing.UpdateGuardrailSettings;
            DeleteGuardrailSettings = existing.DeleteGuardrailSettings;
            ListDeploymentsSettings = existing.ListDeploymentsSettings;
            GetDeploymentSettings = existing.GetDeploymentSettings;
            CreateDeploymentSettings = existing.CreateDeploymentSettings;
            UpdateDeploymentSettings = existing.UpdateDeploymentSettings;
            DeleteDeploymentSettings = existing.DeleteDeploymentSettings;
            ListToolsetsSettings = existing.ListToolsetsSettings;
            GetToolsetSettings = existing.GetToolsetSettings;
            CreateToolsetSettings = existing.CreateToolsetSettings;
            UpdateToolsetSettings = existing.UpdateToolsetSettings;
            DeleteToolsetSettings = existing.DeleteToolsetSettings;
            ListAppVersionsSettings = existing.ListAppVersionsSettings;
            GetAppVersionSettings = existing.GetAppVersionSettings;
            CreateAppVersionSettings = existing.CreateAppVersionSettings;
            DeleteAppVersionSettings = existing.DeleteAppVersionSettings;
            RestoreAppVersionSettings = existing.RestoreAppVersionSettings;
            RestoreAppVersionOperationsSettings = existing.RestoreAppVersionOperationsSettings.Clone();
            ListChangelogsSettings = existing.ListChangelogsSettings;
            GetChangelogSettings = existing.GetChangelogSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AgentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentServiceClient.ListApps</c>
        ///  and <c>AgentServiceClient.ListAppsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAppsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentServiceClient.GetApp</c>
        ///  and <c>AgentServiceClient.GetAppAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAppSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.CreateApp</c> and <c>AgentServiceClient.CreateAppAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAppSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentServiceClient.CreateApp</c> and
        /// <c>AgentServiceClient.CreateAppAsync</c>.
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
        public lro::OperationsSettings CreateAppOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.UpdateApp</c> and <c>AgentServiceClient.UpdateAppAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAppSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.DeleteApp</c> and <c>AgentServiceClient.DeleteAppAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAppSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentServiceClient.DeleteApp</c> and
        /// <c>AgentServiceClient.DeleteAppAsync</c>.
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
        public lro::OperationsSettings DeleteAppOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.ExportApp</c> and <c>AgentServiceClient.ExportAppAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportAppSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentServiceClient.ExportApp</c> and
        /// <c>AgentServiceClient.ExportAppAsync</c>.
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
        public lro::OperationsSettings ExportAppOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.ImportApp</c> and <c>AgentServiceClient.ImportAppAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportAppSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentServiceClient.ImportApp</c> and
        /// <c>AgentServiceClient.ImportAppAsync</c>.
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
        public lro::OperationsSettings ImportAppOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.ListAgents</c> and <c>AgentServiceClient.ListAgentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAgentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentServiceClient.GetAgent</c>
        ///  and <c>AgentServiceClient.GetAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.CreateAgent</c> and <c>AgentServiceClient.CreateAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.UpdateAgent</c> and <c>AgentServiceClient.UpdateAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.DeleteAgent</c> and <c>AgentServiceClient.DeleteAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.ListExamples</c> and <c>AgentServiceClient.ListExamplesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListExamplesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.GetExample</c> and <c>AgentServiceClient.GetExampleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExampleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.CreateExample</c> and <c>AgentServiceClient.CreateExampleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateExampleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.UpdateExample</c> and <c>AgentServiceClient.UpdateExampleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateExampleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.DeleteExample</c> and <c>AgentServiceClient.DeleteExampleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteExampleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.ListTools</c> and <c>AgentServiceClient.ListToolsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListToolsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentServiceClient.GetTool</c>
        ///  and <c>AgentServiceClient.GetToolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetToolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.ListConversations</c> and <c>AgentServiceClient.ListConversationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConversationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.GetConversation</c> and <c>AgentServiceClient.GetConversationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.DeleteConversation</c> and <c>AgentServiceClient.DeleteConversationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.BatchDeleteConversations</c> and <c>AgentServiceClient.BatchDeleteConversationsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeleteConversationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentServiceClient.BatchDeleteConversations</c> and
        /// <c>AgentServiceClient.BatchDeleteConversationsAsync</c>.
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
        public lro::OperationsSettings BatchDeleteConversationsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.CreateTool</c> and <c>AgentServiceClient.CreateToolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateToolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.UpdateTool</c> and <c>AgentServiceClient.UpdateToolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateToolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.DeleteTool</c> and <c>AgentServiceClient.DeleteToolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteToolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.ListGuardrails</c> and <c>AgentServiceClient.ListGuardrailsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGuardrailsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.GetGuardrail</c> and <c>AgentServiceClient.GetGuardrailAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGuardrailSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.CreateGuardrail</c> and <c>AgentServiceClient.CreateGuardrailAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGuardrailSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.UpdateGuardrail</c> and <c>AgentServiceClient.UpdateGuardrailAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGuardrailSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.DeleteGuardrail</c> and <c>AgentServiceClient.DeleteGuardrailAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGuardrailSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.ListDeployments</c> and <c>AgentServiceClient.ListDeploymentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeploymentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.GetDeployment</c> and <c>AgentServiceClient.GetDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.CreateDeployment</c> and <c>AgentServiceClient.CreateDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.UpdateDeployment</c> and <c>AgentServiceClient.UpdateDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.DeleteDeployment</c> and <c>AgentServiceClient.DeleteDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.ListToolsets</c> and <c>AgentServiceClient.ListToolsetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListToolsetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.GetToolset</c> and <c>AgentServiceClient.GetToolsetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetToolsetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.CreateToolset</c> and <c>AgentServiceClient.CreateToolsetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateToolsetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.UpdateToolset</c> and <c>AgentServiceClient.UpdateToolsetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateToolsetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.DeleteToolset</c> and <c>AgentServiceClient.DeleteToolsetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteToolsetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.ListAppVersions</c> and <c>AgentServiceClient.ListAppVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAppVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.GetAppVersion</c> and <c>AgentServiceClient.GetAppVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAppVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.CreateAppVersion</c> and <c>AgentServiceClient.CreateAppVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAppVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.DeleteAppVersion</c> and <c>AgentServiceClient.DeleteAppVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAppVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.RestoreAppVersion</c> and <c>AgentServiceClient.RestoreAppVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreAppVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentServiceClient.RestoreAppVersion</c> and
        /// <c>AgentServiceClient.RestoreAppVersionAsync</c>.
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
        public lro::OperationsSettings RestoreAppVersionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.ListChangelogs</c> and <c>AgentServiceClient.ListChangelogsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListChangelogsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentServiceClient.GetChangelog</c> and <c>AgentServiceClient.GetChangelogAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetChangelogSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AgentServiceSettings"/> object.</returns>
        public AgentServiceSettings Clone() => new AgentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AgentServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AgentServiceClientBuilder : gaxgrpc::ClientBuilderBase<AgentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AgentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AgentServiceClientBuilder() : base(AgentServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AgentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AgentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AgentServiceClient Build()
        {
            AgentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AgentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AgentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AgentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AgentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AgentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AgentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AgentServiceClient.ChannelPool;
    }

    /// <summary>AgentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that manages agent-related resources in Gemini Enterprise for
    /// Customer Engagement (CES).
    /// </remarks>
    public abstract partial class AgentServiceClient
    {
        /// <summary>
        /// The default endpoint for the AgentService service, which is a host of "ces.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "ces.googleapis.com:443";

        /// <summary>The default AgentService scopes.</summary>
        /// <remarks>
        /// The default AgentService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/ces</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/ces",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AgentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AgentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AgentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AgentServiceClient"/>.</returns>
        public static stt::Task<AgentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AgentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AgentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AgentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AgentServiceClient"/>.</returns>
        public static AgentServiceClient Create() => new AgentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AgentServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AgentServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AgentServiceClient"/>.</returns>
        internal static AgentServiceClient Create(grpccore::CallInvoker callInvoker, AgentServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AgentService.AgentServiceClient grpcClient = new AgentService.AgentServiceClient(callInvoker);
            return new AgentServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AgentService client</summary>
        public virtual AgentService.AgentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists apps in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="App"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppsResponse, App> ListApps(ListAppsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists apps in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="App"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppsResponse, App> ListAppsAsync(ListAppsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists apps in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to list apps from.
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
        /// <returns>A pageable sequence of <see cref="App"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppsResponse, App> ListApps(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppsRequest request = new ListAppsRequest
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
            return ListApps(request, callSettings);
        }

        /// <summary>
        /// Lists apps in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to list apps from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="App"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppsResponse, App> ListAppsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppsRequest request = new ListAppsRequest
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
            return ListAppsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists apps in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to list apps from.
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
        /// <returns>A pageable sequence of <see cref="App"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppsResponse, App> ListApps(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppsRequest request = new ListAppsRequest
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
            return ListApps(request, callSettings);
        }

        /// <summary>
        /// Lists apps in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to list apps from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="App"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppsResponse, App> ListAppsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppsRequest request = new ListAppsRequest
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
            return ListAppsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual App GetApp(GetAppRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<App> GetAppAsync(GetAppRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<App> GetAppAsync(GetAppRequest request, st::CancellationToken cancellationToken) =>
            GetAppAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual App GetApp(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApp(new GetAppRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<App> GetAppAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppAsync(new GetAppRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<App> GetAppAsync(string name, st::CancellationToken cancellationToken) =>
            GetAppAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual App GetApp(AppName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApp(new GetAppRequest
            {
                AppName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<App> GetAppAsync(AppName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppAsync(new GetAppRequest
            {
                AppName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<App> GetAppAsync(AppName name, st::CancellationToken cancellationToken) =>
            GetAppAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<App, OperationMetadata> CreateApp(CreateAppRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<App, OperationMetadata>> CreateAppAsync(CreateAppRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<App, OperationMetadata>> CreateAppAsync(CreateAppRequest request, st::CancellationToken cancellationToken) =>
            CreateAppAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateApp</c>.</summary>
        public virtual lro::OperationsClient CreateAppOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateApp</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<App, OperationMetadata> PollOnceCreateApp(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<App, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAppOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateApp</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<App, OperationMetadata>> PollOnceCreateAppAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<App, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAppOperationsClient, callSettings);

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create an app in.
        /// </param>
        /// <param name="app">
        /// Required. The app to create.
        /// </param>
        /// <param name="appId">
        /// Optional. The ID to use for the app, which will become the final component
        /// of the app's resource name. If not provided, a unique ID will be
        /// automatically assigned for the app.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<App, OperationMetadata> CreateApp(string parent, App app, string appId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApp(new CreateAppRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppId = appId ?? "",
                App = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create an app in.
        /// </param>
        /// <param name="app">
        /// Required. The app to create.
        /// </param>
        /// <param name="appId">
        /// Optional. The ID to use for the app, which will become the final component
        /// of the app's resource name. If not provided, a unique ID will be
        /// automatically assigned for the app.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<App, OperationMetadata>> CreateAppAsync(string parent, App app, string appId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppAsync(new CreateAppRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppId = appId ?? "",
                App = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create an app in.
        /// </param>
        /// <param name="app">
        /// Required. The app to create.
        /// </param>
        /// <param name="appId">
        /// Optional. The ID to use for the app, which will become the final component
        /// of the app's resource name. If not provided, a unique ID will be
        /// automatically assigned for the app.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<App, OperationMetadata>> CreateAppAsync(string parent, App app, string appId, st::CancellationToken cancellationToken) =>
            CreateAppAsync(parent, app, appId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create an app in.
        /// </param>
        /// <param name="app">
        /// Required. The app to create.
        /// </param>
        /// <param name="appId">
        /// Optional. The ID to use for the app, which will become the final component
        /// of the app's resource name. If not provided, a unique ID will be
        /// automatically assigned for the app.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<App, OperationMetadata> CreateApp(gagr::LocationName parent, App app, string appId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApp(new CreateAppRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppId = appId ?? "",
                App = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create an app in.
        /// </param>
        /// <param name="app">
        /// Required. The app to create.
        /// </param>
        /// <param name="appId">
        /// Optional. The ID to use for the app, which will become the final component
        /// of the app's resource name. If not provided, a unique ID will be
        /// automatically assigned for the app.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<App, OperationMetadata>> CreateAppAsync(gagr::LocationName parent, App app, string appId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppAsync(new CreateAppRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppId = appId ?? "",
                App = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create an app in.
        /// </param>
        /// <param name="app">
        /// Required. The app to create.
        /// </param>
        /// <param name="appId">
        /// Optional. The ID to use for the app, which will become the final component
        /// of the app's resource name. If not provided, a unique ID will be
        /// automatically assigned for the app.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<App, OperationMetadata>> CreateAppAsync(gagr::LocationName parent, App app, string appId, st::CancellationToken cancellationToken) =>
            CreateAppAsync(parent, app, appId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create an app in.
        /// </param>
        /// <param name="app">
        /// Required. The app to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<App, OperationMetadata> CreateApp(string parent, App app, gaxgrpc::CallSettings callSettings = null) =>
            CreateApp(new CreateAppRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                App = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create an app in.
        /// </param>
        /// <param name="app">
        /// Required. The app to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<App, OperationMetadata>> CreateAppAsync(string parent, App app, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppAsync(new CreateAppRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                App = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create an app in.
        /// </param>
        /// <param name="app">
        /// Required. The app to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<App, OperationMetadata>> CreateAppAsync(string parent, App app, st::CancellationToken cancellationToken) =>
            CreateAppAsync(parent, app, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create an app in.
        /// </param>
        /// <param name="app">
        /// Required. The app to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<App, OperationMetadata> CreateApp(gagr::LocationName parent, App app, gaxgrpc::CallSettings callSettings = null) =>
            CreateApp(new CreateAppRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                App = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create an app in.
        /// </param>
        /// <param name="app">
        /// Required. The app to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<App, OperationMetadata>> CreateAppAsync(gagr::LocationName parent, App app, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppAsync(new CreateAppRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                App = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create an app in.
        /// </param>
        /// <param name="app">
        /// Required. The app to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<App, OperationMetadata>> CreateAppAsync(gagr::LocationName parent, App app, st::CancellationToken cancellationToken) =>
            CreateAppAsync(parent, app, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual App UpdateApp(UpdateAppRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<App> UpdateAppAsync(UpdateAppRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<App> UpdateAppAsync(UpdateAppRequest request, st::CancellationToken cancellationToken) =>
            UpdateAppAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified app.
        /// </summary>
        /// <param name="app">
        /// Required. The app to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual App UpdateApp(App app, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApp(new UpdateAppRequest
            {
                App = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified app.
        /// </summary>
        /// <param name="app">
        /// Required. The app to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<App> UpdateAppAsync(App app, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAppAsync(new UpdateAppRequest
            {
                App = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified app.
        /// </summary>
        /// <param name="app">
        /// Required. The app to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<App> UpdateAppAsync(App app, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAppAsync(app, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApp(DeleteAppRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAppAsync(DeleteAppRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAppAsync(DeleteAppRequest request, st::CancellationToken cancellationToken) =>
            DeleteAppAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteApp</c>.</summary>
        public virtual lro::OperationsClient DeleteAppOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteApp</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteApp(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAppOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteApp</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAppAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAppOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApp(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApp(new DeleteAppRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAppAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppAsync(new DeleteAppRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAppAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAppAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApp(AppName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApp(new DeleteAppRequest
            {
                AppName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAppAsync(AppName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppAsync(new DeleteAppRequest
            {
                AppName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAppAsync(AppName name, st::CancellationToken cancellationToken) =>
            DeleteAppAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportAppResponse, OperationMetadata> ExportApp(ExportAppRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAppResponse, OperationMetadata>> ExportAppAsync(ExportAppRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAppResponse, OperationMetadata>> ExportAppAsync(ExportAppRequest request, st::CancellationToken cancellationToken) =>
            ExportAppAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportApp</c>.</summary>
        public virtual lro::OperationsClient ExportAppOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportApp</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportAppResponse, OperationMetadata> PollOnceExportApp(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportAppResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportAppOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportApp</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportAppResponse, OperationMetadata>> PollOnceExportAppAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportAppResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportAppOperationsClient, callSettings);

        /// <summary>
        /// Exports the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to export.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportAppResponse, OperationMetadata> ExportApp(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApp(new ExportAppRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to export.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAppResponse, OperationMetadata>> ExportAppAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportAppAsync(new ExportAppRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to export.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAppResponse, OperationMetadata>> ExportAppAsync(string name, st::CancellationToken cancellationToken) =>
            ExportAppAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to export.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportAppResponse, OperationMetadata> ExportApp(AppName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApp(new ExportAppRequest
            {
                AppName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to export.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAppResponse, OperationMetadata>> ExportAppAsync(AppName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportAppAsync(new ExportAppRequest
            {
                AppName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports the specified app.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app to export.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAppResponse, OperationMetadata>> ExportAppAsync(AppName name, st::CancellationToken cancellationToken) =>
            ExportAppAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportAppResponse, OperationMetadata> ImportApp(ImportAppRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportAppResponse, OperationMetadata>> ImportAppAsync(ImportAppRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportAppResponse, OperationMetadata>> ImportAppAsync(ImportAppRequest request, st::CancellationToken cancellationToken) =>
            ImportAppAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportApp</c>.</summary>
        public virtual lro::OperationsClient ImportAppOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportApp</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportAppResponse, OperationMetadata> PollOnceImportApp(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportAppResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportAppOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportApp</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportAppResponse, OperationMetadata>> PollOnceImportAppAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportAppResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportAppOperationsClient, callSettings);

        /// <summary>
        /// Imports the specified app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name with the location of the app to import.
        /// </param>
        /// <param name="displayName">
        /// Optional. The display name of the app to import.
        /// * If the app is created on import, and the display name is specified,
        /// the imported app will use this display name. If a conflict is detected
        /// with an existing app, a timestamp will be appended to the display name
        /// to make it unique.
        /// * If the app is a reimport, this field should not be set. Providing a
        /// display name during reimport will result in an INVALID_ARGUMENT error.
        /// </param>
        /// <param name="appId">
        /// Optional. The ID to use for the imported app.
        /// *  If not specified, a unique ID will be automatically assigned for
        /// the app.
        /// *  Otherwise, the imported app will use this ID as the final component of
        /// its resource name. If an app with the same ID already exists at the
        /// specified location in the project, the content of the existing app will be
        /// replaced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportAppResponse, OperationMetadata> ImportApp(string parent, string displayName, string appId, gaxgrpc::CallSettings callSettings = null) =>
            ImportApp(new ImportAppRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DisplayName = displayName ?? "",
                AppId = appId ?? "",
            }, callSettings);

        /// <summary>
        /// Imports the specified app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name with the location of the app to import.
        /// </param>
        /// <param name="displayName">
        /// Optional. The display name of the app to import.
        /// * If the app is created on import, and the display name is specified,
        /// the imported app will use this display name. If a conflict is detected
        /// with an existing app, a timestamp will be appended to the display name
        /// to make it unique.
        /// * If the app is a reimport, this field should not be set. Providing a
        /// display name during reimport will result in an INVALID_ARGUMENT error.
        /// </param>
        /// <param name="appId">
        /// Optional. The ID to use for the imported app.
        /// *  If not specified, a unique ID will be automatically assigned for
        /// the app.
        /// *  Otherwise, the imported app will use this ID as the final component of
        /// its resource name. If an app with the same ID already exists at the
        /// specified location in the project, the content of the existing app will be
        /// replaced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportAppResponse, OperationMetadata>> ImportAppAsync(string parent, string displayName, string appId, gaxgrpc::CallSettings callSettings = null) =>
            ImportAppAsync(new ImportAppRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DisplayName = displayName ?? "",
                AppId = appId ?? "",
            }, callSettings);

        /// <summary>
        /// Imports the specified app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name with the location of the app to import.
        /// </param>
        /// <param name="displayName">
        /// Optional. The display name of the app to import.
        /// * If the app is created on import, and the display name is specified,
        /// the imported app will use this display name. If a conflict is detected
        /// with an existing app, a timestamp will be appended to the display name
        /// to make it unique.
        /// * If the app is a reimport, this field should not be set. Providing a
        /// display name during reimport will result in an INVALID_ARGUMENT error.
        /// </param>
        /// <param name="appId">
        /// Optional. The ID to use for the imported app.
        /// *  If not specified, a unique ID will be automatically assigned for
        /// the app.
        /// *  Otherwise, the imported app will use this ID as the final component of
        /// its resource name. If an app with the same ID already exists at the
        /// specified location in the project, the content of the existing app will be
        /// replaced.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportAppResponse, OperationMetadata>> ImportAppAsync(string parent, string displayName, string appId, st::CancellationToken cancellationToken) =>
            ImportAppAsync(parent, displayName, appId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports the specified app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name with the location of the app to import.
        /// </param>
        /// <param name="displayName">
        /// Optional. The display name of the app to import.
        /// * If the app is created on import, and the display name is specified,
        /// the imported app will use this display name. If a conflict is detected
        /// with an existing app, a timestamp will be appended to the display name
        /// to make it unique.
        /// * If the app is a reimport, this field should not be set. Providing a
        /// display name during reimport will result in an INVALID_ARGUMENT error.
        /// </param>
        /// <param name="appId">
        /// Optional. The ID to use for the imported app.
        /// *  If not specified, a unique ID will be automatically assigned for
        /// the app.
        /// *  Otherwise, the imported app will use this ID as the final component of
        /// its resource name. If an app with the same ID already exists at the
        /// specified location in the project, the content of the existing app will be
        /// replaced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportAppResponse, OperationMetadata> ImportApp(gagr::LocationName parent, string displayName, string appId, gaxgrpc::CallSettings callSettings = null) =>
            ImportApp(new ImportAppRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DisplayName = displayName ?? "",
                AppId = appId ?? "",
            }, callSettings);

        /// <summary>
        /// Imports the specified app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name with the location of the app to import.
        /// </param>
        /// <param name="displayName">
        /// Optional. The display name of the app to import.
        /// * If the app is created on import, and the display name is specified,
        /// the imported app will use this display name. If a conflict is detected
        /// with an existing app, a timestamp will be appended to the display name
        /// to make it unique.
        /// * If the app is a reimport, this field should not be set. Providing a
        /// display name during reimport will result in an INVALID_ARGUMENT error.
        /// </param>
        /// <param name="appId">
        /// Optional. The ID to use for the imported app.
        /// *  If not specified, a unique ID will be automatically assigned for
        /// the app.
        /// *  Otherwise, the imported app will use this ID as the final component of
        /// its resource name. If an app with the same ID already exists at the
        /// specified location in the project, the content of the existing app will be
        /// replaced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportAppResponse, OperationMetadata>> ImportAppAsync(gagr::LocationName parent, string displayName, string appId, gaxgrpc::CallSettings callSettings = null) =>
            ImportAppAsync(new ImportAppRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DisplayName = displayName ?? "",
                AppId = appId ?? "",
            }, callSettings);

        /// <summary>
        /// Imports the specified app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name with the location of the app to import.
        /// </param>
        /// <param name="displayName">
        /// Optional. The display name of the app to import.
        /// * If the app is created on import, and the display name is specified,
        /// the imported app will use this display name. If a conflict is detected
        /// with an existing app, a timestamp will be appended to the display name
        /// to make it unique.
        /// * If the app is a reimport, this field should not be set. Providing a
        /// display name during reimport will result in an INVALID_ARGUMENT error.
        /// </param>
        /// <param name="appId">
        /// Optional. The ID to use for the imported app.
        /// *  If not specified, a unique ID will be automatically assigned for
        /// the app.
        /// *  Otherwise, the imported app will use this ID as the final component of
        /// its resource name. If an app with the same ID already exists at the
        /// specified location in the project, the content of the existing app will be
        /// replaced.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportAppResponse, OperationMetadata>> ImportAppAsync(gagr::LocationName parent, string displayName, string appId, st::CancellationToken cancellationToken) =>
            ImportAppAsync(parent, displayName, appId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists agents in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAgentsResponse, Agent> ListAgents(ListAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists agents in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAgentsResponse, Agent> ListAgentsAsync(ListAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists agents in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list agents from.
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
        /// Lists agents in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list agents from.
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
        /// Lists agents in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list agents from.
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
        public virtual gax::PagedEnumerable<ListAgentsResponse, Agent> ListAgents(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAgentsRequest request = new ListAgentsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists agents in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list agents from.
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
        public virtual gax::PagedAsyncEnumerable<ListAgentsResponse, Agent> ListAgentsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAgentsRequest request = new ListAgentsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Gets details of the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAgent(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(GetAgentRequest request, st::CancellationToken cancellationToken) =>
            GetAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the agent to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAgent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgent(new GetAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the agent to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentAsync(new GetAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the agent to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(string name, st::CancellationToken cancellationToken) =>
            GetAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the agent to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAgent(AgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgent(new GetAgentRequest
            {
                AgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the agent to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(AgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentAsync(new GetAgentRequest
            {
                AgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the agent to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(AgentName name, st::CancellationToken cancellationToken) =>
            GetAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent CreateAgent(CreateAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(CreateAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(CreateAgentRequest request, st::CancellationToken cancellationToken) =>
            CreateAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an agent in.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="agentId">
        /// Optional. The ID to use for the agent, which will become the final
        /// component of the agent's resource name. If not provided, a unique ID will
        /// be automatically assigned for the agent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent CreateAgent(string parent, Agent agent, string agentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgent(new CreateAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AgentId = agentId ?? "",
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an agent in.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="agentId">
        /// Optional. The ID to use for the agent, which will become the final
        /// component of the agent's resource name. If not provided, a unique ID will
        /// be automatically assigned for the agent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(string parent, Agent agent, string agentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgentAsync(new CreateAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AgentId = agentId ?? "",
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an agent in.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="agentId">
        /// Optional. The ID to use for the agent, which will become the final
        /// component of the agent's resource name. If not provided, a unique ID will
        /// be automatically assigned for the agent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(string parent, Agent agent, string agentId, st::CancellationToken cancellationToken) =>
            CreateAgentAsync(parent, agent, agentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an agent in.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="agentId">
        /// Optional. The ID to use for the agent, which will become the final
        /// component of the agent's resource name. If not provided, a unique ID will
        /// be automatically assigned for the agent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent CreateAgent(AppName parent, Agent agent, string agentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgent(new CreateAgentRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AgentId = agentId ?? "",
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an agent in.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="agentId">
        /// Optional. The ID to use for the agent, which will become the final
        /// component of the agent's resource name. If not provided, a unique ID will
        /// be automatically assigned for the agent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(AppName parent, Agent agent, string agentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgentAsync(new CreateAgentRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AgentId = agentId ?? "",
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an agent in.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="agentId">
        /// Optional. The ID to use for the agent, which will become the final
        /// component of the agent's resource name. If not provided, a unique ID will
        /// be automatically assigned for the agent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(AppName parent, Agent agent, string agentId, st::CancellationToken cancellationToken) =>
            CreateAgentAsync(parent, agent, agentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an agent in.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent CreateAgent(string parent, Agent agent, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgent(new CreateAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an agent in.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(string parent, Agent agent, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgentAsync(new CreateAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an agent in.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(string parent, Agent agent, st::CancellationToken cancellationToken) =>
            CreateAgentAsync(parent, agent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an agent in.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent CreateAgent(AppName parent, Agent agent, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgent(new CreateAgentRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an agent in.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(AppName parent, Agent agent, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgentAsync(new CreateAgentRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an agent in.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(AppName parent, Agent agent, st::CancellationToken cancellationToken) =>
            CreateAgentAsync(parent, agent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent UpdateAgent(UpdateAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> UpdateAgentAsync(UpdateAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> UpdateAgentAsync(UpdateAgentRequest request, st::CancellationToken cancellationToken) =>
            UpdateAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified agent.
        /// </summary>
        /// <param name="agent">
        /// Required. The agent to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent UpdateAgent(Agent agent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAgent(new UpdateAgentRequest
            {
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified agent.
        /// </summary>
        /// <param name="agent">
        /// Required. The agent to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> UpdateAgentAsync(Agent agent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAgentAsync(new UpdateAgentRequest
            {
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified agent.
        /// </summary>
        /// <param name="agent">
        /// Required. The agent to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> UpdateAgentAsync(Agent agent, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAgentAsync(agent, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgent(DeleteAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(DeleteAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(DeleteAgentRequest request, st::CancellationToken cancellationToken) =>
            DeleteAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the agent to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgent(new DeleteAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the agent to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentAsync(new DeleteAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the agent to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the agent to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgent(AgentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgent(new DeleteAgentRequest
            {
                AgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the agent to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(AgentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentAsync(new DeleteAgentRequest
            {
                AgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the agent to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(AgentName name, st::CancellationToken cancellationToken) =>
            DeleteAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists examples in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExamplesResponse, Example> ListExamples(ListExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists examples in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExamplesResponse, Example> ListExamplesAsync(ListExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists examples in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list examples from.
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
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExamplesResponse, Example> ListExamples(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExamplesRequest request = new ListExamplesRequest
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
            return ListExamples(request, callSettings);
        }

        /// <summary>
        /// Lists examples in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list examples from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExamplesResponse, Example> ListExamplesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExamplesRequest request = new ListExamplesRequest
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
            return ListExamplesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists examples in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list examples from.
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
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExamplesResponse, Example> ListExamples(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExamplesRequest request = new ListExamplesRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExamples(request, callSettings);
        }

        /// <summary>
        /// Lists examples in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list examples from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExamplesResponse, Example> ListExamplesAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExamplesRequest request = new ListExamplesRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExamplesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example GetExample(GetExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(GetExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(GetExampleRequest request, st::CancellationToken cancellationToken) =>
            GetExampleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the example to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example GetExample(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExample(new GetExampleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the example to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExampleAsync(new GetExampleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the example to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(string name, st::CancellationToken cancellationToken) =>
            GetExampleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the example to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example GetExample(ExampleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExample(new GetExampleRequest
            {
                ExampleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the example to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(ExampleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExampleAsync(new GetExampleRequest
            {
                ExampleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the example to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(ExampleName name, st::CancellationToken cancellationToken) =>
            GetExampleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example CreateExample(CreateExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(CreateExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(CreateExampleRequest request, st::CancellationToken cancellationToken) =>
            CreateExampleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an example in.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="exampleId">
        /// Optional. The ID to use for the example, which will become the final
        /// component of the example's resource name. If not provided, a unique ID will
        /// be automatically assigned for the example.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example CreateExample(string parent, Example example, string exampleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExample(new CreateExampleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExampleId = exampleId ?? "",
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
            }, callSettings);

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an example in.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="exampleId">
        /// Optional. The ID to use for the example, which will become the final
        /// component of the example's resource name. If not provided, a unique ID will
        /// be automatically assigned for the example.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(string parent, Example example, string exampleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExampleAsync(new CreateExampleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExampleId = exampleId ?? "",
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
            }, callSettings);

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an example in.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="exampleId">
        /// Optional. The ID to use for the example, which will become the final
        /// component of the example's resource name. If not provided, a unique ID will
        /// be automatically assigned for the example.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(string parent, Example example, string exampleId, st::CancellationToken cancellationToken) =>
            CreateExampleAsync(parent, example, exampleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an example in.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="exampleId">
        /// Optional. The ID to use for the example, which will become the final
        /// component of the example's resource name. If not provided, a unique ID will
        /// be automatically assigned for the example.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example CreateExample(AppName parent, Example example, string exampleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExample(new CreateExampleRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExampleId = exampleId ?? "",
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
            }, callSettings);

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an example in.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="exampleId">
        /// Optional. The ID to use for the example, which will become the final
        /// component of the example's resource name. If not provided, a unique ID will
        /// be automatically assigned for the example.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(AppName parent, Example example, string exampleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExampleAsync(new CreateExampleRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExampleId = exampleId ?? "",
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
            }, callSettings);

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an example in.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="exampleId">
        /// Optional. The ID to use for the example, which will become the final
        /// component of the example's resource name. If not provided, a unique ID will
        /// be automatically assigned for the example.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(AppName parent, Example example, string exampleId, st::CancellationToken cancellationToken) =>
            CreateExampleAsync(parent, example, exampleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an example in.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example CreateExample(string parent, Example example, gaxgrpc::CallSettings callSettings = null) =>
            CreateExample(new CreateExampleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
            }, callSettings);

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an example in.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(string parent, Example example, gaxgrpc::CallSettings callSettings = null) =>
            CreateExampleAsync(new CreateExampleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
            }, callSettings);

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an example in.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(string parent, Example example, st::CancellationToken cancellationToken) =>
            CreateExampleAsync(parent, example, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an example in.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example CreateExample(AppName parent, Example example, gaxgrpc::CallSettings callSettings = null) =>
            CreateExample(new CreateExampleRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
            }, callSettings);

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an example in.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(AppName parent, Example example, gaxgrpc::CallSettings callSettings = null) =>
            CreateExampleAsync(new CreateExampleRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
            }, callSettings);

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an example in.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(AppName parent, Example example, st::CancellationToken cancellationToken) =>
            CreateExampleAsync(parent, example, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example UpdateExample(UpdateExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> UpdateExampleAsync(UpdateExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> UpdateExampleAsync(UpdateExampleRequest request, st::CancellationToken cancellationToken) =>
            UpdateExampleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified example.
        /// </summary>
        /// <param name="example">
        /// Required. The example to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example UpdateExample(Example example, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExample(new UpdateExampleRequest
            {
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified example.
        /// </summary>
        /// <param name="example">
        /// Required. The example to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> UpdateExampleAsync(Example example, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExampleAsync(new UpdateExampleRequest
            {
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified example.
        /// </summary>
        /// <param name="example">
        /// Required. The example to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> UpdateExampleAsync(Example example, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateExampleAsync(example, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExample(DeleteExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExampleAsync(DeleteExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExampleAsync(DeleteExampleRequest request, st::CancellationToken cancellationToken) =>
            DeleteExampleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the example to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExample(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExample(new DeleteExampleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the example to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExampleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExampleAsync(new DeleteExampleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the example to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExampleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteExampleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the example to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExample(ExampleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExample(new DeleteExampleRequest
            {
                ExampleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the example to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExampleAsync(ExampleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExampleAsync(new DeleteExampleRequest
            {
                ExampleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the example to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExampleAsync(ExampleName name, st::CancellationToken cancellationToken) =>
            DeleteExampleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists tools in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListToolsResponse, Tool> ListTools(ListToolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists tools in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListToolsResponse, Tool> ListToolsAsync(ListToolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists tools in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list tools from.
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
        /// <returns>A pageable sequence of <see cref="Tool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListToolsResponse, Tool> ListTools(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolsRequest request = new ListToolsRequest
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
            return ListTools(request, callSettings);
        }

        /// <summary>
        /// Lists tools in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list tools from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Tool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListToolsResponse, Tool> ListToolsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolsRequest request = new ListToolsRequest
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
            return ListToolsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists tools in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list tools from.
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
        /// <returns>A pageable sequence of <see cref="Tool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListToolsResponse, Tool> ListTools(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolsRequest request = new ListToolsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTools(request, callSettings);
        }

        /// <summary>
        /// Lists tools in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list tools from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Tool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListToolsResponse, Tool> ListToolsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolsRequest request = new ListToolsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListToolsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool GetTool(GetToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> GetToolAsync(GetToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> GetToolAsync(GetToolRequest request, st::CancellationToken cancellationToken) =>
            GetToolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified tool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tool to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool GetTool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTool(new GetToolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified tool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tool to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> GetToolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetToolAsync(new GetToolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified tool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tool to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> GetToolAsync(string name, st::CancellationToken cancellationToken) =>
            GetToolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified tool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tool to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool GetTool(ToolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTool(new GetToolRequest
            {
                ToolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified tool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tool to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> GetToolAsync(ToolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetToolAsync(new GetToolRequest
            {
                ToolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified tool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tool to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> GetToolAsync(ToolName name, st::CancellationToken cancellationToken) =>
            GetToolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists conversations in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists conversations in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists conversations in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list conversations from.
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
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
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
            return ListConversations(request, callSettings);
        }

        /// <summary>
        /// Lists conversations in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list conversations from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
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
            return ListConversationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists conversations in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list conversations from.
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
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConversations(request, callSettings);
        }

        /// <summary>
        /// Lists conversations in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list conversations from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConversationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, st::CancellationToken cancellationToken) =>
            GetConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversation(new GetConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationAsync(new GetConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(string name, st::CancellationToken cancellationToken) =>
            GetConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversation(new GetConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationAsync(new GetConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(ConversationName name, st::CancellationToken cancellationToken) =>
            GetConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversation(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(DeleteConversationRequest request, st::CancellationToken cancellationToken) =>
            DeleteConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversation(new DeleteConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationAsync(new DeleteConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversation(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversation(new DeleteConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationAsync(new DeleteConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(ConversationName name, st::CancellationToken cancellationToken) =>
            DeleteConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch deletes the specified conversations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchDeleteConversationsResponse, OperationMetadata> BatchDeleteConversations(BatchDeleteConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch deletes the specified conversations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteConversationsResponse, OperationMetadata>> BatchDeleteConversationsAsync(BatchDeleteConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch deletes the specified conversations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteConversationsResponse, OperationMetadata>> BatchDeleteConversationsAsync(BatchDeleteConversationsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteConversationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchDeleteConversations</c>.</summary>
        public virtual lro::OperationsClient BatchDeleteConversationsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchDeleteConversations</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchDeleteConversationsResponse, OperationMetadata> PollOnceBatchDeleteConversations(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchDeleteConversationsResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteConversationsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchDeleteConversations</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteConversationsResponse, OperationMetadata>> PollOnceBatchDeleteConversationsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchDeleteConversationsResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteConversationsOperationsClient, callSettings);

        /// <summary>
        /// Batch deletes the specified conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to delete conversations from.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchDeleteConversationsResponse, OperationMetadata> BatchDeleteConversations(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteConversations(new BatchDeleteConversationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Batch deletes the specified conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to delete conversations from.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteConversationsResponse, OperationMetadata>> BatchDeleteConversationsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteConversationsAsync(new BatchDeleteConversationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Batch deletes the specified conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to delete conversations from.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteConversationsResponse, OperationMetadata>> BatchDeleteConversationsAsync(string parent, st::CancellationToken cancellationToken) =>
            BatchDeleteConversationsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch deletes the specified conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to delete conversations from.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchDeleteConversationsResponse, OperationMetadata> BatchDeleteConversations(AppName parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteConversations(new BatchDeleteConversationsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Batch deletes the specified conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to delete conversations from.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteConversationsResponse, OperationMetadata>> BatchDeleteConversationsAsync(AppName parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteConversationsAsync(new BatchDeleteConversationsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Batch deletes the specified conversations.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to delete conversations from.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteConversationsResponse, OperationMetadata>> BatchDeleteConversationsAsync(AppName parent, st::CancellationToken cancellationToken) =>
            BatchDeleteConversationsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool CreateTool(CreateToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(CreateToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(CreateToolRequest request, st::CancellationToken cancellationToken) =>
            CreateToolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a tool in.
        /// </param>
        /// <param name="tool">
        /// Required. The tool to create.
        /// </param>
        /// <param name="toolId">
        /// Optional. The ID to use for the tool, which will become the final component
        /// of the tool's resource name. If not provided, a unique ID will be
        /// automatically assigned for the tool.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool CreateTool(string parent, Tool tool, string toolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTool(new CreateToolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ToolId = toolId ?? "",
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
            }, callSettings);

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a tool in.
        /// </param>
        /// <param name="tool">
        /// Required. The tool to create.
        /// </param>
        /// <param name="toolId">
        /// Optional. The ID to use for the tool, which will become the final component
        /// of the tool's resource name. If not provided, a unique ID will be
        /// automatically assigned for the tool.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(string parent, Tool tool, string toolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolAsync(new CreateToolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ToolId = toolId ?? "",
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
            }, callSettings);

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a tool in.
        /// </param>
        /// <param name="tool">
        /// Required. The tool to create.
        /// </param>
        /// <param name="toolId">
        /// Optional. The ID to use for the tool, which will become the final component
        /// of the tool's resource name. If not provided, a unique ID will be
        /// automatically assigned for the tool.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(string parent, Tool tool, string toolId, st::CancellationToken cancellationToken) =>
            CreateToolAsync(parent, tool, toolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a tool in.
        /// </param>
        /// <param name="tool">
        /// Required. The tool to create.
        /// </param>
        /// <param name="toolId">
        /// Optional. The ID to use for the tool, which will become the final component
        /// of the tool's resource name. If not provided, a unique ID will be
        /// automatically assigned for the tool.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool CreateTool(AppName parent, Tool tool, string toolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTool(new CreateToolRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ToolId = toolId ?? "",
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
            }, callSettings);

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a tool in.
        /// </param>
        /// <param name="tool">
        /// Required. The tool to create.
        /// </param>
        /// <param name="toolId">
        /// Optional. The ID to use for the tool, which will become the final component
        /// of the tool's resource name. If not provided, a unique ID will be
        /// automatically assigned for the tool.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(AppName parent, Tool tool, string toolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolAsync(new CreateToolRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ToolId = toolId ?? "",
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
            }, callSettings);

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a tool in.
        /// </param>
        /// <param name="tool">
        /// Required. The tool to create.
        /// </param>
        /// <param name="toolId">
        /// Optional. The ID to use for the tool, which will become the final component
        /// of the tool's resource name. If not provided, a unique ID will be
        /// automatically assigned for the tool.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(AppName parent, Tool tool, string toolId, st::CancellationToken cancellationToken) =>
            CreateToolAsync(parent, tool, toolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a tool in.
        /// </param>
        /// <param name="tool">
        /// Required. The tool to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool CreateTool(string parent, Tool tool, gaxgrpc::CallSettings callSettings = null) =>
            CreateTool(new CreateToolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
            }, callSettings);

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a tool in.
        /// </param>
        /// <param name="tool">
        /// Required. The tool to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(string parent, Tool tool, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolAsync(new CreateToolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
            }, callSettings);

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a tool in.
        /// </param>
        /// <param name="tool">
        /// Required. The tool to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(string parent, Tool tool, st::CancellationToken cancellationToken) =>
            CreateToolAsync(parent, tool, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a tool in.
        /// </param>
        /// <param name="tool">
        /// Required. The tool to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool CreateTool(AppName parent, Tool tool, gaxgrpc::CallSettings callSettings = null) =>
            CreateTool(new CreateToolRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
            }, callSettings);

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a tool in.
        /// </param>
        /// <param name="tool">
        /// Required. The tool to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(AppName parent, Tool tool, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolAsync(new CreateToolRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
            }, callSettings);

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a tool in.
        /// </param>
        /// <param name="tool">
        /// Required. The tool to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(AppName parent, Tool tool, st::CancellationToken cancellationToken) =>
            CreateToolAsync(parent, tool, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool UpdateTool(UpdateToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> UpdateToolAsync(UpdateToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> UpdateToolAsync(UpdateToolRequest request, st::CancellationToken cancellationToken) =>
            UpdateToolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified tool.
        /// </summary>
        /// <param name="tool">
        /// Required. The tool to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool UpdateTool(Tool tool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTool(new UpdateToolRequest
            {
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified tool.
        /// </summary>
        /// <param name="tool">
        /// Required. The tool to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> UpdateToolAsync(Tool tool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateToolAsync(new UpdateToolRequest
            {
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified tool.
        /// </summary>
        /// <param name="tool">
        /// Required. The tool to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> UpdateToolAsync(Tool tool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateToolAsync(tool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTool(DeleteToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolAsync(DeleteToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolAsync(DeleteToolRequest request, st::CancellationToken cancellationToken) =>
            DeleteToolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified tool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tool to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTool(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTool(new DeleteToolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified tool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tool to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteToolAsync(new DeleteToolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified tool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tool to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteToolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified tool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tool to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTool(ToolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTool(new DeleteToolRequest
            {
                ToolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified tool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tool to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolAsync(ToolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteToolAsync(new DeleteToolRequest
            {
                ToolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified tool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tool to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolAsync(ToolName name, st::CancellationToken cancellationToken) =>
            DeleteToolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists guardrails in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Guardrail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGuardrailsResponse, Guardrail> ListGuardrails(ListGuardrailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists guardrails in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Guardrail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGuardrailsResponse, Guardrail> ListGuardrailsAsync(ListGuardrailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists guardrails in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list guardrails from.
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
        /// <returns>A pageable sequence of <see cref="Guardrail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGuardrailsResponse, Guardrail> ListGuardrails(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGuardrailsRequest request = new ListGuardrailsRequest
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
            return ListGuardrails(request, callSettings);
        }

        /// <summary>
        /// Lists guardrails in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list guardrails from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Guardrail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGuardrailsResponse, Guardrail> ListGuardrailsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGuardrailsRequest request = new ListGuardrailsRequest
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
            return ListGuardrailsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists guardrails in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list guardrails from.
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
        /// <returns>A pageable sequence of <see cref="Guardrail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGuardrailsResponse, Guardrail> ListGuardrails(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGuardrailsRequest request = new ListGuardrailsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGuardrails(request, callSettings);
        }

        /// <summary>
        /// Lists guardrails in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list guardrails from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Guardrail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGuardrailsResponse, Guardrail> ListGuardrailsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGuardrailsRequest request = new ListGuardrailsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGuardrailsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Guardrail GetGuardrail(GetGuardrailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> GetGuardrailAsync(GetGuardrailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> GetGuardrailAsync(GetGuardrailRequest request, st::CancellationToken cancellationToken) =>
            GetGuardrailAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified guardrail.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guardrail to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Guardrail GetGuardrail(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGuardrail(new GetGuardrailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified guardrail.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guardrail to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> GetGuardrailAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGuardrailAsync(new GetGuardrailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified guardrail.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guardrail to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> GetGuardrailAsync(string name, st::CancellationToken cancellationToken) =>
            GetGuardrailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified guardrail.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guardrail to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Guardrail GetGuardrail(GuardrailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGuardrail(new GetGuardrailRequest
            {
                GuardrailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified guardrail.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guardrail to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> GetGuardrailAsync(GuardrailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGuardrailAsync(new GetGuardrailRequest
            {
                GuardrailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified guardrail.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guardrail to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> GetGuardrailAsync(GuardrailName name, st::CancellationToken cancellationToken) =>
            GetGuardrailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Guardrail CreateGuardrail(CreateGuardrailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> CreateGuardrailAsync(CreateGuardrailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> CreateGuardrailAsync(CreateGuardrailRequest request, st::CancellationToken cancellationToken) =>
            CreateGuardrailAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a guardrail in.
        /// </param>
        /// <param name="guardrail">
        /// Required. The guardrail to create.
        /// </param>
        /// <param name="guardrailId">
        /// Optional. The ID to use for the guardrail, which will become the final
        /// component of the guardrail's resource name. If not provided, a unique ID
        /// will be automatically assigned for the guardrail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Guardrail CreateGuardrail(string parent, Guardrail guardrail, string guardrailId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGuardrail(new CreateGuardrailRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GuardrailId = guardrailId ?? "",
                Guardrail = gax::GaxPreconditions.CheckNotNull(guardrail, nameof(guardrail)),
            }, callSettings);

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a guardrail in.
        /// </param>
        /// <param name="guardrail">
        /// Required. The guardrail to create.
        /// </param>
        /// <param name="guardrailId">
        /// Optional. The ID to use for the guardrail, which will become the final
        /// component of the guardrail's resource name. If not provided, a unique ID
        /// will be automatically assigned for the guardrail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> CreateGuardrailAsync(string parent, Guardrail guardrail, string guardrailId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGuardrailAsync(new CreateGuardrailRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GuardrailId = guardrailId ?? "",
                Guardrail = gax::GaxPreconditions.CheckNotNull(guardrail, nameof(guardrail)),
            }, callSettings);

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a guardrail in.
        /// </param>
        /// <param name="guardrail">
        /// Required. The guardrail to create.
        /// </param>
        /// <param name="guardrailId">
        /// Optional. The ID to use for the guardrail, which will become the final
        /// component of the guardrail's resource name. If not provided, a unique ID
        /// will be automatically assigned for the guardrail.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> CreateGuardrailAsync(string parent, Guardrail guardrail, string guardrailId, st::CancellationToken cancellationToken) =>
            CreateGuardrailAsync(parent, guardrail, guardrailId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a guardrail in.
        /// </param>
        /// <param name="guardrail">
        /// Required. The guardrail to create.
        /// </param>
        /// <param name="guardrailId">
        /// Optional. The ID to use for the guardrail, which will become the final
        /// component of the guardrail's resource name. If not provided, a unique ID
        /// will be automatically assigned for the guardrail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Guardrail CreateGuardrail(AppName parent, Guardrail guardrail, string guardrailId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGuardrail(new CreateGuardrailRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GuardrailId = guardrailId ?? "",
                Guardrail = gax::GaxPreconditions.CheckNotNull(guardrail, nameof(guardrail)),
            }, callSettings);

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a guardrail in.
        /// </param>
        /// <param name="guardrail">
        /// Required. The guardrail to create.
        /// </param>
        /// <param name="guardrailId">
        /// Optional. The ID to use for the guardrail, which will become the final
        /// component of the guardrail's resource name. If not provided, a unique ID
        /// will be automatically assigned for the guardrail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> CreateGuardrailAsync(AppName parent, Guardrail guardrail, string guardrailId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGuardrailAsync(new CreateGuardrailRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GuardrailId = guardrailId ?? "",
                Guardrail = gax::GaxPreconditions.CheckNotNull(guardrail, nameof(guardrail)),
            }, callSettings);

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a guardrail in.
        /// </param>
        /// <param name="guardrail">
        /// Required. The guardrail to create.
        /// </param>
        /// <param name="guardrailId">
        /// Optional. The ID to use for the guardrail, which will become the final
        /// component of the guardrail's resource name. If not provided, a unique ID
        /// will be automatically assigned for the guardrail.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> CreateGuardrailAsync(AppName parent, Guardrail guardrail, string guardrailId, st::CancellationToken cancellationToken) =>
            CreateGuardrailAsync(parent, guardrail, guardrailId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a guardrail in.
        /// </param>
        /// <param name="guardrail">
        /// Required. The guardrail to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Guardrail CreateGuardrail(string parent, Guardrail guardrail, gaxgrpc::CallSettings callSettings = null) =>
            CreateGuardrail(new CreateGuardrailRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Guardrail = gax::GaxPreconditions.CheckNotNull(guardrail, nameof(guardrail)),
            }, callSettings);

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a guardrail in.
        /// </param>
        /// <param name="guardrail">
        /// Required. The guardrail to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> CreateGuardrailAsync(string parent, Guardrail guardrail, gaxgrpc::CallSettings callSettings = null) =>
            CreateGuardrailAsync(new CreateGuardrailRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Guardrail = gax::GaxPreconditions.CheckNotNull(guardrail, nameof(guardrail)),
            }, callSettings);

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a guardrail in.
        /// </param>
        /// <param name="guardrail">
        /// Required. The guardrail to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> CreateGuardrailAsync(string parent, Guardrail guardrail, st::CancellationToken cancellationToken) =>
            CreateGuardrailAsync(parent, guardrail, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a guardrail in.
        /// </param>
        /// <param name="guardrail">
        /// Required. The guardrail to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Guardrail CreateGuardrail(AppName parent, Guardrail guardrail, gaxgrpc::CallSettings callSettings = null) =>
            CreateGuardrail(new CreateGuardrailRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Guardrail = gax::GaxPreconditions.CheckNotNull(guardrail, nameof(guardrail)),
            }, callSettings);

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a guardrail in.
        /// </param>
        /// <param name="guardrail">
        /// Required. The guardrail to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> CreateGuardrailAsync(AppName parent, Guardrail guardrail, gaxgrpc::CallSettings callSettings = null) =>
            CreateGuardrailAsync(new CreateGuardrailRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Guardrail = gax::GaxPreconditions.CheckNotNull(guardrail, nameof(guardrail)),
            }, callSettings);

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a guardrail in.
        /// </param>
        /// <param name="guardrail">
        /// Required. The guardrail to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> CreateGuardrailAsync(AppName parent, Guardrail guardrail, st::CancellationToken cancellationToken) =>
            CreateGuardrailAsync(parent, guardrail, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Guardrail UpdateGuardrail(UpdateGuardrailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> UpdateGuardrailAsync(UpdateGuardrailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> UpdateGuardrailAsync(UpdateGuardrailRequest request, st::CancellationToken cancellationToken) =>
            UpdateGuardrailAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified guardrail.
        /// </summary>
        /// <param name="guardrail">
        /// Required. The guardrail to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Guardrail UpdateGuardrail(Guardrail guardrail, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGuardrail(new UpdateGuardrailRequest
            {
                Guardrail = gax::GaxPreconditions.CheckNotNull(guardrail, nameof(guardrail)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified guardrail.
        /// </summary>
        /// <param name="guardrail">
        /// Required. The guardrail to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> UpdateGuardrailAsync(Guardrail guardrail, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGuardrailAsync(new UpdateGuardrailRequest
            {
                Guardrail = gax::GaxPreconditions.CheckNotNull(guardrail, nameof(guardrail)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified guardrail.
        /// </summary>
        /// <param name="guardrail">
        /// Required. The guardrail to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Guardrail> UpdateGuardrailAsync(Guardrail guardrail, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGuardrailAsync(guardrail, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGuardrail(DeleteGuardrailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGuardrailAsync(DeleteGuardrailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGuardrailAsync(DeleteGuardrailRequest request, st::CancellationToken cancellationToken) =>
            DeleteGuardrailAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified guardrail.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guardrail to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGuardrail(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGuardrail(new DeleteGuardrailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified guardrail.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guardrail to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGuardrailAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGuardrailAsync(new DeleteGuardrailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified guardrail.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guardrail to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGuardrailAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGuardrailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified guardrail.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guardrail to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGuardrail(GuardrailName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGuardrail(new DeleteGuardrailRequest
            {
                GuardrailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified guardrail.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guardrail to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGuardrailAsync(GuardrailName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGuardrailAsync(new DeleteGuardrailRequest
            {
                GuardrailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified guardrail.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guardrail to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGuardrailAsync(GuardrailName name, st::CancellationToken cancellationToken) =>
            DeleteGuardrailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists deployments in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists deployments in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists deployments in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists deployments in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists deployments in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists deployments in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployment(new GetDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentAsync(new GetDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployment(new GetDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentAsync(new GetDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(CreateDeploymentRequest request, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The ID to use for the deployment, which will become the final
        /// component of the deployment's resource name. If not provided, a unique ID
        /// will be automatically assigned for the deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(string parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployment(new CreateDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeploymentId = deploymentId ?? "",
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The ID to use for the deployment, which will become the final
        /// component of the deployment's resource name. If not provided, a unique ID
        /// will be automatically assigned for the deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(string parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentAsync(new CreateDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeploymentId = deploymentId ?? "",
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The ID to use for the deployment, which will become the final
        /// component of the deployment's resource name. If not provided, a unique ID
        /// will be automatically assigned for the deployment.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(string parent, Deployment deployment, string deploymentId, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(parent, deployment, deploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The ID to use for the deployment, which will become the final
        /// component of the deployment's resource name. If not provided, a unique ID
        /// will be automatically assigned for the deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(AppName parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployment(new CreateDeploymentRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeploymentId = deploymentId ?? "",
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The ID to use for the deployment, which will become the final
        /// component of the deployment's resource name. If not provided, a unique ID
        /// will be automatically assigned for the deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(AppName parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentAsync(new CreateDeploymentRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeploymentId = deploymentId ?? "",
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The ID to use for the deployment, which will become the final
        /// component of the deployment's resource name. If not provided, a unique ID
        /// will be automatically assigned for the deployment.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(AppName parent, Deployment deployment, string deploymentId, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(parent, deployment, deploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(string parent, Deployment deployment, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployment(new CreateDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(string parent, Deployment deployment, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentAsync(new CreateDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(string parent, Deployment deployment, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(parent, deployment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(AppName parent, Deployment deployment, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployment(new CreateDeploymentRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(AppName parent, Deployment deployment, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentAsync(new CreateDeploymentRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent app.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(AppName parent, Deployment deployment, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(parent, deployment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment UpdateDeployment(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> UpdateDeploymentAsync(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> UpdateDeploymentAsync(UpdateDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UpdateDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified deployment.
        /// </summary>
        /// <param name="deployment">
        /// Required. The deployment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment UpdateDeployment(Deployment deployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeployment(new UpdateDeploymentRequest
            {
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified deployment.
        /// </summary>
        /// <param name="deployment">
        /// Required. The deployment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> UpdateDeploymentAsync(Deployment deployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeploymentAsync(new UpdateDeploymentRequest
            {
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified deployment.
        /// </summary>
        /// <param name="deployment">
        /// Required. The deployment to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> UpdateDeploymentAsync(Deployment deployment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDeploymentAsync(deployment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeployment(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(DeleteDeploymentRequest request, st::CancellationToken cancellationToken) =>
            DeleteDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeployment(new DeleteDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeploymentAsync(new DeleteDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeployment(new DeleteDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeploymentAsync(new DeleteDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            DeleteDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists toolsets in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Toolset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListToolsetsResponse, Toolset> ListToolsets(ListToolsetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists toolsets in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Toolset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListToolsetsResponse, Toolset> ListToolsetsAsync(ListToolsetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists toolsets in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list toolsets from.
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
        /// <returns>A pageable sequence of <see cref="Toolset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListToolsetsResponse, Toolset> ListToolsets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolsetsRequest request = new ListToolsetsRequest
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
            return ListToolsets(request, callSettings);
        }

        /// <summary>
        /// Lists toolsets in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list toolsets from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Toolset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListToolsetsResponse, Toolset> ListToolsetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolsetsRequest request = new ListToolsetsRequest
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
            return ListToolsetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists toolsets in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list toolsets from.
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
        /// <returns>A pageable sequence of <see cref="Toolset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListToolsetsResponse, Toolset> ListToolsets(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolsetsRequest request = new ListToolsetsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListToolsets(request, callSettings);
        }

        /// <summary>
        /// Lists toolsets in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list toolsets from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Toolset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListToolsetsResponse, Toolset> ListToolsetsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolsetsRequest request = new ListToolsetsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListToolsetsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Toolset GetToolset(GetToolsetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> GetToolsetAsync(GetToolsetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> GetToolsetAsync(GetToolsetRequest request, st::CancellationToken cancellationToken) =>
            GetToolsetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified toolset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the toolset to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Toolset GetToolset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetToolset(new GetToolsetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified toolset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the toolset to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> GetToolsetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetToolsetAsync(new GetToolsetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified toolset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the toolset to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> GetToolsetAsync(string name, st::CancellationToken cancellationToken) =>
            GetToolsetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified toolset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the toolset to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Toolset GetToolset(ToolsetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetToolset(new GetToolsetRequest
            {
                ToolsetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified toolset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the toolset to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> GetToolsetAsync(ToolsetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetToolsetAsync(new GetToolsetRequest
            {
                ToolsetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified toolset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the toolset to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> GetToolsetAsync(ToolsetName name, st::CancellationToken cancellationToken) =>
            GetToolsetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Toolset CreateToolset(CreateToolsetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> CreateToolsetAsync(CreateToolsetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> CreateToolsetAsync(CreateToolsetRequest request, st::CancellationToken cancellationToken) =>
            CreateToolsetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a toolset in.
        /// </param>
        /// <param name="toolset">
        /// Required. The toolset to create.
        /// </param>
        /// <param name="toolsetId">
        /// Optional. The ID to use for the toolset, which will become the final
        /// component of the toolset's resource name. If not provided, a unique ID will
        /// be automatically assigned for the toolset.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Toolset CreateToolset(string parent, Toolset toolset, string toolsetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolset(new CreateToolsetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ToolsetId = toolsetId ?? "",
                Toolset = gax::GaxPreconditions.CheckNotNull(toolset, nameof(toolset)),
            }, callSettings);

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a toolset in.
        /// </param>
        /// <param name="toolset">
        /// Required. The toolset to create.
        /// </param>
        /// <param name="toolsetId">
        /// Optional. The ID to use for the toolset, which will become the final
        /// component of the toolset's resource name. If not provided, a unique ID will
        /// be automatically assigned for the toolset.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> CreateToolsetAsync(string parent, Toolset toolset, string toolsetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolsetAsync(new CreateToolsetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ToolsetId = toolsetId ?? "",
                Toolset = gax::GaxPreconditions.CheckNotNull(toolset, nameof(toolset)),
            }, callSettings);

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a toolset in.
        /// </param>
        /// <param name="toolset">
        /// Required. The toolset to create.
        /// </param>
        /// <param name="toolsetId">
        /// Optional. The ID to use for the toolset, which will become the final
        /// component of the toolset's resource name. If not provided, a unique ID will
        /// be automatically assigned for the toolset.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> CreateToolsetAsync(string parent, Toolset toolset, string toolsetId, st::CancellationToken cancellationToken) =>
            CreateToolsetAsync(parent, toolset, toolsetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a toolset in.
        /// </param>
        /// <param name="toolset">
        /// Required. The toolset to create.
        /// </param>
        /// <param name="toolsetId">
        /// Optional. The ID to use for the toolset, which will become the final
        /// component of the toolset's resource name. If not provided, a unique ID will
        /// be automatically assigned for the toolset.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Toolset CreateToolset(AppName parent, Toolset toolset, string toolsetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolset(new CreateToolsetRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ToolsetId = toolsetId ?? "",
                Toolset = gax::GaxPreconditions.CheckNotNull(toolset, nameof(toolset)),
            }, callSettings);

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a toolset in.
        /// </param>
        /// <param name="toolset">
        /// Required. The toolset to create.
        /// </param>
        /// <param name="toolsetId">
        /// Optional. The ID to use for the toolset, which will become the final
        /// component of the toolset's resource name. If not provided, a unique ID will
        /// be automatically assigned for the toolset.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> CreateToolsetAsync(AppName parent, Toolset toolset, string toolsetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolsetAsync(new CreateToolsetRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ToolsetId = toolsetId ?? "",
                Toolset = gax::GaxPreconditions.CheckNotNull(toolset, nameof(toolset)),
            }, callSettings);

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a toolset in.
        /// </param>
        /// <param name="toolset">
        /// Required. The toolset to create.
        /// </param>
        /// <param name="toolsetId">
        /// Optional. The ID to use for the toolset, which will become the final
        /// component of the toolset's resource name. If not provided, a unique ID will
        /// be automatically assigned for the toolset.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> CreateToolsetAsync(AppName parent, Toolset toolset, string toolsetId, st::CancellationToken cancellationToken) =>
            CreateToolsetAsync(parent, toolset, toolsetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a toolset in.
        /// </param>
        /// <param name="toolset">
        /// Required. The toolset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Toolset CreateToolset(string parent, Toolset toolset, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolset(new CreateToolsetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Toolset = gax::GaxPreconditions.CheckNotNull(toolset, nameof(toolset)),
            }, callSettings);

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a toolset in.
        /// </param>
        /// <param name="toolset">
        /// Required. The toolset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> CreateToolsetAsync(string parent, Toolset toolset, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolsetAsync(new CreateToolsetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Toolset = gax::GaxPreconditions.CheckNotNull(toolset, nameof(toolset)),
            }, callSettings);

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a toolset in.
        /// </param>
        /// <param name="toolset">
        /// Required. The toolset to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> CreateToolsetAsync(string parent, Toolset toolset, st::CancellationToken cancellationToken) =>
            CreateToolsetAsync(parent, toolset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a toolset in.
        /// </param>
        /// <param name="toolset">
        /// Required. The toolset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Toolset CreateToolset(AppName parent, Toolset toolset, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolset(new CreateToolsetRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Toolset = gax::GaxPreconditions.CheckNotNull(toolset, nameof(toolset)),
            }, callSettings);

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a toolset in.
        /// </param>
        /// <param name="toolset">
        /// Required. The toolset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> CreateToolsetAsync(AppName parent, Toolset toolset, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolsetAsync(new CreateToolsetRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Toolset = gax::GaxPreconditions.CheckNotNull(toolset, nameof(toolset)),
            }, callSettings);

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create a toolset in.
        /// </param>
        /// <param name="toolset">
        /// Required. The toolset to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> CreateToolsetAsync(AppName parent, Toolset toolset, st::CancellationToken cancellationToken) =>
            CreateToolsetAsync(parent, toolset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Toolset UpdateToolset(UpdateToolsetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> UpdateToolsetAsync(UpdateToolsetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> UpdateToolsetAsync(UpdateToolsetRequest request, st::CancellationToken cancellationToken) =>
            UpdateToolsetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified toolset.
        /// </summary>
        /// <param name="toolset">
        /// Required. The toolset to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Toolset UpdateToolset(Toolset toolset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateToolset(new UpdateToolsetRequest
            {
                Toolset = gax::GaxPreconditions.CheckNotNull(toolset, nameof(toolset)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified toolset.
        /// </summary>
        /// <param name="toolset">
        /// Required. The toolset to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> UpdateToolsetAsync(Toolset toolset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateToolsetAsync(new UpdateToolsetRequest
            {
                Toolset = gax::GaxPreconditions.CheckNotNull(toolset, nameof(toolset)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified toolset.
        /// </summary>
        /// <param name="toolset">
        /// Required. The toolset to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Toolset> UpdateToolsetAsync(Toolset toolset, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateToolsetAsync(toolset, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteToolset(DeleteToolsetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolsetAsync(DeleteToolsetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolsetAsync(DeleteToolsetRequest request, st::CancellationToken cancellationToken) =>
            DeleteToolsetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified toolset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the toolset to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteToolset(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteToolset(new DeleteToolsetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified toolset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the toolset to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolsetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteToolsetAsync(new DeleteToolsetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified toolset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the toolset to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolsetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteToolsetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified toolset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the toolset to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteToolset(ToolsetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteToolset(new DeleteToolsetRequest
            {
                ToolsetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified toolset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the toolset to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolsetAsync(ToolsetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteToolsetAsync(new DeleteToolsetRequest
            {
                ToolsetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified toolset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the toolset to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolsetAsync(ToolsetName name, st::CancellationToken cancellationToken) =>
            DeleteToolsetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all app versions in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AppVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppVersionsResponse, AppVersion> ListAppVersions(ListAppVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all app versions in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AppVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppVersionsResponse, AppVersion> ListAppVersionsAsync(ListAppVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all app versions in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list app versions from.
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
        /// <returns>A pageable sequence of <see cref="AppVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppVersionsResponse, AppVersion> ListAppVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppVersionsRequest request = new ListAppVersionsRequest
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
            return ListAppVersions(request, callSettings);
        }

        /// <summary>
        /// Lists all app versions in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list app versions from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AppVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppVersionsResponse, AppVersion> ListAppVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppVersionsRequest request = new ListAppVersionsRequest
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
            return ListAppVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all app versions in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list app versions from.
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
        /// <returns>A pageable sequence of <see cref="AppVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppVersionsResponse, AppVersion> ListAppVersions(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppVersionsRequest request = new ListAppVersionsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAppVersions(request, callSettings);
        }

        /// <summary>
        /// Lists all app versions in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list app versions from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AppVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppVersionsResponse, AppVersion> ListAppVersionsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppVersionsRequest request = new ListAppVersionsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAppVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppVersion GetAppVersion(GetAppVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> GetAppVersionAsync(GetAppVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> GetAppVersionAsync(GetAppVersionRequest request, st::CancellationToken cancellationToken) =>
            GetAppVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppVersion GetAppVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppVersion(new GetAppVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> GetAppVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppVersionAsync(new GetAppVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> GetAppVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetAppVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppVersion GetAppVersion(AppVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppVersion(new GetAppVersionRequest
            {
                AppVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> GetAppVersionAsync(AppVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppVersionAsync(new GetAppVersionRequest
            {
                AppVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> GetAppVersionAsync(AppVersionName name, st::CancellationToken cancellationToken) =>
            GetAppVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppVersion CreateAppVersion(CreateAppVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> CreateAppVersionAsync(CreateAppVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> CreateAppVersionAsync(CreateAppVersionRequest request, st::CancellationToken cancellationToken) =>
            CreateAppVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an app version in.
        /// </param>
        /// <param name="appVersion">
        /// Required. The app version to create.
        /// </param>
        /// <param name="appVersionId">
        /// Optional. The ID to use for the app version, which will become the final
        /// component of the app version's resource name. If not provided, a unique ID
        /// will be automatically assigned for the app version.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppVersion CreateAppVersion(string parent, AppVersion appVersion, string appVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppVersion(new CreateAppVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppVersionId = appVersionId ?? "",
                AppVersion = gax::GaxPreconditions.CheckNotNull(appVersion, nameof(appVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an app version in.
        /// </param>
        /// <param name="appVersion">
        /// Required. The app version to create.
        /// </param>
        /// <param name="appVersionId">
        /// Optional. The ID to use for the app version, which will become the final
        /// component of the app version's resource name. If not provided, a unique ID
        /// will be automatically assigned for the app version.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> CreateAppVersionAsync(string parent, AppVersion appVersion, string appVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppVersionAsync(new CreateAppVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppVersionId = appVersionId ?? "",
                AppVersion = gax::GaxPreconditions.CheckNotNull(appVersion, nameof(appVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an app version in.
        /// </param>
        /// <param name="appVersion">
        /// Required. The app version to create.
        /// </param>
        /// <param name="appVersionId">
        /// Optional. The ID to use for the app version, which will become the final
        /// component of the app version's resource name. If not provided, a unique ID
        /// will be automatically assigned for the app version.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> CreateAppVersionAsync(string parent, AppVersion appVersion, string appVersionId, st::CancellationToken cancellationToken) =>
            CreateAppVersionAsync(parent, appVersion, appVersionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an app version in.
        /// </param>
        /// <param name="appVersion">
        /// Required. The app version to create.
        /// </param>
        /// <param name="appVersionId">
        /// Optional. The ID to use for the app version, which will become the final
        /// component of the app version's resource name. If not provided, a unique ID
        /// will be automatically assigned for the app version.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppVersion CreateAppVersion(AppName parent, AppVersion appVersion, string appVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppVersion(new CreateAppVersionRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppVersionId = appVersionId ?? "",
                AppVersion = gax::GaxPreconditions.CheckNotNull(appVersion, nameof(appVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an app version in.
        /// </param>
        /// <param name="appVersion">
        /// Required. The app version to create.
        /// </param>
        /// <param name="appVersionId">
        /// Optional. The ID to use for the app version, which will become the final
        /// component of the app version's resource name. If not provided, a unique ID
        /// will be automatically assigned for the app version.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> CreateAppVersionAsync(AppName parent, AppVersion appVersion, string appVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppVersionAsync(new CreateAppVersionRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppVersionId = appVersionId ?? "",
                AppVersion = gax::GaxPreconditions.CheckNotNull(appVersion, nameof(appVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an app version in.
        /// </param>
        /// <param name="appVersion">
        /// Required. The app version to create.
        /// </param>
        /// <param name="appVersionId">
        /// Optional. The ID to use for the app version, which will become the final
        /// component of the app version's resource name. If not provided, a unique ID
        /// will be automatically assigned for the app version.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> CreateAppVersionAsync(AppName parent, AppVersion appVersion, string appVersionId, st::CancellationToken cancellationToken) =>
            CreateAppVersionAsync(parent, appVersion, appVersionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an app version in.
        /// </param>
        /// <param name="appVersion">
        /// Required. The app version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppVersion CreateAppVersion(string parent, AppVersion appVersion, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppVersion(new CreateAppVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppVersion = gax::GaxPreconditions.CheckNotNull(appVersion, nameof(appVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an app version in.
        /// </param>
        /// <param name="appVersion">
        /// Required. The app version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> CreateAppVersionAsync(string parent, AppVersion appVersion, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppVersionAsync(new CreateAppVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppVersion = gax::GaxPreconditions.CheckNotNull(appVersion, nameof(appVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an app version in.
        /// </param>
        /// <param name="appVersion">
        /// Required. The app version to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> CreateAppVersionAsync(string parent, AppVersion appVersion, st::CancellationToken cancellationToken) =>
            CreateAppVersionAsync(parent, appVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an app version in.
        /// </param>
        /// <param name="appVersion">
        /// Required. The app version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppVersion CreateAppVersion(AppName parent, AppVersion appVersion, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppVersion(new CreateAppVersionRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppVersion = gax::GaxPreconditions.CheckNotNull(appVersion, nameof(appVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an app version in.
        /// </param>
        /// <param name="appVersion">
        /// Required. The app version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> CreateAppVersionAsync(AppName parent, AppVersion appVersion, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppVersionAsync(new CreateAppVersionRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppVersion = gax::GaxPreconditions.CheckNotNull(appVersion, nameof(appVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to create an app version in.
        /// </param>
        /// <param name="appVersion">
        /// Required. The app version to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppVersion> CreateAppVersionAsync(AppName parent, AppVersion appVersion, st::CancellationToken cancellationToken) =>
            CreateAppVersionAsync(parent, appVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAppVersion(DeleteAppVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppVersionAsync(DeleteAppVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppVersionAsync(DeleteAppVersionRequest request, st::CancellationToken cancellationToken) =>
            DeleteAppVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAppVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppVersion(new DeleteAppVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppVersionAsync(new DeleteAppVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAppVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAppVersion(AppVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppVersion(new DeleteAppVersionRequest
            {
                AppVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppVersionAsync(AppVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppVersionAsync(new DeleteAppVersionRequest
            {
                AppVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAppVersionAsync(AppVersionName name, st::CancellationToken cancellationToken) =>
            DeleteAppVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores the specified app version.
        /// This will create a new app version from the current draft app and overwrite
        /// the current draft with the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RestoreAppVersionResponse, OperationMetadata> RestoreAppVersion(RestoreAppVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores the specified app version.
        /// This will create a new app version from the current draft app and overwrite
        /// the current draft with the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestoreAppVersionResponse, OperationMetadata>> RestoreAppVersionAsync(RestoreAppVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores the specified app version.
        /// This will create a new app version from the current draft app and overwrite
        /// the current draft with the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestoreAppVersionResponse, OperationMetadata>> RestoreAppVersionAsync(RestoreAppVersionRequest request, st::CancellationToken cancellationToken) =>
            RestoreAppVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestoreAppVersion</c>.</summary>
        public virtual lro::OperationsClient RestoreAppVersionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestoreAppVersion</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RestoreAppVersionResponse, OperationMetadata> PollOnceRestoreAppVersion(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RestoreAppVersionResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreAppVersionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreAppVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RestoreAppVersionResponse, OperationMetadata>> PollOnceRestoreAppVersionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RestoreAppVersionResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreAppVersionOperationsClient, callSettings);

        /// <summary>
        /// Restores the specified app version.
        /// This will create a new app version from the current draft app and overwrite
        /// the current draft with the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to restore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RestoreAppVersionResponse, OperationMetadata> RestoreAppVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreAppVersion(new RestoreAppVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restores the specified app version.
        /// This will create a new app version from the current draft app and overwrite
        /// the current draft with the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to restore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestoreAppVersionResponse, OperationMetadata>> RestoreAppVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreAppVersionAsync(new RestoreAppVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restores the specified app version.
        /// This will create a new app version from the current draft app and overwrite
        /// the current draft with the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to restore.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestoreAppVersionResponse, OperationMetadata>> RestoreAppVersionAsync(string name, st::CancellationToken cancellationToken) =>
            RestoreAppVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores the specified app version.
        /// This will create a new app version from the current draft app and overwrite
        /// the current draft with the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to restore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RestoreAppVersionResponse, OperationMetadata> RestoreAppVersion(AppVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreAppVersion(new RestoreAppVersionRequest
            {
                AppVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restores the specified app version.
        /// This will create a new app version from the current draft app and overwrite
        /// the current draft with the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to restore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestoreAppVersionResponse, OperationMetadata>> RestoreAppVersionAsync(AppVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreAppVersionAsync(new RestoreAppVersionRequest
            {
                AppVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restores the specified app version.
        /// This will create a new app version from the current draft app and overwrite
        /// the current draft with the specified app version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the app version to restore.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestoreAppVersionResponse, OperationMetadata>> RestoreAppVersionAsync(AppVersionName name, st::CancellationToken cancellationToken) =>
            RestoreAppVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the changelogs of the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Changelog"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChangelogsResponse, Changelog> ListChangelogs(ListChangelogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the changelogs of the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Changelog"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChangelogsResponse, Changelog> ListChangelogsAsync(ListChangelogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the changelogs of the specified app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list changelogs from.
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
        /// <returns>A pageable sequence of <see cref="Changelog"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChangelogsResponse, Changelog> ListChangelogs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChangelogsRequest request = new ListChangelogsRequest
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
            return ListChangelogs(request, callSettings);
        }

        /// <summary>
        /// Lists the changelogs of the specified app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list changelogs from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Changelog"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChangelogsResponse, Changelog> ListChangelogsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChangelogsRequest request = new ListChangelogsRequest
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
            return ListChangelogsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the changelogs of the specified app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list changelogs from.
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
        /// <returns>A pageable sequence of <see cref="Changelog"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChangelogsResponse, Changelog> ListChangelogs(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChangelogsRequest request = new ListChangelogsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListChangelogs(request, callSettings);
        }

        /// <summary>
        /// Lists the changelogs of the specified app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list changelogs from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Changelog"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChangelogsResponse, Changelog> ListChangelogsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChangelogsRequest request = new ListChangelogsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListChangelogsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified changelog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Changelog GetChangelog(GetChangelogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified changelog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Changelog> GetChangelogAsync(GetChangelogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified changelog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Changelog> GetChangelogAsync(GetChangelogRequest request, st::CancellationToken cancellationToken) =>
            GetChangelogAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified changelog.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the changelog to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Changelog GetChangelog(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChangelog(new GetChangelogRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified changelog.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the changelog to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Changelog> GetChangelogAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChangelogAsync(new GetChangelogRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified changelog.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the changelog to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Changelog> GetChangelogAsync(string name, st::CancellationToken cancellationToken) =>
            GetChangelogAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified changelog.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the changelog to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Changelog GetChangelog(ChangelogName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChangelog(new GetChangelogRequest
            {
                ChangelogName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified changelog.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the changelog to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Changelog> GetChangelogAsync(ChangelogName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChangelogAsync(new GetChangelogRequest
            {
                ChangelogName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified changelog.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the changelog to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Changelog> GetChangelogAsync(ChangelogName name, st::CancellationToken cancellationToken) =>
            GetChangelogAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AgentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that manages agent-related resources in Gemini Enterprise for
    /// Customer Engagement (CES).
    /// </remarks>
    public sealed partial class AgentServiceClientImpl : AgentServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListAppsRequest, ListAppsResponse> _callListApps;

        private readonly gaxgrpc::ApiCall<GetAppRequest, App> _callGetApp;

        private readonly gaxgrpc::ApiCall<CreateAppRequest, lro::Operation> _callCreateApp;

        private readonly gaxgrpc::ApiCall<UpdateAppRequest, App> _callUpdateApp;

        private readonly gaxgrpc::ApiCall<DeleteAppRequest, lro::Operation> _callDeleteApp;

        private readonly gaxgrpc::ApiCall<ExportAppRequest, lro::Operation> _callExportApp;

        private readonly gaxgrpc::ApiCall<ImportAppRequest, lro::Operation> _callImportApp;

        private readonly gaxgrpc::ApiCall<ListAgentsRequest, ListAgentsResponse> _callListAgents;

        private readonly gaxgrpc::ApiCall<GetAgentRequest, Agent> _callGetAgent;

        private readonly gaxgrpc::ApiCall<CreateAgentRequest, Agent> _callCreateAgent;

        private readonly gaxgrpc::ApiCall<UpdateAgentRequest, Agent> _callUpdateAgent;

        private readonly gaxgrpc::ApiCall<DeleteAgentRequest, wkt::Empty> _callDeleteAgent;

        private readonly gaxgrpc::ApiCall<ListExamplesRequest, ListExamplesResponse> _callListExamples;

        private readonly gaxgrpc::ApiCall<GetExampleRequest, Example> _callGetExample;

        private readonly gaxgrpc::ApiCall<CreateExampleRequest, Example> _callCreateExample;

        private readonly gaxgrpc::ApiCall<UpdateExampleRequest, Example> _callUpdateExample;

        private readonly gaxgrpc::ApiCall<DeleteExampleRequest, wkt::Empty> _callDeleteExample;

        private readonly gaxgrpc::ApiCall<ListToolsRequest, ListToolsResponse> _callListTools;

        private readonly gaxgrpc::ApiCall<GetToolRequest, Tool> _callGetTool;

        private readonly gaxgrpc::ApiCall<ListConversationsRequest, ListConversationsResponse> _callListConversations;

        private readonly gaxgrpc::ApiCall<GetConversationRequest, Conversation> _callGetConversation;

        private readonly gaxgrpc::ApiCall<DeleteConversationRequest, wkt::Empty> _callDeleteConversation;

        private readonly gaxgrpc::ApiCall<BatchDeleteConversationsRequest, lro::Operation> _callBatchDeleteConversations;

        private readonly gaxgrpc::ApiCall<CreateToolRequest, Tool> _callCreateTool;

        private readonly gaxgrpc::ApiCall<UpdateToolRequest, Tool> _callUpdateTool;

        private readonly gaxgrpc::ApiCall<DeleteToolRequest, wkt::Empty> _callDeleteTool;

        private readonly gaxgrpc::ApiCall<ListGuardrailsRequest, ListGuardrailsResponse> _callListGuardrails;

        private readonly gaxgrpc::ApiCall<GetGuardrailRequest, Guardrail> _callGetGuardrail;

        private readonly gaxgrpc::ApiCall<CreateGuardrailRequest, Guardrail> _callCreateGuardrail;

        private readonly gaxgrpc::ApiCall<UpdateGuardrailRequest, Guardrail> _callUpdateGuardrail;

        private readonly gaxgrpc::ApiCall<DeleteGuardrailRequest, wkt::Empty> _callDeleteGuardrail;

        private readonly gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> _callListDeployments;

        private readonly gaxgrpc::ApiCall<GetDeploymentRequest, Deployment> _callGetDeployment;

        private readonly gaxgrpc::ApiCall<CreateDeploymentRequest, Deployment> _callCreateDeployment;

        private readonly gaxgrpc::ApiCall<UpdateDeploymentRequest, Deployment> _callUpdateDeployment;

        private readonly gaxgrpc::ApiCall<DeleteDeploymentRequest, wkt::Empty> _callDeleteDeployment;

        private readonly gaxgrpc::ApiCall<ListToolsetsRequest, ListToolsetsResponse> _callListToolsets;

        private readonly gaxgrpc::ApiCall<GetToolsetRequest, Toolset> _callGetToolset;

        private readonly gaxgrpc::ApiCall<CreateToolsetRequest, Toolset> _callCreateToolset;

        private readonly gaxgrpc::ApiCall<UpdateToolsetRequest, Toolset> _callUpdateToolset;

        private readonly gaxgrpc::ApiCall<DeleteToolsetRequest, wkt::Empty> _callDeleteToolset;

        private readonly gaxgrpc::ApiCall<ListAppVersionsRequest, ListAppVersionsResponse> _callListAppVersions;

        private readonly gaxgrpc::ApiCall<GetAppVersionRequest, AppVersion> _callGetAppVersion;

        private readonly gaxgrpc::ApiCall<CreateAppVersionRequest, AppVersion> _callCreateAppVersion;

        private readonly gaxgrpc::ApiCall<DeleteAppVersionRequest, wkt::Empty> _callDeleteAppVersion;

        private readonly gaxgrpc::ApiCall<RestoreAppVersionRequest, lro::Operation> _callRestoreAppVersion;

        private readonly gaxgrpc::ApiCall<ListChangelogsRequest, ListChangelogsResponse> _callListChangelogs;

        private readonly gaxgrpc::ApiCall<GetChangelogRequest, Changelog> _callGetChangelog;

        /// <summary>
        /// Constructs a client wrapper for the AgentService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AgentServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AgentServiceClientImpl(AgentService.AgentServiceClient grpcClient, AgentServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AgentServiceSettings effectiveSettings = settings ?? AgentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateAppOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAppOperationsSettings, logger);
            DeleteAppOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAppOperationsSettings, logger);
            ExportAppOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportAppOperationsSettings, logger);
            ImportAppOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportAppOperationsSettings, logger);
            BatchDeleteConversationsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchDeleteConversationsOperationsSettings, logger);
            RestoreAppVersionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreAppVersionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListApps = clientHelper.BuildApiCall<ListAppsRequest, ListAppsResponse>("ListApps", grpcClient.ListAppsAsync, grpcClient.ListApps, effectiveSettings.ListAppsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApps);
            Modify_ListAppsApiCall(ref _callListApps);
            _callGetApp = clientHelper.BuildApiCall<GetAppRequest, App>("GetApp", grpcClient.GetAppAsync, grpcClient.GetApp, effectiveSettings.GetAppSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApp);
            Modify_GetAppApiCall(ref _callGetApp);
            _callCreateApp = clientHelper.BuildApiCall<CreateAppRequest, lro::Operation>("CreateApp", grpcClient.CreateAppAsync, grpcClient.CreateApp, effectiveSettings.CreateAppSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApp);
            Modify_CreateAppApiCall(ref _callCreateApp);
            _callUpdateApp = clientHelper.BuildApiCall<UpdateAppRequest, App>("UpdateApp", grpcClient.UpdateAppAsync, grpcClient.UpdateApp, effectiveSettings.UpdateAppSettings).WithGoogleRequestParam("app.name", request => request.App?.Name);
            Modify_ApiCall(ref _callUpdateApp);
            Modify_UpdateAppApiCall(ref _callUpdateApp);
            _callDeleteApp = clientHelper.BuildApiCall<DeleteAppRequest, lro::Operation>("DeleteApp", grpcClient.DeleteAppAsync, grpcClient.DeleteApp, effectiveSettings.DeleteAppSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApp);
            Modify_DeleteAppApiCall(ref _callDeleteApp);
            _callExportApp = clientHelper.BuildApiCall<ExportAppRequest, lro::Operation>("ExportApp", grpcClient.ExportAppAsync, grpcClient.ExportApp, effectiveSettings.ExportAppSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportApp);
            Modify_ExportAppApiCall(ref _callExportApp);
            _callImportApp = clientHelper.BuildApiCall<ImportAppRequest, lro::Operation>("ImportApp", grpcClient.ImportAppAsync, grpcClient.ImportApp, effectiveSettings.ImportAppSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportApp);
            Modify_ImportAppApiCall(ref _callImportApp);
            _callListAgents = clientHelper.BuildApiCall<ListAgentsRequest, ListAgentsResponse>("ListAgents", grpcClient.ListAgentsAsync, grpcClient.ListAgents, effectiveSettings.ListAgentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAgents);
            Modify_ListAgentsApiCall(ref _callListAgents);
            _callGetAgent = clientHelper.BuildApiCall<GetAgentRequest, Agent>("GetAgent", grpcClient.GetAgentAsync, grpcClient.GetAgent, effectiveSettings.GetAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAgent);
            Modify_GetAgentApiCall(ref _callGetAgent);
            _callCreateAgent = clientHelper.BuildApiCall<CreateAgentRequest, Agent>("CreateAgent", grpcClient.CreateAgentAsync, grpcClient.CreateAgent, effectiveSettings.CreateAgentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAgent);
            Modify_CreateAgentApiCall(ref _callCreateAgent);
            _callUpdateAgent = clientHelper.BuildApiCall<UpdateAgentRequest, Agent>("UpdateAgent", grpcClient.UpdateAgentAsync, grpcClient.UpdateAgent, effectiveSettings.UpdateAgentSettings).WithGoogleRequestParam("agent.name", request => request.Agent?.Name);
            Modify_ApiCall(ref _callUpdateAgent);
            Modify_UpdateAgentApiCall(ref _callUpdateAgent);
            _callDeleteAgent = clientHelper.BuildApiCall<DeleteAgentRequest, wkt::Empty>("DeleteAgent", grpcClient.DeleteAgentAsync, grpcClient.DeleteAgent, effectiveSettings.DeleteAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAgent);
            Modify_DeleteAgentApiCall(ref _callDeleteAgent);
            _callListExamples = clientHelper.BuildApiCall<ListExamplesRequest, ListExamplesResponse>("ListExamples", grpcClient.ListExamplesAsync, grpcClient.ListExamples, effectiveSettings.ListExamplesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExamples);
            Modify_ListExamplesApiCall(ref _callListExamples);
            _callGetExample = clientHelper.BuildApiCall<GetExampleRequest, Example>("GetExample", grpcClient.GetExampleAsync, grpcClient.GetExample, effectiveSettings.GetExampleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExample);
            Modify_GetExampleApiCall(ref _callGetExample);
            _callCreateExample = clientHelper.BuildApiCall<CreateExampleRequest, Example>("CreateExample", grpcClient.CreateExampleAsync, grpcClient.CreateExample, effectiveSettings.CreateExampleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateExample);
            Modify_CreateExampleApiCall(ref _callCreateExample);
            _callUpdateExample = clientHelper.BuildApiCall<UpdateExampleRequest, Example>("UpdateExample", grpcClient.UpdateExampleAsync, grpcClient.UpdateExample, effectiveSettings.UpdateExampleSettings).WithGoogleRequestParam("example.name", request => request.Example?.Name);
            Modify_ApiCall(ref _callUpdateExample);
            Modify_UpdateExampleApiCall(ref _callUpdateExample);
            _callDeleteExample = clientHelper.BuildApiCall<DeleteExampleRequest, wkt::Empty>("DeleteExample", grpcClient.DeleteExampleAsync, grpcClient.DeleteExample, effectiveSettings.DeleteExampleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteExample);
            Modify_DeleteExampleApiCall(ref _callDeleteExample);
            _callListTools = clientHelper.BuildApiCall<ListToolsRequest, ListToolsResponse>("ListTools", grpcClient.ListToolsAsync, grpcClient.ListTools, effectiveSettings.ListToolsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTools);
            Modify_ListToolsApiCall(ref _callListTools);
            _callGetTool = clientHelper.BuildApiCall<GetToolRequest, Tool>("GetTool", grpcClient.GetToolAsync, grpcClient.GetTool, effectiveSettings.GetToolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTool);
            Modify_GetToolApiCall(ref _callGetTool);
            _callListConversations = clientHelper.BuildApiCall<ListConversationsRequest, ListConversationsResponse>("ListConversations", grpcClient.ListConversationsAsync, grpcClient.ListConversations, effectiveSettings.ListConversationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConversations);
            Modify_ListConversationsApiCall(ref _callListConversations);
            _callGetConversation = clientHelper.BuildApiCall<GetConversationRequest, Conversation>("GetConversation", grpcClient.GetConversationAsync, grpcClient.GetConversation, effectiveSettings.GetConversationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConversation);
            Modify_GetConversationApiCall(ref _callGetConversation);
            _callDeleteConversation = clientHelper.BuildApiCall<DeleteConversationRequest, wkt::Empty>("DeleteConversation", grpcClient.DeleteConversationAsync, grpcClient.DeleteConversation, effectiveSettings.DeleteConversationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConversation);
            Modify_DeleteConversationApiCall(ref _callDeleteConversation);
            _callBatchDeleteConversations = clientHelper.BuildApiCall<BatchDeleteConversationsRequest, lro::Operation>("BatchDeleteConversations", grpcClient.BatchDeleteConversationsAsync, grpcClient.BatchDeleteConversations, effectiveSettings.BatchDeleteConversationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteConversations);
            Modify_BatchDeleteConversationsApiCall(ref _callBatchDeleteConversations);
            _callCreateTool = clientHelper.BuildApiCall<CreateToolRequest, Tool>("CreateTool", grpcClient.CreateToolAsync, grpcClient.CreateTool, effectiveSettings.CreateToolSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTool);
            Modify_CreateToolApiCall(ref _callCreateTool);
            _callUpdateTool = clientHelper.BuildApiCall<UpdateToolRequest, Tool>("UpdateTool", grpcClient.UpdateToolAsync, grpcClient.UpdateTool, effectiveSettings.UpdateToolSettings).WithGoogleRequestParam("tool.name", request => request.Tool?.Name);
            Modify_ApiCall(ref _callUpdateTool);
            Modify_UpdateToolApiCall(ref _callUpdateTool);
            _callDeleteTool = clientHelper.BuildApiCall<DeleteToolRequest, wkt::Empty>("DeleteTool", grpcClient.DeleteToolAsync, grpcClient.DeleteTool, effectiveSettings.DeleteToolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTool);
            Modify_DeleteToolApiCall(ref _callDeleteTool);
            _callListGuardrails = clientHelper.BuildApiCall<ListGuardrailsRequest, ListGuardrailsResponse>("ListGuardrails", grpcClient.ListGuardrailsAsync, grpcClient.ListGuardrails, effectiveSettings.ListGuardrailsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGuardrails);
            Modify_ListGuardrailsApiCall(ref _callListGuardrails);
            _callGetGuardrail = clientHelper.BuildApiCall<GetGuardrailRequest, Guardrail>("GetGuardrail", grpcClient.GetGuardrailAsync, grpcClient.GetGuardrail, effectiveSettings.GetGuardrailSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGuardrail);
            Modify_GetGuardrailApiCall(ref _callGetGuardrail);
            _callCreateGuardrail = clientHelper.BuildApiCall<CreateGuardrailRequest, Guardrail>("CreateGuardrail", grpcClient.CreateGuardrailAsync, grpcClient.CreateGuardrail, effectiveSettings.CreateGuardrailSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGuardrail);
            Modify_CreateGuardrailApiCall(ref _callCreateGuardrail);
            _callUpdateGuardrail = clientHelper.BuildApiCall<UpdateGuardrailRequest, Guardrail>("UpdateGuardrail", grpcClient.UpdateGuardrailAsync, grpcClient.UpdateGuardrail, effectiveSettings.UpdateGuardrailSettings).WithGoogleRequestParam("guardrail.name", request => request.Guardrail?.Name);
            Modify_ApiCall(ref _callUpdateGuardrail);
            Modify_UpdateGuardrailApiCall(ref _callUpdateGuardrail);
            _callDeleteGuardrail = clientHelper.BuildApiCall<DeleteGuardrailRequest, wkt::Empty>("DeleteGuardrail", grpcClient.DeleteGuardrailAsync, grpcClient.DeleteGuardrail, effectiveSettings.DeleteGuardrailSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGuardrail);
            Modify_DeleteGuardrailApiCall(ref _callDeleteGuardrail);
            _callListDeployments = clientHelper.BuildApiCall<ListDeploymentsRequest, ListDeploymentsResponse>("ListDeployments", grpcClient.ListDeploymentsAsync, grpcClient.ListDeployments, effectiveSettings.ListDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeployments);
            Modify_ListDeploymentsApiCall(ref _callListDeployments);
            _callGetDeployment = clientHelper.BuildApiCall<GetDeploymentRequest, Deployment>("GetDeployment", grpcClient.GetDeploymentAsync, grpcClient.GetDeployment, effectiveSettings.GetDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeployment);
            Modify_GetDeploymentApiCall(ref _callGetDeployment);
            _callCreateDeployment = clientHelper.BuildApiCall<CreateDeploymentRequest, Deployment>("CreateDeployment", grpcClient.CreateDeploymentAsync, grpcClient.CreateDeployment, effectiveSettings.CreateDeploymentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDeployment);
            Modify_CreateDeploymentApiCall(ref _callCreateDeployment);
            _callUpdateDeployment = clientHelper.BuildApiCall<UpdateDeploymentRequest, Deployment>("UpdateDeployment", grpcClient.UpdateDeploymentAsync, grpcClient.UpdateDeployment, effectiveSettings.UpdateDeploymentSettings).WithGoogleRequestParam("deployment.name", request => request.Deployment?.Name);
            Modify_ApiCall(ref _callUpdateDeployment);
            Modify_UpdateDeploymentApiCall(ref _callUpdateDeployment);
            _callDeleteDeployment = clientHelper.BuildApiCall<DeleteDeploymentRequest, wkt::Empty>("DeleteDeployment", grpcClient.DeleteDeploymentAsync, grpcClient.DeleteDeployment, effectiveSettings.DeleteDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDeployment);
            Modify_DeleteDeploymentApiCall(ref _callDeleteDeployment);
            _callListToolsets = clientHelper.BuildApiCall<ListToolsetsRequest, ListToolsetsResponse>("ListToolsets", grpcClient.ListToolsetsAsync, grpcClient.ListToolsets, effectiveSettings.ListToolsetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListToolsets);
            Modify_ListToolsetsApiCall(ref _callListToolsets);
            _callGetToolset = clientHelper.BuildApiCall<GetToolsetRequest, Toolset>("GetToolset", grpcClient.GetToolsetAsync, grpcClient.GetToolset, effectiveSettings.GetToolsetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetToolset);
            Modify_GetToolsetApiCall(ref _callGetToolset);
            _callCreateToolset = clientHelper.BuildApiCall<CreateToolsetRequest, Toolset>("CreateToolset", grpcClient.CreateToolsetAsync, grpcClient.CreateToolset, effectiveSettings.CreateToolsetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateToolset);
            Modify_CreateToolsetApiCall(ref _callCreateToolset);
            _callUpdateToolset = clientHelper.BuildApiCall<UpdateToolsetRequest, Toolset>("UpdateToolset", grpcClient.UpdateToolsetAsync, grpcClient.UpdateToolset, effectiveSettings.UpdateToolsetSettings).WithGoogleRequestParam("toolset.name", request => request.Toolset?.Name);
            Modify_ApiCall(ref _callUpdateToolset);
            Modify_UpdateToolsetApiCall(ref _callUpdateToolset);
            _callDeleteToolset = clientHelper.BuildApiCall<DeleteToolsetRequest, wkt::Empty>("DeleteToolset", grpcClient.DeleteToolsetAsync, grpcClient.DeleteToolset, effectiveSettings.DeleteToolsetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteToolset);
            Modify_DeleteToolsetApiCall(ref _callDeleteToolset);
            _callListAppVersions = clientHelper.BuildApiCall<ListAppVersionsRequest, ListAppVersionsResponse>("ListAppVersions", grpcClient.ListAppVersionsAsync, grpcClient.ListAppVersions, effectiveSettings.ListAppVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAppVersions);
            Modify_ListAppVersionsApiCall(ref _callListAppVersions);
            _callGetAppVersion = clientHelper.BuildApiCall<GetAppVersionRequest, AppVersion>("GetAppVersion", grpcClient.GetAppVersionAsync, grpcClient.GetAppVersion, effectiveSettings.GetAppVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAppVersion);
            Modify_GetAppVersionApiCall(ref _callGetAppVersion);
            _callCreateAppVersion = clientHelper.BuildApiCall<CreateAppVersionRequest, AppVersion>("CreateAppVersion", grpcClient.CreateAppVersionAsync, grpcClient.CreateAppVersion, effectiveSettings.CreateAppVersionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAppVersion);
            Modify_CreateAppVersionApiCall(ref _callCreateAppVersion);
            _callDeleteAppVersion = clientHelper.BuildApiCall<DeleteAppVersionRequest, wkt::Empty>("DeleteAppVersion", grpcClient.DeleteAppVersionAsync, grpcClient.DeleteAppVersion, effectiveSettings.DeleteAppVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAppVersion);
            Modify_DeleteAppVersionApiCall(ref _callDeleteAppVersion);
            _callRestoreAppVersion = clientHelper.BuildApiCall<RestoreAppVersionRequest, lro::Operation>("RestoreAppVersion", grpcClient.RestoreAppVersionAsync, grpcClient.RestoreAppVersion, effectiveSettings.RestoreAppVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestoreAppVersion);
            Modify_RestoreAppVersionApiCall(ref _callRestoreAppVersion);
            _callListChangelogs = clientHelper.BuildApiCall<ListChangelogsRequest, ListChangelogsResponse>("ListChangelogs", grpcClient.ListChangelogsAsync, grpcClient.ListChangelogs, effectiveSettings.ListChangelogsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListChangelogs);
            Modify_ListChangelogsApiCall(ref _callListChangelogs);
            _callGetChangelog = clientHelper.BuildApiCall<GetChangelogRequest, Changelog>("GetChangelog", grpcClient.GetChangelogAsync, grpcClient.GetChangelog, effectiveSettings.GetChangelogSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetChangelog);
            Modify_GetChangelogApiCall(ref _callGetChangelog);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAppsApiCall(ref gaxgrpc::ApiCall<ListAppsRequest, ListAppsResponse> call);

        partial void Modify_GetAppApiCall(ref gaxgrpc::ApiCall<GetAppRequest, App> call);

        partial void Modify_CreateAppApiCall(ref gaxgrpc::ApiCall<CreateAppRequest, lro::Operation> call);

        partial void Modify_UpdateAppApiCall(ref gaxgrpc::ApiCall<UpdateAppRequest, App> call);

        partial void Modify_DeleteAppApiCall(ref gaxgrpc::ApiCall<DeleteAppRequest, lro::Operation> call);

        partial void Modify_ExportAppApiCall(ref gaxgrpc::ApiCall<ExportAppRequest, lro::Operation> call);

        partial void Modify_ImportAppApiCall(ref gaxgrpc::ApiCall<ImportAppRequest, lro::Operation> call);

        partial void Modify_ListAgentsApiCall(ref gaxgrpc::ApiCall<ListAgentsRequest, ListAgentsResponse> call);

        partial void Modify_GetAgentApiCall(ref gaxgrpc::ApiCall<GetAgentRequest, Agent> call);

        partial void Modify_CreateAgentApiCall(ref gaxgrpc::ApiCall<CreateAgentRequest, Agent> call);

        partial void Modify_UpdateAgentApiCall(ref gaxgrpc::ApiCall<UpdateAgentRequest, Agent> call);

        partial void Modify_DeleteAgentApiCall(ref gaxgrpc::ApiCall<DeleteAgentRequest, wkt::Empty> call);

        partial void Modify_ListExamplesApiCall(ref gaxgrpc::ApiCall<ListExamplesRequest, ListExamplesResponse> call);

        partial void Modify_GetExampleApiCall(ref gaxgrpc::ApiCall<GetExampleRequest, Example> call);

        partial void Modify_CreateExampleApiCall(ref gaxgrpc::ApiCall<CreateExampleRequest, Example> call);

        partial void Modify_UpdateExampleApiCall(ref gaxgrpc::ApiCall<UpdateExampleRequest, Example> call);

        partial void Modify_DeleteExampleApiCall(ref gaxgrpc::ApiCall<DeleteExampleRequest, wkt::Empty> call);

        partial void Modify_ListToolsApiCall(ref gaxgrpc::ApiCall<ListToolsRequest, ListToolsResponse> call);

        partial void Modify_GetToolApiCall(ref gaxgrpc::ApiCall<GetToolRequest, Tool> call);

        partial void Modify_ListConversationsApiCall(ref gaxgrpc::ApiCall<ListConversationsRequest, ListConversationsResponse> call);

        partial void Modify_GetConversationApiCall(ref gaxgrpc::ApiCall<GetConversationRequest, Conversation> call);

        partial void Modify_DeleteConversationApiCall(ref gaxgrpc::ApiCall<DeleteConversationRequest, wkt::Empty> call);

        partial void Modify_BatchDeleteConversationsApiCall(ref gaxgrpc::ApiCall<BatchDeleteConversationsRequest, lro::Operation> call);

        partial void Modify_CreateToolApiCall(ref gaxgrpc::ApiCall<CreateToolRequest, Tool> call);

        partial void Modify_UpdateToolApiCall(ref gaxgrpc::ApiCall<UpdateToolRequest, Tool> call);

        partial void Modify_DeleteToolApiCall(ref gaxgrpc::ApiCall<DeleteToolRequest, wkt::Empty> call);

        partial void Modify_ListGuardrailsApiCall(ref gaxgrpc::ApiCall<ListGuardrailsRequest, ListGuardrailsResponse> call);

        partial void Modify_GetGuardrailApiCall(ref gaxgrpc::ApiCall<GetGuardrailRequest, Guardrail> call);

        partial void Modify_CreateGuardrailApiCall(ref gaxgrpc::ApiCall<CreateGuardrailRequest, Guardrail> call);

        partial void Modify_UpdateGuardrailApiCall(ref gaxgrpc::ApiCall<UpdateGuardrailRequest, Guardrail> call);

        partial void Modify_DeleteGuardrailApiCall(ref gaxgrpc::ApiCall<DeleteGuardrailRequest, wkt::Empty> call);

        partial void Modify_ListDeploymentsApiCall(ref gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> call);

        partial void Modify_GetDeploymentApiCall(ref gaxgrpc::ApiCall<GetDeploymentRequest, Deployment> call);

        partial void Modify_CreateDeploymentApiCall(ref gaxgrpc::ApiCall<CreateDeploymentRequest, Deployment> call);

        partial void Modify_UpdateDeploymentApiCall(ref gaxgrpc::ApiCall<UpdateDeploymentRequest, Deployment> call);

        partial void Modify_DeleteDeploymentApiCall(ref gaxgrpc::ApiCall<DeleteDeploymentRequest, wkt::Empty> call);

        partial void Modify_ListToolsetsApiCall(ref gaxgrpc::ApiCall<ListToolsetsRequest, ListToolsetsResponse> call);

        partial void Modify_GetToolsetApiCall(ref gaxgrpc::ApiCall<GetToolsetRequest, Toolset> call);

        partial void Modify_CreateToolsetApiCall(ref gaxgrpc::ApiCall<CreateToolsetRequest, Toolset> call);

        partial void Modify_UpdateToolsetApiCall(ref gaxgrpc::ApiCall<UpdateToolsetRequest, Toolset> call);

        partial void Modify_DeleteToolsetApiCall(ref gaxgrpc::ApiCall<DeleteToolsetRequest, wkt::Empty> call);

        partial void Modify_ListAppVersionsApiCall(ref gaxgrpc::ApiCall<ListAppVersionsRequest, ListAppVersionsResponse> call);

        partial void Modify_GetAppVersionApiCall(ref gaxgrpc::ApiCall<GetAppVersionRequest, AppVersion> call);

        partial void Modify_CreateAppVersionApiCall(ref gaxgrpc::ApiCall<CreateAppVersionRequest, AppVersion> call);

        partial void Modify_DeleteAppVersionApiCall(ref gaxgrpc::ApiCall<DeleteAppVersionRequest, wkt::Empty> call);

        partial void Modify_RestoreAppVersionApiCall(ref gaxgrpc::ApiCall<RestoreAppVersionRequest, lro::Operation> call);

        partial void Modify_ListChangelogsApiCall(ref gaxgrpc::ApiCall<ListChangelogsRequest, ListChangelogsResponse> call);

        partial void Modify_GetChangelogApiCall(ref gaxgrpc::ApiCall<GetChangelogRequest, Changelog> call);

        partial void OnConstruction(AgentService.AgentServiceClient grpcClient, AgentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AgentService client</summary>
        public override AgentService.AgentServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListAppsRequest(ref ListAppsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAppRequest(ref GetAppRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAppRequest(ref CreateAppRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAppRequest(ref UpdateAppRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAppRequest(ref DeleteAppRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportAppRequest(ref ExportAppRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportAppRequest(ref ImportAppRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAgentsRequest(ref ListAgentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAgentRequest(ref GetAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAgentRequest(ref CreateAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAgentRequest(ref UpdateAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAgentRequest(ref DeleteAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExamplesRequest(ref ListExamplesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExampleRequest(ref GetExampleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateExampleRequest(ref CreateExampleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateExampleRequest(ref UpdateExampleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteExampleRequest(ref DeleteExampleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListToolsRequest(ref ListToolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetToolRequest(ref GetToolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConversationsRequest(ref ListConversationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversationRequest(ref GetConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConversationRequest(ref DeleteConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteConversationsRequest(ref BatchDeleteConversationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateToolRequest(ref CreateToolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateToolRequest(ref UpdateToolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteToolRequest(ref DeleteToolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGuardrailsRequest(ref ListGuardrailsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGuardrailRequest(ref GetGuardrailRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGuardrailRequest(ref CreateGuardrailRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGuardrailRequest(ref UpdateGuardrailRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGuardrailRequest(ref DeleteGuardrailRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeploymentsRequest(ref ListDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeploymentRequest(ref GetDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDeploymentRequest(ref CreateDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDeploymentRequest(ref UpdateDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDeploymentRequest(ref DeleteDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListToolsetsRequest(ref ListToolsetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetToolsetRequest(ref GetToolsetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateToolsetRequest(ref CreateToolsetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateToolsetRequest(ref UpdateToolsetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteToolsetRequest(ref DeleteToolsetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAppVersionsRequest(ref ListAppVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAppVersionRequest(ref GetAppVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAppVersionRequest(ref CreateAppVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAppVersionRequest(ref DeleteAppVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreAppVersionRequest(ref RestoreAppVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListChangelogsRequest(ref ListChangelogsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetChangelogRequest(ref GetChangelogRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists apps in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="App"/> resources.</returns>
        public override gax::PagedEnumerable<ListAppsResponse, App> ListApps(ListAppsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAppsRequest, ListAppsResponse, App>(_callListApps, request, callSettings);
        }

        /// <summary>
        /// Lists apps in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="App"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAppsResponse, App> ListAppsAsync(ListAppsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAppsRequest, ListAppsResponse, App>(_callListApps, request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override App GetApp(GetAppRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppRequest(ref request, ref callSettings);
            return _callGetApp.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<App> GetAppAsync(GetAppRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppRequest(ref request, ref callSettings);
            return _callGetApp.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateApp</c>.</summary>
        public override lro::OperationsClient CreateAppOperationsClient { get; }

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<App, OperationMetadata> CreateApp(CreateAppRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppRequest(ref request, ref callSettings);
            return new lro::Operation<App, OperationMetadata>(_callCreateApp.Sync(request, callSettings), CreateAppOperationsClient);
        }

        /// <summary>
        /// Creates a new app in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<App, OperationMetadata>> CreateAppAsync(CreateAppRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppRequest(ref request, ref callSettings);
            return new lro::Operation<App, OperationMetadata>(await _callCreateApp.Async(request, callSettings).ConfigureAwait(false), CreateAppOperationsClient);
        }

        /// <summary>
        /// Updates the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override App UpdateApp(UpdateAppRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAppRequest(ref request, ref callSettings);
            return _callUpdateApp.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<App> UpdateAppAsync(UpdateAppRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAppRequest(ref request, ref callSettings);
            return _callUpdateApp.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteApp</c>.</summary>
        public override lro::OperationsClient DeleteAppOperationsClient { get; }

        /// <summary>
        /// Deletes the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteApp(DeleteAppRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteApp.Sync(request, callSettings), DeleteAppOperationsClient);
        }

        /// <summary>
        /// Deletes the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAppAsync(DeleteAppRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteApp.Async(request, callSettings).ConfigureAwait(false), DeleteAppOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportApp</c>.</summary>
        public override lro::OperationsClient ExportAppOperationsClient { get; }

        /// <summary>
        /// Exports the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportAppResponse, OperationMetadata> ExportApp(ExportAppRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAppRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAppResponse, OperationMetadata>(_callExportApp.Sync(request, callSettings), ExportAppOperationsClient);
        }

        /// <summary>
        /// Exports the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportAppResponse, OperationMetadata>> ExportAppAsync(ExportAppRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAppRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAppResponse, OperationMetadata>(await _callExportApp.Async(request, callSettings).ConfigureAwait(false), ExportAppOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportApp</c>.</summary>
        public override lro::OperationsClient ImportAppOperationsClient { get; }

        /// <summary>
        /// Imports the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportAppResponse, OperationMetadata> ImportApp(ImportAppRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAppRequest(ref request, ref callSettings);
            return new lro::Operation<ImportAppResponse, OperationMetadata>(_callImportApp.Sync(request, callSettings), ImportAppOperationsClient);
        }

        /// <summary>
        /// Imports the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportAppResponse, OperationMetadata>> ImportAppAsync(ImportAppRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAppRequest(ref request, ref callSettings);
            return new lro::Operation<ImportAppResponse, OperationMetadata>(await _callImportApp.Async(request, callSettings).ConfigureAwait(false), ImportAppOperationsClient);
        }

        /// <summary>
        /// Lists agents in the given app.
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
        /// Lists agents in the given app.
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
        /// Gets details of the specified agent.
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
        /// Gets details of the specified agent.
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
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Agent CreateAgent(CreateAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAgentRequest(ref request, ref callSettings);
            return _callCreateAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new agent in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Agent> CreateAgentAsync(CreateAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAgentRequest(ref request, ref callSettings);
            return _callCreateAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Agent UpdateAgent(UpdateAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAgentRequest(ref request, ref callSettings);
            return _callUpdateAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Agent> UpdateAgentAsync(UpdateAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAgentRequest(ref request, ref callSettings);
            return _callUpdateAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAgent(DeleteAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentRequest(ref request, ref callSettings);
            _callDeleteAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAgentAsync(DeleteAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentRequest(ref request, ref callSettings);
            return _callDeleteAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Lists examples in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public override gax::PagedEnumerable<ListExamplesResponse, Example> ListExamples(ListExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExamplesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExamplesRequest, ListExamplesResponse, Example>(_callListExamples, request, callSettings);
        }

        /// <summary>
        /// Lists examples in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExamplesResponse, Example> ListExamplesAsync(ListExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExamplesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExamplesRequest, ListExamplesResponse, Example>(_callListExamples, request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Example GetExample(GetExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExampleRequest(ref request, ref callSettings);
            return _callGetExample.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Example> GetExampleAsync(GetExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExampleRequest(ref request, ref callSettings);
            return _callGetExample.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Example CreateExample(CreateExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExampleRequest(ref request, ref callSettings);
            return _callCreateExample.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new example in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Example> CreateExampleAsync(CreateExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExampleRequest(ref request, ref callSettings);
            return _callCreateExample.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Example UpdateExample(UpdateExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExampleRequest(ref request, ref callSettings);
            return _callUpdateExample.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Example> UpdateExampleAsync(UpdateExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExampleRequest(ref request, ref callSettings);
            return _callUpdateExample.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteExample(DeleteExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExampleRequest(ref request, ref callSettings);
            _callDeleteExample.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteExampleAsync(DeleteExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExampleRequest(ref request, ref callSettings);
            return _callDeleteExample.Async(request, callSettings);
        }

        /// <summary>
        /// Lists tools in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tool"/> resources.</returns>
        public override gax::PagedEnumerable<ListToolsResponse, Tool> ListTools(ListToolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListToolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListToolsRequest, ListToolsResponse, Tool>(_callListTools, request, callSettings);
        }

        /// <summary>
        /// Lists tools in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListToolsResponse, Tool> ListToolsAsync(ListToolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListToolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListToolsRequest, ListToolsResponse, Tool>(_callListTools, request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tool GetTool(GetToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetToolRequest(ref request, ref callSettings);
            return _callGetTool.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tool> GetToolAsync(GetToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetToolRequest(ref request, ref callSettings);
            return _callGetTool.Async(request, callSettings);
        }

        /// <summary>
        /// Lists conversations in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public override gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConversationsRequest, ListConversationsResponse, Conversation>(_callListConversations, request, callSettings);
        }

        /// <summary>
        /// Lists conversations in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConversationsRequest, ListConversationsResponse, Conversation>(_callListConversations, request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Conversation GetConversation(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationRequest(ref request, ref callSettings);
            return _callGetConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationRequest(ref request, ref callSettings);
            return _callGetConversation.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteConversation(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationRequest(ref request, ref callSettings);
            _callDeleteConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteConversationAsync(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationRequest(ref request, ref callSettings);
            return _callDeleteConversation.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchDeleteConversations</c>.</summary>
        public override lro::OperationsClient BatchDeleteConversationsOperationsClient { get; }

        /// <summary>
        /// Batch deletes the specified conversations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchDeleteConversationsResponse, OperationMetadata> BatchDeleteConversations(BatchDeleteConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteConversationsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchDeleteConversationsResponse, OperationMetadata>(_callBatchDeleteConversations.Sync(request, callSettings), BatchDeleteConversationsOperationsClient);
        }

        /// <summary>
        /// Batch deletes the specified conversations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchDeleteConversationsResponse, OperationMetadata>> BatchDeleteConversationsAsync(BatchDeleteConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteConversationsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchDeleteConversationsResponse, OperationMetadata>(await _callBatchDeleteConversations.Async(request, callSettings).ConfigureAwait(false), BatchDeleteConversationsOperationsClient);
        }

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tool CreateTool(CreateToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateToolRequest(ref request, ref callSettings);
            return _callCreateTool.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new tool in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tool> CreateToolAsync(CreateToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateToolRequest(ref request, ref callSettings);
            return _callCreateTool.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tool UpdateTool(UpdateToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateToolRequest(ref request, ref callSettings);
            return _callUpdateTool.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tool> UpdateToolAsync(UpdateToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateToolRequest(ref request, ref callSettings);
            return _callUpdateTool.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTool(DeleteToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteToolRequest(ref request, ref callSettings);
            _callDeleteTool.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteToolAsync(DeleteToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteToolRequest(ref request, ref callSettings);
            return _callDeleteTool.Async(request, callSettings);
        }

        /// <summary>
        /// Lists guardrails in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Guardrail"/> resources.</returns>
        public override gax::PagedEnumerable<ListGuardrailsResponse, Guardrail> ListGuardrails(ListGuardrailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGuardrailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGuardrailsRequest, ListGuardrailsResponse, Guardrail>(_callListGuardrails, request, callSettings);
        }

        /// <summary>
        /// Lists guardrails in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Guardrail"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGuardrailsResponse, Guardrail> ListGuardrailsAsync(ListGuardrailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGuardrailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGuardrailsRequest, ListGuardrailsResponse, Guardrail>(_callListGuardrails, request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Guardrail GetGuardrail(GetGuardrailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGuardrailRequest(ref request, ref callSettings);
            return _callGetGuardrail.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Guardrail> GetGuardrailAsync(GetGuardrailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGuardrailRequest(ref request, ref callSettings);
            return _callGetGuardrail.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Guardrail CreateGuardrail(CreateGuardrailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGuardrailRequest(ref request, ref callSettings);
            return _callCreateGuardrail.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new guardrail in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Guardrail> CreateGuardrailAsync(CreateGuardrailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGuardrailRequest(ref request, ref callSettings);
            return _callCreateGuardrail.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Guardrail UpdateGuardrail(UpdateGuardrailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGuardrailRequest(ref request, ref callSettings);
            return _callUpdateGuardrail.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Guardrail> UpdateGuardrailAsync(UpdateGuardrailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGuardrailRequest(ref request, ref callSettings);
            return _callUpdateGuardrail.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteGuardrail(DeleteGuardrailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGuardrailRequest(ref request, ref callSettings);
            _callDeleteGuardrail.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified guardrail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteGuardrailAsync(DeleteGuardrailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGuardrailRequest(ref request, ref callSettings);
            return _callDeleteGuardrail.Async(request, callSettings);
        }

        /// <summary>
        /// Lists deployments in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeploymentsRequest, ListDeploymentsResponse, Deployment>(_callListDeployments, request, callSettings);
        }

        /// <summary>
        /// Lists deployments in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeploymentsRequest, ListDeploymentsResponse, Deployment>(_callListDeployments, request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment GetDeployment(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentRequest(ref request, ref callSettings);
            return _callGetDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentRequest(ref request, ref callSettings);
            return _callGetDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment CreateDeployment(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentRequest(ref request, ref callSettings);
            return _callCreateDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new deployment in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> CreateDeploymentAsync(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentRequest(ref request, ref callSettings);
            return _callCreateDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment UpdateDeployment(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeploymentRequest(ref request, ref callSettings);
            return _callUpdateDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> UpdateDeploymentAsync(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeploymentRequest(ref request, ref callSettings);
            return _callUpdateDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDeployment(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeploymentRequest(ref request, ref callSettings);
            _callDeleteDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDeploymentAsync(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeploymentRequest(ref request, ref callSettings);
            return _callDeleteDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists toolsets in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Toolset"/> resources.</returns>
        public override gax::PagedEnumerable<ListToolsetsResponse, Toolset> ListToolsets(ListToolsetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListToolsetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListToolsetsRequest, ListToolsetsResponse, Toolset>(_callListToolsets, request, callSettings);
        }

        /// <summary>
        /// Lists toolsets in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Toolset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListToolsetsResponse, Toolset> ListToolsetsAsync(ListToolsetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListToolsetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListToolsetsRequest, ListToolsetsResponse, Toolset>(_callListToolsets, request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Toolset GetToolset(GetToolsetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetToolsetRequest(ref request, ref callSettings);
            return _callGetToolset.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Toolset> GetToolsetAsync(GetToolsetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetToolsetRequest(ref request, ref callSettings);
            return _callGetToolset.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Toolset CreateToolset(CreateToolsetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateToolsetRequest(ref request, ref callSettings);
            return _callCreateToolset.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new toolset in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Toolset> CreateToolsetAsync(CreateToolsetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateToolsetRequest(ref request, ref callSettings);
            return _callCreateToolset.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Toolset UpdateToolset(UpdateToolsetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateToolsetRequest(ref request, ref callSettings);
            return _callUpdateToolset.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Toolset> UpdateToolsetAsync(UpdateToolsetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateToolsetRequest(ref request, ref callSettings);
            return _callUpdateToolset.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteToolset(DeleteToolsetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteToolsetRequest(ref request, ref callSettings);
            _callDeleteToolset.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteToolsetAsync(DeleteToolsetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteToolsetRequest(ref request, ref callSettings);
            return _callDeleteToolset.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all app versions in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AppVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListAppVersionsResponse, AppVersion> ListAppVersions(ListAppVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAppVersionsRequest, ListAppVersionsResponse, AppVersion>(_callListAppVersions, request, callSettings);
        }

        /// <summary>
        /// Lists all app versions in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AppVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAppVersionsResponse, AppVersion> ListAppVersionsAsync(ListAppVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAppVersionsRequest, ListAppVersionsResponse, AppVersion>(_callListAppVersions, request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AppVersion GetAppVersion(GetAppVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppVersionRequest(ref request, ref callSettings);
            return _callGetAppVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AppVersion> GetAppVersionAsync(GetAppVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppVersionRequest(ref request, ref callSettings);
            return _callGetAppVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AppVersion CreateAppVersion(CreateAppVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppVersionRequest(ref request, ref callSettings);
            return _callCreateAppVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new app version in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AppVersion> CreateAppVersionAsync(CreateAppVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppVersionRequest(ref request, ref callSettings);
            return _callCreateAppVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAppVersion(DeleteAppVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppVersionRequest(ref request, ref callSettings);
            _callDeleteAppVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAppVersionAsync(DeleteAppVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppVersionRequest(ref request, ref callSettings);
            return _callDeleteAppVersion.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RestoreAppVersion</c>.</summary>
        public override lro::OperationsClient RestoreAppVersionOperationsClient { get; }

        /// <summary>
        /// Restores the specified app version.
        /// This will create a new app version from the current draft app and overwrite
        /// the current draft with the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RestoreAppVersionResponse, OperationMetadata> RestoreAppVersion(RestoreAppVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreAppVersionRequest(ref request, ref callSettings);
            return new lro::Operation<RestoreAppVersionResponse, OperationMetadata>(_callRestoreAppVersion.Sync(request, callSettings), RestoreAppVersionOperationsClient);
        }

        /// <summary>
        /// Restores the specified app version.
        /// This will create a new app version from the current draft app and overwrite
        /// the current draft with the specified app version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RestoreAppVersionResponse, OperationMetadata>> RestoreAppVersionAsync(RestoreAppVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreAppVersionRequest(ref request, ref callSettings);
            return new lro::Operation<RestoreAppVersionResponse, OperationMetadata>(await _callRestoreAppVersion.Async(request, callSettings).ConfigureAwait(false), RestoreAppVersionOperationsClient);
        }

        /// <summary>
        /// Lists the changelogs of the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Changelog"/> resources.</returns>
        public override gax::PagedEnumerable<ListChangelogsResponse, Changelog> ListChangelogs(ListChangelogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChangelogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListChangelogsRequest, ListChangelogsResponse, Changelog>(_callListChangelogs, request, callSettings);
        }

        /// <summary>
        /// Lists the changelogs of the specified app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Changelog"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListChangelogsResponse, Changelog> ListChangelogsAsync(ListChangelogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChangelogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListChangelogsRequest, ListChangelogsResponse, Changelog>(_callListChangelogs, request, callSettings);
        }

        /// <summary>
        /// Gets the specified changelog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Changelog GetChangelog(GetChangelogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChangelogRequest(ref request, ref callSettings);
            return _callGetChangelog.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified changelog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Changelog> GetChangelogAsync(GetChangelogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChangelogRequest(ref request, ref callSettings);
            return _callGetChangelog.Async(request, callSettings);
        }
    }

    public partial class ListAppsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAgentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExamplesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListToolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConversationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGuardrailsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListToolsetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAppVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListChangelogsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAppsResponse : gaxgrpc::IPageResponse<App>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<App> GetEnumerator() => Apps.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAgentsResponse : gaxgrpc::IPageResponse<Agent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Agent> GetEnumerator() => Agents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListExamplesResponse : gaxgrpc::IPageResponse<Example>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Example> GetEnumerator() => Examples.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListToolsResponse : gaxgrpc::IPageResponse<Tool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Tool> GetEnumerator() => Tools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConversationsResponse : gaxgrpc::IPageResponse<Conversation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Conversation> GetEnumerator() => Conversations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGuardrailsResponse : gaxgrpc::IPageResponse<Guardrail>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Guardrail> GetEnumerator() => Guardrails.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDeploymentsResponse : gaxgrpc::IPageResponse<Deployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Deployment> GetEnumerator() => Deployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListToolsetsResponse : gaxgrpc::IPageResponse<Toolset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Toolset> GetEnumerator() => Toolsets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAppVersionsResponse : gaxgrpc::IPageResponse<AppVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AppVersion> GetEnumerator() => AppVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListChangelogsResponse : gaxgrpc::IPageResponse<Changelog>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Changelog> GetEnumerator() => Changelogs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AgentService
    {
        public partial class AgentServiceClient
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

    public static partial class AgentService
    {
        public partial class AgentServiceClient
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
