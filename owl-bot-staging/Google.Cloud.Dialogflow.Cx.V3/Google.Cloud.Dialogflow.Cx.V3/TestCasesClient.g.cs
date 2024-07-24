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

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Settings for <see cref="TestCasesClient"/> instances.</summary>
    public sealed partial class TestCasesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TestCasesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TestCasesSettings"/>.</returns>
        public static TestCasesSettings GetDefault() => new TestCasesSettings();

        /// <summary>Constructs a new <see cref="TestCasesSettings"/> object with default settings.</summary>
        public TestCasesSettings()
        {
        }

        private TestCasesSettings(TestCasesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListTestCasesSettings = existing.ListTestCasesSettings;
            BatchDeleteTestCasesSettings = existing.BatchDeleteTestCasesSettings;
            GetTestCaseSettings = existing.GetTestCaseSettings;
            CreateTestCaseSettings = existing.CreateTestCaseSettings;
            UpdateTestCaseSettings = existing.UpdateTestCaseSettings;
            RunTestCaseSettings = existing.RunTestCaseSettings;
            RunTestCaseOperationsSettings = existing.RunTestCaseOperationsSettings.Clone();
            BatchRunTestCasesSettings = existing.BatchRunTestCasesSettings;
            BatchRunTestCasesOperationsSettings = existing.BatchRunTestCasesOperationsSettings.Clone();
            CalculateCoverageSettings = existing.CalculateCoverageSettings;
            ImportTestCasesSettings = existing.ImportTestCasesSettings;
            ImportTestCasesOperationsSettings = existing.ImportTestCasesOperationsSettings.Clone();
            ExportTestCasesSettings = existing.ExportTestCasesSettings;
            ExportTestCasesOperationsSettings = existing.ExportTestCasesOperationsSettings.Clone();
            ListTestCaseResultsSettings = existing.ListTestCaseResultsSettings;
            GetTestCaseResultSettings = existing.GetTestCaseResultSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TestCasesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TestCasesClient.ListTestCases</c> and <c>TestCasesClient.ListTestCasesAsync</c>.
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
        public gaxgrpc::CallSettings ListTestCasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TestCasesClient.BatchDeleteTestCases</c> and <c>TestCasesClient.BatchDeleteTestCasesAsync</c>.
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
        public gaxgrpc::CallSettings BatchDeleteTestCasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TestCasesClient.GetTestCase</c>
        ///  and <c>TestCasesClient.GetTestCaseAsync</c>.
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
        public gaxgrpc::CallSettings GetTestCaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TestCasesClient.CreateTestCase</c> and <c>TestCasesClient.CreateTestCaseAsync</c>.
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
        public gaxgrpc::CallSettings CreateTestCaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TestCasesClient.UpdateTestCase</c> and <c>TestCasesClient.UpdateTestCaseAsync</c>.
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
        public gaxgrpc::CallSettings UpdateTestCaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TestCasesClient.RunTestCase</c>
        ///  and <c>TestCasesClient.RunTestCaseAsync</c>.
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
        public gaxgrpc::CallSettings RunTestCaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TestCasesClient.RunTestCase</c> and
        /// <c>TestCasesClient.RunTestCaseAsync</c>.
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
        public lro::OperationsSettings RunTestCaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TestCasesClient.BatchRunTestCases</c> and <c>TestCasesClient.BatchRunTestCasesAsync</c>.
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
        public gaxgrpc::CallSettings BatchRunTestCasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TestCasesClient.BatchRunTestCases</c> and
        /// <c>TestCasesClient.BatchRunTestCasesAsync</c>.
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
        public lro::OperationsSettings BatchRunTestCasesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TestCasesClient.CalculateCoverage</c> and <c>TestCasesClient.CalculateCoverageAsync</c>.
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
        public gaxgrpc::CallSettings CalculateCoverageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TestCasesClient.ImportTestCases</c> and <c>TestCasesClient.ImportTestCasesAsync</c>.
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
        public gaxgrpc::CallSettings ImportTestCasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TestCasesClient.ImportTestCases</c> and
        /// <c>TestCasesClient.ImportTestCasesAsync</c>.
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
        public lro::OperationsSettings ImportTestCasesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TestCasesClient.ExportTestCases</c> and <c>TestCasesClient.ExportTestCasesAsync</c>.
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
        public gaxgrpc::CallSettings ExportTestCasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TestCasesClient.ExportTestCases</c> and
        /// <c>TestCasesClient.ExportTestCasesAsync</c>.
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
        public lro::OperationsSettings ExportTestCasesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TestCasesClient.ListTestCaseResults</c> and <c>TestCasesClient.ListTestCaseResultsAsync</c>.
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
        public gaxgrpc::CallSettings ListTestCaseResultsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TestCasesClient.GetTestCaseResult</c> and <c>TestCasesClient.GetTestCaseResultAsync</c>.
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
        public gaxgrpc::CallSettings GetTestCaseResultSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TestCasesSettings"/> object.</returns>
        public TestCasesSettings Clone() => new TestCasesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TestCasesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TestCasesClientBuilder : gaxgrpc::ClientBuilderBase<TestCasesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TestCasesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TestCasesClientBuilder() : base(TestCasesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TestCasesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TestCasesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TestCasesClient Build()
        {
            TestCasesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TestCasesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TestCasesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TestCasesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TestCasesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TestCasesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TestCasesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TestCasesClient.ChannelPool;
    }

    /// <summary>TestCases client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Test Cases][google.cloud.dialogflow.cx.v3.TestCase] and
    /// [Test Case Results][google.cloud.dialogflow.cx.v3.TestCaseResult].
    /// </remarks>
    public abstract partial class TestCasesClient
    {
        /// <summary>
        /// The default endpoint for the TestCases service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default TestCases scopes.</summary>
        /// <remarks>
        /// The default TestCases scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TestCases.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TestCasesClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="TestCasesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TestCasesClient"/>.</returns>
        public static stt::Task<TestCasesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TestCasesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TestCasesClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="TestCasesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TestCasesClient"/>.</returns>
        public static TestCasesClient Create() => new TestCasesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TestCasesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TestCasesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TestCasesClient"/>.</returns>
        internal static TestCasesClient Create(grpccore::CallInvoker callInvoker, TestCasesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TestCases.TestCasesClient grpcClient = new TestCases.TestCasesClient(callInvoker);
            return new TestCasesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TestCases client</summary>
        public virtual TestCases.TestCasesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a list of test cases for a given agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TestCase"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTestCasesResponse, TestCase> ListTestCases(ListTestCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a list of test cases for a given agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TestCase"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTestCasesResponse, TestCase> ListTestCasesAsync(ListTestCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a list of test cases for a given agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all pages for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TestCase"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTestCasesResponse, TestCase> ListTestCases(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTestCasesRequest request = new ListTestCasesRequest
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
            return ListTestCases(request, callSettings);
        }

        /// <summary>
        /// Fetches a list of test cases for a given agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all pages for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TestCase"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTestCasesResponse, TestCase> ListTestCasesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTestCasesRequest request = new ListTestCasesRequest
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
            return ListTestCasesAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches a list of test cases for a given agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all pages for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TestCase"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTestCasesResponse, TestCase> ListTestCases(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTestCasesRequest request = new ListTestCasesRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTestCases(request, callSettings);
        }

        /// <summary>
        /// Fetches a list of test cases for a given agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all pages for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TestCase"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTestCasesResponse, TestCase> ListTestCasesAsync(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTestCasesRequest request = new ListTestCasesRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTestCasesAsync(request, callSettings);
        }

        /// <summary>
        /// Batch deletes test cases.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteTestCases(BatchDeleteTestCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch deletes test cases.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteTestCasesAsync(BatchDeleteTestCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch deletes test cases.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteTestCasesAsync(BatchDeleteTestCasesRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteTestCasesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch deletes test cases.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to delete test cases from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteTestCases(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteTestCases(new BatchDeleteTestCasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Batch deletes test cases.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to delete test cases from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteTestCasesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteTestCasesAsync(new BatchDeleteTestCasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Batch deletes test cases.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to delete test cases from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteTestCasesAsync(string parent, st::CancellationToken cancellationToken) =>
            BatchDeleteTestCasesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch deletes test cases.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to delete test cases from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteTestCases(AgentName parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteTestCases(new BatchDeleteTestCasesRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Batch deletes test cases.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to delete test cases from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteTestCasesAsync(AgentName parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteTestCasesAsync(new BatchDeleteTestCasesRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Batch deletes test cases.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to delete test cases from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteTestCasesAsync(AgentName parent, st::CancellationToken cancellationToken) =>
            BatchDeleteTestCasesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestCase GetTestCase(GetTestCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> GetTestCaseAsync(GetTestCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> GetTestCaseAsync(GetTestCaseRequest request, st::CancellationToken cancellationToken) =>
            GetTestCaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a test case.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the testcase.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/testCases/&lt;TestCase ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestCase GetTestCase(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTestCase(new GetTestCaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a test case.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the testcase.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/testCases/&lt;TestCase ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> GetTestCaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTestCaseAsync(new GetTestCaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a test case.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the testcase.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/testCases/&lt;TestCase ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> GetTestCaseAsync(string name, st::CancellationToken cancellationToken) =>
            GetTestCaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a test case.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the testcase.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/testCases/&lt;TestCase ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestCase GetTestCase(TestCaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTestCase(new GetTestCaseRequest
            {
                TestCaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a test case.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the testcase.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/testCases/&lt;TestCase ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> GetTestCaseAsync(TestCaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTestCaseAsync(new GetTestCaseRequest
            {
                TestCaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a test case.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the testcase.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/testCases/&lt;TestCase ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> GetTestCaseAsync(TestCaseName name, st::CancellationToken cancellationToken) =>
            GetTestCaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a test case for the given agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestCase CreateTestCase(CreateTestCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a test case for the given agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> CreateTestCaseAsync(CreateTestCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a test case for the given agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> CreateTestCaseAsync(CreateTestCaseRequest request, st::CancellationToken cancellationToken) =>
            CreateTestCaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a test case for the given agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create the test case for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="testCase">
        /// Required. The test case to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestCase CreateTestCase(string parent, TestCase testCase, gaxgrpc::CallSettings callSettings = null) =>
            CreateTestCase(new CreateTestCaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TestCase = gax::GaxPreconditions.CheckNotNull(testCase, nameof(testCase)),
            }, callSettings);

        /// <summary>
        /// Creates a test case for the given agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create the test case for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="testCase">
        /// Required. The test case to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> CreateTestCaseAsync(string parent, TestCase testCase, gaxgrpc::CallSettings callSettings = null) =>
            CreateTestCaseAsync(new CreateTestCaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TestCase = gax::GaxPreconditions.CheckNotNull(testCase, nameof(testCase)),
            }, callSettings);

        /// <summary>
        /// Creates a test case for the given agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create the test case for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="testCase">
        /// Required. The test case to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> CreateTestCaseAsync(string parent, TestCase testCase, st::CancellationToken cancellationToken) =>
            CreateTestCaseAsync(parent, testCase, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a test case for the given agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create the test case for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="testCase">
        /// Required. The test case to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestCase CreateTestCase(AgentName parent, TestCase testCase, gaxgrpc::CallSettings callSettings = null) =>
            CreateTestCase(new CreateTestCaseRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TestCase = gax::GaxPreconditions.CheckNotNull(testCase, nameof(testCase)),
            }, callSettings);

        /// <summary>
        /// Creates a test case for the given agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create the test case for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="testCase">
        /// Required. The test case to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> CreateTestCaseAsync(AgentName parent, TestCase testCase, gaxgrpc::CallSettings callSettings = null) =>
            CreateTestCaseAsync(new CreateTestCaseRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TestCase = gax::GaxPreconditions.CheckNotNull(testCase, nameof(testCase)),
            }, callSettings);

        /// <summary>
        /// Creates a test case for the given agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create the test case for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="testCase">
        /// Required. The test case to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> CreateTestCaseAsync(AgentName parent, TestCase testCase, st::CancellationToken cancellationToken) =>
            CreateTestCaseAsync(parent, testCase, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestCase UpdateTestCase(UpdateTestCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> UpdateTestCaseAsync(UpdateTestCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> UpdateTestCaseAsync(UpdateTestCaseRequest request, st::CancellationToken cancellationToken) =>
            UpdateTestCaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified test case.
        /// </summary>
        /// <param name="testCase">
        /// Required. The test case to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to specify which fields should be updated. The
        /// [`creationTime`][google.cloud.dialogflow.cx.v3.TestCase.creation_time] and
        /// [`lastTestResult`][google.cloud.dialogflow.cx.v3.TestCase.last_test_result]
        /// cannot be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestCase UpdateTestCase(TestCase testCase, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTestCase(new UpdateTestCaseRequest
            {
                TestCase = gax::GaxPreconditions.CheckNotNull(testCase, nameof(testCase)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified test case.
        /// </summary>
        /// <param name="testCase">
        /// Required. The test case to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to specify which fields should be updated. The
        /// [`creationTime`][google.cloud.dialogflow.cx.v3.TestCase.creation_time] and
        /// [`lastTestResult`][google.cloud.dialogflow.cx.v3.TestCase.last_test_result]
        /// cannot be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> UpdateTestCaseAsync(TestCase testCase, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTestCaseAsync(new UpdateTestCaseRequest
            {
                TestCase = gax::GaxPreconditions.CheckNotNull(testCase, nameof(testCase)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified test case.
        /// </summary>
        /// <param name="testCase">
        /// Required. The test case to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to specify which fields should be updated. The
        /// [`creationTime`][google.cloud.dialogflow.cx.v3.TestCase.creation_time] and
        /// [`lastTestResult`][google.cloud.dialogflow.cx.v3.TestCase.last_test_result]
        /// cannot be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCase> UpdateTestCaseAsync(TestCase testCase, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTestCaseAsync(testCase, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Kicks off a test case run.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [RunTestCaseMetadata][google.cloud.dialogflow.cx.v3.RunTestCaseMetadata]
        /// - `response`:
        /// [RunTestCaseResponse][google.cloud.dialogflow.cx.v3.RunTestCaseResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RunTestCaseResponse, RunTestCaseMetadata> RunTestCase(RunTestCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Kicks off a test case run.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [RunTestCaseMetadata][google.cloud.dialogflow.cx.v3.RunTestCaseMetadata]
        /// - `response`:
        /// [RunTestCaseResponse][google.cloud.dialogflow.cx.v3.RunTestCaseResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunTestCaseResponse, RunTestCaseMetadata>> RunTestCaseAsync(RunTestCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Kicks off a test case run.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [RunTestCaseMetadata][google.cloud.dialogflow.cx.v3.RunTestCaseMetadata]
        /// - `response`:
        /// [RunTestCaseResponse][google.cloud.dialogflow.cx.v3.RunTestCaseResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunTestCaseResponse, RunTestCaseMetadata>> RunTestCaseAsync(RunTestCaseRequest request, st::CancellationToken cancellationToken) =>
            RunTestCaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunTestCase</c>.</summary>
        public virtual lro::OperationsClient RunTestCaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunTestCase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RunTestCaseResponse, RunTestCaseMetadata> PollOnceRunTestCase(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RunTestCaseResponse, RunTestCaseMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunTestCaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunTestCase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RunTestCaseResponse, RunTestCaseMetadata>> PollOnceRunTestCaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RunTestCaseResponse, RunTestCaseMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunTestCaseOperationsClient, callSettings);

        /// <summary>
        /// Kicks off a batch run of test cases.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [BatchRunTestCasesMetadata][google.cloud.dialogflow.cx.v3.BatchRunTestCasesMetadata]
        /// - `response`:
        /// [BatchRunTestCasesResponse][google.cloud.dialogflow.cx.v3.BatchRunTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata> BatchRunTestCases(BatchRunTestCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Kicks off a batch run of test cases.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [BatchRunTestCasesMetadata][google.cloud.dialogflow.cx.v3.BatchRunTestCasesMetadata]
        /// - `response`:
        /// [BatchRunTestCasesResponse][google.cloud.dialogflow.cx.v3.BatchRunTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata>> BatchRunTestCasesAsync(BatchRunTestCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Kicks off a batch run of test cases.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [BatchRunTestCasesMetadata][google.cloud.dialogflow.cx.v3.BatchRunTestCasesMetadata]
        /// - `response`:
        /// [BatchRunTestCasesResponse][google.cloud.dialogflow.cx.v3.BatchRunTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata>> BatchRunTestCasesAsync(BatchRunTestCasesRequest request, st::CancellationToken cancellationToken) =>
            BatchRunTestCasesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchRunTestCases</c>.</summary>
        public virtual lro::OperationsClient BatchRunTestCasesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchRunTestCases</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata> PollOnceBatchRunTestCases(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchRunTestCasesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchRunTestCases</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata>> PollOnceBatchRunTestCasesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchRunTestCasesOperationsClient, callSettings);

        /// <summary>
        /// Calculates the test coverage for an agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateCoverageResponse CalculateCoverage(CalculateCoverageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Calculates the test coverage for an agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateCoverageResponse> CalculateCoverageAsync(CalculateCoverageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Calculates the test coverage for an agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateCoverageResponse> CalculateCoverageAsync(CalculateCoverageRequest request, st::CancellationToken cancellationToken) =>
            CalculateCoverageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports the test cases from a Cloud Storage bucket or a local file. It
        /// always creates new test cases and won't overwrite any existing ones. The
        /// provided ID in the imported test case is neglected.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ImportTestCasesMetadata][google.cloud.dialogflow.cx.v3.ImportTestCasesMetadata]
        /// - `response`:
        /// [ImportTestCasesResponse][google.cloud.dialogflow.cx.v3.ImportTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportTestCasesResponse, ImportTestCasesMetadata> ImportTestCases(ImportTestCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the test cases from a Cloud Storage bucket or a local file. It
        /// always creates new test cases and won't overwrite any existing ones. The
        /// provided ID in the imported test case is neglected.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ImportTestCasesMetadata][google.cloud.dialogflow.cx.v3.ImportTestCasesMetadata]
        /// - `response`:
        /// [ImportTestCasesResponse][google.cloud.dialogflow.cx.v3.ImportTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportTestCasesResponse, ImportTestCasesMetadata>> ImportTestCasesAsync(ImportTestCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the test cases from a Cloud Storage bucket or a local file. It
        /// always creates new test cases and won't overwrite any existing ones. The
        /// provided ID in the imported test case is neglected.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ImportTestCasesMetadata][google.cloud.dialogflow.cx.v3.ImportTestCasesMetadata]
        /// - `response`:
        /// [ImportTestCasesResponse][google.cloud.dialogflow.cx.v3.ImportTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportTestCasesResponse, ImportTestCasesMetadata>> ImportTestCasesAsync(ImportTestCasesRequest request, st::CancellationToken cancellationToken) =>
            ImportTestCasesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportTestCases</c>.</summary>
        public virtual lro::OperationsClient ImportTestCasesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportTestCases</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportTestCasesResponse, ImportTestCasesMetadata> PollOnceImportTestCases(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportTestCasesResponse, ImportTestCasesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportTestCasesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportTestCases</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportTestCasesResponse, ImportTestCasesMetadata>> PollOnceImportTestCasesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportTestCasesResponse, ImportTestCasesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportTestCasesOperationsClient, callSettings);

        /// <summary>
        /// Exports the test cases under the agent to a Cloud Storage bucket or a local
        /// file. Filter can be applied to export a subset of test cases.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ExportTestCasesMetadata][google.cloud.dialogflow.cx.v3.ExportTestCasesMetadata]
        /// - `response`:
        /// [ExportTestCasesResponse][google.cloud.dialogflow.cx.v3.ExportTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportTestCasesResponse, ExportTestCasesMetadata> ExportTestCases(ExportTestCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the test cases under the agent to a Cloud Storage bucket or a local
        /// file. Filter can be applied to export a subset of test cases.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ExportTestCasesMetadata][google.cloud.dialogflow.cx.v3.ExportTestCasesMetadata]
        /// - `response`:
        /// [ExportTestCasesResponse][google.cloud.dialogflow.cx.v3.ExportTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportTestCasesResponse, ExportTestCasesMetadata>> ExportTestCasesAsync(ExportTestCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the test cases under the agent to a Cloud Storage bucket or a local
        /// file. Filter can be applied to export a subset of test cases.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ExportTestCasesMetadata][google.cloud.dialogflow.cx.v3.ExportTestCasesMetadata]
        /// - `response`:
        /// [ExportTestCasesResponse][google.cloud.dialogflow.cx.v3.ExportTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportTestCasesResponse, ExportTestCasesMetadata>> ExportTestCasesAsync(ExportTestCasesRequest request, st::CancellationToken cancellationToken) =>
            ExportTestCasesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportTestCases</c>.</summary>
        public virtual lro::OperationsClient ExportTestCasesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportTestCases</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportTestCasesResponse, ExportTestCasesMetadata> PollOnceExportTestCases(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportTestCasesResponse, ExportTestCasesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportTestCasesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportTestCases</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportTestCasesResponse, ExportTestCasesMetadata>> PollOnceExportTestCasesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportTestCasesResponse, ExportTestCasesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportTestCasesOperationsClient, callSettings);

        /// <summary>
        /// Fetches the list of run results for the given test case. A maximum of 100
        /// results are kept for each test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TestCaseResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTestCaseResultsResponse, TestCaseResult> ListTestCaseResults(ListTestCaseResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches the list of run results for the given test case. A maximum of 100
        /// results are kept for each test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TestCaseResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTestCaseResultsResponse, TestCaseResult> ListTestCaseResultsAsync(ListTestCaseResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches the list of run results for the given test case. A maximum of 100
        /// results are kept for each test case.
        /// </summary>
        /// <param name="parent">
        /// Required. The test case to list results for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/
        /// testCases/&lt;TestCase ID&gt;`. Specify a `-` as a wildcard for TestCase ID to
        /// list results across multiple test cases.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TestCaseResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTestCaseResultsResponse, TestCaseResult> ListTestCaseResults(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTestCaseResultsRequest request = new ListTestCaseResultsRequest
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
            return ListTestCaseResults(request, callSettings);
        }

        /// <summary>
        /// Fetches the list of run results for the given test case. A maximum of 100
        /// results are kept for each test case.
        /// </summary>
        /// <param name="parent">
        /// Required. The test case to list results for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/
        /// testCases/&lt;TestCase ID&gt;`. Specify a `-` as a wildcard for TestCase ID to
        /// list results across multiple test cases.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TestCaseResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTestCaseResultsResponse, TestCaseResult> ListTestCaseResultsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTestCaseResultsRequest request = new ListTestCaseResultsRequest
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
            return ListTestCaseResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches the list of run results for the given test case. A maximum of 100
        /// results are kept for each test case.
        /// </summary>
        /// <param name="parent">
        /// Required. The test case to list results for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/
        /// testCases/&lt;TestCase ID&gt;`. Specify a `-` as a wildcard for TestCase ID to
        /// list results across multiple test cases.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TestCaseResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTestCaseResultsResponse, TestCaseResult> ListTestCaseResults(TestCaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTestCaseResultsRequest request = new ListTestCaseResultsRequest
            {
                ParentAsTestCaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTestCaseResults(request, callSettings);
        }

        /// <summary>
        /// Fetches the list of run results for the given test case. A maximum of 100
        /// results are kept for each test case.
        /// </summary>
        /// <param name="parent">
        /// Required. The test case to list results for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;/
        /// testCases/&lt;TestCase ID&gt;`. Specify a `-` as a wildcard for TestCase ID to
        /// list results across multiple test cases.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TestCaseResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTestCaseResultsResponse, TestCaseResult> ListTestCaseResultsAsync(TestCaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTestCaseResultsRequest request = new ListTestCaseResultsRequest
            {
                ParentAsTestCaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTestCaseResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a test case result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestCaseResult GetTestCaseResult(GetTestCaseResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a test case result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCaseResult> GetTestCaseResultAsync(GetTestCaseResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a test case result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCaseResult> GetTestCaseResultAsync(GetTestCaseResultRequest request, st::CancellationToken cancellationToken) =>
            GetTestCaseResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a test case result.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the testcase.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/testCases/&lt;TestCase ID&gt;/results/&lt;TestCaseResult ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestCaseResult GetTestCaseResult(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTestCaseResult(new GetTestCaseResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a test case result.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the testcase.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/testCases/&lt;TestCase ID&gt;/results/&lt;TestCaseResult ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCaseResult> GetTestCaseResultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTestCaseResultAsync(new GetTestCaseResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a test case result.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the testcase.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/testCases/&lt;TestCase ID&gt;/results/&lt;TestCaseResult ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCaseResult> GetTestCaseResultAsync(string name, st::CancellationToken cancellationToken) =>
            GetTestCaseResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a test case result.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the testcase.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/testCases/&lt;TestCase ID&gt;/results/&lt;TestCaseResult ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestCaseResult GetTestCaseResult(TestCaseResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTestCaseResult(new GetTestCaseResultRequest
            {
                TestCaseResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a test case result.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the testcase.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/testCases/&lt;TestCase ID&gt;/results/&lt;TestCaseResult ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCaseResult> GetTestCaseResultAsync(TestCaseResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTestCaseResultAsync(new GetTestCaseResultRequest
            {
                TestCaseResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a test case result.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the testcase.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/testCases/&lt;TestCase ID&gt;/results/&lt;TestCaseResult ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestCaseResult> GetTestCaseResultAsync(TestCaseResultName name, st::CancellationToken cancellationToken) =>
            GetTestCaseResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TestCases client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Test Cases][google.cloud.dialogflow.cx.v3.TestCase] and
    /// [Test Case Results][google.cloud.dialogflow.cx.v3.TestCaseResult].
    /// </remarks>
    public sealed partial class TestCasesClientImpl : TestCasesClient
    {
        private readonly gaxgrpc::ApiCall<ListTestCasesRequest, ListTestCasesResponse> _callListTestCases;

        private readonly gaxgrpc::ApiCall<BatchDeleteTestCasesRequest, wkt::Empty> _callBatchDeleteTestCases;

        private readonly gaxgrpc::ApiCall<GetTestCaseRequest, TestCase> _callGetTestCase;

        private readonly gaxgrpc::ApiCall<CreateTestCaseRequest, TestCase> _callCreateTestCase;

        private readonly gaxgrpc::ApiCall<UpdateTestCaseRequest, TestCase> _callUpdateTestCase;

        private readonly gaxgrpc::ApiCall<RunTestCaseRequest, lro::Operation> _callRunTestCase;

        private readonly gaxgrpc::ApiCall<BatchRunTestCasesRequest, lro::Operation> _callBatchRunTestCases;

        private readonly gaxgrpc::ApiCall<CalculateCoverageRequest, CalculateCoverageResponse> _callCalculateCoverage;

        private readonly gaxgrpc::ApiCall<ImportTestCasesRequest, lro::Operation> _callImportTestCases;

        private readonly gaxgrpc::ApiCall<ExportTestCasesRequest, lro::Operation> _callExportTestCases;

        private readonly gaxgrpc::ApiCall<ListTestCaseResultsRequest, ListTestCaseResultsResponse> _callListTestCaseResults;

        private readonly gaxgrpc::ApiCall<GetTestCaseResultRequest, TestCaseResult> _callGetTestCaseResult;

        /// <summary>
        /// Constructs a client wrapper for the TestCases service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TestCasesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TestCasesClientImpl(TestCases.TestCasesClient grpcClient, TestCasesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TestCasesSettings effectiveSettings = settings ?? TestCasesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            RunTestCaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunTestCaseOperationsSettings, logger);
            BatchRunTestCasesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchRunTestCasesOperationsSettings, logger);
            ImportTestCasesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportTestCasesOperationsSettings, logger);
            ExportTestCasesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportTestCasesOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListTestCases = clientHelper.BuildApiCall<ListTestCasesRequest, ListTestCasesResponse>("ListTestCases", grpcClient.ListTestCasesAsync, grpcClient.ListTestCases, effectiveSettings.ListTestCasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTestCases);
            Modify_ListTestCasesApiCall(ref _callListTestCases);
            _callBatchDeleteTestCases = clientHelper.BuildApiCall<BatchDeleteTestCasesRequest, wkt::Empty>("BatchDeleteTestCases", grpcClient.BatchDeleteTestCasesAsync, grpcClient.BatchDeleteTestCases, effectiveSettings.BatchDeleteTestCasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteTestCases);
            Modify_BatchDeleteTestCasesApiCall(ref _callBatchDeleteTestCases);
            _callGetTestCase = clientHelper.BuildApiCall<GetTestCaseRequest, TestCase>("GetTestCase", grpcClient.GetTestCaseAsync, grpcClient.GetTestCase, effectiveSettings.GetTestCaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTestCase);
            Modify_GetTestCaseApiCall(ref _callGetTestCase);
            _callCreateTestCase = clientHelper.BuildApiCall<CreateTestCaseRequest, TestCase>("CreateTestCase", grpcClient.CreateTestCaseAsync, grpcClient.CreateTestCase, effectiveSettings.CreateTestCaseSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTestCase);
            Modify_CreateTestCaseApiCall(ref _callCreateTestCase);
            _callUpdateTestCase = clientHelper.BuildApiCall<UpdateTestCaseRequest, TestCase>("UpdateTestCase", grpcClient.UpdateTestCaseAsync, grpcClient.UpdateTestCase, effectiveSettings.UpdateTestCaseSettings).WithGoogleRequestParam("test_case.name", request => request.TestCase?.Name);
            Modify_ApiCall(ref _callUpdateTestCase);
            Modify_UpdateTestCaseApiCall(ref _callUpdateTestCase);
            _callRunTestCase = clientHelper.BuildApiCall<RunTestCaseRequest, lro::Operation>("RunTestCase", grpcClient.RunTestCaseAsync, grpcClient.RunTestCase, effectiveSettings.RunTestCaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRunTestCase);
            Modify_RunTestCaseApiCall(ref _callRunTestCase);
            _callBatchRunTestCases = clientHelper.BuildApiCall<BatchRunTestCasesRequest, lro::Operation>("BatchRunTestCases", grpcClient.BatchRunTestCasesAsync, grpcClient.BatchRunTestCases, effectiveSettings.BatchRunTestCasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchRunTestCases);
            Modify_BatchRunTestCasesApiCall(ref _callBatchRunTestCases);
            _callCalculateCoverage = clientHelper.BuildApiCall<CalculateCoverageRequest, CalculateCoverageResponse>("CalculateCoverage", grpcClient.CalculateCoverageAsync, grpcClient.CalculateCoverage, effectiveSettings.CalculateCoverageSettings).WithGoogleRequestParam("agent", request => request.Agent);
            Modify_ApiCall(ref _callCalculateCoverage);
            Modify_CalculateCoverageApiCall(ref _callCalculateCoverage);
            _callImportTestCases = clientHelper.BuildApiCall<ImportTestCasesRequest, lro::Operation>("ImportTestCases", grpcClient.ImportTestCasesAsync, grpcClient.ImportTestCases, effectiveSettings.ImportTestCasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportTestCases);
            Modify_ImportTestCasesApiCall(ref _callImportTestCases);
            _callExportTestCases = clientHelper.BuildApiCall<ExportTestCasesRequest, lro::Operation>("ExportTestCases", grpcClient.ExportTestCasesAsync, grpcClient.ExportTestCases, effectiveSettings.ExportTestCasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportTestCases);
            Modify_ExportTestCasesApiCall(ref _callExportTestCases);
            _callListTestCaseResults = clientHelper.BuildApiCall<ListTestCaseResultsRequest, ListTestCaseResultsResponse>("ListTestCaseResults", grpcClient.ListTestCaseResultsAsync, grpcClient.ListTestCaseResults, effectiveSettings.ListTestCaseResultsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTestCaseResults);
            Modify_ListTestCaseResultsApiCall(ref _callListTestCaseResults);
            _callGetTestCaseResult = clientHelper.BuildApiCall<GetTestCaseResultRequest, TestCaseResult>("GetTestCaseResult", grpcClient.GetTestCaseResultAsync, grpcClient.GetTestCaseResult, effectiveSettings.GetTestCaseResultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTestCaseResult);
            Modify_GetTestCaseResultApiCall(ref _callGetTestCaseResult);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListTestCasesApiCall(ref gaxgrpc::ApiCall<ListTestCasesRequest, ListTestCasesResponse> call);

        partial void Modify_BatchDeleteTestCasesApiCall(ref gaxgrpc::ApiCall<BatchDeleteTestCasesRequest, wkt::Empty> call);

        partial void Modify_GetTestCaseApiCall(ref gaxgrpc::ApiCall<GetTestCaseRequest, TestCase> call);

        partial void Modify_CreateTestCaseApiCall(ref gaxgrpc::ApiCall<CreateTestCaseRequest, TestCase> call);

        partial void Modify_UpdateTestCaseApiCall(ref gaxgrpc::ApiCall<UpdateTestCaseRequest, TestCase> call);

        partial void Modify_RunTestCaseApiCall(ref gaxgrpc::ApiCall<RunTestCaseRequest, lro::Operation> call);

        partial void Modify_BatchRunTestCasesApiCall(ref gaxgrpc::ApiCall<BatchRunTestCasesRequest, lro::Operation> call);

        partial void Modify_CalculateCoverageApiCall(ref gaxgrpc::ApiCall<CalculateCoverageRequest, CalculateCoverageResponse> call);

        partial void Modify_ImportTestCasesApiCall(ref gaxgrpc::ApiCall<ImportTestCasesRequest, lro::Operation> call);

        partial void Modify_ExportTestCasesApiCall(ref gaxgrpc::ApiCall<ExportTestCasesRequest, lro::Operation> call);

        partial void Modify_ListTestCaseResultsApiCall(ref gaxgrpc::ApiCall<ListTestCaseResultsRequest, ListTestCaseResultsResponse> call);

        partial void Modify_GetTestCaseResultApiCall(ref gaxgrpc::ApiCall<GetTestCaseResultRequest, TestCaseResult> call);

        partial void OnConstruction(TestCases.TestCasesClient grpcClient, TestCasesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TestCases client</summary>
        public override TestCases.TestCasesClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListTestCasesRequest(ref ListTestCasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteTestCasesRequest(ref BatchDeleteTestCasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTestCaseRequest(ref GetTestCaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTestCaseRequest(ref CreateTestCaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTestCaseRequest(ref UpdateTestCaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunTestCaseRequest(ref RunTestCaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchRunTestCasesRequest(ref BatchRunTestCasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CalculateCoverageRequest(ref CalculateCoverageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportTestCasesRequest(ref ImportTestCasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportTestCasesRequest(ref ExportTestCasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTestCaseResultsRequest(ref ListTestCaseResultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTestCaseResultRequest(ref GetTestCaseResultRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Fetches a list of test cases for a given agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TestCase"/> resources.</returns>
        public override gax::PagedEnumerable<ListTestCasesResponse, TestCase> ListTestCases(ListTestCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTestCasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTestCasesRequest, ListTestCasesResponse, TestCase>(_callListTestCases, request, callSettings);
        }

        /// <summary>
        /// Fetches a list of test cases for a given agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TestCase"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTestCasesResponse, TestCase> ListTestCasesAsync(ListTestCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTestCasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTestCasesRequest, ListTestCasesResponse, TestCase>(_callListTestCases, request, callSettings);
        }

        /// <summary>
        /// Batch deletes test cases.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void BatchDeleteTestCases(BatchDeleteTestCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteTestCasesRequest(ref request, ref callSettings);
            _callBatchDeleteTestCases.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch deletes test cases.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task BatchDeleteTestCasesAsync(BatchDeleteTestCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteTestCasesRequest(ref request, ref callSettings);
            return _callBatchDeleteTestCases.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestCase GetTestCase(GetTestCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTestCaseRequest(ref request, ref callSettings);
            return _callGetTestCase.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestCase> GetTestCaseAsync(GetTestCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTestCaseRequest(ref request, ref callSettings);
            return _callGetTestCase.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a test case for the given agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestCase CreateTestCase(CreateTestCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTestCaseRequest(ref request, ref callSettings);
            return _callCreateTestCase.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a test case for the given agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestCase> CreateTestCaseAsync(CreateTestCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTestCaseRequest(ref request, ref callSettings);
            return _callCreateTestCase.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestCase UpdateTestCase(UpdateTestCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTestCaseRequest(ref request, ref callSettings);
            return _callUpdateTestCase.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestCase> UpdateTestCaseAsync(UpdateTestCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTestCaseRequest(ref request, ref callSettings);
            return _callUpdateTestCase.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RunTestCase</c>.</summary>
        public override lro::OperationsClient RunTestCaseOperationsClient { get; }

        /// <summary>
        /// Kicks off a test case run.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [RunTestCaseMetadata][google.cloud.dialogflow.cx.v3.RunTestCaseMetadata]
        /// - `response`:
        /// [RunTestCaseResponse][google.cloud.dialogflow.cx.v3.RunTestCaseResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RunTestCaseResponse, RunTestCaseMetadata> RunTestCase(RunTestCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunTestCaseRequest(ref request, ref callSettings);
            return new lro::Operation<RunTestCaseResponse, RunTestCaseMetadata>(_callRunTestCase.Sync(request, callSettings), RunTestCaseOperationsClient);
        }

        /// <summary>
        /// Kicks off a test case run.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [RunTestCaseMetadata][google.cloud.dialogflow.cx.v3.RunTestCaseMetadata]
        /// - `response`:
        /// [RunTestCaseResponse][google.cloud.dialogflow.cx.v3.RunTestCaseResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RunTestCaseResponse, RunTestCaseMetadata>> RunTestCaseAsync(RunTestCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunTestCaseRequest(ref request, ref callSettings);
            return new lro::Operation<RunTestCaseResponse, RunTestCaseMetadata>(await _callRunTestCase.Async(request, callSettings).ConfigureAwait(false), RunTestCaseOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchRunTestCases</c>.</summary>
        public override lro::OperationsClient BatchRunTestCasesOperationsClient { get; }

        /// <summary>
        /// Kicks off a batch run of test cases.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [BatchRunTestCasesMetadata][google.cloud.dialogflow.cx.v3.BatchRunTestCasesMetadata]
        /// - `response`:
        /// [BatchRunTestCasesResponse][google.cloud.dialogflow.cx.v3.BatchRunTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata> BatchRunTestCases(BatchRunTestCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunTestCasesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata>(_callBatchRunTestCases.Sync(request, callSettings), BatchRunTestCasesOperationsClient);
        }

        /// <summary>
        /// Kicks off a batch run of test cases.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [BatchRunTestCasesMetadata][google.cloud.dialogflow.cx.v3.BatchRunTestCasesMetadata]
        /// - `response`:
        /// [BatchRunTestCasesResponse][google.cloud.dialogflow.cx.v3.BatchRunTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata>> BatchRunTestCasesAsync(BatchRunTestCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunTestCasesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata>(await _callBatchRunTestCases.Async(request, callSettings).ConfigureAwait(false), BatchRunTestCasesOperationsClient);
        }

        /// <summary>
        /// Calculates the test coverage for an agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CalculateCoverageResponse CalculateCoverage(CalculateCoverageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateCoverageRequest(ref request, ref callSettings);
            return _callCalculateCoverage.Sync(request, callSettings);
        }

        /// <summary>
        /// Calculates the test coverage for an agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CalculateCoverageResponse> CalculateCoverageAsync(CalculateCoverageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateCoverageRequest(ref request, ref callSettings);
            return _callCalculateCoverage.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportTestCases</c>.</summary>
        public override lro::OperationsClient ImportTestCasesOperationsClient { get; }

        /// <summary>
        /// Imports the test cases from a Cloud Storage bucket or a local file. It
        /// always creates new test cases and won't overwrite any existing ones. The
        /// provided ID in the imported test case is neglected.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ImportTestCasesMetadata][google.cloud.dialogflow.cx.v3.ImportTestCasesMetadata]
        /// - `response`:
        /// [ImportTestCasesResponse][google.cloud.dialogflow.cx.v3.ImportTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportTestCasesResponse, ImportTestCasesMetadata> ImportTestCases(ImportTestCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportTestCasesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportTestCasesResponse, ImportTestCasesMetadata>(_callImportTestCases.Sync(request, callSettings), ImportTestCasesOperationsClient);
        }

        /// <summary>
        /// Imports the test cases from a Cloud Storage bucket or a local file. It
        /// always creates new test cases and won't overwrite any existing ones. The
        /// provided ID in the imported test case is neglected.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ImportTestCasesMetadata][google.cloud.dialogflow.cx.v3.ImportTestCasesMetadata]
        /// - `response`:
        /// [ImportTestCasesResponse][google.cloud.dialogflow.cx.v3.ImportTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportTestCasesResponse, ImportTestCasesMetadata>> ImportTestCasesAsync(ImportTestCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportTestCasesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportTestCasesResponse, ImportTestCasesMetadata>(await _callImportTestCases.Async(request, callSettings).ConfigureAwait(false), ImportTestCasesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportTestCases</c>.</summary>
        public override lro::OperationsClient ExportTestCasesOperationsClient { get; }

        /// <summary>
        /// Exports the test cases under the agent to a Cloud Storage bucket or a local
        /// file. Filter can be applied to export a subset of test cases.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ExportTestCasesMetadata][google.cloud.dialogflow.cx.v3.ExportTestCasesMetadata]
        /// - `response`:
        /// [ExportTestCasesResponse][google.cloud.dialogflow.cx.v3.ExportTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportTestCasesResponse, ExportTestCasesMetadata> ExportTestCases(ExportTestCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportTestCasesRequest(ref request, ref callSettings);
            return new lro::Operation<ExportTestCasesResponse, ExportTestCasesMetadata>(_callExportTestCases.Sync(request, callSettings), ExportTestCasesOperationsClient);
        }

        /// <summary>
        /// Exports the test cases under the agent to a Cloud Storage bucket or a local
        /// file. Filter can be applied to export a subset of test cases.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ExportTestCasesMetadata][google.cloud.dialogflow.cx.v3.ExportTestCasesMetadata]
        /// - `response`:
        /// [ExportTestCasesResponse][google.cloud.dialogflow.cx.v3.ExportTestCasesResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportTestCasesResponse, ExportTestCasesMetadata>> ExportTestCasesAsync(ExportTestCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportTestCasesRequest(ref request, ref callSettings);
            return new lro::Operation<ExportTestCasesResponse, ExportTestCasesMetadata>(await _callExportTestCases.Async(request, callSettings).ConfigureAwait(false), ExportTestCasesOperationsClient);
        }

        /// <summary>
        /// Fetches the list of run results for the given test case. A maximum of 100
        /// results are kept for each test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TestCaseResult"/> resources.</returns>
        public override gax::PagedEnumerable<ListTestCaseResultsResponse, TestCaseResult> ListTestCaseResults(ListTestCaseResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTestCaseResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTestCaseResultsRequest, ListTestCaseResultsResponse, TestCaseResult>(_callListTestCaseResults, request, callSettings);
        }

        /// <summary>
        /// Fetches the list of run results for the given test case. A maximum of 100
        /// results are kept for each test case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TestCaseResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTestCaseResultsResponse, TestCaseResult> ListTestCaseResultsAsync(ListTestCaseResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTestCaseResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTestCaseResultsRequest, ListTestCaseResultsResponse, TestCaseResult>(_callListTestCaseResults, request, callSettings);
        }

        /// <summary>
        /// Gets a test case result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestCaseResult GetTestCaseResult(GetTestCaseResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTestCaseResultRequest(ref request, ref callSettings);
            return _callGetTestCaseResult.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a test case result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestCaseResult> GetTestCaseResultAsync(GetTestCaseResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTestCaseResultRequest(ref request, ref callSettings);
            return _callGetTestCaseResult.Async(request, callSettings);
        }
    }

    public partial class ListTestCasesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTestCaseResultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTestCasesResponse : gaxgrpc::IPageResponse<TestCase>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TestCase> GetEnumerator() => TestCases.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTestCaseResultsResponse : gaxgrpc::IPageResponse<TestCaseResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TestCaseResult> GetEnumerator() => TestCaseResults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class TestCases
    {
        public partial class TestCasesClient
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

    public static partial class TestCases
    {
        public partial class TestCasesClient
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
