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

namespace Google.Cloud.WorkloadManager.V1
{
    /// <summary>Settings for <see cref="WorkloadManagerClient"/> instances.</summary>
    public sealed partial class WorkloadManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WorkloadManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WorkloadManagerSettings"/>.</returns>
        public static WorkloadManagerSettings GetDefault() => new WorkloadManagerSettings();

        /// <summary>Constructs a new <see cref="WorkloadManagerSettings"/> object with default settings.</summary>
        public WorkloadManagerSettings()
        {
        }

        private WorkloadManagerSettings(WorkloadManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListEvaluationsSettings = existing.ListEvaluationsSettings;
            GetEvaluationSettings = existing.GetEvaluationSettings;
            CreateEvaluationSettings = existing.CreateEvaluationSettings;
            CreateEvaluationOperationsSettings = existing.CreateEvaluationOperationsSettings.Clone();
            UpdateEvaluationSettings = existing.UpdateEvaluationSettings;
            UpdateEvaluationOperationsSettings = existing.UpdateEvaluationOperationsSettings.Clone();
            DeleteEvaluationSettings = existing.DeleteEvaluationSettings;
            DeleteEvaluationOperationsSettings = existing.DeleteEvaluationOperationsSettings.Clone();
            ListExecutionsSettings = existing.ListExecutionsSettings;
            GetExecutionSettings = existing.GetExecutionSettings;
            RunEvaluationSettings = existing.RunEvaluationSettings;
            RunEvaluationOperationsSettings = existing.RunEvaluationOperationsSettings.Clone();
            DeleteExecutionSettings = existing.DeleteExecutionSettings;
            DeleteExecutionOperationsSettings = existing.DeleteExecutionOperationsSettings.Clone();
            ListExecutionResultsSettings = existing.ListExecutionResultsSettings;
            ListRulesSettings = existing.ListRulesSettings;
            ListScannedResourcesSettings = existing.ListScannedResourcesSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(WorkloadManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadManagerClient.ListEvaluations</c> and <c>WorkloadManagerClient.ListEvaluationsAsync</c>.
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
        public gaxgrpc::CallSettings ListEvaluationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadManagerClient.GetEvaluation</c> and <c>WorkloadManagerClient.GetEvaluationAsync</c>.
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
        public gaxgrpc::CallSettings GetEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadManagerClient.CreateEvaluation</c> and <c>WorkloadManagerClient.CreateEvaluationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEvaluationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkloadManagerClient.CreateEvaluation</c> and
        /// <c>WorkloadManagerClient.CreateEvaluationAsync</c>.
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
        public lro::OperationsSettings CreateEvaluationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadManagerClient.UpdateEvaluation</c> and <c>WorkloadManagerClient.UpdateEvaluationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEvaluationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkloadManagerClient.UpdateEvaluation</c> and
        /// <c>WorkloadManagerClient.UpdateEvaluationAsync</c>.
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
        public lro::OperationsSettings UpdateEvaluationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadManagerClient.DeleteEvaluation</c> and <c>WorkloadManagerClient.DeleteEvaluationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEvaluationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkloadManagerClient.DeleteEvaluation</c> and
        /// <c>WorkloadManagerClient.DeleteEvaluationAsync</c>.
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
        public lro::OperationsSettings DeleteEvaluationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadManagerClient.ListExecutions</c> and <c>WorkloadManagerClient.ListExecutionsAsync</c>.
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
        public gaxgrpc::CallSettings ListExecutionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadManagerClient.GetExecution</c> and <c>WorkloadManagerClient.GetExecutionAsync</c>.
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
        public gaxgrpc::CallSettings GetExecutionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadManagerClient.RunEvaluation</c> and <c>WorkloadManagerClient.RunEvaluationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunEvaluationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkloadManagerClient.RunEvaluation</c> and
        /// <c>WorkloadManagerClient.RunEvaluationAsync</c>.
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
        public lro::OperationsSettings RunEvaluationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadManagerClient.DeleteExecution</c> and <c>WorkloadManagerClient.DeleteExecutionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteExecutionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkloadManagerClient.DeleteExecution</c> and
        /// <c>WorkloadManagerClient.DeleteExecutionAsync</c>.
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
        public lro::OperationsSettings DeleteExecutionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadManagerClient.ListExecutionResults</c> and <c>WorkloadManagerClient.ListExecutionResultsAsync</c>
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
        public gaxgrpc::CallSettings ListExecutionResultsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadManagerClient.ListRules</c> and <c>WorkloadManagerClient.ListRulesAsync</c>.
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
        public gaxgrpc::CallSettings ListRulesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadManagerClient.ListScannedResources</c> and <c>WorkloadManagerClient.ListScannedResourcesAsync</c>
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
        public gaxgrpc::CallSettings ListScannedResourcesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WorkloadManagerSettings"/> object.</returns>
        public WorkloadManagerSettings Clone() => new WorkloadManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WorkloadManagerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class WorkloadManagerClientBuilder : gaxgrpc::ClientBuilderBase<WorkloadManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WorkloadManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WorkloadManagerClientBuilder() : base(WorkloadManagerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WorkloadManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WorkloadManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WorkloadManagerClient Build()
        {
            WorkloadManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WorkloadManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WorkloadManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WorkloadManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WorkloadManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WorkloadManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WorkloadManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WorkloadManagerClient.ChannelPool;
    }

    /// <summary>WorkloadManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Workload Manager provides various tools to deploy, validate and observe
    /// your workloads running on Google Cloud.
    /// </remarks>
    public abstract partial class WorkloadManagerClient
    {
        /// <summary>
        /// The default endpoint for the WorkloadManager service, which is a host of "workloadmanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "workloadmanager.googleapis.com:443";

        /// <summary>The default WorkloadManager scopes.</summary>
        /// <remarks>
        /// The default WorkloadManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(WorkloadManager.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WorkloadManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WorkloadManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WorkloadManagerClient"/>.</returns>
        public static stt::Task<WorkloadManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WorkloadManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WorkloadManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WorkloadManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WorkloadManagerClient"/>.</returns>
        public static WorkloadManagerClient Create() => new WorkloadManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WorkloadManagerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WorkloadManagerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WorkloadManagerClient"/>.</returns>
        internal static WorkloadManagerClient Create(grpccore::CallInvoker callInvoker, WorkloadManagerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WorkloadManager.WorkloadManagerClient grpcClient = new WorkloadManager.WorkloadManagerClient(callInvoker);
            return new WorkloadManagerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC WorkloadManager client</summary>
        public virtual WorkloadManager.WorkloadManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Evaluations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Evaluations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Evaluations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEvaluationsRequest.
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
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationsRequest request = new ListEvaluationsRequest
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
            return ListEvaluations(request, callSettings);
        }

        /// <summary>
        /// Lists Evaluations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEvaluationsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationsRequest request = new ListEvaluationsRequest
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
            return ListEvaluationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Evaluations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEvaluationsRequest.
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
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationsRequest request = new ListEvaluationsRequest
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
            return ListEvaluations(request, callSettings);
        }

        /// <summary>
        /// Lists Evaluations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListEvaluationsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationsRequest request = new ListEvaluationsRequest
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
            return ListEvaluationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(GetEvaluationRequest request, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluation(new GetEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationAsync(new GetEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(string name, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluation(new GetEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationAsync(new GetEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(EvaluationName name, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Evaluation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Evaluation, OperationMetadata> CreateEvaluation(CreateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Evaluation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, OperationMetadata>> CreateEvaluationAsync(CreateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Evaluation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, OperationMetadata>> CreateEvaluationAsync(CreateEvaluationRequest request, st::CancellationToken cancellationToken) =>
            CreateEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEvaluation</c>.</summary>
        public virtual lro::OperationsClient CreateEvaluationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Evaluation, OperationMetadata> PollOnceCreateEvaluation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Evaluation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, OperationMetadata>> PollOnceCreateEvaluationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Evaluation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Evaluation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource prefix of the evaluation location using the form:
        /// `projects/{project_id}/locations/{location_id}`.
        /// </param>
        /// <param name="evaluation">
        /// Required. The resource being created.
        /// </param>
        /// <param name="evaluationId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Evaluation, OperationMetadata> CreateEvaluation(string parent, Evaluation evaluation, string evaluationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluation(new CreateEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluationId = gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates a new Evaluation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource prefix of the evaluation location using the form:
        /// `projects/{project_id}/locations/{location_id}`.
        /// </param>
        /// <param name="evaluation">
        /// Required. The resource being created.
        /// </param>
        /// <param name="evaluationId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, OperationMetadata>> CreateEvaluationAsync(string parent, Evaluation evaluation, string evaluationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationAsync(new CreateEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluationId = gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates a new Evaluation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource prefix of the evaluation location using the form:
        /// `projects/{project_id}/locations/{location_id}`.
        /// </param>
        /// <param name="evaluation">
        /// Required. The resource being created.
        /// </param>
        /// <param name="evaluationId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, OperationMetadata>> CreateEvaluationAsync(string parent, Evaluation evaluation, string evaluationId, st::CancellationToken cancellationToken) =>
            CreateEvaluationAsync(parent, evaluation, evaluationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Evaluation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource prefix of the evaluation location using the form:
        /// `projects/{project_id}/locations/{location_id}`.
        /// </param>
        /// <param name="evaluation">
        /// Required. The resource being created.
        /// </param>
        /// <param name="evaluationId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Evaluation, OperationMetadata> CreateEvaluation(gagr::LocationName parent, Evaluation evaluation, string evaluationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluation(new CreateEvaluationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluationId = gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates a new Evaluation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource prefix of the evaluation location using the form:
        /// `projects/{project_id}/locations/{location_id}`.
        /// </param>
        /// <param name="evaluation">
        /// Required. The resource being created.
        /// </param>
        /// <param name="evaluationId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, OperationMetadata>> CreateEvaluationAsync(gagr::LocationName parent, Evaluation evaluation, string evaluationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationAsync(new CreateEvaluationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluationId = gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates a new Evaluation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource prefix of the evaluation location using the form:
        /// `projects/{project_id}/locations/{location_id}`.
        /// </param>
        /// <param name="evaluation">
        /// Required. The resource being created.
        /// </param>
        /// <param name="evaluationId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, OperationMetadata>> CreateEvaluationAsync(gagr::LocationName parent, Evaluation evaluation, string evaluationId, st::CancellationToken cancellationToken) =>
            CreateEvaluationAsync(parent, evaluation, evaluationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Evaluation, OperationMetadata> UpdateEvaluation(UpdateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, OperationMetadata>> UpdateEvaluationAsync(UpdateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, OperationMetadata>> UpdateEvaluationAsync(UpdateEvaluationRequest request, st::CancellationToken cancellationToken) =>
            UpdateEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEvaluation</c>.</summary>
        public virtual lro::OperationsClient UpdateEvaluationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Evaluation, OperationMetadata> PollOnceUpdateEvaluation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Evaluation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, OperationMetadata>> PollOnceUpdateEvaluationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Evaluation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Evaluation.
        /// </summary>
        /// <param name="evaluation">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Evaluation resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Evaluation, OperationMetadata> UpdateEvaluation(Evaluation evaluation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEvaluation(new UpdateEvaluationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Evaluation.
        /// </summary>
        /// <param name="evaluation">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Evaluation resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, OperationMetadata>> UpdateEvaluationAsync(Evaluation evaluation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEvaluationAsync(new UpdateEvaluationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Evaluation.
        /// </summary>
        /// <param name="evaluation">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Evaluation resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, OperationMetadata>> UpdateEvaluationAsync(Evaluation evaluation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEvaluationAsync(evaluation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEvaluation(DeleteEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEvaluationAsync(DeleteEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEvaluationAsync(DeleteEvaluationRequest request, st::CancellationToken cancellationToken) =>
            DeleteEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEvaluation</c>.</summary>
        public virtual lro::OperationsClient DeleteEvaluationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteEvaluation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteEvaluationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEvaluation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluation(new DeleteEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEvaluationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationAsync(new DeleteEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEvaluationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEvaluation(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluation(new DeleteEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEvaluationAsync(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationAsync(new DeleteEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEvaluationAsync(EvaluationName name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Executions in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Executions in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Executions in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource prefix of the Execution using the form:
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
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
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionsRequest request = new ListExecutionsRequest
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
            return ListExecutions(request, callSettings);
        }

        /// <summary>
        /// Lists Executions in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource prefix of the Execution using the form:
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionsRequest request = new ListExecutionsRequest
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
            return ListExecutionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Executions in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource prefix of the Execution using the form:
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
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
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(EvaluationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExecutions(request, callSettings);
        }

        /// <summary>
        /// Lists Executions in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource prefix of the Execution using the form:
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(EvaluationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExecutionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution GetExecution(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(GetExecutionRequest request, st::CancellationToken cancellationToken) =>
            GetExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Execution.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution GetExecution(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecution(new GetExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Execution.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecutionAsync(new GetExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Execution.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(string name, st::CancellationToken cancellationToken) =>
            GetExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Execution.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution GetExecution(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecution(new GetExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Execution.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecutionAsync(new GetExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Execution.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(ExecutionName name, st::CancellationToken cancellationToken) =>
            GetExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Execution, OperationMetadata> RunEvaluation(RunEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> RunEvaluationAsync(RunEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> RunEvaluationAsync(RunEvaluationRequest request, st::CancellationToken cancellationToken) =>
            RunEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunEvaluation</c>.</summary>
        public virtual lro::OperationsClient RunEvaluationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Execution, OperationMetadata> PollOnceRunEvaluation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Execution, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> PollOnceRunEvaluationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Execution, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Evaluation using the form:
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// </param>
        /// <param name="execution">
        /// Required. The resource being created.
        /// </param>
        /// <param name="executionId">
        /// Required. ID of the execution which will be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Execution, OperationMetadata> RunEvaluation(string name, Execution execution, string executionId, gaxgrpc::CallSettings callSettings = null) =>
            RunEvaluation(new RunEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ExecutionId = gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Evaluation using the form:
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// </param>
        /// <param name="execution">
        /// Required. The resource being created.
        /// </param>
        /// <param name="executionId">
        /// Required. ID of the execution which will be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> RunEvaluationAsync(string name, Execution execution, string executionId, gaxgrpc::CallSettings callSettings = null) =>
            RunEvaluationAsync(new RunEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ExecutionId = gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Evaluation using the form:
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// </param>
        /// <param name="execution">
        /// Required. The resource being created.
        /// </param>
        /// <param name="executionId">
        /// Required. ID of the execution which will be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> RunEvaluationAsync(string name, Execution execution, string executionId, st::CancellationToken cancellationToken) =>
            RunEvaluationAsync(name, execution, executionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Evaluation using the form:
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// </param>
        /// <param name="execution">
        /// Required. The resource being created.
        /// </param>
        /// <param name="executionId">
        /// Required. ID of the execution which will be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Execution, OperationMetadata> RunEvaluation(EvaluationName name, Execution execution, string executionId, gaxgrpc::CallSettings callSettings = null) =>
            RunEvaluation(new RunEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ExecutionId = gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Evaluation using the form:
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// </param>
        /// <param name="execution">
        /// Required. The resource being created.
        /// </param>
        /// <param name="executionId">
        /// Required. ID of the execution which will be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> RunEvaluationAsync(EvaluationName name, Execution execution, string executionId, gaxgrpc::CallSettings callSettings = null) =>
            RunEvaluationAsync(new RunEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ExecutionId = gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Evaluation using the form:
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// </param>
        /// <param name="execution">
        /// Required. The resource being created.
        /// </param>
        /// <param name="executionId">
        /// Required. ID of the execution which will be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> RunEvaluationAsync(EvaluationName name, Execution execution, string executionId, st::CancellationToken cancellationToken) =>
            RunEvaluationAsync(name, execution, executionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteExecution(DeleteExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(DeleteExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(DeleteExecutionRequest request, st::CancellationToken cancellationToken) =>
            DeleteExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteExecution</c>.</summary>
        public virtual lro::OperationsClient DeleteExecutionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteExecution</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteExecution(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExecutionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteExecution</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteExecutionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExecutionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Execution.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteExecution(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExecution(new DeleteExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Execution.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExecutionAsync(new DeleteExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Execution.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Execution.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteExecution(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExecution(new DeleteExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Execution.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExecutionAsync(new DeleteExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Execution.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(ExecutionName name, st::CancellationToken cancellationToken) =>
            DeleteExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the result of a single evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExecutionResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionResultsResponse, ExecutionResult> ListExecutionResults(ListExecutionResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the result of a single evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExecutionResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionResultsResponse, ExecutionResult> ListExecutionResultsAsync(ListExecutionResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the result of a single evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The execution results.
        /// Format: {parent}/evaluations/*/executions/*/results.
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
        /// <returns>A pageable sequence of <see cref="ExecutionResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionResultsResponse, ExecutionResult> ListExecutionResults(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionResultsRequest request = new ListExecutionResultsRequest
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
            return ListExecutionResults(request, callSettings);
        }

        /// <summary>
        /// Lists the result of a single evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The execution results.
        /// Format: {parent}/evaluations/*/executions/*/results.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ExecutionResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionResultsResponse, ExecutionResult> ListExecutionResultsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionResultsRequest request = new ListExecutionResultsRequest
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
            return ListExecutionResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists rules in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListRulesResponse ListRules(ListRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists rules in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists rules in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, st::CancellationToken cancellationToken) =>
            ListRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists rules in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The [project] on which to execute the request. The format is:
        /// projects/{project_id}/locations/{location}
        /// Currently, the pre-defined rules are global available to all projects and
        /// all regions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListRulesResponse ListRules(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListRules(new ListRulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists rules in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The [project] on which to execute the request. The format is:
        /// projects/{project_id}/locations/{location}
        /// Currently, the pre-defined rules are global available to all projects and
        /// all regions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListRulesResponse> ListRulesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListRulesAsync(new ListRulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists rules in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The [project] on which to execute the request. The format is:
        /// projects/{project_id}/locations/{location}
        /// Currently, the pre-defined rules are global available to all projects and
        /// all regions.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListRulesResponse> ListRulesAsync(string parent, st::CancellationToken cancellationToken) =>
            ListRulesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists rules in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The [project] on which to execute the request. The format is:
        /// projects/{project_id}/locations/{location}
        /// Currently, the pre-defined rules are global available to all projects and
        /// all regions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListRulesResponse ListRules(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListRules(new ListRulesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists rules in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The [project] on which to execute the request. The format is:
        /// projects/{project_id}/locations/{location}
        /// Currently, the pre-defined rules are global available to all projects and
        /// all regions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListRulesResponse> ListRulesAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListRulesAsync(new ListRulesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists rules in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The [project] on which to execute the request. The format is:
        /// projects/{project_id}/locations/{location}
        /// Currently, the pre-defined rules are global available to all projects and
        /// all regions.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListRulesResponse> ListRulesAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            ListRulesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all scanned resources for a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ScannedResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScannedResourcesResponse, ScannedResource> ListScannedResources(ListScannedResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all scanned resources for a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ScannedResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScannedResourcesResponse, ScannedResource> ListScannedResourcesAsync(ListScannedResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all scanned resources for a single Execution.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent for ListScannedResourcesRequest.
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
        /// <returns>A pageable sequence of <see cref="ScannedResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScannedResourcesResponse, ScannedResource> ListScannedResources(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScannedResourcesRequest request = new ListScannedResourcesRequest
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
            return ListScannedResources(request, callSettings);
        }

        /// <summary>
        /// List all scanned resources for a single Execution.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent for ListScannedResourcesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ScannedResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScannedResourcesResponse, ScannedResource> ListScannedResourcesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScannedResourcesRequest request = new ListScannedResourcesRequest
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
            return ListScannedResourcesAsync(request, callSettings);
        }
    }

    /// <summary>WorkloadManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Workload Manager provides various tools to deploy, validate and observe
    /// your workloads running on Google Cloud.
    /// </remarks>
    public sealed partial class WorkloadManagerClientImpl : WorkloadManagerClient
    {
        private readonly gaxgrpc::ApiCall<ListEvaluationsRequest, ListEvaluationsResponse> _callListEvaluations;

        private readonly gaxgrpc::ApiCall<GetEvaluationRequest, Evaluation> _callGetEvaluation;

        private readonly gaxgrpc::ApiCall<CreateEvaluationRequest, lro::Operation> _callCreateEvaluation;

        private readonly gaxgrpc::ApiCall<UpdateEvaluationRequest, lro::Operation> _callUpdateEvaluation;

        private readonly gaxgrpc::ApiCall<DeleteEvaluationRequest, lro::Operation> _callDeleteEvaluation;

        private readonly gaxgrpc::ApiCall<ListExecutionsRequest, ListExecutionsResponse> _callListExecutions;

        private readonly gaxgrpc::ApiCall<GetExecutionRequest, Execution> _callGetExecution;

        private readonly gaxgrpc::ApiCall<RunEvaluationRequest, lro::Operation> _callRunEvaluation;

        private readonly gaxgrpc::ApiCall<DeleteExecutionRequest, lro::Operation> _callDeleteExecution;

        private readonly gaxgrpc::ApiCall<ListExecutionResultsRequest, ListExecutionResultsResponse> _callListExecutionResults;

        private readonly gaxgrpc::ApiCall<ListRulesRequest, ListRulesResponse> _callListRules;

        private readonly gaxgrpc::ApiCall<ListScannedResourcesRequest, ListScannedResourcesResponse> _callListScannedResources;

        /// <summary>
        /// Constructs a client wrapper for the WorkloadManager service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WorkloadManagerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WorkloadManagerClientImpl(WorkloadManager.WorkloadManagerClient grpcClient, WorkloadManagerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WorkloadManagerSettings effectiveSettings = settings ?? WorkloadManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateEvaluationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEvaluationOperationsSettings, logger);
            UpdateEvaluationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEvaluationOperationsSettings, logger);
            DeleteEvaluationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEvaluationOperationsSettings, logger);
            RunEvaluationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunEvaluationOperationsSettings, logger);
            DeleteExecutionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteExecutionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListEvaluations = clientHelper.BuildApiCall<ListEvaluationsRequest, ListEvaluationsResponse>("ListEvaluations", grpcClient.ListEvaluationsAsync, grpcClient.ListEvaluations, effectiveSettings.ListEvaluationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEvaluations);
            Modify_ListEvaluationsApiCall(ref _callListEvaluations);
            _callGetEvaluation = clientHelper.BuildApiCall<GetEvaluationRequest, Evaluation>("GetEvaluation", grpcClient.GetEvaluationAsync, grpcClient.GetEvaluation, effectiveSettings.GetEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEvaluation);
            Modify_GetEvaluationApiCall(ref _callGetEvaluation);
            _callCreateEvaluation = clientHelper.BuildApiCall<CreateEvaluationRequest, lro::Operation>("CreateEvaluation", grpcClient.CreateEvaluationAsync, grpcClient.CreateEvaluation, effectiveSettings.CreateEvaluationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEvaluation);
            Modify_CreateEvaluationApiCall(ref _callCreateEvaluation);
            _callUpdateEvaluation = clientHelper.BuildApiCall<UpdateEvaluationRequest, lro::Operation>("UpdateEvaluation", grpcClient.UpdateEvaluationAsync, grpcClient.UpdateEvaluation, effectiveSettings.UpdateEvaluationSettings).WithGoogleRequestParam("evaluation.name", request => request.Evaluation?.Name);
            Modify_ApiCall(ref _callUpdateEvaluation);
            Modify_UpdateEvaluationApiCall(ref _callUpdateEvaluation);
            _callDeleteEvaluation = clientHelper.BuildApiCall<DeleteEvaluationRequest, lro::Operation>("DeleteEvaluation", grpcClient.DeleteEvaluationAsync, grpcClient.DeleteEvaluation, effectiveSettings.DeleteEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEvaluation);
            Modify_DeleteEvaluationApiCall(ref _callDeleteEvaluation);
            _callListExecutions = clientHelper.BuildApiCall<ListExecutionsRequest, ListExecutionsResponse>("ListExecutions", grpcClient.ListExecutionsAsync, grpcClient.ListExecutions, effectiveSettings.ListExecutionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExecutions);
            Modify_ListExecutionsApiCall(ref _callListExecutions);
            _callGetExecution = clientHelper.BuildApiCall<GetExecutionRequest, Execution>("GetExecution", grpcClient.GetExecutionAsync, grpcClient.GetExecution, effectiveSettings.GetExecutionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExecution);
            Modify_GetExecutionApiCall(ref _callGetExecution);
            _callRunEvaluation = clientHelper.BuildApiCall<RunEvaluationRequest, lro::Operation>("RunEvaluation", grpcClient.RunEvaluationAsync, grpcClient.RunEvaluation, effectiveSettings.RunEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRunEvaluation);
            Modify_RunEvaluationApiCall(ref _callRunEvaluation);
            _callDeleteExecution = clientHelper.BuildApiCall<DeleteExecutionRequest, lro::Operation>("DeleteExecution", grpcClient.DeleteExecutionAsync, grpcClient.DeleteExecution, effectiveSettings.DeleteExecutionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteExecution);
            Modify_DeleteExecutionApiCall(ref _callDeleteExecution);
            _callListExecutionResults = clientHelper.BuildApiCall<ListExecutionResultsRequest, ListExecutionResultsResponse>("ListExecutionResults", grpcClient.ListExecutionResultsAsync, grpcClient.ListExecutionResults, effectiveSettings.ListExecutionResultsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExecutionResults);
            Modify_ListExecutionResultsApiCall(ref _callListExecutionResults);
            _callListRules = clientHelper.BuildApiCall<ListRulesRequest, ListRulesResponse>("ListRules", grpcClient.ListRulesAsync, grpcClient.ListRules, effectiveSettings.ListRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRules);
            Modify_ListRulesApiCall(ref _callListRules);
            _callListScannedResources = clientHelper.BuildApiCall<ListScannedResourcesRequest, ListScannedResourcesResponse>("ListScannedResources", grpcClient.ListScannedResourcesAsync, grpcClient.ListScannedResources, effectiveSettings.ListScannedResourcesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListScannedResources);
            Modify_ListScannedResourcesApiCall(ref _callListScannedResources);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListEvaluationsApiCall(ref gaxgrpc::ApiCall<ListEvaluationsRequest, ListEvaluationsResponse> call);

        partial void Modify_GetEvaluationApiCall(ref gaxgrpc::ApiCall<GetEvaluationRequest, Evaluation> call);

        partial void Modify_CreateEvaluationApiCall(ref gaxgrpc::ApiCall<CreateEvaluationRequest, lro::Operation> call);

        partial void Modify_UpdateEvaluationApiCall(ref gaxgrpc::ApiCall<UpdateEvaluationRequest, lro::Operation> call);

        partial void Modify_DeleteEvaluationApiCall(ref gaxgrpc::ApiCall<DeleteEvaluationRequest, lro::Operation> call);

        partial void Modify_ListExecutionsApiCall(ref gaxgrpc::ApiCall<ListExecutionsRequest, ListExecutionsResponse> call);

        partial void Modify_GetExecutionApiCall(ref gaxgrpc::ApiCall<GetExecutionRequest, Execution> call);

        partial void Modify_RunEvaluationApiCall(ref gaxgrpc::ApiCall<RunEvaluationRequest, lro::Operation> call);

        partial void Modify_DeleteExecutionApiCall(ref gaxgrpc::ApiCall<DeleteExecutionRequest, lro::Operation> call);

        partial void Modify_ListExecutionResultsApiCall(ref gaxgrpc::ApiCall<ListExecutionResultsRequest, ListExecutionResultsResponse> call);

        partial void Modify_ListRulesApiCall(ref gaxgrpc::ApiCall<ListRulesRequest, ListRulesResponse> call);

        partial void Modify_ListScannedResourcesApiCall(ref gaxgrpc::ApiCall<ListScannedResourcesRequest, ListScannedResourcesResponse> call);

        partial void OnConstruction(WorkloadManager.WorkloadManagerClient grpcClient, WorkloadManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC WorkloadManager client</summary>
        public override WorkloadManager.WorkloadManagerClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListEvaluationsRequest(ref ListEvaluationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEvaluationRequest(ref GetEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEvaluationRequest(ref CreateEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEvaluationRequest(ref UpdateEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEvaluationRequest(ref DeleteEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExecutionsRequest(ref ListExecutionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExecutionRequest(ref GetExecutionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunEvaluationRequest(ref RunEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteExecutionRequest(ref DeleteExecutionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExecutionResultsRequest(ref ListExecutionResultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRulesRequest(ref ListRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListScannedResourcesRequest(ref ListScannedResourcesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Evaluations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public override gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEvaluationsRequest, ListEvaluationsResponse, Evaluation>(_callListEvaluations, request, callSettings);
        }

        /// <summary>
        /// Lists Evaluations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEvaluationsRequest, ListEvaluationsResponse, Evaluation>(_callListEvaluations, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Evaluation GetEvaluation(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationRequest(ref request, ref callSettings);
            return _callGetEvaluation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Evaluation> GetEvaluationAsync(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationRequest(ref request, ref callSettings);
            return _callGetEvaluation.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEvaluation</c>.</summary>
        public override lro::OperationsClient CreateEvaluationOperationsClient { get; }

        /// <summary>
        /// Creates a new Evaluation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Evaluation, OperationMetadata> CreateEvaluation(CreateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<Evaluation, OperationMetadata>(_callCreateEvaluation.Sync(request, callSettings), CreateEvaluationOperationsClient);
        }

        /// <summary>
        /// Creates a new Evaluation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Evaluation, OperationMetadata>> CreateEvaluationAsync(CreateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<Evaluation, OperationMetadata>(await _callCreateEvaluation.Async(request, callSettings).ConfigureAwait(false), CreateEvaluationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateEvaluation</c>.</summary>
        public override lro::OperationsClient UpdateEvaluationOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Evaluation, OperationMetadata> UpdateEvaluation(UpdateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<Evaluation, OperationMetadata>(_callUpdateEvaluation.Sync(request, callSettings), UpdateEvaluationOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Evaluation, OperationMetadata>> UpdateEvaluationAsync(UpdateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<Evaluation, OperationMetadata>(await _callUpdateEvaluation.Async(request, callSettings).ConfigureAwait(false), UpdateEvaluationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEvaluation</c>.</summary>
        public override lro::OperationsClient DeleteEvaluationOperationsClient { get; }

        /// <summary>
        /// Deletes a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteEvaluation(DeleteEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteEvaluation.Sync(request, callSettings), DeleteEvaluationOperationsClient);
        }

        /// <summary>
        /// Deletes a single Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEvaluationAsync(DeleteEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteEvaluation.Async(request, callSettings).ConfigureAwait(false), DeleteEvaluationOperationsClient);
        }

        /// <summary>
        /// Lists Executions in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public override gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExecutionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExecutionsRequest, ListExecutionsResponse, Execution>(_callListExecutions, request, callSettings);
        }

        /// <summary>
        /// Lists Executions in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExecutionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExecutionsRequest, ListExecutionsResponse, Execution>(_callListExecutions, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Execution GetExecution(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExecutionRequest(ref request, ref callSettings);
            return _callGetExecution.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Execution> GetExecutionAsync(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExecutionRequest(ref request, ref callSettings);
            return _callGetExecution.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RunEvaluation</c>.</summary>
        public override lro::OperationsClient RunEvaluationOperationsClient { get; }

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Execution, OperationMetadata> RunEvaluation(RunEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<Execution, OperationMetadata>(_callRunEvaluation.Sync(request, callSettings), RunEvaluationOperationsClient);
        }

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Execution, OperationMetadata>> RunEvaluationAsync(RunEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<Execution, OperationMetadata>(await _callRunEvaluation.Async(request, callSettings).ConfigureAwait(false), RunEvaluationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteExecution</c>.</summary>
        public override lro::OperationsClient DeleteExecutionOperationsClient { get; }

        /// <summary>
        /// Deletes a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteExecution(DeleteExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExecutionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteExecution.Sync(request, callSettings), DeleteExecutionOperationsClient);
        }

        /// <summary>
        /// Deletes a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(DeleteExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExecutionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteExecution.Async(request, callSettings).ConfigureAwait(false), DeleteExecutionOperationsClient);
        }

        /// <summary>
        /// Lists the result of a single evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExecutionResult"/> resources.</returns>
        public override gax::PagedEnumerable<ListExecutionResultsResponse, ExecutionResult> ListExecutionResults(ListExecutionResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExecutionResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExecutionResultsRequest, ListExecutionResultsResponse, ExecutionResult>(_callListExecutionResults, request, callSettings);
        }

        /// <summary>
        /// Lists the result of a single evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExecutionResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExecutionResultsResponse, ExecutionResult> ListExecutionResultsAsync(ListExecutionResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExecutionResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExecutionResultsRequest, ListExecutionResultsResponse, ExecutionResult>(_callListExecutionResults, request, callSettings);
        }

        /// <summary>
        /// Lists rules in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListRulesResponse ListRules(ListRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRulesRequest(ref request, ref callSettings);
            return _callListRules.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists rules in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRulesRequest(ref request, ref callSettings);
            return _callListRules.Async(request, callSettings);
        }

        /// <summary>
        /// List all scanned resources for a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ScannedResource"/> resources.</returns>
        public override gax::PagedEnumerable<ListScannedResourcesResponse, ScannedResource> ListScannedResources(ListScannedResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScannedResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListScannedResourcesRequest, ListScannedResourcesResponse, ScannedResource>(_callListScannedResources, request, callSettings);
        }

        /// <summary>
        /// List all scanned resources for a single Execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ScannedResource"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListScannedResourcesResponse, ScannedResource> ListScannedResourcesAsync(ListScannedResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScannedResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListScannedResourcesRequest, ListScannedResourcesResponse, ScannedResource>(_callListScannedResources, request, callSettings);
        }
    }

    public partial class ListEvaluationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExecutionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExecutionResultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListScannedResourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEvaluationsResponse : gaxgrpc::IPageResponse<Evaluation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Evaluation> GetEnumerator() => Evaluations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListExecutionsResponse : gaxgrpc::IPageResponse<Execution>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Execution> GetEnumerator() => Executions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListExecutionResultsResponse : gaxgrpc::IPageResponse<ExecutionResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ExecutionResult> GetEnumerator() => ExecutionResults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListScannedResourcesResponse : gaxgrpc::IPageResponse<ScannedResource>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ScannedResource> GetEnumerator() => ScannedResources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class WorkloadManager
    {
        public partial class WorkloadManagerClient
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

    public static partial class WorkloadManager
    {
        public partial class WorkloadManagerClient
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
