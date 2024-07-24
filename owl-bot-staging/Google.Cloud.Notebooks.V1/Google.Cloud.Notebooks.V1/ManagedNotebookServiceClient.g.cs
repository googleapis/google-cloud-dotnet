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

namespace Google.Cloud.Notebooks.V1
{
    /// <summary>Settings for <see cref="ManagedNotebookServiceClient"/> instances.</summary>
    public sealed partial class ManagedNotebookServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ManagedNotebookServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ManagedNotebookServiceSettings"/>.</returns>
        public static ManagedNotebookServiceSettings GetDefault() => new ManagedNotebookServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ManagedNotebookServiceSettings"/> object with default settings.
        /// </summary>
        public ManagedNotebookServiceSettings()
        {
        }

        private ManagedNotebookServiceSettings(ManagedNotebookServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListRuntimesSettings = existing.ListRuntimesSettings;
            GetRuntimeSettings = existing.GetRuntimeSettings;
            CreateRuntimeSettings = existing.CreateRuntimeSettings;
            CreateRuntimeOperationsSettings = existing.CreateRuntimeOperationsSettings.Clone();
            UpdateRuntimeSettings = existing.UpdateRuntimeSettings;
            UpdateRuntimeOperationsSettings = existing.UpdateRuntimeOperationsSettings.Clone();
            DeleteRuntimeSettings = existing.DeleteRuntimeSettings;
            DeleteRuntimeOperationsSettings = existing.DeleteRuntimeOperationsSettings.Clone();
            StartRuntimeSettings = existing.StartRuntimeSettings;
            StartRuntimeOperationsSettings = existing.StartRuntimeOperationsSettings.Clone();
            StopRuntimeSettings = existing.StopRuntimeSettings;
            StopRuntimeOperationsSettings = existing.StopRuntimeOperationsSettings.Clone();
            SwitchRuntimeSettings = existing.SwitchRuntimeSettings;
            SwitchRuntimeOperationsSettings = existing.SwitchRuntimeOperationsSettings.Clone();
            ResetRuntimeSettings = existing.ResetRuntimeSettings;
            ResetRuntimeOperationsSettings = existing.ResetRuntimeOperationsSettings.Clone();
            UpgradeRuntimeSettings = existing.UpgradeRuntimeSettings;
            UpgradeRuntimeOperationsSettings = existing.UpgradeRuntimeOperationsSettings.Clone();
            ReportRuntimeEventSettings = existing.ReportRuntimeEventSettings;
            ReportRuntimeEventOperationsSettings = existing.ReportRuntimeEventOperationsSettings.Clone();
            RefreshRuntimeTokenInternalSettings = existing.RefreshRuntimeTokenInternalSettings;
            DiagnoseRuntimeSettings = existing.DiagnoseRuntimeSettings;
            DiagnoseRuntimeOperationsSettings = existing.DiagnoseRuntimeOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ManagedNotebookServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedNotebookServiceClient.ListRuntimes</c> and <c>ManagedNotebookServiceClient.ListRuntimesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRuntimesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedNotebookServiceClient.GetRuntime</c> and <c>ManagedNotebookServiceClient.GetRuntimeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRuntimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedNotebookServiceClient.CreateRuntime</c> and <c>ManagedNotebookServiceClient.CreateRuntimeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRuntimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedNotebookServiceClient.CreateRuntime</c> and
        /// <c>ManagedNotebookServiceClient.CreateRuntimeAsync</c>.
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
        public lro::OperationsSettings CreateRuntimeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedNotebookServiceClient.UpdateRuntime</c> and <c>ManagedNotebookServiceClient.UpdateRuntimeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRuntimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedNotebookServiceClient.UpdateRuntime</c> and
        /// <c>ManagedNotebookServiceClient.UpdateRuntimeAsync</c>.
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
        public lro::OperationsSettings UpdateRuntimeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedNotebookServiceClient.DeleteRuntime</c> and <c>ManagedNotebookServiceClient.DeleteRuntimeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRuntimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedNotebookServiceClient.DeleteRuntime</c> and
        /// <c>ManagedNotebookServiceClient.DeleteRuntimeAsync</c>.
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
        public lro::OperationsSettings DeleteRuntimeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedNotebookServiceClient.StartRuntime</c> and <c>ManagedNotebookServiceClient.StartRuntimeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartRuntimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedNotebookServiceClient.StartRuntime</c> and
        /// <c>ManagedNotebookServiceClient.StartRuntimeAsync</c>.
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
        public lro::OperationsSettings StartRuntimeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedNotebookServiceClient.StopRuntime</c> and <c>ManagedNotebookServiceClient.StopRuntimeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopRuntimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedNotebookServiceClient.StopRuntime</c> and
        /// <c>ManagedNotebookServiceClient.StopRuntimeAsync</c>.
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
        public lro::OperationsSettings StopRuntimeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedNotebookServiceClient.SwitchRuntime</c> and <c>ManagedNotebookServiceClient.SwitchRuntimeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SwitchRuntimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedNotebookServiceClient.SwitchRuntime</c> and
        /// <c>ManagedNotebookServiceClient.SwitchRuntimeAsync</c>.
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
        public lro::OperationsSettings SwitchRuntimeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedNotebookServiceClient.ResetRuntime</c> and <c>ManagedNotebookServiceClient.ResetRuntimeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetRuntimeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedNotebookServiceClient.ResetRuntime</c> and
        /// <c>ManagedNotebookServiceClient.ResetRuntimeAsync</c>.
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
        public lro::OperationsSettings ResetRuntimeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedNotebookServiceClient.UpgradeRuntime</c> and <c>ManagedNotebookServiceClient.UpgradeRuntimeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpgradeRuntimeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedNotebookServiceClient.UpgradeRuntime</c> and
        /// <c>ManagedNotebookServiceClient.UpgradeRuntimeAsync</c>.
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
        public lro::OperationsSettings UpgradeRuntimeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedNotebookServiceClient.ReportRuntimeEvent</c> and
        /// <c>ManagedNotebookServiceClient.ReportRuntimeEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReportRuntimeEventSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedNotebookServiceClient.ReportRuntimeEvent</c> and
        /// <c>ManagedNotebookServiceClient.ReportRuntimeEventAsync</c>.
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
        public lro::OperationsSettings ReportRuntimeEventOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedNotebookServiceClient.RefreshRuntimeTokenInternal</c> and
        /// <c>ManagedNotebookServiceClient.RefreshRuntimeTokenInternalAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RefreshRuntimeTokenInternalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedNotebookServiceClient.DiagnoseRuntime</c> and <c>ManagedNotebookServiceClient.DiagnoseRuntimeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DiagnoseRuntimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedNotebookServiceClient.DiagnoseRuntime</c> and
        /// <c>ManagedNotebookServiceClient.DiagnoseRuntimeAsync</c>.
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
        public lro::OperationsSettings DiagnoseRuntimeOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="ManagedNotebookServiceSettings"/> object.</returns>
        public ManagedNotebookServiceSettings Clone() => new ManagedNotebookServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ManagedNotebookServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ManagedNotebookServiceClientBuilder : gaxgrpc::ClientBuilderBase<ManagedNotebookServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ManagedNotebookServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ManagedNotebookServiceClientBuilder() : base(ManagedNotebookServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ManagedNotebookServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ManagedNotebookServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ManagedNotebookServiceClient Build()
        {
            ManagedNotebookServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ManagedNotebookServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ManagedNotebookServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ManagedNotebookServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ManagedNotebookServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ManagedNotebookServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ManagedNotebookServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ManagedNotebookServiceClient.ChannelPool;
    }

    /// <summary>ManagedNotebookService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// API v1 service for Managed Notebooks.
    /// </remarks>
    public abstract partial class ManagedNotebookServiceClient
    {
        /// <summary>
        /// The default endpoint for the ManagedNotebookService service, which is a host of "notebooks.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "notebooks.googleapis.com:443";

        /// <summary>The default ManagedNotebookService scopes.</summary>
        /// <remarks>
        /// The default ManagedNotebookService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ManagedNotebookService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ManagedNotebookServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ManagedNotebookServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ManagedNotebookServiceClient"/>.</returns>
        public static stt::Task<ManagedNotebookServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ManagedNotebookServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ManagedNotebookServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ManagedNotebookServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ManagedNotebookServiceClient"/>.</returns>
        public static ManagedNotebookServiceClient Create() => new ManagedNotebookServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ManagedNotebookServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ManagedNotebookServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ManagedNotebookServiceClient"/>.</returns>
        internal static ManagedNotebookServiceClient Create(grpccore::CallInvoker callInvoker, ManagedNotebookServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ManagedNotebookService.ManagedNotebookServiceClient grpcClient = new ManagedNotebookService.ManagedNotebookServiceClient(callInvoker);
            return new ManagedNotebookServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ManagedNotebookService client</summary>
        public virtual ManagedNotebookService.ManagedNotebookServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Runtimes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Runtime"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuntimesResponse, Runtime> ListRuntimes(ListRuntimesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Runtimes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Runtime"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuntimesResponse, Runtime> ListRuntimesAsync(ListRuntimesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Runtimes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Runtime"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuntimesResponse, Runtime> ListRuntimes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimesRequest request = new ListRuntimesRequest
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
            return ListRuntimes(request, callSettings);
        }

        /// <summary>
        /// Lists Runtimes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Runtime"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuntimesResponse, Runtime> ListRuntimesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimesRequest request = new ListRuntimesRequest
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
            return ListRuntimesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Runtimes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Runtime"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuntimesResponse, Runtime> ListRuntimes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimesRequest request = new ListRuntimesRequest
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
            return ListRuntimes(request, callSettings);
        }

        /// <summary>
        /// Lists Runtimes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Runtime"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuntimesResponse, Runtime> ListRuntimesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimesRequest request = new ListRuntimesRequest
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
            return ListRuntimesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Runtime. The location must be a regional endpoint
        /// rather than zonal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Runtime GetRuntime(GetRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Runtime. The location must be a regional endpoint
        /// rather than zonal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Runtime> GetRuntimeAsync(GetRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Runtime. The location must be a regional endpoint
        /// rather than zonal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Runtime> GetRuntimeAsync(GetRuntimeRequest request, st::CancellationToken cancellationToken) =>
            GetRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Runtime. The location must be a regional endpoint
        /// rather than zonal.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Runtime GetRuntime(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuntime(new GetRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Runtime. The location must be a regional endpoint
        /// rather than zonal.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Runtime> GetRuntimeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuntimeAsync(new GetRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Runtime. The location must be a regional endpoint
        /// rather than zonal.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Runtime> GetRuntimeAsync(string name, st::CancellationToken cancellationToken) =>
            GetRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Runtime. The location must be a regional endpoint
        /// rather than zonal.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Runtime GetRuntime(RuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuntime(new GetRuntimeRequest
            {
                RuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Runtime. The location must be a regional endpoint
        /// rather than zonal.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Runtime> GetRuntimeAsync(RuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuntimeAsync(new GetRuntimeRequest
            {
                RuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Runtime. The location must be a regional endpoint
        /// rather than zonal.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Runtime> GetRuntimeAsync(RuntimeName name, st::CancellationToken cancellationToken) =>
            GetRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Runtime in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> CreateRuntime(CreateRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Runtime in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> CreateRuntimeAsync(CreateRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Runtime in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> CreateRuntimeAsync(CreateRuntimeRequest request, st::CancellationToken cancellationToken) =>
            CreateRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRuntime</c>.</summary>
        public virtual lro::OperationsClient CreateRuntimeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> PollOnceCreateRuntime(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> PollOnceCreateRuntimeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Runtime in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="runtimeId">
        /// Required. User-defined unique ID of this Runtime.
        /// </param>
        /// <param name="runtime">
        /// Required. The Runtime to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> CreateRuntime(string parent, string runtimeId, Runtime runtime, gaxgrpc::CallSettings callSettings = null) =>
            CreateRuntime(new CreateRuntimeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RuntimeId = gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeId, nameof(runtimeId)),
                Runtime = gax::GaxPreconditions.CheckNotNull(runtime, nameof(runtime)),
            }, callSettings);

        /// <summary>
        /// Creates a new Runtime in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="runtimeId">
        /// Required. User-defined unique ID of this Runtime.
        /// </param>
        /// <param name="runtime">
        /// Required. The Runtime to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> CreateRuntimeAsync(string parent, string runtimeId, Runtime runtime, gaxgrpc::CallSettings callSettings = null) =>
            CreateRuntimeAsync(new CreateRuntimeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RuntimeId = gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeId, nameof(runtimeId)),
                Runtime = gax::GaxPreconditions.CheckNotNull(runtime, nameof(runtime)),
            }, callSettings);

        /// <summary>
        /// Creates a new Runtime in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="runtimeId">
        /// Required. User-defined unique ID of this Runtime.
        /// </param>
        /// <param name="runtime">
        /// Required. The Runtime to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> CreateRuntimeAsync(string parent, string runtimeId, Runtime runtime, st::CancellationToken cancellationToken) =>
            CreateRuntimeAsync(parent, runtimeId, runtime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Runtime in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="runtimeId">
        /// Required. User-defined unique ID of this Runtime.
        /// </param>
        /// <param name="runtime">
        /// Required. The Runtime to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> CreateRuntime(RuntimeName parent, string runtimeId, Runtime runtime, gaxgrpc::CallSettings callSettings = null) =>
            CreateRuntime(new CreateRuntimeRequest
            {
                ParentAsRuntimeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RuntimeId = gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeId, nameof(runtimeId)),
                Runtime = gax::GaxPreconditions.CheckNotNull(runtime, nameof(runtime)),
            }, callSettings);

        /// <summary>
        /// Creates a new Runtime in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="runtimeId">
        /// Required. User-defined unique ID of this Runtime.
        /// </param>
        /// <param name="runtime">
        /// Required. The Runtime to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> CreateRuntimeAsync(RuntimeName parent, string runtimeId, Runtime runtime, gaxgrpc::CallSettings callSettings = null) =>
            CreateRuntimeAsync(new CreateRuntimeRequest
            {
                ParentAsRuntimeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RuntimeId = gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeId, nameof(runtimeId)),
                Runtime = gax::GaxPreconditions.CheckNotNull(runtime, nameof(runtime)),
            }, callSettings);

        /// <summary>
        /// Creates a new Runtime in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="runtimeId">
        /// Required. User-defined unique ID of this Runtime.
        /// </param>
        /// <param name="runtime">
        /// Required. The Runtime to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> CreateRuntimeAsync(RuntimeName parent, string runtimeId, Runtime runtime, st::CancellationToken cancellationToken) =>
            CreateRuntimeAsync(parent, runtimeId, runtime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update Notebook Runtime configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> UpdateRuntime(UpdateRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update Notebook Runtime configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> UpdateRuntimeAsync(UpdateRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update Notebook Runtime configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> UpdateRuntimeAsync(UpdateRuntimeRequest request, st::CancellationToken cancellationToken) =>
            UpdateRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateRuntime</c>.</summary>
        public virtual lro::OperationsClient UpdateRuntimeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> PollOnceUpdateRuntime(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> PollOnceUpdateRuntimeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Update Notebook Runtime configuration.
        /// </summary>
        /// <param name="runtime">
        /// Required. The Runtime to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Specifies the path, relative to `Runtime`, of
        /// the field to update. For example, to change the software configuration
        /// kernels, the `update_mask` parameter would be
        /// specified as `software_config.kernels`,
        /// and the `PATCH` request body would specify the new value, as follows:
        /// 
        /// {
        /// "software_config":{
        /// "kernels": [{
        /// 'repository':
        /// 'gcr.io/deeplearning-platform-release/pytorch-gpu', 'tag':
        /// 'latest' }],
        /// }
        /// }
        /// 
        /// 
        /// Currently, only the following fields can be updated:
        /// - `software_config.kernels`
        /// - `software_config.post_startup_script`
        /// - `software_config.custom_gpu_driver_path`
        /// - `software_config.idle_shutdown`
        /// - `software_config.idle_shutdown_timeout`
        /// - `software_config.disable_terminal`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> UpdateRuntime(Runtime runtime, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRuntime(new UpdateRuntimeRequest
            {
                Runtime = gax::GaxPreconditions.CheckNotNull(runtime, nameof(runtime)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update Notebook Runtime configuration.
        /// </summary>
        /// <param name="runtime">
        /// Required. The Runtime to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Specifies the path, relative to `Runtime`, of
        /// the field to update. For example, to change the software configuration
        /// kernels, the `update_mask` parameter would be
        /// specified as `software_config.kernels`,
        /// and the `PATCH` request body would specify the new value, as follows:
        /// 
        /// {
        /// "software_config":{
        /// "kernels": [{
        /// 'repository':
        /// 'gcr.io/deeplearning-platform-release/pytorch-gpu', 'tag':
        /// 'latest' }],
        /// }
        /// }
        /// 
        /// 
        /// Currently, only the following fields can be updated:
        /// - `software_config.kernels`
        /// - `software_config.post_startup_script`
        /// - `software_config.custom_gpu_driver_path`
        /// - `software_config.idle_shutdown`
        /// - `software_config.idle_shutdown_timeout`
        /// - `software_config.disable_terminal`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> UpdateRuntimeAsync(Runtime runtime, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRuntimeAsync(new UpdateRuntimeRequest
            {
                Runtime = gax::GaxPreconditions.CheckNotNull(runtime, nameof(runtime)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update Notebook Runtime configuration.
        /// </summary>
        /// <param name="runtime">
        /// Required. The Runtime to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Specifies the path, relative to `Runtime`, of
        /// the field to update. For example, to change the software configuration
        /// kernels, the `update_mask` parameter would be
        /// specified as `software_config.kernels`,
        /// and the `PATCH` request body would specify the new value, as follows:
        /// 
        /// {
        /// "software_config":{
        /// "kernels": [{
        /// 'repository':
        /// 'gcr.io/deeplearning-platform-release/pytorch-gpu', 'tag':
        /// 'latest' }],
        /// }
        /// }
        /// 
        /// 
        /// Currently, only the following fields can be updated:
        /// - `software_config.kernels`
        /// - `software_config.post_startup_script`
        /// - `software_config.custom_gpu_driver_path`
        /// - `software_config.idle_shutdown`
        /// - `software_config.idle_shutdown_timeout`
        /// - `software_config.disable_terminal`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> UpdateRuntimeAsync(Runtime runtime, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRuntimeAsync(runtime, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRuntime(DeleteRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRuntimeAsync(DeleteRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRuntimeAsync(DeleteRuntimeRequest request, st::CancellationToken cancellationToken) =>
            DeleteRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRuntime</c>.</summary>
        public virtual lro::OperationsClient DeleteRuntimeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteRuntime(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteRuntimeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRuntime(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRuntime(new DeleteRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRuntimeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRuntimeAsync(new DeleteRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRuntimeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRuntime(RuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRuntime(new DeleteRuntimeRequest
            {
                RuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRuntimeAsync(RuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRuntimeAsync(new DeleteRuntimeRequest
            {
                RuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRuntimeAsync(RuntimeName name, st::CancellationToken cancellationToken) =>
            DeleteRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a Managed Notebook Runtime.
        /// Perform "Start" on GPU instances; "Resume" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> StartRuntime(StartRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a Managed Notebook Runtime.
        /// Perform "Start" on GPU instances; "Resume" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> StartRuntimeAsync(StartRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a Managed Notebook Runtime.
        /// Perform "Start" on GPU instances; "Resume" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> StartRuntimeAsync(StartRuntimeRequest request, st::CancellationToken cancellationToken) =>
            StartRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartRuntime</c>.</summary>
        public virtual lro::OperationsClient StartRuntimeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> PollOnceStartRuntime(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> PollOnceStartRuntimeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Starts a Managed Notebook Runtime.
        /// Perform "Start" on GPU instances; "Resume" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> StartRuntime(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartRuntime(new StartRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a Managed Notebook Runtime.
        /// Perform "Start" on GPU instances; "Resume" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> StartRuntimeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartRuntimeAsync(new StartRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a Managed Notebook Runtime.
        /// Perform "Start" on GPU instances; "Resume" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> StartRuntimeAsync(string name, st::CancellationToken cancellationToken) =>
            StartRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops a Managed Notebook Runtime.
        /// Perform "Stop" on GPU instances; "Suspend" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> StopRuntime(StopRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a Managed Notebook Runtime.
        /// Perform "Stop" on GPU instances; "Suspend" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> StopRuntimeAsync(StopRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a Managed Notebook Runtime.
        /// Perform "Stop" on GPU instances; "Suspend" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> StopRuntimeAsync(StopRuntimeRequest request, st::CancellationToken cancellationToken) =>
            StopRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopRuntime</c>.</summary>
        public virtual lro::OperationsClient StopRuntimeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StopRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> PollOnceStopRuntime(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> PollOnceStopRuntimeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Stops a Managed Notebook Runtime.
        /// Perform "Stop" on GPU instances; "Suspend" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> StopRuntime(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopRuntime(new StopRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops a Managed Notebook Runtime.
        /// Perform "Stop" on GPU instances; "Suspend" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> StopRuntimeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopRuntimeAsync(new StopRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops a Managed Notebook Runtime.
        /// Perform "Stop" on GPU instances; "Suspend" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> StopRuntimeAsync(string name, st::CancellationToken cancellationToken) =>
            StopRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Switch a Managed Notebook Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> SwitchRuntime(SwitchRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Switch a Managed Notebook Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> SwitchRuntimeAsync(SwitchRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Switch a Managed Notebook Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> SwitchRuntimeAsync(SwitchRuntimeRequest request, st::CancellationToken cancellationToken) =>
            SwitchRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SwitchRuntime</c>.</summary>
        public virtual lro::OperationsClient SwitchRuntimeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SwitchRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> PollOnceSwitchRuntime(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SwitchRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SwitchRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> PollOnceSwitchRuntimeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SwitchRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Switch a Managed Notebook Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> SwitchRuntime(string name, gaxgrpc::CallSettings callSettings = null) =>
            SwitchRuntime(new SwitchRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Switch a Managed Notebook Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> SwitchRuntimeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            SwitchRuntimeAsync(new SwitchRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Switch a Managed Notebook Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> SwitchRuntimeAsync(string name, st::CancellationToken cancellationToken) =>
            SwitchRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resets a Managed Notebook Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> ResetRuntime(ResetRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets a Managed Notebook Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> ResetRuntimeAsync(ResetRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets a Managed Notebook Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> ResetRuntimeAsync(ResetRuntimeRequest request, st::CancellationToken cancellationToken) =>
            ResetRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResetRuntime</c>.</summary>
        public virtual lro::OperationsClient ResetRuntimeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResetRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> PollOnceResetRuntime(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResetRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> PollOnceResetRuntimeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Resets a Managed Notebook Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> ResetRuntime(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResetRuntime(new ResetRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resets a Managed Notebook Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> ResetRuntimeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResetRuntimeAsync(new ResetRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resets a Managed Notebook Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> ResetRuntimeAsync(string name, st::CancellationToken cancellationToken) =>
            ResetRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upgrades a Managed Notebook Runtime to the latest version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> UpgradeRuntime(UpgradeRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrades a Managed Notebook Runtime to the latest version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> UpgradeRuntimeAsync(UpgradeRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrades a Managed Notebook Runtime to the latest version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> UpgradeRuntimeAsync(UpgradeRuntimeRequest request, st::CancellationToken cancellationToken) =>
            UpgradeRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpgradeRuntime</c>.</summary>
        public virtual lro::OperationsClient UpgradeRuntimeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpgradeRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> PollOnceUpgradeRuntime(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpgradeRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> PollOnceUpgradeRuntimeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Upgrades a Managed Notebook Runtime to the latest version.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> UpgradeRuntime(string name, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeRuntime(new UpgradeRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Upgrades a Managed Notebook Runtime to the latest version.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> UpgradeRuntimeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeRuntimeAsync(new UpgradeRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Upgrades a Managed Notebook Runtime to the latest version.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> UpgradeRuntimeAsync(string name, st::CancellationToken cancellationToken) =>
            UpgradeRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Report and process a runtime event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> ReportRuntimeEvent(ReportRuntimeEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Report and process a runtime event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> ReportRuntimeEventAsync(ReportRuntimeEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Report and process a runtime event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> ReportRuntimeEventAsync(ReportRuntimeEventRequest request, st::CancellationToken cancellationToken) =>
            ReportRuntimeEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReportRuntimeEvent</c>.</summary>
        public virtual lro::OperationsClient ReportRuntimeEventOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ReportRuntimeEvent</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> PollOnceReportRuntimeEvent(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReportRuntimeEventOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReportRuntimeEvent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> PollOnceReportRuntimeEventAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReportRuntimeEventOperationsClient, callSettings);

        /// <summary>
        /// Report and process a runtime event.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> ReportRuntimeEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            ReportRuntimeEvent(new ReportRuntimeEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Report and process a runtime event.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> ReportRuntimeEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ReportRuntimeEventAsync(new ReportRuntimeEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Report and process a runtime event.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> ReportRuntimeEventAsync(string name, st::CancellationToken cancellationToken) =>
            ReportRuntimeEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Report and process a runtime event.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> ReportRuntimeEvent(RuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            ReportRuntimeEvent(new ReportRuntimeEventRequest
            {
                RuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Report and process a runtime event.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> ReportRuntimeEventAsync(RuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            ReportRuntimeEventAsync(new ReportRuntimeEventRequest
            {
                RuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Report and process a runtime event.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> ReportRuntimeEventAsync(RuntimeName name, st::CancellationToken cancellationToken) =>
            ReportRuntimeEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an access token for the consumer service account that the customer
        /// attached to the runtime. Only accessible from the tenant instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RefreshRuntimeTokenInternalResponse RefreshRuntimeTokenInternal(RefreshRuntimeTokenInternalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an access token for the consumer service account that the customer
        /// attached to the runtime. Only accessible from the tenant instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RefreshRuntimeTokenInternalResponse> RefreshRuntimeTokenInternalAsync(RefreshRuntimeTokenInternalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an access token for the consumer service account that the customer
        /// attached to the runtime. Only accessible from the tenant instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RefreshRuntimeTokenInternalResponse> RefreshRuntimeTokenInternalAsync(RefreshRuntimeTokenInternalRequest request, st::CancellationToken cancellationToken) =>
            RefreshRuntimeTokenInternalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an access token for the consumer service account that the customer
        /// attached to the runtime. Only accessible from the tenant instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="vmId">
        /// Required. The VM hardware token for authenticating the VM.
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RefreshRuntimeTokenInternalResponse RefreshRuntimeTokenInternal(string name, string vmId, gaxgrpc::CallSettings callSettings = null) =>
            RefreshRuntimeTokenInternal(new RefreshRuntimeTokenInternalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                VmId = gax::GaxPreconditions.CheckNotNullOrEmpty(vmId, nameof(vmId)),
            }, callSettings);

        /// <summary>
        /// Gets an access token for the consumer service account that the customer
        /// attached to the runtime. Only accessible from the tenant instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="vmId">
        /// Required. The VM hardware token for authenticating the VM.
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RefreshRuntimeTokenInternalResponse> RefreshRuntimeTokenInternalAsync(string name, string vmId, gaxgrpc::CallSettings callSettings = null) =>
            RefreshRuntimeTokenInternalAsync(new RefreshRuntimeTokenInternalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                VmId = gax::GaxPreconditions.CheckNotNullOrEmpty(vmId, nameof(vmId)),
            }, callSettings);

        /// <summary>
        /// Gets an access token for the consumer service account that the customer
        /// attached to the runtime. Only accessible from the tenant instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="vmId">
        /// Required. The VM hardware token for authenticating the VM.
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RefreshRuntimeTokenInternalResponse> RefreshRuntimeTokenInternalAsync(string name, string vmId, st::CancellationToken cancellationToken) =>
            RefreshRuntimeTokenInternalAsync(name, vmId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an access token for the consumer service account that the customer
        /// attached to the runtime. Only accessible from the tenant instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="vmId">
        /// Required. The VM hardware token for authenticating the VM.
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RefreshRuntimeTokenInternalResponse RefreshRuntimeTokenInternal(RuntimeName name, string vmId, gaxgrpc::CallSettings callSettings = null) =>
            RefreshRuntimeTokenInternal(new RefreshRuntimeTokenInternalRequest
            {
                RuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                VmId = gax::GaxPreconditions.CheckNotNullOrEmpty(vmId, nameof(vmId)),
            }, callSettings);

        /// <summary>
        /// Gets an access token for the consumer service account that the customer
        /// attached to the runtime. Only accessible from the tenant instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="vmId">
        /// Required. The VM hardware token for authenticating the VM.
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RefreshRuntimeTokenInternalResponse> RefreshRuntimeTokenInternalAsync(RuntimeName name, string vmId, gaxgrpc::CallSettings callSettings = null) =>
            RefreshRuntimeTokenInternalAsync(new RefreshRuntimeTokenInternalRequest
            {
                RuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                VmId = gax::GaxPreconditions.CheckNotNullOrEmpty(vmId, nameof(vmId)),
            }, callSettings);

        /// <summary>
        /// Gets an access token for the consumer service account that the customer
        /// attached to the runtime. Only accessible from the tenant instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
        /// </param>
        /// <param name="vmId">
        /// Required. The VM hardware token for authenticating the VM.
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RefreshRuntimeTokenInternalResponse> RefreshRuntimeTokenInternalAsync(RuntimeName name, string vmId, st::CancellationToken cancellationToken) =>
            RefreshRuntimeTokenInternalAsync(name, vmId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given a Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> DiagnoseRuntime(DiagnoseRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given a Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> DiagnoseRuntimeAsync(DiagnoseRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given a Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> DiagnoseRuntimeAsync(DiagnoseRuntimeRequest request, st::CancellationToken cancellationToken) =>
            DiagnoseRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DiagnoseRuntime</c>.</summary>
        public virtual lro::OperationsClient DiagnoseRuntimeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DiagnoseRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> PollOnceDiagnoseRuntime(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DiagnoseRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DiagnoseRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> PollOnceDiagnoseRuntimeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Runtime, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DiagnoseRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given a Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtimes_id}`
        /// </param>
        /// <param name="diagnosticConfig">
        /// Required. Defines flags that are used to run the diagnostic tool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> DiagnoseRuntime(string name, DiagnosticConfig diagnosticConfig, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseRuntime(new DiagnoseRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DiagnosticConfig = gax::GaxPreconditions.CheckNotNull(diagnosticConfig, nameof(diagnosticConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given a Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtimes_id}`
        /// </param>
        /// <param name="diagnosticConfig">
        /// Required. Defines flags that are used to run the diagnostic tool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> DiagnoseRuntimeAsync(string name, DiagnosticConfig diagnosticConfig, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseRuntimeAsync(new DiagnoseRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DiagnosticConfig = gax::GaxPreconditions.CheckNotNull(diagnosticConfig, nameof(diagnosticConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given a Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtimes_id}`
        /// </param>
        /// <param name="diagnosticConfig">
        /// Required. Defines flags that are used to run the diagnostic tool
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> DiagnoseRuntimeAsync(string name, DiagnosticConfig diagnosticConfig, st::CancellationToken cancellationToken) =>
            DiagnoseRuntimeAsync(name, diagnosticConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given a Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtimes_id}`
        /// </param>
        /// <param name="diagnosticConfig">
        /// Required. Defines flags that are used to run the diagnostic tool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Runtime, OperationMetadata> DiagnoseRuntime(RuntimeName name, DiagnosticConfig diagnosticConfig, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseRuntime(new DiagnoseRuntimeRequest
            {
                RuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DiagnosticConfig = gax::GaxPreconditions.CheckNotNull(diagnosticConfig, nameof(diagnosticConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given a Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtimes_id}`
        /// </param>
        /// <param name="diagnosticConfig">
        /// Required. Defines flags that are used to run the diagnostic tool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> DiagnoseRuntimeAsync(RuntimeName name, DiagnosticConfig diagnosticConfig, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseRuntimeAsync(new DiagnoseRuntimeRequest
            {
                RuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DiagnosticConfig = gax::GaxPreconditions.CheckNotNull(diagnosticConfig, nameof(diagnosticConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given a Runtime.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/runtimes/{runtimes_id}`
        /// </param>
        /// <param name="diagnosticConfig">
        /// Required. Defines flags that are used to run the diagnostic tool
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Runtime, OperationMetadata>> DiagnoseRuntimeAsync(RuntimeName name, DiagnosticConfig diagnosticConfig, st::CancellationToken cancellationToken) =>
            DiagnoseRuntimeAsync(name, diagnosticConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ManagedNotebookService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// API v1 service for Managed Notebooks.
    /// </remarks>
    public sealed partial class ManagedNotebookServiceClientImpl : ManagedNotebookServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListRuntimesRequest, ListRuntimesResponse> _callListRuntimes;

        private readonly gaxgrpc::ApiCall<GetRuntimeRequest, Runtime> _callGetRuntime;

        private readonly gaxgrpc::ApiCall<CreateRuntimeRequest, lro::Operation> _callCreateRuntime;

        private readonly gaxgrpc::ApiCall<UpdateRuntimeRequest, lro::Operation> _callUpdateRuntime;

        private readonly gaxgrpc::ApiCall<DeleteRuntimeRequest, lro::Operation> _callDeleteRuntime;

        private readonly gaxgrpc::ApiCall<StartRuntimeRequest, lro::Operation> _callStartRuntime;

        private readonly gaxgrpc::ApiCall<StopRuntimeRequest, lro::Operation> _callStopRuntime;

        private readonly gaxgrpc::ApiCall<SwitchRuntimeRequest, lro::Operation> _callSwitchRuntime;

        private readonly gaxgrpc::ApiCall<ResetRuntimeRequest, lro::Operation> _callResetRuntime;

        private readonly gaxgrpc::ApiCall<UpgradeRuntimeRequest, lro::Operation> _callUpgradeRuntime;

        private readonly gaxgrpc::ApiCall<ReportRuntimeEventRequest, lro::Operation> _callReportRuntimeEvent;

        private readonly gaxgrpc::ApiCall<RefreshRuntimeTokenInternalRequest, RefreshRuntimeTokenInternalResponse> _callRefreshRuntimeTokenInternal;

        private readonly gaxgrpc::ApiCall<DiagnoseRuntimeRequest, lro::Operation> _callDiagnoseRuntime;

        /// <summary>
        /// Constructs a client wrapper for the ManagedNotebookService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ManagedNotebookServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ManagedNotebookServiceClientImpl(ManagedNotebookService.ManagedNotebookServiceClient grpcClient, ManagedNotebookServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ManagedNotebookServiceSettings effectiveSettings = settings ?? ManagedNotebookServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateRuntimeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRuntimeOperationsSettings, logger);
            UpdateRuntimeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateRuntimeOperationsSettings, logger);
            DeleteRuntimeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRuntimeOperationsSettings, logger);
            StartRuntimeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartRuntimeOperationsSettings, logger);
            StopRuntimeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopRuntimeOperationsSettings, logger);
            SwitchRuntimeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SwitchRuntimeOperationsSettings, logger);
            ResetRuntimeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResetRuntimeOperationsSettings, logger);
            UpgradeRuntimeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpgradeRuntimeOperationsSettings, logger);
            ReportRuntimeEventOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReportRuntimeEventOperationsSettings, logger);
            DiagnoseRuntimeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DiagnoseRuntimeOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListRuntimes = clientHelper.BuildApiCall<ListRuntimesRequest, ListRuntimesResponse>("ListRuntimes", grpcClient.ListRuntimesAsync, grpcClient.ListRuntimes, effectiveSettings.ListRuntimesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRuntimes);
            Modify_ListRuntimesApiCall(ref _callListRuntimes);
            _callGetRuntime = clientHelper.BuildApiCall<GetRuntimeRequest, Runtime>("GetRuntime", grpcClient.GetRuntimeAsync, grpcClient.GetRuntime, effectiveSettings.GetRuntimeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRuntime);
            Modify_GetRuntimeApiCall(ref _callGetRuntime);
            _callCreateRuntime = clientHelper.BuildApiCall<CreateRuntimeRequest, lro::Operation>("CreateRuntime", grpcClient.CreateRuntimeAsync, grpcClient.CreateRuntime, effectiveSettings.CreateRuntimeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRuntime);
            Modify_CreateRuntimeApiCall(ref _callCreateRuntime);
            _callUpdateRuntime = clientHelper.BuildApiCall<UpdateRuntimeRequest, lro::Operation>("UpdateRuntime", grpcClient.UpdateRuntimeAsync, grpcClient.UpdateRuntime, effectiveSettings.UpdateRuntimeSettings).WithGoogleRequestParam("runtime.name", request => request.Runtime?.Name);
            Modify_ApiCall(ref _callUpdateRuntime);
            Modify_UpdateRuntimeApiCall(ref _callUpdateRuntime);
            _callDeleteRuntime = clientHelper.BuildApiCall<DeleteRuntimeRequest, lro::Operation>("DeleteRuntime", grpcClient.DeleteRuntimeAsync, grpcClient.DeleteRuntime, effectiveSettings.DeleteRuntimeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRuntime);
            Modify_DeleteRuntimeApiCall(ref _callDeleteRuntime);
            _callStartRuntime = clientHelper.BuildApiCall<StartRuntimeRequest, lro::Operation>("StartRuntime", grpcClient.StartRuntimeAsync, grpcClient.StartRuntime, effectiveSettings.StartRuntimeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartRuntime);
            Modify_StartRuntimeApiCall(ref _callStartRuntime);
            _callStopRuntime = clientHelper.BuildApiCall<StopRuntimeRequest, lro::Operation>("StopRuntime", grpcClient.StopRuntimeAsync, grpcClient.StopRuntime, effectiveSettings.StopRuntimeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopRuntime);
            Modify_StopRuntimeApiCall(ref _callStopRuntime);
            _callSwitchRuntime = clientHelper.BuildApiCall<SwitchRuntimeRequest, lro::Operation>("SwitchRuntime", grpcClient.SwitchRuntimeAsync, grpcClient.SwitchRuntime, effectiveSettings.SwitchRuntimeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSwitchRuntime);
            Modify_SwitchRuntimeApiCall(ref _callSwitchRuntime);
            _callResetRuntime = clientHelper.BuildApiCall<ResetRuntimeRequest, lro::Operation>("ResetRuntime", grpcClient.ResetRuntimeAsync, grpcClient.ResetRuntime, effectiveSettings.ResetRuntimeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResetRuntime);
            Modify_ResetRuntimeApiCall(ref _callResetRuntime);
            _callUpgradeRuntime = clientHelper.BuildApiCall<UpgradeRuntimeRequest, lro::Operation>("UpgradeRuntime", grpcClient.UpgradeRuntimeAsync, grpcClient.UpgradeRuntime, effectiveSettings.UpgradeRuntimeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpgradeRuntime);
            Modify_UpgradeRuntimeApiCall(ref _callUpgradeRuntime);
            _callReportRuntimeEvent = clientHelper.BuildApiCall<ReportRuntimeEventRequest, lro::Operation>("ReportRuntimeEvent", grpcClient.ReportRuntimeEventAsync, grpcClient.ReportRuntimeEvent, effectiveSettings.ReportRuntimeEventSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callReportRuntimeEvent);
            Modify_ReportRuntimeEventApiCall(ref _callReportRuntimeEvent);
            _callRefreshRuntimeTokenInternal = clientHelper.BuildApiCall<RefreshRuntimeTokenInternalRequest, RefreshRuntimeTokenInternalResponse>("RefreshRuntimeTokenInternal", grpcClient.RefreshRuntimeTokenInternalAsync, grpcClient.RefreshRuntimeTokenInternal, effectiveSettings.RefreshRuntimeTokenInternalSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRefreshRuntimeTokenInternal);
            Modify_RefreshRuntimeTokenInternalApiCall(ref _callRefreshRuntimeTokenInternal);
            _callDiagnoseRuntime = clientHelper.BuildApiCall<DiagnoseRuntimeRequest, lro::Operation>("DiagnoseRuntime", grpcClient.DiagnoseRuntimeAsync, grpcClient.DiagnoseRuntime, effectiveSettings.DiagnoseRuntimeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDiagnoseRuntime);
            Modify_DiagnoseRuntimeApiCall(ref _callDiagnoseRuntime);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListRuntimesApiCall(ref gaxgrpc::ApiCall<ListRuntimesRequest, ListRuntimesResponse> call);

        partial void Modify_GetRuntimeApiCall(ref gaxgrpc::ApiCall<GetRuntimeRequest, Runtime> call);

        partial void Modify_CreateRuntimeApiCall(ref gaxgrpc::ApiCall<CreateRuntimeRequest, lro::Operation> call);

        partial void Modify_UpdateRuntimeApiCall(ref gaxgrpc::ApiCall<UpdateRuntimeRequest, lro::Operation> call);

        partial void Modify_DeleteRuntimeApiCall(ref gaxgrpc::ApiCall<DeleteRuntimeRequest, lro::Operation> call);

        partial void Modify_StartRuntimeApiCall(ref gaxgrpc::ApiCall<StartRuntimeRequest, lro::Operation> call);

        partial void Modify_StopRuntimeApiCall(ref gaxgrpc::ApiCall<StopRuntimeRequest, lro::Operation> call);

        partial void Modify_SwitchRuntimeApiCall(ref gaxgrpc::ApiCall<SwitchRuntimeRequest, lro::Operation> call);

        partial void Modify_ResetRuntimeApiCall(ref gaxgrpc::ApiCall<ResetRuntimeRequest, lro::Operation> call);

        partial void Modify_UpgradeRuntimeApiCall(ref gaxgrpc::ApiCall<UpgradeRuntimeRequest, lro::Operation> call);

        partial void Modify_ReportRuntimeEventApiCall(ref gaxgrpc::ApiCall<ReportRuntimeEventRequest, lro::Operation> call);

        partial void Modify_RefreshRuntimeTokenInternalApiCall(ref gaxgrpc::ApiCall<RefreshRuntimeTokenInternalRequest, RefreshRuntimeTokenInternalResponse> call);

        partial void Modify_DiagnoseRuntimeApiCall(ref gaxgrpc::ApiCall<DiagnoseRuntimeRequest, lro::Operation> call);

        partial void OnConstruction(ManagedNotebookService.ManagedNotebookServiceClient grpcClient, ManagedNotebookServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ManagedNotebookService client</summary>
        public override ManagedNotebookService.ManagedNotebookServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListRuntimesRequest(ref ListRuntimesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRuntimeRequest(ref GetRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRuntimeRequest(ref CreateRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRuntimeRequest(ref UpdateRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRuntimeRequest(ref DeleteRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartRuntimeRequest(ref StartRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopRuntimeRequest(ref StopRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SwitchRuntimeRequest(ref SwitchRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetRuntimeRequest(ref ResetRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpgradeRuntimeRequest(ref UpgradeRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReportRuntimeEventRequest(ref ReportRuntimeEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RefreshRuntimeTokenInternalRequest(ref RefreshRuntimeTokenInternalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DiagnoseRuntimeRequest(ref DiagnoseRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Runtimes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Runtime"/> resources.</returns>
        public override gax::PagedEnumerable<ListRuntimesResponse, Runtime> ListRuntimes(ListRuntimesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuntimesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRuntimesRequest, ListRuntimesResponse, Runtime>(_callListRuntimes, request, callSettings);
        }

        /// <summary>
        /// Lists Runtimes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Runtime"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRuntimesResponse, Runtime> ListRuntimesAsync(ListRuntimesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuntimesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRuntimesRequest, ListRuntimesResponse, Runtime>(_callListRuntimes, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Runtime. The location must be a regional endpoint
        /// rather than zonal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Runtime GetRuntime(GetRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuntimeRequest(ref request, ref callSettings);
            return _callGetRuntime.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Runtime. The location must be a regional endpoint
        /// rather than zonal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Runtime> GetRuntimeAsync(GetRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuntimeRequest(ref request, ref callSettings);
            return _callGetRuntime.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateRuntime</c>.</summary>
        public override lro::OperationsClient CreateRuntimeOperationsClient { get; }

        /// <summary>
        /// Creates a new Runtime in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Runtime, OperationMetadata> CreateRuntime(CreateRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(_callCreateRuntime.Sync(request, callSettings), CreateRuntimeOperationsClient);
        }

        /// <summary>
        /// Creates a new Runtime in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Runtime, OperationMetadata>> CreateRuntimeAsync(CreateRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(await _callCreateRuntime.Async(request, callSettings).ConfigureAwait(false), CreateRuntimeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateRuntime</c>.</summary>
        public override lro::OperationsClient UpdateRuntimeOperationsClient { get; }

        /// <summary>
        /// Update Notebook Runtime configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Runtime, OperationMetadata> UpdateRuntime(UpdateRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(_callUpdateRuntime.Sync(request, callSettings), UpdateRuntimeOperationsClient);
        }

        /// <summary>
        /// Update Notebook Runtime configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Runtime, OperationMetadata>> UpdateRuntimeAsync(UpdateRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(await _callUpdateRuntime.Async(request, callSettings).ConfigureAwait(false), UpdateRuntimeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteRuntime</c>.</summary>
        public override lro::OperationsClient DeleteRuntimeOperationsClient { get; }

        /// <summary>
        /// Deletes a single Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteRuntime(DeleteRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteRuntime.Sync(request, callSettings), DeleteRuntimeOperationsClient);
        }

        /// <summary>
        /// Deletes a single Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRuntimeAsync(DeleteRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteRuntime.Async(request, callSettings).ConfigureAwait(false), DeleteRuntimeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartRuntime</c>.</summary>
        public override lro::OperationsClient StartRuntimeOperationsClient { get; }

        /// <summary>
        /// Starts a Managed Notebook Runtime.
        /// Perform "Start" on GPU instances; "Resume" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Runtime, OperationMetadata> StartRuntime(StartRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(_callStartRuntime.Sync(request, callSettings), StartRuntimeOperationsClient);
        }

        /// <summary>
        /// Starts a Managed Notebook Runtime.
        /// Perform "Start" on GPU instances; "Resume" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Runtime, OperationMetadata>> StartRuntimeAsync(StartRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(await _callStartRuntime.Async(request, callSettings).ConfigureAwait(false), StartRuntimeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopRuntime</c>.</summary>
        public override lro::OperationsClient StopRuntimeOperationsClient { get; }

        /// <summary>
        /// Stops a Managed Notebook Runtime.
        /// Perform "Stop" on GPU instances; "Suspend" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Runtime, OperationMetadata> StopRuntime(StopRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(_callStopRuntime.Sync(request, callSettings), StopRuntimeOperationsClient);
        }

        /// <summary>
        /// Stops a Managed Notebook Runtime.
        /// Perform "Stop" on GPU instances; "Suspend" on CPU instances
        /// See:
        /// https://cloud.google.com/compute/docs/instances/stop-start-instance
        /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Runtime, OperationMetadata>> StopRuntimeAsync(StopRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(await _callStopRuntime.Async(request, callSettings).ConfigureAwait(false), StopRuntimeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SwitchRuntime</c>.</summary>
        public override lro::OperationsClient SwitchRuntimeOperationsClient { get; }

        /// <summary>
        /// Switch a Managed Notebook Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Runtime, OperationMetadata> SwitchRuntime(SwitchRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SwitchRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(_callSwitchRuntime.Sync(request, callSettings), SwitchRuntimeOperationsClient);
        }

        /// <summary>
        /// Switch a Managed Notebook Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Runtime, OperationMetadata>> SwitchRuntimeAsync(SwitchRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SwitchRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(await _callSwitchRuntime.Async(request, callSettings).ConfigureAwait(false), SwitchRuntimeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ResetRuntime</c>.</summary>
        public override lro::OperationsClient ResetRuntimeOperationsClient { get; }

        /// <summary>
        /// Resets a Managed Notebook Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Runtime, OperationMetadata> ResetRuntime(ResetRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(_callResetRuntime.Sync(request, callSettings), ResetRuntimeOperationsClient);
        }

        /// <summary>
        /// Resets a Managed Notebook Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Runtime, OperationMetadata>> ResetRuntimeAsync(ResetRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(await _callResetRuntime.Async(request, callSettings).ConfigureAwait(false), ResetRuntimeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpgradeRuntime</c>.</summary>
        public override lro::OperationsClient UpgradeRuntimeOperationsClient { get; }

        /// <summary>
        /// Upgrades a Managed Notebook Runtime to the latest version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Runtime, OperationMetadata> UpgradeRuntime(UpgradeRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(_callUpgradeRuntime.Sync(request, callSettings), UpgradeRuntimeOperationsClient);
        }

        /// <summary>
        /// Upgrades a Managed Notebook Runtime to the latest version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Runtime, OperationMetadata>> UpgradeRuntimeAsync(UpgradeRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(await _callUpgradeRuntime.Async(request, callSettings).ConfigureAwait(false), UpgradeRuntimeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReportRuntimeEvent</c>.</summary>
        public override lro::OperationsClient ReportRuntimeEventOperationsClient { get; }

        /// <summary>
        /// Report and process a runtime event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Runtime, OperationMetadata> ReportRuntimeEvent(ReportRuntimeEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportRuntimeEventRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(_callReportRuntimeEvent.Sync(request, callSettings), ReportRuntimeEventOperationsClient);
        }

        /// <summary>
        /// Report and process a runtime event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Runtime, OperationMetadata>> ReportRuntimeEventAsync(ReportRuntimeEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportRuntimeEventRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(await _callReportRuntimeEvent.Async(request, callSettings).ConfigureAwait(false), ReportRuntimeEventOperationsClient);
        }

        /// <summary>
        /// Gets an access token for the consumer service account that the customer
        /// attached to the runtime. Only accessible from the tenant instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RefreshRuntimeTokenInternalResponse RefreshRuntimeTokenInternal(RefreshRuntimeTokenInternalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RefreshRuntimeTokenInternalRequest(ref request, ref callSettings);
            return _callRefreshRuntimeTokenInternal.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an access token for the consumer service account that the customer
        /// attached to the runtime. Only accessible from the tenant instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RefreshRuntimeTokenInternalResponse> RefreshRuntimeTokenInternalAsync(RefreshRuntimeTokenInternalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RefreshRuntimeTokenInternalRequest(ref request, ref callSettings);
            return _callRefreshRuntimeTokenInternal.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DiagnoseRuntime</c>.</summary>
        public override lro::OperationsClient DiagnoseRuntimeOperationsClient { get; }

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given a Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Runtime, OperationMetadata> DiagnoseRuntime(DiagnoseRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiagnoseRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(_callDiagnoseRuntime.Sync(request, callSettings), DiagnoseRuntimeOperationsClient);
        }

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given a Runtime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Runtime, OperationMetadata>> DiagnoseRuntimeAsync(DiagnoseRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiagnoseRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<Runtime, OperationMetadata>(await _callDiagnoseRuntime.Async(request, callSettings).ConfigureAwait(false), DiagnoseRuntimeOperationsClient);
        }
    }

    public partial class ListRuntimesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRuntimesResponse : gaxgrpc::IPageResponse<Runtime>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Runtime> GetEnumerator() => Runtimes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ManagedNotebookService
    {
        public partial class ManagedNotebookServiceClient
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

    public static partial class ManagedNotebookService
    {
        public partial class ManagedNotebookServiceClient
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
