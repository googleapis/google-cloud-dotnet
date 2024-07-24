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

namespace Google.Cloud.DataCatalog.Lineage.V1
{
    /// <summary>Settings for <see cref="LineageClient"/> instances.</summary>
    public sealed partial class LineageSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LineageSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LineageSettings"/>.</returns>
        public static LineageSettings GetDefault() => new LineageSettings();

        /// <summary>Constructs a new <see cref="LineageSettings"/> object with default settings.</summary>
        public LineageSettings()
        {
        }

        private LineageSettings(LineageSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ProcessOpenLineageRunEventSettings = existing.ProcessOpenLineageRunEventSettings;
            CreateProcessSettings = existing.CreateProcessSettings;
            UpdateProcessSettings = existing.UpdateProcessSettings;
            GetProcessSettings = existing.GetProcessSettings;
            ListProcessesSettings = existing.ListProcessesSettings;
            DeleteProcessSettings = existing.DeleteProcessSettings;
            DeleteProcessOperationsSettings = existing.DeleteProcessOperationsSettings.Clone();
            CreateRunSettings = existing.CreateRunSettings;
            UpdateRunSettings = existing.UpdateRunSettings;
            GetRunSettings = existing.GetRunSettings;
            ListRunsSettings = existing.ListRunsSettings;
            DeleteRunSettings = existing.DeleteRunSettings;
            DeleteRunOperationsSettings = existing.DeleteRunOperationsSettings.Clone();
            CreateLineageEventSettings = existing.CreateLineageEventSettings;
            GetLineageEventSettings = existing.GetLineageEventSettings;
            ListLineageEventsSettings = existing.ListLineageEventsSettings;
            DeleteLineageEventSettings = existing.DeleteLineageEventSettings;
            SearchLinksSettings = existing.SearchLinksSettings;
            BatchSearchLinkProcessesSettings = existing.BatchSearchLinkProcessesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LineageSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineageClient.ProcessOpenLineageRunEvent</c> and <c>LineageClient.ProcessOpenLineageRunEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ProcessOpenLineageRunEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LineageClient.CreateProcess</c>
        ///  and <c>LineageClient.CreateProcessAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProcessSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LineageClient.UpdateProcess</c>
        ///  and <c>LineageClient.UpdateProcessAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProcessSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LineageClient.GetProcess</c>
        ///  and <c>LineageClient.GetProcessAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProcessSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LineageClient.ListProcesses</c>
        ///  and <c>LineageClient.ListProcessesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProcessesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LineageClient.DeleteProcess</c>
        ///  and <c>LineageClient.DeleteProcessAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProcessSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LineageClient.DeleteProcess</c> and
        /// <c>LineageClient.DeleteProcessAsync</c>.
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
        public lro::OperationsSettings DeleteProcessOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LineageClient.CreateRun</c>
        /// and <c>LineageClient.CreateRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LineageClient.UpdateRun</c>
        /// and <c>LineageClient.UpdateRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LineageClient.GetRun</c>
        /// and <c>LineageClient.GetRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LineageClient.ListRuns</c>
        /// and <c>LineageClient.ListRunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRunsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LineageClient.DeleteRun</c>
        /// and <c>LineageClient.DeleteRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LineageClient.DeleteRun</c> and
        /// <c>LineageClient.DeleteRunAsync</c>.
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
        public lro::OperationsSettings DeleteRunOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineageClient.CreateLineageEvent</c> and <c>LineageClient.CreateLineageEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateLineageEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineageClient.GetLineageEvent</c> and <c>LineageClient.GetLineageEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLineageEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineageClient.ListLineageEvents</c> and <c>LineageClient.ListLineageEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLineageEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineageClient.DeleteLineageEvent</c> and <c>LineageClient.DeleteLineageEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteLineageEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LineageClient.SearchLinks</c>
        ///  and <c>LineageClient.SearchLinksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineageClient.BatchSearchLinkProcesses</c> and <c>LineageClient.BatchSearchLinkProcessesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchSearchLinkProcessesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LineageSettings"/> object.</returns>
        public LineageSettings Clone() => new LineageSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LineageClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class LineageClientBuilder : gaxgrpc::ClientBuilderBase<LineageClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LineageSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LineageClientBuilder() : base(LineageClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LineageClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LineageClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LineageClient Build()
        {
            LineageClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LineageClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LineageClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LineageClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LineageClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LineageClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LineageClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LineageClient.ChannelPool;
    }

    /// <summary>Lineage client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Lineage is used to track data flows between assets over time. You can
    /// create [LineageEvents][google.cloud.datacatalog.lineage.v1.LineageEvent]
    /// to record lineage between multiple sources and a single target, for
    /// example, when table data is based on data from multiple tables.
    /// </remarks>
    public abstract partial class LineageClient
    {
        /// <summary>
        /// The default endpoint for the Lineage service, which is a host of "datalineage.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datalineage.googleapis.com:443";

        /// <summary>The default Lineage scopes.</summary>
        /// <remarks>
        /// The default Lineage scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Lineage.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LineageClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="LineageClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LineageClient"/>.</returns>
        public static stt::Task<LineageClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LineageClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LineageClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="LineageClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LineageClient"/>.</returns>
        public static LineageClient Create() => new LineageClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LineageClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LineageSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LineageClient"/>.</returns>
        internal static LineageClient Create(grpccore::CallInvoker callInvoker, LineageSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Lineage.LineageClient grpcClient = new Lineage.LineageClient(callInvoker);
            return new LineageClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Lineage client</summary>
        public virtual Lineage.LineageClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new lineage events together with their parents: process and run.
        /// Updates the process and run if they already exist.
        /// Mapped from Open Lineage specification:
        /// https://github.com/OpenLineage/OpenLineage/blob/main/spec/OpenLineage.json.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessOpenLineageRunEventResponse ProcessOpenLineageRunEvent(ProcessOpenLineageRunEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new lineage events together with their parents: process and run.
        /// Updates the process and run if they already exist.
        /// Mapped from Open Lineage specification:
        /// https://github.com/OpenLineage/OpenLineage/blob/main/spec/OpenLineage.json.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessOpenLineageRunEventResponse> ProcessOpenLineageRunEventAsync(ProcessOpenLineageRunEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new lineage events together with their parents: process and run.
        /// Updates the process and run if they already exist.
        /// Mapped from Open Lineage specification:
        /// https://github.com/OpenLineage/OpenLineage/blob/main/spec/OpenLineage.json.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessOpenLineageRunEventResponse> ProcessOpenLineageRunEventAsync(ProcessOpenLineageRunEventRequest request, st::CancellationToken cancellationToken) =>
            ProcessOpenLineageRunEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new lineage events together with their parents: process and run.
        /// Updates the process and run if they already exist.
        /// Mapped from Open Lineage specification:
        /// https://github.com/OpenLineage/OpenLineage/blob/main/spec/OpenLineage.json.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and its location that should own the
        /// process, run, and lineage event.
        /// </param>
        /// <param name="openLineage">
        /// Required. OpenLineage message following OpenLineage format:
        /// https://github.com/OpenLineage/OpenLineage/blob/main/spec/OpenLineage.json
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessOpenLineageRunEventResponse ProcessOpenLineageRunEvent(string parent, wkt::Struct openLineage, gaxgrpc::CallSettings callSettings = null) =>
            ProcessOpenLineageRunEvent(new ProcessOpenLineageRunEventRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OpenLineage = gax::GaxPreconditions.CheckNotNull(openLineage, nameof(openLineage)),
            }, callSettings);

        /// <summary>
        /// Creates new lineage events together with their parents: process and run.
        /// Updates the process and run if they already exist.
        /// Mapped from Open Lineage specification:
        /// https://github.com/OpenLineage/OpenLineage/blob/main/spec/OpenLineage.json.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and its location that should own the
        /// process, run, and lineage event.
        /// </param>
        /// <param name="openLineage">
        /// Required. OpenLineage message following OpenLineage format:
        /// https://github.com/OpenLineage/OpenLineage/blob/main/spec/OpenLineage.json
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessOpenLineageRunEventResponse> ProcessOpenLineageRunEventAsync(string parent, wkt::Struct openLineage, gaxgrpc::CallSettings callSettings = null) =>
            ProcessOpenLineageRunEventAsync(new ProcessOpenLineageRunEventRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OpenLineage = gax::GaxPreconditions.CheckNotNull(openLineage, nameof(openLineage)),
            }, callSettings);

        /// <summary>
        /// Creates new lineage events together with their parents: process and run.
        /// Updates the process and run if they already exist.
        /// Mapped from Open Lineage specification:
        /// https://github.com/OpenLineage/OpenLineage/blob/main/spec/OpenLineage.json.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and its location that should own the
        /// process, run, and lineage event.
        /// </param>
        /// <param name="openLineage">
        /// Required. OpenLineage message following OpenLineage format:
        /// https://github.com/OpenLineage/OpenLineage/blob/main/spec/OpenLineage.json
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessOpenLineageRunEventResponse> ProcessOpenLineageRunEventAsync(string parent, wkt::Struct openLineage, st::CancellationToken cancellationToken) =>
            ProcessOpenLineageRunEventAsync(parent, openLineage, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Process CreateProcess(CreateProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> CreateProcessAsync(CreateProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> CreateProcessAsync(CreateProcessRequest request, st::CancellationToken cancellationToken) =>
            CreateProcessAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new process.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and its location that should own the
        /// process.
        /// </param>
        /// <param name="process">
        /// Required. The process to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Process CreateProcess(string parent, Process process, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcess(new CreateProcessRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Process = gax::GaxPreconditions.CheckNotNull(process, nameof(process)),
            }, callSettings);

        /// <summary>
        /// Creates a new process.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and its location that should own the
        /// process.
        /// </param>
        /// <param name="process">
        /// Required. The process to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> CreateProcessAsync(string parent, Process process, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessAsync(new CreateProcessRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Process = gax::GaxPreconditions.CheckNotNull(process, nameof(process)),
            }, callSettings);

        /// <summary>
        /// Creates a new process.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and its location that should own the
        /// process.
        /// </param>
        /// <param name="process">
        /// Required. The process to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> CreateProcessAsync(string parent, Process process, st::CancellationToken cancellationToken) =>
            CreateProcessAsync(parent, process, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new process.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and its location that should own the
        /// process.
        /// </param>
        /// <param name="process">
        /// Required. The process to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Process CreateProcess(gagr::LocationName parent, Process process, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcess(new CreateProcessRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Process = gax::GaxPreconditions.CheckNotNull(process, nameof(process)),
            }, callSettings);

        /// <summary>
        /// Creates a new process.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and its location that should own the
        /// process.
        /// </param>
        /// <param name="process">
        /// Required. The process to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> CreateProcessAsync(gagr::LocationName parent, Process process, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessAsync(new CreateProcessRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Process = gax::GaxPreconditions.CheckNotNull(process, nameof(process)),
            }, callSettings);

        /// <summary>
        /// Creates a new process.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and its location that should own the
        /// process.
        /// </param>
        /// <param name="process">
        /// Required. The process to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> CreateProcessAsync(gagr::LocationName parent, Process process, st::CancellationToken cancellationToken) =>
            CreateProcessAsync(parent, process, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Process UpdateProcess(UpdateProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> UpdateProcessAsync(UpdateProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> UpdateProcessAsync(UpdateProcessRequest request, st::CancellationToken cancellationToken) =>
            UpdateProcessAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a process.
        /// </summary>
        /// <param name="process">
        /// Required. The lineage process to update.
        /// 
        /// The process's `name` field is used to identify the process to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. Currently not used. The whole message is
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Process UpdateProcess(Process process, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProcess(new UpdateProcessRequest
            {
                Process = gax::GaxPreconditions.CheckNotNull(process, nameof(process)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a process.
        /// </summary>
        /// <param name="process">
        /// Required. The lineage process to update.
        /// 
        /// The process's `name` field is used to identify the process to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. Currently not used. The whole message is
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> UpdateProcessAsync(Process process, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProcessAsync(new UpdateProcessRequest
            {
                Process = gax::GaxPreconditions.CheckNotNull(process, nameof(process)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a process.
        /// </summary>
        /// <param name="process">
        /// Required. The lineage process to update.
        /// 
        /// The process's `name` field is used to identify the process to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. Currently not used. The whole message is
        /// updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> UpdateProcessAsync(Process process, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProcessAsync(process, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of the specified process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Process GetProcess(GetProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of the specified process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> GetProcessAsync(GetProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of the specified process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> GetProcessAsync(GetProcessRequest request, st::CancellationToken cancellationToken) =>
            GetProcessAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of the specified process.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the process to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Process GetProcess(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcess(new GetProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of the specified process.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the process to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> GetProcessAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessAsync(new GetProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of the specified process.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the process to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> GetProcessAsync(string name, st::CancellationToken cancellationToken) =>
            GetProcessAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of the specified process.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the process to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Process GetProcess(ProcessName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcess(new GetProcessRequest
            {
                ProcessName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of the specified process.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the process to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> GetProcessAsync(ProcessName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessAsync(new GetProcessRequest
            {
                ProcessName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of the specified process.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the process to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> GetProcessAsync(ProcessName name, st::CancellationToken cancellationToken) =>
            GetProcessAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List processes in the given project and location. List order is descending
        /// by insertion time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Process"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessesResponse, Process> ListProcesses(ListProcessesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List processes in the given project and location. List order is descending
        /// by insertion time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Process"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessesResponse, Process> ListProcessesAsync(ListProcessesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List processes in the given project and location. List order is descending
        /// by insertion time.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and its location that owns this
        /// collection of processes.
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
        /// <returns>A pageable sequence of <see cref="Process"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessesResponse, Process> ListProcesses(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessesRequest request = new ListProcessesRequest
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
            return ListProcesses(request, callSettings);
        }

        /// <summary>
        /// List processes in the given project and location. List order is descending
        /// by insertion time.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and its location that owns this
        /// collection of processes.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Process"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessesResponse, Process> ListProcessesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessesRequest request = new ListProcessesRequest
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
            return ListProcessesAsync(request, callSettings);
        }

        /// <summary>
        /// List processes in the given project and location. List order is descending
        /// by insertion time.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and its location that owns this
        /// collection of processes.
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
        /// <returns>A pageable sequence of <see cref="Process"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessesResponse, Process> ListProcesses(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessesRequest request = new ListProcessesRequest
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
            return ListProcesses(request, callSettings);
        }

        /// <summary>
        /// List processes in the given project and location. List order is descending
        /// by insertion time.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and its location that owns this
        /// collection of processes.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Process"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessesResponse, Process> ListProcessesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessesRequest request = new ListProcessesRequest
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
            return ListProcessesAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the process with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteProcess(DeleteProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the process with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(DeleteProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the process with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(DeleteProcessRequest request, st::CancellationToken cancellationToken) =>
            DeleteProcessAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteProcess</c>.</summary>
        public virtual lro::OperationsClient DeleteProcessOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteProcess</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteProcess(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProcessOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteProcess</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteProcessAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProcessOperationsClient, callSettings);

        /// <summary>
        /// Deletes the process with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the process to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteProcess(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcess(new DeleteProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the process with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the process to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessAsync(new DeleteProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the process with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the process to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProcessAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the process with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the process to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteProcess(ProcessName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcess(new DeleteProcessRequest
            {
                ProcessName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the process with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the process to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(ProcessName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessAsync(new DeleteProcessRequest
            {
                ProcessName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the process with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the process to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(ProcessName name, st::CancellationToken cancellationToken) =>
            DeleteProcessAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Run CreateRun(CreateRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> CreateRunAsync(CreateRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> CreateRunAsync(CreateRunRequest request, st::CancellationToken cancellationToken) =>
            CreateRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new run.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the process that should own the run.
        /// </param>
        /// <param name="run">
        /// Required. The run to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Run CreateRun(string parent, Run run, gaxgrpc::CallSettings callSettings = null) =>
            CreateRun(new CreateRunRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Run = gax::GaxPreconditions.CheckNotNull(run, nameof(run)),
            }, callSettings);

        /// <summary>
        /// Creates a new run.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the process that should own the run.
        /// </param>
        /// <param name="run">
        /// Required. The run to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> CreateRunAsync(string parent, Run run, gaxgrpc::CallSettings callSettings = null) =>
            CreateRunAsync(new CreateRunRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Run = gax::GaxPreconditions.CheckNotNull(run, nameof(run)),
            }, callSettings);

        /// <summary>
        /// Creates a new run.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the process that should own the run.
        /// </param>
        /// <param name="run">
        /// Required. The run to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> CreateRunAsync(string parent, Run run, st::CancellationToken cancellationToken) =>
            CreateRunAsync(parent, run, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new run.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the process that should own the run.
        /// </param>
        /// <param name="run">
        /// Required. The run to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Run CreateRun(ProcessName parent, Run run, gaxgrpc::CallSettings callSettings = null) =>
            CreateRun(new CreateRunRequest
            {
                ParentAsProcessName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Run = gax::GaxPreconditions.CheckNotNull(run, nameof(run)),
            }, callSettings);

        /// <summary>
        /// Creates a new run.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the process that should own the run.
        /// </param>
        /// <param name="run">
        /// Required. The run to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> CreateRunAsync(ProcessName parent, Run run, gaxgrpc::CallSettings callSettings = null) =>
            CreateRunAsync(new CreateRunRequest
            {
                ParentAsProcessName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Run = gax::GaxPreconditions.CheckNotNull(run, nameof(run)),
            }, callSettings);

        /// <summary>
        /// Creates a new run.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the process that should own the run.
        /// </param>
        /// <param name="run">
        /// Required. The run to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> CreateRunAsync(ProcessName parent, Run run, st::CancellationToken cancellationToken) =>
            CreateRunAsync(parent, run, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Run UpdateRun(UpdateRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> UpdateRunAsync(UpdateRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> UpdateRunAsync(UpdateRunRequest request, st::CancellationToken cancellationToken) =>
            UpdateRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a run.
        /// </summary>
        /// <param name="run">
        /// Required. The lineage run to update.
        /// 
        /// The run's `name` field is used to identify the run to update.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/processes/{process}/runs/{run}`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. Currently not used. The whole message is
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Run UpdateRun(Run run, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRun(new UpdateRunRequest
            {
                Run = gax::GaxPreconditions.CheckNotNull(run, nameof(run)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a run.
        /// </summary>
        /// <param name="run">
        /// Required. The lineage run to update.
        /// 
        /// The run's `name` field is used to identify the run to update.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/processes/{process}/runs/{run}`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. Currently not used. The whole message is
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> UpdateRunAsync(Run run, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRunAsync(new UpdateRunRequest
            {
                Run = gax::GaxPreconditions.CheckNotNull(run, nameof(run)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a run.
        /// </summary>
        /// <param name="run">
        /// Required. The lineage run to update.
        /// 
        /// The run's `name` field is used to identify the run to update.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/processes/{process}/runs/{run}`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. Currently not used. The whole message is
        /// updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> UpdateRunAsync(Run run, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRunAsync(run, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of the specified run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Run GetRun(GetRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of the specified run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> GetRunAsync(GetRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of the specified run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> GetRunAsync(GetRunRequest request, st::CancellationToken cancellationToken) =>
            GetRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of the specified run.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the run to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Run GetRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRun(new GetRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of the specified run.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the run to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> GetRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRunAsync(new GetRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of the specified run.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the run to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> GetRunAsync(string name, st::CancellationToken cancellationToken) =>
            GetRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of the specified run.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the run to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Run GetRun(RunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRun(new GetRunRequest
            {
                RunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of the specified run.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the run to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> GetRunAsync(RunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRunAsync(new GetRunRequest
            {
                RunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of the specified run.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the run to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Run> GetRunAsync(RunName name, st::CancellationToken cancellationToken) =>
            GetRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists runs in the given project and location. List order is descending by
        /// `start_time`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Run"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRunsResponse, Run> ListRuns(ListRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists runs in the given project and location. List order is descending by
        /// `start_time`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Run"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRunsResponse, Run> ListRunsAsync(ListRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists runs in the given project and location. List order is descending by
        /// `start_time`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of process that owns this collection of runs.
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
        /// <returns>A pageable sequence of <see cref="Run"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRunsResponse, Run> ListRuns(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRunsRequest request = new ListRunsRequest
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
            return ListRuns(request, callSettings);
        }

        /// <summary>
        /// Lists runs in the given project and location. List order is descending by
        /// `start_time`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of process that owns this collection of runs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Run"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRunsResponse, Run> ListRunsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRunsRequest request = new ListRunsRequest
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
            return ListRunsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists runs in the given project and location. List order is descending by
        /// `start_time`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of process that owns this collection of runs.
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
        /// <returns>A pageable sequence of <see cref="Run"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRunsResponse, Run> ListRuns(ProcessName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRunsRequest request = new ListRunsRequest
            {
                ParentAsProcessName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuns(request, callSettings);
        }

        /// <summary>
        /// Lists runs in the given project and location. List order is descending by
        /// `start_time`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of process that owns this collection of runs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Run"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRunsResponse, Run> ListRunsAsync(ProcessName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRunsRequest request = new ListRunsRequest
            {
                ParentAsProcessName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRunsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the run with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRun(DeleteRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the run with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRunAsync(DeleteRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the run with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRunAsync(DeleteRunRequest request, st::CancellationToken cancellationToken) =>
            DeleteRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRun</c>.</summary>
        public virtual lro::OperationsClient DeleteRunOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRun</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteRun(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRunOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRun</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteRunAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRunOperationsClient, callSettings);

        /// <summary>
        /// Deletes the run with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the run to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRun(new DeleteRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the run with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the run to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRunAsync(new DeleteRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the run with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the run to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRunAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the run with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the run to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRun(RunName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRun(new DeleteRunRequest
            {
                RunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the run with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the run to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRunAsync(RunName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRunAsync(new DeleteRunRequest
            {
                RunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the run with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the run to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRunAsync(RunName name, st::CancellationToken cancellationToken) =>
            DeleteRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new lineage event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageEvent CreateLineageEvent(CreateLineageEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new lineage event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageEvent> CreateLineageEventAsync(CreateLineageEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new lineage event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageEvent> CreateLineageEventAsync(CreateLineageEventRequest request, st::CancellationToken cancellationToken) =>
            CreateLineageEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new lineage event.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the run that should own the lineage event.
        /// </param>
        /// <param name="lineageEvent">
        /// Required. The lineage event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageEvent CreateLineageEvent(string parent, LineageEvent lineageEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateLineageEvent(new CreateLineageEventRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LineageEvent = gax::GaxPreconditions.CheckNotNull(lineageEvent, nameof(lineageEvent)),
            }, callSettings);

        /// <summary>
        /// Creates a new lineage event.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the run that should own the lineage event.
        /// </param>
        /// <param name="lineageEvent">
        /// Required. The lineage event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageEvent> CreateLineageEventAsync(string parent, LineageEvent lineageEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateLineageEventAsync(new CreateLineageEventRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LineageEvent = gax::GaxPreconditions.CheckNotNull(lineageEvent, nameof(lineageEvent)),
            }, callSettings);

        /// <summary>
        /// Creates a new lineage event.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the run that should own the lineage event.
        /// </param>
        /// <param name="lineageEvent">
        /// Required. The lineage event to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageEvent> CreateLineageEventAsync(string parent, LineageEvent lineageEvent, st::CancellationToken cancellationToken) =>
            CreateLineageEventAsync(parent, lineageEvent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new lineage event.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the run that should own the lineage event.
        /// </param>
        /// <param name="lineageEvent">
        /// Required. The lineage event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageEvent CreateLineageEvent(RunName parent, LineageEvent lineageEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateLineageEvent(new CreateLineageEventRequest
            {
                ParentAsRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineageEvent = gax::GaxPreconditions.CheckNotNull(lineageEvent, nameof(lineageEvent)),
            }, callSettings);

        /// <summary>
        /// Creates a new lineage event.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the run that should own the lineage event.
        /// </param>
        /// <param name="lineageEvent">
        /// Required. The lineage event to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageEvent> CreateLineageEventAsync(RunName parent, LineageEvent lineageEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateLineageEventAsync(new CreateLineageEventRequest
            {
                ParentAsRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineageEvent = gax::GaxPreconditions.CheckNotNull(lineageEvent, nameof(lineageEvent)),
            }, callSettings);

        /// <summary>
        /// Creates a new lineage event.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the run that should own the lineage event.
        /// </param>
        /// <param name="lineageEvent">
        /// Required. The lineage event to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageEvent> CreateLineageEventAsync(RunName parent, LineageEvent lineageEvent, st::CancellationToken cancellationToken) =>
            CreateLineageEventAsync(parent, lineageEvent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a specified lineage event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageEvent GetLineageEvent(GetLineageEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a specified lineage event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageEvent> GetLineageEventAsync(GetLineageEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a specified lineage event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageEvent> GetLineageEventAsync(GetLineageEventRequest request, st::CancellationToken cancellationToken) =>
            GetLineageEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a specified lineage event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lineage event to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageEvent GetLineageEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineageEvent(new GetLineageEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a specified lineage event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lineage event to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageEvent> GetLineageEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineageEventAsync(new GetLineageEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a specified lineage event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lineage event to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageEvent> GetLineageEventAsync(string name, st::CancellationToken cancellationToken) =>
            GetLineageEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a specified lineage event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lineage event to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineageEvent GetLineageEvent(LineageEventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineageEvent(new GetLineageEventRequest
            {
                LineageEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a specified lineage event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lineage event to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageEvent> GetLineageEventAsync(LineageEventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineageEventAsync(new GetLineageEventRequest
            {
                LineageEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a specified lineage event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lineage event to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineageEvent> GetLineageEventAsync(LineageEventName name, st::CancellationToken cancellationToken) =>
            GetLineageEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists lineage events in the given project and location. The list order is
        /// not defined.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LineageEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLineageEventsResponse, LineageEvent> ListLineageEvents(ListLineageEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists lineage events in the given project and location. The list order is
        /// not defined.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LineageEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLineageEventsResponse, LineageEvent> ListLineageEventsAsync(ListLineageEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists lineage events in the given project and location. The list order is
        /// not defined.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the run that owns the collection of lineage events to
        /// get.
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
        /// <returns>A pageable sequence of <see cref="LineageEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLineageEventsResponse, LineageEvent> ListLineageEvents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineageEventsRequest request = new ListLineageEventsRequest
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
            return ListLineageEvents(request, callSettings);
        }

        /// <summary>
        /// Lists lineage events in the given project and location. The list order is
        /// not defined.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the run that owns the collection of lineage events to
        /// get.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LineageEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLineageEventsResponse, LineageEvent> ListLineageEventsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineageEventsRequest request = new ListLineageEventsRequest
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
            return ListLineageEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists lineage events in the given project and location. The list order is
        /// not defined.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the run that owns the collection of lineage events to
        /// get.
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
        /// <returns>A pageable sequence of <see cref="LineageEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLineageEventsResponse, LineageEvent> ListLineageEvents(RunName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineageEventsRequest request = new ListLineageEventsRequest
            {
                ParentAsRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLineageEvents(request, callSettings);
        }

        /// <summary>
        /// Lists lineage events in the given project and location. The list order is
        /// not defined.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the run that owns the collection of lineage events to
        /// get.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LineageEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLineageEventsResponse, LineageEvent> ListLineageEventsAsync(RunName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineageEventsRequest request = new ListLineageEventsRequest
            {
                ParentAsRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLineageEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the lineage event with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLineageEvent(DeleteLineageEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the lineage event with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLineageEventAsync(DeleteLineageEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the lineage event with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLineageEventAsync(DeleteLineageEventRequest request, st::CancellationToken cancellationToken) =>
            DeleteLineageEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the lineage event with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lineage event to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLineageEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLineageEvent(new DeleteLineageEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the lineage event with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lineage event to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLineageEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLineageEventAsync(new DeleteLineageEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the lineage event with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lineage event to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLineageEventAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteLineageEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the lineage event with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lineage event to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLineageEvent(LineageEventName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLineageEvent(new DeleteLineageEventRequest
            {
                LineageEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the lineage event with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lineage event to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLineageEventAsync(LineageEventName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLineageEventAsync(new DeleteLineageEventRequest
            {
                LineageEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the lineage event with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the lineage event to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLineageEventAsync(LineageEventName name, st::CancellationToken cancellationToken) =>
            DeleteLineageEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a list of links connected to a specific asset.
        /// Links represent the data flow between **source** (upstream)
        /// and **target** (downstream) assets in transformation pipelines.
        /// Links are stored in the same project as the Lineage Events that create
        /// them.
        /// 
        /// You can retrieve links in every project where you have the
        /// `datalineage.events.get` permission. The project provided in the URL
        /// is used for Billing and Quota.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchLinksResponse, Link> SearchLinks(SearchLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a list of links connected to a specific asset.
        /// Links represent the data flow between **source** (upstream)
        /// and **target** (downstream) assets in transformation pipelines.
        /// Links are stored in the same project as the Lineage Events that create
        /// them.
        /// 
        /// You can retrieve links in every project where you have the
        /// `datalineage.events.get` permission. The project provided in the URL
        /// is used for Billing and Quota.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchLinksResponse, Link> SearchLinksAsync(SearchLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve information about LineageProcesses associated with specific
        /// links. LineageProcesses are transformation pipelines that result in data
        /// flowing from **source** to **target** assets. Links between assets
        /// represent this operation.
        /// 
        /// If you have specific link names, you can use this method to
        /// verify which LineageProcesses contribute to creating those links.
        /// See the
        /// [SearchLinks][google.cloud.datacatalog.lineage.v1.Lineage.SearchLinks]
        /// method for more information on how to retrieve link name.
        /// 
        /// You can retrieve the LineageProcess information in every project where you
        /// have the `datalineage.events.get` permission. The project provided in the
        /// URL is used for Billing and Quota.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProcessLinks"/> resources.</returns>
        public virtual gax::PagedEnumerable<BatchSearchLinkProcessesResponse, ProcessLinks> BatchSearchLinkProcesses(BatchSearchLinkProcessesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve information about LineageProcesses associated with specific
        /// links. LineageProcesses are transformation pipelines that result in data
        /// flowing from **source** to **target** assets. Links between assets
        /// represent this operation.
        /// 
        /// If you have specific link names, you can use this method to
        /// verify which LineageProcesses contribute to creating those links.
        /// See the
        /// [SearchLinks][google.cloud.datacatalog.lineage.v1.Lineage.SearchLinks]
        /// method for more information on how to retrieve link name.
        /// 
        /// You can retrieve the LineageProcess information in every project where you
        /// have the `datalineage.events.get` permission. The project provided in the
        /// URL is used for Billing and Quota.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProcessLinks"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<BatchSearchLinkProcessesResponse, ProcessLinks> BatchSearchLinkProcessesAsync(BatchSearchLinkProcessesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>Lineage client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Lineage is used to track data flows between assets over time. You can
    /// create [LineageEvents][google.cloud.datacatalog.lineage.v1.LineageEvent]
    /// to record lineage between multiple sources and a single target, for
    /// example, when table data is based on data from multiple tables.
    /// </remarks>
    public sealed partial class LineageClientImpl : LineageClient
    {
        private readonly gaxgrpc::ApiCall<ProcessOpenLineageRunEventRequest, ProcessOpenLineageRunEventResponse> _callProcessOpenLineageRunEvent;

        private readonly gaxgrpc::ApiCall<CreateProcessRequest, Process> _callCreateProcess;

        private readonly gaxgrpc::ApiCall<UpdateProcessRequest, Process> _callUpdateProcess;

        private readonly gaxgrpc::ApiCall<GetProcessRequest, Process> _callGetProcess;

        private readonly gaxgrpc::ApiCall<ListProcessesRequest, ListProcessesResponse> _callListProcesses;

        private readonly gaxgrpc::ApiCall<DeleteProcessRequest, lro::Operation> _callDeleteProcess;

        private readonly gaxgrpc::ApiCall<CreateRunRequest, Run> _callCreateRun;

        private readonly gaxgrpc::ApiCall<UpdateRunRequest, Run> _callUpdateRun;

        private readonly gaxgrpc::ApiCall<GetRunRequest, Run> _callGetRun;

        private readonly gaxgrpc::ApiCall<ListRunsRequest, ListRunsResponse> _callListRuns;

        private readonly gaxgrpc::ApiCall<DeleteRunRequest, lro::Operation> _callDeleteRun;

        private readonly gaxgrpc::ApiCall<CreateLineageEventRequest, LineageEvent> _callCreateLineageEvent;

        private readonly gaxgrpc::ApiCall<GetLineageEventRequest, LineageEvent> _callGetLineageEvent;

        private readonly gaxgrpc::ApiCall<ListLineageEventsRequest, ListLineageEventsResponse> _callListLineageEvents;

        private readonly gaxgrpc::ApiCall<DeleteLineageEventRequest, wkt::Empty> _callDeleteLineageEvent;

        private readonly gaxgrpc::ApiCall<SearchLinksRequest, SearchLinksResponse> _callSearchLinks;

        private readonly gaxgrpc::ApiCall<BatchSearchLinkProcessesRequest, BatchSearchLinkProcessesResponse> _callBatchSearchLinkProcesses;

        /// <summary>
        /// Constructs a client wrapper for the Lineage service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LineageSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LineageClientImpl(Lineage.LineageClient grpcClient, LineageSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LineageSettings effectiveSettings = settings ?? LineageSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteProcessOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteProcessOperationsSettings, logger);
            DeleteRunOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRunOperationsSettings, logger);
            _callProcessOpenLineageRunEvent = clientHelper.BuildApiCall<ProcessOpenLineageRunEventRequest, ProcessOpenLineageRunEventResponse>("ProcessOpenLineageRunEvent", grpcClient.ProcessOpenLineageRunEventAsync, grpcClient.ProcessOpenLineageRunEvent, effectiveSettings.ProcessOpenLineageRunEventSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callProcessOpenLineageRunEvent);
            Modify_ProcessOpenLineageRunEventApiCall(ref _callProcessOpenLineageRunEvent);
            _callCreateProcess = clientHelper.BuildApiCall<CreateProcessRequest, Process>("CreateProcess", grpcClient.CreateProcessAsync, grpcClient.CreateProcess, effectiveSettings.CreateProcessSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProcess);
            Modify_CreateProcessApiCall(ref _callCreateProcess);
            _callUpdateProcess = clientHelper.BuildApiCall<UpdateProcessRequest, Process>("UpdateProcess", grpcClient.UpdateProcessAsync, grpcClient.UpdateProcess, effectiveSettings.UpdateProcessSettings).WithGoogleRequestParam("process.name", request => request.Process?.Name);
            Modify_ApiCall(ref _callUpdateProcess);
            Modify_UpdateProcessApiCall(ref _callUpdateProcess);
            _callGetProcess = clientHelper.BuildApiCall<GetProcessRequest, Process>("GetProcess", grpcClient.GetProcessAsync, grpcClient.GetProcess, effectiveSettings.GetProcessSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProcess);
            Modify_GetProcessApiCall(ref _callGetProcess);
            _callListProcesses = clientHelper.BuildApiCall<ListProcessesRequest, ListProcessesResponse>("ListProcesses", grpcClient.ListProcessesAsync, grpcClient.ListProcesses, effectiveSettings.ListProcessesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProcesses);
            Modify_ListProcessesApiCall(ref _callListProcesses);
            _callDeleteProcess = clientHelper.BuildApiCall<DeleteProcessRequest, lro::Operation>("DeleteProcess", grpcClient.DeleteProcessAsync, grpcClient.DeleteProcess, effectiveSettings.DeleteProcessSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProcess);
            Modify_DeleteProcessApiCall(ref _callDeleteProcess);
            _callCreateRun = clientHelper.BuildApiCall<CreateRunRequest, Run>("CreateRun", grpcClient.CreateRunAsync, grpcClient.CreateRun, effectiveSettings.CreateRunSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRun);
            Modify_CreateRunApiCall(ref _callCreateRun);
            _callUpdateRun = clientHelper.BuildApiCall<UpdateRunRequest, Run>("UpdateRun", grpcClient.UpdateRunAsync, grpcClient.UpdateRun, effectiveSettings.UpdateRunSettings).WithGoogleRequestParam("run.name", request => request.Run?.Name);
            Modify_ApiCall(ref _callUpdateRun);
            Modify_UpdateRunApiCall(ref _callUpdateRun);
            _callGetRun = clientHelper.BuildApiCall<GetRunRequest, Run>("GetRun", grpcClient.GetRunAsync, grpcClient.GetRun, effectiveSettings.GetRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRun);
            Modify_GetRunApiCall(ref _callGetRun);
            _callListRuns = clientHelper.BuildApiCall<ListRunsRequest, ListRunsResponse>("ListRuns", grpcClient.ListRunsAsync, grpcClient.ListRuns, effectiveSettings.ListRunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRuns);
            Modify_ListRunsApiCall(ref _callListRuns);
            _callDeleteRun = clientHelper.BuildApiCall<DeleteRunRequest, lro::Operation>("DeleteRun", grpcClient.DeleteRunAsync, grpcClient.DeleteRun, effectiveSettings.DeleteRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRun);
            Modify_DeleteRunApiCall(ref _callDeleteRun);
            _callCreateLineageEvent = clientHelper.BuildApiCall<CreateLineageEventRequest, LineageEvent>("CreateLineageEvent", grpcClient.CreateLineageEventAsync, grpcClient.CreateLineageEvent, effectiveSettings.CreateLineageEventSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateLineageEvent);
            Modify_CreateLineageEventApiCall(ref _callCreateLineageEvent);
            _callGetLineageEvent = clientHelper.BuildApiCall<GetLineageEventRequest, LineageEvent>("GetLineageEvent", grpcClient.GetLineageEventAsync, grpcClient.GetLineageEvent, effectiveSettings.GetLineageEventSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLineageEvent);
            Modify_GetLineageEventApiCall(ref _callGetLineageEvent);
            _callListLineageEvents = clientHelper.BuildApiCall<ListLineageEventsRequest, ListLineageEventsResponse>("ListLineageEvents", grpcClient.ListLineageEventsAsync, grpcClient.ListLineageEvents, effectiveSettings.ListLineageEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLineageEvents);
            Modify_ListLineageEventsApiCall(ref _callListLineageEvents);
            _callDeleteLineageEvent = clientHelper.BuildApiCall<DeleteLineageEventRequest, wkt::Empty>("DeleteLineageEvent", grpcClient.DeleteLineageEventAsync, grpcClient.DeleteLineageEvent, effectiveSettings.DeleteLineageEventSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteLineageEvent);
            Modify_DeleteLineageEventApiCall(ref _callDeleteLineageEvent);
            _callSearchLinks = clientHelper.BuildApiCall<SearchLinksRequest, SearchLinksResponse>("SearchLinks", grpcClient.SearchLinksAsync, grpcClient.SearchLinks, effectiveSettings.SearchLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchLinks);
            Modify_SearchLinksApiCall(ref _callSearchLinks);
            _callBatchSearchLinkProcesses = clientHelper.BuildApiCall<BatchSearchLinkProcessesRequest, BatchSearchLinkProcessesResponse>("BatchSearchLinkProcesses", grpcClient.BatchSearchLinkProcessesAsync, grpcClient.BatchSearchLinkProcesses, effectiveSettings.BatchSearchLinkProcessesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchSearchLinkProcesses);
            Modify_BatchSearchLinkProcessesApiCall(ref _callBatchSearchLinkProcesses);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ProcessOpenLineageRunEventApiCall(ref gaxgrpc::ApiCall<ProcessOpenLineageRunEventRequest, ProcessOpenLineageRunEventResponse> call);

        partial void Modify_CreateProcessApiCall(ref gaxgrpc::ApiCall<CreateProcessRequest, Process> call);

        partial void Modify_UpdateProcessApiCall(ref gaxgrpc::ApiCall<UpdateProcessRequest, Process> call);

        partial void Modify_GetProcessApiCall(ref gaxgrpc::ApiCall<GetProcessRequest, Process> call);

        partial void Modify_ListProcessesApiCall(ref gaxgrpc::ApiCall<ListProcessesRequest, ListProcessesResponse> call);

        partial void Modify_DeleteProcessApiCall(ref gaxgrpc::ApiCall<DeleteProcessRequest, lro::Operation> call);

        partial void Modify_CreateRunApiCall(ref gaxgrpc::ApiCall<CreateRunRequest, Run> call);

        partial void Modify_UpdateRunApiCall(ref gaxgrpc::ApiCall<UpdateRunRequest, Run> call);

        partial void Modify_GetRunApiCall(ref gaxgrpc::ApiCall<GetRunRequest, Run> call);

        partial void Modify_ListRunsApiCall(ref gaxgrpc::ApiCall<ListRunsRequest, ListRunsResponse> call);

        partial void Modify_DeleteRunApiCall(ref gaxgrpc::ApiCall<DeleteRunRequest, lro::Operation> call);

        partial void Modify_CreateLineageEventApiCall(ref gaxgrpc::ApiCall<CreateLineageEventRequest, LineageEvent> call);

        partial void Modify_GetLineageEventApiCall(ref gaxgrpc::ApiCall<GetLineageEventRequest, LineageEvent> call);

        partial void Modify_ListLineageEventsApiCall(ref gaxgrpc::ApiCall<ListLineageEventsRequest, ListLineageEventsResponse> call);

        partial void Modify_DeleteLineageEventApiCall(ref gaxgrpc::ApiCall<DeleteLineageEventRequest, wkt::Empty> call);

        partial void Modify_SearchLinksApiCall(ref gaxgrpc::ApiCall<SearchLinksRequest, SearchLinksResponse> call);

        partial void Modify_BatchSearchLinkProcessesApiCall(ref gaxgrpc::ApiCall<BatchSearchLinkProcessesRequest, BatchSearchLinkProcessesResponse> call);

        partial void OnConstruction(Lineage.LineageClient grpcClient, LineageSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Lineage client</summary>
        public override Lineage.LineageClient GrpcClient { get; }

        partial void Modify_ProcessOpenLineageRunEventRequest(ref ProcessOpenLineageRunEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateProcessRequest(ref CreateProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProcessRequest(ref UpdateProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProcessRequest(ref GetProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProcessesRequest(ref ListProcessesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProcessRequest(ref DeleteProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRunRequest(ref CreateRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRunRequest(ref UpdateRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRunRequest(ref GetRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRunsRequest(ref ListRunsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRunRequest(ref DeleteRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateLineageEventRequest(ref CreateLineageEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLineageEventRequest(ref GetLineageEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLineageEventsRequest(ref ListLineageEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteLineageEventRequest(ref DeleteLineageEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchLinksRequest(ref SearchLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchSearchLinkProcessesRequest(ref BatchSearchLinkProcessesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates new lineage events together with their parents: process and run.
        /// Updates the process and run if they already exist.
        /// Mapped from Open Lineage specification:
        /// https://github.com/OpenLineage/OpenLineage/blob/main/spec/OpenLineage.json.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProcessOpenLineageRunEventResponse ProcessOpenLineageRunEvent(ProcessOpenLineageRunEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProcessOpenLineageRunEventRequest(ref request, ref callSettings);
            return _callProcessOpenLineageRunEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates new lineage events together with their parents: process and run.
        /// Updates the process and run if they already exist.
        /// Mapped from Open Lineage specification:
        /// https://github.com/OpenLineage/OpenLineage/blob/main/spec/OpenLineage.json.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProcessOpenLineageRunEventResponse> ProcessOpenLineageRunEventAsync(ProcessOpenLineageRunEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProcessOpenLineageRunEventRequest(ref request, ref callSettings);
            return _callProcessOpenLineageRunEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Process CreateProcess(CreateProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProcessRequest(ref request, ref callSettings);
            return _callCreateProcess.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Process> CreateProcessAsync(CreateProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProcessRequest(ref request, ref callSettings);
            return _callCreateProcess.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Process UpdateProcess(UpdateProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProcessRequest(ref request, ref callSettings);
            return _callUpdateProcess.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Process> UpdateProcessAsync(UpdateProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProcessRequest(ref request, ref callSettings);
            return _callUpdateProcess.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the details of the specified process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Process GetProcess(GetProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProcessRequest(ref request, ref callSettings);
            return _callGetProcess.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of the specified process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Process> GetProcessAsync(GetProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProcessRequest(ref request, ref callSettings);
            return _callGetProcess.Async(request, callSettings);
        }

        /// <summary>
        /// List processes in the given project and location. List order is descending
        /// by insertion time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Process"/> resources.</returns>
        public override gax::PagedEnumerable<ListProcessesResponse, Process> ListProcesses(ListProcessesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProcessesRequest, ListProcessesResponse, Process>(_callListProcesses, request, callSettings);
        }

        /// <summary>
        /// List processes in the given project and location. List order is descending
        /// by insertion time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Process"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProcessesResponse, Process> ListProcessesAsync(ListProcessesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProcessesRequest, ListProcessesResponse, Process>(_callListProcesses, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteProcess</c>.</summary>
        public override lro::OperationsClient DeleteProcessOperationsClient { get; }

        /// <summary>
        /// Deletes the process with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteProcess(DeleteProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProcessRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteProcess.Sync(request, callSettings), DeleteProcessOperationsClient);
        }

        /// <summary>
        /// Deletes the process with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(DeleteProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProcessRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteProcess.Async(request, callSettings).ConfigureAwait(false), DeleteProcessOperationsClient);
        }

        /// <summary>
        /// Creates a new run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Run CreateRun(CreateRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRunRequest(ref request, ref callSettings);
            return _callCreateRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Run> CreateRunAsync(CreateRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRunRequest(ref request, ref callSettings);
            return _callCreateRun.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Run UpdateRun(UpdateRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRunRequest(ref request, ref callSettings);
            return _callUpdateRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Run> UpdateRunAsync(UpdateRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRunRequest(ref request, ref callSettings);
            return _callUpdateRun.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the details of the specified run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Run GetRun(GetRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRunRequest(ref request, ref callSettings);
            return _callGetRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of the specified run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Run> GetRunAsync(GetRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRunRequest(ref request, ref callSettings);
            return _callGetRun.Async(request, callSettings);
        }

        /// <summary>
        /// Lists runs in the given project and location. List order is descending by
        /// `start_time`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Run"/> resources.</returns>
        public override gax::PagedEnumerable<ListRunsResponse, Run> ListRuns(ListRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRunsRequest, ListRunsResponse, Run>(_callListRuns, request, callSettings);
        }

        /// <summary>
        /// Lists runs in the given project and location. List order is descending by
        /// `start_time`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Run"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRunsResponse, Run> ListRunsAsync(ListRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRunsRequest, ListRunsResponse, Run>(_callListRuns, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteRun</c>.</summary>
        public override lro::OperationsClient DeleteRunOperationsClient { get; }

        /// <summary>
        /// Deletes the run with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteRun(DeleteRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRunRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteRun.Sync(request, callSettings), DeleteRunOperationsClient);
        }

        /// <summary>
        /// Deletes the run with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRunAsync(DeleteRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRunRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteRun.Async(request, callSettings).ConfigureAwait(false), DeleteRunOperationsClient);
        }

        /// <summary>
        /// Creates a new lineage event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LineageEvent CreateLineageEvent(CreateLineageEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLineageEventRequest(ref request, ref callSettings);
            return _callCreateLineageEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new lineage event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LineageEvent> CreateLineageEventAsync(CreateLineageEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLineageEventRequest(ref request, ref callSettings);
            return _callCreateLineageEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of a specified lineage event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LineageEvent GetLineageEvent(GetLineageEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLineageEventRequest(ref request, ref callSettings);
            return _callGetLineageEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a specified lineage event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LineageEvent> GetLineageEventAsync(GetLineageEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLineageEventRequest(ref request, ref callSettings);
            return _callGetLineageEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Lists lineage events in the given project and location. The list order is
        /// not defined.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LineageEvent"/> resources.</returns>
        public override gax::PagedEnumerable<ListLineageEventsResponse, LineageEvent> ListLineageEvents(ListLineageEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLineageEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLineageEventsRequest, ListLineageEventsResponse, LineageEvent>(_callListLineageEvents, request, callSettings);
        }

        /// <summary>
        /// Lists lineage events in the given project and location. The list order is
        /// not defined.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LineageEvent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLineageEventsResponse, LineageEvent> ListLineageEventsAsync(ListLineageEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLineageEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLineageEventsRequest, ListLineageEventsResponse, LineageEvent>(_callListLineageEvents, request, callSettings);
        }

        /// <summary>
        /// Deletes the lineage event with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteLineageEvent(DeleteLineageEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLineageEventRequest(ref request, ref callSettings);
            _callDeleteLineageEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the lineage event with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteLineageEventAsync(DeleteLineageEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLineageEventRequest(ref request, ref callSettings);
            return _callDeleteLineageEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve a list of links connected to a specific asset.
        /// Links represent the data flow between **source** (upstream)
        /// and **target** (downstream) assets in transformation pipelines.
        /// Links are stored in the same project as the Lineage Events that create
        /// them.
        /// 
        /// You can retrieve links in every project where you have the
        /// `datalineage.events.get` permission. The project provided in the URL
        /// is used for Billing and Quota.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Link"/> resources.</returns>
        public override gax::PagedEnumerable<SearchLinksResponse, Link> SearchLinks(SearchLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchLinksRequest, SearchLinksResponse, Link>(_callSearchLinks, request, callSettings);
        }

        /// <summary>
        /// Retrieve a list of links connected to a specific asset.
        /// Links represent the data flow between **source** (upstream)
        /// and **target** (downstream) assets in transformation pipelines.
        /// Links are stored in the same project as the Lineage Events that create
        /// them.
        /// 
        /// You can retrieve links in every project where you have the
        /// `datalineage.events.get` permission. The project provided in the URL
        /// is used for Billing and Quota.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Link"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchLinksResponse, Link> SearchLinksAsync(SearchLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchLinksRequest, SearchLinksResponse, Link>(_callSearchLinks, request, callSettings);
        }

        /// <summary>
        /// Retrieve information about LineageProcesses associated with specific
        /// links. LineageProcesses are transformation pipelines that result in data
        /// flowing from **source** to **target** assets. Links between assets
        /// represent this operation.
        /// 
        /// If you have specific link names, you can use this method to
        /// verify which LineageProcesses contribute to creating those links.
        /// See the
        /// [SearchLinks][google.cloud.datacatalog.lineage.v1.Lineage.SearchLinks]
        /// method for more information on how to retrieve link name.
        /// 
        /// You can retrieve the LineageProcess information in every project where you
        /// have the `datalineage.events.get` permission. The project provided in the
        /// URL is used for Billing and Quota.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProcessLinks"/> resources.</returns>
        public override gax::PagedEnumerable<BatchSearchLinkProcessesResponse, ProcessLinks> BatchSearchLinkProcesses(BatchSearchLinkProcessesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchSearchLinkProcessesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<BatchSearchLinkProcessesRequest, BatchSearchLinkProcessesResponse, ProcessLinks>(_callBatchSearchLinkProcesses, request, callSettings);
        }

        /// <summary>
        /// Retrieve information about LineageProcesses associated with specific
        /// links. LineageProcesses are transformation pipelines that result in data
        /// flowing from **source** to **target** assets. Links between assets
        /// represent this operation.
        /// 
        /// If you have specific link names, you can use this method to
        /// verify which LineageProcesses contribute to creating those links.
        /// See the
        /// [SearchLinks][google.cloud.datacatalog.lineage.v1.Lineage.SearchLinks]
        /// method for more information on how to retrieve link name.
        /// 
        /// You can retrieve the LineageProcess information in every project where you
        /// have the `datalineage.events.get` permission. The project provided in the
        /// URL is used for Billing and Quota.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProcessLinks"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<BatchSearchLinkProcessesResponse, ProcessLinks> BatchSearchLinkProcessesAsync(BatchSearchLinkProcessesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchSearchLinkProcessesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<BatchSearchLinkProcessesRequest, BatchSearchLinkProcessesResponse, ProcessLinks>(_callBatchSearchLinkProcesses, request, callSettings);
        }
    }

    public partial class ListProcessesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRunsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLineageEventsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchLinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class BatchSearchLinkProcessesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProcessesResponse : gaxgrpc::IPageResponse<Process>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Process> GetEnumerator() => Processes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRunsResponse : gaxgrpc::IPageResponse<Run>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Run> GetEnumerator() => Runs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListLineageEventsResponse : gaxgrpc::IPageResponse<LineageEvent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LineageEvent> GetEnumerator() => LineageEvents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchLinksResponse : gaxgrpc::IPageResponse<Link>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Link> GetEnumerator() => Links.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class BatchSearchLinkProcessesResponse : gaxgrpc::IPageResponse<ProcessLinks>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ProcessLinks> GetEnumerator() => ProcessLinks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Lineage
    {
        public partial class LineageClient
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
